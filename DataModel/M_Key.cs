using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class M_Key
    {
        public M_Key()
        {

        }

        public M_Key(string value)
        {
            string[] strs = value.Split(';');
            foreach (string item in strs)
            {
                switch (item.Split(':')[0])
                {
                    case "CardID": _CardID = item.Split(':')[1]; break;
                    case "CardNo": _CardNo = item.Split(':')[1]; break;
                    case "Name": _Name = item.Split(':')[1]; break;
                    case "Sex": _Sex = item.Split(':')[1]; break;
                    case "Type": _Type = item.Split(':')[1]; break;
                    case "Dept": _Dept = item.Split(':')[1]; break;
                    case "Flag": _Flag = item.Split(':')[1]; break;
                    case "Password": _Password = item.Split(':')[1]; break;
                    default: break;
                }
            }
        }

        public string ToValue()
        {
            return "CardID:" + _CardID
                + ";CardNo:" + _CardNo
                + ";Name:" + _Name
                + ";Sex:" + _Sex
                + ";Type:" + _Type
                + ";Dept:" + _Dept
                + ";Flag:" + _Flag
                + ";Password:" + _Password;
        }

        private string _CardID = "";
        private string _CardNo = "";
        private string _Name = "";
        private string _Sex = "";
        private string _Type = "";
        private string _Dept = "";
        private string _Flag = "";
        private string _Password = "";

        public string CardID
        {
            get { return _CardID; }
            set { _CardID = value; }
        }

        public string CardNo
        {
            get { return _CardNo; }
            set { _CardNo = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }

        public string Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
    }
}
