<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web_Project.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="color:cornflowerblue"><%: Title %>Our Contact</h2>
    <address>
        Mirpur-12<br />
        Road, WA 9/A<br />
        <abbr title="Phone">Phone:</abbr>
        425.555.0100
    </address>

    <address>
        <strong style="color:royalblue">Support:</strong><a href="mailto:Support@example.com">sellbazar@example.com</a><br />
        <strong style="color:royalblue">Marketing:</strong> <a href="mailto:Marketing@example.com">sellbazarmarketing@example.com</a>
    </address>
</asp:Content>
