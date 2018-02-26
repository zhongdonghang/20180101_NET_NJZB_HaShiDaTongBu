using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataModel;
using DBUtility;
using SeatManage.ClassModel;
using SeatManage.EnumType;
using SeatManage.SeatManageComm;

namespace ReaderInfoSync
{
    public class AddUserInfo
    {
        public event CommonClass.EventClass.EventHandleSync DataProgress;
        List<UserInfo> oldList;
        List<UserInfo> newList;
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetUserDataTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LoginID,UsrName,UsrPwd,UsrEnabled,UsrType,Remark,IPLockIPAdress ");
            strSql.Append(" FROM Users_ALL ");
            strSql.Append(" WHERE UsrType='1' ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取新旧list
        /// </summary>
        /// <param name="newDS"></param>
        /// <param name="userDS"></param>
        /// <param name="syncPW"></param>
        public void GetList(DataTable newDS, DataTable userDS, bool syncPW)
        {
            oldList = new List<UserInfo>();
            newList = new List<UserInfo>();
            foreach (DataRow dr in newDS.Rows)
            {
                int i = 1;
                UserInfo userInfo = new UserInfo();
                userInfo.LoginId = dr["CardNo"].ToString();
                if (string.IsNullOrEmpty(dr["Password"].ToString()))
                {
                    continue;
                }
                userInfo.Password = syncPW ? dr["Password"].ToString() : MD5Algorithm.GetMD5Str32(dr["Password"].ToString());
                userInfo.UserType = UserType.Reader;
                userInfo.UserName = dr["ReaderName"].ToString();
                userInfo.IsUsing = LogStatus.Valid;
                userInfo.Remark = "同步程序自动激活";
                userInfo.LockIPAdress = "";
                newList.Add(userInfo);
                if ((i % 100 == 0 || i == newDS.Rows.Count) && DataProgress != null)
                {
                    DataProgress(newList.Count);
                }
                i++;
            }
            foreach (DataRow dr in userDS.Rows)
            {
                int i = 1;
                UserInfo userInfo = new UserInfo();
                userInfo.LoginId = dr["LoginID"].ToString();
                userInfo.Password = dr["UsrPwd"].ToString();
                userInfo.UserType = (UserType)int.Parse(dr["UsrType"].ToString());
                userInfo.UserName = dr["UsrName"].ToString();
                userInfo.IsUsing = (LogStatus)int.Parse(dr["UsrEnabled"].ToString());
                userInfo.Remark = dr["Remark"].ToString();
                if (dr["IPLockIPAdress"] != null)
                {
                    userInfo.LockIPAdress = dr["IPLockIPAdress"].ToString();
                }
                oldList.Add(userInfo);
                if ((i % 100 == 0 || i == userDS.Rows.Count) && DataProgress != null)
                {
                    DataProgress(newList.Count);
                }
                i++;
            }
        }

        /// <summary>
        ///获取新增的用户
        /// </summary>
        public List<UserInfo> GetAddList()
        {
            List<UserInfo> list = newList.FindAll(u => oldList.FirstOrDefault(v => v.LoginId == u.LoginId) == null);
            return list;
        }
        /// <summary>
        ///获取更新的用户
        /// </summary>
        public List<UserInfo> GetUpdateList(bool loginout, bool syncPW)
        {
            List<UserInfo> list = new List<UserInfo>();
            if (loginout)
            {
                List<UserInfo> loginoutList = oldList.FindAll(u => newList.FirstOrDefault(v => v.LoginId == u.LoginId) == null);
                foreach (var item in loginoutList)
                {
                    item.IsUsing = LogStatus.Fail;
                }
                list.AddRange(loginoutList);
            }
            if (syncPW)
            {
                List<UserInfo> pwlist = oldList.FindAll(u => newList.FirstOrDefault(v => v.LoginId == u.LoginId && v.Password != u.Password) != null);
                foreach (var item in pwlist)
                {
                    item.Password = newList.First(v => v.LoginId == item.LoginId).Password;
                }
                list.AddRange(pwlist);
            }
            return list;
        }
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="list"></param>
        public void AddUser(List<UserInfo> list)
        {
            WcfServiceForSeatManage.SeatManageDateService seatService = new WcfServiceForSeatManage.SeatManageDateService();
            for (int i = 0; i < list.Count; i++)
            {
                seatService.AddNewUser(list[i]);
                if ((i % 10 == 0 || i == list.Count-1) && DataProgress != null)
                {
                    DataProgress(i);
                }
            }
            if (DataProgress != null)
            {
                DataProgress(list.Count);
            }
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="list"></param>
        public void UpdateUser(List<UserInfo> list)
        {
            WcfServiceForSeatManage.SeatManageDateService seatService = new WcfServiceForSeatManage.SeatManageDateService();
            for (int i = 0; i < list.Count; i++)
            {
                seatService.UpdateUser(list[i]);
                if ((i % 10 == 0 || i == list.Count - 1) && DataProgress != null)
                {
                    DataProgress(i);
                }
            }
            if (DataProgress != null)
            {
                DataProgress(list.Count);
            }
        }
    }
}
