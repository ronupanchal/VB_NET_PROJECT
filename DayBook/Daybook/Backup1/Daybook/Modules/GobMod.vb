#Region "Import Namespace"
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO
#End Region
Module GobMod
#Region "Global Variables"
    Public Dir_Path As String
    Public Startup_path As String
    Private nonNumberEntered As Boolean = False '' To Use Private flages
    Public UserId As String = ""
    Public ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\DB\MyData.mdb"
    ''  to use OLEDB components
    Public conn As New OleDbConnection(ConStr)
    Public cmd As New OleDbCommand '' where the query will be written and executed
    Public da As New OleDbDataAdapter '' where the result of the command stored
    Public ds As New DataSet '' all the tables of the selested data adepter
    Public dt As New DataTable ''where all data will be stored from dataset
#End Region
#Region "Database Establishment"
    Public Sub DisConn()
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Public Sub ConnMe()
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
#End Region
#Region "Date,Text,Number Format"
    Public Function mk_dt_fmt(ByVal X As Date) As Date
        Dim Y As String
        Y = Format(X, "dd-MMM-yy")
        mk_dt_fmt = CDate(Y)
    End Function
    Public Sub txt_key_prs(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If nonNumberEntered = True Then
            Beep()
            e.Handled = True
        End If
    End Sub
    Public Sub txt_key_dwn(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 OrElse e.KeyCode = Keys.Space Then
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                If e.KeyCode <> Keys.Back Then
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub
#End Region
End Module
