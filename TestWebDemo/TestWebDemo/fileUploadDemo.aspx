<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="fileUploadDemo.aspx.vb" Inherits="TestWebDemo.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
    <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" /><br />
    <asp:Button ID="Button1" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
</asp:Content>
