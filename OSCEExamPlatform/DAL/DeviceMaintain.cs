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

namespace Tellyes.DAL
{
    //设备维修表
    public partial class DeviceMaintain : BaseDAL<Tellyes.Model.DeviceMaintain>
    {

        public bool Exists(int DM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceMaintain");
            strSql.Append(" where ");
            strSql.Append(" DM_ID = @DM_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@DM_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DM_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceMaintain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceMaintain(");
            strSql.Append("DM_ID,DM_ContactPersonCompany,DM_ContactPerson,DM_ContactPersonPhone,DM_Number1,DM_Number2,DM_Number3,DM_Number4,DM_String1,DM_String2,DM_String3,D_ID,DM_String4,DM_String5,DM_StartTime,DM_EndTime,DM_TimeSpan,DM_Reason,DM_Result,DM_Fee,DM_Content");
            strSql.Append(") values (");
            strSql.Append("@DM_ID,@DM_ContactPersonCompany,@DM_ContactPerson,@DM_ContactPersonPhone,@DM_Number1,@DM_Number2,@DM_Number3,@DM_Number4,@DM_String1,@DM_String2,@DM_String3,@D_ID,@DM_String4,@DM_String5,@DM_StartTime,@DM_EndTime,@DM_TimeSpan,@DM_Reason,@DM_Result,@DM_Fee,@DM_Content");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DM_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_ContactPersonCompany", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_ContactPerson", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_ContactPersonPhone", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DM_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DM_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DM_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@DM_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DM_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DM_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Reason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DM_Result", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Fee", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Content", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DM_ID;
            parameters[1].Value = model.DM_ContactPersonCompany;
            parameters[2].Value = model.DM_ContactPerson;
            parameters[3].Value = model.DM_ContactPersonPhone;
            parameters[4].Value = model.DM_Number1;
            parameters[5].Value = model.DM_Number2;
            parameters[6].Value = model.DM_Number3;
            parameters[7].Value = model.DM_Number4;
            parameters[8].Value = model.DM_String1;
            parameters[9].Value = model.DM_String2;
            parameters[10].Value = model.DM_String3;
            parameters[11].Value = model.D_ID;
            parameters[12].Value = model.DM_String4;
            parameters[13].Value = model.DM_String5;
            parameters[14].Value = model.DM_StartTime;
            parameters[15].Value = model.DM_EndTime;
            parameters[16].Value = model.DM_TimeSpan;
            parameters[17].Value = model.DM_Reason;
            parameters[18].Value = model.DM_Result;
            parameters[19].Value = model.DM_Fee;
            parameters[20].Value = model.DM_Content;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceMaintain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceMaintain set ");

            strSql.Append(" DM_ID = @DM_ID , ");
            strSql.Append(" DM_ContactPersonCompany = @DM_ContactPersonCompany , ");
            strSql.Append(" DM_ContactPerson = @DM_ContactPerson , ");
            strSql.Append(" DM_ContactPersonPhone = @DM_ContactPersonPhone , ");
            strSql.Append(" DM_Number1 = @DM_Number1 , ");
            strSql.Append(" DM_Number2 = @DM_Number2 , ");
            strSql.Append(" DM_Number3 = @DM_Number3 , ");
            strSql.Append(" DM_Number4 = @DM_Number4 , ");
            strSql.Append(" DM_String1 = @DM_String1 , ");
            strSql.Append(" DM_String2 = @DM_String2 , ");
            strSql.Append(" DM_String3 = @DM_String3 , ");
            strSql.Append(" D_ID = @D_ID , ");
            strSql.Append(" DM_String4 = @DM_String4 , ");
            strSql.Append(" DM_String5 = @DM_String5 , ");
            strSql.Append(" DM_StartTime = @DM_StartTime , ");
            strSql.Append(" DM_EndTime = @DM_EndTime , ");
            strSql.Append(" DM_TimeSpan = @DM_TimeSpan , ");
            strSql.Append(" DM_Reason = @DM_Reason , ");
            strSql.Append(" DM_Result = @DM_Result , ");
            strSql.Append(" DM_Fee = @DM_Fee , ");
            strSql.Append(" DM_Content = @DM_Content  ");
            strSql.Append(" where DM_ID=@DM_ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DM_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_ContactPersonCompany", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_ContactPerson", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_ContactPersonPhone", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DM_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DM_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DM_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@DM_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DM_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DM_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DM_Reason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@DM_Result", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Fee", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@DM_Content", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.DM_ID;
            parameters[1].Value = model.DM_ContactPersonCompany;
            parameters[2].Value = model.DM_ContactPerson;
            parameters[3].Value = model.DM_ContactPersonPhone;
            parameters[4].Value = model.DM_Number1;
            parameters[5].Value = model.DM_Number2;
            parameters[6].Value = model.DM_Number3;
            parameters[7].Value = model.DM_Number4;
            parameters[8].Value = model.DM_String1;
            parameters[9].Value = model.DM_String2;
            parameters[10].Value = model.DM_String3;
            parameters[11].Value = model.D_ID;
            parameters[12].Value = model.DM_String4;
            parameters[13].Value = model.DM_String5;
            parameters[14].Value = model.DM_StartTime;
            parameters[15].Value = model.DM_EndTime;
            parameters[16].Value = model.DM_TimeSpan;
            parameters[17].Value = model.DM_Reason;
            parameters[18].Value = model.DM_Result;
            parameters[19].Value = model.DM_Fee;
            parameters[20].Value = model.DM_Content;
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
        public bool Delete(int DM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceMaintain ");
            strSql.Append(" where DM_ID=@DM_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DM_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DM_ID;


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
        public Tellyes.Model.DeviceMaintain GetModel(int DM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DM_ID, DM_ContactPersonCompany, DM_ContactPerson, DM_ContactPersonPhone, DM_Number1, DM_Number2, DM_Number3, DM_Number4, DM_String1, DM_String2, DM_String3, D_ID, DM_String4, DM_String5, DM_StartTime, DM_EndTime, DM_TimeSpan, DM_Reason, DM_Result, DM_Fee, DM_Content  ");
            strSql.Append("  from DeviceMaintain ");
            strSql.Append(" where DM_ID=@DM_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@DM_ID", SqlDbType.Int,4)			};
            parameters[0].Value = DM_ID;


            Tellyes.Model.DeviceMaintain model = new Tellyes.Model.DeviceMaintain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DM_ID"].ToString() != "")
                {
                    model.DM_ID = int.Parse(ds.Tables[0].Rows[0]["DM_ID"].ToString());
                }
                model.DM_ContactPersonCompany = ds.Tables[0].Rows[0]["DM_ContactPersonCompany"].ToString();
                model.DM_ContactPerson = ds.Tables[0].Rows[0]["DM_ContactPerson"].ToString();
                model.DM_ContactPersonPhone = ds.Tables[0].Rows[0]["DM_ContactPersonPhone"].ToString();
                if (ds.Tables[0].Rows[0]["DM_Number1"].ToString() != "")
                {
                    model.DM_Number1 = int.Parse(ds.Tables[0].Rows[0]["DM_Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DM_Number2"].ToString() != "")
                {
                    model.DM_Number2 = int.Parse(ds.Tables[0].Rows[0]["DM_Number2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DM_Number3"].ToString() != "")
                {
                    model.DM_Number3 = int.Parse(ds.Tables[0].Rows[0]["DM_Number3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DM_Number4"].ToString() != "")
                {
                    model.DM_Number4 = int.Parse(ds.Tables[0].Rows[0]["DM_Number4"].ToString());
                }
                model.DM_String1 = ds.Tables[0].Rows[0]["DM_String1"].ToString();
                model.DM_String2 = ds.Tables[0].Rows[0]["DM_String2"].ToString();
                model.DM_String3 = ds.Tables[0].Rows[0]["DM_String3"].ToString();
                if (ds.Tables[0].Rows[0]["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(ds.Tables[0].Rows[0]["D_ID"].ToString());
                }
                model.DM_String4 = ds.Tables[0].Rows[0]["DM_String4"].ToString();
                model.DM_String5 = ds.Tables[0].Rows[0]["DM_String5"].ToString();
                if (ds.Tables[0].Rows[0]["DM_StartTime"].ToString() != "")
                {
                    model.DM_StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["DM_StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DM_EndTime"].ToString() != "")
                {
                    model.DM_EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["DM_EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DM_TimeSpan"].ToString() != "")
                {
                    model.DM_TimeSpan = int.Parse(ds.Tables[0].Rows[0]["DM_TimeSpan"].ToString());
                }
                model.DM_Reason = ds.Tables[0].Rows[0]["DM_Reason"].ToString();
                model.DM_Result = ds.Tables[0].Rows[0]["DM_Result"].ToString();
                model.DM_Fee = ds.Tables[0].Rows[0]["DM_Fee"].ToString();
                model.DM_Content = ds.Tables[0].Rows[0]["DM_Content"].ToString();

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
            strSql.Append(" FROM DeviceMaintain ");
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
            strSql.Append(" FROM DeviceMaintain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            //查询等于设备编号的设备
            if (conditionDictionary.ContainsKey("D_ID="))
            {
                criteria.Add(Restrictions.IsNotNull("D_ID"));
                criteria.Add(Restrictions.Eq("D_ID", (int)conditionDictionary["D_ID="]));
            }
            //查询等于设备编号的设备
            if (conditionDictionary.ContainsKey("DM_EndTime=Null"))
            {
                criteria.Add(Restrictions.IsNull("DM_EndTime"));
            }
            return criteria;
        }

    }
}
