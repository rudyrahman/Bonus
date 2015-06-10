Imports ADODB
Imports System.Data.OleDb
Module mdlAlpha
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Public mainconnectionstring As String
    Public CurrentAccountId As String
    Public CurrentAccountName As String
    Public CurrentAccountPriority As Byte

    Sub connect()
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
    End Sub
End Module
