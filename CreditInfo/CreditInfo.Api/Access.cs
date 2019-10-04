using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CreditInfo.Api
{
	public class Access
	{
		public static SqlConnection GetOpenConnection()
		{
			var str = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
			var con = new SqlConnection(str);
			con.Open();
			return con;
		}
	}
}