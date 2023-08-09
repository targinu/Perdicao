<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DE USUARIO OU EMAIL"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(15, 325)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(286, 22)
        Me.txt_login.TabIndex = 1
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_login.Location = New System.Drawing.Point(15, 369)
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_login.Size = New System.Drawing.Size(178, 22)
        Me.txt_senha_login.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SENHA"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(15, 397)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(178, 22)
        Me.btn_cadastrar.TabIndex = 5
        Me.btn_cadastrar.Text = "CRIAR NOVA CONTA"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'btn_entrar
        '
        Me.btn_entrar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Location = New System.Drawing.Point(199, 397)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(102, 22)
        Me.btn_entrar.TabIndex = 6
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sexshop_perdicao.My.Resources.Resources.sexshop_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 291)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'chk_visualizar
        '
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visualizar.Location = New System.Drawing.Point(199, 371)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(104, 20)
        Me.chk_visualizar.TabIndex = 7
        Me.chk_visualizar.Text = "Visualizar senha"
        Me.chk_visualizar.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(313, 448)
        Me.Controls.Add(Me.chk_visualizar)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents txt_senha_login As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_entrar As System.Windows.Forms.Button
    Friend WithEvents chk_visualizar As System.Windows.Forms.CheckBox
End Class
