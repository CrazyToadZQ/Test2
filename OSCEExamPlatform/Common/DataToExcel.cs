using System;
using System.Diagnostics;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
namespace Tellyes.Common
{
    /// <summary>
    /// 操作EXCEL导出数据报表的类
    /// Copyright (C) Tellyes
    /// </summary>
    public class DataToExcel
    {
        public DataToExcel()
        {
        }

        #region 操作EXCEL的一个类(需要Excel.dll支持)

        private int titleColorindex = 15;
        /// <summary>
        /// 标题背景色
        /// </summary>
        public int TitleColorIndex
        {
            set { titleColorindex = value; }
            get { return titleColorindex; }
        }

        private DateTime beforeTime;			//Excel启动之前时间
        private DateTime afterTime;				//Excel启动之后时间

        #region 创建一个Excel示例
        /// <summary>
        /// 创建一个Excel示例
        /// </summary>
        public void CreateExcel()
        {
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Cells[1, 1] = "第1行第1列";
            excel.Cells[1, 2] = "第1行第2列";
            excel.Cells[2, 1] = "第2行第1列";
            excel.Cells[2, 2] = "第2行第2列";
            excel.Cells[3, 1] = "第3行第1列";
            excel.Cells[3, 2] = "第3行第2列";

            //保存
            excel.ActiveWorkbook.SaveAs("./tt.xls", XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            //打开显示
            excel.Visible = true;
            //			excel.Quit();
            //			excel=null;            
            //			GC.Collect();//垃圾回收
        }
        #endregion

        #region 将DataTable的数据导出显示为报表
        /// <summary>
        /// 将DataTable的数据导出显示为报表
        /// </summary>
        /// <param name="dt">要导出的数据</param>
        /// <param name="strTitle">导出报表的标题</param>
        /// <param name="FilePath">保存文件的路径</param>
        /// <returns></returns>
        public string OutputExcel(System.Data.DataTable dt, string strTitle, string FilePath)
        {
            beforeTime = DateTime.Now;

            Excel.Application excel;
            Excel._Workbook xBk;
            Excel._Worksheet xSt;

            int rowIndex = 4;
            int colIndex = 1;

            excel = new Excel.ApplicationClass();
            xBk = excel.Workbooks.Add(true);
            xSt = (Excel._Worksheet)xBk.ActiveSheet;

            //取得列标题			
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[4, colIndex] = col.ColumnName;

                //设置标题格式为居中对齐
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Font.Bold = true;
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Select();
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Interior.ColorIndex = titleColorindex;//19;//设置为浅黄色，共计有56种
            }


            //取得表格中的数据			
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 1;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        excel.Cells[rowIndex, colIndex] = (Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd");
                        xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;//设置日期型的字段格式为居中对齐
                    }
                    else
                        if (col.DataType == System.Type.GetType("System.String"))
                        {
                            excel.Cells[rowIndex, colIndex] = "'" + row[col.ColumnName].ToString();
                            xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;//设置字符型的字段格式为居中对齐
                        }
                        else
                        {
                            excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                        }
                }
            }

