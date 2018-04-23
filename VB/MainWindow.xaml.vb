Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.ComponentModel

Namespace DXSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            DataContext = New Contact With {.FirstName = "Carolyn", .LastName = "Baker", .Email = "carolyn.baker@example.com", .Phone = "(555)349-3010", .Address = "1198 Theresa Cir", .City = "Whitinsville", .State = "MA", .Zip = "01582"}
            InitializeComponent()
        End Sub
    End Class
    Public Class Contact
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property CreditCardNumber() As String
        Public Property Email() As String
        Public Property Phone() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property State() As String
        Public Property Zip() As String
        Public Property Photo() As Byte()
    End Class
End Namespace