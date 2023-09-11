<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalespeople = New System.Windows.Forms.TextBox()
        Me.txtAllowance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number of salespeople:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Expense allowance:"
        '
        'txtSalespeople
        '
        Me.txtSalespeople.Location = New System.Drawing.Point(151, 24)
        Me.txtSalespeople.Name = "txtSalespeople"
        Me.txtSalespeople.Size = New System.Drawing.Size(51, 31)
        Me.txtSalespeople.TabIndex = 1
        '
        'txtAllowance
        '
        Me.txtAllowance.Location = New System.Drawing.Point(12, 95)
        Me.txtAllowance.Name = "txtAllowance"
        Me.txtAllowance.Size = New System.Drawing.Size(75, 31)
        Me.txtAllowance.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(151, 95)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(75, 22)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(254, 23)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 28)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(254, 54)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 28)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 158)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAllowance)
        Me.Controls.Add(Me.txtSalespeople)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kramden Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalespeople As TextBox
    Friend WithEvents txtAllowance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
