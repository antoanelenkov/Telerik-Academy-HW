<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="U.K.aspx.cs" Inherits="_01.SiteMap.Nutrition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div>
            Welcome to our office in U.K.!
                <br />
         <asp:Menu ID="NavigationMenu" runat="server" CssClass="verticalMenu"
             EnableViewState="False" IncludeStyleBlock="False" SkipLinkText=""
             DataSourceID="SiteMapDataSource">
         </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server"
            ShowStartingNode="False" StartingNodeOffset="1" />
    </div>
</asp:Content>
