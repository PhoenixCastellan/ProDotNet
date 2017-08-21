<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleTest.aspx.cs" Inherits="AspxPageLifeCycle.SimpleTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="aspbtn_TestPostBack" runat="server" OnClick="aspbtn_TestPostBack_Click" Text="提交" />
    </form>
</body>
</html>
