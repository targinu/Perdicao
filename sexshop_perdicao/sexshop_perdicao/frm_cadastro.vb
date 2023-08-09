Public Class frm_cadastro

    Private Sub Frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_comp.Focus()
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não coincidem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txt_senha.Clear()
                txt_rsenha.Clear()
                Exit Sub
            End If

            If rs.EOF = False Then

                sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " & _
                      "data_nasc='" & cmb_data_nasc.Text & "', " & _
                      "cep='" & txt_cep.Text & "', endereco='" & txt_endereco.Text & "', " & _
                      "comp='" & txt_comp.Text & "', bairro='" & txt_bairro.Text & "', " & _
                      "cidade='" & txt_cidade.Text & "', uf='" & txt_uf.Text & "', " & _
                      "celular='" & txt_celular.Text & "', " & _
                      "email='" & txt_email.Text & "', senha='" & txt_senha.Text & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")



            Else
                sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', '" & cmb_data_nasc.Text & "', " &
                    "'" & txt_nome.Text & "', '" & txt_cep.Text & "', " &
                    "'" & txt_endereco.Text & "', '" & txt_comp.Text & "', " &
                    "'" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
                    "'" & txt_uf.Text & "', " &
                    "'" & txt_celular.Text & "', '" & txt_email.Text & "', " &
                    "'" & txt_senha.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Conta cadastrada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro()
            carregar_dados_clientes()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao gravar cadastro no banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                cmb_data_nasc.Text = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(2).Value
                txt_cep.Text = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_comp.Text = rs.Fields(5).Value
                txt_bairro.Text = rs.Fields(6).Value
                txt_cidade.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_celular.Text = rs.Fields(9).Value
                txt_email.Text = rs.Fields(10).Value
                txt_senha.Text = rs.Fields(11).Value
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar CEP!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class