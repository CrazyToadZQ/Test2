using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references

namespace Tellyes.DAL
{
    public partial class ReservationTimeInfo
    {

        public bool Exists(int ReservationTimeInfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReservationTimeInfo");
            strSql.Append(" where ");
            strSql.Append(" ReservationTimeInfoID = @ReservationTimeInfoID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ReservationTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReservationTimeInfoID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ReservationTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReservationTimeInfo(");
            strSql.Append("EnityID,ReservationTimeInfoDateInfo,ReservationTimeInfoStartTime,ReservationTimeInfoEndTime,ReservationID");
            strSql.Append(") values (");
            strSql.Append("@EnityID,@ReservationTimeInfoDateInfo,@ReservationTimeInfoStartTime,@ReservationTimeInfoEndTime,@ReservationID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@EnityID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoDateInfo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoStartTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoEndTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.EnityID;
            parameters[1].Value = model.ReservationTimeInfoDateInfo;
            parameters[2].Value = model.ReservationTimeInfoStartTime;
            parameters[3].Value = model.ReservationTimeInfoEndTime;
            parameters[4].Value = model.ReservationID;

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
        public bool Update(Tellyes.Model.ReservationTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReservationTimeInfo set ");

            strSql.Append(" EnityID = @EnityID , ");
            strSql.Append(" ReservationTimeInfoDateInfo = @ReservationTimeInfoDateInfo , ");
            strSql.Append(" ReservationTimeInfoStartTime = @ReservationTimeInfoStartTime , ");
            strSql.Append(" ReservationTimeInfoEndTime = @ReservationTimeInfoEndTime , ");
            strSql.Append(" ReservationID = @ReservationID  ");
            strSql.Append(" where ReservationTimeInfoID=@ReservationTimeInfoID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ReservationTimeInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@EnityID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoDateInfo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoStartTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationTimeInfoEndTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ReservationID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ReservationTimeInfoID;
            parameters[1].Value = model.EnityID;
            parameters[2].Value = model.ReservationTimeInfoDateInfo;
            parameters[3].Value = model.ReservationTimeInfoStartTime;
            parameters[4].Value = model.ReservationTimeInfoEndTime;
            parameters[5].Value = model.ReservationID;
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
        public bool Delete(int ReservationTimeInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReservationTimeInfo ");
            strSql.Append(" where ReservationTimeInfoID=@ReservationTimeInfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@ReservationTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReservationTimeInfoID;


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
        public bool DeleteList(string ReservationTimeInfoIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReservationTimeInfo ");
            strSql.Append(" where ID in (" + ReservationTimeInfoIDlist + ")  ");
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
        public Tellyes.Model.ReservationTimeInfo GetModel(int ReservationTimeInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ReservationTimeInfoID, EnityID, ReservationTimeInfoDateInfo, ReservationTimeInfoStartTime, ReservationTimeInfoEndTime, ReservationID  ");
            strSql.Append("  from ReservationTimeInfo ");
            strSql.Append(" where ReservationTimeInfoID=@ReservationTimeInfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@ReservationTimeInfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReservationTimeInfoID;


            Tellyes.Model.ReservationTimeInfo model = new Tellyes.Model.ReservationTimeInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ReservationTimeInfoID"].ToString() != "")
                {
                    model.ReservationTimeInfoID = int.Parse(ds.Tables[0].Rows[0]["ReservationTimeInfoID"].ToString());
                }
                model.EnityID = ds.Tables[0].Rows[0]["EnityID"].ToString();
                model.ReservationTimeInfoDateInfo = ds.Tables[0].Rows[0]["ReservationTimeInfoDateInfo"].ToString();
                model.ReservationTimeInfoStartTime = ds.Tables[0].Rows[0]["ReservationTimeInfoStartTime"].ToString();
                model.ReservationTimeInfoEndTime = ds.Tables[0].Rows[0]["ReservationTimeInfoEndTime"].ToString();
                if (ds.Tables[0].Rows[0]["ReservationID"].ToString() != "")
                {
                    model.ReservationID = int.Parse(ds.Tables[0].Rows[0]["ReservationID"].ToString());
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
            strSql.Append(" FROM ReservationTimeInfo ");
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
            strSql.Append(" FROM ReservationTimeInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}
