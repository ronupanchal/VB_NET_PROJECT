<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/test.Master" CodeBehind="AJAXDemo3.aspx.vb" Inherits="TestWebDemo.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="testmain" runat="server">

  <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Timer ID="Timer1" runat="server" Interval="1000">
        </asp:Timer>                      
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AJAX3.xml"  />
        </ContentTemplate>

        </asp:UpdatePanel>
</asp:Content>
