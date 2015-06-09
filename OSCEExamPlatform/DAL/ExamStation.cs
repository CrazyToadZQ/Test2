using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using Tellyes.Log4Net;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamStation
    /// </summary>
    public partial class ExamStation: BaseDAL<Model.ExamStation>
    {
        public ExamStation()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamStation");
            strSql.Append(" where ES_ID=@ES_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ES_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamStation(");
            strSql.Append("ES_ID,ES_Name,ES_Ccontent,ES_Kind,ES_Curriculum,ESC_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@ES_ID,@ES_Name,@ES_Ccontent,@ES_Kind,@ES_Curriculum,@ESC_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ES_Ccontent", SqlDbType.NVarChar,500),
					new SqlParameter("@ES_Kind", SqlDbType.Int,4),
					new SqlParameter("@ES_Curriculum", SqlDbType.NVarChar,500),
					new SqlParameter("@ESC_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.UniqueIdentifier,32),
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
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.ES_Name;
            parameters[1].Value = model.ES_Ccontent;
            parameters[2].Value = model.ES_Kind;
            parameters[3].Value = model.ES_Curriculum;
            parameters[4].Value = model.ESC_ID;
            parameters[5].Value = model.int1;
            parameters[6].Value = model.int2;
            parameters[7].Value = model.int3;
            parameters[8].Value = model.string1;
            parameters[9].Value = model.string2;
            parameters[10].Value = model.string3;
            parameters[11].Value = model.date1;
            parameters[12].Value = model.date2;
            parameters[13].Value = model.date3;
            parameters[14].Value = model.float1;
            parameters[15].Value = model.float2;
            parameters[16].Value = model.float3;
            parameters[17].Value = model.ES_ID;

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
        public bool Update(Tellyes.Model.ExamStation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamStation set ");
            strSql.Append("ES_Name=@ES_Name,");
            strSql.Append("ES_Ccontent=@ES_Ccontent,");
            strSql.Append("ES_Kind=@ES_Kind,");
            strSql.Append("ES_Curriculum=@ES_Curriculum,");
            strSql.Append("ESC_ID=@ESC_ID,");
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
            strSql.Append(" where ES_ID=@ES_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ES_Ccontent", SqlDbType.NVarChar,500),
					new SqlParameter("@ES_Kind", SqlDbType.Int,4),
					new SqlParameter("@ES_Curriculum", SqlDbType.NVarChar,500),
					new SqlParameter("@ESC_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.UniqueIdentifier,32),
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
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.ES_Name;
            parameters[1].Value = model.ES_Ccontent;
            parameters[2].Value = model.ES_Kind;
            parameters[3].Value = model.ES_Curriculum;
            parameters[4].Value = model.ESC_ID;
            parameters[5].Value = model.int1;
            parameters[6].Value = model.int2;
            parameters[7].Value = model.int3;
            parameters[8].Value = model.string1;
            parameters[9].Value = model.string2;
            parameters[10].Value = model.string3;
            parameters[11].Value = model.date1;
            parameters[12].Value = model.date2;
            parameters[13].Value = model.date3;
            parameters[14].Value = model.float1;
            parameters[15].Value = model.float2;
            parameters[16].Value = model.float3;
            parameters[17].Value = model.ES_ID;

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
        public bool Delete(int ES_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStation ");
            strSql.Append(" where ES_ID=@ES_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ES_ID;

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
        public bool DeleteList(string ES_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStation ");
            strSql.Append(" where ES_ID in (" + ES_IDlist + ")  ");
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
        public Tellyes.Model.ExamStation GetModel(Guid ES_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ES_ID,ES_Name,ES_Ccontent,ES_Kind,ES_Curriculum,ESC_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ExamStation ");
            strSql.Append(" where ES_ID=@ES_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = ES_ID;

            Tellyes.Model.ExamStation model = new Tellyes.Model.ExamStation();
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
        public Tellyes.Model.ExamStation DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamStation model = new Tellyes.Model.ExamStation();
            if (row != null)
            {
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["ES_Name"] != null)
                {
                    model.ES_Name = row["ES_Name"].ToString();
                }
                if (row["ES_Ccontent"] != null)
                {
                    model.ES_Ccontent = row["ES_Ccontent"].ToString();
                }
                if (row["ES_Kind"] != null && row["ES_Kind"].ToString() != "")
                {
                    model.ES_Kind = int.Parse(row["ES_Kind"].ToString());
                }
                if (row["ES_Curriculum"] != null)
                {
                    model.ES_Curriculum = row["ES_Curriculum"].ToString();
                }
                if (row["ESC_ID"] != null && row["ESC_ID"].ToString() != "")
                {
                    model.ESC_ID = int.Parse(row["ESC_ID"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = new Guid(row["int1"].ToString());
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
            strSql.Append("select ES_ID,ES_Name,ES_Ccontent,ES_Kind,ES_Curriculum,ESC_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamStation ");
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
            strSql.Append(" ES_ID,ES_Name,ES_Ccontent,ES_Kind,ES_Curriculum,ESC_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamStation ");
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
            strSql.Append("select count(1) FROM ExamStation ");
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
                strSql.Append("order by T.ES_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamStation T ");
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
            parameters[0].Value = "ExamStation";
            parameters[1].Value = "ES_ID";
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
        /// 判断考站的完备性
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public bool ESIsFinished(Guid ES_ID)
        {
            Model.ExamStation es = GetModel(ES_ID);
            if (string.IsNullOrEmpty(es.ES_Name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(es.ES_Curriculum))
            {
                return false;
            }
            if (es.ESC_ID <= 0)
            {
                return false;
            }
            DataSet ds = new ExamStation_Room().GetList("ES_ID=" + ES_ID);
            if (es.ES_Kind == 1)
            {
                if (ds.Tables[0].Rows.Count < 2)
                {
                    return false;
                }
                else
                {
                    bool b = true;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        int esrid = Convert.ToInt32(ds.Tables[0].Rows[i]["ESR_ID"]);
                        DataSet dsUser = new ExamUser().GetList("ESR_ID=" + esrid);
                        if (dsUser.Tables[0].Rows.Count==0)
                        {
                            b = false;
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < dsUser.Tables[0].Rows.Count; j++)
                            {
                                Model.ExamUser eu = new ExamUser().GetModel(new Guid(dsUser.Tables[0].Rows[i]["EU_ID"].ToString()));
                                if (eu.int1.HasValue)
                                {
                                    if (eu.int1.Value > 0)
                                    {
                                        DataSet dsEUMS = new ExamUserMarkSheet().GetList("EU_ID=" + eu.EU_ID);
                                        if (dsEUMS.Tables[0].Rows.Count==0)
                                        {
                                            b = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!b)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (ds.Tables[0].Rows.Count < 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 更新考站表，主观评分比例
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="int2"></param>
        public void UpdateSubRate(string ES_ID,string int2)
        {
            string sql = " update ExamStation set int2='" + int2 + "' where ES_ID='" + ES_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 根据考试ID，获得考站信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetSingleExamData(string E_ID) 
        {
            string sql = " select top (1) * from ExamStation where int1='" + E_ID + "'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        //查找当前考生的下一个考站
        public DataSet SelectNextStationName(Guid ExamID, int ExamKind, int UID, DateTime dt1, DateTime dt2)
        {
            string strSql = "";

            if (ExamKind == 1)
            {
                strSql = string.Format(@"select * from [ExamStation] where ES_ID = (select ES_ID from [OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView]
                    where E_ID = '{0}' and U_ID = '{1}' and OEA_StartTime  between '{2}' and '{3}')", ExamID, UID, dt1, dt2);
            }
            else if (ExamKind == 2)
            {
                strSql = string.Format(@"select * from [ExamStation] where ES_ID = (select ES_ID  from [MultiStationExamArrangement] 
                    where E_ID = '{0}' and U_ID = '{1}' and Exam_StartTime between '{2}' and '{3}')", ExamID, UID, dt1, dt2);
            }

            return DbHelperSQL.Query(strSql);
        }

        //查找当前考生的下一个考站的房间名称
        public DataSet SelectNextStationRoomName(Guid ExamID, int ExamKind, int UID, DateTime dt1, DateTime dt2)
        {
            string strSql = "";

            if (ExamKind == 1)
            {
                strSql = string.Format(@"select Room_Name from [Room] where Room_ID = (select Room_ID from [OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView]
                    where E_ID = '{0}' and U_ID = '{1}' and OEA_StartTime  between '{2}' and '{3}')", ExamID, UID, dt1, dt2);
            }
            else if (ExamKind == 2)
            {
                strSql = string.Format(@"select Room_Name from [Room] where Room_ID = (select Room_ID  from [MultiStationExamArrangement] 
                    where E_ID = '{0}' and U_ID = '{1}' and Exam_StartTime between '{2}' and '{3}')", ExamID, UID, dt1, dt2);
            }

            return DbHelperSQL.Query(strSql);
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamStationAndRoomByExamID(Guid examID)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [ExamStation].[ES_ID], ")
                .Append("    [ExamStation].[ES_Name], ")
                .Append("    [ExamStation].[ES_Ccontent], ")
                .Append("    [ExamStation].[ES_Kind], ")
                .Append("    [ExamStation].[ES_Curriculum], ")
                .Append("    [ExamStation].[ESC_ID], ")
                .Append("    [ExamStation].[int1], ")
                .Append("    [ExamStation].[int2], ")
                .Append("    [ExamStation].[int3], ")
                .Append("    [ExamStationClass].[Exam_Station_Class_Name], ")
                .Append("    [Room].[Room_ID], ")
                .Append("    [Room].[Parent_Room_ID], ")
                .Append("    [Room].[Room_Name], ")
                .Append("    [Room].[Room_Area], ")
                .Append("    [Room].[Room_People_Number], ")
                .Append("    [Room].[Room_Station_Number], ")
                .Append("    [Room].[Room_IS_Binding_Device], ")
                .Append("    [Room].[Room_Device_Name], ")
                .Append("    [Room].[Room_Describe], ")
                .Append("    [Room].[Number1] ")
                .Append("FROM ")
                .Append("   [ExamStation] ")
                .Append("   INNER JOIN [ExamStationClass] ")
                .Append("       ON [ExamStation].[ESC_ID] = [ExamStationClass].[Exam_Station_Class_ID] ")
                .Append("   INNER JOIN [ExamStation_Room] ")
                .Append("       ON [ExamStation].[ES_ID] = [ExamStation_Room].[ES_ID] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [ExamStation_Room].[Room_ID] = [Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStation].[int1] = :E_ID ")
                .Append("ORDER BY ")
                .Append("   [ExamStation].[int3] ASC ")
                .ToString();
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session
                    .CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.ExamStation))
                    .AddEntity(typeof(Model.Room))
                    .AddScalar("Exam_Station_Class_Name", NHibernateUtil.String)
                    .SetGuid("E_ID", examID)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考站信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public Model.ExamStation SelectExamStationByExamStationRoomID(Guid ESR_ID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamStation].* ")
                .Append("FROM ")
                .Append("   [ExamStation] ")
                .Append("   INNER JOIN [ExamStation_Room] ")
                .Append("       ON [ExamStation].[ES_ID] = [ExamStation_Room].[ES_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStation_Room].[ESR_ID] = :ESR_ID ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.ExamStation));
                //设置查询参数
                iSQLQuery.SetGuid("ESR_ID", ESR_ID);
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult(0)
                    .SetMaxResults(1)
                    .UniqueResult<Model.ExamStation>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，考站信息查询失败：ESR_ID（" + ESR_ID + "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("int1", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString())));
            }
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("int1", Guid.Parse(conditionDictionary["E_ID,eq"].ToString())));
            }
            if (conditionDictionary.ContainsKey("examTableID,Eq"))
            {
                criteria.Add(Restrictions.Eq("int1", conditionDictionary["examTableID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("int1", conditionDictionary["E_ID,EQ"]));
            }
            return criteria;
        }
      
        /// <summary>
        /// 查询每个学生每场考试的信息
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectEachStudentEachExamInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            int  examKind=Convert.ToInt32(conditionDictionary["E_Kind,IS"]);
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ExamStation].*, ")
                .Append("   [ExamStationClass].[Exam_Station_Class_Name], ")
                .Append("   [Room].[Room_Name], ");
            if (examKind == 1)
            {
                //长短站
                sqlStringBuilder
                .Append("   [ExamArrangement].[OEA_StartTime] AS [E_StartTime] , ");
            }
            else if (examKind == 2)
            {
                //多站
                sqlStringBuilder
                    .Append("   [ExamArrangement].[Exam_StartTime] AS [E_StartTime] , ");
            }
            else if (examKind== 3)
            {
                 //单站
                sqlStringBuilder
                 .Append("   [ExamArrangement].[SE_StartTime] AS [E_StartTime] , ");
            }
            sqlStringBuilder
            .Append("   [ScoreSummariedScore].[score],")
            .Append("   [CameraSavePath].[File_Path] ")
            .Append("FROM ")
            .Append("   [ExamStation] ");

            if (examKind == 1)
            {
                //长短站
                sqlStringBuilder
                    .Append("INNER JOIN [OSCEExaminationArrangement] AS [ExamArrangement] ");
            }
            else if (examKind == 2)
            {
                //多站
                sqlStringBuilder
                    .Append("INNER JOIN [MultiStationExamArrangement] AS [ExamArrangement] ");
            }
            else if (examKind == 3)
            {
                //单站
                sqlStringBuilder
                    .Append("INNER JOIN [SingleStationExamArrangement] AS [ExamArrangement] ");
            }
            sqlStringBuilder
                .Append("       ON [ExamArrangement].[E_ID] =[ExamStation].[int1] ")
                .Append("           AND [ExamArrangement].[U_ID] = :U_ID ")
                .Append("           AND [ExamArrangement].[ES_ID] = [ExamStation].[ES_ID] ")
                .Append("   INNER JOIN [ExamStationClass] ")
                .Append("       ON [ExamStation].[ESC_ID] =[ExamStationClass].[Exam_Station_Class_ID] ")
                .Append("   INNER JOIN [Room] ")
                .Append("       ON [Room].[Room_ID] =[ExamArrangement].[Room_ID] ")
                .Append("   LEFT JOIN [ScoreSummariedScore] ")
                .Append("       ON [ScoreSummariedScore].[ES_ID]=[ExamStation].[ES_ID] ")
                .Append("       AND [ScoreSummariedScore].[Student_ID] = [ExamArrangement].[U_ID] ")
                .Append("   LEFT JOIN [CameraSavePath] ")
                .Append("       ON [CameraSavePath].[ES_ID]=[ExamStation].[ES_ID] ")
                .Append("       AND [CameraSavePath].[U_ID] = [ExamArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("      [ExamStation].[int1]=:E_ID ")
                .Append("ORDER BY ")
                .Append("      [ExamStation].[int3] ASC ");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Tellyes.Model.ExamStation));
                iSQLQuery.AddScalar("Exam_Station_Class_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("E_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("score", NHibernateUtil.Decimal);
                iSQLQuery.AddScalar("file_path", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID,Eq"].ToString()));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考试信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询每场考试的考站信息
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectEachExamEachExamStationInfoByCondition(Guid examStationID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [ExamStation].*, ")
                .Append("   [ExamStationClass].[Exam_Station_Class_Name] ")
                .Append("FROM ")
                .Append("   [ExamStation] ")
                .Append("INNER JOIN  ")
                .Append("   [ExamStationClass] ")
                .Append("ON [ExamStation].[ESC_ID] = [ExamStationClass].[Exam_Station_Class_ID]  ")
                .Append("WHERE ")
                .Append("      [ExamStation].[ES_ID]=:ES_ID ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Tellyes.Model.ExamStation));
                iSQLQuery.AddScalar("Exam_Station_Class_Name", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("ES_ID", examStationID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考试信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion

        #region 扩展方法


        /// <summary>
        /// 教师查询-获得单站式考试的考站数据列表 陶东利-2014-7-18
        /// 输入E_ID
        /// </summary>
        public DataSet GetListTeacherQuerySingleStation(int E_ID)  //此方法需要修改！！！！！！！
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MIN(MultiStationExamArrangement.E_ID)as E_ID ,MultiStationExamArrangement.ES_ID,MIN(MultiStationExamArrangement.Room_ID)as Room_ID , MIN(ExamStationClass.Exam_Station_Class_Name)as Exam_Station_Class_Name,MIN(ExamStation.ES_Name) as ES_Name ,MIN(ExamStation.ES_Curriculum) as ES_Curriculum ,MIN(Room_Name) as Room_Name ");
            strSql.Append("  FROM [OSCE].[dbo].[MultiStationExamArrangement] ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[Room] on MultiStationExamArrangement.Room_ID=Room.Room_ID ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[ExamStation] on MultiStationExamArrangement.ES_ID=ExamStation.ES_ID ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[ExamStationClass] on ExamStationClass.Exam_Station_Class_ID=ExamStation.ESC_ID ");
            strSql.Append(" where  MultiStationExamArrangement.E_ID=" + E_ID);
            strSql.Append(" group by MultiStationExamArrangement.ES_ID ");
            strSql.Append("order by MIN(ExamStation.ES_Name) Asc ");


            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 教师查询-获得多站式考试的考站数据列表 陶东利-2014-7-17
        /// 输入E_ID
        /// </summary>
        public DataSet GetListTeacherQueryMultiStation(Guid E_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MIN(MultiStationExamArrangement.E_ID)as E_ID ,MultiStationExamArrangement.ES_ID,MIN(MultiStationExamArrangement.Room_ID)as Room_ID , MIN(ExamStationClass.Exam_Station_Class_Name)as Exam_Station_Class_Name,MIN(ExamStation.ES_Name) as ES_Name ,MIN(ExamStation.ES_Curriculum) as ES_Curriculum ,MIN(Room_Name) as Room_Name ");
            strSql.Append("  FROM [OSCE].[dbo].[MultiStationExamArrangement] ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[Room] on MultiStationExamArrangement.Room_ID=Room.Room_ID ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[ExamStation] on MultiStationExamArrangement.ES_ID=ExamStation.ES_ID ");
            strSql.Append("INNER JOIN [OSCE].[dbo].[ExamStationClass] on ExamStationClass.Exam_Station_Class_ID=ExamStation.ESC_ID ");       
            strSql.Append(" where  MultiStationExamArrangement.E_ID=" + E_ID);           
            strSql.Append(" group by MultiStationExamArrangement.ES_ID ");
            strSql.Append("order by MIN(ExamStation.ES_Name) Asc ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 教师查询- DataRow数据转换为 model数据，返回一个对象实体  陶东利-2014-7-17
        /// </summary>
        public Tellyes.Model.CompositedModelTeacherQueryExamStation DataRowToModelTeacherQuery(DataRow row)
        {
            Tellyes.Model.CompositedModelTeacherQueryExamStation model = new Tellyes.Model.CompositedModelTeacherQueryExamStation();
            if (row != null)
            {
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.EsId= int.Parse(row["ES_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = int.Parse(row["E_ID"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.RoomId = int.Parse(row["Room_ID"].ToString());
                }

                if (row["Exam_Station_Class_Name"] != null)
                {
                    model.ExamStationClass = row["Exam_Station_Class_Name"].ToString();
                }
                if (row["ES_Name"] != null)
                {
                    model.EsName = row["ES_Name"].ToString();
                }
                if (row["ES_Curriculum"] != null)
                {
                    model.Subject = row["ES_Curriculum"].ToString();
                }
                if (row["Room_Name"] != null)
                {
                    model.RoomName = row["Room_Name"].ToString();
                }

                //备注：增加设备信息查询时，此处需要修改               
                
            }
            return model;
        }


        /// <summary>
        /// 教师查询-获得某个考站、某个房间中的评委或SP列表 陶东利-2014-7-17
        /// </summary>
        /// <param name="ES_ID">考站ID</param>
        /// <param name="RoomId">房间ID</param>
        /// <param name="Flag">查询评委列表或Sp列表标识位（Flag=1：查询评委列表，Flag=2：查询SP列表）</param>
        /// <returns></returns>
        public DataSet GetListTeacherQuery(int ES_ID,int RoomId,int Flag)
        {
            StringBuilder strSql = new StringBuilder();

            switch (Flag)
            {
                case 1: //查询评委列表
                    strSql.Append("  SELECT [E_ID],[ES_ID],ExamUser.ESR_ID,[Room_ID],[EU_ID],UserInfo.[U_ID],U_TrueName,[EU_ISSP],ExamUser.int2 ");
                    strSql.Append("FROM [OSCE].[dbo].[ExamUser] ");
                    strSql.Append("inner join [OSCE].[dbo].[ExamStation_Room] on ExamUser.ESR_ID=ExamStation_Room.ESR_ID ");
                    strSql.Append("inner join [OSCE].[dbo].[UserInfo] on ExamUser.U_ID=UserInfo.U_ID ");
                    strSql.Append("where ExamStation_Room.ES_ID=" + ES_ID + " and ExamStation_Room.Room_ID=" + RoomId + " and ExamUser.int2 <> 0 ");
                    break;
                case 2:  //查询SP列表
                    strSql.Append("  SELECT [E_ID],[ES_ID],ExamUser.ESR_ID,[Room_ID],[EU_ID],UserInfo.[U_ID],U_TrueName,[EU_ISSP],ExamUser.int2 ");
                    strSql.Append("FROM [OSCE].[dbo].[ExamUser] ");
                    strSql.Append("inner join [OSCE].[dbo].[ExamStation_Room] on ExamUser.ESR_ID=ExamStation_Room.ESR_ID ");
                    strSql.Append("inner join [OSCE].[dbo].[UserInfo] on ExamUser.U_ID=UserInfo.U_ID ");
                    strSql.Append("where ExamStation_Room.ES_ID=" + ES_ID + " and ExamStation_Room.Room_ID=" + RoomId + " and ExamUser.EU_ISSP=1 ");
                    break;
                default:
                    break;
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 教师查询- DataRow数据转换为 model数据，返回一个对象实体  陶东利-2014-7-17
        /// </summary>
        public Tellyes.Model.CompositedModelTeacherQueryExamStationUser DataRowToModelTeacherQueryUser(DataRow row)
        {
            Tellyes.Model.CompositedModelTeacherQueryExamStationUser model = new Tellyes.Model.CompositedModelTeacherQueryExamStationUser();
            if (row != null)
            {
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = int.Parse(row["E_ID"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.EsId = int.Parse(row["ES_ID"].ToString());
                }              
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.RoomId = int.Parse(row["Room_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.EsrId = int.Parse(row["ESR_ID"].ToString());
                }
                if (row["EU_ID"] != null && row["EU_ID"].ToString() != "")
                {
                    model.EuserId = int.Parse(row["EU_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.UserId = int.Parse(row["U_ID"].ToString());
                }
                if (row["U_TrueName"] != null)
                {
                    model.UserName = row["U_TrueName"].ToString();
                }
                if (row["EU_ISSP"] != null && row["EU_ISSP"].ToString() != "")
                {
                    model.IsSp = int.Parse(row["EU_ISSP"].ToString());
                }        
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.IsJudgement = int.Parse(row["int2"].ToString());
                }                        

            }
            return model;
        }


        /// <summary>
        /// 查询每场考试的考站数量
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectEachExamStationCountByCondition(List<Guid> examTableIDList)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [int1] AS [E_ID], ")
                .Append("   COUNT(ES_ID) AS examStationCount  ")
                .Append("FROM ")
                .Append("   [ExamStation] ")
                .Append("WHERE ")
                .Append("      [int1] IN (:examTableList) ")
                .Append("GROUP BY  ")
                .Append("   [int1] ");
                
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("examStationCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetParameterList("examTableList", examTableIDList);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考站总量失败", e);
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
