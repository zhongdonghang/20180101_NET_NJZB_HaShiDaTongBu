using CommonClass;
using DataModel;
using ReaderInfoSource.API;
using SeatManage.SeatManageComm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ReaderInfoSyncCMD
{
    class Program
    {
        private static Dictionary<string, string> readerType;
        private static TimeLoop timeLoop;//循环时间  
        static string loopInterval = ConfigurationManager.AppSettings["CheckTimes"];
        static string SyncTimeHour = ConfigurationManager.AppSettings["SyncTimeHour"];

        static bool IsWork = false;

        static void Display(string msg)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + msg);
        }
        #region 解释文件
        public static void GetReaderTypeFile()
        {
            readerType = new Dictionary<string, string>();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "ReaderType.txt";
            SeatManage.SeatManageComm.WriteLog.Write("ReaderType.txt文件读取成功");
            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                while (true)
                {
                    //全部读取
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] strlist = line.Split(',');
                    if (strlist.Length < 2)
                    {
                        continue;
                    }
                    readerType.Add(strlist[0], strlist[1]);

                }
                fs.Close();
            }

        }

        public static System.Data.DataTable GetReaderList(DataModel.M_Config config)
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "File\\";
                string[] files = Directory.GetFiles(filePath);
                if (files.Length < 1)
                {
                    throw new Exception("找不到读者信息文件！");
                }
                string file = files[files.Length - 1];
                GetReaderTypeFile();
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
                try
                {
                    int structSize = Marshal.SizeOf(typeof(XZX_API.HazyInqAccMsg));
                    FileStream fs = new FileStream(file, FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] abt = br.ReadBytes((int)br.BaseStream.Length);
                    br.Close();
                    fs.Close();

                    int readerCount = (int)(abt.Length / structSize);
                    for (int i = 0; i < readerCount; i++)
                    {
                        byte[] bt = new byte[structSize];
                        Array.Copy(abt, i * structSize, bt, 0, structSize);

                        IntPtr ptemp = Marshal.AllocHGlobal(structSize);
                        Marshal.Copy(bt, 0, ptemp, structSize);
                        XZX_API.HazyInqAccMsg accMsg = (XZX_API.HazyInqAccMsg)Marshal.PtrToStructure(ptemp, typeof(XZX_API.HazyInqAccMsg));
                        Marshal.FreeHGlobal(ptemp);

                        if (config.XzxSetting.EveryInfoGet)
                        {
                            XZX_API.AccountMsg acc = new XZX_API.AccountMsg();
                            acc.AccountNo = accMsg.AccountNo;
                            int r = XZX_API.TA_InqAcc(ref acc, 10);
                            if (r == 0)
                            {
                                DataRow dr = dt.NewRow();
                                if (config.XzxSetting.SyncAccountNum)
                                {
                                    dr["CardNo"] = acc.AccountNo.ToString();
                                }
                                else if (!string.IsNullOrEmpty(acc.StudentCode.Trim()))
                                {
                                    dr["CardNo"] = acc.StudentCode.Trim();
                                }
                                else if (config.XzxSetting.NoStudentUseAccount)
                                {
                                    dr["CardNo"] = acc.AccountNo.ToString();
                                }
                                else
                                {
                                    continue;
                                }
                                dr["CardID"] = acc.CardNo.ToString().Trim();
                                dr["ReaderName"] = acc.Name.Trim();
                                dr["Sex"] = acc.SexNo.Trim();
                                if (readerType != null && readerType.Count > 0 && readerType.ContainsKey(acc.PID))
                                {
                                    dr["ReaderTypeName"] = readerType[acc.PID];
                                }
                                else
                                {
                                    dr["ReaderTypeName"] = acc.PID;
                                }
                                dr["ReaderDeptName"] = acc.DeptCode.Trim();
                                dr["ReaderProName"] = "";
                                dr["Flag"] = acc.Flag.Trim();
                                dr["Password"] = "";
                                if (string.IsNullOrEmpty(dr["CardNo"].ToString()))
                                {
                                    continue;
                                }
                                dt.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            DataRow dr = dt.NewRow();
                            if (config.XzxSetting.SyncAccountNum)
                            {
                                dr["CardNo"] = accMsg.AccountNo.ToString();
                            }
                            else if (!string.IsNullOrEmpty(accMsg.StudentCode.Trim()))
                            {
                                dr["CardNo"] = accMsg.StudentCode.Trim();
                            }
                            else if (config.XzxSetting.NoStudentUseAccount)
                            {
                                dr["CardNo"] = accMsg.AccountNo.ToString();
                            }
                            else
                            {
                                continue;
                            }
                            dr["CardID"] = accMsg.CardNo.ToString().Trim();
                            dr["ReaderName"] = accMsg.Name.Trim();
                            // dr["Sex"] = accMsg.SexNo.Trim();
                            if (readerType != null && readerType.Count > 0 && readerType.ContainsKey(accMsg.PID))
                            {
                                dr["ReaderTypeName"] = readerType[accMsg.PID];
                            }
                            else
                            {
                                dr["ReaderTypeName"] = accMsg.PID;
                            }
                            dr["ReaderDeptName"] = accMsg.DeptCode.Trim();
                            //dr["ReaderProName"] = "";
                            //dr["Flag"] = accMsg.Flag.Trim();
                            if (string.IsNullOrEmpty(dr["CardNo"].ToString()))
                            {
                                continue;
                            }
                            dt.Rows.Add(dr);

                         //   Display("第" + i + "条cardno+" + dr["CardNo"].ToString() + "&cardid" + dr["CardID"] + "&name" + dr["ReaderName"] + "");
                        }
                    }
                }
                catch (Exception e)
                {
                    SeatManage.SeatManageComm.WriteLog.Write(string.Format("异常e:" + e.ToString()));
                    throw e;
                }
                return dt;
            }
            catch (Exception ex)
            {
                SeatManage.SeatManageComm.WriteLog.Write(string.Format("异常ex:" + ex.ToString()));
                throw ex;
            }
        }
        #endregion


        /// <summary>
        /// 判断是否时间到了指定工作时间
        /// </summary>
        /// <returns></returns>
        static bool IsTimeToWork()
        {
            bool isTrue = false;
            if (DateTime.Now.Hour.ToString() == SyncTimeHour)
            {
                isTrue = true;
            }

            return isTrue;
        }



        private static void timeLoop_TimeTo(object sender, EventArgs e)
        {
            try
            {
                if (IsTimeToWork() && IsWork == false)
                {
                    IsWork = true; //开始工作
                    try
                    {
                        //拷贝文件
                        string oldPath = ConfigurationManager.AppSettings["oldFilePath"];
                        string[] files = Directory.GetFiles(oldPath);
                        if (files.Length < 1)
                        {
                            throw new Exception("找不到读者信息文件！");
                        }
                        else
                        {
                            string newFilePath = AppDomain.CurrentDomain.BaseDirectory + "File\\";
                            string file = files[files.Length - 1];
                            File.Copy(file, newFilePath+"data", true);
                            Display("读者信息文件拷贝成功");
                            M_Config config = CommonClass.SystemConfig.GetConfig();
                            System.Data.DataTable dt = GetReaderList(config);
                            DBUtility.DbHelperSQL.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                            //1：清空reader表
                            StringBuilder sb = new StringBuilder("delete from T_SM_Reader;");
                            foreach (DataRow item in dt.Rows)
                            {
                                string sql = "insert into T_SM_Reader(CardNo,CardID,ReaderName,ReaderTypeName,ReaderDeptName) values('" + item["CardNo"].ToString().Trim() + "','" + item["CardID"].ToString().Trim() + "','" + item["ReaderName"].ToString().Trim() + "','" + item["ReaderTypeName"].ToString().Trim() + "','" + item["ReaderDeptName"].ToString().Trim() + "');";
                                sb.Append(sql);
                            }
                           int count = DBUtility.DbHelperSQL.ExecuteSqlByTime(sb.ToString(), 300);//同步完reader表
                            sb.Clear();
                            Display("成功同步了"+count+"个读者记录");
                        }

                    }
                    catch (Exception ex)
                    {
                        Display(ex.ToString());
                        SeatManage.SeatManageComm.WriteLog.Write(ex.ToString());
                    }
                    IsWork = false;
                }

            }
            catch (Exception ex)
            {
                SeatManage.SeatManageComm.WriteLog.Write("异常信息:" + ex);
                Display("异常信息:" + ex);
            }
        }

        static void Main(string[] args)
        {
            Display("解释程序启动");
            int loopTime = 0;
            if (!int.TryParse(loopInterval, out loopTime))
            {
                SeatManage.SeatManageComm.WriteLog.Write("运行间隔时间获取失败，请检查是否配置了‘CheckTimes’项");
                Console.WriteLine("运行间隔时间获取失败，请检查是否配置了‘CheckTimes’项");
            }
            timeLoop = new TimeLoop(loopTime);
            timeLoop.TimeTo += new EventHandler(timeLoop_TimeTo);
            timeLoop.TimeStrat();
            Console.ReadLine();
        }
    }
}
