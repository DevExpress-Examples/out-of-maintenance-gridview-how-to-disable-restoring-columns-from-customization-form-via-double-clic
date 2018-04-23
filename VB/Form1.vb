' Developer Express Code Central Example:
' How to create a GridView descendant class and register it for design-time use
' 
' This is an example of a custom GridView and a custom control that inherits the
' DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
' Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
' Knowledge Base article for the additional information.
' In addition, you can
' refer to the examples describing how to create GridControl's View
' descendants:
' 1. http://www.devexpress.com/scid=T122347; 2.
' http://www.devexpress.com/scid=T122335; 3.
' http://www.devexpress.com/scid=T122333; 4.
' http://www.devexpress.com/scid=T122322 ;
' 5.
' http://www.devexpress.com/scid=T122275.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E900

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MyXtraGrid
    Partial Public Class Form1
        Inherits Form

        Private customers As BindingList(Of Customer)
        Public Sub New()
            InitializeComponent()
            FillGridDataSource()
            AddHandler myGridView1.ColumnPositionChanged, AddressOf myGridView1_ColumnPositionChanged
        End Sub

        Private Sub myGridView1_ColumnPositionChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub FillGridDataSource()
            customers = New BindingList(Of Customer)()
            For i As Integer = 0 To 49
                Dim customer As New Customer()
                customer.Name = "Mike"
                If i Mod 2 = 0 Then
                    customer.Name = "John"
                End If
                customer.Age = 70 - i
                customer.Weight = 50 + i
                customer.Height = 150 + i
                customers.Add(customer)
            Next i
            myGridControl1.DataSource = customers
        End Sub
    End Class
End Namespace