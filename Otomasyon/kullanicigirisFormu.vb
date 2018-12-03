Imports System.Data.SqlClient
Public Class kullanicigirisFormu
    Private Kapat As Boolean = True
    Private Hak As Integer = 3



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String = UsernameTextBox.Text.Trim
        Dim password As String = PasswordTextBox.Text.Trim
        If username.Length > 0 And password.Length > 0 Then
            Hak -= 1
            password = SHA512_Hash(password)
            Dim KullaniciDT As New DataTable
            Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
            Try

                Dim sorgu As String = "SELECT * FROM KullanicilarTablosu WHERE KullaniciAdi=@KullaniciAdi and Sifre=@Sifre"
                Dim sqlkomut As New SqlCommand(sorgu, sqlbaglanti)
                sqlkomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 20).Value = username
                sqlkomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = password
                sqlbaglanti.Open()
                KullaniciDT.Load(sqlkomut.ExecuteReader)
            Catch ex As Exception
                MsgBox("Ba�lant� Hatas� Program Kapat�lacakt�r")
            Finally
                If KullaniciDT.Rows.Count = 1 And Hak >= 0 Then
                    Kapat = False
                    Me.Close()
                ElseIf Hak > 0 Then
                    MsgBox("Kullan�c� ad� ve\veya �ifre Hatal�. Tekrar Deneyiniz ")
                Else
                    MsgBox("Kullan�c� ad� ve\veya �ifre Hatal�. 3 Hatal� Giri� Yapt�n�z Program Kapat�lacakt�r. ")
                    Me.Close()
                End If
                sqlbaglanti.Close()
            End Try

        Else
            MsgBox("Kullan�c� ad� veya �ifre bo� ge�ilemez!")
            UsernameTextBox.Focus()
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub kullanicigirisFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Kapat Then
            Application.Exit()
        End If
    End Sub
End Class
