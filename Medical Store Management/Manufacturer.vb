Imports System.Data.OleDb
'Object Linking and Embedding Database
Public Class Manufacturer
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("Select * From CompanyTBL", cn)
        adp.Fill(ds)
        DataGridViewCom.DataSource = ds.Tables(0)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are You Really Want To Close App?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Manufacturer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Database.accdb"
        cn.Open()
        display()
        cn.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            cn.Open()
            Dim str As String
            str = "Insert into CompanyTBL values(" & CompID.Text & ",'" & CompName.Text & "'," & CompPhn.Text & ",'" & CompCity.Text & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Company Successfully Added")
            display()
        Catch ex As Exception
            MsgBox("Record Can't Inserted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If CompName.Text = "" Then
                MsgBox("No Company Selected")
            Else
                cn.Open()
                Dim str As String
                str = "Delete From CompanyTBL Where CompName='" & CompName.Text & "'"
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Company Successfully Deleted")
                display()
            End If
        Catch ex As Exception
            MsgBox("Record Can't Deleted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If CompID.Text = "" Or CompName.Text = "" Or CompPhn.Text = "" Or CompCity.Text = "" Then
                MsgBox("Incomplete Data")
            Else
                cn.Open()
                Dim str As String
                str = "Update CompanyTBL set CompName='" & CompName.Text & "',CompPhone=" & CompPhn.Text & ",CompCity='" & CompCity.Text & "' where CompID=" & CompID.Text & ""
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Company Successfully Updated")
                display()
            End If
        Catch ex As Exception
            MsgBox("Record Can't Updated")
        End Try
        cn.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim str As String
            str = "select * from CompanyTBL where CompName='" & CompName.Text & "'"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                CompID.Text = dr("CompID")
                CompName.Text = dr("CompName")
                CompPhn.Text = dr("CompPhone")
                CompCity.Text = dr("CompCity")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        CompID.Clear()
        CompName.Clear()
        CompPhn.Clear()
        CompCity.Clear()
    End Sub

End Class