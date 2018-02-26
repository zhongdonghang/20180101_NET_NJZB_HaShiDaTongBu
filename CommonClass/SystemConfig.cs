using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using DataModel;

namespace CommonClass
{
    public class SystemConfig
    {
        /// <summary>
        /// 获取设置
        /// </summary>
        /// <returns></returns>
        public static M_Config GetConfig()
        {
            try
            {
                M_Config configModel = new M_Config();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //FTP配置获取
                configModel.FtpSetting.FtpFileUrl = config.AppSettings.Settings["FTPFileUrl"].Value;
                configModel.FtpSetting.SavePath = config.AppSettings.Settings["FilePath"].Value;
                configModel.FtpSetting.UID = config.AppSettings.Settings["FTPUID"].Value;
                configModel.FtpSetting.PW = config.AppSettings.Settings["FTPPW"].Value;
                configModel.FtpSetting.UseFtp = config.AppSettings.Settings["UseFtp"].Value == "1";
                //数据库配置
                configModel.OrcaleSourceSetting = new M_OrcaleSetting(config.ConnectionStrings.ConnectionStrings["OrcaleConnection"].ConnectionString);
                configModel.SqlSourceSetting = new M_SQLSetting(config.ConnectionStrings.ConnectionStrings["SQLConnection"].ConnectionString);
                configModel.SeatDbSetting = new M_SQLSetting(config.ConnectionStrings.ConnectionStrings["ConnectionString"].ConnectionString);
                configModel.SybaseSourceSetting = new M_SybaseSetting(config.ConnectionStrings.ConnectionStrings["SybaseConnection"].ConnectionString);
                configModel.TypeKeys = new M_Key(config.AppSettings.Settings["SourceKey"].Value);
                //新中新接口配置
                configModel.XzxSetting.Ip = config.AppSettings.Settings["XZXIP"].Value.Split(':')[0];
                configModel.XzxSetting.Port = config.AppSettings.Settings["XZXIP"].Value.Split(':')[1];
                configModel.XzxSetting.SysCode = config.AppSettings.Settings["XZXSysCode"].Value;
                configModel.XzxSetting.TerminalNo = config.AppSettings.Settings["TerminalNo"].Value;
                configModel.XzxSetting.EveryInfoGet = config.AppSettings.Settings["EveryInfoGet"].Value == "1";
                configModel.XzxSetting.NoStudentUseAccount = config.AppSettings.Settings["NoStudentUseAccount"].Value == "1";
                configModel.XzxSetting.SyncAccountNum = config.AppSettings.Settings["SyncAccountNum"].Value == "1";
                //其他设置
                configModel.AccessAccount = config.AppSettings.Settings["AccessAccount"].Value == "1";
                configModel.AutoSetup = config.AppSettings.Settings["AutoSetup"].Value == "1";
                configModel.ClearAccount = config.AppSettings.Settings["ClearAccount"].Value == "1";
                configModel.FilePath = config.AppSettings.Settings["FilePath"].Value;
                configModel.MiniSetup = config.AppSettings.Settings["MiniSetup"].Value == "1";
                configModel.SyncPw = config.AppSettings.Settings["SyncPw"].Value == "1";
                configModel.SyncTime = config.AppSettings.Settings["SyncTime"].Value;
                configModel.SyncSpanTime = config.AppSettings.Settings["SyncSpanTime"].Value;
                configModel.SourceType = (E_SyncSourceType)int.Parse(config.AppSettings.Settings["SourceType"].Value);
                configModel.TypeKeys = new M_Key(config.AppSettings.Settings["SourceKey"].Value);
                configModel.SQLString = config.AppSettings.Settings["SQLString"].Value;
                configModel.IsSpanTime = config.AppSettings.Settings["IsSpanTime"].Value == "1";
                return configModel;
            }
            catch (Exception ex)
            {
                WriteLog.Write("获取配置文件遇到错误：" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="configModel"></param>
        /// <returns></returns>
        public static string SaveConfig(M_Config configModel)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //FTP配置获取
                config.AppSettings.Settings["FTPFileUrl"].Value = configModel.FtpSetting.FtpFileUrl;
                config.AppSettings.Settings["FTPUID"].Value = configModel.FtpSetting.UID;
                config.AppSettings.Settings["FTPPW"].Value = configModel.FtpSetting.PW;
                config.AppSettings.Settings["UseFtp"].Value = configModel.FtpSetting.UseFtp ? "1" : "0";

                //数据库配置
                config.ConnectionStrings.ConnectionStrings["OrcaleConnection"].ConnectionString = configModel.OrcaleSourceSetting.ToConnectionString();
                config.ConnectionStrings.ConnectionStrings["SQLConnection"].ConnectionString = configModel.SqlSourceSetting.ToConnectionString();
                config.ConnectionStrings.ConnectionStrings["ConnectionString"].ConnectionString = configModel.SeatDbSetting.ToConnectionString();
                config.ConnectionStrings.ConnectionStrings["SybaseConnection"].ConnectionString = configModel.SybaseSourceSetting.ToConnectionString();
                config.AppSettings.Settings["SourceKey"].Value = configModel.TypeKeys.ToValue();
                //新中新接口配置
                config.AppSettings.Settings["XZXIP"].Value = configModel.XzxSetting.Ip + ":" + configModel.XzxSetting.Port;
                config.AppSettings.Settings["XZXSysCode"].Value = configModel.XzxSetting.SysCode;
                config.AppSettings.Settings["TerminalNo"].Value = configModel.XzxSetting.TerminalNo;
                config.AppSettings.Settings["EveryInfoGet"].Value = configModel.XzxSetting.EveryInfoGet ? "1" : "0";
                config.AppSettings.Settings["NoStudentUseAccount"].Value = configModel.XzxSetting.NoStudentUseAccount ? "1" : "0";
                config.AppSettings.Settings["SyncAccountNum"].Value = configModel.XzxSetting.SyncAccountNum ? "1" : "0";
                //其他设置
                config.AppSettings.Settings["AccessAccount"].Value = configModel.AccessAccount ? "1" : "0";
                config.AppSettings.Settings["AutoSetup"].Value = configModel.AutoSetup ? "1" : "0";
                config.AppSettings.Settings["ClearAccount"].Value = configModel.ClearAccount ? "1" : "0";
                config.AppSettings.Settings["FilePath"].Value = configModel.FilePath;
                config.AppSettings.Settings["MiniSetup"].Value = configModel.MiniSetup ? "1" : "0";
                config.AppSettings.Settings["SyncPw"].Value = configModel.SyncPw ? "1" : "0";
                config.AppSettings.Settings["SyncTime"].Value = configModel.SyncTime;
                config.AppSettings.Settings["SyncSpanTime"].Value = configModel.SyncSpanTime;
                config.AppSettings.Settings["SourceType"].Value = ((int)configModel.SourceType).ToString();
                config.AppSettings.Settings["SQLString"].Value = configModel.SQLString;
                config.AppSettings.Settings["IsSpanTime"].Value = configModel.IsSpanTime ? "1" : "0";
                config.Save();
                return "保存成功";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
