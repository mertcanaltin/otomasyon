Imports System.Data.SqlClient
Public Class YeniYolcuKayitFormu
    Private SQLBaglanti As New SqlConnection(SqlBaglantiCumlesi) 'SqlBaglantiModule'ünden gelen fonksiyon
    Private YolcuSQLDataAdapter As SqlDataAdapter
    Private BipBusDataSet As New DataSet
    Private YolcuBS As New BindingSource 'Form nesnelerini bağlamak ve kayıtlar arasında gezinme, yeni kayıt ekleme, sile vb. işlemleri yapmak için kullanılır.
    Private Sub YeniYolcuKayitFormu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Sorgu As String = "SELECT * FROM YolcuTablosu"
        YolcuSQLDataAdapter = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Try
            SQLBaglanti.Open()
            YolcuSQLDataAdapter.Fill(BipBusDataSet, "YolcuTablosu")
            'SqlDataAdapter nesnesine Insert, Update ve Delete Komutlarını Ekleme
            Dim SqlCumleOlusturucu As New SqlCommandBuilder(YolcuSQLDataAdapter)
            YolcuSQLDataAdapter.InsertCommand = SqlCumleOlusturucu.GetInsertCommand
            YolcuSQLDataAdapter.UpdateCommand = SqlCumleOlusturucu.GetUpdateCommand
            YolcuSQLDataAdapter.DeleteCommand = SqlCumleOlusturucu.GetDeleteCommand

            'BindingSource nesnesi ile form nesneleri arasında bağlantı kurulumu
            'YolcuBS.DataSource = BipBusDataSet.Tables("YolcuTablosu")
            YolcuBS.DataSource = BipBusDataSet
            YolcuBS.DataMember = "YolcuTablosu"
            'Sanal olarak oluşturulan bir nesneye olay ekleme
            AddHandler YolcuBS.PositionChanged, AddressOf YolcuBS_PositionChanged
            CinsiyetBilgileriGetir()
            FormNesneleriniBagla()
        Catch ex As SqlException
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub YolcuBS_PositionChanged(sender As Object, e As EventArgs)
        ilkKayitButton.Enabled = True
        OncekiKayitButton.Enabled = True
        SonrakiKayitButton.Enabled = True
        SonKayitButton.Enabled = True
        If YolcuBS.Position = 0 Then
            ilkKayitButton.Enabled = False
            OncekiKayitButton.Enabled = False
        End If
        If YolcuBS.Position = YolcuBS.Count - 1 Then
            SonrakiKayitButton.Enabled = False
            SonKayitButton.Enabled = False
        End If
    End Sub
    Private Sub FormNesneleriniBagla()
        'YolcuNoTextBox.DataBindings.Add("Text", BipBusDataSet.Tables("YolcuTablosu"), "YolcuNo")'eski hali
        YolcuNoTextBox.DataBindings.Add("Text", YolcuBS, "YolcuNo")
        TCKimlikNoTextBox.DataBindings.Add("Text", YolcuBS, "TCKimlikNo")
        TCVatandasiCheckBox.DataBindings.Add("Checked", YolcuBS, "TCVatandasi", True)
        AdiTextBox.DataBindings.Add("Text", YolcuBS, "Adi")
        SoyadiTextBox.DataBindings.Add("Text", YolcuBS, "Soyadi")
        'Cinsiyet Bilgilerini Cinsiyet Tablosundan Getirmek İçin Gerekli Yapılandırma
        CinsiyetComboBox.DataBindings.Add("SelectedValue", YolcuBS, "Cinsiyet")
        '************************************************************
        TelefonTextBox.DataBindings.Add("Text", YolcuBS, "Telefon")
        DogumTarihiDateTimePicker.DataBindings.Add("Value", YolcuBS, "DogumTarihi", True)
    End Sub
    Private Sub CinsiyetBilgileriGetir()
        Dim Sorgu As String = "SELECT * FROM CinsiyetTablosu"
        Dim CinsiyetSqlCommand As New SqlCommand(Sorgu, SQLBaglanti)
        BipBusDataSet.Tables.Add("CinsiyetTablosu").Load(CinsiyetSqlCommand.ExecuteReader)
        CinsiyetComboBox.DataSource = BipBusDataSet.Tables("CinsiyetTablosu")
        CinsiyetComboBox.DisplayMember = "CinsiyetAdi" 'Kullanıcının görmesini istediğimiz ve seçim yapacağı bilgilerin bulunduğu alan
        CinsiyetComboBox.ValueMember = "CinsiyetKodu" 'Bu alan Yolcu Tablosundaki Cinsiyet alanı ile ilişkili olan alan
    End Sub

    Private Sub ilkKayitButton_Click(sender As Object, e As EventArgs) Handles ilkKayitButton.Click
        YolcuBS.MoveFirst()
    End Sub

    Private Sub OncekiKayitButton_Click(sender As Object, e As EventArgs) Handles OncekiKayitButton.Click
        YolcuBS.MovePrevious()
    End Sub

    Private Sub SonrakiKayitButton_Click(sender As Object, e As EventArgs) Handles SonrakiKayitButton.Click
        YolcuBS.MoveNext()
    End Sub

    Private Sub SonKayitButton_Click(sender As Object, e As EventArgs) Handles SonKayitButton.Click
        YolcuBS.MoveLast()
    End Sub

    Private Sub YeniKayitButton_Click(sender As Object, e As EventArgs) Handles YeniKayitButton.Click
        YolcuBS.AddNew()
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Dim Satir As DataRowView = YolcuBS.Current
        Dim AdSoyad As String = Satir("Adi") & " " & Satir("Soyadi")
        Dim Mesaj As String = AdSoyad & " isimli yolcuyu silmek istediğinize emin misiniz?"
        Dim Stil As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question
        If MsgBox(Mesaj, Stil, "Silme Onayı") = MsgBoxResult.Yes Then
            YolcuBS.RemoveCurrent()
        End If
    End Sub

    Private Sub KaydetButton_Click(sender As Object, e As EventArgs) Handles KaydetButton.Click
        Try
            SQLBaglanti.Open()
            Me.Validate()
            YolcuBS.EndEdit()
            Dim Sayi As Integer = YolcuSQLDataAdapter.Update(BipBusDataSet, "YolcuTablosu")
            MsgBox(Sayi & " kayıt üzerinde yapılan işlemler veritabanına aktarıldı.")
        Catch ex As Exception
            MsgBox("Hata: " & ex.Message)
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
End Class