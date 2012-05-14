using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMFW.IDAL;
using MMFW.CommonStruct;
using System.Data;
using System.Data.SqlClient;

namespace MMFW.MSSQLSERVERDAL
{
    public class UserDAL:ChildDBCBase,IUserDAL
    {
        //接口IUserDAL中方法的实现
        //通过ChildDBCBase调用DBCBase取配置文件中的连接数据库参数连接数据库

        /// <summary>
        /// 网页用户登录函数
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回数据库中传回的密码值</returns>
        public string Login(string userName, string password)
        {
            string ret; //函数返回值，记录数据库返回的密码
            try
            {
                #region 调用执行存储过程
                //将用户名与密码传回数据库执行判断
                SqlDataReader sqlData = null; //存储数据库返回值的变量
                SqlParameter[] sqlPara = new SqlParameter[2];
                sqlPara[0] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
                sqlPara[0].Value = userName;
                sqlPara[1] = new SqlParameter("@password", SqlDbType.VarChar, 15);
                sqlPara[1].Value = password;
                
                sqlData = this.RunProcedure("UserDAL_Login", sqlPara);
                #endregion
                
                if (sqlData.Read())
                {
                    //读取存储过程中返回的值
                    ret = sqlData["Password"].ToString();
                }
                else
                {
                    ret = "";
                }
            }
            catch (Exception ex)
            {
                //捕捉异常，写入日志
                throw ex;
            }
            return ret;
        }

        public string UserRegist(string userName, string password)
        {
            string ret = "fail";
            try
            {
                SqlParameter[] sqlPara = new SqlParameter[3];
                sqlPara[0] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
                sqlPara[0].Value = userName;
                sqlPara[1] = new SqlParameter("@password", SqlDbType.VarChar, 15);
                sqlPara[1].Value = password;
                sqlPara[2] = new SqlParameter("@strReturn", SqlDbType.VarChar, 50);
                sqlPara[2].Direction = System.Data.ParameterDirection.Output;
                int rowCount = 0;
                this.RunProcedure("UserDAL_Regist", sqlPara, out rowCount);
                ret = Convert.ToString(sqlPara[2].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public int UpdateUserInfo(UserInfoVO strUserInfo)
        {
            try
            {
                #region 赋值给存储过程变量
                SqlParameter[] sqlPara = new SqlParameter[12];
                sqlPara[0] = new SqlParameter("@loginName", SqlDbType.VarChar, 50);
                sqlPara[0].Value = strUserInfo.LoginName;
                sqlPara[1] = new SqlParameter("@userName", SqlDbType.VarChar, 10);
                sqlPara[1].Value = strUserInfo.UserName;
                sqlPara[2] = new SqlParameter("@EnglishName", SqlDbType.VarChar, 25);
                sqlPara[2].Value = strUserInfo.EnglishName;
                sqlPara[3] = new SqlParameter("@birthday", SqlDbType.Date);
                sqlPara[3].Value = strUserInfo.Birthday;
                sqlPara[4] = new SqlParameter("@sex", SqlDbType.VarChar, 2);
                sqlPara[4].Value = strUserInfo.Sex;
                sqlPara[5] = new SqlParameter("@school", SqlDbType.VarChar, 50);
                sqlPara[5].Value = strUserInfo.School;
                sqlPara[6] = new SqlParameter("@job", SqlDbType.VarChar, 10);
                sqlPara[6].Value = strUserInfo.Job;
                sqlPara[7] = new SqlParameter("@qq", SqlDbType.VarChar, 15);
                sqlPara[7].Value = strUserInfo.QQ;
                sqlPara[8] = new SqlParameter("@weibo", SqlDbType.VarChar, 50);
                sqlPara[8].Value = strUserInfo.Weibo;
                sqlPara[9] = new SqlParameter("@msn", SqlDbType.VarChar, 50);
                sqlPara[9].Value = strUserInfo.Msn;
                sqlPara[10] = new SqlParameter("@mobilPhone", SqlDbType.VarChar, 20);
                sqlPara[10].Value = strUserInfo.Mobilphone;
                sqlPara[11] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
                sqlPara[11].Value = strUserInfo.Phone;
                #endregion

                int rowCount = 0;
                this.RunProcedure("UserDAL_UpdateUserInfo", sqlPara, out rowCount);
                return rowCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
