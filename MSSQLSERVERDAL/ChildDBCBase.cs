using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMFW.MSSQLSERVERDAL
{
    public class ChildDBCBase : DBCBase
    {
        public ChildDBCBase()
            : base("TheConnectionString")  //调用DBCBase构造函数获取配置文件件的数据库连接字符串
        { }
    }
}
