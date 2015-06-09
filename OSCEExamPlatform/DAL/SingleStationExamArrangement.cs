using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using System.Collections.Generic;
using Tellyes.Log4Net;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:SingleStationExamArrangement
	/// </summary>
	public partial class SingleStationExamArrangement : BaseDAL<Model.SingleStationExamArrangement>
	{
		public SingleStationExamArrangement()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SE_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SingleStationExamArrangement");
			strSql.Append(" where SE_ID=@SE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = SE_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(Tellyes.Model.SingleStationExamArrangement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SingleStationExamArrangement(");
			strSql.Append("E_ID,U_ID,Room_ID,SE_StartTime,ES_ID)");
			strSql.Append(" values (");
			strSql.Append("@E_ID,@U_ID,@Room_ID,@SE_StartTime,@ES_ID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@SE_StartTime", SqlDbType.DateTime),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.U_ID;
			parameters[2].Value = model.Room_ID;
			parameters[3].Value = model.SE_StartTime;
			parameters[4].Value = model.ES_ID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
        public bool Update(Tellyes.Model.SingleStationExamArrangement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SingleStationExamArrangement set ");
			strSql.Append("E_ID=@E_ID,");
			strSql.Append("U_ID=@U_ID,");
			strSql.Append("Room_ID=@Room_ID,");
			strSql.Append("SE_StartTime=@SE_StartTime,");
			strSql.Append("ES_ID=@ES_ID");
			strSql.Append(" where SE_ID=@SE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@SE_StartTime", SqlDbType.DateTime),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@SE_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.U_ID;
			parameters[2].Value = model.Room_ID;
			parameters[3].Value = model.SE_StartTime;
			parameters[4].Value = model.ES_ID;
			parameters[5].Value = model.SE_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int SE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SingleStationExamArrangement ");
			strSql.Append(" where SE_ID=@SE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = SE_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string SE_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SingleStationExamArrangement ");
			strSql.Append(" where SE_ID in ("+SE_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Tellyes.Model.SingleStationExamArrangement GetModel(int SE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 SE_ID,E_ID,U_ID,Room_ID,SE_StartTime,ES_ID,SE_EndTime from SingleStationExamArrangement ");
			strSql.Append(" where SE_ID=@SE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = SE_ID;

            Tellyes.Model.SingleStationExamArrangement model = new Tellyes.Model.SingleStationExamArrangement();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
        public Tellyes.Model.SingleStationExamArrangement DataRowToModel(DataRow row)
		{
            Tellyes.Model.SingleStationExamArrangement model = new Tellyes.Model.SingleStationExamArrangement();
			if (row != null)
			{
				if(row["SE_ID"]!=null && row["SE_ID"].ToString()!="")
				{
					model.SE_ID=int.Parse(row["SE_ID"].ToString());
				}
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID=Guid.Parse(row["E_ID"].ToString());
				}
				if(row["U_ID"]!=null && row["U_ID"].ToString()!="")
				{
					model.U_ID=int.Parse(row["U_ID"].ToString());
				}
				if(row["Room_ID"]!=null && row["Room_ID"].ToString()!="")
				{
					model.Room_ID=int.Parse(row["Room_ID"].ToString());
				}
				if(row["SE_StartTime"]!=null && row["SE_StartTime"].ToString()!="")
				{
					model.SE_StartTime=DateTime.Parse(row["SE_StartTime"].ToString());
				}
                if (row["SE_EndTime"] != null && row["SE_EndTime"].ToString() != "")
                {
                    model.SE_EndTime = DateTime.Parse(row["SE_EndTime"].ToString());
                }
				if(row["ES_ID"]!=null && row["ES_ID"].ToString()!="")
				{
					model.ES_ID=Guid.Parse(row["ES_ID"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select SE_ID,E_ID,U_ID,Room_ID,SE_StartTime,ES_ID,SE_EndTime ");
			strSql.Append(" FROM SingleStationExamArrangement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" SE_ID,E_ID,U_ID,Room_ID,SE_StartTime,ES_ID ");
			strSql.Append(" FROM SingleStationExamArrangement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SingleStationExamArrangement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.SE_ID desc");
			}
			strSql.Append(")AS Row, T.*  from SingleStationExamArrangement T ");
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
			parameters[0].Value = "SingleStationExamArrangement";
			parameters[1].Value = "SE_ID";
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
        /// 根据RoomID查找考试ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetExamID(string RoomID)
        {
            //string strSql = string.Format(@"select top 1 * from [SingleStationExamArrangement] where Room_ID = '{0}' and 
            //SE_StartTime = (select MIN (SE_StartTime) from [SingleStationExamArrangement] where SE_StartTime >= GETDATE() and Room_ID = '{0}')", RoomID);
            string strSql = string.Format(@"select top 1 * from [SingleStationExamArrangement] left join [ExamTable] on [SingleStationExamArrangement].E_ID = [ExamTable].E_ID
                    where [SingleStationExamArrangement].Room_ID = '{0}' and 
  [SingleStationExamArrangement].SE_StartTime = (select MIN (SE_StartTime) from [SingleStationExamArrangement] where SE_EndTime >= GETDATE() and Room_ID = '{0}')
                            and [ExamTable].E_State = '2' and [ExamTable].int1 = '1' ", RoomID);
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
            string strSql = string.Format("select E_ID ,ES_ID ,Room_ID ,U_ID ,SE_StartTime from [SingleStationExamArrangement] where E_ID = '{0}' and Room_ID = '{1}' order by SE_StartTime", ExamID, RoomID);
            return DbHelperSQL.Query(strSql);
        }
		#endregion  ExtensionMethod

        #region NHibernate Extension

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
                .Append("   [SingleStationExamArrangement] AS [ExamArrangement] ")
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
                .Append("   AND [ExamArrangement].[SE_StartTime] >= :minExamStartTime ")
                .Append("   AND [ExamArrangement].[SE_StartTime] <= :maxExamStartTime ")
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
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,Eq"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,Eq"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,Eq"]))
                    .SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Ge"]))
                    .SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Le"]));
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
                .Append("   [SingleStationExamArrangement] AS [ExamArrangement] ")
                .Append("   INNER JOIN [ExamStudent] ")
                .Append("       ON [ExamArrangement].[ExamStudent_ID] = [ExamStudent].[EStu_ID] ")
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
            if (conditionDictionary.ContainsKey("SE_StartTime,Ge"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[SE_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("SE_StartTime,Le"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[SE_StartTime] <= :maxExamStartTime ");
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
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,Eq"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,Eq"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,Eq"]));
                if (conditionDictionary.ContainsKey("SE_StartTime,Ge"))
                {
                    iSQLQuery.SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Ge"]));
                }
                if (conditionDictionary.ContainsKey("SE_StartTime,Le"))
                {
                    iSQLQuery.SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Le"]));
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
                .Append("   [ExamArrangement].[SE_StartTime], ")
                .Append("   [ExamArrangement].[SE_EndTime], ")
                .Append("   [ScoreInfo].[SI_Score], ")
                .Append("   [ScoreInfo].[SI_int2] ")
                .Append("FROM ")
                .Append("   [SingleStationExamArrangement] AS [ExamArrangement] ")
                .Append("   INNER JOIN [ExamStudent] ")
                .Append("       ON [ExamArrangement].[ExamStudent_ID] = [ExamStudent].[EStu_ID] ")
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
            if (conditionDictionary.ContainsKey("SE_StartTime,Ge"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[SE_StartTime] >= :minExamStartTime ");
            }
            if (conditionDictionary.ContainsKey("SE_StartTime,Le"))
            {
                sqlBuilder.Append(" AND [ExamArrangement].[SE_StartTime] <= :maxExamStartTime ");
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
                .Append("   [ExamArrangement].[SE_StartTime] ASC ");
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
                    .AddScalar("SE_StartTime", NHibernateUtil.DateTime)
                    .AddScalar("SI_Score", NHibernateUtil.Decimal)
                    .AddScalar("SI_int2", NHibernateUtil.Int32)
                    .AddScalar("SE_EndTime", NHibernateUtil.DateTime);
                //设置查询参数
                iSQLQuery
                    .SetInt32("judgeUserInfoID", Convert.ToInt32(conditionDictionary["JudgeUserInfoID,Eq"]))
                    .SetGuid("examTableID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()))
                    .SetGuid("examStationID", Guid.Parse(conditionDictionary["ES_ID,Eq"].ToString()))
                    .SetInt32("roomID", Convert.ToInt32(conditionDictionary["Room_ID,Eq"]));
                if (conditionDictionary.ContainsKey("SE_StartTime,Ge"))
                {
                    iSQLQuery.SetDateTime("minExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Ge"]));
                }
                if (conditionDictionary.ContainsKey("SE_StartTime,Le"))
                {
                    iSQLQuery.SetDateTime("maxExamStartTime", Convert.ToDateTime(conditionDictionary["SE_StartTime,Le"]));
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

        #endregion

        #region ExtensionMethod
        //查找单站考试房间
        public DataSet GetSingleRoom(Guid EID)
        {
            string strSql = string.Format("select distinct (Room_ID) FROM [SingleStationExamArrangement] where E_ID = '{0}'", EID);
            return DbHelperSQL.Query(strSql);
        }

        //查找该房间的考试开始时间和结束时间
        public DataSet GetRoomExamStartEndTime(Guid EID , int RoomID)
        {
            string strSql = string.Format("select * from [SingleStationExamArrangement] where E_ID = '{0}' and Room_ID = '{1}' order by SE_StartTime",EID ,RoomID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion
    }
}

