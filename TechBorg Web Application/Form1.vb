Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webbrowser1.Navigate(New Uri("https://www.google.com"))
        webbrowser1.ObjectForScripting = True
    End Sub
End Class
