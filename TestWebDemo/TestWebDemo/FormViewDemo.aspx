<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="FormViewDemo.aspx.vb" Inherits="TestWebDemo.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">

    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
        CellPadding="4" GridLines="Horizontal">
        <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
    </asp:FormView>

   

</asp:Content>
