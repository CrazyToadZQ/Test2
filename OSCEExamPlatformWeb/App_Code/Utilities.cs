using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Common;
using System.Collections;

/// <summary>
/// Summary description for Utilities
/// </summary>
public static class Utilities
{
    
    public struct FieldInfo
    {
        public string name;
        public string value;
    }

    public static Hashtable ParseJsonToHash(FieldInfo[] json)
    {
        Hashtable ht = new Hashtable();

        foreach (FieldInfo fi in json)
        {
            ht.Add(fi.name, fi.value);
        }
        return ht;
    }

    public static string HandleNull(object obj, string sDefault)
    {
        if (obj == System.DBNull.Value || obj == null)
        {
            return sDefault;
        }
        else
        {
            return obj.ToString();
        }
    }

    public static decimal HandleNullDec(object obj, decimal dDefault)
    {
        if (obj == System.DBNull.Value || obj == null)
        {
            return dDefault;
        }
        else
        {
            return Convert.ToDecimal(obj);
        }
    }

    public static void BindGV(string sSql, GridView gv)
    {
        DBOP dbop = new DBOP();
        gv.DataSource = dbop.GetDataSet(sSql).Tables[0].DefaultView;
        gv.DataBind();
    }

    public static int BindGV_ReturnCount(string sSql, GridView gv)
    {
        DBOP dbop = new DBOP();
        DataTable dt = dbop.GetDataSet(sSql).Tables[0];
        gv.DataSource = dt.DefaultView;
        gv.DataBind();
        return dt.Rows.Count;
    }

    public static void BindDDL(DropDownList ddl, string strSQL, string textName, string valueName)
    {
        DBOP dbop = new DBOP();
        DataTable dt;
        dt = dbop.GetDataSet(strSQL).Tables[0];
        ddl.DataSource = dt.DefaultView;
        ddl.DataTextField = textName;
        ddl.DataValueField = valueName;
        ddl.DataBind();
        if (ddl.Items.Count > 0)
        {
            ddl.SelectedIndex = 0;
        }
    }



    public static Boolean DDLSafeSelect(DropDownList ddl, string sValue)
    {
        ddl.ClearSelection();
        ListItem liError = ddl.Items.FindByValue("#InValidValue#");
        while (liError != null)
        {
            ddl.Items.Remove(liError);
            liError = ddl.Items.FindByValue("#InValidValue#");
        }
        ListItem li = ddl.Items.FindByValue(sValue);
        if (li == null)
        {
            ListItem liNew = new ListItem();
            liNew.Text = sValue;
            liNew.Value = sValue;
            liNew.Attributes.Add("style", "background: red;");

            ddl.Items.Insert(0, liNew);
            liNew.Selected = true;
            return false;
        }
        else
        {
            li.Selected = true;
            return true;
        }

    }

    public static void AddDDLBlankRow(DropDownList ddl, string sText, string sValue)
    {

        ListItem li = new ListItem();
        li.Text = sText;
        li.Value = sValue;
        ddl.Items.Insert(0, li);
        for (int i = 0; i < ddl.Items.Count; i++)
        {
            ddl.Items[i].Selected = false;
        }
        ddl.SelectedIndex = 0;
    }

    public static string AntiSqlInjectionStringFilter(string sValue)
    {
        sValue = sValue.Replace("'", "''");
        sValue = sValue.Replace(";", " ");
        sValue = sValue.Replace("--", " ");
        sValue = sValue.Replace("xp_", " ");
        sValue = sValue.Replace("/*", " ");
        sValue = sValue.Replace("*/", " ");
        sValue = sValue.Replace("　", " ");
        return sValue.Trim();
    }

    public static string Base64Encode(string sRawData)
    {
        byte[] data = new byte[sRawData.Length];
        data = System.Text.Encoding.ASCII.GetBytes(sRawData);

        string Base64Data = Convert.ToBase64String(data);

        return Base64Data;
    }


