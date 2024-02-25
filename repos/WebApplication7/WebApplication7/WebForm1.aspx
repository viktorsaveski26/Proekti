<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <span>Izberete boja na pozadina</span>
        <asp:DropDownList ID="color" runat="server"></asp:DropDownList>
    </div>
    <div>
        <span>Izberete font</span>
        <asp:DropDownList ID="font" runat="server"></asp:DropDownList>
    </div>
    <div>
        <span>Izberete boja na font/span>
        <asp:DropDownList ID="boja_Font" runat="server"></asp:DropDownList>
    </div>
    <div>
        <span>Izberete goleima na font</span>
        <asp:TextBox ID="golemina_font" runat="server"></asp:TextBox>
    </div>
    <div>
        <span>Izberete tip na ramka</span>
        <asp:RadioButtonList ID="tip_Ramka" runat="server"></asp:RadioButtonList>
    </div>
    <div>
        <span>SLika </span>
        <asp:CheckBox ID="ShowImg" runat="server" />
    </div>
    <div>
        <span></span>
        <asp:TextBox ID="ShortText" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Save" runat="server" Text="Button" OnClick="Save_Click" />
    </div>
    <asp:Panel ID="Cestitka" runat="server"></asp:Panel>

  

    </span>

  

</asp:Content>
