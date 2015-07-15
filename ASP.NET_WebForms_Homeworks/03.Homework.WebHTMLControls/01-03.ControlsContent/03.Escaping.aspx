<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="03.Escaping.aspx.cs" Inherits="_01_03.ControlsContent._03_Escaping"  ValidateRequest="false"%> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server" />
            <asp:Button ID="btnResult" runat="server" OnClick="EscapeText" Text="convert text" />
            <asp:Label ID="lblResult" runat="server" Text="</br>Waiting for input..." />
        </div>
    </form>
</body>
</html>
