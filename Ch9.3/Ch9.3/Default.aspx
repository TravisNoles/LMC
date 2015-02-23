<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Ch9._3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Username: 
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Password: 
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        Confirm Password:&nbsp; <asp:TextBox ID="txtPassConfirm" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_error" runat="server"></asp:Label>
        <br />
        <asp:Button ID="cmdSubmit" runat="server" Text="Submit" />
        <br />
        </div>
    </form>
</body>
</html>
