using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using NHibernate;
using NHibernate.Criterion;
using System.Web.Script.Serialization;
using System.Reflection;
using System.Collections.ObjectModel;
using Tellyes.Model;
using System.Collections;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class TempExamStationRoom : BaseDAL<Model.TempExamStationRoom>
    {
        #region Base Method

        public bool Exists(Guid TempExamStationRoomID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamStationRoom");
            strSql.Append(" where ");
            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationRoomID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStationRoom model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamStationRoom(");
            strSql.Append("TempExamStationRoomID,TempExamStationRoomNumber5,TempExamStationRoomNumber6,TempExamStationRoomNumber7,TempExamStationRoomNumber8,TempExamStationRoomNumber9,TempExamStationRoomString1,TempExamStationRoomString2,TempExamStationRoomString3,TempExamStationRoomString4,TempExamStationRoomString5,TempExamTableID,TempExamStationRoomString6,TempExamStationRoomString7,TempExamStationRoomString8,TempExamStationRoomString9,TempExamStationRoomDatetime1,TempExamStationRoomDatetime2,TempExamStationRoomDatetime3,TempExamStationRoomDatetime4,TempExamStationRoomDatetime5,TempExamStationRoomDatetime6,TempExamStationID,RoomID,TempExamStationRoomIsComplete,TempExamStationRoomNumber1,TempExamStationRoomNumber2,TempExamStationRoomNumber3,TempExamStationRoomNumber4");
            strSql.Append(") values (");
            strSql.Append("@TempExamStationRoomID,@TempExamStationRoomNumber5,@TempExamStationRoomNumber6,@TempExamStationRoomNumber7,@TempExamStationRoomNumber8,@TempExamStationRoomNumber9,@TempExamStationRoomString1,@TempExamStationRoomString2,@TempExamStationRoomString3,@TempExamStationRoomString4,@TempExamStationRoomString5,@TempExamTableID,@TempExamStationRoomString6,@TempExamStationRoomString7,@TempExamStationRoomString8,@TempExamStationRoomString9,@TempExamStationRoomDatetime1,@TempExamStationRoomDatetime2,@TempExamStationRoomDatetime3,@TempExamStationRoomDatetime4,@TempExamStationRoomDatetime5,@TempExamStationRoomDatetime6,@TempExamStationID,@RoomID,@TempExamStationRoomIsComplete,@TempExamStationRoomNumber1,@TempExamStationRoomNumber2,@TempExamStationRoomNumber3,@TempExamStationRoomNumber4");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationRoomNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationRoomString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationRoomString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationRoomString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationRoomString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamStationRoomString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStationRoomString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStationRoomString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStationRoomDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber4", SqlDbType.BigInt,8)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.TempExamStationRoomNumber5;
            parameters[2].Value = model.TempExamStationRoomNumber6;
            parameters[3].Value = model.TempExamStationRoomNumber7;
            parameters[4].Value = model.TempExamStationRoomNumber8;
            parameters[5].Value = model.TempExamStationRoomNumber9;
            parameters[6].Value = model.TempExamStationRoomString1;
            parameters[7].Value = model.TempExamStationRoomString2;
            parameters[8].Value = model.TempExamStationRoomString3;
            parameters[9].Value = model.TempExamStationRoomString4;
            parameters[10].Value = model.TempExamStationRoomString5;
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.TempExamStationRoomString6;
            parameters[13].Value = model.TempExamStationRoomString7;
            parameters[14].Value = model.TempExamStationRoomString8;
            parameters[15].Value = model.TempExamStationRoomString9;
            parameters[16].Value = model.TempExamStationRoomDatetime1;
            parameters[17].Value = model.TempExamStationRoomDatetime2;
            parameters[18].Value = model.TempExamStationRoomDatetime3;
            parameters[19].Value = model.TempExamStationRoomDatetime4;
            parameters[20].Value = model.TempExamStationRoomDatetime5;
            parameters[21].Value = model.TempExamStationRoomDatetime6;
            parameters[22].Value = Guid.NewGuid();
            parameters[23].Value = model.RoomID;
            parameters[24].Value = model.TempExamStationRoomIsComplete;
            parameters[25].Value = model.TempExamStationRoomNumber1;
            parameters[26].Value = model.TempExamStationRoomNumber2;
            parameters[27].Value = model.TempExamStationRoomNumber3;
            parameters[28].Value = model.TempExamStationRoomNumber4;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStationRoom model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamStationRoom set ");

            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID , ");
            strSql.Append(" TempExamStationRoomNumber5 = @TempExamStationRoomNumber5 , ");
            strSql.Append(" TempExamStationRoomNumber6 = @TempExamStationRoomNumber6 , ");
            strSql.Append(" TempExamStationRoomNumber7 = @TempExamStationRoomNumber7 , ");
            strSql.Append(" TempExamStationRoomNumber8 = @TempExamStationRoomNumber8 , ");
            strSql.Append(" TempExamStationRoomNumber9 = @TempExamStationRoomNumber9 , ");
            strSql.Append(" TempExamStationRoomString1 = @TempExamStationRoomString1 , ");
            strSql.Append(" TempExamStationRoomString2 = @TempExamStationRoomString2 , ");
            strSql.Append(" TempExamStationRoomString3 = @TempExamStationRoomString3 , ");
            strSql.Append(" TempExamStationRoomString4 = @TempExamStationRoomString4 , ");
            strSql.Append(" TempExamStationRoomString5 = @TempExamStationRoomString5 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationRoomString6 = @TempExamStationRoomString6 , ");
            strSql.Append(" TempExamStationRoomString7 = @TempExamStationRoomString7 , ");
            strSql.Append(" TempExamStationRoomString8 = @TempExamStationRoomString8 , ");
            strSql.Append(" TempExamStationRoomString9 = @TempExamStationRoomString9 , ");
            strSql.Append(" TempExamStationRoomDatetime1 = @TempExamStationRoomDatetime1 , ");
            strSql.Append(" TempExamStationRoomDatetime2 = @TempExamStationRoomDatetime2 , ");
            strSql.Append(" TempExamStationRoomDatetime3 = @TempExamStationRoomDatetime3 , ");
            strSql.Append(" TempExamStationRoomDatetime4 = @TempExamStationRoomDatetime4 , ");
            strSql.Append(" TempExamStationRoomDatetime5 = @TempExamStationRoomDatetime5 , ");
            strSql.Append(" TempExamStationRoomDatetime6 = @TempExamStationRoomDatetime6 , ");
            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" TempExamStationRoomIsComplete = @TempExamStationRoomIsComplete , ");
            strSql.Append(" TempExamStationRoomNumber1 = @TempExamStationRoomNumber1 , ");
            strSql.Append(" TempExamStationRoomNumber2 = @TempExamStationRoomNumber2 , ");
            strSql.Append(" TempExamStationRoomNumber3 = @TempExamStationRoomNumber3 , ");
            strSql.Append(" TempExamStationRoomNumber4 = @TempExamStationRoomNumber4  ");
            strSql.Append(" where TempExamStationRoomID=@TempExamStationRoomID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationRoomNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationRoomString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationRoomString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationRoomString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationRoomString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationRoomString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamStationRoomString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStationRoomString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStationRoomString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStationRoomDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationRoomDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationRoomNumber4", SqlDbType.BigInt,8)             
              
            };

            parameters[0].Value = model.TempExamStationRoomID;
            parameters[1].Value = model.TempExamStationRoomNumber5;
            parameters[2].Value = model.TempExamStationRoomNumber6;
            parameters[3].Value = model.TempExamStationRoomNumber7;
            parameters[4].Value = model.TempExamStationRoomNumber8;
            parameters[5].Value = model.TempExamStationRoomNumber9;
            parameters[6].Value = model.TempExamStationRoomString1;
            parameters[7].Value = model.TempExamStationRoomString2;
            parameters[8].Value = model.TempExamStationRoomString3;
            parameters[9].Value = model.TempExamStationRoomString4;
            parameters[10].Value = model.TempExamStationRoomString5;
            parameters[11].Value = model.TempExamTableID;
            parameters[12].Value = model.TempExamStationRoomString6;
            parameters[13].Value = model.TempExamStationRoomString7;
            parameters[14].Value = model.TempExamStationRoomString8;
            parameters[15].Value = model.TempExamStationRoomString9;
            parameters[16].Value = model.TempExamStationRoomDatetime1;
            parameters[17].Value = model.TempExamStationRoomDatetime2;
            parameters[18].Value = model.TempExamStationRoomDatetime3;
            parameters[19].Value = model.TempExamStationRoomDatetime4;
            parameters[20].Value = model.TempExamStationRoomDatetime5;
            parameters[21].Value = model.TempExamStationRoomDatetime6;
            parameters[22].Value = model.TempExamStationID;
            parameters[23].Value = model.RoomID;
            parameters[24].Value = model.TempExamStationRoomIsComplete;
            parameters[25].Value = model.TempExamStationRoomNumber1;
            parameters[26].Value = model.TempExamStationRoomNumber2;
            parameters[27].Value = model.TempExamStationRoomNumber3;
            parameters[28].Value = model.TempExamStationRoomNumber4;
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
        public bool Delete(Guid TempExamStationRoomID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamStationRoom ");
            strSql.Append(" where TempExamStationRoomID=@TempExamStationRoomID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationRoomID;


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
        public Model.TempExamStationRoom GetModel(Guid TempExamStationRoomID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamStationRoomID, TempExamStationRoomNumber5, TempExamStationRoomNumber6, TempExamStationRoomNumber7, TempExamStationRoomNumber8, TempExamStationRoomNumber9, TempExamStationRoomString1, TempExamStationRoomString2, TempExamStationRoomString3, TempExamStationRoomString4, TempExamStationRoomString5, TempExamTableID, TempExamStationRoomString6, TempExamStationRoomString7, TempExamStationRoomString8, TempExamStationRoomString9, TempExamStationRoomDatetime1, TempExamStationRoomDatetime2, TempExamStationRoomDatetime3, TempExamStationRoomDatetime4, TempExamStationRoomDatetime5, TempExamStationRoomDatetime6, TempExamStationID, RoomID, TempExamStationRoomIsComplete, TempExamStationRoomNumber1, TempExamStationRoomNumber2, TempExamStationRoomNumber3, TempExamStationRoomNumber4  ");
            strSql.Append("  from TempExamStationRoom ");
            strSql.Append(" where TempExamStationRoomID=@TempExamStationRoomID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationRoomID;


            Model.TempExamStationRoom model = new Model.TempExamStationRoom();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamStationRoomID"].ToString() != "")
                {
                    model.TempExamStationRoomID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber5"].ToString() != "")
                {
                    model.TempExamStationRoomNumber5 = long.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber6"].ToString() != "")
                {
                    model.TempExamStationRoomNumber6 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber7"].ToString() != "")
                {
                    model.TempExamStationRoomNumber7 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber8"].ToString() != "")
                {
                    model.TempExamStationRoomNumber8 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber8"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber9"].ToString() != "")
                {
                    model.TempExamStationRoomNumber9 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber9"].ToString());
                }
                model.TempExamStationRoomString1 = ds.Tables[0].Rows[0]["TempExamStationRoomString1"].ToString();
                model.TempExamStationRoomString2 = ds.Tables[0].Rows[0]["TempExamStationRoomString2"].ToString();
                model.TempExamStationRoomString3 = ds.Tables[0].Rows[0]["TempExamStationRoomString3"].ToString();
                model.TempExamStationRoomString4 = ds.Tables[0].Rows[0]["TempExamStationRoomString4"].ToString();
                model.TempExamStationRoomString5 = ds.Tables[0].Rows[0]["TempExamStationRoomString5"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                model.TempExamStationRoomString6 = ds.Tables[0].Rows[0]["TempExamStationRoomString6"].ToString();
                model.TempExamStationRoomString7 = ds.Tables[0].Rows[0]["TempExamStationRoomString7"].ToString();
                model.TempExamStationRoomString8 = ds.Tables[0].Rows[0]["TempExamStationRoomString8"].ToString();
                model.TempExamStationRoomString9 = ds.Tables[0].Rows[0]["TempExamStationRoomString9"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime1"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime2"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime3"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime3 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime4"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime5"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime5 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomDatetime6"].ToString() != "")
                {
                    model.TempExamStationRoomDatetime6 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomDatetime6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationID"].ToString() != "")
                {
                    model.TempExamStationID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStationID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RoomID"].ToString() != "")
                {
                    model.RoomID = int.Parse(ds.Tables[0].Rows[0]["RoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomIsComplete"].ToString() != "")
                {
                    model.TempExamStationRoomIsComplete = int.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomIsComplete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber1"].ToString() != "")
                {
                    model.TempExamStationRoomNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber2"].ToString() != "")
                {
                    model.TempExamStationRoomNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber3"].ToString() != "")
                {
                    model.TempExamStationRoomNumber3 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationRoomNumber4"].ToString() != "")
                {
                    model.TempExamStationRoomNumber4 = long.Parse(ds.Tables[0].Rows[0]["TempExamStationRoomNumber4"].ToString());
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
            strSql.Append(" FROM TempExamStationRoom ");
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
            strSql.Append(" FROM TempExamStationRoom ");
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public List<object[]> SelectTempExamStationRoomAndRoomByTempExamTableID(Guid tempExamTableID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [TempExamStationRoom].*, ")
                .Append("   [Room].[Room_Name] ")
                .Append("FROM ")
                .Append("   [TempExamStationRoom] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [TempExamStationRoom].[RoomID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [TempExamTableID] = :tempExamTableID")
                .Append(" order by [Room].[Room_Name] ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.TempExamStationRoom))
                    .AddScalar("Room_Name", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("tempExamTableID", tempExamTableID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch(Exception e)
            {
                Log4NetUtility.Error(this, "查询单站式考站房间信息失败：" + tempExamTableID, e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 获得房间评委，SP级联信息
        /// </summary>
        /// <param name="TempExamTableID"></param>
        public static Hashtable GetTempExamRoomAndUserInfoForSingleExam(Guid TempExamTableID)
        {
            Hashtable result = new Hashtable();

            StringBuilder sql = new StringBuilder();
            sql.Append(" select r.RoomID,Room.Room_Name,Room.Room_Area,Room.Room_People_Number ");
            sql.Append(" ,r.TempExamStationRoomID,r.TempExamStationRoomIsComplete ");
            sql.Append(" from dbo.TempExamStationRoom as r  ");
            sql.Append(" join Room on r.RoomID=Room.Room_ID  ");
            sql.Append(" where r.TempExamTableID='" + TempExamTableID.ToString() + "'; ");

            DataTable source1 = DbHelperSQL.Query(sql.ToString()).Tables[0];

            sql.Clear();
            sql.Append(" select UserInfo.U_ID,UserInfo.U_TrueName,u.UserType,u.TempExamStationRoomID ");
            sql.Append(" from dbo.TempExamUser as u join UserInfo on u.UserInfoID=UserInfo.U_ID ");
            sql.Append(" where u.TempExamTableID = '" + TempExamTableID.ToString() + "'; ");

            DataTable source2 = DbHelperSQL.Query(sql.ToString()).Tables[0];

            if (source1.Rows.Count > 0)
            {
                result.Add("roomInfo", source1);
                if (source2.Rows.Count > 0)
                {
                    result.Add("userInfoInOneRoom", source2);
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        public static class DTLinqUtility
        {
            public static List<T> ChangDTToTList<T>(DataTable source) where T : new()
            {
                List<T> result = new List<T>();

                foreach (DataRow row in source.Rows)
                {
                    T item = new T();
                    foreach (DataColumn col in source.Columns)
                    {
                        PropertyInfo tempProperty = item.GetType().GetProperty(col.ColumnName);
                        if (tempProperty != null)
                        {
                            if (row[col] is DBNull)
                            {
                                if (tempProperty.PropertyType.UnderlyingSystemType.FullName.Contains("System.Nullable"))
                                {
                                    tempProperty.SetValue(item, null, null);
                                }
                            }
                            else
                            {
                                tempProperty.SetValue(item, row[col], null);
                            }
                        }
                    }
                    result.Add(item);
                }

                return result;
            }

            private static DataTable ChangModelToTable<T>(List<T> modelList = null) where T : new()
            {
                DataTable source = new DataTable();
                T item = new T();
                PropertyInfo[] properties = item.GetType().GetProperties();
                foreach (PropertyInfo pInfo in properties)
                {
                    DataColumn col = new DataColumn();
                    col.ColumnName = pInfo.Name;
                    if (pInfo.PropertyType.FullName.Contains("System.Guid"))
                    {
                        col.DataType = typeof(System.Guid);
                    }
                    if (pInfo.PropertyType.FullName.Contains("System.Int32"))
                    {
                        col.DataType = typeof(Int32);
                    }
                    if (pInfo.PropertyType.FullName.Contains("System.String"))
                    {
                        col.DataType = typeof(String);
                    }
                    if (pInfo.PropertyType.FullName.Contains("System.DateTime"))
                    {
                        col.DataType = typeof(DateTime);
                    }
                    if (pInfo.PropertyType.FullName.Contains("System.Decimal"))
                    {
                        col.DataType = typeof(Decimal);
                    }
                    source.Columns.Add(col);
                }

                #region 填充数据
                if (modelList != null)
                {
                    foreach (T model in modelList)
                    {
                        DataRow newRow = source.NewRow();
                        source.Rows.Add(newRow);
                        foreach (DataColumn col in source.Columns)
                        {
                            PropertyInfo p = model.GetType().GetProperty(col.ColumnName);
                            newRow[col.ColumnName] = p.GetValue(model, null) ?? DBNull.Value;
                        }
                    }
                }
                #endregion

                return source;
            }
        }

        #endregion

        private class DateTimeString : JavaScriptConverter
        {
            public override IEnumerable<Type> SupportedTypes
            {
                get
                {
                    return new ReadOnlyCollection<Type>(new List<Type>(new Type[] { typeof(DateTime) }));
                }
            }

            public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
            {
                DateTime target = Convert.ToDateTime(obj);
                Dictionary<string, object> result = new Dictionary<string, object>();
                result.Add("date", target.ToString("yyyy-MM-dd HH:mm:ss"));
                return result;
            }

            public override object Deserialize(IDictionary<string, object> obj, Type type, JavaScriptSerializer serializer)
            {
                if (obj == null || !obj.Keys.Contains("date"))
                {
                    throw new ArgumentNullException("dictionary");
                }
                return Convert.ToDateTime(obj["date"]);
            }
        }
    }
}
