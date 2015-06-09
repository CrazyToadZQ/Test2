using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class TempExamStudent : BaseDAL<Model.TempExamStudent>
    {
        #region Base Method

        public bool Exists(Guid TempExamStudentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamStudent");
            strSql.Append(" where ");
            strSql.Append(" TempExamStudentID = @TempExamStudentID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStudentID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStudentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStudent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamStudent(");
            strSql.Append("TempExamStudentID,TempExamStudentString2,TempExamStudentString3,TempExamStudentString4,TempExamStudentDatetime1,TempExamStudentDatetime2,TempExamTableID,UserInfoID,ExamNumber,TempExamStudentNumber1,TempExamStudentNumber2,TempExamStudentNumber3,TempExamStudentNumber4,TempExamStudentString1");
            strSql.Append(") values (");
            strSql.Append("@TempExamStudentID,@TempExamStudentString2,@TempExamStudentString3,@TempExamStudentString4,@TempExamStudentDatetime1,@TempExamStudentDatetime2,@TempExamTableID,@UserInfoID,@ExamNumber,@TempExamStudentNumber1,@TempExamStudentNumber2,@TempExamStudentNumber3,@TempExamStudentNumber4,@TempExamStudentString1");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStudentID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStudentString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStudentString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStudentString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStudentDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStudentDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStudentNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStudentString1", SqlDbType.NVarChar,1000)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.TempExamStudentString2;
            parameters[2].Value = model.TempExamStudentString3;
            parameters[3].Value = model.TempExamStudentString4;
            parameters[4].Value = model.TempExamStudentDatetime1;
            parameters[5].Value = model.TempExamStudentDatetime2;
            parameters[6].Value = Guid.NewGuid();
            parameters[7].Value = model.UserInfoID;
            parameters[8].Value = model.ExamNumber;
            parameters[9].Value = model.TempExamStudentNumber1;
            parameters[10].Value = model.TempExamStudentNumber2;
            parameters[11].Value = model.TempExamStudentNumber3;
            parameters[12].Value = model.TempExamStudentNumber4;
            parameters[13].Value = model.TempExamStudentString1;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStudent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamStudent set ");

            strSql.Append(" TempExamStudentID = @TempExamStudentID , ");
            strSql.Append(" TempExamStudentString2 = @TempExamStudentString2 , ");
            strSql.Append(" TempExamStudentString3 = @TempExamStudentString3 , ");
            strSql.Append(" TempExamStudentString4 = @TempExamStudentString4 , ");
            strSql.Append(" TempExamStudentDatetime1 = @TempExamStudentDatetime1 , ");
            strSql.Append(" TempExamStudentDatetime2 = @TempExamStudentDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" UserInfoID = @UserInfoID , ");
            strSql.Append(" ExamNumber = @ExamNumber , ");
            strSql.Append(" TempExamStudentNumber1 = @TempExamStudentNumber1 , ");
            strSql.Append(" TempExamStudentNumber2 = @TempExamStudentNumber2 , ");
            strSql.Append(" TempExamStudentNumber3 = @TempExamStudentNumber3 , ");
            strSql.Append(" TempExamStudentNumber4 = @TempExamStudentNumber4 , ");
            strSql.Append(" TempExamStudentString1 = @TempExamStudentString1  ");
            strSql.Append(" where TempExamStudentID=@TempExamStudentID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStudentID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStudentString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStudentString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStudentString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStudentDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStudentDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStudentNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStudentNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStudentString1", SqlDbType.NVarChar,1000)             
              
            };

            parameters[0].Value = model.TempExamStudentID;
            parameters[1].Value = model.TempExamStudentString2;
            parameters[2].Value = model.TempExamStudentString3;
            parameters[3].Value = model.TempExamStudentString4;
            parameters[4].Value = model.TempExamStudentDatetime1;
            parameters[5].Value = model.TempExamStudentDatetime2;
            parameters[6].Value = model.TempExamTableID;
            parameters[7].Value = model.UserInfoID;
            parameters[8].Value = model.ExamNumber;
            parameters[9].Value = model.TempExamStudentNumber1;
            parameters[10].Value = model.TempExamStudentNumber2;
            parameters[11].Value = model.TempExamStudentNumber3;
            parameters[12].Value = model.TempExamStudentNumber4;
            parameters[13].Value = model.TempExamStudentString1;
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
        public bool Delete(Guid TempExamStudentID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamStudent ");
            strSql.Append(" where TempExamStudentID=@TempExamStudentID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStudentID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStudentID;


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
        public Model.TempExamStudent GetModel(Guid TempExamStudentID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamStudentID, TempExamStudentString2, TempExamStudentString3, TempExamStudentString4, TempExamStudentDatetime1, TempExamStudentDatetime2, TempExamTableID, UserInfoID, ExamNumber, TempExamStudentNumber1, TempExamStudentNumber2, TempExamStudentNumber3, TempExamStudentNumber4, TempExamStudentString1  ");
            strSql.Append("  from TempExamStudent ");
            strSql.Append(" where TempExamStudentID=@TempExamStudentID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStudentID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStudentID;


            Model.TempExamStudent model = new Model.TempExamStudent();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamStudentID"].ToString() != "")
                {
                    model.TempExamStudentID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStudentID"].ToString());
                }
                model.TempExamStudentString2 = ds.Tables[0].Rows[0]["TempExamStudentString2"].ToString();
                model.TempExamStudentString3 = ds.Tables[0].Rows[0]["TempExamStudentString3"].ToString();
                model.TempExamStudentString4 = ds.Tables[0].Rows[0]["TempExamStudentString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamStudentDatetime1"].ToString() != "")
                {
                    model.TempExamStudentDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStudentDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentDatetime2"].ToString() != "")
                {
                    model.TempExamStudentDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStudentDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamNumber"].ToString() != "")
                {
                    model.ExamNumber = int.Parse(ds.Tables[0].Rows[0]["ExamNumber"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentNumber1"].ToString() != "")
                {
                    model.TempExamStudentNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamStudentNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentNumber2"].ToString() != "")
                {
                    model.TempExamStudentNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamStudentNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentNumber3"].ToString() != "")
                {
                    model.TempExamStudentNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStudentNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentNumber4"].ToString() != "")
                {
                    model.TempExamStudentNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStudentNumber4"].ToString());
                }
                model.TempExamStudentString1 = ds.Tables[0].Rows[0]["TempExamStudentString1"].ToString();

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
            strSql.Append(" FROM TempExamStudent ");
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
            strSql.Append(" FROM TempExamStudent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("TempExamTableID,EQ"))
            {
                criteria.Add(Restrictions.Eq("TempExamTableID", conditionDictionary["TempExamTableID,EQ"])); 
            }
            return criteria;
        }

        /// <summary>
        /// 查询指定TempExamStudentID的用户信息和组织机构信息，带条件查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelectUserInfoAndOrganizationByTempExamTableID(Dictionary<string, object> conditionDictionary)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [TempExamStudent].[TempExamStudentID], ")
                .Append("    [TempExamStudent].[ExamNumber], ")
                .Append("    [UserInfo].[U_ID], ")
                .Append("    [U_Name], ")
                .Append("    [U_TrueName], ")
                .Append("    [U_PWD], ")
                .Append("    [U_Sex], ")
                .Append("    [U_Phone], ")
                .Append("    [U_Phone2], ")
                .Append("    [U_Email], ")
                .Append("    [U_Email2], ")
                .Append("    [U_Contont], ")
                .Append("    [U_Photo], ")
                .Append("    [U_GoodField], ")
                .Append("    [UserInfo].[date1], ")
                .Append("    [UserInfo].[string1], ")
                .Append("    [U_Title], ")
                .Append("    [U_Ethnic], ")
                .Append("    [U_Education], ")
                .Append("    [U_InTime], ")
                .Append("    [U_Source], ")
                .Append("    [U_Unit], ")
                .Append("    [Organization].[O_ID], ")
                .Append("    [O_Name], ")
                .Append("    [O_Contont], ")
                .Append("    [O_ParentID], ")
                .Append("    [OL_ID] ")
                .Append("FROM ")
                .Append("   ( ")
                .Append("       [UserInfo] ")
                .Append("       INNER JOIN [UserRole] ")
                .Append("           ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                .Append("       INNER JOIN [Role] ")
                .Append("           ON [Role].[R_ID] = [UserRole].[R_ID] ")
                .Append("       INNER JOIN [TempExamStudent] ")
                .Append("           ON [TempExamStudent].[UserInfoID] = [UserInfo].[U_ID] ")
                .Append("   ) ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [Organization].[O_ID] = [UserOrganization].[O_ID] ")
                .Append("WHERE ")
                .Append("   1=1 ")
                .ToString();

            if (conditionDictionary.ContainsKey("TempExamStudentID"))
            {
                sql += " AND [TempExamStudent].[TempExamStudentID] IN (" + conditionDictionary["TempExamStudentID"] + ") ";
            }

            sql += " ORDER BY [TempExamStudent].[ExamNumber] ASC";

            DataTable result = new DataTable();

            try
            {
                result = DbHelperSQL.Query(sql.ToString()).Tables[0];
                return result;
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询单站考生的用户信息失败", e);
                return null;
            }
            finally
            {

            }
        }

        #endregion
    }
}
