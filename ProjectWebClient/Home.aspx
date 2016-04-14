<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectWebClient.Home" Theme="TemaDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="lib/bootstrap/Content/bootstrap.min.js"></script>
    <script type="text/javascript" src="lib/WinJS/js/base.min.js"></script>
    <script type="text/javascript" src="lib/WinJS/js/ui.min.js"></script>

    <link rel="stylesheet" href="lib/bootstrap/Content/bootstrap.css" />
    <link rel="stylesheet" href="lib/WinJS/css/ui-light.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" runat="server">
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <button class="navbar-toggle collapsed" type="button" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand win-h2" href="#">Brand</a>
            </div>
        </div>
    </nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
</asp:Content>
