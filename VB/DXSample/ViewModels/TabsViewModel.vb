Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DXSample.Services
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels
    <POCOViewModel> _
    Public Class TabsViewModel

        Public Sub New()
            Tabs = New ObservableCollection(Of TabViewModel)()
            For i As Integer = 0 To 9
                Tabs.Add(ViewModelSource.Create(Function() New TabViewModel() With {.Content = String.Format("Content_{0}", i), .Header = String.Format("Header_{0}", i)}))
            Next i
        End Sub

        Protected ReadOnly Property TabControlService() As ITabControlService
            Get
                Return Me.GetService(Of ITabControlService)()
            End Get
        End Property

        Public Sub HideItem(ByVal item As Object)
            TabControlService.Hide(item)
        End Sub
        Public Sub ShowAllItems()
            For Each item In Tabs
                TabControlService.Show(item)
            Next item
        End Sub

        Public Overridable Property Tabs() As ObservableCollection(Of TabViewModel)
    End Class

    <POCOViewModel> _
    Public Class TabViewModel
        Public Overridable Property Content() As String
        Public Overridable Property Header() As String
    End Class
End Namespace