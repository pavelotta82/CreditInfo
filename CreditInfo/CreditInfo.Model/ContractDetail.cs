using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Model
{
	public class ContractDetail
	{
		public string NationalId { get; set; }
		public List<Contract> Contracts { get; set; } = new List<Contract>();

		public ContractIndividual Individual
		{
			get
			{
				var contr = Contracts.FirstOrDefault(c => c.Individual.Any(i => i.IdentificationNumbers.NationalID == NationalId));
				if (contr == null) return null;
				return contr.Individual.FirstOrDefault(i => i.IdentificationNumbers.NationalID == NationalId);
			}
		}
	}
}
