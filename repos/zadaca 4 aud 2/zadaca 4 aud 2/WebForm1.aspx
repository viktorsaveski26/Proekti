<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="zadaca_4_aud_2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style ="padding-bottom:10px">
        <span style="padding-right:116px">Име на валута</span>
    <asp:TextBox ID="currencyName" runat="server"></asp:TextBox>
        </div>
   
    <div>
         <span>Вредност во денари на валута</span>
    <asp:TextBox ID="currencyValue" runat="server"></asp:TextBox>
        </div>
    <div style ="margin-left:350px; padding-top:10px">
    <asp:Button ID="save" runat="server" Text="dodaj valuta" OnClick ="save_Click"/>
        <asp:Button ID="delete" runat="server" Text="izbrisi valuta" OnClick ="delete_Click"/>
        </div>
    <div>
        <span>Листа на валути</span>
        <asp:RadioButtonList ID="currencyList" runat="server"></asp:RadioButtonList>
    </div>
    <div style ="margin-left:300px">
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
    <div>
        <span>Vkupno valuti:</span>
        <asp:Label ID="Total" runat="server" Text="0"></asp:Label>
    </div>
    <div>
        <span>Status:</span>
    <asp:Label ID="status" runat="server" Text=""></asp:Label>
        </div>
</asp:Content>
