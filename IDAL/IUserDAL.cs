using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMFW.CommonStruct;

namespace MMFW.IDAL
{
    public interface IUserDAL
    {
        /// <summary>
        /// 登录函数
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <param name="strPassword">密码</param>
        /// <returns></returns>
        string Login(string strUserName, string strPassword);

        /// <summary>
        /// 用户注册函数
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <param name="strPassword">密码</param>
        /// <returns>返回值</returns>
        string UserRegist(string strUserName, string strPassword);

        int UpdateUserInfo(UserInfoVO strUserInfo);
    }
}
