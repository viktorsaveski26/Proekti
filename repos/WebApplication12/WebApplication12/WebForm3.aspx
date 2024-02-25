<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication12.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin: 20px;">
       <div class="row">
           <div class="col-md-3">
               <asp:TextBox ID="phone" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator
                   class="text-danger"
                   ID="RequiredFieldValidator1"
                   runat="server"
                   ErrorMessage="Poleto za telefon e zadolzielno!"
                   ControlToValidate="phone">

               </asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                   runat="server" 
                   ValidationExpression="\+389 7[0-8] \d{3} \d{3}"
                   ControlToValidate="phone"
                   ErrorMessage="Vnesenata vrednost e nevalidna"></asp:RegularExpressionValidator>
           </div>
       </div>

     

       <div class="row" style="margin-left: 0px; margin-top: 10px;">
           <asp:Button ID="Button1" runat="server" Text="Registriraj se" OnClick="Button1_Click" />
       </div>
        <div class="row" style="margin-left: 0px; margin-top: 10px;">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       </div>
        
   </div>
</asp:Content>
