using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    /// <summary>
    /// SQL源设置
    /// </summary>
    public class M_SQLSetting
    {
        private string _IP = "";
        private string _DBName = "";
        private string _UID = "";
        private string _PW = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        public M_SQLSetting() { }
        /// <summary>
        /// 连接字符转换成类
        /// </summary>
        /// <param name="connectionString"></param>
        public M_SQLSetting(string connectionString)
        {
            string[] dbstr = connectionString.Split(';');
            foreach (string str in dbstr)
            {
                switch (str.Split('=')[0])
                {
                    case "Data Source":
                        _IP = str.Split('=')[1];
                        break;
                    case "Initial Catalog":
                        _DBName = str.Split('=')[1];
                        break;
                    case "User ID":
                        _UID = str.Split('=')[1];
                        break;
                    case "Password":
                        _PW = str.Split('=')[1];
                        break;
                }
            }
        }
        /// <summary>
        /// 输出连接字符
        /// </summary>
        /// <returns></returns>
        public string ToConnectionString()
        {
            return "Data Source=" + _IP + ";Initial Catalog=" + _DBName + ";Persist Security Info=True" + ";User ID=" + _UID + ";Password=" + _PW;
        }

        /// <summary>
        /// 数据库IP
        /// </summary>
        public string Ip
        {
            get { return _IP; }
            set { _IP = value; }
        }
        /// <summary>
        /// 数据库名
        /// </summary>
        public string DBName
        {
            get { return _DBName; }
            set { _DBName = value; }
        }
        /// <summary>
        ///账户名
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
    }
}
