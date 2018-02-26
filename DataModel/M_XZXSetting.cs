using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    /// <summary>
    /// 新中新设置
    /// </summary>
    public class M_XZXSetting
    {
        private string _IP = "";
        private string _Port = "";
        private string _SysCode = "";
        private string _TerminalNo = "";
        private bool _EveryInfoGet = false;
        private bool _NoStudentUseAccount = false;
        private bool _SyncAccountNum = false;
        /// <summary>
        /// 第三方IP
        /// </summary>
        public string Ip
        {
            get { return _IP; }
            set { _IP = value; }
        }
        /// <summary>
        /// 端口号
        /// </summary>
        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
        }
        /// <summary>
        /// 子系统代码
        /// </summary>
        public string SysCode
        {
            get { return _SysCode; }
            set { _SysCode = value; }
        }
        /// <summary>
        /// 站点号
        /// </summary>
        public string TerminalNo
        {
            get { return _TerminalNo; }
            set { _TerminalNo = value; }
        }
        /// <summary>
        /// 是否逐条同步
        /// </summary>
        public bool EveryInfoGet
        {
            get { return _EveryInfoGet; }
            set { _EveryInfoGet = value; }
        }
        /// <summary>
        /// 用账号代替学号
        /// </summary>
        public bool NoStudentUseAccount
        {
            get { return _NoStudentUseAccount; }
            set { _NoStudentUseAccount = value; }
        }
        /// <summary>
        /// 同步账户
        /// </summary>
        public bool SyncAccountNum
        {
            get { return _SyncAccountNum; }
            set { _SyncAccountNum = value; }
        }
    }
}
