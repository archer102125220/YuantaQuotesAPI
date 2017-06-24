namespace yuan_app
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lbPasswd = new System.Windows.Forms.Label();
            this.txtConnStatus = new System.Windows.Forms.TextBox();
            this.lbConnStatus = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lbUserId = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.axYQ = new AxYuantaQuoteLib.AxYuantaQuote();
            this.combUpdateMode = new System.Windows.Forms.ComboBox();
            this.txtItemStatus = new System.Windows.Forms.TextBox();
            this.lbItemStatus = new System.Windows.Forms.Label();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lbUpdateMode = new System.Windows.Forms.Label();
            this.lbSymbol = new System.Windows.Forms.Label();
            this.Dg = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DnPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TolMatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listbox = new System.Windows.Forms.ListBox();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.da = new yuan_app.YuantaDataSetTableAdapters.DataTableAdapter();
            this.lbRuntimes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axYQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(83, 119);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(5);
            this.txtPasswd.MaxLength = 20;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(190, 22);
            this.txtPasswd.TabIndex = 4;
            this.txtPasswd.Text = "e2345678";
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // lbPasswd
            // 
            this.lbPasswd.AutoSize = true;
            this.lbPasswd.Location = new System.Drawing.Point(23, 122);
            this.lbPasswd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPasswd.Name = "lbPasswd";
            this.lbPasswd.Size = new System.Drawing.Size(53, 12);
            this.lbPasswd.TabIndex = 21;
            this.lbPasswd.Text = "登入密碼";
            // 
            // txtConnStatus
            // 
            this.txtConnStatus.Location = new System.Drawing.Point(83, 154);
            this.txtConnStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtConnStatus.Name = "txtConnStatus";
            this.txtConnStatus.Size = new System.Drawing.Size(190, 22);
            this.txtConnStatus.TabIndex = 19;
            // 
            // lbConnStatus
            // 
            this.lbConnStatus.AutoSize = true;
            this.lbConnStatus.Location = new System.Drawing.Point(23, 158);
            this.lbConnStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbConnStatus.Name = "lbConnStatus";
            this.lbConnStatus.Size = new System.Drawing.Size(29, 12);
            this.lbConnStatus.TabIndex = 18;
            this.lbConnStatus.Text = "狀態";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(186, 186);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserId.Location = new System.Drawing.Point(83, 83);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserId.MaxLength = 20;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(190, 22);
            this.txtUserId.TabIndex = 3;
            this.txtUserId.Text = "P123257564";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(23, 87);
            this.lbUserId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(41, 12);
            this.lbUserId.TabIndex = 16;
            this.lbUserId.Text = "登入ID";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(83, 13);
            this.txtIP.Margin = new System.Windows.Forms.Padding(5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(190, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "quote.yuantafutures.com.tw";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(83, 48);
            this.txtPort.Margin = new System.Windows.Forms.Padding(5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(41, 22);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "80";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(23, 52);
            this.lbPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 12);
            this.lbPort.TabIndex = 14;
            this.lbPort.Text = "PORT";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(23, 16);
            this.lbIP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(50, 12);
            this.lbIP.TabIndex = 11;
            this.lbIP.Text = "API 主機";
            // 
            // axYQ
            // 
            this.axYQ.Enabled = true;
            this.axYQ.Location = new System.Drawing.Point(1046, 10);
            this.axYQ.Name = "axYQ";
            this.axYQ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axYQ.OcxState")));
            this.axYQ.Size = new System.Drawing.Size(97, 89);
            this.axYQ.TabIndex = 24;
            this.axYQ.OnMktStatusChange += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnMktStatusChangeEventHandler(this.axYQ_OnMktStatusChange);
            this.axYQ.OnRegError += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnRegErrorEventHandler(this.axYQ_OnRegError);
            this.axYQ.OnGetMktAll += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnGetMktAllEventHandler(this.axYQ_OnGetMktAll);
            this.axYQ.OnGetTimePack += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnGetTimePackEventHandler(this.axYQ_OnGetTimePack);
            // 
            // combUpdateMode
            // 
            this.combUpdateMode.Enabled = false;
            this.combUpdateMode.FormattingEnabled = true;
            this.combUpdateMode.Items.AddRange(new object[] {
            "1-Snapshot",
            "2-Update",
            "4-SnapshotUpd"});
            this.combUpdateMode.Location = new System.Drawing.Point(466, 45);
            this.combUpdateMode.Margin = new System.Windows.Forms.Padding(5);
            this.combUpdateMode.MaxLength = 1;
            this.combUpdateMode.Name = "combUpdateMode";
            this.combUpdateMode.Size = new System.Drawing.Size(165, 20);
            this.combUpdateMode.TabIndex = 22;
            this.combUpdateMode.Text = "4-SnapshotUpd";
            // 
            // txtItemStatus
            // 
            this.txtItemStatus.Location = new System.Drawing.Point(463, 131);
            this.txtItemStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtItemStatus.Name = "txtItemStatus";
            this.txtItemStatus.Size = new System.Drawing.Size(294, 22);
            this.txtItemStatus.TabIndex = 21;
            // 
            // lbItemStatus
            // 
            this.lbItemStatus.AutoSize = true;
            this.lbItemStatus.Location = new System.Drawing.Point(363, 134);
            this.lbItemStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbItemStatus.Name = "lbItemStatus";
            this.lbItemStatus.Size = new System.Drawing.Size(85, 12);
            this.lbItemStatus.TabIndex = 20;
            this.lbItemStatus.Text = "狀態(取得時間)";
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.Enabled = false;
            this.btnItemRemove.Location = new System.Drawing.Point(641, 87);
            this.btnItemRemove.Margin = new System.Windows.Forms.Padding(5);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(87, 34);
            this.btnItemRemove.TabIndex = 18;
            this.btnItemRemove.Text = "取消商品";
            this.btnItemRemove.UseVisualStyleBackColor = true;
            this.btnItemRemove.Click += new System.EventHandler(this.btnItemRemove_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Enabled = false;
            this.btnItemAdd.Location = new System.Drawing.Point(641, 42);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(87, 35);
            this.btnItemAdd.TabIndex = 7;
            this.btnItemAdd.Text = "註冊商品";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Location = new System.Drawing.Point(463, 10);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(5);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(294, 22);
            this.txtSymbol.TabIndex = 6;
            this.txtSymbol.Text = "MXFF7";
            // 
            // lbUpdateMode
            // 
            this.lbUpdateMode.AutoSize = true;
            this.lbUpdateMode.Location = new System.Drawing.Point(363, 48);
            this.lbUpdateMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUpdateMode.Name = "lbUpdateMode";
            this.lbUpdateMode.Size = new System.Drawing.Size(65, 12);
            this.lbUpdateMode.TabIndex = 14;
            this.lbUpdateMode.Text = "UpdateMode";
            // 
            // lbSymbol
            // 
            this.lbSymbol.AutoSize = true;
            this.lbSymbol.Location = new System.Drawing.Point(363, 12);
            this.lbSymbol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSymbol.Name = "lbSymbol";
            this.lbSymbol.Size = new System.Drawing.Size(53, 12);
            this.lbSymbol.TabIndex = 11;
            this.lbSymbol.Text = "商品代碼";
            this.lbSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dg
            // 
            this.Dg.AllowUserToAddRows = false;
            this.Dg.AllowUserToDeleteRows = false;
            this.Dg.AllowUserToResizeColumns = false;
            this.Dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.Dg.BackgroundColor = System.Drawing.Color.Black;
            this.Dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.Dg.ColumnHeadersHeight = 30;
            this.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.RefPri,
            this.OpenPri,
            this.HighPri,
            this.LowPri,
            this.UpPri,
            this.DnPri,
            this.MatchTim,
            this.MatchPri,
            this.MatchQty,
            this.TolMatchQty});
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg.DefaultCellStyle = dataGridViewCellStyle43;
            this.Dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dg.EnableHeadersVisualStyles = false;
            this.Dg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dg.Location = new System.Drawing.Point(12, 241);
            this.Dg.Margin = new System.Windows.Forms.Padding(5);
            this.Dg.MultiSelect = false;
            this.Dg.Name = "Dg";
            this.Dg.ReadOnly = true;
            this.Dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.Dg.RowHeadersVisible = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.White;
            this.Dg.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.Dg.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dg.RowTemplate.Height = 24;
            this.Dg.ShowCellErrors = false;
            this.Dg.ShowCellToolTips = false;
            this.Dg.ShowEditingIcon = false;
            this.Dg.ShowRowErrors = false;
            this.Dg.Size = new System.Drawing.Size(1161, 245);
            this.Dg.TabIndex = 25;
            this.Dg.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dg_CellPainting);
            // 
            // key
            // 
            this.key.DataPropertyName = "商品代碼";
            this.key.Frozen = true;
            this.key.HeaderText = "商品代碼";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RefPri
            // 
            this.RefPri.DataPropertyName = "參考價";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RefPri.DefaultCellStyle = dataGridViewCellStyle33;
            this.RefPri.HeaderText = "參考價";
            this.RefPri.Name = "RefPri";
            this.RefPri.ReadOnly = true;
            this.RefPri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpenPri
            // 
            this.OpenPri.DataPropertyName = "開盤價";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.OpenPri.DefaultCellStyle = dataGridViewCellStyle34;
            this.OpenPri.HeaderText = "開盤價";
            this.OpenPri.Name = "OpenPri";
            this.OpenPri.ReadOnly = true;
            this.OpenPri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HighPri
            // 
            this.HighPri.DataPropertyName = "最高價";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.HighPri.DefaultCellStyle = dataGridViewCellStyle35;
            this.HighPri.HeaderText = "最高價";
            this.HighPri.Name = "HighPri";
            this.HighPri.ReadOnly = true;
            // 
            // LowPri
            // 
            this.LowPri.DataPropertyName = "最低價";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LowPri.DefaultCellStyle = dataGridViewCellStyle36;
            this.LowPri.HeaderText = "最低價";
            this.LowPri.Name = "LowPri";
            this.LowPri.ReadOnly = true;
            // 
            // UpPri
            // 
            this.UpPri.DataPropertyName = "漲停價";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UpPri.DefaultCellStyle = dataGridViewCellStyle37;
            this.UpPri.HeaderText = "漲停價";
            this.UpPri.Name = "UpPri";
            this.UpPri.ReadOnly = true;
            // 
            // DnPri
            // 
            this.DnPri.DataPropertyName = "跌停價";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DnPri.DefaultCellStyle = dataGridViewCellStyle38;
            this.DnPri.HeaderText = "跌停價";
            this.DnPri.Name = "DnPri";
            this.DnPri.ReadOnly = true;
            // 
            // MatchTim
            // 
            this.MatchTim.DataPropertyName = "成交時間";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MatchTim.DefaultCellStyle = dataGridViewCellStyle39;
            this.MatchTim.HeaderText = "成交時間";
            this.MatchTim.Name = "MatchTim";
            this.MatchTim.ReadOnly = true;
            this.MatchTim.Width = 130;
            // 
            // MatchPri
            // 
            this.MatchPri.DataPropertyName = "成交價位";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MatchPri.DefaultCellStyle = dataGridViewCellStyle40;
            this.MatchPri.HeaderText = "成交價位";
            this.MatchPri.Name = "MatchPri";
            this.MatchPri.ReadOnly = true;
            // 
            // MatchQty
            // 
            this.MatchQty.DataPropertyName = "成交數量";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MatchQty.DefaultCellStyle = dataGridViewCellStyle41;
            this.MatchQty.HeaderText = "成交數量";
            this.MatchQty.Name = "MatchQty";
            this.MatchQty.ReadOnly = true;
            // 
            // TolMatchQty
            // 
            this.TolMatchQty.DataPropertyName = "總成交量";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TolMatchQty.DefaultCellStyle = dataGridViewCellStyle42;
            this.TolMatchQty.HeaderText = "總成交量";
            this.TolMatchQty.Name = "TolMatchQty";
            this.TolMatchQty.ReadOnly = true;
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.Color.Black;
            this.listbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox.ForeColor = System.Drawing.Color.Yellow;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(12, 498);
            this.listbox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.listbox.Name = "listbox";
            this.listbox.ScrollAlwaysVisible = true;
            this.listbox.Size = new System.Drawing.Size(1129, 124);
            this.listbox.TabIndex = 26;
            // 
            // timerLogin
            // 
            this.timerLogin.Interval = 600000;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // da
            // 
            this.da.ClearBeforeFill = true;
            // 
            // lbRuntimes
            // 
            this.lbRuntimes.AutoSize = true;
            this.lbRuntimes.Location = new System.Drawing.Point(1058, 109);
            this.lbRuntimes.Name = "lbRuntimes";
            this.lbRuntimes.Size = new System.Drawing.Size(67, 12);
            this.lbRuntimes.TabIndex = 27;
            this.lbRuntimes.Text = "Runtimes：0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 635);
            this.Controls.Add(this.lbRuntimes);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Dg);
            this.Controls.Add(this.combUpdateMode);
            this.Controls.Add(this.axYQ);
            this.Controls.Add(this.txtItemStatus);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lbItemStatus);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.btnItemRemove);
            this.Controls.Add(this.lbPasswd);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txtConnStatus);
            this.Controls.Add(this.lbUpdateMode);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbSymbol);
            this.Controls.Add(this.lbConnStatus);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.txtUserId);
            this.Name = "FrmMain";
            this.Text = "Yuan_App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axYQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lbPasswd;
        private System.Windows.Forms.TextBox txtConnStatus;
        private System.Windows.Forms.Label lbConnStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIP;
        private AxYuantaQuoteLib.AxYuantaQuote axYQ;
        private System.Windows.Forms.ComboBox combUpdateMode;
        private System.Windows.Forms.TextBox txtItemStatus;
        private System.Windows.Forms.Label lbItemStatus;
        private System.Windows.Forms.Button btnItemRemove;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lbUpdateMode;
        private System.Windows.Forms.Label lbSymbol;
        private System.Windows.Forms.DataGridView Dg;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DnPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TolMatchQty;
        private System.Windows.Forms.Timer timerLogin;
        private YuantaDataSetTableAdapters.DataTableAdapter da;
        private System.Windows.Forms.Label lbRuntimes;
    }
}

