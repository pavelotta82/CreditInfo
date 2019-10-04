﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Model
{

	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://creditinfo.com/schemas/Sample/Data", IsNullable = false)]
	public partial class Contract
	{

		private string contractCodeField;

		private ContractContractData contractDataField;

		private ContractIndividual[] individualField;

		private ContractSubjectRole[] subjectRoleField;

		/// <remarks/>
		public string ContractCode
		{
			get
			{
				return this.contractCodeField;
			}
			set
			{
				this.contractCodeField = value;
			}
		}

		/// <remarks/>
		public ContractContractData ContractData
		{
			get
			{
				return this.contractDataField;
			}
			set
			{
				this.contractDataField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Individual")]
		public ContractIndividual[] Individual
		{
			get
			{
				return this.individualField;
			}
			set
			{
				this.individualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubjectRole")]
		public ContractSubjectRole[] SubjectRole
		{
			get
			{
				return this.subjectRoleField;
			}
			set
			{
				this.subjectRoleField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractContractData
	{

		private string phaseOfContractField;

		private ContractContractDataOriginalAmount originalAmountField;

		private ContractContractDataInstallmentAmount installmentAmountField;

		private ContractContractDataCurrentBalance currentBalanceField;

		private ContractContractDataOverdueBalance overdueBalanceField;

		private System.DateTime dateOfLastPaymentField;

		private System.DateTime nextPaymentDateField;

		private System.DateTime dateAccountOpenedField;

		private System.DateTime realEndDateField;

		/// <remarks/>
		public string PhaseOfContract
		{
			get
			{
				return this.phaseOfContractField;
			}
			set
			{
				this.phaseOfContractField = value;
			}
		}

		/// <remarks/>
		public ContractContractDataOriginalAmount OriginalAmount
		{
			get
			{
				return this.originalAmountField;
			}
			set
			{
				this.originalAmountField = value;
			}
		}

		/// <remarks/>
		public ContractContractDataInstallmentAmount InstallmentAmount
		{
			get
			{
				return this.installmentAmountField;
			}
			set
			{
				this.installmentAmountField = value;
			}
		}

		/// <remarks/>
		public ContractContractDataCurrentBalance CurrentBalance
		{
			get
			{
				return this.currentBalanceField;
			}
			set
			{
				this.currentBalanceField = value;
			}
		}

		/// <remarks/>
		public ContractContractDataOverdueBalance OverdueBalance
		{
			get
			{
				return this.overdueBalanceField;
			}
			set
			{
				this.overdueBalanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime DateOfLastPayment
		{
			get
			{
				return this.dateOfLastPaymentField;
			}
			set
			{
				this.dateOfLastPaymentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime NextPaymentDate
		{
			get
			{
				return this.nextPaymentDateField;
			}
			set
			{
				this.nextPaymentDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime DateAccountOpened
		{
			get
			{
				return this.dateAccountOpenedField;
			}
			set
			{
				this.dateAccountOpenedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime RealEndDate
		{
			get
			{
				return this.realEndDateField;
			}
			set
			{
				this.realEndDateField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractContractDataOriginalAmount
	{

		private decimal valueField;

		private string currencyField;

		/// <remarks/>
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractContractDataInstallmentAmount
	{

		private decimal valueField;

		private string currencyField;

		/// <remarks/>
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractContractDataCurrentBalance
	{

		private decimal valueField;

		private string currencyField;

		/// <remarks/>
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractContractDataOverdueBalance
	{

		private decimal valueField;

		private string currencyField;

		/// <remarks/>
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractIndividual
	{

		private string customerCodeField;

		private string firstNameField;

		private string lastNameField;

		private string genderField;

		private System.DateTime dateOfBirthField;

		private ContractIndividualIdentificationNumbers identificationNumbersField;

		/// <remarks/>
		public string CustomerCode
		{
			get
			{
				return this.customerCodeField;
			}
			set
			{
				this.customerCodeField = value;
			}
		}

		/// <remarks/>
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}

		/// <remarks/>
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}

		/// <remarks/>
		public string Gender
		{
			get
			{
				return this.genderField;
			}
			set
			{
				this.genderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime DateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}

		/// <remarks/>
		public ContractIndividualIdentificationNumbers IdentificationNumbers
		{
			get
			{
				return this.identificationNumbersField;
			}
			set
			{
				this.identificationNumbersField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractIndividualIdentificationNumbers
	{

		private string nationalIDField;

		/// <remarks/>
		public string NationalID
		{
			get
			{
				return this.nationalIDField;
			}
			set
			{
				this.nationalIDField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractSubjectRole
	{

		private string customerCodeField;

		private string roleOfCustomerField;

		private ContractSubjectRoleGuaranteeAmount guaranteeAmountField;

		/// <remarks/>
		public string CustomerCode
		{
			get
			{
				return this.customerCodeField;
			}
			set
			{
				this.customerCodeField = value;
			}
		}

		/// <remarks/>
		public string RoleOfCustomer
		{
			get
			{
				return this.roleOfCustomerField;
			}
			set
			{
				this.roleOfCustomerField = value;
			}
		}

		/// <remarks/>
		public ContractSubjectRoleGuaranteeAmount GuaranteeAmount
		{
			get
			{
				return this.guaranteeAmountField;
			}
			set
			{
				this.guaranteeAmountField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://creditinfo.com/schemas/Sample/Data")]
	public partial class ContractSubjectRoleGuaranteeAmount
	{

		private decimal valueField;

		private string currencyField;

		/// <remarks/>
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
	}


}
