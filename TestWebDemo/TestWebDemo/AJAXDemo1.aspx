﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AJAXDemo1.aspx.vb" Inherits="TestWebDemo.AJAXDemo1" %>

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
        <br />
        <asp:Timer ID="Timer1" runat="server" Interval="1000">
        </asp:Timer>                      
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </ContentTemplate>

        </asp:UpdatePanel>

        
        
    </div>
    </form>
</body>
</html>
