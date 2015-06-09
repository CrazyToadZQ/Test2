using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
using Tellyes.NHibernate;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Criterion;
namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:MarkSheetKind
    /// </summary>
    public partial class MarkSheetKind : BaseDAL<Model.MarkSheetKind>
    {
        public MarkSheetKind()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSK_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MarkSheetKind");
            strSql.Append(" where MSK_ID=@MSK_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSK_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.MarkSheetKind model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MarkSheetKind(");
            strSql.Append("MSK_Kind,string1,string2,string3)");
            strSql.Append(" values (");
            strSql.Append("@MSK_Kind,@string1,@string2,@string3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_Kind", SqlDbType.NVarChar,50),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.MSK_Kind;
            parameters[1].Value = model.string1;
            parameters[2].Value = model.string2;
            parameters[3].Value = model.string3;

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
        public bool Update(Tellyes.Model.MarkSheetKind model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MarkSheetKind set ");
            strSql.Append("MSK_Kind=@MSK_Kind,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3");
            strSql.Append(" where MSK_ID=@MSK_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_Kind", SqlDbType.NVarChar,50),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@MSK_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MSK_Kind;
            parameters[1].Value = model.string1;
            parameters[2].Value = model.string2;
            parameters[3].Value = model.string3;
            parameters[4].Value = model.MSK_ID;

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
        public bool Delete(int MSK_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheetKind ");
            strSql.Append(" where MSK_ID=@MSK_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSK_ID;

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
        public bool DeleteList(string MSK_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheetKind ");
            strSql.Append(" where MSK_ID in (" + MSK_IDlist + ")  ");
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
        public Tellyes.Model.MarkSheetKind GetModel(int MSK_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MSK_ID,MSK_Kind,string1,string2,string3 from MarkSheetKind ");
            strSql.Append(" where MSK_ID=@MSK_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSK_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSK_ID;

            Tellyes.Model.MarkSheetKind model = new Tellyes.Model.MarkSheetKind();
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
        public Tellyes.Model.MarkSheetKind DataRowToModel(DataRow row)
        {
            Tellyes.Model.MarkSheetKind model = new Tellyes.Model.MarkSheetKind();
            if (row != null)
            {
                if (row["MSK_ID"] != null && row["MSK_ID"].ToString() != "")
                {
                    model.MSK_ID = int.Parse(row["MSK_ID"].ToString());
                }
                if (row["MSK_Kind"] != null)
                {
                    model.MSK_Kind = row["MSK_Kind"].ToString();
                }
                if (row["string1"] != null)
                {
                    model.string1 = row["string1"].ToString();
                }
                if (row["string2"] != null)
                {
                    model.string2 = row["string2"].ToString();
                }
                if (row["string3"] != null)
                {
                    model.string3 = row["string3"].ToString();
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
            strSql.Append("select MSK_ID,MSK_Kind,string1,string2,string3 ");
            strSql.Append(" FROM MarkSheetKind ");
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
            strSql.Append(" MSK_ID,MSK_Kind,string1,string2,string3 ");
            strSql.Append(" FROM MarkSheetKind ");
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
            strSql.Append("select count(1) FROM MarkSheetKind ");
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
                strSql.Append("order by T.MSK_ID desc");
            }
            strSql.Append(")AS Row, T.*  from MarkSheetKind T ");
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
            parameters[0].Value = "MarkSheetKind";
            parameters[1].Value = "MSK_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("string1"))
            {
                criteria.Add(Restrictions.Eq("string1", conditionDictionary["string1"]));
            }
            return criteria;
        }
        #endregion  ExtensionMethod
    }
}

