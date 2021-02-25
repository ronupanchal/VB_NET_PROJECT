<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="repeaterDemo.aspx.vb" Inherits="TestWebDemo.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Show Data" />
    <br />
    <asp:Repeater ID="Repeater1" runat="server" >
    <ItemTemplate>
        Pid : <%# DataBinder.Eval(Container.DataItem, "PId")%> <br />
        Product Name :  <%# DataBinder.Eval(Container.DataItem, "PName")%> <br />
        Image : 
        <asp:Image ID="Image1" runat="server" Height="120" Width="120" ImageUrl ='<%# DataBinder.Eval(Container.DataItem, "Pics")%>' />  <br />
    </ItemTemplate>
    </asp:Repeater>
</asp:Content>
 