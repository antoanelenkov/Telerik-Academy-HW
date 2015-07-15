<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02.ServerControl.aspx.cs" Inherits="_01_03.ControlsContent._01_ServerControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLeft" Text="left bound" runat="server" />
            <asp:TextBox ID="txtLeft" runat="server" />
            <asp:Label ID="lblRight"  Text="right bound" runat="server" />
            <asp:TextBox ID="txtRight" runat="server" />
            <asp:Button ID="btnResult" runat="server" OnClick="GenerateRandomNum" Text="Generate number"/>
            <asp:Label ID="lblResult" runat="server" Text=""/>
        </div>
    </form>
</body>
</html>
