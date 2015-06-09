using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ObjectiveMarkSheet
	/// </summary>
	public partial class ObjectiveMarkSheet
	{
		public ObjectiveMarkSheet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OMS_ID", "ObjectiveMarkSheet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OMS_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjectiveMarkSheet");
			strSql.Append(" where OMS_ID=@OMS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OMS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = OMS_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.ObjectiveMarkSheet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjectiveMarkSheet(");
			strSql.Append("OMS_Name,OMS_Kind,OMS_CreateDate,OMS_ModifyDate,string1,string2,string3,string4,int1,int2)");
			strSql.Append(" values (");
			strSql.Append("@OMS_Name,@OMS_Kind,@OMS_CreateDate,@OMS_ModifyDate,@string1,@string2,@string3,@string4,@int1,@int2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OMS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OMS_Kind", SqlDbType.NVarChar,50),
					new SqlParameter("@OMS_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@OMS_ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@string4", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4)};
			parameters[0].Value = model.OMS_Name;
			parameters[1].Value = model.OMS_Kind;
			parameters[2].Value = model.OMS_CreateDate;
			parameters[3].Value = model.OMS_ModifyDate;
			parameters[4].Value = model.string1;
			parameters[5].Value = model.string2;
			parameters[6].Value = model.string3;
			parameters[7].Value = model.string4;
			parameters[8].Value = model.int1;
			parameters[9].Value = model.int2;

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
		public bool Update(Tellyes.Model.ObjectiveMarkSheet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjectiveMarkSheet set ");
			strSql.Append("OMS_Name=@OMS_Name,");
			strSql.Append("OMS_Kind=@OMS_Kind,");
			strSql.Append("OMS_CreateDate=@OMS_CreateDate,");
			strSql.Append("OMS_ModifyDate=@OMS_ModifyDate,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3,");
			strSql.Append("string4=@string4,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2");
			strSql.Append(" where OMS_ID=@OMS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OMS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OMS_Kind", SqlDbType.NVarChar,50),
					new SqlParameter("@OMS_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@OMS_ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@string4", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@OMS_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OMS_Name;
			parameters[1].Value = model.OMS_Kind;
			parameters[2].Value = model.OMS_CreateDate;
			parameters[3].Value = model.OMS_ModifyDate;
			parameters[4].Value = model.string1;
			parameters[5].Value = model.string2;
			parameters[6].Value = model.string3;
			parameters[7].Value = model.string4;
			parameters[8].Value = model.int1;
			parameters[9].Value = model.int2;
			parameters[10].Value = model.OMS_ID;

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
		public bool Delete(int OMS_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjectiveMarkSheet ");
			strSql.Append(" where OMS_ID=@OMS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OMS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = OMS_ID;

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
		public bool DeleteList(string OMS_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjectiveMarkSheet ");
			strSql.Append(" where OMS_ID in ("+OMS_IDlist + ")  ");
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
		public Tellyes.Model.ObjectiveMarkSheet GetModel(int OMS_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OMS_ID,OMS_Name,OMS_Kind,OMS_CreateDate,OMS_ModifyDate,string1,string2,string3,string4,int1,int2 from ObjectiveMarkSheet ");
			strSql.Append(" where OMS_ID=@OMS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OMS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = OMS_ID;

			Tellyes.Model.ObjectiveMarkSheet model=new Tellyes.Model.ObjectiveMarkSheet();
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
		public Tellyes.Model.ObjectiveMarkSheet DataRowToModel(DataRow row)
		{
			Tellyes.Model.ObjectiveMarkSheet model=new Tellyes.Model.ObjectiveMarkSheet();
			if (row != null)
			{
				if(row["OMS_ID"]!=null && row["OMS_ID"].ToString()!="")
				{
					model.OMS_ID=int.Parse(row["OMS_ID"].ToString());
				}
				if(row["OMS_Name"]!=null)
				{
					model.OMS_Name=row["OMS_Name"].ToString();
				}
				if(row["OMS_Kind"]!=null)
				{
					model.OMS_Kind=row["OMS_Kind"].ToString();
				}
				if(row["OMS_CreateDate"]!=null && row["OMS_CreateDate"].ToString()!="")
				{
					model.OMS_CreateDate=DateTime.Parse(row["OMS_CreateDate"].ToString());
				}
				if(row["OMS_ModifyDate"]!=null && row["OMS_ModifyDate"].ToString()!="")
				{
					model.OMS_ModifyDate=DateTime.Parse(row["OMS_ModifyDate"].ToString());
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
				if(row["int1"]!=null && row["int1"].ToString()!="")
				{
					model.int1=int.Parse(row["int1"].ToString());
				}
				if(row["int2"]!=null && row["int2"].ToString()!="")
				{
					model.int2=int.Parse(row["int2"].ToString());
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
			strSql.Append("select OMS_ID,OMS_Name,OMS_Kind,OMS_CreateDate,OMS_ModifyDate,string1,string2,string3,string4,int1,int2 ");
			strSql.Append(" FROM ObjectiveMarkSheet ");
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
			strSql.Append(" OMS_ID,OMS_Name,OMS_Kind,OMS_CreateDate,OMS_ModifyDate,string1,string2,string3,string4,int1,int2 ");
			strSql.Append(" FROM ObjectiveMarkSheet ");
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
			strSql.Append("select count(1) FROM ObjectiveMarkSheet ");
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
				strSql.Append("order by T.OMS_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ObjectiveMarkSheet T ");
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
			parameters[0].Value = "ObjectiveMarkSheet";
			parameters[1].Value = "OMS_ID";
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
        /// 获得某种设备，全部客观评分表
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public static DataTable GetObjectMarkTable(string DC_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select os.OMS_Name,osi.* ");
            sql.Append(" from dbo.ObjectiveMarkSheet as os join dbo.ObjectiveMarkSheetItem as osi on os.OMS_ID=osi.OMS_ID ");
            sql.Append(" where os.OMS_ID in (select OMS_ID from DC_OMS where DC_ID ='" + DC_ID + "'); ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

