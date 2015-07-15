<!--01.Create a simple ASPX page that enters a name and
prints "Hello" + name in the page. Use a TextBox +
Button + Label.-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.SimpleASPXpage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label   Text="Enter your name" runat="server"/>
        <asp:TextBox ID="TbName" runat="server" />
        <asp:Button runat="server" Text="greet" OnClick="OnGreet_Click" />
        <asp:Label  ID="LblGreeting"  runat="server"/>
    </div>
    </form>
</body>
</html>
