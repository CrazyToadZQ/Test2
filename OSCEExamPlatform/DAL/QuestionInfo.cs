using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:QuestionInfo
	/// </summary>
	public partial class QuestionInfo
	{
		public QuestionInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Q_ID", "QuestionInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Q_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QuestionInfo");
			strSql.Append(" where Q_ID=@Q_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Q_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Q_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.QuestionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QuestionInfo(");
			strSql.Append("EQ_ID,Q_Score,int1,int2,int3,int4,int5,string1,string2,string3,string4,string5,date1,date2,date3)");
			strSql.Append(" values (");
			strSql.Append("@EQ_ID,@Q_Score,@int1,@int2,@int3,@int4,@int5,@string1,@string2,@string3,@string4,@string5,@date1,@date2,@date3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4),
					new SqlParameter("@Q_Score", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@int4", SqlDbType.Int,4),
					new SqlParameter("@int5", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,200),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime)};
			parameters[0].Value = model.EQ_ID;
			parameters[1].Value = model.Q_Score;
			parameters[2].Value = model.int1;
			parameters[3].Value = model.int2;
			parameters[4].Value = model.int3;
			parameters[5].Value = model.int4;
			parameters[6].Value = model.int5;
			parameters[7].Value = model.string1;
			parameters[8].Value = model.string2;
			parameters[9].Value = model.string3;
			parameters[10].Value = model.string4;
			parameters[11].Value = model.string5;
			parameters[12].Value = model.date1;
			parameters[13].Value = model.date2;
			parameters[14].Value = model.date3;

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
		public bool Update(Tellyes.Model.QuestionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QuestionInfo set ");
			strSql.Append("EQ_ID=@EQ_ID,");
			strSql.Append("Q_Score=@Q_Score,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("int4=@int4,");
			strSql.Append("int5=@int5,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3,");
			strSql.Append("string4=@string4,");
			strSql.Append("string5=@string5,");
			strSql.Append("date1=@date1,");
			strSql.Append("date2=@date2,");
			strSql.Append("date3=@date3");
			strSql.Append(" where Q_ID=@Q_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4),
					new SqlParameter("@Q_Score", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@int4", SqlDbType.Int,4),
					new SqlParameter("@int5", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,200),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@Q_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.EQ_ID;
			parameters[1].Value = model.Q_Score;
			parameters[2].Value = model.int1;
			parameters[3].Value = model.int2;
			parameters[4].Value = model.int3;
			parameters[5].Value = model.int4;
			parameters[6].Value = model.int5;
			parameters[7].Value = model.string1;
			parameters[8].Value = model.string2;
			parameters[9].Value = model.string3;
			parameters[10].Value = model.string4;
			parameters[11].Value = model.string5;
			parameters[12].Value = model.date1;
			parameters[13].Value = model.date2;
			parameters[14].Value = model.date3;
			parameters[15].Value = model.Q_ID;

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
		public bool Delete(int Q_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionInfo ");
			strSql.Append(" where Q_ID=@Q_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Q_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Q_ID;

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
		public bool DeleteList(string Q_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QuestionInfo ");
			strSql.Append(" where Q_ID in ("+Q_IDlist + ")  ");
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
		public Tellyes.Model.QuestionInfo GetModel(int Q_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Q_ID,EQ_ID,Q_Score,int1,int2,int3,int4,int5,string1,string2,string3,string4,string5,date1,date2,date3 from QuestionInfo ");
			strSql.Append(" where Q_ID=@Q_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Q_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Q_ID;

			Tellyes.Model.QuestionInfo model=new Tellyes.Model.QuestionInfo();
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
		public Tellyes.Model.QuestionInfo DataRowToModel(DataRow row)
		{
			Tellyes.Model.QuestionInfo model=new Tellyes.Model.QuestionInfo();
			if (row != null)
			{
				if(row["Q_ID"]!=null && row["Q_ID"].ToString()!="")
				{
					model.Q_ID=int.Parse(row["Q_ID"].ToString());
				}
				if(row["EQ_ID"]!=null && row["EQ_ID"].ToString()!="")
				{
					model.EQ_ID=int.Parse(row["EQ_ID"].ToString());
				}
				if(row["Q_Score"]!=null)
				{
					model.Q_Score=row["Q_Score"].ToString();
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
			strSql.Append("select Q_ID,EQ_ID,Q_Score,int1,int2,int3,int4,int5,string1,string2,string3,string4,string5,date1,date2,date3 ");
			strSql.Append(" FROM QuestionInfo ");
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
			strSql.Append(" Q_ID,EQ_ID,Q_Score,int1,int2,int3,int4,int5,string1,string2,string3,string4,string5,date1,date2,date3 ");
			strSql.Append(" FROM QuestionInfo ");
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
			strSql.Append("select count(1) FROM QuestionInfo ");
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
				strSql.Append("order by T.Q_ID desc");
			}
			strSql.Append(")AS Row, T.*  from QuestionInfo T ");
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
			parameters[0].Value = "QuestionInfo";
			parameters[1].Value = "Q_ID";
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
        /// 通过EQ_ID查找Q_ID
        /// </summary>
        /// <param name="EQ_ID"></param>
        /// <returns></returns>
        public DataSet GetQID(string EQ_ID)
        {
            string strSql = string.Format("select * from [QuestionInfo] where EQ_ID = '{0}'", EQ_ID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 根据EID更改所有试题成绩为平均成绩
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="averageScore"></param>
        /// <returns></returns>
        public int UpdateAllScore(string EID, int averageScore)
        {
            string strSql = string.Format("update [QuestionInfo] set Q_Score = '{0}' where [QuestionInfo].Q_ID in (select Q_ID from [TestQuestionRelation] where E_ID = '{1}')", averageScore, EID);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 更改最后一道试题的分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="TQR_Number"></param>
        /// <param name="lastScore"></param>
        /// <returns></returns>
        public int UpdateLastScore(string EID, int TQR_Number, int lastScore)
        {
            string strSql = string.Format("update [QuestionInfo] set Q_Score = '{0}' where Q_ID = (select Q_ID from [TestQuestionRelation] where E_ID = '{1}' and TQR_Number = '{2}')", lastScore, EID, TQR_Number);
            return DbHelperSQL.ExecuteSql(strSql);
        }

		#endregion  ExtensionMethod
	}
}

