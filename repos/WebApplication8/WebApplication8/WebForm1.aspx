<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style ="width:300px">
        <div class ="pom" style="background-color:gray">
            <div class ="pom2" style="color:blue">
       <span>Izberete boja na pozadina:</span>
    <div>
     
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>
        
        <span>Izberete font</span>
    <div>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    </div>
        <span>IZberete boja na font</span>
    <div>
        
        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
    </div>
            <span>Vnesete golemina na font</span>
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <span>pt</span>
    </div>
        <span>Tip na ramka</span>
    <div>
      
           <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
    </div>
     
    <div>
      
        <asp:CheckBox ID="CheckBox1" runat="server" />
         <span>Dodadi slika</span>
    </div>
    <span>Vnesete ja sodrzinata na cestitkata</span>
    <div>
        
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Kreiraj" OnClick="Button1_Click" />
    </div>
                  <div>
                     
                      <asp:Panel ID="Panel1" runat="server">
                          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                          <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/noke dinamicka1.jpg" Visible="False" />
                      </asp:Panel>

    </div>
                </div>

        </div>
        </div>
  
</asp:Content>
