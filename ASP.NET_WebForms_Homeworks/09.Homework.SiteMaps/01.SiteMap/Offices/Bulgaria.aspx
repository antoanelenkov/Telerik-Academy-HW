<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bulgaria.aspx.cs" Inherits="_01.SiteMap.Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div>
        Welcome to our offices in Bulgaria!
        <br />
         <asp:Menu ID="NavigationMenu" runat="server" CssClass="verticalMenu"
             EnableViewState="False" IncludeStyleBlock="False" SkipLinkText=""
             DataSourceID="SiteMapDataSource">
         </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server"
            ShowStartingNode="False" StartingNodeOffset="1" />
    </div>
</asp:Content>
