Public Class Info

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are You Really Want To Close App?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class