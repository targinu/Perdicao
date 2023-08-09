Public Class frm_loja
    Private Sub frm_loja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
        carregar_dados_loja()
        carregar_categoria_loja()
        lbl_usuario_loja.Text = UCase(frm_login.txt_login.Text)
        lbl_data.Text = Date.Today
        lbl_hora.Text = TimeOfDay
        Timer1.Start()

        carregar_carrinho()

    End Sub

    Private Sub txt_buscar_loja_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_loja.TextChanged
        Try
            With dgv_loja
                sql = "select * from tb_produtos where " & cmb_categoria_loja.Text & " like '" & txt_buscar_loja.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_loja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_loja.CellContentClick
        Try
            With dgv_loja
                If .CurrentRow.Cells(1).Selected = True Then
                    frm_visualizar.Show()
                End If

                If .CurrentRow.Cells(4).Selected Then
                    aux_id = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_carrinho where id_produto='" & aux_id & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = "update tb_carrinho set quantidade = quantidade + 1 where id_produto='" & aux_id & "'"
                        rs = db.Execute(sql)
                        sql = "update tb_carrinho set total = preço_produto*quantidade"
                        rs = db.Execute(sql)
                        MsgBox("+1 Produto adicionado ao carrinho!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    Else
                        aux_id = .CurrentRow.Cells(0).Value
                        aux_produto = .CurrentRow.Cells(1).Value
                        aux_preço = .CurrentRow.Cells(2).Value
                        aux_categoria = .CurrentRow.Cells(3).Value
                        aux_quantidade = 1
                        aux_total = sql = "update tb_carrinho set total = preço_produto"
                        sql = "insert into tb_carrinho values ('" & aux_id & "', '" & aux_produto & "', " & _
                            "'" & aux_preço & "', '" & aux_quantidade & "', '" & 0 & "')"
                        rs = db.Execute(sql)

                        sql = "update tb_carrinho set total = preço_produto*quantidade"
                        rs = db.Execute(sql)

                        MsgBox("Produto adicionado ao carrinho!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                    sql = "select * from tb_total"
                    rs = db.Execute(sql)

                    carregar_carrinho()
                    carregar_total()
                    carregar_cupom()
                    carregar_desconto()

                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao colocar produtos no carrinho!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub btn_sair_loja_Click(sender As Object, e As EventArgs) Handles btn_sair_loja.Click
        frm_login.Show()
        Me.Close()
        frm_login.txt_login.Clear()
        frm_login.txt_senha_login.Clear()
    End Sub

    Private Sub lbl_sair_loja_Click(sender As Object, e As EventArgs) Handles lbl_sair_loja.Click
        frm_login.Show()
        Me.Close()
        frm_login.txt_login.Clear()
        frm_login.txt_senha_login.Clear()
    End Sub

   
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        carregar_carrinho()
    End Sub

    Private Sub btn_confirmar_compra_Click(sender As Object, e As EventArgs) Handles btn_confirmar_compra.Click
        Try
            sql = "insert into tb_clientes values ('" & lbl_usuario_loja.Text & "', '" & lbl_data.Text & "', " & _
                    "'" & lbl_hora.Text & "', '" & lbl_valor_total.Text & "', '" & lbl_desconto.Text & "', '" & 0 & "')"
            rs = db.Execute(UCase(sql))

            sql = "update tb_clientes set total_com_desconto = total-desconto"
            rs = db.Execute(UCase(sql))

            MsgBox("Compra efetuada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            sql = "delete * from tb_total"
            rs = db.Execute(sql)
            sql = "delete * from tb_carrinho"
            rs = db.Execute(sql)

            lbl_valor_total.Text = "0"

            lbl_cupom.ForeColor = Color.Red
            lbl_cupom.Text = "Indisponivel"

            lbl_desconto.Text = "0"

            carregar_carrinho()

        Catch ex As Exception
            MsgBox("Erro ao gravar no banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub btn_esvaziar_Click(sender As Object, e As EventArgs) Handles btn_esvaziar.Click
        Try
            sql = "delete * from tb_total"
            rs = db.Execute(sql)
            sql = "delete * from tb_carrinho"
            rs = db.Execute(sql)

            lbl_valor_total.Text = "0"

            lbl_cupom.ForeColor = Color.Red
            lbl_cupom.Text = "Indisponivel"

            lbl_desconto.Text = "0"
            carregar_carrinho()
        Catch ex As Exception
            MsgBox("Erro ao carregar carrinho!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_total()
        sql = "select * from tb_total"
        rs = db.Execute(sql)
        If rs.EOF = False Then

            sql = "delete * from tb_total"
            rs = db.Execute(sql)

            sql = "insert into tb_total (total_carrinho) select sum(total) as total_carrinho from tb_carrinho"
            rs = db.Execute(sql)

            sql = "select * from tb_total"
            rs = db.Execute(sql)


            lbl_valor_total.Text = rs.Fields(0).Value

        Else

            sql = "insert into tb_total (total_carrinho) select sum(total) as total_carrinho from tb_carrinho"
            rs = db.Execute(sql)

            sql = "select * from tb_total"
            rs = db.Execute(sql)

            lbl_valor_total.Text = rs.Fields(0).Value

        End If
    End Sub

    Sub carregar_cupom()
        Try
            If lbl_valor_total.Text < 100 Then
                lbl_cupom.ForeColor = Color.Red
                lbl_cupom.Text = "Indisponivel"

            ElseIf lbl_valor_total.Text > 100 Then
                lbl_cupom.ForeColor = Color.ForestGreen
                lbl_cupom.Text = "Disponível"
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar cupom!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_desconto()
        Try
            If lbl_valor_total.Text > 100 And lbl_valor_total.Text < 200 Then
                lbl_desconto.Text = "5,00"
            ElseIf lbl_valor_total.Text > 200 And lbl_valor_total.Text < 300 Then
                lbl_desconto.Text = "10,00"
            ElseIf lbl_valor_total.Text > 300 And lbl_valor_total.Text < 400 Then
                lbl_desconto.Text = "15,00"
            ElseIf lbl_valor_total.Text > 400 And lbl_valor_total.Text < 500 Then
                lbl_desconto.Text = "20,00"
            ElseIf lbl_valor_total.Text > 500 And lbl_valor_total.Text < 600 Then
                lbl_desconto.Text = "25,00"
            ElseIf lbl_valor_total.Text > 600 And lbl_valor_total.Text < 700 Then
                lbl_desconto.Text = "30,00"
            ElseIf lbl_valor_total.Text > 700 And lbl_valor_total.Text < 800 Then
                lbl_desconto.Text = "35,00"
            ElseIf lbl_valor_total.Text > 800 And lbl_valor_total.Text < 900 Then
                lbl_desconto.Text = "40,00"
            ElseIf lbl_valor_total.Text > 900 And lbl_valor_total.Text < 1000 Then
                lbl_desconto.Text = "45,00"
            ElseIf lbl_valor_total.Text > 1000 And lbl_valor_total.Text < 1100 Then
                lbl_desconto.Text = "50,00"
            ElseIf lbl_valor_total.Text > 1100 And lbl_valor_total.Text < 1200 Then
                lbl_desconto.Text = "55,00"
            ElseIf lbl_valor_total.Text > 1200 And lbl_valor_total.Text < 1300 Then
                lbl_desconto.Text = "60,00"
            ElseIf lbl_valor_total.Text > 1300 And lbl_valor_total.Text < 1400 Then
                lbl_desconto.Text = "65,00"
            ElseIf lbl_valor_total.Text > 1400 And lbl_valor_total.Text < 1500 Then
                lbl_desconto.Text = "70,00"
            ElseIf lbl_valor_total.Text > 1500 And lbl_valor_total.Text < 1600 Then
                lbl_desconto.Text = "75,00"
            ElseIf lbl_valor_total.Text > 1600 And lbl_valor_total.Text < 1700 Then
                lbl_desconto.Text = "80,00"
            ElseIf lbl_valor_total.Text > 1700 And lbl_valor_total.Text < 1800 Then
                lbl_desconto.Text = "85,00"
            ElseIf lbl_valor_total.Text > 1800 And lbl_valor_total.Text < 1900 Then
                lbl_desconto.Text = "90,00"
            ElseIf lbl_valor_total.Text > 1900 And lbl_valor_total.Text < 2000 Then
                lbl_desconto.Text = "95,00"
            ElseIf lbl_valor_total.Text > 2000 And lbl_valor_total.Text < 2100 Then
                lbl_desconto.Text = "100,00"
            ElseIf lbl_valor_total.Text > 2100 And lbl_valor_total.Text < 2200 Then
                lbl_desconto.Text = "105,00"

            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar desconto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class