using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    /// <summary>
    /// orcale数据源设置
    /// </summary>
    public class M_OrcaleSetting
    {
        private string _SID = "";
        private string _UID = "";
        private string _PW = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        public M_OrcaleSetting() { }
        /// <summary>
        /// 连接字符转换成类
        /// </summary>
        /// <param name="connectionString"></param>
        public M_OrcaleSetting(string connectionString)
        {
            string[] dbstr = connectionString.Split(';');
            foreach (string str in dbstr)
            {
                switch (str.Split('=')[0])
                {
                    case "Data Source":
                        _SID = str.Split('=')[1];
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
            return "Data Source=" + _SID + ";Persist Security Info=True;User ID=" + _UID + ";Password=" + _PW;
        }

        /// <summary>
        /// SID
        /// </summary>
        public string SID
        {
            get { return _SID; }
            set { _SID = value; }
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
