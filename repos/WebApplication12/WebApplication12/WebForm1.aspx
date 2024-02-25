<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication12.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin: 20px;">
       <div class="row">
           <div class="col-md-3">
               <asp:DropDownList ID="cities" runat="server">
                   <asp:ListItem>(grad)</asp:ListItem>
                   <asp:ListItem>Ohrid</asp:ListItem>
                   <asp:ListItem>Skopje</asp:ListItem>
                   <asp:ListItem>Veles</asp:ListItem>
               </asp:DropDownList>
           </div>
           <div class="col-md-9 text-left">
               <asp:RequiredFieldValidator 
                   class="text-danger"
                   ID="cityVal"
                   runat="server"
                   InitialValue="(grad)"
                   ControlToValidate="cities"
                   ErrorMessage="Izberete grad odd listata"></asp:RequiredFieldValidator>
           </div>
       </div>

       

       <div class="row" style="margin-left: 0px; margin-top: 10px;">
           <asp:Button ID="Submit" runat="server" Text="Zacuvaj" OnClick="Submit_Click" />
       </div>
            <div class="row" style="margin-left: 0px; margin-top: 10px;">
                <asp:Label ID="Label1" runat="server" Text="Selektiraniot grad e:"></asp:Label>       </div>
   </div>   
</asp:Content>
