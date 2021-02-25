<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="DataBindingDemo.aspx.vb" Inherits="TestWebDemo.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">

    <asp:Button ID="Button1" runat="server" Text="Show Data In DataList Control" />
    <br />
    <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" GridLines="Both" RepeatDirection="Horizontal">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <ItemTemplate>
            <table class="style1" width="400">
                <tr>
                    <td rowspan="5">
                        <asp:Image ID="Image2" runat="server" Height="150px" 
                            ImageUrl='<%# Eval("Pics") %>' Width="150px" />
                    </td>
                    <td align="left">
                        PName :
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("PName") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        Qty:
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Qty") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        Price: $
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>
