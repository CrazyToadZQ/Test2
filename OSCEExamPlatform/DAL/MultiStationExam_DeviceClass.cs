using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class MultiStationExam_DeviceClass : BaseDAL<Model.MultiStationExam_DeviceClass>
    {
        #region Basic

        public bool Exists(int MSE_DC_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MultiStationExam_DeviceClass");
            strSql.Append(" where ");
            strSql.Append(" MSE_DC_ID = @MSE_DC_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@MSE_DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSE_DC_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MultiStationExam_DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MultiStationExam_DeviceClass(");
            strSql.Append("E_ID,ES_ID,Room_ID,DC_ID,DC_Count");
            strSql.Append(") values (");
            strSql.Append("@E_ID,@ES_ID,@Room_ID,@DC_ID,@DC_Count");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_Count", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.E_ID;
            parameters[1].Value = model.ES_ID;
            parameters[2].Value = model.Room_ID;
            parameters[3].Value = model.DC_ID;
            parameters[4].Value = model.DC_Count;

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
        public bool Update(Model.MultiStationExam_DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MultiStationExam_DeviceClass set ");

            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" ES_ID = @ES_ID , ");
            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" DC_ID = @DC_ID , ");
            strSql.Append(" DC_Count = @DC_Count  ");
            strSql.Append(" where MSE_DC_ID=@MSE_DC_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@MSE_DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_Count", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.MSE_DC_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.ES_ID;
            parameters[3].Value = model.Room_ID;
            parameters[4].Value = model.DC_ID;
            parameters[5].Value = model.DC_Count;
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
        public bool Delete(int MSE_DC_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExam_DeviceClass ");
            strSql.Append(" where MSE_DC_ID=@MSE_DC_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSE_DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSE_DC_ID;


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
        public bool DeleteList(string MSE_DC_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExam_DeviceClass ");
            strSql.Append(" where ID in (" + MSE_DC_IDlist + ")  ");
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
        public Model.MultiStationExam_DeviceClass GetModel(int MSE_DC_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MSE_DC_ID, E_ID, ES_ID, Room_ID, DC_ID, DC_Count  ");
            strSql.Append("  from MultiStationExam_DeviceClass ");
            strSql.Append(" where MSE_DC_ID=@MSE_DC_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSE_DC_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSE_DC_ID;


            Model.MultiStationExam_DeviceClass model = new Model.MultiStationExam_DeviceClass();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MSE_DC_ID"].ToString() != "")
                {
                    model.MSE_DC_ID = int.Parse(ds.Tables[0].Rows[0]["MSE_DC_ID"].ToString());
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
                if (ds.Tables[0].Rows[0]["DC_ID"].ToString() != "")
                {
                    model.DC_ID = int.Parse(ds.Tables[0].Rows[0]["DC_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DC_Count"].ToString() != "")
                {
                    model.DC_Count = int.Parse(ds.Tables[0].Rows[0]["DC_Count"].ToString());
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
            strSql.Append(" FROM MultiStationExam_DeviceClass ");
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
            strSql.Append(" FROM MultiStationExam_DeviceClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion

        #region Extension

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Like("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,eq"))
            {
                criteria.Add(Restrictions.Like("ES_ID", conditionDictionary["ES_ID,eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
