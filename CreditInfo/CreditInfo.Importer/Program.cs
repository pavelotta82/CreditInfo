using CreditInfo.Data;
using CreditInfo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CreditInfo.Importer
{
	class Program
	{
		static void Main(string[] args)
		{
			var serializer = new XmlSerializer(typeof(Contract));
			var settings = new XmlReaderSettings();
			settings.Schemas.Add("http://creditinfo.com/schemas/Sample/Data", "Sample.xsd");
			settings.ValidationType = ValidationType.Schema;
			settings.IgnoreWhitespace = true;

			try
			{
				using (var con = new SqlConnection(Properties.Settings.Default.DefaultConnection))
				{
					con.Open();
					using (var reader = XmlReader.Create("Sample.xml", settings))
					{
						while (reader.ReadToFollowing("Contract", "http://creditinfo.com/schemas/Sample/Data"))
						{
							try
							{
								var contract = serializer.Deserialize(reader.ReadSubtree()) as Contract;
								var cw = new ContractWrapper(contract);
								ContractSaver.Save(cw, con);
							}
							catch (Exception ex)
							{
								// log exception
							}
						}
					}

					// var i = ContractLoader.HasIndividual("AA0000011", con);
				}
			}
			catch (Exception ex)
			{
				// log exception
			}
			Console.ReadKey();
		}


	}




}
