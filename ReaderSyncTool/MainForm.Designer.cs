namespace ReaderSyncTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtype_SQL = new System.Windows.Forms.RadioButton();
            this.rbtype_Orcale = new System.Windows.Forms.RadioButton();
            this.rbtype_Sybase = new System.Windows.Forms.RadioButton();
            this.rbtype_Excel = new System.Windows.Forms.RadioButton();
            this.rbtype_Xml = new System.Windows.Forms.RadioButton();
            this.rbtype_TXT = new System.Windows.Forms.RadioButton();
            this.rbtype_XZX = new System.Windows.Forms.RadioButton();
            this.gb_SQL = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SQL_PW = new System.Windows.Forms.TextBox();
            this.tb_SQL_DB = new System.Windows.Forms.TextBox();
            this.tb_SQL_User = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SQL_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TestConn = new System.Windows.Forms.Button();
            this.gb_Orcale = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Orcale_PW = new System.Windows.Forms.TextBox();
            this.tb_Orcale_User = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Oracle_SSID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_File = new System.Windows.Forms.GroupBox();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_Sybase = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Sybase_PW = new System.Windows.Forms.TextBox();
            this.tb_Sybase_DB = new System.Windows.Forms.TextBox();
            this.tb_Sybase_UID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_Sybase_IPPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gb_XZX = new System.Windows.Forms.GroupBox();
            this.cb_XZX_SyncAcc = new System.Windows.Forms.CheckBox();
            this.cb_XZX_NoStud = new System.Windows.Forms.CheckBox();
            this.cb_XZX_EveryInfo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_XZX_Trem = new System.Windows.Forms.TextBox();
            this.tb_XZX_SystemCode = new System.Windows.Forms.TextBox();
            this.tb_XZX_Port = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_XZX_IP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gb_SQLSelect = new System.Windows.Forms.GroupBox();
            this.rtb_SQLSelect = new System.Windows.Forms.RichTextBox();
            this.btn_DataTest = new System.Windows.Forms.Button();
            this.gb_RowKey = new System.Windows.Forms.GroupBox();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_Flag = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_Dept = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_Type = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_Sex = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_CardID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_CardNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_SyncPW = new System.Windows.Forms.CheckBox();
            this.cb_AutoActive = new System.Windows.Forms.CheckBox();
            this.cb_AutoLogout = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_Seat_PW = new System.Windows.Forms.TextBox();
            this.tb_Seat_Name = new System.Windows.Forms.TextBox();
            this.tb_Seat_UID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_Seat_IP = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_SeatLinkTest = new System.Windows.Forms.Button();
            this.gb_FTP = new System.Windows.Forms.GroupBox();
            this.btn_TsetFtp = new System.Windows.Forms.Button();
            this.cb_UseFTP = new System.Windows.Forms.CheckBox();
            this.tb_FTP_PW = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_FTP_UID = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_FTP_Path = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_AutoSync = new System.Windows.Forms.CheckBox();
            this.cb_MiniSetup = new System.Windows.Forms.CheckBox();
            this.tb_SyancTime = new System.Windows.Forms.TextBox();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lb_Progress = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lb_SyncTime = new System.Windows.Forms.Label();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.rb_TimeSync = new System.Windows.Forms.RadioButton();
            this.rb_SpanSync = new System.Windows.Forms.RadioButton();
            this.tb_SpanTime = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.gb_SQL.SuspendLayout();
            this.gb_Orcale.SuspendLayout();
            this.gb_File.SuspendLayout();
            this.gb_Sybase.SuspendLayout();
            this.gb_XZX.SuspendLayout();
            this.gb_SQLSelect.SuspendLayout();
            this.gb_RowKey.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_FTP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据源类型";
            // 
            // rbtype_SQL
            // 
            this.rbtype_SQL.AutoSize = true;
            this.rbtype_SQL.Location = new System.Drawing.Point(97, 17);
            this.rbtype_SQL.Name = "rbtype_SQL";
            this.rbtype_SQL.Size = new System.Drawing.Size(83, 16);
            this.rbtype_SQL.TabIndex = 1;
            this.rbtype_SQL.TabStop = true;
            this.rbtype_SQL.Text = "SQL Server";
            this.rbtype_SQL.UseVisualStyleBackColor = true;
            this.rbtype_SQL.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_Orcale
            // 
            this.rbtype_Orcale.AutoSize = true;
            this.rbtype_Orcale.Location = new System.Drawing.Point(186, 17);
            this.rbtype_Orcale.Name = "rbtype_Orcale";
            this.rbtype_Orcale.Size = new System.Drawing.Size(59, 16);
            this.rbtype_Orcale.TabIndex = 2;
            this.rbtype_Orcale.TabStop = true;
            this.rbtype_Orcale.Text = "Orcale";
            this.rbtype_Orcale.UseVisualStyleBackColor = true;
            this.rbtype_Orcale.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_Sybase
            // 
            this.rbtype_Sybase.AutoSize = true;
            this.rbtype_Sybase.Location = new System.Drawing.Point(251, 17);
            this.rbtype_Sybase.Name = "rbtype_Sybase";
            this.rbtype_Sybase.Size = new System.Drawing.Size(59, 16);
            this.rbtype_Sybase.TabIndex = 3;
            this.rbtype_Sybase.TabStop = true;
            this.rbtype_Sybase.Text = "Sybase";
            this.rbtype_Sybase.UseVisualStyleBackColor = true;
            this.rbtype_Sybase.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_Excel
            // 
            this.rbtype_Excel.AutoSize = true;
            this.rbtype_Excel.Location = new System.Drawing.Point(316, 17);
            this.rbtype_Excel.Name = "rbtype_Excel";
            this.rbtype_Excel.Size = new System.Drawing.Size(53, 16);
            this.rbtype_Excel.TabIndex = 4;
            this.rbtype_Excel.TabStop = true;
            this.rbtype_Excel.Text = "Excel";
            this.rbtype_Excel.UseVisualStyleBackColor = true;
            this.rbtype_Excel.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_Xml
            // 
            this.rbtype_Xml.AutoSize = true;
            this.rbtype_Xml.Location = new System.Drawing.Point(375, 17);
            this.rbtype_Xml.Name = "rbtype_Xml";
            this.rbtype_Xml.Size = new System.Drawing.Size(41, 16);
            this.rbtype_Xml.TabIndex = 5;
            this.rbtype_Xml.TabStop = true;
            this.rbtype_Xml.Text = "Xml";
            this.rbtype_Xml.UseVisualStyleBackColor = true;
            this.rbtype_Xml.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_TXT
            // 
            this.rbtype_TXT.AutoSize = true;
            this.rbtype_TXT.Location = new System.Drawing.Point(422, 17);
            this.rbtype_TXT.Name = "rbtype_TXT";
            this.rbtype_TXT.Size = new System.Drawing.Size(41, 16);
            this.rbtype_TXT.TabIndex = 6;
            this.rbtype_TXT.TabStop = true;
            this.rbtype_TXT.Text = "TXT";
            this.rbtype_TXT.UseVisualStyleBackColor = true;
            this.rbtype_TXT.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // rbtype_XZX
            // 
            this.rbtype_XZX.AutoSize = true;
            this.rbtype_XZX.Location = new System.Drawing.Point(469, 17);
            this.rbtype_XZX.Name = "rbtype_XZX";
            this.rbtype_XZX.Size = new System.Drawing.Size(59, 16);
            this.rbtype_XZX.TabIndex = 7;
            this.rbtype_XZX.TabStop = true;
            this.rbtype_XZX.Text = "新中新";
            this.rbtype_XZX.UseVisualStyleBackColor = true;
            this.rbtype_XZX.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged);
            // 
            // gb_SQL
            // 
            this.gb_SQL.Controls.Add(this.label6);
            this.gb_SQL.Controls.Add(this.label4);
            this.gb_SQL.Controls.Add(this.tb_SQL_PW);
            this.gb_SQL.Controls.Add(this.tb_SQL_DB);
            this.gb_SQL.Controls.Add(this.tb_SQL_User);
            this.gb_SQL.Controls.Add(this.label5);
            this.gb_SQL.Controls.Add(this.tb_SQL_IP);
            this.gb_SQL.Controls.Add(this.label2);
            this.gb_SQL.Location = new System.Drawing.Point(28, 39);
            this.gb_SQL.Name = "gb_SQL";
            this.gb_SQL.Size = new System.Drawing.Size(420, 80);
            this.gb_SQL.TabIndex = 8;
            this.gb_SQL.TabStop = false;
            this.gb_SQL.Text = "SQL Server 设置";
            this.gb_SQL.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "数据库";
            // 
            // tb_SQL_PW
            // 
            this.tb_SQL_PW.Location = new System.Drawing.Point(276, 44);
            this.tb_SQL_PW.Name = "tb_SQL_PW";
            this.tb_SQL_PW.Size = new System.Drawing.Size(92, 21);
            this.tb_SQL_PW.TabIndex = 1;
            // 
            // tb_SQL_DB
            // 
            this.tb_SQL_DB.Location = new System.Drawing.Point(53, 44);
            this.tb_SQL_DB.Name = "tb_SQL_DB";
            this.tb_SQL_DB.Size = new System.Drawing.Size(182, 21);
            this.tb_SQL_DB.TabIndex = 1;
            // 
            // tb_SQL_User
            // 
            this.tb_SQL_User.Location = new System.Drawing.Point(276, 17);
            this.tb_SQL_User.Name = "tb_SQL_User";
            this.tb_SQL_User.Size = new System.Drawing.Size(92, 21);
            this.tb_SQL_User.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "账户";
            // 
            // tb_SQL_IP
            // 
            this.tb_SQL_IP.Location = new System.Drawing.Point(53, 17);
            this.tb_SQL_IP.Name = "tb_SQL_IP";
            this.tb_SQL_IP.Size = new System.Drawing.Size(182, 21);
            this.tb_SQL_IP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器";
            // 
            // btn_TestConn
            // 
            this.btn_TestConn.Location = new System.Drawing.Point(351, 125);
            this.btn_TestConn.Name = "btn_TestConn";
            this.btn_TestConn.Size = new System.Drawing.Size(97, 23);
            this.btn_TestConn.TabIndex = 3;
            this.btn_TestConn.Text = "连接测试";
            this.btn_TestConn.UseVisualStyleBackColor = true;
            this.btn_TestConn.Click += new System.EventHandler(this.btn_TestConn_Click);
            // 
            // gb_Orcale
            // 
            this.gb_Orcale.Controls.Add(this.label3);
            this.gb_Orcale.Controls.Add(this.tb_Orcale_PW);
            this.gb_Orcale.Controls.Add(this.tb_Orcale_User);
            this.gb_Orcale.Controls.Add(this.label8);
            this.gb_Orcale.Controls.Add(this.tb_Oracle_SSID);
            this.gb_Orcale.Controls.Add(this.label9);
            this.gb_Orcale.Location = new System.Drawing.Point(28, 39);
            this.gb_Orcale.Name = "gb_Orcale";
            this.gb_Orcale.Size = new System.Drawing.Size(420, 80);
            this.gb_Orcale.TabIndex = 9;
            this.gb_Orcale.TabStop = false;
            this.gb_Orcale.Text = "Orcale 设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // tb_Orcale_PW
            // 
            this.tb_Orcale_PW.Location = new System.Drawing.Point(311, 26);
            this.tb_Orcale_PW.Name = "tb_Orcale_PW";
            this.tb_Orcale_PW.Size = new System.Drawing.Size(92, 21);
            this.tb_Orcale_PW.TabIndex = 1;
            // 
            // tb_Orcale_User
            // 
            this.tb_Orcale_User.Location = new System.Drawing.Point(178, 26);
            this.tb_Orcale_User.Name = "tb_Orcale_User";
            this.tb_Orcale_User.Size = new System.Drawing.Size(92, 21);
            this.tb_Orcale_User.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "账户";
            // 
            // tb_Oracle_SSID
            // 
            this.tb_Oracle_SSID.Location = new System.Drawing.Point(45, 26);
            this.tb_Oracle_SSID.Name = "tb_Oracle_SSID";
            this.tb_Oracle_SSID.Size = new System.Drawing.Size(92, 21);
            this.tb_Oracle_SSID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "SSID";
            // 
            // gb_File
            // 
            this.gb_File.Controls.Add(this.tb_FilePath);
            this.gb_File.Controls.Add(this.label11);
            this.gb_File.Location = new System.Drawing.Point(28, 39);
            this.gb_File.Name = "gb_File";
            this.gb_File.Size = new System.Drawing.Size(420, 80);
            this.gb_File.TabIndex = 10;
            this.gb_File.TabStop = false;
            this.gb_File.Text = "文件路径设置";
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(8, 41);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(407, 21);
            this.tb_FilePath.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "文件路径";
            // 
            // gb_Sybase
            // 
            this.gb_Sybase.Controls.Add(this.label12);
            this.gb_Sybase.Controls.Add(this.label13);
            this.gb_Sybase.Controls.Add(this.tb_Sybase_PW);
            this.gb_Sybase.Controls.Add(this.tb_Sybase_DB);
            this.gb_Sybase.Controls.Add(this.tb_Sybase_UID);
            this.gb_Sybase.Controls.Add(this.label14);
            this.gb_Sybase.Controls.Add(this.tb_Sybase_IPPort);
            this.gb_Sybase.Controls.Add(this.label15);
            this.gb_Sybase.Location = new System.Drawing.Point(28, 39);
            this.gb_Sybase.Name = "gb_Sybase";
            this.gb_Sybase.Size = new System.Drawing.Size(420, 80);
            this.gb_Sybase.TabIndex = 9;
            this.gb_Sybase.TabStop = false;
            this.gb_Sybase.Text = "Sybase 设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "密码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "数据库";
            // 
            // tb_Sybase_PW
            // 
            this.tb_Sybase_PW.Location = new System.Drawing.Point(276, 44);
            this.tb_Sybase_PW.Name = "tb_Sybase_PW";
            this.tb_Sybase_PW.Size = new System.Drawing.Size(92, 21);
            this.tb_Sybase_PW.TabIndex = 1;
            // 
            // tb_Sybase_DB
            // 
            this.tb_Sybase_DB.Location = new System.Drawing.Point(53, 44);
            this.tb_Sybase_DB.Name = "tb_Sybase_DB";
            this.tb_Sybase_DB.Size = new System.Drawing.Size(182, 21);
            this.tb_Sybase_DB.TabIndex = 1;
            // 
            // tb_Sybase_UID
            // 
            this.tb_Sybase_UID.Location = new System.Drawing.Point(276, 17);
            this.tb_Sybase_UID.Name = "tb_Sybase_UID";
            this.tb_Sybase_UID.Size = new System.Drawing.Size(92, 21);
            this.tb_Sybase_UID.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "账户";
            // 
            // tb_Sybase_IPPort
            // 
            this.tb_Sybase_IPPort.Location = new System.Drawing.Point(53, 17);
            this.tb_Sybase_IPPort.Name = "tb_Sybase_IPPort";
            this.tb_Sybase_IPPort.Size = new System.Drawing.Size(182, 21);
            this.tb_Sybase_IPPort.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "服务器";
            // 
            // gb_XZX
            // 
            this.gb_XZX.Controls.Add(this.cb_XZX_SyncAcc);
            this.gb_XZX.Controls.Add(this.cb_XZX_NoStud);
            this.gb_XZX.Controls.Add(this.cb_XZX_EveryInfo);
            this.gb_XZX.Controls.Add(this.label7);
            this.gb_XZX.Controls.Add(this.label18);
            this.gb_XZX.Controls.Add(this.tb_XZX_Trem);
            this.gb_XZX.Controls.Add(this.tb_XZX_SystemCode);
            this.gb_XZX.Controls.Add(this.tb_XZX_Port);
            this.gb_XZX.Controls.Add(this.label19);
            this.gb_XZX.Controls.Add(this.tb_XZX_IP);
            this.gb_XZX.Controls.Add(this.label20);
            this.gb_XZX.Location = new System.Drawing.Point(28, 39);
            this.gb_XZX.Name = "gb_XZX";
            this.gb_XZX.Size = new System.Drawing.Size(420, 80);
            this.gb_XZX.TabIndex = 11;
            this.gb_XZX.TabStop = false;
            this.gb_XZX.Text = "新中新WebService 设置";
            this.gb_XZX.Visible = false;
            // 
            // cb_XZX_SyncAcc
            // 
            this.cb_XZX_SyncAcc.AutoSize = true;
            this.cb_XZX_SyncAcc.Location = new System.Drawing.Point(323, 46);
            this.cb_XZX_SyncAcc.Name = "cb_XZX_SyncAcc";
            this.cb_XZX_SyncAcc.Size = new System.Drawing.Size(72, 16);
            this.cb_XZX_SyncAcc.TabIndex = 5;
            this.cb_XZX_SyncAcc.Text = "同步账号";
            this.cb_XZX_SyncAcc.UseVisualStyleBackColor = true;
            // 
            // cb_XZX_NoStud
            // 
            this.cb_XZX_NoStud.AutoSize = true;
            this.cb_XZX_NoStud.Location = new System.Drawing.Point(301, 19);
            this.cb_XZX_NoStud.Name = "cb_XZX_NoStud";
            this.cb_XZX_NoStud.Size = new System.Drawing.Size(108, 16);
            this.cb_XZX_NoStud.TabIndex = 4;
            this.cb_XZX_NoStud.Text = "账号代替空学号";
            this.cb_XZX_NoStud.UseVisualStyleBackColor = true;
            // 
            // cb_XZX_EveryInfo
            // 
            this.cb_XZX_EveryInfo.AutoSize = true;
            this.cb_XZX_EveryInfo.Location = new System.Drawing.Point(249, 46);
            this.cb_XZX_EveryInfo.Name = "cb_XZX_EveryInfo";
            this.cb_XZX_EveryInfo.Size = new System.Drawing.Size(72, 16);
            this.cb_XZX_EveryInfo.TabIndex = 3;
            this.cb_XZX_EveryInfo.Text = "逐条获取";
            this.cb_XZX_EveryInfo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "站点号";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "子系统代码";
            // 
            // tb_XZX_Trem
            // 
            this.tb_XZX_Trem.Location = new System.Drawing.Point(184, 44);
            this.tb_XZX_Trem.Name = "tb_XZX_Trem";
            this.tb_XZX_Trem.Size = new System.Drawing.Size(51, 21);
            this.tb_XZX_Trem.TabIndex = 1;
            // 
            // tb_XZX_SystemCode
            // 
            this.tb_XZX_SystemCode.Location = new System.Drawing.Point(77, 44);
            this.tb_XZX_SystemCode.Name = "tb_XZX_SystemCode";
            this.tb_XZX_SystemCode.Size = new System.Drawing.Size(54, 21);
            this.tb_XZX_SystemCode.TabIndex = 1;
            // 
            // tb_XZX_Port
            // 
            this.tb_XZX_Port.Location = new System.Drawing.Point(249, 17);
            this.tb_XZX_Port.Name = "tb_XZX_Port";
            this.tb_XZX_Port.Size = new System.Drawing.Size(46, 21);
            this.tb_XZX_Port.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(205, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "端口号";
            // 
            // tb_XZX_IP
            // 
            this.tb_XZX_IP.Location = new System.Drawing.Point(53, 17);
            this.tb_XZX_IP.Name = "tb_XZX_IP";
            this.tb_XZX_IP.Size = new System.Drawing.Size(146, 21);
            this.tb_XZX_IP.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "服务器";
            // 
            // gb_SQLSelect
            // 
            this.gb_SQLSelect.Controls.Add(this.rtb_SQLSelect);
            this.gb_SQLSelect.Location = new System.Drawing.Point(27, 154);
            this.gb_SQLSelect.Name = "gb_SQLSelect";
            this.gb_SQLSelect.Size = new System.Drawing.Size(420, 118);
            this.gb_SQLSelect.TabIndex = 12;
            this.gb_SQLSelect.TabStop = false;
            this.gb_SQLSelect.Text = "SQL查询语句";
            // 
            // rtb_SQLSelect
            // 
            this.rtb_SQLSelect.Location = new System.Drawing.Point(12, 20);
            this.rtb_SQLSelect.Name = "rtb_SQLSelect";
            this.rtb_SQLSelect.Size = new System.Drawing.Size(391, 82);
            this.rtb_SQLSelect.TabIndex = 0;
            this.rtb_SQLSelect.Text = "";
            // 
            // btn_DataTest
            // 
            this.btn_DataTest.Location = new System.Drawing.Point(248, 125);
            this.btn_DataTest.Name = "btn_DataTest";
            this.btn_DataTest.Size = new System.Drawing.Size(97, 23);
            this.btn_DataTest.TabIndex = 13;
            this.btn_DataTest.Text = "数据获取测试";
            this.btn_DataTest.UseVisualStyleBackColor = true;
            this.btn_DataTest.Click += new System.EventHandler(this.btn_DataTest_Click);
            // 
            // gb_RowKey
            // 
            this.gb_RowKey.Controls.Add(this.tb_PW);
            this.gb_RowKey.Controls.Add(this.label25);
            this.gb_RowKey.Controls.Add(this.tb_Flag);
            this.gb_RowKey.Controls.Add(this.label24);
            this.gb_RowKey.Controls.Add(this.tb_Dept);
            this.gb_RowKey.Controls.Add(this.label23);
            this.gb_RowKey.Controls.Add(this.tb_Type);
            this.gb_RowKey.Controls.Add(this.label22);
            this.gb_RowKey.Controls.Add(this.tb_Sex);
            this.gb_RowKey.Controls.Add(this.label21);
            this.gb_RowKey.Controls.Add(this.tb_Name);
            this.gb_RowKey.Controls.Add(this.label17);
            this.gb_RowKey.Controls.Add(this.tb_CardID);
            this.gb_RowKey.Controls.Add(this.label16);
            this.gb_RowKey.Controls.Add(this.tb_CardNo);
            this.gb_RowKey.Controls.Add(this.label10);
            this.gb_RowKey.Location = new System.Drawing.Point(27, 278);
            this.gb_RowKey.Name = "gb_RowKey";
            this.gb_RowKey.Size = new System.Drawing.Size(420, 87);
            this.gb_RowKey.TabIndex = 14;
            this.gb_RowKey.TabStop = false;
            this.gb_RowKey.Text = "对应关键字（TXT文档使用数字标示对应属性）";
            // 
            // tb_PW
            // 
            this.tb_PW.Location = new System.Drawing.Point(333, 47);
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.Size = new System.Drawing.Size(55, 21);
            this.tb_PW.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(298, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 14;
            this.label25.Text = "密码";
            // 
            // tb_Flag
            // 
            this.tb_Flag.Location = new System.Drawing.Point(237, 47);
            this.tb_Flag.Name = "tb_Flag";
            this.tb_Flag.Size = new System.Drawing.Size(55, 21);
            this.tb_Flag.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(202, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 12;
            this.label24.Text = "标示";
            // 
            // tb_Dept
            // 
            this.tb_Dept.Location = new System.Drawing.Point(141, 47);
            this.tb_Dept.Name = "tb_Dept";
            this.tb_Dept.Size = new System.Drawing.Size(55, 21);
            this.tb_Dept.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(106, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 10;
            this.label23.Text = "院系";
            // 
            // tb_Type
            // 
            this.tb_Type.Location = new System.Drawing.Point(45, 47);
            this.tb_Type.Name = "tb_Type";
            this.tb_Type.Size = new System.Drawing.Size(55, 21);
            this.tb_Type.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 8;
            this.label22.Text = "类型";
            // 
            // tb_Sex
            // 
            this.tb_Sex.Location = new System.Drawing.Point(333, 20);
            this.tb_Sex.Name = "tb_Sex";
            this.tb_Sex.Size = new System.Drawing.Size(55, 21);
            this.tb_Sex.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(298, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 6;
            this.label21.Text = "性别";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(237, 20);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(55, 21);
            this.tb_Name.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(202, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "姓名";
            // 
            // tb_CardID
            // 
            this.tb_CardID.Location = new System.Drawing.Point(141, 20);
            this.tb_CardID.Name = "tb_CardID";
            this.tb_CardID.Size = new System.Drawing.Size(55, 21);
            this.tb_CardID.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "卡号";
            // 
            // tb_CardNo
            // 
            this.tb_CardNo.Location = new System.Drawing.Point(45, 20);
            this.tb_CardNo.Name = "tb_CardNo";
            this.tb_CardNo.Size = new System.Drawing.Size(55, 21);
            this.tb_CardNo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "学号";
            // 
            // cb_SyncPW
            // 
            this.cb_SyncPW.AutoSize = true;
            this.cb_SyncPW.Location = new System.Drawing.Point(6, 20);
            this.cb_SyncPW.Name = "cb_SyncPW";
            this.cb_SyncPW.Size = new System.Drawing.Size(132, 16);
            this.cb_SyncPW.TabIndex = 16;
            this.cb_SyncPW.Text = "同步密码（限汇文）";
            this.cb_SyncPW.UseVisualStyleBackColor = true;
            // 
            // cb_AutoActive
            // 
            this.cb_AutoActive.AutoSize = true;
            this.cb_AutoActive.Location = new System.Drawing.Point(6, 42);
            this.cb_AutoActive.Name = "cb_AutoActive";
            this.cb_AutoActive.Size = new System.Drawing.Size(96, 16);
            this.cb_AutoActive.TabIndex = 17;
            this.cb_AutoActive.Text = "账号自动激活";
            this.cb_AutoActive.UseVisualStyleBackColor = true;
            // 
            // cb_AutoLogout
            // 
            this.cb_AutoLogout.AutoSize = true;
            this.cb_AutoLogout.Location = new System.Drawing.Point(108, 42);
            this.cb_AutoLogout.Name = "cb_AutoLogout";
            this.cb_AutoLogout.Size = new System.Drawing.Size(96, 16);
            this.cb_AutoLogout.TabIndex = 18;
            this.cb_AutoLogout.Text = "注销失效账号";
            this.cb_AutoLogout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tb_Seat_PW);
            this.groupBox1.Controls.Add(this.tb_Seat_Name);
            this.groupBox1.Controls.Add(this.tb_Seat_UID);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.tb_Seat_IP);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Location = new System.Drawing.Point(454, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "座位系统数据库设置";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(206, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "密码";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "数据库";
            // 
            // tb_Seat_PW
            // 
            this.tb_Seat_PW.Location = new System.Drawing.Point(241, 44);
            this.tb_Seat_PW.Name = "tb_Seat_PW";
            this.tb_Seat_PW.Size = new System.Drawing.Size(86, 21);
            this.tb_Seat_PW.TabIndex = 1;
            // 
            // tb_Seat_Name
            // 
            this.tb_Seat_Name.Location = new System.Drawing.Point(53, 44);
            this.tb_Seat_Name.Name = "tb_Seat_Name";
            this.tb_Seat_Name.Size = new System.Drawing.Size(147, 21);
            this.tb_Seat_Name.TabIndex = 1;
            // 
            // tb_Seat_UID
            // 
            this.tb_Seat_UID.Location = new System.Drawing.Point(241, 17);
            this.tb_Seat_UID.Name = "tb_Seat_UID";
            this.tb_Seat_UID.Size = new System.Drawing.Size(86, 21);
            this.tb_Seat_UID.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(206, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "账号";
            // 
            // tb_Seat_IP
            // 
            this.tb_Seat_IP.Location = new System.Drawing.Point(53, 17);
            this.tb_Seat_IP.Name = "tb_Seat_IP";
            this.tb_Seat_IP.Size = new System.Drawing.Size(147, 21);
            this.tb_Seat_IP.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "服务器";
            // 
            // btn_SeatLinkTest
            // 
            this.btn_SeatLinkTest.Location = new System.Drawing.Point(720, 125);
            this.btn_SeatLinkTest.Name = "btn_SeatLinkTest";
            this.btn_SeatLinkTest.Size = new System.Drawing.Size(75, 23);
            this.btn_SeatLinkTest.TabIndex = 20;
            this.btn_SeatLinkTest.Text = "连接测试";
            this.btn_SeatLinkTest.UseVisualStyleBackColor = true;
            this.btn_SeatLinkTest.Click += new System.EventHandler(this.btn_SeatLinkTest_Click);
            // 
            // gb_FTP
            // 
            this.gb_FTP.Controls.Add(this.btn_TsetFtp);
            this.gb_FTP.Controls.Add(this.cb_UseFTP);
            this.gb_FTP.Controls.Add(this.tb_FTP_PW);
            this.gb_FTP.Controls.Add(this.label30);
            this.gb_FTP.Controls.Add(this.tb_FTP_UID);
            this.gb_FTP.Controls.Add(this.label31);
            this.gb_FTP.Controls.Add(this.tb_FTP_Path);
            this.gb_FTP.Controls.Add(this.label32);
            this.gb_FTP.Location = new System.Drawing.Point(27, 371);
            this.gb_FTP.Name = "gb_FTP";
            this.gb_FTP.Size = new System.Drawing.Size(420, 100);
            this.gb_FTP.TabIndex = 21;
            this.gb_FTP.TabStop = false;
            this.gb_FTP.Text = "FTP下载设置（Excel/Xml/Txt）";
            // 
            // btn_TsetFtp
            // 
            this.btn_TsetFtp.Location = new System.Drawing.Point(312, 65);
            this.btn_TsetFtp.Name = "btn_TsetFtp";
            this.btn_TsetFtp.Size = new System.Drawing.Size(97, 23);
            this.btn_TsetFtp.TabIndex = 28;
            this.btn_TsetFtp.Text = "下载测试";
            this.btn_TsetFtp.UseVisualStyleBackColor = true;
            this.btn_TsetFtp.Click += new System.EventHandler(this.btn_TsetFtp_Click);
            // 
            // cb_UseFTP
            // 
            this.cb_UseFTP.AutoSize = true;
            this.cb_UseFTP.Location = new System.Drawing.Point(13, 16);
            this.cb_UseFTP.Name = "cb_UseFTP";
            this.cb_UseFTP.Size = new System.Drawing.Size(66, 16);
            this.cb_UseFTP.TabIndex = 27;
            this.cb_UseFTP.Text = "启用FTP";
            this.cb_UseFTP.UseVisualStyleBackColor = true;
            // 
            // tb_FTP_PW
            // 
            this.tb_FTP_PW.Location = new System.Drawing.Point(186, 66);
            this.tb_FTP_PW.Name = "tb_FTP_PW";
            this.tb_FTP_PW.Size = new System.Drawing.Size(111, 21);
            this.tb_FTP_PW.TabIndex = 11;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(151, 69);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 10;
            this.label30.Text = "密码";
            // 
            // tb_FTP_UID
            // 
            this.tb_FTP_UID.Location = new System.Drawing.Point(46, 66);
            this.tb_FTP_UID.Name = "tb_FTP_UID";
            this.tb_FTP_UID.Size = new System.Drawing.Size(99, 21);
            this.tb_FTP_UID.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 8;
            this.label31.Text = "账号";
            // 
            // tb_FTP_Path
            // 
            this.tb_FTP_Path.Location = new System.Drawing.Point(70, 38);
            this.tb_FTP_Path.Name = "tb_FTP_Path";
            this.tb_FTP_Path.Size = new System.Drawing.Size(339, 21);
            this.tb_FTP_Path.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(11, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 6;
            this.label32.Text = "下载地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.tb_SpanTime);
            this.groupBox2.Controls.Add(this.rb_SpanSync);
            this.groupBox2.Controls.Add(this.rb_TimeSync);
            this.groupBox2.Controls.Add(this.cb_AutoSync);
            this.groupBox2.Controls.Add(this.cb_MiniSetup);
            this.groupBox2.Controls.Add(this.tb_SyancTime);
            this.groupBox2.Controls.Add(this.btn_Auto);
            this.groupBox2.Controls.Add(this.btn_Sync);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.cb_SyncPW);
            this.groupBox2.Controls.Add(this.cb_AutoActive);
            this.groupBox2.Controls.Add(this.cb_AutoLogout);
            this.groupBox2.Location = new System.Drawing.Point(453, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 141);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "同步设置";
            // 
            // cb_AutoSync
            // 
            this.cb_AutoSync.AutoSize = true;
            this.cb_AutoSync.Location = new System.Drawing.Point(6, 64);
            this.cb_AutoSync.Name = "cb_AutoSync";
            this.cb_AutoSync.Size = new System.Drawing.Size(108, 16);
            this.cb_AutoSync.TabIndex = 26;
            this.cb_AutoSync.Text = "启动后自动同步";
            this.cb_AutoSync.UseVisualStyleBackColor = true;
            // 
            // cb_MiniSetup
            // 
            this.cb_MiniSetup.AutoSize = true;
            this.cb_MiniSetup.Location = new System.Drawing.Point(120, 64);
            this.cb_MiniSetup.Name = "cb_MiniSetup";
            this.cb_MiniSetup.Size = new System.Drawing.Size(84, 16);
            this.cb_MiniSetup.TabIndex = 25;
            this.cb_MiniSetup.Text = "最小化启动";
            this.cb_MiniSetup.UseVisualStyleBackColor = true;
            // 
            // tb_SyancTime
            // 
            this.tb_SyancTime.Location = new System.Drawing.Point(85, 86);
            this.tb_SyancTime.Name = "tb_SyancTime";
            this.tb_SyancTime.Size = new System.Drawing.Size(63, 21);
            this.tb_SyancTime.TabIndex = 24;
            // 
            // btn_Auto
            // 
            this.btn_Auto.Location = new System.Drawing.Point(230, 78);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(106, 23);
            this.btn_Auto.TabIndex = 22;
            this.btn_Auto.Text = "开始自动同步";
            this.btn_Auto.UseVisualStyleBackColor = true;
            this.btn_Auto.Click += new System.EventHandler(this.btn_Auto_Click);
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(230, 49);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(106, 23);
            this.btn_Sync.TabIndex = 21;
            this.btn_Sync.Text = "手动同步";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(230, 20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(106, 23);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "保存设置";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pb_Progress
            // 
            this.pb_Progress.Location = new System.Drawing.Point(453, 458);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(283, 13);
            this.pb_Progress.Step = 1;
            this.pb_Progress.TabIndex = 23;
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(453, 340);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(342, 112);
            this.rtb_Message.TabIndex = 24;
            this.rtb_Message.Text = "";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(453, 325);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 12);
            this.label34.TabIndex = 25;
            this.label34.Text = "操作消息";
            // 
            // lb_Progress
            // 
            this.lb_Progress.AutoSize = true;
            this.lb_Progress.Location = new System.Drawing.Point(742, 459);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(47, 12);
            this.lb_Progress.TabIndex = 26;
            this.lb_Progress.Text = "100.00%";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(451, 301);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(89, 12);
            this.label36.TabIndex = 27;
            this.label36.Text = "下次同步时间：";
            // 
            // lb_SyncTime
            // 
            this.lb_SyncTime.AutoSize = true;
            this.lb_SyncTime.Location = new System.Drawing.Point(546, 301);
            this.lb_SyncTime.Name = "lb_SyncTime";
            this.lb_SyncTime.Size = new System.Drawing.Size(101, 12);
            this.lb_SyncTime.TabIndex = 28;
            this.lb_SyncTime.Text = "2016-1-1 2:00:00";
            // 
            // nIcon
            // 
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "座位管理系统读者信息同步程序";
            this.nIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_MouseDoubleClick);
            // 
            // rb_TimeSync
            // 
            this.rb_TimeSync.AutoSize = true;
            this.rb_TimeSync.Checked = true;
            this.rb_TimeSync.Location = new System.Drawing.Point(8, 90);
            this.rb_TimeSync.Name = "rb_TimeSync";
            this.rb_TimeSync.Size = new System.Drawing.Size(71, 16);
            this.rb_TimeSync.TabIndex = 27;
            this.rb_TimeSync.TabStop = true;
            this.rb_TimeSync.Text = "固定时间";
            this.rb_TimeSync.UseVisualStyleBackColor = true;
            // 
            // rb_SpanSync
            // 
            this.rb_SpanSync.AutoSize = true;
            this.rb_SpanSync.Location = new System.Drawing.Point(8, 113);
            this.rb_SpanSync.Name = "rb_SpanSync";
            this.rb_SpanSync.Size = new System.Drawing.Size(71, 16);
            this.rb_SpanSync.TabIndex = 28;
            this.rb_SpanSync.TabStop = true;
            this.rb_SpanSync.Text = "时间间隔";
            this.rb_SpanSync.UseVisualStyleBackColor = true;
            // 
            // tb_SpanTime
            // 
            this.tb_SpanTime.Location = new System.Drawing.Point(85, 112);
            this.tb_SpanTime.Name = "tb_SpanTime";
            this.tb_SpanTime.Size = new System.Drawing.Size(63, 21);
            this.tb_SpanTime.TabIndex = 30;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(154, 117);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 31;
            this.label33.Text = "分钟";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.lb_SyncTime);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.lb_Progress);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.rtb_Message);
            this.Controls.Add(this.pb_Progress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_FTP);
            this.Controls.Add(this.btn_SeatLinkTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_RowKey);
            this.Controls.Add(this.btn_DataTest);
            this.Controls.Add(this.gb_SQLSelect);
            this.Controls.Add(this.gb_XZX);
            this.Controls.Add(this.gb_File);
            this.Controls.Add(this.gb_Orcale);
            this.Controls.Add(this.btn_TestConn);
            this.Controls.Add(this.gb_Sybase);
            this.Controls.Add(this.gb_SQL);
            this.Controls.Add(this.rbtype_XZX);
            this.Controls.Add(this.rbtype_TXT);
            this.Controls.Add(this.rbtype_Xml);
            this.Controls.Add(this.rbtype_Excel);
            this.Controls.Add(this.rbtype_Sybase);
            this.Controls.Add(this.rbtype_Orcale);
            this.Controls.Add(this.rbtype_SQL);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "读者信息同步工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.gb_SQL.ResumeLayout(false);
            this.gb_SQL.PerformLayout();
            this.gb_Orcale.ResumeLayout(false);
            this.gb_Orcale.PerformLayout();
            this.gb_File.ResumeLayout(false);
            this.gb_File.PerformLayout();
            this.gb_Sybase.ResumeLayout(false);
            this.gb_Sybase.PerformLayout();
            this.gb_XZX.ResumeLayout(false);
            this.gb_XZX.PerformLayout();
            this.gb_SQLSelect.ResumeLayout(false);
            this.gb_RowKey.ResumeLayout(false);
            this.gb_RowKey.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_FTP.ResumeLayout(false);
            this.gb_FTP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtype_SQL;
        private System.Windows.Forms.RadioButton rbtype_Orcale;
        private System.Windows.Forms.RadioButton rbtype_Sybase;
        private System.Windows.Forms.RadioButton rbtype_Excel;
        private System.Windows.Forms.RadioButton rbtype_Xml;
        private System.Windows.Forms.RadioButton rbtype_TXT;
        private System.Windows.Forms.RadioButton rbtype_XZX;
        private System.Windows.Forms.GroupBox gb_SQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SQL_IP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SQL_PW;
        private System.Windows.Forms.TextBox tb_SQL_DB;
        private System.Windows.Forms.TextBox tb_SQL_User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TestConn;
        private System.Windows.Forms.GroupBox gb_Orcale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Orcale_PW;
        private System.Windows.Forms.TextBox tb_Orcale_User;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Oracle_SSID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_Sybase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Sybase_PW;
        private System.Windows.Forms.TextBox tb_Sybase_DB;
        private System.Windows.Forms.TextBox tb_Sybase_UID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_Sybase_IPPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gb_File;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_XZX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_XZX_Trem;
        private System.Windows.Forms.TextBox tb_XZX_SystemCode;
        private System.Windows.Forms.TextBox tb_XZX_Port;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_XZX_IP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gb_SQLSelect;
        private System.Windows.Forms.RichTextBox rtb_SQLSelect;
        private System.Windows.Forms.Button btn_DataTest;
        private System.Windows.Forms.GroupBox gb_RowKey;
        private System.Windows.Forms.TextBox tb_CardNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_PW;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_Flag;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_Dept;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_Type;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_Sex;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_CardID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cb_SyncPW;
        private System.Windows.Forms.CheckBox cb_AutoActive;
        private System.Windows.Forms.CheckBox cb_AutoLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_Seat_PW;
        private System.Windows.Forms.TextBox tb_Seat_Name;
        private System.Windows.Forms.TextBox tb_Seat_UID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_Seat_IP;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_SeatLinkTest;
        private System.Windows.Forms.GroupBox gb_FTP;
        private System.Windows.Forms.TextBox tb_FTP_PW;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_FTP_UID;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_FTP_Path;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_MiniSetup;
        private System.Windows.Forms.TextBox tb_SyancTime;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox cb_XZX_EveryInfo;
        private System.Windows.Forms.CheckBox cb_AutoSync;
        private System.Windows.Forms.Label lb_Progress;
        private System.Windows.Forms.CheckBox cb_UseFTP;
        private System.Windows.Forms.Button btn_TsetFtp;
        private System.Windows.Forms.CheckBox cb_XZX_SyncAcc;
        private System.Windows.Forms.CheckBox cb_XZX_NoStud;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lb_SyncTime;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.TextBox tb_SpanTime;
        private System.Windows.Forms.RadioButton rb_SpanSync;
        private System.Windows.Forms.RadioButton rb_TimeSync;
        private System.Windows.Forms.Label label33;

    }
}

