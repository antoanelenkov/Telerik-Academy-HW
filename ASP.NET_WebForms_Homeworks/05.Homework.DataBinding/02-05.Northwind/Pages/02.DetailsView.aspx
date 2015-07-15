<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02.DetailsView.aspx.cs" Inherits="_02_05.Northwind._02_DetailsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView ID="DtlsViewCustomers" runat="server" AutoGenerateRows="true"/>
        <asp:LinkButton NavigateUrl="~/GridView.aspx" runat="server"  Text="Back"/>        
    </div>
    </form>
</body>
</html>
