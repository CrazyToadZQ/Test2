using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class ExamFeedback : BaseDAL<Model.ExamFeedback>
    {
        public ExamFeedback()
        { }

        #region Base Method
        public bool Exists(int ExamFeedbackID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamFeedback");
            strSql.Append(" where ");
            strSql.Append(" ExamFeedbackID = @ExamFeedbackID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamFeedbackID", SqlDbType.Int,4)
			};
            parameters[0].Value = ExamFeedbackID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamFeedback model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamFeedback(");
            strSql.Append("ExamFeedbackNumber2,ExamFeedbackString1,ExamFeedbackString2,UserInfoID,UserTrueName,ExamID,ExamName,RoleName,ExamFeedbackContent,ExamFeedbackDate,ExamFeedbackNumber1");
            strSql.Append(") values (");
            strSql.Append("@ExamFeedbackNumber2,@ExamFeedbackString1,@ExamFeedbackString2,@UserInfoID,@UserTrueName,@ExamID,@ExamName,@RoleName,@ExamFeedbackContent,@ExamFeedbackDate,@ExamFeedbackNumber1");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@ExamFeedbackNumber2", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ExamFeedbackString1", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@ExamFeedbackString2", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserTrueName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RoleName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamFeedbackContent", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@ExamFeedbackDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamFeedbackNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ExamFeedbackNumber2;
            parameters[1].Value = model.ExamFeedbackString1;
            parameters[2].Value = model.ExamFeedbackString2;
            parameters[3].Value = model.UserInfoID;
            parameters[4].Value = model.UserTrueName;
            parameters[5].Value = Guid.NewGuid();
            parameters[6].Value = model.ExamName;
            parameters[7].Value = model.RoleName;
            parameters[8].Value = model.ExamFeedbackContent;
            parameters[9].Value = model.ExamFeedbackDate;
            parameters[10].Value = model.ExamFeedbackNumber1;

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
        public bool Update(Tellyes.Model.ExamFeedback model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamFeedback set ");

            strSql.Append(" ExamFeedbackNumber2 = @ExamFeedbackNumber2 , ");
            strSql.Append(" ExamFeedbackString1 = @ExamFeedbackString1 , ");
            strSql.Append(" ExamFeedbackString2 = @ExamFeedbackString2 , ");
            strSql.Append(" UserInfoID = @UserInfoID , ");
            strSql.Append(" UserTrueName = @UserTrueName , ");
            strSql.Append(" ExamID = @ExamID , ");
            strSql.Append(" ExamName = @ExamName , ");
            strSql.Append(" RoleName = @RoleName , ");
            strSql.Append(" ExamFeedbackContent = @ExamFeedbackContent , ");
            strSql.Append(" ExamFeedbackDate = @ExamFeedbackDate , ");
            strSql.Append(" ExamFeedbackNumber1 = @ExamFeedbackNumber1  ");
            strSql.Append(" where ExamFeedbackID=@ExamFeedbackID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ExamFeedbackID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamFeedbackNumber2", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@ExamFeedbackString1", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@ExamFeedbackString2", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserTrueName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RoleName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamFeedbackContent", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@ExamFeedbackDate", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamFeedbackNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ExamFeedbackID;
            parameters[1].Value = model.ExamFeedbackNumber2;
            parameters[2].Value = model.ExamFeedbackString1;
            parameters[3].Value = model.ExamFeedbackString2;
            parameters[4].Value = model.UserInfoID;
            parameters[5].Value = model.UserTrueName;
            parameters[6].Value = model.ExamID;
            parameters[7].Value = model.ExamName;
            parameters[8].Value = model.RoleName;
            parameters[9].Value = model.ExamFeedbackContent;
            parameters[10].Value = model.ExamFeedbackDate;
            parameters[11].Value = model.ExamFeedbackNumber1;
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
        public bool Delete(int ExamFeedbackID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamFeedback ");
            strSql.Append(" where ExamFeedbackID=@ExamFeedbackID");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamFeedbackID", SqlDbType.Int,4)
			};
            parameters[0].Value = ExamFeedbackID;


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
        public bool DeleteList(string ExamFeedbackIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamFeedback ");
            strSql.Append(" where ID in (" + ExamFeedbackIDlist + ")  ");
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
        public Tellyes.Model.ExamFeedback GetModel(int ExamFeedbackID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ExamFeedbackID, ExamFeedbackNumber2, ExamFeedbackString1, ExamFeedbackString2, UserInfoID, UserTrueName, ExamID, ExamName, RoleName, ExamFeedbackContent, ExamFeedbackDate, ExamFeedbackNumber1  ");
            strSql.Append("  from ExamFeedback ");
            strSql.Append(" where ExamFeedbackID=@ExamFeedbackID");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamFeedbackID", SqlDbType.Int,4)
			};
            parameters[0].Value = ExamFeedbackID;


            Tellyes.Model.ExamFeedback model = new Tellyes.Model.ExamFeedback();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ExamFeedbackID"].ToString() != "")
                {
                    model.ExamFeedbackID = int.Parse(ds.Tables[0].Rows[0]["ExamFeedbackID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamFeedbackNumber2"].ToString() != "")
                {
                    model.ExamFeedbackNumber2 = decimal.Parse(ds.Tables[0].Rows[0]["ExamFeedbackNumber2"].ToString());
                }
                model.ExamFeedbackString1 = ds.Tables[0].Rows[0]["ExamFeedbackString1"].ToString();
                model.ExamFeedbackString2 = ds.Tables[0].Rows[0]["ExamFeedbackString2"].ToString();
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
                model.UserTrueName = ds.Tables[0].Rows[0]["UserTrueName"].ToString();
                if (ds.Tables[0].Rows[0]["ExamID"].ToString() != "")
                {
                    model.ExamID = Guid.Parse(ds.Tables[0].Rows[0]["ExamID"].ToString());
                }
                model.ExamName = ds.Tables[0].Rows[0]["ExamName"].ToString();
                model.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                model.ExamFeedbackContent = ds.Tables[0].Rows[0]["ExamFeedbackContent"].ToString();
                if (ds.Tables[0].Rows[0]["ExamFeedbackDate"].ToString() != "")
                {
                    model.ExamFeedbackDate = DateTime.Parse(ds.Tables[0].Rows[0]["ExamFeedbackDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamFeedbackNumber1"].ToString() != "")
                {
                    model.ExamFeedbackNumber1 = int.Parse(ds.Tables[0].Rows[0]["ExamFeedbackNumber1"].ToString());
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
            strSql.Append(" FROM ExamFeedback ");
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
            strSql.Append(" FROM ExamFeedback ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region NHibernate Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("U_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("UserInfoID", conditionDictionary["U_ID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("ExamID", conditionDictionary["E_ID,Eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
