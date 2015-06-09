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
    /// 数据访问类:ExamUser
    /// </summary>
    public partial class ExamUser: BaseDAL<Model.ExamUser>
    {
        public ExamUser()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EU_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamUser");
            strSql.Append(" where EU_ID=@EU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EU_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamUser(");
            strSql.Append("EU_ID,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,E_ID,U_ID,ESR_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@EU_ID,@EU_ISSP,@EU_ISZadokTheExaminer,@EU_ISReserve,@E_ID,@U_ID,@ESR_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.UniqueIdentifier,32),
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
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.EU_ISSP;
            parameters[1].Value = model.EU_ISZadokTheExaminer;
            parameters[2].Value = model.EU_ISReserve;
            parameters[3].Value = model.E_ID;
            parameters[4].Value = model.U_ID;
            parameters[5].Value = model.ESR_ID;
            parameters[6].Value = model.int1;
            parameters[7].Value = model.int2;
            parameters[8].Value = model.int3;
            parameters[9].Value = model.string1;
            parameters[10].Value = model.string2;
            parameters[11].Value = model.string3;
            parameters[12].Value = model.date1;
            parameters[13].Value = model.date2;
            parameters[14].Value = model.date3;
            parameters[15].Value = model.float1;
            parameters[16].Value = model.float2;
            parameters[17].Value = model.float3;

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
        public bool Update(Tellyes.Model.ExamUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamUser set ");
            strSql.Append("EU_ISSP=@EU_ISSP,");
            strSql.Append("EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer,");
            strSql.Append("EU_ISReserve=@EU_ISReserve,");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("ESR_ID=@ESR_ID,");
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
            strSql.Append(" where EU_ID=@EU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
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
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.EU_ISSP;
            parameters[1].Value = model.EU_ISZadokTheExaminer;
            parameters[2].Value = model.EU_ISReserve;
            parameters[3].Value = model.E_ID;
            parameters[4].Value = model.U_ID;
            parameters[5].Value = model.ESR_ID;
            parameters[6].Value = model.int1;
            parameters[7].Value = model.int2;
            parameters[8].Value = model.int3;
            parameters[9].Value = model.string1;
            parameters[10].Value = model.string2;
            parameters[11].Value = model.string3;
            parameters[12].Value = model.date1;
            parameters[13].Value = model.date2;
            parameters[14].Value = model.date3;
            parameters[15].Value = model.float1;
            parameters[16].Value = model.float2;
            parameters[17].Value = model.float3;
            parameters[18].Value = model.EU_ID;

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
        public bool Delete(int EU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamUser ");
            strSql.Append(" where EU_ID=@EU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EU_ID;

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
        public bool DeleteList(string EU_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamUser ");
            strSql.Append(" where EU_ID in (" + EU_IDlist + ")  ");
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
        public Tellyes.Model.ExamUser GetModel(Guid EU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 EU_ID,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,E_ID,U_ID,ESR_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ExamUser ");
            strSql.Append(" where EU_ID=@EU_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = EU_ID;

            Tellyes.Model.ExamUser model = new Tellyes.Model.ExamUser();
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
        public Tellyes.Model.ExamUser DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamUser model = new Tellyes.Model.ExamUser();
            if (row != null)
            {
                if (row["EU_ID"] != null && row["EU_ID"].ToString() != "")
                {
                    model.EU_ID = new Guid(row["EU_ID"].ToString());
                }
                if (row["EU_ISSP"] != null && row["EU_ISSP"].ToString() != "")
                {
                    model.EU_ISSP = int.Parse(row["EU_ISSP"].ToString());
                }
                if (row["EU_ISZadokTheExaminer"] != null && row["EU_ISZadokTheExaminer"].ToString() != "")
                {
                    model.EU_ISZadokTheExaminer = int.Parse(row["EU_ISZadokTheExaminer"].ToString());
                }
                if (row["EU_ISReserve"] != null && row["EU_ISReserve"].ToString() != "")
                {
                    model.EU_ISReserve = int.Parse(row["EU_ISReserve"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = int.Parse(row["int1"].ToString());
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
                    model.string1 = Guid.Parse(row["string1"].ToString());
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
            strSql.Append("select EU_ID,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,E_ID,U_ID,ESR_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamUser ");
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
            strSql.Append(" EU_ID,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,E_ID,U_ID,ESR_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamUser ");
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
            strSql.Append("select count(1) FROM ExamUser ");
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
                strSql.Append("order by T.EU_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamUser T ");
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
            parameters[0].Value = "ExamUser";
            parameters[1].Value = "EU_ID";
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
        /// 根据考试ID，获得督考官ID
        /// </summary>
        /// <param name="eid"></param>
        /// <returns></returns>
        public string getZadok(Guid eid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select U_ID from ExamUser where EU_ISZadokTheExaminer=1 and E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = eid;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj==null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        //public List<Model.ExamUser> getEuInfo()
        //{
 
        //}
      
        public static DataTable GetErrorApplyExamUserData(string eid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct a.* from ");
            sql.Append(" (select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=0 and ExamUser.int2 in (2,3)) as a  ");
            sql.Append(" join (select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=1) as b ");
            sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime)  ");
            sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime)  ");
            sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime)  ");
            sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime))  ");
            sql.Append(" and a.U_ID=b.U_ID where a.E_ID ='" + eid + "' ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        public static DataTable GetPreparingUserInfo(string eid) 
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select UserInfo.*,'1' as canBeSeen from UserInfo join UserRole on UserInfo.U_ID=UserRole.U_ID and UserRole.R_ID in (4,5)  where UserInfo.U_ID not in ( ");
            sql.Append(" select U_ID from ExamUser where E_ID in (select b.E_ID from ");
            sql.Append(" (select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=0 and ExamUser.int2 in (2,3)) as a  ");
            sql.Append(" join (select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=1) as b ");
            sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) or (a.E_EndTime between b.E_StartTime and b.E_EndTime) or (b.E_StartTime between a.E_StartTime and a.E_EndTime) or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
            sql.Append(" and a.U_ID=b.U_ID where a.E_ID ='" + eid + "') or E_ID ='" + eid + "');");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        #endregion  ExtensionMethod


        #region  扩展方法（评委查询）
            /// <summary>
        /// 得到一个对象实体 评委查询     陶东利2014/6/18增加
           /// </summary>
        public Tellyes.Model.CompositedModelJudgeQuery DataRowToModelJudgeQuery(DataRow row)
        {
            Tellyes.Model.CompositedModelJudgeQuery model = new Tellyes.Model.CompositedModelJudgeQuery();
            if (row != null)
            {
                //ExamUser 实体
                if (row["EU_ID"] != null && row["EU_ID"].ToString() != "")
                {
                    model.examUser.EU_ID = new Guid(row["EU_ID"].ToString());
                }
                if (row["EU_ISSP"] != null && row["EU_ISSP"].ToString() != "")
                {
                    model.examUser.EU_ISSP = int.Parse(row["EU_ISSP"].ToString());
                }
                if (row["EU_ISZadokTheExaminer"] != null && row["EU_ISZadokTheExaminer"].ToString() != "")
                {
                    model.examUser.EU_ISZadokTheExaminer = int.Parse(row["EU_ISZadokTheExaminer"].ToString());
                }
                if (row["EU_ISReserve"] != null && row["EU_ISReserve"].ToString() != "")
                {
                    model.examUser.EU_ISReserve = int.Parse(row["EU_ISReserve"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.examUser.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.examUser.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.examUser.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["ExamUserint1"] != null && row["ExamUserint1"].ToString() != "")
                {
                    model.examUser.int1 = int.Parse(row["ExamUserint1"].ToString());
                }
                if (row["ExamUserint2"] != null && row["ExamUserint2"].ToString() != "")
                {
                    model.examUser.int2 = int.Parse(row["ExamUserint2"].ToString());
                }
                if (row["ExamUserint3"] != null && row["ExamUserint3"].ToString() != "")
                {
                    model.examUser.int3 = int.Parse(row["ExamUserint3"].ToString());
                }
                if (row["ExamUserstring1"] != null)
                {
                    model.examUser.string1 = Guid.Parse(row["ExamUserstring1"].ToString());
                }
                if (row["ExamUserstring2"] != null)
                {
                    model.examUser.string2 = row["ExamUserstring2"].ToString();
                }
                if (row["ExamUserstring3"] != null)
                {
                    model.examUser.string3 = row["ExamUserstring3"].ToString();
                }
                if (row["ExamUserdate1"] != null && row["ExamUserdate1"].ToString() != "")
                {
                    model.examUser.date1 = DateTime.Parse(row["ExamUserdate1"].ToString());
                }
                if (row["ExamUserdate2"] != null && row["ExamUserdate2"].ToString() != "")
                {
                    model.examUser.date2 = DateTime.Parse(row["ExamUserdate2"].ToString());
                }
                if (row["ExamUserdate3"] != null && row["ExamUserdate3"].ToString() != "")
                {
                    model.examUser.date3 = DateTime.Parse(row["ExamUserdate3"].ToString());
                }
                if (row["ExamUserfloat1"] != null && row["ExamUserfloat1"].ToString() != "")
                {
                    model.examUser.float1 = decimal.Parse(row["ExamUserfloat1"].ToString());
                }
                if (row["ExamUserfloat2"] != null && row["ExamUserfloat2"].ToString() != "")
                {
                    model.examUser.float2 = decimal.Parse(row["ExamUserfloat2"].ToString());
                }
                if (row["ExamUserfloat3"] != null && row["ExamUserfloat3"].ToString() != "")
                {
                    model.examUser.float3 = decimal.Parse(row["ExamUserfloat3"].ToString());
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
                if (row["ExamTableint1"] != null && row["ExamTableint1"].ToString() != "")
                {
                    model.examTable.int1 = int.Parse(row["ExamTableint1"].ToString());
                }
                if (row["ExamTableint2"] != null && row["ExamTableint2"].ToString() != "")
                {
                    model.examTable.int2 = int.Parse(row["ExamTableint2"].ToString());
                }
                if (row["ExamTableint3"] != null && row["ExamTableint3"].ToString() != "")
                {
                    model.examTable.int3 = int.Parse(row["ExamTableint3"].ToString());
                }
                if (row["ExamTablestring1"] != null)
                {
                    model.examTable.string1 = row["ExamTablestring1"].ToString();
                }
                if (row["ExamTablestring2"] != null)
                {
                    model.examTable.string2 = row["ExamTablestring2"].ToString();
                }
                if (row["ExamTablestring3"] != null)
                {
                    model.examTable.string3 = row["ExamTablestring3"].ToString();
                }
                if (row["ExamTabledate1"] != null && row["ExamTabledate1"].ToString() != "")
                {
                    model.examTable.date1 = DateTime.Parse(row["ExamTabledate1"].ToString());
                }
                if (row["ExamTabledate2"] != null && row["ExamTabledate2"].ToString() != "")
                {
                    model.examTable.date2 = DateTime.Parse(row["date2"].ToString());
                }
                if (row["ExamTabledate3"] != null && row["ExamTabledate3"].ToString() != "")
                {
                    model.examTable.date3 = DateTime.Parse(row["ExamTabledate3"].ToString());
                }
                if (row["ExamTablefloat1"] != null && row["ExamTablefloat1"].ToString() != "")
                {
                    model.examTable.float1 = decimal.Parse(row["ExamTablefloat1"].ToString());
                }
                if (row["ExamTablefloat2"] != null && row["ExamTablefloat2"].ToString() != "")
                {
                    model.examTable.float2 = decimal.Parse(row["ExamTablefloat2"].ToString());
                }
                if (row["ExamTablefloat3"] != null && row["ExamTablefloat3"].ToString() != "")
                {
                    model.examTable.float3 = decimal.Parse(row["ExamTablefloat3"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得某个评委所参与的所有考试列表，按照考试开始时间降序排列
        /// </summary>
        public DataSet GetListJudgeQuery(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ExamUser.E_ID,ExamUser.EU_ID,ExamUser.EU_ISSP,ExamUser.EU_ISZadokTheExaminer,ExamUser.EU_ISReserve,ExamUser.U_ID,ExamUser.ESR_ID,ExamUser.int1 as ExamUserint1  ,ExamUser.int2 as ExamUserint2,ExamUser.int3 as ExamUserint3,ExamUser.string1 as ExamUserstring1,ExamUser.string2 as ExamUserstring2,ExamUser.string3 as ExamUserstring3,ExamUser.date1 as ExamUserdate1,ExamUser.date2 as ExamUserdate2,ExamUser.date3 as ExamUserdate3,ExamUser.float1 as ExamUserfloat1,ExamUser.float2 as ExamUserfloat2,ExamUser.float3 as ExamUserfloat3,");
            strSql.Append("ExamTable.E_Name,ExamTable.E_StartTime,ExamTable.E_EndTime,ExamTable.E_CreateUser,ExamTable.E_CreateTime,ExamTable.E_ModifyTime,ExamTable.E_Kind,ExamTable.E_OID,ExamTable.E_GID,ExamTable.E_NoStuID,ExamTable.E_LongStationExamTimeNum,ExamTable.E_LongStationScoreTimeNum,ExamTable.E_ShortStationExamTimeNum,ExamTable.E_ShortStationScoreTimeNum,ExamTable.E_State,ExamTable.E_ZadokTheExaminer,ExamTable.E_IsOpenScore,ExamTable.E_IsOpenVideo,ExamTable.int1 as ExamTableint1 ,ExamTable.int2 as ExamTableint2,ExamTable.int3 as ExamTableint3,ExamTable.string1 as ExamTablestring1,ExamTable.string2 as ExamTablestring2,ExamTable.string3 as ExamTablestring3,ExamTable.date1 as ExamTabledate1,ExamTable.date2 as ExamTabledate2,ExamTable.date3 as ExamTabledate3,ExamTable.float1 as ExamTablefloat1,ExamTable.float2 as ExamTablefloat2,ExamTable.float3 as ExamTablefloat3");
            strSql.Append(" FROM [OSCE].[dbo].[ExamUser],");
            strSql.Append(" [OSCE].[dbo].[ExamTable]");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where ExamUser.E_ID=ExamTable.E_ID and ExamUser.int2 in (1,2,3) and ExamUser.U_ID= " + strWhere);
            }
            strSql.Append("order by ExamTable.E_StartTime Desc");
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion 

        #region ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<object[]> SelectExamUserAndUserInfoByExamTableID(Guid examTableID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamUser].*, ")
                .Append(" [UserInfo].[U_TrueName], ")
                .Append(" [UserInfo].[U_Title], ")
                .Append(" [UserInfo].[U_GoodField] ")
                .Append("FROM ")
                .Append("   [ExamUser] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamUser].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[E_ID] = :E_ID and (EU_ISReserve='1' or EU_ISZadokTheExaminer = '1' )  ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.ExamUser))
                    .AddScalar("U_TrueName", NHibernateUtil.String)
                    .AddScalar("U_Title", NHibernateUtil.String)
                    .AddScalar("U_GoodField", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", examTableID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败，examTableID：" + examTableID, e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        public List<object[]> SelectExamUserAndUserInfoByExamTableIDAndExamStationID(Guid examTableID,Guid examStationID) {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamUser].*, ")
                .Append("   [UserInfo].[U_TrueName], ") 
                .Append("   [UserInfo].[U_Title], ")
                .Append("   [UserInfo].[U_GoodField] ")
                .Append("FROM ")
                .Append("   [ExamUser] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamUser].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[E_ID] = :E_ID ")
                .Append(" and  [ExamUser].[string1] = :ES_ID ")
                .Append(" and  [ExamUser].[EU_ISReserve] <> '1' ")
                .Append(" order by U_TrueName; ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.ExamUser))
                    .AddScalar("U_TrueName", NHibernateUtil.String)
                    .AddScalar("U_Title", NHibernateUtil.String)
                    .AddScalar("U_GoodField", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", examTableID);
                iSQLQuery.SetGuid("ES_ID", examStationID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败，examTableID：" + examTableID, e);
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
        /// <param name="U_ID"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public List<object[]> SelectExamUserInHandScoreByUserInfoIDAndDatetime(int U_ID, DateTime datetime)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [ExamUser].[EU_ID], ")
                .Append("   [ExamUser].[E_ID], ")
                .Append("   [ExamUser].[ESR_ID], ")
                .Append("   [ExamUserMarkSheetCount].[MarkSheetCount], ")
                .Append("   [ExamUser].[int2] AS [ExamUserType] ")
                .Append("FROM ")
                .Append("   [ExamUser] ")
                .Append("   INNER JOIN [ExamTable] ")
                .Append("       ON [ExamUser].[E_ID] = [ExamTable].[E_ID] AND [ExamTable].[E_State] = 2 AND [ExamTable].[int1] = 1 ")
                .Append("   INNER JOIN ( ")
                .Append("       SELECT ")
                .Append("           [EU_ID], ")
                .Append("           COUNT(DISTINCT [MS_ID]) AS [MarkSheetCount] ")
                .Append("       FROM ")
                .Append("           [ExamUserMarkSheet] ")
                .Append("       GROUP BY ")
                .Append("           [EU_ID] ")
                .Append("   ) AS [ExamUserMarkSheetCount] ")
                .Append("       ON [ExamUser].[EU_ID] = [ExamUserMarkSheetCount].[EU_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND ( ")
                .Append("       [ExamUser].[E_ID] =ANY ( ")
                .Append("           SELECT ")
                .Append("               DISTINCT [E_ID] ")
                .Append("           FROM ")
                .Append("               [MultiStationExamArrangement] ")
                .Append("           WHERE ")
                .Append("               [Exam_StartTime] <= :datetime1 ")
                .Append("               AND [Exam_EndTime] >= :datetime2 ")
                .Append("       ) ")
                .Append("       OR [ExamUser].[E_ID] =ANY ( ")
                .Append("           SELECT ")
                .Append("               DISTINCT [E_ID] ")
                .Append("           FROM ")
                .Append("               [SingleStationExamArrangement] ")
                .Append("           WHERE ")
                .Append("               [SE_StartTime] <= :datetime1 ")
                .Append("               AND [SE_EndTime] >= :datetime2 ")
                .Append("       ) ")
                .Append("       OR [ExamUser].[E_ID] =ANY ( ")
                .Append("           SELECT ")
                .Append("               DISTINCT [E_ID] ")
                .Append("           FROM ")
                .Append("               [OSCEExaminationArrangement] ")
                .Append("           WHERE ")
                .Append("               [OEA_StartTime] <= :datetime1 ")
                .Append("               AND [OEA_EndTime] >= :datetime2 ")
                .Append("       ) ")
                .Append("   ) ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("EU_ID", NHibernateUtil.Guid)
                    .AddScalar("E_ID", NHibernateUtil.Guid)
                    .AddScalar("ESR_ID", NHibernateUtil.Guid)
                    .AddScalar("MarkSheetCount", NHibernateUtil.Int32)
                    .AddScalar("ExamUserType", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery
                    .SetInt32("U_ID", U_ID)
                    .SetDateTime("datetime1", datetime)
                    .SetDateTime("datetime2", datetime);
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult(0)
                    .SetMaxResults(1)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，用户登录查询失败：U_ID（" + U_ID + "），Datetime（" + datetime.ToString("yyyy-MM-dd HH:mm:ss") + "）", e);
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
            if (conditionDictionary.ContainsKey("Exam_ID")) 
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["Exam_ID"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID"))
            {
                criteria.Add(Restrictions.Eq("int3", conditionDictionary["Room_ID"]));
            }
            if (conditionDictionary.ContainsKey("UserInfo_ID"))
            {
                criteria.Add(Restrictions.Eq("U_ID", conditionDictionary["UserInfo_ID"]));
            }
            return criteria;
        }

        /// <summary>
        /// 分类统计某考站人员
        /// </summary>
        /// <param name="examTableID"></param>
        /// <param name="examStationID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamUserCountGroupedByType(Guid examTableID,Guid examStationID) { 
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
            .Append(" select EU_ISSP,int2,COUNT(*) as examusercount from dbo.ExamUser ")
            .Append(" where E_ID= :E_ID  ")
            .Append(" and string1= :ES_ID  ")
            .Append(" and ((EU_ISSP=1 and int2=0) or int2 in (2,3)) group by EU_ISSP,int2; ").ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("EU_ISSP", NHibernateUtil.Int32)
                    .AddScalar("int2", NHibernateUtil.Int32)
                    .AddScalar("examusercount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery
                    .SetGuid("E_ID", examTableID)
                    .SetGuid("ES_ID", examStationID);
                //查询结果并返回
                return iSQLQuery
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "考站人员信息查询失败：E_ID（" + examTableID.ToString() + "），ES_ID（" + examStationID.ToString() + "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据 E_ID，获得评委 | SP信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<object[]> SelectExamUserInfoForApplyModel(Dictionary<string,object> condition) 
        {
            Guid E_ID = Guid.Parse(condition["E_ID"].ToString().Trim());
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
            .Append(" select ")
            .Append("   u.*, ")
            .Append("   es.ES_Name as ES_Name, ")
            .Append("   case when eu.EU_ISReserve=1 then case when eu.EU_ISSP =1 then '后备SP' else '后备评委' end else case when eu.EU_ISSP=1 then 'SP' else '评委' end end as U_Type, ")
            .Append("   r.Room_Name as Room_Name, ")
            .Append("  es.int3 ")
            .Append(" from ")
            .Append("   ExamUser as eu ")
            .Append(" inner join ExamStation as es ")
            .Append("       on eu.E_ID=es.int1 ")
            .Append("           and eu.string1=es.ES_ID ")
            .Append(" inner join UserInfo as u ")
            .Append("   on u.U_ID = eu.U_ID ")
            .Append(" inner join ExamStation_Room as esr ")
            .Append("   on eu.ESR_ID = esr.ESR_ID ")
            .Append(" inner join Room as r ")
            .Append("   on r.Room_ID = esr.Room_ID ")
            .Append(" where ")
            .Append("   E_ID = :E_ID ")
            .Append(" order by es.int3,u.U_TrueName; ").ToString().Trim();

            //NHibernate连接对象
            ISession session = null;

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Tellyes.Model.UserInfo))
                    .AddScalar("ES_Name", NHibernateUtil.String)
                    .AddScalar("U_Type", NHibernateUtil.String)
                    .AddScalar("Room_Name", NHibernateUtil.String)
                    .AddScalar("int3", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", E_ID);
                //查询结果并返回
                return iSQLQuery
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "评委 | SP信息查询失败：E_ID（" + E_ID.ToString().Trim()+ "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 评委|SP查询页面 查询评委|SP相关的考试总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamUserInfoCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   COUNT([ExamUser].[E_ID]) AS [ExamUserCount] ")
                .Append("FROM ")
                .Append("   [ExamUser] ")
                .Append("INNER JOIN ")
                .Append("   [ExamTable] ")
                .Append("ON [ExamUser].[E_ID]=[ExamTable].[E_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND [ExamTable].[int1] = 1 ")
                .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_EndTime]>=:E_EndTime ");
            }

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamUserCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["UserInfo_ID"]));
                if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Ge"].ToString()));
                }
                //查询结果并返回
                return  Convert.ToInt32(iSQLQuery.UniqueResult()); 
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询评委|SP信息数量失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 评委|SP查询页面 查询评委|SP相关的考试信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectExamUserInfoByCondition(Dictionary<string, object> conditionDictionary , int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [ExamUser].[int2] AS [RoleType],  ")
                .Append("   [ExamUser].[EU_ISSP], ")
                .Append("   [ExamUser].[EU_ISReserve], ")
                .Append("   [ExamUser].[string1] AS [ES_ID], ")
                .Append("   [ExamStation].[ES_Name],  ")
                .Append("   [Room].[Room_Name],")
                .Append("   [ExamTable].* ")
                .Append("FROM ")
                .Append("   [ExamUser] ")
                .Append("INNER JOIN ")
                .Append("   [ExamTable] ")
                .Append("ON [ExamUser].[E_ID]=[ExamTable].[E_ID] ")
                .Append("LEFT JOIN ")
                .Append("   [ExamStation] ")
                .Append("ON [ExamUser].[string1]=[ExamStation].[ES_ID] ")
                .Append("LEFT JOIN ")
                .Append("   [Room] ")
                .Append("ON [ExamUser].[int3]=[Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND [ExamTable].[int1] = 1 ")
                .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_EndTime]>=:E_EndTime ");
            }
            sqlStringBuilder.Append("ORDER BY");
            sqlStringBuilder.Append("   [ExamTable].[E_StartTime] DESC");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("RoleType", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("EU_ISSP", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("EU_ISReserve", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("ES_ID", NHibernateUtil.Guid);
                iSQLQuery.AddScalar("ES_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("Room_Name", NHibernateUtil.String);
                iSQLQuery.AddEntity(typeof(Tellyes.Model.ExamTable));
                //设置查询参数
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["UserInfo_ID"]));
                if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Ge"].ToString()));
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
                Log4NetUtility.Error(this, "根据条件查询评委|SP信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 教师查询页面 查询教师相关的考试总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectExamInfoCountWithTeacherInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   COUNT([ExamTable].[E_ID]) AS [ExamCount] ")
                .Append("FROM ")
                .Append("   [ExamTable] ")
                .Append("   INNER JOIN [ExamUser] ")
                .Append("       ON [ExamUser].[E_ID]=[ExamTable].[E_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND [ExamUser].[EU_ISZadokTheExaminer] = 1 ")
                .Append("   AND [ExamTable].[int1] = 1 ")
                .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_Name,Like"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_Name] LIKE (:E_Name) ");
            }
            if (conditionDictionary.ContainsKey("int3,In"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[int3] IN (:examClassIDList) ");
            }
            if (conditionDictionary.ContainsKey("E_Kind,In"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_Kind] IN (:examKindList) ");
            }

            if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_EndTime]>=:E_EndTime ");
            }

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("ExamCount", NHibernateUtil.Int32);
                //设置查询参数
                if (conditionDictionary.ContainsKey("E_Name,Like"))
                {
                    iSQLQuery.SetString("E_Name", "%" + conditionDictionary["E_Name,Like"].ToString() + "%"); ;
                }
                if (conditionDictionary.ContainsKey("int3,In"))
                {
                    iSQLQuery.SetParameterList("examClassIDList", (List<int>)conditionDictionary["int3,In"]);
                }
                if (conditionDictionary.ContainsKey("E_Kind,In"))
                {
                    iSQLQuery.SetParameterList("examKindList", (List<int>)conditionDictionary["E_Kind,In"]);
                }
                if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Ge"].ToString()));
                }
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID"]));
              
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件查询教师相关的考试总数失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 教师查询页面 查询教师相关的考试信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Tellyes.Model.ExamTable> SelectExamInfoWithTeacherInfoByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty);
            sqlStringBuilder
                .Append("SELECT  ")
                .Append("   [ExamTable].* ")
                .Append("FROM ")
                .Append("   [ExamTable] ")
                .Append("INNER JOIN ")
                .Append("   [ExamUser] ")
                .Append("ON [ExamUser].[E_ID]=[ExamTable].[E_ID] ")
                .Append("WHERE ")
                .Append("   [ExamUser].[U_ID] = :U_ID ")
                .Append("   AND [ExamUser].[EU_ISZadokTheExaminer] = 1 ")
                .Append("   AND [ExamTable].[int1] = 1 ")
                .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_Name,Like"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_Name] LIKE (:E_Name) ");
            }
            if (conditionDictionary.ContainsKey("int3,In"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[int3] IN (:examClassIDList) ");
            }
            if (conditionDictionary.ContainsKey("E_Kind,In"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_Kind] IN (:examKindList) ");
            }

            if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
            {
                sqlStringBuilder.Append("AND [ExamTable].[E_EndTime]>=:E_EndTime ");
            }
            sqlStringBuilder.Append("ORDER BY");
            sqlStringBuilder.Append("   [ExamTable].[E_StartTime] DESC");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Tellyes.Model.ExamTable));
                //设置查询参数
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID"]));
                if (conditionDictionary.ContainsKey("E_Name,Like"))
                {
                    iSQLQuery.SetString("E_Name", "%" + conditionDictionary["E_Name,Like"].ToString() + "%"); ;
                }
                if (conditionDictionary.ContainsKey("int3,In"))
                {
                    iSQLQuery.SetParameterList("examClassIDList", (List<int>)conditionDictionary["int3,In"]);
                }
                if (conditionDictionary.ContainsKey("E_Kind,In"))
                {
                    iSQLQuery.SetParameterList("examKindList", (List<int>)conditionDictionary["E_Kind,In"]);
                }
                if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Ge"].ToString()));
                }
              
                //查询结果并返回
                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<Tellyes.Model.ExamTable>()
                   .ToList<Tellyes.Model.ExamTable>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "根据条件询教师相关的考试信息失败", e);
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
