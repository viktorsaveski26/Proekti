<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication20.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <span>Korisnicko ime</span>
    <asp:TextBox ID="ime" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator
        class="text-danger"
        ID="RequiredFieldValidator1"
        runat="server"
        ControlToValidate="ime"
        ErrorMessage="Ne smee da nema ime"></asp:RequiredFieldValidator>
   
       
</div>
    <div>
        <span>Lozinka</span>
        <asp:TextBox ID="lozinka" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ControlToValidate="lozinka"
            ID="RequiredFieldValidator2"
            
            runat="server" ErrorMessage="Ne smee da nema password"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            ID="RegularExpressionValidator1" 
            ControlToValidate="lozinka"
            class="text-danger"
            runat="server" ErrorMessage="Mora specijalen znak" ValidationExpression="\w+[\^!-]+"></asp:RegularExpressionValidator>
    </div>
    <div>
        <span>Email</span>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            class="text-danger"
            ID="RequiredFieldValidator3"
            runat="server"
            ControlToValidate="email"
            ErrorMessage="Ne smee da nema email"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            class="text-danger"
            ID="RegularExpressionValidator2" 
            runat="server" 
            ControlToValidate="email"

            ErrorMessage="Emailot ne e vo validen format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Najavi se" OnClick="Button1_Click" />
    </div>

</asp:Content>
