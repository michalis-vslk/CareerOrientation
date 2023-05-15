<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="CareerOrientation.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 761px;
        }
    </style>
</head>
<body>
    
        <form runat="server">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        <div>
            <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:RadioButtonList ID="rbOptions" runat="server" RepeatDirection="Vertical">
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
        </div>
    </form>
        
    
</body>
</html>
