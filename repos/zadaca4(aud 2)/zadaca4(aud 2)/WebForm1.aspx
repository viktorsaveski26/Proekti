<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="zadaca4_aud_2_.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <span style=" padding-right: 120px">Ime na valuta:</span>
        
        <asp:TextBox ID="currencyName" runat="server"></asp:TextBox>
    </div>
    <div style ="padding-top:10px">
        <span>Vrednost vo denari na valutata:</span>
        <asp:TextBox ID="currencyValue" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="save" runat="server" Text="Zacuvaj" />
    </div>
</asp:Content>