Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_login.Text = "admin" And txt_senha_login.Text = "admin" Then
            txt_login.Clear()
            txt_senha_login.Clear()
            Me.Hide()
            frm_cadastro_produtos.Show()
        Else
            Try
                sql = "select * from tb_cadastro where (nome='" & txt_login.Text & "' or email='" & txt_login.Text & "') and senha='" & txt_senha_login.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    frm_loja.Show()
                Else
                    MsgBox("Usuario ou senha incorretos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_login.Clear()
                    txt_senha_login.Clear()
                    txt_login.Focus()
                End If
            Catch ex As Exception
                MsgBox("Erro ao logar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        txt_login.Clear()
        txt_senha_login.Clear()
        frm_cadastro.Show()

    End Sub

    Private Sub chk_visualizar_Click(sender As Object, e As EventArgs) Handles chk_visualizar.Click
        If chk_visualizar.Checked = True Then
            txt_senha_login.PasswordChar = ""
        Else
            txt_senha_login.PasswordChar = "*"
        End If
    End Sub
End Class

