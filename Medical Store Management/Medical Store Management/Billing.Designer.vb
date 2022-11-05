<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BillGV = New System.Windows.Forms.DataGridView
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MedCB = New System.Windows.Forms.ComboBox
        Me.Stock = New System.Windows.Forms.Label
        Me.Qty = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Total = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.QtyA = New System.Windows.Forms.TextBox
        Me.rupees = New System.Windows.Forms.TextBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BillGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 19)
        Me.Panel2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(225, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Powered By Rana Corporation®"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 100)
        Me.Panel1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(678, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(322, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Billing"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Medical Store™"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(15, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Billing Form"
        '
        'BillGV
        '
        Me.BillGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BillGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        Me.BillGV.EnableHeadersVisualStyles = False
        Me.BillGV.Location = New System.Drawing.Point(169, 121)
        Me.BillGV.Name = "BillGV"
        Me.BillGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BillGV.Size = New System.Drawing.Size(522, 338)
        Me.BillGV.TabIndex = 28
        '
        'C1
        '
        Me.C1.HeaderText = "ID"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        '
        'C2
        '
        Me.C2.HeaderText = "MedName"
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        '
        'C3
        '
        Me.C3.HeaderText = "Quantity"
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        '
        'C4
        '
        Me.C4.HeaderText = "UnitPrice"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        '
        'C5
        '
        Me.C5.HeaderText = "TotalPrice"
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        '
        'MedCB
        '
        Me.MedCB.FormattingEnabled = True
        Me.MedCB.Location = New System.Drawing.Point(15, 162)
        Me.MedCB.Name = "MedCB"
        Me.MedCB.Size = New System.Drawing.Size(143, 21)
        Me.MedCB.TabIndex = 29
        Me.MedCB.Text = "Select Medicine"
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock.ForeColor = System.Drawing.Color.Navy
        Me.Stock.Location = New System.Drawing.Point(14, 212)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(112, 18)
        Me.Stock.TabIndex = 3
        Me.Stock.Text = "Availabel Stock:"
        '
        'Qty
        '
        Me.Qty.Location = New System.Drawing.Point(22, 264)
        Me.Qty.Multiline = True
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(124, 23)
        Me.Qty.TabIndex = 30
        Me.Qty.Text = "Quantity"
        Me.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(38, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 25)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Add To Bill"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(38, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 25)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Back"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Navy
        Me.Total.Location = New System.Drawing.Point(366, 462)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(33, 20)
        Me.Total.TabIndex = 33
        Me.Total.Text = "Rs:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(38, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 25)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Print"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'QtyA
        '
        Me.QtyA.BackColor = System.Drawing.SystemColors.Window
        Me.QtyA.Location = New System.Drawing.Point(123, 213)
        Me.QtyA.Multiline = True
        Me.QtyA.Name = "QtyA"
        Me.QtyA.Size = New System.Drawing.Size(35, 19)
        Me.QtyA.TabIndex = 35
        Me.QtyA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rupees
        '
        Me.rupees.BackColor = System.Drawing.SystemColors.Window
        Me.rupees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rupees.ForeColor = System.Drawing.Color.DarkBlue
        Me.rupees.Location = New System.Drawing.Point(396, 461)
        Me.rupees.Multiline = True
        Me.rupees.Name = "rupees"
        Me.rupees.Size = New System.Drawing.Size(63, 22)
        Me.rupees.TabIndex = 36
        Me.rupees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 504)
        Me.Controls.Add(Me.rupees)
        Me.Controls.Add(Me.QtyA)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Qty)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.MedCB)
        Me.Controls.Add(Me.BillGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BillGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BillGV As System.Windows.Forms.DataGridView
    Friend WithEvents MedCB As System.Windows.Forms.ComboBox
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents Qty As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyA As System.Windows.Forms.TextBox
    Friend WithEvents rupees As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
