using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Connection

    {
        public static SqlConnection sc;
        public static SqlConnection Get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = "Data Source=DESKTOP-G09GGNJ;Initial Catalog=master;Integrated Security=True";
                sc.Open();
            }
            return sc;
        }

    }
}