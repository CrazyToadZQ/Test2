using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using NHibernate.Criterion;
using Tellyes.Log4Net;
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:Reservation
	/// </summary>
	public partial class Reservation : BaseDAL<Model.Reservation>
	{
		public Reservation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReservationID", "Reservation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReservationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Reservation");
			strSql.Append(" where ReservationID=@ReservationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReservationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.Reservation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Reservation(");
			strSql.Append("ReservationCode,ReservationType,ReservationName,EnityID,ReservationStartTime,ReservationEndTime,Remark,IsExamine,ExamineState,ExamineMessage,ApplyUserInfoID,ApplyRoleName,ApplyUserInfoTureName,ExamineUserInfoID,ExamineRoleName,ExamineUserInfoTrueName,ApplyDatetime,ExamineDatetime,ReservationNumber1,ReservationNumber2,ReservationNumber3,ReservationNumber4,ReservationNumber5,ReservationNumber6,ReservationNumber7,ReservationNumber8,ReservationString1,ReservationString2,ReservationString3,ReservationString4,ReservationString5,ReservationString6,ReservationString7,ReservationString8,ReservationDatetime1,ReservationDatetime2,ReservationDatetime3,ReservationDatetime4)");
			strSql.Append(" values (");
			strSql.Append("@ReservationCode,@ReservationType,@ReservationName,@EnityID,@ReservationStartTime,@ReservationEndTime,@Remark,@IsExamine,@ExamineState,@ExamineMessage,@ApplyUserInfoID,@ApplyRoleName,@ApplyUserInfoTureName,@ExamineUserInfoID,@ExamineRoleName,@ExamineUserInfoTrueName,@ApplyDatetime,@ExamineDatetime,@ReservationNumber1,@ReservationNumber2,@ReservationNumber3,@ReservationNumber4,@ReservationNumber5,@ReservationNumber6,@ReservationNumber7,@ReservationNumber8,@ReservationString1,@ReservationString2,@ReservationString3,@ReservationString4,@ReservationString5,@ReservationString6,@ReservationString7,@ReservationString8,@ReservationDatetime1,@ReservationDatetime2,@ReservationDatetime3,@ReservationDatetime4)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationCode", SqlDbType.VarChar,20),
					new SqlParameter("@ReservationType", SqlDbType.VarChar,20),
					new SqlParameter("@ReservationName", SqlDbType.VarChar,50),
					new SqlParameter("@EnityID", SqlDbType.Int,4),
					new SqlParameter("@ReservationStartTime", SqlDbType.DateTime),
					new SqlParameter("@ReservationEndTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@IsExamine", SqlDbType.Int,4),
					new SqlParameter("@ExamineState", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineMessage", SqlDbType.VarChar,200),
					new SqlParameter("@ApplyUserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ApplyRoleName", SqlDbType.VarChar,20),
					new SqlParameter("@ApplyUserInfoTureName", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineUserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ExamineRoleName", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineUserInfoTrueName", SqlDbType.VarChar,20),
					new SqlParameter("@ApplyDatetime", SqlDbType.DateTime),
					new SqlParameter("@ExamineDatetime", SqlDbType.DateTime),
					new SqlParameter("@ReservationNumber1", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber2", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber3", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber4", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber5", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber6", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationNumber7", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationNumber8", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationString1", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString2", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString3", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString4", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString5", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString6", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString7", SqlDbType.VarChar,-1),
					new SqlParameter("@ReservationString8", SqlDbType.VarChar,-1),
					new SqlParameter("@ReservationDatetime1", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime2", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime3", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime4", SqlDbType.DateTime)};
			parameters[0].Value = model.ReservationCode;
			parameters[1].Value = model.ReservationType;
			parameters[2].Value = model.ReservationName;
			parameters[3].Value = model.EnityID;
			parameters[4].Value = model.ReservationStartTime;
			parameters[5].Value = model.ReservationEndTime;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.IsExamine;
			parameters[8].Value = model.ExamineState;
			parameters[9].Value = model.ExamineMessage;
			parameters[10].Value = model.ApplyUserInfoID;
			parameters[11].Value = model.ApplyRoleName;
			parameters[12].Value = model.ApplyUserInfoTureName;
			parameters[13].Value = model.ExamineUserInfoID;
			parameters[14].Value = model.ExamineRoleName;
			parameters[15].Value = model.ExamineUserInfoTrueName;
			parameters[16].Value = model.ApplyDatetime;
			parameters[17].Value = model.ExamineDatetime;
			parameters[18].Value = model.ReservationNumber1;
			parameters[19].Value = model.ReservationNumber2;
			parameters[20].Value = model.ReservationNumber3;
			parameters[21].Value = model.ReservationNumber4;
			parameters[22].Value = model.ReservationNumber5;
			parameters[23].Value = model.ReservationNumber6;
			parameters[24].Value = model.ReservationNumber7;
			parameters[25].Value = model.ReservationNumber8;
			parameters[26].Value = model.ReservationString1;
			parameters[27].Value = model.ReservationString2;
			parameters[28].Value = model.ReservationString3;
			parameters[29].Value = model.ReservationString4;
			parameters[30].Value = model.ReservationString5;
			parameters[31].Value = model.ReservationString6;
			parameters[32].Value = model.ReservationString7;
			parameters[33].Value = model.ReservationString8;
			parameters[34].Value = model.ReservationDatetime1;
			parameters[35].Value = model.ReservationDatetime2;
			parameters[36].Value = model.ReservationDatetime3;
			parameters[37].Value = model.ReservationDatetime4;

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
		public bool Update(Tellyes.Model.Reservation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Reservation set ");
			strSql.Append("ReservationCode=@ReservationCode,");
			strSql.Append("ReservationType=@ReservationType,");
			strSql.Append("ReservationName=@ReservationName,");
			strSql.Append("EnityID=@EnityID,");
			strSql.Append("ReservationStartTime=@ReservationStartTime,");
			strSql.Append("ReservationEndTime=@ReservationEndTime,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsExamine=@IsExamine,");
			strSql.Append("ExamineState=@ExamineState,");
			strSql.Append("ExamineMessage=@ExamineMessage,");
			strSql.Append("ApplyUserInfoID=@ApplyUserInfoID,");
			strSql.Append("ApplyRoleName=@ApplyRoleName,");
			strSql.Append("ApplyUserInfoTureName=@ApplyUserInfoTureName,");
			strSql.Append("ExamineUserInfoID=@ExamineUserInfoID,");
			strSql.Append("ExamineRoleName=@ExamineRoleName,");
			strSql.Append("ExamineUserInfoTrueName=@ExamineUserInfoTrueName,");
			strSql.Append("ApplyDatetime=@ApplyDatetime,");
			strSql.Append("ExamineDatetime=@ExamineDatetime,");
			strSql.Append("ReservationNumber1=@ReservationNumber1,");
			strSql.Append("ReservationNumber2=@ReservationNumber2,");
			strSql.Append("ReservationNumber3=@ReservationNumber3,");
			strSql.Append("ReservationNumber4=@ReservationNumber4,");
			strSql.Append("ReservationNumber5=@ReservationNumber5,");
			strSql.Append("ReservationNumber6=@ReservationNumber6,");
			strSql.Append("ReservationNumber7=@ReservationNumber7,");
			strSql.Append("ReservationNumber8=@ReservationNumber8,");
			strSql.Append("ReservationString1=@ReservationString1,");
			strSql.Append("ReservationString2=@ReservationString2,");
			strSql.Append("ReservationString3=@ReservationString3,");
			strSql.Append("ReservationString4=@ReservationString4,");
			strSql.Append("ReservationString5=@ReservationString5,");
			strSql.Append("ReservationString6=@ReservationString6,");
			strSql.Append("ReservationString7=@ReservationString7,");
			strSql.Append("ReservationString8=@ReservationString8,");
			strSql.Append("ReservationDatetime1=@ReservationDatetime1,");
			strSql.Append("ReservationDatetime2=@ReservationDatetime2,");
			strSql.Append("ReservationDatetime3=@ReservationDatetime3,");
			strSql.Append("ReservationDatetime4=@ReservationDatetime4");
			strSql.Append(" where ReservationID=@ReservationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationCode", SqlDbType.VarChar,20),
					new SqlParameter("@ReservationType", SqlDbType.VarChar,20),
					new SqlParameter("@ReservationName", SqlDbType.VarChar,50),
					new SqlParameter("@EnityID", SqlDbType.Int,4),
					new SqlParameter("@ReservationStartTime", SqlDbType.DateTime),
					new SqlParameter("@ReservationEndTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@IsExamine", SqlDbType.Int,4),
					new SqlParameter("@ExamineState", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineMessage", SqlDbType.VarChar,200),
					new SqlParameter("@ApplyUserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ApplyRoleName", SqlDbType.VarChar,20),
					new SqlParameter("@ApplyUserInfoTureName", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineUserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ExamineRoleName", SqlDbType.VarChar,20),
					new SqlParameter("@ExamineUserInfoTrueName", SqlDbType.VarChar,20),
					new SqlParameter("@ApplyDatetime", SqlDbType.DateTime),
					new SqlParameter("@ExamineDatetime", SqlDbType.DateTime),
					new SqlParameter("@ReservationNumber1", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber2", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber3", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber4", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber5", SqlDbType.Int,4),
					new SqlParameter("@ReservationNumber6", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationNumber7", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationNumber8", SqlDbType.Decimal,13),
					new SqlParameter("@ReservationString1", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString2", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString3", SqlDbType.VarChar,50),
					new SqlParameter("@ReservationString4", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString5", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString6", SqlDbType.VarChar,200),
					new SqlParameter("@ReservationString7", SqlDbType.VarChar,-1),
					new SqlParameter("@ReservationString8", SqlDbType.VarChar,-1),
					new SqlParameter("@ReservationDatetime1", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime2", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime3", SqlDbType.DateTime),
					new SqlParameter("@ReservationDatetime4", SqlDbType.DateTime),
					new SqlParameter("@ReservationID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReservationCode;
			parameters[1].Value = model.ReservationType;
			parameters[2].Value = model.ReservationName;
			parameters[3].Value = model.EnityID;
			parameters[4].Value = model.ReservationStartTime;
			parameters[5].Value = model.ReservationEndTime;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.IsExamine;
			parameters[8].Value = model.ExamineState;
			parameters[9].Value = model.ExamineMessage;
			parameters[10].Value = model.ApplyUserInfoID;
			parameters[11].Value = model.ApplyRoleName;
			parameters[12].Value = model.ApplyUserInfoTureName;
			parameters[13].Value = model.ExamineUserInfoID;
			parameters[14].Value = model.ExamineRoleName;
			parameters[15].Value = model.ExamineUserInfoTrueName;
			parameters[16].Value = model.ApplyDatetime;
			parameters[17].Value = model.ExamineDatetime;
			parameters[18].Value = model.ReservationNumber1;
			parameters[19].Value = model.ReservationNumber2;
			parameters[20].Value = model.ReservationNumber3;
			parameters[21].Value = model.ReservationNumber4;
			parameters[22].Value = model.ReservationNumber5;
			parameters[23].Value = model.ReservationNumber6;
			parameters[24].Value = model.ReservationNumber7;
			parameters[25].Value = model.ReservationNumber8;
			parameters[26].Value = model.ReservationString1;
			parameters[27].Value = model.ReservationString2;
			parameters[28].Value = model.ReservationString3;
			parameters[29].Value = model.ReservationString4;
			parameters[30].Value = model.ReservationString5;
			parameters[31].Value = model.ReservationString6;
			parameters[32].Value = model.ReservationString7;
			parameters[33].Value = model.ReservationString8;
			parameters[34].Value = model.ReservationDatetime1;
			parameters[35].Value = model.ReservationDatetime2;
			parameters[36].Value = model.ReservationDatetime3;
			parameters[37].Value = model.ReservationDatetime4;
			parameters[38].Value = model.ReservationID;

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
		public bool Delete(int ReservationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reservation ");
			strSql.Append(" where ReservationID=@ReservationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReservationID;

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
		public bool DeleteList(string ReservationIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reservation ");
			strSql.Append(" where ReservationID in ("+ReservationIDlist + ")  ");
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
		public Tellyes.Model.Reservation GetModel(int ReservationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReservationID,ReservationCode,ReservationType,ReservationName,EnityID,ReservationStartTime,ReservationEndTime,Remark,IsExamine,ExamineState,ExamineMessage,ApplyUserInfoID,ApplyRoleName,ApplyUserInfoTureName,ExamineUserInfoID,ExamineRoleName,ExamineUserInfoTrueName,ApplyDatetime,ExamineDatetime,ReservationNumber1,ReservationNumber2,ReservationNumber3,ReservationNumber4,ReservationNumber5,ReservationNumber6,ReservationNumber7,ReservationNumber8,ReservationString1,ReservationString2,ReservationString3,ReservationString4,ReservationString5,ReservationString6,ReservationString7,ReservationString8,ReservationDatetime1,ReservationDatetime2,ReservationDatetime3,ReservationDatetime4 from Reservation ");
			strSql.Append(" where ReservationID=@ReservationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReservationID;

			Tellyes.Model.Reservation model=new Tellyes.Model.Reservation();
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
		public Tellyes.Model.Reservation DataRowToModel(DataRow row)
		{
			Tellyes.Model.Reservation model=new Tellyes.Model.Reservation();
			if (row != null)
			{
				if(row["ReservationID"]!=null && row["ReservationID"].ToString()!="")
				{
					model.ReservationID=int.Parse(row["ReservationID"].ToString());
				}
				if(row["ReservationCode"]!=null)
				{
					model.ReservationCode=row["ReservationCode"].ToString();
				}
				if(row["ReservationType"]!=null)
				{
					model.ReservationType=row["ReservationType"].ToString();
				}
				if(row["ReservationName"]!=null)
				{
					model.ReservationName=row["ReservationName"].ToString();
				}
				if(row["EnityID"]!=null && row["EnityID"].ToString()!="")
				{
					model.EnityID=row["EnityID"].ToString();
				}
				if(row["ReservationStartTime"]!=null && row["ReservationStartTime"].ToString()!="")
				{
					model.ReservationStartTime=DateTime.Parse(row["ReservationStartTime"].ToString());
				}
				if(row["ReservationEndTime"]!=null && row["ReservationEndTime"].ToString()!="")
				{
					model.ReservationEndTime=DateTime.Parse(row["ReservationEndTime"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["IsExamine"]!=null && row["IsExamine"].ToString()!="")
				{
					model.IsExamine=int.Parse(row["IsExamine"].ToString());
				}
				if(row["ExamineState"]!=null)
				{
					model.ExamineState=row["ExamineState"].ToString();
				}
				if(row["ExamineMessage"]!=null)
				{
					model.ExamineMessage=row["ExamineMessage"].ToString();
				}
				if(row["ApplyUserInfoID"]!=null && row["ApplyUserInfoID"].ToString()!="")
				{
					model.ApplyUserInfoID=int.Parse(row["ApplyUserInfoID"].ToString());
				}
				if(row["ApplyRoleName"]!=null)
				{
					model.ApplyRoleName=row["ApplyRoleName"].ToString();
				}
				if(row["ApplyUserInfoTureName"]!=null)
				{
					model.ApplyUserInfoTureName=row["ApplyUserInfoTureName"].ToString();
				}
				if(row["ExamineUserInfoID"]!=null && row["ExamineUserInfoID"].ToString()!="")
				{
					model.ExamineUserInfoID=int.Parse(row["ExamineUserInfoID"].ToString());
				}
				if(row["ExamineRoleName"]!=null)
				{
					model.ExamineRoleName=row["ExamineRoleName"].ToString();
				}
				if(row["ExamineUserInfoTrueName"]!=null)
				{
					model.ExamineUserInfoTrueName=row["ExamineUserInfoTrueName"].ToString();
				}
				if(row["ApplyDatetime"]!=null && row["ApplyDatetime"].ToString()!="")
				{
					model.ApplyDatetime=DateTime.Parse(row["ApplyDatetime"].ToString());
				}
				if(row["ExamineDatetime"]!=null && row["ExamineDatetime"].ToString()!="")
				{
					model.ExamineDatetime=DateTime.Parse(row["ExamineDatetime"].ToString());
				}
				if(row["ReservationNumber1"]!=null && row["ReservationNumber1"].ToString()!="")
				{
					model.ReservationNumber1=int.Parse(row["ReservationNumber1"].ToString());
				}
				if(row["ReservationNumber2"]!=null && row["ReservationNumber2"].ToString()!="")
				{
					model.ReservationNumber2=int.Parse(row["ReservationNumber2"].ToString());
				}
				if(row["ReservationNumber3"]!=null && row["ReservationNumber3"].ToString()!="")
				{
					model.ReservationNumber3=int.Parse(row["ReservationNumber3"].ToString());
				}
				if(row["ReservationNumber4"]!=null && row["ReservationNumber4"].ToString()!="")
				{
					model.ReservationNumber4=int.Parse(row["ReservationNumber4"].ToString());
				}
				if(row["ReservationNumber5"]!=null && row["ReservationNumber5"].ToString()!="")
				{
					model.ReservationNumber5=int.Parse(row["ReservationNumber5"].ToString());
				}
				if(row["ReservationNumber6"]!=null && row["ReservationNumber6"].ToString()!="")
				{
					model.ReservationNumber6=decimal.Parse(row["ReservationNumber6"].ToString());
				}
				if(row["ReservationNumber7"]!=null && row["ReservationNumber7"].ToString()!="")
				{
					model.ReservationNumber7=decimal.Parse(row["ReservationNumber7"].ToString());
				}
				if(row["ReservationNumber8"]!=null && row["ReservationNumber8"].ToString()!="")
				{
					model.ReservationNumber8=decimal.Parse(row["ReservationNumber8"].ToString());
				}
				if(row["ReservationString1"]!=null)
				{
					model.ReservationString1=row["ReservationString1"].ToString();
				}
				if(row["ReservationString2"]!=null)
				{
					model.ReservationString2=row["ReservationString2"].ToString();
				}
				if(row["ReservationString3"]!=null)
				{
					model.ReservationString3=row["ReservationString3"].ToString();
				}
				if(row["ReservationString4"]!=null)
				{
					model.ReservationString4=row["ReservationString4"].ToString();
				}
				if(row["ReservationString5"]!=null)
				{
					model.ReservationString5=row["ReservationString5"].ToString();
				}
				if(row["ReservationString6"]!=null)
				{
					model.ReservationString6=row["ReservationString6"].ToString();
				}
				if(row["ReservationString7"]!=null)
				{
					model.ReservationString7=row["ReservationString7"].ToString();
				}
				if(row["ReservationString8"]!=null)
				{
					model.ReservationString8=row["ReservationString8"].ToString();
				}
				if(row["ReservationDatetime1"]!=null && row["ReservationDatetime1"].ToString()!="")
				{
					model.ReservationDatetime1=DateTime.Parse(row["ReservationDatetime1"].ToString());
				}
				if(row["ReservationDatetime2"]!=null && row["ReservationDatetime2"].ToString()!="")
				{
					model.ReservationDatetime2=DateTime.Parse(row["ReservationDatetime2"].ToString());
				}
				if(row["ReservationDatetime3"]!=null && row["ReservationDatetime3"].ToString()!="")
				{
					model.ReservationDatetime3=DateTime.Parse(row["ReservationDatetime3"].ToString());
				}
				if(row["ReservationDatetime4"]!=null && row["ReservationDatetime4"].ToString()!="")
				{
					model.ReservationDatetime4=DateTime.Parse(row["ReservationDatetime4"].ToString());
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
			strSql.Append("select ReservationID,ReservationCode,ReservationType,ReservationName,EnityID,ReservationStartTime,ReservationEndTime,Remark,IsExamine,ExamineState,ExamineMessage,ApplyUserInfoID,ApplyRoleName,ApplyUserInfoTureName,ExamineUserInfoID,ExamineRoleName,ExamineUserInfoTrueName,ApplyDatetime,ExamineDatetime,ReservationNumber1,ReservationNumber2,ReservationNumber3,ReservationNumber4,ReservationNumber5,ReservationNumber6,ReservationNumber7,ReservationNumber8,ReservationString1,ReservationString2,ReservationString3,ReservationString4,ReservationString5,ReservationString6,ReservationString7,ReservationString8,ReservationDatetime1,ReservationDatetime2,ReservationDatetime3,ReservationDatetime4 ");
			strSql.Append(" FROM Reservation ");
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
			strSql.Append(" ReservationID,ReservationCode,ReservationType,ReservationName,EnityID,ReservationStartTime,ReservationEndTime,Remark,IsExamine,ExamineState,ExamineMessage,ApplyUserInfoID,ApplyRoleName,ApplyUserInfoTureName,ExamineUserInfoID,ExamineRoleName,ExamineUserInfoTrueName,ApplyDatetime,ExamineDatetime,ReservationNumber1,ReservationNumber2,ReservationNumber3,ReservationNumber4,ReservationNumber5,ReservationNumber6,ReservationNumber7,ReservationNumber8,ReservationString1,ReservationString2,ReservationString3,ReservationString4,ReservationString5,ReservationString6,ReservationString7,ReservationString8,ReservationDatetime1,ReservationDatetime2,ReservationDatetime3,ReservationDatetime4 ");
			strSql.Append(" FROM Reservation ");
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
			strSql.Append("select count(1) FROM Reservation ");
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
				strSql.Append("order by T.ReservationID desc");
			}
			strSql.Append(")AS Row, T.*  from Reservation T ");
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
			parameters[0].Value = "Reservation";
			parameters[1].Value = "ReservationID";
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
        /// 获得有申请的起始日期
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static DataTable GetReservationCalenderDataByTimeCondition(string startDate, string endDate,string otherSqlCondition=null)
        {
            StringBuilder sql = new StringBuilder( " select distinct CONVERT(nvarchar(10),ReservationStartTime,102) from dbo.Reservation where ReservationStartTime between '" + startDate + "' and '" + endDate + "' ");
            addOtherSqlCondition(sql, otherSqlCondition);
            sql.Append(" ; ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        private static void addOtherSqlCondition(StringBuilder sql,string otherSqlCondition) 
        {
            if (otherSqlCondition != null)
            {
                if (!otherSqlCondition.TrimStart().StartsWith("and"))
                {
                    sql.Append(" and ");
                }
                sql.Append(otherSqlCondition);
            }
        }

        /// <summary>
        /// 获得有申请的日期的分类统计
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByCondition(string startDate, string endDate, string others = null)
        {
            StringBuilder sql = new StringBuilder( " select CONVERT(nvarchar(10),ReservationStartTime,102),COUNT(ReservationCode),coalesce(ExamineState,0) from dbo.Reservation where ReservationStartTime between '" + startDate + "' and '" + endDate + "' ");
            addOtherSqlCondition(sql, others);
            sql.Append(" group by CONVERT(nvarchar(10),ReservationStartTime,102),ExamineState; ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 直接获取，带有详细时间的考试申请
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByConditionWithNoSum(string startDate, string endDate, string others = null)
        {
            StringBuilder sql = new StringBuilder(" select ReservationStartTime,1,coalesce(ExamineState,0),ReservationCode,ReservationEndTime from dbo.Reservation where ReservationStartTime between '" + startDate + "' and '" + endDate + "' ");
            addOtherSqlCondition(sql, others);
            sql.Append(" ; ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 生成测试数据
        /// </summary>
        public static void MockTestData()
        {
            DateTime old = DateTime.Now.AddMonths(-1);
            Random r = new Random();
            string sourceSql = "select * from Reservation;";
            DataTable source = DbHelperSQL.Query(sourceSql.ToString()).Tables[0];
            StringBuilder sql=new StringBuilder();
            int t;
            foreach(DataRow row in source.Rows)
            {
                t = r.Next(3);
                string startDate = old.ToString("yyyy-MM-dd");
                string enddate = old.AddDays(t).ToString("yyyy-MM-dd");
                sql.Append(" update Reservation set ReservationStartTime='" + startDate + "',ReservationEndTime='" + enddate + "' where ReservationID='" + row["ReservationID"].ToString().Trim() + "';");
                old = old.AddDays(1);
            }
            DbHelperSQL.ExecuteSql(sql.ToString());
        }

		#endregion  ExtensionMethod

        #region NHibernate Extension

        /// <summary>
        /// 根据预约ID及资源类型，获得冲突信息
        /// </summary>
        /// <returns></returns>
        public List<object[]> SelectClashedInfoByReservationIDAndResourceType(Dictionary<string, object> condition)
        {
            int ReservationID = Convert.ToInt32(condition["ReservationID"]);
            string ReservationType = condition["ReservationType"].ToString().Trim();

            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT ");
            sql.Append("    [TargetReservationResource].[Reservation_ID], ");
            sql.Append("    [Reservation].[ReservationName], ");
            sql.Append("    [TargetReservationResource].[ResourceID], ");
            sql.Append("    [ReservationTimeInfo].[ReservationTimeInfoDateInfo], ");
            sql.Append("    [ReservationTimeInfo].[StartTime], ");
            sql.Append("    [ReservationTimeInfo].[EndTime] ");
            sql.Append(" FROM ");
            sql.Append("    [ReservationResource] AS [CurrentReservationResource]  ");
            sql.Append("    INNER JOIN [ReservationResource] AS [TargetReservationResource] ");
            sql.Append("        ON [CurrentReservationResource].[Reservation_ID] <> [TargetReservationResource].[Reservation_ID] ");
            sql.Append("            AND [CurrentReservationResource].[Resource_Type] = [TargetReservationResource].[Resource_Type] ");
            sql.Append("            AND [CurrentReservationResource].[ResourceID] = [TargetReservationResource].[ResourceID] ");
            sql.Append("    INNER JOIN [Reservation] ");
            sql.Append("        ON [Reservation].[ReservationID] = [TargetReservationResource].[Reservation_ID]  ");
            sql.Append("            AND [Reservation].[IsExamine] = 1 ");
            sql.Append("            AND [Reservation].[ExamineState] = 1 ");
            sql.Append("    INNER JOIN ( ");
            sql.Append("        SELECT ");
            sql.Append("            [TargetReservationTimeInfo].[ReservationID], ");
            sql.Append("            [TargetReservationTimeInfo].[ReservationTimeInfoDateInfo], ");
            sql.Append("            CASE WHEN [CurrentReservationTimeInfo].[ReservationTimeInfoStartTime] > [TargetReservationTimeInfo].[ReservationTimeInfoStartTime] THEN [CurrentReservationTimeInfo].[ReservationTimeInfoStartTime] ELSE [TargetReservationTimeInfo].[ReservationTimeInfoStartTime] END AS [StartTime], ");
            sql.Append("            CASE WHEN [CurrentReservationTimeInfo].[ReservationTimeInfoEndTime] < [TargetReservationTimeInfo].[ReservationTimeInfoEndTime] THEN [CurrentReservationTimeInfo].[ReservationTimeInfoEndTime] ELSE [TargetReservationTimeInfo].[ReservationTimeInfoEndTime] END AS [EndTime] ");
            sql.Append("        FROM ");
            sql.Append("            [ReservationTimeInfo] AS [CurrentReservationTimeInfo] ");
            sql.Append("            INNER JOIN [ReservationTimeInfo] AS [TargetReservationTimeInfo] ");
            sql.Append("                ON [CurrentReservationTimeInfo].[ReservationID] <> [TargetReservationTimeInfo].[ReservationID] ");
            sql.Append("                    AND [CurrentReservationTimeInfo].[ReservationTimeInfoDateInfo] = [TargetReservationTimeInfo].[ReservationTimeInfoDateInfo] ");
            sql.Append("                    AND [CurrentReservationTimeInfo].[ReservationTimeInfoStartTime] < [TargetReservationTimeInfo].[ReservationTimeInfoEndTime] ");
            sql.Append("                    AND [CurrentReservationTimeInfo].[ReservationTimeInfoEndTime] > [TargetReservationTimeInfo].[ReservationTimeInfoStartTime] ");
            sql.Append("            INNER JOIN [Reservation]  ");
            sql.Append("                ON [Reservation].[ReservationID] = [TargetReservationTimeInfo].[ReservationID]  ");
            sql.Append("                    AND [Reservation].[IsExamine] = 1 ");
            sql.Append("                    AND [Reservation].[ExamineState] = 1 ");
            sql.Append("        WHERE ");
            sql.Append("            [CurrentReservationTimeInfo].[ReservationID] = :ReservationID ");
            sql.Append("    ) AS [ReservationTimeInfo] ");
            sql.Append("        ON [ReservationTimeInfo].[ReservationID] = [TargetReservationResource].[Reservation_ID] ");
            sql.Append(" WHERE ");
            sql.Append("    [CurrentReservationResource].[Reservation_ID] = :ReservationID ");
            sql.Append("    AND [CurrentReservationResource].[Resource_Type] = :ReservationType ");
            sql.Append(" ORDER BY ");
            sql.Append("    [TargetReservationResource].[Reservation_ID] ASC, ");
            sql.Append("    [ReservationTimeInfo].[ReservationTimeInfoDateInfo] ASC, ");
            sql.Append("    [ReservationTimeInfo].[StartTime] ASC ");

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("Reservation_ID", NHibernateUtil.Int32)
                    .AddScalar("ReservationName", NHibernateUtil.String)
                    .AddScalar("ResourceID", NHibernateUtil.String)
                    .AddScalar("ReservationTimeInfoDateInfo", NHibernateUtil.String)
                    .AddScalar("StartTime", NHibernateUtil.String)
                    .AddScalar("EndTime", NHibernateUtil.String);
                //设置查询参数
                iSQLQuery.SetInt32("ReservationID", ReservationID)
                    .SetString("ReservationType", ReservationType);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败，ReservationID：" + ReservationID.ToString().Trim(), e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据条件搜索参加考试的考生
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<object[]> SelectStudentInfoForReservation(Dictionary<string,object> condition) 
        {
            Guid eid = Guid.Parse(condition["E_ID,eq"].ToString().Trim());
            bool usePager = true;
            
            int pageIndex =0;
            if (condition.Keys.Contains("pageIndex"))
            {
                pageIndex = Convert.ToInt32(condition["pageIndex"].ToString().Trim());
            }
            else
            {
                usePager = false;
            }

            int pageSide = 0;
            if(condition.Keys.Contains("pageSide"))
            {
                pageSide = Convert.ToInt32(condition["pageSide"].ToString().Trim());
            }
            else
            {
                usePager = false;
            }

            StringBuilder sql = new StringBuilder();
            if (usePager)
            {
                sql.Append(" select * from ( ");
            }
            sql.Append(" select ");
            sql.Append("    u.*, ");
            sql.Append("    (select CONVERT(nvarchar(10), O_ID)+',' from UserOrganization where U_ID=u.U_ID for XML path('')) as O_ID_List ");
            if (usePager)
            {
                sql.Append("    ,ROW_NUMBER() over(order by u.U_TrueName) as rowIndex ");
            }
            sql.Append(" from ");
            sql.Append("    dbo.ExamStudent as eu ");
            sql.Append(" join dbo.UserInfo as u ");
            sql.Append("    on eu.U_ID=u.U_ID ");
            sql.Append(" where eu.E_ID=:E_ID ");
            if (condition.Keys.Contains("O_ID,in")) 
            {
                //班级
                if (((List<Int32>)condition["O_ID,in"]).Contains(-1))
                {
                    //包含未分配班级
                    sql.Append(" and  u.U_ID in (select U_ID from UserOrganization where O_ID in  (" + String.Join(",", (List<Int32>)condition["O_ID,in"]) + ") or O_ID is null)  "); 
                }
                else
                {
                    //不包含未分配班级
                    sql.Append(" and u.U_ID in (select U_ID from UserOrganization where O_ID in  (" + String.Join(",", (List<Int32>)condition["O_ID,in"]) + ")) "); 
                }
            }
            if (condition.Keys.Contains("U_Name,like")) 
            {
                //学号
                sql.Append(" and u.U_Name like '" + condition["U_Name,like"].ToString().Trim() + "%' ");             
            }
            if (condition.Keys.Contains("U_TrueName,like"))
            { 
                //姓名
                sql.Append(" and  u.U_TrueName like '%" + condition["U_TrueName,like"].ToString().Trim() + "%' ");             
            }
            if (usePager)
            {
                sql.Append(" ) as source ");
                sql.Append(" where source.rowIndex between " + (pageIndex * pageSide + 1) + " and " + (pageIndex * pageSide + pageSide) + " ");
            }

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Tellyes.Model.UserInfo))
                    .AddScalar("O_ID_List", NHibernateUtil.String);
                if (usePager)
                {
                    iSQLQuery.AddScalar("rowIndex", NHibernateUtil.Int32);
                }
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", eid);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询参加考试的考试用户信息失败，E_ID：" + eid.ToString().Trim(), e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }

        }

        /// <summary>
        /// 根据条件搜索参加考试的考生总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int? SelectStudentInfoTotalCount(Dictionary<string, object> condition)
        {
            Guid eid = Guid.Parse(condition["E_ID,eq"].ToString().Trim());

            StringBuilder sql = new StringBuilder();
            sql.Append(" select ");
            sql.Append("    COUNT(distinct u.U_ID) as totalExamstudentCount ");
            sql.Append(" from ");
            sql.Append("    dbo.ExamStudent as eu ");
            sql.Append(" join dbo.UserInfo as u ");
            sql.Append("    on eu.U_ID=u.U_ID ");
            sql.Append(" where eu.E_ID=:E_ID ");
            if (condition.Keys.Contains("O_ID,in"))
            {
                //班级
                if (((List<Int32>)condition["O_ID,in"]).Contains(-1))
                {
                    //包含未分配班级
                    sql.Append(" and  u.U_ID in (select U_ID from UserOrganization where O_ID in  (" + String.Join(",", (List<Int32>)condition["O_ID,in"]) + ") or O_ID is null)  ");
                }
                else
                {
                    //不包含未分配班级
                    sql.Append(" and u.U_ID in (select U_ID from UserOrganization where O_ID in  (" + String.Join(",", (List<Int32>)condition["O_ID,in"]) + ")) ");
                }
            }
            if (condition.Keys.Contains("U_Name,like"))
            {
                //学号
                sql.Append(" and u.U_Name like '" + condition["U_Name,like"].ToString().Trim() + "%' ");
            }
            if (condition.Keys.Contains("U_TrueName,like"))
            {
                //姓名
                sql.Append(" and  u.U_TrueName like '%" + condition["U_TrueName,like"].ToString().Trim() + "%' ");
            }

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("totalExamstudentCount", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", eid);
                //查询结果并返回
                return iSQLQuery.UniqueResult<int>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询参加考试的考试用户信息失败，E_ID：" + eid.ToString().Trim(), e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }

        #endregion

        
    }
}

