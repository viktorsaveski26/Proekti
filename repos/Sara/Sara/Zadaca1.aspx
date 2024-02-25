<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Zadaca1.aspx.cs" Inherits="Sara.Zadaca1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="float:none; margin-left:200px">
        <div class="m-4">
            <asp:ListBox ID="list" runat="server" SelectionMode="Multiple">
                <asp:ListItem Value="60">Круша</asp:ListItem>
                <asp:ListItem Value="30">Јаболко</asp:ListItem>
                <asp:ListItem Value="100">Лубеница</asp:ListItem>
            </asp:ListBox>
        </div>
        <div class="m-4">
            <asp:Button ID="zacuvaj" runat="server" Text="Зачувај" OnClick="save"/>
        </div>
        <div class="m-4">
           Oд пазар купив: <asp:Label ID="ovoshje" runat="server" Text=""></asp:Label>
            <br />
           Цена: <asp:Label ID="cena" runat="server" Text=""></asp:Label>
            <br />
           Баба од пазар купи:<asp:Label ID="proizvodi" runat="server" Text=""></asp:Label>
            <br />
           Баба потрошила: <asp:Label ID="vkupno" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
