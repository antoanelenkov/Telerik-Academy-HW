<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05.Repeater.aspx.cs" Inherits="_02_05.Northwind.Pages._05_Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="RepeaterCustomers" runat="server" ItemType="_02_05.Northwind.Customer">
        <ItemTemplate>
            <%#: Item.FirstName + " " +Item.LastName +" with age of "+Item.Age %>
            <hr>
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
