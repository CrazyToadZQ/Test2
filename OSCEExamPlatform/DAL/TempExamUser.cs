using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using Tellyes.Model;
using Tellyes.Log4Net;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    public class TempExamUser : BaseDAL<Model.TempExamUser>
    {
        #region Base Method

        public bool Exists(Guid TempExamUserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamUser");
            strSql.Append(" where ");
            strSql.Append(" TempExamUserID = @TempExamUserID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamUserID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamUser(");
            strSql.Append("TempExamUserID,TempExamUserNumber1,TempExamUserNumber2,TempExamUserNumber3,TempExamUserNumber4,TempExamUserString1,TempExamUserString2,TempExamUserString3,TempExamUserString4,TempExamUserDatetime1,TempExamUserDatetime2,TempExamTableID,TempExamStationID,TempExamStationRoomID,RoomID,UserInfoID,UserType,UserScorePercent,UserMarkSheetCount");
            strSql.Append(") values (");
            strSql.Append("@TempExamUserID,@TempExamUserNumber1,@TempExamUserNumber2,@TempExamUserNumber3,@TempExamUserNumber4,@TempExamUserString1,@TempExamUserString2,@TempExamUserString3,@TempExamUserString4,@TempExamUserDatetime1,@TempExamUserDatetime2,@TempExamTableID,@TempExamStationID,@TempExamStationRoomID,@RoomID,@UserInfoID,@UserType,@UserScorePercent,@UserMarkSheetCount");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamUserNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamUserString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamUserString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamUserString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamUserDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamUserDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserType", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserScorePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserMarkSheetCount", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.TempExamUserNumber1;
            parameters[2].Value = model.TempExamUserNumber2;
            parameters[3].Value = model.TempExamUserNumber3;
            parameters[4].Value = model.TempExamUserNumber4;
            parameters[5].Value = model.TempExamUserString1;
            parameters[6].Value = model.TempExamUserString2;
            parameters[7].Value = model.TempExamUserString3;
            parameters[8].Value = model.TempExamUserString4;
            parameters[9].Value = model.TempExamUserDatetime1;
            parameters[10].Value = model.TempExamUserDatetime2;
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = Guid.NewGuid();
            parameters[13].Value = Guid.NewGuid();
            parameters[14].Value = model.RoomID;
            parameters[15].Value = model.UserInfoID;
            parameters[16].Value = model.UserType;
            parameters[17].Value = model.UserScorePercent;
            parameters[18].Value = model.UserMarkSheetCount;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamUser set ");

            strSql.Append(" TempExamUserID = @TempExamUserID , ");
            strSql.Append(" TempExamUserNumber1 = @TempExamUserNumber1 , ");
            strSql.Append(" TempExamUserNumber2 = @TempExamUserNumber2 , ");
            strSql.Append(" TempExamUserNumber3 = @TempExamUserNumber3 , ");
            strSql.Append(" TempExamUserNumber4 = @TempExamUserNumber4 , ");
            strSql.Append(" TempExamUserString1 = @TempExamUserString1 , ");
            strSql.Append(" TempExamUserString2 = @TempExamUserString2 , ");
            strSql.Append(" TempExamUserString3 = @TempExamUserString3 , ");
            strSql.Append(" TempExamUserString4 = @TempExamUserString4 , ");
            strSql.Append(" TempExamUserDatetime1 = @TempExamUserDatetime1 , ");
            strSql.Append(" TempExamUserDatetime2 = @TempExamUserDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" UserInfoID = @UserInfoID , ");
            strSql.Append(" UserType = @UserType , ");
            strSql.Append(" UserScorePercent = @UserScorePercent , ");
            strSql.Append(" UserMarkSheetCount = @UserMarkSheetCount  ");
            strSql.Append(" where TempExamUserID=@TempExamUserID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamUserNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamUserString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamUserString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamUserString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamUserDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamUserDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserType", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserScorePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserMarkSheetCount", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamUserID;
            parameters[1].Value = model.TempExamUserNumber1;
            parameters[2].Value = model.TempExamUserNumber2;
            parameters[3].Value = model.TempExamUserNumber3;
            parameters[4].Value = model.TempExamUserNumber4;
            parameters[5].Value = model.TempExamUserString1;
            parameters[6].Value = model.TempExamUserString2;
            parameters[7].Value = model.TempExamUserString3;
            parameters[8].Value = model.TempExamUserString4;
            parameters[9].Value = model.TempExamUserDatetime1;
            parameters[10].Value = model.TempExamUserDatetime2;
            parameters[11].Value = model.TempExamTableID;
            parameters[12].Value = model.TempExamStationID;
            parameters[13].Value = model.TempExamStationRoomID;
            parameters[14].Value = model.RoomID;
            parameters[15].Value = model.UserInfoID;
            parameters[16].Value = model.UserType;
            parameters[17].Value = model.UserScorePercent;
            parameters[18].Value = model.UserMarkSheetCount;
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
        public bool Delete(Guid TempExamUserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamUser ");
            strSql.Append(" where TempExamUserID=@TempExamUserID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamUserID;


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
        public Model.TempExamUser GetModel(Guid TempExamUserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamUserID, TempExamUserNumber1, TempExamUserNumber2, TempExamUserNumber3, TempExamUserNumber4, TempExamUserString1, TempExamUserString2, TempExamUserString3, TempExamUserString4, TempExamUserDatetime1, TempExamUserDatetime2, TempExamTableID, TempExamStationID, TempExamStationRoomID, RoomID, UserInfoID, UserType, UserScorePercent, UserMarkSheetCount  ");
            strSql.Append("  from TempExamUser ");
            strSql.Append(" where TempExamUserID=@TempExamUserID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamUserID;


            Model.TempExamUser model = new Model.TempExamUser();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamUserID"].ToString() != "")
                {
                    model.TempExamUserID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamUserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserNumber1"].ToString() != "")
                {
                    model.TempExamUserNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamUserNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserNumber2"].ToString() != "")
                {
                    model.TempExamUserNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamUserNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserNumber3"].ToString() != "")
                {
                    model.TempExamUserNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamUserNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserNumber4"].ToString() != "")
                {
                    model.TempExamUserNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamUserNumber4"].ToString());
                }
                model.TempExamUserString1 = ds.Tables[0].Rows[0]["TempExamUserString1"].ToString();
                model.TempExamUserString2 = ds.Tables[0].Rows[0]["TempExamUserString2"].ToString();
                model.TempExamUserString3 = ds.Tables[0].Rows[0]["TempExamUserString3"].ToString();
                model.TempExamUserString4 = ds.Tables[0].Rows[0]["TempExamUserString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamUserDatetime1"].ToString() != "")
                {
                    model.TempExamUserDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamUserDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserDatetime2"].ToString() != "")
                {
                    model.TempExamUserDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamUserDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationID"].ToString() != "")
                {
                    model.TempExamStationID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStationID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomID"].ToString() != "")
                {
                    model.TempExamStationRoomID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RoomID"].ToString() != "")
                {
                    model.RoomID = int.Parse(ds.Tables[0].Rows[0]["RoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserType"].ToString() != "")
                {
                    model.UserType = int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserScorePercent"].ToString() != "")
                {
                    model.UserScorePercent = int.Parse(ds.Tables[0].Rows[0]["UserScorePercent"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserMarkSheetCount"].ToString() != "")
                {
                    model.UserMarkSheetCount = int.Parse(ds.Tables[0].Rows[0]["UserMarkSheetCount"].ToString());
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
            strSql.Append(" FROM TempExamUser ");
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
            strSql.Append(" FROM TempExamUser ");
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
            if (conditionDictionary.ContainsKey("TempExamStationID,Eq"))
            {
                criteria.Add(Restrictions.Eq("TempExamStationID", conditionDictionary["TempExamStationID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("TempExamStationID,In"))
            {
                criteria.Add(Restrictions.In("TempExamStationID", (List<Guid>)conditionDictionary["TempExamStationID,In"]));
            }
            if (conditionDictionary.ContainsKey("UserType,In"))
            {
                criteria.Add(Restrictions.In("UserType", (List<int>)conditionDictionary["UserType,In"]));
            }
            return criteria;
        }
        #endregion

        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public List<object[]> SelectTempExamUserAndUserInfoByTempExamTableID(Guid tempExamTableID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [TempExamUser].*, ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [UserInfo].[U_Title], ")
                .Append("   [UserInfo].[U_GoodField] ")
                .Append("FROM ")
                .Append("   [TempExamUser] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [TempExamUser].[UserInfoID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [TempExamTableID] = :tempExamTableID")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.TempExamUser))
                    .AddScalar("U_TrueName", NHibernateUtil.String)
                    .AddScalar("U_Title", NHibernateUtil.String)
                    .AddScalar("U_GoodField", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("tempExamTableID", tempExamTableID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败：" + tempExamTableID, e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 获得单站排考，首界面上要显示的已存在TempExamUser数据
        /// </summary>
        /// <param name="TempExamTableID"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public List<Tellyes.Model.TempExamUser_SingleExamMainPage> GetExistedExamUserInfoForSingleExamMainPage(string TempExamTableID, ExamUserType userType) 
        {
            string sql = " select * from TempExamUser join UserInfo on TempExamUser.UserInfoID=UserInfo.U_ID where TempExamTableID ='" + TempExamTableID + "' and UserType='" + Convert.ToInt32(userType) + "';";
            DataTable source = DbHelperSQL.Query(sql).Tables[0];
            if(source.Rows.Count > 0)
            {
                List<Tellyes.Model.TempExamUser_SingleExamMainPage> result = new List<Model.TempExamUser_SingleExamMainPage>();
                foreach(DataRow row in source.Rows)
                {
                    Tellyes.Model.TempExamUser_SingleExamMainPage newItem = new Model.TempExamUser_SingleExamMainPage();
                    result.Add(newItem);
                    newItem.TempExamUserID = Guid.Parse(row["TempExamUserID"].ToString());
                    newItem.U_ID = Convert.ToInt32(row["U_ID"]);
                    newItem.U_TrueName = row["U_TrueName"].ToString().Trim();
                    newItem.U_Title = row["U_Title"].ToString().Trim();
                    newItem.U_GoodField = row["U_GoodField"].ToString().Trim();
                }
                return result;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
