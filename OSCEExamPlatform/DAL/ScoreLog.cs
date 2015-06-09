using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class ScoreLog : BaseDAL<Model.ScoreLog>
    {
        #region Base Method

        public bool Exists(int ScoreLogID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ScoreLog");
            strSql.Append(" where ");
            strSql.Append(" ScoreLogID = @ScoreLogID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ScoreLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = ScoreLogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ScoreLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ScoreLog(");
            strSql.Append("Score,ScoreLogNumber1,ScoreLogNumber2,ScoreLogString1,ScoreLogString2,ScoreLogDatetime1,ScoreLogDatetime2,MS_ID,ScorePercent,ExamStationScore,LogUserInfoID,ExamStationPercent,ExamScore,LogDatetime,LogType,ScoreSummariedScoreID,E_ID,ES_ID,Room_ID,StudentUserInfoID");
            strSql.Append(") values (");
            strSql.Append("@Score,@ScoreLogNumber1,@ScoreLogNumber2,@ScoreLogString1,@ScoreLogString2,@ScoreLogDatetime1,@ScoreLogDatetime2,@MS_ID,@ScorePercent,@ExamStationScore,@LogUserInfoID,@ExamStationPercent,@ExamScore,@LogDatetime,@LogType,@ScoreSummariedScoreID,@E_ID,@ES_ID,@Room_ID,@StudentUserInfoID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@Score", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ScoreLogNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScoreLogNumber2", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ScoreLogString1", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@ScoreLogString2", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@ScoreLogDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ScoreLogDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScorePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStationScore", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@LogUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStationPercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamScore", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@LogDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@LogType", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScoreSummariedScoreID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@StudentUserInfoID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Score;
            parameters[1].Value = model.ScoreLogNumber1;
            parameters[2].Value = model.ScoreLogNumber2;
            parameters[3].Value = model.ScoreLogString1;
            parameters[4].Value = model.ScoreLogString2;
            parameters[5].Value = model.ScoreLogDatetime1;
            parameters[6].Value = model.ScoreLogDatetime2;
            parameters[7].Value = model.MS_ID;
            parameters[8].Value = model.ScorePercent;
            parameters[9].Value = model.ExamStationScore;
            parameters[10].Value = model.LogUserInfoID;
            parameters[11].Value = model.ExamStationPercent;
            parameters[12].Value = model.ExamScore;
            parameters[13].Value = model.LogDatetime;
            parameters[14].Value = model.LogType;
            parameters[15].Value = model.ScoreSummariedScoreID;
            parameters[16].Value = Guid.NewGuid();
            parameters[17].Value = Guid.NewGuid();
            parameters[18].Value = model.Room_ID;
            parameters[19].Value = model.StudentUserInfoID;  

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
        public bool Update(Model.ScoreLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ScoreLog set ");

            strSql.Append(" Score = @Score , ");
            strSql.Append(" ScoreLogNumber1 = @ScoreLogNumber1 , ");
            strSql.Append(" ScoreLogNumber2 = @ScoreLogNumber2 , ");
            strSql.Append(" ScoreLogString1 = @ScoreLogString1 , ");
            strSql.Append(" ScoreLogString2 = @ScoreLogString2 , ");
            strSql.Append(" ScoreLogDatetime1 = @ScoreLogDatetime1 , ");
            strSql.Append(" ScoreLogDatetime2 = @ScoreLogDatetime2 , ");
            strSql.Append(" MS_ID = @MS_ID , ");
            strSql.Append(" ScorePercent = @ScorePercent , ");
            strSql.Append(" ExamStationScore = @ExamStationScore , ");
            strSql.Append(" LogUserInfoID = @LogUserInfoID , ");
            strSql.Append(" ExamStationPercent = @ExamStationPercent , ");
            strSql.Append(" ExamScore = @ExamScore , ");
            strSql.Append(" LogDatetime = @LogDatetime , ");
            strSql.Append(" LogType = @LogType , ");
            strSql.Append(" ScoreSummariedScoreID = @ScoreSummariedScoreID , ");
            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" ES_ID = @ES_ID , ");
            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" StudentUserInfoID = @StudentUserInfoID  ");
            strSql.Append(" where ScoreLogID=@ScoreLogID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ScoreLogID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Score", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ScoreLogNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScoreLogNumber2", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ScoreLogString1", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@ScoreLogString2", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@ScoreLogDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ScoreLogDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScorePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStationScore", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@LogUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamStationPercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamScore", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@LogDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@LogType", SqlDbType.Int,4) ,            
                        new SqlParameter("@ScoreSummariedScoreID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@StudentUserInfoID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ScoreLogID;
            parameters[1].Value = model.Score;
            parameters[2].Value = model.ScoreLogNumber1;
            parameters[3].Value = model.ScoreLogNumber2;
            parameters[4].Value = model.ScoreLogString1;
            parameters[5].Value = model.ScoreLogString2;
            parameters[6].Value = model.ScoreLogDatetime1;
            parameters[7].Value = model.ScoreLogDatetime2;
            parameters[8].Value = model.MS_ID;
            parameters[9].Value = model.ScorePercent;
            parameters[10].Value = model.ExamStationScore;
            parameters[11].Value = model.LogUserInfoID;
            parameters[12].Value = model.ExamStationPercent;
            parameters[13].Value = model.ExamScore;
            parameters[14].Value = model.LogDatetime;
            parameters[15].Value = model.LogType;
            parameters[16].Value = model.ScoreSummariedScoreID;
            parameters[17].Value = model.E_ID;
            parameters[18].Value = model.ES_ID;
            parameters[19].Value = model.Room_ID;
            parameters[20].Value = model.StudentUserInfoID;
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
        public bool Delete(int ScoreLogID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreLog ");
            strSql.Append(" where ScoreLogID=@ScoreLogID");
            SqlParameter[] parameters = {
					new SqlParameter("@ScoreLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = ScoreLogID;


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
        public bool DeleteList(string ScoreLogIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ScoreLog ");
            strSql.Append(" where ID in (" + ScoreLogIDlist + ")  ");
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
        public Model.ScoreLog GetModel(int ScoreLogID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ScoreLogID, Score, ScoreLogNumber1, ScoreLogNumber2, ScoreLogString1, ScoreLogString2, ScoreLogDatetime1, ScoreLogDatetime2, MS_ID, ScorePercent, ExamStationScore, LogUserInfoID, ExamStationPercent, ExamScore, LogDatetime, LogType, ScoreSummariedScoreID, E_ID, ES_ID, Room_ID, StudentUserInfoID  ");
            strSql.Append("  from ScoreLog ");
            strSql.Append(" where ScoreLogID=@ScoreLogID");
            SqlParameter[] parameters = {
					new SqlParameter("@ScoreLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = ScoreLogID;


            Model.ScoreLog model = new Model.ScoreLog();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ScoreLogID"].ToString() != "")
                {
                    model.ScoreLogID = int.Parse(ds.Tables[0].Rows[0]["ScoreLogID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Score"].ToString() != "")
                {
                    model.Score = decimal.Parse(ds.Tables[0].Rows[0]["Score"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ScoreLogNumber1"].ToString() != "")
                {
                    model.ScoreLogNumber1 = int.Parse(ds.Tables[0].Rows[0]["ScoreLogNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ScoreLogNumber2"].ToString() != "")
                {
                    model.ScoreLogNumber2 = decimal.Parse(ds.Tables[0].Rows[0]["ScoreLogNumber2"].ToString());
                }
                model.ScoreLogString1 = ds.Tables[0].Rows[0]["ScoreLogString1"].ToString();
                model.ScoreLogString2 = ds.Tables[0].Rows[0]["ScoreLogString2"].ToString();
                if (ds.Tables[0].Rows[0]["ScoreLogDatetime1"].ToString() != "")
                {
                    model.ScoreLogDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["ScoreLogDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ScoreLogDatetime2"].ToString() != "")
                {
                    model.ScoreLogDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["ScoreLogDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MS_ID"].ToString() != "")
                {
                    model.MS_ID = int.Parse(ds.Tables[0].Rows[0]["MS_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ScorePercent"].ToString() != "")
                {
                    model.ScorePercent = int.Parse(ds.Tables[0].Rows[0]["ScorePercent"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamStationScore"].ToString() != "")
                {
                    model.ExamStationScore = decimal.Parse(ds.Tables[0].Rows[0]["ExamStationScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LogUserInfoID"].ToString() != "")
                {
                    model.LogUserInfoID = int.Parse(ds.Tables[0].Rows[0]["LogUserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamStationPercent"].ToString() != "")
                {
                    model.ExamStationPercent = int.Parse(ds.Tables[0].Rows[0]["ExamStationPercent"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamScore"].ToString() != "")
                {
                    model.ExamScore = decimal.Parse(ds.Tables[0].Rows[0]["ExamScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LogDatetime"].ToString() != "")
                {
                    model.LogDatetime = DateTime.Parse(ds.Tables[0].Rows[0]["LogDatetime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LogType"].ToString() != "")
                {
                    model.LogType = int.Parse(ds.Tables[0].Rows[0]["LogType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ScoreSummariedScoreID"].ToString() != "")
                {
                    model.ScoreSummariedScoreID = int.Parse(ds.Tables[0].Rows[0]["ScoreSummariedScoreID"].ToString());
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
                if (ds.Tables[0].Rows[0]["StudentUserInfoID"].ToString() != "")
                {
                    model.StudentUserInfoID = int.Parse(ds.Tables[0].Rows[0]["StudentUserInfoID"].ToString());
                }

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
            strSql.Append(" FROM ScoreLog ");
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
            strSql.Append(" FROM ScoreLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion

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

        #region Extension Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectScoreLogInfo(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ScoreLog].* ,")
                .Append("   [ExamStation].[ES_Name] ,")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [MarkSheet].[MS_Name], ")
                .Append("   [Room].[Room_Name] ")
                .Append("FROM ")
                .Append("   [ScoreLog] ")
                .Append("   INNER JOIN [ExamStation] ")
                .Append("       ON [ScoreLog].[ES_ID] = [ExamStation].[ES_ID] ")
                .Append("   INNER JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreLog].[ScoreSummariedScoreID] = [ScoreSummariedScore].[id] ")
                .Append("   LEFT JOIN [UserInfo] ")
                .Append("       ON [ScoreLog].[LogUserInfoID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN [MarkSheet] ")
                .Append("       ON [ScoreLog].[MS_ID] = [MarkSheet].[MS_ID] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [ScoreLog].[Room_ID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("       [ScoreSummariedScore].[id] in (:idList) ")
                .Append("ORDER BY  ")
                .Append("       [ScoreLog].[LogDatetime] DESC ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.ScoreLog));
                iSQLQuery.AddScalar("ES_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("MS_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                
                //设置查询参数
                if (conditionDictionary.ContainsKey("id,IN"))
                {
                    iSQLQuery.SetParameterList("idList", (List<int>)conditionDictionary["id,IN"]);
                }
               
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询成绩日志信息失败", e);
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
