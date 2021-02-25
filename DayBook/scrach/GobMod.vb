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
    ''  to use OLEDB components
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\DocSoftData.mdb")
    Public cmd As New OleDbCommand '' where the query will be written and executed
    Public da As New OleDbDataAdapter '' where the result of the command stored
    Public ds As New DataSet '' all the tables of the selested data adepter
    Public dt As New DataTable ''where all data will be stored from dataset
#End Region
    Public Sub DisConn()
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Public Sub ConnMe()
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
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
    Public Sub msgBx(ByVal Msg As String, ByVal errtype As String, ByVal Title As String)
        Dim ms As New frmMsg
        If errtype = "Done" Then
            ms.pbImage.Image = ms.ilistimg.Images(3)
            ms.lblMsg.Text = Msg
            ms.Text = Title
        Else
            ms.pbImage.Image = ms.ilistimg.Images(2)
            ms.lblMsg.Text = Msg
            ms.Text = Title
        End If
        ms.ShowDialog()
    End Sub
    Function Standardize_path(ByVal aPath As String) As String
        'standardize the path, always add a "\" to the end of the path
        If Right(aPath, 1) <> "\" Then
            Standardize_path = aPath & "\"
        Else
            Standardize_path = aPath
        End If
    End Function
    Sub get_Startup_path()
        'get the program's start up path and save it into the global variable Startup_path.

        Dim aPath As String = Application.StartupPath
        aPath = Standardize_path(aPath)
        Startup_path = aPath

    End Sub
    Sub load_default_if_needed()
        If Not File.Exists(Startup_path & "Skin.ini") Then
            get_Startup_path()
            Dir_Path = Startup_path
            set_Config(Startup_path & "skin.ini")
        End If
    End Sub
    Sub set_Config(ByVal Config_fn As String)
        'save the variables into the config file
        Dim objWriter As StreamWriter = New StreamWriter(Config_fn)
        objWriter.WriteLine("Dir_Path = " & Dir_Path)
        objWriter.WriteLine("skin = " & frmMenu.BackgroundImage.ToString)
        objWriter.Close()
        objWriter.Dispose()
    End Sub
#Region "Making Database Effects"
    '' For Encryption
    Public Sub EncryptDatabase()
        Call DisConn()
        If File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.mdb") And File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.ocx") Then
            Kill(My.Application.Info.DirectoryPath & "\DocSoftData.ocx")
        End If
        If File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.mdb") Then
            File.Copy(My.Application.Info.DirectoryPath & "\DocSoftData.mdb", My.Application.Info.DirectoryPath & "\DocSoftData.ocx")
            Kill(My.Application.Info.DirectoryPath & "\DocSoftData.mdb")
        End If
    End Sub
    Public Sub DecryptDatabase()
        Call DisConn()
        If File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.mdb") And File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.ocx") Then
            Kill(My.Application.Info.DirectoryPath & "\DocSoftData.mdb")
        End If
        If File.Exists(My.Application.Info.DirectoryPath & "\DocSoftData.ocx") Then
            File.Copy(My.Application.Info.DirectoryPath & "\DocSoftData.ocx", My.Application.Info.DirectoryPath & "\DocSoftData.mdb")
            Kill(My.Application.Info.DirectoryPath & "\DocSoftData.ocx")
        End If
    End Sub
    '' For Decryption
    Public Sub clearAllDatas()
        conn.ConnectionString = ""
        If conn.State = 1 Then conn.Close()
        cmd.Connection = Nothing
        cmd.CommandText = ""
        da.SelectCommand = cmd
        ds.Clear()
        dt.Clear()
    End Sub
#End Region
End Module
