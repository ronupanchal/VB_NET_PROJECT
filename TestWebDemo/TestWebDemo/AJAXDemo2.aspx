<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AJAXDemo2.aspx.vb" Inherits="TestWebDemo.AJAXDemo2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <asp:Label ID="lblGreeting" runat="server" Text=""></asp:Label>

                <br />
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            
            <ProgressTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/progress.gif" />
            </ProgressTemplate>
            
            </asp:UpdateProgress>

        </ContentTemplate>


        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
