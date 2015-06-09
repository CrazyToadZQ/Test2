using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
    //预约资源表
    public partial class ReservationResource
    {

        public bool Exists(int Reservation_Res_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReservationResource");
            strSql.Append(" where ");
            strSql.Append(" Reservation_Res_ID = @Reservation_Res_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@Reservation_Res_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Reservation_Res_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ReservationResource model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReservationResource(");
            strSql.Append("Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,Reservation_ID,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4,Resource_Type,ResourceID,Resource_Code,Resource_Name,EnityID,Number1,Number2");
            strSql.Append(") values (");
            strSql.Append("@Number3,@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@String2,@String3,@String4,@Reservation_ID,@String5,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@Datetime4,@Resource_Type,@ResourceID,@Resource_Code,@Resource_Name,@EnityID,@Number1,@Number2");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@Reservation_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@Resource_Type", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@ResourceID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Resource_Code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Resource_Name", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@EnityID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Number3;
            parameters[1].Value = model.Number4;
            parameters[2].Value = model.Number5;
            parameters[3].Value = model.Number6;
            parameters[4].Value = model.Number7;
            parameters[5].Value = model.Number8;
            parameters[6].Value = model.String1;
            parameters[7].Value = model.String2;
            parameters[8].Value = model.String3;
            parameters[9].Value = model.String4;
            parameters[10].Value = model.Reservation_ID;
            parameters[11].Value = model.String5;
            parameters[12].Value = model.String6;
            parameters[13].Value = model.String7;
            parameters[14].Value = model.String8;
            parameters[15].Value = model.Datetime1;
            parameters[16].Value = model.Datetime2;
            parameters[17].Value = model.Datetime3;
            parameters[18].Value = model.Datetime4;
            parameters[19].Value = model.Resource_Type;
            parameters[20].Value = model.ResourceID;
            parameters[21].Value = model.Resource_Code;
            parameters[22].Value = model.Resource_Name;
            parameters[23].Value = model.EnityID;
            parameters[24].Value = model.Number1;
            parameters[25].Value = model.Number2;

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
        public bool Update(Tellyes.Model.ReservationResource model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReservationResource set ");

            strSql.Append(" Number3 = @Number3 , ");
            strSql.Append(" Number4 = @Number4 , ");
            strSql.Append(" Number5 = @Number5 , ");
            strSql.Append(" Number6 = @Number6 , ");
            strSql.Append(" Number7 = @Number7 , ");
            strSql.Append(" Number8 = @Number8 , ");
            strSql.Append(" String1 = @String1 , ");
            strSql.Append(" String2 = @String2 , ");
            strSql.Append(" String3 = @String3 , ");
            strSql.Append(" String4 = @String4 , ");
            strSql.Append(" Reservation_ID = @Reservation_ID , ");
            strSql.Append(" String5 = @String5 , ");
            strSql.Append(" String6 = @String6 , ");
            strSql.Append(" String7 = @String7 , ");
            strSql.Append(" String8 = @String8 , ");
            strSql.Append(" Datetime1 = @Datetime1 , ");
            strSql.Append(" Datetime2 = @Datetime2 , ");
            strSql.Append(" Datetime3 = @Datetime3 , ");
            strSql.Append(" Datetime4 = @Datetime4 , ");
            strSql.Append(" Resource_Type = @Resource_Type , ");
            strSql.Append(" ResourceID = @ResourceID , ");
            strSql.Append(" Resource_Code = @Resource_Code , ");
            strSql.Append(" Resource_Name = @Resource_Name , ");
            strSql.Append(" EnityID = @EnityID , ");
            strSql.Append(" Number1 = @Number1 , ");
            strSql.Append(" Number2 = @Number2  ");
            strSql.Append(" where Reservation_Res_ID=@Reservation_Res_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@Reservation_Res_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number5", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number6", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number7", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@Number8", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String2", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String3", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@String4", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@Reservation_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@String5", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String6", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@String7", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@String8", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Datetime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime3", SqlDbType.DateTime) ,            
                        new SqlParameter("@Datetime4", SqlDbType.DateTime) ,            
                        new SqlParameter("@Resource_Type", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@ResourceID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Resource_Code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Resource_Name", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@EnityID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Number2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Reservation_Res_ID;
            parameters[1].Value = model.Number3;
            parameters[2].Value = model.Number4;
            parameters[3].Value = model.Number5;
            parameters[4].Value = model.Number6;
            parameters[5].Value = model.Number7;
            parameters[6].Value = model.Number8;
            parameters[7].Value = model.String1;
            parameters[8].Value = model.String2;
            parameters[9].Value = model.String3;
            parameters[10].Value = model.String4;
            parameters[11].Value = model.Reservation_ID;
            parameters[12].Value = model.String5;
            parameters[13].Value = model.String6;
            parameters[14].Value = model.String7;
            parameters[15].Value = model.String8;
            parameters[16].Value = model.Datetime1;
            parameters[17].Value = model.Datetime2;
            parameters[18].Value = model.Datetime3;
            parameters[19].Value = model.Datetime4;
            parameters[20].Value = model.Resource_Type;
            parameters[21].Value = model.ResourceID;
            parameters[22].Value = model.Resource_Code;
            parameters[23].Value = model.Resource_Name;
            parameters[24].Value = model.EnityID;
            parameters[25].Value = model.Number1;
            parameters[26].Value = model.Number2;
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
        public bool Delete(int Reservation_Res_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReservationResource ");
            strSql.Append(" where Reservation_Res_ID=@Reservation_Res_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Reservation_Res_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Reservation_Res_ID;


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
        public bool DeleteList(string Reservation_Res_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReservationResource ");
            strSql.Append(" where ID in (" + Reservation_Res_IDlist + ")  ");
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
        public Tellyes.Model.ReservationResource GetModel(int Reservation_Res_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Reservation_Res_ID, Number3, Number4, Number5, Number6, Number7, Number8, String1, String2, String3, String4, Reservation_ID, String5, String6, String7, String8, Datetime1, Datetime2, Datetime3, Datetime4, Resource_Type, ResourceID, Resource_Code, Resource_Name, EnityID, Number1, Number2  ");
            strSql.Append("  from ReservationResource ");
            strSql.Append(" where Reservation_Res_ID=@Reservation_Res_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Reservation_Res_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = Reservation_Res_ID;


            Tellyes.Model.ReservationResource model = new Tellyes.Model.ReservationResource();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Reservation_Res_ID"].ToString() != "")
                {
                    model.Reservation_Res_ID = int.Parse(ds.Tables[0].Rows[0]["Reservation_Res_ID"].ToString());
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
                model.String2 = ds.Tables[0].Rows[0]["String2"].ToString();
                model.String3 = ds.Tables[0].Rows[0]["String3"].ToString();
                model.String4 = ds.Tables[0].Rows[0]["String4"].ToString();
                if (ds.Tables[0].Rows[0]["Reservation_ID"].ToString() != "")
                {
                    model.Reservation_ID = int.Parse(ds.Tables[0].Rows[0]["Reservation_ID"].ToString());
                }
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
                if (ds.Tables[0].Rows[0]["Datetime4"].ToString() != "")
                {
                    model.Datetime4 = DateTime.Parse(ds.Tables[0].Rows[0]["Datetime4"].ToString());
                }
                model.Resource_Type = ds.Tables[0].Rows[0]["Resource_Type"].ToString();
                if (ds.Tables[0].Rows[0]["ResourceID"].ToString() != "")
                {
                    model.ResourceID = ds.Tables[0].Rows[0]["ResourceID"].ToString();
                }
                model.Resource_Code = ds.Tables[0].Rows[0]["Resource_Code"].ToString();
                model.Resource_Name = ds.Tables[0].Rows[0]["Resource_Name"].ToString();
                model.EnityID = ds.Tables[0].Rows[0]["EnityID"].ToString();
                if (ds.Tables[0].Rows[0]["Number1"].ToString() != "")
                {
                    model.Number1 = int.Parse(ds.Tables[0].Rows[0]["Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number2"].ToString() != "")
                {
                    model.Number2 = int.Parse(ds.Tables[0].Rows[0]["Number2"].ToString());
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
            strSql.Append(" FROM ReservationResource ");
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
            strSql.Append(" FROM ReservationResource ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

