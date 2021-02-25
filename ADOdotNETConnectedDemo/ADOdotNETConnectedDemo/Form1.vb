Imports System.Data.SqlClient

Public Class Form1
    'ADO.NET  Practical
	'-----------
    Dim cnstring As String = "Data Source=lenovo\sqlexpress;Initial Catalog=db_sybca;Integrated Security=True" 'compulsury
    Dim cn As New SqlConnection(cnstring) 'compulsury
    Dim cmd As New SqlCommand() 'compulsury
	Dim rd As SqlDataReader
    '----------
	
	Dim ds As New DataSet
    Dim Record_num As Integer = 0
    Dim pos As Integer = 0

 


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'connected 
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select * from tbl_std"
        rd = cmd.ExecuteReader()
        DataGridView2.Columns.Add("c1", "sid")
        DataGridView2.Columns.Add("c2", "sname")
        DataGridView2.Columns.Add("c3", "city")
        While rd.Read()
            ListBox1.Items.Add(rd(0) & " --- " & rd(1) & " --- " & rd(2))
            ComboBox1.Items.Add(rd(2))
            DataGridView2.Rows.Add(rd(0).ToString(), rd(1).ToString(), rd(2).ToString())
        End While
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'connected 
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "insert into tbl_std values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Inserted Successfully....!!!")
        cn.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
    End Sub

   
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        'Disconnected 

        Dim da As New SqlDataAdapter("select * from tbl_std", cn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        pos = ds.Tables(0).Rows.Count - 1
        display(pos)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If pos < ds.Tables(0).Rows.Count - 1 Then
            pos = pos + 1
            display(pos)
        Else
            MsgBox("the data has reach it limit")
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If pos >= 1 Then
            pos = pos - 1
            display(pos)
        Else
            MsgBox("Please select the next button")
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        pos = 0
        display(pos)
    End Sub


    Sub display(ByVal i As Integer)
        txtSID.Text = ds.Tables(0).Rows.Item(i).Item("sid")
        txtSNAME.Text = ds.Tables(0).Rows.Item(i).Item("sname")
        txtCity.Text = ds.Tables(0).Rows.Item(i).Item("city")
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
      


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        TextBox2.Text = DataGridView2.Item(1, i).Value
       
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtSID.Text = DataGridView1.Item(0, i).Value
        txtSNAME.Text = DataGridView1.Item(1, i).Value

        txtCity.Text = DataGridView1.Item(2, i).Value
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'connected 
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " update tbl_std set sname ='" & txtSNAME.Text & "', city='" & txtCity.Text & "' where sid=" & txtSID.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data update Successfully....!!!")
        cn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'connected 
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "delete from tbl_std  where sid=" & txtSID.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data update Successfully....!!!")
        cn.Close()
    End Sub

    Private Sub txtSNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSNAME.TextChanged

    End Sub
End Class
