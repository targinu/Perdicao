Public Class frm_relat_clientes

    Private Sub frm_relat_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'sexshopdbDataSet.tb_clientes' table. You can move, or remove it, as needed.
        Me.tb_clientesTableAdapter.query_clientes(Me.sexshopdbDataSet.tb_clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class