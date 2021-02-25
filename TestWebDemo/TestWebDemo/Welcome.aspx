<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Welcome.aspx.vb" Inherits="TestWebDemo.Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <fieldset>
            <legend>Personal Detail</legend>
            <table>
            <tr><td>
            <asp:Label ID="fname" runat="server" Text="First Name"></asp:Label> </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=":"></asp:Label></td>
            <td> <asp:TextBox ID="txtfname" runat="server"></asp:TextBox><br /></td></tr>
           
           
            
            <tr><td>
            <asp:Label ID="mname" runat="server" Text="Middle Name" ></asp:Label></td>
                   <td>
                <asp:Label ID="Label2" runat="server" Text=":"></asp:Label></td><td>
            <asp:TextBox ID="txtmname" runat="server" ></asp:TextBox><br />
            </td></tr>
          
            <tr><td>
            <asp:Label ID="lname" runat="server" Text="Last Name" ></asp:Label></td>
                   <td>
                <asp:Label ID="Label3" runat="server" Text=":"></asp:Label></td><td>
            <asp:TextBox ID="txtlname" runat="server" ></asp:TextBox><br />
            </td></tr>
            
        <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label5" runat="server" Text=":"></asp:Label></td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
              <%-- <asp:Label ID="Label6" runat="server" Text="Male"></asp:Label>
              <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" />
                <asp:Label ID="Label7" runat="server" Text="Female"></asp:Label>
                <asp:RadioButton ID="RadioButton2" runat="server" /></td>--%>
        </tr>
        <tr><td>
            <asp:Label ID="Label8" runat="server" Text="Course"></asp:Label></td>
            <td><asp:Label ID="Label9" runat="server" Text=":"></asp:Label></td>
           <td>
               <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select Cource</asp:ListItem>
                   <asp:ListItem>BCA</asp:ListItem>
                   <asp:ListItem>BBA</asp:ListItem>
               </asp:DropDownList>
           </td>
           </tr>

           <tr>
           <td></td><td></td>
           <td>
               <asp:Button ID="submit" runat="server" Text="Submit" /></td></tr>
            </table>

          
         
          
            <asp:Panel ID="Panel1" runat="server" BackColor="#66FFFF">
              <hr />
               <h2>Your Personal Detail</h2>
             <table>
           <tr>
           <td>
               <asp:Label ID="Label10" runat="server" Text="Name "></asp:Label>
           </td>
           <td>
               <asp:Label ID="Label11" runat="server" Text=":"></asp:Label></td>
               <td>
                   <asp:Label ID="Label12" runat="server" Text=""></asp:Label></td><td>&nbsp;<asp:Label ID="lbl19" runat="server" Text=""></asp:Label></td>&nbsp;<td><asp:Label ID="lbl20" runat="server" Text=""></asp:Label></td>
                   <br />
            </tr>
            <tr>
                   <td>
                       <asp:Label ID="Label13" runat="server" Text="Gender"></asp:Label></td>
                       <td>
                           <asp:Label ID="Label14" runat="server" Text=":"></asp:Label></td>
                           <td>
                               <asp:Label ID="Label15" runat="server" Text=""></asp:Label></td>
           </tr>
           <tr>
           <td> 
               <asp:Label ID="Label16" runat="server" Text="Course"></asp:Label></td>
               <td>
                   <asp:Label ID="Label17" runat="server" Text=":"></asp:Label></td>
                   <td>
                       <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
                      
               </td>
           </tr>
           </table>
                       </asp:Panel>
        </fieldset>
    </div>
    </form>
</body>
</html>
