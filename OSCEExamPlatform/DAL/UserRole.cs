using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Collections;
using System.Collections.Generic;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;//Please add references
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:UserRole
	/// </summary>
	public partial class UserRole : BaseDAL<Model.UserRole>
	{
		public UserRole()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("R_ID", "UserRole"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int R_ID,int U_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserRole");
			strSql.Append(" where R_ID=@R_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = R_ID;
			parameters[1].Value = U_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.UserRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserRole(");
			strSql.Append("R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
			strSql.Append("@R_ID,@U_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
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
			parameters[0].Value = model.R_ID;
			parameters[1].Value = model.U_ID;
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
		public bool Update(Tellyes.Model.UserRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserRole set ");
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
			strSql.Append(" where R_ID=@R_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
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
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.int1;
			parameters[1].Value = model.int2;
			parameters[2].Value = model.int3;
			parameters[3].Value = model.string1;
			parameters[4].Value = model.string2;
			parameters[5].Value = model.string3;
			parameters[6].Value = model.date1;
			parameters[7].Value = model.date2;
			parameters[8].Value = model.date3;
			parameters[9].Value = model.float1;
			parameters[10].Value = model.float2;
			parameters[11].Value = model.float3;
			parameters[12].Value = model.R_ID;
			parameters[13].Value = model.U_ID;

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
		public bool Delete(int R_ID,int U_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserRole ");
			strSql.Append(" where R_ID=@R_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = R_ID;
			parameters[1].Value = U_ID;

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
        public bool DeleteByUser(int U_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserRole ");
            strSql.Append(" where U_ID=@U_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

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
		public Tellyes.Model.UserRole GetModel(int R_ID,int U_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from UserRole ");
			strSql.Append(" where R_ID=@R_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = R_ID;
			parameters[1].Value = U_ID;

			Tellyes.Model.UserRole model=new Tellyes.Model.UserRole();
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
		public Tellyes.Model.UserRole DataRowToModel(DataRow row)
		{
			Tellyes.Model.UserRole model=new Tellyes.Model.UserRole();
			if (row != null)
			{
				if(row["R_ID"]!=null && row["R_ID"].ToString()!="")
				{
					model.R_ID=int.Parse(row["R_ID"].ToString());
				}
				if(row["U_ID"]!=null && row["U_ID"].ToString()!="")
				{
					model.U_ID=int.Parse(row["U_ID"].ToString());
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
			strSql.Append("select R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM UserRole ");
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
			strSql.Append(" R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM UserRole ");
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
			strSql.Append("select count(1) FROM UserRole ");
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
				strSql.Append("order by T.U_ID desc");
			}
			strSql.Append(")AS Row, T.*  from UserRole T ");
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
			parameters[0].Value = "UserRole";
			parameters[1].Value = "U_ID";
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
        /// 添加用户与角色的关联信息（事务处理）
        /// </summary>
        /// <param name="rids"></param>
        /// <param name="uids"></param>
        /// <returns></returns>
        public bool InsertByTran(string rids, string uids)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            uids = uids.Trim(new char[] { ',' });
            list.Add(getDelByUser(uids));
            string[] uidArr = uids.Split(new char[] { ',' });
            string[] ridArr = rids.Split(new char[] { ',' });
            for (int i = 0; i < uidArr.Length; i++)
            {
                int uid = int.Parse(uidArr[i].Replace("'", ""));
                for (int j = 0; j < ridArr.Length; j++)
                {
                    int rid = int.Parse(ridArr[j]);
                    Model.UserRole ur = new Model.UserRole();
                    ur.R_ID = rid;
                    ur.U_ID = uid;
                    list.Add(getInsert(ur));
                }
            }

            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CommandInfo getInsert(Model.UserRole model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserRole(");
            strSql.Append("R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@R_ID,@U_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
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
            parameters[0].Value = model.R_ID;
            parameters[1].Value = model.U_ID;
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

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        public CommandInfo getDelByUser(string uids)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("delete from UserRole where U_ID in ("+uids+")");
            return new CommandInfo(sqlStr.ToString(), null, EffentNextType.None);

        }

        /// <summary>
        /// 将用户从某一个角色中删除关联
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="uList"></param>
        /// <returns></returns>
        public bool DeleteUserFromRole(string rid,string uList)
        {
            StringBuilder sqlStr = new StringBuilder();
            uList = uList.Trim(new char[] { ',' });
            uList = uList.Replace("'", "");
            sqlStr.Append("delete from UserRole where U_ID in (" + uList + ") and R_ID=" + rid);
            try
            {
                DbHelperSQL.ExecuteSql(sqlStr.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
            
        }

        /// <summary>
        /// 获得角色ID的集合，通过用户的ID
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string getRidList(int uid)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("select R_ID from UserRole where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = uid;

            DataSet ds = DbHelperSQL.Query(sqlStr.ToString(), parameters);
            string sRtn = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sRtn += "'" + ds.Tables[0].Rows[i]["R_ID"] + "',";
            }
            return sRtn.Trim(new char[] { ',' });
        }

        /// <summary>
        /// 获得角色名称的集合，通过用户的ID
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string getRNameList(int uid)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("select R_Name from Role where R_ID in(select R_ID from UserRole where U_ID=@U_ID)");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = uid;

            DataSet ds = DbHelperSQL.Query(sqlStr.ToString(), parameters);
            string sRtn = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sRtn += ds.Tables[0].Rows[i]["R_Name"] + ",";
            }
            return sRtn.Trim(new char[] { ',' });
        }

		#endregion  ExtensionMethod

        #region Extension
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("U_ID"))
            {
                criteria.Add(Restrictions.Eq("U_ID", conditionDictionary["U_ID"]));
            }
            if (conditionDictionary.ContainsKey("U_ID,EQ"))
            {
                criteria.Add(Restrictions.Eq("U_ID", conditionDictionary["U_ID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("R_ID,IN"))
            {
                criteria.Add(Restrictions.In("R_ID", (List<int>)conditionDictionary["R_ID,IN"]));
            }
            return criteria;
        }

        //根据用户UID判断其角色
        public DataSet GetRole(int UID)
        {
            string strSql = string.Format("select * from [OSCE].[dbo].[UserRole] where U_ID ='{0}'", UID);
            return DbHelperSQL.Query(strSql);
        }
        #endregion

        #region 批量设置用户的角色
        /// <summary>
        /// 批量设置用户的角色
        /// </summary>
        /// <returns></returns>
        public int serialSetUserRole(string userids,string roleids) 
        {
            if (!string.IsNullOrEmpty(userids) && !string.IsNullOrEmpty(roleids))
            {
                int flagCount = DbHelperSQL.ExecuteSql(" delete from UserRole  where U_ID in ("+userids+")  ");
                string[] u_id = userids.Split(',');
                string[] r_id = roleids.Split(',');
                StringBuilder strSql = new StringBuilder();
                List<string> strList = new List<string>();
                for (int item = 0; item < r_id.Length;item++) 
                {
                    for (int items = 0; items < u_id.Length;items++ ) 
                    {
                 
                        strSql.Append("insert into UserRole(");
                        strSql.Append("R_ID,U_ID )");
                        strSql.Append(" values (");
                        strSql.Append("" + r_id[item] + "," + u_id[items] + ")");
                        strList.Add(strSql.ToString());
                        strSql.Clear();
             
                    }
                }

                return DbHelperSQL.ExecuteSqlTran(strList);


            }
            else {
                return 0;
            }
            
            
           
        
        }
        #endregion
    }
}

