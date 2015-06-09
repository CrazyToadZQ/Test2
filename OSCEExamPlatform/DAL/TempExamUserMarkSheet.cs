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

namespace Tellyes.DAL
{
    public class TempExamUserMarkSheet : BaseDAL<Model.TempExamUserMarkSheet>
    {
        #region Base Method

        public bool Exists(int TempExamUserMarkSheetID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamUserMarkSheet");
            strSql.Append(" where ");
            strSql.Append(" TempExamUserMarkSheetID = @TempExamUserMarkSheetID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamUserMarkSheetID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamUserMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamUserMarkSheet(");
            strSql.Append("TempExamUserMarkSheetNumber2,TempExamUserMarkSheetNumber3,TempExamUserMarkSheetNumber4,TempExamUserMarkSheetString1,TempExamUserMarkSheetString2,TempExamUserMarkSheetString3,TempExamUserMarkSheetString4,TempExamUserMarkSheetDatetime1,TempExamUserMarkSheetDatetime2,TempExamTableID,TempExamStationID,TempExamStationRoomID,TempExamUserID,RoomID,UserInfoID,MarkSheetID,TempExamUserMarkSheetNumber1");
            strSql.Append(") values (");
            strSql.Append("@TempExamUserMarkSheetNumber2,@TempExamUserMarkSheetNumber3,@TempExamUserMarkSheetNumber4,@TempExamUserMarkSheetString1,@TempExamUserMarkSheetString2,@TempExamUserMarkSheetString3,@TempExamUserMarkSheetString4,@TempExamUserMarkSheetDatetime1,@TempExamUserMarkSheetDatetime2,@TempExamTableID,@TempExamStationID,@TempExamStationRoomID,@TempExamUserID,@RoomID,@UserInfoID,@MarkSheetID,@TempExamUserMarkSheetNumber1");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamUserMarkSheetNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserMarkSheetString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamUserMarkSheetDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamUserMarkSheetDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamUserMarkSheetNumber2;
            parameters[1].Value = model.TempExamUserMarkSheetNumber3;
            parameters[2].Value = model.TempExamUserMarkSheetNumber4;
            parameters[3].Value = model.TempExamUserMarkSheetString1;
            parameters[4].Value = model.TempExamUserMarkSheetString2;
            parameters[5].Value = model.TempExamUserMarkSheetString3;
            parameters[6].Value = model.TempExamUserMarkSheetString4;
            parameters[7].Value = model.TempExamUserMarkSheetDatetime1;
            parameters[8].Value = model.TempExamUserMarkSheetDatetime2;
            parameters[9].Value = Guid.NewGuid();
            parameters[10].Value = Guid.NewGuid();
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = Guid.NewGuid();
            parameters[13].Value = model.RoomID;
            parameters[14].Value = model.UserInfoID;
            parameters[15].Value = model.MarkSheetID;
            parameters[16].Value = model.TempExamUserMarkSheetNumber1;

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
        public bool Update(Model.TempExamUserMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamUserMarkSheet set ");

            strSql.Append(" TempExamUserMarkSheetNumber2 = @TempExamUserMarkSheetNumber2 , ");
            strSql.Append(" TempExamUserMarkSheetNumber3 = @TempExamUserMarkSheetNumber3 , ");
            strSql.Append(" TempExamUserMarkSheetNumber4 = @TempExamUserMarkSheetNumber4 , ");
            strSql.Append(" TempExamUserMarkSheetString1 = @TempExamUserMarkSheetString1 , ");
            strSql.Append(" TempExamUserMarkSheetString2 = @TempExamUserMarkSheetString2 , ");
            strSql.Append(" TempExamUserMarkSheetString3 = @TempExamUserMarkSheetString3 , ");
            strSql.Append(" TempExamUserMarkSheetString4 = @TempExamUserMarkSheetString4 , ");
            strSql.Append(" TempExamUserMarkSheetDatetime1 = @TempExamUserMarkSheetDatetime1 , ");
            strSql.Append(" TempExamUserMarkSheetDatetime2 = @TempExamUserMarkSheetDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID , ");
            strSql.Append(" TempExamUserID = @TempExamUserID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" UserInfoID = @UserInfoID , ");
            strSql.Append(" MarkSheetID = @MarkSheetID , ");
            strSql.Append(" TempExamUserMarkSheetNumber1 = @TempExamUserMarkSheetNumber1  ");
            strSql.Append(" where TempExamUserMarkSheetID=@TempExamUserMarkSheetID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamUserMarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamUserMarkSheetString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamUserMarkSheetString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamUserMarkSheetDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamUserMarkSheetDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamUserID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamUserMarkSheetNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamUserMarkSheetID;
            parameters[1].Value = model.TempExamUserMarkSheetNumber2;
            parameters[2].Value = model.TempExamUserMarkSheetNumber3;
            parameters[3].Value = model.TempExamUserMarkSheetNumber4;
            parameters[4].Value = model.TempExamUserMarkSheetString1;
            parameters[5].Value = model.TempExamUserMarkSheetString2;
            parameters[6].Value = model.TempExamUserMarkSheetString3;
            parameters[7].Value = model.TempExamUserMarkSheetString4;
            parameters[8].Value = model.TempExamUserMarkSheetDatetime1;
            parameters[9].Value = model.TempExamUserMarkSheetDatetime2;
            parameters[10].Value = model.TempExamTableID;
            parameters[11].Value = model.TempExamStationID;
            parameters[12].Value = model.TempExamStationRoomID;
            parameters[13].Value = model.TempExamUserID;
            parameters[14].Value = model.RoomID;
            parameters[15].Value = model.UserInfoID;
            parameters[16].Value = model.MarkSheetID;
            parameters[17].Value = model.TempExamUserMarkSheetNumber1;
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
        public bool Delete(int TempExamUserMarkSheetID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamUserMarkSheet ");
            strSql.Append(" where TempExamUserMarkSheetID=@TempExamUserMarkSheetID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamUserMarkSheetID;


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
        public bool DeleteList(string TempExamUserMarkSheetIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamUserMarkSheet ");
            strSql.Append(" where ID in (" + TempExamUserMarkSheetIDlist + ")  ");
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
        public Model.TempExamUserMarkSheet GetModel(int TempExamUserMarkSheetID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamUserMarkSheetID, TempExamUserMarkSheetNumber2, TempExamUserMarkSheetNumber3, TempExamUserMarkSheetNumber4, TempExamUserMarkSheetString1, TempExamUserMarkSheetString2, TempExamUserMarkSheetString3, TempExamUserMarkSheetString4, TempExamUserMarkSheetDatetime1, TempExamUserMarkSheetDatetime2, TempExamTableID, TempExamStationID, TempExamStationRoomID, TempExamUserID, RoomID, UserInfoID, MarkSheetID, TempExamUserMarkSheetNumber1  ");
            strSql.Append("  from TempExamUserMarkSheet ");
            strSql.Append(" where TempExamUserMarkSheetID=@TempExamUserMarkSheetID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamUserMarkSheetID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamUserMarkSheetID;


            Model.TempExamUserMarkSheet model = new Model.TempExamUserMarkSheet();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetID"].ToString() != "")
                {
                    model.TempExamUserMarkSheetID = int.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber2"].ToString() != "")
                {
                    model.TempExamUserMarkSheetNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber3"].ToString() != "")
                {
                    model.TempExamUserMarkSheetNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber4"].ToString() != "")
                {
                    model.TempExamUserMarkSheetNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber4"].ToString());
                }
                model.TempExamUserMarkSheetString1 = ds.Tables[0].Rows[0]["TempExamUserMarkSheetString1"].ToString();
                model.TempExamUserMarkSheetString2 = ds.Tables[0].Rows[0]["TempExamUserMarkSheetString2"].ToString();
                model.TempExamUserMarkSheetString3 = ds.Tables[0].Rows[0]["TempExamUserMarkSheetString3"].ToString();
                model.TempExamUserMarkSheetString4 = ds.Tables[0].Rows[0]["TempExamUserMarkSheetString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetDatetime1"].ToString() != "")
                {
                    model.TempExamUserMarkSheetDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetDatetime2"].ToString() != "")
                {
                    model.TempExamUserMarkSheetDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetDatetime2"].ToString());
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
                if (ds.Tables[0].Rows[0]["TempExamUserID"].ToString() != "")
                {
                    model.TempExamUserID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamUserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RoomID"].ToString() != "")
                {
                    model.RoomID = int.Parse(ds.Tables[0].Rows[0]["RoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetID"].ToString() != "")
                {
                    model.MarkSheetID = int.Parse(ds.Tables[0].Rows[0]["MarkSheetID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber1"].ToString() != "")
                {
                    model.TempExamUserMarkSheetNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamUserMarkSheetNumber1"].ToString());
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
            strSql.Append(" FROM TempExamUserMarkSheet ");
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
            strSql.Append(" FROM TempExamUserMarkSheet ");
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
            if (conditionDictionary.ContainsKey("TempExamStationID,In"))
            {
                criteria.Add(Restrictions.In("TempExamStationID", (List<Guid>)conditionDictionary["TempExamStationID,In"]));
            }
            if (conditionDictionary.ContainsKey("TempExamStationID,Eq"))
            {
                criteria.Add(Restrictions.Eq("TempExamStationID", conditionDictionary["TempExamStationID,Eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
