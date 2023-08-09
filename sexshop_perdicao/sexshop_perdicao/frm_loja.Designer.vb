<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loja
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loja))
        Me.dgv_loja = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPRAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_loja = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar_loja = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_categoria_loja = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_esvaziar = New System.Windows.Forms.Button()
        Me.btn_confirmar_compra = New System.Windows.Forms.Button()
        Me.lbl_valor_total = New System.Windows.Forms.Label()
        Me.lbl_desconto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cupom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_carrinho = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_usuario_loja = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_data = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_hora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_sair_loja = New System.Windows.Forms.ToolStripButton()
        Me.lbl_sair_loja = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_loja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_loja.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_loja
        '
        Me.dgv_loja.AllowUserToAddRows = False
        Me.dgv_loja.AllowUserToDeleteRows = False
        Me.dgv_loja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_loja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_loja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.PREÇO, Me.Column3, Me.COMPRAR})
        Me.dgv_loja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_loja.Location = New System.Drawing.Point(3, 28)
        Me.dgv_loja.Name = "dgv_loja"
        Me.dgv_loja.ReadOnly = True
        Me.dgv_loja.Size = New System.Drawing.Size(525, 238)
        Me.dgv_loja.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUTO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 182
        '
        'PREÇO
        '
        Me.PREÇO.HeaderText = "PREÇO"
        Me.PREÇO.Name = "PREÇO"
        Me.PREÇO.ReadOnly = True
        Me.PREÇO.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "CATEGORIA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'COMPRAR
        '
        Me.COMPRAR.HeaderText = "COMPRAR"
        Me.COMPRAR.Image = Global.sexshop_perdicao.My.Resources.Resources.Add_Cart_icon
        Me.COMPRAR.Name = "COMPRAR"
        Me.COMPRAR.ReadOnly = True
        '
        'tab_loja
        '
        Me.tab_loja.Controls.Add(Me.TabPage1)
        Me.tab_loja.Controls.Add(Me.TabPage2)
        Me.tab_loja.Location = New System.Drawing.Point(6, 28)
        Me.tab_loja.Name = "tab_loja"
        Me.tab_loja.SelectedIndex = 0
        Me.tab_loja.Size = New System.Drawing.Size(539, 295)
        Me.tab_loja.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_loja)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(531, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LOJA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_buscar_loja, Me.ToolStripLabel2, Me.cmb_categoria_loja})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(525, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel1.Text = "BUSQUE UM PRODUTO:"
        '
        'txt_buscar_loja
        '
        Me.txt_buscar_loja.Name = "txt_buscar_loja"
        Me.txt_buscar_loja.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel2.Text = "SELECIONE:"
        '
        'cmb_categoria_loja
        '
        Me.cmb_categoria_loja.Name = "cmb_categoria_loja"
        Me.cmb_categoria_loja.Size = New System.Drawing.Size(121, 25)
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.sexshop_perdicao.My.Resources.Resources.sexshop_logo_coracao1
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btn_esvaziar)
        Me.TabPage2.Controls.Add(Me.btn_confirmar_compra)
        Me.TabPage2.Controls.Add(Me.lbl_valor_total)
        Me.TabPage2.Controls.Add(Me.lbl_desconto)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lbl_cupom)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dgv_carrinho)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(531, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CARRINHO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "R$"
        '
        'btn_esvaziar
        '
        Me.btn_esvaziar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esvaziar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_esvaziar.Location = New System.Drawing.Point(6, 231)
        Me.btn_esvaziar.Name = "btn_esvaziar"
        Me.btn_esvaziar.Size = New System.Drawing.Size(170, 32)
        Me.btn_esvaziar.TabIndex = 9
        Me.btn_esvaziar.Text = "ESVAZIAR CARRINHO"
        Me.btn_esvaziar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_esvaziar.UseVisualStyleBackColor = True
        '
        'btn_confirmar_compra
        '
        Me.btn_confirmar_compra.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_compra.Image = Global.sexshop_perdicao.My.Resources.Resources.Full_Cart_icon
        Me.btn_confirmar_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar_compra.Location = New System.Drawing.Point(330, 231)
        Me.btn_confirmar_compra.Name = "btn_confirmar_compra"
        Me.btn_confirmar_compra.Size = New System.Drawing.Size(195, 32)
        Me.btn_confirmar_compra.TabIndex = 8
        Me.btn_confirmar_compra.Text = "CONFIRMAR COMPRA"
        Me.btn_confirmar_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar_compra.UseVisualStyleBackColor = True
        '
        'lbl_valor_total
        '
        Me.lbl_valor_total.AutoSize = True
        Me.lbl_valor_total.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor_total.Location = New System.Drawing.Point(373, 25)
        Me.lbl_valor_total.Name = "lbl_valor_total"
        Me.lbl_valor_total.Size = New System.Drawing.Size(14, 16)
        Me.lbl_valor_total.TabIndex = 7
        Me.lbl_valor_total.Text = "0"
        Me.lbl_valor_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_desconto
        '
        Me.lbl_desconto.AutoSize = True
        Me.lbl_desconto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desconto.Location = New System.Drawing.Point(373, 133)
        Me.lbl_desconto.Name = "lbl_desconto"
        Me.lbl_desconto.Size = New System.Drawing.Size(14, 16)
        Me.lbl_desconto.TabIndex = 6
        Me.lbl_desconto.Text = "0"
        Me.lbl_desconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DESCONTO DISPONIVEL"
        '
        'lbl_cupom
        '
        Me.lbl_cupom.AutoSize = True
        Me.lbl_cupom.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cupom.ForeColor = System.Drawing.Color.Red
        Me.lbl_cupom.Location = New System.Drawing.Point(439, 25)
        Me.lbl_cupom.Name = "lbl_cupom"
        Me.lbl_cupom.Size = New System.Drawing.Size(64, 16)
        Me.lbl_cupom.TabIndex = 4
        Me.lbl_cupom.Text = "Indisponível"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CUPOM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL"
        '
        'dgv_carrinho
        '
        Me.dgv_carrinho.AllowUserToAddRows = False
        Me.dgv_carrinho.AllowUserToDeleteRows = False
        Me.dgv_carrinho.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column4, Me.Column6})
        Me.dgv_carrinho.Location = New System.Drawing.Point(3, 6)
        Me.dgv_carrinho.Name = "dgv_carrinho"
        Me.dgv_carrinho.ReadOnly = True
        Me.dgv_carrinho.Size = New System.Drawing.Size(345, 150)
        Me.dgv_carrinho.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "PRODUTO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "PREÇO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "QUANTIDADE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_usuario_loja, Me.ToolStripStatusLabel2, Me.lbl_data, Me.ToolStripStatusLabel4, Me.lbl_hora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(545, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "USUÁRIO:"
        '
        'lbl_usuario_loja
        '
        Me.lbl_usuario_loja.Name = "lbl_usuario_loja"
        Me.lbl_usuario_loja.Size = New System.Drawing.Size(119, 17)
        Me.lbl_usuario_loja.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel2.Text = "DATA:"
        '
        'lbl_data
        '
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(119, 17)
        Me.lbl_data.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel4.Text = "HORA:"
        '
        'lbl_hora
        '
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(119, 17)
        Me.lbl_hora.Text = "ToolStripStatusLabel5"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_sair_loja, Me.lbl_sair_loja})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(545, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_sair_loja
        '
        Me.btn_sair_loja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_sair_loja.Image = Global.sexshop_perdicao.My.Resources.Resources.exit_icon
        Me.btn_sair_loja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_sair_loja.Name = "btn_sair_loja"
        Me.btn_sair_loja.Size = New System.Drawing.Size(23, 22)
        Me.btn_sair_loja.Text = "ToolStripButton1"
        '
        'lbl_sair_loja
        '
        Me.lbl_sair_loja.Name = "lbl_sair_loja"
        Me.lbl_sair_loja.Size = New System.Drawing.Size(31, 22)
        Me.lbl_sair_loja.Text = "SAIR"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "COMPRAR"
        Me.DataGridViewImageColumn1.Image = Global.sexshop_perdicao.My.Resources.Resources.Add_Cart_icon
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "R$"
        '
        'frm_loja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 354)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tab_loja)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_loja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEXSHOP PERDIÇÃO"
        CType(Me.dgv_loja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_loja.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_loja As System.Windows.Forms.DataGridView
    Friend WithEvents tab_loja As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_buscar_loja As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmb_categoria_loja As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_usuario_loja As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_data As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_hora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_sair_loja As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_sair_loja As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgv_carrinho As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_desconto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cupom As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PREÇO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMPRAR As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_valor_total As System.Windows.Forms.Label
    Friend WithEvents btn_esvaziar As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar_compra As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
