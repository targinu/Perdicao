<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(18, 45)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(148, 35)
        Me.txt_cpf.TabIndex = 1
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(405, 45)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(150, 35)
        Me.cmb_data_nasc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DATA NASC."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOME "
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(18, 116)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(537, 35)
        Me.txt_nome.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(18, 186)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(104, 35)
        Me.txt_cep.TabIndex = 7
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(128, 186)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(427, 35)
        Me.txt_endereco.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ENDEREÇO"
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.Location = New System.Drawing.Point(17, 257)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(105, 35)
        Me.txt_comp.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "COMP."
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(128, 257)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(142, 35)
        Me.txt_bairro.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "BAIRRO"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(276, 257)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(210, 35)
        Me.txt_cidade.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(271, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "CIDADE"
        '
        'txt_uf
        '
        Me.txt_uf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.Location = New System.Drawing.Point(492, 257)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(63, 35)
        Me.txt_uf.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(487, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "UF"
        '
        'txt_celular
        '
        Me.txt_celular.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(18, 327)
        Me.txt_celular.Mask = " (00)00000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(156, 35)
        Me.txt_celular.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "CELULAR"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(180, 327)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(375, 35)
        Me.txt_email.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(175, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "E-MAIL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 29)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "SENHA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(290, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 29)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "REPETIR SENHA"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(18, 397)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(260, 35)
        Me.txt_senha.TabIndex = 25
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha.Location = New System.Drawing.Point(284, 397)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rsenha.Size = New System.Drawing.Size(271, 35)
        Me.txt_rsenha.TabIndex = 26
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(336, 438)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(219, 34)
        Me.btn_cadastrar.TabIndex = 27
        Me.btn_cadastrar.Text = "CADASTRAR-SE"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(18, 438)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(120, 34)
        Me.btn_voltar.TabIndex = 28
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 480)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_rsenha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_data_nasc)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOVA CONTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_data_nasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_comp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_uf As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents txt_rsenha As System.Windows.Forms.TextBox
    Friend WithEvents btn_cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
End Class
