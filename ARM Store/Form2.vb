Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://forum.xda-developers.com/windows-8-rt/rt-general/arm-rt-app-store-windows-10-rt-t4067813")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://forum.xda-developers.com/member.php?u=10365003")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://store.rg-adguard.net/")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("https://www.alexenferman.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://github.com/alexenferman/MStoreLinkGenLite")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://github.com/alexenferman/AEM-Store")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://www.alexenferman.com/files/aemstore")
    End Sub
End Class