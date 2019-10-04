using CreditInfo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Data
{
	public class ContractSaver
	{
		public static void Save(ContractWrapper cw, SqlConnection con)
		{
				SaveContract(cw, con);
				SaveIndividuals(cw, con);
				SaveErrors(cw, con);
		}

		public static void SaveContract(ContractWrapper cw, SqlConnection con)
		{
			var sql = @"
						Insert INTO Contract(Code,Data) 
						VALUES(@code,@data);
						SELECT SCOPE_IDENTITY();
					";

			using (var cmd = new SqlCommand(sql, con))
			{
				cmd.Parameters.AddRange(new[] { new SqlParameter("@code", cw.Code), new SqlParameter("@data", cw.Body)});

				var retId = cmd.ExecuteScalar();
				var id = int.Parse(retId.ToString());
				cw.Id = id;
			};
			
		}

		public static void SaveIndividuals(ContractWrapper cw, SqlConnection con)
		{
			var sql = @"
						Insert INTO ContractIndividual(Fk_Contract,CustomerCode,NationalId) 
						VALUES(@fk_Contract,@customerCode,@NationalId);
					";

			foreach(var ind in cw.Individuals)
			{
				using (var cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.AddRange(new[] {
					new SqlParameter("@fk_Contract", cw.Id),
					new SqlParameter("@customerCode", ind.CustomerCode),
					new SqlParameter("@NationalId", ind.NationalId),
				});

					cmd.ExecuteNonQuery();
				};
			}
		}

		public static void SaveErrors(ContractWrapper cw, SqlConnection con)
		{
			var sql = @"
						Insert INTO ContractError(Fk_Contract,Fk_ContractErrorType,Text) 
						VALUES(@fk_Contract,@fk_ContractErrorType,@text);
					";
			try
			{

			
			foreach (var err in cw.Errors)
			{
				using (var cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.AddRange(new[] {
					new SqlParameter("@fk_Contract", cw.Id),
					new SqlParameter("@fk_ContractErrorType", (int)err.ErrorType),
					new SqlParameter("@text", (object)err.Text ?? DBNull.Value ),
				});
					cmd.ExecuteNonQuery();
				};
			}
			}
			catch
			{
				// int i = 5;
			}
		}
	}
}
