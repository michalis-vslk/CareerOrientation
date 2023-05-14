<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="CareerOrientation.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <h1>Career Orientation</h1>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="kef1_click">Κεφάλαιο 1:Τεχνολογία Λογισμικού και Ευφυή Συστήματα (ΤΛΕΣ)</asp:LinkButton>
    <br />
     <h3><asp:HyperLink ID="HyperLink2" runat="server">Κεφάλαιο 2 : Προγραμματιστής Web</asp:HyperLink> </h3>
        <br />
    <h3><asp:HyperLink ID="HyperLink3" runat="server">Κεφάλαιο 3 : Ειδικός μηχανικής μάθησης</asp:HyperLink> </h3>
    </form>
</body>
</html>
