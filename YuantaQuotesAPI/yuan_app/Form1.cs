using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AxYuantaQuoteLib;

namespace yuan_app
{
    public partial class FrmMain : Form
    {

        public DataTable dt = null;
        public BindingSource bs = new BindingSource();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dt = new DataTable("QuoteTable");
            DataColumn Col0 = new DataColumn("商品代碼", System.Type.GetType("System.String"));
            DataColumn Col2 = new DataColumn("參考價", System.Type.GetType("System.String"));
            DataColumn Col3 = new DataColumn("開盤價", System.Type.GetType("System.String"));
            DataColumn Col4 = new DataColumn("最高價", System.Type.GetType("System.String"));
            DataColumn Col5 = new DataColumn("最低價", System.Type.GetType("System.String"));
            DataColumn Col6 = new DataColumn("漲停價", System.Type.GetType("System.String"));
            DataColumn Col7 = new DataColumn("跌停價", System.Type.GetType("System.String"));
            DataColumn Col8 = new DataColumn("成交時間", System.Type.GetType("System.String"));
            DataColumn Col9 = new DataColumn("成交價位", System.Type.GetType("System.String"));
            DataColumn Col10 = new DataColumn("成交數量", System.Type.GetType("System.String"));
            DataColumn Col11 = new DataColumn("總成交量", System.Type.GetType("System.String"));
            DataColumn Col12 = new DataColumn("買五", System.Type.GetType("System.String"));
            DataColumn Col13 = new DataColumn("賣五", System.Type.GetType("System.String"));
            dt.Columns.Add(Col0);
            dt.Columns.Add(Col2);
            dt.Columns.Add(Col3);
            dt.Columns.Add(Col4);
            dt.Columns.Add(Col5);
            dt.Columns.Add(Col6);
            dt.Columns.Add(Col7);
            dt.Columns.Add(Col8);
            dt.Columns.Add(Col9);
            dt.Columns.Add(Col10);
            dt.Columns.Add(Col11);
            dt.Columns.Add(Col12);
            dt.Columns.Add(Col13);
            dt.PrimaryKey = new DataColumn[] { dt.Columns["商品代碼"] };

            bs.DataSource = dt;
            Dg.DataSource = bs;

