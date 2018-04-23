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
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Customization

Namespace MyXtraGrid
    Public Class MyGridView
        Inherits DevExpress.XtraGrid.Views.Grid.GridView

        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
            MyBase.New(grid)
            ' put your initialization code here
        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property
        Protected Overrides Function CreateCustomizationForm() As DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm
            Return New CustomCustomizationForm(Me) '            base.CreateCustomizationForm();
        End Function
    End Class
    Public Class CustomCustomizationForm
        Inherits CustomizationForm

        Public Sub New(ByVal view As GridView)
            MyBase.New(view)

        End Sub
        Protected Overrides Function CreateCustomizationListBox() As DevExpress.XtraEditors.Customization.CustomizationListBoxBase
            Return New CustomCustomizationListBox(Me)
        End Function
    End Class
    Public Class CustomCustomizationListBox
        Inherits ColumnCustomizationListBox

        Public Sub New(ByVal form As CustomizationForm)
            MyBase.New(form)

        End Sub
        Protected Overrides Sub OnMouseDoubleClick(ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.Clicks >= 2 Then
                Return
            End If
            MyBase.OnMouseDoubleClick(e)
        End Sub
    End Class
End Namespace
