using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;
using AxYuantaQuoteLib;
using System.Linq;

using yuan_app.Model;

namespace yuan_app
{
    public partial class FrmMain : Form
    {

        public DataTable dtable = null;
        public BindingSource bs = new BindingSource();
        public int _times = 0;

        DataBase db = new DataBase();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dtable = new DataTable("QuoteTable");
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
            dtable.Columns.Add(Col0);
            dtable.Columns.Add(Col2);
            dtable.Columns.Add(Col3);
            dtable.Columns.Add(Col4);
            dtable.Columns.Add(Col5);
            dtable.Columns.Add(Col6);
            dtable.Columns.Add(Col7);
            dtable.Columns.Add(Col8);
            dtable.Columns.Add(Col9);
            dtable.Columns.Add(Col10);
            dtable.Columns.Add(Col11);
            dtable.Columns.Add(Col12);
            dtable.Columns.Add(Col13);
            dtable.PrimaryKey = new DataColumn[] { dtable.Columns["商品代碼"] };

            bs.DataSource = dtable;
            Dg.DataSource = bs;

            // 自動登入
            timerLogin.Interval = 300000;
            Login();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            ListenData();
        }

        private void btnItemRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // 取消接收該商品的行情 
                int RegErrCode = axYQ.DelMktReg(txtSymbol.Text.Trim());
                txtItemStatus.Text = RegErrCode.ToString();
                Console.WriteLine("RegErrCode:" + RegErrCode);
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
            Console.WriteLine("axYQ_OnMktStatusChange:" + rs);

