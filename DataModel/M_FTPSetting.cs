using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class M_FTPSetting
    {
        private string _FTPFileURL = "";
        private string _SavePath = "";
        private string _UID = "";
        private string _PW = "";
        private bool _UseFTP = false;
        /// <summary>
        /// 下载地址
        /// </summary>
        public string FtpFileUrl
        {
            get { return _FTPFileURL; }
            set { _FTPFileURL = value; }
        }
        /// <summary>
        /// 保存地址
        /// </summary>
        public string SavePath
        {
            get { return _SavePath; }
            set { _SavePath = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UID
        {
            get { return _UID; }
            set { _UID = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string PW
        {
            get { return _PW; }
            set { _PW = value; }
        }
        /// <summary>
        /// 启用FTP下载
        /// </summary>
        public bool UseFtp
        {
            get { return _UseFTP; }
            set { _UseFTP = value; }
        }
    }
}
