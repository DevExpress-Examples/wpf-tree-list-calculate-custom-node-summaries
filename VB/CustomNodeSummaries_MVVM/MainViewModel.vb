Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomNodeSummaries_MVVM
	Public Class Employee
		Public Property ID() As Integer
		Public Property ParentID() As Integer
		Public Property Name() As String
		Public Property Statistics() As Double
		Public Property Position() As String
		Public Property Department() As String
	End Class

	Friend Class MainViewModel
		Inherits ViewModelBase

		Public Property Employees() As ObservableCollection(Of Employee)

		Public Sub New()
			Employees = New ObservableCollection(Of Employee)(GetEmployees())
		End Sub

		<Command>
		Public Sub CustomSummaryCommand(ByVal args As NodeSummaryArgs)
			If args.IsNodeSummary AndAlso args.SummaryItem.PropertyName = NameOf(Employee.Statistics) Then
				If args.SummaryProcess = SummaryProcess.Calculate Then
					args.TotalValue = Convert.ToDouble(args.TotalValue) + CDbl(args.FieldValue)
				End If
			End If
		End Sub

		Private Iterator Function GetEmployees() As IEnumerable(Of Employee)
			Yield New Employee() With {
				.ID = 1,
				.ParentID = 0,
				.Name = "Gregory S. Price",
				.Statistics = 2350,
				.Department = "",
				.Position = "President"
			}
			Yield New Employee() With {
				.ID = 2,
				.ParentID = 1,
				.Name = "Irma R. Marshall",
				.Statistics = 2150,
				.Department = "Marketing",
				.Position = "Vice President"
			}
			Yield New Employee() With {
				.ID = 3,
				.ParentID = 1,
				.Name = "John C. Powell",
				.Statistics = 3350,
				.Department = "Operations",
				.Position = "Vice President"
			}
			Yield New Employee() With {
				.ID = 4,
				.ParentID = 1,
				.Name = "Christian P. Laclair",
				.Statistics = 2350,
				.Department = "Production",
				.Position = "Vice President"
			}
			Yield New Employee() With {
				.ID = 5,
				.ParentID = 1,
				.Name = "Karen J. Kelly",
				.Statistics = 1350,
				.Department = "Finance",
				.Position = "Vice President"
			}

			Yield New Employee() With {
				.ID = 6,
				.ParentID = 2,
				.Name = "Brian C. Cowling",
				.Statistics = 1650,
				.Department = "Marketing",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 7,
				.ParentID = 2,
				.Name = "Thomas C. Dawson",
				.Statistics = 1050,
				.Department = "Marketing",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 8,
				.ParentID = 2,
				.Name = "Angel M. Wilson",
				.Statistics = 2500,
				.Department = "Marketing",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 9,
				.ParentID = 2,
				.Name = "Bryan R. Henderson",
				.Statistics = 250,
				.Department = "Marketing",
				.Position = "Manager"
			}

			Yield New Employee() With {
				.ID = 10,
				.ParentID = 3,
				.Name = "Harold S. Brandes",
				.Statistics = 350,
				.Department = "Operations",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 11,
				.ParentID = 3,
				.Name = "Michael S. Blevins",
				.Statistics = 3550,
				.Department = "Operations",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 12,
				.ParentID = 3,
				.Name = "Jan K. Sisk",
				.Statistics = 1750,
				.Department = "Operations",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 13,
				.ParentID = 3,
				.Name = "Sidney L. Holder",
				.Statistics = 1900,
				.Department = "Operations",
				.Position = "Manager"
			}

			Yield New Employee() With {
				.ID = 14,
				.ParentID = 4,
				.Name = "James L. Kelsey",
				.Statistics = 5010,
				.Department = "Production",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 15,
				.ParentID = 4,
				.Name = "Howard M. Carpenter",
				.Statistics = 3400,
				.Department = "Production",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 16,
				.ParentID = 4,
				.Name = "Jennifer T. Tapia",
				.Statistics = 2350,
				.Department = "Production",
				.Position = "Manager"
			}

			Yield New Employee() With {
				.ID = 17,
				.ParentID = 5,
				.Name = "Judith P. Underhill",
				.Statistics = 2950,
				.Department = "Finance",
				.Position = "Manager"
			}
			Yield New Employee() With {
				.ID = 18,
				.ParentID = 5,
				.Name = "Russell E. Belton",
				.Statistics = 2150,
				.Department = "Finance",
				.Position = "Manager"
			}
		End Function
	End Class
End Namespace
