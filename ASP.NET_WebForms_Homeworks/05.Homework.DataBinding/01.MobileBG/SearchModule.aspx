<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchModule.aspx.cs" Inherits="_01.MobileBG.SearchModule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Producer: " />
                        <asp:DropDownList runat="server" ID="DropProducer" AutoPostBack="true" OnSelectedIndexChanged="GetModels"/>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Models: " />
                        <asp:DropDownList runat="server" ID="DropModels" AutoPostBack="true" />
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Engine type: " />
                        <asp:RadioButtonList runat="server" ID="RadioEngine" RepeatDirection="Horizontal"/>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Extras: " />
                        <asp:CheckBoxList runat="server" ID="CheckExtras" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="BtnSubmit" OnClick="GetInfo" Text="Find"/>
                    </td>
                </tr>
                <tr>
                    <td id="result">
                        <asp:Literal runat="server" ID="LitResult" Visible="false"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <link href="Styles.css" rel="stylesheet" />
</body>
</html>
