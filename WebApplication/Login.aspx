<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Names="Segoe Script" Font-Size="Larger" Text="Welcome!"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label2" runat="server" Font-Italic="False" Font-Names="Segoe Script" Text="Login"></asp:Label>
&nbsp;: </p>
    Username :&nbsp;&nbsp; <asp:TextBox ID="userTxt" runat="server" style="margin-top: 12px"></asp:TextBox>
    <br />
    Password :&nbsp;&nbsp; <asp:TextBox ID="passTxt" runat="server" style="margin-top: 12px"></asp:TextBox>
&nbsp;
<br />
&nbsp;<asp:Label ID="errorLbl" runat="server" ForeColor="#993300" Text="That username/password combination is invalid" Visible="False"></asp:Label>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
</asp:Content>
