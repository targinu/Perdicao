Public Class frm_visualizar

    Private Sub frm_visualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With frm_loja.dgv_loja
                aux_id = .CurrentRow.Cells(0).Value
                sql = "select * from tb_produtos where id='" & aux_id & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    img_visualizar.Load(rs.Fields(1).Value)
                    lbl_nome_produto.Text = rs.Fields(2).Value
                    lbl_descricao.Text = rs.Fields(3).Value
                    lbl_preco.Text = rs.Fields(4).Value
                    lbl_categoria.Text = rs.Fields(5).Value
                    lbl_nome_produto.MaximumSize = New Size(320, 0)
                    lbl_nome_produto.AutoSize = True
                    lbl_descricao.MaximumSize = New Size(580, 0)
                    lbl_descricao.AutoSize = True
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao visualizar produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_voltar_loja_Click(sender As Object, e As EventArgs) Handles btn_voltar_loja.Click
        Me.Close()
    End Sub
End Class