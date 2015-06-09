using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using NHibernate.Criterion;//Please add references
namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:MarkSheet
    /// </summary>
    public partial class MarkSheet : BaseDAL<Model.MarkSheet>
    {
        #region Base Method

        public bool Exists(int MS_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MarkSheet");
            strSql.Append(" where ");
            strSql.Append(" MS_ID = @MS_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MS_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MarkSheet(");
            strSql.Append("string1,string2,string3,string4,MarkSheetNumber1,MarkSheetNumber2,MarkSheetNumber3,MarkSheetNumber4,User_ID,MSK_ID,MS_Name,MS_Share,MS_CreateDate,MS_ModifyDate,MS_ModifyPerson,MS_Score");
            strSql.Append(") values (");
            strSql.Append("@string1,@string2,@string3,@string4,@MarkSheetNumber1,@MarkSheetNumber2,@MarkSheetNumber3,@MarkSheetNumber4,@User_ID,@MSK_ID,@MS_Name,@MS_Share,@MS_CreateDate,@MS_ModifyDate,@MS_ModifyPerson,@MS_Score");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@string1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string3", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string4", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@MarkSheetNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetNumber3", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@MarkSheetNumber4", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@User_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MSK_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_Name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@MS_Share", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_CreateDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_Score", SqlDbType.Decimal,9)             
              
            };

            parameters[0].Value = model.string1;
            parameters[1].Value = model.string2;
            parameters[2].Value = model.string3;
            parameters[3].Value = model.string4;
            parameters[4].Value = model.MarkSheetNumber1;
            parameters[5].Value = model.MarkSheetNumber2;
            parameters[6].Value = model.MarkSheetNumber3;
            parameters[7].Value = model.MarkSheetNumber4;
            parameters[8].Value = model.User_ID;
            parameters[9].Value = model.MSK_ID;
            parameters[10].Value = model.MS_Name;
            parameters[11].Value = model.MS_Share;
            parameters[12].Value = model.MS_CreateDate;
            parameters[13].Value = model.MS_ModifyDate;
            parameters[14].Value = model.MS_ModifyPerson;
            parameters[15].Value = model.MS_Score;

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
        public bool Update(Model.MarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MarkSheet set ");

            strSql.Append(" string1 = @string1 , ");
            strSql.Append(" string2 = @string2 , ");
            strSql.Append(" string3 = @string3 , ");
            strSql.Append(" string4 = @string4 , ");
            strSql.Append(" MarkSheetNumber1 = @MarkSheetNumber1 , ");
            strSql.Append(" MarkSheetNumber2 = @MarkSheetNumber2 , ");
            strSql.Append(" MarkSheetNumber3 = @MarkSheetNumber3 , ");
            strSql.Append(" MarkSheetNumber4 = @MarkSheetNumber4 , ");
            strSql.Append(" User_ID = @User_ID , ");
            strSql.Append(" MSK_ID = @MSK_ID , ");
            strSql.Append(" MS_Name = @MS_Name , ");
            strSql.Append(" MS_Share = @MS_Share , ");
            strSql.Append(" MS_CreateDate = @MS_CreateDate , ");
            strSql.Append(" MS_ModifyDate = @MS_ModifyDate , ");
            strSql.Append(" MS_ModifyPerson = @MS_ModifyPerson , ");
            strSql.Append(" MS_Score = @MS_Score  ");
            strSql.Append(" where MS_ID=@MS_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@MS_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@string1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string3", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@string4", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@MarkSheetNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetNumber3", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@MarkSheetNumber4", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@User_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MSK_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_Name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@MS_Share", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_CreateDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4) ,            
                        new SqlParameter("@MS_Score", SqlDbType.Decimal,9)             
              
            };

            parameters[0].Value = model.MS_ID;
            parameters[1].Value = model.string1;
            parameters[2].Value = model.string2;
            parameters[3].Value = model.string3;
            parameters[4].Value = model.string4;
            parameters[5].Value = model.MarkSheetNumber1;
            parameters[6].Value = model.MarkSheetNumber2;
            parameters[7].Value = model.MarkSheetNumber3;
            parameters[8].Value = model.MarkSheetNumber4;
            parameters[9].Value = model.User_ID;
            parameters[10].Value = model.MSK_ID;
            parameters[11].Value = model.MS_Name;
            parameters[12].Value = model.MS_Share;
            parameters[13].Value = model.MS_CreateDate;
            parameters[14].Value = model.MS_ModifyDate;
            parameters[15].Value = model.MS_ModifyPerson;
            parameters[16].Value = model.MS_Score;
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
        public bool Delete(int MS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheet ");
            strSql.Append(" where MS_ID=@MS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MS_ID;


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
        public bool DeleteList(string MS_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheet ");
            strSql.Append(" where MS_ID in (" + MS_IDlist + ")  ");
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
        public Model.MarkSheet GetModel(int MS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MS_ID, string1, string2, string3, string4, MarkSheetNumber1, MarkSheetNumber2, MarkSheetNumber3, MarkSheetNumber4, User_ID, MSK_ID, MS_Name, MS_Share, MS_CreateDate, MS_ModifyDate, MS_ModifyPerson, MS_Score  ");
            strSql.Append("  from MarkSheet ");
            strSql.Append(" where MS_ID=@MS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MS_ID;


            Model.MarkSheet model = new Model.MarkSheet();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MS_ID"].ToString() != "")
                {
                    model.MS_ID = int.Parse(ds.Tables[0].Rows[0]["MS_ID"].ToString());
                }
                model.string1 = ds.Tables[0].Rows[0]["string1"].ToString();
                model.string2 = ds.Tables[0].Rows[0]["string2"].ToString();
                model.string3 = ds.Tables[0].Rows[0]["string3"].ToString();
                model.string4 = ds.Tables[0].Rows[0]["string4"].ToString();
                if (ds.Tables[0].Rows[0]["MarkSheetNumber1"].ToString() != "")
                {
                    model.MarkSheetNumber1 = int.Parse(ds.Tables[0].Rows[0]["MarkSheetNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetNumber2"].ToString() != "")
                {
                    model.MarkSheetNumber2 = int.Parse(ds.Tables[0].Rows[0]["MarkSheetNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetNumber3"].ToString() != "")
                {
                    model.MarkSheetNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["MarkSheetNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetNumber4"].ToString() != "")
                {
                    model.MarkSheetNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["MarkSheetNumber4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_ID"].ToString() != "")
                {
                    model.User_ID = int.Parse(ds.Tables[0].Rows[0]["User_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MSK_ID"].ToString() != "")
                {
                    model.MSK_ID = int.Parse(ds.Tables[0].Rows[0]["MSK_ID"].ToString());
                }
                model.MS_Name = ds.Tables[0].Rows[0]["MS_Name"].ToString();
                if (ds.Tables[0].Rows[0]["MS_Share"].ToString() != "")
                {
                    model.MS_Share = int.Parse(ds.Tables[0].Rows[0]["MS_Share"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MS_CreateDate"].ToString() != "")
                {
                    model.MS_CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["MS_CreateDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MS_ModifyDate"].ToString() != "")
                {
                    model.MS_ModifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["MS_ModifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MS_ModifyPerson"].ToString() != "")
                {
                    model.MS_ModifyPerson = int.Parse(ds.Tables[0].Rows[0]["MS_ModifyPerson"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MS_Score"].ToString() != "")
                {
                    model.MS_Score = decimal.Parse(ds.Tables[0].Rows[0]["MS_Score"].ToString());
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
            strSql.Append(" FROM MarkSheet ");
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
            strSql.Append(" FROM MarkSheet ");
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
            if (conditionDictionary.ContainsKey("MS_Name"))
            {
                criteria.Add(Restrictions.Like("MS_Name", "%" + conditionDictionary["MS_Name"] + "%"));
            }
            if (conditionDictionary.ContainsKey("MSK_ID_IN"))
            {
                criteria.Add(Restrictions.In("MSK_ID", (List<int>)conditionDictionary["MSK_ID_IN"]));
            }
            if (conditionDictionary.ContainsKey("MS_ID_IN"))
            {
                criteria.Add(Restrictions.In("MS_ID", (List<int>)conditionDictionary["MS_ID_IN"]));
            }
            return criteria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SelectMarkSheetByExamStationIDAndUserInfoID(Guid ES_ID, int U_ID)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [MarkSheet].* ")
                    .Append("FROM ")
                    .Append("   [MarkSheet] ")
                    .Append("   INNER JOIN [ExamUserMarkSheet] ")
                    .Append("       ON [ExamUserMarkSheet].[MS_ID] = [MarkSheet].[MS_ID] ")
                    .Append("WHERE ")
                    .Append("   [ExamUserMarkSheet].[int1] = :U_ID ")
                    .Append("   AND [ExamUserMarkSheet].[int2] = :ES_ID ")
                    .ToString();
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.MarkSheet))
                    .SetInt32("U_ID", U_ID)
                    .SetGuid("ES_ID", ES_ID)
                    .List<Model.MarkSheet>()
                    .ToList<Model.MarkSheet>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询ExamTable信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <returns></returns>
        public List<object[]> SelectMarkSheetScoreByExamTableID(Guid examTableID)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [ExamUserMarkSheet].[int2] AS [ExamStationID], ")
                    .Append("   MAX([MarkSheet].[MS_Score]) AS [MaxMarkSheetScore] ")
                    .Append("FROM ")
                    .Append("   [ExamUserMarkSheet] ")
                    .Append("   INNER JOIN [MarkSheet] ")
                    .Append("       ON [ExamUserMarkSheet].[MS_ID] = [MarkSheet].[MS_ID] ")
                    .Append("WHERE ")
                    .Append("   [ExamUserMarkSheet].[string1] = :examTableID ")
                    .Append("GROUP BY ")
                    .Append("   [ExamUserMarkSheet].[int2] ")
                    .ToString();
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddScalar("ExamStationID", NHibernateUtil.Guid)
                    .AddScalar("MaxMarkSheetScore", NHibernateUtil.Decimal)
                    .SetGuid("examTableID", examTableID)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考站对应的评分表分值失败，examTableID：" + examTableID, e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public int?  SelectMarkSheetCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            StringBuilder sqlStringBuilder = new StringBuilder()
                .Append("SELECT ")
                .Append("    COUNT([MarkSheet].[User_ID]) AS [MarkSheetCount] ")
                .Append("FROM ")
                .Append("   [MarkSheet] ")
                .Append("   LEFT JOIN [MarkSheetKind] ")
                .Append("       ON [MarkSheet].[MSK_ID] = [MarkSheetKind].[MSK_ID] ")
                .Append("   LEFT JOIN [UserInfo] ")
                .Append("       ON [MarkSheet].[User_ID] = [UserInfo].[U_ID] ")
                .Append("   WHERE [MarkSheet].[string1] = 0 ");
            if (conditionDictionary.ContainsKey("MS_Name,Like"))
            {
                sqlStringBuilder.Append("  AND [MarkSheet].[MS_Name] Like :MS_Name ");
            }
            if (conditionDictionary.ContainsKey("MS_Kind,Eq"))
            {
                 sqlStringBuilder.Append(" AND [MarkSheet].[MSK_ID] = :MS_Kind ");
            }

            if (conditionDictionary.ContainsKey("UserID,In") && conditionDictionary.ContainsKey("UserID,Not In"))
            {

                sqlStringBuilder.Append(" AND ([MarkSheet].[User_ID] IN  (:UserIDList) ")
                                .Append(" OR [MarkSheet].[User_ID] NOT  IN  (:UserIDNotInList) ) ");
            }
            else
            {
                if (conditionDictionary.ContainsKey("UserID,In"))
                {
                    sqlStringBuilder.Append(" AND [MarkSheet].[User_ID] IN  (:UserIDList) ");
                }
                else if (conditionDictionary.ContainsKey("UserID,Not In"))
                {
                    sqlStringBuilder.Append(" AND  [MarkSheet].[User_ID] NOT  IN  (:UserIDNotInList) ");
                }
            }

            string sql = sqlStringBuilder.ToString();   
            ISession session = null;
            try
            {
                 //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                iSQLQuery.AddScalar("MarkSheetCount", NHibernateUtil.Int32);
                if (conditionDictionary.ContainsKey("MS_Name,Like"))
                {
                    iSQLQuery.SetString("MS_Name", "%" + conditionDictionary["MS_Name,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("MS_Kind,Eq"))
                {
                    iSQLQuery.SetString("MS_Kind", conditionDictionary["MS_Kind,Eq"].ToString());
                }

                if (conditionDictionary.ContainsKey("UserID,In"))
                {
                    iSQLQuery.SetParameterList("UserIDList", (List<int>)conditionDictionary["UserID,In"]);
                }
                if (conditionDictionary.ContainsKey("UserID,Not In"))
                {
                    iSQLQuery.SetParameterList("UserIDNotInList", (List<int>)conditionDictionary["UserID,Not In"]);
                }

                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询评分表信息失败", e);
                return null;
            }
            finally
            {
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
        public List<object[]> SelectMarkSheetInfoByCondition(Dictionary<string, object> conditionDictionary,int pageIndex,int pageSize)
        {
            StringBuilder sqlStringBuilder = new StringBuilder()
                .Append("SELECT ")
                .Append("    [MarkSheet].[User_ID], ")
                .Append("    [UserInfo].[U_Name], ")
                .Append("    [MarkSheet].[MSK_ID], ")
                .Append("    [MarkSheetKind].[MSK_Kind], ")
                .Append("    [MarkSheet].[MS_Name], ")
                .Append("    [MarkSheet].[MS_Share], ")
                .Append("    [MarkSheet].[MS_CreateDate], ")
                .Append("    [MarkSheet].[MS_ID] ")
                .Append("FROM ")
                .Append("   [MarkSheet] ")
                .Append("   LEFT JOIN [MarkSheetKind] ")
                .Append("       ON [MarkSheet].[MSK_ID] = [MarkSheetKind].[MSK_ID] ")
                .Append("   LEFT JOIN [UserInfo] ")
                .Append("       ON [MarkSheet].[User_ID] = [UserInfo].[U_ID] ")
                .Append("   WHERE [MarkSheet].[string1] = 0 ");
            if (conditionDictionary.ContainsKey("MS_Name,Like"))
            {
                sqlStringBuilder.Append("  AND [MarkSheet].[MS_Name] Like :MS_Name ");
            }
            if (conditionDictionary.ContainsKey("MS_Kind,Eq"))
            {
                 sqlStringBuilder.Append(" AND [MarkSheet].[MSK_ID] = :MS_Kind ");
            }
            if (conditionDictionary.ContainsKey("UserID,In") && conditionDictionary.ContainsKey("UserID,Not In"))
            {

                sqlStringBuilder.Append(" AND ([MarkSheet].[User_ID] IN  (:UserIDList) ")
                                .Append(" OR [MarkSheet].[User_ID] NOT  IN  (:UserIDNotInList) ) ");
            }
            else
            {
                if (conditionDictionary.ContainsKey("UserID,In"))
                {
                    sqlStringBuilder.Append(" AND [MarkSheet].[User_ID] IN  (:UserIDList) ");
                }
                else if (conditionDictionary.ContainsKey("UserID,Not In"))
                {
                    sqlStringBuilder.Append(" AND  [MarkSheet].[User_ID] NOT  IN  (:UserIDNotInList) ");
                }
            }
           
            string sql = sqlStringBuilder.ToString();   
            ISession session = null;
            try
            {
                 //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                iSQLQuery
                    .AddScalar("User_ID", NHibernateUtil.Int32)
                    .AddScalar("U_Name", NHibernateUtil.String)
                    .AddScalar("MSK_ID", NHibernateUtil.Int32)
                    .AddScalar("MSK_Kind", NHibernateUtil.String)
                    .AddScalar("MS_Name", NHibernateUtil.String)
                    .AddScalar("MS_Share", NHibernateUtil.Int32)
                    .AddScalar("MS_CreateDate", NHibernateUtil.DateTime)
                    .AddScalar("MS_ID", NHibernateUtil.Int32);
                
                //设置查询参数
                if (conditionDictionary.ContainsKey("MS_Name,Like"))
                {
                    iSQLQuery.SetString("MS_Name", "%" + conditionDictionary["MS_Name,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("MS_Kind,Eq"))
                {
                    iSQLQuery.SetString("MS_Kind", conditionDictionary["MS_Kind,Eq"].ToString());
                }
                if (conditionDictionary.ContainsKey("UserID,In"))
                {
                    iSQLQuery.SetParameterList("UserIDList", (List<int>)conditionDictionary["UserID,In"]);
                }
                if (conditionDictionary.ContainsKey("UserID,Not In"))
                {
                    iSQLQuery.SetParameterList("UserIDNotInList", (List<int>)conditionDictionary["UserID,Not In"]);
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
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询评分表信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        #endregion

        #region  ExtensionMethod

        /// <summary>
        /// 返回评分表列表
        /// </summary>
        /// <param name="sheetSort">评分表类别（0代表全部）</param>
        /// <param name="sheetKind">类型（1代表个人评分表，2代表他人评分表，3代表系统评分表）</param>
        /// <param name="userID">用户id（0代表admin，-1代表系统评分表）</param>
        /// <param name="searchSheetName">评分表名称（查询关键字）</param>
        /// <returns></returns>
        public DataSet GetMarkSheetList(string sheetSort, string[] sheetKinds, int userID, string searchSheetName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.*,B.MSK_Kind,C.U_Name,C.U_TrueName from MarkSheet as A left join MarkSheetKind as B on A.MSK_ID=B.MSK_ID left join UserInfo as C on A.User_ID=C.U_ID ");
            switch (sheetKinds.Length)
            {
                case 0:
                    strSql.Append(" where 1=2 "); break;
                case 1:
                    if (sheetKinds[0] == "1")
                    {
                        strSql.Append(string.Format(" where A.User_ID={0} ", userID));
                    }
                    else if (sheetKinds[0] == "2")
                    {
                        if (userID == 0)
                        {
                            strSql.Append(string.Format(" where A.User_ID!={0} and A.User_ID!=-1 ", userID));
                        }
                        else
                        {
                            strSql.Append(string.Format(" where A.User_ID!={0} and A.User_ID!=-1 and A.MS_Share=1 ", userID));
                        }
                    }
                    else if (sheetKinds[0] == "3")
                    {
                        strSql.Append(" where A.User_ID=-1 ");
                    }
                    break;
                case 2:
                    if ((sheetKinds[0] == "1" && sheetKinds[1] == "2") || (sheetKinds[0] == "2" && sheetKinds[1] == "1"))
                    {
                        if (userID == 0)
                        {
                            strSql.Append(" where A.User_ID!=-1 ");
                        }
                        else
                        {
                            strSql.Append(string.Format(" where ((A.User_ID={0}) or (A.User_ID!={0} and A.User_ID!=-1 and A.MS_Share=1)) ", userID));
                        }
                    }
                    else if ((sheetKinds[0] == "1" && sheetKinds[1] == "3") || (sheetKinds[0] == "3" && sheetKinds[1] == "1"))
                    {
                        strSql.Append(string.Format(" where ((A.User_ID=-1) or (A.User_ID={0})) ", userID));
                    }
                    else if ((sheetKinds[0] == "2" && sheetKinds[1] == "3") || (sheetKinds[0] == "3" && sheetKinds[1] == "2"))
                    {
                        if (userID == 0)
                        {
                            strSql.Append(" where A.User_ID!=0 ");
                        }
                        else
                        {
                            strSql.Append(string.Format(" where ((A.User_ID=-1) or (A.User_ID!={0} and A.User_ID!=-1 and A.MS_Share=1)) ", userID));
                        }
                    }
                    break;
                case 3:
                    if (userID == 0)
                    {
                        strSql.Append(" where 1=1 ");
                    }
                    else
                    {
                        strSql.Append(string.Format(" where ((A.User_ID={0}) or (A.User_ID!={0} and A.MS_Share=1) or (A.User_ID=-1)) ", userID));
                    }
                    break;
            }

            if (sheetSort != "0")
            {
                strSql.Append(string.Format(" and A.MSK_ID={0} ", sheetSort));
            }

            if (searchSheetName != string.Empty)
            {
                strSql.Append(string.Format(" and A.MS_Name like '%{0}%'", searchSheetName));
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取单个评分表信息
        /// </summary>
        /// <param name="ms_id">父评分表id</param>
        /// <returns></returns>
        public DataSet GetSingleMarkSheet(string ms_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.*,B.MSK_Kind,C.U_Name,C.U_TrueName from MarkSheet as A left join MarkSheetKind as B on A.MSK_ID=B.MSK_ID left join UserInfo as C on A.User_ID=C.U_ID ");
            strSql.Append(string.Format(" where A.MS_ID={0}", ms_id));

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新评分表（父表 + 子表），含二级评分项.（事务操作）
        /// </summary>
        /// <param name="model">父表model</param>
        /// <param name="dtParentItem">父评分项表</param>
        /// <param name="ChildrenItemList">子评分项表</param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Update(Tellyes.Model.MarkSheet model, DataTable dtParentItem, System.Collections.Generic.List<DataTable> ChildrenItemList)
        {
            System.Collections.Generic.List<CommandInfo> commandinfoList = new System.Collections.Generic.List<CommandInfo>();
            System.Collections.Generic.List<CommandInfo> cmdParentItemList = new System.Collections.Generic.List<CommandInfo>();
            System.Collections.Generic.List<System.Collections.Generic.List<CommandInfo>> cmdChildrenItemList = new System.Collections.Generic.List<System.Collections.Generic.List<CommandInfo>>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MarkSheet set ");
            strSql.Append("MSK_ID=@MSK_ID,");
            strSql.Append("MS_Name=@MS_Name,");
            strSql.Append("MS_Share=@MS_Share,");
            strSql.Append("MS_ModifyDate=@MS_ModifyDate,");
            strSql.Append("MS_ModifyPerson=@MS_ModifyPerson");
            strSql.Append(" where MS_ID=@MS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_ID", SqlDbType.Int,4),
					new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_Share", SqlDbType.Int,4),
					new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4),
                    new SqlParameter("@MS_ID",SqlDbType.Int,4)
                                        };
            parameters[0].Value = model.MSK_ID;
            parameters[1].Value = model.MS_Name;
            parameters[2].Value = model.MS_Share;
            parameters[3].Value = model.MS_ModifyDate;
            parameters[4].Value = model.MS_ModifyPerson;
            parameters[5].Value = model.MS_ID;
            commandinfoList.Add(new CommandInfo(strSql.ToString(), parameters));//

            StringBuilder strSql_del = new StringBuilder();
            strSql_del.Append("delete from MarkSheetItem where MS_ID=@MS_ID");
            SqlParameter[] parameters_del = { 
                     new SqlParameter("@MS_ID",SqlDbType.Int,4)
                                            };
            parameters_del[0].Value = model.MS_ID;
            commandinfoList.Add(new CommandInfo(strSql_del.ToString(), parameters_del));//

            cmdParentItemList = GetChildrenCmdList(dtParentItem);//
            foreach (DataTable dt in ChildrenItemList)
            {
                cmdChildrenItemList.Add(GetChildrenCmdList(dt));//
            }

            return DbHelperSQL.ExecuteSqlTran_Update(model.MS_ID, commandinfoList, cmdParentItemList, cmdChildrenItemList);
        }

        /// <summary>
        /// 插入评分表（父表 + 子表），含二级评分项.（事务操作）
        /// </summary>
        /// <param name="model">父表model</param>
        /// <param name="dtParentItem">父评分项表</param>
        /// <param name="ChildrenItemList">子评分项表</param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(Tellyes.Model.MarkSheet model, DataTable dtParentItem, System.Collections.Generic.List<DataTable> ChildrenItemList)
        {
            System.Collections.Generic.List<CommandInfo> cmdParentSheetList = new System.Collections.Generic.List<CommandInfo>();
            System.Collections.Generic.List<CommandInfo> cmdParentItemList = new System.Collections.Generic.List<CommandInfo>();
            System.Collections.Generic.List<System.Collections.Generic.List<CommandInfo>> cmdChildrenItemList = new System.Collections.Generic.List<System.Collections.Generic.List<CommandInfo>>();

            cmdParentSheetList = GetParentCmdList(model);
            cmdParentItemList = GetChildrenCmdList(dtParentItem);
            foreach (DataTable dt in ChildrenItemList)
            {
                cmdChildrenItemList.Add(GetChildrenCmdList(dt));
            }

            return DbHelperSQL.ExecuteSqlTran_Insert(cmdParentSheetList, cmdParentItemList, cmdChildrenItemList);
        }

        /// <summary>
        /// 获取父表插入数据(List）
        /// </summary>
        public System.Collections.Generic.List<CommandInfo> GetParentCmdList(Tellyes.Model.MarkSheet model)
        {
            System.Collections.Generic.List<CommandInfo> cmdList = new System.Collections.Generic.List<CommandInfo>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MarkSheet(");
            strSql.Append("User_ID,MSK_ID,MS_Name,MS_Share,MS_CreateDate,MS_ModifyDate,MS_ModifyPerson,string1,string2,string3,string4,MS_Score)");
            strSql.Append(" values (");
            strSql.Append("@User_ID,@MSK_ID,@MS_Name,@MS_Share,@MS_CreateDate,@MS_ModifyDate,@MS_ModifyPerson,@string1,@string2,@string3,@string4,@MS_Score)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4),
					new SqlParameter("@MSK_ID", SqlDbType.Int,4),
					new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_Share", SqlDbType.Int,4),
					new SqlParameter("@MS_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@string4", SqlDbType.NVarChar,50),
                    new SqlParameter("@MS_Score",SqlDbType.Decimal,18)                    
                                        };
                
            parameters[0].Value = model.User_ID;
            parameters[1].Value = model.MSK_ID;
            parameters[2].Value = model.MS_Name;
            parameters[3].Value = model.MS_Share;
            parameters[4].Value = model.MS_CreateDate;
            parameters[5].Value = model.MS_ModifyDate;
            parameters[6].Value = model.MS_ModifyPerson;
            parameters[7].Value = model.string1;
            parameters[8].Value = model.string2;
            parameters[9].Value = model.string3;
            parameters[10].Value = model.string4;
            parameters[11].Value = model.MS_Score;
            cmdList.Add(new CommandInfo(strSql.ToString(), parameters));
            return cmdList;
        }

        /// <summary>
        /// 获取子表插入数据(List)
        /// </summary>
        public System.Collections.Generic.List<CommandInfo> GetChildrenCmdList(DataTable SheetItemTable)
        {
            System.Collections.Generic.List<CommandInfo> cmdList = new System.Collections.Generic.List<CommandInfo>();
            foreach (DataRow dr in SheetItemTable.Rows)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into MarkSheetItem(");
                strSql.Append("MS_ID,MSI_Item,MSI_Score,string1,string2,string3)");
                strSql.Append(" values (");
                strSql.Append("@MS_ID,@MSI_Item,@MSI_Score,@string1,@string2,@string3)");
                strSql.Append(";select @@IDENTITY");
                SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@MSI_Item", SqlDbType.NVarChar,200),
					new SqlParameter("@MSI_Score", SqlDbType.Decimal,9),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50)};
                parameters[0].Value = null;
                parameters[1].Value = SheetItemTable.Columns.Contains("MSI_Item") == true ? dr["MSI_Item"] : dr["Child_Item"];//
                parameters[2].Value = SheetItemTable.Columns.Contains("MSI_Score") == true ? dr["MSI_Score"] : dr["Child_Score"];//
                parameters[3].Value = null;
                parameters[4].Value = null;
                parameters[5].Value = null;

                cmdList.Add(new CommandInfo(strSql.ToString(), parameters));
            }

            return cmdList;
        }

        /// <summary>
        /// 根据病例脚本，获得评分表集合
        /// </summary>
        /// <param name="icsID"></param>
        /// <returns></returns>
        public DataSet getMsFromIllnessCaseScript(string icsID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from MarkSheet where MS_ID in (select MarkSheetID from IllnessCaseScriptMarkSheet where IllnessCaseScriptID=" + icsID + ") ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod

        #region 获取的是评分表的信息
        public DataSet GetMarkSheetListNew(string pageIndex, string pageSize, string msName, string mskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from ( select  *, ROW_NUMBER() over(order by MS_CreateDate desc   ) as haha  from (select uu.U_TrueName,aa.MS_ID ,aa.MS_Name ,aa.MS_CreateDate ,aa.MSK_ID,kk.MSK_Kind ,aa.MS_Score   from  MarkSheet as  aa  left join  UserInfo  as uu on  aa.User_ID=uu.U_ID left join  MarkSheetKind as kk on  aa.MSK_ID=kk.MSK_ID  ");
            strSql.Append("  ) as  nn   ");
            if (!string.IsNullOrEmpty(msName) && (!string.IsNullOrEmpty(mskID) && mskID != "0"))
            {
                strSql.Append(" where  MS_Name like  '%" + msName + "%'  and  MSK_ID=" + mskID + "  ");
            }
            else if (string.IsNullOrEmpty(msName) && (!string.IsNullOrEmpty(mskID) && mskID != "0"))
            {

                strSql.Append(" where   MSK_ID=" + mskID + "   ");
            }
            else if (!string.IsNullOrEmpty(msName) && (string.IsNullOrEmpty(mskID) || mskID == "0"))
            {

                strSql.Append(" where  MS_Name like  '%" + msName + "%'   ");
            }
            strSql.Append(" ) qq  where  haha  between  (( " + pageSize + " * " + (Convert.ToInt32(pageIndex) - 1) + " )+1)   and  ( " + pageSize + " * " + (Convert.ToInt32(pageIndex)) + " )  ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion

        #region 获取到评分表总的数量
        public object GetMarkSheetListNewALL( string msName, string mskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(1) from ( select  *, ROW_NUMBER() over(order by MS_CreateDate   ) as haha  from (select uu.U_TrueName,aa.MS_ID ,aa.MS_Name ,aa.MS_CreateDate ,aa.MSK_ID,kk.MSK_Kind ,aa.MS_Score   from  MarkSheet as  aa  left join  UserInfo  as uu on  aa.User_ID=uu.U_ID left join  MarkSheetKind as kk on  aa.MSK_ID=kk.MSK_ID  ");
            strSql.Append("  ) as  nn   ");
            if (!string.IsNullOrEmpty(msName) && (!string.IsNullOrEmpty(mskID) && mskID != "0"))
            {
                strSql.Append(" where  MS_Name like  '%" + msName + "%'  and  MSK_ID=" + mskID + "  ");
            }
            else if (string.IsNullOrEmpty(msName) && (!string.IsNullOrEmpty(mskID) && mskID != "0"))
            {

                strSql.Append(" where   MSK_ID=" + mskID + "   ");
            }
            else if (!string.IsNullOrEmpty(msName) && (string.IsNullOrEmpty(mskID) || mskID == "0"))
            {

                strSql.Append(" where  MS_Name like  '%" + msName + "%'   ");
            }
            strSql.Append(" ) markSheetTotal ");

            return DbHelperSQL.GetSingle(strSql.ToString());
        }
        #endregion

        #region 新增评分列表
        public int AddMarkSheet(Tellyes.Model.MarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert  into  MarkSheet (User_ID,MSK_ID,MS_Name,MS_Share,MS_CreateDate,MS_ModifyDate,MS_ModifyPerson,MS_Score,string1,string2,string3,string4) ");
            strSql.Append("values( @User_ID,@MSK_ID ,@MS_Name, @MS_Share,@MS_CreateDate,@MS_ModifyDate,@MS_ModifyPerson,@MS_Score,@string1,@string2,@string3,@string4) ");
            SqlParameter[] sqlParameters = { 
                                            new SqlParameter("@User_ID", SqlDbType.Int,4),
					                        new SqlParameter("@MSK_ID", SqlDbType.Int,4),
					                        new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					                        new SqlParameter("@MS_Share", SqlDbType.Int,4),
					                        new SqlParameter("@MS_CreateDate", SqlDbType.DateTime),
					                        new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime),
					                        new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4),
                                            new SqlParameter("@MS_Score",SqlDbType.Decimal,18),
					                        new SqlParameter("@string1", SqlDbType.NVarChar,50),
					                        new SqlParameter("@string2", SqlDbType.NVarChar,50),
					                        new SqlParameter("@string3", SqlDbType.NVarChar,50),
					                        new SqlParameter("@string4", SqlDbType.NVarChar,50)
                                           };

            sqlParameters[0].Value = model.User_ID;
            sqlParameters[1].Value = model.MSK_ID;
            sqlParameters[2].Value = model.MS_Name;
            sqlParameters[3].Value = model.MS_Share;
            sqlParameters[4].Value = model.MS_CreateDate;
            sqlParameters[5].Value = model.MS_ModifyDate;
            sqlParameters[6].Value = model.MS_ModifyPerson;
            sqlParameters[7].Value = model.MS_Score;
            sqlParameters[8].Value = model.string1;
            sqlParameters[9].Value = model.string2;
            sqlParameters[10].Value = model.string3;
            sqlParameters[11].Value = model.string4;


            return DbHelperSQL.ExecuteSql(strSql.ToString(), sqlParameters);
        }
        #endregion

        #region 编辑评分列表
        public int EditMarkSheetNew(Tellyes.Model.MarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update MarkSheet  set MSK_ID=@MSK_ID ,MS_Name=@MS_Name,MS_ModifyDate=@MS_ModifyDate,MS_ModifyPerson=@MS_ModifyPerson ");
            strSql.Append(" where MS_ID = " + model.MS_ID + " ");
            SqlParameter[] sqlParameters = { 
					                        new SqlParameter("@MSK_ID", SqlDbType.Int,4),
					                        new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					                        new SqlParameter("@MS_ModifyDate", SqlDbType.DateTime),
					                        new SqlParameter("@MS_ModifyPerson", SqlDbType.Int,4),
                                           };

            sqlParameters[0].Value = model.MSK_ID;
            sqlParameters[1].Value = model.MS_Name;
            sqlParameters[2].Value = model.MS_ModifyDate;
            sqlParameters[3].Value = model.MS_ModifyPerson;
            return DbHelperSQL.ExecuteSql(strSql.ToString(), sqlParameters);
        }
        #endregion

        #region 删除评分表
        public int DelMarkSheetNew(string conditon)
        {
            List<string> strList = new List<string>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from MarkSheet where MS_ID in(" + conditon + ") ");
            strList.Add(strSql.ToString());
            strSql.Clear();
            strSql.Append(" delete from MarkSheetItem where  MS_ID in (" + conditon + ") ");
            strList.Add(strSql.ToString());
            return DbHelperSQL.ExecuteSqlTran(strList);
        }
        #endregion

        #region 获取到一级评分表中的数据
        public DataSet getMarkSheetLists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select marksheet.MS_ID,marksheet.User_ID,marksheet.MSK_ID,marksheet.MS_Name,marksheet.MS_CreateDate,marksheet.MS_modifyDate,marksheet.Ms_Score,marksheet.string3,marksheetKind.MSK_Kind from  marksheet ");
            strSql.Append("  left  join  markSheetKind  on  marksheet.msk_id  = marksheetKind.MSK_ID  ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}

