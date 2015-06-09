using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:Role
	/// </summary>
	public partial class Role
	{
		public Role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("R_ID", "Role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int R_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Role");
			strSql.Append(" where R_ID=@R_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = R_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Role(");
			strSql.Append("R_Name,R_Content,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
			strSql.Append("@R_Name,@R_Content,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@R_Content", SqlDbType.NVarChar,500),
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
			parameters[0].Value = model.R_Name;
			parameters[1].Value = model.R_Content;
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
		public bool Update(Tellyes.Model.Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Role set ");
			strSql.Append("R_Name=@R_Name,");
			strSql.Append("R_Content=@R_Content,");
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
			strSql.Append(" where R_ID=@R_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@R_Content", SqlDbType.NVarChar,500),
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
					new SqlParameter("@R_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.R_Name;
			parameters[1].Value = model.R_Content;
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
			parameters[14].Value = model.R_ID;

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
		public bool Delete(int R_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Role ");
			strSql.Append(" where R_ID=@R_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = R_ID;

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
		public bool DeleteList(string R_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Role ");
			strSql.Append(" where R_ID in ("+R_IDlist + ")  ");
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
		public Tellyes.Model.Role GetModel(int R_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 R_ID,R_Name,R_Content,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from Role ");
			strSql.Append(" where R_ID=@R_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = R_ID;

			Tellyes.Model.Role model=new Tellyes.Model.Role();
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
		public Tellyes.Model.Role DataRowToModel(DataRow row)
		{
			Tellyes.Model.Role model=new Tellyes.Model.Role();
			if (row != null)
			{
				if(row["R_ID"]!=null && row["R_ID"].ToString()!="")
				{
					model.R_ID=int.Parse(row["R_ID"].ToString());
				}
				if(row["R_Name"]!=null)
				{
					model.R_Name=row["R_Name"].ToString();
				}
				if(row["R_Content"]!=null)
				{
					model.R_Content=row["R_Content"].ToString();
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
				if(row["float1"]!=null && row["float1"].ToString()!="")
				{
					model.float1=decimal.Parse(row["float1"].ToString());
				}
				if(row["float2"]!=null && row["float2"].ToString()!="")
				{
					model.float2=decimal.Parse(row["float2"].ToString());
				}
				if(row["float3"]!=null && row["float3"].ToString()!="")
				{
					model.float3=decimal.Parse(row["float3"].ToString());
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
			strSql.Append("select R_ID,R_Name,R_Content,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM Role ");
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
			strSql.Append(" R_ID,R_Name,R_Content,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM Role ");
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
			strSql.Append("select count(1) FROM Role ");
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
				strSql.Append("order by T.R_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Role T ");
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
			parameters[0].Value = "Role";
			parameters[1].Value = "R_ID";
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

