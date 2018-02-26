using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ReaderInfoSource
{
    public class SQLSource
    {
        /// <summary>
        /// 连接测试
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public bool LinkDataSourceTest(DataModel.M_Config config)
        {
            SqlConnection conn = new SqlConnection(config.SqlSourceSetting.ToConnectionString());
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public DataTable GetReaderInfo(DataModel.M_Config config)
        {
            SqlConnection conn = new SqlConnection(config.SqlSourceSetting.ToConnectionString());
            string cmdstr = config.SQLString;
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmdstr, conn);
                adapt.Fill(ds);
                conn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable GetReaderList(DataModel.M_Config config, DataTable readerDS)
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
            foreach (DataRow dr in readerDS.Rows)
            {
                DataRow ndr = dt.NewRow();
                ndr["CardNo"] = !string.IsNullOrEmpty(config.TypeKeys.CardNo) && dr[config.TypeKeys.CardNo] != null ? dr[config.TypeKeys.CardNo].ToString().Trim() : "";
                ndr["CardID"] = !string.IsNullOrEmpty(config.TypeKeys.CardID) && dr[config.TypeKeys.CardID] != null ? dr[config.TypeKeys.CardID].ToString().Trim() : "";
                ndr["ReaderName"] = !string.IsNullOrEmpty(config.TypeKeys.Name) && dr[config.TypeKeys.Name] != null ? dr[config.TypeKeys.Name].ToString().Trim() : "";
                ndr["Sex"] = !string.IsNullOrEmpty(config.TypeKeys.Sex) && dr[config.TypeKeys.Sex] != null ? dr[config.TypeKeys.Sex].ToString().Trim() : "";
                ndr["ReaderTypeName"] = !string.IsNullOrEmpty(config.TypeKeys.Type) && dr[config.TypeKeys.Type] != null ? dr[config.TypeKeys.Type].ToString().Trim() : "";
                ndr["ReaderDeptName"] = !string.IsNullOrEmpty(config.TypeKeys.Dept) && dr[config.TypeKeys.Dept] != null ? dr[config.TypeKeys.Dept].ToString().Trim() : "";
                ndr["Flag"] = !string.IsNullOrEmpty(config.TypeKeys.Flag) && dr[config.TypeKeys.Flag] != null ? dr[config.TypeKeys.Flag].ToString().Trim() : "";
                ndr["Password"] = !string.IsNullOrEmpty(config.TypeKeys.Password) && dr[config.TypeKeys.Password] != null ? dr[config.TypeKeys.Password].ToString().Trim() : "";
                ndr["ReaderProName"] = "";
                if (string.IsNullOrEmpty(ndr["CardNo"].ToString()))
                {
                    continue;
                }
                dt.Rows.Add(ndr);
                i++;
                if ((i % 100 == 0 || i == readerDS.Rows.Count) && DataProgress != null)
                {
                    DataProgress(i);
                }
            }
            return dt;
        }

        public event CommonClass.EventClass.EventHandleSync DataProgress;
    }
}
