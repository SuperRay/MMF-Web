using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using MMFW.BLL;

namespace MaoMaoFriendsWeb.Ajax
{
    /// <summary>
    /// Summary description for RegistHandler
    /// </summary>
    public class RegistHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string username = System.Web.HttpUtility.UrlDecode(context.Request["username"]);
            string password = System.Web.HttpUtility.UrlDecode(context.Request["password"]);
            try {
                UserBLL insUserBLL = new UserBLL();
                if (insUserBLL.UserRegist(username, password) == "注册成功")
                {
                    //context.Session.Add("loginName", username); 
                    context.Application.Add("loginName", username);
                    //HttpApplication httpApp = new HttpApplication();
                    //httpApp.Application.Add("loginName", username);
                    context.Response.Write("success");
                }
                else
                {
                    context.Response.Write("fail");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
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