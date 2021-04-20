<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample1.aspx.cs" Inherits="_109_2Mid.Sample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><h1>會員註冊</h1></div>
            <div>
                <asp:Label ID="lb_Acc" runat="server" Text="會員帳號" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="tb_Acc" runat="server" Height="15px" Width="200px"></asp:TextBox>
                </br>
                <asp:Label ID="lb_Pass" runat="server" Text="密碼" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="tb_Pass" runat="server" Height="15px" Width="200px" TextMode="Password"></asp:TextBox>.
                </br>
                <asp:Label ID="lb_rbg_Interest" runat="server" Text="興趣(單選)" Font-Size="X-Large"></asp:Label>
                <asp:RadioButton ID="rb_book" runat="server" Text="看書"  AutoPostBack="True" />
                <asp:RadioButton ID="rb_game" runat="server" Text="打電動" AutoPostBack="True"  />
                <asp:RadioButton ID="rb_other" runat="server" Text="其他" AutoPostBack="True"/>
                </br>
                <asp:Label ID="otherurl" runat="server" Text="其他連結" Font-Size="X-Large"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://aws.amazon.com/tw/" ImageUrl="~/aws-brands.svg" Height="30px" Width="30px"></asp:HyperLink>
                <br />
                <asp:Button ID="bt_Next" runat="server" Text="送出" ButtonOnclick="bt_Next_Click" Width="80px" Height="30px" PostBackUrl="~/Sample1Com.aspx" />

            </div>
        </div>
    </form>
</body>
</html>
