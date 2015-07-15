<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuOfLinks.ascx.cs" Inherits="_01.MenuOfLinks.MenuOfLinks" %>

<asp:DataList runat="server" ID="dataList">
    <ItemTemplate>
        <asp:HyperLink runat="server" NavigateUrl='<%# Eval("Url") %>' Text='<%# Eval("Name") %>'></asp:HyperLink>
    </ItemTemplate>
</asp:DataList>