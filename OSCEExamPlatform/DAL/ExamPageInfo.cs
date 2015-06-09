
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ExamPageInfo
	/// </summary>
	public partial class ExamPageInfo
	{
		public ExamPageInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("E_ID", "ExamPageInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int E_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExamPageInfo");
			strSql.Append(" where E_ID=@E_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = E_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.ExamPageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExamPageInfo(");
			strSql.Append("E_Name,E_TotalScore,E_TotalNumber,E_IsShare,E_AnswerTime,E_IsRollback,E_OldOrder,E_AOldOrder,E_Creater,E_CreateTime,E_ModifyTime,E_Remarks,E_OldID,int1,int2,int3,int4,int5,int6,string1,string2,string3,string4,string5,string6,date1,date2,date3)");
			strSql.Append(" values (");
			strSql.Append("@E_Name,@E_TotalScore,@E_TotalNumber,@E_IsShare,@E_AnswerTime,@E_IsRollback,@E_OldOrder,@E_AOldOrder,@E_Creater,@E_CreateTime,@E_ModifyTime,@E_Remarks,@E_OldID,@int1,@int2,@int3,@int4,@int5,@int6,@string1,@string2,@string3,@string4,@string5,@string6,@date1,@date2,@date3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_TotalScore", SqlDbType.Int,4),
					new SqlParameter("@E_TotalNumber", SqlDbType.Int,4),
					new SqlParameter("@E_IsShare", SqlDbType.Int,4),
					new SqlParameter("@E_AnswerTime", SqlDbType.Int,4),
					new SqlParameter("@E_IsRollback", SqlDbType.Int,4),
					new SqlParameter("@E_OldOrder", SqlDbType.Int,4),
					new SqlParameter("@E_AOldOrder", SqlDbType.Int,4),
					new SqlParameter("@E_Creater", SqlDbType.Int,4),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Remarks", SqlDbType.NVarChar,2000),
					new SqlParameter("@E_OldID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@int4", SqlDbType.Int,4),
					new SqlParameter("@int5", SqlDbType.Int,4),
					new SqlParameter("@int6", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,200),
					new SqlParameter("@string4", SqlDbType.NVarChar,200),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@string6", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime)};
			parameters[0].Value = model.E_Name;
			parameters[1].Value = model.E_TotalScore;
			parameters[2].Value = model.E_TotalNumber;
			parameters[3].Value = model.E_IsShare;
			parameters[4].Value = model.E_AnswerTime;
			parameters[5].Value = model.E_IsRollback;
			parameters[6].Value = model.E_OldOrder;
			parameters[7].Value = model.E_AOldOrder;
			parameters[8].Value = model.E_Creater;
			parameters[9].Value = model.E_CreateTime;
			parameters[10].Value = model.E_ModifyTime;
			parameters[11].Value = model.E_Remarks;
			parameters[12].Value = model.E_OldID;
			parameters[13].Value = model.int1;
			parameters[14].Value = model.int2;
			parameters[15].Value = model.int3;
			parameters[16].Value = model.int4;
			parameters[17].Value = model.int5;
			parameters[18].Value = model.int6;
			parameters[19].Value = model.string1;
			parameters[20].Value = model.string2;
			parameters[21].Value = model.string3;
			parameters[22].Value = model.string4;
			parameters[23].Value = model.string5;
			parameters[24].Value = model.string6;
			parameters[25].Value = model.date1;
			parameters[26].Value = model.date2;
			parameters[27].Value = model.date3;

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
		public bool Update(Tellyes.Model.ExamPageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExamPageInfo set ");
			strSql.Append("E_Name=@E_Name,");
			strSql.Append("E_TotalScore=@E_TotalScore,");
			strSql.Append("E_TotalNumber=@E_TotalNumber,");
			strSql.Append("E_IsShare=@E_IsShare,");
			strSql.Append("E_AnswerTime=@E_AnswerTime,");
			strSql.Append("E_IsRollback=@E_IsRollback,");
			strSql.Append("E_OldOrder=@E_OldOrder,");
			strSql.Append("E_AOldOrder=@E_AOldOrder,");
			strSql.Append("E_Creater=@E_Creater,");
			strSql.Append("E_CreateTime=@E_CreateTime,");
			strSql.Append("E_ModifyTime=@E_ModifyTime,");
			strSql.Append("E_Remarks=@E_Remarks,");
			strSql.Append("E_OldID=@E_OldID,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("int4=@int4,");
			strSql.Append("int5=@int5,");
			strSql.Append("int6=@int6,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3,");
			strSql.Append("string4=@string4,");
			strSql.Append("string5=@string5,");
			strSql.Append("string6=@string6,");
			strSql.Append("date1=@date1,");
			strSql.Append("date2=@date2,");
			strSql.Append("date3=@date3");
			strSql.Append(" where E_ID=@E_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_TotalScore", SqlDbType.Int,4),
					new SqlParameter("@E_TotalNumber", SqlDbType.Int,4),
					new SqlParameter("@E_IsShare", SqlDbType.Int,4),
					new SqlParameter("@E_AnswerTime", SqlDbType.Int,4),
					new SqlParameter("@E_IsRollback", SqlDbType.Int,4),
					new SqlParameter("@E_OldOrder", SqlDbType.Int,4),
					new SqlParameter("@E_AOldOrder", SqlDbType.Int,4),
					new SqlParameter("@E_Creater", SqlDbType.Int,4),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Remarks", SqlDbType.NVarChar,2000),
					new SqlParameter("@E_OldID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@int4", SqlDbType.Int,4),
					new SqlParameter("@int5", SqlDbType.Int,4),
					new SqlParameter("@int6", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,200),
					new SqlParameter("@string4", SqlDbType.NVarChar,200),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@string6", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@E_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_Name;
			parameters[1].Value = model.E_TotalScore;
			parameters[2].Value = model.E_TotalNumber;
			parameters[3].Value = model.E_IsShare;
			parameters[4].Value = model.E_AnswerTime;
			parameters[5].Value = model.E_IsRollback;
			parameters[6].Value = model.E_OldOrder;
			parameters[7].Value = model.E_AOldOrder;
			parameters[8].Value = model.E_Creater;
			parameters[9].Value = model.E_CreateTime;
			parameters[10].Value = model.E_ModifyTime;
			parameters[11].Value = model.E_Remarks;
			parameters[12].Value = model.E_OldID;
			parameters[13].Value = model.int1;
			parameters[14].Value = model.int2;
			parameters[15].Value = model.int3;
			parameters[16].Value = model.int4;
			parameters[17].Value = model.int5;
			parameters[18].Value = model.int6;
			parameters[19].Value = model.string1;
			parameters[20].Value = model.string2;
			parameters[21].Value = model.string3;
			parameters[22].Value = model.string4;
			parameters[23].Value = model.string5;
			parameters[24].Value = model.string6;
			parameters[25].Value = model.date1;
			parameters[26].Value = model.date2;
			parameters[27].Value = model.date3;
			parameters[28].Value = model.E_ID;

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
		public bool Delete(int E_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamPageInfo ");
			strSql.Append(" where E_ID=@E_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = E_ID;

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
		public bool DeleteList(string E_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamPageInfo ");
			strSql.Append(" where E_ID in ("+E_IDlist + ")  ");
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
		public Tellyes.Model.ExamPageInfo GetModel(int E_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 E_ID,E_Name,E_TotalScore,E_TotalNumber,E_IsShare,E_AnswerTime,E_IsRollback,E_OldOrder,E_AOldOrder,E_Creater,E_CreateTime,E_ModifyTime,E_Remarks,E_OldID,int1,int2,int3,int4,int5,int6,string1,string2,string3,string4,string5,string6,date1,date2,date3 from ExamPageInfo ");
			strSql.Append(" where E_ID=@E_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = E_ID;

			Tellyes.Model.ExamPageInfo model=new Tellyes.Model.ExamPageInfo();
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
		public Tellyes.Model.ExamPageInfo DataRowToModel(DataRow row)
		{
			Tellyes.Model.ExamPageInfo model=new Tellyes.Model.ExamPageInfo();
			if (row != null)
			{
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID=int.Parse(row["E_ID"].ToString());
				}
				if(row["E_Name"]!=null)
				{
					model.E_Name=row["E_Name"].ToString();
				}
				if(row["E_TotalScore"]!=null && row["E_TotalScore"].ToString()!="")
				{
					model.E_TotalScore=int.Parse(row["E_TotalScore"].ToString());
				}
				if(row["E_TotalNumber"]!=null && row["E_TotalNumber"].ToString()!="")
				{
					model.E_TotalNumber=int.Parse(row["E_TotalNumber"].ToString());
				}
				if(row["E_IsShare"]!=null && row["E_IsShare"].ToString()!="")
				{
					model.E_IsShare=int.Parse(row["E_IsShare"].ToString());
				}
				if(row["E_AnswerTime"]!=null && row["E_AnswerTime"].ToString()!="")
				{
					model.E_AnswerTime=int.Parse(row["E_AnswerTime"].ToString());
				}
				if(row["E_IsRollback"]!=null && row["E_IsRollback"].ToString()!="")
				{
					model.E_IsRollback=int.Parse(row["E_IsRollback"].ToString());
				}
				if(row["E_OldOrder"]!=null && row["E_OldOrder"].ToString()!="")
				{
					model.E_OldOrder=int.Parse(row["E_OldOrder"].ToString());
				}
				if(row["E_AOldOrder"]!=null && row["E_AOldOrder"].ToString()!="")
				{
					model.E_AOldOrder=int.Parse(row["E_AOldOrder"].ToString());
				}
				if(row["E_Creater"]!=null && row["E_Creater"].ToString()!="")
				{
					model.E_Creater=int.Parse(row["E_Creater"].ToString());
				}
				if(row["E_CreateTime"]!=null && row["E_CreateTime"].ToString()!="")
				{
					model.E_CreateTime=DateTime.Parse(row["E_CreateTime"].ToString());
				}
				if(row["E_ModifyTime"]!=null && row["E_ModifyTime"].ToString()!="")
				{
					model.E_ModifyTime=DateTime.Parse(row["E_ModifyTime"].ToString());
				}
				if(row["E_Remarks"]!=null)
				{
					model.E_Remarks=row["E_Remarks"].ToString();
				}
				if(row["E_OldID"]!=null && row["E_OldID"].ToString()!="")
				{
					model.E_OldID=int.Parse(row["E_OldID"].ToString());
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
				if(row["int4"]!=null && row["int4"].ToString()!="")
				{
					model.int4=int.Parse(row["int4"].ToString());
				}
				if(row["int5"]!=null && row["int5"].ToString()!="")
				{
					model.int5=int.Parse(row["int5"].ToString());
				}
				if(row["int6"]!=null && row["int6"].ToString()!="")
				{
					model.int6=int.Parse(row["int6"].ToString());
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
				if(row["string4"]!=null)
				{
					model.string4=row["string4"].ToString();
				}
				if(row["string5"]!=null)
				{
					model.string5=row["string5"].ToString();
				}
				if(row["string6"]!=null)
				{
					model.string6=row["string6"].ToString();
				}
				if(row["date1"]!=null && row["date1"].ToString()!="")
				{
					model.date1=DateTime.Parse(row["date1"].ToString());
				}
				if(row["date2"]!=null && row["date2"].ToString()!="")
				{
					model.date2=DateTime.Parse(row["date2"].ToString());
				}
				if(row["date3"]!=null && row["date3"].ToString()!="")
				{
					model.date3=DateTime.Parse(row["date3"].ToString());
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
			strSql.Append("select E_ID,E_Name,E_TotalScore,E_TotalNumber,E_IsShare,E_AnswerTime,E_IsRollback,E_OldOrder,E_AOldOrder,E_Creater,E_CreateTime,E_ModifyTime,E_Remarks,E_OldID,int1,int2,int3,int4,int5,int6,string1,string2,string3,string4,string5,string6,date1,date2,date3 ");
			strSql.Append(" FROM ExamPageInfo ");
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
			strSql.Append(" E_ID,E_Name,E_TotalScore,E_TotalNumber,E_IsShare,E_AnswerTime,E_IsRollback,E_OldOrder,E_AOldOrder,E_Creater,E_CreateTime,E_ModifyTime,E_Remarks,E_OldID,int1,int2,int3,int4,int5,int6,string1,string2,string3,string4,string5,string6,date1,date2,date3 ");
			strSql.Append(" FROM ExamPageInfo ");
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
			strSql.Append("select count(1) FROM ExamPageInfo ");
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
				strSql.Append("order by T.E_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ExamPageInfo T ");
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
			parameters[0].Value = "ExamPageInfo";
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

		#endregion  ExtensionMethod
	}
}

