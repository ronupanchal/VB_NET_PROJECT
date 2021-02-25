<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="AdRotatorDemo.aspx.vb" Inherits="TestWebDemo.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
<h2>Adrotator Control::</h2>
<br />
    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/ITcompany.xml" />
</asp:Content>
