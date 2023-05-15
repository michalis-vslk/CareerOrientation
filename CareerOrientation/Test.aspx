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
    
        <form id="form1" runat="server">
    
        <asp:Label ID="testlabel" runat="server">hey</asp:Label>
   <br />
         <asp:Button ID="Button1" runat="server" Text="Button" OnClick="showTest_Click"/>
        
        <iframe runat="server" id="frame" width="100%" class="auto-style1"></iframe>
        
    
           
        </form>
        
    
</body>
</html>
