<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication16.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            class="text-danger"
            ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage="Ne smee prazno pole"
            ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            class="text-danger"
            ID="RegularExpressionValidator1" 
            runat="server" ErrorMessage="Ne e mkd "
            ControlToValidate="TextBox1" ValidateRequestMode="Inherit" ViewStateMode="Inherit">
            
        </asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
</asp:Content>
