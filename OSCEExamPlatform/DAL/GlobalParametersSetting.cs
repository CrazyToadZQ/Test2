using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class GlobalParametersSetting : BaseDAL<Model.GlobalParametersSetting>
    {
        public GlobalParametersSetting()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Global_Parameters_Setting_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GlobalParametersSetting");
            strSql.Append(" where Global_Parameters_Setting_ID=@Global_Parameters_Setting_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Global_Parameters_Setting_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Global_Parameters_Setting_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.GlobalParametersSetting model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into GlobalParametersSetting(");
            strSql.Append("Judge_Is_Support_Binding_Multi_Mark_Sheet,SP_Is_Support_Binding_Mark_Sheet,Global_Parameter1,Global_Parameter2,Global_Parameter3,Global_Parameter4,Global_Parameter5,Global_Parameter6,Global_Parameter7,Global_Parameter8,Global_Parameter9,Global_Parameter10,Global_Parameter11,Global_Parameter12,Global_Parameter13,Global_Parameter14,Global_Parameter15,Global_Parameter16,Global_Parameter17,Global_Parameter18,Global_Parameter19,Global_Parameter20,Global_Parameter21,Global_Parameter22,Global_Parameter23,Global_Parameter24,Global_Parameter25,Global_Parameter26,Global_Parameter27,Global_Parameter28,Global_Parameter29,Global_Parameter30)");
            strSql.Append(" values (");
            strSql.Append("@Judge_Is_Support_Binding_Multi_Mark_Sheet,@SP_Is_Support_Binding_Mark_Sheet,@Global_Parameter1,@Global_Parameter2,@Global_Parameter3,@Global_Parameter4,@Global_Parameter5,@Global_Parameter6,@Global_Parameter7,@Global_Parameter8,@Global_Parameter9,@Global_Parameter10,@Global_Parameter11,@Global_Parameter12,@Global_Parameter13,@Global_Parameter14,@Global_Parameter15,@Global_Parameter16,@Global_Parameter17,@Global_Parameter18,@Global_Parameter19,@Global_Parameter20,@Global_Parameter21,@Global_Parameter22,@Global_Parameter23,@Global_Parameter24,@Global_Parameter25,@Global_Parameter26,@Global_Parameter27,@Global_Parameter28,@Global_Parameter29,@Global_Parameter30)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Judge_Is_Support_Binding_Multi_Mark_Sheet", SqlDbType.Int,4),
					new SqlParameter("@SP_Is_Support_Binding_Mark_Sheet", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter1", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter2", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter3", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter4", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter5", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter6", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter7", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter8", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter9", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter10", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter11", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter12", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter13", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter14", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter15", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter16", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter17", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter18", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter19", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter20", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter21", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter22", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter23", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter24", SqlDbType.VarChar,-1),
					new SqlParameter("@Global_Parameter25", SqlDbType.VarChar,-1),
					new SqlParameter("@Global_Parameter26", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter27", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter28", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter29", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter30", SqlDbType.DateTime)};
            parameters[0].Value = model.Judge_Is_Support_Binding_Multi_Mark_Sheet;
            parameters[1].Value = model.SP_Is_Support_Binding_Mark_Sheet;
            parameters[2].Value = model.Global_Parameter1;
            parameters[3].Value = model.Global_Parameter2;
            parameters[4].Value = model.Global_Parameter3;
            parameters[5].Value = model.Global_Parameter4;
            parameters[6].Value = model.Global_Parameter5;
            parameters[7].Value = model.Global_Parameter6;
            parameters[8].Value = model.Global_Parameter7;
            parameters[9].Value = model.Global_Parameter8;
            parameters[10].Value = model.Global_Parameter9;
            parameters[11].Value = model.Global_Parameter10;
            parameters[12].Value = model.Global_Parameter11;
            parameters[13].Value = model.Global_Parameter12;
            parameters[14].Value = model.Global_Parameter13;
            parameters[15].Value = model.Global_Parameter14;
            parameters[16].Value = model.Global_Parameter15;
            parameters[17].Value = model.Global_Parameter16;
            parameters[18].Value = model.Global_Parameter17;
            parameters[19].Value = model.Global_Parameter18;
            parameters[20].Value = model.Global_Parameter19;
            parameters[21].Value = model.Global_Parameter20;
            parameters[22].Value = model.Global_Parameter21;
            parameters[23].Value = model.Global_Parameter22;
            parameters[24].Value = model.Global_Parameter23;
            parameters[25].Value = model.Global_Parameter24;
            parameters[26].Value = model.Global_Parameter25;
            parameters[27].Value = model.Global_Parameter26;
            parameters[28].Value = model.Global_Parameter27;
            parameters[29].Value = model.Global_Parameter28;
            parameters[30].Value = model.Global_Parameter29;
            parameters[31].Value = model.Global_Parameter30;

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
        public bool Update(Tellyes.Model.GlobalParametersSetting model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update GlobalParametersSetting set ");
            strSql.Append("Judge_Is_Support_Binding_Multi_Mark_Sheet=@Judge_Is_Support_Binding_Multi_Mark_Sheet,");
            strSql.Append("SP_Is_Support_Binding_Mark_Sheet=@SP_Is_Support_Binding_Mark_Sheet,");
            strSql.Append("Global_Parameter1=@Global_Parameter1,");
            strSql.Append("Global_Parameter2=@Global_Parameter2,");
            strSql.Append("Global_Parameter3=@Global_Parameter3,");
            strSql.Append("Global_Parameter4=@Global_Parameter4,");
            strSql.Append("Global_Parameter5=@Global_Parameter5,");
            strSql.Append("Global_Parameter6=@Global_Parameter6,");
            strSql.Append("Global_Parameter7=@Global_Parameter7,");
            strSql.Append("Global_Parameter8=@Global_Parameter8,");
            strSql.Append("Global_Parameter9=@Global_Parameter9,");
            strSql.Append("Global_Parameter10=@Global_Parameter10,");
            strSql.Append("Global_Parameter11=@Global_Parameter11,");
            strSql.Append("Global_Parameter12=@Global_Parameter12,");
            strSql.Append("Global_Parameter13=@Global_Parameter13,");
            strSql.Append("Global_Parameter14=@Global_Parameter14,");
            strSql.Append("Global_Parameter15=@Global_Parameter15,");
            strSql.Append("Global_Parameter16=@Global_Parameter16,");
            strSql.Append("Global_Parameter17=@Global_Parameter17,");
            strSql.Append("Global_Parameter18=@Global_Parameter18,");
            strSql.Append("Global_Parameter19=@Global_Parameter19,");
            strSql.Append("Global_Parameter20=@Global_Parameter20,");
            strSql.Append("Global_Parameter21=@Global_Parameter21,");
            strSql.Append("Global_Parameter22=@Global_Parameter22,");
            strSql.Append("Global_Parameter23=@Global_Parameter23,");
            strSql.Append("Global_Parameter24=@Global_Parameter24,");
            strSql.Append("Global_Parameter25=@Global_Parameter25,");
            strSql.Append("Global_Parameter26=@Global_Parameter26,");
            strSql.Append("Global_Parameter27=@Global_Parameter27,");
            strSql.Append("Global_Parameter28=@Global_Parameter28,");
            strSql.Append("Global_Parameter29=@Global_Parameter29,");
            strSql.Append("Global_Parameter30=@Global_Parameter30");
            strSql.Append(" where Global_Parameters_Setting_ID=@Global_Parameters_Setting_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Judge_Is_Support_Binding_Multi_Mark_Sheet", SqlDbType.Int,4),
					new SqlParameter("@SP_Is_Support_Binding_Mark_Sheet", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter1", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter2", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter3", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter4", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter5", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter6", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter7", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter8", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter9", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter10", SqlDbType.Int,4),
					new SqlParameter("@Global_Parameter11", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter12", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter13", SqlDbType.Decimal,13),
					new SqlParameter("@Global_Parameter14", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter15", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter16", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter17", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter18", SqlDbType.VarChar,50),
					new SqlParameter("@Global_Parameter19", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter20", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter21", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter22", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter23", SqlDbType.VarChar,200),
					new SqlParameter("@Global_Parameter24", SqlDbType.VarChar,-1),
					new SqlParameter("@Global_Parameter25", SqlDbType.VarChar,-1),
					new SqlParameter("@Global_Parameter26", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter27", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter28", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter29", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameter30", SqlDbType.DateTime),
					new SqlParameter("@Global_Parameters_Setting_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Judge_Is_Support_Binding_Multi_Mark_Sheet;
            parameters[1].Value = model.SP_Is_Support_Binding_Mark_Sheet;
            parameters[2].Value = model.Global_Parameter1;
            parameters[3].Value = model.Global_Parameter2;
            parameters[4].Value = model.Global_Parameter3;
            parameters[5].Value = model.Global_Parameter4;
            parameters[6].Value = model.Global_Parameter5;
            parameters[7].Value = model.Global_Parameter6;
            parameters[8].Value = model.Global_Parameter7;
            parameters[9].Value = model.Global_Parameter8;
            parameters[10].Value = model.Global_Parameter9;
            parameters[11].Value = model.Global_Parameter10;
            parameters[12].Value = model.Global_Parameter11;
            parameters[13].Value = model.Global_Parameter12;
            parameters[14].Value = model.Global_Parameter13;
            parameters[15].Value = model.Global_Parameter14;
            parameters[16].Value = model.Global_Parameter15;
            parameters[17].Value = model.Global_Parameter16;
            parameters[18].Value = model.Global_Parameter17;
            parameters[19].Value = model.Global_Parameter18;
            parameters[20].Value = model.Global_Parameter19;
            parameters[21].Value = model.Global_Parameter20;
            parameters[22].Value = model.Global_Parameter21;
            parameters[23].Value = model.Global_Parameter22;
            parameters[24].Value = model.Global_Parameter23;
            parameters[25].Value = model.Global_Parameter24;
            parameters[26].Value = model.Global_Parameter25;
            parameters[27].Value = model.Global_Parameter26;
            parameters[28].Value = model.Global_Parameter27;
            parameters[29].Value = model.Global_Parameter28;
            parameters[30].Value = model.Global_Parameter29;
            parameters[31].Value = model.Global_Parameter30;
            parameters[32].Value = model.Global_Parameters_Setting_ID;

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
        public bool Delete(int Global_Parameters_Setting_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GlobalParametersSetting ");
            strSql.Append(" where Global_Parameters_Setting_ID=@Global_Parameters_Setting_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Global_Parameters_Setting_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Global_Parameters_Setting_ID;

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
        public bool DeleteList(string Global_Parameters_Setting_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GlobalParametersSetting ");
            strSql.Append(" where Global_Parameters_Setting_ID in (" + Global_Parameters_Setting_IDlist + ")  ");
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
        public Tellyes.Model.GlobalParametersSetting GetModel(int Global_Parameters_Setting_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Global_Parameters_Setting_ID,Judge_Is_Support_Binding_Multi_Mark_Sheet,SP_Is_Support_Binding_Mark_Sheet,Global_Parameter1,Global_Parameter2,Global_Parameter3,Global_Parameter4,Global_Parameter5,Global_Parameter6,Global_Parameter7,Global_Parameter8,Global_Parameter9,Global_Parameter10,Global_Parameter11,Global_Parameter12,Global_Parameter13,Global_Parameter14,Global_Parameter15,Global_Parameter16,Global_Parameter17,Global_Parameter18,Global_Parameter19,Global_Parameter20,Global_Parameter21,Global_Parameter22,Global_Parameter23,Global_Parameter24,Global_Parameter25,Global_Parameter26,Global_Parameter27,Global_Parameter28,Global_Parameter29,Global_Parameter30 from GlobalParametersSetting ");
            strSql.Append(" where Global_Parameters_Setting_ID=@Global_Parameters_Setting_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Global_Parameters_Setting_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Global_Parameters_Setting_ID;

            Tellyes.Model.GlobalParametersSetting model = new Tellyes.Model.GlobalParametersSetting();
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
        public Tellyes.Model.GlobalParametersSetting DataRowToModel(DataRow row)
        {
            Tellyes.Model.GlobalParametersSetting model = new Tellyes.Model.GlobalParametersSetting();
            if (row != null)
            {
                if (row["Global_Parameters_Setting_ID"] != null && row["Global_Parameters_Setting_ID"].ToString() != "")
                {
                    model.Global_Parameters_Setting_ID = int.Parse(row["Global_Parameters_Setting_ID"].ToString());
                }
                if (row["Judge_Is_Support_Binding_Multi_Mark_Sheet"] != null && row["Judge_Is_Support_Binding_Multi_Mark_Sheet"].ToString() != "")
                {
                    model.Judge_Is_Support_Binding_Multi_Mark_Sheet = int.Parse(row["Judge_Is_Support_Binding_Multi_Mark_Sheet"].ToString());
                }
                if (row["SP_Is_Support_Binding_Mark_Sheet"] != null && row["SP_Is_Support_Binding_Mark_Sheet"].ToString() != "")
                {
                    model.SP_Is_Support_Binding_Mark_Sheet = int.Parse(row["SP_Is_Support_Binding_Mark_Sheet"].ToString());
                }
                if (row["Global_Parameter1"] != null && row["Global_Parameter1"].ToString() != "")
                {
                    model.Global_Parameter1 = int.Parse(row["Global_Parameter1"].ToString());
                }
                if (row["Global_Parameter2"] != null && row["Global_Parameter2"].ToString() != "")
                {
                    model.Global_Parameter2 = int.Parse(row["Global_Parameter2"].ToString());
                }
                if (row["Global_Parameter3"] != null && row["Global_Parameter3"].ToString() != "")
                {
                    model.Global_Parameter3 = int.Parse(row["Global_Parameter3"].ToString());
                }
                if (row["Global_Parameter4"] != null && row["Global_Parameter4"].ToString() != "")
                {
                    model.Global_Parameter4 = int.Parse(row["Global_Parameter4"].ToString());
                }
                if (row["Global_Parameter5"] != null && row["Global_Parameter5"].ToString() != "")
                {
                    model.Global_Parameter5 = int.Parse(row["Global_Parameter5"].ToString());
                }
                if (row["Global_Parameter6"] != null && row["Global_Parameter6"].ToString() != "")
                {
                    model.Global_Parameter6 = int.Parse(row["Global_Parameter6"].ToString());
                }
                if (row["Global_Parameter7"] != null && row["Global_Parameter7"].ToString() != "")
                {
                    model.Global_Parameter7 = int.Parse(row["Global_Parameter7"].ToString());
                }
                if (row["Global_Parameter8"] != null && row["Global_Parameter8"].ToString() != "")
                {
                    model.Global_Parameter8 = int.Parse(row["Global_Parameter8"].ToString());
                }
                if (row["Global_Parameter9"] != null && row["Global_Parameter9"].ToString() != "")
                {
                    model.Global_Parameter9 = int.Parse(row["Global_Parameter9"].ToString());
                }
                if (row["Global_Parameter10"] != null && row["Global_Parameter10"].ToString() != "")
                {
                    model.Global_Parameter10 = int.Parse(row["Global_Parameter10"].ToString());
                }
                if (row["Global_Parameter11"] != null && row["Global_Parameter11"].ToString() != "")
                {
                    model.Global_Parameter11 = decimal.Parse(row["Global_Parameter11"].ToString());
                }
                if (row["Global_Parameter12"] != null && row["Global_Parameter12"].ToString() != "")
                {
                    model.Global_Parameter12 = decimal.Parse(row["Global_Parameter12"].ToString());
                }
                if (row["Global_Parameter13"] != null && row["Global_Parameter13"].ToString() != "")
                {
                    model.Global_Parameter13 = decimal.Parse(row["Global_Parameter13"].ToString());
                }
                if (row["Global_Parameter14"] != null)
                {
                    model.Global_Parameter14 = row["Global_Parameter14"].ToString();
                }
                if (row["Global_Parameter15"] != null)
                {
                    model.Global_Parameter15 = row["Global_Parameter15"].ToString();
                }
                if (row["Global_Parameter16"] != null)
                {
                    model.Global_Parameter16 = row["Global_Parameter16"].ToString();
                }
                if (row["Global_Parameter17"] != null)
                {
                    model.Global_Parameter17 = row["Global_Parameter17"].ToString();
                }
                if (row["Global_Parameter18"] != null)
                {
                    model.Global_Parameter18 = row["Global_Parameter18"].ToString();
                }
                if (row["Global_Parameter19"] != null)
                {
                    model.Global_Parameter19 = row["Global_Parameter19"].ToString();
                }
                if (row["Global_Parameter20"] != null)
                {
                    model.Global_Parameter20 = row["Global_Parameter20"].ToString();
                }
                if (row["Global_Parameter21"] != null)
                {
                    model.Global_Parameter21 = row["Global_Parameter21"].ToString();
                }
                if (row["Global_Parameter22"] != null)
                {
                    model.Global_Parameter22 = row["Global_Parameter22"].ToString();
                }
                if (row["Global_Parameter23"] != null)
                {
                    model.Global_Parameter23 = row["Global_Parameter23"].ToString();
                }
                if (row["Global_Parameter24"] != null)
                {
                    model.Global_Parameter24 = row["Global_Parameter24"].ToString();
                }
                if (row["Global_Parameter25"] != null)
                {
                    model.Global_Parameter25 = row["Global_Parameter25"].ToString();
                }
                if (row["Global_Parameter26"] != null && row["Global_Parameter26"].ToString() != "")
                {
                    model.Global_Parameter26 = DateTime.Parse(row["Global_Parameter26"].ToString());
                }
                if (row["Global_Parameter27"] != null && row["Global_Parameter27"].ToString() != "")
                {
                    model.Global_Parameter27 = DateTime.Parse(row["Global_Parameter27"].ToString());
                }
                if (row["Global_Parameter28"] != null && row["Global_Parameter28"].ToString() != "")
                {
                    model.Global_Parameter28 = DateTime.Parse(row["Global_Parameter28"].ToString());
                }
                if (row["Global_Parameter29"] != null && row["Global_Parameter29"].ToString() != "")
                {
                    model.Global_Parameter29 = DateTime.Parse(row["Global_Parameter29"].ToString());
                }
                if (row["Global_Parameter30"] != null && row["Global_Parameter30"].ToString() != "")
                {
                    model.Global_Parameter30 = DateTime.Parse(row["Global_Parameter30"].ToString());
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
            strSql.Append("select Global_Parameters_Setting_ID,Judge_Is_Support_Binding_Multi_Mark_Sheet,SP_Is_Support_Binding_Mark_Sheet,Global_Parameter1,Global_Parameter2,Global_Parameter3,Global_Parameter4,Global_Parameter5,Global_Parameter6,Global_Parameter7,Global_Parameter8,Global_Parameter9,Global_Parameter10,Global_Parameter11,Global_Parameter12,Global_Parameter13,Global_Parameter14,Global_Parameter15,Global_Parameter16,Global_Parameter17,Global_Parameter18,Global_Parameter19,Global_Parameter20,Global_Parameter21,Global_Parameter22,Global_Parameter23,Global_Parameter24,Global_Parameter25,Global_Parameter26,Global_Parameter27,Global_Parameter28,Global_Parameter29,Global_Parameter30 ");
            strSql.Append(" FROM GlobalParametersSetting ");
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
            strSql.Append(" Global_Parameters_Setting_ID,Judge_Is_Support_Binding_Multi_Mark_Sheet,SP_Is_Support_Binding_Mark_Sheet,Global_Parameter1,Global_Parameter2,Global_Parameter3,Global_Parameter4,Global_Parameter5,Global_Parameter6,Global_Parameter7,Global_Parameter8,Global_Parameter9,Global_Parameter10,Global_Parameter11,Global_Parameter12,Global_Parameter13,Global_Parameter14,Global_Parameter15,Global_Parameter16,Global_Parameter17,Global_Parameter18,Global_Parameter19,Global_Parameter20,Global_Parameter21,Global_Parameter22,Global_Parameter23,Global_Parameter24,Global_Parameter25,Global_Parameter26,Global_Parameter27,Global_Parameter28,Global_Parameter29,Global_Parameter30 ");
            strSql.Append(" FROM GlobalParametersSetting ");
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
            strSql.Append("select count(1) FROM GlobalParametersSetting ");
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
                strSql.Append("order by T.Global_Parameters_Setting_ID desc");
            }
            strSql.Append(")AS Row, T.*  from GlobalParametersSetting T ");
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
            parameters[0].Value = "GlobalParametersSetting";
            parameters[1].Value = "Global_Parameters_Setting_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 得到第一条记录（Top 1）
        /// </summary>
        public Tellyes.Model.GlobalParametersSetting GetModelTopOne()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Global_Parameters_Setting_ID,Judge_Is_Support_Binding_Multi_Mark_Sheet,SP_Is_Support_Binding_Mark_Sheet,Global_Parameter1,Global_Parameter2,Global_Parameter3,Global_Parameter4,Global_Parameter5,Global_Parameter6,Global_Parameter7,Global_Parameter8,Global_Parameter9,Global_Parameter10,Global_Parameter11,Global_Parameter12,Global_Parameter13,Global_Parameter14,Global_Parameter15,Global_Parameter16,Global_Parameter17,Global_Parameter18,Global_Parameter19,Global_Parameter20,Global_Parameter21,Global_Parameter22,Global_Parameter23,Global_Parameter24,Global_Parameter25,Global_Parameter26,Global_Parameter27,Global_Parameter28,Global_Parameter29,Global_Parameter30 from GlobalParametersSetting ");
            Tellyes.Model.GlobalParametersSetting model = new Tellyes.Model.GlobalParametersSetting();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod

        #region NHibernate Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }

        #endregion

    }
}
