using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfo.Model
{
	public class ContractIndividualWrapper
	{
		public ContractIndividual ContractIndividual;
		public ContractIndividualWrapper(ContractIndividual individual)
		{
			ContractIndividual = individual;
		}

		public string CustomerCode { get { return ContractIndividual.CustomerCode; } }
		public string NationalId { get { return ContractIndividual.IdentificationNumbers.NationalID; } }

	}
}
