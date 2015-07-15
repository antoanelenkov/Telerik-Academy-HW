<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="_02_05.Northwind._02_GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="EmployeeGridView" AllowPaging="True" PageSize="5" OnPageIndexChanging="grdData_PageIndexChanging" AutoGenerateColumns="false">
                <HeaderStyle BackColor="LightCyan" ForeColor="MediumBlue" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="FirstName" DataNavigateUrlFormatString="Pages/02.DetailsView.aspx?FirstName={0}" DataTextField="FullName" HeaderText="Full Name" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
