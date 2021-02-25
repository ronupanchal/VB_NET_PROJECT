<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="Insert_Update_Delete.aspx.vb" Inherits="TestWebDemo.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="stdid" 
    DataSourceID="SqlDataSource1" ShowFooter="True">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                        CommandName="Update" Text="Update"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                        CommandName="Edit" Text="Edit"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Select" Text="Select"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" 
                        CommandName="Delete" Text="Delete"></asp:LinkButton>
                </ItemTemplate>
                 <FooterTemplate>
                     <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True"  
                        CommandName="Insert" Text="Insert" onclick="LinkButton1_Click" 
                         oncommand="LinkButton1_Command"></asp:LinkButton>
                </FooterTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="stdid" SortExpression="stdid">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("stdid") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("stdid") %>'></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
            <asp:TemplateField HeaderText="stdname" SortExpression="stdname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("stdname") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("stdname") %>'></asp:Label>
                </ItemTemplate>
                 <FooterTemplate>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please Enter Name">*</asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="stdcity" SortExpression="stdcity">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("stdcity") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("stdcity") %>'></asp:Label>
                </ItemTemplate>
                 <FooterTemplate>
                   <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCity" ErrorMessage="Please Enter City">*</asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConflictDetection="CompareAllValues" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    DeleteCommand="DELETE FROM [std_mst] WHERE [stdid] = @original_stdid AND (([stdname] = @original_stdname) OR ([stdname] IS NULL AND @original_stdname IS NULL)) AND (([stdcity] = @original_stdcity) OR ([stdcity] IS NULL AND @original_stdcity IS NULL))" 
    InsertCommand="INSERT INTO [std_mst] ([stdid], [stdname], [stdcity]) VALUES (@stdid, @stdname, @stdcity)" 
    OldValuesParameterFormatString="original_{0}" 
    SelectCommand="SELECT * FROM [std_mst]" 
    UpdateCommand="UPDATE [std_mst] SET [stdname] = @stdname, [stdcity] = @stdcity WHERE [stdid] = @original_stdid AND (([stdname] = @original_stdname) OR ([stdname] IS NULL AND @original_stdname IS NULL)) AND (([stdcity] = @original_stdcity) OR ([stdcity] IS NULL AND @original_stdcity IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_stdid" Type="Int32" />
            <asp:Parameter Name="original_stdname" Type="String" />
            <asp:Parameter Name="original_stdcity" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="stdid" Type="Int32" />
            <asp:Parameter Name="stdname" Type="String" />
            <asp:Parameter Name="stdcity" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="stdname" Type="String" />
            <asp:Parameter Name="stdcity" Type="String" />
            <asp:Parameter Name="original_stdid" Type="Int32" />
            <asp:Parameter Name="original_stdname" Type="String" />
            <asp:Parameter Name="original_stdcity" Type="String" />
        </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
