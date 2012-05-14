using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using MMFW.IDAL;

namespace MMFW.BLL
{
    public class DALFactory
    {
        internal static IUserDAL CreateUsersDAL(string msSQLDALOrOracleDAL)
        {
            string className = msSQLDALOrOracleDAL + ".UserDAL";
            return (IUserDAL)Assembly.Load(msSQLDALOrOracleDAL).CreateInstance(className);
        }
    }
}
