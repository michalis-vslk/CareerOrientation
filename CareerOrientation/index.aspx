<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CareerOrientation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>Επαγγελματικός Προσανατολισμός</title>
</head>
<body>
    <img width="120px" height="100px" src="getDev.png">
    <form action="login.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Log In</button>
                </td>
            </tr>
        </table>
    </form>
    <form action="register.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Register</button>
                </td>
            </tr>
        </table>
    </form>
    
</body>
</html>


