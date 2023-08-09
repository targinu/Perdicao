<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_visualizar
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
        Me.lbl_nome_produto = New System.Windows.Forms.Label()
        Me.img_visualizar = New System.Windows.Forms.PictureBox()
        Me.lbl_preco = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_voltar_loja = New System.Windows.Forms.Button()
        CType(Me.img_visualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DO PRODUTO"
        '
        'lbl_nome_produto
        '
        Me.lbl_nome_produto.AutoSize = True
        Me.lbl_nome_produto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome_produto.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_produto.Location = New System.Drawing.Point(212, 36)
        Me.lbl_nome_produto.Name = "lbl_nome_produto"
        Me.lbl_nome_produto.Size = New System.Drawing.Size(95, 25)
        Me.lbl_nome_produto.TabIndex = 1
        Me.lbl_nome_produto.Text = "nome aqui"
        '
        'img_visualizar
        '
        Me.img_visualizar.Location = New System.Drawing.Point(12, 12)
        Me.img_visualizar.Name = "img_visualizar"
        Me.img_visualizar.Size = New System.Drawing.Size(194, 179)
        Me.img_visualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_visualizar.TabIndex = 2
        Me.img_visualizar.TabStop = False
        '
        'lbl_preco
        '
        Me.lbl_preco.AutoSize = True
        Me.lbl_preco.BackColor = System.Drawing.Color.Transparent
        Me.lbl_preco.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco.Location = New System.Drawing.Point(212, 141)
        Me.lbl_preco.Name = "lbl_preco"
        Me.lbl_preco.Size = New System.Drawing.Size(96, 25)
        Me.lbl_preco.TabIndex = 4
        Me.lbl_preco.Text = "preço aqui"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PREÇO"
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.BackColor = System.Drawing.Color.Transparent
        Me.lbl_categoria.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(314, 141)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(125, 25)
        Me.lbl_categoria.TabIndex = 6
        Me.lbl_categoria.Text = "categoria aqui"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CATEGORIA"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descricao.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descricao.Location = New System.Drawing.Point(12, 218)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(128, 25)
        Me.lbl_descricao.TabIndex = 9
        Me.lbl_descricao.Text = "descrição aqui"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DESCRIÇÃO"
        '
        'btn_voltar_loja
        '
        Me.btn_voltar_loja.Location = New System.Drawing.Point(12, 385)
        Me.btn_voltar_loja.Name = "btn_voltar_loja"
        Me.btn_voltar_loja.Size = New System.Drawing.Size(75, 33)
        Me.btn_voltar_loja.TabIndex = 10
        Me.btn_voltar_loja.Text = "VOLTAR"
        Me.btn_voltar_loja.UseVisualStyleBackColor = True
        '
        'frm_visualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sexshop_perdicao.My.Resources.Resources.sexshop_logo_coracao1
        Me.ClientSize = New System.Drawing.Size(598, 430)
        Me.Controls.Add(Me.btn_voltar_loja)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_preco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.img_visualizar)
        Me.Controls.Add(Me.lbl_nome_produto)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_visualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.img_visualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nome_produto As System.Windows.Forms.Label
    Friend WithEvents img_visualizar As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_preco As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_categoria As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_descricao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_voltar_loja As System.Windows.Forms.Button
End Class