            // 自動登入
            axYQ.SetMktLogon(txtUserId.Text, txtPasswd.Text, txtIP.Text, txtPort.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 登入
            axYQ.SetMktLogon(txtUserId.Text, txtPasswd.Text, txtIP.Text, txtPort.Text);
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //  註冊商品代碼
                int RegErrCode = axYQ.AddMktReg(txtSymbol.Text.Trim(), combUpdateMode.Text.Substring(0, 1));
                txtItemStatus.Text = DateTime.Now.ToString("HH:mm:ss.fff ") + RegErrCode.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnItemRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // 取消接收該商品的行情 
                int RegErrCode = axYQ.DelMktReg(txtSymbol.Text.Trim());
                txtItemStatus.Text = RegErrCode.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void axYQ_OnMktStatusChange(object sender, _DYuantaQuoteEvents_OnMktStatusChangeEvent e)
        {
            // 連線狀況
            string rs = e.msg.ToString();
            Console.WriteLine(rs);

            txtConnStatus.Text = rs;
            if (rs == "0行情連線登入成功!")
            {
                btnItemAdd.Enabled = true;
                btnItemRemove.Enabled = true;
                combUpdateMode.Enabled = true;
            }
        }


        private void axYQ_OnGetMktAll(object sender, _DYuantaQuoteEvents_OnGetMktAllEvent e)
        {
            // 獲取所有行情資料
            //Console.WriteLine(e.fDBPri);
            DataRow DR = this.dt.Rows.Find(e.symbol);
            string matchtime = e.matchTime != "" ? (string.Format("{0}:{1}:{2}.{3}", e.matchTime.Substring(0, 2), e.matchTime.Substring(2, 2), e.matchTime.Substring(4, 2), e.matchTime.Substring(6, 3))) : "";

            Console.WriteLine(matchtime);
            if (DR != null)
            {
                DR["參考價"] = e.refPri;
                DR["開盤價"] = e.openPri;
                DR["最高價"] = e.highPri;
                DR["最低價"] = e.lowPri;
                DR["漲停價"] = e.upPri;
                DR["跌停價"] = e.dnPri;
                DR["成交時間"] = e.matchTime != "" ? matchtime : "";
                DR["成交價位"] = e.matchPri;
                DR["成交數量"] = e.matchQty;
                DR["總成交量"] = e.tolMatchQty;
                DR["買五"] = e.bestBuyPri + e.bestBuyQty;
                DR["賣五"] = e.bestSellPri + e.bestSellQty;

                DR.EndEdit();
                DR.AcceptChanges();
            }
            else
            {
                DR = this.dt.NewRow();
                DR["商品代碼"] = e.symbol;
                DR["參考價"] = e.refPri;
                DR["開盤價"] = e.openPri;
                DR["最高價"] = e.highPri;
                DR["最低價"] = e.lowPri;
                DR["漲停價"] = e.upPri;
                DR["跌停價"] = e.dnPri;
                DR["成交時間"] = e.matchTime != "" ? matchtime : ""; DR["成交價位"] = e.matchPri;
                DR["成交數量"] = e.matchQty;
                DR["總成交量"] = e.tolMatchQty;
                DR["買五"] = e.bestBuyPri + e.bestBuyQty;
                DR["賣五"] = e.bestSellPri + e.bestSellQty;
                this.dt.Rows.Add(DR);
            }

            //Dg.Rows.Add(e.symbol, e.refPri, e.openPri, e.highPri, e.lowPri, e.upPri, e.dnPri, matchtime, e.matchPri, e.matchQty, e.tolMatchQty);

             

            ListShow(String.Format("{0} 買五：{1}-{2}", e.symbol, e.bestBuyPri, e.bestBuyQty));
            ListShow(String.Format("{0} 賣五：{1}-{2}", e.symbol, e.bestSellPri, e.bestSellQty));
        }

        private void Dg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                // 繪製 cell 的時候幫欄位上點底色, 比較好判斷

                if (e.Value.ToString() != "")
                {
                    if (this.Dg.Columns["UpPri"].Index == e.ColumnIndex && e.RowIndex >= 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                    if (this.Dg.Columns["DnPri"].Index == e.ColumnIndex && e.RowIndex >= 0)
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }

                    if ((this.Dg.Columns["OpenPri"].Index == e.ColumnIndex && e.RowIndex >= 0) || (this.Dg.Columns["HighPri"].Index == e.ColumnIndex && e.RowIndex >= 0) || (this.Dg.Columns["LowPri"].Index == e.ColumnIndex && e.RowIndex >= 0) || (this.Dg.Columns["MatchPri"].Index == e.ColumnIndex && e.RowIndex >= 0))
                    {
                        if (string.Compare(Dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), Dg.Rows[e.RowIndex].Cells[5].Value.ToString()) == 0)
                            e.CellStyle.BackColor = Color.Red;
                        else if (string.Compare(Dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), Dg.Rows[e.RowIndex].Cells[6].Value.ToString()) == 0)
                            e.CellStyle.BackColor = Color.Green;
                        else if (string.Compare(Dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), Dg.Rows[e.RowIndex].Cells[1].Value.ToString()) > 0)
                            e.CellStyle.ForeColor = Color.Red;
                        else if (string.Compare(Dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), Dg.Rows[e.RowIndex].Cells[1].Value.ToString()) < 0)
                            e.CellStyle.ForeColor = Color.Lime;
                        else
                            e.CellStyle.ForeColor = Color.White;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void axYQ_OnRegError(object sender, _DYuantaQuoteEvents_OnRegErrorEvent e)
        {
            // 註冊失敗代碼 
            txtConnStatus.Text = e.errCode.ToString();
        }

        private void axYQ_OnGetMktData(object sender, _DYuantaQuoteEvents_OnGetMktDataEvent e)
        {
            // 未知 可能是標的代號基本資料
            //Console.WriteLine("sym:" + e.symbol);
            //Console.WriteLine("pri:" + e.pri);
            //Console.WriteLine("priType:" + e.priType);
            //Console.WriteLine("qty:" + e.qty);
        }

        private delegate void InvokeFunction(string msg);

        public void ListShow(string str_log)
        {
            string StrLog = string.Format("{0}  [{1}] ", DateTime.Now.ToString("HH:mm:ss.fff "), str_log);
            listbox.BeginInvoke(new InvokeFunction(ShowMsg), new object[] { StrLog });
        }

        public void ShowMsg(string logstr)
        {
            this.Invoke((System.Windows.Forms.MethodInvoker)delegate
            {
                if (listbox.Items.Count > 1000)
                {
                    listbox.Items.Clear();
                    listbox.Items.Insert(0, string.Format("{0}  [{1}]", DateTime.Now.ToString("HH:mm:ss.fff "), "清除舊資料"));
                }
                listbox.Items.Insert(0, logstr);
            });
        }

        private void axYQ_OnGetTickData(object sender, _DYuantaQuoteEvents_OnGetTickDataEvent e)
        {
            // 未知
            Console.WriteLine("axYQ_OnGetTickData:" + e.strBuyPri);
        }

        private void axYQ_OnGetMktQuote(object sender, _DYuantaQuoteEvents_OnGetMktQuoteEvent e)
        {
            // 未知
            Console.WriteLine("axYQ_OnGetMktQuote:" + e.disClosure);
        }

        private void axYQ_OnGetTickRangeData(object sender, _DYuantaQuoteEvents_OnGetTickRangeDataEvent e)
        {
            // 未知 可能是取得某個時段資料
            Console.WriteLine("axYQ_OnGetTickRangeData:" + e.strStartTime);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
           int tr = axYQ.GetTickRangeData(txtSymbol.Text.Trim(), "201705151000", "201705151200");
        }
    }
}
