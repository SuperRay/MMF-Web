using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMFW.IDAL;
using MMFW.CommonStruct;
using System.Configuration;

namespace MMFW.BLL
{
    public class UserBLL
    {
        //初始化接口
        private IUserDAL newUserDAL = new MSSQLSERVERDAL.UserDAL();

        /// <summary>
        /// 网页用户登录函数
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回数据库中传回的密码值</returns>
        public string Login(string userName, string password)
        {
            return newUserDAL.Login(userName, password);
        }

        /// <summary>
        /// 用户注册函数
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回注册状态值</returns>
        public string UserRegist(string userName, string password)
        {
            return newUserDAL.UserRegist(userName, password);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="strUserInfo">用户信息</param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserInfoVO strUserInfo)
        {
            if (newUserDAL.UpdateUserInfo(strUserInfo) > 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
