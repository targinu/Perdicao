Module Module1
    Public diretorio As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp, aux_id, aux_cpf As String
    Public aux_produto, aux_preço, aux_categoria, aux_quantidade, aux_qtd2 As String
    Public aux_total, aux_cupom, aux_desconto As String
    Public total_carrinho As String
    Public banco_acess = Application.StartupPath & "\banco_dados\sexshopdb.accdb"
    Public cont As Integer

    Sub carregar_categoria_loja()
        Try
            With frm_loja.cmb_categoria_loja.Items
                .Add("NOME")
                .Add("PREÇO")
                .Add("CATEGORIA")
            End With
            frm_loja.cmb_categoria_loja.SelectedIndex = 2
        Catch ex As Exception
            MsgBox("Erro ao carregar categorias!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_categoria_produtos()
        Try
            With frm_cadastro_produtos.cmb_tipo_produtos.Items
                .Add("ID")
                .Add("NOME")
                .Add("PREÇO")
                .Add("CATEGORIA")
            End With
            frm_cadastro_produtos.cmb_tipo_produtos.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar categorias!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_categoria_clientes()
        Try
            With frm_cadastro_produtos.cmb_tipo_clientes.Items
                .Add("CPF")
                .Add("NOME")
                .Add("EMAIL")
                .Add("SENHA")
            End With
            frm_cadastro_produtos.cmb_tipo_clientes.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar categorias!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados_produtos()
        Try
            With frm_cadastro_produtos.dgv_dados_produtos
                sql = "select * from tb_produtos order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar busca avançada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados_clientes()
        Try
            With frm_cadastro_produtos.dgv_dados_clientes
                sql = "select * from tb_cadastro order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, rs.Fields(11).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar busca de clientes!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados_loja()
        Try
            With frm_loja.dgv_loja
                sql = "select * from tb_produtos order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar loja!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_carrinho()
        Try
            With frm_loja.dgv_carrinho
                sql = "select * from tb_carrinho order by nome_produto asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar carrinho", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_relacao_vendas()
        Try
            With frm_cadastro_produtos.dgv_realacao_vendas
                sql = "select * from tb_clientes order by data asc"
                rs = db.Execute(UCase(sql))
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar relação de vendas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub conecta_banco_acess()
        Try
            db = CreateObject("ADODB.connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" & banco_acess)
            ' MsgBox("Conexão realizada com sucesso - ACCESS!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_cadastro_produtos()
        With frm_cadastro_produtos
            .txt_id.Clear()
            .img_produto.Load(Application.StartupPath & "\icones\lub.jpg")
            .txt_nome_produto.Clear()
            .txt_descr_produto.Clear()
            .txt_preco_produto.Clear()
            .txt_id.Focus()
        End With
    End Sub

    Sub limpar_cadastro()
        With frm_cadastro
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_comp.Clear()
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_uf.Clear()
            .txt_celular.Clear()
            .txt_email.Clear()
            .txt_rsenha.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

    Sub editar_cadastro()
        With frm_cadastro

        End With
    End Sub
    
   


End Module