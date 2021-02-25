<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="TestWebDemo.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Lblv1" runat="server" Text="enter a value"></asp:Label>
        <asp:TextBox ID="Txtfname" runat="server"></asp:TextBox><br />
        <asp:Label ID="Lblv2" runat="server" Text="enter a value"></asp:Label>
        <asp:TextBox ID="Txtlname" runat="server"></asp:TextBox><br />
        <asp:Label ID="Lblans" runat="server" Text="answer"></asp:Label>
        <asp:TextBox ID="txtans" runat="server"></asp:TextBox><br />
        <asp:Button ID="Btnlogin" runat="server" Text="submit" />
    </div>
    </form>
</body>
</html>
