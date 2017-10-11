using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
namespace QuanLiDaiLi
{
    class ConnectSQL
    {
        
        public SqlConnection conn;
       
        public ConnectSQL()
        {

            try
            {//string str = System.Configuration.ConfigurationSettings.AppSettings["MYCONN"];
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBfilename=|DataDirectory|\QuanLiDaiLi.mdf;Integrated Security=True");
            } catch { }

                
                
            
        }


    }
}

