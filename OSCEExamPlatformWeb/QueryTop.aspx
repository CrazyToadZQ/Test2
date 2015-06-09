<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryTop.aspx.cs" Inherits="OSCEExamPlatformWeb.QueryTop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/admin.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script language="javascript" type="text/javascript">
        function logout() {
            if (confirm("确定注销当前用户，重新登陆？")) {
                window.location = "logout.aspx";
            } else {
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
   
    <div class="top">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td width="227px" valign="top" align="center" height="64px" >
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/logo.png" 
                        BorderStyle="None" Height="64px" Width="227px" />
                </td>
                <td>
                    <div class="nav">
                        <ul class="TabBarLevel1" id="TabPage1">                            
                          <%=menuStr%>
                          <%-- <li id="Tab1"><a href="/UI/QueryManagement/StudentQueryManagement/StudentQueryExam.aspx" target="mainFrame" onclick="javascript:switchTab('TabPage1','Tab1')">考试查询</a></li>--%>
                        </ul>
                    </div>
                </td>
            </tr>
        </table>
        <div class="righttop">
            <ul>
                <li class="righttophelp"><a href="http://cn.tellyes.com/doc/%E9%94%80%E5%94%AE%E7%BD%91%E7%BB%9C-44.html" target="_blank">
                    购买咨询</a></li>
                <li class="righttopabout"><a id="maticsoft" href="http://cn.tellyes.com/solutions/设计建立实训中心-9.html" target="_blank">
                    关于</a></li>
            </ul>
        </div>
    </div>
    <div class="adminmenu" >
        欢迎您，<%=userTrueName%>
        <em>|</em> <a href="UI/SystemManagement/Accounts/userinfo.aspx" target="mainFrame">基本信息</a> <em>|</em>
        <a href="/UI/QueryManagement/StudentQueryManagement/queryStuInfos.aspx" target="mainFrame">近期信息</a>  <em>|</em>
        <a href="UI/SystemManagement/Accounts/PwdChange.aspx" target="mainFrame">修改密码</a> <em>|</em> 
        <img src="images/cross.png" style=" width:12px;height:12px">
        <a onclick="logout()" href="#">退出</a>
    </div>
    
    <script language="JavaScript" type="text/javascript">
        //Switch Tab Effect
        function switchTab(tabpage, tabid) {
            $("#TabPage1 li").removeClass('Selected');
            $("#TabPage1").find("#" + tabid).addClass('Selected');
        }
    </script>
    </ContentTemplate>
    </asp:UpdatePanel>
    
    </form>
</body>
</html>

