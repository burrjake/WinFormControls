Public Class WInFormControlsForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If ExamplePictureBox.Visible = False Then
            ExamplePictureBox.Show()
            ExitButton.Enabled = False
        Else
            ExamplePictureBox.Hide()
            ExitButton.Enabled = True
        End If
        If GroupOne1RadioButton.Checked = True Then
            ExamplePictureBox.BackgroundImage = My.Resources.Waveform2_10
        Else
            ExamplePictureBox.Hide()
        End If
    End Sub
End Class
