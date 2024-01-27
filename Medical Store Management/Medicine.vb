Imports System.Data.OleDb
'Object Linking and Embedding Database
Public Class Medicine
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("Select * From MedicineTBL", cn)
        adp.Fill(ds)
        DataGridViewMedicine.DataSource = ds.Tables(0)
    End Sub

    Public Sub FillCombo()
        Dim cmd As New OleDbCommand("Select * From CompanyTBL", cn)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataTable()
        adp.Fill(ds)
        CompanyCB.DataSource = ds
        CompanyCB.DisplayMember = "CompName"
        CompanyCB.ValueMember = "CompName"
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

    Private Sub Medicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Database.accdb"
        cn.open()
        FillCombo()
        display()
        cn.close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim str As String
            str = "Insert into MedicineTBL values('" & MedName.Text & "'," & BPrice.Text & "," & SPrice.Text & "," & MedQty.Text & ",'" & ExpDate.Text & "','" & CompanyCB.SelectedValue.ToString & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Added")
            display()
        Catch ex As Exception
            MsgBox("Record Can't Inserted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If MedName.Text = "" Then
                MsgBox("No Medicine Selected")
            Else
                cn.Open()
                Dim str As String
                str = "Delete From MedicineTBL Where MedName='" & MedName.Text & "'"
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Medicine Successfully Deleted")
                display()
            End If
        Catch ex As Exception
            MsgBox("Record Can't Deleted")
        End Try
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If MedName.Text = "" Or BPrice.Text = "" Or SPrice.Text = "" Or MedQty.Text = "" Then
                MsgBox("Incomplete Data")
            Else
                cn.Open()
                Dim str As String
                str = "Update MedicineTBL set BPrice=" & BPrice.Text & ",SPrice=" & SPrice.Text & ",MedQty=" & MedQty.Text & ",ExpDate='" & ExpDate.Text & "',Company='" & CompanyCB.Text & "' where MedName='" & MedName.Text & "' "
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Medicine Successfully Updated")
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
            str = "select * from MedicineTBL where MedName='" & MedName.Text & "'"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                MedName.Text = dr("MedName")
                BPrice.Text = dr("Bprice")
                SPrice.Text = dr("Sprice")
                MedQty.Text = dr("MedQty")
                ExpDate.Text = dr("ExpDate")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        MedName.Clear()
        MedQty.Clear()
        BPrice.Clear()
        SPrice.Clear()
    End Sub

  
End Class