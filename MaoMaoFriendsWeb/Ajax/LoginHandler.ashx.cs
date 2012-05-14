//<%@ WebHandler Language="C#" Class="Handler" %>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMFW.BLL;

namespace MaoMaoFriendsWeb.Ajax
{
    /// <summary>
    /// Summary description for LoginHandler
    /// </summary>
    public class LoginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {            
            string username = context.Request["username"].ToString();
            string password = context.Request["password"].ToString();
            
            try
            {
                UserBLL insUserBLL = new UserBLL();
                if (insUserBLL.Login(username, password) == password)
                {
                    context.Response.Write("success");
                    //存储session
                }
                else
                {
                    context.Response.Write("fail");
                }
            }
            catch (Exception ex)
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