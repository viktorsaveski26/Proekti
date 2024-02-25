<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication20.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/images.jpg" />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" >
            <asp:ListItem>Drama</asp:ListItem>
            <asp:ListItem>Komedija</asp:ListItem>
            <asp:ListItem>Akcija</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        </div>
    <div>
        <div>
        <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        <div>
         <asp:CheckBox ID="CheckBox2" runat="server" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
        <div>   
         <asp:CheckBox ID="CheckBox3" runat="server" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Kupi" OnClick="Button1_Click" />
    </div>
</asp:Content>
