<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="CareerOrientation.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="TestTable" runat="server">
            <asp:TableRow><asp:TableHeaderCell>Questions</asp:TableHeaderCell></asp:TableRow>
        </asp:Table>
                <asp:Button runat="server" Text="submit" ID="button1" class="opt" OnClick="submitButton_Click" />

    </form>
</body>
</html>
