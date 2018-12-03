Imports System.Data.SqlClient
Public Class OtobuslerFormu
    Private SQLBaglanti As New SqlConnection(SqlBaglantiCumlesi)
    Private OtobusTablosuSDA As SqlDataAdapter
    Private Sub OtobuslerFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OtobusBilgileriniGetir()
        MarkaModelBilgileriniGetir()
        OtobusTablosuBindingSource.CancelEdit()
    End Sub
    Private Sub OtobusBilgileriniGetir()
        Dim Sorgu As String = "SELECT * FROM OtobusTablosu"
        OtobusTablosuSDA = New SqlDataAdapter(Sorgu, SQLBaglanti)
        OtobusTablosuSDA.Fill(BipBusDataSet, "OtobusTablosu")
        'Insert, Update ve Delete Komutlarını Ekle
        Dim SQLKomutOlusturucu As New SqlCommandBuilder(OtobusTablosuSDA)
        OtobusTablosuSDA.InsertCommand = SQLKomutOlusturucu.GetInsertCommand
        OtobusTablosuSDA.UpdateCommand = SQLKomutOlusturucu.GetUpdateCommand
        OtobusTablosuSDA.DeleteCommand = SQLKomutOlusturucu.GetDeleteCommand
        '**********************************
        OtobusTablosuBindingSource.DataSource = BipBusDataSet
        OtobusTablosuBindingSource.DataMember = "OtobusTablosu"
        OtobusTablosuBindingNavigator.BindingSource = OtobusTablosuBindingSource
        OtobuslerDataGridView.DataSource = OtobusTablosuBindingSource
        FormNesneleriniBagla()
    End Sub
    Private Sub FormNesneleriniBagla()
        PlakaTextBox.DataBindings.Add("Text", OtobusTablosuBindingSource, "Plaka")
        MarkaNoComboBox.DataBindings.Add("SelectedValue", OtobusTablosuBindingSource, "MarkaNo")
        ModelNoComboBox.DataBindings.Add("SelectedValue", OtobusTablosuBindingSource, "ModelNo")
        KoltukSayisiNUD.DataBindings.Add("Value", OtobusTablosuBindingSource, "KoltukSayisi", True)
        TelefonTextBox.DataBindings.Add("Text", OtobusTablosuBindingSource, "Telefon")
        KoltukDizilisiComboBox.DataBindings.Add("Text", OtobusTablosuBindingSource, "KoltukDizilisi")
        KatNUD.DataBindings.Add("Value", OtobusTablosuBindingSource, "Kat", True)
    End Sub
    Private Sub MarkaModelBilgileriniGetir()
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
            'Marka ve Model Tabloları Arasında DataSet Üzerinde İlişki Kurma************
            'MarkaNo Alanlarını Değişkenlere Ata
            Dim Marka_MarkaNo As DataColumn = BipBusDataSet.Tables("MarkaTablosu").Columns("MarkaNo")
            Dim Model_MarkaNo As DataColumn = BipBusDataSet.Tables("ModelTablosu").Columns("MarkaNo")
            'İlişki Değişkenini Oluştur New DataRelation("İlişki Adı", PK Olan Alan, FK Olan Alan)
            Dim MarkaModelRelation As New DataRelation("MarkaModel", Marka_MarkaNo, Model_MarkaNo)
            'İlişkiyi DataSet'e Ekle
            BipBusDataSet.Relations.Add(MarkaModelRelation)
            'BindingSource'ler ile Bağlantı Kur
            MarkaBindingSource.DataSource = BipBusDataSet
            MarkaBindingSource.DataMember = "MarkaTablosu"
            'Buraya Dikkat
            ModelBindingSource.DataSource = MarkaBindingSource
            ModelBindingSource.DataMember = "MarkaModel" 'İlişkiye Verdiğimiz İsmi Yazıyoruz
            '***************************************************************
            'ComboBox'lar ile Bağlantı Kur
            MarkaNoComboBox.DataSource = MarkaBindingSource
            MarkaNoComboBox.DisplayMember = "Marka"
            MarkaNoComboBox.ValueMember = "MarkaNo"
            ModelNoComboBox.DataSource = ModelBindingSource
            ModelNoComboBox.DisplayMember = "ModelAdi"
            ModelNoComboBox.ValueMember = "ModelNo"
            'DataGridView İçerisindeki Tipi ComboBox Olan Alanlar İle Bağlantı Kur
            Dim MarkaNoCB As DataGridViewComboBoxColumn = OtobuslerDataGridView.Columns("MarkaNo")
            MarkaNoCB.DataSource = MarkaBindingSource
            MarkaNoCB.DisplayMember = "Marka"
            MarkaNoCB.ValueMember = "MarkaNo"
            Dim ModelNoCB As DataGridViewComboBoxColumn = OtobuslerDataGridView.Columns("ModelNo")
            ModelNoCB.DataSource = ModelBindingSource
            ModelNoCB.DisplayMember = "ModelAdi"
            ModelNoCB.ValueMember = "ModelNo"
        Catch ex As Exception
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub

    Private Sub MarkaNoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles MarkaNoComboBox.SelectedValueChanged
        ' MarkaBindingSource.Position = MarkaNoComboBox.SelectedIndex
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        Me.Validate()
        OtobusTablosuBindingSource.EndEdit()
        OtobusTablosuSDA.Update(BipBusDataSet, "OtobusTablosu")
        MsgBox("Yapılan Değişiklikler (Ekle, Değiştir, Sil) Veri Tabanına Aktarıldı.")
    End Sub

    Private Sub AraButton_Click(sender As Object, e As EventArgs) Handles AraButton.Click
        OtobusAramaFormu.ShowDialog(Me)
    End Sub
    Private Sub OtobuslerDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles OtobuslerDataGridView.DataError
        If e.Exception.Message = "DataGridViewComboBoxCell value is not valid." Then
            Dim value As Object = OtobuslerDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            If Not (CType(OtobuslerDataGridView.Columns(e.ColumnIndex), DataGridViewComboBoxColumn)).Items.Contains(value) Then
                CType(OtobuslerDataGridView.Columns(e.ColumnIndex), DataGridViewComboBoxColumn).Items.Add(value)
                e.ThrowException = False
            End If
        End If

    End Sub
End Class