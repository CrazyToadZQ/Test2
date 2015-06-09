using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class PropertyValue : BaseDAL<Tellyes.Model.PropertyValue>
    {
        public PropertyValue()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PropertyValueID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PropertyValue");
            strSql.Append(" where PropertyValueID=@PropertyValueID");
            SqlParameter[] parameters = {
					new SqlParameter("@PropertyValueID", SqlDbType.Int,4)
			};
            parameters[0].Value = PropertyValueID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.PropertyValue model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PropertyValue(");
            strSql.Append("PropertyValueName,PropertyValueOrderNumber,PropertyValueNumber1,PropertyValueNumber2,PropertyValueNumber3,PropertyValueNumber4,PropertyValueString1,PropertyValueString2,PropertyValueString3,PropertyValueString4,PropertyValueString5)");
            strSql.Append(" values (");
            strSql.Append("@PropertyValueName,@PropertyValueOrderNumber,@PropertyValueNumber1,@PropertyValueNumber2,@PropertyValueNumber3,@PropertyValueNumber4,@PropertyValueString1,@PropertyValueString2,@PropertyValueString3,@PropertyValueString4,@PropertyValueString5)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@PropertyValueName", SqlDbType.NVarChar,200),
					new SqlParameter("@PropertyValueOrderNumber", SqlDbType.VarChar,-1),
					new SqlParameter("@PropertyValueNumber1", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber2", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber3", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber4", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueString1", SqlDbType.VarChar,50),
					new SqlParameter("@PropertyValueString2", SqlDbType.VarChar,500),
					new SqlParameter("@PropertyValueString3", SqlDbType.VarChar,1000),
					new SqlParameter("@PropertyValueString4", SqlDbType.VarChar,2000),
					new SqlParameter("@PropertyValueString5", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.PropertyValueName;
            parameters[1].Value = model.PropertyValueOrderNumber;
            parameters[2].Value = model.PropertyValueNumber1;
            parameters[3].Value = model.PropertyValueNumber2;
            parameters[4].Value = model.PropertyValueNumber3;
            parameters[5].Value = model.PropertyValueNumber4;
            parameters[6].Value = model.PropertyValueString1;
            parameters[7].Value = model.PropertyValueString2;
            parameters[8].Value = model.PropertyValueString3;
            parameters[9].Value = model.PropertyValueString4;
            parameters[10].Value = model.PropertyValueString5;

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
        public bool Update(Tellyes.Model.PropertyValue model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PropertyValue set ");
            strSql.Append("PropertyValueName=@PropertyValueName,");
            strSql.Append("PropertyValueOrderNumber=@PropertyValueOrderNumber,");
            strSql.Append("PropertyValueNumber1=@PropertyValueNumber1,");
            strSql.Append("PropertyValueNumber2=@PropertyValueNumber2,");
            strSql.Append("PropertyValueNumber3=@PropertyValueNumber3,");
            strSql.Append("PropertyValueNumber4=@PropertyValueNumber4,");
            strSql.Append("PropertyValueString1=@PropertyValueString1,");
            strSql.Append("PropertyValueString2=@PropertyValueString2,");
            strSql.Append("PropertyValueString3=@PropertyValueString3,");
            strSql.Append("PropertyValueString4=@PropertyValueString4,");
            strSql.Append("PropertyValueString5=@PropertyValueString5");
            strSql.Append(" where PropertyValueID=@PropertyValueID");
            SqlParameter[] parameters = {
					new SqlParameter("@PropertyValueName", SqlDbType.NVarChar,200),
					new SqlParameter("@PropertyValueOrderNumber", SqlDbType.VarChar,-1),
					new SqlParameter("@PropertyValueNumber1", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber2", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber3", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueNumber4", SqlDbType.Int,4),
					new SqlParameter("@PropertyValueString1", SqlDbType.VarChar,50),
					new SqlParameter("@PropertyValueString2", SqlDbType.VarChar,500),
					new SqlParameter("@PropertyValueString3", SqlDbType.VarChar,1000),
					new SqlParameter("@PropertyValueString4", SqlDbType.VarChar,2000),
					new SqlParameter("@PropertyValueString5", SqlDbType.VarChar,-1),
					new SqlParameter("@PropertyValueID", SqlDbType.Int,4)};
            parameters[0].Value = model.PropertyValueName;
            parameters[1].Value = model.PropertyValueOrderNumber;
            parameters[2].Value = model.PropertyValueNumber1;
            parameters[3].Value = model.PropertyValueNumber2;
            parameters[4].Value = model.PropertyValueNumber3;
            parameters[5].Value = model.PropertyValueNumber4;
            parameters[6].Value = model.PropertyValueString1;
            parameters[7].Value = model.PropertyValueString2;
            parameters[8].Value = model.PropertyValueString3;
            parameters[9].Value = model.PropertyValueString4;
            parameters[10].Value = model.PropertyValueString5;
            parameters[11].Value = model.PropertyValueID;

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
        public bool Delete(int PropertyValueID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PropertyValue ");
            strSql.Append(" where PropertyValueID=@PropertyValueID");
            SqlParameter[] parameters = {
					new SqlParameter("@PropertyValueID", SqlDbType.Int,4)
			};
            parameters[0].Value = PropertyValueID;

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
        public bool DeleteList(string PropertyValueIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PropertyValue ");
            strSql.Append(" where PropertyValueID in (" + PropertyValueIDlist + ")  ");
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
        public Tellyes.Model.PropertyValue GetModel(int PropertyValueID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PropertyValueID,PropertyValueName,PropertyValueOrderNumber,PropertyValueNumber1,PropertyValueNumber2,PropertyValueNumber3,PropertyValueNumber4,PropertyValueString1,PropertyValueString2,PropertyValueString3,PropertyValueString4,PropertyValueString5 from PropertyValue ");
            strSql.Append(" where PropertyValueID=@PropertyValueID");
            SqlParameter[] parameters = {
					new SqlParameter("@PropertyValueID", SqlDbType.Int,4)
			};
            parameters[0].Value = PropertyValueID;

            Tellyes.Model.PropertyValue model = new Tellyes.Model.PropertyValue();
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
        public Tellyes.Model.PropertyValue DataRowToModel(DataRow row)
        {
            Tellyes.Model.PropertyValue model = new Tellyes.Model.PropertyValue();
            if (row != null)
            {
                if (row["PropertyValueID"] != null && row["PropertyValueID"].ToString() != "")
                {
                    model.PropertyValueID = int.Parse(row["PropertyValueID"].ToString());
                }
                if (row["PropertyValueName"] != null)
                {
                    model.PropertyValueName = row["PropertyValueName"].ToString();
                }
                if (row["PropertyValueOrderNumber"] != null)
                {
                    model.PropertyValueOrderNumber = row["PropertyValueOrderNumber"].ToString();
                }
                if (row["PropertyValueNumber1"] != null && row["PropertyValueNumber1"].ToString() != "")
                {
                    model.PropertyValueNumber1 = int.Parse(row["PropertyValueNumber1"].ToString());
                }
                if (row["PropertyValueNumber2"] != null && row["PropertyValueNumber2"].ToString() != "")
                {
                    model.PropertyValueNumber2 = int.Parse(row["PropertyValueNumber2"].ToString());
                }
                if (row["PropertyValueNumber3"] != null && row["PropertyValueNumber3"].ToString() != "")
                {
                    model.PropertyValueNumber3 = int.Parse(row["PropertyValueNumber3"].ToString());
                }
                if (row["PropertyValueNumber4"] != null && row["PropertyValueNumber4"].ToString() != "")
                {
                    model.PropertyValueNumber4 = int.Parse(row["PropertyValueNumber4"].ToString());
                }
                if (row["PropertyValueString1"] != null)
                {
                    model.PropertyValueString1 = row["PropertyValueString1"].ToString();
                }
                if (row["PropertyValueString2"] != null)
                {
                    model.PropertyValueString2 = row["PropertyValueString2"].ToString();
                }
                if (row["PropertyValueString3"] != null)
                {
                    model.PropertyValueString3 = row["PropertyValueString3"].ToString();
                }
                if (row["PropertyValueString4"] != null)
                {
                    model.PropertyValueString4 = row["PropertyValueString4"].ToString();
                }
                if (row["PropertyValueString5"] != null)
                {
                    model.PropertyValueString5 = row["PropertyValueString5"].ToString();
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
            strSql.Append("select PropertyValueID,PropertyValueName,PropertyValueOrderNumber,PropertyValueNumber1,PropertyValueNumber2,PropertyValueNumber3,PropertyValueNumber4,PropertyValueString1,PropertyValueString2,PropertyValueString3,PropertyValueString4,PropertyValueString5 ");
            strSql.Append(" FROM PropertyValue ");
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
            strSql.Append(" PropertyValueID,PropertyValueName,PropertyValueOrderNumber,PropertyValueNumber1,PropertyValueNumber2,PropertyValueNumber3,PropertyValueNumber4,PropertyValueString1,PropertyValueString2,PropertyValueString3,PropertyValueString4,PropertyValueString5 ");
            strSql.Append(" FROM PropertyValue ");
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
            strSql.Append("select count(1) FROM PropertyValue ");
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
                strSql.Append("order by T.PropertyValueID desc");
            }
            strSql.Append(")AS Row, T.*  from PropertyValue T ");
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
            parameters[0].Value = "PropertyValue";
            parameters[1].Value = "PropertyValueID";
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
            if (conditionDictionary.ContainsKey("UserPropertyID_Is"))
            {
                criteria.Add(Restrictions.Eq("UserPropertyID", conditionDictionary["UserPropertyID_Is"]));
            }
            if (conditionDictionary.ContainsKey("PropertyValueName_Is"))
            {
                criteria.Add(Restrictions.Eq("PropertyValueName", conditionDictionary["PropertyValueName_Is"]));
            }
            if (conditionDictionary.ContainsKey("PropertyValueId_In"))
            {
                criteria.Add(Restrictions.In("PropertyValueID", (List<int>)conditionDictionary["PropertyValueId_In"]));
            }
            return criteria;
        }
        #endregion  ExtensionMethod    
    }
}
