using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class IllnessCaseSP : BaseDAL<Model.IllnessCaseSP>
    {
        #region Methed
        public bool Exists(int IllnessCaseSPID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from IllnessCaseSP");
            strSql.Append(" where ");
            strSql.Append(" IllnessCaseSPID = @IllnessCaseSPID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseSPID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseSPID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseSP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IllnessCaseSP(");
            strSql.Append("IllnessCaseID,SPUserInfoID");
            strSql.Append(") values (");
            strSql.Append("@IllnessCaseID,@SPUserInfoID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SPUserInfoID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.IllnessCaseID;
            parameters[1].Value = model.SPUserInfoID;

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
        public bool Update(Model.IllnessCaseSP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update IllnessCaseSP set ");

            strSql.Append(" IllnessCaseID = @IllnessCaseID , ");
            strSql.Append(" SPUserInfoID = @SPUserInfoID  ");
            strSql.Append(" where IllnessCaseSPID=@IllnessCaseSPID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@IllnessCaseSPID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@SPUserInfoID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.IllnessCaseSPID;
            parameters[1].Value = model.IllnessCaseID;
            parameters[2].Value = model.SPUserInfoID;
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
        public bool Delete(int IllnessCaseSPID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseSP ");
            strSql.Append(" where IllnessCaseSPID=@IllnessCaseSPID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseSPID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseSPID;


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
        public bool DeleteList(string IllnessCaseSPIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseSP ");
            strSql.Append(" where ID in (" + IllnessCaseSPIDlist + ")  ");
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
        public Model.IllnessCaseSP GetModel(int IllnessCaseSPID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select IllnessCaseSPID, IllnessCaseID, SPUserInfoID  ");
            strSql.Append("  from IllnessCaseSP ");
            strSql.Append(" where IllnessCaseSPID=@IllnessCaseSPID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseSPID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseSPID;


            Model.IllnessCaseSP model = new Model.IllnessCaseSP();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["IllnessCaseSPID"].ToString() != "")
                {
                    model.IllnessCaseSPID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseSPID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IllnessCaseID"].ToString() != "")
                {
                    model.IllnessCaseID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SPUserInfoID"].ToString() != "")
                {
                    model.SPUserInfoID = int.Parse(ds.Tables[0].Rows[0]["SPUserInfoID"].ToString());
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
            strSql.Append(" FROM IllnessCaseSP ");
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
            strSql.Append(" FROM IllnessCaseSP ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region Extension

        public List<object[]> SelectIllnessCaseSPInfoByIllnessCaseID(int illnessCaseID)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [IllnessCaseSPID], ")
                    .Append("   [IllnessCaseID], ")
                    .Append("   [SPUserInfoID], ")
                    .Append("   [U_ID], ")
                    .Append("   [U_Name], ")
                    .Append("   [U_TrueName], ")
                    .Append("   [U_PWD], ")
                    .Append("   [U_Sex], ")
                    .Append("   [U_Phone], ")
                    .Append("   [U_Phone2], ")
                    .Append("   [U_Email], ")
                    .Append("   [U_Email2], ")
                    .Append("   [U_Contont], ")
                    .Append("   [U_Photo], ")
                    .Append("   [date1], ")
                    .Append("   [string1], ")
                    .Append("   [U_GoodField], ")
                    .Append("   [U_Title], ")
                    .Append("   [U_Ethnic], ")
                    .Append("   [U_Education], ")
                    .Append("   [U_InTime], ")
                    .Append("   [U_Source], ")
                    .Append("   [U_Unit] ")
                    .Append("FROM ")
                    .Append("   [IllnessCaseSP] ")
                    .Append("   INNER JOIN [UserInfo] ")
                    .Append("       ON [IllnessCaseSP].[SPUserInfoID] = [UserInfo].[U_ID] ")
                    .Append("WHERE ")
                    .Append("   [IllnessCaseSP].[IllnessCaseID] = :IllnessCaseID ")
                    .ToString();
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.UserInfo))
                    .AddEntity(typeof(Model.IllnessCaseSP))
                    .SetInt32("IllnessCaseID", illnessCaseID)
                    .List<object[]>().
                    ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("IllnessCaseID"))
            {
                criteria.Add(Restrictions.Eq("IllnessCaseID", conditionDictionary["IllnessCaseID"]));
            }
            return criteria;
        }
        #endregion
    }
}
