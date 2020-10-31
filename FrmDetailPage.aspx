<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDetailPage.aspx.cs" Inherits="_201533892NoticeBoard.FrmDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap-theme.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label ID="myTitle" runat="server" Text="제목 : "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="title" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myBody" runat="server" Text="내용 : "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="body" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="boardUpdate" runat="server" Text="Button" OnClick="boardUpdate_Click" />
                    </td>
                    <td>
                        <asp:Button ID="cancel" runat="server" Text="Button" OnClick="cancel_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
