using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamStation_Room
    /// </summary>
    public partial class ExamStation_Room: BaseDAL<Model.ExamStation_Room>
    {
        private static ExamStation_Room room_Dal = new ExamStation_Room();

        public ExamStation_Room()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ESR_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamStation_Room");
            strSql.Append(" where ESR_ID=@ESR_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ESR_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStation_Room model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamStation_Room(");
            strSql.Append("ESR_ID,ES_ID,Room_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@ESR_ID,@ES_ID,@Room_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.ES_ID;
            parameters[1].Value = model.Room_ID;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.float3;
            parameters[14].Value = model.ESR_ID;

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
        public bool Update(Tellyes.Model.ExamStation_Room model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamStation_Room set ");
            strSql.Append("ES_ID=@ES_ID,");
            strSql.Append("Room_ID=@Room_ID,");
            strSql.Append("int1=@int1,");
            strSql.Append("int2=@int2,");
            strSql.Append("int3=@int3,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3,");
            strSql.Append("date1=@date1,");
            strSql.Append("date2=@date2,");
            strSql.Append("date3=@date3,");
            strSql.Append("float1=@float1,");
            strSql.Append("float2=@float2,");
            strSql.Append("float3=@float3");
            strSql.Append(" where ESR_ID=@ESR_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.ES_ID;
            parameters[1].Value = model.Room_ID;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.float3;
            parameters[14].Value = model.ESR_ID;

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
        /// 获取房间名称信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetRoomInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Room.Room_ID,Room.Room_Name");
            strSql.Append(" from ExamStation_Room,Room");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ESR_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStation_Room ");
            strSql.Append(" where ESR_ID=@ESR_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ESR_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string ESR_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStation_Room ");
            strSql.Append(" where ESR_ID in (" + ESR_IDlist + ")  ");
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
        public Tellyes.Model.ExamStation_Room GetModel(int ESR_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ESR_ID,ES_ID,Room_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ExamStation_Room ");
            strSql.Append(" where ESR_ID=@ESR_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ESR_ID;

            Tellyes.Model.ExamStation_Room model = new Tellyes.Model.ExamStation_Room();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamStation_Room DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamStation_Room model = new Tellyes.Model.ExamStation_Room();
            if (row != null)
            {
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(row["Room_ID"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = Guid.Parse(row["int1"].ToString());
                }
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.int2 = int.Parse(row["int2"].ToString());
                }
                if (row["int3"] != null && row["int3"].ToString() != "")
                {
                    model.int3 = int.Parse(row["int3"].ToString());
                }
                if (row["string1"] != null)
                {
                    model.string1 = row["string1"].ToString();
                }
                if (row["string2"] != null)
                {
                    model.string2 = row["string2"].ToString();
                }
                if (row["string3"] != null)
                {
                    model.string3 = row["string3"].ToString();
                }
                if (row["date1"] != null && row["date1"].ToString() != "")
                {
                    model.date1 = DateTime.Parse(row["date1"].ToString());
                }
                if (row["date2"] != null && row["date2"].ToString() != "")
                {
                    model.date2 = DateTime.Parse(row["date2"].ToString());
                }
                if (row["date3"] != null && row["date3"].ToString() != "")
                {
                    model.date3 = DateTime.Parse(row["date3"].ToString());
                }
                if (row["float1"] != null && row["float1"].ToString() != "")
                {
                    model.float1 = decimal.Parse(row["float1"].ToString());
                }
                if (row["float2"] != null && row["float2"].ToString() != "")
                {
                    model.float2 = decimal.Parse(row["float2"].ToString());
                }
                if (row["float3"] != null && row["float3"].ToString() != "")
                {
                    model.float3 = decimal.Parse(row["float3"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ESR_ID,ES_ID,Room_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamStation_Room ");
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
            strSql.Append(" ESR_ID,ES_ID,Room_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamStation_Room ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ExamStation_Room ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ESR_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamStation_Room T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ExamStation_Room";
            parameters[1].Value = "ESR_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 判断是否已经，包含了此房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="Room_ID"></param>
        /// <returns></returns>
        public static bool isESRoomExisted(string ES_ID, string Room_ID)
        {
            bool result = false;
            int rowCount = room_Dal.GetRecordCount(" ES_ID='" + ES_ID + "' and Room_ID='" + Room_ID + "' ");
            if (rowCount > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 向某考站增加一个房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="Room_ID"></param>
        public static void AddNewRoomToES(string ES_ID,string Room_ID) 
        {
            Tellyes.Model.ExamStation_Room model = new Model.ExamStation_Room();
            model.ES_ID = new Guid( ES_ID);
            model.Room_ID =Convert.ToInt32(  Room_ID);
            room_Dal.Add(model);
        }

        /// <summary>
        /// 从某考站，删除某房间
        /// </summary>
        /// <param name="self"></param>
        /// <param name="ESR_ID"></param>
        public static void DeleteRoomFromES(string ESR_ID)
        {
            string sql = "delete from ExamUser where ESR_ID='" + ESR_ID + "'; delete from ExamStation_Room where ESR_ID='" + ESR_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 根据E_ID获得考站中房间信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetExamStationRoomByE_ID(string E_ID)
        {
            string sql = "select * from dbo.ExamStation_Room where ES_ID in (select ES_ID from dbo.ExamStation where int1='" + E_ID + "');";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据E_ID，获得冲突考站房间信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetErrorExamStationRoomByE_ID(string E_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct Room_ID from dbo.ExamStation_Room where ES_ID in ( ");
            sql.Append(" select ES_ID from dbo.ExamStation where int1 in ( ");
            sql.Append(" select b.E_ID from ExamTable as a join  ExamTable as b ");
            sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime)  ");
            sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime) ");
            sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime) ");
            sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime))  ");
            sql.Append(" where a.E_ID ='" + E_ID + "')); ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 根据E_ID，获得可选考站房间
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingExamStationRoomByE_ID(string E_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select *,1 as canBeSeen from Room where Room_ID not in ");
            sql.Append(" (select Room_ID from dbo.ExamStation_Room where ES_ID in ( ");
            sql.Append(" select ES_ID from dbo.ExamStation where int1 in ( ");
            sql.Append(" select b.E_ID from ExamTable as a join  ExamTable as b ");
            sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) ");
            sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime) ");
            sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime) ");
            sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
            sql.Append(" where a.E_ID ='" + E_ID + "')) union select Room_ID from dbo.ExamStation_Room where ES_ID in ( ");
            sql.Append(" select ES_ID from dbo.ExamStation where int1 ='" + E_ID + "')); ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("examTableID,Eq"))
            {
                criteria.Add(Restrictions.Eq("int1", conditionDictionary["examTableID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("int1", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("Room_ID", conditionDictionary["Room_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("examStationID,Eq"))
            {
                criteria.Add(Restrictions.Eq("ES_ID", conditionDictionary["examStationID,Eq"]));
            }
            return criteria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamStationRoomAndRoomByExamTableID(Guid examTableID)
        { 
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamStation_Room].[ESR_ID], ")
                .Append("   [ExamStation_Room].[ES_ID], ")
                .Append("   [ExamStation_Room].[Room_ID], ")
                .Append("   [Room].[Room_Name] ")
                .Append("FROM ")
                .Append("   [ExamStation_Room] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [ExamStation_Room].[Room_ID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStation_Room].[int1] = :examTableID ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("ESR_ID", NHibernateUtil.Guid)
                    .AddScalar("ES_ID", NHibernateUtil.Guid)
                    .AddScalar("Room_ID", NHibernateUtil.Int32)
                    .AddScalar("Room_Name", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("examTableID", examTableID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考站房间失败，E_ID：" + examTableID, e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        public List<object[]> SelectExamStation_RoomListByExamTableID(Guid examTableID,Guid examStationID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamStation_Room].*, ")
                .Append("   [Room].[Room_Name] ")
                .Append("FROM ")
                .Append("   [ExamStation_Room] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [ExamStation_Room].[Room_ID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStation_Room].[int1] = :examTableID ")
                .Append(" and   [ExamStation_Room].[ES_ID] = :examStationID ")
                .Append(" order by Room_Name; ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Tellyes.Model.ExamStation_Room))
                    .AddScalar("Room_Name", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("examTableID", examTableID);
                iSQLQuery.SetGuid("examStationID", examStationID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考站房间失败，E_ID：" + examTableID, e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }
        #endregion
    }

    
}
