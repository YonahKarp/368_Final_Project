<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="PurchaseItems.aspx.cs" Inherits="WebApplication.PurchaseItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Welcome&nbsp;
    <asp:Label ID="nameLbl" runat="server" Text="(nameHere)"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Purchase Goods"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Search By: "></asp:Label>
&nbsp;<asp:DropDownList ID="dDownWhere" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Price Above</asp:ListItem>
        <asp:ListItem>Price Below</asp:ListItem>
        <asp:ListItem>Name</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="searchTxt" runat="server" Width="171px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="searchBtn" runat="server" OnClick="searchBtn_Click" Text="Search" />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="errorLbl" runat="server"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="itemsList" runat="server" Height="103px" Width="230px"></asp:ListBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="purchaseBtn" runat="server" OnClick="purchaseBtn_Click" Text="Purchase" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="quantTxt" runat="server" Width="22px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="thankYouLbl" runat="server"></asp:Label>
&nbsp;
</asp:Content>
