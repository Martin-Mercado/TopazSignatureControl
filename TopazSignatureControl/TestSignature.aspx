<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSignature.aspx.cs" Inherits="TopazSignatureControl.TestSignature" %>
<%@ Register TagName="TopazSignatureControl" Src="~/Controls/TopazSignatureControl.ascx" TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc:TopazSignatureControl  ID="TopazSignatureControl" runat="server" />

        <asp:Button ID="ClearSignature" OnClick="ClearSignature_Click" runat="server" Text="Button" />
        <asp:Button ID="ConfirmSignatureBtn"  OnClick="ConfirmSignatureBtn_Click" runat="server" Text="Button" />
    </form>
</body>
</html>
