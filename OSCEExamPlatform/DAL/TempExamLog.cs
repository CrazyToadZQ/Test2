using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    public class TempExamLog : BaseDAL<Model.TempExamLog>
    {
        #region Base Method

        public bool Exists(int TempExamLogID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamLog");
            strSql.Append(" where ");
            strSql.Append(" TempExamLogID = @TempExamLogID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamLogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamLog(");
            strSql.Append("TempExamLogNumber3,TempExamLogNumber4,TempExamLogString1,TempExamLogString2,TempExamLogString3,TempExamLogString4,TempExamLogDatetime1,TempExamLogDatetime2,TempExamTableID,LogType,LogContent,LogDatetime,LogUserInfoID,LogUerInfoTrueName,TempExamLogNumber1,TempExamLogNumber2");
            strSql.Append(") values (");
            strSql.Append("@TempExamLogNumber3,@TempExamLogNumber4,@TempExamLogString1,@TempExamLogString2,@TempExamLogString3,@TempExamLogString4,@TempExamLogDatetime1,@TempExamLogDatetime2,@TempExamTableID,@LogType,@LogContent,@LogDatetime,@LogUserInfoID,@LogUerInfoTrueName,@TempExamLogNumber1,@TempExamLogNumber2");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamLogNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamLogNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamLogString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamLogString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamLogString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamLogString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamLogDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamLogDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@LogType", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@LogContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LogDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@LogUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@LogUerInfoTrueName", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamLogNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamLogNumber2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamLogNumber3;
            parameters[1].Value = model.TempExamLogNumber4;
            parameters[2].Value = model.TempExamLogString1;
            parameters[3].Value = model.TempExamLogString2;
            parameters[4].Value = model.TempExamLogString3;
            parameters[5].Value = model.TempExamLogString4;
            parameters[6].Value = model.TempExamLogDatetime1;
            parameters[7].Value = model.TempExamLogDatetime2;
            parameters[8].Value = Guid.NewGuid();
            parameters[9].Value = model.LogType;
            parameters[10].Value = model.LogContent;
            parameters[11].Value = model.LogDatetime;
            parameters[12].Value = model.LogUserInfoID;
            parameters[13].Value = model.LogUerInfoTrueName;
            parameters[14].Value = model.TempExamLogNumber1;
            parameters[15].Value = model.TempExamLogNumber2;

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
        public bool Update(Model.TempExamLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamLog set ");

            strSql.Append(" TempExamLogNumber3 = @TempExamLogNumber3 , ");
            strSql.Append(" TempExamLogNumber4 = @TempExamLogNumber4 , ");
            strSql.Append(" TempExamLogString1 = @TempExamLogString1 , ");
            strSql.Append(" TempExamLogString2 = @TempExamLogString2 , ");
            strSql.Append(" TempExamLogString3 = @TempExamLogString3 , ");
            strSql.Append(" TempExamLogString4 = @TempExamLogString4 , ");
            strSql.Append(" TempExamLogDatetime1 = @TempExamLogDatetime1 , ");
            strSql.Append(" TempExamLogDatetime2 = @TempExamLogDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" LogType = @LogType , ");
            strSql.Append(" LogContent = @LogContent , ");
            strSql.Append(" LogDatetime = @LogDatetime , ");
            strSql.Append(" LogUserInfoID = @LogUserInfoID , ");
            strSql.Append(" LogUerInfoTrueName = @LogUerInfoTrueName , ");
            strSql.Append(" TempExamLogNumber1 = @TempExamLogNumber1 , ");
            strSql.Append(" TempExamLogNumber2 = @TempExamLogNumber2  ");
            strSql.Append(" where TempExamLogID=@TempExamLogID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamLogID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamLogNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamLogNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamLogString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamLogString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamLogString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamLogString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamLogDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamLogDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@LogType", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@LogContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LogDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@LogUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@LogUerInfoTrueName", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@TempExamLogNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamLogNumber2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamLogID;
            parameters[1].Value = model.TempExamLogNumber3;
            parameters[2].Value = model.TempExamLogNumber4;
            parameters[3].Value = model.TempExamLogString1;
            parameters[4].Value = model.TempExamLogString2;
            parameters[5].Value = model.TempExamLogString3;
            parameters[6].Value = model.TempExamLogString4;
            parameters[7].Value = model.TempExamLogDatetime1;
            parameters[8].Value = model.TempExamLogDatetime2;
            parameters[9].Value = model.TempExamTableID;
            parameters[10].Value = model.LogType;
            parameters[11].Value = model.LogContent;
            parameters[12].Value = model.LogDatetime;
            parameters[13].Value = model.LogUserInfoID;
            parameters[14].Value = model.LogUerInfoTrueName;
            parameters[15].Value = model.TempExamLogNumber1;
            parameters[16].Value = model.TempExamLogNumber2;
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
        public bool Delete(int TempExamLogID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamLog ");
            strSql.Append(" where TempExamLogID=@TempExamLogID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamLogID;


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
        public bool DeleteList(string TempExamLogIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamLog ");
            strSql.Append(" where ID in (" + TempExamLogIDlist + ")  ");
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
        public Model.TempExamLog GetModel(int TempExamLogID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamLogID, TempExamLogNumber3, TempExamLogNumber4, TempExamLogString1, TempExamLogString2, TempExamLogString3, TempExamLogString4, TempExamLogDatetime1, TempExamLogDatetime2, TempExamTableID, LogType, LogContent, LogDatetime, LogUserInfoID, LogUerInfoTrueName, TempExamLogNumber1, TempExamLogNumber2  ");
            strSql.Append("  from TempExamLog ");
            strSql.Append(" where TempExamLogID=@TempExamLogID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamLogID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamLogID;


            Model.TempExamLog model = new Model.TempExamLog();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamLogID"].ToString() != "")
                {
                    model.TempExamLogID = int.Parse(ds.Tables[0].Rows[0]["TempExamLogID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLogNumber3"].ToString() != "")
                {
                    model.TempExamLogNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamLogNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLogNumber4"].ToString() != "")
                {
                    model.TempExamLogNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamLogNumber4"].ToString());
                }
                model.TempExamLogString1 = ds.Tables[0].Rows[0]["TempExamLogString1"].ToString();
                model.TempExamLogString2 = ds.Tables[0].Rows[0]["TempExamLogString2"].ToString();
                model.TempExamLogString3 = ds.Tables[0].Rows[0]["TempExamLogString3"].ToString();
                model.TempExamLogString4 = ds.Tables[0].Rows[0]["TempExamLogString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamLogDatetime1"].ToString() != "")
                {
                    model.TempExamLogDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamLogDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLogDatetime2"].ToString() != "")
                {
                    model.TempExamLogDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamLogDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                model.LogType = ds.Tables[0].Rows[0]["LogType"].ToString();
                model.LogContent = ds.Tables[0].Rows[0]["LogContent"].ToString();
                if (ds.Tables[0].Rows[0]["LogDatetime"].ToString() != "")
                {
                    model.LogDatetime = DateTime.Parse(ds.Tables[0].Rows[0]["LogDatetime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LogUserInfoID"].ToString() != "")
                {
                    model.LogUserInfoID = int.Parse(ds.Tables[0].Rows[0]["LogUserInfoID"].ToString());
                }
                model.LogUerInfoTrueName = ds.Tables[0].Rows[0]["LogUerInfoTrueName"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamLogNumber1"].ToString() != "")
                {
                    model.TempExamLogNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamLogNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLogNumber2"].ToString() != "")
                {
                    model.TempExamLogNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamLogNumber2"].ToString());
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
            strSql.Append(" FROM TempExamLog ");
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
            strSql.Append(" FROM TempExamLog ");
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
            return criteria;
        }

        #endregion
    }
}
