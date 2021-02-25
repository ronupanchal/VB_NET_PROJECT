<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="DisconnectedDemo.aspx.vb" Inherits="TestWebDemo.WebForm22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="stdcity" DataValueField="stdid">
    </asp:DropDownList>
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
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
