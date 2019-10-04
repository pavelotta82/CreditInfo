There are 4 projects in this solution.

Project CreditInfo.Api:
Please extract database file from App_Data.zip and attach to your server. 

You can run CreditInfo.Api application on your IIS or IISExrpress
For search method use (api/search/{nationalId}) for example: http://localhost:3552/api/search/AA0000011
For detail method use (api/detail/{nationalId}) (partially implemented) http://localhost:3552/api/detail/AA0000011 (partially implemented)

Project CreditInfo.Importer
Importer just consume Sample.xml file and inserts it into DB (args are not used).

Project CreditInfo.Model
Contains of models created from XML

Project CreditInfo.Data
Project used for Loading and Saving objects
SQL scrips are in SQL folder

Remarks:
Database is filled with data from export. 
Use script from Cleanup.sql to erase data. 
Run CreditInfo.Importer project to import data


I had some problems with XSD file (I was not able to download it from your site: https://creditinfocandidate2019.azurewebsites.net/Home/Exam/assets/Data.xsd, so I made one by my own from XML)
