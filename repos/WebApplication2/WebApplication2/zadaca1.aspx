<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zadaca1.aspx.cs" Inherits="WebApplication2.zadaca1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="display: block; margin: auto; text-align: center;">
        <p>Листа на градови:</p>
        <div>
        <asp:ListBox ID="cities" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="0">Skopje</asp:ListItem>
            <asp:ListItem Value="50">Veles</asp:ListItem>
            <asp:ListItem Value="200">Ohrid</asp:ListItem>
        </asp:ListBox>
            </div>
        <div>
        <asp:Button ID="save" runat="server" Text="Прикажи" OnClick="save_Click" />
            </div>
        <br />
        Селектирани се градовите: <asp:Label ID="selectedCity" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
       
      <%--  Растојанието изнесува:<asp:Label ID="distance" runat="server" Text=""></asp:Label> --%>
    </div>
</asp:Content>
