using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class MultiStationExamArrangement : BaseDAL<Model.MultiStationExamArrangement>
    {
        #region Basic
        public bool Exists(int MSEA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MultiStationExamArrangement");
            strSql.Append(" where ");
            strSql.Append(" MSEA_ID = @MSEA_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@MSEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSEA_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MultiStationExamArrangement model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MultiStationExamArrangement(");
            strSql.Append("E_ID,ES_ID,Room_ID,EStu_ID,U_ID,Exam_StartTime,Exam_EndTime");
            strSql.Append(") values (");
            strSql.Append("@E_ID,@ES_ID,@Room_ID,@EStu_ID,@U_ID,@Exam_StartTime,@Exam_EndTime");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@U_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Exam_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@Exam_EndTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.E_ID;
            parameters[1].Value = model.ES_ID;
            parameters[2].Value = model.Room_ID;
            parameters[3].Value = model.EStu_ID;
            parameters[4].Value = model.U_ID;
            parameters[5].Value = model.Exam_StartTime;
            parameters[6].Value = model.Exam_EndTime;

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
        public bool Update(Model.MultiStationExamArrangement model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MultiStationExamArrangement set ");

            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" ES_ID = @ES_ID , ");
            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" EStu_ID = @EStu_ID , ");
            strSql.Append(" U_ID = @U_ID , ");
            strSql.Append(" Exam_StartTime = @Exam_StartTime , ");
            strSql.Append(" Exam_EndTime = @Exam_EndTime  ");
            strSql.Append(" where MSEA_ID=@MSEA_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@MSEA_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@U_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Exam_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@Exam_EndTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.MSEA_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.ES_ID;
            parameters[3].Value = model.Room_ID;
            parameters[4].Value = model.EStu_ID;
            parameters[5].Value = model.U_ID;
            parameters[6].Value = model.Exam_StartTime;
            parameters[7].Value = model.Exam_EndTime;
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
        public bool Delete(int MSEA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExamArrangement ");
            strSql.Append(" where MSEA_ID=@MSEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSEA_ID;


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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string MSEA_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExamArrangement ");
            strSql.Append(" where ID in (" + MSEA_IDlist + ")  ");
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
        public Model.MultiStationExamArrangement GetModel(int MSEA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MSEA_ID, E_ID, ES_ID, Room_ID, EStu_ID, U_ID, Exam_StartTime, Exam_EndTime  ");
            strSql.Append("  from MultiStationExamArrangement ");
            strSql.Append(" where MSEA_ID=@MSEA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSEA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSEA_ID;


            Model.MultiStationExamArrangement model = new Model.MultiStationExamArrangement();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MSEA_ID"].ToString() != "")
                {
                    model.MSEA_ID = int.Parse(ds.Tables[0].Rows[0]["MSEA_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(ds.Tables[0].Rows[0]["E_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ES_ID"].ToString() != "")
                {
                    model.ES_ID = Guid.Parse(ds.Tables[0].Rows[0]["ES_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(ds.Tables[0].Rows[0]["Room_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = Guid.Parse(ds.Tables[0].Rows[0]["EStu_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(ds.Tables[0].Rows[0]["U_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Exam_StartTime"].ToString() != "")
                {
                    model.Exam_StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["Exam_StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Exam_EndTime"].ToString() != "")
                {
                    model.Exam_EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["Exam_EndTime"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.MultiStationExamArrangement DataRowToModel(DataRow row)
        {
            Tellyes.Model.MultiStationExamArrangement model = new Tellyes.Model.MultiStationExamArrangement();
            if (row != null)
            {
                if (row["MSEA_ID"] != null && row["MSEA_ID"].ToString() != "")
                {
                    model.MSEA_ID = int.Parse(row["MSEA_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(row["E_ID"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = Guid.Parse(row["ES_ID"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(row["Room_ID"].ToString());
                }
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = Guid.Parse(row["EStu_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["Exam_StartTime"] != null && row["Exam_StartTime"].ToString() != "")
                {
                    model.Exam_StartTime = DateTime.Parse(row["Exam_StartTime"].ToString());
                }
                if (row["Exam_EndTime"] != null && row["Exam_EndTime"].ToString() != "")
                {
                    model.Exam_EndTime = DateTime.Parse(row["Exam_EndTime"].ToString());
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
            strSql.Append("select * ");
            strSql.Append(" FROM MultiStationExamArrangement ");
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
            strSql.Append(" * ");
            strSql.Append(" FROM MultiStationExamArrangement ");
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
            strSql.Append("select count(1) FROM MultiStationExamArrangement ");
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
                strSql.Append("order by T.MSEA_ID desc");
            }
            strSql.Append(")AS Row, T.*  from MultiStationExamArrangement T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion

        #region ExtensionMethod

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
                .Append("   [MultiStationExamArrangement] AS [ExamArrangement] ")
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
                .Append("   AND [ExamArrangement].[Exam_StartTime] >= :minExamStartTime ")
                .Append("   AND [ExamArrangement].[Exam_StartTime] <= :maxExamStartTime ")
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
                .Append("   [MultiStationExamArrangement] AS [ExamArrangement] ")
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
                sqlBuilder.Append(" AND [ExamArrangement].[Exam_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[Exam_StartTime] <= :maxExamStartTime ");
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
                .Append("   [ExamArrangement].[Exam_StartTime], ")
                .Append("   [ExamArrangement].[Exam_EndTime], ")
                .Append("   [ScoreInfo].[SI_Score], ")
                .Append("   [ScoreInfo].[SI_int2] ")
                .Append("FROM ")
                .Append("   [MultiStationExamArrangement] AS [ExamArrangement] ")
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
                sqlBuilder.Append(" AND [ExamArrangement].[Exam_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[Exam_StartTime] <= :maxExamStartTime ");
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
                .Append("   [ExamArrangement].[Exam_StartTime] ASC ");
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
                    .AddScalar("Exam_StartTime", NHibernateUtil.DateTime)
                    .AddScalar("SI_Score", NHibernateUtil.Decimal)
                    .AddScalar("SI_int2", NHibernateUtil.Int32)
                    .AddScalar("Exam_EndTime", NHibernateUtil.DateTime);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("Exam_ID")) 
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["Exam_ID"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("ES_ID", conditionDictionary["ES_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Room_ID", conditionDictionary["Room_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,GE"))
            {
                criteria.Add(Restrictions.Ge("Exam_StartTime", conditionDictionary["Exam_StartTime,GE"]));
            }
            if (conditionDictionary.ContainsKey("Exam_StartTime,LE"))
            {
                criteria.Add(Restrictions.Le("Exam_StartTime", conditionDictionary["Exam_StartTime,LE"]));
            }

            if (conditionDictionary.ContainsKey("ES_ID,In"))
            {
                criteria.Add(Restrictions.In("ES_ID", (List<Guid> )conditionDictionary["ES_ID,In"]));
            }

            if (conditionDictionary.ContainsKey("EStu_ID,In"))
            {
                criteria.Add(Restrictions.In("EStu_ID", (List<Guid>)conditionDictionary["EStu_ID,In"]));
            }

            if (conditionDictionary.ContainsKey("E_ID,Eq")) 
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,Eq"]));
            }
            return criteria;
        }

        /// <summary>
        /// 根据RoomID查找考试ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetExamID(string RoomID)
        {
            //string strSql = string.Format(@"select top 1 * from [MultiStationExamArrangement] where Room_ID ='{0}' and 
            //  Exam_EndTime = (select MIN (Exam_EndTime ) from [MultiStationExamArrangement] where Exam_EndTime >= GETDATE () and Room_ID = '{0}')", RoomID);
            string strSql = string.Format(@"select top 1 * from [MultiStationExamArrangement] left join [ExamTable] on [MultiStationExamArrangement].E_ID = [ExamTable].E_ID
            where Room_ID ='{0}' and Exam_EndTime = (select MIN (Exam_EndTime ) from [MultiStationExamArrangement] where Exam_EndTime >= GETDATE () and Room_ID = '{0}')
            and [ExamTable].E_State = '2' and [ExamTable].int1 = '1'", RoomID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站排考表
        /// </summary>
        /// <param name="ExamID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetArrangementTable(Guid ExamID, int RoomID)
        {
            string strSql = string.Format("select E_ID,ES_ID ,Room_ID ,U_ID ,Exam_StartTime ,Exam_EndTime from [MultiStationExamArrangement] where E_ID = '{0}' and Room_ID = '{1}' order by Exam_StartTime", ExamID, RoomID);
            return DbHelperSQL.Query(strSql);
        }

        public DataSet GetSystemTime()
        {
            string strSql = "select getdate()";
            return DbHelperSQL.Query(strSql);
        }
        #endregion

        #region ExtensionMethod
        /// <summary>
        /// 根据考试EID查找考试房间ID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet GetMultiRoom(Guid EID)
        {
            string strSql = string.Format("SELECT distinct (Room_ID) FROM [MultiStationExamArrangement] where E_ID = '{0}'", EID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 查找该房间的考试开始时间和结束时间
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetRoomExamStartEndTime(Guid EID, int RoomID)
        {
            string strSql = string.Format("select * from [MultiStationExamArrangement] where E_ID = '{0}' and Room_ID = '{1}' order by Exam_StartTime",EID ,RoomID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion
    }
}