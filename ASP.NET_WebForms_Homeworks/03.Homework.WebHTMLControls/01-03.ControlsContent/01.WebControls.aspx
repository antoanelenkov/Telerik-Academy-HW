<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01.WebControls.aspx.cs" Inherits="_01_03.ControlsContent._01_WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="lowerBound">Lower range bound:</label>
            <input runat="server" type="number" min="1" max="1000" step="1" id="lowerBound" />
            <label for="upperBound">Upper range bound:</label>
            <input runat="server" type="number" min="1" max="1000" step="1" id="upperBound" />
            <input runat="server" id="submitBntn" type="button"  value="Submit" onserverclick="SubmitBtn_ServerClick"/>
            <p id="randomlyGeneratedNumber" runat="server"></p>
        </div>
    </form>
</body>
</html>
