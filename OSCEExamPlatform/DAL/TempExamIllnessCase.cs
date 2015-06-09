using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using Tellyes.DBUtility;
using System.Data.SqlClient;

namespace Tellyes.DAL
{
    public class TempExamIllnessCase : BaseDAL<Model.TempExamIllnessCase>
    {
        #region Base Method

        public bool Exists(int TempExamIllnessCaseID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamIllnessCase");
            strSql.Append(" where ");
            strSql.Append(" TempExamIllnessCaseID = @TempExamIllnessCaseID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamIllnessCaseID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamIllnessCaseID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamIllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamIllnessCase(");
            strSql.Append("TempExamIllnessCaseNumber2,TempExamIllnessCaseNumber3,TempExamIllnessCaseNumber4,TempExamIllnessCaseString1,TempExamIllnessCaseString2,TempExamIllnessCaseString3,TempExamIllnessCaseString4,TempExamIllnessCaseDatetime1,TempExamIllnessCaseDatetime2,TempExamTableID,TempExamStationID,TempExamStationRoomID,RoomID,IllnessCaseID,IllnessCaseScriptID,MarkSheetID,TempExamIllnessCaseNumber1");
            strSql.Append(") values (");
            strSql.Append("@TempExamIllnessCaseNumber2,@TempExamIllnessCaseNumber3,@TempExamIllnessCaseNumber4,@TempExamIllnessCaseString1,@TempExamIllnessCaseString2,@TempExamIllnessCaseString3,@TempExamIllnessCaseString4,@TempExamIllnessCaseDatetime1,@TempExamIllnessCaseDatetime2,@TempExamTableID,@TempExamStationID,@TempExamStationRoomID,@RoomID,@IllnessCaseID,@IllnessCaseScriptID,@MarkSheetID,@TempExamIllnessCaseNumber1");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamIllnessCaseNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamIllnessCaseString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamIllnessCaseString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamIllnessCaseString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamIllnessCaseString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamIllnessCaseDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamIllnessCaseDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamIllnessCaseNumber2;
            parameters[1].Value = model.TempExamIllnessCaseNumber3;
            parameters[2].Value = model.TempExamIllnessCaseNumber4;
            parameters[3].Value = model.TempExamIllnessCaseString1;
            parameters[4].Value = model.TempExamIllnessCaseString2;
            parameters[5].Value = model.TempExamIllnessCaseString3;
            parameters[6].Value = model.TempExamIllnessCaseString4;
            parameters[7].Value = model.TempExamIllnessCaseDatetime1;
            parameters[8].Value = model.TempExamIllnessCaseDatetime2;
            parameters[9].Value = Guid.NewGuid();
            parameters[10].Value = Guid.NewGuid();
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.RoomID;
            parameters[13].Value = model.IllnessCaseID;
            parameters[14].Value = model.IllnessCaseScriptID;
            parameters[15].Value = model.MarkSheetID;
            parameters[16].Value = model.TempExamIllnessCaseNumber1;

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
        public bool Update(Model.TempExamIllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamIllnessCase set ");

            strSql.Append(" TempExamIllnessCaseNumber2 = @TempExamIllnessCaseNumber2 , ");
            strSql.Append(" TempExamIllnessCaseNumber3 = @TempExamIllnessCaseNumber3 , ");
            strSql.Append(" TempExamIllnessCaseNumber4 = @TempExamIllnessCaseNumber4 , ");
            strSql.Append(" TempExamIllnessCaseString1 = @TempExamIllnessCaseString1 , ");
            strSql.Append(" TempExamIllnessCaseString2 = @TempExamIllnessCaseString2 , ");
            strSql.Append(" TempExamIllnessCaseString3 = @TempExamIllnessCaseString3 , ");
            strSql.Append(" TempExamIllnessCaseString4 = @TempExamIllnessCaseString4 , ");
            strSql.Append(" TempExamIllnessCaseDatetime1 = @TempExamIllnessCaseDatetime1 , ");
            strSql.Append(" TempExamIllnessCaseDatetime2 = @TempExamIllnessCaseDatetime2 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" TempExamStationRoomID = @TempExamStationRoomID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" IllnessCaseID = @IllnessCaseID , ");
            strSql.Append(" IllnessCaseScriptID = @IllnessCaseScriptID , ");
            strSql.Append(" MarkSheetID = @MarkSheetID , ");
            strSql.Append(" TempExamIllnessCaseNumber1 = @TempExamIllnessCaseNumber1  ");
            strSql.Append(" where TempExamIllnessCaseID=@TempExamIllnessCaseID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamIllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamIllnessCaseString1", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamIllnessCaseString2", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamIllnessCaseString3", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamIllnessCaseString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamIllnessCaseDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamIllnessCaseDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationRoomID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4) ,            
                        new SqlParameter("@MarkSheetID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIllnessCaseNumber1", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamIllnessCaseID;
            parameters[1].Value = model.TempExamIllnessCaseNumber2;
            parameters[2].Value = model.TempExamIllnessCaseNumber3;
            parameters[3].Value = model.TempExamIllnessCaseNumber4;
            parameters[4].Value = model.TempExamIllnessCaseString1;
            parameters[5].Value = model.TempExamIllnessCaseString2;
            parameters[6].Value = model.TempExamIllnessCaseString3;
            parameters[7].Value = model.TempExamIllnessCaseString4;
            parameters[8].Value = model.TempExamIllnessCaseDatetime1;
            parameters[9].Value = model.TempExamIllnessCaseDatetime2;
            parameters[10].Value = model.TempExamTableID;
            parameters[11].Value = model.TempExamStationID;
            parameters[12].Value = model.TempExamStationRoomID;
            parameters[13].Value = model.RoomID;
            parameters[14].Value = model.IllnessCaseID;
            parameters[15].Value = model.IllnessCaseScriptID;
            parameters[16].Value = model.MarkSheetID;
            parameters[17].Value = model.TempExamIllnessCaseNumber1;
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
        public bool Delete(int TempExamIllnessCaseID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamIllnessCase ");
            strSql.Append(" where TempExamIllnessCaseID=@TempExamIllnessCaseID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamIllnessCaseID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamIllnessCaseID;


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
        public bool DeleteList(string TempExamIllnessCaseIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamIllnessCase ");
            strSql.Append(" where ID in (" + TempExamIllnessCaseIDlist + ")  ");
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
        public Model.TempExamIllnessCase GetModel(int TempExamIllnessCaseID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamIllnessCaseID, TempExamIllnessCaseNumber2, TempExamIllnessCaseNumber3, TempExamIllnessCaseNumber4, TempExamIllnessCaseString1, TempExamIllnessCaseString2, TempExamIllnessCaseString3, TempExamIllnessCaseString4, TempExamIllnessCaseDatetime1, TempExamIllnessCaseDatetime2, TempExamTableID, TempExamStationID, TempExamStationRoomID, RoomID, IllnessCaseID, IllnessCaseScriptID, MarkSheetID, TempExamIllnessCaseNumber1  ");
            strSql.Append("  from TempExamIllnessCase ");
            strSql.Append(" where TempExamIllnessCaseID=@TempExamIllnessCaseID");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamIllnessCaseID", SqlDbType.Int,4)
			};
            parameters[0].Value = TempExamIllnessCaseID;


            Model.TempExamIllnessCase model = new Model.TempExamIllnessCase();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseID"].ToString() != "")
                {
                    model.TempExamIllnessCaseID = int.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber2"].ToString() != "")
                {
                    model.TempExamIllnessCaseNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber3"].ToString() != "")
                {
                    model.TempExamIllnessCaseNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber4"].ToString() != "")
                {
                    model.TempExamIllnessCaseNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber4"].ToString());
                }
                model.TempExamIllnessCaseString1 = ds.Tables[0].Rows[0]["TempExamIllnessCaseString1"].ToString();
                model.TempExamIllnessCaseString2 = ds.Tables[0].Rows[0]["TempExamIllnessCaseString2"].ToString();
                model.TempExamIllnessCaseString3 = ds.Tables[0].Rows[0]["TempExamIllnessCaseString3"].ToString();
                model.TempExamIllnessCaseString4 = ds.Tables[0].Rows[0]["TempExamIllnessCaseString4"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseDatetime1"].ToString() != "")
                {
                    model.TempExamIllnessCaseDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseDatetime2"].ToString() != "")
                {
                    model.TempExamIllnessCaseDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseDatetime2"].ToString());
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
                if (ds.Tables[0].Rows[0]["IllnessCaseID"].ToString() != "")
                {
                    model.IllnessCaseID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString() != "")
                {
                    model.IllnessCaseScriptID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MarkSheetID"].ToString() != "")
                {
                    model.MarkSheetID = int.Parse(ds.Tables[0].Rows[0]["MarkSheetID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber1"].ToString() != "")
                {
                    model.TempExamIllnessCaseNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamIllnessCaseNumber1"].ToString());
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
            strSql.Append(" FROM TempExamIllnessCase ");
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
            strSql.Append(" FROM TempExamIllnessCase ");
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
            return criteria;
        }

        #endregion
    }
}
