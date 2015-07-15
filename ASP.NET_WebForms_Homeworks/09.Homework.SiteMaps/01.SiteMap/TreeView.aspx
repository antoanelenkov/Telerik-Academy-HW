<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="_01.SiteMap.TreeView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>TreeView</h1>
    <asp:TreeView runat="server" DataSourceID="SiteMapDataSource"></asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" />
</asp:Content>
