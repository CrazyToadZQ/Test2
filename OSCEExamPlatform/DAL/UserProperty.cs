using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Tellyes.NHibernate;
using Tellyes.DBUtility;
using System.Data;
using System.Data.SqlClient;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class UserProperty : BaseDAL<Tellyes.Model.UserProperty>
    {
        public UserProperty()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int UserPropertyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserProperty");
            strSql.Append(" where UserPropertyID=@UserPropertyID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPropertyID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserPropertyID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.UserProperty model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserProperty(");
            strSql.Append("UserPropertyName,UserPropertyNumber1,UserPropertyNumber2,UserPropertyNumber3,UserPropertyNumber4,UserPropertyString1,UserPropertyString2,UserPropertyString3,UserPropertyString4,UserPropertyString5)");
            strSql.Append(" values (");
            strSql.Append("@UserPropertyName,@UserPropertyNumber1,@UserPropertyNumber2,@UserPropertyNumber3,@UserPropertyNumber4,@UserPropertyString1,@UserPropertyString2,@UserPropertyString3,@UserPropertyString4,@UserPropertyString5)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPropertyName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserPropertyNumber1", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber2", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber3", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber4", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyString1", SqlDbType.VarChar,50),
					new SqlParameter("@UserPropertyString2", SqlDbType.VarChar,500),
					new SqlParameter("@UserPropertyString3", SqlDbType.VarChar,1000),
					new SqlParameter("@UserPropertyString4", SqlDbType.VarChar,2000),
					new SqlParameter("@UserPropertyString5", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.UserPropertyName;
            parameters[1].Value = model.UserPropertyNumber1;
            parameters[2].Value = model.UserPropertyNumber2;
            parameters[3].Value = model.UserPropertyNumber3;
            parameters[4].Value = model.UserPropertyNumber4;
            parameters[5].Value = model.UserPropertyString1;
            parameters[6].Value = model.UserPropertyString2;
            parameters[7].Value = model.UserPropertyString3;
            parameters[8].Value = model.UserPropertyString4;
            parameters[9].Value = model.UserPropertyString5;

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
        public bool Update(Tellyes.Model.UserProperty model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserProperty set ");
            strSql.Append("UserPropertyName=@UserPropertyName,");
            strSql.Append("UserPropertyNumber1=@UserPropertyNumber1,");
            strSql.Append("UserPropertyNumber2=@UserPropertyNumber2,");
            strSql.Append("UserPropertyNumber3=@UserPropertyNumber3,");
            strSql.Append("UserPropertyNumber4=@UserPropertyNumber4,");
            strSql.Append("UserPropertyString1=@UserPropertyString1,");
            strSql.Append("UserPropertyString2=@UserPropertyString2,");
            strSql.Append("UserPropertyString3=@UserPropertyString3,");
            strSql.Append("UserPropertyString4=@UserPropertyString4,");
            strSql.Append("UserPropertyString5=@UserPropertyString5");
            strSql.Append(" where UserPropertyID=@UserPropertyID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPropertyName", SqlDbType.NVarChar,200),
					new SqlParameter("@UserPropertyNumber1", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber2", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber3", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyNumber4", SqlDbType.Int,4),
					new SqlParameter("@UserPropertyString1", SqlDbType.VarChar,50),
					new SqlParameter("@UserPropertyString2", SqlDbType.VarChar,500),
					new SqlParameter("@UserPropertyString3", SqlDbType.VarChar,1000),
					new SqlParameter("@UserPropertyString4", SqlDbType.VarChar,2000),
					new SqlParameter("@UserPropertyString5", SqlDbType.VarChar,-1),
					new SqlParameter("@UserPropertyID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserPropertyName;
            parameters[1].Value = model.UserPropertyNumber1;
            parameters[2].Value = model.UserPropertyNumber2;
            parameters[3].Value = model.UserPropertyNumber3;
            parameters[4].Value = model.UserPropertyNumber4;
            parameters[5].Value = model.UserPropertyString1;
            parameters[6].Value = model.UserPropertyString2;
            parameters[7].Value = model.UserPropertyString3;
            parameters[8].Value = model.UserPropertyString4;
            parameters[9].Value = model.UserPropertyString5;
            parameters[10].Value = model.UserPropertyID;

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
        public bool Delete(int UserPropertyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserProperty ");
            strSql.Append(" where UserPropertyID=@UserPropertyID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPropertyID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserPropertyID;

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
        public bool DeleteList(string UserPropertyIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserProperty ");
            strSql.Append(" where UserPropertyID in (" + UserPropertyIDlist + ")  ");
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
        public Tellyes.Model.UserProperty GetModel(int UserPropertyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserPropertyID,UserPropertyName,UserPropertyNumber1,UserPropertyNumber2,UserPropertyNumber3,UserPropertyNumber4,UserPropertyString1,UserPropertyString2,UserPropertyString3,UserPropertyString4,UserPropertyString5 from UserProperty ");
            strSql.Append(" where UserPropertyID=@UserPropertyID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPropertyID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserPropertyID;

            Tellyes.Model.UserProperty model = new Tellyes.Model.UserProperty();
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
        public Tellyes.Model.UserProperty DataRowToModel(DataRow row)
        {
            Tellyes.Model.UserProperty model = new Tellyes.Model.UserProperty();
            if (row != null)
            {
                if (row["UserPropertyID"] != null && row["UserPropertyID"].ToString() != "")
                {
                    model.UserPropertyID = int.Parse(row["UserPropertyID"].ToString());
                }
                if (row["UserPropertyName"] != null)
                {
                    model.UserPropertyName = row["UserPropertyName"].ToString();
                }
                if (row["UserPropertyNumber1"] != null && row["UserPropertyNumber1"].ToString() != "")
                {
                    model.UserPropertyNumber1 = int.Parse(row["UserPropertyNumber1"].ToString());
                }
                if (row["UserPropertyNumber2"] != null && row["UserPropertyNumber2"].ToString() != "")
                {
                    model.UserPropertyNumber2 = int.Parse(row["UserPropertyNumber2"].ToString());
                }
                if (row["UserPropertyNumber3"] != null && row["UserPropertyNumber3"].ToString() != "")
                {
                    model.UserPropertyNumber3 = int.Parse(row["UserPropertyNumber3"].ToString());
                }
                if (row["UserPropertyNumber4"] != null && row["UserPropertyNumber4"].ToString() != "")
                {
                    model.UserPropertyNumber4 = int.Parse(row["UserPropertyNumber4"].ToString());
                }
                if (row["UserPropertyString1"] != null)
                {
                    model.UserPropertyString1 = row["UserPropertyString1"].ToString();
                }
                if (row["UserPropertyString2"] != null)
                {
                    model.UserPropertyString2 = row["UserPropertyString2"].ToString();
                }
                if (row["UserPropertyString3"] != null)
                {
                    model.UserPropertyString3 = row["UserPropertyString3"].ToString();
                }
                if (row["UserPropertyString4"] != null)
                {
                    model.UserPropertyString4 = row["UserPropertyString4"].ToString();
                }
                if (row["UserPropertyString5"] != null)
                {
                    model.UserPropertyString5 = row["UserPropertyString5"].ToString();
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
            strSql.Append("select UserPropertyID,UserPropertyName,UserPropertyNumber1,UserPropertyNumber2,UserPropertyNumber3,UserPropertyNumber4,UserPropertyString1,UserPropertyString2,UserPropertyString3,UserPropertyString4,UserPropertyString5 ");
            strSql.Append(" FROM UserProperty ");
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
            strSql.Append(" UserPropertyID,UserPropertyName,UserPropertyNumber1,UserPropertyNumber2,UserPropertyNumber3,UserPropertyNumber4,UserPropertyString1,UserPropertyString2,UserPropertyString3,UserPropertyString4,UserPropertyString5 ");
            strSql.Append(" FROM UserProperty ");
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
            strSql.Append("select count(1) FROM UserProperty ");
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
                strSql.Append("order by T.UserPropertyID desc");
            }
            strSql.Append(")AS Row, T.*  from UserProperty T ");
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
            parameters[0].Value = "UserProperty";
            parameters[1].Value = "UserPropertyID";
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
            if (conditionDictionary.ContainsKey("PropertyName_Is"))
            {
                criteria.Add(Restrictions.Eq("UserPropertyName", conditionDictionary["PropertyName_Is"]));
            }  
            return criteria;
        }
        #endregion  ExtensionMethod 
    }
}
