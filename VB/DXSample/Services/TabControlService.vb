Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Core

Namespace DXSample.Services
    Public Class TabControlService
        Inherits ServiceBase
        Implements ITabControlService

        Private ReadOnly Property AssociatedTabControl() As DXTabControl
            Get
                Return CType(AssociatedObject, DXTabControl)
            End Get
        End Property

        Public Sub Hide(ByVal item As Object) Implements ITabControlService.Hide
            AssociatedTabControl.HideTabItem(item)
        End Sub

        Public Sub Show(ByVal item As Object) Implements ITabControlService.Show
            AssociatedTabControl.ShowTabItem(item)
        End Sub
    End Class
End Namespace
