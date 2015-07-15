<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.RegisterUser_ClientValidations.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width: 400px">
                <legend>Register user:</legend>
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:ValidationSummary
                                ID="ValidationSummary1"
                                runat="server"
                                HeaderText="Following error occurs:"
                                ForeColor="Red"
                                ShowMessageBox="false"
                                DisplayMode="BulletList"
                                ShowSummary="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="userName">User name:</label></td>
                        <td>
                            <asp:TextBox runat="server" ID="userName" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator1"
                                ControlToValidate="userName"
                                ErrorMessage="User name is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="password1">Password:</label></td>
                        <td>
                            <asp:TextBox runat="server" ID="password1" TextMode="Password" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator2"
                                ControlToValidate="password1"
                                ErrorMessage="Password is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                            <asp:CompareValidator
                                runat="server"
                                ID="CompareValidator1"
                                ControlToValidate="password1"
                                ControlToCompare="password2"
                                ErrorMessage="Passwords does not match"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="password2">Repeat password:</label></td>
                        <td>
                            <asp:TextBox runat="server" ID="password2" TextMode="Password" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator3"
                                ControlToValidate="password2"
                                ErrorMessage="Password is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="firstName">First name:</label></td>
                        <td>
                            <asp:TextBox runat="server" ID="firstName" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator4"
                                ControlToValidate="firstName"
                                ErrorMessage="First name is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="lastName">Last name:</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="lastName" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator5"
                                ControlToValidate="lastName"
                                ErrorMessage="Last name is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="age">Age:</label></td>
                        <td>
                            <asp:TextBox runat="server" ID="age" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator6"
                                ControlToValidate="age"
                                ErrorMessage="Last name is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                            <asp:RangeValidator
                                runat="server"
                                ID="RangeValidator1"
                                ControlToValidate="age"
                                MinimumValue="18"
                                MaximumValue="81"
                                ErrorMessage="Age must be between 18 and 200!"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="email">Email:</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="email" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator7"
                                ControlToValidate="email"
                                ErrorMessage="Email is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                            <asp:RegularExpressionValidator
                                ID="RegularExpressionValidator1"
                                runat="server"
                                ErrorMessage="Invalid email!"
                                Text="*"
                                ValidationExpression="[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}"
                                ControlToValidate="email" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="localAdress">Local adress:</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="localAdress" Rows="2" TextMode="Multiline" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator8"
                                ControlToValidate="localAdress"
                                ErrorMessage="Local adress is required"
                                Text="*"
                                ForeColor="Red"

                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="phone">Phone:</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="phone" />
                            <asp:RequiredFieldValidator
                                runat="server"
                                ID="RequiredFieldValidator9"
                                ControlToValidate="phone"
                                ErrorMessage="Phone is required"
                                Text="*"
                                ForeColor="Red"
                                Display="Dynamic" />
                            <asp:RegularExpressionValidator
                                ID="RegularExpressionValidator2"
                                runat="server"
                                ErrorMessage="Invalid phone number!"
                                Text="*"
                                ValidationExpression="^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$"
                                                                ForeColor="Red" 
                                ControlToValidate="phone" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="check">I agree with conditions:</label>
                        </td>
                        <td>
                            <asp:CheckBox runat="server" ID="checkBox" />
                            <asp:CustomValidator 
                                runat="server"
                                ID="agree" 
                                OnServerValidate="CheckBoxRequired_AgreeWithRequirements"
                                ForeColor="Red" 
                                Text="*"
                                ErrorMessage="You must first agree with requirements."/>                             
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button runat="server" ID="submit" Text="Register" OnClick="submit_Click" />
            </fieldset>
        </div>
    </form>
</body>
</html>
