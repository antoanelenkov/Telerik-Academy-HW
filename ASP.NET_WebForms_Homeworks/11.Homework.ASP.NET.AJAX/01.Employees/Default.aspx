<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.Employees.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

                    <asp:DropDownList
                        runat="server"
                        ID="employees_lbx"
                        OnSelectedIndexChanged="employees_lbx_SelectedIndexChanged"
                        AutoPostBack="true" />

                    <asp:UpdateProgress runat="server">
                        <ProgressTemplate>
                            <img src="loading.gif" width="50" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>

                    <asp:GridView
                        runat="server"
                        ID="orders_grid"
                        AutoGenerateColumns="true">
                    </asp:GridView>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
