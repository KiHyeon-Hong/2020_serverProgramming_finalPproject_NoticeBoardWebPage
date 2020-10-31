<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMainPage.aspx.cs" Inherits="_201533892NoticeBoard.FrmMainPage" %>

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
            <asp:DropDownList ID="searchCriteria" runat="server">
                <asp:ListItem Value="0">제목</asp:ListItem>
                <asp:ListItem Value="1">내용</asp:ListItem>
                <asp:ListItem Value="2">작성자</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="searchText" runat="server"></asp:TextBox>
            <asp:Button ID="search" runat="server" Text="검색" />
            <hr />
            <asp:Label ID="board" runat="server" Text=""></asp:Label>
            <hr />
            <asp:Button ID="addBoard" runat="server" Text="글 추가" OnClick="addBoard_Click" />
        </div>
    </form>
</body>
</html>
