<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_03.Cookies.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Go to next page if you have logged in and the cookie has not expired:
        <br />
            <asp:Button runat="server" ID="login_btn" OnClick="login_btn_Click" Text="Log in!" />
            <br />
            <asp:Button runat="server" ID="redirect_btn" OnClick="redirect_btn_Click" Text="Go to the next page!" />(If you are logged in!)
        </div>
    </form>
</body>
</html>
