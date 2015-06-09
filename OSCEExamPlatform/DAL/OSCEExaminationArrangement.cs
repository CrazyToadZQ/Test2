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
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:OSCEExaminationArrangement
    /// </summary>
    public partial class OSCEExaminationArrangement : BaseDAL<Model.OSCEExaminationArrangement>
    {
        public OSCEExaminationArrangement()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int OEA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OSCEExaminationArrangement");
            strSql.Append(" where OEA_ID=@OEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@OEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = OEA_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.OSCEExaminationArrangement model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OSCEExaminationArrangement(");
            strSql.Append("EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@EStu_ID,@ESR_ID,@OEA_StartTime,@OEA_EndTime,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9)};
            parameters[0].Value = model.EStu_ID;
            parameters[1].Value = model.ESR_ID;
            parameters[2].Value = model.OEA_StartTime;
            parameters[3].Value = model.OEA_EndTime;
            parameters[4].Value = model.int1;
            parameters[5].Value = model.int2;
            parameters[6].Value = model.int3;
            parameters[7].Value = model.string1;
            parameters[8].Value = model.string2;
            parameters[9].Value = model.string3;
            parameters[10].Value = model.date1;
            parameters[11].Value = model.date2;
            parameters[12].Value = model.date3;
            parameters[13].Value = model.float1;
            parameters[14].Value = model.float2;
            parameters[15].Value = model.float3;

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
        public bool Update(Tellyes.Model.OSCEExaminationArrangement model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OSCEExaminationArrangement set ");
            strSql.Append("EStu_ID=@EStu_ID,");
            strSql.Append("ESR_ID=@ESR_ID,");
            strSql.Append("OEA_StartTime=@OEA_StartTime,");
            strSql.Append("OEA_EndTime=@OEA_EndTime,");
            strSql.Append("int1=@int1,");
            strSql.Append("int2=@int2,");
            strSql.Append("int3=@int3,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3,");
            strSql.Append("date1=@date1,");
            strSql.Append("date2=@date2,");
            strSql.Append("date3=@date3,");
            strSql.Append("float1=@float1,");
            strSql.Append("float2=@float2,");
            strSql.Append("float3=@float3");
            strSql.Append(" where OEA_ID=@OEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.EStu_ID;
            parameters[1].Value = model.ESR_ID;
            parameters[2].Value = model.OEA_StartTime;
            parameters[3].Value = model.OEA_EndTime;
            parameters[4].Value = model.int1;
            parameters[5].Value = model.int2;
            parameters[6].Value = model.int3;
            parameters[7].Value = model.string1;
            parameters[8].Value = model.string2;
            parameters[9].Value = model.string3;
            parameters[10].Value = model.date1;
            parameters[11].Value = model.date2;
            parameters[12].Value = model.date3;
            parameters[13].Value = model.float1;
            parameters[14].Value = model.float2;
            parameters[15].Value = model.float3;
            parameters[16].Value = model.OEA_ID;

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
        public bool Delete(int OEA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEExaminationArrangement ");
            strSql.Append(" where OEA_ID=@OEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@OEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = OEA_ID;

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
        public bool DeleteList(string OEA_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEExaminationArrangement ");
            strSql.Append(" where OEA_ID in (" + OEA_IDlist + ")  ");
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
        public Tellyes.Model.OSCEExaminationArrangement GetModel(int OEA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from OSCEExaminationArrangement ");
            strSql.Append(" where OEA_ID=@OEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@OEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = OEA_ID;

            Tellyes.Model.OSCEExaminationArrangement model = new Tellyes.Model.OSCEExaminationArrangement();
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
        public Tellyes.Model.OSCEExaminationArrangement DataRowToModel(DataRow row)
        {
            Tellyes.Model.OSCEExaminationArrangement model = new Tellyes.Model.OSCEExaminationArrangement();
            if (row != null)
            {
                if (row["OEA_ID"] != null && row["OEA_ID"].ToString() != "")
                {
                    model.OEA_ID = int.Parse(row["OEA_ID"].ToString());
                }
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = new Guid(row["EStu_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["OEA_StartTime"] != null && row["OEA_StartTime"].ToString() != "")
                {
                    model.OEA_StartTime = DateTime.Parse(row["OEA_StartTime"].ToString());
                }
                if (row["OEA_EndTime"] != null && row["OEA_EndTime"].ToString() != "")
                {
                    model.OEA_EndTime = DateTime.Parse(row["OEA_EndTime"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = int.Parse(row["int1"].ToString());
                }
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.int2 = int.Parse(row["int2"].ToString());
                }
                if (row["int3"] != null && row["int3"].ToString() != "")
                {
                    model.int3 = int.Parse(row["int3"].ToString());
                }
                if (row["string1"] != null)
                {
                    model.string1 = row["string1"].ToString();
                }
                if (row["string2"] != null)
                {
                    model.string2 = row["string2"].ToString();
                }
                if (row["string3"] != null)
                {
                    model.string3 = row["string3"].ToString();
                }
                if (row["date1"] != null && row["date1"].ToString() != "")
                {
                    model.date1 = DateTime.Parse(row["date1"].ToString());
                }
                if (row["date2"] != null && row["date2"].ToString() != "")
                {
                    model.date2 = DateTime.Parse(row["date2"].ToString());
                }
                if (row["date3"] != null && row["date3"].ToString() != "")
                {
                    model.date3 = DateTime.Parse(row["date3"].ToString());
                }
                if (row["float1"] != null && row["float1"].ToString() != "")
                {
                    model.float1 = decimal.Parse(row["float1"].ToString());
                }
                if (row["float2"] != null && row["float2"].ToString() != "")
                {
                    model.float2 = decimal.Parse(row["float2"].ToString());
                }
                if (row["float3"] != null && row["float3"].ToString() != "")
                {
                    model.float3 = decimal.Parse(row["float3"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(row["Room_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
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
            strSql.Append("select OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,E_ID,ES_ID,Room_ID,U_ID ");
            strSql.Append(" FROM OSCEExaminationArrangement ");
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
            strSql.Append(" OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM OSCEExaminationArrangement ");
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
            strSql.Append("select count(1) FROM OSCEExaminationArrangement ");
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
                strSql.Append("order by T.OEA_ID desc");
            }
            strSql.Append(")AS Row, T.*  from OSCEExaminationArrangement T ");
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
            parameters[0].Value = "OSCEExaminationArrangement";
            parameters[1].Value = "OEA_ID";
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
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public object[] SelectStudentCountDictionaryInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   COUNT(*) AS [All_Student_Count], ")
                .Append("   COUNT(DISTINCT [ScoreInfo].[SI_ID]) AS [Student_With_Score_Count] ")
                .Append("FROM ")
                .Append("   [OSCEExaminationArrangement] AS [ExamArrangement] ")
                .Append("   LEFT JOIN [ScoreInfo] ")
                .Append("       ON [ExamArrangement].[E_ID] = [ScoreInfo].[Exam_ID] ")
                .Append("           AND [ExamArrangement].[ES_ID] = [ScoreInfo].[ExamStation_ID] ")
                .Append("           AND [ExamArrangement].[Room_ID] = [ScoreInfo].[Room_ID] ")
                .Append("           AND [ExamArrangement].[U_ID] = [ScoreInfo].[Student_ID] ")
                .Append("           AND [ScoreInfo].[Rater_ID] = :judgeUserInfoID ")
                .Append("           AND [ScoreInfo].[SI_int2] = 2 ")
                .Append("WHERE ")
                .Append("   [ExamArrangement].[E_ID] = :examTableID ")
                .Append("   AND [ExamArrangement].[ES_ID] = :examStationID ")
                .Append("   AND [ExamArrangement].[Room_ID] = :roomID ")
                .Append("   AND [ExamArrangement].[OEA_StartTime] >= :minExamStartTime ")
                .Append("   AND [ExamArrangement].[OEA_StartTime] <= :maxExamStartTime ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("All_Student_Count", NHibernateUtil.Int32)
                    .AddScalar("Student_With_Score_Count", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,EQ"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,EQ"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,EQ"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,EQ"]))
                    .SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,GE"]))
                    .SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,LE"]));
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult(0)
                    .SetMaxResults(1)
                    .List<object[]>()
                    .ToList<object[]>()[0];
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，查询考试学生数量失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectStudentCountInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   COUNT(*) AS [Student_Count] ")
                .Append("FROM ")
                .Append("   [OSCEExaminationArrangement] AS [ExamArrangement] ")
                .Append("   INNER JOIN [ExamStudent] ")
                .Append("       ON [ExamArrangement].[EStu_ID] = [ExamStudent].[EStu_ID] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamArrangement].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN [ScoreInfo] ")
                .Append("       ON [ExamArrangement].[E_ID] = [ScoreInfo].[Exam_ID]  ")
                .Append("           AND [ExamArrangement].[ES_ID] = [ScoreInfo].[ExamStation_ID] ")
                .Append("           AND [ExamArrangement].[Room_ID] = [ScoreInfo].[Room_ID] ")
                .Append("           AND [ExamArrangement].[U_ID] = [ScoreInfo].[Student_ID] ")
                .Append("           AND [ScoreInfo].[Rater_ID] = :judgeUserInfoID ")
                .Append("WHERE ")
                .Append("   [ExamArrangement].[E_ID] = :examTableID ")
                .Append("   AND [ExamArrangement].[ES_ID] = :examStationID ")
                .Append("   AND [ExamArrangement].[Room_ID] = :roomID ");
            if (conditionDictionary.ContainsKey("Exam_StartTime,GE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[OEA_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[OEA_StartTime] <= :maxExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("ScoreInfoID,IsNotNull"))
            {
                sqlBuilder
                    .Append(" AND [ScoreInfo].[SI_ID] IS NOT NULL ")
                    .Append(" AND [ScoreInfo].[SI_int2] = 2 ");
            }
            if (conditionDictionary.ContainsKey("ScoreInfoID,IsNull"))
            {
                sqlBuilder.Append(" AND ([ScoreInfo].[SI_ID] IS NULL OR [ScoreInfo].[SI_int2] <> 2) ");
            }
            if (conditionDictionary.ContainsKey("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"))
            {
                sqlBuilder
                    .Append(" AND ( ")
                    .Append("   [UserInfo].[U_Name] LIKE :studentUserInfoName ")
                    .Append("   OR [UserInfo].[U_TrueName] LIKE :studentUserInfoTrueName ")
                    .Append("   OR [ExamStudent].[EStu_ExamNumber] LIKE :examStudentNumber ")
                    .Append(") ");
            }
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sqlBuilder.ToString());
                //设置查询结果类型
                iSQLQuery.AddScalar("Student_Count", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,EQ"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,EQ"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,EQ"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,EQ"]));
                if (conditionDictionary.ContainsKey("Exam_StartTime,GE"))
                {
                    iSQLQuery.SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,GE"]));
                }
                if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
                {
                    iSQLQuery.SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,LE"]));
                }
                if (conditionDictionary.ContainsKey("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"))
                {
                    string param = "%" + conditionDictionary["UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"] + "%";
                    iSQLQuery
                        .SetString("studentUserInfoName", param)
                        .SetString("studentUserInfoTrueName", param)
                        .SetString("examStudentNumber", param);
                }
                //查询结果并返回
                return iSQLQuery.UniqueResult<int>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，查询考试学生分页信息，查询符合条件的考生数量失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectStudentListInHandScoreByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamArrangement].[U_ID], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [Organization].[O_Name], ")
                .Append("   [ExamArrangement].[OEA_StartTime], ")
                .Append("   [ExamArrangement].[OEA_EndTime], ")
                .Append("   [ScoreInfo].[SI_Score], ")
                .Append("   [ScoreInfo].[SI_int2] ")
                .Append("FROM ")
                .Append("   [OSCEExaminationArrangement] AS [ExamArrangement] ")
                .Append("   INNER JOIN [ExamStudent] ")
                .Append("       ON [ExamArrangement].[EStu_ID] = [ExamStudent].[EStu_ID] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamArrangement].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserOrganization].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [UserOrganization].[O_ID] = [Organization].[O_ID] ")
                .Append("   LEFT JOIN [ScoreInfo] ")
                .Append("       ON [ExamArrangement].[E_ID] = [ScoreInfo].[Exam_ID]  ")
                .Append("           AND [ExamArrangement].[ES_ID] = [ScoreInfo].[ExamStation_ID] ")
                .Append("           AND [ExamArrangement].[Room_ID] = [ScoreInfo].[Room_ID] ")
                .Append("           AND [ExamArrangement].[U_ID] = [ScoreInfo].[Student_ID] ")
                .Append("           AND [ScoreInfo].[Rater_ID] = :judgeUserInfoID ")
                .Append("WHERE ")
                .Append("   [ExamArrangement].[E_ID] = :examTableID ")
                .Append("   AND [ExamArrangement].[ES_ID] = :examStationID ")
                .Append("   AND [ExamArrangement].[Room_ID] = :roomID ");
            if (conditionDictionary.ContainsKey("Exam_StartTime,GE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[OEA_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[OEA_StartTime] <= :maxExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("ScoreInfoID,IsNotNull"))
            {
                sqlBuilder
                    .Append(" AND [ScoreInfo].[SI_ID] IS NOT NULL ")
                    .Append(" AND [ScoreInfo].[SI_int2] = 2 ");
            }
            if (conditionDictionary.ContainsKey("ScoreInfoID,IsNull"))
            {
                sqlBuilder.Append(" AND ([ScoreInfo].[SI_ID] IS NULL OR [ScoreInfo].[SI_int2] <> 2) ");
            }
            if (conditionDictionary.ContainsKey("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"))
            {
                sqlBuilder
                    .Append(" AND ( ")
                    .Append("   [UserInfo].[U_Name] LIKE :studentUserInfoName ")
                    .Append("   OR [UserInfo].[U_TrueName] LIKE :studentUserInfoTrueName ")
                    .Append("   OR [ExamStudent].[EStu_ExamNumber] LIKE :examStudentNumber ")
                    .Append(") ");
            }
            sqlBuilder
                .Append("ORDER BY ")
                .Append("   [ExamArrangement].[OEA_StartTime] ASC ");
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sqlBuilder.ToString());
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("U_ID", NHibernateUtil.Int32)
                    .AddScalar("U_TrueName", NHibernateUtil.String)
                    .AddScalar("U_Name", NHibernateUtil.String)
                    .AddScalar("EStu_ExamNumber", NHibernateUtil.Int32)
                    .AddScalar("O_Name", NHibernateUtil.String)
                    .AddScalar("OEA_StartTime", NHibernateUtil.DateTime)
                    .AddScalar("SI_Score", NHibernateUtil.Decimal)
                    .AddScalar("SI_int2", NHibernateUtil.Int32)
                    .AddScalar("OEA_EndTime", NHibernateUtil.DateTime);
                //设置查询参数
                iSQLQuery
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,EQ"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,EQ"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,EQ"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,EQ"]));
                if (conditionDictionary.ContainsKey("Exam_StartTime,GE"))
                {
                    iSQLQuery.SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,GE"]));
                }
                if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
                {
                    iSQLQuery.SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["Exam_StartTime,LE"]));
                }
                if (conditionDictionary.ContainsKey("UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"))
                {
                    string param = "%" + conditionDictionary["UserInfoName,UserInfoTrueName,ExamStudentNumber,Like"] + "%";
                    iSQLQuery
                        .SetString("studentUserInfoName", param)
                        .SetString("studentUserInfoTrueName", param)
                        .SetString("examStudentNumber", param);
                }
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult((pageIndex - 1) * pageSize)
                    .SetMaxResults(pageSize)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，查询考试学生分页信息，查询符合条件的考生失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion  ExtensionMethod

        #region ExtensionMethod
        public DataSet GetOsceRoom(Guid EID)
        {
            string strSql = string.Format("select distinct (Room_ID) FROM [OSCEExaminationArrangement] where E_ID = '{0}'", EID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion
    }
}
