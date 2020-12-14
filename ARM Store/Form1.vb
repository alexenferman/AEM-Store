Imports System.ComponentModel
Imports System.Text

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebBrowser1.CanGoBack() Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WebBrowser1.CanGoForward() Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button11.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.CanGoBack() Then
            Button3.Show()
            PictureBox1.Show()
        Else
            PictureBox1.Hide()
            Button3.Hide()
        End If
        If WebBrowser1.CanGoForward() Then
            Button4.Show()
        Else
            Button4.Hide()
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Maximized
            Me.MaximumSize = Me.Size
            Me.FormBorderStyle = FormBorderStyle.None
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebBrowser1.Navigate("https://www.microsoft.com/en-us/store/apps/windows")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebBrowser1.Navigate("https://www.microsoft.com/en-us/store/games/")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebBrowser1.Navigate("https://www.microsoft.com/en-us/store/top-free/apps/pc?category=Entertainment")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        WebBrowser1.Navigate("https://www.microsoft.com/en-us/store/top-free/apps/mobile")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Navigate("www.microsoft.com/en-us/search?q=" + TextBox1.Text)
        TextBox1.Hide()
        Button7.Hide()
        Button19.Hide()
        Button5.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Show()
        Button7.Show()
        Button19.Show()
        Button5.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        System.Diagnostics.Process.Start("https://alexenferman.github.io/MStoreLinkGenLite/main/index.html" + "?" + WebBrowser1.Url.ToString)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Hide()
        Button7.Hide()
        Button19.Hide()
        Button5.Show()
    End Sub
End Class
