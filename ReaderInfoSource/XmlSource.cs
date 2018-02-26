using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ReaderInfoSource
{
    public class XmlSource
    {
        /// <summary>
        /// 连接测试
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public bool LinkDataSourceTest(DataModel.M_Config config)
        {
            return File.Exists(config.FilePath);
        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public XmlNodeList GetReaderInfo(DataModel.M_Config config)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(config.FilePath);
                //下面部分需要根据实际情况写
                XmlNodeList nodes = doc.SelectNodes("//" + doc.ChildNodes.Item(1).Name + "/Person");
                return nodes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 格式转换
        /// </summary>
        /// <param name="config"></param>
        /// <param name="readerDs"></param>
        /// <returns></returns>
        public System.Data.DataTable GetReaderList(DataModel.M_Config config, XmlNodeList readerDs)
        {
            int i = 0;
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
            foreach (XmlNode node in readerDs)
            {
                DataRow ndr = dt.NewRow();
                int num = 999;
                ndr["CardNo"] = int.TryParse(config.TypeKeys.CardNo, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["CardID"] = int.TryParse(config.TypeKeys.CardID, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["ReaderName"] = int.TryParse(config.TypeKeys.Name, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["Sex"] = int.TryParse(config.TypeKeys.Sex, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["ReaderTypeName"] = int.TryParse(config.TypeKeys.Type, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["ReaderDeptName"] = int.TryParse(config.TypeKeys.Dept, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["Flag"] = int.TryParse(config.TypeKeys.Flag, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["Password"] = int.TryParse(config.TypeKeys.Password, out num) && num < node.ChildNodes.Count && node.ChildNodes[num] != null ? node.ChildNodes[num].Value.Trim() : "";
                ndr["ReaderProName"] = "";
                if (string.IsNullOrEmpty(ndr["CardNo"].ToString()))
                {
                    continue;
                }
                dt.Rows.Add(ndr);
                if ((i % 100 == 0 || i == readerDs.Count) && DataProgress != null)
                {
                    DataProgress(i);
                }
            }
            return dt;
        }

        public event CommonClass.EventClass.EventHandleSync DataProgress;
    }
}
