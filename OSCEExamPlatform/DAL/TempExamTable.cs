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
using Tellyes.Log4Net;
using System.Transactions;

namespace Tellyes.DAL
{
    public class TempExamTable : BaseDAL<Model.TempExamTable>
    {
        #region Base Method

        public bool Exists(Guid TempExamTableID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamTable");
            strSql.Append(" where ");
            strSql.Append(" TempExamTableID = @TempExamTableID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamTableID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamTable(");
            strSql.Append("TempExamTableID,TempExamLongExamMinute,TempExamLongScoreMinute,TempExamShortExamMinute,TempExamShortScoreMinute,TempExamIsOpenScore,TempExamIsOpenVideo,TempExamIsComplete,TempExamState,TempExamCreateTime,TempExamLastModifyTime,TempExamName,TempExamUserInfoID,TempExamNumber1,TempExamNumber2,TempExamNumber3,TempExamNumber4,TempExamNumber5,TempExamNumber6,TempExamNumber7,TempExamNumber8,TempExamNumber9,TempExamKind,TempExamString1,TempExamString2,TempExamString3,TempExamString4,TempExamString5,TempExamString6,TempExamString7,TempExamString8,TempExamString9,TempExamDatetime1,ExamClassID,TempExamDatetime2,TempExamDatetime3,TempExamDatetime4,TempExamDatetime5,TempExamDatetime6,TempExamStudentCount,TempExamStationCount,TempExamRoomCount,TempExamStartTime,TempExamEndTime");
            strSql.Append(") values (");
            strSql.Append("@TempExamTableID,@TempExamLongExamMinute,@TempExamLongScoreMinute,@TempExamShortExamMinute,@TempExamShortScoreMinute,@TempExamIsOpenScore,@TempExamIsOpenVideo,@TempExamIsComplete,@TempExamState,@TempExamCreateTime,@TempExamLastModifyTime,@TempExamName,@TempExamUserInfoID,@TempExamNumber1,@TempExamNumber2,@TempExamNumber3,@TempExamNumber4,@TempExamNumber5,@TempExamNumber6,@TempExamNumber7,@TempExamNumber8,@TempExamNumber9,@TempExamKind,@TempExamString1,@TempExamString2,@TempExamString3,@TempExamString4,@TempExamString5,@TempExamString6,@TempExamString7,@TempExamString8,@TempExamString9,@TempExamDatetime1,@ExamClassID,@TempExamDatetime2,@TempExamDatetime3,@TempExamDatetime4,@TempExamDatetime5,@TempExamDatetime6,@TempExamStudentCount,@TempExamStationCount,@TempExamRoomCount,@TempExamStartTime,@TempExamEndTime");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamLongExamMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamLongScoreMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamShortExamMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamShortScoreMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsOpenScore", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsOpenVideo", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamState", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamCreateTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamLastModifyTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber4", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamKind", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStudentCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamRoomCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamEndTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.TempExamLongExamMinute;
            parameters[2].Value = model.TempExamLongScoreMinute;
            parameters[3].Value = model.TempExamShortExamMinute;
            parameters[4].Value = model.TempExamShortScoreMinute;
            parameters[5].Value = model.TempExamIsOpenScore;
            parameters[6].Value = model.TempExamIsOpenVideo;
            parameters[7].Value = model.TempExamIsComplete;
            parameters[8].Value = model.TempExamState;
            parameters[9].Value = model.TempExamCreateTime;
            parameters[10].Value = model.TempExamLastModifyTime;
            parameters[11].Value = model.TempExamName;
            parameters[12].Value = model.TempExamUserInfoID;
            parameters[13].Value = model.TempExamNumber1;
            parameters[14].Value = model.TempExamNumber2;
            parameters[15].Value = model.TempExamNumber3;
            parameters[16].Value = model.TempExamNumber4;
            parameters[17].Value = model.TempExamNumber5;
            parameters[18].Value = model.TempExamNumber6;
            parameters[19].Value = model.TempExamNumber7;
            parameters[20].Value = model.TempExamNumber8;
            parameters[21].Value = model.TempExamNumber9;
            parameters[22].Value = model.TempExamKind;
            parameters[23].Value = model.TempExamString1;
            parameters[24].Value = model.TempExamString2;
            parameters[25].Value = model.TempExamString3;
            parameters[26].Value = model.TempExamString4;
            parameters[27].Value = model.TempExamString5;
            parameters[28].Value = model.TempExamString6;
            parameters[29].Value = model.TempExamString7;
            parameters[30].Value = model.TempExamString8;
            parameters[31].Value = model.TempExamString9;
            parameters[32].Value = model.TempExamDatetime1;
            parameters[33].Value = model.ExamClassID;
            parameters[34].Value = model.TempExamDatetime2;
            parameters[35].Value = model.TempExamDatetime3;
            parameters[36].Value = model.TempExamDatetime4;
            parameters[37].Value = model.TempExamDatetime5;
            parameters[38].Value = model.TempExamDatetime6;
            parameters[39].Value = model.TempExamStudentCount;
            parameters[40].Value = model.TempExamStationCount;
            parameters[41].Value = model.TempExamRoomCount;
            parameters[42].Value = model.TempExamStartTime;
            parameters[43].Value = model.TempExamEndTime;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamTable set ");

            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamLongExamMinute = @TempExamLongExamMinute , ");
            strSql.Append(" TempExamLongScoreMinute = @TempExamLongScoreMinute , ");
            strSql.Append(" TempExamShortExamMinute = @TempExamShortExamMinute , ");
            strSql.Append(" TempExamShortScoreMinute = @TempExamShortScoreMinute , ");
            strSql.Append(" TempExamIsOpenScore = @TempExamIsOpenScore , ");
            strSql.Append(" TempExamIsOpenVideo = @TempExamIsOpenVideo , ");
            strSql.Append(" TempExamIsComplete = @TempExamIsComplete , ");
            strSql.Append(" TempExamState = @TempExamState , ");
            strSql.Append(" TempExamCreateTime = @TempExamCreateTime , ");
            strSql.Append(" TempExamLastModifyTime = @TempExamLastModifyTime , ");
            strSql.Append(" TempExamName = @TempExamName , ");
            strSql.Append(" TempExamUserInfoID = @TempExamUserInfoID , ");
            strSql.Append(" TempExamNumber1 = @TempExamNumber1 , ");
            strSql.Append(" TempExamNumber2 = @TempExamNumber2 , ");
            strSql.Append(" TempExamNumber3 = @TempExamNumber3 , ");
            strSql.Append(" TempExamNumber4 = @TempExamNumber4 , ");
            strSql.Append(" TempExamNumber5 = @TempExamNumber5 , ");
            strSql.Append(" TempExamNumber6 = @TempExamNumber6 , ");
            strSql.Append(" TempExamNumber7 = @TempExamNumber7 , ");
            strSql.Append(" TempExamNumber8 = @TempExamNumber8 , ");
            strSql.Append(" TempExamNumber9 = @TempExamNumber9 , ");
            strSql.Append(" TempExamKind = @TempExamKind , ");
            strSql.Append(" TempExamString1 = @TempExamString1 , ");
            strSql.Append(" TempExamString2 = @TempExamString2 , ");
            strSql.Append(" TempExamString3 = @TempExamString3 , ");
            strSql.Append(" TempExamString4 = @TempExamString4 , ");
            strSql.Append(" TempExamString5 = @TempExamString5 , ");
            strSql.Append(" TempExamString6 = @TempExamString6 , ");
            strSql.Append(" TempExamString7 = @TempExamString7 , ");
            strSql.Append(" TempExamString8 = @TempExamString8 , ");
            strSql.Append(" TempExamString9 = @TempExamString9 , ");
            strSql.Append(" TempExamDatetime1 = @TempExamDatetime1 , ");
            strSql.Append(" ExamClassID = @ExamClassID , ");
            strSql.Append(" TempExamDatetime2 = @TempExamDatetime2 , ");
            strSql.Append(" TempExamDatetime3 = @TempExamDatetime3 , ");
            strSql.Append(" TempExamDatetime4 = @TempExamDatetime4 , ");
            strSql.Append(" TempExamDatetime5 = @TempExamDatetime5 , ");
            strSql.Append(" TempExamDatetime6 = @TempExamDatetime6 , ");
            strSql.Append(" TempExamStudentCount = @TempExamStudentCount , ");
            strSql.Append(" TempExamStationCount = @TempExamStationCount , ");
            strSql.Append(" TempExamRoomCount = @TempExamRoomCount , ");
            strSql.Append(" TempExamStartTime = @TempExamStartTime , ");
            strSql.Append(" TempExamEndTime = @TempExamEndTime  ");
            strSql.Append(" where TempExamTableID=@TempExamTableID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamLongExamMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamLongScoreMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamShortExamMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamShortScoreMinute", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsOpenScore", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsOpenVideo", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamState", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamCreateTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamLastModifyTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamNumber4", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamKind", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStudentCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamRoomCount", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamEndTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.TempExamTableID;
            parameters[1].Value = model.TempExamLongExamMinute;
            parameters[2].Value = model.TempExamLongScoreMinute;
            parameters[3].Value = model.TempExamShortExamMinute;
            parameters[4].Value = model.TempExamShortScoreMinute;
            parameters[5].Value = model.TempExamIsOpenScore;
            parameters[6].Value = model.TempExamIsOpenVideo;
            parameters[7].Value = model.TempExamIsComplete;
            parameters[8].Value = model.TempExamState;
            parameters[9].Value = model.TempExamCreateTime;
            parameters[10].Value = model.TempExamLastModifyTime;
            parameters[11].Value = model.TempExamName;
            parameters[12].Value = model.TempExamUserInfoID;
            parameters[13].Value = model.TempExamNumber1;
            parameters[14].Value = model.TempExamNumber2;
            parameters[15].Value = model.TempExamNumber3;
            parameters[16].Value = model.TempExamNumber4;
            parameters[17].Value = model.TempExamNumber5;
            parameters[18].Value = model.TempExamNumber6;
            parameters[19].Value = model.TempExamNumber7;
            parameters[20].Value = model.TempExamNumber8;
            parameters[21].Value = model.TempExamNumber9;
            parameters[22].Value = model.TempExamKind;
            parameters[23].Value = model.TempExamString1;
            parameters[24].Value = model.TempExamString2;
            parameters[25].Value = model.TempExamString3;
            parameters[26].Value = model.TempExamString4;
            parameters[27].Value = model.TempExamString5;
            parameters[28].Value = model.TempExamString6;
            parameters[29].Value = model.TempExamString7;
            parameters[30].Value = model.TempExamString8;
            parameters[31].Value = model.TempExamString9;
            parameters[32].Value = model.TempExamDatetime1;
            parameters[33].Value = model.ExamClassID;
            parameters[34].Value = model.TempExamDatetime2;
            parameters[35].Value = model.TempExamDatetime3;
            parameters[36].Value = model.TempExamDatetime4;
            parameters[37].Value = model.TempExamDatetime5;
            parameters[38].Value = model.TempExamDatetime6;
            parameters[39].Value = model.TempExamStudentCount;
            parameters[40].Value = model.TempExamStationCount;
            parameters[41].Value = model.TempExamRoomCount;
            parameters[42].Value = model.TempExamStartTime;
            parameters[43].Value = model.TempExamEndTime;
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
        public bool Delete(Guid TempExamTableID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamTable ");
            strSql.Append(" where TempExamTableID=@TempExamTableID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamTableID;


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
        public Model.TempExamTable GetModel(Guid TempExamTableID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamTableID, TempExamLongExamMinute, TempExamLongScoreMinute, TempExamShortExamMinute, TempExamShortScoreMinute, TempExamIsOpenScore, TempExamIsOpenVideo, TempExamIsComplete, TempExamState, TempExamCreateTime, TempExamLastModifyTime, TempExamName, TempExamUserInfoID, TempExamNumber1, TempExamNumber2, TempExamNumber3, TempExamNumber4, TempExamNumber5, TempExamNumber6, TempExamNumber7, TempExamNumber8, TempExamNumber9, TempExamKind, TempExamString1, TempExamString2, TempExamString3, TempExamString4, TempExamString5, TempExamString6, TempExamString7, TempExamString8, TempExamString9, TempExamDatetime1, ExamClassID, TempExamDatetime2, TempExamDatetime3, TempExamDatetime4, TempExamDatetime5, TempExamDatetime6, TempExamStudentCount, TempExamStationCount, TempExamRoomCount, TempExamStartTime, TempExamEndTime  ");
            strSql.Append("  from TempExamTable ");
            strSql.Append(" where TempExamTableID=@TempExamTableID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamTableID;


            Model.TempExamTable model = new Model.TempExamTable();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLongExamMinute"].ToString() != "")
                {
                    model.TempExamLongExamMinute = int.Parse(ds.Tables[0].Rows[0]["TempExamLongExamMinute"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLongScoreMinute"].ToString() != "")
                {
                    model.TempExamLongScoreMinute = int.Parse(ds.Tables[0].Rows[0]["TempExamLongScoreMinute"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamShortExamMinute"].ToString() != "")
                {
                    model.TempExamShortExamMinute = int.Parse(ds.Tables[0].Rows[0]["TempExamShortExamMinute"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamShortScoreMinute"].ToString() != "")
                {
                    model.TempExamShortScoreMinute = int.Parse(ds.Tables[0].Rows[0]["TempExamShortScoreMinute"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIsOpenScore"].ToString() != "")
                {
                    model.TempExamIsOpenScore = int.Parse(ds.Tables[0].Rows[0]["TempExamIsOpenScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIsOpenVideo"].ToString() != "")
                {
                    model.TempExamIsOpenVideo = int.Parse(ds.Tables[0].Rows[0]["TempExamIsOpenVideo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamIsComplete"].ToString() != "")
                {
                    model.TempExamIsComplete = int.Parse(ds.Tables[0].Rows[0]["TempExamIsComplete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamState"].ToString() != "")
                {
                    model.TempExamState = int.Parse(ds.Tables[0].Rows[0]["TempExamState"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamCreateTime"].ToString() != "")
                {
                    model.TempExamCreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamCreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamLastModifyTime"].ToString() != "")
                {
                    model.TempExamLastModifyTime = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamLastModifyTime"].ToString());
                }
                model.TempExamName = ds.Tables[0].Rows[0]["TempExamName"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamUserInfoID"].ToString() != "")
                {
                    model.TempExamUserInfoID = int.Parse(ds.Tables[0].Rows[0]["TempExamUserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber1"].ToString() != "")
                {
                    model.TempExamNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber2"].ToString() != "")
                {
                    model.TempExamNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber3"].ToString() != "")
                {
                    model.TempExamNumber3 = int.Parse(ds.Tables[0].Rows[0]["TempExamNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber4"].ToString() != "")
                {
                    model.TempExamNumber4 = long.Parse(ds.Tables[0].Rows[0]["TempExamNumber4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber5"].ToString() != "")
                {
                    model.TempExamNumber5 = long.Parse(ds.Tables[0].Rows[0]["TempExamNumber5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber6"].ToString() != "")
                {
                    model.TempExamNumber6 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamNumber6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber7"].ToString() != "")
                {
                    model.TempExamNumber7 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamNumber7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber8"].ToString() != "")
                {
                    model.TempExamNumber8 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamNumber8"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamNumber9"].ToString() != "")
                {
                    model.TempExamNumber9 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamNumber9"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamKind"].ToString() != "")
                {
                    model.TempExamKind = int.Parse(ds.Tables[0].Rows[0]["TempExamKind"].ToString());
                }
                model.TempExamString1 = ds.Tables[0].Rows[0]["TempExamString1"].ToString();
                model.TempExamString2 = ds.Tables[0].Rows[0]["TempExamString2"].ToString();
                model.TempExamString3 = ds.Tables[0].Rows[0]["TempExamString3"].ToString();
                model.TempExamString4 = ds.Tables[0].Rows[0]["TempExamString4"].ToString();
                model.TempExamString5 = ds.Tables[0].Rows[0]["TempExamString5"].ToString();
                model.TempExamString6 = ds.Tables[0].Rows[0]["TempExamString6"].ToString();
                model.TempExamString7 = ds.Tables[0].Rows[0]["TempExamString7"].ToString();
                model.TempExamString8 = ds.Tables[0].Rows[0]["TempExamString8"].ToString();
                model.TempExamString9 = ds.Tables[0].Rows[0]["TempExamString9"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamDatetime1"].ToString() != "")
                {
                    model.TempExamDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamClassID"].ToString() != "")
                {
                    model.ExamClassID = int.Parse(ds.Tables[0].Rows[0]["ExamClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDatetime2"].ToString() != "")
                {
                    model.TempExamDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDatetime3"].ToString() != "")
                {
                    model.TempExamDatetime3 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDatetime4"].ToString() != "")
                {
                    model.TempExamDatetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDatetime5"].ToString() != "")
                {
                    model.TempExamDatetime5 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamDatetime6"].ToString() != "")
                {
                    model.TempExamDatetime6 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamDatetime6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStudentCount"].ToString() != "")
                {
                    model.TempExamStudentCount = int.Parse(ds.Tables[0].Rows[0]["TempExamStudentCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationCount"].ToString() != "")
                {
                    model.TempExamStationCount = int.Parse(ds.Tables[0].Rows[0]["TempExamStationCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamRoomCount"].ToString() != "")
                {
                    model.TempExamRoomCount = int.Parse(ds.Tables[0].Rows[0]["TempExamRoomCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStartTime"].ToString() != "")
                {
                    model.TempExamStartTime = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamEndTime"].ToString() != "")
                {
                    model.TempExamEndTime = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamEndTime"].ToString());
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
            strSql.Append(" FROM TempExamTable ");
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
            strSql.Append(" FROM TempExamTable ");
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
            if (conditionDictionary.ContainsKey("TempExamUserInfoID,EQ"))
            {
                criteria.Add(Restrictions.Eq("TempExamUserInfoID", conditionDictionary["TempExamUserInfoID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("TempExamName,Like"))
            {
                criteria.Add(Restrictions.Like("TempExamName", "%" + conditionDictionary["TempExamName,Like"] + "%"));
            }
            if (conditionDictionary.ContainsKey("TempExamKind,IN"))
            {
                criteria.Add(Restrictions.In("TempExamKind", (List<int>)conditionDictionary["TempExamKind,IN"]));
            }
            if (conditionDictionary.ContainsKey("TempExamState,IN"))
            {
                criteria.Add(Restrictions.In("TempExamState", (List<int>)conditionDictionary["TempExamState,IN"]));
            }
            if (conditionDictionary.ContainsKey("ExamClassID,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("ExamClassID"));
                criteria.Add(Restrictions.In("ExamClassID", (List<int>)conditionDictionary["ExamClassID,IN"]));
            }
            if (conditionDictionary.ContainsKey("TempExamStartTime,Earliest"))
            {
                criteria.Add(Restrictions.IsNotNull("TempExamEndTime"));
                criteria.Add(Restrictions.Ge("TempExamEndTime", conditionDictionary["TempExamStartTime,Earliest"]));
            }
            if (conditionDictionary.ContainsKey("TempExamEndTime,Latest"))
            {
                criteria.Add(Restrictions.IsNotNull("TempExamStartTime"));
                criteria.Add(Restrictions.Le("TempExamStartTime", conditionDictionary["TempExamEndTime,Latest"]));
            }
            return criteria;
        }

        public bool TransactionMulitySameTable(List<List<object>> modelObjectList)
        {
            string _connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            string ConStringEncrypt = System.Configuration.ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                _connectionString = DESEncrypt.Decrypt(_connectionString);
            }

            using (SqlConnection connection = new SqlConnection(DbHelperSQL.connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.Connection = connection;

                try
                {
                    using (TransactionScope tsCope = new TransactionScope())
                    {
                        foreach (List<object> item in modelObjectList)
                        {
                            List<object> objectList = null;
                            if (item[1] is List<object>)
                            {
                                objectList = item[1] as List<object>;
                            }
                            else
                            {
                                objectList = new List<object>() { item[1] };
                            }

                            if (objectList.Count == 0)
                            {
                                continue;
                            }

                            Type modelObjectType = objectList[0].GetType();
                            string tableName = SessionManager.GetEntityTableName(modelObjectType.Name);
                            List<Dictionary<string, string>> entityPropertyList = SessionManager.GetEntityPropertyList(modelObjectType.Name);
                            if (entityPropertyList == null)
                            {
                                throw new Exception("查询实体对象属性集合失败");
                            }

                            if (item[0].Equals("insert") && objectList.Count > 0)
                            {
                                foreach (object modelObject in objectList)
                                {
                                    #region insert
                                    StringBuilder columnsNameList = new StringBuilder();
                                    StringBuilder columnsValueList = new StringBuilder();
                                    string columnsListFengefu = String.Empty;
                                    object modelObjectID = modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null);

                                    if (modelObjectID is Guid)
                                    {
                                        columnsNameList.Append(columnsListFengefu + "[" + entityPropertyList[0]["column"] + "]");
                                        columnsValueList.Append(columnsListFengefu + "'" + modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null).ToString() + "'");
                                        columnsListFengefu = ",";
                                    }

                                    for (int i = 1; i < entityPropertyList.Count; i++)
                                    {
                                        if (modelObjectType.GetProperty(entityPropertyList[i]["name"]).GetValue(modelObject, null) != null)
                                        {
                                            columnsNameList.Append(columnsListFengefu + "[" + entityPropertyList[i]["column"] + "]");
                                            columnsValueList.Append(columnsListFengefu + "'" + modelObjectType.GetProperty(entityPropertyList[i]["name"]).GetValue(modelObject, null).ToString() + "'");
                                            columnsListFengefu = ",";
                                        }
                                    }
                                    #endregion

                                    command.CommandText = "INSERT INTO [" + tableName + "](" + columnsNameList.ToString().Trim() + ") VALUES(" + columnsValueList.ToString().Trim() + ");";
                                    command.ExecuteNonQuery();
                                }
                            }
                            else if (item[0].Equals("delete") && objectList.Count > 0)
                            {
                                #region delete
                                foreach (object modelObject in objectList)
                                {
                                    object modelObjectID = modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null);
                                    string sql = " delete from [" + tableName + "] where [" + entityPropertyList[0]["column"] + "] = '" + modelObjectID.ToString().Trim() + "'; ";
                                    command.CommandText = sql;
                                    command.ExecuteNonQuery();
                                }
                                #endregion
                            }
                            else if (item[0].Equals("update") && objectList.Count > 0)
                            {
                                #region update
                                foreach (object modelObject in objectList)
                                {
                                    object modelObjectID = modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null);
                                    StringBuilder sqlContainer = new StringBuilder(" update [" + tableName + "] set ");
                                    string updateFengefu = String.Empty;
                                    for (int i = 1; i < entityPropertyList.Count; i++)
                                    {
                                        if (modelObjectType.GetProperty(entityPropertyList[i]["name"]).GetValue(modelObject, null) != null)
                                        {
                                            sqlContainer.Append(updateFengefu + " [" + entityPropertyList[i]["column"] + "] = '" + modelObjectType.GetProperty(entityPropertyList[i]["name"]).GetValue(modelObject, null).ToString() + "' ");
                                            updateFengefu = ",";
                                        }
                                    }
                                    sqlContainer.Append(" where [" + entityPropertyList[0]["column"] + "] = '" + modelObjectID.ToString().Trim() + "'; ");
                                    command.CommandText = sqlContainer.ToString().Trim();
                                    command.ExecuteNonQuery();
                                }
                                #endregion
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Log4NetUtility.Error(this, "事务执行失败", ex);
                    return false;
                }

            }
        }

        private string _filterContent(String content)
        {
            String flt = "'|and|exec|insert|select|delete|update|count|*|%|chr|mid|master|truncate|char|declare|; |or|-|+|,|'";
            String[] filter = flt.Split('|');
            for (int i = 0; i < filter.Length; i++)
            {
                content.Replace(filter[i], "");
            }
            return content;
        }

        #endregion
    }
}
