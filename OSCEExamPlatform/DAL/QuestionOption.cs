using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:QuestionOption
	/// </summary>
	public partial class QuestionOption
	{
		public QuestionOption()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("QO_ID", "QuestionOption"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int QO_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QuestionOption");
			strSql.Append(" where QO_ID=@QO_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QO_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QO_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.QuestionOption model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QuestionOption(");
			strSql.Append("EQ_ID,QO_Option,QO_Accessory,QO_SubjectAnswer,QO_Explain,QO_ObjectAnswer,int1,int2,int3,string1,string2,string3,string4,string5)");
			strSql.Append(" values (");
			strSql.Append("@EQ_ID,@QO_Option,@QO_Accessory,@QO_SubjectAnswer,@QO_Explain,@QO_ObjectAnswer,@int1,@int2,@int3,@string1,@string2,@string3,@string4,@string5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4),
					new SqlParameter("@QO_Option", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_Accessory", SqlDbType.NVarChar,1000),
					new SqlParameter("@QO_SubjectAnswer", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_Explain", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_ObjectAnswer", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,100),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.EQ_ID;
			parameters[1].Value = model.QO_Option;
			parameters[2].Value = model.QO_Accessory;
			parameters[3].Value = model.QO_SubjectAnswer;
			parameters[4].Value = model.QO_Explain;
			parameters[5].Value = model.QO_ObjectAnswer;
			parameters[6].Value = model.int1;
			parameters[7].Value = model.int2;
			parameters[8].Value = model.int3;
			parameters[9].Value = model.string1;
			parameters[10].Value = model.string2;
			parameters[11].Value = model.string3;
			parameters[12].Value = model.string4;
			parameters[13].Value = model.string5;

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
		public bool Update(Tellyes.Model.QuestionOption model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QuestionOption set ");
			strSql.Append("EQ_ID=@EQ_ID,");
			strSql.Append("QO_Option=@QO_Option,");
			strSql.Append("QO_Accessory=@QO_Accessory,");
			strSql.Append("QO_SubjectAnswer=@QO_SubjectAnswer,");
			strSql.Append("QO_Explain=@QO_Explain,");
			strSql.Append("QO_ObjectAnswer=@QO_ObjectAnswer,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3,");
			strSql.Append("string4=@string4,");
			strSql.Append("string5=@string5");
			strSql.Append(" where QO_ID=@QO_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4),
					new SqlParameter("@QO_Option", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_Accessory", SqlDbType.NVarChar,1000),
					new SqlParameter("@QO_SubjectAnswer", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_Explain", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_ObjectAnswer", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,100),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@QO_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.EQ_ID;
			parameters[1].Value = model.QO_Option;
			parameters[2].Value = model.QO_Accessory;
			parameters[3].Value = model.QO_SubjectAnswer;
			parameters[4].Value = model.QO_Explain;
			parameters[5].Value = model.QO_ObjectAnswer;
			parameters[6].Value = model.int1;
			parameters[7].Value = model.int2;
			parameters[8].Value = model.int3;
			parameters[9].Value = model.string1;
			parameters[10].Value = model.string2;
			parameters[11].Value = model.string3;
			parameters[12].Value = model.string4;
			parameters[13].Value = model.string5;
			parameters[14].Value = model.QO_ID;

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
		public bool Delete(int QO_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionOption ");
			strSql.Append(" where QO_ID=@QO_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QO_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QO_ID;

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
		public bool DeleteList(string QO_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionOption ");
			strSql.Append(" where QO_ID in ("+QO_IDlist + ")  ");
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
		public Tellyes.Model.QuestionOption GetModel(int QO_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 QO_ID,EQ_ID,QO_Option,QO_Accessory,QO_SubjectAnswer,QO_Explain,QO_ObjectAnswer,int1,int2,int3,string1,string2,string3,string4,string5 from QuestionOption ");
			strSql.Append(" where QO_ID=@QO_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@QO_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = QO_ID;

			Tellyes.Model.QuestionOption model=new Tellyes.Model.QuestionOption();
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
		public Tellyes.Model.QuestionOption DataRowToModel(DataRow row)
		{
			Tellyes.Model.QuestionOption model=new Tellyes.Model.QuestionOption();
			if (row != null)
			{
				if(row["QO_ID"]!=null && row["QO_ID"].ToString()!="")
				{
					model.QO_ID=int.Parse(row["QO_ID"].ToString());
				}
				if(row["EQ_ID"]!=null && row["EQ_ID"].ToString()!="")
				{
					model.EQ_ID=int.Parse(row["EQ_ID"].ToString());
				}
				if(row["QO_Option"]!=null)
				{
					model.QO_Option=row["QO_Option"].ToString();
				}
				if(row["QO_Accessory"]!=null)
				{
					model.QO_Accessory=row["QO_Accessory"].ToString();
				}
				if(row["QO_SubjectAnswer"]!=null)
				{
					model.QO_SubjectAnswer=row["QO_SubjectAnswer"].ToString();
				}
				if(row["QO_Explain"]!=null)
				{
					model.QO_Explain=row["QO_Explain"].ToString();
				}
				if(row["QO_ObjectAnswer"]!=null && row["QO_ObjectAnswer"].ToString()!="")
				{
					model.QO_ObjectAnswer=int.Parse(row["QO_ObjectAnswer"].ToString());
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
				if(row["string4"]!=null)
				{
					model.string4=row["string4"].ToString();
				}
				if(row["string5"]!=null)
				{
					model.string5=row["string5"].ToString();
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
			strSql.Append("select QO_ID,EQ_ID,QO_Option,QO_Accessory,QO_SubjectAnswer,QO_Explain,QO_ObjectAnswer,int1,int2,int3,string1,string2,string3,string4,string5 ");
			strSql.Append(" FROM QuestionOption ");
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
			strSql.Append(" QO_ID,EQ_ID,QO_Option,QO_Accessory,QO_SubjectAnswer,QO_Explain,QO_ObjectAnswer,int1,int2,int3,string1,string2,string3,string4,string5 ");
			strSql.Append(" FROM QuestionOption ");
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
			strSql.Append("select count(1) FROM QuestionOption ");
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
				strSql.Append("order by T.QO_ID desc");
			}
			strSql.Append(")AS Row, T.*  from QuestionOption T ");
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
			parameters[0].Value = "QuestionOption";
			parameters[1].Value = "QO_ID";
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
        /// 查找试题的选项信息，并根据int1排序显示
        /// </summary>
        /// <param name="EQ_ID"></param>
        /// <returns></returns>
        public DataSet GetQuestionOption(string EQ_ID)
        {
            string strSql = string.Format("select * from [QuestionOption] where EQ_ID = '{0}' order by int1 ", EQ_ID);
            return DbHelperSQL.Query(strSql);
        }

        public DataSet GetOption(string QO_IDStr)
        {
            string strSql = string.Format("select * from [QuestionOption] where QO_ID in ({0}) order by int1", QO_IDStr);
            return DbHelperSQL.Query(strSql);
        }

		#endregion  ExtensionMethod
	}
}

