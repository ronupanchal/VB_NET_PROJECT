Public Class WebForm14
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

    End Sub

    Public ReadOnly Property FirstNameTextBox As TextBox
        Get
            Return TextBox1
        End Get
    End Property

    Public ReadOnly Property LastNameTextBox As TextBox
        Get
            Return TextBox1
        End Get
    End Property

    Public ReadOnly Property FullName() As String
        Get
            Return TextBox1.Text & " " & TextBox2.Text
        End Get
    End Property

End Class