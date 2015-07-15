<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04.ListView.aspx.cs" Inherits="_02_05.Northwind.Pages._03_ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListView ID="ListViewEmployees" runat="server" ItemType="_02_05.Northwind.Customer">
                <LayoutTemplate>
                    <h2>Customers</h2>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemSeparatorTemplate>
                    <hr />
                </ItemSeparatorTemplate>
                <ItemTemplate>
                    <div>
                        <h3><%#: Item.FirstName + " "+ Item.LastName %></h3>
                        Age: <%#: Item.Age %>
                        <br />
                    </div>
                </ItemTemplate>
            </asp:ListView>
    </div>
    </form>
</body>
</html>
