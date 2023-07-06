Imports DevExpress.DataAccess.Sql
Imports System

Namespace XtraReportApp
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			reportDesigner1.AddService(GetType(IDBCommandInterceptor), New NolockInterceptor())
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			reportDesigner1.OpenReport(New XtraReport1())
		End Sub
	End Class
End Namespace
