using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
   public class Iconlibrary
    {
        public Iconlibrary()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Icon_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Iconlibrary");
            strSql.Append(" where Icon_ID=@Icon_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Icon_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Icon_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.Iconlibrary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Iconlibrary(");
            strSql.Append("Icon_Name,Icon_Path,Icon_Person,Icon_Is_Existing,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4)");
            strSql.Append(" values (");
            strSql.Append("@Icon_Name,@Icon_Path,@Icon_Person,@Icon_Is_Existing,@Number1,@Number2,@Number3,@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@String2,@String3,@String4,@String5,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@Datetime4)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Icon_Name", SqlDbType.VarChar,50),
					new SqlParameter("@Icon_Path", SqlDbType.VarChar,200),
					new SqlParameter("@Icon_Person", SqlDbType.Int,4),
					new SqlParameter("@Icon_Is_Existing", SqlDbType.Int,4),
					new SqlParameter("@Number1", SqlDbType.Int,4),
					new SqlParameter("@Number2", SqlDbType.Int,4),
					new SqlParameter("@Number3", SqlDbType.Int,4),
					new SqlParameter("@Number4", SqlDbType.Int,4),
					new SqlParameter("@Number5", SqlDbType.Int,4),
					new SqlParameter("@Number6", SqlDbType.Decimal,13),
					new SqlParameter("@Number7", SqlDbType.Decimal,13),
					new SqlParameter("@Number8", SqlDbType.Decimal,13),
					new SqlParameter("@String1", SqlDbType.VarChar,50),
					new SqlParameter("@String2", SqlDbType.VarChar,50),
					new SqlParameter("@String3", SqlDbType.VarChar,50),
					new SqlParameter("@String4", SqlDbType.VarChar,200),
					new SqlParameter("@String5", SqlDbType.VarChar,200),
					new SqlParameter("@String6", SqlDbType.VarChar,200),
					new SqlParameter("@String7", SqlDbType.VarChar,-1),
					new SqlParameter("@String8", SqlDbType.VarChar,-1),
					new SqlParameter("@Datetime1", SqlDbType.DateTime),
					new SqlParameter("@Datetime2", SqlDbType.DateTime),
					new SqlParameter("@Datetime3", SqlDbType.DateTime),
					new SqlParameter("@Datetime4", SqlDbType.DateTime)};
            parameters[0].Value = model.Icon_Name;
            parameters[1].Value = model.Icon_Path;
            parameters[2].Value = model.Icon_Person;
            parameters[3].Value = model.Icon_Is_Existing;
            parameters[4].Value = model.Number1;
            parameters[5].Value = model.Number2;
            parameters[6].Value = model.Number3;
            parameters[7].Value = model.Number4;
            parameters[8].Value = model.Number5;
            parameters[9].Value = model.Number6;
            parameters[10].Value = model.Number7;
            parameters[11].Value = model.Number8;
            parameters[12].Value = model.String1;
            parameters[13].Value = model.String2;
            parameters[14].Value = model.String3;
            parameters[15].Value = model.String4;
            parameters[16].Value = model.String5;
            parameters[17].Value = model.String6;
            parameters[18].Value = model.String7;
            parameters[19].Value = model.String8;
            parameters[20].Value = model.Datetime1;
            parameters[21].Value = model.Datetime2;
            parameters[22].Value = model.Datetime3;
            parameters[23].Value = model.Datetime4;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.Iconlibrary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Iconlibrary set ");
            strSql.Append("Icon_Name=@Icon_Name,");
            strSql.Append("Icon_Path=@Icon_Path,");
            strSql.Append("Icon_Person=@Icon_Person,");
            strSql.Append("Icon_Is_Existing=@Icon_Is_Existing,");
            strSql.Append("Number1=@Number1,");
            strSql.Append("Number2=@Number2,");
            strSql.Append("Number3=@Number3,");
            strSql.Append("Number4=@Number4,");
            strSql.Append("Number5=@Number5,");
            strSql.Append("Number6=@Number6,");
            strSql.Append("Number7=@Number7,");
            strSql.Append("Number8=@Number8,");
            strSql.Append("String1=@String1,");
            strSql.Append("String2=@String2,");
            strSql.Append("String3=@String3,");
            strSql.Append("String4=@String4,");
            strSql.Append("String5=@String5,");
            strSql.Append("String6=@String6,");
            strSql.Append("String7=@String7,");
            strSql.Append("String8=@String8,");
            strSql.Append("Datetime1=@Datetime1,");
            strSql.Append("Datetime2=@Datetime2,");
            strSql.Append("Datetime3=@Datetime3,");
            strSql.Append("Datetime4=@Datetime4");
            strSql.Append(" where Icon_ID=@Icon_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Icon_Name", SqlDbType.VarChar,50),
					new SqlParameter("@Icon_Path", SqlDbType.VarChar,200),
					new SqlParameter("@Icon_Person", SqlDbType.Int,4),
					new SqlParameter("@Icon_Is_Existing", SqlDbType.Int,4),
					new SqlParameter("@Number1", SqlDbType.Int,4),
					new SqlParameter("@Number2", SqlDbType.Int,4),
					new SqlParameter("@Number3", SqlDbType.Int,4),
					new SqlParameter("@Number4", SqlDbType.Int,4),
					new SqlParameter("@Number5", SqlDbType.Int,4),
					new SqlParameter("@Number6", SqlDbType.Decimal,13),
					new SqlParameter("@Number7", SqlDbType.Decimal,13),
					new SqlParameter("@Number8", SqlDbType.Decimal,13),
					new SqlParameter("@String1", SqlDbType.VarChar,50),
					new SqlParameter("@String2", SqlDbType.VarChar,50),
					new SqlParameter("@String3", SqlDbType.VarChar,50),
					new SqlParameter("@String4", SqlDbType.VarChar,200),
					new SqlParameter("@String5", SqlDbType.VarChar,200),
					new SqlParameter("@String6", SqlDbType.VarChar,200),
					new SqlParameter("@String7", SqlDbType.VarChar,-1),
					new SqlParameter("@String8", SqlDbType.VarChar,-1),
					new SqlParameter("@Datetime1", SqlDbType.DateTime),
					new SqlParameter("@Datetime2", SqlDbType.DateTime),
					new SqlParameter("@Datetime3", SqlDbType.DateTime),
					new SqlParameter("@Datetime4", SqlDbType.DateTime),
					new SqlParameter("@Icon_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Icon_Name;
            parameters[1].Value = model.Icon_Path;
            parameters[2].Value = model.Icon_Person;
            parameters[3].Value = model.Icon_Is_Existing;
            parameters[4].Value = model.Number1;
            parameters[5].Value = model.Number2;
            parameters[6].Value = model.Number3;
            parameters[7].Value = model.Number4;
            parameters[8].Value = model.Number5;
            parameters[9].Value = model.Number6;
            parameters[10].Value = model.Number7;
            parameters[11].Value = model.Number8;
            parameters[12].Value = model.String1;
            parameters[13].Value = model.String2;
            parameters[14].Value = model.String3;
            parameters[15].Value = model.String4;
            parameters[16].Value = model.String5;
            parameters[17].Value = model.String6;
            parameters[18].Value = model.String7;
            parameters[19].Value = model.String8;
            parameters[20].Value = model.Datetime1;
            parameters[21].Value = model.Datetime2;
            parameters[22].Value = model.Datetime3;
            parameters[23].Value = model.Datetime4;
            parameters[24].Value = model.Icon_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Icon_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Iconlibrary ");
            strSql.Append(" where Icon_ID=@Icon_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Icon_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Icon_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Icon_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Iconlibrary ");
            strSql.Append(" where Icon_ID in (" + Icon_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.Iconlibrary GetModel(int Icon_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Icon_ID,Icon_Name,Icon_Path,Icon_Person,Icon_Is_Existing,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 from Iconlibrary ");
            strSql.Append(" where Icon_ID=@Icon_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Icon_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Icon_ID;

            Tellyes.Model.Iconlibrary model = new Tellyes.Model.Iconlibrary();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.Iconlibrary DataRowToModel(DataRow row)
        {
            Tellyes.Model.Iconlibrary model = new Tellyes.Model.Iconlibrary();
            if (row != null)
            {
                if (row["Icon_ID"] != null && row["Icon_ID"].ToString() != "")
                {
                    model.Icon_ID = int.Parse(row["Icon_ID"].ToString());
                }
                if (row["Icon_Name"] != null)
                {
                    model.Icon_Name = row["Icon_Name"].ToString();
                }
                if (row["Icon_Path"] != null)
                {
                    model.Icon_Path = row["Icon_Path"].ToString();
                }
                if (row["Icon_Person"] != null && row["Icon_Person"].ToString() != "")
                {
                    model.Icon_Person = int.Parse(row["Icon_Person"].ToString());
                }
                if (row["Icon_Is_Existing"] != null && row["Icon_Is_Existing"].ToString() != "")
                {
                    model.Icon_Is_Existing = int.Parse(row["Icon_Is_Existing"].ToString());
                }
                if (row["Number1"] != null && row["Number1"].ToString() != "")
                {
                    model.Number1 = int.Parse(row["Number1"].ToString());
                }
                if (row["Number2"] != null && row["Number2"].ToString() != "")
                {
                    model.Number2 = int.Parse(row["Number2"].ToString());
                }
                if (row["Number3"] != null && row["Number3"].ToString() != "")
                {
                    model.Number3 = int.Parse(row["Number3"].ToString());
                }
                if (row["Number4"] != null && row["Number4"].ToString() != "")
                {
                    model.Number4 = int.Parse(row["Number4"].ToString());
                }
                if (row["Number5"] != null && row["Number5"].ToString() != "")
                {
                    model.Number5 = int.Parse(row["Number5"].ToString());
                }
                if (row["Number6"] != null && row["Number6"].ToString() != "")
                {
                    model.Number6 = decimal.Parse(row["Number6"].ToString());
                }
                if (row["Number7"] != null && row["Number7"].ToString() != "")
                {
                    model.Number7 = decimal.Parse(row["Number7"].ToString());
                }
                if (row["Number8"] != null && row["Number8"].ToString() != "")
                {
                    model.Number8 = decimal.Parse(row["Number8"].ToString());
                }
                if (row["String1"] != null)
                {
                    model.String1 = row["String1"].ToString();
                }
                if (row["String2"] != null)
                {
                    model.String2 = row["String2"].ToString();
                }
                if (row["String3"] != null)
                {
                    model.String3 = row["String3"].ToString();
                }
                if (row["String4"] != null)
                {
                    model.String4 = row["String4"].ToString();
                }
                if (row["String5"] != null)
                {
                    model.String5 = row["String5"].ToString();
                }
                if (row["String6"] != null)
                {
                    model.String6 = row["String6"].ToString();
                }
                if (row["String7"] != null)
                {
                    model.String7 = row["String7"].ToString();
                }
                if (row["String8"] != null)
                {
                    model.String8 = row["String8"].ToString();
                }
                if (row["Datetime1"] != null && row["Datetime1"].ToString() != "")
                {
                    model.Datetime1 = DateTime.Parse(row["Datetime1"].ToString());
                }
                if (row["Datetime2"] != null && row["Datetime2"].ToString() != "")
                {
                    model.Datetime2 = DateTime.Parse(row["Datetime2"].ToString());
                }
                if (row["Datetime3"] != null && row["Datetime3"].ToString() != "")
                {
                    model.Datetime3 = DateTime.Parse(row["Datetime3"].ToString());
                }
                if (row["Datetime4"] != null && row["Datetime4"].ToString() != "")
                {
                    model.Datetime4 = DateTime.Parse(row["Datetime4"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Icon_ID,Icon_Name,Icon_Path,Icon_Person,Icon_Is_Existing,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
            strSql.Append(" FROM Iconlibrary ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Icon_ID,Icon_Name,Icon_Path,Icon_Person,Icon_Is_Existing,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
            strSql.Append(" FROM Iconlibrary ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Iconlibrary ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Icon_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Iconlibrary T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Iconlibrary";
            parameters[1].Value = "Icon_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod


        ///// <summary>
        // 批量更新数据
        // </summary>
        public int UpdateList( List<Tellyes.Model.Iconlibrary> iconModelList)
        {
            List<string> SQLStringList = new List<string>();

            foreach (Tellyes.Model.Iconlibrary iconModel in iconModelList)
           {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update Iconlibrary set ");
                strSql.Append("Icon_Name='" + iconModel.Icon_Name + "',");
                strSql.Append("Icon_Path='" + iconModel.Icon_Path + "',");
                strSql.Append("Icon_Person=" + iconModel.Icon_Person + ",");
                strSql.Append("Icon_Is_Existing=" + iconModel.Icon_Is_Existing + ",");

                #region  对允许为空的字段的处理
                if (iconModel.Number1 != null)
                {
                    strSql.Append("Number1=" + iconModel.Number1 + ",");
                }
                if (iconModel.Number2 != null)
                {
                    strSql.Append("Number2=" + iconModel.Number2 + ",");
                }
                if (iconModel.Number3 != null)
                {
                    strSql.Append("Number3=" + iconModel.Number3 + ",");
                }
                if (iconModel.Number4 != null)
                {
                    strSql.Append("Number4=" + iconModel.Number4 + ",");
                }
                if (iconModel.Number5 != null)
                {
                    strSql.Append("Number5=" + iconModel.Number5 + ",");
                }
                if (iconModel.Number6 != null)
                {
                    strSql.Append("Number6=" + iconModel.Number6 + ",");
                }
                if (iconModel.Number7 != null)
                {
                    strSql.Append("Number7=" + iconModel.Number7 + ",");
                }
                if (iconModel.Number8 != null)
                {
                    strSql.Append("Number8=" + iconModel.Number8 + ",");
                }
                if (iconModel.String1 != null)
                {
                    strSql.Append("String1='" + iconModel.String1 + "',");
                }
                if (iconModel.String2 != null)
                {
                    strSql.Append("String2='" + iconModel.String2 + "',");
                }
                if (iconModel.String3 != null)
                {
                    strSql.Append("String3='" + iconModel.String3 + "',");
                }
                if (iconModel.String4 != null)
                {
                    strSql.Append("String4='" + iconModel.String4 + "',");
                }
                if (iconModel.String5 != null)
                {
                    strSql.Append("String5='" + iconModel.String5 + "',");
                }
                if (iconModel.String6 != null)
                {
                    strSql.Append("String6='" + iconModel.String6 + "',");
                }
                if (iconModel.String7 != null)
                {
                    strSql.Append("String7='" + iconModel.String7 + "',");
                }
                if (iconModel.String8 != null)
                {
                    strSql.Append("String8='" + iconModel.String8 + "',");
                }
                if (iconModel.Datetime1 <= new DateTime(1900, 1, 1))
                {
                    iconModel.Datetime1 = new DateTime(1900, 1, 1);
                    strSql.Append("Datetime1='" + iconModel.Datetime1 + "',");
                }
                if (iconModel.Datetime2 <= new DateTime(1900, 1, 1))
                {
                    iconModel.Datetime2 = new DateTime(1900, 1, 1);
                    strSql.Append("Datetime2='" + iconModel.Datetime2 + "',");
                }
                if (iconModel.Datetime3 <= new DateTime(1900, 1, 1))
                {
                    iconModel.Datetime3 = new DateTime(1900, 1, 1);
                    strSql.Append("Datetime3='" + iconModel.Datetime3 + "',");
                }
                if (iconModel.Datetime4 <= new DateTime(1900, 1, 1))
                {
                    iconModel.Datetime4 = new DateTime(1900, 1, 1);
                    strSql.Append("Datetime4='" + iconModel.Datetime4 + "'");
                }                 
                #endregion               

                strSql.Append(" where Icon_ID=" + iconModel.Icon_ID);
                SQLStringList.Add(strSql.ToString());
          }        

            int rows = DbHelperSQL.ExecuteSqlTran(SQLStringList);
           
            if (rows > 0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }
        #endregion  ExtensionMethod
    }
}
