using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using CommonClass;
using DataModel;

namespace ReaderInfoSource
{
    public class TxtSource
    {
        /// <summary>
        /// 测试文件是否存在
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public bool LinkDataSourceTest(M_Config config)
        {
            return File.Exists(config.FilePath);
        }
        /// <summary>
        /// 获取读者信息
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public List<string> GetReaderInfo(M_Config config)
        {
            List<string> readerList = new List<string>();
            try
            {
                if (File.Exists(config.FilePath))
                {
                    FileStream fs = new FileStream(config.FilePath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                    int i = 0;
                    while (true)
                    {
                        //全部读取
                        string line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        readerList.Add(line);
                    }
                }
                return readerList;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 转换信息
        /// </summary>
        /// <param name="config"></param>
        /// <param name="readerDs"></param>
        /// <returns></returns>
        public DataTable GetReaderList(M_Config config, List<string> readerDs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CardNo");
            dt.Columns.Add("CardID");
            dt.Columns.Add("ReaderName");
            dt.Columns.Add("Sex");
            dt.Columns.Add("ReaderTypeName");
            dt.Columns.Add("ReaderDeptName");
            dt.Columns.Add("ReaderProName");
            dt.Columns.Add("Flag");
            dt.Columns.Add("Password");
            for (int i = 0; i < readerDs.Count; i++)
            {
                string line = readerDs[i];
                string[] strlist = line.Split(',');
                DataRow ndr = dt.NewRow();
                int num = 999;
                ndr["CardNo"] = int.TryParse(config.TypeKeys.CardNo, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["CardID"] = int.TryParse(config.TypeKeys.CardID, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["ReaderName"] = int.TryParse(config.TypeKeys.Name, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["Sex"] = int.TryParse(config.TypeKeys.Sex, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["ReaderTypeName"] = int.TryParse(config.TypeKeys.Type, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["ReaderDeptName"] = int.TryParse(config.TypeKeys.Dept, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["Flag"] = int.TryParse(config.TypeKeys.Flag, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["Password"] = int.TryParse(config.TypeKeys.Password, out num) && num < strlist.Length && strlist[num] != null ? strlist[num].Trim() : "";
                ndr["ReaderProName"] = "";
                if (string.IsNullOrEmpty(ndr["CardNo"].ToString()))
                {
                    continue;
                }
                dt.Rows.Add(ndr);
                if ((i % 100 == 0 || i == readerDs.Count - 1) && DataProgress != null)
                {
                    DataProgress(i);
                }
            }
            return dt;
        }
        /// <summary>
        /// 消息提醒事件
        /// </summary>
        public event EventClass.EventHandleSync DataProgress;
    }
}
