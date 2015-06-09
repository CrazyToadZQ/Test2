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
    public class IllnessCaseScript : BaseDAL<Model.IllnessCaseScript>
    {
        #region Basic
        public bool Exists(int IllnessCaseScriptID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from IllnessCaseScript");
            strSql.Append(" where ");
            strSql.Append(" IllnessCaseScriptID = @IllnessCaseScriptID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseScript model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IllnessCaseScript(");
            strSql.Append("IsValid,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,IllnessCaseScriptName,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,IllnessCaseID,Datetime4,IllnessCaseScriptContent,IllnessCaseScriptText,CreatorUserInfoID,CreateDatetime,ModifierUserInfoID,ModifyDatetime");
            strSql.Append(") values (");
            strSql.Append("@IsValid,@Number1,@Number2,@Number3,@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@IllnessCaseScriptName,@String2,@String3,@String4,@String5,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@IllnessCaseID,@Datetime4,@IllnessCaseScriptContent,@IllnessCaseScriptText,@CreatorUserInfoID,@CreateDatetime,@ModifierUserInfoID,@ModifyDatetime");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@IsValid", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@IllnessCaseScriptName", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@IllnessCaseScriptContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@IllnessCaseScriptText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@CreatorUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@ModifierUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDatetime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.IsValid;
            parameters[1].Value = model.Number1;
            parameters[2].Value = model.Number2;
            parameters[3].Value = model.Number3;
            parameters[4].Value = model.Number4;
            parameters[5].Value = model.Number5;
            parameters[6].Value = model.Number6;
            parameters[7].Value = model.Number7;
            parameters[8].Value = model.Number8;
            parameters[9].Value = model.String1;
            parameters[10].Value = model.IllnessCaseScriptName;
            parameters[11].Value = model.String2;
            parameters[12].Value = model.String3;
            parameters[13].Value = model.String4;
            parameters[14].Value = model.String5;
            parameters[15].Value = model.String6;
            parameters[16].Value = model.String7;
            parameters[17].Value = model.String8;
            parameters[18].Value = model.Datetime1;
            parameters[19].Value = model.Datetime2;
            parameters[20].Value = model.Datetime3;
            parameters[21].Value = model.IllnessCaseID;
            parameters[22].Value = model.Datetime4;
            parameters[23].Value = model.IllnessCaseScriptContent;
            parameters[24].Value = model.IllnessCaseScriptText;
            parameters[25].Value = model.CreatorUserInfoID;
            parameters[26].Value = model.CreateDatetime;
            parameters[27].Value = model.ModifierUserInfoID;
            parameters[28].Value = model.ModifyDatetime;

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
        public bool Update(Model.IllnessCaseScript model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update IllnessCaseScript set ");

            strSql.Append(" IsValid = @IsValid , ");
            strSql.Append(" Number1 = @Number1 , ");
            strSql.Append(" Number2 = @Number2 , ");
            strSql.Append(" Number3 = @Number3 , ");
            strSql.Append(" Number4 = @Number4 , ");
            strSql.Append(" Number5 = @Number5 , ");
            strSql.Append(" Number6 = @Number6 , ");
            strSql.Append(" Number7 = @Number7 , ");
            strSql.Append(" Number8 = @Number8 , ");
            strSql.Append(" String1 = @String1 , ");
            strSql.Append(" IllnessCaseScriptName = @IllnessCaseScriptName , ");
            strSql.Append(" String2 = @String2 , ");
            strSql.Append(" String3 = @String3 , ");
            strSql.Append(" String4 = @String4 , ");
            strSql.Append(" String5 = @String5 , ");
            strSql.Append(" String6 = @String6 , ");
            strSql.Append(" String7 = @String7 , ");
            strSql.Append(" String8 = @String8 , ");
            strSql.Append(" Datetime1 = @Datetime1 , ");
            strSql.Append(" Datetime2 = @Datetime2 , ");
            strSql.Append(" Datetime3 = @Datetime3 , ");
            strSql.Append(" IllnessCaseID = @IllnessCaseID , ");
            strSql.Append(" Datetime4 = @Datetime4 , ");
            strSql.Append(" IllnessCaseScriptContent = @IllnessCaseScriptContent , ");
            strSql.Append(" IllnessCaseScriptText = @IllnessCaseScriptText , ");
            strSql.Append(" CreatorUserInfoID = @CreatorUserInfoID , ");
            strSql.Append(" CreateDatetime = @CreateDatetime , ");
            strSql.Append(" ModifierUserInfoID = @ModifierUserInfoID , ");
            strSql.Append(" ModifyDatetime = @ModifyDatetime  ");
            strSql.Append(" where IllnessCaseScriptID=@IllnessCaseScriptID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsValid", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@IllnessCaseScriptName", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@IllnessCaseID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@IllnessCaseScriptContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@IllnessCaseScriptText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@CreatorUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDatetime", SqlDbType.DateTime) ,            
                        new SqlParameter("@ModifierUserInfoID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDatetime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.IllnessCaseScriptID;
            parameters[1].Value = model.IsValid;
            parameters[2].Value = model.Number1;
            parameters[3].Value = model.Number2;
            parameters[4].Value = model.Number3;
            parameters[5].Value = model.Number4;
            parameters[6].Value = model.Number5;
            parameters[7].Value = model.Number6;
            parameters[8].Value = model.Number7;
            parameters[9].Value = model.Number8;
            parameters[10].Value = model.String1;
            parameters[11].Value = model.IllnessCaseScriptName;
            parameters[12].Value = model.String2;
            parameters[13].Value = model.String3;
            parameters[14].Value = model.String4;
            parameters[15].Value = model.String5;
            parameters[16].Value = model.String6;
            parameters[17].Value = model.String7;
            parameters[18].Value = model.String8;
            parameters[19].Value = model.Datetime1;
            parameters[20].Value = model.Datetime2;
            parameters[21].Value = model.Datetime3;
            parameters[22].Value = model.IllnessCaseID;
            parameters[23].Value = model.Datetime4;
            parameters[24].Value = model.IllnessCaseScriptContent;
            parameters[25].Value = model.IllnessCaseScriptText;
            parameters[26].Value = model.CreatorUserInfoID;
            parameters[27].Value = model.CreateDatetime;
            parameters[28].Value = model.ModifierUserInfoID;
            parameters[29].Value = model.ModifyDatetime;
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
        public bool Delete(int IllnessCaseScriptID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseScript ");
            strSql.Append(" where IllnessCaseScriptID=@IllnessCaseScriptID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptID;


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
        public bool DeleteList(string IllnessCaseScriptIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from IllnessCaseScript ");
            strSql.Append(" where ID in (" + IllnessCaseScriptIDlist + ")  ");
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
        public Model.IllnessCaseScript GetModel(int IllnessCaseScriptID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select IllnessCaseScriptID, IsValid, Number1, Number2, Number3, Number4, Number5, Number6, Number7, Number8, String1, IllnessCaseScriptName, String2, String3, String4, String5, String6, String7, String8, Datetime1, Datetime2, Datetime3, IllnessCaseID, Datetime4, IllnessCaseScriptContent, IllnessCaseScriptText, CreatorUserInfoID, CreateDatetime, ModifierUserInfoID, ModifyDatetime  ");
            strSql.Append("  from IllnessCaseScript ");
            strSql.Append(" where IllnessCaseScriptID=@IllnessCaseScriptID");
            SqlParameter[] parameters = {
					new SqlParameter("@IllnessCaseScriptID", SqlDbType.Int,4)
			};
            parameters[0].Value = IllnessCaseScriptID;


            Model.IllnessCaseScript model = new Model.IllnessCaseScript();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString() != "")
                {
                    model.IllnessCaseScriptID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseScriptID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsValid"].ToString() != "")
                {
                    model.IsValid = int.Parse(ds.Tables[0].Rows[0]["IsValid"].ToString());
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
                model.IllnessCaseScriptName = ds.Tables[0].Rows[0]["IllnessCaseScriptName"].ToString();
                model.String2 = ds.Tables[0].Rows[0]["String2"].ToString();
                model.String3 = ds.Tables[0].Rows[0]["String3"].ToString();
                model.String4 = ds.Tables[0].Rows[0]["String4"].ToString();
                model.String5 = ds.Tables[0].Rows[0]["String5"].ToString();
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
                if (ds.Tables[0].Rows[0]["IllnessCaseID"].ToString() != "")
                {
                    model.IllnessCaseID = int.Parse(ds.Tables[0].Rows[0]["IllnessCaseID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Datetime4"].ToString() != "")
                {
                    model.Datetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime4"].ToString());
                }
                model.IllnessCaseScriptContent = ds.Tables[0].Rows[0]["IllnessCaseScriptContent"].ToString();
                model.IllnessCaseScriptText = ds.Tables[0].Rows[0]["IllnessCaseScriptText"].ToString();
                if (ds.Tables[0].Rows[0]["CreatorUserInfoID"].ToString() != "")
                {
                    model.CreatorUserInfoID = int.Parse(ds.Tables[0].Rows[0]["CreatorUserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateDatetime"].ToString() != "")
                {
                    model.CreateDatetime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateDatetime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModifierUserInfoID"].ToString() != "")
                {
                    model.ModifierUserInfoID = int.Parse(ds.Tables[0].Rows[0]["ModifierUserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModifyDatetime"].ToString() != "")
                {
                    model.ModifyDatetime = DateTime.Parse(ds.Tables[0].Rows[0]["ModifyDatetime"].ToString());
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
            strSql.Append(" FROM IllnessCaseScript ");
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
            strSql.Append(" FROM IllnessCaseScript ");
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
            if (conditionDictionary.ContainsKey("IsValid")) 
            {
                criteria.Add(Restrictions.Eq("IsValid", conditionDictionary["IsValid"]));
            }
            if (conditionDictionary.ContainsKey("IllnessCaseID"))
            {
                criteria.Add(Restrictions.Eq("IllnessCaseID", conditionDictionary["IllnessCaseID"]));
            }
            if (conditionDictionary.ContainsKey("IllnessCaseScriptIDList")) 
            {
                criteria.Add(Restrictions.In("IllnessCaseScriptID", (List<int>)conditionDictionary["IllnessCaseScriptIDList"]));
            }
            return criteria;
        }

        #endregion
        
    }
}
