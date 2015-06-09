using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public partial class OSCEStationExamRoom_DeviceClass : BaseDAL<Model.OSCEStationExamRoom_DeviceClass>
    {
        public OSCEStationExamRoom_DeviceClass()
        { }

        #region Basic Method
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OSCEStationExamRoom_DeviceClass");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.OSCEStationExamRoom_DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OSCEStationExamRoom_DeviceClass(");
            strSql.Append("E_ID,DC_ID,D_Count,ES_ID");
            strSql.Append(") values (");
            strSql.Append("@E_ID,@DC_ID,@D_Count,@ES_ID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@D_Count", SqlDbType.Int,4) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.DC_ID;
            parameters[2].Value = model.D_Count;
            parameters[3].Value = Guid.NewGuid();

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
        public bool Update(Tellyes.Model.OSCEStationExamRoom_DeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OSCEStationExamRoom_DeviceClass set ");

            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" DC_ID = @DC_ID , ");
            strSql.Append(" D_Count = @D_Count , ");
            strSql.Append(" ES_ID = @ES_ID  ");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@D_Count", SqlDbType.Int,4) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.DC_ID;
            parameters[3].Value = model.D_Count;
            parameters[4].Value = model.ES_ID;
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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEStationExamRoom_DeviceClass ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEStationExamRoom_DeviceClass ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public Tellyes.Model.OSCEStationExamRoom_DeviceClass GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, E_ID, DC_ID, D_Count, ES_ID  ");
            strSql.Append("  from OSCEStationExamRoom_DeviceClass ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


            Tellyes.Model.OSCEStationExamRoom_DeviceClass model = new Tellyes.Model.OSCEStationExamRoom_DeviceClass();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(ds.Tables[0].Rows[0]["E_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DC_ID"].ToString() != "")
                {
                    model.DC_ID = int.Parse(ds.Tables[0].Rows[0]["DC_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["D_Count"].ToString() != "")
                {
                    model.D_Count = int.Parse(ds.Tables[0].Rows[0]["D_Count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ES_ID"].ToString() != "")
                {
                    model.ES_ID = Guid.Parse(ds.Tables[0].Rows[0]["ES_ID"].ToString());
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
            strSql.Append(" FROM OSCEStationExamRoom_DeviceClass ");
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
            strSql.Append(" FROM OSCEStationExamRoom_DeviceClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region  ExtensionMethod
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }
        #endregion


    }
}
