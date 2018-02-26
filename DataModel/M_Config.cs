using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class M_Config
    {
        private M_SQLSetting _SQLSourceSetting = new M_SQLSetting();
        private M_SQLSetting _SeatDbSetting = new M_SQLSetting();
        private M_OrcaleSetting _OrcaleSourceSetting = new M_OrcaleSetting();
        private M_SybaseSetting _SybaseSourceSetting = new M_SybaseSetting();
        private M_FTPSetting _FTPSetting = new M_FTPSetting();
        private M_XZXSetting _XZXSetting = new M_XZXSetting();
        private string _FilePath = "";
        private string _SyncTime = "";
        private string _SyncSpanTime = "";
        private bool _SyncPW = false;
        private bool _AccessAccount = false;
        private bool _ClearAccount = false;
        private bool _MiniSetup = false;
        private bool _AutoSetup = false;
        private E_SyncSourceType _SourceType= E_SyncSourceType.None;
        private M_Key _TypeKeys=new M_Key();
        private string _SQLString = "";
        private bool _IsSpanTime = false;
        /// <summary>
        /// SQL数据源设置
        /// </summary>
        public M_SQLSetting SqlSourceSetting
        {
            get { return _SQLSourceSetting; }
            set { _SQLSourceSetting = value; }
        }
        /// <summary>
        /// 座位数据库设置
        /// </summary>
        public M_SQLSetting SeatDbSetting
        {
            get { return _SeatDbSetting; }
            set { _SeatDbSetting = value; }
        }
        /// <summary>
        /// orcal数据源设置
        /// </summary>
        public M_OrcaleSetting OrcaleSourceSetting
        {
            get { return _OrcaleSourceSetting; }
            set { _OrcaleSourceSetting = value; }
        }
        /// <summary>
        /// sysbase数据库设置
        /// </summary>
        public M_SybaseSetting SybaseSourceSetting
        {
            get { return _SybaseSourceSetting; }
            set { _SybaseSourceSetting = value; }
        }
        /// <summary>
        /// 发图片设置
        /// </summary>
        public M_FTPSetting FtpSetting
        {
            get { return _FTPSetting; }
            set { _FTPSetting = value; }
        }
        /// <summary>
        /// 新中新设置
        /// </summary>
        public M_XZXSetting XzxSetting
        {
            get { return _XZXSetting; }
            set { _XZXSetting = value; }
        }
        /// <summary>
        /// 文件下载地址设置
        /// </summary>
        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }
        /// <summary>
        /// 同步时间
        /// </summary>
        public string SyncTime
        {
            get { return _SyncTime; }
            set { _SyncTime = value; }
        }
        /// <summary>
        /// 是否同步密码
        /// </summary>
        public bool SyncPw
        {
            get { return _SyncPW; }
            set { _SyncPW = value; }
        }
        /// <summary>
        /// 是否账号激活
        /// </summary>
        public bool AccessAccount
        {
            get { return _AccessAccount; }
            set { _AccessAccount = value; }
        }
        /// <summary>
        /// 是否清除账户
        /// </summary>
        public bool ClearAccount
        {
            get { return _ClearAccount; }
            set { _ClearAccount = value; }
        }
        /// <summary>
        /// 最小化启动
        /// </summary>
        public bool MiniSetup
        {
            get { return _MiniSetup; }
            set { _MiniSetup = value; }
        }
        /// <summary>
        /// 启动同步
        /// </summary>
        public bool AutoSetup
        {
            get { return _AutoSetup; }
            set { _AutoSetup = value; }
        }
        /// <summary>
        /// 数据源类型
        /// </summary>
        public E_SyncSourceType SourceType
        {
            get { return _SourceType; }
            set { _SourceType = value; }
        }
        /// <summary>
        /// 对应关键字
        /// </summary>
        public M_Key TypeKeys
        {
            get { return _TypeKeys; }
            set { _TypeKeys = value; }
        }
        /// <summary>
        /// SQL语句
        /// </summary>
        public string SQLString
        {
            get { return _SQLString; }
            set { _SQLString = value; }
        }
        /// <summary>
        /// 是否按照时间间隔同步
        /// </summary>
        public bool IsSpanTime
        {
            get { return _IsSpanTime; }
            set { _IsSpanTime = value; }
        }
        /// <summary>
        /// 间隔同步时间
        /// </summary>
        public string SyncSpanTime
        {
            get { return _SyncSpanTime; }
            set { _SyncSpanTime = value; }
        }
    }
}
