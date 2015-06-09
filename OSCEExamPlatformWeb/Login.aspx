<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OSCEExamPlatformWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录</title>
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
            $("#btnLogin").click(function () {
                var uName = $("#txtUserName").val();
                var pwd = $("#txtPwd").val();
                var hfCaptcha = $("#hfCaptcha").val();
                var txtCaptcha = $("#txtCaptcha").val();
                if (uName.length == 0) {
                    //                    alert("必须输入用户名");
                    $("#lblErr").html("必须输入用户名");
                    $("#txtUserName").focus();
                    return false;
                }
                if (pwd.length == 0) {
                    $("#lblErr").html("必须输入密码");
                    $("#txtPwd").focus();
                    return false;
                }
//                if (txtCaptcha.length == 0) {
//                    $("#lblErr").html("必须输入验证码");
//                    $("#hfCaptcha").focus();
//                    return false;
//                }
                $("#lblErr").html("");
            });
        });
        function ChangeCode() {

            var date = new Date();
            var myImg = document.getElementById("ImageCheck");
            var GUID = document.getElementById("lblGUID");

            if (GUID != null) {
                if (GUID.innerHTML != "" && GUID.innerHTML != null) {
                    myImg.src = "../ValidateCode.aspx?GUID=" + GUID.innerHTML + "&flag=" + date.getMilliseconds()

                }
            }
            return false;
        }
    </script>
</head>
<body style=" background-attachment:fixed;background-image:url(images/login_bg.jpg); ">
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
       </asp:ScriptManager>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
                                <asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
   <div style="position:absolute;left:805px;top:413px" >
     <table cellpadding="3" cellspacing="12">
    <tr>
    <td align="right">
        <asp:Label ID="Label1" runat="server" Text="用户名：" Font-Bold="True" ForeColor="#7498B0"></asp:Label></td>
    <td align="left" colspan="3">
        <asp:TextBox ID="txtUserName" runat="server" Height="28" Width="370"  Text="admin"
            BorderStyle="None" ></asp:TextBox>
     </td>
    </tr>
    <tr>
    <td align="right"> <asp:Label ID="Label2" runat="server" Text="密&nbsp;&nbsp;码：" Font-Bold="True" ForeColor="#7498B0"></asp:Label></td>
    <td colspan="3">
        <asp:TextBox ID="txtPwd"  TextMode="Password" runat="server" Height="28" Width="370" BorderStyle="None" Text="admin" ></asp:TextBox>
     </td>
    </tr>
    <tr>
    <td align="right"> <asp:Label ID="Label3" runat="server" Text="验证码：" Font-Bold="True" ForeColor="#7498B0"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtCaptcha" runat="server" Height="28" Width="150"  BorderStyle="None" ></asp:TextBox>
       </td>
                   
                   <td>
                       <a id="A2" href="" onclick="ChangeCode();return false;">
                                                                        <asp:Image ID="ImageCheck" CssStyle="float:left;width:120px;" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                                                            ImageAlign="AbsMiddle" ToolTip="看不清，换一个"></asp:Image></a>
                   </td>
                            <td>
                                <asp:LinkButton CssStyle="float:left;padding-top:8px;" ID="btnRefresh" Text="看不清？"
                                runat="server" OnClientClick="ChangeCode();return false;" ></asp:LinkButton>
                             </td>
    </tr>
    <tr>
    <td>
        <asp:HiddenField ID="hfCaptcha" runat="server" />
    </td>
    <td></td>
    <td align="right">
        <asp:CheckBox ID="cbCookie" runat="server" Text="记住我" 
                        Checked="True" Font-Size="Small" />
    </td>
    <td>
        <asp:Button ID="btnLogin" runat="server" Text="  登录" 
            Style="background-image: url(icon/user_b.png); background-position:left center; background-repeat:no-repeat; text-align:right; text-indent:1px" 
            onclick="btnLogin_Click" />
    </td>
    </tr>
    </table>    
    </div>
    <div style="position:absolute;left:820px;top:613px" >
        <asp:Label ID="lblErr" runat="server" Text="" ForeColor="Red" 
            Font-Size="Smaller"></asp:Label></div>
    </ContentTemplate>
       </asp:UpdatePanel>
    </form>
</body>
</html>
