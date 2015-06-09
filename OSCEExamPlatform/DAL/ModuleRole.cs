using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Collections;
using System.Collections.Generic;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ModuleRole
	/// </summary>
	public partial class ModuleRole
	{
		public ModuleRole()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("M_ID", "ModuleRole"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int M_ID,int R_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ModuleRole");
			strSql.Append(" where M_ID=@M_ID and R_ID=@R_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4)			};
			parameters[0].Value = M_ID;
			parameters[1].Value = R_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.ModuleRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ModuleRole(");
			strSql.Append("M_ID,R_ID,MR_IsAdd,MR_IsDel,MR_IsUpd,MR_IsQue,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
			strSql.Append("@M_ID,@R_ID,@MR_IsAdd,@MR_IsDel,@MR_IsUpd,@MR_IsQue,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@MR_IsAdd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsDel", SqlDbType.Int,4),
					new SqlParameter("@MR_IsUpd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsQue", SqlDbType.Int,4),
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
			parameters[0].Value = model.M_ID;
			parameters[1].Value = model.R_ID;
			parameters[2].Value = model.MR_IsAdd;
			parameters[3].Value = model.MR_IsDel;
			parameters[4].Value = model.MR_IsUpd;
			parameters[5].Value = model.MR_IsQue;
			parameters[6].Value = model.int1;
			parameters[7].Value = model.int2;
			parameters[8].Value = model.int3;
			parameters[9].Value = model.string1;
			parameters[10].Value = model.string2;
			parameters[11].Value = model.string3;
			parameters[12].Value = model.date1;
			parameters[13].Value = model.date2;
			parameters[14].Value = model.date3;
			parameters[15].Value = model.float1;
			parameters[16].Value = model.float2;
			parameters[17].Value = model.float3;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.ModuleRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ModuleRole set ");
			strSql.Append("MR_IsAdd=@MR_IsAdd,");
			strSql.Append("MR_IsDel=@MR_IsDel,");
			strSql.Append("MR_IsUpd=@MR_IsUpd,");
			strSql.Append("MR_IsQue=@MR_IsQue,");
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
			strSql.Append(" where M_ID=@M_ID and R_ID=@R_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MR_IsAdd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsDel", SqlDbType.Int,4),
					new SqlParameter("@MR_IsUpd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsQue", SqlDbType.Int,4),
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
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MR_IsAdd;
			parameters[1].Value = model.MR_IsDel;
			parameters[2].Value = model.MR_IsUpd;
			parameters[3].Value = model.MR_IsQue;
			parameters[4].Value = model.int1;
			parameters[5].Value = model.int2;
			parameters[6].Value = model.int3;
			parameters[7].Value = model.string1;
			parameters[8].Value = model.string2;
			parameters[9].Value = model.string3;
			parameters[10].Value = model.date1;
			parameters[11].Value = model.date2;
			parameters[12].Value = model.date3;
			parameters[13].Value = model.float1;
			parameters[14].Value = model.float2;
			parameters[15].Value = model.float3;
			parameters[16].Value = model.M_ID;
			parameters[17].Value = model.R_ID;

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
		public bool Delete(int M_ID,int R_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ModuleRole ");
			strSql.Append(" where M_ID=@M_ID and R_ID=@R_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4)			};
			parameters[0].Value = M_ID;
			parameters[1].Value = R_ID;

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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ModuleRole ");
            strSql.Append(" where R_ID=@R_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4)			};
            parameters[0].Value = R_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public Tellyes.Model.ModuleRole GetModel(int M_ID,int R_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 M_ID,R_ID,MR_IsAdd,MR_IsDel,MR_IsUpd,MR_IsQue,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ModuleRole ");
			strSql.Append(" where M_ID=@M_ID and R_ID=@R_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4)			};
			parameters[0].Value = M_ID;
			parameters[1].Value = R_ID;

			Tellyes.Model.ModuleRole model=new Tellyes.Model.ModuleRole();
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
		public Tellyes.Model.ModuleRole DataRowToModel(DataRow row)
		{
			Tellyes.Model.ModuleRole model=new Tellyes.Model.ModuleRole();
			if (row != null)
			{
				if(row["M_ID"]!=null && row["M_ID"].ToString()!="")
				{
					model.M_ID=int.Parse(row["M_ID"].ToString());
				}
				if(row["R_ID"]!=null && row["R_ID"].ToString()!="")
				{
					model.R_ID=int.Parse(row["R_ID"].ToString());
				}
				if(row["MR_IsAdd"]!=null && row["MR_IsAdd"].ToString()!="")
				{
					model.MR_IsAdd=int.Parse(row["MR_IsAdd"].ToString());
				}
				if(row["MR_IsDel"]!=null && row["MR_IsDel"].ToString()!="")
				{
					model.MR_IsDel=int.Parse(row["MR_IsDel"].ToString());
				}
				if(row["MR_IsUpd"]!=null && row["MR_IsUpd"].ToString()!="")
				{
					model.MR_IsUpd=int.Parse(row["MR_IsUpd"].ToString());
				}
				if(row["MR_IsQue"]!=null && row["MR_IsQue"].ToString()!="")
				{
					model.MR_IsQue=int.Parse(row["MR_IsQue"].ToString());
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
			strSql.Append("select M_ID,R_ID,MR_IsAdd,MR_IsDel,MR_IsUpd,MR_IsQue,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM ModuleRole ");
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
			strSql.Append(" M_ID,R_ID,MR_IsAdd,MR_IsDel,MR_IsUpd,MR_IsQue,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM ModuleRole ");
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
			strSql.Append("select count(1) FROM ModuleRole ");
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
			strSql.Append(")AS Row, T.*  from ModuleRole T ");
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
			parameters[0].Value = "ModuleRole";
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

        /// <summary>
        /// 根据角色ID，获得模块ID的列表。
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public string getMidList(int rid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select M_ID from ModuleRole where R_ID=@R_ID");
            SqlParameter[] para = { new SqlParameter("@R_ID", SqlDbType.Int, 4) };
            para[0].Value = rid;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), para);
            string midList = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                midList += "'" + ds.Tables[0].Rows[i]["M_ID"] + "',";
            }
            return midList.Trim(new char[] { ',' });
        }

        /// <summary>
        /// 添加一个角色的所有权限（事务处理）
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="mids"></param>
        /// <returns></returns>
        public bool insertByTran(string rid,string mids)
        {
            List<CommandInfo> cmdList = new List<CommandInfo>();
            cmdList.Add(getDel(rid));
            string[] midArr = mids.Split(new char[] { ',' });
            for (int i = 0; i < midArr.Length; i++)
            {
                Model.ModuleRole mr = new Model.ModuleRole();
                mr.R_ID = int.Parse(rid);
                mr.M_ID = int.Parse(midArr[i]);
                mr.MR_IsAdd = mr.MR_IsDel = mr.MR_IsQue = mr.MR_IsUpd = 1;
                cmdList.Add(Insert(mr));
            }
            try
            {
                return DbHelperSQL.ExecuteSqlTran(cmdList) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CommandInfo Insert(Model.ModuleRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ModuleRole(");
            strSql.Append("M_ID,R_ID,MR_IsAdd,MR_IsDel,MR_IsUpd,MR_IsQue,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@M_ID,@R_ID,@MR_IsAdd,@MR_IsDel,@MR_IsUpd,@MR_IsQue,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            SqlParameter[] parameters = {
					new SqlParameter("@M_ID", SqlDbType.Int,4),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@MR_IsAdd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsDel", SqlDbType.Int,4),
					new SqlParameter("@MR_IsUpd", SqlDbType.Int,4),
					new SqlParameter("@MR_IsQue", SqlDbType.Int,4),
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
            parameters[0].Value = model.M_ID;
            parameters[1].Value = model.R_ID;
            parameters[2].Value = model.MR_IsAdd;
            parameters[3].Value = model.MR_IsDel;
            parameters[4].Value = model.MR_IsUpd;
            parameters[5].Value = model.MR_IsQue;
            parameters[6].Value = model.int1;
            parameters[7].Value = model.int2;
            parameters[8].Value = model.int3;
            parameters[9].Value = model.string1;
            parameters[10].Value = model.string2;
            parameters[11].Value = model.string3;
            parameters[12].Value = model.date1;
            parameters[13].Value = model.date2;
            parameters[14].Value = model.date3;
            parameters[15].Value = model.float1;
            parameters[16].Value = model.float2;
            parameters[17].Value = model.float3;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        private CommandInfo getDel(string rid)
        {
            string sql = "delete from ModuleRole where R_ID=@R_ID";
            SqlParameter[] para = { new SqlParameter("@R_ID", SqlDbType.Int, 4) };
            para[0].Value = int.Parse(rid);
            return new CommandInfo(sql, para, EffentNextType.None);
        }

		#endregion  ExtensionMethod
	}
}

