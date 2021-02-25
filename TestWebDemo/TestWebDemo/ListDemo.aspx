<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="WebForm5.aspx.vb" Inherits="TestWebDemo.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <table class="style1">
        <tr>
            <td style="text-align: center" colspan=2>
                List Control Example<br />
                <br />
            </td>
            
        </tr>
        <tr>
            <td>
                1.List Box<br />
                2. DropDownList<br />
                3.CheckBoxList<br />
                4.RadioButtonLisi</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                1.Select Country<br />
                <asp:ListBox ID="lstCountries" runat="server">
                    <asp:ListItem Value="0">India</asp:ListItem>
                    <asp:ListItem Value="1">Pakistan</asp:ListItem>
                    <asp:ListItem Value="2">Shi Lanka</asp:ListItem>
                </asp:ListBox>
            </td>
            <td>
                2. Select` Fruit<br />
                <asp:DropDownList ID="ddlFruits" runat="server">
                    <asp:ListItem Value="0">Apple</asp:ListItem>
                    <asp:ListItem Value="1">Banana</asp:ListItem>
                    <asp:ListItem Value="2">Orange</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                3.Select Hobby<br />
                <asp:CheckBoxList ID="cblHobbies" runat="server">
                    <asp:ListItem Value="0">Reading</asp:ListItem>
                    <asp:ListItem Value="1">Writing</asp:ListItem>
                    <asp:ListItem Value="2">paiting</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td>
                4.Select Course<br />
                <asp:RadioButtonList ID="rblCourse" runat="server">
                    <asp:ListItem Value="0">BCA</asp:ListItem>
                    <asp:ListItem Value="1">BBA</asp:ListItem>
                    <asp:ListItem Value="2">MCA</asp:ListItem>
                    <asp:ListItem Value="3">MBA</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="btnDisp" runat="server" Text="Display" />
            </td>
        </tr>
    </table>
</asp:Content>
