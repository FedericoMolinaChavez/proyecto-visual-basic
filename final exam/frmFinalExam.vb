Public Class frmFinalExam
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Validating
        Dim number As Integer


        If Not TextBox1.TextLength > 0 Or Not Int32.TryParse(TextBox1.Text, number) Or Int32.Parse(TextBox1.Text, number) <=
            0 Then

            MessageBox.Show("Please enter a number bigger than 0 for calculating",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)







        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        result = 0
        Dim acum As Integer
        acum = 0
        Dim Number As Integer

        For i As Integer = 1 To Int32.Parse(TextBox1.Text, Number)

            If i = 1 Then
                result = 1
                acum += result

            Else
                result = acum + 1
                acum += result
            End If

        Next

        MessageBox.Show("The total earned is: " + acum.ToString + vbCrLf + "The value for the day is: " + result.ToString)
        Label4.Text = "The total earned is: " + acum.ToString + vbCrLf + "The value for the day is: " + result.ToString







    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.TextChanged
        MessageBox.Show("the Payment was written")



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        MessageBox.Show("Thank you for your approval")
        PlayBackgroundSoundFile()


    End Sub

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\Users\Usuario\Documents\Visual Studio 2015\Projects\final exam\a.wav")
    End Sub
End Class
