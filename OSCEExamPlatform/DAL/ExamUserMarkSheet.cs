using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.DBUtility;
using System.Data.SqlClient;
using Tellyes.NHibernate;
using NHibernate;
using Tellyes.Log4Net;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamUserMarkSheet
    /// </summary>
    public partial class ExamUserMarkSheet: BaseDAL<Model.ExamUserMarkSheet>
    {
        public ExamUserMarkSheet()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EUMS_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamUserMarkSheet");
            strSql.Append(" where EUMS_ID=@EUMS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EUMS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = EUMS_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamUserMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamUserMarkSheet(");
            strSql.Append("EU_ID,MS_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@EU_ID,@MS_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.UniqueIdentifier,32),
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
            parameters[0].Value = model.EU_ID;
            parameters[1].Value = model.MS_ID;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.float3;

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
        public bool Update(Tellyes.Model.ExamUserMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamUserMarkSheet set ");
            strSql.Append("EU_ID=@EU_ID,");
            strSql.Append("MS_ID=@MS_ID,");
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
            strSql.Append(" where EUMS_ID=@EUMS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.UniqueIdentifier,32),
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
					new SqlParameter("@EUMS_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.EU_ID;
            parameters[1].Value = model.MS_ID;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.float3;
            parameters[14].Value = model.EUMS_ID;

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
        public bool Delete(int EUMS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamUserMarkSheet ");
            strSql.Append(" where EUMS_ID=@EUMS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EUMS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = EUMS_ID;

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
        public bool DeleteList(string EUMS_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamUserMarkSheet ");
            strSql.Append(" where EUMS_ID in (" + EUMS_IDlist + ")  ");
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
        public Tellyes.Model.ExamUserMarkSheet GetModel(int EUMS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 EUMS_ID,EU_ID,MS_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ExamUserMarkSheet ");
            strSql.Append(" where EUMS_ID=@EUMS_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EUMS_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = EUMS_ID;

            Tellyes.Model.ExamUserMarkSheet model = new Tellyes.Model.ExamUserMarkSheet();
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
        public Tellyes.Model.ExamUserMarkSheet DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamUserMarkSheet model = new Tellyes.Model.ExamUserMarkSheet();
            if (row != null)
            {
                if (row["EUMS_ID"] != null && row["EUMS_ID"].ToString() != "")
                {
                    model.EUMS_ID = int.Parse(row["EUMS_ID"].ToString());
                }
                if (row["EU_ID"] != null && row["EU_ID"].ToString() != "")
                {
                    model.EU_ID = new Guid(row["EU_ID"].ToString());
                }
                if (row["MS_ID"] != null && row["MS_ID"].ToString() != "")
                {
                    model.MS_ID = int.Parse(row["MS_ID"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = int.Parse(row["int1"].ToString());
                }
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.int2 = Guid.Parse(row["int2"].ToString());
                }
                if (row["int3"] != null && row["int3"].ToString() != "")
                {
                    model.int3 = int.Parse(row["int3"].ToString());
                }
                if (row["string1"] != null)
                {
                    model.string1 = Guid.Parse( row["string1"].ToString());
                }
                if (row["string2"] != null)
                {
                    model.string2 = Guid.Parse( row["string2"].ToString());
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EUMS_ID,EU_ID,MS_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamUserMarkSheet ");
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
            strSql.Append(" EUMS_ID,EU_ID,MS_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamUserMarkSheet ");
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
            strSql.Append("select count(1) FROM ExamUserMarkSheet ");
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
                strSql.Append("order by T.EUMS_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamUserMarkSheet T ");
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
            parameters[0].Value = "ExamUserMarkSheet";
            parameters[1].Value = "EUMS_ID";
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
        /// 根据考试的ID，获得考试User评分表的集合
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet getEumsByExamID(Guid EID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from ExamUserMarkSheet where EU_ID in (select EU_ID from ExamUser where E_ID=@E_ID)");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EID;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        #endregion  ExtensionMethod

        #region ExtensionMethod

        public List<Model.MarkSheet> SelectMarkSheetByExamUserID(Guid examUserID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [MarkSheet].* ")
                .Append("FROM ")
                .Append("   [ExamUserMarkSheet] ")
                .Append("   INNER JOIN [MarkSheet] ")
                .Append("       ON [ExamUserMarkSheet].[MS_ID] = [MarkSheet].[MS_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUserMarkSheet].[EU_ID] = :examUserID ");
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sqlBuilder.ToString());
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.MarkSheet));
                //设置查询参数
                iSQLQuery.SetGuid("examUserID", examUserID);
                //查询结果并返回
                return iSQLQuery
                    .List<Model.MarkSheet>()
                    .ToList<Model.MarkSheet>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，查询评委绑定评分表失败", e);
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
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("string1", conditionDictionary["E_ID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("string1", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("int2", conditionDictionary["ES_ID,eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
