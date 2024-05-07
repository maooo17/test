<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.USER = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.LOGINBUTTON = New System.Windows.Forms.Button()
        Me.CLOSEBUTTON = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'USER
        '
        Me.USER.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER.Location = New System.Drawing.Point(434, 206)
        Me.USER.Name = "USER"
        Me.USER.Size = New System.Drawing.Size(308, 49)
        Me.USER.TabIndex = 3
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(434, 280)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(308, 49)
        Me.password.TabIndex = 4
        '
        'LOGINBUTTON
        '
        Me.LOGINBUTTON.Location = New System.Drawing.Point(178, 370)
        Me.LOGINBUTTON.Name = "LOGINBUTTON"
        Me.LOGINBUTTON.Size = New System.Drawing.Size(127, 40)
        Me.LOGINBUTTON.TabIndex = 6
        Me.LOGINBUTTON.Text = "LOG IN"
        Me.LOGINBUTTON.UseVisualStyleBackColor = True
        '
        'CLOSEBUTTON
        '
        Me.CLOSEBUTTON.Location = New System.Drawing.Point(543, 370)
        Me.CLOSEBUTTON.Name = "CLOSEBUTTON"
        Me.CLOSEBUTTON.Size = New System.Drawing.Size(127, 40)
        Me.CLOSEBUTTON.TabIndex = 6
        Me.CLOSEBUTTON.Text = "CLOSE"
        Me.CLOSEBUTTON.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.CLOSEBUTTON)
        Me.Panel1.Controls.Add(Me.LOGINBUTTON)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.USER)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 483)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp4.My.Resources.Resources._118844979_111022414066274_1438237637059554697_n
        Me.PictureBox1.Location = New System.Drawing.Point(9, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(803, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 467)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents USER As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents LOGINBUTTON As Button
    Friend WithEvents CLOSEBUTTON As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
