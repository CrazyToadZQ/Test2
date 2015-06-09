using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;

namespace Tellyes.DAL
{
    public class Room1
    {
        public Room1()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Room_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Room");
			strSql.Append(" where Room_ID=@Room_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Room_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Room_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.Room1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Room(");
			strSql.Append("Parent_Room_ID,Room_Name,Room_Area,Room_People_Number,Room_Station_Number,Room_IS_Binding_Device,Room_Device_Name,Room_Describe,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4)");
			strSql.Append(" values (");
			strSql.Append("@Parent_Room_ID,@Room_Name,@Room_Area,@Room_People_Number,@Room_Station_Number,@Room_IS_Binding_Device,@Room_Device_Name,@Room_Describe,@Number1,@Number2,@Number3,@Number4,@Number5,@Number6,@Number7,@Number8,@String1,@String2,@String3,@String4,@String5,@String6,@String7,@String8,@Datetime1,@Datetime2,@Datetime3,@Datetime4)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Parent_Room_ID", SqlDbType.Int,4),
					new SqlParameter("@Room_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_Area", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_People_Number", SqlDbType.Int,4),
					new SqlParameter("@Room_Station_Number", SqlDbType.Int,4),
					new SqlParameter("@Room_IS_Binding_Device", SqlDbType.Int,4),
					new SqlParameter("@Room_Device_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_Describe", SqlDbType.NVarChar,200),
					new SqlParameter("@Number1", SqlDbType.Int,4),
					new SqlParameter("@Number2", SqlDbType.Int,4),
					new SqlParameter("@Number3", SqlDbType.Int,4),
					new SqlParameter("@Number4", SqlDbType.Int,4),
					new SqlParameter("@Number5", SqlDbType.Int,4),
					new SqlParameter("@Number6", SqlDbType.Decimal,13),
					new SqlParameter("@Number7", SqlDbType.Decimal,13),
					new SqlParameter("@Number8", SqlDbType.Decimal,13),
					new SqlParameter("@String1", SqlDbType.VarChar,50),
					new SqlParameter("@String2", SqlDbType.VarChar,50),
					new SqlParameter("@String3", SqlDbType.VarChar,50),
					new SqlParameter("@String4", SqlDbType.VarChar,200),
					new SqlParameter("@String5", SqlDbType.VarChar,200),
					new SqlParameter("@String6", SqlDbType.VarChar,200),
					new SqlParameter("@String7", SqlDbType.VarChar,-1),
					new SqlParameter("@String8", SqlDbType.VarChar,-1),
					new SqlParameter("@Datetime1", SqlDbType.DateTime),
					new SqlParameter("@Datetime2", SqlDbType.DateTime),
					new SqlParameter("@Datetime3", SqlDbType.DateTime),
					new SqlParameter("@Datetime4", SqlDbType.DateTime)};
			parameters[0].Value = model.Parent_Room_ID;
			parameters[1].Value = model.Room_Name;
			parameters[2].Value = model.Room_Area;
			parameters[3].Value = model.Room_People_Number;
			parameters[4].Value = model.Room_Station_Number;
			parameters[5].Value = model.Room_IS_Binding_Device;
			parameters[6].Value = model.Room_Device_Name;
			parameters[7].Value = model.Room_Describe;
			parameters[8].Value = model.Number1;
			parameters[9].Value = model.Number2;
			parameters[10].Value = model.Number3;
			parameters[11].Value = model.Number4;
			parameters[12].Value = model.Number5;
			parameters[13].Value = model.Number6;
			parameters[14].Value = model.Number7;
			parameters[15].Value = model.Number8;
			parameters[16].Value = model.String1;
			parameters[17].Value = model.String2;
			parameters[18].Value = model.String3;
			parameters[19].Value = model.String4;
			parameters[20].Value = model.String5;
			parameters[21].Value = model.String6;
			parameters[22].Value = model.String7;
			parameters[23].Value = model.String8;
			parameters[24].Value = model.Datetime1;
			parameters[25].Value = model.Datetime2;
			parameters[26].Value = model.Datetime3;
			parameters[27].Value = model.Datetime4;

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
        public bool Update(Tellyes.Model.Room1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Room set ");
			strSql.Append("Parent_Room_ID=@Parent_Room_ID,");
			strSql.Append("Room_Name=@Room_Name,");
			strSql.Append("Room_Area=@Room_Area,");
			strSql.Append("Room_People_Number=@Room_People_Number,");
			strSql.Append("Room_Station_Number=@Room_Station_Number,");
			strSql.Append("Room_IS_Binding_Device=@Room_IS_Binding_Device,");
			strSql.Append("Room_Device_Name=@Room_Device_Name,");
			strSql.Append("Room_Describe=@Room_Describe,");
			strSql.Append("Number1=@Number1,");
			strSql.Append("Number2=@Number2,");
			strSql.Append("Number3=@Number3,");
			strSql.Append("Number4=@Number4,");
			strSql.Append("Number5=@Number5,");
			strSql.Append("Number6=@Number6,");
			strSql.Append("Number7=@Number7,");
			strSql.Append("Number8=@Number8,");
			strSql.Append("String1=@String1,");
			strSql.Append("String2=@String2,");
			strSql.Append("String3=@String3,");
			strSql.Append("String4=@String4,");
			strSql.Append("String5=@String5,");
			strSql.Append("String6=@String6,");
			strSql.Append("String7=@String7,");
			strSql.Append("String8=@String8,");
			strSql.Append("Datetime1=@Datetime1,");
			strSql.Append("Datetime2=@Datetime2,");
			strSql.Append("Datetime3=@Datetime3,");
			strSql.Append("Datetime4=@Datetime4");
			strSql.Append(" where Room_ID=@Room_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Parent_Room_ID", SqlDbType.Int,4),
					new SqlParameter("@Room_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_Area", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_People_Number", SqlDbType.Int,4),
					new SqlParameter("@Room_Station_Number", SqlDbType.Int,4),
					new SqlParameter("@Room_IS_Binding_Device", SqlDbType.Int,4),
					new SqlParameter("@Room_Device_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Room_Describe", SqlDbType.NVarChar,200),
					new SqlParameter("@Number1", SqlDbType.Int,4),
					new SqlParameter("@Number2", SqlDbType.Int,4),
					new SqlParameter("@Number3", SqlDbType.Int,4),
					new SqlParameter("@Number4", SqlDbType.Int,4),
					new SqlParameter("@Number5", SqlDbType.Int,4),
					new SqlParameter("@Number6", SqlDbType.Decimal,13),
					new SqlParameter("@Number7", SqlDbType.Decimal,13),
					new SqlParameter("@Number8", SqlDbType.Decimal,13),
					new SqlParameter("@String1", SqlDbType.VarChar,50),
					new SqlParameter("@String2", SqlDbType.VarChar,50),
					new SqlParameter("@String3", SqlDbType.VarChar,50),
					new SqlParameter("@String4", SqlDbType.VarChar,200),
					new SqlParameter("@String5", SqlDbType.VarChar,200),
					new SqlParameter("@String6", SqlDbType.VarChar,200),
					new SqlParameter("@String7", SqlDbType.VarChar,-1),
					new SqlParameter("@String8", SqlDbType.VarChar,-1),
					new SqlParameter("@Datetime1", SqlDbType.DateTime),
					new SqlParameter("@Datetime2", SqlDbType.DateTime),
					new SqlParameter("@Datetime3", SqlDbType.DateTime),
					new SqlParameter("@Datetime4", SqlDbType.DateTime),
					new SqlParameter("@Room_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Parent_Room_ID;
			parameters[1].Value = model.Room_Name;
			parameters[2].Value = model.Room_Area;
			parameters[3].Value = model.Room_People_Number;
			parameters[4].Value = model.Room_Station_Number;
			parameters[5].Value = model.Room_IS_Binding_Device;
			parameters[6].Value = model.Room_Device_Name;
			parameters[7].Value = model.Room_Describe;
			parameters[8].Value = model.Number1;
			parameters[9].Value = model.Number2;
			parameters[10].Value = model.Number3;
			parameters[11].Value = model.Number4;
			parameters[12].Value = model.Number5;
			parameters[13].Value = model.Number6;
			parameters[14].Value = model.Number7;
			parameters[15].Value = model.Number8;
			parameters[16].Value = model.String1;
			parameters[17].Value = model.String2;
			parameters[18].Value = model.String3;
			parameters[19].Value = model.String4;
			parameters[20].Value = model.String5;
			parameters[21].Value = model.String6;
			parameters[22].Value = model.String7;
			parameters[23].Value = model.String8;
			parameters[24].Value = model.Datetime1;
			parameters[25].Value = model.Datetime2;
			parameters[26].Value = model.Datetime3;
			parameters[27].Value = model.Datetime4;
			parameters[28].Value = model.Room_ID;

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
		public bool Delete(int Room_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Room ");
			strSql.Append(" where Room_ID=@Room_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Room_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Room_ID;

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
		public bool DeleteList(string Room_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Room ");
			strSql.Append(" where Room_ID in ("+Room_IDlist + ")  ");
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
        public Tellyes.Model.Room1 GetModel(int Room_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Room_ID,Parent_Room_ID,Room_Name,Room_Area,Room_People_Number,Room_Station_Number,Room_IS_Binding_Device,Room_Device_Name,Room_Describe,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 from Room ");
			strSql.Append(" where Room_ID=@Room_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Room_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Room_ID;

            Tellyes.Model.Room1 model = new Tellyes.Model.Room1();
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
		public Tellyes.Model.Room1 DataRowToModel(DataRow row)
		{
            Tellyes.Model.Room1 model = new Tellyes.Model.Room1();
			if (row != null)
			{
				if(row["Room_ID"]!=null && row["Room_ID"].ToString()!="")
				{
					model.Room_ID=int.Parse(row["Room_ID"].ToString());
				}
				if(row["Parent_Room_ID"]!=null && row["Parent_Room_ID"].ToString()!="")
				{
					model.Parent_Room_ID=int.Parse(row["Parent_Room_ID"].ToString());
				}
				if(row["Room_Name"]!=null)
				{
					model.Room_Name=row["Room_Name"].ToString();
				}
				if(row["Room_Area"]!=null)
				{
					model.Room_Area=row["Room_Area"].ToString();
				}
				if(row["Room_People_Number"]!=null && row["Room_People_Number"].ToString()!="")
				{
					model.Room_People_Number=int.Parse(row["Room_People_Number"].ToString());
				}
				if(row["Room_Station_Number"]!=null && row["Room_Station_Number"].ToString()!="")
				{
					model.Room_Station_Number=int.Parse(row["Room_Station_Number"].ToString());
				}
				if(row["Room_IS_Binding_Device"]!=null && row["Room_IS_Binding_Device"].ToString()!="")
				{
					model.Room_IS_Binding_Device=int.Parse(row["Room_IS_Binding_Device"].ToString());
				}
				if(row["Room_Device_Name"]!=null)
				{
					model.Room_Device_Name=row["Room_Device_Name"].ToString();
				}
				if(row["Room_Describe"]!=null)
				{
					model.Room_Describe=row["Room_Describe"].ToString();
				}
				if(row["Number1"]!=null && row["Number1"].ToString()!="")
				{
					model.Number1=int.Parse(row["Number1"].ToString());
				}
				if(row["Number2"]!=null && row["Number2"].ToString()!="")
				{
					model.Number2=int.Parse(row["Number2"].ToString());
				}
				if(row["Number3"]!=null && row["Number3"].ToString()!="")
				{
					model.Number3=int.Parse(row["Number3"].ToString());
				}
				if(row["Number4"]!=null && row["Number4"].ToString()!="")
				{
					model.Number4=int.Parse(row["Number4"].ToString());
				}
				if(row["Number5"]!=null && row["Number5"].ToString()!="")
				{
					model.Number5=int.Parse(row["Number5"].ToString());
				}
				if(row["Number6"]!=null && row["Number6"].ToString()!="")
				{
					model.Number6=decimal.Parse(row["Number6"].ToString());
				}
				if(row["Number7"]!=null && row["Number7"].ToString()!="")
				{
					model.Number7=decimal.Parse(row["Number7"].ToString());
				}
				if(row["Number8"]!=null && row["Number8"].ToString()!="")
				{
					model.Number8=decimal.Parse(row["Number8"].ToString());
				}
				if(row["String1"]!=null)
				{
					model.String1=row["String1"].ToString();
				}
				if(row["String2"]!=null)
				{
					model.String2=row["String2"].ToString();
				}
				if(row["String3"]!=null)
				{
					model.String3=row["String3"].ToString();
				}
				if(row["String4"]!=null)
				{
					model.String4=row["String4"].ToString();
				}
				if(row["String5"]!=null)
				{
					model.String5=row["String5"].ToString();
				}
				if(row["String6"]!=null)
				{
					model.String6=row["String6"].ToString();
				}
				if(row["String7"]!=null)
				{
					model.String7=row["String7"].ToString();
				}
				if(row["String8"]!=null)
				{
					model.String8=row["String8"].ToString();
				}
				if(row["Datetime1"]!=null && row["Datetime1"].ToString()!="")
				{
					model.Datetime1=DateTime.Parse(row["Datetime1"].ToString());
				}
				if(row["Datetime2"]!=null && row["Datetime2"].ToString()!="")
				{
					model.Datetime2=DateTime.Parse(row["Datetime2"].ToString());
				}
				if(row["Datetime3"]!=null && row["Datetime3"].ToString()!="")
				{
					model.Datetime3=DateTime.Parse(row["Datetime3"].ToString());
				}
				if(row["Datetime4"]!=null && row["Datetime4"].ToString()!="")
				{
					model.Datetime4=DateTime.Parse(row["Datetime4"].ToString());
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
			strSql.Append("select Room_ID,Parent_Room_ID,Room_Name,Room_Area,Room_People_Number,Room_Station_Number,Room_IS_Binding_Device,Room_Device_Name,Room_Describe,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
			strSql.Append(" FROM Room ");
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
			strSql.Append(" Room_ID,Parent_Room_ID,Room_Name,Room_Area,Room_People_Number,Room_Station_Number,Room_IS_Binding_Device,Room_Device_Name,Room_Describe,Number1,Number2,Number3,Number4,Number5,Number6,Number7,Number8,String1,String2,String3,String4,String5,String6,String7,String8,Datetime1,Datetime2,Datetime3,Datetime4 ");
			strSql.Append(" FROM Room ");
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
			strSql.Append("select count(1) FROM Room ");
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
				strSql.Append("order by T.Room_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Room T ");
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
			parameters[0].Value = "Room";
			parameters[1].Value = "Room_ID";
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
        /// 获得所有可选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllRoomsThatCanBeChoose(string ES_ID)
        {
            string sql = " select * from Room where Room_ID not in (select Room_ID from ExamStation_Room where ES_ID='" + ES_ID + "') and Number1='1'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获得所有可选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllRoomsThatCanBeChooseByMemory(string Room_IDs)
        {
            string sql = " select * from Room where Room_ID not in (" + Room_IDs + ")  and Number1='1'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获得所有已选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllSelectedRooms(string ES_ID)
        {
            string sql = " select * from dbo.ExamStation_Room as er join dbo.Room as r on er.Room_ID=r.Room_ID where er.ES_ID='" + ES_ID + "'; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据roomname查找roomid
        /// </summary>
        /// <param name="RoomName"></param>
        /// <returns></returns>
        public DataSet GetRoomID(string RoomName)
        {
            string strSql = string.Format(" select * from [Room] where Room_Name ='{0}'", RoomName);
            return DbHelperSQL.Query(strSql);
        }

        public DataSet GetRoomIDName()
        {
            string strSql = string.Format("select Room_Name,Room_ID from [Room]");
            return DbHelperSQL.Query(strSql);
        }
		#endregion  ExtensionMethod
    }
}
