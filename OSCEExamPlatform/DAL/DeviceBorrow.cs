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
    public class DeviceBorrow : BaseDAL<Tellyes.Model.DeviceBorrow>
    {
        public bool Exists(int DB_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceBorrow");
            strSql.Append(" where ");
            strSql.Append(" DB_ID = @DB_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@DB_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DB_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceBorrow model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceBorrow(");
            strSql.Append("DB_ID,DB_ReturnState,DB_OperatePersonID,DB_OperatePersonName,DB_Number1,DB_Number2,DB_Number3,DB_Number4,DB_String1,DB_String2,DB_String3,D_ID,DB_String4,DB_String5,DB_StartTime,DB_EndTime,DB_TimeSpan,DB_Reason,DB_ContactPersonCompany,DB_ContactPerson,DB_ContactPersonPhone");
            strSql.Append(") values (");
            strSql.Append("@DB_ID,@DB_ReturnState,@DB_OperatePersonID,@DB_OperatePersonName,@DB_Number1,@DB_Number2,@DB_Number3,@DB_Number4,@DB_String1,@DB_String2,@DB_String3,@D_ID,@DB_String4,@DB_String5,@DB_StartTime,@DB_EndTime,@DB_TimeSpan,@DB_Reason,@DB_ContactPersonCompany,@DB_ContactPerson,@DB_ContactPersonPhone");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DB_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_ReturnState", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@DB_OperatePersonID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_OperatePersonName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DB_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DB_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DB_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DB_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@DB_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DB_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DB_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Reason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DB_ContactPersonCompany", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@DB_ContactPerson", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DB_ContactPersonPhone", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DB_ID;
            parameters[1].Value = model.DB_ReturnState;
            parameters[2].Value = model.DB_OperatePersonID;
            parameters[3].Value = model.DB_OperatePersonName;
            parameters[4].Value = model.DB_Number1;
            parameters[5].Value = model.DB_Number2;
            parameters[6].Value = model.DB_Number3;
            parameters[7].Value = model.DB_Number4;
            parameters[8].Value = model.DB_String1;
            parameters[9].Value = model.DB_String2;
            parameters[10].Value = model.DB_String3;
            parameters[11].Value = model.D_ID;
            parameters[12].Value = model.DB_String4;
            parameters[13].Value = model.DB_String5;
            parameters[14].Value = model.DB_StartTime;
            parameters[15].Value = model.DB_EndTime;
            parameters[16].Value = model.DB_TimeSpan;
            parameters[17].Value = model.DB_Reason;
            parameters[18].Value = model.DB_ContactPersonCompany;
            parameters[19].Value = model.DB_ContactPerson;
            parameters[20].Value = model.DB_ContactPersonPhone;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceBorrow model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceBorrow set ");

            strSql.Append(" DB_ID = @DB_ID , ");
            strSql.Append(" DB_ReturnState = @DB_ReturnState , ");
            strSql.Append(" DB_OperatePersonID = @DB_OperatePersonID , ");
            strSql.Append(" DB_OperatePersonName = @DB_OperatePersonName , ");
            strSql.Append(" DB_Number1 = @DB_Number1 , ");
            strSql.Append(" DB_Number2 = @DB_Number2 , ");
            strSql.Append(" DB_Number3 = @DB_Number3 , ");
            strSql.Append(" DB_Number4 = @DB_Number4 , ");
            strSql.Append(" DB_String1 = @DB_String1 , ");
            strSql.Append(" DB_String2 = @DB_String2 , ");
            strSql.Append(" DB_String3 = @DB_String3 , ");
            strSql.Append(" D_ID = @D_ID , ");
            strSql.Append(" DB_String4 = @DB_String4 , ");
            strSql.Append(" DB_String5 = @DB_String5 , ");
            strSql.Append(" DB_StartTime = @DB_StartTime , ");
            strSql.Append(" DB_EndTime = @DB_EndTime , ");
            strSql.Append(" DB_TimeSpan = @DB_TimeSpan , ");
            strSql.Append(" DB_Reason = @DB_Reason , ");
            strSql.Append(" DB_ContactPersonCompany = @DB_ContactPersonCompany , ");
            strSql.Append(" DB_ContactPerson = @DB_ContactPerson , ");
            strSql.Append(" DB_ContactPersonPhone = @DB_ContactPersonPhone  ");
            strSql.Append(" where DB_ID=@DB_ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DB_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_ReturnState", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@DB_OperatePersonID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_OperatePersonName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DB_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DB_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DB_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DB_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@DB_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DB_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DB_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DB_Reason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DB_ContactPersonCompany", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@DB_ContactPerson", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DB_ContactPersonPhone", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DB_ID;
            parameters[1].Value = model.DB_ReturnState;
            parameters[2].Value = model.DB_OperatePersonID;
            parameters[3].Value = model.DB_OperatePersonName;
            parameters[4].Value = model.DB_Number1;
            parameters[5].Value = model.DB_Number2;
            parameters[6].Value = model.DB_Number3;
            parameters[7].Value = model.DB_Number4;
            parameters[8].Value = model.DB_String1;
            parameters[9].Value = model.DB_String2;
            parameters[10].Value = model.DB_String3;
            parameters[11].Value = model.D_ID;
            parameters[12].Value = model.DB_String4;
            parameters[13].Value = model.DB_String5;
            parameters[14].Value = model.DB_StartTime;
            parameters[15].Value = model.DB_EndTime;
            parameters[16].Value = model.DB_TimeSpan;
            parameters[17].Value = model.DB_Reason;
            parameters[18].Value = model.DB_ContactPersonCompany;
            parameters[19].Value = model.DB_ContactPerson;
            parameters[20].Value = model.DB_ContactPersonPhone;
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
        public bool Delete(int DB_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceBorrow ");
            strSql.Append(" where DB_ID=@DB_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DB_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DB_ID;


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
        public Tellyes.Model.DeviceBorrow GetModel(int DB_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DB_ID, DB_ReturnState, DB_OperatePersonID, DB_OperatePersonName, DB_Number1, DB_Number2, DB_Number3, DB_Number4, DB_String1, DB_String2, DB_String3, D_ID, DB_String4, DB_String5, DB_StartTime, DB_EndTime, DB_TimeSpan, DB_Reason, DB_ContactPersonCompany, DB_ContactPerson, DB_ContactPersonPhone  ");
            strSql.Append("  from DeviceBorrow ");
            strSql.Append(" where DB_ID=@DB_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DB_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DB_ID;


            Tellyes.Model.DeviceBorrow model = new Tellyes.Model.DeviceBorrow();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DB_ID"].ToString() != "")
                {
                    model.DB_ID = int.Parse(ds.Tables[0].Rows[0]["DB_ID"].ToString());
                }
                model.DB_ReturnState = ds.Tables[0].Rows[0]["DB_ReturnState"].ToString();
                if (ds.Tables[0].Rows[0]["DB_OperatePersonID"].ToString() != "")
                {
                    model.DB_OperatePersonID = int.Parse(ds.Tables[0].Rows[0]["DB_OperatePersonID"].ToString());
                }
                model.DB_OperatePersonName = ds.Tables[0].Rows[0]["DB_OperatePersonName"].ToString();
                if (ds.Tables[0].Rows[0]["DB_Number1"].ToString() != "")
                {
                    model.DB_Number1 = int.Parse(ds.Tables[0].Rows[0]["DB_Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DB_Number2"].ToString() != "")
                {
                    model.DB_Number2 = int.Parse(ds.Tables[0].Rows[0]["DB_Number2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DB_Number3"].ToString() != "")
                {
                    model.DB_Number3 = int.Parse(ds.Tables[0].Rows[0]["DB_Number3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DB_Number4"].ToString() != "")
                {
                    model.DB_Number4 = int.Parse(ds.Tables[0].Rows[0]["DB_Number4"].ToString());
                }
                model.DB_String1 = ds.Tables[0].Rows[0]["DB_String1"].ToString();
                model.DB_String2 = ds.Tables[0].Rows[0]["DB_String2"].ToString();
                model.DB_String3 = ds.Tables[0].Rows[0]["DB_String3"].ToString();
                if (ds.Tables[0].Rows[0]["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(ds.Tables[0].Rows[0]["D_ID"].ToString());
                }
                model.DB_String4 = ds.Tables[0].Rows[0]["DB_String4"].ToString();
                model.DB_String5 = ds.Tables[0].Rows[0]["DB_String5"].ToString();
                if (ds.Tables[0].Rows[0]["DB_StartTime"].ToString() != "")
                {
                    model.DB_StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["DB_StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DB_EndTime"].ToString() != "")
                {
                    model.DB_EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["DB_EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DB_TimeSpan"].ToString() != "")
                {
                    model.DB_TimeSpan = int.Parse(ds.Tables[0].Rows[0]["DB_TimeSpan"].ToString());
                }
                model.DB_Reason = ds.Tables[0].Rows[0]["DB_Reason"].ToString();
                model.DB_ContactPersonCompany = ds.Tables[0].Rows[0]["DB_ContactPersonCompany"].ToString();
                model.DB_ContactPerson = ds.Tables[0].Rows[0]["DB_ContactPerson"].ToString();
                model.DB_ContactPersonPhone = ds.Tables[0].Rows[0]["DB_ContactPersonPhone"].ToString();

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
            strSql.Append(" FROM DeviceBorrow ");
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
            strSql.Append(" FROM DeviceBorrow ");
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
           
            if (conditionDictionary.ContainsKey("DB_EndTime=Null"))
            {
                criteria.Add(Restrictions.IsNull("DB_EndTime"));               
            }
            return criteria;
        }
    }
}
