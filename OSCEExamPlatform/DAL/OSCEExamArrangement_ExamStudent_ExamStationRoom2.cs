
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
	/// </summary>
	public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom2
	{
        public OSCEExamArrangement_ExamStudent_ExamStationRoom2()
		{}
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OSCEExamArrangement_ExamStudent_ExamStationRoom2(");
            strSql.Append("OEA_ID,OEA_StartTime,ESR_ID,EStu_ID,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,ES_ID,Expr1,Room_ID,Expr2,Expr3,Expr4,Expr5,Expr6,Expr7,Expr8,Expr9,Expr10,Expr11,float3,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool)");
            strSql.Append(" values (");
            strSql.Append("@OEA_ID,@OEA_StartTime,@ESR_ID,@EStu_ID,@OEA_EndTime,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@ES_ID,@Expr1,@Room_ID,@Expr2,@Expr3,@Expr4,@Expr5,@Expr6,@Expr7,@Expr8,@Expr9,@Expr10,@Expr11,@float3,@U_ID,@E_ID,@EStu_ExamNumber,@EStu_int,@EStu_string,@EStu_bool)");
            SqlParameter[] parameters = {
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,16),
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
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Expr1", SqlDbType.Int,4),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@Expr2", SqlDbType.Int,4),
					new SqlParameter("@Expr3", SqlDbType.Int,4),
					new SqlParameter("@Expr4", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr5", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr6", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr7", SqlDbType.DateTime),
					new SqlParameter("@Expr8", SqlDbType.DateTime),
					new SqlParameter("@Expr9", SqlDbType.DateTime),
					new SqlParameter("@Expr10", SqlDbType.Decimal,9),
					new SqlParameter("@Expr11", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1)};
            parameters[0].Value = model.OEA_ID;
            parameters[1].Value = model.OEA_StartTime;
            parameters[2].Value = Guid.NewGuid();
            parameters[3].Value = Guid.NewGuid();
            parameters[4].Value = model.OEA_EndTime;
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
            parameters[16].Value = Guid.NewGuid();
            parameters[17].Value = model.Expr1;
            parameters[18].Value = model.Room_ID;
            parameters[19].Value = model.Expr2;
            parameters[20].Value = model.Expr3;
            parameters[21].Value = model.Expr4;
            parameters[22].Value = model.Expr5;
            parameters[23].Value = model.Expr6;
            parameters[24].Value = model.Expr7;
            parameters[25].Value = model.Expr8;
            parameters[26].Value = model.Expr9;
            parameters[27].Value = model.Expr10;
            parameters[28].Value = model.Expr11;
            parameters[29].Value = model.float3;
            parameters[30].Value = model.U_ID;
            parameters[31].Value = Guid.NewGuid();
            parameters[32].Value = model.EStu_ExamNumber;
            parameters[33].Value = model.EStu_int;
            parameters[34].Value = model.EStu_string;
            parameters[35].Value = model.EStu_bool;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OSCEExamArrangement_ExamStudent_ExamStationRoom2 set ");
            strSql.Append("OEA_ID=@OEA_ID,");
            strSql.Append("OEA_StartTime=@OEA_StartTime,");
            strSql.Append("ESR_ID=@ESR_ID,");
            strSql.Append("EStu_ID=@EStu_ID,");
            strSql.Append("OEA_EndTime=@OEA_EndTime,");
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
            strSql.Append("ES_ID=@ES_ID,");
            strSql.Append("Expr1=@Expr1,");
            strSql.Append("Room_ID=@Room_ID,");
            strSql.Append("Expr2=@Expr2,");
            strSql.Append("Expr3=@Expr3,");
            strSql.Append("Expr4=@Expr4,");
            strSql.Append("Expr5=@Expr5,");
            strSql.Append("Expr6=@Expr6,");
            strSql.Append("Expr7=@Expr7,");
            strSql.Append("Expr8=@Expr8,");
            strSql.Append("Expr9=@Expr9,");
            strSql.Append("Expr10=@Expr10,");
            strSql.Append("Expr11=@Expr11,");
            strSql.Append("float3=@float3,");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("EStu_ExamNumber=@EStu_ExamNumber,");
            strSql.Append("EStu_int=@EStu_int,");
            strSql.Append("EStu_string=@EStu_string,");
            strSql.Append("EStu_bool=@EStu_bool");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,16),
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
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Expr1", SqlDbType.Int,4),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@Expr2", SqlDbType.Int,4),
					new SqlParameter("@Expr3", SqlDbType.Int,4),
					new SqlParameter("@Expr4", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr5", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr6", SqlDbType.NVarChar,500),
					new SqlParameter("@Expr7", SqlDbType.DateTime),
					new SqlParameter("@Expr8", SqlDbType.DateTime),
					new SqlParameter("@Expr9", SqlDbType.DateTime),
					new SqlParameter("@Expr10", SqlDbType.Decimal,9),
					new SqlParameter("@Expr11", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1)};
            parameters[0].Value = model.OEA_ID;
            parameters[1].Value = model.OEA_StartTime;
            parameters[2].Value = model.ESR_ID;
            parameters[3].Value = model.EStu_ID;
            parameters[4].Value = model.OEA_EndTime;
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
            parameters[16].Value = model.ES_ID;
            parameters[17].Value = model.Expr1;
            parameters[18].Value = model.Room_ID;
            parameters[19].Value = model.Expr2;
            parameters[20].Value = model.Expr3;
            parameters[21].Value = model.Expr4;
            parameters[22].Value = model.Expr5;
            parameters[23].Value = model.Expr6;
            parameters[24].Value = model.Expr7;
            parameters[25].Value = model.Expr8;
            parameters[26].Value = model.Expr9;
            parameters[27].Value = model.Expr10;
            parameters[28].Value = model.Expr11;
            parameters[29].Value = model.float3;
            parameters[30].Value = model.U_ID;
            parameters[31].Value = model.E_ID;
            parameters[32].Value = model.EStu_ExamNumber;
            parameters[33].Value = model.EStu_int;
            parameters[34].Value = model.EStu_string;
            parameters[35].Value = model.EStu_bool;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEExamArrangement_ExamStudent_ExamStationRoom2 ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

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
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OEA_ID,OEA_StartTime,ESR_ID,EStu_ID,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,ES_ID,Expr1,Room_ID,Expr2,Expr3,Expr4,Expr5,Expr6,Expr7,Expr8,Expr9,Expr10,Expr11,float3,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool from OSCEExamArrangement_ExamStudent_ExamStationRoom2 ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model = new Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2();
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
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 DataRowToModel(DataRow row)
        {
            Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model = new Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2();
            if (row != null)
            {
                if (row["OEA_ID"] != null && row["OEA_ID"].ToString() != "")
                {
                    model.OEA_ID = int.Parse(row["OEA_ID"].ToString());
                }
                if (row["OEA_StartTime"] != null && row["OEA_StartTime"].ToString() != "")
                {
                    model.OEA_StartTime = DateTime.Parse(row["OEA_StartTime"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = new Guid(row["EStu_ID"].ToString());
                }
                if (row["OEA_EndTime"] != null && row["OEA_EndTime"].ToString() != "")
                {
                    model.OEA_EndTime = DateTime.Parse(row["OEA_EndTime"].ToString());
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
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["Expr1"] != null && row["Expr1"].ToString() != "")
                {
                    model.Expr1 = int.Parse(row["Expr1"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(row["Room_ID"].ToString());
                }
                if (row["Expr2"] != null && row["Expr2"].ToString() != "")
                {
                    model.Expr2 = int.Parse(row["Expr2"].ToString());
                }
                if (row["Expr3"] != null && row["Expr3"].ToString() != "")
                {
                    model.Expr3 = int.Parse(row["Expr3"].ToString());
                }
                if (row["Expr4"] != null)
                {
                    model.Expr4 = row["Expr4"].ToString();
                }
                if (row["Expr5"] != null)
                {
                    model.Expr5 = row["Expr5"].ToString();
                }
                if (row["Expr6"] != null)
                {
                    model.Expr6 = row["Expr6"].ToString();
                }
                if (row["Expr7"] != null && row["Expr7"].ToString() != "")
                {
                    model.Expr7 = DateTime.Parse(row["Expr7"].ToString());
                }
                if (row["Expr8"] != null && row["Expr8"].ToString() != "")
                {
                    model.Expr8 = DateTime.Parse(row["Expr8"].ToString());
                }
                if (row["Expr9"] != null && row["Expr9"].ToString() != "")
                {
                    model.Expr9 = DateTime.Parse(row["Expr9"].ToString());
                }
                if (row["Expr10"] != null && row["Expr10"].ToString() != "")
                {
                    model.Expr10 = decimal.Parse(row["Expr10"].ToString());
                }
                if (row["Expr11"] != null && row["Expr11"].ToString() != "")
                {
                    model.Expr11 = decimal.Parse(row["Expr11"].ToString());
                }
                if (row["float3"] != null && row["float3"].ToString() != "")
                {
                    model.float3 = decimal.Parse(row["float3"].ToString());
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
            strSql.Append("select OEA_ID,OEA_StartTime,ESR_ID,EStu_ID,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,ES_ID,Expr1,Room_ID,Expr2,Expr3,Expr4,Expr5,Expr6,Expr7,Expr8,Expr9,Expr10,Expr11,float3,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool ");
            strSql.Append(" FROM OSCEExamArrangement_ExamStudent_ExamStationRoom2 ");
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
            strSql.Append(" OEA_ID,OEA_StartTime,ESR_ID,EStu_ID,OEA_EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,ES_ID,Expr1,Room_ID,Expr2,Expr3,Expr4,Expr5,Expr6,Expr7,Expr8,Expr9,Expr10,Expr11,float3,U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool ");
            strSql.Append(" FROM OSCEExamArrangement_ExamStudent_ExamStationRoom2 ");
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
            strSql.Append("select count(1) FROM OSCEExamArrangement_ExamStudent_ExamStationRoom2 ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from OSCEExamArrangement_ExamStudent_ExamStationRoom2 T ");
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
            parameters[0].Value = "OSCEExamArrangement_ExamStudent_ExamStationRoom2";
            parameters[1].Value = "";
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
        /// 根据RoomID查找考试ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetExamID(string RoomID)
        {
            //string strSql = string.Format(@"select top 1 * from [OSCEExamArrangement_ExamStudent_ExamStationRoom2] where Room_ID = '{0}' and 
            //  OEA_EndTime = (select MIN (OEA_EndTime) from [OSCEExamArrangement_ExamStudent_ExamStationRoom2] where OEA_EndTime >= GETDATE () and Room_ID = '{0}')", RoomID);
            string strSql = string.Format(@"select top 1 * from [OSCEExamArrangement_ExamStudent_ExamStationRoom2] left join [ExamTable] 
                                    on [ExamTable].E_ID = [OSCEExamArrangement_ExamStudent_ExamStationRoom2].E_ID where Room_ID = '{0}' and 
                                    OEA_EndTime = (select MIN (OEA_EndTime) from [OSCEExamArrangement_ExamStudent_ExamStationRoom2] 
                                    where OEA_EndTime >= GETDATE () and Room_ID = '{0}') and [ExamTable].E_State = '2' and [ExamTable].int1 = '1'", RoomID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站排考表
        /// </summary>
        /// <param name="ExamID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetArrangementTable(Guid ExamID, int RoomID)
        {
            string strSql = string.Format("select E_ID ,ES_ID ,Room_ID ,U_ID ,OEA_StartTime ,OEA_EndTime from [OSCEExamArrangement_ExamStudent_ExamStationRoom2] where E_ID = '{0}' and Room_ID = '{1}' order by OEA_StartTime", ExamID, RoomID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion  ExtensionMethod
	}
}

