<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_1zadacaa.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
        <div style="padding-bottom:10px">
        <span>Vnesete ime na valuta:</span>
        <asp:TextBox ID="ime_Valuta" runat="server"></asp:TextBox>
            </div>
         <div style="padding-bottom:10px">
        <span style="margin-left:-35px">Vnesete vrednost na valuta:</span>
            
        <asp:TextBox ID="vrednost_Valuta" runat="server"></asp:TextBox>
                 </div>
          
        <div style="margin-left:286px">
            <asp:Button ID="dodadi_Valuta" runat="server" Text="Dodaj" OnClick="DodadiValuta_Click" />
            <asp:Button ID="izbrisi_Valuta" runat="server" Text="izbrisi" OnClick="IzbrisiValuta_Click"/>
            <asp:Button ID="Button1" runat="server" Text="viktor" />
            </div>
       
        <div>
            <asp:RadioButtonList ID="lista_Valuti" runat="server" ></asp:RadioButtonList>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <span>Brojot na stavki vo listata e </span>
            <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>

        </div>
        <div>
            <span> Vnesete vrednost:</span>
            <asp:TextBox ID="Vrednost" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="promena" runat="server" Text="Label"></asp:Label>
        </div>
      

    </div>
</asp:Content>