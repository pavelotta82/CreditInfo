using CreditInfo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Model
{
	public class ContractValidator
	{
		public static bool TryValidate(Contract contract, out List<ContractError> errors)
		{
			errors = new List<ContractError>(); 
			
			var isValid = true;

			var now = DateTime.Now;

			try
			{
				foreach (var indiv in contract.Individual)
				{
					if (!(indiv.DateOfBirth < now.AddYears(-18)) && (now < indiv.DateOfBirth.AddYears(99)))
					{
						isValid = false;
						errors.Add(new ContractError { Code = contract.ContractCode, ErrorType = ContractErrorTypeEn.BadAge, Text = indiv.IdentificationNumbers.NationalID });
					}
				}

				if (contract.SubjectRole.Where(sr=>sr.GuaranteeAmount?.Value != null).Sum(sr => sr.GuaranteeAmount.Value) > contract.ContractData.OriginalAmount.Value)
				{
					isValid = false;
					errors.Add(new ContractError { Code = contract.ContractCode, ErrorType = ContractErrorTypeEn.GuaranteeTooHigh });
				}

				if (contract.ContractData.NextPaymentDate < contract.ContractData.DateOfLastPayment)
				{
					isValid = false;
					errors.Add(new ContractError { Code = contract.ContractCode, ErrorType = ContractErrorTypeEn.DelayedPayment });
				}

				if (contract.ContractData.DateOfLastPayment < contract.ContractData.DateAccountOpened)
				{
					isValid = false;
					errors.Add(new ContractError { Code = contract.ContractCode, ErrorType = ContractErrorTypeEn.LateOpening });
				}
			}
			catch (Exception ex)
			{
				var i= 5;
			}

			return isValid;
		}
	}

	public class ContractError
	{
		public string Code { get; set; }
		public ContractErrorTypeEn ErrorType {get;set;}
		public string Text { get; set; } = null;
	}

	public enum ContractErrorTypeEn
	{
		BadAge = 1,
		DelayedPayment = 2,
		LateOpening = 3,
		GuaranteeTooHigh = 4,
	}
}
