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
using Tellyes.Model;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class ExamStudent: BaseDAL<Model.ExamStudent>
    {
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EStu_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamStudent");
            strSql.Append(" where EStu_ID=@EStu_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EStu_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ExamStudent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamStudent(");
            strSql.Append("EStu_ID,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool)");
            strSql.Append(" values (");
            strSql.Append("@EStu_ID,@U_ID,@E_ID,@EStu_ExamNumber,@EStu_int,@EStu_string,@EStu_bool)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.EStu_ExamNumber;
            parameters[3].Value = model.EStu_int;
            parameters[4].Value = model.EStu_string;
            parameters[5].Value = model.EStu_bool;
            parameters[6].Value = model.EStu_ID;

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
        public bool Update(Model.ExamStudent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamStudent set ");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("EStu_ExamNumber=@EStu_ExamNumber,");
            strSql.Append("EStu_int=@EStu_int,");
            strSql.Append("EStu_string=@EStu_string,");
            strSql.Append("EStu_bool=@EStu_bool");
            strSql.Append(" where EStu_ID=@EStu_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.EStu_ExamNumber;
            parameters[3].Value = model.EStu_int;
            parameters[4].Value = model.EStu_string;
            parameters[5].Value = model.EStu_bool;
            parameters[6].Value = model.EStu_ID;

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
        public bool Delete(int EStu_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStudent ");
            strSql.Append(" where EStu_ID=@EStu_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EStu_ID;

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
        public bool DeleteList(string EStu_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStudent ");
            strSql.Append(" where EStu_ID in (" + EStu_IDlist + ")  ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList_Where(string sql)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamStudent ");
            strSql.Append(" where " + sql + "  ;");
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
        public Model.ExamStudent GetModel(int EStu_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 EStu_ID,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool from ExamStudent ");
            strSql.Append(" where EStu_ID=@EStu_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EStu_ID;

            Model.ExamStudent model = new Model.ExamStudent();
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
        public Model.ExamStudent DataRowToModel(DataRow row)
        {
            Model.ExamStudent model = new Model.ExamStudent();
            if (row != null)
            {
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = new Guid(row["EStu_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["EStu_ExamNumber"] != null && row["EStu_ExamNumber"].ToString() != "")
                {
                    model.EStu_ExamNumber = int.Parse(row["EStu_ExamNumber"].ToString());
                }
                if (row["EStu_int"] != null && row["EStu_int"].ToString() != "")
                {
                    model.EStu_int = int.Parse(row["EStu_int"].ToString());
                }
                if (row["EStu_string"] != null)
                {
                    model.EStu_string = row["EStu_string"].ToString();
                }
                if (row["EStu_bool"] != null && row["EStu_bool"].ToString() != "")
                {
                    if ((row["EStu_bool"].ToString() == "1") || (row["EStu_bool"].ToString().ToLower() == "true"))
                    {
                        model.EStu_bool = true;
                    }
                    else
                    {
                        model.EStu_bool = false;
                    }
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
            strSql.Append("select EStu_ID,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool ");
            strSql.Append(" FROM ExamStudent ");
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
            strSql.Append(" EStu_ID,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool ");
            strSql.Append(" FROM ExamStudent ");
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
            strSql.Append("select count(1) FROM ExamStudent ");
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
                strSql.Append("order by T.EStu_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamStudent T ");
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
            parameters[0].Value = "ExamStudent";
            parameters[1].Value = "EStu_ID";
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
        /// 递增打印次数
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        public static void AddPrintCount(string E_ID,string U_ID)
        {
            string sql = " update ExamStudent set EStu_int=coalesce(EStu_int,0)+1 where U_ID in (" + U_ID + ") and E_ID='" + E_ID + "'; ";
            DbHelperSQL.GetSingle(sql);

        }

        /// <summary>
        /// 获取某次考试考生信息
        /// </summary>
        /// <param name="examID">考试id</param>
        /// <returns></returns>
        public DataSet GetExamStudentInfo(Guid examID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.U_ID,B.U_Name,A.EStu_ExamNumber as ExamNumber,A.E_ID from ");
            strSql.Append(string.Format("(select * from ExamStudent where E_ID='{0}') as A ", examID));
            strSql.Append("left join UserInfo as B on A.U_ID=B.U_ID");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据UID查找考生信息
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet GetExamStudentInfo(int UID, Guid EID)
        {
            string strSql = string.Format("select * from [ExamStudent] where U_ID = '{0}' and E_ID = '{1}'", UID, EID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamStudentAndUserInfoByExamID(Guid examID)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [ExamStudent].[EStu_ID], ")
                .Append("    [ExamStudent].[U_ID], ")
                .Append("    [ExamStudent].[E_ID], ")
                .Append("    [ExamStudent].[EStu_ExamNumber], ")
                .Append("    [ExamStudent].[EStu_int], ")
                .Append("    [UserInfo].[U_Name], ")
                .Append("    [UserInfo].[U_TrueName] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID] = :E_ID ")
                .Append("ORDER BY ")
                .Append("   [ExamStudent].[EStu_ExamNumber] ASC ")
                .ToString();
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session
                    .CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.ExamStudent))
                    .AddScalar("U_Name", NHibernateUtil.String)
                    .AddScalar("U_TrueName", NHibernateUtil.String)
                    .SetGuid("E_ID", examID)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考试学生信息失败", e);
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
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public List<object> SelectExamStudentUNameByExamID(int E_ID)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                //.Append("    [ExamStudent].[EStu_ExamNumber] ")
                .Append("    [UserInfo].[U_Name] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID] = :E_ID ")
                .Append("ORDER BY ")
                .Append("   [ExamStudent].[EStu_ExamNumber] ASC ")
                .ToString();
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session
                    .CreateSQLQuery(sql)
                    //.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32)
                    .AddScalar("U_Name", NHibernateUtil.String)
                    .SetInt32("E_ID", E_ID)
                    .List<object>()
                    .ToList<object>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考试学生信息失败", e);
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
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("U_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("U_ID", conditionDictionary["U_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("examTableID,Eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["examTableID,Eq"]));
            }

            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,Eq"]));
            }
            return criteria;
        }

        #endregion


        #region 扩展方法（学生查询）
        /// <summary>
        /// 得到一个对象实体 学生查询     陶东利2014/7/15增加
        /// </summary>
        public Tellyes.Model.CompositedModelStudentQuery DataRowToModelStudentQuery(DataRow row)
        {
            Tellyes.Model.CompositedModelStudentQuery model = new Model.CompositedModelStudentQuery();
            if (row != null)
            {
                //ExamStudent 实体
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.examStudent.EStu_ID = new Guid(row["EStu_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.examStudent.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.examStudent.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["EStu_ExamNumber"] != null && row["EStu_ExamNumber"].ToString() != "")
                {
                    model.examStudent.EStu_ExamNumber = int.Parse(row["EStu_ExamNumber"].ToString());
                }
                if (row["EStu_int"] != null && row["EStu_int"].ToString() != "")
                {
                    model.examStudent.EStu_int = int.Parse(row["EStu_int"].ToString());
                }
                if (row["EStu_string"] != null)
                {
                    model.examStudent.EStu_string = row["EStu_string"].ToString();
                }
                if (row["EStu_bool"] != null && row["EStu_bool"].ToString() != "")
                {
                    model.examStudent.EStu_bool = bool.Parse(row["EStu_bool"].ToString());
                }               

                //ExamTable 实体
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.examTable.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["E_Name"] != null)
                {
                    model.examTable.E_Name = row["E_Name"].ToString();
                }
                if (row["E_StartTime"] != null && row["E_StartTime"].ToString() != "")
                {
                    model.examTable.E_StartTime = DateTime.Parse(row["E_StartTime"].ToString());
                }
                if (row["E_EndTime"] != null && row["E_EndTime"].ToString() != "")
                {
                    model.examTable.E_EndTime = DateTime.Parse(row["E_EndTime"].ToString());
                }
                if (row["E_CreateUser"] != null)
                {
                    model.examTable.E_CreateUser = row["E_CreateUser"].ToString();
                }
                if (row["E_CreateTime"] != null && row["E_CreateTime"].ToString() != "")
                {
                    model.examTable.E_CreateTime = DateTime.Parse(row["E_CreateTime"].ToString());
                }
                if (row["E_ModifyTime"] != null && row["E_ModifyTime"].ToString() != "")
                {
                    model.examTable.E_ModifyTime = DateTime.Parse(row["E_ModifyTime"].ToString());
                }
                if (row["E_Kind"] != null && row["E_Kind"].ToString() != "")
                {
                    model.examTable.E_Kind = int.Parse(row["E_Kind"].ToString());
                }
                if (row["E_OID"] != null)
                {
                    model.examTable.E_OID = row["E_OID"].ToString();
                }
                if (row["E_GID"] != null)
                {
                    model.examTable.E_GID = row["E_GID"].ToString();
                }
                if (row["E_NoStuID"] != null)
                {
                    model.examTable.E_NoStuID = row["E_NoStuID"].ToString();
                }
                if (row["E_LongStationExamTimeNum"] != null && row["E_LongStationExamTimeNum"].ToString() != "")
                {
                    model.examTable.E_LongStationExamTimeNum = int.Parse(row["E_LongStationExamTimeNum"].ToString());
                }
                if (row["E_LongStationScoreTimeNum"] != null && row["E_LongStationScoreTimeNum"].ToString() != "")
                {
                    model.examTable.E_LongStationScoreTimeNum = int.Parse(row["E_LongStationScoreTimeNum"].ToString());
                }
                if (row["E_ShortStationExamTimeNum"] != null && row["E_ShortStationExamTimeNum"].ToString() != "")
                {
                    model.examTable.E_ShortStationExamTimeNum = int.Parse(row["E_ShortStationExamTimeNum"].ToString());
                }
                if (row["E_ShortStationScoreTimeNum"] != null && row["E_ShortStationScoreTimeNum"].ToString() != "")
                {
                    model.examTable.E_ShortStationScoreTimeNum = int.Parse(row["E_ShortStationScoreTimeNum"].ToString());
                }
                if (row["E_State"] != null && row["E_State"].ToString() != "")
                {
                    model.examTable.E_State = int.Parse(row["E_State"].ToString());
                }
                if (row["E_ZadokTheExaminer"] != null)
                {
                    model.examTable.E_ZadokTheExaminer = row["E_ZadokTheExaminer"].ToString();
                }
                if (row["E_IsOpenScore"] != null && row["E_IsOpenScore"].ToString() != "")
                {
                    model.examTable.E_IsOpenScore = int.Parse(row["E_IsOpenScore"].ToString());
                }
                if (row["E_IsOpenVideo"] != null && row["E_IsOpenVideo"].ToString() != "")
                {
                    model.examTable.E_IsOpenVideo = int.Parse(row["E_IsOpenVideo"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.examTable.int1 = int.Parse(row["int1"].ToString());
                }
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.examTable.int2 = int.Parse(row["int2"].ToString());
                }
                if (row["int3"] != null && row["int3"].ToString() != "")
                {
                    model.examTable.int3 = int.Parse(row["int3"].ToString());
                }
                if (row["string1"] != null)
                {
                    model.examTable.string1 = row["string1"].ToString();
                }
                if (row["string2"] != null)
                {
                    model.examTable.string2 = row["string2"].ToString();
                }
                if (row["string3"] != null)
                {
                    model.examTable.string3 = row["string3"].ToString();
                }
                if (row["date1"] != null && row["date1"].ToString() != "")
                {
                    model.examTable.date1 = DateTime.Parse(row["date1"].ToString());
                }
                if (row["date2"] != null && row["date2"].ToString() != "")
                {
                    model.examTable.date2 = DateTime.Parse(row["date2"].ToString());
                }
                if (row["date3"] != null && row["date3"].ToString() != "")
                {
                    model.examTable.date3 = DateTime.Parse(row["date3"].ToString());
                }
                if (row["float1"] != null && row["float1"].ToString() != "")
                {
                    model.examTable.float1 = decimal.Parse(row["float1"].ToString());
                }
                if (row["float2"] != null && row["float2"].ToString() != "")
                {
                    model.examTable.float2 = decimal.Parse(row["float2"].ToString());
                }
                if (row["float3"] != null && row["float3"].ToString() != "")
                {
                    model.examTable.float3 = decimal.Parse(row["float3"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得某个学生所参与的所有考试列表，按照考试开始时间升序排列
        /// </summary>
        public DataSet GetListStudentQuery(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EStu_ID,U_ID,ExamStudent.E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool,");
            strSql.Append(" [E_Name],[E_StartTime],[E_EndTime],[E_CreateUser],[E_CreateTime],[E_ModifyTime],[E_Kind],[E_OID],[E_GID],[E_NoStuID],");
            strSql.Append("[E_LongStationExamTimeNum],[E_LongStationScoreTimeNum],[E_ShortStationExamTimeNum],[E_ShortStationScoreTimeNum],[E_State],");
            strSql.Append("[E_ZadokTheExaminer],[E_IsOpenScore],[E_IsOpenVideo],[int1],[int2],[int3],[string1],[string2],[string3],[date1],[date2],");
            strSql.Append("[date3],[float1],[float2],[float3]");
            strSql.Append("FROM [OSCE].[dbo].[ExamStudent]");
            strSql.Append("INNER JOIN [OSCE].[dbo].[ExamTable]  ON ExamTable.E_ID =ExamStudent.E_ID  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where EStu_ID in (select MIN(EStu_ID) from [OSCE].[dbo].[ExamStudent] where U_ID= " + strWhere + "group by E_ID ) ");
            }
            strSql.Append("and E_StartTime is not null ");
            strSql.Append("and E_EndTime is not null ");
            strSql.Append("and E_Kind is not null ");
            strSql.Append("and int2 is not null ");
            strSql.Append("order by E_StartTime Asc");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据考试ID查询考生信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamStudentInfoListByCondition(Dictionary<string, object> conditionDictionary)
        {
             //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [UserInfo].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID] = :E_ID ")
                .Append("ORDER BY ")
                .Append("   [ExamStudent].[EStu_ExamNumber] ASC");
            
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
               
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据考试ID查询参加考试的学生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-多站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamStudentCountInMultiStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
             //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("    COUNT(*) AS [ExamStudentCount] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("     ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN  ")
                .Append("    (SELECT  ")
                .Append("        [U_ID],  ")
                .Append("        MIN([Exam_StartTime]) AS [MINExam_StartTime] ")
                .Append("   FROM  ")
                .Append("       [MultiStationExamArrangement] ")
                .Append("   WHERE ")
                .Append("       [E_ID] = :E_ID ")
                .Append("   GROUP BY ")
                .Append("   [U_ID] ")
                .Append("  )AS [EStu_ExamNumberArrangement] ")
                .Append("   ON [ExamStudent].[U_ID]=[EStu_ExamNumberArrangement].[U_ID]  ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamStudentCount", NHibernateUtil.Int32);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-长短站考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamStudentCountInLongShortStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("    COUNT(*) AS [ExamStudentCount] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("     ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN  ")
                .Append("    (SELECT  ")
                .Append("        [U_ID],  ")
                .Append("        MIN([OEA_StartTime]) AS [MINExam_StartTime] ")
                .Append("   FROM  ")
                .Append("       [OSCEExaminationArrangement] ")
                .Append("   WHERE ")
                .Append("       [E_ID] = :E_ID ")
                .Append("   GROUP BY ")
                .Append("   [U_ID] ")
                .Append("  )AS [EStu_ExamNumberArrangement] ")
                .Append("   ON [ExamStudent].[U_ID]=[EStu_ExamNumberArrangement].[U_ID]  ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamStudentCount", NHibernateUtil.Int32);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-单站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamStudentCountInSingleStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("    COUNT(*) AS [ExamStudentCount] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("     ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID],  ")
                .Append("           MIN([SE_StartTime]) AS [MINExam_StartTime] ")
                .Append("       FROM  ")
                .Append("           [SingleStationExamArrangement] ")
                .Append("       WHERE ")
                .Append("           [E_ID] = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID]=[EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");
            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamStudentCount", NHibernateUtil.Int32);

                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 条件查询参加该场考试的考生信息-多站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListInMultiStationExamByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN(Exam_StartTime) AS [MINExam_StartTime] ")
                .Append("       FROM  ")
                .Append("           [MultiStationExamArrangement] ")
                .Append("       WHERE ")
                .Append("           [E_ID] = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            if (orderList != null && orderList.Count > 0)
            {
                sqlConditionStringBuilder.Append("ORDER BY ");
                foreach (KeyValuePair<string, string> item in orderList)
                {
                    string orderItem = "";
                    if(item.Key == "student_exam_start_datetime")
                    {
                        orderItem = "[EStu_ExamNumberArrangement].[MINExam_StartTime]";
                    }
                    else if(item.Key == "EStu_ExamNumber")
                    {
                        orderItem = "[ExamStudent].[EStu_ExamNumber]";
                    }
                    if (orderItem != "")
                    {
                        sqlConditionStringBuilder.Append(orderItem).Append(" ").Append(item.Value).Append(",");
                    }
                }
                if (sqlConditionStringBuilder[sqlConditionStringBuilder.Length - 1] == ',')
                {
                    sqlConditionStringBuilder.Remove(sqlConditionStringBuilder.Length - 1, 1);
                }
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<object[]>()
                   .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 条件查询参加该场考试的考生信息-长短站考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListInLongShortStationExamByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN(OEA_StartTime) AS [MINExam_StartTime] ")
                .Append("       FROM  ")
                .Append("           [OSCEExaminationArrangement] ")
                .Append("       WHERE ")
                .Append("           [E_ID] = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            if (orderList != null && orderList.Count > 0)
            {
                sqlConditionStringBuilder.Append("ORDER BY ");
                foreach (KeyValuePair<string, string> item in orderList)
                {
                    string orderItem = "";
                    if (item.Key == "student_exam_start_datetime")
                    {
                        orderItem = "[EStu_ExamNumberArrangement].[MINExam_StartTime]";
                    }
                    else if (item.Key == "EStu_ExamNumber")
                    {
                        orderItem = "[ExamStudent].[EStu_ExamNumber]";
                    }
                    if (orderItem != "")
                    {
                        sqlConditionStringBuilder.Append(orderItem).Append(" ").Append(item.Value).Append(",");
                    }
                }
                if (sqlConditionStringBuilder[sqlConditionStringBuilder.Length - 1] == ',')
                {
                    sqlConditionStringBuilder.Remove(sqlConditionStringBuilder.Length - 1, 1);
                }
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<object[]>()
                   .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩查询与打印页面 条件查询参加该场考试的考生信息-单站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListInSingleStationExamByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN([SE_StartTime]) AS [MINExam_StartTime] ")
                .Append("       FROM  ")
                .Append("           [SingleStationExamArrangement] ")
                .Append("       WHERE ")
                .Append("           [E_ID] = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] >= :examStartTime ");
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                sqlConditionStringBuilder.Append("AND [EStu_ExamNumberArrangement].[MINExam_StartTime] <= :examEndTime ");
            }
            if (orderList != null && orderList.Count > 0)
            {
                sqlConditionStringBuilder.Append("ORDER BY ");
                foreach (KeyValuePair<string, string> item in orderList)
                {
                    string orderItem = "";
                    if (item.Key == "student_exam_start_datetime")
                    {
                        orderItem = "[EStu_ExamNumberArrangement].[MINExam_StartTime]";
                    }
                    else if (item.Key == "EStu_ExamNumber")
                    {
                        orderItem = "[ExamStudent].[EStu_ExamNumber]";
                    }
                    if (orderItem != "")
                    {
                        sqlConditionStringBuilder.Append(orderItem).Append(" ").Append(item.Value).Append(",");
                    }
                }
                if (sqlConditionStringBuilder[sqlConditionStringBuilder.Length - 1] == ',')
                {
                    sqlConditionStringBuilder.Remove(sqlConditionStringBuilder.Length - 1, 1);
                }
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<object[]>()
                   .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询学生成绩打印-多站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListPrintInMultiStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN(Exam_StartTime) AS MINExam_StartTime ")
                .Append("       FROM  ")
                .Append("           [MultiStationExamArrangement] ")
                .Append("       WHERE ")
                .Append("           E_ID = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder(string.Empty);
            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_ID]  IN  (:U_IDList) ");
            }
            StringBuilder sqlOrderByStringBuilder = new StringBuilder(string.Empty)
                .Append("ORDER BY ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime] ASC ");

            string sql = sqlStringBuilder.ToString()  + sqlConditionStringBuilder.ToString()+sqlOrderByStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In")){
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询学生成绩打印-长短站
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListPrintInLongShortStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN(OEA_StartTime) AS MINExam_StartTime ")
                .Append("       FROM  ")
                .Append("           [OSCEExaminationArrangement] ")
                .Append("       WHERE ")
                .Append("           E_ID = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder(string.Empty);
            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_ID]  IN  (:U_IDList) ");
            }
            StringBuilder sqlOrderByStringBuilder = new StringBuilder(string.Empty)
                .Append("ORDER BY ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime] ASC ");

            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString() + sqlOrderByStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In"))
                {
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询学生成绩打印-单站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListPrintInSingleStationExam(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime], ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [U_ID], ")
                .Append("           MIN(SE_StartTime) AS MINExam_StartTime ")
                .Append("       FROM  ")
                .Append("           [SingleStationExamArrangement] ")
                .Append("       WHERE ")
                .Append("           E_ID = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [U_ID] ")
                .Append("   ) AS [EStu_ExamNumberArrangement] ")
                .Append("       ON [ExamStudent].[U_ID] = [EStu_ExamNumberArrangement].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder(string.Empty);
            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_ID]  IN  (:U_IDList) ");
            }
            StringBuilder sqlOrderByStringBuilder = new StringBuilder(string.Empty)
                .Append("ORDER BY ")
                .Append("   [EStu_ExamNumberArrangement].[MINExam_StartTime] ASC ");

            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString() + sqlOrderByStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("MINExam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("U_ID,In"))
                {
                    iSQLQuery.SetParameterList("U_IDList", (List<int>)conditionDictionary["U_ID,In"]);
                }
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩展示页面：查询学生信息和总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectStudentInfoAndTotalScoreBySingleStation(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [UserInfo].[U_ID] ,")
                .Append("   [UserInfo].[U_Name] ,")
                .Append("   [UserInfo].[U_TrueName] ,")
                .Append("   [ExamStudent].[EStu_ExamNumber] ,")
                .Append("   [TotalScoreSummariedScore].[TotalScore] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN ( ")
                .Append("       SELECT  ")
                .Append("           [ScoreSummariedScore].[Student_ID],  ")
                .Append("           SUM([ScoreSummariedScore].[score]) AS [TotalScore] ")
                .Append("       FROM ")
                .Append("           [ScoreSummariedScore] ")
                .Append("       WHERE ")
                .Append("           [ScoreSummariedScore].[E_ID] = :E_ID ")
                .Append("       GROUP BY ")
                .Append("           [ScoreSummariedScore].[Student_ID] ")
                .Append("   ) AS [TotalScoreSummariedScore] ")
                .Append("       ON [ExamStudent].[U_ID] = [TotalScoreSummariedScore].[Student_ID]  ")
                .Append("WHERE ")
                .Append("       [ExamStudent].[E_ID] = :E_ID ")
                .Append("ORDER  BY ")
                .Append("   [TotalScoreSummariedScore].[TotalScore] DESC, ")
                .Append("   [ExamStudent].[EStu_ExamNumber] ASC ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("TotalScore", NHibernateUtil.Decimal);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));

                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生以及总分失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩录入与修改页面  根据条件查询考生信息总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamStudentCountInScoreModifyPageByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("    COUNT(DISTINCT [UserInfo].[U_ID]) AS [ExamStudentCount] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("     ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlConditionStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlConditionStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }

            if (conditionDictionary.ContainsKey("O_ID,IN") || conditionDictionary.ContainsKey("O_ID,NotIn"))
            {
                sqlStringBuilder.Append("AND ( ");
                string organizationIN = "";
                if (conditionDictionary.ContainsKey("O_ID,IN"))
                {
                    organizationIN = "[ExamStudent].[U_ID] IN (SELECT DISTINCT [U_ID] FROM [UserOrganization] WHERE [O_ID] IN (:O_IDList)) ";
                }
                string organizationNotIN = "";
                if (conditionDictionary.ContainsKey("O_ID,NotIn"))
                {
                    organizationNotIN = "[ExamStudent].[U_ID] NOT IN (SELECT DISTINCT [U_ID] FROM [UserOrganization] WHERE [O_ID] IN (:All_O_IDList)) ";
                }
                sqlStringBuilder.Append(organizationIN + (organizationIN != "" && organizationNotIN != "" ? " OR " : "") + organizationNotIN);
                sqlStringBuilder.Append(") ");
            }

            if (conditionDictionary.ContainsKey("score_not_completed_student,NOT IN"))
            {
                sqlConditionStringBuilder
                    .Append("AND [ExamStudent].[U_ID]  NOT IN ( ")
                    .Append("   SELECT ")
                    .Append("       [ScoreInfoCount].[Student_ID] ")
                    .Append("   FROM ")
                    .Append("       ( ")
                    .Append("           SELECT ")
                    .Append("               [ExamUser].[string1] AS [ES_ID], ")
                    .Append("               [ExamUser].[int3] AS [Room_ID], ")
                    .Append("               COUNT(DISTINCT [ExamUser].[U_ID]) AS [ExamUserCount] ")
                    .Append("           FROM ")
                    .Append("               [ExamUser] ")
                    .Append("               INNER JOIN [ExamUserMarkSheet] ")
                    .Append("                   ON [ExamUser].[EU_ID] = [ExamUserMarkSheet].[EU_ID] ")
                    .Append("           WHERE ")
                    .Append("               [ExamUser].[E_ID] =:E_ID ")
                    .Append("           GROUP BY ")
                    .Append("               [ExamUser].[string1], ")
                    .Append("               [ExamUser].[int3] ")
                    .Append("       ) AS [ExamUserCount] ")
                    .Append("       INNER JOIN ( ")
                    .Append("           SELECT ")
                    .Append("               [Student_ID], ")
                    .Append("               [ExamStation_ID], ")
                    .Append("               [Room_ID], ")
                    .Append("               COUNT(DISTINCT [Rater_ID])  AS [ScoreInfoCount] ")
                    .Append("           FROM ")
                    .Append("               [ScoreInfo]  ")
                    .Append("           WHERE ")
                    .Append("               [ScoreInfo].[Exam_ID] = :E_ID ")
                    .Append("               AND [ScoreInfo].[SI_int2] = 2 ")
                    .Append("           GROUP BY  ")
                    .Append("               [Student_ID], ")
                    .Append("               [ExamStation_ID], ")
                    .Append("               [Room_ID] ")
                    .Append("       ) AS [ScoreInfoCount] ")
                    .Append("           ON [ExamUserCount].[ES_ID] = [ScoreInfoCount].[ExamStation_ID] ")
                    .Append("               AND [ExamUserCount].[Room_ID] = [ScoreInfoCount].[Room_ID] ")
                    .Append("               AND [ExamUserCount].[ExamUserCount] = [ScoreInfoCount].[ScoreInfoCount] ")
                    .Append("   GROUP BY ")
                    .Append("       [ScoreInfoCount].[Student_ID] ")
                    .Append("   HAVING ")
                    .Append("       COUNT(DISTINCT [ExamUserCount].[ES_ID]) = ( ")
                    .Append("           SELECT ")
                    .Append("               COUNT(*)  ")
                    .Append("           FROM ")
                    .Append("               [ExamStation]  ")
                    .Append("           WHERE  ")
                    .Append("               [int1] = :E_ID ")
                    .Append("       )")
                    .Append(")");
            }

            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamStudentCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("O_ID,IN"))
                {
                    iSQLQuery.SetParameterList("O_IDList", (List<int>)conditionDictionary["O_ID,IN"]);
                }
                if (conditionDictionary.ContainsKey("O_ID,NotIn"))
                {
                    iSQLQuery.SetParameterList("All_O_IDList", (List<int>)conditionDictionary["O_ID,NotIn"]);
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 成绩录入与修改页面 条件查询参加该场考试的考生信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectExamScoreStudentInfoListByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [ExamStudent].[U_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("   LEFT JOIN ( ");

            if (conditionDictionary.ContainsKey("examStationID,Eq"))
            {
                sqlStringBuilder
                    .Append("       SELECT ")
                    .Append("           [ScoreSummariedScore].[Student_ID], ")
                    .Append("           [ScoreSummariedScore].[score] AS [ScoreOrderColumn] ")
                    .Append("       FROM ")
                    .Append("           [ScoreSummariedScore] ")
                    .Append("       WHERE ")
                    .Append("           [ScoreSummariedScore].[E_ID] = :E_ID ")
                    .Append("           AND [ScoreSummariedScore].[ES_ID] = :ES_ID ");
            }
            else
            {
                sqlStringBuilder
                    .Append("       SELECT ")
                    .Append("           [ScoreSummariedScore].[Student_ID], ")
                    .Append("           SUM ([ScoreSummariedScore].[score]) AS [ScoreOrderColumn] ")
                    .Append("       FROM ")
                    .Append("           [ScoreSummariedScore] ")
                    .Append("       WHERE ")
                    .Append("           [ScoreSummariedScore].[E_ID] = :E_ID ")
                    .Append("       GROUP BY ")
                    .Append("           [ScoreSummariedScore].[Student_ID] ");
                
            }
            sqlStringBuilder
                .Append("   ) AS [ScoreSummariedScoreOrder] ")
                .Append("       ON [ExamStudent].[U_ID] = [ScoreSummariedScoreOrder].[Student_ID] ")
                //.Append("   LEFT JOIN [UserOrganization] ")
                //.Append("       ON [ExamStudent].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID]= :E_ID ");

            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlStringBuilder.Append("AND [UserInfo].[U_Name] LIKE :student_UserInfoName ");
            }
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlStringBuilder.Append("AND [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                sqlStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
            }

            if (conditionDictionary.ContainsKey("O_ID,IN") || conditionDictionary.ContainsKey("O_ID,NotIn"))
            {
                sqlStringBuilder.Append("AND ( ");
                string organizationIN = "";
                if (conditionDictionary.ContainsKey("O_ID,IN"))
                {
                    organizationIN = "[ExamStudent].[U_ID] IN (SELECT DISTINCT [U_ID] FROM [UserOrganization] WHERE [O_ID] IN (:O_IDList)) ";
                }
                string organizationNotIN = "";
                if (conditionDictionary.ContainsKey("O_ID,NotIn"))
                {
                    organizationNotIN = "[ExamStudent].[U_ID] NOT IN (SELECT DISTINCT [U_ID] FROM [UserOrganization] WHERE [O_ID] IN (:All_O_IDList)) ";
                }
                sqlStringBuilder.Append(organizationIN + (organizationIN != "" && organizationNotIN != "" ? " OR " : "") + organizationNotIN);
                sqlStringBuilder.Append(") ");
            }

            if (conditionDictionary.ContainsKey("score_not_completed_student,NOT IN"))
            {
                sqlStringBuilder
                    .Append("AND [ExamStudent].[U_ID]  NOT IN ( ")
                    .Append("   SELECT ")
                    .Append("       [ScoreInfoCount].[Student_ID] ")
                    .Append("   FROM ")
                    .Append("       ( ")
                    .Append("           SELECT ")
                    .Append("               [ExamUser].[string1] AS [ES_ID], ")
                    .Append("               [ExamUser].[int3] AS [Room_ID], ")
                    .Append("               COUNT(DISTINCT [ExamUser].[U_ID]) AS [ExamUserCount] ")
                    .Append("           FROM ")
                    .Append("               [ExamUser] ")
                    .Append("               INNER JOIN [ExamUserMarkSheet] ")
                    .Append("                   ON [ExamUser].[EU_ID] = [ExamUserMarkSheet].[EU_ID] ")
                    .Append("           WHERE ")
                    .Append("               [ExamUser].[E_ID] =:E_ID ")
                    .Append("           GROUP BY ")
                    .Append("               [ExamUser].[string1], ")
                    .Append("               [ExamUser].[int3] ")
                    .Append("       ) AS [ExamUserCount] ")
                    .Append("       INNER JOIN ( ")
                    .Append("           SELECT ")
                    .Append("               [Student_ID], ")
                    .Append("               [ExamStation_ID], ")
                    .Append("               [Room_ID], ")
                    .Append("               COUNT(DISTINCT [Rater_ID])  AS [ScoreInfoCount] ")
                    .Append("           FROM ")
                    .Append("               [ScoreInfo]  ")
                    .Append("           WHERE ")
                    .Append("               [ScoreInfo].[Exam_ID] =:E_ID ")
                    .Append("               AND [ScoreInfo].[SI_int2] =2 ")
                    .Append("           GROUP BY  ")
                    .Append("               [Student_ID], ")
                    .Append("               [ExamStation_ID], ")
                    .Append("               [Room_ID] ")
                    .Append("       ) AS [ScoreInfoCount] ")
                    .Append("           ON [ExamUserCount].[ES_ID] = [ScoreInfoCount].[ExamStation_ID] ")
                    .Append("               AND [ExamUserCount].[Room_ID] = [ScoreInfoCount].[Room_ID] ")
                    .Append("               AND [ExamUserCount].[ExamUserCount] = [ScoreInfoCount].[ScoreInfoCount] ")
                    .Append("   GROUP BY ")
                    .Append("       [ScoreInfoCount].[Student_ID] ")
                    .Append("   HAVING ")
                    .Append("   COUNT(DISTINCT [ExamUserCount].[ES_ID]) = ( ")
                    .Append("       SELECT ")
                    .Append("           COUNT(*)  ")
                    .Append("       FROM ")
                    .Append("           [ExamStation]  ")
                    .Append("       WHERE  ")
                    .Append("           [int1] = :E_ID ")
                    .Append("   ) ")
                    .Append(")");
            }

            if (orderList != null && orderList.Count > 0)
            {
                sqlStringBuilder.Append(" ORDER BY ");
                foreach (KeyValuePair<string, string> item in orderList)
                {
                    sqlStringBuilder.Append(item.Key).Append(" ").Append(item.Value).Append(",");
                }
                if (sqlStringBuilder[sqlStringBuilder.Length - 1] == ',')
                {
                    sqlStringBuilder.Remove(sqlStringBuilder.Length - 1, 1);
                }
            }
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("examStationID,Eq"))
                {
                    iSQLQuery.SetGuid("ES_ID", Guid.Parse(conditionDictionary["examStationID,Eq"].ToString()));
                }
                if (conditionDictionary.ContainsKey("O_ID,IN"))
                {
                    iSQLQuery.SetParameterList("O_IDList", (List<int>)conditionDictionary["O_ID,IN"]);
                }
                if (conditionDictionary.ContainsKey("O_ID,NotIn"))
                {
                    iSQLQuery.SetParameterList("All_O_IDList", (List<int>)conditionDictionary["O_ID,NotIn"]);
                }

                //查询结果并返回
                if (pageIndex != null && pageSize != null)
                {
                    
                    return iSQLQuery
                        .SetFirstResult((pageIndex - 1) * pageSize)
                        .SetMaxResults(pageSize)
                        .List<object[]>()
                        .ToList<object[]>();
                }
                else
                {
                    return iSQLQuery.List<object[]>().ToList<object[]>();
                }
                
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生信息失败", e);
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
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectPerSelectedStudentInfo(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [UserInfo].[U_ID] ,")
                .Append("   [UserInfo].[U_Name] ,")
                .Append("   [UserInfo].[U_TrueName] ,")
                .Append("   [ExamStudent].[EStu_ExamNumber] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("       [ExamStudent].[E_ID] = :E_ID ")
                .Append("       AND [ExamStudent].[U_ID] = :U_ID ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID,Eq"]));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询选中的考生信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询各个班级的考生数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectEachOrganizationStudentCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [Organization].[O_ID] ,")
                .Append("   COUNT(DISTINCT [ExamStudent].[U_ID]) AS [examStudentCount] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [UserOrganization].[O_ID] = [Organization].[O_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[E_ID] = :E_ID ")
                .Append("GROUP BY ")
                .Append("   [Organization].[O_ID], ")
                .Append("   [Organization].[O_Name] ")
                .Append("ORDER BY ")
                .Append("   [Organization].[O_Name] ASC ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("O_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("examStudentCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件各个班级的考生数量失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 查询每场考试的学生数量
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectEachExamStudentCountByCondition(List<Guid> examTableIDList)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT ")
                .Append("   [E_ID], ")
                .Append("   COUNT(U_ID) AS examStudentCount  ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("WHERE ")
                .Append("      [E_ID] IN (:examTableList) ")
                .Append("GROUP BY  ")
                .Append("   [E_ID] ");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("examStudentCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetParameterList("examTableList", examTableIDList);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考生总量失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 条件查询考试视频
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelecPlaybackByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlBaseStringBuilder = new StringBuilder(string.Empty);
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamTable].[E_Name], ")
                .Append("   [ExamStation].[ES_Name], ")
                .Append("   [ExamStudent].[U_ID],")
                .Append("   [ExamStudent].[EStu_ExamNumber], ")
                .Append("   [UserInfo].[U_Name], ")
                .Append("   [UserInfo].[U_TrueName], ")
                .Append("   [EA].[StartTime], ")
                .Append("   [EA].[EndTime], ")
                .Append("   [CameraSavePath].[File_Path] ")
                .Append("FROM ")
                .Append("      (SELECT * FROM [UserInfo] ");

            bool needjoinstr = false;
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlStringBuilder.Append("where [UserInfo].[U_Name] LIKE :student_UserInfoName ");
                needjoinstr = true;
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                if (needjoinstr)
                {
                    sqlStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
                }
                else
                {
                    sqlStringBuilder.Append("where [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
                }
            }
            sqlStringBuilder.Append(") [UserInfo] inner join (");
            sqlStringBuilder.Append("select * from [ExamStudent]");
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlStringBuilder.Append("where [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            sqlStringBuilder.Append(") [ExamStudent] on [UserInfo].[U_ID] = [ExamStudent].[U_ID] ");
            //单站考试
            StringBuilder sqlSingleStringBuilder = new StringBuilder("");
            //多站考试
            StringBuilder sqlMultiStringBuilder = new StringBuilder("");
            //长短站考试
            StringBuilder sqlOSCEStringBuilder = new StringBuilder("");
            needjoinstr = false;
            sqlSingleStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[SE_StartTime] as [StartTime], [SE_EndTime] as [EndTime] ")
                .Append("from [SingleStationExamArrangement] ");
            sqlMultiStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[Exam_StartTime] as [StartTime], [Exam_EndTime] as [EndTime] ")
                .Append("from [MultiStationExamArrangement] ");
            sqlOSCEStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[OEA_StartTime] as [StartTime], [OEA_EndTime] as [EndTime] ")
                .Append("from [OSCEExaminationArrangement] ");
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlSingleStringBuilder.Append("where [SingleStationExamArrangement].[SE_StartTime] >= :examStartTime ");
                sqlMultiStringBuilder.Append("where [MultiStationExamArrangement].[Exam_StartTime] >= :examStartTime ");
                sqlOSCEStringBuilder.Append("where [OSCEExaminationArrangement].[OEA_StartTime] >= :examStartTime ");
                needjoinstr = true;
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                if (needjoinstr)
                {
                    sqlSingleStringBuilder.Append("AND [SingleStationExamArrangement].[SE_EndTime] <= :examEndTime ");
                    sqlMultiStringBuilder.Append("AND [MultiStationExamArrangement].[Exam_EndTime] <= :examEndTime ");
                    sqlOSCEStringBuilder.Append("AND [OSCEExaminationArrangement].[OEA_EndTime] >= :examEndTime ");
                    needjoinstr = true;
                }
                else
                {
                    sqlSingleStringBuilder.Append("where [SingleStationExamArrangement].[SE_EndTime] <= :examEndTime ");
                    sqlMultiStringBuilder.Append("where [MultiStationExamArrangement].[Exam_EndTime] <= :examEndTime ");
                    sqlOSCEStringBuilder.Append("where [OSCEExaminationArrangement].[OEA_EndTime] >= :examEndTime ");
                }
            }
            //评委条件
            StringBuilder sqlRaterStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("rater_UserInfoTrueName,Like"))
            {
                sqlRaterStringBuilder.Append(") [EA] on [EA].[U_ID]=[ExamStudent].[U_ID] ")
                    .Append("inner join (SELECT [ExamUser].E_ID FROM (select * from [UserInfo] ")
                    .Append("where [UserInfo].[U_TrueName] LIKE :rater_UserInfoTrueName) ")
                    .Append("[UserInfo] inner join ")
                    .Append("(SELECT * FROM [ExamUser] WHERE  [ExamUser].[EU_ISSP] != 0) [ExamUser] ")
                    .Append("on [UserInfo].[U_ID] = [ExamUser].[U_ID]")
                    .Append(") [RaterInfo] on [EA].[E_ID] = [RaterInfo].[E_ID] ");
            }
            else
            {
                sqlRaterStringBuilder.Append(") [EA] on [EA].[U_ID]=[ExamStudent].[U_ID] ");
            }
            //加上考试名称，考站名称
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                sqlRaterStringBuilder.Append("inner join (SELECT * FROM [ExamTable] where [E_ID] = :E_ID) ExamTable ")
                    .Append("on [ExamTable].[E_ID] = [EA].[E_ID] ");
            }
            sqlRaterStringBuilder.Append("inner join [ExamStation]")
                .Append("on [ExamStation].[int1] = [EA].[E_ID] ")
                .Append("and [ExamStation].[ES_ID] = [EA].[ES_ID] ");
            //录像路径
            StringBuilder sqlFilePathStringBuilder = new StringBuilder("");
            sqlFilePathStringBuilder.Append("inner join [CameraSavePath] on  [ExamStudent].[U_ID] = [CameraSavePath].[U_ID] ")
                .Append("and [CameraSavePath].[E_ID] = [EA].[E_ID] ")
                .Append("and [CameraSavePath].[ES_ID] = [EA].[ES_ID] ");

            //拼合所有
            sqlBaseStringBuilder.Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlSingleStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder)
                .Append("union all ")
                .Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlMultiStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder)
                .Append("union all ")
                .Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlOSCEStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder);

            string sql = sqlBaseStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("ES_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("EStu_ExamNumber", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("U_TrueName", NHibernateUtil.String);
                iSQLQuery.AddScalar("StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("EndTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("File_Path", NHibernateUtil.String);

                //设置查询参数
                if(conditionDictionary.ContainsKey("E_ID,Eq"))
                {
                    iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                }
                if (conditionDictionary.ContainsKey("rater_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("rater_UserInfoTrueName", "%" + conditionDictionary["rater_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<object[]>()
                   .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考试视频失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 考试视频回放页面 根据条件查询视频总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchexamPlaybackCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlBaseStringBuilder = new StringBuilder(string.Empty);
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT [UserInfo].[U_ID] FROM ")
                .Append("      (SELECT * FROM [UserInfo] ");

            bool needjoinstr = false;
            if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
            {
                sqlStringBuilder.Append("where [UserInfo].[U_Name] LIKE :student_UserInfoName ");
                needjoinstr = true;
            }
            if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
            {
                if (needjoinstr)
                {
                    sqlStringBuilder.Append("AND [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
                }
                else
                {
                    sqlStringBuilder.Append("where [UserInfo].[U_TrueName] LIKE :student_UserInfoTrueName ");
                }
            }
            sqlStringBuilder.Append(") [UserInfo] inner join (");
            sqlStringBuilder.Append("select * from [ExamStudent]");
            if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
            {
                sqlStringBuilder.Append("where [ExamStudent].[EStu_ExamNumber] LIKE :student_ExamNumber ");
            }
            sqlStringBuilder.Append(") [ExamStudent] on [UserInfo].[U_ID] = [ExamStudent].[U_ID] ");
            //单站考试
            StringBuilder sqlSingleStringBuilder = new StringBuilder("");
            //多站考试
            StringBuilder sqlMultiStringBuilder = new StringBuilder("");
            //长短站考试
            StringBuilder sqlOSCEStringBuilder = new StringBuilder("");
            needjoinstr = false;
            sqlSingleStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[SE_StartTime] as [StartTime], [SE_EndTime] as [EndTime] ")
                .Append("from [SingleStationExamArrangement] ");
            sqlMultiStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[Exam_StartTime] as [StartTime], [Exam_EndTime] as [EndTime] ")
                .Append("from [MultiStationExamArrangement] ");
            sqlOSCEStringBuilder.Append("(SELECT [U_ID],[E_ID],[ES_ID],[OEA_StartTime] as [StartTime], [OEA_EndTime] as [EndTime] ")
                .Append("from [OSCEExaminationArrangement] ");
            if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
            {
                sqlSingleStringBuilder.Append("where [SingleStationExamArrangement].[SE_StartTime] >= :examStartTime ");
                sqlMultiStringBuilder.Append("where [MultiStationExamArrangement].[Exam_StartTime] >= :examStartTime ");
                sqlOSCEStringBuilder.Append("where [OSCEExaminationArrangement].[OEA_StartTime] >= :examStartTime ");
                needjoinstr = true;
            }
            if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
            {
                if (needjoinstr)
                {
                    sqlSingleStringBuilder.Append("AND [SingleStationExamArrangement].[SE_EndTime] <= :examEndTime ");
                    sqlMultiStringBuilder.Append("AND [MultiStationExamArrangement].[Exam_EndTime] <= :examEndTime ");
                    sqlOSCEStringBuilder.Append("AND [OSCEExaminationArrangement].[OEA_EndTime] >= :examEndTime ");
                    needjoinstr = true;
                }
                else
                {
                    sqlSingleStringBuilder.Append("where [SingleStationExamArrangement].[SE_EndTime] <= :examEndTime ");
                    sqlMultiStringBuilder.Append("where [MultiStationExamArrangement].[Exam_EndTime] <= :examEndTime ");
                    sqlOSCEStringBuilder.Append("where [OSCEExaminationArrangement].[OEA_EndTime] >= :examEndTime ");
                }
            }
            //评委条件
            StringBuilder sqlRaterStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("rater_UserInfoTrueName,Like"))
            {
                sqlRaterStringBuilder.Append(") [EA] on [EA].[U_ID]=[ExamStudent].[U_ID] ")
                    .Append("inner join (SELECT [ExamUser].E_ID FROM (select * from [UserInfo] ")
                    .Append("where [UserInfo].[U_TrueName] LIKE :rater_UserInfoTrueName) ")
                    .Append("[UserInfo] inner join ")
                    .Append("(SELECT * FROM [ExamUser] WHERE  [ExamUser].[EU_ISSP] != 0) [ExamUser] ")
                    .Append("on [UserInfo].[U_ID] = [ExamUser].[U_ID]")
                    .Append(") [RaterInfo] on [EA].[E_ID] = [RaterInfo].[E_ID] ");
            }
            else
            {
                sqlRaterStringBuilder.Append(") [EA] on [EA].[U_ID]=[ExamStudent].[U_ID] ");
            }
            //加上考试名称，考站名称
            if (conditionDictionary.ContainsKey("E_ID,Eq"))
            {
                sqlRaterStringBuilder.Append("inner join (SELECT * FROM [ExamTable] where [E_ID] = :E_ID) ExamTable ")
                    .Append("on [ExamTable].[E_ID] = [EA].[E_ID] ");
            }
            sqlRaterStringBuilder.Append("inner join [ExamStation]")
                .Append("on [ExamStation].[int1] = [EA].[E_ID] ")
                .Append("and [ExamStation].[ES_ID] = [EA].[ES_ID] ");
            //录像路径
            StringBuilder sqlFilePathStringBuilder = new StringBuilder("");
            sqlFilePathStringBuilder.Append("inner join [CameraSavePath] on  [ExamStudent].[U_ID] = [CameraSavePath].[U_ID] ")
                .Append("and [CameraSavePath].[E_ID] = [EA].[E_ID] ")
                .Append("and [CameraSavePath].[ES_ID] = [EA].[ES_ID] ");

            //拼合所有
            sqlBaseStringBuilder.Append("select count(*) as [ExamPlaybackCount] from (")
                .Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlSingleStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder)
                .Append("union all ")
                .Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlMultiStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder)
                .Append("union all ")
                .Append(sqlStringBuilder)
                .Append("inner join ")
                .Append(sqlOSCEStringBuilder)
                .Append(sqlRaterStringBuilder)
                .Append(sqlFilePathStringBuilder)
                .Append(") TEMP_TABLE");

            string sql = sqlBaseStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamPlaybackCount", NHibernateUtil.Int32);
                if (conditionDictionary.ContainsKey("E_ID,Eq"))
                {
                    iSQLQuery.SetGuid("E_ID", Guid.Parse(conditionDictionary["E_ID,Eq"].ToString()));
                }
                if (conditionDictionary.ContainsKey("rater_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("rater_UserInfoTrueName", "%" + conditionDictionary["rater_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoName", "%" + conditionDictionary["student_UserInfoName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("student_ExamNumber", "%" + conditionDictionary["student_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("student_UserInfoTrueName,Like"))
                {
                    iSQLQuery.SetString("student_UserInfoTrueName", "%" + conditionDictionary["student_UserInfoTrueName,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("ExamStartTime,Earliest"))
                {
                    iSQLQuery.SetDateTime("examStartTime", Convert.ToDateTime(conditionDictionary["ExamStartTime,Earliest"]));
                }
                if (conditionDictionary.ContainsKey("ExamEndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("examEndTime", Convert.ToDateTime(conditionDictionary["ExamEndTime,Latest"]));
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询考试视频总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }
        #endregion

        #region 获取的是学生最近一周的考站信息
        /// <summary>
        /// 获取的是学生最近一周的考站信息
        /// </summary>
        /// <returns></returns>
        public DataSet getStuStationInfos(int userID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct *  from ( 	select     c.E_ID    ,c.E_Name    ,c.E_StartTime    ,c.E_EndTime     from   UserInfo  as  a   inner join  MultiStationExamArrangement as b   on a.U_ID = b.U_ID   inner join  ExamTable as ");
            strSql.Append(" 	c   on b.E_ID=c.E_ID    where   c.E_StartTime between '2015-05-26' and DATEADD(DAY,7,GETDATE())   and  a.U_ID =@userID  ");
            strSql.Append("  union all     ");
            strSql.Append("   select       c.E_ID,      c.E_Name,     c.E_StartTime,     c.E_EndTime      from   UserInfo  as  a  inner join  OSCEExaminationArrangement as b on a.U_ID = b.U_ID  inner join  ExamTable as c on b.E_ID=c.E_ID      ");
            strSql.Append("   where    c.E_StartTime   between  '2015-05-26'  and    DATEADD(DAY,7,GETDATE())  and  a.U_ID =@userID  ");
            strSql.Append("   union all    ");
            strSql.Append("  select         c.E_ID,    c.E_Name,    c.E_StartTime,     c.E_EndTime   from     UserInfo  as  a  inner join  SingleStationExamArrangement as b on a.U_ID = b.U_ID  inner join  ExamTable as c on b.E_ID=c.E_ID       ");
            strSql.Append(" where     c.E_StartTime  between    '2015-05-26'   and   DATEADD(DAY,7,GETDATE())     and  a.U_ID =@userID  )  stationtable   ");
            strSql.Append(" order by  E_StartTime asc  ");

            SqlParameter[] parameters ={
                                        new SqlParameter("@userID",SqlDbType.Int,4)
                                       };
            parameters[0].Value = userID;
            return DbHelperSQL.Query(strSql.ToString(), parameters);

        }
        #endregion


        #region 获取考站的所有的信息
        public DataSet getStuStationAllInfos(int userID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from(");
            strSql.Append("  select    c.E_Name ,d.Room_Name,b.Exam_StartTime  as  starttime ,b.Exam_EndTime  as endtime      from   UserInfo  as  a   inner join  MultiStationExamArrangement as b   on a.U_ID = b.U_ID   inner join  ExamTable as c   on  ");
            strSql.Append(" b.E_ID=c.E_ID  inner join  Room as d   on  b.Room_ID =d.Room_ID    where   c.E_StartTime       between '2015-05-26' and DATEADD(DAY,7,GETDATE())   and  a.U_ID =@userID   ");
            strSql.Append("  union all  ");
            strSql.Append("   select   c.E_Name,   d.Room_Name,  b.OEA_StartTime  as  starttime ,b.OEA_EndTime as endtime     from   UserInfo  as  a  inner join  OSCEExaminationArrangement as b on a.U_ID = b.U_ID  inner join  ExamTable as c on  ");
            strSql.Append(" b.E_ID=c.E_ID   inner join Room as  d on  b.Room_ID=d.Room_ID   where    c.E_StartTime   between  '2015-05-26'  and    DATEADD(DAY,7,GETDATE())  and  a.U_ID =@userID ");
            strSql.Append(" union all ");
            strSql.Append("  select         c.E_Name,   d.Room_Name, b.SE_StartTime  as  starttime,b.SE_EndTime as endtime    from     UserInfo  as  a  inner join  SingleStationExamArrangement as b on a.U_ID = b.U_ID  inner join  ExamTable as c on  ");
            strSql.Append(" b.E_ID=c.E_ID   inner join Room as  d  on      b.Room_ID = d.Room_ID   where     c.E_StartTime  between    '2015-05-26'   and   DATEADD(DAY,7,GETDATE())     and  a.U_ID =@userID ) staiton  order by  starttime ");
            SqlParameter[] parameters ={
                                        new SqlParameter("@userID",SqlDbType.Int,4)
                                       };
            parameters[0].Value = userID;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        #endregion
    }
}

