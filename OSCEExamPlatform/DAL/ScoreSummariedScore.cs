using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using Tellyes.Log4Net;//Please add references
namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ScoreSummariedScore
    /// </summary>
    public partial class ScoreSummariedScore : BaseDAL<Model.ScoreSummariedScore>
    {
        public ScoreSummariedScore()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ScoreSummariedScore");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ScoreSummariedScore model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ScoreSummariedScore(");
            strSql.Append("Student_ID,E_ID,ES_ID,Room_ID,score,timeStamp,lateScoreID,EStu_ExamNumber)");
            strSql.Append(" values (");
            strSql.Append("@Student_ID,@E_ID,@ES_ID,@Room_ID,@score,@timeStamp,@lateScoreID,@EStu_ExamNumber)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Student_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@score", SqlDbType.Decimal,9),
					new SqlParameter("@timeStamp", SqlDbType.NVarChar,50),
					new SqlParameter("@lateScoreID", SqlDbType.NVarChar,500),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4)};
            parameters[0].Value = model.Student_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.ES_ID;
            parameters[3].Value = model.Room_ID;
            parameters[4].Value = model.score;
            parameters[5].Value = model.timeStamp;
            parameters[6].Value = model.lateScoreID;
            parameters[7].Value = model.EStu_ExamNumber;

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
        public bool Update(Tellyes.Model.ScoreSummariedScore model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ScoreSummariedScore set ");
            strSql.Append("Student_ID=@Student_ID,");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("ES_ID=@ES_ID,");
            strSql.Append("Room_ID=@Room_ID,");
            strSql.Append("score=@score,");
            strSql.Append("timeStamp=@timeStamp,");
            strSql.Append("lateScoreID=@lateScoreID,");
            strSql.Append("EStu_ExamNumber=@EStu_ExamNumber");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@Student_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@score", SqlDbType.Decimal,9),
					new SqlParameter("@timeStamp", SqlDbType.NVarChar,50),
					new SqlParameter("@lateScoreID", SqlDbType.NVarChar,500),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.Student_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.ES_ID;
            parameters[3].Value = model.Room_ID;
            parameters[4].Value = model.score;
            parameters[5].Value = model.timeStamp;
            parameters[6].Value = model.lateScoreID;
            parameters[7].Value = model.EStu_ExamNumber;
            parameters[8].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreSummariedScore ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreSummariedScore ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public Tellyes.Model.ScoreSummariedScore GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,Student_ID,E_ID,ES_ID,Room_ID,score,timeStamp,lateScoreID,EStu_ExamNumber from ScoreSummariedScore ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            Tellyes.Model.ScoreSummariedScore model = new Tellyes.Model.ScoreSummariedScore();
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
        public Tellyes.Model.ScoreSummariedScore DataRowToModel(DataRow row)
        {
            Tellyes.Model.ScoreSummariedScore model = new Tellyes.Model.ScoreSummariedScore();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Student_ID"] != null && row["Student_ID"].ToString() != "")
                {
                    model.Student_ID = int.Parse(row["Student_ID"].ToString());
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
                if (row["score"] != null && row["score"].ToString() != "")
                {
                    model.score = decimal.Parse(row["score"].ToString());
                }
                if (row["timeStamp"] != null)
                {
                    model.timeStamp = row["timeStamp"].ToString();
                }
                if (row["lateScoreID"] != null)
                {
                    model.lateScoreID = row["lateScoreID"].ToString();
                }
                if (row["EStu_ExamNumber"] != null && row["EStu_ExamNumber"].ToString() != "")
                {
                    model.EStu_ExamNumber = int.Parse(row["EStu_ExamNumber"].ToString());
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
            strSql.Append("select id,Student_ID,E_ID,ES_ID,Room_ID,score,timeStamp,lateScoreID,EStu_ExamNumber ");
            strSql.Append(" FROM ScoreSummariedScore ");
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
            strSql.Append(" id,Student_ID,E_ID,ES_ID,Room_ID,score,timeStamp,lateScoreID,EStu_ExamNumber ");
            strSql.Append(" FROM ScoreSummariedScore ");
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
            strSql.Append("select count(1) FROM ScoreSummariedScore ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from ScoreSummariedScore T ");
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
            parameters[0].Value = "ScoreSummariedScore";
            parameters[1].Value = "id";
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
        /// 获取插入命令
        /// </summary>
        public CommandInfo GetInsetCmdInfo(Tellyes.Model.ScoreSummariedScore model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ScoreSummariedScore(");
            strSql.Append("Student_ID,E_ID,ES_ID,score,timeStamp,lateScoreID)");
            strSql.Append(" values (");
            strSql.Append("@Student_ID,@E_ID,@ES_ID,@score,@timeStamp,@lateScoreID)");
            //strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Student_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@score", SqlDbType.Decimal,9),
					new SqlParameter("@timeStamp", SqlDbType.NVarChar,50),
					new SqlParameter("@lateScoreID", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.Student_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.ES_ID;
            parameters[3].Value = model.score;
            parameters[4].Value = model.timeStamp;
            parameters[5].Value = model.lateScoreID;

            return new CommandInfo(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取删除命令
        /// </summary>
        public CommandInfo GetDeleteCmdInfo(Guid examID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreSummariedScore ");
            strSql.Append(" where E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16)
			};
            parameters[0].Value = examID;

            return new CommandInfo(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 事务处理（插入成绩）
        /// </summary>
        /// <param name="SSSmodelList"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(System.Collections.Generic.List<Tellyes.Model.ScoreSummariedScore> SSSmodelList, Guid examID)
        {
            System.Collections.Generic.List<CommandInfo> cmdList = new System.Collections.Generic.List<CommandInfo>();
            cmdList.Add(GetDeleteCmdInfo(examID));//
            foreach (Tellyes.Model.ScoreSummariedScore model in SSSmodelList)
            {
                cmdList.Add(GetInsetCmdInfo(model));//
            }

            int count = DbHelperSQL.ExecuteSqlTran(cmdList);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得考试成绩 详细信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="Student_ID"></param>
        /// <returns></returns>
        public static DataTable GetScoreDetail(string E_ID, string Student_ID)
        {
            string sql = " select distinct (select ES_Name from dbo.ExamStation where ES_ID=base.ES_ID) as ES_Name,Student_ID,E_ID,ES_ID,score,EStu_ExamNumber from dbo.ScoreSummariedScore as base where E_ID='" + E_ID + "' and Student_ID ='" + Student_ID + "'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获得当天考试列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllExams() 
        {
            string sql = " select distinct E_ID,(select E_Name from dbo.ExamTable where E_ID=base.E_ID) as E_Name from dbo.ScoreScanScoreSchema as base where CONVERT(nvarchar(10), ExecDateTime,102) like '%"+DateTime.Now.ToString("yyyy.MM.dd")+"%'  ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获得待打印成绩列表
        /// </summary>
        /// <param name="E_ID">考试ID</param>
        /// <param name="EStu_int">状态 0|Null</param>
        /// <param name="Student_ID">学号</param>
        /// <param name="EStu_ExamNumber">考号</param>
        /// <param name="U_TrueName">真实姓名</param>
        /// <returns></returns>
        public static DataTable GetScorePrintList(string E_ID, string EStu_int = null, string Student_ID = null,string EStu_ExamNumber=null, string U_TrueName=null)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct Student_ID,ui.U_TrueName,es.EStu_ExamNumber,es.EStu_int ");
            sql.Append(" from dbo.ScoreSummariedScore as ss join dbo.ExamStudent as es ");
            sql.Append(" on ss.Student_ID=es.U_ID and ss.E_ID=es.E_ID ");
            sql.Append(" join UserInfo as ui on ss.Student_ID=ui.U_ID ");
            sql.Append(" where ss.E_ID='"+E_ID+"' ");
            if (EStu_int != null)
            {
                sql.Append(" and es.EStu_int=0 ");
            }
            if (Student_ID != null)
            {
                sql.Append(" and ss.Student_ID='" + Student_ID + "' ");
            }
            if (EStu_ExamNumber != null) 
            {
                sql.Append(" and es.EStu_ExamNumber='" + EStu_ExamNumber + "' ");
            }
            if (U_TrueName != null)
            {
                sql.Append(" and ui.U_TrueName='" + U_TrueName + "' ");
            }
            sql.Append(" ; ");

            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }

        /// <summary>
        /// 获取某次考试所有考生的成绩信息
        /// </summary>
        /// <param name="classIDs">班级列表（例如：'2','3','4'）</param>
        /// <param name="examID">考试id</param>
        /// <param name="noExamStudentIDs">未参加学生列表（例如：'2','3','4'）</param>
        /// <returns></returns>
        public DataSet GetStatisticsScoreList(string classIDs, Guid examID, string noExamStudentIDs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.O_ID as Class_ID,A.U_ID as Student_ID,B.E_ID,B.ES_ID,B.score as Score,B.timeStamp,B.lateScoreID from ");
            strSql.Append(string.Format(" (select * from UserOrganization where O_ID in ({0})) as A ", classIDs));
            strSql.Append(string.Format(" left join (select * from ScoreSummariedScore where E_ID='{0}') as B on A.U_ID=B.Student_ID ", examID));
            if (noExamStudentIDs != string.Empty)
            {
                strSql.Append(string.Format(" where A.U_ID not in ({0}) ", noExamStudentIDs));
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某次考试单个考生的成绩信息
        /// </summary>
        /// <param name="examID"></param>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public DataSet GetSingleStudentScore(Guid examID, int studentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.O_ID as Class_ID,A.U_ID as Student_ID,B.E_ID,B.ES_ID,B.score as Score,B.timeStamp,B.lateScoreID from ");
            strSql.Append(string.Format(" (select * from UserOrganization where U_ID={0}) as A ", studentID));
            strSql.Append(string.Format(" left join (select * from ScoreSummariedScore where E_ID='{0}') as B on A.U_ID=B.Student_ID ", examID));

            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod

        #region ExtensionNHibernateMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
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
            if (conditionDictionary.ContainsKey("Student_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Student_ID", conditionDictionary["Student_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("Student_ID,In"))
            {
                criteria.Add(Restrictions.In("Student_ID", (List<int>)conditionDictionary["Student_ID,In"]));
            }
            if (conditionDictionary.ContainsKey("ScoreSummariedScoreID,In"))
            {
                criteria.Add(Restrictions.In("id", (List<int>)conditionDictionary["ScoreSummariedScoreID,In"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,NEQ")) 
            {
                criteria.Add(Restrictions.Not(Restrictions.Eq("ES_ID", conditionDictionary["ES_ID,NEQ"])));
            }
            return criteria;
        }

        #region

        /// <summary>
        /// 成绩查询与打印页面 查询打印预览信息-多站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectScoreSummariedScoreRoomPrintInMultiStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [MultiStationExamArrangement].*, ")
                .Append("   [Room].[Room_Name], ")
                .Append("   [ScoreSummariedScore].[score] ")
                .Append("FROM ")
                .Append("   [MultiStationExamArrangement] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [MultiStationExamArrangement].[Room_ID] = [Room].[Room_ID] ")
                .Append("   LEFT JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreSummariedScore].[E_ID] = [MultiStationExamArrangement].[E_ID] ")
                .Append("           AND [ScoreSummariedScore].[ES_ID] = [MultiStationExamArrangement].[ES_ID] ")
                .Append("           AND [ScoreSummariedScore].[Student_ID] = [MultiStationExamArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [MultiStationExamArrangement].[E_ID] = :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");

            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [MultiStationExamArrangement].[U_ID]  IN  (:U_IDList) ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.MultiStationExamArrangement));
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Score", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In"))
                {
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }
               
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 查询打印预览信息-长短站
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectScoreSummariedScoreRoomPrintInLongShortStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [OSCEExaminationArrangement].*, ")
                .Append("   [Room].[Room_Name], ")
                .Append("   [ScoreSummariedScore].[score] ")
                .Append("FROM ")
                .Append("   [OSCEExaminationArrangement] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [OSCEExaminationArrangement].[Room_ID] = [Room].[Room_ID] ")
                .Append("   LEFT JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreSummariedScore].[E_ID] = [OSCEExaminationArrangement].[E_ID] ")
                .Append("           AND [ScoreSummariedScore].[ES_ID] = [OSCEExaminationArrangement].[ES_ID] ")
                .Append("           AND [ScoreSummariedScore].[Student_ID] = [OSCEExaminationArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [OSCEExaminationArrangement].[E_ID] = :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");

            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [OSCEExaminationArrangement].[U_ID]  IN  (:U_IDList) ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.OSCEExaminationArrangement));
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Score", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In"))
                {
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }

                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 查询打印预览信息-单站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectScoreSummariedScoreRoomPrintInSingleStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [SingleStationExamArrangement].*, ")
                .Append("   [Room].[Room_Name], ")
                .Append("   [ScoreSummariedScore].[score] ")
                .Append("FROM ")
                .Append("   [SingleStationExamArrangement] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [SingleStationExamArrangement].[Room_ID] = [Room].[Room_ID] ")
                .Append("   LEFT JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreSummariedScore].[E_ID] = [SingleStationExamArrangement].[E_ID] ")
                .Append("           AND [ScoreSummariedScore].[ES_ID] = [SingleStationExamArrangement].[ES_ID] ")
                .Append("           AND [ScoreSummariedScore].[Student_ID] = [SingleStationExamArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [SingleStationExamArrangement].[E_ID] = :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");

            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [SingleStationExamArrangement].[U_ID]  IN  (:U_IDList) ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.SingleStationExamArrangement));
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Score", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In"))
                {
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }

                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询学生总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public  List<object[]> SelectTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [ScoreSummariedScore].[Student_ID],  ")
                .Append("   SUM([ScoreSummariedScore].[score]) AS [score] ")
                .Append("FROM ")
                .Append("   [ScoreSummariedScore] ")
                .Append("WHERE ")
                .Append("   [ScoreSummariedScore].[E_ID] = :E_ID ")
                .Append("   AND [ScoreSummariedScore].[Student_ID] IN (:Student_IDList) ")
                .Append("GROUP BY ")
                .Append("   [ScoreSummariedScore].[Student_ID] ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
               // iSQLQuery.AddEntity(typeof(Model.ScoreSummariedScore));
                iSQLQuery.AddScalar("Student_ID",NHibernateUtil.Int32);
                iSQLQuery.AddScalar("score", NHibernateUtil.Decimal);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetParameterList("Student_IDList", (List<int>)conditionDictionary["Student_ID,In"]);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩总分失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }
    
        /// <summary>
        /// 成绩录入与修改页面 查询选中考生的成绩信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectPerStudentScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ExamStation].[ES_ID] ,")
                .Append("   [ExamStation].[ES_Name], ")
                .Append("   [Room].[Room_ID], ")
                .Append("   [Room].[Room_Name], ")
                .Append("   [ScoreSummariedScore].[id], ")
                .Append("   [ScoreSummariedScore].[ScoreType], ")
                .Append("   [ScoreSummariedScore].[LastScoreModifyDate], ")
                .Append("   [ScoreSummariedScore].[ScoreModifyUserInfoID], ")
                .Append("   [UserInfo].[U_TrueName] AS ScoreModifyUserInfoName, ")
                .Append("   [ScoreSummariedScore].[score] ")
                .Append("FROM ")
                .Append("   [ExamStation] ");

            if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 1)
            {
                //长短站
                sqlStringBuilder
                    .Append("INNER JOIN [OSCEExaminationArrangement] AS [ExamArrangement] ");
            }
            else if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 2)
            {
                //多站
                sqlStringBuilder
                    .Append("INNER JOIN [MultiStationExamArrangement] AS [ExamArrangement] ");
            }
            else if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 3)
            {
                //单站
                sqlStringBuilder
                    .Append("INNER JOIN [SingleStationExamArrangement] AS [ExamArrangement] ");
            }
            sqlStringBuilder
                .Append("       ON [ExamArrangement].[E_ID] =[ExamStation].[int1] ")
                .Append("           AND [ExamArrangement].[U_ID] = :U_ID ")
                .Append("           AND [ExamArrangement].[ES_ID] = [ExamStation].[ES_ID] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [Room].[Room_ID] =[ExamArrangement].[Room_ID] ")
                .Append("   LEFT JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreSummariedScore].[ES_ID]=[ExamStation].[ES_ID] ")
                .Append("       AND [ScoreSummariedScore].[Student_ID] = [ExamArrangement].[U_ID] ")
                .Append("   LEFT JOIN [UserInfo] ")
                .Append("       ON [ScoreSummariedScore].[ScoreModifyUserInfoID]=[UserInfo].[U_ID] ") 
                .Append("WHERE ")
                .Append("      [ExamStation].[int1]=:E_ID ")
                .Append("ORDER BY ")
                .Append("      [ExamStation].[int3] ASC ");
            
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("ES_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Room_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("id", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ScoreType", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("LastScoreModifyDate", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("ScoreModifyUserInfoID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ScoreModifyUserInfoName", NHibernateUtil.String);
                iSQLQuery.AddScalar("score", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID,Eq"].ToString()));

                if (conditionDictionary.ContainsKey("id,IN"))
                {
                    iSQLQuery.SetParameterList("idList", (List<int>)conditionDictionary["id,IN"]);
                }
               
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 查询各考站的分数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectEachStationTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [ScoreSummariedScore].[ES_ID], ")
                .Append("   SUM([ScoreSummariedScore].[score]) AS [EachStationTotalScore] ")
                .Append("FROM ")
                .Append("   [ScoreSummariedScore] ")
                .Append("WHERE ")
                .Append("   [ScoreSummariedScore].[E_ID] = :E_ID ")
                .Append("GROUP BY ")
                .Append("   [ScoreSummariedScore].[E_ID], ")
                .Append("   [ScoreSummariedScore].[ES_ID] ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("EachStationTotalScore", NHibernateUtil.Decimal);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,EQ"].ToString()));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询各考站的平均分失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 查询各班级的分数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectEachOrganizationTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [Organization].[O_ID],  ")
                .Append("   [ScoreSummariedScore].[ES_ID],  ")
                .Append("   SUM([ScoreSummariedScore].[score]) AS [TotalScore] ")
                .Append("FROM ")
                .Append("   [ScoreSummariedScore] ")
                .Append("   LEFT JOIN [UserOrganization]")
                .Append("       ON [ScoreSummariedScore].[Student_ID] = [UserOrganization].[U_ID]")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [UserOrganization].[O_ID] = [Organization].[O_ID] ");
            if (conditionDictionary.ContainsKey("O_ID,In"))
            {
                sqlStringBuilder
                    .Append("       AND [Organization].[O_ID] IN (:OrganizationIDList) ");
            }
            sqlStringBuilder
                .Append("WHERE ")
                .Append("   [ScoreSummariedScore].[E_ID] = :E_ID ")
                .Append("GROUP BY ")
                .Append("   [Organization].[O_ID], ")
                .Append("   [ScoreSummariedScore].[ES_ID] ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("O_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("TotalScore", NHibernateUtil.Decimal);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("O_ID,In"))
                {
                    iSQLQuery.SetParameterList("OrganizationIDList", (List<int>)conditionDictionary["O_ID,In"]);
                }
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询各班级的分数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩录入与修改页面 查询房间信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectRoomIDByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ExamArrangement].[U_ID] ,")
                .Append("   [ExamArrangement].[ES_ID], ")
                .Append("   [ExamArrangement].[Room_ID] ")
                .Append("FROM  ");
            if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 1)
            {
                //长短站
                sqlStringBuilder
                    .Append("[OSCEExaminationArrangement] AS [ExamArrangement] ");
            }
            else if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 2)
            {
                //多站
                sqlStringBuilder
                    .Append("[MultiStationExamArrangement] AS [ExamArrangement] ");
            }
            else if (Convert.ToInt32(conditionDictionary["E_Kind,IS"]) == 3)
            {
                //单站
                sqlStringBuilder
                    .Append("[SingleStationExamArrangement] AS [ExamArrangement] ");
            }
            sqlStringBuilder
                .Append("WHERE ")
                .Append("      [ExamArrangement].[E_ID]=:E_ID ")
                .Append("  AND [ExamArrangement].[U_ID] IN (:U_IDList) ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("Room_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["Student_ID,In"]);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询房间ID失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 学生查询页面 查询学生在每场考试中的总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectTotalScoreByStudentID(int studentID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [ScoreSummariedScore].[E_ID],  ")
                .Append("   SUM([ScoreSummariedScore].[score]) AS [score] ")
                .Append("FROM ")
                .Append("   [ScoreSummariedScore] ")
                .Append("WHERE ")
                .Append("   [ScoreSummariedScore].[Student_ID] = :Student_ID ")
                .Append("GROUP BY ")
                .Append("   [ScoreSummariedScore].[E_ID] ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("score", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetInt32("Student_ID", studentID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生成绩总分失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion


        #endregion
    }
}

