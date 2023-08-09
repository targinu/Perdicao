Public Class frm_cadastro_produtos
    Private Sub frm_cadastro_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
        carregar_dados_produtos()
        carregar_dados_clientes()
        carregar_categoria_produtos()
        carregar_categoria_clientes()
        carregar_relacao_vendas()
    End Sub

    Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_produto.Click
        Try
            With abrir_foto
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\produtos"
                .ShowDialog()
                diretorio = .FileName
                img_produto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = "select * from tb_produtos where id='" & txt_id.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                diretorio = rs.Fields(1).Value
                sql = "update tb_produtos set NOME='" & txt_nome_produto.Text & "', " & _
                      "descrição='" & txt_descr_produto.Text & "', " & _
                      "preço='" & txt_preco_produto.Text & "', categoria='" & cmb_categoria.Text & "', " & _
                      "foto='" & diretorio & "' where id='" & txt_id.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "insert into tb_produtos values ('" & txt_id.Text & "', '" & diretorio & "', " & _
                    "'" & txt_nome_produto.Text & "', '" & txt_descr_produto.Text & "', " & _
                    "'" & txt_preco_produto.Text & "', '" & cmb_categoria.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro_produtos()
            carregar_dados_produtos()
        Catch ex As Exception
            MsgBox("Erro ao gravar no banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_id_LostFocus(sender As Object, e As EventArgs) Handles txt_id.LostFocus
        Try
            sql = "select * from tb_produtos where id='" & txt_id.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                img_produto.Load(rs.Fields(1).Value)
                txt_nome_produto.Text = rs.Fields(2).Value
                txt_descr_produto.Text = rs.Fields(3).Value
                txt_preco_produto.Text = rs.Fields(4).Value
                cmb_categoria.Text = rs.Fields(5).Value
            Else
                txt_nome_produto.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_id_doubleclick(sender As Object, e As EventArgs) Handles txt_id.DoubleClick
        limpar_cadastro_produtos()
    End Sub



    Private Sub txt_busca_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_produto.TextChanged
        Try
            With dgv_dados_produtos
                sql = "select * from tb_produtos where " & cmb_tipo_produtos.Text & " like '" & txt_busca_produto.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_produtos.CellContentClick
        Try
            With dgv_dados_produtos
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_produtos where id='" & aux_id & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        tab_cadastro_produtos.SelectTab(0) 'explorando a aba de dados pessoais
                        txt_id.Text = rs.Fields(0).Value
                        img_produto.Load(rs.Fields(1).Value)
                        txt_nome_produto.Text = rs.Fields(2).Value
                        txt_descr_produto.Text = rs.Fields(3).Value
                        txt_preco_produto.Text = rs.Fields(4).Value
                        cmb_categoria.Text = rs.Fields(5).Value
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine & _
                                  "Produto de ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_produtos where id='" & aux_id & "'"
                        rs = db.Execute(sql)
                        carregar_dados_produtos()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub txt_busca_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cliente.TextChanged
        Try
            With dgv_dados_clientes
                sql = "select * from tb_cadastro where " & cmb_tipo_clientes.Text & " like '" & txt_busca_cliente.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, rs.Fields(11).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_clientes.CellContentClick
        Try
            With dgv_dados_clientes
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine & _
                              "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_cadastro where cpf ='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados_clientes()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub



    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        frm_login.Show()
        Me.Close()
    End Sub


    Private Sub btn_relatorio_vendas_Click(sender As Object, e As EventArgs) Handles btn_relatorio_vendas.Click
        Try
            frm_relat_clientes.Show()
        Catch ex As Exception
            MsgBox("Erro ao visualizar relatório!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        Try
            frm_relat_clientes.Show()
        Catch ex As Exception
            MsgBox("Erro ao visualizar relatório!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class


