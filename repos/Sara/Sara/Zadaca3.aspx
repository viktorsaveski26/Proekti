<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Zadaca3.aspx.cs" Inherits="Sara.Zadaca3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class row="class">
        <div class="m-4">
            <asp:Image ID="Image1" runat="server" ImageUrl="slika1.png" />
            <asp:ImageButton ID="ImageButton1" runat="server" />
        </div>
         <div class="m-4">
            <asp:Image ID="Image2" runat="server" />
            <asp:ImageButton ID="ImageButton2" runat="server" />
        </div>
         <div class="m-4">
            <asp:Image ID="Image3" runat="server"/>
            <asp:ImageButton ID="ImageButton3" runat="server" />
        </div>
         <div class="m-4">
            <asp:Image ID="Image4" runat="server" />
            <asp:ImageButton ID="ImageButton4" runat="server" />
        </div>
        </div>
</asp:Content>
