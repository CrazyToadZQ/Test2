using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.DBUtility;
using System.Data.SqlClient;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.NHibernate;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class DeviceUse : BaseDAL<Tellyes.Model.DeviceUse>
  {

      #region BaseMethod
      public bool Exists(int DU_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceUse");
            strSql.Append(" where ");
            strSql.Append(" DU_ID = @DU_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@DU_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DU_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceUse model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceUse(");
            strSql.Append("DU_Number3,DU_Number4,DU_String1,DU_String2,DU_String3,DU_String4,DU_String5,D_ID,E_ID,RoomID,DU_StartTime,DU_EndTime,DU_TimeSpan,DU_Number1,DU_Number2");
            strSql.Append(") values (");
            strSql.Append("@DU_Number3,@DU_Number4,@DU_String1,@DU_String2,@DU_String3,@DU_String4,@DU_String5,@D_ID,@E_ID,@RoomID,@DU_StartTime,@DU_EndTime,@DU_TimeSpan,@DU_Number1,@DU_Number2");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@DU_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DU_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DU_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@DU_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DU_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DU_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DU_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.DU_Number3;
            parameters[1].Value = model.DU_Number4;
            parameters[2].Value = model.DU_String1;
            parameters[3].Value = model.DU_String2;
            parameters[4].Value = model.DU_String3;
            parameters[5].Value = model.DU_String4;
            parameters[6].Value = model.DU_String5;
            parameters[7].Value = model.D_ID;
            parameters[8].Value = Guid.NewGuid();
            parameters[9].Value = model.RoomID;
            parameters[10].Value = model.DU_StartTime;
            parameters[11].Value = model.DU_EndTime;
            parameters[12].Value = model.DU_TimeSpan;
            parameters[13].Value = model.DU_Number1;
            parameters[14].Value = model.DU_Number2;

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
        public bool Update(Tellyes.Model.DeviceUse model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceUse set ");

            strSql.Append(" DU_Number3 = @DU_Number3 , ");
            strSql.Append(" DU_Number4 = @DU_Number4 , ");
            strSql.Append(" DU_String1 = @DU_String1 , ");
            strSql.Append(" DU_String2 = @DU_String2 , ");
            strSql.Append(" DU_String3 = @DU_String3 , ");
            strSql.Append(" DU_String4 = @DU_String4 , ");
            strSql.Append(" DU_String5 = @DU_String5 , ");
            strSql.Append(" D_ID = @D_ID , ");
            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" RoomID = @RoomID , ");
            strSql.Append(" DU_StartTime = @DU_StartTime , ");
            strSql.Append(" DU_EndTime = @DU_EndTime , ");
            strSql.Append(" DU_TimeSpan = @DU_TimeSpan , ");
            strSql.Append(" DU_Number1 = @DU_Number1 , ");
            strSql.Append(" DU_Number2 = @DU_Number2  ");
            strSql.Append(" where DU_ID=@DU_ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@DU_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@DU_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@DU_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@DU_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@DU_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@RoomID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_StartTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DU_EndTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@DU_TimeSpan", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@DU_Number2", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.DU_ID;
            parameters[1].Value = model.DU_Number3;
            parameters[2].Value = model.DU_Number4;
            parameters[3].Value = model.DU_String1;
            parameters[4].Value = model.DU_String2;
            parameters[5].Value = model.DU_String3;
            parameters[6].Value = model.DU_String4;
            parameters[7].Value = model.DU_String5;
            parameters[8].Value = model.D_ID;
            parameters[9].Value = model.E_ID;
            parameters[10].Value = model.RoomID;
            parameters[11].Value = model.DU_StartTime;
            parameters[12].Value = model.DU_EndTime;
            parameters[13].Value = model.DU_TimeSpan;
            parameters[14].Value = model.DU_Number1;
            parameters[15].Value = model.DU_Number2;
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
        public bool Delete(int DU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceUse ");
            strSql.Append(" where DU_ID=@DU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DU_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DU_ID;


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
        public bool DeleteList(string DU_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceUse ");
            strSql.Append(" where ID in (" + DU_IDlist + ")  ");
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
        public Tellyes.Model.DeviceUse GetModel(int DU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DU_ID, DU_Number3, DU_Number4, DU_String1, DU_String2, DU_String3, DU_String4, DU_String5, D_ID, E_ID, RoomID, DU_StartTime, DU_EndTime, DU_TimeSpan, DU_Number1, DU_Number2  ");
            strSql.Append("  from DeviceUse ");
            strSql.Append(" where DU_ID=@DU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DU_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DU_ID;


            Tellyes.Model.DeviceUse model = new Tellyes.Model.DeviceUse();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DU_ID"].ToString() != "")
                {
                    model.DU_ID = int.Parse(ds.Tables[0].Rows[0]["DU_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_Number3"].ToString() != "")
                {
                    model.DU_Number3 = int.Parse(ds.Tables[0].Rows[0]["DU_Number3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_Number4"].ToString() != "")
                {
                    model.DU_Number4 = int.Parse(ds.Tables[0].Rows[0]["DU_Number4"].ToString());
                }
                model.DU_String1 = ds.Tables[0].Rows[0]["DU_String1"].ToString();
                model.DU_String2 = ds.Tables[0].Rows[0]["DU_String2"].ToString();
                model.DU_String3 = ds.Tables[0].Rows[0]["DU_String3"].ToString();
                model.DU_String4 = ds.Tables[0].Rows[0]["DU_String4"].ToString();
                model.DU_String5 = ds.Tables[0].Rows[0]["DU_String5"].ToString();
                if (ds.Tables[0].Rows[0]["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(ds.Tables[0].Rows[0]["D_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(ds.Tables[0].Rows[0]["E_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RoomID"].ToString() != "")
                {
                    model.RoomID = int.Parse(ds.Tables[0].Rows[0]["RoomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_StartTime"].ToString() != "")
                {
                    model.DU_StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["DU_StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_EndTime"].ToString() != "")
                {
                    model.DU_EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["DU_EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_TimeSpan"].ToString() != "")
                {
                    model.DU_TimeSpan = int.Parse(ds.Tables[0].Rows[0]["DU_TimeSpan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_Number1"].ToString() != "")
                {
                    model.DU_Number1 = int.Parse(ds.Tables[0].Rows[0]["DU_Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DU_Number2"].ToString() != "")
                {
                    model.DU_Number2 = int.Parse(ds.Tables[0].Rows[0]["DU_Number2"].ToString());
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
            strSql.Append(" FROM DeviceUse ");
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
            strSql.Append(" FROM DeviceUse ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
      #endregion


      
        /// <summary>
      /// 
      /// </summary>
      /// <param name="criteria"></param>
      /// <param name="conditionDictionary"></param>
      /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("D_ID,in"))
            {
                criteria.Add(Restrictions.In("D_ID", (List<Int32>)conditionDictionary["D_ID,in"]));
            }
            return criteria;
        }

    }
}
