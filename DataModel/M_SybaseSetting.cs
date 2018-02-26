using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    /// <summary>
    /// sybase数据库设置
    /// </summary>
    public class M_SybaseSetting
    {
        private string _IP = "";
        private string _Port = "";
        private string _DBName = "";
        private string _UID = "";
        private string _PW = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        public M_SybaseSetting() { }
        /// <summary>
        /// 连接字符转换成类
        /// </summary>
        /// <param name="connectionString"></param>
        public M_SybaseSetting(string connectionString)
        {
            string[] dbstr = connectionString.Split(';');
            foreach (string str in dbstr)
            {
                switch (str.Split('=')[0])
                {
                    case "Data Source":
                        _IP = str.Split('=')[1];
                        break;
                    case "Port":
                        _Port = str.Split('=')[1];
                        break;
                    case "Database":
                        _DBName = str.Split('=')[1];
                        break;
                    case "UID":
                        _UID = str.Split('=')[1];
                        break;
                    case "PWD":
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
            //Data Source={0};Port={1};charset=cp850; UID={2};PWD={3};Database={4};
            return "Data Source=" + _IP + ";Port=" + _Port + ";charset=cp850; UID=" + _UID + ";PWD=" + _PW + ";Database=" + _DBName;
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
        /// <summary>
        /// 端口号
        /// </summary>
        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
        }
    }
}
