using Dwjk.Dtp;
using NetMQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmReportSubscribe : Form
    {
        public FrmReportSubscribe()
        {
            InitializeComponent();
            InitSubscirbe();
        }

        private void InitSubscirbe()
        {
            TradeFacade.Clients().ForEach((client) => {
                client.PlaceReportReceived += On_PlaceReportReceived;
                client.FillReportReceived += On_FillReportReceived;
                client.CancelReportReceived += On_CancelReportReceived;
            });
        }

        private void ReleaseSubscribe()
        {
            TradeFacade.Clients().ForEach((client) => {
                client.PlaceReportReceived -= On_PlaceReportReceived;
                client.FillReportReceived -= On_FillReportReceived;
                client.CancelReportReceived -= On_CancelReportReceived;
            });
        }

        private void On_PlaceReportReceived(string accountNo, ReportHeader header, PlacedReport report)
        {
            string log = string.Format("{0} 账号:{1} {2} 券:{3} 数量:{4,6} 价格:{5,8}. 单号:{6,10}, 原号:{7,10}. {8}",
                    report.Status, report.AccountNo, report.OrderSide, report.Code, report.Quantity, report.Price, 
                    report.OrderExchangeId, report.OrderOriginalId, header.Message
                    );
            BeginInvoke(new MethodInvoker(() => { WriteReport(log); }));
            WriteTiming(report.OrderOriginalId);
        }
        private void On_FillReportReceived(string accountNo, ReportHeader header, FillReport report)
        {
            string log = string.Format("{0} 账号:{1} {2} 券:{3} 数量:{4,6} 价格:{5,8}. 单号:{6,10}, 原号:{7,10}. 成交:{8, 6} 价格:{9, 8}. {10} ",
                   report.FillStatus, report.AccountNo, report.OrderSide, report.Code, report.Quantity, report.Price,
                   report.OrderExchangeId, report.OrderOriginalId, 
                   report.FillQuantity, report.FillPrice, header.Message
                   );
            BeginInvoke(new MethodInvoker(() => { WriteReport(log); }));
        }
        private void On_CancelReportReceived(string accountNo, ReportHeader header, CancellationReport report)
        {
            string log = string.Format("{0} 账号:{1} {2} 券:{3} 数量:{4,6} 撤消:{6,6}. 单号:{7,10}, 原号:{8,10}. 成交:{5, 6}. {9} ",
                   report.Status, report.AccountNo, report.OrderSide, report.Code, report.Quantity, 
                   report.TotalFillQuantity, report.CancelledQuantity,
                   report.OrderExchangeId, report.OrderOriginalId, header.Message);
            BeginInvoke(new MethodInvoker(() => { WriteReport(log); }));
        }
        private void WriteTiming(string originalId)
        {
            int orgTiming;
            if (!int.TryParse(originalId, out orgTiming)) return;

            int timing = int.Parse(DateTime.Now.ToString("HHmmssfff")) - int.Parse(originalId);
            string timelog = string.Format("耗时: {0}", timing);
            BeginInvoke(new MethodInvoker(() => { WriteReport(timelog); }));
        }
        private void WriteReport(string text)
        {
            rtxtReport.AppendText(text);
            rtxtReport.AppendText("\r\n");
            rtxtReport.SelectionStart = rtxtReport.Text.Length;
            rtxtReport.ScrollToCaret();
        }

        private void FrmReportSubscribe_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseSubscribe();
        }
    }
}
