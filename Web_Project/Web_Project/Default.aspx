<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-image:url(Cover/Product.jpg);">
        <h1 style="color:white">Sell Bazar</h1>
        <p class="lead" style="color:black">Dress your Dream ..</p>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    <div class="row">
        <div class="col-md-4" style="text-align:center" >
            <h2 style="color:cornflowerblue">Customer Services</h2>
            <p>
                The value consumers place on customer service is growing each year. With texting increasingly becoming the preferred mode of communication, 
                bringing your customer service directly to text makes it a lot easier to deliver feedback. 
                
               
            </p>
            <p>
                <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>--%>
            </p>
        </div>
        <div class="col-md-4" style="text-align:center">
            <h2 style="color:cornflowerblue">Buy and Sell</h2>
            <p>
                Customer services is just one aspect of the bigger picture: the customer experience. 
                People want to feel connected to your brand, and follow up texts are a great way to re-engage people with your business.

            </p>
            <p>
                <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>--%>
            </p>
        </div>
        <div class="col-md-4" style="text-align:center">
            <h2 style="color:cornflowerblue">Trade Services</h2>
            <p>
                You can easily find tread services that offers the right mix of features and price for your products.
                The value consumers place on customer service is growing each year. With texting increasingly becoming the preferred mode of communication.

            </p>
            <p>
                <%--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>--%>
            </p>
        </div>
    </div>

</asp:Content>
