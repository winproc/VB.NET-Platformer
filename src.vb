Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Loaded")
    End Sub
    Dim JumpForce As Integer


    Private Async Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim GravityEnabled As Boolean

        GravityEnabled = True

        Do
            Await Task.Delay(10)
            If Label1.Location.Y < 250 Then
                Label1.Location += New Point(0, 2)


            End If
            If Label1.Location.Y < 0 Then
                Label1.Location = New Point(300, 250)
            End If
        Loop
    End Sub

    Private Async Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim Jumping As Boolean

        JumpForce = 0
        If e.KeyChar = "w" Then
            Jumping = True
            JumpForce = -15
            Do Until JumpForce >= JumpForce * -1
                Await Task.Delay(20)
                Label1.Location += New Point(0, JumpForce)
                JumpForce += 1
            Loop
            JumpForce = 0

        ElseIf e.KeyChar = "a" Then
            Label1.Location += New Point(-10, 0)
        ElseIf e.KeyChar = "d" Then
            Label1.Location += New Point(10, 0)
        End If

    End Sub
End Class
