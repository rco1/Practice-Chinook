<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FirstSample.aspx.cs" Inherits="Queries_FirstSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Enitity vs linq to entity query</h1>
    <asp:GridView ID="EntityFrameworkList" runat="server" DataSourceID="ObjectDataSource1"></asp:GridView>

    
</asp:Content>

