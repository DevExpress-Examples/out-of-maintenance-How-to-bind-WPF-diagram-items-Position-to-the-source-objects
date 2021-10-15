Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Windows

Namespace dxSample

    Public Class ViewModel

        Public Sub New()
            Items = New List(Of Item)()
            For i As Integer = 0 To 5 - 1
                Items.Add(New Item With {.Id = i, .Name = "Item " & i, .Position = New Point(i * 100, i * 200)})
            Next

            Connections = New List(Of Link)()
            For i As Integer = 0 To 4 - 1
                Connections.Add(New Link With {.From = Items(i).Id, .[To] = Items(i + 1).Id})
            Next

            Connections.Add(New Link With {.From = Items(4).Id, .[To] = Items(0).Id})
        End Sub

        Public Property Connections As List(Of Link)

        Public Property Items As List(Of Item)
    End Class

    Public Class Item
        Inherits BindableBase

        Public Property Id As Integer

        Public Property Name As String

        Public Property Position As Point
            Get
                Return GetProperty(Function() Me.Position)
            End Get

            Set(ByVal value As Point)
                SetProperty(Function() Position, value)
            End Set
        End Property
    End Class

    Public Class Link

        Public Property From As Object

        Public Property [To] As Object
    End Class
End Namespace
