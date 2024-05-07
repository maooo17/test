<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PRICETextBox2 = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox3 = New System.Windows.Forms.TextBox()
        Me.ADDBUTTON = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(495, 272)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(234, 87)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "CLOSE"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 49)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTextBox1
        '
        Me.nameTextBox1.Location = New System.Drawing.Point(356, 36)
        Me.nameTextBox1.Name = "nameTextBox1"
        Me.nameTextBox1.Size = New System.Drawing.Size(245, 32)
        Me.nameTextBox1.TabIndex = 2
        '
        'PRICETextBox2
        '
        Me.PRICETextBox2.Location = New System.Drawing.Point(356, 103)
        Me.PRICETextBox2.Name = "PRICETextBox2"
        Me.PRICETextBox2.Size = New System.Drawing.Size(245, 32)
        Me.PRICETextBox2.TabIndex = 2
        '
        'QuantityTextBox3
        '
        Me.QuantityTextBox3.Location = New System.Drawing.Point(356, 162)
        Me.QuantityTextBox3.Name = "QuantityTextBox3"
        Me.QuantityTextBox3.Size = New System.Drawing.Size(245, 32)
        Me.QuantityTextBox3.TabIndex = 2
        '
        'ADDBUTTON
        '
        Me.ADDBUTTON.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDBUTTON.Location = New System.Drawing.Point(221, 272)
        Me.ADDBUTTON.Margin = New System.Windows.Forms.Padding(6)
        Me.ADDBUTTON.Name = "ADDBUTTON"
        Me.ADDBUTTON.Size = New System.Drawing.Size(234, 87)
        Me.ADDBUTTON.TabIndex = 0
        Me.ADDBUTTON.Text = "ADD"
        Me.ADDBUTTON.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 470)
        Me.Controls.Add(Me.QuantityTextBox3)
        Me.Controls.Add(Me.PRICETextBox2)
        Me.Controls.Add(Me.nameTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ADDBUTTON)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nameTextBox1 As TextBox
    Friend WithEvents PRICETextBox2 As TextBox
    Friend WithEvents QuantityTextBox3 As TextBox
    Friend WithEvents ADDBUTTON As Button
End Class
