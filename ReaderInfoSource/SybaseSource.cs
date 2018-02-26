using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Sybase.Data.AseClient;

namespace ReaderInfoSource
{
    public class SybaseSource
    {
        public bool LinkDataSourceTest(DataModel.M_Config config)
        {
            AseConnection conn = new AseConnection(config.SybaseSourceSetting.ToConnectionString());
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

        public DataTable GetReaderInfo(DataModel.M_Config config)
        {

            AseConnection conn = new AseConnection(config.SybaseSourceSetting.ToConnectionString());
            string cmdstr = config.SQLString;
            DataSet ds = new DataSet();
            try
            {
                AseDataAdapter adapter = new AseDataAdapter(cmdstr, conn);
                adapter.Fill(ds);
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
                if (dr[config.TypeKeys.CardNo] != null)
                {
                    ndr["CardNo"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.CardNo].ToString())).Trim();
                }
                if (dr[config.TypeKeys.CardID] != null)
                {
                    ndr["CardID"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.CardID].ToString())).Trim();
                }
                if (dr[config.TypeKeys.Name] != null)
                {
                    ndr["ReaderName"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Name].ToString())).Trim();
                }
                if (dr[config.TypeKeys.Sex] != null)
                {
                    ndr["Sex"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Sex].ToString())).Trim();
                }
                if (dr[config.TypeKeys.Type] != null)
                {
                    ndr["ReaderTypeName"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Type].ToString())).Trim();
                }
                if (dr[config.TypeKeys.Dept] != null)
                {
                    ndr["ReaderDeptName"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Dept].ToString())).Trim();
                }
                ndr["ReaderProName"] = "";
                if (dr[config.TypeKeys.Flag] != null)
                {
                    ndr["Flag"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Flag].ToString())).Trim();
                }
                if (dr[config.TypeKeys.Password] != null)
                {
                    ndr["Password"] = System.Text.Encoding.GetEncoding("gb2312").GetString(System.Text.Encoding.GetEncoding("cp850").GetBytes(dr[config.TypeKeys.Password].ToString())).Trim();
                }
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
