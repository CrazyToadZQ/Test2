using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using Tellyes.Log4Net;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamStationClass
    /// </summary>
    public partial class ExamStationClass : BaseDAL<Tellyes.Model.ExamStationClass>
    {
        public ExamStationClass()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Exam_Station_Class_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamStationClass");
            strSql.Append(" where Exam_Station_Class_ID=@Exam_Station_Class_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_Class_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStationClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamStationClass(");
            strSql.Append("Exam_Station_Class_Name,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4)");
            strSql.Append(" values (");
            strSql.Append("@Exam_Station_Class_Name,@Number1,@Number2,@Number3,@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@String2,@String3,@String4,@String5,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@Datetime4)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_Class_Name", SqlDbType.NVarChar,50),
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
            parameters[0].Value = model.Exam_Station_Class_Name;
            parameters[1].Value = model.Number1;
            parameters[2].Value = model.Number2;
            parameters[3].Value = model.Number3;
            parameters[4].Value = model.Number4;
            parameters[5].Value = model.Number5;
            parameters[6].Value = model.Number6;
            parameters[7].Value = model.Number7;
            parameters[8].Value = model.Number8;
            parameters[9].Value = model.String1;
            parameters[10].Value = model.String2;
            parameters[11].Value = model.String3;
            parameters[12].Value = model.String4;
            parameters[13].Value = model.String5;
            parameters[14].Value = model.String6;
            parameters[15].Value = model.String7;
            parameters[16].Value = model.String8;
            parameters[17].Value = model.Datetime1;
            parameters[18].Value = model.Datetime2;
            parameters[19].Value = model.Datetime3;
            parameters[20].Value = model.Datetime4;

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
        public bool Update(Tellyes.Model.ExamStationClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamStationClass set ");
            strSql.Append("Exam_Station_Class_Name=@Exam_Station_Class_Name,");
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
            strSql.Append(" where Exam_Station_Class_ID=@Exam_Station_Class_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_Class_Name", SqlDbType.NVarChar,50),
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
					new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Exam_Station_Class_Name;
            parameters[1].Value = model.Number1;
            parameters[2].Value = model.Number2;
            parameters[3].Value = model.Number3;
            parameters[4].Value = model.Number4;
            parameters[5].Value = model.Number5;
            parameters[6].Value = model.Number6;
            parameters[7].Value = model.Number7;
            parameters[8].Value = model.Number8;
            parameters[9].Value = model.String1;
            parameters[10].Value = model.String2;
            parameters[11].Value = model.String3;
            parameters[12].Value = model.String4;
            parameters[13].Value = model.String5;
            parameters[14].Value = model.String6;
            parameters[15].Value = model.String7;
            parameters[16].Value = model.String8;
            parameters[17].Value = model.Datetime1;
            parameters[18].Value = model.Datetime2;
            parameters[19].Value = model.Datetime3;
            parameters[20].Value = model.Datetime4;
            parameters[21].Value = model.Exam_Station_Class_ID;

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
        public bool Delete(int Exam_Station_Class_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStationClass ");
            strSql.Append(" where Exam_Station_Class_ID=@Exam_Station_Class_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_Class_ID;

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
        public bool DeleteList(string Exam_Station_Class_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStationClass ");
            strSql.Append(" where Exam_Station_Class_ID in (" + Exam_Station_Class_IDlist + ")  ");
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
        public Tellyes.Model.ExamStationClass GetModel(int Exam_Station_Class_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Exam_Station_Class_ID,Exam_Station_Class_Name,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 from ExamStationClass ");
            strSql.Append(" where Exam_Station_Class_ID=@Exam_Station_Class_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_Class_ID;

            Tellyes.Model.ExamStationClass model = new Tellyes.Model.ExamStationClass();
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
        public Tellyes.Model.ExamStationClass DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamStationClass model = new Tellyes.Model.ExamStationClass();
            if (row != null)
            {
                if (row["Exam_Station_Class_ID"] != null && row["Exam_Station_Class_ID"].ToString() != "")
                {
                    model.Exam_Station_Class_ID = int.Parse(row["Exam_Station_Class_ID"].ToString());
                }
                if (row["Exam_Station_Class_Name"] != null)
                {
                    model.Exam_Station_Class_Name = row["Exam_Station_Class_Name"].ToString();
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
            strSql.Append("select Exam_Station_Class_ID,Exam_Station_Class_Name,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
            strSql.Append(" FROM ExamStationClass ");
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
            strSql.Append(" Exam_Station_Class_ID,Exam_Station_Class_Name,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
            strSql.Append(" FROM ExamStationClass ");
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
            strSql.Append("select count(1) FROM ExamStationClass ");
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
                strSql.Append("order by T.Exam_Station_Class_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamStationClass T ");
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
            parameters[0].Value = "ExamStationClass";
            parameters[1].Value = "Exam_Station_Class_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod

        #region  ExtensionMethod   


        #endregion  ExtensionMethod


        #region  NHibernate 数据库操作方法

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("Number1"))
            {
                criteria.Add(Restrictions.Eq("Number1", 1));
            }
            if (conditionDictionary.ContainsKey("Number1,Eq"))
            {
                criteria.Add(Restrictions.Eq("Number1", conditionDictionary["Number1,Eq"]));
            }
            if (conditionDictionary.ContainsKey("Number2,Eq"))
            {
                criteria.Add(Restrictions.Eq("Number2", conditionDictionary["Number2,Eq"]));
            }
            return criteria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public List<Tellyes.Model.ExamStationClass> SelectExamStationClassByRoomID(int roomID)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [ExamStationClass].[Exam_Station_Class_ID], ")
                    .Append("   [ExamStationClass].[Exam_Station_Class_Name], ")
                    .Append("   [ExamStationClass].[Number1], ")
                    .Append("   [ExamStationClass].[Number2] ")
                    .Append("FROM ")
                    .Append("   [Room] ")
                    .Append("   INNER JOIN [RoomExamStationClassRelation] AS [Relation] ")
                    .Append("       ON [Room].[Room_ID] = [Relation].[Room_ID] ")
                    .Append("   INNER JOIN [ExamStationClass] ")
                    .Append("       ON [ExamStationClass].[Exam_Station_Class_ID] = [Relation].[Exam_Station_Class_ID] ")
                    .Append("WHERE ")
                    .Append("   [Room].[Room_ID] = :Room_ID ")
                    .Append("   AND [ExamStationClass].[Number1] = 1 ")
                    .ToString();
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.ExamStationClass))
                    .SetInt32("Room_ID", roomID)
                    .List<Model.ExamStationClass>().
                    ToList<Model.ExamStationClass>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询ExamStationClass信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        } 
        #endregion
    }
}
