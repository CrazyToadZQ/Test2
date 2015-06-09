using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tellyes.Log4Net;

namespace OSCEExamPlatformWeb
{
    public partial class QueryTop : System.Web.UI.Page
    {
        public string userTrueName;
        public string menuStr = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO 
            if (Session["UserInfo"] != null)
            {
                Tellyes.Model.UserInfo userInfo = (Tellyes.Model.UserInfo)Session["UserInfo"];
                userTrueName = userInfo.U_TrueName;
                Session["userInfoID"] = userInfo.U_ID;
            }

            if (!IsPostBack)
            {
                searchMenuByRoleID();
            }

        }

        /// <summary>
        /// 得到该权限对应的操作菜单 根据数据库设置相应菜单（数据库数据未更新）
        /// </summary>
        private void searchMenuByRoleID()
        {
            if (Session["userRoleModelList"] != null)
            {
                List<Tellyes.Model.UserRole> userRoleModelList = (List<Tellyes.Model.UserRole>)Session["userRoleModelList"];

                foreach (Tellyes.Model.UserRole userRole in userRoleModelList)
                {
                    string url = "";
                    int roleID = userRole.R_ID;
                    if (roleID == 3)
                    {
                        //教师
                        url = "UI/QueryManagement/TeacherQueryManagement/TeacherQueryExam.aspx";
                        menuStr += "<li id=\"Tab\"" + 1 + "><a href=\"" + url + "?id=" + 1 + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + 1 + "');\">" + "教师考试查询" + "</a></li>";
                    }
                    else if (roleID == 4)
                    {
                        //评委或者SP
                        url = "UI/QueryManagement/SPQueryManagement/SPQueryExam.aspx";
                        menuStr += "<li id=\"Tab\"" + 1 + "><a href=\"" + url + "?id=" + 1 + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + 1 + "');\">" + "评委考试查询" + "</a></li>";
                    }
                    else if (roleID == 5)
                    {
                        //学生
                        url = "UI/QueryManagement/StudentQueryManagement/StudentQueryExam.aspx";
                        menuStr += "<li id=\"Tab\"" + 1 + "><a href=\"" + url + "?id=" + 1 + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + 1 + "');\">" + "SP考试查询" + "</a></li>";
                    }


                    else if (roleID == 6)
                    {
                        //学生
                        url = "UI/QueryManagement/StudentQueryManagement/StudentQueryExam.aspx";
                        menuStr += "<li id=\"Tab\"" + 1 + "><a href=\"" + url + "?id=" + 1 + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + 1 + "');\">" + "考试查询" + "</a></li>";
                    }
                }
                /*
            int roleID = 0;
            if(Session["RoleID"]!=null){
                roleID = Convert.ToInt32(Session["RoleID"]);
            }
            Tellyes.BLL.Module moduleBLL = new Tellyes.BLL.Module();
            List<Tellyes.Model.Module> moduleList = moduleBLL.SearchModuleNameByCondition(roleID);
            if (moduleList == null)
            {
                Log4NetUtility.Error(this, "条件查询菜单项失败");
                return;
            }
            //TODO
            string url = "";
            if (roleID == 3)
            {
                //教师
                url = "UI/QueryManagement/TeacherQueryManagement/TeacherQueryExam.aspx";
            }
            else if (roleID == 4 || roleID == 5)
            {
                //评委或者SP
                url = "UI/QueryManagement/SPQueryManagement/SPQueryExam.aspx";
            }
            else if (roleID == 6)
            {
                //学生
                url = "UI/QueryManagement/StudentQueryManagement/StudentQueryExam.aspx";
            }
            //for(int i=0;i<moduleList.Count;i++){
            //    menuStr += "<li id=\"Tab\"" + i + "><a href=\"" + url + "?id=" + moduleList[i].M_ID + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + i + "');\">" + moduleList[i].M_Name + "</a></li>"; 
            //}

            //TODO test
           menuStr += "<li id=\"Tab\"" + 1 + "><a href=\"" + url + "?id=" + 1 + "\"  target=\"mainFrame\" onclick=\"javascript:switchTab('TabPage1','Tab" + 1 + "');\">" + "考试查询"+ "</a></li>"; 
                 * */
            }
        }
    }
}