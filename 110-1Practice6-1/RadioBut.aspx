<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioBut.aspx.cs" Inherits="_110_1Practice6_1.RadioBut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:RadioButton ID="rb_V1" runat="server" GroupName="姓別" value="male" Text="男" Checked ="True" />
        <asp:RadioButton ID="rb_V2" runat="server" GroupName="姓別" value="female" Text="女" />
        <asp:Button ID="btn_sub" runat="server" Text="確定" PostBackUrl="~/RadioButCom.aspx" />
        </div>
    </form>
</body>
</html>
