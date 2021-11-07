<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="_110_1Practice6_1.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <asp:RadioButton ID="rb_V1" runat="server" GroupName="book" value="buy" Text="購買" Checked="True" />
         <asp:RadioButton ID="rb_V2" runat="server" GroupName="book" value="nbuy" Text="不購買" Checked="True" />
         <asp:CheckBox ID="ch_V1" runat="server" GroupName="book" value="book1" Text="科幻書" Checked="True" />
         <asp:CheckBox ID="ch_V2" runat="server" GroupName="book" value="book2" Text="教科書" />
         <asp:Button ID="btn_sub" runat="server" Text="Button" PostBackUrl="~/CheckBoxCom.aspx" />
        </div>
    </form>
</body>
</html>
