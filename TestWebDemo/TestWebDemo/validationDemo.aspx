
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="validationDemo.aspx.vb" Inherits="TestWebDemo.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">



    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ForeColor="#CC0000" ShowMessageBox="True" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Please Enter Your Name..!" ControlToValidate="txtName" 
                    ForeColor="#CC0000" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email..." 
                    ForeColor="#CC0000" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                password</td>
            <td>
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtpass" ControlToValidate="txtRepass" 
                    ErrorMessage="Not Match" ForeColor="#CC0000"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                retype password</td>
            <td>
                <asp:TextBox ID="txtRepass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Age</td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="txtAge" ErrorMessage="Age must be between 10 to 20" 
                    ForeColor="#CC0000" MaximumValue="20" MinimumValue="10"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                Mobile No</td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtMobile" ErrorMessage="Length of mobile no must be 10." 
                    ForeColor="#CC0000"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>



</asp:Content>
