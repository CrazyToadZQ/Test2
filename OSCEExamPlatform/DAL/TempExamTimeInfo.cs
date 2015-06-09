using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class TempExamTimeInfo : BaseDAL<Model.TempExamTimeInfo>
    {
        #region Base Method

        public bool Exists(int TempExamTimeInfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamTimeInfo");
            strSql.Append(" where ");
            strSql.Append(" TempExamTimeInfoID = @TempExamTimeInfoID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamTimeInfoID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamTimeInfo(");
            strSql.Append("TempExamTimeInfoNumber4,TempExamTimeInfoString1,TempExamTimeInfoString2,TempExamTimeInfoString3,TempExamTimeInfoString4,TempExamTimeInfoDatetime1,TempExamTimeInfoDatetime2,TempExamTableID,TempExamTimeInfoDate,TempExamTimeInfoStartTime,TempExamTimeInfoEndTime,TempExamTimeInfoStudentCount,TempExamTimeInfoNumber1,TempExamTimeInfoNumber2,TempExamTimeInfoNumber3");
            strSql.Append(") values (");
            strSql.Append("@TempExamTimeInfoNumber4,@TempExamTimeInfoString1,@TempExamTimeInfoString2,@TempExamTimeInfoString3,@TempExamTimeInfoString4,@TempExamTimeInfoDatetime1,@TempExamTimeInfoDatetime2,@TempExamTableID,@TempExamTimeInfoDate,@TempExamTimeInfoStartTime,@TempExamTimeInfoEndTime,@TempExamTimeInfoStudentCount,@TempExamTimeInfoNumber1,@TempExamTimeInfoNumber2,@TempExamTimeInfoNumber3");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamTimeInfoNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamTimeInfoString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamTimeInfoString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamTimeInfoString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamTimeInfoString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamTimeInfoDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTimeInfoDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamTimeInfoDate", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@TempExamTimeInfoStartTime", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamTimeInfoEndTime", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamTimeInfoStudentCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber3", SqlDbType.Decimal,13)             
              
            };

            parameters[0].Value = model.TempExamTimeInfoNumber4;
            parameters[1].Value = model.TempExamTimeInfoString1;
            parameters[2].Value = model.TempExamTimeInfoString2;
            parameters[3].Value = model.TempExamTimeInfoString3;
            parameters[4].Value = model.TempExamTimeInfoString4;
            parameters[5].Value = model.TempExamTimeInfoDatetime1;
            parameters[6].Value = model.TempExamTimeInfoDatetime2;
            parameters[7].Value = Guid.NewGuid();
            parameters[8].Value = model.TempExamTimeInfoDate;
            parameters[9].Value = model.TempExamTimeInfoStartTime;
            parameters[10].Value = model.TempExamTimeInfoEndTime;
            parameters[11].Value = model.TempExamTimeInfoStudentCount;
            parameters[12].Value = model.TempExamTimeInfoNumber1;
            parameters[13].Value = model.TempExamTimeInfoNumber2;
            parameters[14].Value = model.TempExamTimeInfoNumber3;

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
        public bool Update(Model.TempExamTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamTimeInfo set ");

            strSql.Append(" TempExamTimeInfoNumber4 = @TempExamTimeInfoNumber4 , ");
            strSql.Append(" TempExamTimeInfoString1 = @TempExamTimeInfoString1 , ");
            strSql.Append(" TempExamTimeInfoString2 = @TempExamTimeInfoString2 , ");
            strSql.Append(" TempExamTimeInfoString3 = @TempExamTimeInfoString3 , ");
            strSql.Append(" TempExamTimeInfoString4 = @TempExamTimeInfoString4 , ");
            strSql.Append(" TempExamTimeInfoDatetime1 = @TempExamTimeInfoDatetime1 , ");
            strSql.Append(" TempExamTimeInfoDatetime2 = @TempExamTimeInfoDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamTimeInfoDate = @TempExamTimeInfoDate , ");
            strSql.Append(" TempExamTimeInfoStartTime = @TempExamTimeInfoStartTime , ");
            strSql.Append(" TempExamTimeInfoEndTime = @TempExamTimeInfoEndTime , ");
            strSql.Append(" TempExamTimeInfoStudentCount = @TempExamTimeInfoStudentCount , ");
            strSql.Append(" TempExamTimeInfoNumber1 = @TempExamTimeInfoNumber1 , ");
            strSql.Append(" TempExamTimeInfoNumber2 = @TempExamTimeInfoNumber2 , ");
            strSql.Append(" TempExamTimeInfoNumber3 = @TempExamTimeInfoNumber3  ");
            strSql.Append(" where TempExamTimeInfoID=@TempExamTimeInfoID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamTimeInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamTimeInfoString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamTimeInfoString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamTimeInfoString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamTimeInfoString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamTimeInfoDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTimeInfoDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamTimeInfoDate", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@TempExamTimeInfoStartTime", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamTimeInfoEndTime", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamTimeInfoStudentCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamTimeInfoNumber3", SqlDbType.Decimal,13)             
              
            };

            parameters[0].Value = model.TempExamTimeInfoID;
            parameters[1].Value = model.TempExamTimeInfoNumber4;
            parameters[2].Value = model.TempExamTimeInfoString1;
            parameters[3].Value = model.TempExamTimeInfoString2;
            parameters[4].Value = model.TempExamTimeInfoString3;
            parameters[5].Value = model.TempExamTimeInfoString4;
            parameters[6].Value = model.TempExamTimeInfoDatetime1;
            parameters[7].Value = model.TempExamTimeInfoDatetime2;
            parameters[8].Value = model.TempExamTableID;
            parameters[9].Value = model.TempExamTimeInfoDate;
            parameters[10].Value = model.TempExamTimeInfoStartTime;
            parameters[11].Value = model.TempExamTimeInfoEndTime;
            parameters[12].Value = model.TempExamTimeInfoStudentCount;
            parameters[13].Value = model.TempExamTimeInfoNumber1;
            parameters[14].Value = model.TempExamTimeInfoNumber2;
            parameters[15].Value = model.TempExamTimeInfoNumber3;
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
        public bool Delete(int TempExamTimeInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamTimeInfo ");
            strSql.Append(" where TempExamTimeInfoID=@TempExamTimeInfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamTimeInfoID;


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
        public bool DeleteList(string TempExamTimeInfoIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamTimeInfo ");
            strSql.Append(" where ID in (" + TempExamTimeInfoIDlist + ")  ");
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
        public Model.TempExamTimeInfo GetModel(int TempExamTimeInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamTimeInfoID, TempExamTimeInfoNumber4, TempExamTimeInfoString1, TempExamTimeInfoString2, TempExamTimeInfoString3, TempExamTimeInfoString4, TempExamTimeInfoDatetime1, TempExamTimeInfoDatetime2, TempExamTableID, TempExamTimeInfoDate, TempExamTimeInfoStartTime, TempExamTimeInfoEndTime, TempExamTimeInfoStudentCount, TempExamTimeInfoNumber1, TempExamTimeInfoNumber2, TempExamTimeInfoNumber3  ");
            strSql.Append("  from TempExamTimeInfo ");
            strSql.Append(" where TempExamTimeInfoID=@TempExamTimeInfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamTimeInfoID;


            Model.TempExamTimeInfo model = new Model.TempExamTimeInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoID"].ToString() != "")
                {
                    model.TempExamTimeInfoID = int.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoNumber4"].ToString() != "")
                {
                    model.TempExamTimeInfoNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoNumber4"].ToString());
                }
                model.TempExamTimeInfoString1 = ds.Tables[0].Rows[0]["TempExamTimeInfoString1"].ToString();
                model.TempExamTimeInfoString2 = ds.Tables[0].Rows[0]["TempExamTimeInfoString2"].ToString();
                model.TempExamTimeInfoString3 = ds.Tables[0].Rows[0]["TempExamTimeInfoString3"].ToString();
                model.TempExamTimeInfoString4 = ds.Tables[0].Rows[0]["TempExamTimeInfoString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoDatetime1"].ToString() != "")
                {
                    model.TempExamTimeInfoDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoDatetime2"].ToString() != "")
                {
                    model.TempExamTimeInfoDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                model.TempExamTimeInfoDate = ds.Tables[0].Rows[0]["TempExamTimeInfoDate"].ToString();
                model.TempExamTimeInfoStartTime = ds.Tables[0].Rows[0]["TempExamTimeInfoStartTime"].ToString();
                model.TempExamTimeInfoEndTime = ds.Tables[0].Rows[0]["TempExamTimeInfoEndTime"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoStudentCount"].ToString() != "")
                {
                    model.TempExamTimeInfoStudentCount = int.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoStudentCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoNumber1"].ToString() != "")
                {
                    model.TempExamTimeInfoNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoNumber2"].ToString() != "")
                {
                    model.TempExamTimeInfoNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTimeInfoNumber3"].ToString() != "")
                {
                    model.TempExamTimeInfoNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamTimeInfoNumber3"].ToString());
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
            strSql.Append(" FROM TempExamTimeInfo ");
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
            strSql.Append(" FROM TempExamTimeInfo ");
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

        #endregion
    }
}
