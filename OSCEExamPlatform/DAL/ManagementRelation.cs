using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using Tellyes.Log4Net;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:ManagementRelation
	/// </summary>
	public partial class ManagementRelation : BaseDAL<Model.ManagementRelation>
	{
		public ManagementRelation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ManagementRelation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ManagementRelation");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,32)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.ManagementRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ManagementRelation(");
            strSql.Append("O_ID,U_ID,Flag,AddTime,EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
            strSql.Append("@O_ID,@U_ID,@Flag,@AddTime,@EndTime,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
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
			parameters[0].Value = model.O_ID;
			parameters[1].Value = model.U_ID;
			parameters[2].Value = model.Flag;
			parameters[3].Value = model.AddTime;
            parameters[4].Value = model.EndTime;
			parameters[5].Value = model.int1;
			parameters[6].Value = model.int2;
			parameters[7].Value = model.int3;
			parameters[8].Value = model.string1;
			parameters[9].Value = model.string2;
			parameters[10].Value = model.string3;
			parameters[11].Value = model.date1;
			parameters[12].Value = model.date2;
			parameters[13].Value = model.date3;
			parameters[14].Value = model.float1;
			parameters[15].Value = model.float2;
			parameters[16].Value = model.float3;

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
		public bool Update(Tellyes.Model.ManagementRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ManagementRelation set ");
            strSql.Append("O_ID=@O_ID,");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("Flag=@Flag,");
            strSql.Append("AddTime=@AddTime,");
            strSql.Append("EndTime=@EndTime,");
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
			strSql.Append(" where O_ID=@O_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
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
					new SqlParameter("@O_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.O_ID;
            parameters[1].Value = model.U_ID;
            parameters[2].Value = model.Flag;
            parameters[3].Value = model.AddTime;
            parameters[4].Value = model.EndTime;
            parameters[5].Value = model.int1;
            parameters[6].Value = model.int2;
            parameters[7].Value = model.int3;
            parameters[8].Value = model.string1;
            parameters[9].Value = model.string2;
            parameters[10].Value = model.string3;
            parameters[11].Value = model.date1;
            parameters[12].Value = model.date2;
            parameters[13].Value = model.date3;
            parameters[14].Value = model.float1;
            parameters[15].Value = model.float2;
            parameters[16].Value = model.float3;
			parameters[17].Value = model.O_ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManagementRelation ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,32)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManagementRelation ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Tellyes.Model.ManagementRelation GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,O_ID,U_ID,Flag,AddTime,EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from ManagementRelation ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,32)
			};
			parameters[0].Value = ID;

			Tellyes.Model.ManagementRelation model=new Tellyes.Model.ManagementRelation();
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
		public Tellyes.Model.ManagementRelation DataRowToModel(DataRow row)
		{
			Tellyes.Model.ManagementRelation model=new Tellyes.Model.ManagementRelation();
			if (row != null)
			{
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = new Guid(row["ID"].ToString());
                }
				if(row["O_ID"]!=null && row["O_ID"].ToString()!="")
				{
					model.O_ID=int.Parse(row["O_ID"].ToString());
				}
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["Flag"] != null && row["U_ID"].ToString() != "")
				{
                    model.Flag = int.Parse(row["Flag"].ToString());
				}
                if (row["AddTime"] != null && row["date2"].ToString() != "")
				{
                    model.AddTime = DateTime.Parse(row["AddTime"].ToString());
				}
                if (row["EndTime"] != null && row["EndTime"].ToString() != "")
				{
                    model.EndTime = DateTime.Parse(row["EndTime"].ToString());
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
            strSql.Append("select ID,O_ID,U_ID,Flag,AddTime,EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM ManagementRelation ");
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
            strSql.Append(" ID,O_ID,U_ID,Flag,AddTime,EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM ManagementRelation ");
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
			strSql.Append("select count(1) FROM ManagementRelation ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from ManagementRelation T ");
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
			parameters[0].Value = "ManagementRelation";
			parameters[1].Value = "O_ID";
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
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("U_ID,Eq"))
            {
                criteria.Add(Restrictions.Eq("U_ID", conditionDictionary["U_ID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("Flag,Eq"))
            {
                criteria.Add(Restrictions.Eq("Flag", conditionDictionary["Flag,Eq"]));
            }
            if (conditionDictionary.ContainsKey("O_ID,NotEq"))
            {
                criteria.Add(Restrictions.Not(Restrictions.Eq("O_ID", conditionDictionary["O_ID,NotEq"])));
            }
            return criteria;
        }

        /// <summary>
        /// 依据用户id,获取该用户的分管班级列表
        /// </summary>
        /// <param name="U_ID">用户ID</param>
        /// <returns></returns>
        public DataSet GetManagementList(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format("select * from ManagementRelation where U_ID = {0}", U_ID));

            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod

        
    }
}

