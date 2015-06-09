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

namespace Tellyes.DAL
{
    //设备异常表
    public partial class DeviceException : BaseDAL<Tellyes.Model.DeviceException>
    {

        public bool Exists(int DE_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceException");
            strSql.Append(" where ");
            strSql.Append(" DE_ID = @DE_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@DE_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DE_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceException model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceException(");
            strSql.Append("DE_ID,DE_Number4,DE_String1,DE_String2,DE_String3,DE_String4,DE_String5,D_ID,DE_StartTime,DE_EndTime,DE_TimeSpan,DE_Description,DE_Number1,DE_Number2,DE_Number3");
            strSql.Append(") values (");
            strSql.Append("@DE_ID,@DE_Number4,@DE_String1,@DE_String2,@DE_String3,@DE_String4,@DE_String5,@D_ID,@DE_StartTime,@DE_EndTime,@DE_TimeSpan,@DE_Description,@DE_Number1,@DE_Number2,@DE_Number3");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DE_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DE_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DE_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@DE_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DE_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DE_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DE_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Description", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DE_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number3", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.DE_ID;
            parameters[1].Value = model.DE_Number4;
            parameters[2].Value = model.DE_String1;
            parameters[3].Value = model.DE_String2;
            parameters[4].Value = model.DE_String3;
            parameters[5].Value = model.DE_String4;
            parameters[6].Value = model.DE_String5;
            parameters[7].Value = model.D_ID;
            parameters[8].Value = model.DE_StartTime;
            parameters[9].Value = model.DE_EndTime;
            parameters[10].Value = model.DE_TimeSpan;
            parameters[11].Value = model.DE_Description;
            parameters[12].Value = model.DE_Number1;
            parameters[13].Value = model.DE_Number2;
            parameters[14].Value = model.DE_Number3;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceException model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceException set ");

            strSql.Append(" DE_ID = @DE_ID , ");
            strSql.Append(" DE_Number4 = @DE_Number4 , ");
            strSql.Append(" DE_String1 = @DE_String1 , ");
            strSql.Append(" DE_String2 = @DE_String2 , ");
            strSql.Append(" DE_String3 = @DE_String3 , ");
            strSql.Append(" DE_String4 = @DE_String4 , ");
            strSql.Append(" DE_String5 = @DE_String5 , ");
            strSql.Append(" D_ID = @D_ID , ");
            strSql.Append(" DE_StartTime = @DE_StartTime , ");
            strSql.Append(" DE_EndTime = @DE_EndTime , ");
            strSql.Append(" DE_TimeSpan = @DE_TimeSpan , ");
            strSql.Append(" DE_Description = @DE_Description , ");
            strSql.Append(" DE_Number1 = @DE_Number1 , ");
            strSql.Append(" DE_Number2 = @DE_Number2 , ");
            strSql.Append(" DE_Number3 = @DE_Number3  ");
            strSql.Append(" where DE_ID=@DE_ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DE_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DE_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DE_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@DE_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DE_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DE_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DE_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Description", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DE_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DE_Number3", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.DE_ID;
            parameters[1].Value = model.DE_Number4;
            parameters[2].Value = model.DE_String1;
            parameters[3].Value = model.DE_String2;
            parameters[4].Value = model.DE_String3;
            parameters[5].Value = model.DE_String4;
            parameters[6].Value = model.DE_String5;
            parameters[7].Value = model.D_ID;
            parameters[8].Value = model.DE_StartTime;
            parameters[9].Value = model.DE_EndTime;
            parameters[10].Value = model.DE_TimeSpan;
            parameters[11].Value = model.DE_Description;
            parameters[12].Value = model.DE_Number1;
            parameters[13].Value = model.DE_Number2;
            parameters[14].Value = model.DE_Number3;
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
        public bool Delete(int DE_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceException ");
            strSql.Append(" where DE_ID=@DE_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DE_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DE_ID;


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
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceException GetModel(int DE_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DE_ID, DE_Number4, DE_String1, DE_String2, DE_String3, DE_String4, DE_String5, D_ID, DE_StartTime, DE_EndTime, DE_TimeSpan, DE_Description, DE_Number1, DE_Number2, DE_Number3  ");
            strSql.Append("  from DeviceException ");
            strSql.Append(" where DE_ID=@DE_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DE_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DE_ID;


            Tellyes.Model.DeviceException model = new Tellyes.Model.DeviceException();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DE_ID"].ToString() != "")
                {
                    model.DE_ID = int.Parse(ds.Tables[0].Rows[0]["DE_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_Number4"].ToString() != "")
                {
                    model.DE_Number4 = int.Parse(ds.Tables[0].Rows[0]["DE_Number4"].ToString());
                }
                model.DE_String1 = ds.Tables[0].Rows[0]["DE_String1"].ToString();
                model.DE_String2 = ds.Tables[0].Rows[0]["DE_String2"].ToString();
                model.DE_String3 = ds.Tables[0].Rows[0]["DE_String3"].ToString();
                model.DE_String4 = ds.Tables[0].Rows[0]["DE_String4"].ToString();
                model.DE_String5 = ds.Tables[0].Rows[0]["DE_String5"].ToString();
                if (ds.Tables[0].Rows[0]["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(ds.Tables[0].Rows[0]["D_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_StartTime"].ToString() != "")
                {
                    model.DE_StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["DE_StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_EndTime"].ToString() != "")
                {
                    model.DE_EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["DE_EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_TimeSpan"].ToString() != "")
                {
                    model.DE_TimeSpan = int.Parse(ds.Tables[0].Rows[0]["DE_TimeSpan"].ToString());
                }
                model.DE_Description = ds.Tables[0].Rows[0]["DE_Description"].ToString();
                if (ds.Tables[0].Rows[0]["DE_Number1"].ToString() != "")
                {
                    model.DE_Number1 = int.Parse(ds.Tables[0].Rows[0]["DE_Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_Number2"].ToString() != "")
                {
                    model.DE_Number2 = int.Parse(ds.Tables[0].Rows[0]["DE_Number2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DE_Number3"].ToString() != "")
                {
                    model.DE_Number3 = int.Parse(ds.Tables[0].Rows[0]["DE_Number3"].ToString());
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
            strSql.Append(" FROM DeviceException ");
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
            strSql.Append(" FROM DeviceException ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            
            if (conditionDictionary.ContainsKey("D_ID="))
            {
                criteria.Add(Restrictions.IsNotNull("D_ID"));
                criteria.Add(Restrictions.Eq("D_ID", (int)conditionDictionary["D_ID="]));
            }

            if (conditionDictionary.ContainsKey("DE_EndTime=Null"))
            {
                criteria.Add(Restrictions.IsNull("DE_EndTime"));
            }
            return criteria;
        }
    }
}
