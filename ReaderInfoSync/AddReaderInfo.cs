using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DBUtility;

namespace ReaderInfoSync
{
    public class AddReaderInfo
    {
        public event CommonClass.EventClass.EventHandleSync DataProgress;
        /// <summary>
        /// 读者信息添加到数据库
        /// </summary>
        /// <param name="readerDT"></param>
        public void AddNewData(DataTable readerDT, string connStr)
        {
            try
            {
                ClearDB(connStr);
                SqlBulkCopy sbc = new SqlBulkCopy(connStr);
                sbc.DestinationTableName = "[T_SM_Reader]";
                sbc.BatchSize = 100;
                sbc.NotifyAfter = 100;
                sbc.SqlRowsCopied += sbc_SqlRowsCopied;
                sbc.ColumnMappings.Add(0, 0);
                sbc.ColumnMappings.Add(1, 1);
                sbc.ColumnMappings.Add(2, 2);
                sbc.ColumnMappings.Add(3, 3);
                sbc.ColumnMappings.Add(4, 4);
                sbc.ColumnMappings.Add(5, 5);
                sbc.ColumnMappings.Add(6, 6);
                sbc.ColumnMappings.Add(7, 7);
                sbc.WriteToServer(readerDT);
                if (DataProgress != null)
                {
                    DataProgress(readerDT.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 插入完成100条后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sbc_SqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            if (DataProgress != null)
            {
                DataProgress(e.RowsCopied);
            }
        }
        /// <summary>
        /// 清空T_SM_Reader表
        /// </summary>
        /// <param name="connStr"></param>
        public void ClearDB(string connStr)
        {
            int rows = DbHelperSQL.ExecuteSql("TRUNCATE table T_SM_Reader", connStr);
        }

      
    }

}
