<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="WebApplication13.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-bottom:10px">
        <span style="margin-left:34px">Ime</span>
        <asp:TextBox ID="ime" runat="server" OnTextChanged="ime_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ID="RequiredFieldValidator1"
            runat="server" ErrorMessage="Vnesete ime" 
            ControlToValidate="ime"></asp:RequiredFieldValidator>
    </div>
    <div style="margin-left:9px"
        <span style="margin-left:13px">Lozinka</span>
        <asp:TextBox ID="lozinka" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            class="text-danger"
            ID="RequiredFieldValidator2" 
            runat="server"
            ErrorMessage="Vnesete lozinka"
            ControlToValidate="lozinka"
            ></asp:RequiredFieldValidator>
    </div>
    <div style="padding-top:10px">
        <span>E-adresa</span>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            class="text-danger"
            ID="RequiredFieldValidator3" 
            runat="server" 
            ErrorMessage="Vnesi email"
            ControlToValidate="email"
            ></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator 
            class="text-danger"
            ID="RegularExpressionValidator1" 
            runat="server" 
            ValidationExpression="\w+@\w+\.\w+"
            ErrorMessage="Nevaliden format"
            ControlToValidate="email"
            ></asp:RegularExpressionValidator>
    </div>
    <div style="padding-top:10px">
    <div style="margin-left:65px">
        <asp:Button ID="Button1" runat="server" Text="Najavete se" OnClick="Button1_Click" />
    </div>
        </div>
</asp:Content>
