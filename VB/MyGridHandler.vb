﻿' Developer Express Code Central Example:
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
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace MyXtraGrid
    Public Class MyGridHandler
        Inherits DevExpress.XtraGrid.Views.Grid.Handler.GridHandler

        Public Sub New(ByVal gridView As GridView)
            MyBase.New(gridView)
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            MyBase.OnKeyDown(e)
            If e.KeyData = Keys.Delete AndAlso View.State = GridState.Normal Then
                View.DeleteRow(View.FocusedRowHandle)
            End If
        End Sub
    End Class
End Namespace
