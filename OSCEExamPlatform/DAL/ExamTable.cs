using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using System.Collections;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamTable
    /// </summary>
    public partial class ExamTable: BaseDAL<Model.ExamTable>
    {
        public ExamTable()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int E_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamTable");
            strSql.Append(" where E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = E_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamTable(");
            strSql.Append("E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@E_ID,@E_Name,@E_StartTime,@E_EndTime,@E_CreateUser,@E_CreateTime,@E_ModifyTime,@E_Kind,@E_OID,@E_GID,@E_NoStuID,@E_LongStationExamTimeNum,@E_LongStationScoreTimeNum,@E_ShortStationExamTimeNum,@E_ShortStationScoreTimeNum,@E_State,@E_ZadokTheExaminer,@E_IsOpenScore,@E_IsOpenVideo,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
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
                                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.E_Name;
            parameters[1].Value = model.E_StartTime;
            parameters[2].Value = model.E_EndTime;
            parameters[3].Value = model.E_CreateUser;
            parameters[4].Value = model.E_CreateTime;
            parameters[5].Value = model.E_ModifyTime;
            parameters[6].Value = model.E_Kind;
            parameters[7].Value = model.E_OID;
            parameters[8].Value = model.E_GID;
            parameters[9].Value = model.E_NoStuID;
            parameters[10].Value = model.E_LongStationExamTimeNum;
            parameters[11].Value = model.E_LongStationScoreTimeNum;
            parameters[12].Value = model.E_ShortStationExamTimeNum;
            parameters[13].Value = model.E_ShortStationScoreTimeNum;
            parameters[14].Value = model.E_State;
            parameters[15].Value = model.E_ZadokTheExaminer;
            parameters[16].Value = model.E_IsOpenScore;
            parameters[17].Value = model.E_IsOpenVideo;
            parameters[18].Value = model.int1;
            parameters[19].Value = model.int2;
            parameters[20].Value = model.int3;
            parameters[21].Value = model.string1;
            parameters[22].Value = model.string2;
            parameters[23].Value = model.string3;
            parameters[24].Value = model.date1;
            parameters[25].Value = model.date2;
            parameters[26].Value = model.date3;
            parameters[27].Value = model.float1;
            parameters[28].Value = model.float2;
            parameters[29].Value = model.float3;
            parameters[30].Value = model.E_ID;

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
        public bool Update(Tellyes.Model.ExamTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamTable set ");
            strSql.Append("E_Name=@E_Name,");
            strSql.Append("E_StartTime=@E_StartTime,");
            strSql.Append("E_EndTime=@E_EndTime,");
            strSql.Append("E_CreateUser=@E_CreateUser,");
            strSql.Append("E_CreateTime=@E_CreateTime,");
            strSql.Append("E_ModifyTime=@E_ModifyTime,");
            strSql.Append("E_Kind=@E_Kind,");
            strSql.Append("E_OID=@E_OID,");
            strSql.Append("E_GID=@E_GID,");
            strSql.Append("E_NoStuID=@E_NoStuID,");
            strSql.Append("E_LongStationExamTimeNum=@E_LongStationExamTimeNum,");
            strSql.Append("E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum,");
            strSql.Append("E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum,");
            strSql.Append("E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum,");
            strSql.Append("E_State=@E_State,");
            strSql.Append("E_ZadokTheExaminer=@E_ZadokTheExaminer,");
            strSql.Append("E_IsOpenScore=@E_IsOpenScore,");
            strSql.Append("E_IsOpenVideo=@E_IsOpenVideo,");
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
            strSql.Append(" where E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
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
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.E_Name;
            parameters[1].Value = model.E_StartTime;
            parameters[2].Value = model.E_EndTime;
            parameters[3].Value = model.E_CreateUser;
            parameters[4].Value = model.E_CreateTime;
            parameters[5].Value = model.E_ModifyTime;
            parameters[6].Value = model.E_Kind;
            parameters[7].Value = model.E_OID;
            parameters[8].Value = model.E_GID;
            parameters[9].Value = model.E_NoStuID;
            parameters[10].Value = model.E_LongStationExamTimeNum;
            parameters[11].Value = model.E_LongStationScoreTimeNum;
            parameters[12].Value = model.E_ShortStationExamTimeNum;
            parameters[13].Value = model.E_ShortStationScoreTimeNum;
            parameters[14].Value = model.E_State;
            parameters[15].Value = model.E_ZadokTheExaminer;
            parameters[16].Value = model.E_IsOpenScore;
            parameters[17].Value = model.E_IsOpenVideo;
            parameters[18].Value = model.int1;
            parameters[19].Value = model.int2;
            parameters[20].Value = model.int3;
            parameters[21].Value = model.string1;
            parameters[22].Value = model.string2;
            parameters[23].Value = model.string3;
            parameters[24].Value = model.date1;
            parameters[25].Value = model.date2;
            parameters[26].Value = model.date3;
            parameters[27].Value = model.float1;
            parameters[28].Value = model.float2;
            parameters[29].Value = model.float3;
            parameters[30].Value = model.E_ID;

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
        public bool Delete(int E_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamTable ");
            strSql.Append(" where E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = E_ID;

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
        public bool DeleteList(string E_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamTable ");
            strSql.Append(" where E_ID in (" + E_IDlist + ")  ");
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
        public Tellyes.Model.ExamTable GetModel(Guid E_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ExamTable ");
            strSql.Append(" where E_ID=@E_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)
			};
            parameters[0].Value = E_ID;

            Tellyes.Model.ExamTable model = new Tellyes.Model.ExamTable();
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
        public Tellyes.Model.ExamTable DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamTable model = new Tellyes.Model.ExamTable();
            if (row != null)
            {
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["E_Name"] != null)
                {
                    model.E_Name = row["E_Name"].ToString();
                }
                if (row["E_StartTime"] != null && row["E_StartTime"].ToString() != "")
                {
                    model.E_StartTime = DateTime.Parse(row["E_StartTime"].ToString());
                }
                if (row["E_EndTime"] != null && row["E_EndTime"].ToString() != "")
                {
                    model.E_EndTime = DateTime.Parse(row["E_EndTime"].ToString());
                }
                if (row["E_CreateUser"] != null)
                {
                    model.E_CreateUser = row["E_CreateUser"].ToString();
                }
                if (row["E_CreateTime"] != null && row["E_CreateTime"].ToString() != "")
                {
                    model.E_CreateTime = DateTime.Parse(row["E_CreateTime"].ToString());
                }
                if (row["E_ModifyTime"] != null && row["E_ModifyTime"].ToString() != "")
                {
                    model.E_ModifyTime = DateTime.Parse(row["E_ModifyTime"].ToString());
                }
                if (row["E_Kind"] != null && row["E_Kind"].ToString() != "")
                {
                    model.E_Kind = int.Parse(row["E_Kind"].ToString());
                }
                if (row["E_OID"] != null)
                {
                    model.E_OID = row["E_OID"].ToString();
                }
                if (row["E_GID"] != null)
                {
                    model.E_GID = row["E_GID"].ToString();
                }
                if (row["E_NoStuID"] != null)
                {
                    model.E_NoStuID = row["E_NoStuID"].ToString();
                }
                if (row["E_LongStationExamTimeNum"] != null && row["E_LongStationExamTimeNum"].ToString() != "")
                {
                    model.E_LongStationExamTimeNum = int.Parse(row["E_LongStationExamTimeNum"].ToString());
                }
                if (row["E_LongStationScoreTimeNum"] != null && row["E_LongStationScoreTimeNum"].ToString() != "")
                {
                    model.E_LongStationScoreTimeNum = int.Parse(row["E_LongStationScoreTimeNum"].ToString());
                }
                if (row["E_ShortStationExamTimeNum"] != null && row["E_ShortStationExamTimeNum"].ToString() != "")
                {
                    model.E_ShortStationExamTimeNum = int.Parse(row["E_ShortStationExamTimeNum"].ToString());
                }
                if (row["E_ShortStationScoreTimeNum"] != null && row["E_ShortStationScoreTimeNum"].ToString() != "")
                {
                    model.E_ShortStationScoreTimeNum = int.Parse(row["E_ShortStationScoreTimeNum"].ToString());
                }
                if (row["E_State"] != null && row["E_State"].ToString() != "")
                {
                    model.E_State = int.Parse(row["E_State"].ToString());
                }
                if (row["E_ZadokTheExaminer"] != null)
                {
                    model.E_ZadokTheExaminer = row["E_ZadokTheExaminer"].ToString();
                }
                if (row["E_IsOpenScore"] != null && row["E_IsOpenScore"].ToString() != "")
                {
                    model.E_IsOpenScore = int.Parse(row["E_IsOpenScore"].ToString());
                }
                if (row["E_IsOpenVideo"] != null && row["E_IsOpenVideo"].ToString() != "")
                {
                    model.E_IsOpenVideo = int.Parse(row["E_IsOpenVideo"].ToString());
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
            strSql.Append("select E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamTable ");
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
            strSql.Append(" E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM ExamTable ");
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
            strSql.Append("select count(1) FROM ExamTable ");
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
                strSql.Append("order by T.E_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamTable T ");
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
            parameters[0].Value = "ExamTable";
            parameters[1].Value = "E_ID";
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
        /// 是否存在考试编号
        /// </summary>
        public bool ExistsExamNo(string E_No,string oldNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamTable");
            strSql.Append(" where string1=@E_ID");
            if (!string.IsNullOrEmpty(oldNo))
            {
                strSql.Append(" and string1 <> @oldName");
            }
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.NVarChar,500),
					new SqlParameter("@oldName", SqlDbType.NVarChar,500)
			};
            parameters[0].Value = E_No;
            parameters[1].Value = oldNo;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在考试名称
        /// </summary>
        public bool ExistsExamName(string E_Name,string oldName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamTable");
            strSql.Append(" where E_Name=@E_Name");
            if (!string.IsNullOrEmpty(oldName))
            {
                strSql.Append(" and E_Name <> @oldName");
            }
            SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,500),
					new SqlParameter("@oldName", SqlDbType.NVarChar,500)
			};
            parameters[0].Value = E_Name;
            parameters[1].Value = oldName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 添加一次排考信息
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public bool InsertByTran(Hashtable ht)
        {
            List<CommandInfo> cmdList = new List<CommandInfo>();
            Model.ExamTable eModel = ht["eModel"] as Model.ExamTable;
            cmdList.Add(getAdd(eModel));
            List<Tellyes.Model.ExamTimeInfo> etiList = ht["etiList"] as List<Tellyes.Model.ExamTimeInfo>;
            for (int i = 0; i < etiList.Count; i++)
            {
                Tellyes.Model.ExamTimeInfo eti = etiList[i];
                eti.E_ID = eModel.E_ID;
                cmdList.Add(getAddEti(eti)); 
            }
            List<Model.ExamStation> esList = ht["esList"] as List<Model.ExamStation>;
            for (int i = 0; i < esList.Count; i++)
            {
                cmdList.Add(getAddES(esList[i]));
            }
            Hashtable esrHt = ht["esrHt"] as Hashtable;
            Hashtable euListHt = ht["euListHt"] as Hashtable;
            for (int i = 0; i < esrHt.Count; i++)
            {
                List<Model.ExamStation_Room> esrList = esrHt[i.ToString()] as List<Model.ExamStation_Room>;
                Hashtable euHT = euListHt[i.ToString()] as Hashtable;

                for (int j = 0; j < esrList.Count; j++)
                {
                    cmdList.Add(getAddEsr(esrList[j]));
                     List<Tellyes.Model.ExamUser> euList = euHT[j.ToString()] as List<Tellyes.Model.ExamUser>;
                     for (int k = 0; k < euList.Count; k++)
                     {
                         cmdList.Add(getAddEu(euList[k]));
                     }
                }
                
            }
            //Hashtable euListHt = ht["euListHt"] as Hashtable;
            List<Model.ExamUserMarkSheet> euMarkList = ht["euMarkList"] as List<Model.ExamUserMarkSheet>;
            for (int i = 0; i < euMarkList.Count; i++)
            {
                cmdList.Add(getAddEums(euMarkList[i]));
            }
            List<Model.ExamStudent> eStuList = ht["eStuList"] as List<Model.ExamStudent>;
            for (int i = 0; i < eStuList.Count; i++)
            {
                cmdList.Add(getAddEStu(eStuList[i]));
                
            }
            List<Model.OSCEExaminationArrangement> oeaList = ht["oeaList"] as List<Model.OSCEExaminationArrangement>;
            for (int i = 0; i < oeaList.Count; i++)
            {
                cmdList.Add(getAddOEA(oeaList[i]));
            }
            try
            {
                return DbHelperSQL.ExecuteSqlTran(cmdList) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 添加排考信息表
        /// </summary>
        /// <param name="oSCEExaminationArrangement"></param>
        /// <returns></returns>
        private CommandInfo getAddOEA(Model.OSCEExaminationArrangement model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OSCEExaminationArrangement(");
            strSql.Append("EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@EStu_ID,@ESR_ID,@OEA_StartTime,@OEA_EndTime,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
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
					new SqlParameter("@float3", SqlDbType.Decimal,9)};
            parameters[0].Value = model.EStu_ID;
            parameters[1].Value = model.ESR_ID;
            parameters[2].Value = model.OEA_StartTime;
            parameters[3].Value = model.OEA_EndTime;
            parameters[4].Value = model.int1;
            parameters[5].Value = model.int2;
            parameters[6].Value = model.int3;
            parameters[7].Value = model.string1;
            parameters[8].Value = model.string2;
            parameters[9].Value = model.string3;
            parameters[10].Value = model.date1;
            parameters[11].Value = model.date2;
            parameters[12].Value = model.date3;
            parameters[13].Value = model.float1;
            parameters[14].Value = model.float2;
            parameters[15].Value = model.float3;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);

        }

        /// <summary>
        /// 添加考试学生表内的信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CommandInfo getAddEStu(Model.ExamStudent model)
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        /// <summary>
        /// 添加用户与评分表对应关系
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CommandInfo getAddEums(Model.ExamUserMarkSheet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamUserMarkSheet(");
            strSql.Append("EU_ID,MS_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@EU_ID,@MS_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
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
					new SqlParameter("@float3", SqlDbType.Decimal,9)};
            parameters[0].Value = model.EU_ID;
            parameters[1].Value = model.MS_ID;
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        private CommandInfo getAddEu(Model.ExamUser model)
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows); ;
        }

        private CommandInfo getAddEsr(Model.ExamStation_Room model)
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        /// <summary>
        /// 添加有效时间段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CommandInfo getAddEti(Model.ExamTimeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamTimeInfo(");
            strSql.Append("ETI_StartTime,ETI_EndTime,E_ID)");
            strSql.Append(" values (");
            strSql.Append("@ETI_StartTime,@ETI_EndTime,@E_ID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@UseName", SqlDbType.NVarChar,5000),
					new SqlParameter("@ETI_StartTime", SqlDbType.NVarChar,50),
					new SqlParameter("@ETI_EndTime", SqlDbType.NVarChar,50),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = "ExamTimeInfo";
            parameters[1].Value = "EID";
            parameters[2].Value = model.ETI_StartTime;
            parameters[3].Value = model.ETI_EndTime;
            parameters[4].Value = model.E_ID;
            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        /// <summary>
        /// 添加考站
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CommandInfo getAddES(Model.ExamStation model)
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        /// <summary>
        /// 添加ExamTable
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CommandInfo getAdd(Model.ExamTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamTable(");
            strSql.Append("E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@E_ID,@E_Name,@E_StartTime,@E_EndTime,@E_CreateUser,@E_CreateTime,@E_ModifyTime,@E_Kind,@E_OID,@E_GID,@E_NoStuID,@E_LongStationExamTimeNum,@E_LongStationScoreTimeNum,@E_ShortStationExamTimeNum,@E_ShortStationScoreTimeNum,@E_State,@E_ZadokTheExaminer,@E_IsOpenScore,@E_IsOpenVideo,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
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
                                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.E_Name;
            parameters[1].Value = model.E_StartTime;
            parameters[2].Value = model.E_EndTime;
            parameters[3].Value = model.E_CreateUser;
            parameters[4].Value = model.E_CreateTime;
            parameters[5].Value = model.E_ModifyTime;
            parameters[6].Value = model.E_Kind;
            parameters[7].Value = model.E_OID;
            parameters[8].Value = model.E_GID;
            parameters[9].Value = model.E_NoStuID;
            parameters[10].Value = model.E_LongStationExamTimeNum;
            parameters[11].Value = model.E_LongStationScoreTimeNum;
            parameters[12].Value = model.E_ShortStationExamTimeNum;
            parameters[13].Value = model.E_ShortStationScoreTimeNum;
            parameters[14].Value = model.E_State;
            parameters[15].Value = model.E_ZadokTheExaminer;
            parameters[16].Value = model.E_IsOpenScore;
            parameters[17].Value = model.E_IsOpenVideo;
            parameters[18].Value = model.int1;
            parameters[19].Value = model.int2;
            parameters[20].Value = model.int3;
            parameters[21].Value = model.string1;
            parameters[22].Value = model.string2;
            parameters[23].Value = model.string3;
            parameters[24].Value = model.date1;
            parameters[25].Value = model.date2;
            parameters[26].Value = model.date3;
            parameters[27].Value = model.float1;
            parameters[28].Value = model.float2;
            parameters[29].Value = model.float3;
            parameters[30].Value = model.E_ID;
           

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.WhenHaveContinueAndUse);
        }

        /// <summary>
        /// 获得有申请的日期的分类统计
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByCondition(string startDate,string endDate,string others=null)
        {
            string sql = " select CONVERT(nvarchar(10),E_StartTime,102),COUNT(E_ID),coalesce(int1,0) from dbo.ExamTable where E_StartTime between '" + startDate + "' and '" + endDate + "' group by CONVERT(nvarchar(10),E_StartTime,102),int1; ";
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 直接获取，带有详细时间的考试申请
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByConditionWithNoSum(string startDate, string endDate, string others = null)
        {
            string sql = " select E_StartTime,1,coalesce(int1,0),E_ID from dbo.ExamTable where E_StartTime between '" + startDate + "' and '" + endDate + "'; ";
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 获得有申请的日期
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static DataTable GetExamTableCalenderDataByTimeCondition(string startDate, string endDate)
        {
            string sql = " select distinct CONVERT(nvarchar(10),E_StartTime,102) from dbo.ExamTable where E_StartTime between '" + startDate + "' and '" + endDate + "'; ";
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 为申请页面左边列表，获取数据
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="applyType"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyForLeftList(string startDate,string applyType=null)
        {
            StringBuilder sql = new StringBuilder( " select * from ExamTable where '" + startDate.Replace('-','.').Trim() + "' = CONVERT(nvarchar(10), E_StartTime,102)  ");
            if(applyType != null)
            {
                sql.Append(" and int1='" + applyType + "'");
            }
            sql.Append(";");
            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }

        /// <summary>
        /// 级联ExamTable与UserInfo
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static DataSet GetListByCondition(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct ExamTable.* from dbo.ExamTable join dbo.UserInfo on ExamTable.int2=UserInfo.U_ID ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得人员冲突列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetCrashedApply(string E_ID,bool isSP=false)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" with base as(select a.EU_ID,a.U_ID,(select U_TrueName from UserInfo where U_ID=a.U_ID) as trueName,a.E_Name from ");
            sql.Append(" (select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=0 and ExamUser.int2 in (2,3) ");
            sql.Append(" ) as a join(	select ExamTable.*,ExamUser.U_ID,ExamUser.EU_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=1 ");
            sql.Append(" ) as b on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) or (a.E_EndTime between b.E_StartTime and b.E_EndTime) or (b.E_StartTime between a.E_StartTime and a.E_EndTime) or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
            sql.Append(" and a.U_ID=b.U_ID where a.E_ID = '" + E_ID + "' ) ");
            sql.Append(" ,result1 as(select ExamUser.*,UserInfo.U_TrueName,1 as deleteFlag from ExamUser join UserInfo on ExamUser.U_ID=UserInfo.U_ID where EU_ID in (select EU_ID from base) ");
            sql.Append(" ),result2 as(	select ExamUser.*,UserInfo.U_TrueName,0 as deleteFlag from ExamUser join UserInfo on ExamUser.U_ID=UserInfo.U_ID where E_ID  = '" + E_ID + "' and EU_ID not in (select EU_ID from result1) ");
            sql.Append(" ),result3 as(	select * from result1 union select * from result2) select * from result3; ");
            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }

        /// <summary>
        /// 获得可选老师、SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="isSP"></param>
        /// <returns></returns>
        public static DataTable GetJuryOrSPThatCanBeChoose(string E_ID,bool isSP=false)
        {
            StringBuilder sql = new StringBuilder();
            if (!isSP)
            {
                sql.Append(" select * from UserInfo where U_ID in (select U_ID from UserRole where R_ID = 4)  ");
            }
            else
            {
                sql.Append(" select * from UserInfo where U_ID in (select U_ID from UserRole where R_ID = 5)  ");
            }
            sql.Append(" and U_ID not in ( select b.U_ID from(select ExamTable.*,ExamUser.U_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID  ");
            sql.Append(" ) as a join (	select ExamTable.*,ExamUser.U_ID from dbo.ExamTable join dbo.ExamUser on ExamTable.E_ID=ExamUser.E_ID and ExamTable.int1=1  ");
            sql.Append(" ) as b on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) or (a.E_EndTime between b.E_StartTime and b.E_EndTime) or (b.E_StartTime between a.E_StartTime and a.E_EndTime) or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
            sql.Append(" where a.E_ID = '" + E_ID + "'); ");

            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }

        #endregion  ExtensionMethod

        #region ExtensionMethod

        /// <summary>
        /// 考试成绩页面，按参加考试的学生信息查询考试ID集合
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Guid> SelectExamIDListByConditionInExamScorePage(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   DISTINCT [ExamStudent].[E_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   INNER JOIN [UserInfo] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserInfo].[U_ID] ")
                .Append("WHERE ");
            StringBuilder sqlConditionStringBuilder = new StringBuilder("");
            if (conditionDictionary.ContainsKey("U_Name,Like"))
            {
                sqlConditionStringBuilder.Append("[UserInfo].[U_Name] LIKE :U_Name");
            }
            if (conditionDictionary.ContainsKey("EStu_ExamNumber,Like"))
            {
                sqlConditionStringBuilder
                    .Append(sqlConditionStringBuilder.ToString() == "" ? "" : " AND ")
                    .Append("[ExamStudent].[EStu_ExamNumber] LIKE :EStu_ExamNumber");
            }
            if (conditionDictionary.ContainsKey("U_TrueName,Like"))
            {
                sqlConditionStringBuilder
                    .Append(sqlConditionStringBuilder.ToString() == "" ? "" : " AND ")
                    .Append("[UserInfo].[U_TrueName] LIKE :U_TrueName");
            }
            string sql = sqlStringBuilder.ToString() + sqlConditionStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_ID", NHibernateUtil.Guid);
                //设置查询参数
                if (conditionDictionary.ContainsKey("U_Name,Like"))
                {
                    iSQLQuery.SetString("U_Name", "%" + conditionDictionary["U_Name,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("EStu_ExamNumber,Like"))
                {
                    iSQLQuery.SetString("EStu_ExamNumber", "%" + conditionDictionary["EStu_ExamNumber,Like"].ToString() + "%");
                }
                if (conditionDictionary.ContainsKey("U_TrueName,Like"))
                {
                    iSQLQuery.SetString("U_TrueName", "%" + conditionDictionary["U_TrueName,Like"].ToString() + "%");
                }
                //查询结果并返回
                return iSQLQuery.List<Guid>().ToList<Guid>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "按照参加考试学生查询考试ID失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据特定的条件查询考试列表信息
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("Exam_Datetime")) 
            {
                criteria
                    //.Add(Restrictions.Le("E_StartTime", conditionDictionary["Exam_Datetime"]))
                    .Add(Restrictions.Ge("E_EndTime", conditionDictionary["Exam_Datetime"]));
            }
            if (conditionDictionary.ContainsKey("E_State,Eq"))
            {
                criteria.Add(Restrictions.IsNotNull("E_State"));
                criteria.Add(Restrictions.Eq("E_State", conditionDictionary["E_State,Eq"]));
            }
            if (conditionDictionary.ContainsKey("int1,Eq"))
            {
                criteria.Add(Restrictions.IsNotNull("int1"));
                criteria.Add(Restrictions.Eq("int1", conditionDictionary["int1,Eq"]));
            }
            if (conditionDictionary.ContainsKey("E_StartTime,Le"))
            {
                criteria.Add(Restrictions.Le("E_StartTime", conditionDictionary["E_StartTime,Le"]));
            }
            if (conditionDictionary.ContainsKey("E_EndTime,Ge"))
            {
                criteria.Add(Restrictions.IsNotNull("E_EndTime"));
                criteria.Add(Restrictions.Ge("E_EndTime", conditionDictionary["E_EndTime,Ge"]));
            }
            if (conditionDictionary.ContainsKey("E_Name,Like"))
            {
                criteria.Add(Restrictions.Like("E_Name", "%" + conditionDictionary["E_Name,Like"] + "%"));
            }
            if (conditionDictionary.ContainsKey("int3,In"))
            {
                criteria.Add(Restrictions.IsNotNull("int3"));
                criteria.Add(Restrictions.In("int3", (List<int>)conditionDictionary["int3,In"]));
            }
            if (conditionDictionary.ContainsKey("E_Kind,In"))
            {
                criteria.Add(Restrictions.IsNotNull("E_Kind"));
                criteria.Add(Restrictions.In("E_Kind", (List<int>)conditionDictionary["E_Kind,In"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,In")) 
            {
                criteria.Add(Restrictions.In("E_ID", (List<Guid>)conditionDictionary["E_ID,In"]));
            }
            //考试结束时间小于系统时间
            if (conditionDictionary.ContainsKey("E_EndTime,Le"))
            {
                criteria.Add(Restrictions.IsNotNull("E_EndTime"));
                criteria.Add(Restrictions.Le("E_EndTime", conditionDictionary["E_EndTime,Le"]));
            }
            return criteria;
        }
        
        /// <summary>
        /// 根据考生ID查询考试总数
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public  int? SelectExamTableCountByStudentID(Dictionary<string, object> conditionDictionary){
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(String.Empty)
            .Append("SELECT ")
            .Append("   COUNT([ExamTable].[E_ID]) AS [ExamCount] ")
            .Append("FROM ")
            .Append("   [ExamTable] ")
            .Append("INNER JOIN  ")
            .Append("   [ExamStudent] ")
            .Append("  ON  [ExamTable].[E_ID]=[ExamStudent].[E_ID] ")
            .Append("INNER JOIN  ")
            .Append("   ( ")
            .Append("   SELECT ")
            .Append("       [ExamTable].[E_ID],  ")
            .Append("       CASE [ExamTable].[E_Kind] ")
            .Append("           WHEN 1 THEN [OSCE_MIN_Exam_StartTime] WHEN 2 THEN [Multi_MIN_Exam_StartTime] WHEN 3 THEN [Single_MIN_Exam_StartTime] END AS [MIN_Exam_StartTime],")
            .Append("       CASE [ExamTable].[E_Kind] ")
            .Append("           WHEN 1 THEN [OSCE_MAX_Exam_EndTime] WHEN 2 THEN [Multi_MAX_Exam_EndTime] WHEN 3 THEN [Single_MAX_Exam_EndTime] END AS [MAX_Exam_EndTime]")
            .Append("   FROM ")
            .Append("       [ExamTable] ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [SingleStationExamArrangement].[E_ID] AS [Single_Exam_ID], ")
            .Append("           MIN([SE_StartTime]) AS [Single_MIN_Exam_StartTime],  ")
            .Append("           MAX([SE_EndTime]) AS [Single_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [SingleStationExamArrangement] ")
            .Append("       WHERE ")
            .Append("           [SingleStationExamArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [SingleStationExamArrangement].[E_ID] ")
            .Append("     ) AS [SingleStationExamTime]  ")
            .Append("    ON [SingleStationExamTime].[Single_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [MultiStationExamArrangement].[E_ID] AS [Multi_Exam_ID], ")
            .Append("           MIN([Exam_StartTime]) AS [Multi_MIN_Exam_StartTime],  ")
            .Append("           MAX([Exam_EndTime]) AS [Multi_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [MultiStationExamArrangement] ")
            .Append("       WHERE ")
            .Append("           [MultiStationExamArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [MultiStationExamArrangement].[E_ID] ")
            .Append("     ) AS [MultiStationExamTime]  ")
            .Append("     ON [MultiStationExamTime].[Multi_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [OSCEExaminationArrangement].[E_ID] AS [OSCE_Exam_ID], ")
            .Append("           MIN([OEA_StartTime]) AS [OSCE_MIN_Exam_StartTime],  ")
            .Append("           MAX([OEA_EndTime]) AS [OSCE_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [OSCEExaminationArrangement] ")
            .Append("       WHERE ")
            .Append("           [OSCEExaminationArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [OSCEExaminationArrangement].[E_ID] ")
            .Append("     ) AS [OSCEExaminationTime]  ")
            .Append("     ON [OSCEExaminationTime].[OSCE_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   WHERE ")
            .Append("       [SingleStationExamTime].[Single_Exam_ID] IS NOT NULL ")
            .Append("        OR [MultiStationExamTime].[Multi_Exam_ID] IS NOT NULL ")
            .Append("        OR [OSCEExaminationTime].[OSCE_Exam_ID] IS NOT NULL ")
            .Append("  ) AS [ExamStudentTime] ")
            .Append("   ON [ExamStudentTime].[E_ID] = [ExamTable].[E_ID] ")
            .Append("WHERE")
            .Append("   [ExamStudent].[U_ID]=:U_ID ")
            .Append("   AND [ExamTable].[int1] = 1 ")
            .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_EndTime,Latest"))
            {
                sqlStringBuilder.Append("AND [ExamStudentTime].[MAX_Exam_EndTime]>=:E_EndTime ");
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
                //设置查询参数类型
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID,Eq"]));
                if (conditionDictionary.ContainsKey("E_EndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Latest"].ToString()));
                }
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch(Exception e){
                Log4NetUtility.Error(this, "按照参加考试学生查询考试信息失败", e);
                return null;
            }
            finally{
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据考生ID查询考试信息
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamTableInfoByStudentID(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize) 
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(String.Empty)
            .Append("SELECT ")
            .Append("   [ExamTable].[E_ID], ")
            .Append("   [ExamTable].[E_Name], ")
            .Append("   [ExamTable].[E_Kind], ")
            .Append("   [ExamTable].[int3], ")
            .Append("   [ExamTable].[E_IsOpenScore], ")
            .Append("   [ExamTable].[E_StartTime], ")
            .Append("   [ExamTable].[E_EndTime], ")
            .Append("   [ExamStudentTime].[MIN_Exam_StartTime], ")
            .Append("   [ExamStudentTime].[MAX_Exam_EndTime] ")
            .Append("FROM ")
            .Append("   [ExamTable] ")
            .Append("INNER JOIN  ")
            .Append("   [ExamStudent] ")
            .Append("  ON  [ExamTable].[E_ID]=[ExamStudent].[E_ID] ")
            .Append("INNER JOIN  ")
            .Append("   ( ")
            .Append("   SELECT ")
            .Append("       [ExamTable].[E_ID],  ")
            .Append("       CASE [ExamTable].[E_Kind] ")
            .Append("           WHEN 1 THEN [OSCE_MIN_Exam_StartTime] WHEN 2 THEN [Multi_MIN_Exam_StartTime] WHEN 3 THEN [Single_MIN_Exam_StartTime] END AS [MIN_Exam_StartTime],")
            .Append("       CASE [ExamTable].[E_Kind] ")
            .Append("           WHEN 1 THEN [OSCE_MAX_Exam_EndTime] WHEN 2 THEN [Multi_MAX_Exam_EndTime] WHEN 3 THEN [Single_MAX_Exam_EndTime] END AS [MAX_Exam_EndTime]")
            .Append("   FROM ")
            .Append("       [ExamTable] ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [SingleStationExamArrangement].[E_ID] AS [Single_Exam_ID], ")
            .Append("           MIN([SE_StartTime]) AS [Single_MIN_Exam_StartTime],  ")
            .Append("           MAX([SE_EndTime]) AS [Single_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [SingleStationExamArrangement] ")
            .Append("       WHERE ")
            .Append("           [SingleStationExamArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [SingleStationExamArrangement].[E_ID] ")
            .Append("     ) AS [SingleStationExamTime]  ")
            .Append("    ON [SingleStationExamTime].[Single_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [MultiStationExamArrangement].[E_ID] AS [Multi_Exam_ID], ")
            .Append("           MIN([Exam_StartTime]) AS [Multi_MIN_Exam_StartTime],  ")
            .Append("           MAX([Exam_EndTime]) AS [Multi_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [MultiStationExamArrangement] ")
            .Append("       WHERE ")
            .Append("           [MultiStationExamArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [MultiStationExamArrangement].[E_ID] ")
            .Append("     ) AS [MultiStationExamTime]  ")
            .Append("     ON [MultiStationExamTime].[Multi_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   LEFT JOIN  ")
            .Append("    ( ")
            .Append("       SELECT  ")
            .Append("           [OSCEExaminationArrangement].[E_ID] AS [OSCE_Exam_ID], ")
            .Append("           MIN([OEA_StartTime]) AS [OSCE_MIN_Exam_StartTime],  ")
            .Append("           MAX([OEA_EndTime]) AS [OSCE_MAX_Exam_EndTime] ")
            .Append("       FROM ")
            .Append("           [OSCEExaminationArrangement] ")
            .Append("       WHERE ")
            .Append("           [OSCEExaminationArrangement].[U_ID] =:U_ID ")
            .Append("       GROUP BY ")
            .Append("           [OSCEExaminationArrangement].[E_ID] ")
            .Append("     ) AS [OSCEExaminationTime]  ")
            .Append("     ON [OSCEExaminationTime].[OSCE_Exam_ID] = [ExamTable].[E_ID]  ")
            .Append("   WHERE ")
            .Append("       [SingleStationExamTime].[Single_Exam_ID] IS NOT NULL ")
            .Append("        OR [MultiStationExamTime].[Multi_Exam_ID] IS NOT NULL ")
            .Append("        OR [OSCEExaminationTime].[OSCE_Exam_ID] IS NOT NULL ")
            .Append("  ) AS [ExamStudentTime] ")
            .Append("   ON [ExamStudentTime].[E_ID] = [ExamTable].[E_ID] ")
            .Append("WHERE")
            .Append("   [ExamStudent].[U_ID]=:U_ID ")
            .Append("   AND [ExamTable].[int1] = 1 ")
            .Append("   AND [ExamTable].[E_State] = 2 ");

            if (conditionDictionary.ContainsKey("E_EndTime,Latest"))
            {
                sqlStringBuilder.Append("AND [ExamStudentTime].[MAX_Exam_EndTime]>=:E_EndTime ");
            }
           
            sqlStringBuilder
                .Append("ORDER BY ")
                .Append( "[MIN_Exam_StartTime] DESC");

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("E_ID",NHibernateUtil.Guid);
                iSQLQuery.AddScalar("E_Name", NHibernateUtil.String);
                iSQLQuery.AddScalar("E_Kind", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("int3", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("E_IsOpenScore", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("E_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("E_EndTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("MIN_Exam_StartTime", NHibernateUtil.DateTime);
                iSQLQuery.AddScalar("MAX_Exam_EndTime", NHibernateUtil.DateTime);

                //设置查询参数类型
                iSQLQuery.SetInt32("U_ID", Convert.ToInt32(conditionDictionary["U_ID,Eq"]));
                if (conditionDictionary.ContainsKey("E_EndTime,Latest"))
                {
                    iSQLQuery.SetDateTime("E_EndTime", DateTime.Parse(conditionDictionary["E_EndTime,Latest"].ToString()));
                }

                return iSQLQuery
                   .SetFirstResult((pageIndex - 1) * pageSize)
                   .SetMaxResults(pageSize)
                   .List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "按照参加考试学生查询考试信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }
        #endregion

        #region ExtensionMethod
        //查找当天的考试
        public DataSet GetTodayExamInfo()
        {
            string strSql = string.Format(@"select * FROM [ExamTable] where (DATEDIFF (DD,E_StartTime ,GETDATE ())=0) 
                            or (DATEDIFF (DD,E_EndTime ,GETDATE ()) = 0) or (GETDATE () >= E_StartTime and GETDATE () <= E_EndTime)");
            return DbHelperSQL.Query(strSql);
        }
        #endregion
    }
}
