Imports DevExpress.Data
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace TreeList_DataBinding
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()

			InitializeComponent()
			treeListView1.ExpandAllNodes()


		End Sub

		Private Sub treeListView1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.TreeList.TreeListCustomSummaryEventArgs)
			If e.IsNodeSummary AndAlso e.SummaryItem.FieldName = "Statistics" Then
				If e.SummaryProcess = CustomSummaryProcess.Calculate Then
					e.TotalValue = Convert.ToDouble(e.TotalValue) + CDbl(e.FieldValue)
				End If
			End If
		End Sub
	End Class

	Public Class ViewModel
		Inherits ViewModelBase

		Public Property SourceList() As ObservableCollection(Of Employee)
			Get
				Return GetProperty(Function() SourceList)
			End Get
			Set(ByVal value As ObservableCollection(Of Employee))
				SetProperty(Function() SourceList, value)
			End Set
		End Property

		Public Sub New()
			SourceList = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
