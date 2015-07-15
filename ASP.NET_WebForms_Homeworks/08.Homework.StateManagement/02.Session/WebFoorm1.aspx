<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFoorm1.aspx.cs" Inherits="_02.Session.WebFoorm1" %>

<%--Create a ASP.NET Web Form which appends the
input of a text field when a button is clicked in the
Session object and then prints it in a <asp:Label>
control. Use List<string> to keep all the text lines
entered in the page during the session lifetime.--%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="input_txt" />
            <asp:Button runat="server" ID="input_btn" OnClick="input_btn_Click" Text="Add text"/>
            <asp:Label runat="server" ID="currentOutput_lbl" />
            <asp:ListBox runat="server" ID="output_lbx" />
        </div>
    </form>
</body>
</html>
