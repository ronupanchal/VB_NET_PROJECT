<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="stateMgmtDemo.EmployeeSearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome,&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
         <Columns>
               
                <asp:TemplateField HeaderText ="Employee Name">
                    <ItemTemplate>
                        <asp:LinkButton ID="lknEmpName" CommandName ='<%# Eval("EmpID") %>' 
                            runat="server" Text ='<%# Eval("EmpName") %>' onclick="lknEmpName_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Address" HeaderText="Address"/>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
