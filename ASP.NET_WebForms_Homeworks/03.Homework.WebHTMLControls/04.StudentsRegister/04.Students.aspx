<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04.Students.aspx.cs" Inherits="_01_03.ControlsContent._04_Students" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server"
            HeaderText="There were errors on the page:" />
        <div>
            <asp:RequiredFieldValidator runat="server"
                ControlToValidate="tbxFirstName"
                ErrorMessage="User first name is required.">*
            </asp:RequiredFieldValidator>
            <asp:Label runat="server" Text="First Name" AssociatedControlID="tbxFirstName" />
            <asp:TextBox runat="server" ID="tbxFirstName" />
        </div>
        <div>
             <asp:RequiredFieldValidator runat="server"
                ControlToValidate="tbxLastName"
                ErrorMessage="User last last is required.">*
            </asp:RequiredFieldValidator>
            <asp:Label runat="server" Text="Last Name" AssociatedControlID="tbxLastName" />
            <asp:TextBox runat="server" ID="tbxLastName" />
        </div>
        <div>
             <asp:RequiredFieldValidator runat="server"
                ControlToValidate="tbxFN"
                ErrorMessage="User F.N. is required.">*
            </asp:RequiredFieldValidator>
            <asp:Label runat="server" ID="lblFN" Text="First Name" AssociatedControlID="tbxFN" />
            <asp:TextBox runat="server" ID="tbxFN" />
        </div>
        <div>
            <asp:Label runat="server" Text="University: " />
            <asp:DropDownList runat="server" ID="DropDownListOfUniv">
                <asp:ListItem runat="server" Text="UNWE" />
                <asp:ListItem runat="server" Text="UACG" />
                <asp:ListItem runat="server" Text="SU" />
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label runat="server" Text="Specialty: " />
            <asp:DropDownList runat="server" ID="DropDownListOfSpec">
                <asp:ListItem Text="Civil Engineer" />
                <asp:ListItem Text="Programmer" />
                <asp:ListItem Text="Accounter" />
                <asp:ListItem Text="Playboy" />
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label runat="server" Text="Course: " />
            <asp:CheckBoxList runat="server" ID="CheckBoxListOfCourses">
                <asp:ListItem Text="English" />
                <asp:ListItem Text="MacroEconomics" />
                <asp:ListItem Text="Strength of materials" />
                <asp:ListItem Text="Math" />
            </asp:CheckBoxList>
        </div>
        <asp:Button runat="server" ID="btnRegister" OnClick="RegisterStudent" Text="Register" />
        <div runat="server" id="result">
        </div>
    </form>
</body>
</html>
