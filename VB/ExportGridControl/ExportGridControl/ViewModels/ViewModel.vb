Imports DevExpress.Mvvm
Imports System.Collections.Generic

Namespace ExportGridControl

    Public Class Product

        Public Property ProductName As String

        Public Property Country As String

        Public Property City As String

        Public Property UnitPrice As Double

        Public Property Quantity As Integer
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Dim products As List(Of Product) = New List(Of Product) From {New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10}, New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .UnitPrice = 22, .Quantity = 50}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .UnitPrice = 18, .Quantity = 20}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15}, New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16}, New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10}, New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .UnitPrice = 22, .Quantity = 50}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .UnitPrice = 18, .Quantity = 20}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15}, New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16}, New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10}, New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .UnitPrice = 22, .Quantity = 50}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .UnitPrice = 18, .Quantity = 20}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15}, New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16}, New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10}, New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .UnitPrice = 22, .Quantity = 50}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .UnitPrice = 18, .Quantity = 20}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15}, New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16}}
            Me.Products = products
        End Sub

        Public ReadOnly Property Products As List(Of Product)
    End Class
End Namespace
