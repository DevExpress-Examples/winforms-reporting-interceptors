Imports DevExpress.DataAccess.Sql
Imports System.Data

Namespace XtraReportApp
	Friend Class NolockInterceptor
		Implements IDBCommandInterceptor

		Public Sub CommandCreated(ByVal queryName As String, ByVal command As IDbCommand) Implements IDBCommandInterceptor.CommandCreated
			command.CommandText &= " WITH (NOLOCK)"
		End Sub

	End Class
End Namespace
