using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Tellyes.DAL
{
    public class TempExamDeviceClass : BaseDAL<Model.TempExamDeviceClass>
    {
        #region Base Method

        public bool Exists(int TempExamDeviceClassID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamDeviceClass");
            strSql.Append(" where ");
            strSql.Append(" TempExamDeviceClassID = @TempExamDeviceClassID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamDeviceClassID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamDeviceClassID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamDeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamDeviceClass(");
            strSql.Append("TempExamDeviceClassNumber2,TempExamDeviceClassNumber3,TempExamDeviceClassNumber4,TempExamDeviceClassString1,TempExamDeviceClassString2,TempExamDeviceClassString3,TempExamDeviceClassString4,TempExamDeviceClassDatetime1,TempExamDeviceClassDatetime2,TempExamTableID,TempExamStationID,TempExamStationRoomID,RoomID,DeviceClassID,DeviceCount,ObjectiveMarkSheetID,TempExamDeviceClassNumber1");
            strSql.Append(") values (");
            strSql.Append("@TempExamDeviceClassNumber2,@TempExamDeviceClassNumber3,@TempExamDeviceClassNumber4,@TempExamDeviceClassString1,@TempExamDeviceClassString2,@TempExamDeviceClassString3,@TempExamDeviceClassString4,@TempExamDeviceClassDatetime1,@TempExamDeviceClassDatetime2,@TempExamTableID,@TempExamStationID,@TempExamStationRoomID,@RoomID,@DeviceClassID,@DeviceCount,@ObjectiveMarkSheetID,@TempExamDeviceClassNumber1");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamDeviceClassNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDeviceClassNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamDeviceClassNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamDeviceClassString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamDeviceClassString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamDeviceClassString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamDeviceClassString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamDeviceClassDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDeviceClassDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DeviceClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DeviceCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@ObjectiveMarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDeviceClassNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamDeviceClassNumber2;
            parameters[1].Value = model.TempExamDeviceClassNumber3;
            parameters[2].Value = model.TempExamDeviceClassNumber4;
            parameters[3].Value = model.TempExamDeviceClassString1;
            parameters[4].Value = model.TempExamDeviceClassString2;
            parameters[5].Value = model.TempExamDeviceClassString3;
            parameters[6].Value = model.TempExamDeviceClassString4;
            parameters[7].Value = model.TempExamDeviceClassDatetime1;
            parameters[8].Value = model.TempExamDeviceClassDatetime2;
            parameters[9].Value = Guid.NewGuid();
            parameters[10].Value = Guid.NewGuid();
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.RoomID;
            parameters[13].Value = model.DeviceClassID;
            parameters[14].Value = model.DeviceCount;
            parameters[15].Value = model.ObjectiveMarkSheetID;
            parameters[16].Value = model.TempExamDeviceClassNumber1;

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
        public bool Update(Model.TempExamDeviceClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamDeviceClass set ");

            strSql.Append(" TempExamDeviceClassNumber2 = @TempExamDeviceClassNumber2 , ");
            strSql.Append(" TempExamDeviceClassNumber3 = @TempExamDeviceClassNumber3 , ");
            strSql.Append(" TempExamDeviceClassNumber4 = @TempExamDeviceClassNumber4 , ");
            strSql.Append(" TempExamDeviceClassString1 = @TempExamDeviceClassString1 , ");
            strSql.Append(" TempExamDeviceClassString2 = @TempExamDeviceClassString2 , ");
            strSql.Append(" TempExamDeviceClassString3 = @TempExamDeviceClassString3 , ");
            strSql.Append(" TempExamDeviceClassString4 = @TempExamDeviceClassString4 , ");
            strSql.Append(" TempExamDeviceClassDatetime1 = @TempExamDeviceClassDatetime1 , ");
            strSql.Append(" TempExamDeviceClassDatetime2 = @TempExamDeviceClassDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" DeviceClassID = @DeviceClassID , ");
            strSql.Append(" DeviceCount = @DeviceCount , ");
            strSql.Append(" ObjectiveMarkSheetID = @ObjectiveMarkSheetID , ");
            strSql.Append(" TempExamDeviceClassNumber1 = @TempExamDeviceClassNumber1  ");
            strSql.Append(" where TempExamDeviceClassID=@TempExamDeviceClassID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamDeviceClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDeviceClassNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDeviceClassNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamDeviceClassNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamDeviceClassString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamDeviceClassString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamDeviceClassString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamDeviceClassString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamDeviceClassDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDeviceClassDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DeviceClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DeviceCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@ObjectiveMarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDeviceClassNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamDeviceClassID;
            parameters[1].Value = model.TempExamDeviceClassNumber2;
            parameters[2].Value = model.TempExamDeviceClassNumber3;
            parameters[3].Value = model.TempExamDeviceClassNumber4;
            parameters[4].Value = model.TempExamDeviceClassString1;
            parameters[5].Value = model.TempExamDeviceClassString2;
            parameters[6].Value = model.TempExamDeviceClassString3;
            parameters[7].Value = model.TempExamDeviceClassString4;
            parameters[8].Value = model.TempExamDeviceClassDatetime1;
            parameters[9].Value = model.TempExamDeviceClassDatetime2;
            parameters[10].Value = model.TempExamTableID;
            parameters[11].Value = model.TempExamStationID;
            parameters[12].Value = model.TempExamStationRoomID;
            parameters[13].Value = model.RoomID;
            parameters[14].Value = model.DeviceClassID;
            parameters[15].Value = model.DeviceCount;
            parameters[16].Value = model.ObjectiveMarkSheetID;
            parameters[17].Value = model.TempExamDeviceClassNumber1;
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
        public bool Delete(int TempExamDeviceClassID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamDeviceClass ");
            strSql.Append(" where TempExamDeviceClassID=@TempExamDeviceClassID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamDeviceClassID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamDeviceClassID;


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
        public bool DeleteList(string TempExamDeviceClassIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamDeviceClass ");
            strSql.Append(" where ID in (" + TempExamDeviceClassIDlist + ")  ");
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
        public Model.TempExamDeviceClass GetModel(int TempExamDeviceClassID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamDeviceClassID, TempExamDeviceClassNumber2, TempExamDeviceClassNumber3, TempExamDeviceClassNumber4, TempExamDeviceClassString1, TempExamDeviceClassString2, TempExamDeviceClassString3, TempExamDeviceClassString4, TempExamDeviceClassDatetime1, TempExamDeviceClassDatetime2, TempExamTableID, TempExamStationID, TempExamStationRoomID, RoomID, DeviceClassID, DeviceCount, ObjectiveMarkSheetID, TempExamDeviceClassNumber1  ");
            strSql.Append("  from TempExamDeviceClass ");
            strSql.Append(" where TempExamDeviceClassID=@TempExamDeviceClassID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamDeviceClassID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamDeviceClassID;


            Model.TempExamDeviceClass model = new Model.TempExamDeviceClass();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassID"].ToString() != "")
                {
                    model.TempExamDeviceClassID = int.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassNumber2"].ToString() != "")
                {
                    model.TempExamDeviceClassNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassNumber3"].ToString() != "")
                {
                    model.TempExamDeviceClassNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassNumber4"].ToString() != "")
                {
                    model.TempExamDeviceClassNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassNumber4"].ToString());
                }
                model.TempExamDeviceClassString1 = ds.Tables[0].Rows[0]["TempExamDeviceClassString1"].ToString();
                model.TempExamDeviceClassString2 = ds.Tables[0].Rows[0]["TempExamDeviceClassString2"].ToString();
                model.TempExamDeviceClassString3 = ds.Tables[0].Rows[0]["TempExamDeviceClassString3"].ToString();
                model.TempExamDeviceClassString4 = ds.Tables[0].Rows[0]["TempExamDeviceClassString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassDatetime1"].ToString() != "")
                {
                    model.TempExamDeviceClassDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassDatetime2"].ToString() != "")
                {
                    model.TempExamDeviceClassDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassDatetime2"].ToString());
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
                if (ds.Tables[0].Rows[0]["DeviceClassID"].ToString() != "")
                {
                    model.DeviceClassID = int.Parse(ds.Tables[0].Rows[0]["DeviceClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeviceCount"].ToString() != "")
                {
                    model.DeviceCount = int.Parse(ds.Tables[0].Rows[0]["DeviceCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ObjectiveMarkSheetID"].ToString() != "")
                {
                    model.ObjectiveMarkSheetID = int.Parse(ds.Tables[0].Rows[0]["ObjectiveMarkSheetID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDeviceClassNumber1"].ToString() != "")
                {
                    model.TempExamDeviceClassNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamDeviceClassNumber1"].ToString());
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
            strSql.Append(" FROM TempExamDeviceClass ");
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
            strSql.Append(" FROM TempExamDeviceClass ");
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
            if (conditionDictionary.ContainsKey("TempExamStationID,Eq"))
            {
                criteria.Add(Restrictions.Eq("TempExamStationID", conditionDictionary["TempExamStationID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("TempExamTableID,eq"))
            {
                criteria.Add(Restrictions.Eq("TempExamTableID", conditionDictionary["TempExamTableID,eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
