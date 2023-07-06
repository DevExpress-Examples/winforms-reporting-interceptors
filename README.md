# Reporting for WinForms - Override the Default Isolation Level 

This example overrides the default isolation level (READ COMMITTED) for a specific query. It allows users to retrieve information without being locked by another process that modifies the same data. 


## Example Overview

1. Implement the [IDBCommandInterceptor](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBCommandInterceptor?p=netframework) interface (`NolockInterceptor.cs` in this example). Call the [IDBCommandInterceptor.CommandCreated(String, IDbCommand)](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBCommandInterceptor.CommandCreated(System.String-System.Data.IDbCommand)) method and specify `CommandText` to execute.

2. Call the [XRDesignMdiController.AddService](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UserDesigner.XRDesignMdiController.AddService(System.Type-System.Object)) method to register the interceptor.

## Files to Review

* [Form1.cs](CS/XtraReportApp/Form1.cs)/[Form1.vb](VB/XtraReportApp/Form1.vb)
* [NolockInterceptor.cs](CS/XtraReportApp/NolockInterceptor.cs)/[NolockInterceptor.vb](VB/XtraReportApp/NolockInterceptor.vb)

## More Examples 

[Reporting for ASP NET.Core - Implement Row-Level Security](https://github.com/DevExpress-Examples/asp-net-core-reporting-row-level-security)

##  Documentation 

* [IDBConnectionInterceptor](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBConnectionInterceptor)
* [IDBCommandInterceptor](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBCommandInterceptor)
