using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:QuestionType
	/// </summary>
	public partial class QuestionType
	{
		public QuestionType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("QT_ID", "QuestionType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int QT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QuestionType");
			strSql.Append(" where QT_ID=@QT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.QuestionType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QuestionType(");
			strSql.Append("QT_Name,int1,int2,int3,string1,string2,string3)");
			strSql.Append(" values (");
			strSql.Append("@QT_Name,@int1,@int2,@int3,@string1,@string2,@string3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@QT_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.QT_Name;
			parameters[1].Value = model.int1;
			parameters[2].Value = model.int2;
			parameters[3].Value = model.int3;
			parameters[4].Value = model.string1;
			parameters[5].Value = model.string2;
			parameters[6].Value = model.string3;

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
		public bool Update(Tellyes.Model.QuestionType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QuestionType set ");
			strSql.Append("QT_Name=@QT_Name,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3");
			strSql.Append(" where QT_ID=@QT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QT_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@QT_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.QT_Name;
			parameters[1].Value = model.int1;
			parameters[2].Value = model.int2;
			parameters[3].Value = model.int3;
			parameters[4].Value = model.string1;
			parameters[5].Value = model.string2;
			parameters[6].Value = model.string3;
			parameters[7].Value = model.QT_ID;

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
		public bool Delete(int QT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionType ");
			strSql.Append(" where QT_ID=@QT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QT_ID;

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
		public bool DeleteList(string QT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionType ");
			strSql.Append(" where QT_ID in ("+QT_IDlist + ")  ");
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
		public Tellyes.Model.QuestionType GetModel(int QT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 QT_ID,QT_Name,int1,int2,int3,string1,string2,string3 from QuestionType ");
			strSql.Append(" where QT_ID=@QT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QT_ID;

			Tellyes.Model.QuestionType model=new Tellyes.Model.QuestionType();
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
		public Tellyes.Model.QuestionType DataRowToModel(DataRow row)
		{
			Tellyes.Model.QuestionType model=new Tellyes.Model.QuestionType();
			if (row != null)
			{
				if(row["QT_ID"]!=null && row["QT_ID"].ToString()!="")
				{
					model.QT_ID=int.Parse(row["QT_ID"].ToString());
				}
				if(row["QT_Name"]!=null)
				{
					model.QT_Name=row["QT_Name"].ToString();
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
			strSql.Append("select QT_ID,QT_Name,int1,int2,int3,string1,string2,string3 ");
			strSql.Append(" FROM QuestionType ");
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
			strSql.Append(" QT_ID,QT_Name,int1,int2,int3,string1,string2,string3 ");
			strSql.Append(" FROM QuestionType ");
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
			strSql.Append("select count(1) FROM QuestionType ");
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
				strSql.Append("order by T.QT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from QuestionType T ");
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
			parameters[0].Value = "QuestionType";
			parameters[1].Value = "QT_ID";
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

