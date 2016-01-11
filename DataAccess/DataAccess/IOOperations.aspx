<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IOOperations.aspx.cs" Inherits="DataAccess.IOOperations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label> Comments</asp:Label>
            <asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:TextBox runat="server" ID="txtfileName" />
        </div>
        <div>
            <asp:Button Text="Write to Currect Directory" runat="server" ID="btnCurrentDir" OnClick="btnCurrentDir_Click" />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
