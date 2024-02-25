<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="WebApplication14.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <span>Ime</span>
        <asp:TextBox ID="ime" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ID="RequiredFieldValidator1"
            runat="server" 
            ErrorMessage="Vnesete Ime"
            ControlToValidate="ime"></asp:RequiredFieldValidator>
    </div>
    <div>
        <span>Lozinka</span>
        <asp:TextBox ID="lozinka" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ID="RequiredFieldValidator2" 
            runat="server" 
            ErrorMessage="Vnesete Lozinka" 
            ControlToValidate="lozinka"></asp:RequiredFieldValidator>
    </div>
    <div>
        <span>E-adresa</span>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ID="RequiredFieldValidator3" 
            runat="server" 
            ErrorMessage="Vnesete Email"
            ControlToValidate="email"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator 
            class="text-danger"
            ID="RegularExpressionValidator1"
            runat="server"
            ErrorMessage="Formatot na adresata ne e validen"
            ControlToValidate="email" ValidationExpression="\w+@\w+\.\w+"></asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Najavete se" OnClick="Button1_Click" />
    </div>
</asp:Content>
