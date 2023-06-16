Imports DevExpress.DataAccess.Sql
Imports System.Data

Namespace XtraReportApp
	Friend Class NolockInterceptor
		Inherits IDBCommandInterceptor

		Public Sub CommandCreated(ByVal queryName As String, ByVal command As IDbCommand)
			command.CommandText &= " WITH (NOLOCK)"
		End Sub
	End Class
End Namespace
