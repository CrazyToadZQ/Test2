
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:TestQuestionRelation
	/// </summary>
	public partial class TestQuestionRelation
	{
		public TestQuestionRelation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TQR_ID", "TestQuestionRelation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TQR_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TestQuestionRelation");
			strSql.Append(" where TQR_ID=@TQR_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@TQR_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = TQR_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.TestQuestionRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TestQuestionRelation(");
			strSql.Append("E_ID,Q_ID,TQR_Number,TQR_Score)");
			strSql.Append(" values (");
			strSql.Append("@E_ID,@Q_ID,@TQR_Number,@TQR_Score)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.Int,4),
					new SqlParameter("@Q_ID", SqlDbType.Int,4),
					new SqlParameter("@TQR_Number", SqlDbType.Int,4),
					new SqlParameter("@TQR_Score", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.Q_ID;
			parameters[2].Value = model.TQR_Number;
			parameters[3].Value = model.TQR_Score;

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
		public bool Update(Tellyes.Model.TestQuestionRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TestQuestionRelation set ");
			strSql.Append("E_ID=@E_ID,");
			strSql.Append("Q_ID=@Q_ID,");
			strSql.Append("TQR_Number=@TQR_Number,");
			strSql.Append("TQR_Score=@TQR_Score");
			strSql.Append(" where TQR_ID=@TQR_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.Int,4),
					new SqlParameter("@Q_ID", SqlDbType.Int,4),
					new SqlParameter("@TQR_Number", SqlDbType.Int,4),
					new SqlParameter("@TQR_Score", SqlDbType.NVarChar,50),
					new SqlParameter("@TQR_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.Q_ID;
			parameters[2].Value = model.TQR_Number;
			parameters[3].Value = model.TQR_Score;
			parameters[4].Value = model.TQR_ID;

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
		public bool Delete(int TQR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TestQuestionRelation ");
			strSql.Append(" where TQR_ID=@TQR_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@TQR_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = TQR_ID;

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
		public bool DeleteList(string TQR_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TestQuestionRelation ");
			strSql.Append(" where TQR_ID in ("+TQR_IDlist + ")  ");
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
		public Tellyes.Model.TestQuestionRelation GetModel(int TQR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TQR_ID,E_ID,Q_ID,TQR_Number,TQR_Score from TestQuestionRelation ");
			strSql.Append(" where TQR_ID=@TQR_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@TQR_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = TQR_ID;

			Tellyes.Model.TestQuestionRelation model=new Tellyes.Model.TestQuestionRelation();
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
		public Tellyes.Model.TestQuestionRelation DataRowToModel(DataRow row)
		{
			Tellyes.Model.TestQuestionRelation model=new Tellyes.Model.TestQuestionRelation();
			if (row != null)
			{
				if(row["TQR_ID"]!=null && row["TQR_ID"].ToString()!="")
				{
					model.TQR_ID=int.Parse(row["TQR_ID"].ToString());
				}
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID=int.Parse(row["E_ID"].ToString());
				}
				if(row["Q_ID"]!=null && row["Q_ID"].ToString()!="")
				{
					model.Q_ID=int.Parse(row["Q_ID"].ToString());
				}
				if(row["TQR_Number"]!=null && row["TQR_Number"].ToString()!="")
				{
					model.TQR_Number=int.Parse(row["TQR_Number"].ToString());
				}
				if(row["TQR_Score"]!=null)
				{
					model.TQR_Score=row["TQR_Score"].ToString();
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
			strSql.Append("select TQR_ID,E_ID,Q_ID,TQR_Number,TQR_Score ");
			strSql.Append(" FROM TestQuestionRelation ");
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
			strSql.Append(" TQR_ID,E_ID,Q_ID,TQR_Number,TQR_Score ");
			strSql.Append(" FROM TestQuestionRelation ");
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
			strSql.Append("select count(1) FROM TestQuestionRelation ");
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
				strSql.Append("order by T.TQR_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TestQuestionRelation T ");
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
			parameters[0].Value = "TestQuestionRelation";
			parameters[1].Value = "TQR_ID";
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
        /// 根据EID查找所有的试题库中EQID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet ExportEID(string EID)
        {
            string strSql = string.Format(@"select * from [TestQuestionRelation] left join [QuestionInfo] on 
                        [QuestionInfo].Q_ID = [TestQuestionRelation].Q_ID where [TestQuestionRelation].E_ID = '{0}' 
                        order by [TestQuestionRelation].TQR_Number ", EID);
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
            string strSql = string.Format("update [TestQuestionRelation] set TQR_Score = '{0}' where E_ID = '{1}'", averageScore, EID);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 更改最后一道试卷试题的分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="TQR_Number"></param>
        /// <param name="lastScore"></param>
        /// <returns></returns>
        public int UpdateLastScore(string EID, int TQR_Number, int lastScore)
        {
            string strSql = string.Format("update [TestQuestionRelation] set TQR_Score = '{0}' where E_ID = '{1}' and TQR_Number = '{2}'", lastScore, EID, TQR_Number);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 根据EID,QID更新分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="QID"></param>
        /// <param name="scoreStr"></param>
        /// <returns></returns>
        public int UpdateScore(string EID, string QID, string scoreStr)
        {
            string strSql = string.Format("update [TestQuestionRelation] set TQR_Score = '{0}' where E_ID = '{1}' and Q_ID ='{2}'", scoreStr, EID, QID);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 通过试卷ID查找其相应的试题ID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet GetQID(string EID)
        {
            string strSql = string.Format("select * from [TestQuestionRelation] where E_ID = '{0}' order by TQR_Number ", EID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 根据EQID和EID查找题号TQR_Number
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="EQID"></param>
        /// <returns></returns>
        public DataSet GetNumber(string EID, string EQID)
        {
            string strSql = string.Format("select * from [TestQuestionRelation] where Q_ID = (select Q_ID  from [QuestionInfo] where EQ_ID = '{0}') and E_ID = '{1}'", EQID, EID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 更新试卷试题的题号
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="oldNumber"></param>
        /// <param name="newNumber"></param>
        /// <returns></returns>
        public int UpdateTQR_Number(string EID, int oldNumber, int newNumber)
        {
            string strSql = string.Format("update [TestQuestionRelation] set TQR_Number = '{0}' where TQR_Number = '{1}' and E_ID = '{2}'", newNumber, oldNumber, EID);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 更新当前行试题的题号
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="QID"></param>
        /// <param name="oldNumber"></param>
        /// <param name="newNumber"></param>
        /// <returns></returns>
        public int UpdateCurrentTQR_Number(string EID, string QID, int oldNumber, int newNumber)
        {
            string strSql = string.Format("update [TestQuestionRelation] set TQR_Number = '{0}' where TQR_Number = '{1}' and E_ID = '{2}' and Q_ID = '{3}'", newNumber, oldNumber, EID, QID);
            return DbHelperSQL.ExecuteSql(strSql);
        }

        #endregion  ExtensionMethod
	}
}

