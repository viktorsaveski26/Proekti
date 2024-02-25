<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication12.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="margin: 20px;">
        <div class="row" style="margin-top:10px">
            <asp:ValidationSummary class="text-danger" ID="ValidationSummary1" runat="server" ValidationGroup="grupa1" />
        </div>
       <div class="row">
           <div class="col-md-3">
               <asp:TextBox ID="name" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator 
                   class="text-danger"
                   ID="RequiredFieldValidator1"
                   runat="server"
                   ErrorMessage="Zadolzitelno  e poleto za e-mail"
                   ControlToValidate="name" Display="None" ValidationGroup="grupa1"></asp:RequiredFieldValidator>
           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
               <asp:TextBox ID="grade" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
                <asp:RequiredFieldValidator 
                   class="text-danger"
                   ID="RequiredFieldValidator2"
                   runat="server"
                   ErrorMessage="Zadolzitelno  e poleto za otcena"
                   ControlToValidate="grade"  Display="None"></asp:RequiredFieldValidator>
               <asp:RangeValidator 
                   class="text-danger"
                   ID="RangeValidator1" 
                   runat="server" 
                   ErrorMessage="Vnesenata vrednost za ocenka e nevalidna" 
                  MaximumValue="10"   MinimumValue="5"
                   Type="Integer"
                   
                   ControlToValidate="grade"  Display="None"></asp:RangeValidator>
           </div>
       </div>

       <div class="row" style="margin-top: 10px;">
           <div class="col-md-3">
               <asp:TextBox ID="date" runat="server" style="width: 100%"></asp:TextBox>
           </div>
           <div class="col-md-9 text-left">
                <asp:RequiredFieldValidator 
                   class="text-danger"
                   ID="RequiredFieldValidator3"
                   runat="server"
                   ErrorMessage="Zadolzitelno  e poleto za datum"
                   ControlToValidate="date"  Display="None"></asp:RequiredFieldValidator>
               <asp:CompareValidator 
                   class="text-danger"
                   ID="CompareValidator1"
                   runat="server"
                  ControlToValidate="date"
                   ValueToCompare="2023-03-27"
                    
                   ErrorMessage="Ne moze takov datum" Operator="LessThanEqual"  Display="None"></asp:CompareValidator>
           </div>
       </div>

       <div class="row" style="margin-left: 0px; margin-top: 10px;">
           <asp:Button ID="Submit" runat="server" Text="Vnesi" ValidationGroup="grupa1" OnClick="Submit_Click" />
       </div>
         <div class="row" style="margin-left: 0px; margin-top: 10px;">
             <asp:Label CssClass="text-success" ID="Label1" runat="server" Text=""></asp:Label>
       </div>
   </div>
</asp:Content>
