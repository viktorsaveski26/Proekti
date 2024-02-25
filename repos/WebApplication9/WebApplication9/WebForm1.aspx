<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin: 20px;">
       <div class="row">
           <div class="col-md-3">
               <asp:TextBox ID="email" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator class = "text-danger" ID="RequiredFieldValidator1" 
                   runat="server"  ControlToValidate="email"
                   ErrorMessage="Zadolzitelno e poleto za email"></asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator class = "text-danger" ID="email_Validator" runat="server" ControlToValidate="email" ValidationExpression="\w+@\w+\.\w+" ErrorMessage="Vrednosta za e-mail e nevalidna"></asp:RegularExpressionValidator>
           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
               <asp:TextBox ID="password" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator class = "text-danger" ID="RequiredFieldValidator2" 
                   runat="server" ControlToValidate="password" ErrorMessage="Zadolzitelno e poleto za password :D"></asp:RequiredFieldValidator>
     <asp:RegularExpressionValidator class = "text-danger" ID="passwordVal" runat="server" ControlToValidate="password" ValidationExpression=".{5,}" ErrorMessage="Vnesenata lozinka e nevalidna"></asp:RegularExpressionValidator>

           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
               <asp:TextBox ID="cpassword" runat="server" style="width: 100%"></asp:TextBox> 
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator class = "text-danger" ID="RequiredFieldValidator3"
                   runat="server" ControlToValidate="cpassword"
                   ErrorMessage="Zadolzitelno e poleto za  lozinka :D"></asp:RequiredFieldValidator>
               <asp:CompareValidator ID="cpassVal"
                   ControlToValidate="cpassword"
                   ControlToCompare="password"
                   runat="server"
                   ErrorMessage="Lozinkite ne se sovpagaat">

               </asp:CompareValidator>
           </div>
       </div>

       <div class="row" style="margin-left: 0px; margin-top: 10px;">
           <div class="col-md-3"></div>
           <div class="col-md-9">
               <asp:Button ID="Register" runat="server" Text="Registriraj se" CssClass="btn btn-primary" OnClick="Register_Click" />
           </div>

       </div>
         <div class="row" style="margin-left: 0px; margin-top: 10px;">
             <asp:Label ID="username" runat="server" Text=""></asp:Label>
             </div>
   </div>
</asp:Content>
