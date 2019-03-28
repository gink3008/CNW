using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace CNW.Models
{
    public class connect
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        string sql = "server=.; database=bcdonlinesv; integrated security = true;"
        public connect()
        {
            if (con == null)
                con = new SqlConnection(sql);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
                con.Close();
        }
    }
}