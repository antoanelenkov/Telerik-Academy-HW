<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorldMap.aspx.cs" Inherits="_01.Continents.WorldMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td id="continentError" runat="server" colspan="3"></td>
                        </tr>
                        <tr id="Continents">
                            <td>Choose Continent
                            <br />
                                <asp:ListBox runat="server" ID="ListBox_continents" AutoPostBack="True"
                                    OnSelectedIndexChanged="ListBoxContinents_SelectedIndexChanged" />
                            </td>
                            <td>Name of continent
                                    <asp:TextBox ID="tbContinent" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnInsertContinent" runat="server" OnClick="InsertContienent_OnClick" Text="Add" />
                            </td>
                            <td>
                                <asp:Button ID="btnDeleteContinent" runat="server" OnClick="DeleteContienent_OnClick" Text="Delete" />
                            </td>
                        </tr>

                        <tr id="Countries" runat="server">
                            <td>
                                <asp:ListBox runat="server" ID="ListBox_Countries" AutoPostBack="True"
                                    OnSelectedIndexChanged="ListBoxCountries_SelectedIndexChanged" />
                            </td>
                            <td>Name of country
                        <asp:TextBox ID="tbCountry" runat="server"></asp:TextBox>
                                <br />
                            </td>
                            <td>
                                <asp:Button ID="btnInsertCountry" runat="server" OnClick="btnInsertCountry_Click" Text="Add" />
                            </td>
                            <td>
                                <asp:Button ID="btnDeleteCountry" runat="server" OnClick="btnDeleteCountry_Click" Text="Delete" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:UpdateProgress runat="server">
                                    <ProgressTemplate>
                                        Loading...
                                    </ProgressTemplate>
                                </asp:UpdateProgress>
                            </td>
                        </tr>
                        <tr id="Towns" runat="server">
                            <td colspan="3">
                                <asp:GridView runat="server" ID="GridView_Towns"
                                    AutoPostBack="True"
                                    AutoGenerateColumns="False"
                                    AllowSorting="true"
                                    OnSorting="SortTowns">
                                    <Columns>
                                        <asp:BoundField DataField="Name" HeaderText="Town Name"
                                            SortExpression="name" />
                                        <asp:BoundField DataField="Country.Name" HeaderText="Country Name"
                                            SortExpression="country" />
                                        <asp:BoundField DataField="population" HeaderText="Population"
                                            SortExpression="population" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
