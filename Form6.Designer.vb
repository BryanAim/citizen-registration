<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(86, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "(For countries without IBAN format)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(86, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "(For countries with IBAN format only)"
        '
        'TextBox24
        '
        Me.TextBox24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox24.Location = New System.Drawing.Point(388, 128)
        Me.TextBox24.Multiline = True
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(250, 42)
        Me.TextBox24.TabIndex = 150
        Me.TextBox24.Text = "CODE SWIFT (BIC)"
        '
        'TextBox29
        '
        Me.TextBox29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox29.Location = New System.Drawing.Point(86, 234)
        Me.TextBox29.Multiline = True
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(250, 40)
        Me.TextBox29.TabIndex = 149
        Me.TextBox29.Text = "BANK ACCOUNT NUMBER"
        '
        'TextBox30
        '
        Me.TextBox30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox30.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox30.Location = New System.Drawing.Point(388, 234)
        Me.TextBox30.Multiline = True
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(250, 42)
        Me.TextBox30.TabIndex = 148
        Me.TextBox30.Text = "BANK NAME"
        '
        'TextBox11
        '
        Me.TextBox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox11.Location = New System.Drawing.Point(86, 128)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(250, 42)
        Me.TextBox11.TabIndex = 145
        Me.TextBox11.Text = "IBAN"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(1229, 314)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 33)
        Me.Button4.TabIndex = 144
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(762, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 33)
        Me.Button5.TabIndex = 143
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(609, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(195, 28)
        Me.Label23.TabIndex = 142
        Me.Label23.Text = "Citizen's Bank Details"
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(1064, 128)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 42)
        Me.TextBox1.TabIndex = 157
        Me.TextBox1.Text = "Number"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox7.Location = New System.Drawing.Point(762, 234)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(250, 40)
        Me.TextBox7.TabIndex = 156
        Me.TextBox7.Text = "TOWN / CITY"
        '
        'TextBox8
        '
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox8.Location = New System.Drawing.Point(1064, 234)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(250, 42)
        Me.TextBox8.TabIndex = 155
        Me.TextBox8.Text = "COUNTRY"
        '
        'TextBox9
        '
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox9.Location = New System.Drawing.Point(762, 128)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(250, 42)
        Me.TextBox9.TabIndex = 154
        Me.TextBox9.Text = "Street"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(964, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(977, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Bank Address"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1363, 660)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.TextBox29)
        Me.Controls.Add(Me.TextBox30)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form6"
        Me.Text = "Citizen Bank Details form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
