<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="SessionDemo.aspx.vb" Inherits="TestWebDemo.WebForm18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" Text="More Information" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
