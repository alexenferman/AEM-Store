Public Class Form3
    Dim documentcomplete As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Diagnostics.Process.Start("https://alexenferman.github.io/MStoreLinkGenLite/main/index.html" + "?" + Form1.WebBrowser1.Url.ToString)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class