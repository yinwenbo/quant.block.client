using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trade.client.Marketdata
{
    public class JsonCache<T>
    {
        private Dictionary<string, T> Caches = new Dictionary<string, T>();

        public JsonCache(string filename, Func<T, string> CacheKeyMaker)
        {
            FileName = filename;
            BuildCacheKey = CacheKeyMaker;
            LoadFromFile();
        }

        ~JsonCache()
        {
            SaveToFile();
        }

        public Timer timer;
        public string FileName { get; private set; }
        public Action<List<T>> OnCacheUpdated { set; get; }
        public Func<T, string> BuildCacheKey { get; private set; }

        public void Update(List<T> list)
        {
            lock (Caches)
            {
                list.ForEach((data) => { Caches[BuildCacheKey(data)] = data; });
            }
            OnCacheUpdated?.Invoke(list);
            timer = new Timer(OnTimerCallback, null, 1 * 1000, 30 * 1000);
        }

        private void OnTimerCallback(object state)
        {
            //Thread thread = new Thread(SaveToFile);
            //thread.Start();
        }

        public T Get(string key)
        {
            Caches.TryGetValue(key, out T result);
            return result;
        }

        public void SaveToFile()
        {
            Dictionary<string, T> data;
            lock (Caches)
            {
                data = new Dictionary<string, T>(Caches);
            }
            lock(this)
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(FileName, json);
            }
        }
        public void LoadFromFile()
        {
            if (!File.Exists(FileName)) return;
            try
            {
                string text = File.ReadAllText(FileName);
                Caches = JsonConvert.DeserializeObject<Dictionary<string, T>>(text);
            }
            catch (Exception e)
            {
                Caches = new Dictionary<string, T>();
            }

        }
    }
}
