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
Imports System.Linq
Imports System.Text

Namespace MyXtraGrid
    Public Class Customer

        Private name_Renamed As String

        Private age_Renamed As Integer

        Private weight_Renamed As Integer

        Private height_Renamed As Integer

        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property
        Public Property Age() As Integer
            Get
                Return age_Renamed
            End Get
            Set(ByVal value As Integer)
                age_Renamed = value
            End Set
        End Property
        Public Property Weight() As Integer
            Get
                Return weight_Renamed
            End Get
            Set(ByVal value As Integer)
                weight_Renamed = value
            End Set
        End Property
        Public Property Height() As Integer
            Get
                Return height_Renamed
            End Get
            Set(ByVal value As Integer)
                height_Renamed = value
            End Set
        End Property
    End Class
End Namespace
