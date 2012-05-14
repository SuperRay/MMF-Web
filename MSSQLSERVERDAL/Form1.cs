using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MSSQLSERVERDAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=(local);Initial Catalog=MaoMaoFriends;Persist Security Info=True;User ID=RAY\Administrator;Password=''";
            SqlConnection myconn = new SqlConnection(connStr);
            SqlCommand mycomm = myconn.CreateCommand();
            myconn.Open();
        }
    }
}