            txtConnStatus.Text = rs;
            if (e.msg.ToString().IndexOf("行情連線結束") >= 0 || e.msg.ToString().IndexOf("行情連線失敗") >= 0)
            {
                //隔幾秒再連線
                timerLogin.Enabled = true;
                btnItemAdd.Enabled = false;
                btnItemRemove.Enabled = false;
                combUpdateMode.Enabled = false;
            }
            else
            {
                // 行情連線登入成功!
                btnItemAdd.Enabled = true;
                btnItemRemove.Enabled = true;
                combUpdateMode.Enabled = true;


                // 傾聽指定項目
                ListenData();
            }

        }

        private void axYQ_OnGetMktAll(object sender, _DYuantaQuoteEvents_OnGetMktAllEvent e)
        {
            // 獲取所有行情資料
            DataRow DR = this.dtable.Rows.Find(e.symbol);
            string matchtime = e.matchTime != "" ? (string.Format("{0}:{1}:{2}.{3}", e.matchTime.Substring(0, 2), e.matchTime.Substring(2, 2), e.matchTime.Substring(4, 2), e.matchTime.Substring(6, 3))) : "";

            //Console.WriteLine(e.matchTime);
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
                DR = this.dtable.NewRow();
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
                this.dtable.Rows.Add(DR);
            }

            // 更新資料
            if (!CheckData(e))
            {
                UpdateData(e);
                _times++;
                lbRuntimes.Text = "Runtimes： " + _times;
            }

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
                Console.WriteLine("error:" + ex);
            }
        }

        private void axYQ_OnRegError(object sender, _DYuantaQuoteEvents_OnRegErrorEvent e)
        {
            // 註冊失敗代碼 
            txtConnStatus.Text = e.errCode.ToString();
            Console.WriteLine("axYQ_OnRegError(註冊失敗代碼):" + e.errCode.ToString());
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

        private void axYQ_OnGetTimePack(object sender, _DYuantaQuoteEvents_OnGetTimePackEvent e)
        {
            Console.WriteLine("axYQ_OnGetTimePack:" + e.strTime);
        }

        public void Login()
        {
            try
            {
                axYQ.SetMktLogon(txtUserId.Text, txtPasswd.Text, txtIP.Text, txtPort.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login Faild：" + ex);
            }
            timerLogin.Start();
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            timerLogin.Stop();
            Login();
        }


        public bool CheckData(_DYuantaQuoteEvents_OnGetMktAllEvent e)
        {
            // 檢查取得的資料是否與資料庫最後新增的那筆不同

            string sql = "select top 1 matchTime from Data order by id desc";
            SqlConnection conn = new SqlConnection(db.ini);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = conn;

            DataList n_data = new DataList();
            DataList e_data = new DataList();

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    n_data.matchTime = dr[0].ToString();
                }

                //  e matchTime
                e_data.matchTime = e.matchTime;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            // Compare 如果目前資料庫最後一筆matchTime 與 API取得的相同,就不寫入資料庫了
            Console.WriteLine("{0} = DataBase", n_data.matchTime);
            Console.WriteLine("{0} = API", e_data.matchTime);
            Console.WriteLine("{0} = Compare Result", n_data.matchTime == e_data.matchTime);
            return n_data.matchTime == e_data.matchTime;
        }

        public void ListenData()
        {
            try
            {
                //  註冊商品代碼
                int RegCode = axYQ.AddMktReg(txtSymbol.Text.Trim(), combUpdateMode.Text.Substring(0, 1));
                txtItemStatus.Text = DateTime.Now.ToString("HH:mm:ss.fff ") + RegCode.ToString();
                Console.WriteLine("RegCode:" + RegCode + "   ,  |  0=Success , 3=Faild");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void UpdateData(_DYuantaQuoteEvents_OnGetMktAllEvent e)
        {
            if (e != null)
            {
                string sql = "INSERT into Data (symbol, refPri, openPri, highPri, lowPri, upPri, dnPri, matchTime, matchPri, matchQty, tolMatchQty, bestBuyPri, bestBuyQty, bestSellPri, bestSellQty, currentTime) " +
                    "VALUES (@symbol, @refPri, @openPri, @highPri, @lowPri, @upPri, @dnPri, @matchTime, @matchPri, @matchQty, @tolMatchQty, @bestBuyPri, @bestBuyQty, @bestSellPri, @bestSellQty, @currentTime)";
                SqlConnection conn = new SqlConnection(db.ini);
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;

                cmd.Parameters.Add("@symbol", SqlDbType.NVarChar).Value = e.symbol;
                cmd.Parameters.Add("@refPri", SqlDbType.NVarChar).Value = e.refPri;
                cmd.Parameters.Add("@openPri", SqlDbType.NVarChar).Value = e.openPri;

                cmd.Parameters.Add("@highPri", SqlDbType.NVarChar).Value = e.highPri;
                cmd.Parameters.Add("@lowPri", SqlDbType.NVarChar).Value = e.lowPri;
                cmd.Parameters.Add("@upPri", SqlDbType.NVarChar).Value = e.upPri;
                cmd.Parameters.Add("@dnPri", SqlDbType.NVarChar).Value = e.dnPri;

                cmd.Parameters.Add("@matchTime", SqlDbType.NVarChar).Value = e.matchTime;
                cmd.Parameters.Add("@matchPri", SqlDbType.NVarChar).Value = e.matchPri;
                cmd.Parameters.Add("@matchQty", SqlDbType.NVarChar).Value = e.matchQty;
                cmd.Parameters.Add("@tolMatchQty", SqlDbType.NVarChar).Value = e.tolMatchQty;

                cmd.Parameters.Add("@bestBuyPri", SqlDbType.NVarChar).Value = e.bestBuyPri;
                cmd.Parameters.Add("@bestBuyQty", SqlDbType.NVarChar).Value = e.bestBuyQty;

                cmd.Parameters.Add("@bestSellPri", SqlDbType.NVarChar).Value = e.bestSellPri;
                cmd.Parameters.Add("@bestSellQty", SqlDbType.NVarChar).Value = e.bestSellQty;

                cmd.Parameters.Add("@currentTime", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    conn.Close();
                    Console.WriteLine("Updating Finish");
                }
            }
        }

    }
}
