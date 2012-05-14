using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMFW.CommonStruct
{
    public class UserInfoVO
    {
        private string _loginName;

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _englishName;

        public string EnglishName
        {
            get { return _englishName; }
            set { _englishName = value; }
        }
        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _school;

        public string School
        {
            get { return _school; }
            set { _school = value; }
        }
        private string _job;

        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        private string _qq;

        public string QQ
        {
            get { return _qq; }
            set { _qq = value; }
        }
        private string _msn;

        public string Msn
        {
            get { return _msn; }
            set { _msn = value; }
        }
        private string _weibo;

        public string Weibo
        {
            get { return _weibo; }
            set { _weibo = value; }
        }
        private string _mobilphone;

        public string Mobilphone
        {
            get { return _mobilphone; }
            set { _mobilphone = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public UserInfoVO()
        { }
    }
}