    public static string Base64Decode(string sBase64Data)
    {
        byte[] data = Convert.FromBase64String(sBase64Data);

        string rawData = System.Text.Encoding.ASCII.GetString(data);
        return rawData;
    }

    public static string EncryptPassword(string plainString, string encrypType)
    {
        string EncryptString;
        if (encrypType == "MD5")
        {
            EncryptString = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(plainString, "MD5");
        }
        else if (encrypType == "SHA1")
        {
            EncryptString = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(plainString, "SHA1");
        }
        else
        {
            EncryptString = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(plainString, "SHA1");
        }

        return EncryptString;
    }

    public static void PageAlert(Page page, string info)
    {
        //page.ClientScript.RegisterStartupScript(GetType(), "", "alert('" + info + "');", true);
    }

    public static void AjaxAlert(Control cl, string info)
    {
        ScriptManager.RegisterStartupScript(cl, cl.GetType(), "Alert", "alert('" + info + "');", true);
    }

    public static void SetWebGridRowSelect(Page page, object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "GV_changeBackColor(this, true)");
            e.Row.Attributes.Add("onmouseout", "GV_changeBackColor(this, false)");
            e.Row.Attributes["OnClick"] = page.ClientScript.GetPostBackEventReference((GridView)sender, "Select$" + e.Row.RowIndex);
            e.Row.Style["cursor"] = "hand";
        }

    }

    public static void SetWebGridRowHover(GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "GV_changeBackColor(this, true)");
            e.Row.Attributes.Add("onmouseout", "GV_changeBackColor(this, false)");
        }

    }

    public static void HandleError(Page page, string ErrorType)
    {
        page.Response.Redirect("~/ErrorPage.aspx?rsn=" + ErrorType + "&pg=" + page.Request.RawUrl, true);
    }

    public static string GetPYString(string str)
    {
        string tempStr = "";

        foreach (char c in str)//当前在text里的中文
        {

            if ((int)c >= 33 && (int)c <= 126)
            {
                tempStr += c.ToString();
            }
            else
            {
                tempStr += GetPYChar(c.ToString()).ToUpper().Trim() ;
            }
        }
        return tempStr;
    }

        public static string GetPYChar(string c)
        {
            if (c == "讴")
            {
                c = "欧";
            }
            byte[] array = new byte[2];
            array = System.Text.Encoding.GetEncoding("GB2312").GetBytes(c);
            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));

            if (i < 0xB0A1) return "*";
            if (i < 0xB0C5) return "a";
            if (i < 0xB2C1) return "b";
            if (i < 0xB4EE) return "c";
            if (i < 0xB6EA) return "d";
            if (i < 0xB7A2) return "e";
            if (i < 0xB8C1) return "f";
            if (i < 0xB9FE) return "g";
            if (i < 0xBBF7) return "h";
            if (i < 0xBFA6) return "g";
            if (i < 0xC0AC) return "k";
            if (i < 0xC2E8) return "l";
            if (i < 0xC4C3) return "m";
            if (i < 0xC5B6) return "n";
            if (i < 0xC5BE) return "o";
            if (i < 0xC6DA) return "p";
            if (i < 0xC8BB) return "q";
            if (i < 0xC8F6) return "r";
            if (i < 0xCBFA) return "s";
            if (i < 0xCDDA) return "t";
            if (i < 0xCEF4) return "w";
            if (i < 0xD1B9) return "x";
            if (i < 0xD4D1) return "y";
            if (i < 0xD7FA) return "z";
            return "*";
        }




    #region File OPs
    //-----------------------------------------------------------
    // FUNCTION: FileExists
    // Determines whether the specified file exists
    // IN: [sPathName] - file to check for
    // Returns: True if file exists, False otherwise
    //-----------------------------------------------------------
    public static bool ifFileExists(string sFileName)
    {
        try
        {
            sFileName = HttpContext.Current.Server.MapPath(sFileName);
            return (System.IO.File.Exists(sFileName));  //Exception for folder
        }
        catch (Exception)
        {
            return (false);                                   //Error occured, return False
        }
    }

    //-----------------------------------------------------------
    // FUNCTION: DirExists
    // Determines whether the specified directory name exists.
    // IN: [sDirName] - name of directory to check for
    // Returns: True if the directory exists, False otherwise
    //-----------------------------------------------------------
    public static bool ifDirExists(string sDirName)
    {
        try
        {
            sDirName = HttpContext.Current.Server.MapPath(sDirName);
            return (System.IO.Directory.Exists(sDirName));    //Check for file
        }
        catch (Exception)
        {
            return (false);                                 //Exception occured, return False
        }
    }

    //public static int SaveUploadFile(string sFileFolder, string sFileName, bool ifOverWrite, DevExpress.Web.ASPxUploadControl.UploadedFile file)
    //{
    //    try
    //    {
    //        if (!ifDirExists(sFileFolder))
    //        {
    //            System.IO.Directory.CreateDirectory(sFileFolder);
    //        }
    //        string sFileSaveName = System.IO.Path.Combine(HttpContext.Current.Server.MapPath(sFileFolder), sFileName);
    //        if (!ifOverWrite)
    //        {
    //            if (ifFileExists(sFileSaveName))
    //            {
    //                return 2;
    //            }
    //        }
    //        file.SaveAs(sFileSaveName);
    //        return 0;
    //    }
    //    catch (Exception)
    //    {
    //        return 1;
    //    }
    //}

    //public static bool CreateJpgFromUploadFile(DevExpress.Web.ASPxUploadControl.UploadedFile file, string outputFileName, int lnWidth, int lnHeight)
    //{
    //    System.Drawing.Bitmap bmpOut = null;
    //    try
    //    {
    //        System.Drawing.Bitmap loBMP = new System.Drawing.Bitmap(System.Drawing.Image.FromStream(file.FileContent));
    //        System.Drawing.Imaging.ImageFormat loFormat = loBMP.RawFormat;
    //        decimal lnRatio;
    //        int lnNewWidth = 0;
    //        int lnNewHeight = 0;

    //        //*** If the image is smaller than a thumbnail just return it
    //        if (loBMP.Width < lnWidth && loBMP.Height < lnHeight)
    //        {
    //            loBMP.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
    //            loBMP.Dispose();
    //        }

    //        if (loBMP.Width > loBMP.Height)
    //        {
    //            lnRatio = (decimal)lnWidth / loBMP.Width;
    //            lnNewWidth = lnWidth;
    //            decimal lnTemp = loBMP.Height * lnRatio;
    //            lnNewHeight = (int)lnTemp;
    //        }
    //        else
    //        {
    //            lnRatio = (decimal)lnHeight / loBMP.Height;
    //            lnNewHeight = lnHeight;
    //            decimal lnTemp = loBMP.Width * lnRatio;
    //            lnNewWidth = (int)lnTemp;
    //        }

    //        // System.Drawing.Image imgOut =  loBMP.GetThumbnailImage(lnNewWidth,lnNewHeight, null,IntPtr.Zero);
    //        // *** This code creates cleaner (though bigger) thumbnails and properly
    //        // *** and handles GIF files better by generating a white background for
    //        // *** transparent images (as opposed to black)
    //        bmpOut = new System.Drawing.Bitmap(lnNewWidth, lnNewHeight);
    //        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmpOut);
    //        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
    //        g.FillRectangle(System.Drawing.Brushes.White, 0, 0, lnNewWidth, lnNewHeight);
    //        g.DrawImage(loBMP, 0, 0, lnNewWidth, lnNewHeight);
    //        loBMP.Dispose();
    //        bmpOut.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
    //        bmpOut.Dispose();
    //    }
    //    catch
    //    {
    //        return false;
    //    }
    //    return true;
    //}
    #endregion
}