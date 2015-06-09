using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamTimeInfo
    /// </summary>
    public partial class ExamTimeInfo : BaseDAL<Model.ExamTimeInfo>
    {
        public ExamTimeInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ETI_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamTimeInfo");
            strSql.Append(" where ETI_ID=@ETI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ETI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ETI_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamTimeInfo(");
            strSql.Append("ETI_StartTime,ETI_EndTime,E_ID)");
            strSql.Append(" values (");
            strSql.Append("@ETI_StartTime,@ETI_EndTime,@E_ID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ETI_StartTime", SqlDbType.NVarChar,50),
					new SqlParameter("@ETI_EndTime", SqlDbType.NVarChar,50),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.ETI_StartTime;
            parameters[1].Value = model.ETI_EndTime;
            parameters[2].Value = model.E_ID;

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
        public bool Update(Tellyes.Model.ExamTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamTimeInfo set ");
            strSql.Append("ETI_StartTime=@ETI_StartTime,");
            strSql.Append("ETI_EndTime=@ETI_EndTime,");
            strSql.Append("E_ID=@E_ID");
            strSql.Append(" where ETI_ID=@ETI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ETI_StartTime", SqlDbType.NVarChar,50),
					new SqlParameter("@ETI_EndTime", SqlDbType.NVarChar,50),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ETI_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ETI_StartTime;
            parameters[1].Value = model.ETI_EndTime;
            parameters[2].Value = model.E_ID;
            parameters[3].Value = model.ETI_ID;

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
        public bool Delete(int ETI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamTimeInfo ");
            strSql.Append(" where ETI_ID=@ETI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ETI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ETI_ID;

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
        public bool DeleteList(string ETI_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamTimeInfo ");
            strSql.Append(" where ETI_ID in (" + ETI_IDlist + ")  ");
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
        public Tellyes.Model.ExamTimeInfo GetModel(int ETI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ETI_ID,ETI_StartTime,ETI_EndTime,E_ID from ExamTimeInfo ");
            strSql.Append(" where ETI_ID=@ETI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ETI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ETI_ID;

            Tellyes.Model.ExamTimeInfo model = new Tellyes.Model.ExamTimeInfo();
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
        public Tellyes.Model.ExamTimeInfo DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamTimeInfo model = new Tellyes.Model.ExamTimeInfo();
            if (row != null)
            {
                if (row["ETI_ID"] != null && row["ETI_ID"].ToString() != "")
                {
                    model.ETI_ID = int.Parse(row["ETI_ID"].ToString());
                }
                if (row["ETI_StartTime"] != null)
                {
                    model.ETI_StartTime = row["ETI_StartTime"].ToString();
                }
                if (row["ETI_EndTime"] != null)
                {
                    model.ETI_EndTime = row["ETI_EndTime"].ToString();
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = int.Parse(row["int1"].ToString());
                }
                if (row["string1"] != null && row["string1"].ToString() != "")
                {
                    model.string1 = row["string1"].ToString();
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
            strSql.Append("select ETI_ID,ETI_StartTime,ETI_EndTime,E_ID,int1,string1 ");
            strSql.Append(" FROM ExamTimeInfo ");
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
            strSql.Append(" ETI_ID,ETI_StartTime,ETI_EndTime,E_ID ");
            strSql.Append(" FROM ExamTimeInfo ");
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
            strSql.Append("select count(1) FROM ExamTimeInfo ");
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
                strSql.Append("order by T.ETI_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamTimeInfo T ");
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
            parameters[0].Value = "ExamTimeInfo";
            parameters[1].Value = "ETI_ID";
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
            if (conditionDictionary.ContainsKey("examTableID,Eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["examTableID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,eq"]));
            }

            if (conditionDictionary.ContainsKey("string1,Eq"))
            {
                criteria.Add(Restrictions.Eq("string1", conditionDictionary["string1,Eq"]));
            }
            return criteria;
        }


        /// <summary>
        /// 查询每天的考生数量
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectEachDateStudentCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [string1], ")
                .Append("   SUM(int1) AS examStudentCount  ")
                .Append("FROM ")
                .Append("   [ExamTimeInfo] ")
                .Append("WHERE ")
                .Append("      [E_ID] = (:E_ID) ")
                .Append("GROUP BY  ")
                .Append("   [string1] ")
                .Append("ORDER BY  ")
                .Append("   [string1] ");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("string1", NHibernateUtil.String);
                iSQLQuery.AddScalar("examStudentCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询每天的考生数量", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion  ExtensionMethod
    }
}
