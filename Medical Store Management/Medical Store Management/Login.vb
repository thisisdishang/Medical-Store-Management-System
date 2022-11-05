Imports System.Data.OleDb
Public Class Login

    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Database.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If uname.Text = Nothing Or pass.Text = Nothing Then
            MessageBox.Show("Please Enter Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cn.Open()
        Using Command As New OleDbCommand("Select count(*) from AgentTBL where EmpName=@uname And EmpPass=@pass", cn)
            Command.Parameters.AddWithValue("@uname", OleDbType.VarChar).Value = uname.Text.Trim
            Command.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = pass.Text.Trim
            Dim count = Convert.ToInt32(Command.ExecuteScalar())
            If count > 0 Then
                MsgBox("Login Found!Welcome " + uname.Text)
                Me.Hide()
                Dim home = New Home
                home.Show()
            Else
                MsgBox("Oops!Invalid Username Or Password")
            End If
        End Using
        cn.Close()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        uname.Clear()
        pass.Clear()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are You Really Want To Close App?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class