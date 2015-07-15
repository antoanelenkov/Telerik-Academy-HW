<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="03.FormView.aspx.cs" Inherits="_02_05.Northwind._03_DetailView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView runat="server" ID="FormView_Customers" AllowPaging="True"
                OnPageIndexChanging="FormViewEmployees_PageIndexChanging" ItemType="_02_05.Northwind.Customer">
                <ItemTemplate>
                    <h4><%#: Item.FirstName + " " + Item.LastName %></h4>
                    <ul>
                        <li>
                            <%#:"Age: "+ Eval("Age") %>
                        </li>
                    </ul>
                </ItemTemplate>
            </asp:FormView>
            <asp:HyperLink NavigateUrl="~/GridView.aspx" runat="server" Text="Back" />
        </div>
    </form>
</body>
</html>