            //加载一个合计行			
            int rowSum = rowIndex + 1;
            int colSum = 2;
            excel.Cells[rowSum, 2] = "合计";
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, 2]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //设置选中的部分的颜色			
            xSt.get_Range(excel.Cells[rowSum, colSum], excel.Cells[rowSum, colIndex]).Select();
            //xSt.get_Range(excel.Cells[rowSum,colSum],excel.Cells[rowSum,colIndex]).Interior.ColorIndex =Assistant.GetConfigInt("ColorIndex");// 1;//设置为浅黄色，共计有56种

            //取得整个报表的标题			
            excel.Cells[2, 2] = strTitle;

            //设置整个报表的标题格式			
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, 2]).Font.Bold = true;
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, 2]).Font.Size = 22;

            //设置报表表格为最适应宽度			
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Select();
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Columns.AutoFit();

            //设置整个报表的标题为跨列居中			
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, colIndex]).Select();
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, colIndex]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenterAcrossSelection;

            //绘制边框			
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Borders.LineStyle = 1;
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, 2]).Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThick;//设置左边线加粗
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[4, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;//设置上边线加粗
            xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[rowSum, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThick;//设置右边线加粗
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;//设置下边线加粗



            afterTime = DateTime.Now;

            //显示效果			
            //excel.Visible=true;			
            //excel.Sheets[0] = "sss";

            ClearFile(FilePath);
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
            excel.ActiveWorkbook.SaveAs(FilePath + filename, Excel.XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);

            //wkbNew.SaveAs strBookName;
            //excel.Save(strExcelFileName);

            #region  结束Excel进程

            //需要对Excel的DCOM对象进行配置:dcomcnfg


            //excel.Quit();
            //excel=null;            

            xBk.Close(null, null, null);
            excel.Workbooks.Close();
            excel.Quit();


            //注意：这里用到的所有Excel对象都要执行这个操作，否则结束不了Excel进程
            //			if(rng != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(rng);
            //				rng = null;
            //			}
            //			if(tb != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(tb);
            //				tb = null;
            //			}
            if (xSt != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xSt);
                xSt = null;
            }
            if (xBk != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xBk);
                xBk = null;
            }
            if (excel != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                excel = null;
            }
            GC.Collect();//垃圾回收
            #endregion

            return filename;

        }
        #endregion

        #region Kill Excel进程

        /// <summary>
        /// 结束Excel进程
        /// </summary>
        public void KillExcelProcess()
        {
            Process[] myProcesses;
            DateTime startTime;
            myProcesses = Process.GetProcessesByName("Excel");

            //得不到Excel进程ID，暂时只能判断进程启动时间
            foreach (Process myProcess in myProcesses)
            {
                startTime = myProcess.StartTime;
                if (startTime > beforeTime && startTime < afterTime)
                {
                    myProcess.Kill();
                }
            }
        }
        #endregion

        #endregion

        #region 将DataTable的数据导出显示为报表(不使用Excel对象，使用COM.Excel)

        #region 使用示例
        /*使用示例：
		 * DataSet ds=(DataSet)Session["AdBrowseHitDayList"];
			string ExcelFolder=Assistant.GetConfigString("ExcelFolder");
			string FilePath=Server.MapPath(".")+"\\"+ExcelFolder+"\\";
			
			//生成列的中文对应表
			Hashtable nameList = new Hashtable();
			nameList.Add("ADID", "广告编码");
			nameList.Add("ADName", "广告名称");
			nameList.Add("year", "年");
			nameList.Add("month", "月");
			nameList.Add("browsum", "显示数");
			nameList.Add("hitsum", "点击数");
			nameList.Add("BrowsinglIP", "独立IP显示");
			nameList.Add("HitsinglIP", "独立IP点击");
			//利用excel对象
			DataToExcel dte=new DataToExcel();
			string filename="";
			try
			{			
				if(ds.Tables[0].Rows.Count>0)
				{
					filename=dte.DataExcel(ds.Tables[0],"标题",FilePath,nameList);
				}
			}
			catch
			{
				//dte.KillExcelProcess();
			}
			
			if(filename!="")
			{
				Response.Redirect(ExcelFolder+"\\"+filename,true);
			}
		 * 
		 * */

        #endregion

        /// <summary>
        /// 将DataTable的数据导出显示为报表(不使用Excel对象)
        /// </summary>
        /// <param name="dt">数据DataTable</param>
        /// <param name="strTitle">标题</param>
        /// <param name="FilePath">生成文件的路径</param>
        /// <param name="nameList"></param>
        /// <returns></returns>
        public string DataExcel(System.Data.DataTable dt, string strTitle, string FilePath, Hashtable nameList)
        {
            COM.Excel.cExcelFile excel = new COM.Excel.cExcelFile();
            ClearFile(FilePath);
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
            excel.CreateFile(FilePath + filename);
            excel.PrintGridLines = false;

            COM.Excel.cExcelFile.MarginTypes mt1 = COM.Excel.cExcelFile.MarginTypes.xlsTopMargin;
            COM.Excel.cExcelFile.MarginTypes mt2 = COM.Excel.cExcelFile.MarginTypes.xlsLeftMargin;
            COM.Excel.cExcelFile.MarginTypes mt3 = COM.Excel.cExcelFile.MarginTypes.xlsRightMargin;
            COM.Excel.cExcelFile.MarginTypes mt4 = COM.Excel.cExcelFile.MarginTypes.xlsBottomMargin;

            double height = 1.5;
            excel.SetMargin(ref mt1, ref height);
            excel.SetMargin(ref mt2, ref height);
            excel.SetMargin(ref mt3, ref height);
            excel.SetMargin(ref mt4, ref height);

            COM.Excel.cExcelFile.FontFormatting ff = COM.Excel.cExcelFile.FontFormatting.xlsNoFormat;
            string font = "宋体";
            short fontsize = 9;
            excel.SetFont(ref font, ref fontsize, ref ff);

            byte b1 = 1,
                b2 = 12;
            short s3 = 12;
            excel.SetColumnWidth(ref b1, ref b2, ref s3);

            string header = "页眉";
            string footer = "页脚";
            excel.SetHeader(ref header);
            excel.SetFooter(ref footer);


            COM.Excel.cExcelFile.ValueTypes vt = COM.Excel.cExcelFile.ValueTypes.xlsText;
            COM.Excel.cExcelFile.CellFont cf = COM.Excel.cExcelFile.CellFont.xlsFont0;
            COM.Excel.cExcelFile.CellAlignment ca = COM.Excel.cExcelFile.CellAlignment.xlsCentreAlign;
            COM.Excel.cExcelFile.CellHiddenLocked chl = COM.Excel.cExcelFile.CellHiddenLocked.xlsNormal;

            // 报表标题
            int cellformat = 1;
            //			int rowindex = 1,colindex = 3;					
            //			object title = (object)strTitle;
            //			excel.WriteValue(ref vt, ref cf, ref ca, ref chl,ref rowindex,ref colindex,ref title,ref cellformat);

            int rowIndex = 1;//起始行
            int colIndex = 0;



            //取得列标题				
            foreach (DataColumn colhead in dt.Columns)
            {
                colIndex++;
                string name = colhead.ColumnName.Trim();
                object namestr = (object)name;
                IDictionaryEnumerator Enum = nameList.GetEnumerator();
                while (Enum.MoveNext())
                {
                    if (Enum.Key.ToString().Trim() == name)
                    {
                        namestr = Enum.Value;
                    }
                }
                excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref namestr, ref cellformat);
            }

            //取得表格中的数据			
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        object str = (object)(Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd"); ;
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                    else
                    {
                        object str = (object)row[col.ColumnName].ToString();
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                }
            }
            int ret = excel.CloseFile();

            //			if(ret!=0)
            //			{
            //				//MessageBox.Show(this,"Error!");
            //			}
            //			else
            //			{
            //				//MessageBox.Show(this,"请打开文件c:\\test.xls!");
            //			}
            return filename;

        }

        #endregion

        #region  清理过时的Excel文件

        private void ClearFile(string FilePath)
        {
            String[] Files = System.IO.Directory.GetFiles(FilePath);
            if (Files.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        System.IO.File.Delete(Files[i]);
                    }
                    catch
                    {
                    }

                }
            }
        }
        #endregion

        #region 导入Excel
        public List<Model.UserInfo> ImportExcel(string[] list, string filePath,ref string err ,ref  List<Int32> roleIDList)
        {
            string isXls = System.IO.Path.GetExtension(filePath).ToLower();//System.IO.Path.GetExtension获得文件的扩展名  

            if (isXls != ".xls")
            {
                err = "请选择97-03格式的Excel文件";
                return null;
            }
            DataSet ds = ExecleDataSet(filePath);//调用自定义方法  
            System.Data.DataTable dt = ds.Tables[0];
            if (dt.Columns.Count != list.Length)
            {
                err = "您上传的Excel文件内容不符，请按照《学生导入模板》样式，填写内容并上传";
                return null;
            }
            bool b = true;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var q = from str in list
                        where str == dt.Columns[i].ColumnName
                        select str;
                if (q.Count<string>() == 0)
                {
                    b = false;
                    err = "列名【" + dt.Columns[i].ColumnName + "】不应是导入模板包含列的一部分，请选择正确的模板导入";
                    break;
                }
            }
            if (!b)
            {
                return null;
            }
            dt.Columns.Add(new DataColumn("U_PWD", typeof(string)));
            dt.Columns.Add(new DataColumn("U_ID", typeof(Int32)));
            if (dt.Rows.Count==0)
            {
                err = "所上传文件无数据";
                return null;
            }
            //dt.Columns.Add(new DataColumn("int1", typeof(Int32)));
            //dt.Columns.Add(new DataColumn("int2", typeof(Int32)));
            //dt.Columns.Add(new DataColumn("int3", typeof(Int32)));
            //dt.Columns.Add(new DataColumn("date2", typeof(DateTime)));
            //dt.Columns.Add(new DataColumn("date3", typeof(DateTime)));
            //dt.Columns.Add(new DataColumn("float1", typeof(decimal)));
            //dt.Columns.Add(new DataColumn("float2", typeof(decimal)));
            //dt.Columns.Add(new DataColumn("float3", typeof(decimal)));
            
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].ColumnName)
                {
                    case "用户名":
                        dt.Columns[i].ColumnName = "U_Name";
                        break;
                    case "真实姓名":
                        dt.Columns[i].ColumnName = "U_TrueName";
                        break;
                    //case "性别":
                    //    dt.Columns[i].ColumnName = "U_Sex";
                    //    break;
                    //case "手机号码":
                    //    dt.Columns[i].ColumnName = "U_Phone";
                    //    break;
                    //case "手机号码（备用）":
                    //    dt.Columns[i].ColumnName = "U_Phone2";
                    //    break;
                    case "Email":
                        dt.Columns[i].ColumnName = "U_Email";
                        break;
                    case "Email（备用）":
                        dt.Columns[i].ColumnName = "U_Email2";
                        break;
                    //case "身份证号":
                    //    dt.Columns[i].ColumnName = "string1";
                    //    break;
                    case "毕业院校":
                        dt.Columns[i].ColumnName = "string2";
                        break;
                    case "政治背景":
                        dt.Columns[i].ColumnName = "string3";
                        break;
                    case "出生日期":
                        dt.Columns[i].ColumnName = "date1";
                        break;
                    case "民族":
                        dt.Columns[i].ColumnName = "U_Ethnic";
                        break;
                    case "学历":
                        dt.Columns[i].ColumnName = "U_Education";
                        break;
                    case "入学时间":
                        dt.Columns[i].ColumnName = "U_InTime";
                        break;
                    case "生源地":
                        dt.Columns[i].ColumnName = "U_Source";
                        break;
                    //case "描述":
                    //    dt.Columns[i].ColumnName = "U_Contont";
                    //    break;
                    default:
                        break;
                }
            }
            dt.Columns.Add(new DataColumn("U_Sex", typeof(Int32)));
            dt.Columns.Add(new DataColumn("U_Phone", typeof(string)));
            dt.Columns.Add(new DataColumn("U_Phone2", typeof(string)));
            dt.Columns.Add(new DataColumn("U_Contont", typeof(string)));
            dt.Columns.Add(new DataColumn("R_ID", typeof(Int32)));
            dt.Columns.Add(new DataColumn("string1", typeof(string)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["U_Sex"] = dt.Rows[i]["性别"].ToString() == "女" ? 2 : 1;
                dt.Rows[i]["U_Phone"] = dt.Rows[i]["手机号码"] != null ? dt.Rows[i]["手机号码"].ToString() : null;
                dt.Rows[i]["U_Phone2"] = dt.Rows[i]["手机号码（备用）"] != null ? dt.Rows[i]["手机号码（备用）"].ToString() : null;
                dt.Rows[i]["U_Contont"] = dt.Rows[i]["描述"] != null ? dt.Rows[i]["描述"].ToString() : null;
                dt.Rows[i]["R_ID"] = dt.Rows[i]["角色"].ToString() == "学生" ? 6 : dt.Rows[i]["角色"].ToString() == "SP" ? 5 : dt.Rows[i]["角色"].ToString() == "评委" ? 4 : dt.Rows[i]["角色"].ToString() == "教师" ? 3 : dt.Rows[i]["角色"].ToString() == "实验员" ? 2 : dt.Rows[i]["角色"].ToString() == "管理员" ? 1 : 0;
                dt.Rows[i]["string1"] = dt.Rows[i]["身份证号"] != null ? dt.Rows[i]["身份证号"].ToString() : null;
                roleIDList.Add(Convert.ToInt32(dt.Rows[i]["R_ID"]));
            }
            //dt.Columns["U_Sex"].DataType = typeof(Int32);

            List<Model.UserInfo> uList= LINQBase.LINQObjChange.ToList<Model.UserInfo>(dt);
            return uList;
            //DataRow[] dr = ds.Tables[0].Select();//定义一个DataRow数组  
            //int rowsnum = ds.Tables[0].Rows.Count;
            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    err="Excel无数据！";
            //    return false;
            //}
            //bool b = true;
            //for (int i = 0; i < dr.Length; i++)
            //{
            //    DataRow drow = dr[i];
            //    Model.UserInfo u = new Model.UserInfo();
            //    if (!checkRowInfo(drow,ref u)) 
            //    {
            //        b = false;
            //        break;
            //    }
            //}
            //if (!b)
            //{
            //    err="Excel数据错误！";
            //    return false;
            //}
            //return true;
        }

        //private bool checkRowInfo(DataRow drow,ref Model.UserInfo u)
        //{
        //    return false;
        //}

        //OleDB连接读取Excel中数据  
        public DataSet ExecleDataSet(string filePath)
        {
            string OleDbConnection = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + filePath + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(OleDbConnection);
            try
            {
                conn.Open();
            }
            catch(Exception ee)
            {
                if (ee.Message.Contains("外部表不是预期的格式"))
                {
                    OleDbConnection = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filePath + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'";
                    conn.ConnectionString = OleDbConnection;
                    conn.Open();
                }
                else
                {
                    Log4Net.Log4NetUtility.Error(this, "无法打开文件");
                    return null;
                }
            }
            
            DataSet ds = new DataSet();
            OleDbDataAdapter odda = new OleDbDataAdapter("select * from [Sheet1$]", conn);
            odda.Fill(ds);
            conn.Close();
            return ds;
        }
        #endregion 

    }
}
