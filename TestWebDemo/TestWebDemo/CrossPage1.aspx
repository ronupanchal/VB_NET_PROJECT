<%@ Page Title="My Cross Page 1" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="CrossPage1.aspx.vb" Inherits="TestWebDemo.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Cross Page" PostBackUrl="~/CrossPage2.aspx" />

</asp:Content>
