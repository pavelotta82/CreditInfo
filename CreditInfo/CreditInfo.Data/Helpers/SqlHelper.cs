using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Data.Helpers
{
	public class SqlHelper
	{
		static public void Test()
		{
			var sql = "SELECT * FROM Info";
			using (var conn = new SqlConnection(ConnectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var n = reader["Name"] as string;
							var i = 0;
						}
					}
				};
			}
		}

		public static string ConnectionString
		{
			get
			{
				return "";
				// return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
			}
		}
	}
}
