<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="TestWebDemo.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>My Login</legend>
            <asp:Label ID="lblUserName" runat="server" Text="Enter Your Name :"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPwd" runat="server" Text="Enter Your Password :" ></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="LogIn" />
        &nbsp;<asp:Label ID="LblStatus" runat="server" Text=""></asp:Label>
        </fieldset>
    </div>
    </form>
</body>
</html>
