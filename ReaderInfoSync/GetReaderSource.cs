using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;
using DataModel;
using SeatManage.ClassModel;

namespace ReaderInfoSync
{
    public class GetReaderSource
    {
        public event CommonClass.EventClass.EventHandleSyncMessage SyncMessage;
        public event CommonClass.EventClass.EventHandleSyncMessage SyncTime;
        public event CommonClass.EventClass.EventHandleSync SyncProgress;
        public System.Timers.Timer syncT;
        public DateTime syncTime = new DateTime();
        private int readerCount = 0;
        private int addCount = 0;
        private int updateCount = 0;
        //private bool isSync = false;
        /// <summary>
        /// 连接测试
        /// </summary>
        public void LinkTest()
        {
            M_Config config = CommonClass.SystemConfig.GetConfig();
            bool testReturn = false;
            if (SyncMessage != null)
            {
                SyncMessage("连接测试......");
            }
            try
            {
                switch (config.SourceType)
                {
                    case E_SyncSourceType.Excel:
                        {
                            ReaderInfoSource.ExcelSource source = new ReaderInfoSource.ExcelSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.Sybase:
                        {
                            ReaderInfoSource.SybaseSource source = new ReaderInfoSource.SybaseSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.Orcale:
                        {
                            ReaderInfoSource.OrcaleSource source = new ReaderInfoSource.OrcaleSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.SQL:
                        {
                            ReaderInfoSource.SQLSource source = new ReaderInfoSource.SQLSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.TXT:
                        {
                            ReaderInfoSource.TxtSource source = new ReaderInfoSource.TxtSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.Xml:
                        {
                            ReaderInfoSource.XmlSource source = new ReaderInfoSource.XmlSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;
                    case E_SyncSourceType.XZX:
                        {
                            ReaderInfoSource.XZXSource source = new ReaderInfoSource.XZXSource();
                            testReturn = source.LinkDataSourceTest(config);
                        }
                        break;

                }
                if (SyncMessage != null)
                {
                    SyncMessage(testReturn ? "连接成功！" : "连接失败！");
                }
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }


        }
        /// <summary>
        /// 连接测试
        /// </summary>
        public void SeatLinkTest()
        {
            if (SyncMessage != null)
            {
                SyncMessage("连接测试......");
            }
            M_Config config = CommonClass.SystemConfig.GetConfig();
            bool testReturn = false;
            try
            {
                SqlConnection conn = new SqlConnection(config.SeatDbSetting.ToConnectionString());
                conn.Open();
                testReturn = true;
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }
            if (SyncMessage != null)
            {
                SyncMessage(testReturn ? "连接成功！" : "连接失败！");
            }
        }
        /// <summary>
        /// ftp测试
        /// </summary>
        public void FtpTest()
        {
            M_Config config = CommonClass.SystemConfig.GetConfig();
            if (SyncMessage != null)
            {
                SyncMessage("FTP文件下载测试......");
            }
            try
            {
                // 根据uri创建FtpWebRequest对象
                FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(new Uri(config.FtpSetting.FtpFileUrl));
                // 指定数据传输类型
                reqFTP.UseBinary = true;
                // ftp用户名和密码
                reqFTP.Credentials = new NetworkCredential(config.FtpSetting.UID, config.FtpSetting.PW);
                string newFileName = config.FtpSetting.SavePath;
                if (File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }
                //连接                  
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                FileStream outputStream = new FileStream(newFileName, FileMode.Create);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                if (!File.Exists(newFileName))
                {
                    if (SyncMessage != null)
                    {
                        SyncMessage("FTP文件下载失败！");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }
        }
        /// <summary>
        /// 获取数据测试
        /// </summary>
        public void GetDateTest()
        {
            M_Config config = CommonClass.SystemConfig.GetConfig();
            if (SyncMessage != null)
            {
                SyncMessage("获取到用户信息测试......");
            }
            try
            {
                switch (config.SourceType)
                {
                    case E_SyncSourceType.Excel:
                        {
                            ReaderInfoSource.ExcelSource source = new ReaderInfoSource.ExcelSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Rows.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.Sybase:
                        {
                            ReaderInfoSource.SybaseSource source = new ReaderInfoSource.SybaseSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Rows.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.Orcale:
                        {
                            ReaderInfoSource.OrcaleSource source = new ReaderInfoSource.OrcaleSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Rows.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.SQL:
                        {
                            ReaderInfoSource.SQLSource source = new ReaderInfoSource.SQLSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Rows.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.TXT:
                        {
                            ReaderInfoSource.TxtSource source = new ReaderInfoSource.TxtSource();
                            List<string> testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.Xml:
                        {
                            ReaderInfoSource.XmlSource source = new ReaderInfoSource.XmlSource();
                            XmlNodeList testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn.Count.ToString() + "条");
                            }
                        }
                        break;
                    case E_SyncSourceType.XZX:
                        {
                            ReaderInfoSource.XZXSource source = new ReaderInfoSource.XZXSource();
                            int testReturn = source.GetReaderInfo(config);
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + testReturn + "条");
                            }
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }
        }
        /// <summary>
        /// 同步用户信息
        /// </summary>
        public void SyncReaderInfo()
        {
            //isSync = true;
            DateTime sdt = DateTime.Now;
            M_Config config = CommonClass.SystemConfig.GetConfig();
            readerCount = 0;
            updateCount = 0;
            addCount = 0;
            try
            {
                if (config.FtpSetting.UseFtp)
                {
                    if (SyncMessage != null)
                    {
                        SyncMessage("开始下载FTP文件......");
                    }
                    // 根据uri创建FtpWebRequest对象
                    FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(new Uri(config.FtpSetting.FtpFileUrl));
                    // 指定数据传输类型
                    reqFTP.UseBinary = true;
                    // ftp用户名和密码
                    reqFTP.Credentials = new NetworkCredential(config.FtpSetting.UID, config.FtpSetting.PW);
                    string newFileName = config.FtpSetting.SavePath;
                    if (File.Exists(newFileName))
                    {
                        File.Delete(newFileName);
                    }
                    //连接                  
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();
                    long cl = response.ContentLength;
                    int bufferSize = 2048;
                    int readCount;
                    byte[] buffer = new byte[bufferSize];
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                    FileStream outputStream = new FileStream(newFileName, FileMode.Create);
                    while (readCount > 0)
                    {
                        outputStream.Write(buffer, 0, readCount);
                        readCount = ftpStream.Read(buffer, 0, bufferSize);
                    }
                    ftpStream.Close();
                    outputStream.Close();
                    response.Close();
                    if (!File.Exists(newFileName))
                    {
                        if (SyncMessage != null)
                        {
                            SyncMessage("FTP文件下载失败！");
                        }
                        return;
                    }
                    if (SyncMessage != null)
                    {
                        SyncMessage("文件下载完成！");
                        SyncMessage("开始获取用户信息......");
                    }
                }
                DataTable newDT = null;
                switch (config.SourceType)
                {
                    case E_SyncSourceType.Excel:
                        {
                            ReaderInfoSource.ExcelSource source = new ReaderInfoSource.ExcelSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Rows.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.Sybase:
                        {
                            ReaderInfoSource.SybaseSource source = new ReaderInfoSource.SybaseSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Rows.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.Orcale:
                        {
                            ReaderInfoSource.OrcaleSource source = new ReaderInfoSource.OrcaleSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Rows.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.SQL:
                        {
                            ReaderInfoSource.SQLSource source = new ReaderInfoSource.SQLSource();
                            DataTable testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Rows.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.TXT:
                        {
                            ReaderInfoSource.TxtSource source = new ReaderInfoSource.TxtSource();
                            List<string> testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.Xml:
                        {
                            ReaderInfoSource.XmlSource source = new ReaderInfoSource.XmlSource();
                            XmlNodeList testReturn = source.GetReaderInfo(config);
                            source.DataProgress += source_ChangeProgress;
                            readerCount = testReturn.Count;
                            if (SyncMessage != null)
                            {
                                SyncMessage("获取到用户信息" + readerCount.ToString() + "条");
                                SyncMessage("开始转换用户信息......");
                            }
                            newDT = source.GetReaderList(config, testReturn);
                        }
                        break;
                    case E_SyncSourceType.XZX:
                        {
                            try
                            {
                                ReaderInfoSource.XZXSource source = new ReaderInfoSource.XZXSource();
                                int testReturn = source.GetReaderInfo(config);
                                source.DataProgress += source_ChangeProgress;
                                readerCount = testReturn;
                                if (SyncMessage != null)
                                {

                                    SyncMessage("获取到用户信息" + readerCount + "条");
                                    SyncMessage("开始转换用户信息......");
                                }

                                newDT = source.GetReaderList(config);
                            }
                            catch (Exception ex)
                            {
                                SeatManage.SeatManageComm.WriteLog.Write(string.Format("异常：" + ex));
                                throw;
                            }
                        }
                        break;
                }
                if (newDT == null || newDT.Rows.Count < 1)
                {
                    if (SyncMessage != null)
                    {
                        SyncMessage("转换用户信息失败！");
                    }
                }
                else
                {
                    readerCount = newDT.Rows.Count;
                    if (SyncMessage != null)
                    {
                        SyncMessage("转换有效用户信息" + readerCount + "条");
                        SyncMessage("开始同步数据库......");
                    }
                }
                AddReaderInfo addReader = new AddReaderInfo();
                addReader.DataProgress += addReader_DataProgress;
                addReader.AddNewData(newDT, config.SeatDbSetting.ToConnectionString());
                if (SyncMessage != null)
                {
                    SyncMessage("一卡通信息同步完成！");
                }
                if (config.AccessAccount)
                {
                    if (SyncMessage != null)
                    {
                        SyncMessage("开始激活预约账号......");
                    }
                    AddUserInfo addUser = new AddUserInfo();
                    addUser.DataProgress += addUser_DataProgress;
                    DataSet ds = addUser.GetUserDataTable();
                    readerCount = ds.Tables[0].Rows.Count;
                    if (SyncMessage != null)
                    {
                        SyncMessage("已激活账号" + readerCount + "条");
                        SyncMessage("开始获取新增用户激活信息......");
                    }
                    addUser.GetList(newDT, ds.Tables[0], config.SyncPw);
                    List<UserInfo> list = addUser.GetAddList();
                    addCount = list.Count;
                    if (SyncMessage != null)
                    {
                        SyncMessage("获取新增用户" + addCount + "条");
                        SyncMessage("开始添加新增用户激活信息......");
                    }
                    addUser.AddUser(list);
                    if (SyncMessage != null)
                    {
                        SyncMessage("获取新增用户激活完成！");
                        SyncMessage("开始获取更新用户信息......");
                    }
                    list = addUser.GetUpdateList(config.ClearAccount, config.SyncPw);
                    addCount = list.Count;
                    if (SyncMessage != null)
                    {
                        SyncMessage("获取更新用户" + addCount + "条");
                        SyncMessage("开始更新用户信息......");
                    }
                    addUser.UpdateUser(list);
                    if (SyncMessage != null)
                    {
                        SyncMessage("更新用户信息完成！");
                    }
                }
                if (SyncMessage != null)
                {
                    SyncMessage("同步完成！本次耗时" + (DateTime.Now - sdt).TotalSeconds + "秒");
                }
                if (config.IsSpanTime)
                {
                    syncTime = DateTime.Now.AddMinutes(int.Parse(config.SyncSpanTime));
                }
                else
                {
                    if (syncTime < DateTime.Now)
                    {
                        syncTime = syncTime.AddDays(1);
                        if (SyncTime != null)
                        {
                            SyncTime(syncTime.ToString("yyy-MM-dd HH:mm:ss"));
                        }
                    }
                }
                if (SyncMessage != null)
                {
                    SyncMessage("下次同步时间：" + syncTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }
            finally
            {
                //isSync = false;
            }
        }
        /// <summary>
        /// 开始自动同步
        /// </summary>
        public void StartAuto()
        {
            M_Config config = CommonClass.SystemConfig.GetConfig();
            if (config.IsSpanTime)
            {
                syncTime = DateTime.Now.AddMinutes(int.Parse(config.SyncSpanTime));
            }
            else
            {
                syncTime = DateTime.Parse(DateTime.Now.ToLongDateString() + " " + config.SyncTime);
                if (syncTime < DateTime.Now)
                {
                    syncTime = syncTime.AddDays(1);
                }
            }
            if (SyncTime != null)
            {
                SyncTime(syncTime.ToString("yyy-MM-dd HH:mm:ss"));
            }
            syncT = new System.Timers.Timer(30000);
            syncT.Enabled = true;
            syncT.Elapsed += syncT_Elapsed;
            syncT.Start();
            if (SyncMessage != null)
            {
                SyncMessage("开始自动同步！下次同步时间：" + syncTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }

        }

        void syncT_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            syncT.Stop();
            try
            {
                if (syncTime < DateTime.Now)
                {
                    Thread myThread = new Thread(new ThreadStart(SyncReaderInfo));
                    myThread.Start();
                }
            }
            catch (Exception ex)
            {
                if (SyncMessage != null)
                {
                    SyncMessage(ex.Message);
                }
            }
            finally
            {
                syncT.Start();
            }
        }
        /// <summary>
        /// 停止自动同步
        /// </summary>
        public void StopAuto()
        {
            syncT.Stop();
            syncT.Elapsed -= syncT_Elapsed;
            syncT.Close();
            if (SyncMessage != null)
            {
                SyncMessage("自动同步已停止！");
            }
        }
        /// <summary>
        /// 激活用户进度
        /// </summary>
        /// <param name="count"></param>
        void addUser_DataProgress(double count)
        {
            if (SyncProgress != null && addCount > 0)
            {
                SyncProgress(count / (double)addCount);
            }
        }
        /// <summary>
        /// 添加用户进度
        /// </summary>
        /// <param name="count"></param>
        void addReader_DataProgress(double count)
        {
            if (SyncProgress != null && readerCount > 0)
            {
                SyncProgress(count / (double)readerCount);
            }
        }
        /// <summary>
        /// 进度消息
        /// </summary>
        /// <param name="count"></param>
        void source_ChangeProgress(double count)
        {
            if (SyncProgress != null && readerCount > 0)
            {
                SyncProgress(count / (double)readerCount);
            }
        }
    }
}
