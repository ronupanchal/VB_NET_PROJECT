<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master"
    CodeBehind="Home.aspx.vb" Inherits="TestWebDemo.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <fieldset>
        <legend>My Login</legend>
        <asp:Label ID="lblUserName" runat="server" Text="Enter Your Name :"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblPwd" runat="server" Text="Enter Your Password :"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="LogIn" />
        &nbsp;<asp:Label ID="LblStatus" runat="server" Text=""></asp:Label>
    </fieldset>
</asp:Content>
