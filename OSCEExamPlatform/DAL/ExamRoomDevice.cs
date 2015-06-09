using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Maticsoft.Common.Type;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ExamRoomDevice
	/// </summary>
	public partial class ExamRoomDevice
	{
		public ExamRoomDevice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ERD_ID", "ExamRoomDevice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ERD_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExamRoomDevice");
			strSql.Append(" where ERD_ID=@ERD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ERD_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ERD_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.ExamRoomDevice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExamRoomDevice(");
			strSql.Append("E_ID,Room_ID,DC_ID,D_ID,int1,int2,int3,string1,string2,string3)");
			strSql.Append(" values (");
			strSql.Append("@E_ID,@Room_ID,@DC_ID,@D_ID,@int1,@int2,@int3,@string1,@string2,@string3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@D_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.Room_ID;
			parameters[2].Value = model.DC_ID;
			parameters[3].Value = model.D_ID;
			parameters[4].Value = model.int1;
			parameters[5].Value = model.int2;
			parameters[6].Value = model.int3;
			parameters[7].Value = model.string1;
			parameters[8].Value = model.string2;
			parameters[9].Value = model.string3;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Tellyes.Model.ExamRoomDevice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExamRoomDevice set ");
			strSql.Append("E_ID=@E_ID,");
			strSql.Append("Room_ID=@Room_ID,");
			strSql.Append("DC_ID=@DC_ID,");
			strSql.Append("D_ID=@D_ID,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3");
			strSql.Append(" where ERD_ID=@ERD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@D_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@ERD_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.Room_ID;
			parameters[2].Value = model.DC_ID;
			parameters[3].Value = model.D_ID;
			parameters[4].Value = model.int1;
			parameters[5].Value = model.int2;
			parameters[6].Value = model.int3;
			parameters[7].Value = model.string1;
			parameters[8].Value = model.string2;
			parameters[9].Value = model.string3;
			parameters[10].Value = model.ERD_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int ERD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamRoomDevice ");
			strSql.Append(" where ERD_ID=@ERD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ERD_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ERD_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string ERD_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamRoomDevice ");
			strSql.Append(" where ERD_ID in ("+ERD_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Tellyes.Model.ExamRoomDevice GetModel(int ERD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ERD_ID,E_ID,Room_ID,DC_ID,D_ID,int1,int2,int3,string1,string2,string3 from ExamRoomDevice ");
			strSql.Append(" where ERD_ID=@ERD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ERD_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ERD_ID;

			Tellyes.Model.ExamRoomDevice model=new Tellyes.Model.ExamRoomDevice();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Tellyes.Model.ExamRoomDevice DataRowToModel(DataRow row)
		{
			Tellyes.Model.ExamRoomDevice model=new Tellyes.Model.ExamRoomDevice();
			if (row != null)
			{
				if(row["ERD_ID"]!=null && row["ERD_ID"].ToString()!="")
				{
					model.ERD_ID=int.Parse(row["ERD_ID"].ToString());
				}
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID=int.Parse(row["E_ID"].ToString());
				}
				if(row["Room_ID"]!=null && row["Room_ID"].ToString()!="")
				{
					model.Room_ID=int.Parse(row["Room_ID"].ToString());
				}
				if(row["DC_ID"]!=null && row["DC_ID"].ToString()!="")
				{
					model.DC_ID=int.Parse(row["DC_ID"].ToString());
				}
				if(row["D_ID"]!=null && row["D_ID"].ToString()!="")
				{
					model.D_ID=int.Parse(row["D_ID"].ToString());
				}
				if(row["int1"]!=null && row["int1"].ToString()!="")
				{
					model.int1=int.Parse(row["int1"].ToString());
				}
				if(row["int2"]!=null && row["int2"].ToString()!="")
				{
					model.int2=int.Parse(row["int2"].ToString());
				}
				if(row["int3"]!=null && row["int3"].ToString()!="")
				{
					model.int3=int.Parse(row["int3"].ToString());
				}
				if(row["string1"]!=null)
				{
					model.string1=row["string1"].ToString();
				}
				if(row["string2"]!=null)
				{
					model.string2=row["string2"].ToString();
				}
				if(row["string3"]!=null)
				{
					model.string3=row["string3"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ERD_ID,E_ID,Room_ID,DC_ID,D_ID,int1,int2,int3,string1,string2,string3 ");
			strSql.Append(" FROM ExamRoomDevice ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ERD_ID,E_ID,Room_ID,DC_ID,D_ID,int1,int2,int3,string1,string2,string3 ");
			strSql.Append(" FROM ExamRoomDevice ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ExamRoomDevice ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ERD_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ExamRoomDevice T ");
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
			parameters[0].Value = "ExamRoomDevice";
			parameters[1].Value = "ERD_ID";
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
        /// 根据E_ID获得已选中设备
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetSelectedDeviceByE_ID(string E_ID)
        {
            string sql = " select * from ExamRoomDevice where E_ID='"+E_ID+"'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据E_ID，获得每个房间对应种类的个数
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="examType"></param>
        /// <returns></returns>
        public static DataTable GetDeviceCountInEachRoom(string E_ID,ExamType examType)
        {
            DataTable result=new DataTable();
            StringBuilder sql = new StringBuilder();
            if(examType== ExamType.SingleExam)
            {
                sql.Append(" with base as ( select Room_ID,DC_ID,D_Count from (select distinct Room_ID from  ExamStation_Room where ES_ID in (select ES_ID from dbo.ExamStation where int1='" + E_ID + "')) as a ");
                sql.Append(" cross join (select distinct DC_ID,D_Count from SingleStationExamRoom_DeviceClass where E_ID='" + E_ID + "') as b) ");
                sql.Append(" ,countRoom as ( select COUNT(distinct Room_ID) as roomCount from base )");
                sql.Append(" ,base2 as ( select * from base cross join countRoom ),result as ( select Room_ID,DC_ID,FLOOR(D_Count/roomCount) as perRoomCount from base2 ) select * from result;");
                result = DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
            }
            if(examType == ExamType.MultiExam)
            {
                sql.Append(" select Room_ID,DC_ID,DC_Count as perRoomCount from dbo.MultiStationExam_DeviceClass where E_ID='" + E_ID + "'; ");
                result = DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
            }
            if(!result.Columns.Contains("Room_ID"))
            {
                result.Columns.Add("Room_ID");
                result.Columns.Add("DC_ID");
                result.Columns.Add("perRoomCount");
            }
            return result;
        }

        /// <summary>
        /// 根据E_ID获得冲突设备列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetErrorDevice(string E_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select D_ID from ExamRoomDevice where E_ID in ( ");
            sql.Append(" select b.E_ID from ExamTable as a join  ExamTable as b ");
            sql.Append(" on a.E_ID<>b.E_ID  ");
            sql.Append(" and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) ");
            sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime) ");
            sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime) ");
            sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) where a.E_ID ='" + E_ID + "'); ");
            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }

        /// <summary>
        /// 根据E_ID，获得可用待选设备
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="examType"></param>
        /// <returns></returns>
        public static DataTable GetPreparingDevice(string E_ID,ExamType examType)
        {
            DataTable result = new DataTable();
            StringBuilder sql = new StringBuilder();
            if(examType ==  ExamType.SingleExam)
            {
                sql.Append(" select * from dbo.Device where D_ID not in ( ");
                sql.Append(" select D_ID from ExamRoomDevice where E_ID in ( ");
                sql.Append(" select b.E_ID from ExamTable as a join  ExamTable as b ");
                sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) ");
                sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime) ");
                sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime) ");
                sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
                sql.Append(" where a.E_ID ='" + E_ID + "')) and DC_ID  in (select DC_ID from SingleStationExamRoom_DeviceClass where E_ID='" + E_ID + "'); ");
                result = DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
            }
            if(examType == ExamType.MultiExam)
            {
                sql.Append(" select * from dbo.Device where D_ID not in ( ");
                sql.Append(" select D_ID from ExamRoomDevice where E_ID in ( ");
                sql.Append(" select b.E_ID from ExamTable as a join  ExamTable as b ");
                sql.Append(" on a.E_ID<>b.E_ID and ((a.E_StartTime between b.E_StartTime and b.E_EndTime) ");
                sql.Append(" or (a.E_EndTime between b.E_StartTime and b.E_EndTime) ");
                sql.Append(" or (b.E_StartTime between a.E_StartTime and a.E_EndTime) ");
                sql.Append(" or (b.E_EndTime between a.E_StartTime and a.E_EndTime)) ");
                sql.Append(" where a.E_ID ='" + E_ID + "')) and DC_ID  in (select DC_ID from MultiStationExam_DeviceClass where E_ID='" + E_ID + "'); ");
                result = DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
            }
            return result;
        }
		#endregion  ExtensionMethod
	}
}

