<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Practice.aspx.cs" Inherits="Practice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="load_Products" runat="server" Text="Load Products" OnClick="load_Products_Click" />
    <asp:Button ID="load_customer" runat="server" Text="Load customer with orders" OnClick="load_customer_Click" />
    <br />
    <asp:dropdownlist ID="Drop1" runat="server">
    </asp:dropdownlist>
    <asp:DropDownList ID="Drop2" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
</asp:Content>

