using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class ScoreInfo: BaseDAL<Model.ScoreInfo>
    {
        #region Basic
        public bool Exists(int SI_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ScoreInfo");
            strSql.Append(" where ");
            strSql.Append(" SI_ID = @SI_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@SI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SI_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ScoreInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ScoreInfo(");
            strSql.Append("SI_ProvisionScore,SI_DigitalSignature,SI_CreateTime,SI_int1,SI_int2,SI_string1,SI_string2,SI_datetime,calcuated,timeStamp,Exam_ID,ExamStation_ID,Student_ID,SI_Type,Rater_ID,SI_Score,SI_ActualScore,SI_Items");
            strSql.Append(") values (");
            strSql.Append("@SI_ProvisionScore,@SI_DigitalSignature,@SI_CreateTime,@SI_int1,@SI_int2,@SI_string1,@SI_string2,@SI_datetime,@calcuated,@timeStamp,@Exam_ID,@ExamStation_ID,@Student_ID,@SI_Type,@Rater_ID,@SI_Score,@SI_ActualScore,@SI_Items");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@SI_ProvisionScore", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_DigitalSignature", SqlDbType.Image) ,            
                        new SqlParameter("@SI_CreateTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@SI_int1", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_int2", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_string1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SI_string2", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_datetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@calcuated", SqlDbType.Int,4) ,            
                        new SqlParameter("@timeStamp", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Exam_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStation_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Student_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_Type", SqlDbType.Int,4) ,            
                        new SqlParameter("@Rater_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_Score", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_ActualScore", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_Items", SqlDbType.NVarChar,-1)             
              
            };

            parameters[0].Value = model.SI_ProvisionScore;
            parameters[1].Value = model.SI_DigitalSignature;
            parameters[2].Value = model.SI_CreateTime;
            parameters[3].Value = model.SI_int1;
            parameters[4].Value = model.SI_int2;
            parameters[5].Value = model.SI_string1;
            parameters[6].Value = model.SI_string2;
            parameters[7].Value = model.SI_datetime;
            parameters[8].Value = model.calcuated;
            parameters[9].Value = model.timeStamp;
            parameters[10].Value = model.Exam_ID;
            parameters[11].Value = model.ExamStation_ID;
            parameters[12].Value = model.Student_ID;
            parameters[13].Value = model.SI_Type;
            parameters[14].Value = model.Rater_ID;
            parameters[15].Value = model.SI_Score;
            parameters[16].Value = model.SI_ActualScore;
            parameters[17].Value = model.SI_Items;

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
        public bool Update(Model.ScoreInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ScoreInfo set ");

            strSql.Append(" SI_ProvisionScore = @SI_ProvisionScore , ");
            strSql.Append(" SI_DigitalSignature = @SI_DigitalSignature , ");
            strSql.Append(" SI_CreateTime = @SI_CreateTime , ");
            strSql.Append(" SI_int1 = @SI_int1 , ");
            strSql.Append(" SI_int2 = @SI_int2 , ");
            strSql.Append(" SI_string1 = @SI_string1 , ");
            strSql.Append(" SI_string2 = @SI_string2 , ");
            strSql.Append(" SI_datetime = @SI_datetime , ");
            strSql.Append(" calcuated = @calcuated , ");
            strSql.Append(" timeStamp = @timeStamp , ");
            strSql.Append(" Exam_ID = @Exam_ID , ");
            strSql.Append(" ExamStation_ID = @ExamStation_ID , ");
            strSql.Append(" Student_ID = @Student_ID , ");
            strSql.Append(" SI_Type = @SI_Type , ");
            strSql.Append(" Rater_ID = @Rater_ID , ");
            strSql.Append(" SI_Score = @SI_Score , ");
            strSql.Append(" SI_ActualScore = @SI_ActualScore , ");
            strSql.Append(" SI_Items = @SI_Items  ");
            strSql.Append(" where SI_ID=@SI_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@SI_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_ProvisionScore", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_DigitalSignature", SqlDbType.Image) ,            
                        new SqlParameter("@SI_CreateTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@SI_int1", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_int2", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_string1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SI_string2", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_datetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@calcuated", SqlDbType.Int,4) ,            
                        new SqlParameter("@timeStamp", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Exam_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStation_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Student_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_Type", SqlDbType.Int,4) ,            
                        new SqlParameter("@Rater_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_Score", SqlDbType.Int,4) ,            
                        new SqlParameter("@SI_ActualScore", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SI_Items", SqlDbType.NVarChar,-1)             
              
            };

            parameters[0].Value = model.SI_ID;
            parameters[1].Value = model.SI_ProvisionScore;
            parameters[2].Value = model.SI_DigitalSignature;
            parameters[3].Value = model.SI_CreateTime;
            parameters[4].Value = model.SI_int1;
            parameters[5].Value = model.SI_int2;
            parameters[6].Value = model.SI_string1;
            parameters[7].Value = model.SI_string2;
            parameters[8].Value = model.SI_datetime;
            parameters[9].Value = model.calcuated;
            parameters[10].Value = model.timeStamp;
            parameters[11].Value = model.Exam_ID;
            parameters[12].Value = model.ExamStation_ID;
            parameters[13].Value = model.Student_ID;
            parameters[14].Value = model.SI_Type;
            parameters[15].Value = model.Rater_ID;
            parameters[16].Value = model.SI_Score;
            parameters[17].Value = model.SI_ActualScore;
            parameters[18].Value = model.SI_Items;
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
        public bool Delete(int SI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreInfo ");
            strSql.Append(" where SI_ID=@SI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SI_ID;


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
        public bool DeleteList(string SI_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreInfo ");
            strSql.Append(" where ID in (" + SI_IDlist + ")  ");
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
        public Model.ScoreInfo GetModel(int SI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SI_ID, SI_ProvisionScore, SI_DigitalSignature, SI_CreateTime, SI_int1, SI_int2, SI_string1, SI_string2, SI_datetime, calcuated, timeStamp, Exam_ID, ExamStation_ID, Student_ID, SI_Type, Rater_ID, SI_Score, SI_ActualScore, SI_Items  ");
            strSql.Append("  from ScoreInfo ");
            strSql.Append(" where SI_ID=@SI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SI_ID;


            Model.ScoreInfo model = new Model.ScoreInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["SI_ID"].ToString() != "")
                {
                    model.SI_ID = int.Parse(ds.Tables[0].Rows[0]["SI_ID"].ToString());
                }
                model.SI_ProvisionScore = ds.Tables[0].Rows[0]["SI_ProvisionScore"].ToString();
                if (ds.Tables[0].Rows[0]["SI_DigitalSignature"].ToString() != "")
                {
                    model.SI_DigitalSignature = (byte[])ds.Tables[0].Rows[0]["SI_DigitalSignature"];
                }
                if (ds.Tables[0].Rows[0]["SI_CreateTime"].ToString() != "")
                {
                    model.SI_CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["SI_CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SI_int1"].ToString() != "")
                {
                    model.SI_int1 = int.Parse(ds.Tables[0].Rows[0]["SI_int1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SI_int2"].ToString() != "")
                {
                    model.SI_int2 = int.Parse(ds.Tables[0].Rows[0]["SI_int2"].ToString());
                }
                model.SI_string1 = ds.Tables[0].Rows[0]["SI_string1"].ToString();
                model.SI_string2 = ds.Tables[0].Rows[0]["SI_string2"].ToString();
                if (ds.Tables[0].Rows[0]["SI_datetime"].ToString() != "")
                {
                    model.SI_datetime = DateTime.Parse(ds.Tables[0].Rows[0]["SI_datetime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["calcuated"].ToString() != "")
                {
                    model.calcuated = int.Parse(ds.Tables[0].Rows[0]["calcuated"].ToString());
                }
                model.timeStamp = ds.Tables[0].Rows[0]["timeStamp"].ToString();
                if (ds.Tables[0].Rows[0]["Exam_ID"].ToString() != "")
                {
                    model.Exam_ID = Guid.Parse(ds.Tables[0].Rows[0]["Exam_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamStation_ID"].ToString() != "")
                {
                    model.ExamStation_ID = Guid.Parse(ds.Tables[0].Rows[0]["ExamStation_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Student_ID"].ToString() != "")
                {
                    model.Student_ID = int.Parse(ds.Tables[0].Rows[0]["Student_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SI_Type"].ToString() != "")
                {
                    model.SI_Type = int.Parse(ds.Tables[0].Rows[0]["SI_Type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rater_ID"].ToString() != "")
                {
                    model.Rater_ID = int.Parse(ds.Tables[0].Rows[0]["Rater_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SI_Score"].ToString() != "")
                {
                    model.SI_Score = int.Parse(ds.Tables[0].Rows[0]["SI_Score"].ToString());
                }
                model.SI_ActualScore = ds.Tables[0].Rows[0]["SI_ActualScore"].ToString();
                model.SI_Items = ds.Tables[0].Rows[0]["SI_Items"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ScoreInfo ");
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
            strSql.Append(" FROM ScoreInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
        #region Extension
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("Exam_ID")) 
            {
                criteria.Add(Restrictions.Eq("Exam_ID", conditionDictionary["Exam_ID"]));
            }
            if (conditionDictionary.ContainsKey("Exam_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Exam_ID", conditionDictionary["Exam_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("examTableID,Eq"))
            {
                criteria.Add(Restrictions.Eq("Exam_ID", conditionDictionary["examTableID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("ExamStation_ID"))
            {
                criteria.Add(Restrictions.Eq("ExamStation_ID", conditionDictionary["ExamStation_ID"]));
            }
            if (conditionDictionary.ContainsKey("ExamStation_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("ExamStation_ID", conditionDictionary["ExamStation_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("examStationID,Eq"))
            {
                criteria.Add(Restrictions.Eq("ExamStation_ID", conditionDictionary["examStationID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID"))
            {
                criteria.Add(Restrictions.Eq("Room_ID", conditionDictionary["Room_ID"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Room_ID", conditionDictionary["Room_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("ScoreInfo_Type"))
            {
                criteria.Add(Restrictions.Eq("SI_Type", conditionDictionary["ScoreInfo_Type"]));
            }
            if (conditionDictionary.ContainsKey("ScoreInfo_Type,EQ"))
            {
                criteria.Add(Restrictions.Eq("SI_Type", conditionDictionary["ScoreInfo_Type,EQ"]));
            }
            if (conditionDictionary.ContainsKey("Rater_ID"))
            {
                criteria.Add(Restrictions.Eq("Rater_ID", conditionDictionary["Rater_ID"]));
            }
            if (conditionDictionary.ContainsKey("Rater_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Rater_ID", conditionDictionary["Rater_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("Student_ID"))
            {
                criteria.Add(Restrictions.Eq("Student_ID", conditionDictionary["Student_ID"]));
            }
            if (conditionDictionary.ContainsKey("Student_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("Student_ID", conditionDictionary["Student_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("studentUserInfoID,Eq"))
            {
                criteria.Add(Restrictions.Eq("Student_ID", conditionDictionary["studentUserInfoID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("Student_ID,IN"))
            {
                criteria.Add(Restrictions.In("Student_ID", (List<int>)conditionDictionary["Student_ID,IN"]));
            }
            if (conditionDictionary.ContainsKey("SI_int2,EQ"))
            {
                criteria.Add(Restrictions.Eq("SI_int2", conditionDictionary["SI_int2,EQ"]));
            }
            if (conditionDictionary.ContainsKey("SI_int2,Eq"))
            {
                criteria.Add(Restrictions.Eq("SI_int2", conditionDictionary["SI_int2,Eq"]));
            }
            return criteria;
        }



        /// <summary>
        /// 成绩录入与修改页面 查询成绩完整性
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectStudentInfoWithCompletedScoreInScoreEnterAndModifyPage(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("       [ScoreInfoCount].[Student_ID], ")
                    .Append("       [ExamUserCount].[ES_ID] ")
                    .Append("FROM ")
                    .Append("   ( ")
                    .Append("       SELECT ")
                    .Append("           [ExamUser].[string1] AS [ES_ID], ")
                    .Append("           [ExamUser].[int3] AS [Room_ID], ")
                    .Append("           COUNT(DISTINCT [ExamUser].[U_ID]) AS [ExamUserCount] ")
                    .Append("       FROM ")
                    .Append("           [ExamUser] ")
                    .Append("           INNER JOIN [ExamUserMarkSheet] ")
                    .Append("               ON [ExamUser].[EU_ID] = [ExamUserMarkSheet].[EU_ID] ")
                    .Append("       WHERE ")
                    .Append("           [ExamUser].[E_ID] = :E_ID ")
                    .Append("       GROUP BY ")
                    .Append("           [ExamUser].[string1], ")
                    .Append("           [ExamUser].[int3] ")
                    .Append("   ) AS [ExamUserCount] ")
                    .Append("   INNER JOIN ( ")
                    .Append("       SELECT ")
                    .Append("           [Student_ID], ")
                    .Append("           [ExamStation_ID], ")
                    .Append("           [Room_ID], ")
                    .Append("           COUNT(DISTINCT [Rater_ID])  AS [ScoreInfoCount] ")
                    .Append("       FROM ")
                    .Append("           [ScoreInfo]  ")
                    .Append("       WHERE ")
                    .Append("           [ScoreInfo].[Exam_ID] = :E_ID ")
                    .Append("           AND [ScoreInfo].[SI_int2] =2 ")
                    .Append("       GROUP BY  ")
                    .Append("           [Student_ID], ")
                    .Append("           [ExamStation_ID], ")
                    .Append("           [Room_ID] ")
                    .Append("   ) AS [ScoreInfoCount] ")
                    .Append("       ON [ExamUserCount].[ES_ID] = [ScoreInfoCount].[ExamStation_ID] ")
                    .Append("           AND [ExamUserCount].[Room_ID] = [ScoreInfoCount].[Room_ID] ")
                    .Append("           AND [ExamUserCount].[ExamUserCount] = [ScoreInfoCount].[ScoreInfoCount] ")
                    .Append("WHERE  ")
                    .Append("   [ScoreInfoCount].[Student_ID] IN  (:Student_IDList) ");
              
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("Student_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetParameterList("Student_IDList", (List<int>)conditionDictionary["Student_ID,In"]);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 查询考试时间和房间信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamTimeAndRoomInfo(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ");
            if (conditionDictionary["examTableKind,IS"].Equals(1))
            {
                //长短站
                sqlStringBuilder
                .Append("   [ExamArrangement].[OEA_StartTime]  AS [Exam_StartTime],")
                .Append("   [ExamArrangement].[OEA_EndTime]  AS [Exam_EndTime],");
            }else if (conditionDictionary["examTableKind,IS"].Equals(2))
            {
                //多站
                sqlStringBuilder
                .Append("   [ExamArrangement].[Exam_StartTime] ,")
                .Append("   [ExamArrangement].[Exam_EndTime] ,");
            }else if (conditionDictionary["examTableKind,IS"].Equals(3))
            {
                //单站
                sqlStringBuilder
                .Append("   [ExamArrangement].[SE_StartTime]  AS [Exam_StartTime],")
                .Append("   [ExamArrangement].[SE_EndTime]  AS [Exam_EndTime],");
            }
            sqlStringBuilder
                .Append("   [Room].[Room_Name] ")
                .Append("FROM ");
            if (conditionDictionary["examTableKind,IS"].Equals(1))
            {
                sqlStringBuilder.Append("   [OSCEExaminationArrangement] AS [ExamArrangement] ");
            }else if (conditionDictionary["examTableKind,IS"].Equals(2))
            {
                sqlStringBuilder.Append("   [MultiStationExamArrangement] AS [ExamArrangement] ");
            }else if (conditionDictionary["examTableKind,IS"].Equals(3))
            {
                sqlStringBuilder.Append("   [SingleStationExamArrangement] AS [ExamArrangement] ");
            }
               sqlStringBuilder 
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [ExamArrangement].[Room_ID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("       [ExamArrangement].[E_ID] = :E_ID ")
                .Append("       AND [ExamArrangement].[ES_ID] = :ES_ID ")
                .Append("       AND [ExamArrangement].[U_ID] = :U_ID ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("Exam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("Exam_EndTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["examTableID,Eq"].ToString()));
                iSQLQuery.SetGuid("ES_ID", Guid.Parse(conditionDictionary["examStationID,Eq"].ToString()));
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["studentUserInfoID,Eq"]));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考试时间和房间信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询评分表名称，评委
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectScoreInfoAndMarkSheetInfo(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ScoreInfo].* ,")
                .Append("   [MarkSheet].[MS_Name] ,")
                .Append("   [UserInfo].[U_TrueName] ")
                .Append("FROM ")
                .Append("   [ScoreInfo]")
                .Append("   INNER JOIN [MarkSheet] ")
                .Append("       ON [ScoreInfo].[SI_int1] = [MarkSheet].[MS_ID] ")
                .Append("   LEFT JOIN [UserInfo] ")
                .Append("       ON [ScoreInfo].[Rater_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ScoreInfo].[Exam_ID] = :E_ID ")
                .Append("   AND [ScoreInfo].[ExamStation_ID] = :ES_ID ")
                .Append("   AND [ScoreInfo].[Student_ID] = :U_ID ")
                .Append("   AND [ScoreInfo].[SI_int2] = :SI_int2 ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.ScoreInfo));
                iSQLQuery.AddScalar("MS_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["examTableID,Eq"].ToString()));
                iSQLQuery.SetGuid("ES_ID", Guid.Parse(conditionDictionary["examStationID,Eq"].ToString()));
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["studentUserInfoID,Eq"]));
                iSQLQuery.SetInt32("SI_int2", Convert.ToInt32(conditionDictionary["SI_int2,Eq"]));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询评分表名称，评委", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion
    }
}
