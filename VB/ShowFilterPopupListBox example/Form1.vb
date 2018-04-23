Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace ShowFilterPopupListBox_example
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub treeList1_ShowFilterPopupListBox(ByVal sender As Object, ByVal e As FilterPopupListBoxEventArgs) Handles treeList1.ShowFilterPopupListBox
			If e.Column.FieldName = "Name" Then
				'Removes "(Blanks)"
				e.ComboBox.Items.RemoveAt(0)
				'Removes "(Non blanks)"
				e.ComboBox.Items.RemoveAt(0)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.table1TableAdapter.Fill(Me.treelistdbDataSet.Table1)

		End Sub
	End Class
End Namespace
