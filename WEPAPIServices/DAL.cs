using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEPAPIServices
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AizantIT_ConStr"].ToString());
        public DataTable GetTableDetails()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [AizantIT_Training].[dbo].[Emloyee]", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}