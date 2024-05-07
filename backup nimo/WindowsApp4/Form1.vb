Imports System.Runtime.Remoting.Messaging

Public Class Form1


    Private Sub CLOSEBUTTON_Click(sender As Object, e As EventArgs) Handles CLOSEBUTTON.Click

        Dim response As Integer

        MsgBox("goodbye")



        Application.Exit()

    End Sub


    Private Sub textbox2_TextChanged(sender As Object, e As EventArgs) Handles PASSWORD.TextChanged

    End Sub
    Private Sub LOGINBUTTON_Click(sender As Object, e As EventArgs) Handles LOGINBUTTON.Click
        If USER.Text = "asdf" And PASSWORD.Text = "1234" Then
            MsgBox("welcome master")
            Form2.Show()
            Me.Hide()
            USER.Clear()
            password.Clear()

        Else
            MsgBox("wrong password or username po try again")

        End If
    End Sub

    Private Sub USER_TextChanged(sender As Object, e As EventArgs) Handles USER.TextChanged

    End Sub


End Class