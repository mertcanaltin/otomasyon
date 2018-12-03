Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class OtobusAramaFormu

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OtobusAra_SQL(ByVal Plaka As String)
        Dim sqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM OtobusTablosu Where Plaka=@Plaka Order By Plaka"
        Dim OtobusTablosuSDA As New SqlDataAdapter(sorgu, sqlBaglanti)
        'parametre değişkeninin tanımla ve değer aktar (SelectCommand)
        OtobusTablosuSDA.SelectCommand.Parameters.Add("@Plaka", SqlDbType.NVarChar, 35)
        OtobusTablosuSDA.SelectCommand.Parameters("@Plaka").Value = Plaka
        '*****************************************************************************
        Try
            sqlBaglanti.Open()
            If BipBusDataSet.Tables.Contains("OtobusTablosu") Then
                BipBusDataSet.Tables("OtobusTablosu").Clear()
            End If
            OtobusTablosuSDA.Fill(BipBusDataSet, "OtobusTablosu")
            OtobusTablosuBindingSource.DataSource = BipBusDataSet
            OtobusTablosuBindingSource.DataMember = "OtobusTablosu"
            OtobuslerDataGridView.DataSource = OtobusTablosuBindingSource
        Catch ex As Exception
        Finally
            sqlBaglanti.Close()

        End Try
    End Sub
    Private Sub OtobusAra_SQLLike(ByVal Plaka As String)
        Dim sqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM OtobusTablosu Where Plaka like @Plaka Order By Plaka"
        Dim OtobusTablosuSDA As New SqlDataAdapter(sorgu, sqlBaglanti)
        'parametre değişkeninin tanımla ve değer aktar (SelectCommand)
        OtobusTablosuSDA.SelectCommand.Parameters.Add("@Plaka", SqlDbType.NVarChar, 35)
        OtobusTablosuSDA.SelectCommand.Parameters("@Plaka").Value = "%" & Plaka & "%" '__ (alt tre)de kullanabiliriz '__m%'
        '*****************************************************************************
        Try
            sqlBaglanti.Open()
            If BipBusDataSet.Tables.Contains("OtobusTablosu") Then
                BipBusDataSet.Tables("OtobusTablosu").Clear()
            End If
            OtobusTablosuSDA.Fill(BipBusDataSet, "OtobusTablosu")
            OtobusTablosuBindingSource.DataSource = BipBusDataSet
            OtobusTablosuBindingSource.DataMember = "OtobusTablosu"
            OtobuslerDataGridView.DataSource = OtobusTablosuBindingSource
        Catch ex As Exception
        Finally
            sqlBaglanti.Close()

        End Try
    End Sub

    Private Sub AraButton_Click(sender As Object, e As EventArgs) Handles AraButton.Click
        'OtobusAra_SQL(PlakaTextBox.Text.Trim) 
    End Sub

    Private Sub OtobusAramaFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        markaModelBilgileriniGetir()
        OtobusBilgileriniGetir()
    End Sub
    Private Sub markaModelBilgileriniGetir()
        Dim SQLBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Try

            SQLBaglanti.Open()
            'Marka Bilgilerini Getir
            Dim Sorgu As String = "SELECT * FROM MarkaTablosu"
            Dim SQLKomut As New SqlCommand(Sorgu, SQLBaglanti)
            BipBusDataSet.Tables.Add("MarkaTablosu").Load(SQLKomut.ExecuteReader)
            'Model Bilgilerini Getir
            Sorgu = "SELECT * FROM ModelTablosu"
            SQLKomut.CommandText = Sorgu
            BipBusDataSet.Tables.Add("ModelTablosu").Load(SQLKomut.ExecuteReader)
            'BindingSource'ler ile Bağlantı Kur
            markatablosuBindingSource.DataSource = BipBusDataSet
            markatablosuBindingSource.DataMember = "MarkaTablosu"
            'Buraya Dikkat
            modeltablosuBindingSource.DataSource = BipBusDataSet
            modeltablosuBindingSource.DataMember = "ModelTablosu"
            'İlişkiye Verdiğimiz İsmi Yazıyoruz

            'DataGridView İçerisindeki Tipi ComboBox Olan Alanlar İle Bağlantı Kur
            Dim MarkaNoCB As DataGridViewComboBoxColumn = OtobuslerDataGridView.Columns("MarkaNo")
            MarkaNoCB.DataSource = markatablosuBindingSource
            MarkaNoCB.DisplayMember = "Marka"
            MarkaNoCB.ValueMember = "MarkaNo"
            Dim ModelNoCB As DataGridViewComboBoxColumn = OtobuslerDataGridView.Columns("ModelNo")
            ModelNoCB.DataSource = modeltablosuBindingSource
            ModelNoCB.DisplayMember = "ModelAdi"
            ModelNoCB.ValueMember = "ModelNo"
        Catch ex As Exception
        Finally
            SQLBaglanti.Close()
        End Try

    End Sub
    Private Sub OtobusBilgileriniGetir()
        Dim sqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM OtobusTablosu  Order By Plaka"
        Dim OtobusTablosuSDA As New SqlDataAdapter(sorgu, sqlBaglanti)
        Try
            sqlBaglanti.Open()
            If BipBusDataSet.Tables.Contains("OtobusTablosu") Then
                BipBusDataSet.Tables("OtobusTablosu").Clear()
            End If
            OtobusTablosuSDA.Fill(BipBusDataSet, "OtobusTablosu")
            OtobusTablosuBindingSource.DataSource = BipBusDataSet
            OtobusTablosuBindingSource.DataMember = "OtobusTablosu"
            OtobuslerDataGridView.DataSource = OtobusTablosuBindingSource
        Catch ex As Exception
        Finally
            sqlBaglanti.Close()

        End Try
    End Sub

    Private Sub PlakaTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlakaTextBox.TextChanged
        OtobusTablosuBindingSource.Filter = " Plaka Like '%" & PlakaTextBox.Text.Trim & "%'" ' like tek tırnak içerisinde yazılır 
    End Sub
End Class
