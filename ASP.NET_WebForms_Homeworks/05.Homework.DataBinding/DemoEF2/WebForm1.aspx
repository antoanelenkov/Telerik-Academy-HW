<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoEF2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:ListBox runat="server" ID="ListBoxCustomers" DataSourceID="EntityDataSource1" DataTextField="CompanyName" DataValueField="CustomerID" Rows="20">
    <asp:ListItem Value="CustomerID">CustomerName</asp:ListItem>
        </asp:ListBox>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=NorthwindEntities1" DefaultContainerName="NorthwindEntities1" EnableFlattening="False" EntitySetName="Customers" Select="it.[CustomerID], it.[CompanyName]">
        </asp:EntityDataSource>
    </form>
</body>
</html>
