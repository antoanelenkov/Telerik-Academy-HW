<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DupmEvents.aspx.cs" Inherits="_03.DumpAllEvents.DupmEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtBox" runat="server" AutoPostBack="true" OnTextChanged="changed" />
           <asp:Button runat="server" Text="dump button" ID="EventBtn" OnClick="EventBtn_Click" OnUnload="EventBtn_Unload" />
        </div>
    </form>
</body>
</html>
