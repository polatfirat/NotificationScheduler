# NotificationScheduler

Database : MSSQL
DB and tables created with migrate of EF Core. Before running you should change the Connection Strings value in appsettings.Development.json on Development environment.

You can use the link below for API testing 
https://localhost:44345/NotificationScheduler/Create


There are 2 enums for CompanyType and Market

Company Type 
Small = 1,
Medium = 2,
Large = 3

Market
Denmark = 1,
Norway = 2,
Sweden = 3,
Finland = 4


Example : 
{
    "CompanyName":"Test",
    "CompanyNumber":"Asdasd34",
    "CompanyType":1,
    "Market":1
}

Response : 

{
    "companyId": "a5eb8b3f-82ec-409d-28f9-08d97ecaca17",
    "notifications": [
        "24/09/2021",
        "28/09/2021",
        "03/10/2021",
        "08/10/2021",
        "13/10/2021"
    ]
}
