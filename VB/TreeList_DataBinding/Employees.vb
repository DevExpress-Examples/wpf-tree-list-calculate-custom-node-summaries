Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace TreeList_DataBinding

	Public Class Employee
		Inherits BindableBase

		Public Property ID() As Integer
		Public Property ParentID() As Integer
		Public Property Name() As String
		Public Property Statistics() As Double
		Public Property Position() As String
		Public Property Department() As String
	End Class

	Public NotInheritable Class Stuff

		Private Sub New()
		End Sub

		Public Shared Function GetStuff() As ObservableCollection(Of Employee)
'INSTANT VB NOTE: The variable stuff was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim stuff_Renamed As New ObservableCollection(Of Employee)()
			stuff_Renamed.Add(New Employee() With {.ID = 1, .ParentID = 0, .Name = "Gregory S. Price", .Statistics = 2350, .Department = "", .Position = "President"})
			stuff_Renamed.Add(New Employee() With {.ID = 2, .ParentID = 1, .Name = "Irma R. Marshall", .Statistics = 2150, .Department = "Marketing", .Position = "Vice President"})
			stuff_Renamed.Add(New Employee() With {.ID = 3, .ParentID = 1, .Name = "John C. Powell", .Statistics = 3350, .Department = "Operations", .Position = "Vice President"})
			stuff_Renamed.Add(New Employee() With {.ID = 4, .ParentID = 1, .Name = "Christian P. Laclair", .Statistics = 2350, .Department = "Production", .Position = "Vice President"})
			stuff_Renamed.Add(New Employee() With {.ID = 5, .ParentID = 1, .Name = "Karen J. Kelly", .Statistics = 1350, .Department = "Finance", .Position = "Vice President"})

			stuff_Renamed.Add(New Employee() With {.ID = 6, .ParentID = 2, .Name = "Brian C. Cowling", .Statistics = 1650, .Department = "Marketing", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 7, .ParentID = 2, .Name = "Thomas C. Dawson", .Statistics = 1050, .Department = "Marketing", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 8, .ParentID = 2, .Name = "Angel M. Wilson", .Statistics = 2500, .Department = "Marketing", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 9, .ParentID = 2, .Name = "Bryan R. Henderson", .Statistics = 250, .Department = "Marketing", .Position = "Manager"})

			stuff_Renamed.Add(New Employee() With {.ID = 10, .ParentID = 3, .Name = "Harold S. Brandes", .Statistics = 350, .Department = "Operations", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 11, .ParentID = 3, .Name = "Michael S. Blevins", .Statistics = 3550, .Department = "Operations", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 12, .ParentID = 3, .Name = "Jan K. Sisk", .Statistics = 1750, .Department = "Operations", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 13, .ParentID = 3, .Name = "Sidney L. Holder", .Statistics = 1900, .Department = "Operations", .Position = "Manager"})

			stuff_Renamed.Add(New Employee() With {.ID = 14, .ParentID = 4, .Name = "James L. Kelsey", .Statistics = 5010, .Department = "Production", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 15, .ParentID = 4, .Name = "Howard M. Carpenter", .Statistics = 3400, .Department = "Production", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 16, .ParentID = 4, .Name = "Jennifer T. Tapia", .Statistics = 2350, .Department = "Production", .Position = "Manager"})

			stuff_Renamed.Add(New Employee() With {.ID = 17, .ParentID = 5, .Name = "Judith P. Underhill", .Statistics = 2950, .Department = "Finance", .Position = "Manager"})
			stuff_Renamed.Add(New Employee() With {.ID = 18, .ParentID = 5, .Name = "Russell E. Belton", .Statistics = 2150, .Department = "Finance", .Position = "Manager"})
			Return stuff_Renamed
		End Function
	End Class
End Namespace