<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication13.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/Лого-ФИНКИ.jpg" />
</div>
    
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <div><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Goce Armenski">Интернет Технологии</asp:ListItem>
            <asp:ListItem Value="Katarina Trojacanec">ООП</asp:ListItem>
            <asp:ListItem Value="Mile Jovanov">СП</asp:ListItem>
        </asp:DropDownList>
        
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
        </asp:DropDownList>

    </div>

    <div style="padding-top:10px">
    <asp:Button ID="Button1" runat="server" Text="Гласајте" OnClick="Button1_Click" />
        </div>
    <hr />
    <span>Predmet:</span>
    <div style="padding-bottom:15px">
        <asp:TextBox ID="predmet" runat="server"></asp:TextBox>  
</div>
    <span>Krediti:</span>
    <div>
        <asp:TextBox ID="krediti" runat="server"></asp:TextBox>
    </div>
    <div style="padding-top:33px">
        <asp:Button ID="dodadi" runat="server" Text="Dodadi" OnClick="dodadi_Click" />
    </div>
    <div style="padding-top:15px">
        <asp:Button ID="izbrisi" runat="server" Text="Izbrisi" OnClick="izbrisi_Click" />
    </div>
</asp:Content>
