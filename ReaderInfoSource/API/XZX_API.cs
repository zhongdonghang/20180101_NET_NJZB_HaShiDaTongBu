using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ReaderInfoSource.API
{
    unsafe public class XZX_API
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct AccountMsg
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string Name;           /*姓名*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string SexNo;           /*性别*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
            public string DeptCode;       /*部门代码*/
            public uint CardNo;             /*卡号*/
            public uint AccountNo;          /*帐号*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string StudentCode;    /*学号*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string IDCard;         /*身份证号*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string PID;             /*身份代码*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
            public string IDNo;           /*身份序号*/
            public int Balance;            /*现余额*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
            public string Password;        /*消费密码*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
            public string ExpireDate;      /*账户截止日期*/
            public Int32 SubSeq;             /*补助戳*/
            public char IsOpenInSys;        /*是否在本系统内开通*/
            public Int32 TerminalNo;         /*终端号码,提取补助时需要填写*/
            public Int32 RetCode;            /*后台处理返回值*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string Flag;           /*状态(2004-08-26增加)*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string CardType;        /*卡类型*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string AccType;         /*电子账户类型，如果输入则会查询相应的电子帐户余额*/
            public Int32 UsedCardNum;        /*卡片上的用卡次数*/
            public long AccAmt;             /*精确查询时根据输入的AccType查询到的电子帐户余额*/
            public bool bUseInternalAuth;       /*读卡的时候作为输入参数表示是否使用PSAM做内部认证，1使用，0不使用*/
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 69)]
            public string Pad;                /*预留字段*/
        }
        /// <summary>
        /// 用户信息结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct HazyInqAccMsg
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string SexNo;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
            public string DeptCode;
            public uint CardNo;
            public uint AccountNo;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string StudentCode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string IDCard;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string PID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
            public string IDNo;
            public int Balance;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
            public string ExpireDate;
            public int SubSeq;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string Flag;
        }
        /// <summary>
        /// 初始化第三方服务器
        /// </summary>
        /// <param name="IP">第三方服务器IP</param>
        /// <param name="port">端口号</param>
        /// <param name="SysCode">子系统代码</param>
        /// <param name="TerminalNo">站点号</param>
        /// <param name="ProxyOffline">是否在线</param>
        /// <param name="MaxJnl">最大序列号</param>
        [DllImport("AIO_API.dll", EntryPoint = "TA_Init")]
        public static extern bool TA_Init(string IP, int port, int SysCode, int TerminalNo, bool* ProxyOffline, ulong* MaxJnl);

        /// <summary>
        /// 获取全部的账户（白名单）
        /// </summary>
        /// <param name="pAccMsg"></param>
        /// <param name="RecNum"></param>
        /// <param name="FileName"></param>
        /// <param name="TimeOut"></param>
        /// <returns></returns>
        [DllImport("AIO_API.dll", EntryPoint = "TA_HazyInqAcc")]
        public static extern int TA_HazyInqAcc(ref AccountMsg pAccMsg, int* RecNum, string FileName, short TimeOut);

        /// <summary>
        /// 账户查询
        /// </summary>
        /// <param name="pAccMsg"></param>
        /// <param name="TimeOut"></param>
        /// <returns></returns>
        [DllImport("AIO_API.dll", EntryPoint = "TA_InqAcc")]
        public static extern int TA_InqAcc(ref AccountMsg pAccMsg, short TimeOut);

    }
}
