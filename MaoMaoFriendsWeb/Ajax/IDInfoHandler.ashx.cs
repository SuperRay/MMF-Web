using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using MMFW.BLL;
using MMFW.CommonStruct;

namespace MaoMaoFriendsWeb.Ajax
{
    /// <summary>
    /// Summary description for IDInfoHandler
    /// </summary>
    public class IDInfoHandler : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            UserInfoVO strUserInfo = new UserInfoVO();
            strUserInfo.LoginName = context.Application.Equals("loginName").ToString();
            strUserInfo.UserName = System.Web.HttpUtility.UrlDecode(context.Request["username"]);
            strUserInfo.Birthday = Convert.ToDateTime(System.Web.HttpUtility.UrlDecode(context.Request["birthday"]));
            strUserInfo.Sex = System.Web.HttpUtility.UrlDecode(context.Request["sex"]);
            strUserInfo.School = System.Web.HttpUtility.UrlDecode(context.Request["school"]);
            strUserInfo.Job = System.Web.HttpUtility.UrlDecode(context.Request["job"]);
            strUserInfo.Mobilphone = System.Web.HttpUtility.UrlDecode(context.Request["mobilphone"]);
            strUserInfo.QQ = System.Web.HttpUtility.UrlDecode(context.Request["qq"]);
            strUserInfo.Msn = System.Web.HttpUtility.UrlDecode(context.Request["msn"]);
            strUserInfo.Weibo = System.Web.HttpUtility.UrlDecode(context.Request["weibo"]);
            try
            {
                UserBLL insUserBLL = new UserBLL();
                if (insUserBLL.UpdateUserInfo(strUserInfo) == true)
                {
                    context.Response.Write("success");
                }
                else
                {
                    context.Response.Write("fail");
                }
            }
            catch (Exception ex)
            { }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}