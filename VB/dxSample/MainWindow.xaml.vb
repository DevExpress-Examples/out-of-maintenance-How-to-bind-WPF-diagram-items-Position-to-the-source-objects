Imports DevExpress.Xpf.Core

Namespace dxSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub DiagramDataBindingBehavior_CustomLayoutItems(ByVal sender As Object, ByVal e As DevExpress.Xpf.Diagram.DiagramCustomLayoutItemsEventArgs)
            e.Handled = True
        End Sub
    End Class
End Namespace
