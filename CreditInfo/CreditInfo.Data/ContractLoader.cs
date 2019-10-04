using CreditInfo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfo.Data
{
	public class ContractLoader
	{
		public static bool HasIndividual(string nationalId, SqlConnection con)
		{
			
			var sql = @"SELECT CASE WHEN 
								Exists (SELECT * FROM ContractIndividual AS CI WHERE CI.NationalId = @nationalId)
								THEN 1 ELSE 0 END AS HasIndividual
					";


			using (var cmd = new SqlCommand(sql, con))
			{
				cmd.Parameters.AddRange(new[] {
					new SqlParameter("@nationalId", nationalId),
				});

				var retId = cmd.ExecuteScalar();
				return retId.ToString() == "1";
			};
		}

		public static ContractDetail LoadContractDetail(string nationalId, SqlConnection con)
		{
			var detail = new ContractDetail();
			detail.NationalId = nationalId;

			var sql = @"SELECT *
					FROM Contract C
					WHERE C.ContractId IN
					(
						SELECT Fk_Contract
						FROM ContractIndividual CI
						WHERE CI.NationalId = @nationalId
					)";

			using (var cmd = new SqlCommand(sql, con))
			{
				cmd.Parameters.AddRange(new[] {
					new SqlParameter("@nationalId", nationalId),
				});

				using(var reader = cmd.ExecuteReader())
				{
					while(reader.Read())
					{
						detail.Contracts.Add(LoadContract(reader));
					}
				}
			};

			return detail;
		}

		public static Contract LoadContract(SqlDataReader reader)
		{
			var xml = reader["Data"] as string;
			var serializer = new XmlSerializer(typeof(Contract));
			using (TextReader rdr = new StringReader(xml))
			{
				return (Contract)serializer.Deserialize(rdr);
			}
		}
	}
}
