<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <%--<div>
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/dsa.jpg" />
   </div>--%>
    <div>
<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Content/dsa.jpg" OnClick="ImageButton1_Click" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
