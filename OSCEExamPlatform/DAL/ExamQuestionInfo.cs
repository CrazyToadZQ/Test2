using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ExamQuestionInfo
	/// </summary>
	public partial class ExamQuestionInfo
	{
		public ExamQuestionInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EQ_ID", "ExamQuestionInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EQ_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExamQuestionInfo");
			strSql.Append(" where EQ_ID=@EQ_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = EQ_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.ExamQuestionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExamQuestionInfo(");
			strSql.Append("EQ_Name,QT_ID,EQ_Difficulty,EQ_Type,EQ_Stem,EQ_StemAccessory,QO_ID,EQ_Classify,EQ_AnswerNumber,EQ_Kind,EQ_Share,EQ_Creater,EQ_CreateTime,EQ_ModifyTime,EQ_OldID,int1,int2,int3,string1,string2,string3,string4,string5,date1,date2,date3)");
			strSql.Append(" values (");
			strSql.Append("@EQ_Name,@QT_ID,@EQ_Difficulty,@EQ_Type,@EQ_Stem,@EQ_StemAccessory,@QO_ID,@EQ_Classify,@EQ_AnswerNumber,@EQ_Kind,@EQ_Share,@EQ_Creater,@EQ_CreateTime,@EQ_ModifyTime,@EQ_OldID,@int1,@int2,@int3,@string1,@string2,@string3,@string4,@string5,@date1,@date2,@date3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@QT_ID", SqlDbType.Int,4),
					new SqlParameter("@EQ_Difficulty", SqlDbType.Int,4),
					new SqlParameter("@EQ_Type", SqlDbType.Int,4),
					new SqlParameter("@EQ_Stem", SqlDbType.NVarChar,-1),
					new SqlParameter("@EQ_StemAccessory", SqlDbType.NVarChar,1000),
					new SqlParameter("@QO_ID", SqlDbType.NVarChar,1000),
					new SqlParameter("@EQ_Classify", SqlDbType.Int,4),
					new SqlParameter("@EQ_AnswerNumber", SqlDbType.Int,4),
					new SqlParameter("@EQ_Kind", SqlDbType.Int,4),
					new SqlParameter("@EQ_Share", SqlDbType.Int,4),
					new SqlParameter("@EQ_Creater", SqlDbType.Int,4),
					new SqlParameter("@EQ_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@EQ_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@EQ_OldID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,100),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime)};
			parameters[0].Value = model.EQ_Name;
			parameters[1].Value = model.QT_ID;
			parameters[2].Value = model.EQ_Difficulty;
			parameters[3].Value = model.EQ_Type;
			parameters[4].Value = model.EQ_Stem;
			parameters[5].Value = model.EQ_StemAccessory;
			parameters[6].Value = model.QO_ID;
			parameters[7].Value = model.EQ_Classify;
			parameters[8].Value = model.EQ_AnswerNumber;
			parameters[9].Value = model.EQ_Kind;
			parameters[10].Value = model.EQ_Share;
			parameters[11].Value = model.EQ_Creater;
			parameters[12].Value = model.EQ_CreateTime;
			parameters[13].Value = model.EQ_ModifyTime;
			parameters[14].Value = model.EQ_OldID;
			parameters[15].Value = model.int1;
			parameters[16].Value = model.int2;
			parameters[17].Value = model.int3;
			parameters[18].Value = model.string1;
			parameters[19].Value = model.string2;
			parameters[20].Value = model.string3;
			parameters[21].Value = model.string4;
			parameters[22].Value = model.string5;
			parameters[23].Value = model.date1;
			parameters[24].Value = model.date2;
			parameters[25].Value = model.date3;

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
		public bool Update(Tellyes.Model.ExamQuestionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExamQuestionInfo set ");
			strSql.Append("EQ_Name=@EQ_Name,");
			strSql.Append("QT_ID=@QT_ID,");
			strSql.Append("EQ_Difficulty=@EQ_Difficulty,");
			strSql.Append("EQ_Type=@EQ_Type,");
			strSql.Append("EQ_Stem=@EQ_Stem,");
			strSql.Append("EQ_StemAccessory=@EQ_StemAccessory,");
			strSql.Append("QO_ID=@QO_ID,");
			strSql.Append("EQ_Classify=@EQ_Classify,");
			strSql.Append("EQ_AnswerNumber=@EQ_AnswerNumber,");
			strSql.Append("EQ_Kind=@EQ_Kind,");
			strSql.Append("EQ_Share=@EQ_Share,");
			strSql.Append("EQ_Creater=@EQ_Creater,");
			strSql.Append("EQ_CreateTime=@EQ_CreateTime,");
			strSql.Append("EQ_ModifyTime=@EQ_ModifyTime,");
			strSql.Append("EQ_OldID=@EQ_OldID,");
			strSql.Append("int1=@int1,");
			strSql.Append("int2=@int2,");
			strSql.Append("int3=@int3,");
			strSql.Append("string1=@string1,");
			strSql.Append("string2=@string2,");
			strSql.Append("string3=@string3,");
			strSql.Append("string4=@string4,");
			strSql.Append("string5=@string5,");
			strSql.Append("date1=@date1,");
			strSql.Append("date2=@date2,");
			strSql.Append("date3=@date3");
			strSql.Append(" where EQ_ID=@EQ_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@QT_ID", SqlDbType.Int,4),
					new SqlParameter("@EQ_Difficulty", SqlDbType.Int,4),
					new SqlParameter("@EQ_Type", SqlDbType.Int,4),
					new SqlParameter("@EQ_Stem", SqlDbType.NVarChar,-1),
					new SqlParameter("@EQ_StemAccessory", SqlDbType.NVarChar,1000),
					new SqlParameter("@QO_ID", SqlDbType.NVarChar,1000),
					new SqlParameter("@EQ_Classify", SqlDbType.Int,4),
					new SqlParameter("@EQ_AnswerNumber", SqlDbType.Int,4),
					new SqlParameter("@EQ_Kind", SqlDbType.Int,4),
					new SqlParameter("@EQ_Share", SqlDbType.Int,4),
					new SqlParameter("@EQ_Creater", SqlDbType.Int,4),
					new SqlParameter("@EQ_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@EQ_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@EQ_OldID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,100),
					new SqlParameter("@string3", SqlDbType.NVarChar,100),
					new SqlParameter("@string4", SqlDbType.NVarChar,2000),
					new SqlParameter("@string5", SqlDbType.NVarChar,2000),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@EQ_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.EQ_Name;
			parameters[1].Value = model.QT_ID;
			parameters[2].Value = model.EQ_Difficulty;
			parameters[3].Value = model.EQ_Type;
			parameters[4].Value = model.EQ_Stem;
			parameters[5].Value = model.EQ_StemAccessory;
			parameters[6].Value = model.QO_ID;
			parameters[7].Value = model.EQ_Classify;
			parameters[8].Value = model.EQ_AnswerNumber;
			parameters[9].Value = model.EQ_Kind;
			parameters[10].Value = model.EQ_Share;
			parameters[11].Value = model.EQ_Creater;
			parameters[12].Value = model.EQ_CreateTime;
			parameters[13].Value = model.EQ_ModifyTime;
			parameters[14].Value = model.EQ_OldID;
			parameters[15].Value = model.int1;
			parameters[16].Value = model.int2;
			parameters[17].Value = model.int3;
			parameters[18].Value = model.string1;
			parameters[19].Value = model.string2;
			parameters[20].Value = model.string3;
			parameters[21].Value = model.string4;
			parameters[22].Value = model.string5;
			parameters[23].Value = model.date1;
			parameters[24].Value = model.date2;
			parameters[25].Value = model.date3;
			parameters[26].Value = model.EQ_ID;

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
		public bool Delete(int EQ_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamQuestionInfo ");
			strSql.Append(" where EQ_ID=@EQ_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = EQ_ID;

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
		public bool DeleteList(string EQ_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExamQuestionInfo ");
			strSql.Append(" where EQ_ID in ("+EQ_IDlist + ")  ");
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
		public Tellyes.Model.ExamQuestionInfo GetModel(int EQ_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EQ_ID,EQ_Name,QT_ID,EQ_Difficulty,EQ_Type,EQ_Stem,EQ_StemAccessory,QO_ID,EQ_Classify,EQ_AnswerNumber,EQ_Kind,EQ_Share,EQ_Creater,EQ_CreateTime,EQ_ModifyTime,EQ_OldID,int1,int2,int3,string1,string2,string3,string4,string5,date1,date2,date3 from ExamQuestionInfo ");
			strSql.Append(" where EQ_ID=@EQ_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EQ_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = EQ_ID;

			Tellyes.Model.ExamQuestionInfo model=new Tellyes.Model.ExamQuestionInfo();
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
		public Tellyes.Model.ExamQuestionInfo DataRowToModel(DataRow row)
		{
			Tellyes.Model.ExamQuestionInfo model=new Tellyes.Model.ExamQuestionInfo();
			if (row != null)
			{
				if(row["EQ_ID"]!=null && row["EQ_ID"].ToString()!="")
				{
					model.EQ_ID=int.Parse(row["EQ_ID"].ToString());
				}
				if(row["EQ_Name"]!=null)
				{
					model.EQ_Name=row["EQ_Name"].ToString();
				}
				if(row["QT_ID"]!=null && row["QT_ID"].ToString()!="")
				{
					model.QT_ID=int.Parse(row["QT_ID"].ToString());
				}
				if(row["EQ_Difficulty"]!=null && row["EQ_Difficulty"].ToString()!="")
				{
					model.EQ_Difficulty=int.Parse(row["EQ_Difficulty"].ToString());
				}
				if(row["EQ_Type"]!=null && row["EQ_Type"].ToString()!="")
				{
					model.EQ_Type=int.Parse(row["EQ_Type"].ToString());
				}
				if(row["EQ_Stem"]!=null)
				{
					model.EQ_Stem=row["EQ_Stem"].ToString();
				}
				if(row["EQ_StemAccessory"]!=null)
				{
					model.EQ_StemAccessory=row["EQ_StemAccessory"].ToString();
				}
				if(row["QO_ID"]!=null)
				{
					model.QO_ID=row["QO_ID"].ToString();
				}
				if(row["EQ_Classify"]!=null && row["EQ_Classify"].ToString()!="")
				{
					model.EQ_Classify=int.Parse(row["EQ_Classify"].ToString());
				}
				if(row["EQ_AnswerNumber"]!=null && row["EQ_AnswerNumber"].ToString()!="")
				{
					model.EQ_AnswerNumber=int.Parse(row["EQ_AnswerNumber"].ToString());
				}
				if(row["EQ_Kind"]!=null && row["EQ_Kind"].ToString()!="")
				{
					model.EQ_Kind=int.Parse(row["EQ_Kind"].ToString());
				}
				if(row["EQ_Share"]!=null && row["EQ_Share"].ToString()!="")
				{
					model.EQ_Share=int.Parse(row["EQ_Share"].ToString());
				}
				if(row["EQ_Creater"]!=null && row["EQ_Creater"].ToString()!="")
				{
					model.EQ_Creater=int.Parse(row["EQ_Creater"].ToString());
				}
				if(row["EQ_CreateTime"]!=null && row["EQ_CreateTime"].ToString()!="")
				{
					model.EQ_CreateTime=DateTime.Parse(row["EQ_CreateTime"].ToString());
				}
				if(row["EQ_ModifyTime"]!=null && row["EQ_ModifyTime"].ToString()!="")
				{
					model.EQ_ModifyTime=DateTime.Parse(row["EQ_ModifyTime"].ToString());
				}
				if(row["EQ_OldID"]!=null && row["EQ_OldID"].ToString()!="")
				{
					model.EQ_OldID=int.Parse(row["EQ_OldID"].ToString());
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
			strSql.Append("select EQ_ID,EQ_Name,QT_ID,EQ_Difficulty,EQ_Type,EQ_Stem,EQ_StemAccessory,QO_ID,EQ_Classify,EQ_AnswerNumber,EQ_Kind,EQ_Share,EQ_Creater,EQ_CreateTime,EQ_ModifyTime,EQ_OldID,int1,int2,int3,string1,string2,string3,string4,string5,date1,date2,date3 ");
			strSql.Append(" FROM ExamQuestionInfo ");
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
			strSql.Append(" EQ_ID,EQ_Name,QT_ID,EQ_Difficulty,EQ_Type,EQ_Stem,EQ_StemAccessory,QO_ID,EQ_Classify,EQ_AnswerNumber,EQ_Kind,EQ_Share,EQ_Creater,EQ_CreateTime,EQ_ModifyTime,EQ_OldID,int1,int2,int3,string1,string2,string3,string4,string5,date1,date2,date3 ");
			strSql.Append(" FROM ExamQuestionInfo ");
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
			strSql.Append("select count(1) FROM ExamQuestionInfo ");
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
				strSql.Append("order by T.EQ_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ExamQuestionInfo T ");
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
			parameters[0].Value = "ExamQuestionInfo";
			parameters[1].Value = "EQ_ID";
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
        /// 根据试题名称查找试题
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetExamQuestionByName(string name)
        {
            string strSql = string.Format("select * from [ExamQuestionInfo] where EQ_Name = '{0}'", name);
            return DbHelperSQL.Query(strSql);
        }

		#endregion  ExtensionMethod
	}
}

