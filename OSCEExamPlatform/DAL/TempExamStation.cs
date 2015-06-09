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
    public class TempExamStation : BaseDAL<Model.TempExamStation>
    {
        #region Base Method

        public bool Exists(Guid TempExamStationID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TempExamStation");
            strSql.Append(" where ");
            strSql.Append(" TempExamStationID = @TempExamStationID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TempExamStation(");
            strSql.Append("TempExamStationID,TempExamStationIsComplete,TempExamStationNumber1,TempExamStationNumber2,TempExamStationNumber3,TempExamStationNumber4,TempExamStationNumber5,TempExamStationNumber6,TempExamStationNumber7,TempExamStationNumber8,TempExamStationNumber9,TempExamTableID,TempExamStationString1,TempExamStationString2,TempExamStationString3,TempExamStationString4,TempExamStationString5,TempExamStationString6,TempExamStationString7,TempExamStationString8,TempExamStationString9,TempExamStationDatetime1,ExamStationClassID,TempExamStationDatetime2,TempExamStationDatetime3,TempExamStationDatetime4,TempExamStationDatetime5,TempExamStationDatetime6,TempExamStationName,TempExamStationContent,TempExamStationCurriculum,TempExamStationKind,TempExamStationSubjectivePercent,TempExamStationOrderNumber");
            strSql.Append(") values (");
            strSql.Append("@TempExamStationID,@TempExamStationIsComplete,@TempExamStationNumber1,@TempExamStationNumber2,@TempExamStationNumber3,@TempExamStationNumber4,@TempExamStationNumber5,@TempExamStationNumber6,@TempExamStationNumber7,@TempExamStationNumber8,@TempExamStationNumber9,@TempExamTableID,@TempExamStationString1,@TempExamStationString2,@TempExamStationString3,@TempExamStationString4,@TempExamStationString5,@TempExamStationString6,@TempExamStationString7,@TempExamStationString8,@TempExamStationString9,@TempExamStationDatetime1,@ExamStationClassID,@TempExamStationDatetime2,@TempExamStationDatetime3,@TempExamStationDatetime4,@TempExamStationDatetime5,@TempExamStationDatetime6,@TempExamStationName,@TempExamStationContent,@TempExamStationCurriculum,@TempExamStationKind,@TempExamStationSubjectivePercent,@TempExamStationOrderNumber");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber4", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamStationString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStationString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStationString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStationDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamStationClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationContent", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationCurriculum", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationKind", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationSubjectivePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationOrderNumber", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.TempExamStationIsComplete;
            parameters[2].Value = model.TempExamStationNumber1;
            parameters[3].Value = model.TempExamStationNumber2;
            parameters[4].Value = model.TempExamStationNumber3;
            parameters[5].Value = model.TempExamStationNumber4;
            parameters[6].Value = model.TempExamStationNumber5;
            parameters[7].Value = model.TempExamStationNumber6;
            parameters[8].Value = model.TempExamStationNumber7;
            parameters[9].Value = model.TempExamStationNumber8;
            parameters[10].Value = model.TempExamStationNumber9;
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.TempExamStationString1;
            parameters[13].Value = model.TempExamStationString2;
            parameters[14].Value = model.TempExamStationString3;
            parameters[15].Value = model.TempExamStationString4;
            parameters[16].Value = model.TempExamStationString5;
            parameters[17].Value = model.TempExamStationString6;
            parameters[18].Value = model.TempExamStationString7;
            parameters[19].Value = model.TempExamStationString8;
            parameters[20].Value = model.TempExamStationString9;
            parameters[21].Value = model.TempExamStationDatetime1;
            parameters[22].Value = model.ExamStationClassID;
            parameters[23].Value = model.TempExamStationDatetime2;
            parameters[24].Value = model.TempExamStationDatetime3;
            parameters[25].Value = model.TempExamStationDatetime4;
            parameters[26].Value = model.TempExamStationDatetime5;
            parameters[27].Value = model.TempExamStationDatetime6;
            parameters[28].Value = model.TempExamStationName;
            parameters[29].Value = model.TempExamStationContent;
            parameters[30].Value = model.TempExamStationCurriculum;
            parameters[31].Value = model.TempExamStationKind;
            parameters[32].Value = model.TempExamStationSubjectivePercent;
            parameters[33].Value = model.TempExamStationOrderNumber;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TempExamStation set ");

            strSql.Append(" TempExamStationID = @TempExamStationID , ");
            strSql.Append(" TempExamStationIsComplete = @TempExamStationIsComplete , ");
            strSql.Append(" TempExamStationNumber1 = @TempExamStationNumber1 , ");
            strSql.Append(" TempExamStationNumber2 = @TempExamStationNumber2 , ");
            strSql.Append(" TempExamStationNumber3 = @TempExamStationNumber3 , ");
            strSql.Append(" TempExamStationNumber4 = @TempExamStationNumber4 , ");
            strSql.Append(" TempExamStationNumber5 = @TempExamStationNumber5 , ");
            strSql.Append(" TempExamStationNumber6 = @TempExamStationNumber6 , ");
            strSql.Append(" TempExamStationNumber7 = @TempExamStationNumber7 , ");
            strSql.Append(" TempExamStationNumber8 = @TempExamStationNumber8 , ");
            strSql.Append(" TempExamStationNumber9 = @TempExamStationNumber9 , ");
            strSql.Append(" TempExamTableID = @TempExamTableID , ");
            strSql.Append(" TempExamStationString1 = @TempExamStationString1 , ");
            strSql.Append(" TempExamStationString2 = @TempExamStationString2 , ");
            strSql.Append(" TempExamStationString3 = @TempExamStationString3 , ");
            strSql.Append(" TempExamStationString4 = @TempExamStationString4 , ");
            strSql.Append(" TempExamStationString5 = @TempExamStationString5 , ");
            strSql.Append(" TempExamStationString6 = @TempExamStationString6 , ");
            strSql.Append(" TempExamStationString7 = @TempExamStationString7 , ");
            strSql.Append(" TempExamStationString8 = @TempExamStationString8 , ");
            strSql.Append(" TempExamStationString9 = @TempExamStationString9 , ");
            strSql.Append(" TempExamStationDatetime1 = @TempExamStationDatetime1 , ");
            strSql.Append(" ExamStationClassID = @ExamStationClassID , ");
            strSql.Append(" TempExamStationDatetime2 = @TempExamStationDatetime2 , ");
            strSql.Append(" TempExamStationDatetime3 = @TempExamStationDatetime3 , ");
            strSql.Append(" TempExamStationDatetime4 = @TempExamStationDatetime4 , ");
            strSql.Append(" TempExamStationDatetime5 = @TempExamStationDatetime5 , ");
            strSql.Append(" TempExamStationDatetime6 = @TempExamStationDatetime6 , ");
            strSql.Append(" TempExamStationName = @TempExamStationName , ");
            strSql.Append(" TempExamStationContent = @TempExamStationContent , ");
            strSql.Append(" TempExamStationCurriculum = @TempExamStationCurriculum , ");
            strSql.Append(" TempExamStationKind = @TempExamStationKind , ");
            strSql.Append(" TempExamStationSubjectivePercent = @TempExamStationSubjectivePercent , ");
            strSql.Append(" TempExamStationOrderNumber = @TempExamStationOrderNumber  ");
            strSql.Append(" where TempExamStationID=@TempExamStationID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationIsComplete", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber3", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationNumber4", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationNumber5", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TempExamStationNumber6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamStationNumber9", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@TempExamTableID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TempExamStationString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationString2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationString3", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationString4", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@TempExamStationString5", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationString6", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("@TempExamStationString7", SqlDbType.NVarChar,2000) ,            
                        new SqlParameter("@TempExamStationString8", SqlDbType.NVarChar,4000) ,            
                        new SqlParameter("@TempExamStationString9", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@TempExamStationDatetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExamStationClassID", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationDatetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime5", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationDatetime6", SqlDbType.DateTime) ,            
                        new SqlParameter("@TempExamStationName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TempExamStationContent", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationCurriculum", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@TempExamStationKind", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationSubjectivePercent", SqlDbType.Int,4) ,            
                        new SqlParameter("@TempExamStationOrderNumber", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.TempExamStationID;
            parameters[1].Value = model.TempExamStationIsComplete;
            parameters[2].Value = model.TempExamStationNumber1;
            parameters[3].Value = model.TempExamStationNumber2;
            parameters[4].Value = model.TempExamStationNumber3;
            parameters[5].Value = model.TempExamStationNumber4;
            parameters[6].Value = model.TempExamStationNumber5;
            parameters[7].Value = model.TempExamStationNumber6;
            parameters[8].Value = model.TempExamStationNumber7;
            parameters[9].Value = model.TempExamStationNumber8;
            parameters[10].Value = model.TempExamStationNumber9;
            parameters[11].Value = model.TempExamTableID;
            parameters[12].Value = model.TempExamStationString1;
            parameters[13].Value = model.TempExamStationString2;
            parameters[14].Value = model.TempExamStationString3;
            parameters[15].Value = model.TempExamStationString4;
            parameters[16].Value = model.TempExamStationString5;
            parameters[17].Value = model.TempExamStationString6;
            parameters[18].Value = model.TempExamStationString7;
            parameters[19].Value = model.TempExamStationString8;
            parameters[20].Value = model.TempExamStationString9;
            parameters[21].Value = model.TempExamStationDatetime1;
            parameters[22].Value = model.ExamStationClassID;
            parameters[23].Value = model.TempExamStationDatetime2;
            parameters[24].Value = model.TempExamStationDatetime3;
            parameters[25].Value = model.TempExamStationDatetime4;
            parameters[26].Value = model.TempExamStationDatetime5;
            parameters[27].Value = model.TempExamStationDatetime6;
            parameters[28].Value = model.TempExamStationName;
            parameters[29].Value = model.TempExamStationContent;
            parameters[30].Value = model.TempExamStationCurriculum;
            parameters[31].Value = model.TempExamStationKind;
            parameters[32].Value = model.TempExamStationSubjectivePercent;
            parameters[33].Value = model.TempExamStationOrderNumber;
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
        public bool Delete(Guid TempExamStationID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TempExamStation ");
            strSql.Append(" where TempExamStationID=@TempExamStationID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationID;


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
        public Model.TempExamStation GetModel(Guid TempExamStationID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TempExamStationID, TempExamStationIsComplete, TempExamStationNumber1, TempExamStationNumber2, TempExamStationNumber3, TempExamStationNumber4, TempExamStationNumber5, TempExamStationNumber6, TempExamStationNumber7, TempExamStationNumber8, TempExamStationNumber9, TempExamTableID, TempExamStationString1, TempExamStationString2, TempExamStationString3, TempExamStationString4, TempExamStationString5, TempExamStationString6, TempExamStationString7, TempExamStationString8, TempExamStationString9, TempExamStationDatetime1, ExamStationClassID, TempExamStationDatetime2, TempExamStationDatetime3, TempExamStationDatetime4, TempExamStationDatetime5, TempExamStationDatetime6, TempExamStationName, TempExamStationContent, TempExamStationCurriculum, TempExamStationKind, TempExamStationSubjectivePercent, TempExamStationOrderNumber  ");
            strSql.Append("  from TempExamStation ");
            strSql.Append(" where TempExamStationID=@TempExamStationID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempExamStationID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = TempExamStationID;


            Model.TempExamStation model = new Model.TempExamStation();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["TempExamStationID"].ToString() != "")
                {
                    model.TempExamStationID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamStationID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationIsComplete"].ToString() != "")
                {
                    model.TempExamStationIsComplete = int.Parse(ds.Tables[0].Rows[0]["TempExamStationIsComplete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber1"].ToString() != "")
                {
                    model.TempExamStationNumber1 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber2"].ToString() != "")
                {
                    model.TempExamStationNumber2 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber3"].ToString() != "")
                {
                    model.TempExamStationNumber3 = int.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber4"].ToString() != "")
                {
                    model.TempExamStationNumber4 = long.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber5"].ToString() != "")
                {
                    model.TempExamStationNumber5 = long.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber6"].ToString() != "")
                {
                    model.TempExamStationNumber6 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber7"].ToString() != "")
                {
                    model.TempExamStationNumber7 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber8"].ToString() != "")
                {
                    model.TempExamStationNumber8 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber8"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationNumber9"].ToString() != "")
                {
                    model.TempExamStationNumber9 = decimal.Parse(ds.Tables[0].Rows[0]["TempExamStationNumber9"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamTableID"].ToString() != "")
                {
                    model.TempExamTableID = Guid.Parse(ds.Tables[0].Rows[0]["TempExamTableID"].ToString());
                }
                model.TempExamStationString1 = ds.Tables[0].Rows[0]["TempExamStationString1"].ToString();
                model.TempExamStationString2 = ds.Tables[0].Rows[0]["TempExamStationString2"].ToString();
                model.TempExamStationString3 = ds.Tables[0].Rows[0]["TempExamStationString3"].ToString();
                model.TempExamStationString4 = ds.Tables[0].Rows[0]["TempExamStationString4"].ToString();
                model.TempExamStationString5 = ds.Tables[0].Rows[0]["TempExamStationString5"].ToString();
                model.TempExamStationString6 = ds.Tables[0].Rows[0]["TempExamStationString6"].ToString();
                model.TempExamStationString7 = ds.Tables[0].Rows[0]["TempExamStationString7"].ToString();
                model.TempExamStationString8 = ds.Tables[0].Rows[0]["TempExamStationString8"].ToString();
                model.TempExamStationString9 = ds.Tables[0].Rows[0]["TempExamStationString9"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime1"].ToString() != "")
                {
                    model.TempExamStationDatetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamStationClassID"].ToString() != "")
                {
                    model.ExamStationClassID = int.Parse(ds.Tables[0].Rows[0]["ExamStationClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime2"].ToString() != "")
                {
                    model.TempExamStationDatetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime3"].ToString() != "")
                {
                    model.TempExamStationDatetime3 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime4"].ToString() != "")
                {
                    model.TempExamStationDatetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime5"].ToString() != "")
                {
                    model.TempExamStationDatetime5 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationDatetime6"].ToString() != "")
                {
                    model.TempExamStationDatetime6 = DateTime.Parse(ds.Tables[0].Rows[0]["TempExamStationDatetime6"].ToString());
                }
                model.TempExamStationName = ds.Tables[0].Rows[0]["TempExamStationName"].ToString();
                model.TempExamStationContent = ds.Tables[0].Rows[0]["TempExamStationContent"].ToString();
                model.TempExamStationCurriculum = ds.Tables[0].Rows[0]["TempExamStationCurriculum"].ToString();
                if (ds.Tables[0].Rows[0]["TempExamStationKind"].ToString() != "")
                {
                    model.TempExamStationKind = int.Parse(ds.Tables[0].Rows[0]["TempExamStationKind"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationSubjectivePercent"].ToString() != "")
                {
                    model.TempExamStationSubjectivePercent = int.Parse(ds.Tables[0].Rows[0]["TempExamStationSubjectivePercent"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TempExamStationOrderNumber"].ToString() != "")
                {
                    model.TempExamStationOrderNumber = int.Parse(ds.Tables[0].Rows[0]["TempExamStationOrderNumber"].ToString());
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
            strSql.Append(" FROM TempExamStation ");
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
            strSql.Append(" FROM TempExamStation ");
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
            if (conditionDictionary.ContainsKey("TempExamTableID,eq"))
            {
                criteria.Add(Restrictions.Eq("TempExamTableID", conditionDictionary["TempExamTableID,eq"]));
            }
            return criteria;
        }

        #endregion
    }
}
