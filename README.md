# Notification Scheduler

Database : MSSQL
DB and tables created with migrate of EF Core. Before running you should change the Connection Strings value in appsettings.Development.json on Development environment.

You can use the link for API testing
https://localhost:44345/NotificationScheduler/Create    (HTTP POST)

There are 2 enums for CompanyType and Market. You must use values listed below for API Request

| Company Type | Value |
| ------ | ------ |
| Small  | 1 |
| Medium  | 2 |
| Large | 3 |

| Market | Value |
| ------ | ------ |
| Denmark   | 1 |
| Norway   | 2 |
| Sweden  | 3 |
| Finland   | 4 |

## Request

```sh
    "CompanyName":"Test",
    "CompanyNumber":"Asdasd34",
    "CompanyType":1,
    "Market":1
```

## Response

```sh
    "companyId": "a5eb8b3f-82ec-409d-28f9-08d97ecaca17",
    "notifications": [
        "24/09/2021",
        "28/09/2021",
        "03/10/2021",
        "08/10/2021",
        "13/10/2021"
    ]
```
