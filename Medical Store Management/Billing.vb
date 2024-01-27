Imports System.Data.OleDb
'Object Linking and Embedding Database
Public Class Billing
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Database.accdb")
    Dim cmd As OleDbCommand
    Public Sub FillCombo()
        Dim cmd As New OleDbCommand("Select * From MedicineTBL", cn)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataTable()
        adp.Fill(ds)
        MedCB.DataSource = ds
        MedCB.DisplayMember = "MedName"
        MedCB.ValueMember = "MedName"
    End Sub
    Dim uprice
    Private Sub FetchQty()
        cn.Open()
        Dim qry = "Select * from MedicineTBL where MedName='" & MedCB.SelectedValue.ToString() & "'"
        Dim cmd As New OleDbCommand(qry, cn)
        Dim dt As New DataTable
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()

        While dr.Read
            uprice = dr(2)
            QtyA.Text = dr(3)
        End While
        cn.Close()
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are You Really Want To Close App?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub MedCB_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedCB.SelectionChangeCommitted
        FetchQty()
    End Sub
    Private Sub updateqty()
        Dim a As Integer
        a = Val(QtyA.Text) - Val(Qty.Text)
        cn.Open()
        Dim str As String
        str = "Update MedicineTBL set MedQty=" & a & " where Medname='" & MedCB.Text & "'"
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Dim i = 0, totprice
    Dim grtotal = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = Qty.Text
        b = QtyA.Text

        If a > b Then
            MsgBox("Not Enough Stock")
        ElseIf Qty.Text = "" Then
            MsgBox("Please Enter A Quantity")
        Else
            Dim rnum As Integer = BillGV.Rows.Add()
            i = i + 1
            BillGV.Rows.Item(rnum).Cells("C1").Value = i
            BillGV.Rows.Item(rnum).Cells("C2").Value = MedCB.SelectedValue.ToString()
            BillGV.Rows.Item(rnum).Cells("C3").Value = Qty.Text
            BillGV.Rows.Item(rnum).Cells("C4").Value = uprice
            BillGV.Rows.Item(rnum).Cells("C5").Value = Qty.Text * uprice
            Dim subtot = Qty.Text * uprice
            grtotal = grtotal + subtot
            rupees.Text = grtotal.ToString()
            QtyA.Text = Val(QtyA.Text) - Val(Qty.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        updateqty()

        cn.Open()
        Dim str As String
        Dim a
        a = Qty.Text * uprice
        str = "Insert into BillingTBL(MedName,Qty,Uprice,TotalPrice) values('" & MedCB.SelectedValue.ToString & "'," & Qty.Text & "," & uprice & "," & a & ")"
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.BillGV.Width, Me.BillGV.Height)
        e.Graphics.DrawString("Medical Store™", New Font("Arial", 25, FontStyle.Bold), Brushes.DarkBlue, New Point(290, 20))
        e.Graphics.DrawString("Invoice", New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, New Point(385, 60))
        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(40, 100))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(40, 120))
        BillGV.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.BillGV.Width, Me.BillGV.Height))
        e.Graphics.DrawImage(imagebmp, 150, 150)
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(40, 510))
        e.Graphics.DrawString("Total Amount:", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(50, 535))
        e.Graphics.DrawString("Rs:" + rupees.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(700, 535))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(40, 560))
    End Sub


End Class