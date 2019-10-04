ALTER TABLE ContractError
ADD CONSTRAINT DF_ContractError_Contract
FOREIGN KEY (Fk_Contract) REFERENCES Contract(ContractID);

ALTER TABLE ContractError
ADD CONSTRAINT DF_ContractError_ContractErrorType
FOREIGN KEY (Fk_ContractErrorType) REFERENCES ContractErrorType(ContractErrorTypeID);

ALTER TABLE ContractIndividual
ADD CONSTRAINT DF_ContractIndividual_Contract
FOREIGN KEY (Fk_Contract) REFERENCES Contract(ContractID);