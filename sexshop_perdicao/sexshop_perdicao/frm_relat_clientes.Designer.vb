<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_clientes
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relat_clientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sexshopdbDataSet = New sexshop_perdicao.sexshopdbDataSet()
        Me.tb_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_clientesTableAdapter = New sexshop_perdicao.sexshopdbDataSetTableAdapters.tb_clientesTableAdapter()
        CType(Me.sexshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.tb_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sexshop_perdicao.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(633, 424)
        Me.ReportViewer1.TabIndex = 0
        '
        'sexshopdbDataSet
        '
        Me.sexshopdbDataSet.DataSetName = "sexshopdbDataSet"
        Me.sexshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_clientesBindingSource
        '
        Me.tb_clientesBindingSource.DataMember = "tb_clientes"
        Me.tb_clientesBindingSource.DataSource = Me.sexshopdbDataSet
        '
        'tb_clientesTableAdapter
        '
        Me.tb_clientesTableAdapter.ClearBeforeFill = True
        '
        'frm_relat_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 424)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relat_clientes"
        Me.Text = "RELATÓRIO DE VENDAS"
        CType(Me.sexshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sexshopdbDataSet As sexshop_perdicao.sexshopdbDataSet
    Friend WithEvents tb_clientesTableAdapter As sexshop_perdicao.sexshopdbDataSetTableAdapters.tb_clientesTableAdapter
End Class
