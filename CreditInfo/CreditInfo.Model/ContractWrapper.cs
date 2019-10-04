using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfo.Model
{
	public class ContractWrapper
	{
		private static XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contract));

		public Contract Contract;
		public int Id { get; set; }
		public ContractWrapper(Contract contract)
		{
			Contract = contract;
		}

		public string Code
		{
			get { return Contract.ContractCode; }
		}

		public string Body
		{
			get
			{

				using (StringWriter textWriter = new StringWriter())
				{
					xmlSerializer.Serialize(textWriter, Contract);
					return textWriter.ToString();
				}
			}
		}

		public List<ContractIndividualWrapper> Individuals
		{
			get
			{
				return Contract.Individual.Select(i => new ContractIndividualWrapper(i)).ToList();
			}
		}

		public List<ContractError> Errors
		{
			get
			{
				ContractValidator.TryValidate(Contract, out var errors);
				return errors;
			}
		}

	}
}
