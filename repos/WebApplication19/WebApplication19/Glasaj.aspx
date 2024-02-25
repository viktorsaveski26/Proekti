<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication19.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/logo-large-500x500_2.png" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="Goce">IT</asp:ListItem>
            <asp:ListItem Value="mile">SP</asp:ListItem>
            <asp:ListItem Value="Katarina">OOP</asp:ListItem>
        </asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server">
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
        </asp:ListBox>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Glasajte" OnClick="Button1_Click" />
    </div>
    <hr />
    <span>Predmet</span>
    <div>
        <asp:TextBox ID="predmet" runat="server"></asp:TextBox>
    </div>
        <span>Krediti</span>
    <div>
        <asp:TextBox ID="krediti" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="dodadi" runat="server" Text="Dodadi" OnClick="dodadi_Click" />
    </div>
    <div>
        <asp:Button ID="izbrisi" runat="server" Text="Izbrisi" OnClick="izbrisi_Click" />
    </div>
</asp:Content>
