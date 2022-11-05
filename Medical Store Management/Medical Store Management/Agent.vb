Imports System.Data.OleDb
Public Class Agent
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("Select * From AgentTBL", cn)
        adp.Fill(ds)
        DataGridViewAgent.DataSource = ds.Tables(0)
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are You Really Want To Close App?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        EmpID.Clear()
        EmpName.Clear()
        EmpAge.Clear()
        EmpPhone.Clear()
        EmpSal.Clear()
        EmpPass.Clear()
    End Sub

    Private Sub Agent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Database.accdb"
        cn.Open()
        display()
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim str As String
            str = "Insert into AgentTBL values(" & EmpID.Text & ",'" & EmpName.Text & "'," & EmpSal.Text & "," & EmpAge.Text & "," & EmpPhone.Text & ",'" & EmpPass.Text & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Agent Successfully Inserted")
            display()
        Catch ex As Exception
            MsgBox("Record Can't Inserted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If EmpName.Text = "" Then
                MsgBox("No Agent Selected")
            Else
                cn.Open()
                Dim str As String
                str = "Delete From AgentTBL Where EmpName='" & EmpName.Text & "'"
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Agent Successfully Deleted")
                display()
            End If
        Catch ex As Exception
            MsgBox("Record Can't Deleted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If EmpName.Text = "" Or EmpID.Text = "" Or EmpAge.Text = "" Or EmpPass.Text = "" Or EmpPhone.Text = "" Or EmpSal.Text = "" Then
                MsgBox("Incomplete Data")
            Else
                cn.Open()
                Dim str As String
                str = "Update AgentTBL set EmpName='" & EmpName.Text & "',EmpAge=" & EmpAge.Text & ",EmpSal=" & EmpSal.Text & ",EmpPhone=" & EmpPhone.Text & ",EmpPass='" & EmpPass.Text & "'where Empid=" & EmpID.Text & ""
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Agent Successfully Updated")
                display()
            End If
        Catch ex As Exception
            MsgBox("Record Can't Updated")
        End Try
            cn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            cn.Open()
            Dim str As String
            str = "select * from AgentTBL where EmpName='" & EmpName.Text & "'"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                EmpName.Text = dr("EmpName")
                EmpID.Text = dr("Empid")
                EmpAge.Text = dr("EmpAge")
                EmpPhone.Text = dr("EmpPhone")
                EmpSal.Text = dr("EmpSal")
                EmpPass.Text = dr("EmpPass")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub

End Class