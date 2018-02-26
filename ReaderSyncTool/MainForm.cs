using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CommonClass;
using DataModel;
using ReaderInfoSync;

namespace ReaderSyncTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private GetReaderSource getReader;
        private bool isAuto = false;
        private void rbtype_CheckedChanged(object sender, EventArgs e)
        {
            gb_SQL.Visible = rbtype_SQL.Checked;
            gb_Orcale.Visible = rbtype_Orcale.Checked;
            gb_File.Visible = rbtype_Excel.Checked || rbtype_TXT.Checked || rbtype_Xml.Checked;
            gb_Sybase.Visible = rbtype_Sybase.Checked;
            gb_XZX.Visible = rbtype_XZX.Checked;
            gb_FTP.Enabled = rbtype_Excel.Checked || rbtype_TXT.Checked || rbtype_Xml.Checked;
            gb_SQLSelect.Enabled = rbtype_SQL.Checked || rbtype_Orcale.Checked || rbtype_Excel.Checked || rbtype_Sybase.Checked;
            gb_RowKey.Enabled = !rbtype_XZX.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetData();
            getReader = new GetReaderSource();
            getReader.SyncMessage += getReader_SyncMessage;
            getReader.SyncProgress += getReader_SyncProgress;
            getReader.SyncTime += getReader_SyncTime;
            M_Config config = CommonClass.SystemConfig.GetConfig();
            if (config.AutoSetup)
            {
                getReader.StartAuto();
                isAuto = true;
                btn_Auto.Text = "停止自动同步";
            }
            if (config.MiniSetup)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.nIcon.Visible = true;
                this.nIcon.BalloonTipClicked += nIcon_BalloonTipClicked;
            }
        }

        void getReader_SyncTime(string message)
        {
            this.Invoke(new Action(() =>
            { lb_SyncTime.Text = message; }));
        }

        /// <summary>
        /// 同步进度
        /// </summary>
        /// <param name="count"></param>
        void getReader_SyncProgress(double count)
        {
            this.Invoke(new Action(() =>
            {
                pb_Progress.Value = (int)(count * 100);
                lb_Progress.Text = (count * 100).ToString("0.00") + "%";
            }));
        }
        /// <summary>
        /// 同步消息
        /// </summary>
        /// <param name="message"></param>
        void getReader_SyncMessage(string message)
        {
            this.Invoke(new Action(() =>
            {
                rtb_Message.Text += DateTime.Now.ToString("HH:mm:ss") + " " + message + "\n";
                rtb_Message.Select(this.rtb_Message.TextLength, 0);  
                rtb_Message.ScrollToCaret();
                WriteLog.Write(message);
                nIcon.ShowBalloonTip(5000, "同步信息", message, ToolTipIcon.Info);
            }));
        }

        private void GetData()
        {
            M_Config config = CommonClass.SystemConfig.GetConfig();
            if (config == null)
            {
                rtb_Message.Text = "设置获取失败！\n";
                return;
            }
            tb_SQL_IP.Text = config.SqlSourceSetting.Ip;
            tb_SQL_DB.Text = config.SqlSourceSetting.DBName;
            tb_SQL_User.Text = config.SqlSourceSetting.UID;
            tb_SQL_PW.Text = config.SqlSourceSetting.PW;

            tb_Oracle_SSID.Text = config.OrcaleSourceSetting.SID;
            tb_Orcale_User.Text = config.OrcaleSourceSetting.UID;
            tb_Orcale_PW.Text = config.OrcaleSourceSetting.PW;

            tb_Sybase_IPPort.Text = config.SybaseSourceSetting.Ip + ":" + config.SybaseSourceSetting.Port;
            tb_Sybase_DB.Text = config.SybaseSourceSetting.DBName;
            tb_Sybase_UID.Text = config.SybaseSourceSetting.UID;
            tb_Sybase_PW.Text = config.SybaseSourceSetting.PW;

            tb_XZX_IP.Text = config.XzxSetting.Ip;
            tb_XZX_Port.Text = config.XzxSetting.Port;
            tb_XZX_SystemCode.Text = config.XzxSetting.SysCode;
            tb_XZX_Trem.Text = config.XzxSetting.TerminalNo;
            cb_XZX_EveryInfo.Checked = config.XzxSetting.EveryInfoGet;
            cb_XZX_SyncAcc.Checked = config.XzxSetting.SyncAccountNum;
            cb_XZX_NoStud.Checked = config.XzxSetting.NoStudentUseAccount;

            tb_Seat_IP.Text = config.SeatDbSetting.Ip;
            tb_Seat_Name.Text = config.SeatDbSetting.DBName;
            tb_Seat_UID.Text = config.SeatDbSetting.UID;
            tb_Seat_PW.Text = config.SeatDbSetting.PW;

            tb_FilePath.Text = config.FilePath;
            tb_FTP_Path.Text = config.FtpSetting.FtpFileUrl;
            tb_FTP_PW.Text = config.FtpSetting.PW;
            tb_FTP_UID.Text = config.FtpSetting.UID;
            cb_UseFTP.Checked = config.FtpSetting.UseFtp;

            tb_CardID.Text = config.TypeKeys.CardID;
            tb_CardNo.Text = config.TypeKeys.CardNo;
            tb_Dept.Text = config.TypeKeys.Dept;
            tb_Flag.Text = config.TypeKeys.Flag;
            tb_Name.Text = config.TypeKeys.Name;
            tb_PW.Text = config.TypeKeys.Password;
            tb_Sex.Text = config.TypeKeys.Sex;
            tb_Type.Text = config.TypeKeys.Type;

            switch (config.SourceType)
            {
                case E_SyncSourceType.Excel: rbtype_Excel.Checked = true; break;
                case E_SyncSourceType.Sybase: rbtype_Sybase.Checked = true; break;
                case E_SyncSourceType.None: rbtype_SQL.Checked = true; break;
                case E_SyncSourceType.Orcale: rbtype_Orcale.Checked = true; break;
                case E_SyncSourceType.SQL: rbtype_SQL.Checked = true; break;
                case E_SyncSourceType.TXT: rbtype_TXT.Checked = true; break;
                case E_SyncSourceType.Xml: rbtype_Xml.Checked = true; break;
                case E_SyncSourceType.XZX: rbtype_XZX.Checked = true; break;
            }
            cb_AutoActive.Checked = config.AccessAccount;
            cb_AutoLogout.Checked = config.ClearAccount;
            cb_AutoSync.Checked = config.AutoSetup;
            cb_MiniSetup.Checked = config.MiniSetup;
            cb_SyncPW.Checked = config.SyncPw;
            tb_SyancTime.Text = config.SyncTime;
            tb_SpanTime.Text = config.SyncSpanTime;
            rtb_SQLSelect.Text = config.SQLString;
            if (config.IsSpanTime)
            {
                rb_SpanSync.Checked = true;
            }
            else
            {
                rb_TimeSync.Checked = true;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            M_Config config = new M_Config();
            config.SqlSourceSetting.Ip = tb_SQL_IP.Text;
            config.SqlSourceSetting.DBName = tb_SQL_DB.Text;
            config.SqlSourceSetting.UID = tb_SQL_User.Text;
            config.SqlSourceSetting.PW = tb_SQL_PW.Text;

            config.OrcaleSourceSetting.SID = tb_Oracle_SSID.Text;
            config.OrcaleSourceSetting.UID = tb_Orcale_User.Text;
            config.OrcaleSourceSetting.PW = tb_Orcale_PW.Text;

            tb_Sybase_IPPort.Text = config.SybaseSourceSetting.Ip + ":" + config.SybaseSourceSetting.Port;
            config.SybaseSourceSetting.DBName = tb_Sybase_DB.Text;
            config.SybaseSourceSetting.UID = tb_Sybase_UID.Text;
            config.SybaseSourceSetting.PW = tb_Sybase_PW.Text;

            config.XzxSetting.Ip = tb_XZX_IP.Text;
            config.XzxSetting.Port = tb_XZX_Port.Text;
            config.XzxSetting.SysCode = tb_XZX_SystemCode.Text;
            config.XzxSetting.TerminalNo = tb_XZX_Trem.Text;
            config.XzxSetting.EveryInfoGet = cb_XZX_EveryInfo.Checked;
            config.XzxSetting.SyncAccountNum = cb_XZX_SyncAcc.Checked;
            config.XzxSetting.NoStudentUseAccount = cb_XZX_NoStud.Checked;

            config.SeatDbSetting.Ip = tb_Seat_IP.Text;
            config.SeatDbSetting.DBName = tb_Seat_Name.Text;
            config.SeatDbSetting.UID = tb_Seat_UID.Text;
            config.SeatDbSetting.PW = tb_Seat_PW.Text;

            config.FilePath = tb_FilePath.Text;
            config.FtpSetting.FtpFileUrl = tb_FTP_Path.Text;
            config.FtpSetting.PW = tb_FTP_PW.Text;
            config.FtpSetting.UID = tb_FTP_UID.Text;
            config.FtpSetting.UseFtp = cb_UseFTP.Checked;


            config.TypeKeys.CardID = tb_CardID.Text;
            config.TypeKeys.CardNo = tb_CardNo.Text;
            config.TypeKeys.Dept = tb_Dept.Text;
            config.TypeKeys.Flag = tb_Flag.Text;
            config.TypeKeys.Name = tb_Name.Text;
            config.TypeKeys.Password = tb_PW.Text;
            config.TypeKeys.Sex = tb_Sex.Text;
            config.TypeKeys.Type = tb_Type.Text;

            config.SourceType = rbtype_Excel.Checked ? E_SyncSourceType.Excel :
                rbtype_Sybase.Checked ? E_SyncSourceType.Sybase :
                rbtype_SQL.Checked ? E_SyncSourceType.SQL :
                rbtype_Orcale.Checked ? E_SyncSourceType.Orcale :
                rbtype_TXT.Checked ? E_SyncSourceType.TXT :
                rbtype_Xml.Checked ? E_SyncSourceType.Xml :
                rbtype_XZX.Checked ? E_SyncSourceType.XZX :
                E_SyncSourceType.None;

            config.AccessAccount = cb_AutoActive.Checked;
            config.ClearAccount = cb_AutoLogout.Checked;
            config.AutoSetup = cb_AutoSync.Checked;
            config.MiniSetup = cb_MiniSetup.Checked;
            config.SyncPw = cb_SyncPW.Checked;
            config.SyncTime = tb_SyancTime.Text;
            config.SyncSpanTime = tb_SpanTime.Text;
            config.SQLString = rtb_SQLSelect.Text;
            config.IsSpanTime = rb_SpanSync.Checked;
            rtb_Message.Text = CommonClass.SystemConfig.SaveConfig(config) + "\n";
        }
        /// <summary>
        /// 手动同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sync_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            Thread myThread = new Thread(new ThreadStart(getReader.SyncReaderInfo));
            myThread.Start();
        }
        /// <summary>
        /// 自动同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Auto_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            if (isAuto)
            {
                getReader.StopAuto();
                isAuto = false;
                btn_Auto.Text = "开始自动同步";
            }
            else
            {
                getReader.StartAuto();
                isAuto = true;
                btn_Auto.Text = "停止自动同步";
            }

        }
        /// <summary>
        /// 数据获取测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DataTest_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            Thread myThread = new Thread(new ThreadStart(getReader.GetDateTest));
            myThread.Start();
        }
        /// <summary>
        /// 连接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TestConn_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            Thread myThread = new Thread(new ThreadStart(getReader.LinkTest));
            myThread.Start();
        }
        /// <summary>
        /// 连接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SeatLinkTest_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            Thread myThread = new Thread(new ThreadStart(getReader.SeatLinkTest));
            myThread.Start();
        }
        /// <summary>
        /// FTP测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TsetFtp_Click(object sender, EventArgs e)
        {
            rtb_Message.Text = "";
            Thread myThread = new Thread(new ThreadStart(getReader.FtpTest));
            myThread.Start();
        }

        private void nIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.nIcon.Visible = false;
            this.nIcon.BalloonTipClicked -= nIcon_BalloonTipClicked;
        }
        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.nIcon.Visible = true;
                this.nIcon.BalloonTipClicked += nIcon_BalloonTipClicked;
            }
        }

        void nIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.nIcon.Visible = false;
            this.nIcon.BalloonTipClicked -= nIcon_BalloonTipClicked;
        }
    }
}
