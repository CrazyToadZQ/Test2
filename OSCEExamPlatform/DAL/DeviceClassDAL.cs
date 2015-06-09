using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using Tellyes.Model;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    public class DeviceClassDAL : BaseDAL<DeviceClass>
    {
        #region Basic
        public bool Exists(int DC_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceClass");
            strSql.Append(" where ");
            strSql.Append(" DC_ID = @DC_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DC_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceClass(");
            strSql.Append("DC_Name,DC_ParentID,DC_Content,DC_IsValid,DC_int,DC_string");
            strSql.Append(") values (");
            strSql.Append("@DC_Name,@DC_ParentID,@DC_Content,@DC_IsValid,@DC_int,@DC_string");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@DC_Name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DC_ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_Content", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@DC_IsValid", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_int", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_string", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DC_Name;
            parameters[1].Value = model.DC_ParentID;
            parameters[2].Value = model.DC_Content;
            parameters[3].Value = model.DC_IsValid;
            parameters[4].Value = model.DC_int;
            parameters[5].Value = model.DC_string;

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
        public bool Update(Model.DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceClass set ");

            strSql.Append(" DC_Name = @DC_Name , ");
            strSql.Append(" DC_ParentID = @DC_ParentID , ");
            strSql.Append(" DC_Content = @DC_Content , ");
            strSql.Append(" DC_IsValid = @DC_IsValid , ");
            strSql.Append(" DC_int = @DC_int , ");
            strSql.Append(" DC_string = @DC_string  ");
            strSql.Append(" where DC_ID=@DC_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_Name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DC_ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_Content", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@DC_IsValid", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_int", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_string", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DC_ID;
            parameters[1].Value = model.DC_Name;
            parameters[2].Value = model.DC_ParentID;
            parameters[3].Value = model.DC_Content;
            parameters[4].Value = model.DC_IsValid;
            parameters[5].Value = model.DC_int;
            parameters[6].Value = model.DC_string;
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
        public bool Delete(int DC_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceClass ");
            strSql.Append(" where DC_ID=@DC_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DC_ID;


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
        public bool DeleteList(string DC_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceClass ");
            strSql.Append(" where ID in (" + DC_IDlist + ")  ");
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
        public Model.DeviceClass GetModel(int DC_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DC_ID, DC_Name, DC_ParentID, DC_Content, DC_IsValid, DC_int, DC_string  ");
            strSql.Append("  from DeviceClass ");
            strSql.Append(" where DC_ID=@DC_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DC_ID;


            Model.DeviceClass model = new Model.DeviceClass();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DC_ID"].ToString() != "")
                {
                    model.DC_ID = int.Parse(ds.Tables[0].Rows[0]["DC_ID"].ToString());
                }
                model.DC_Name = ds.Tables[0].Rows[0]["DC_Name"].ToString();
                if (ds.Tables[0].Rows[0]["DC_ParentID"].ToString() != "")
                {
                    model.DC_ParentID = int.Parse(ds.Tables[0].Rows[0]["DC_ParentID"].ToString());
                }
                model.DC_Content = ds.Tables[0].Rows[0]["DC_Content"].ToString();
                if (ds.Tables[0].Rows[0]["DC_IsValid"].ToString() != "")
                {
                    model.DC_IsValid = int.Parse(ds.Tables[0].Rows[0]["DC_IsValid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DC_int"].ToString() != "")
                {
                    model.DC_int = int.Parse(ds.Tables[0].Rows[0]["DC_int"].ToString());
                }
                model.DC_string = ds.Tables[0].Rows[0]["DC_string"].ToString();

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
            strSql.Append(" FROM DeviceClass ");
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
            strSql.Append(" FROM DeviceClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region NHibernate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("DC_IsValid")) 
            {
                criteria.Add(Restrictions.Eq("DC_IsValid", conditionDictionary["DC_IsValid"]));
            }
            if (conditionDictionary.ContainsKey("DC_ParentID"))
            {
                criteria.Add(Restrictions.Eq("DC_ParentID", conditionDictionary["DC_ParentID"]));
            }
            if (conditionDictionary.ContainsKey("DC_Name,Eq"))
            {
                criteria.Add(Restrictions.Eq("DC_Name", conditionDictionary["DC_Name,Eq"]));
            }
            if (conditionDictionary.ContainsKey("DC_ParentID,Eq"))
            {
                criteria.Add(Restrictions.Eq("DC_ParentID", conditionDictionary["DC_ParentID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("DC_IsValid,Eq"))
            {
                criteria.Add(Restrictions.Eq("DC_IsValid", conditionDictionary["DC_IsValid,Eq"]));
            }
            if (conditionDictionary.ContainsKey("DC_ID,NotEq"))
            {
                criteria.Add(Restrictions.Not(Restrictions.Eq("DC_ID", conditionDictionary["DC_ID,NotEq"])));
            }
            if (conditionDictionary.ContainsKey("DC_ID,in")) {
                criteria.Add(Restrictions.In("DC_ID", (List<Int32>)conditionDictionary["DC_ID,in"]));
            }
            return criteria;
        }

        #endregion
    }
}
