<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BulletList.aspx.vb" Inherits="TestWebDemo.BulletList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:BulletedList ID="BulletedList1" runat="server" 
            BulletImageUrl="~/Images/GreenFish.ico" BulletStyle="Square">
            <asp:ListItem>MCA</asp:ListItem>
            <asp:ListItem>MBA</asp:ListItem>
            <asp:ListItem>BCA</asp:ListItem>
        </asp:BulletedList>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Show Password" 
            AutoPostBack="True" />
    </div>
    </form>
</body>
</html>
