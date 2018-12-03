Imports System.Security.Cryptography
Imports System.Text
Module cripto
    Public Function SHA512_Hash(ByVal Metin As String) As String
        Dim Kripto As New SHA512CryptoServiceProvider 'Kriptolama için gerekli servis sağlayıcısı
        Dim ByteMetin() As Byte = Encoding.UTF8.GetBytes(Metin) 'Kriptolanacak metni byte dizi değişkene aktar
        ByteMetin = Kripto.ComputeHash(ByteMetin) 'Kriptolama işlemi yapıldı
        Dim Sonuc As String = Nothing
        For Each Karakter As Byte In ByteMetin
            Sonuc &= Karakter.ToString("x2")
        Next
        Return Sonuc
    End Function
End Module
