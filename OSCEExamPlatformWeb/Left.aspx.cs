using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OSCEExamPlatformWeb
{
    public partial class Left : System.Web.UI.Page
    {
        #region 公共变量

        private readonly Tellyes.BLL.ModuleGroup mgBLL = new Tellyes.BLL.ModuleGroup();
        private readonly Tellyes.BLL.Module mBLL = new Tellyes.BLL.Module();

        #endregion
        public string strMenu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindMenu();
            }
        }

        public string getMenu(object dv)
        {
            string Rtn = "";
            string rights = ViewState["Rights"] != null ? ViewState["Rights"].ToString() : "";
            DataRowView drv = (DataRowView)dv;
            Rtn += "<ul class=\"open\"><span class=\"span_open\">" + drv["M_Name"] + "</span>";
            if (drv["int2"].ToString() == "0")
            {
                DataTable dt = mBLL.GetList("int2=" + drv["M_ID"]).Tables[0];
                int MNum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    string MID = "'" + dr["M_ID"] + "'";
                    if (rights == "0" || rights.IndexOf(MID) > -1)
                    {
                        string url = dr["string1"] != null ? dr["string1"].ToString() : "";
                        Rtn += "<li><a href=\"" + url + "\" target=\"mainFrame\">" + dr["M_Name"] + "</a></li>";
                        MNum++;
                    }
                }
                Rtn += "</ul>";
                if (MNum == 0)
                {
                    Rtn = "";
                }
            }
            return Rtn;
        }

        private void bindMenu()
        {
            /*<span class="span_open">快捷菜单</span>
                   <li><a href="CMS/Content/add.aspx" target="mainFrame">添加内容</a></li>*/
            string mgID = Request.QueryString["id"];
            Tellyes.Model.UserLogin ulModel = Session["UserLogin"] as Tellyes.Model.UserLogin;
            string mList = "0";
            if (ulModel!=null)
            {
                mList = ulModel.MList;
            }
            ViewState["Rights"] = mList;
            DataSet ds = mBLL.GetList("int2=0 and int1=" + mgID);
            rpMenu.DataSource = ds;
            rpMenu.DataBind();
        }
    }
}