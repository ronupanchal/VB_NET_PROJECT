<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="ViewStateDemo2.aspx.vb" Inherits="TestWebDemo.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="87px" 
        Width="253px"></asp:TextBox><br /><br />

    <asp:Button ID="Button1" runat="server" Text="Save Content" />&nbsp;
     <asp:Button ID="Button2" runat="server" Text="Load Content" />

</asp:Content>
