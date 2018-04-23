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
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Registrator

Namespace MyXtraGrid
    Public Class MyGridViewInfoRegistrator
        Inherits GridInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property
        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyGridView(TryCast(grid, GridControl))
        End Function
        Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
            Return New MyGridViewInfo(TryCast(view, MyGridView))
        End Function
        Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
            Return New MyGridHandler(TryCast(view, MyGridView))
        End Function
    End Class
End Namespace
