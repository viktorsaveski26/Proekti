<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication14.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/Лого-ФИНКИ.jpg" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem Value="Goce Aremnski">Internet Tehnologii</asp:ListItem>
            <asp:ListItem Value="Mile Jovanov">Strukturno</asp:ListItem>
            <asp:ListItem Value="Katarina Trojacanec">Objektno</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
        </asp:DropDownList>

    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Glasaj" OnClick="Button1_Click" />
    </div>
    <hr />
    <span>Predmet:</span>
    <div>
        <asp:TextBox ID="predemt" runat="server"></asp:TextBox>
    </div>
    <span>Krediti:</span>
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
