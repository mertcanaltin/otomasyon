Imports System.Data.SqlClient
Module SqlBaglantiModule
    Public Function SqlBaglantiCumlesi() As String
        Dim SqlBaglantiCumleOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCumleOlusturucu.DataSource = "localhost"
        SqlBaglantiCumleOlusturucu.InitialCatalog = "BipBusVT"
        SqlBaglantiCumleOlusturucu.PersistSecurityInfo = True
        SqlBaglantiCumleOlusturucu.UserID = "sa"
        SqlBaglantiCumleOlusturucu.Password = "mmyo"

        Return SqlBaglantiCumleOlusturucu.ConnectionString
    End Function
End Module
