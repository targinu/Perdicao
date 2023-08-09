<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_produtos))
        Me.abrir_foto = New System.Windows.Forms.OpenFileDialog()
        Me.tab_cadastro_produtos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.txt_preco_produto = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_descr_produto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_produtos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmb_busca_categoria = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca_produto = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_produtos = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_clientes = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca_cliente = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_clientes = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgv_realacao_vendas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btn_relatorio_vendas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_sair = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_cadastro_produtos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmb_busca_categoria.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgv_realacao_vendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'abrir_foto
        '
        Me.abrir_foto.FileName = "OpenFileDialog1"
        '
        'tab_cadastro_produtos
        '
        Me.tab_cadastro_produtos.Controls.Add(Me.TabPage1)
        Me.tab_cadastro_produtos.Controls.Add(Me.TabPage2)
        Me.tab_cadastro_produtos.Controls.Add(Me.TabPage3)
        Me.tab_cadastro_produtos.Controls.Add(Me.TabPage4)
        Me.tab_cadastro_produtos.Location = New System.Drawing.Point(12, 28)
        Me.tab_cadastro_produtos.Name = "tab_cadastro_produtos"
        Me.tab_cadastro_produtos.SelectedIndex = 0
        Me.tab_cadastro_produtos.Size = New System.Drawing.Size(644, 344)
        Me.tab_cadastro_produtos.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btn_gravar)
        Me.TabPage1.Controls.Add(Me.cmb_categoria)
        Me.TabPage1.Controls.Add(Me.txt_preco_produto)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_descr_produto)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_nome_produto)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.img_produto)
        Me.TabPage1.Controls.Add(Me.txt_id)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO DE PRODUTOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(512, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "FOTO DO PRODUTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CATEGORIA"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gravar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.Image = Global.sexshop_perdicao.My.Resources.Resources.save_icon
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gravar.Location = New System.Drawing.Point(473, 247)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(157, 57)
        Me.btn_gravar.TabIndex = 10
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Items.AddRange(New Object() {"Acessórios", "Cosméticos", "Fantasias e Lingeries", "Fetiche", "Vibradores"})
        Me.cmb_categoria.Location = New System.Drawing.Point(153, 265)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(288, 39)
        Me.cmb_categoria.TabIndex = 9
        '
        'txt_preco_produto
        '
        Me.txt_preco_produto.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco_produto.Location = New System.Drawing.Point(12, 265)
        Me.txt_preco_produto.Name = "txt_preco_produto"
        Me.txt_preco_produto.Size = New System.Drawing.Size(111, 38)
        Me.txt_preco_produto.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PREÇO"
        '
        'txt_descr_produto
        '
        Me.txt_descr_produto.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descr_produto.Location = New System.Drawing.Point(12, 190)
        Me.txt_descr_produto.Name = "txt_descr_produto"
        Me.txt_descr_produto.Size = New System.Drawing.Size(618, 38)
        Me.txt_descr_produto.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DESCRIÇÃO DO PRODUTO"
        '
        'txt_nome_produto
        '
        Me.txt_nome_produto.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_produto.Location = New System.Drawing.Point(12, 115)
        Me.txt_nome_produto.Name = "txt_nome_produto"
        Me.txt_nome_produto.Size = New System.Drawing.Size(429, 38)
        Me.txt_nome_produto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOME DO PRODUTO"
        '
        'img_produto
        '
        Me.img_produto.Image = Global.sexshop_perdicao.My.Resources.Resources.lub1
        Me.img_produto.Location = New System.Drawing.Point(507, 6)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(123, 122)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_produto.TabIndex = 2
        Me.img_produto.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(12, 40)
        Me.txt_id.Mask = "1999"
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(56, 38)
        Me.txt_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID DO PRODUTO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_dados_produtos)
        Me.TabPage2.Controls.Add(Me.cmb_busca_categoria)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCA AVANÇADA DE PRODUTOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_dados_produtos
        '
        Me.dgv_dados_produtos.AllowUserToAddRows = False
        Me.dgv_dados_produtos.AllowUserToDeleteRows = False
        Me.dgv_dados_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgv_dados_produtos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_dados_produtos.Location = New System.Drawing.Point(3, 28)
        Me.dgv_dados_produtos.Name = "dgv_dados_produtos"
        Me.dgv_dados_produtos.ReadOnly = True
        Me.dgv_dados_produtos.Size = New System.Drawing.Size(630, 287)
        Me.dgv_dados_produtos.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "PREÇO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "CATEGORIA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "EDITAR"
        Me.Column7.Image = Global.sexshop_perdicao.My.Resources.Resources.save2
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "EXCLUIR"
        Me.Column8.Image = Global.sexshop_perdicao.My.Resources.Resources.Industry_Trash_icon
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'cmb_busca_categoria
        '
        Me.cmb_busca_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmb_busca_categoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca_produto, Me.ToolStripLabel2, Me.cmb_tipo_produtos})
        Me.cmb_busca_categoria.Location = New System.Drawing.Point(3, 3)
        Me.cmb_busca_categoria.Name = "cmb_busca_categoria"
        Me.cmb_busca_categoria.Size = New System.Drawing.Size(630, 25)
        Me.cmb_busca_categoria.TabIndex = 0
        Me.cmb_busca_categoria.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel1.Text = "DIGITE UM PARAMÊTRO:"
        '
        'txt_busca_produto
        '
        Me.txt_busca_produto.Name = "txt_busca_produto"
        Me.txt_busca_produto.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel2.Text = "CATEGORIA"
        '
        'cmb_tipo_produtos
        '
        Me.cmb_tipo_produtos.Name = "cmb_tipo_produtos"
        Me.cmb_tipo_produtos.Size = New System.Drawing.Size(121, 25)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_dados_clientes)
        Me.TabPage3.Controls.Add(Me.ToolStrip2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(636, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BUSCA DE CLIENTES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_dados_clientes
        '
        Me.dgv_dados_clientes.AllowUserToAddRows = False
        Me.dgv_dados_clientes.AllowUserToDeleteRows = False
        Me.dgv_dados_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column9, Me.Column10, Me.Column12})
        Me.dgv_dados_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_dados_clientes.Location = New System.Drawing.Point(0, 25)
        Me.dgv_dados_clientes.Name = "dgv_dados_clientes"
        Me.dgv_dados_clientes.ReadOnly = True
        Me.dgv_dados_clientes.Size = New System.Drawing.Size(636, 293)
        Me.dgv_dados_clientes.TabIndex = 2
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.MediumPurple
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.txt_busca_cliente, Me.ToolStripLabel5, Me.cmb_tipo_clientes})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(636, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel4.Text = "DIGITE UM PARAMÊTRO:"
        '
        'txt_busca_cliente
        '
        Me.txt_busca_cliente.Name = "txt_busca_cliente"
        Me.txt_busca_cliente.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripLabel5.Text = "SELECIONE UM PARAMÊTRO"
        '
        'cmb_tipo_clientes
        '
        Me.cmb_tipo_clientes.Name = "cmb_tipo_clientes"
        Me.cmb_tipo_clientes.Size = New System.Drawing.Size(121, 25)
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgv_realacao_vendas)
        Me.TabPage4.Controls.Add(Me.ToolStrip3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(636, 318)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "RELAÇÃO DE VENDAS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgv_realacao_vendas
        '
        Me.dgv_realacao_vendas.AllowUserToAddRows = False
        Me.dgv_realacao_vendas.AllowUserToDeleteRows = False
        Me.dgv_realacao_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_realacao_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column13, Me.Column14, Me.Column15, Me.Column18, Me.Column16, Me.Column17})
        Me.dgv_realacao_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_realacao_vendas.Location = New System.Drawing.Point(3, 28)
        Me.dgv_realacao_vendas.Name = "dgv_realacao_vendas"
        Me.dgv_realacao_vendas.ReadOnly = True
        Me.dgv_realacao_vendas.Size = New System.Drawing.Size(630, 287)
        Me.dgv_realacao_vendas.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_relatorio_vendas, Me.ToolStripLabel6})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(630, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btn_relatorio_vendas
        '
        Me.btn_relatorio_vendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_relatorio_vendas.Image = Global.sexshop_perdicao.My.Resources.Resources.document_icon
        Me.btn_relatorio_vendas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_relatorio_vendas.Name = "btn_relatorio_vendas"
        Me.btn_relatorio_vendas.Size = New System.Drawing.Size(23, 22)
        Me.btn_relatorio_vendas.Text = "ToolStripButton1"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel6.Text = "VISUALIZAR RELATÓRIO"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_sair, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(668, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_sair
        '
        Me.btn_sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(23, 22)
        Me.btn_sair.Text = "SAIR"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripLabel3.Text = "SAIR DA CONTA"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.Image = Global.sexshop_perdicao.My.Resources.Resources.save2
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn2.Image = Global.sexshop_perdicao.My.Resources.Resources.Industry_Trash_icon
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn3.Image = Global.sexshop_perdicao.My.Resources.Resources.save
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn4.Image = Global.sexshop_perdicao.My.Resources.Resources.Industry_Trash_icon
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        '
        'Column13
        '
        Me.Column13.HeaderText = "CLIENTE"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 180
        '
        'Column14
        '
        Me.Column14.HeaderText = "DATA"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 80
        '
        'Column15
        '
        Me.Column15.HeaderText = "HORA"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 80
        '
        'Column18
        '
        Me.Column18.HeaderText = "TOTAL"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 80
        '
        'Column16
        '
        Me.Column16.HeaderText = "DESCONTO"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 80
        '
        'Column17
        '
        Me.Column17.HeaderText = "TOTAL GASTO"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "NOME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "EMAIL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 150
        '
        'Column10
        '
        Me.Column10.HeaderText = "SENHA"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "EXCLUIR"
        Me.Column12.Image = Global.sexshop_perdicao.My.Resources.Resources.Industry_Trash_icon
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'frm_cadastro_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(668, 377)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tab_cadastro_produtos)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEXSHOP PERDIÇÃO"
        Me.tab_cadastro_produtos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_dados_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmb_busca_categoria.ResumeLayout(False)
        Me.cmb_busca_categoria.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgv_realacao_vendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents abrir_foto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tab_cadastro_produtos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents txt_preco_produto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_descr_produto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_produto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents img_produto As System.Windows.Forms.PictureBox
    Friend WithEvents txt_id As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_busca_categoria As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_busca_produto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmb_tipo_produtos As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents dgv_dados_produtos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_dados_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_busca_cliente As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmb_tipo_clientes As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_realacao_vendas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_relatorio_vendas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewImageColumn
End Class
