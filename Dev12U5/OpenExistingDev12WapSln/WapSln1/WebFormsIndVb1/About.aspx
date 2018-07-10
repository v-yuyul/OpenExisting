<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="WebFormsIndVb1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h2><%: ClassLibraryCs1.Class1.sayHello() %>.</h2>
    <p>Your app description page.</p>
    <p>Use this area to provide additional information.</p>
</asp:Content>
