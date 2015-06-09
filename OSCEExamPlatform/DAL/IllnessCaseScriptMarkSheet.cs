using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.Log4Net;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class IllnessCaseScriptMarkSheet : BaseDAL<Model.IllnessCaseScriptMarkSheet>
    {
        #region Basic
        public bool Exists(int IllnessCaseScriptMarkSheetID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from IllnessCaseScriptMarkSheet");
            strSql.Append(" where ");
            strSql.Append(" IllnessCaseScriptMarkSheetID = @IllnessCaseScriptMarkSheetID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptMarkSheetID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseScriptMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IllnessCaseScriptMarkSheet(");
            strSql.Append("IllnessCaseScriptID,MarkSheetID");
            strSql.Append(") values (");
            strSql.Append("@IllnessCaseScriptID,@MarkSheetID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.IllnessCaseScriptID;
            parameters[1].Value = model.MarkSheetID;

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
        public bool Update(Model.IllnessCaseScriptMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update IllnessCaseScriptMarkSheet set ");

            strSql.Append(" IllnessCaseScriptID = @IllnessCaseScriptID , ");
            strSql.Append(" MarkSheetID = @MarkSheetID  ");
            strSql.Append(" where IllnessCaseScriptMarkSheetID=@IllnessCaseScriptMarkSheetID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@IllnessCaseScriptMarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.IllnessCaseScriptMarkSheetID;
            parameters[1].Value = model.IllnessCaseScriptID;
            parameters[2].Value = model.MarkSheetID;
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
        public bool Delete(int IllnessCaseScriptMarkSheetID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseScriptMarkSheet ");
            strSql.Append(" where IllnessCaseScriptMarkSheetID=@IllnessCaseScriptMarkSheetID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptMarkSheetID;


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
        public bool DeleteList(string IllnessCaseScriptMarkSheetIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseScriptMarkSheet ");
            strSql.Append(" where ID in (" + IllnessCaseScriptMarkSheetIDlist + ")  ");
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
        public Model.IllnessCaseScriptMarkSheet GetModel(int IllnessCaseScriptMarkSheetID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select IllnessCaseScriptMarkSheetID, IllnessCaseScriptID, MarkSheetID  ");
            strSql.Append("  from IllnessCaseScriptMarkSheet ");
            strSql.Append(" where IllnessCaseScriptMarkSheetID=@IllnessCaseScriptMarkSheetID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptMarkSheetID;


            Model.IllnessCaseScriptMarkSheet model = new Model.IllnessCaseScriptMarkSheet();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["IllnessCaseScriptMarkSheetID"].ToString() != "")
                {
                    model.IllnessCaseScriptMarkSheetID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseScriptMarkSheetID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString() != "")
                {
                    model.IllnessCaseScriptID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetID"].ToString() != "")
                {
                    model.MarkSheetID = int.Parse(ds.Tables[0].Rows[0]["MarkSheetID"].ToString());
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
            strSql.Append(" FROM IllnessCaseScriptMarkSheet ");
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
            strSql.Append(" FROM IllnessCaseScriptMarkSheet ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion

        #region Extension

        public bool DeleteIllnessCaseScriptMarkSheetByIllnessCaseScriptID(int illnessCaseScriptID)
        {
            ISession session = null;
            string sql = new StringBuilder(string.Empty)
                .Append("DELETE  ")
                .Append("FROM ")
                .Append("   [IllnessCaseScriptMarkSheet] ")
                .Append("WHERE ")
                .Append("   [IllnessCaseScriptID] = :IllnessCaseScriptID")
                .ToString();
            try
            {
                session = SessionManager.OpenSession();
                session.CreateSQLQuery(sql)
                    .SetInt32("IllnessCaseScriptID", illnessCaseScriptID)
                    .ExecuteUpdate();
                return true;
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return false;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        public List<object[]> SelectIllnessCaseScriptMarkSheetByIllnessCaseScriptList(List<int> illnessCaseScriptIDList)
        {
            ISession session = null;
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [IllnessCaseScriptMarkSheet].*, ")
                .Append("   [MarkSheet].* ")
                .Append("FROM ")
                .Append("   [IllnessCaseScriptMarkSheet] ")
                .Append("   INNER JOIN [MarkSheet] ")
                .Append("       ON [MarkSheet].[MS_ID] = [IllnessCaseScriptMarkSheet].[MarkSheetID] ")
                .Append("WHERE ")
                .Append("   [IllnessCaseScriptMarkSheet].[IllnessCaseScriptID] IN (:illnessCaseScriptIDList) ")
                .Append("ORDER BY ")
                .Append("   [MarkSheet].[MS_Name] ASC")
                .ToString();
            try
            {
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.IllnessCaseScriptMarkSheet))
                    .AddEntity(typeof(Model.MarkSheet))
                    .SetParameterList("illnessCaseScriptIDList", illnessCaseScriptIDList)
                    .List<object[]>().
                    ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("IllnessCaseScriptID")) 
            {
                criteria.Add(Restrictions.Eq("IllnessCaseScriptID", conditionDictionary["IllnessCaseScriptID"]));
            }
            if (conditionDictionary.ContainsKey("IllnessCaseScriptIDList")) 
            {
                criteria.Add(Restrictions.In("IllnessCaseScriptID", (List<int>)conditionDictionary["IllnessCaseScriptIDList"]));
            }
            return criteria;
        }

        #endregion
        
    }
}
