using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ReaderInfoSource.API;

namespace ReaderInfoSource
{
    public class XZXSource
    {
        private Dictionary<string, string> readerType;

        unsafe public bool LinkDataSourceTest(DataModel.M_Config config)
        {
            try
            {
                ulong uJnl = 1;
                UInt16 sSysCode = UInt16.Parse(config.XzxSetting.SysCode);
                UInt16 sTerminalNo = UInt16.Parse(config.XzxSetting.TerminalNo);
                string ipip = config.XzxSetting.Ip;
                short ipport = short.Parse(config.XzxSetting.Port);
                bool bOffline = false;
                bool b =  XZX_API.TA_Init(ipip, ipport, sSysCode, sTerminalNo, &bOffline, &uJnl);
                SeatManage.SeatManageComm.WriteLog.Write(string.Format("第三方初始化结果：" + b));
                return b;
            }
            catch (Exception ex)
            {
                SeatManage.SeatManageComm.WriteLog.Write(string.Format("异常：" + ex));
                return false;
            }
        }

        unsafe public int GetReaderInfo(DataModel.M_Config config)
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "RecvTemp";
                if (Directory.Exists(filePath))
                {
                    Directory.Delete(filePath, true);
                }
                Directory.CreateDirectory(filePath);
                filePath = "";
                int recNum = 0;
                XZX_API.AccountMsg accountMsg = new XZX_API.AccountMsg();
                Int16 timeOut = 200;
                int c = XZX_API.TA_HazyInqAcc(ref accountMsg, &recNum, filePath, timeOut);
                if (c == 0)
                {
                    return recNum;
                }
                else
                {
                    throw new Exception("获取用户信息失败！错误代码：" + c);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public System.Data.DataTable GetReaderList(DataModel.M_Config config)
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "RecvTemp\\";
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
                            dr["Sex"] = accMsg.SexNo.Trim();
                            if (readerType != null && readerType.Count > 0 && readerType.ContainsKey(accMsg.PID))
                            {
                                dr["ReaderTypeName"] = readerType[accMsg.PID];
                            }
                            else
                            {
                                dr["ReaderTypeName"] = accMsg.PID;
                            }
                            dr["ReaderDeptName"] = accMsg.DeptCode.Trim();
                            dr["ReaderProName"] = "";
                            dr["Flag"] = accMsg.Flag.Trim();
                            if (string.IsNullOrEmpty(dr["CardNo"].ToString()))
                            {
                                continue;
                            }
                            dt.Rows.Add(dr);
                        }
                        if ((i % 100 == 0 || i == readerCount-1) && DataProgress != null)
                        {
                            DataProgress(i);
                        }
                    }
                }
                catch (Exception e)
                {
                    SeatManage.SeatManageComm.WriteLog.Write(string.Format("异常e:"+e.ToString()));
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

        public void GetReaderTypeFile()
        {
            readerType = new Dictionary<string, string>();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "ReaderType.txt";
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

        public event CommonClass.EventClass.EventHandleSync DataProgress;
    }
}
