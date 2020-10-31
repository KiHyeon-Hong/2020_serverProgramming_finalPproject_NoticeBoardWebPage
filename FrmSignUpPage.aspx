<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSignUpPage.aspx.cs" Inherits="_201533892NoticeBoard.FrmSignUpPage" %>

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
                    <td colspan="2">
                        <asp:Label ID="signUpTitle" runat="server" Text="회원가입 정보 입력"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myId" runat="server" Text="아이디 입력 : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="id" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="check" runat="server" Text="중복체크" />
                    </td>
                    <td>
                        <asp:Label ID="checkResult" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myPwd" runat="server" Text="비밀번호 입력 : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myUserName" runat="server" Text="이름 입력 : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myBirth" runat="server" Text="생일 입력 : "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="birthMon" runat="server"></asp:DropDownList>
                        <asp:Label ID="myMon" runat="server" Text="월"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="birthDay" runat="server"></asp:DropDownList>
                        <asp:Label ID="myDay" runat="server" Text="일"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myPhoneNum" runat="server" Text="휴대폰 번호 입력 : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="phoneNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="myAlarm" runat="server" Text="알람 수신 여부 : "></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="alarm" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="0">알람 수신 받지 않음</asp:ListItem>
                            <asp:ListItem Value="1">알람 수신 받음</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="signUp" runat="server" Text="회원가입" OnClick="signUp_Click" />
                    </td>
                    <td>
                        <asp:Button ID="cancel" runat="server" Text="취소" PostBackUrl="~/FrmLoginPage.aspx" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
