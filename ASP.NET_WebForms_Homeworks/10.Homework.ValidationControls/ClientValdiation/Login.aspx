<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClientValdiation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div data-valmsg-summary="true">
                <ul><li style="display:none"></li></ul>
            </div>
            <asp:TextBox runat="server" ID="userName" />
            <asp:RequiredFieldValidator
                runat="server"
                ID="RequiredFieldValidator1"
                ControlToValidate="userName"
                EnableClientScript="true"
                ErrorMessage="User name is required"
                ForeColor="Red"
                Display="Dynamic" />
            <asp:Button runat="server" ID="submit" Text="Register" OnClick="submit_Click" />
        </div>
    </form>
</body>
</html>
