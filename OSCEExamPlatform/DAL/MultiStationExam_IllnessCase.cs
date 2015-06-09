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
    public class MultiStationExam_IllnessCase : BaseDAL<Model.MultiStationExam_IllnessCase>
    {
        #region Basic
        public bool Exists(int Exam_Station_IllnessCase_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MultiStationExam_IllnessCase");
            strSql.Append(" where ");
            strSql.Append(" Exam_Station_IllnessCase_ID = @Exam_Station_IllnessCase_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_IllnessCase_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MultiStationExam_IllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MultiStationExam_IllnessCase(");
            strSql.Append("Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,Exam_ID,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4,Exam_Station_ID,Room_ID,Illness_Case_ID,Illness_Case_Script_ID,Number1,Number2,Number3");
            strSql.Append(") values (");
            strSql.Append("@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@String2,@String3,@String4,@String5,@Exam_ID,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@Datetime4,@Exam_Station_ID,@Room_ID,@Illness_Case_ID,@Illness_Case_Script_ID,@Number1,@Number2,@Number3");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@Exam_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@Exam_Station_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Illness_Case_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Illness_Case_Script_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number3", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Number4;
            parameters[1].Value = model.Number5;
            parameters[2].Value = model.Number6;
            parameters[3].Value = model.Number7;
            parameters[4].Value = model.Number8;
            parameters[5].Value = model.String1;
            parameters[6].Value = model.String2;
            parameters[7].Value = model.String3;
            parameters[8].Value = model.String4;
            parameters[9].Value = model.String5;
            parameters[10].Value = model.Exam_ID;
            parameters[11].Value = model.String6;
            parameters[12].Value = model.String7;
            parameters[13].Value = model.String8;
            parameters[14].Value = model.Datetime1;
            parameters[15].Value = model.Datetime2;
            parameters[16].Value = model.Datetime3;
            parameters[17].Value = model.Datetime4;
            parameters[18].Value = model.Exam_Station_ID;
            parameters[19].Value = model.Room_ID;
            parameters[20].Value = model.Illness_Case_ID;
            parameters[21].Value = model.Illness_Case_Script_ID;
            parameters[22].Value = model.Number1;
            parameters[23].Value = model.Number2;
            parameters[24].Value = model.Number3;

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
        public bool Update(Model.MultiStationExam_IllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MultiStationExam_IllnessCase set ");

            strSql.Append(" Number4 = @Number4 , ");
            strSql.Append(" Number5 = @Number5 , ");
            strSql.Append(" Number6 = @Number6 , ");
            strSql.Append(" Number7 = @Number7 , ");
            strSql.Append(" Number8 = @Number8 , ");
            strSql.Append(" String1 = @String1 , ");
            strSql.Append(" String2 = @String2 , ");
            strSql.Append(" String3 = @String3 , ");
            strSql.Append(" String4 = @String4 , ");
            strSql.Append(" String5 = @String5 , ");
            strSql.Append(" Exam_ID = @Exam_ID , ");
            strSql.Append(" String6 = @String6 , ");
            strSql.Append(" String7 = @String7 , ");
            strSql.Append(" String8 = @String8 , ");
            strSql.Append(" Datetime1 = @Datetime1 , ");
            strSql.Append(" Datetime2 = @Datetime2 , ");
            strSql.Append(" Datetime3 = @Datetime3 , ");
            strSql.Append(" Datetime4 = @Datetime4 , ");
            strSql.Append(" Exam_Station_ID = @Exam_Station_ID , ");
            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" Illness_Case_ID = @Illness_Case_ID , ");
            strSql.Append(" Illness_Case_Script_ID = @Illness_Case_Script_ID , ");
            strSql.Append(" Number1 = @Number1 , ");
            strSql.Append(" Number2 = @Number2 , ");
            strSql.Append(" Number3 = @Number3  ");
            strSql.Append(" where Exam_Station_IllnessCase_ID=@Exam_Station_IllnessCase_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@Exam_Station_IllnessCase_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@Exam_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@Exam_Station_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Illness_Case_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Illness_Case_Script_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number3", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Exam_Station_IllnessCase_ID;
            parameters[1].Value = model.Number4;
            parameters[2].Value = model.Number5;
            parameters[3].Value = model.Number6;
            parameters[4].Value = model.Number7;
            parameters[5].Value = model.Number8;
            parameters[6].Value = model.String1;
            parameters[7].Value = model.String2;
            parameters[8].Value = model.String3;
            parameters[9].Value = model.String4;
            parameters[10].Value = model.String5;
            parameters[11].Value = model.Exam_ID;
            parameters[12].Value = model.String6;
            parameters[13].Value = model.String7;
            parameters[14].Value = model.String8;
            parameters[15].Value = model.Datetime1;
            parameters[16].Value = model.Datetime2;
            parameters[17].Value = model.Datetime3;
            parameters[18].Value = model.Datetime4;
            parameters[19].Value = model.Exam_Station_ID;
            parameters[20].Value = model.Room_ID;
            parameters[21].Value = model.Illness_Case_ID;
            parameters[22].Value = model.Illness_Case_Script_ID;
            parameters[23].Value = model.Number1;
            parameters[24].Value = model.Number2;
            parameters[25].Value = model.Number3;
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
        public bool Delete(int Exam_Station_IllnessCase_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExam_IllnessCase ");
            strSql.Append(" where Exam_Station_IllnessCase_ID=@Exam_Station_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_IllnessCase_ID;


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
        public bool DeleteList(string Exam_Station_IllnessCase_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MultiStationExam_IllnessCase ");
            strSql.Append(" where ID in (" + Exam_Station_IllnessCase_IDlist + ")  ");
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
        public Model.MultiStationExam_IllnessCase GetModel(int Exam_Station_IllnessCase_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Exam_Station_IllnessCase_ID, Number4, Number5, Number6, Number7, Number8, String1, String2, String3, String4, String5, Exam_ID, String6, String7, String8, Datetime1, Datetime2, Datetime3, Datetime4, Exam_Station_ID, Room_ID, Illness_Case_ID, Illness_Case_Script_ID, Number1, Number2, Number3  ");
            strSql.Append("  from MultiStationExam_IllnessCase ");
            strSql.Append(" where Exam_Station_IllnessCase_ID=@Exam_Station_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Exam_Station_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Exam_Station_IllnessCase_ID;


            Model.MultiStationExam_IllnessCase model = new Model.MultiStationExam_IllnessCase();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Exam_Station_IllnessCase_ID"].ToString() != "")
                {
                    model.Exam_Station_IllnessCase_ID = int.Parse(ds.Tables[0].Rows[0]["Exam_Station_IllnessCase_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number4"].ToString() != "")
                {
                    model.Number4 = int.Parse(ds.Tables[0].Rows[0]["Number4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number5"].ToString() != "")
                {
                    model.Number5 = int.Parse(ds.Tables[0].Rows[0]["Number5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number6"].ToString() != "")
                {
                    model.Number6 = decimal.Parse(ds.Tables[0].Rows[0]["Number6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number7"].ToString() != "")
                {
                    model.Number7 = decimal.Parse(ds.Tables[0].Rows[0]["Number7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number8"].ToString() != "")
                {
                    model.Number8 = decimal.Parse(ds.Tables[0].Rows[0]["Number8"].ToString());
                }
                model.String1 = ds.Tables[0].Rows[0]["String1"].ToString();
                model.String2 = ds.Tables[0].Rows[0]["String2"].ToString();
                model.String3 = ds.Tables[0].Rows[0]["String3"].ToString();
                model.String4 = ds.Tables[0].Rows[0]["String4"].ToString();
                model.String5 = ds.Tables[0].Rows[0]["String5"].ToString();
                if (ds.Tables[0].Rows[0]["Exam_ID"].ToString() != "")
                {
                    model.Exam_ID = Guid.Parse(ds.Tables[0].Rows[0]["Exam_ID"].ToString());
                }
                model.String6 = ds.Tables[0].Rows[0]["String6"].ToString();
                model.String7 = ds.Tables[0].Rows[0]["String7"].ToString();
                model.String8 = ds.Tables[0].Rows[0]["String8"].ToString();
                if (ds.Tables[0].Rows[0]["Datetime1"].ToString() != "")
                {
                    model.Datetime1 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Datetime2"].ToString() != "")
                {
                    model.Datetime2 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Datetime3"].ToString() != "")
                {
                    model.Datetime3 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Datetime4"].ToString() != "")
                {
                    model.Datetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Exam_Station_ID"].ToString() != "")
                {
                    model.Exam_Station_ID = Guid.Parse(ds.Tables[0].Rows[0]["Exam_Station_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(ds.Tables[0].Rows[0]["Room_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Illness_Case_ID"].ToString() != "")
                {
                    model.Illness_Case_ID = int.Parse(ds.Tables[0].Rows[0]["Illness_Case_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Illness_Case_Script_ID"].ToString() != "")
                {
                    model.Illness_Case_Script_ID = int.Parse(ds.Tables[0].Rows[0]["Illness_Case_Script_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number1"].ToString() != "")
                {
                    model.Number1 = int.Parse(ds.Tables[0].Rows[0]["Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number2"].ToString() != "")
                {
                    model.Number2 = int.Parse(ds.Tables[0].Rows[0]["Number2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number3"].ToString() != "")
                {
                    model.Number3 = int.Parse(ds.Tables[0].Rows[0]["Number3"].ToString());
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
            strSql.Append(" FROM MultiStationExam_IllnessCase ");
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
            strSql.Append(" FROM MultiStationExam_IllnessCase ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion
        #region Extension
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Like("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,eq"))
            {
                criteria.Add(Restrictions.Like("ES_ID", conditionDictionary["ES_ID,eq"]));
            }
            return criteria;
        }
        #endregion
    }
}
