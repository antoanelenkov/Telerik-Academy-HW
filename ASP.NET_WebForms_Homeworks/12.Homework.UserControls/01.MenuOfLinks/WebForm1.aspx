<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_01.MenuOfLinks.WebForm1" %>

<%@ Register Src="UserControl/MenuOfLinks.ascx" TagName="MenuOfLinks"
    TagPrefix="userControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <userControls:MenuOfLinks runat="server" ID="menu1" FontColor="Yellow" />
        </div>
    </form>
</body>
</html>
