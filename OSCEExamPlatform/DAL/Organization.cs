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
	/// 数据访问类:Organization
	/// </summary>
	public partial class Organization : BaseDAL<Model.Organization>
	{
		public Organization()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("O_ID", "Organization"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int O_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Organization");
			strSql.Append(" where O_ID=@O_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = O_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Organization(");
			strSql.Append("O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
			strSql.Append("@O_Name,@O_Contont,@O_ParentID,@OL_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_Contont", SqlDbType.NVarChar,500),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
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
			parameters[0].Value = model.O_Name;
			parameters[1].Value = model.O_Contont;
			parameters[2].Value = model.O_ParentID;
			parameters[3].Value = model.OL_ID;
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
		public bool Update(Tellyes.Model.Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Organization set ");
			strSql.Append("O_Name=@O_Name,");
			strSql.Append("O_Contont=@O_Contont,");
			strSql.Append("O_ParentID=@O_ParentID,");
			strSql.Append("OL_ID=@OL_ID,");
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
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_Contont", SqlDbType.NVarChar,500),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
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
					new SqlParameter("@O_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.O_Name;
			parameters[1].Value = model.O_Contont;
			parameters[2].Value = model.O_ParentID;
			parameters[3].Value = model.OL_ID;
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
			parameters[16].Value = model.O_ID;

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
		public bool Delete(int O_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Organization ");
			strSql.Append(" where O_ID=@O_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = O_ID;

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
		public bool DeleteList(string O_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Organization ");
			strSql.Append(" where O_ID in ("+O_IDlist + ")  ");
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
		public Tellyes.Model.Organization GetModel(int O_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 O_ID,O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from Organization ");
			strSql.Append(" where O_ID=@O_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = O_ID;

			Tellyes.Model.Organization model=new Tellyes.Model.Organization();
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
		public Tellyes.Model.Organization DataRowToModel(DataRow row)
		{
			Tellyes.Model.Organization model=new Tellyes.Model.Organization();
			if (row != null)
			{
				if(row["O_ID"]!=null && row["O_ID"].ToString()!="")
				{
					model.O_ID=int.Parse(row["O_ID"].ToString());
				}
				if(row["O_Name"]!=null)
				{
					model.O_Name=row["O_Name"].ToString();
				}
				if(row["O_Contont"]!=null)
				{
					model.O_Contont=row["O_Contont"].ToString();
				}
				if(row["O_ParentID"]!=null && row["O_ParentID"].ToString()!="")
				{
					model.O_ParentID=int.Parse(row["O_ParentID"].ToString());
				}
				if(row["OL_ID"]!=null && row["OL_ID"].ToString()!="")
				{
					model.OL_ID=int.Parse(row["OL_ID"].ToString());
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
			strSql.Append("select O_ID,O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM Organization ");
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
			strSql.Append(" O_ID,O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM Organization ");
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
			strSql.Append("select count(1) FROM Organization ");
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
				strSql.Append("order by T.O_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Organization T ");
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
			parameters[0].Value = "Organization";
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
            if (conditionDictionary.ContainsKey("O_Name,Eq"))
            {
                criteria.Add(Restrictions.Eq("O_Name", conditionDictionary["O_Name,Eq"]));
            }
            if (conditionDictionary.ContainsKey("O_ParentID,Eq"))
            {
                criteria.Add(Restrictions.Eq("O_ParentID", conditionDictionary["O_ParentID,Eq"]));
            }
            if (conditionDictionary.ContainsKey("O_ID,NotEq"))
            {
                criteria.Add(Restrictions.Not(Restrictions.Eq("O_ID", conditionDictionary["O_ID,NotEq"])));
            }
            if (conditionDictionary.ContainsKey("OL_ID,In"))
            {
                criteria.Add(Restrictions.In("OL_ID", (List<int>)conditionDictionary["OL_ID,In"]));
            }
            return criteria;
        }

        /// <summary>
        /// 依据班级id,反向查询整个组织机构
        /// </summary>
        /// <param name="strClassIds">班级IDS（例如： '1','2','3'）</param>
        /// <returns></returns>
        public DataSet GetDetailList(string strClassIds)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Class.O_ID as Class_ID,Class.O_Name as Class_Name,Class.O_ParentID as Class_ParentID,Class.OL_ID as Class_LevelID,");
            strSql.Append("Major.O_ID as Major_ID,Major.O_Name as Major_Name,Major.O_ParentID as Major_ParentID,Major.OL_ID as Major_LevelID,");
            strSql.Append("Faculty.O_ID as Faculty_ID,Faculty.O_Name as Faculty_Name,Faculty.O_ParentID as Faculty_ParentID,Faculty.OL_ID as Faculty_LevelID ");
            strSql.Append(string.Format(" from (select * from Organization where O_ID in ({0})) as Class ", strClassIds));
            strSql.Append(" left join Organization as Major on Class.O_ParentID=Major.O_ID ");
            strSql.Append(" left join Organization as Faculty on Major.O_ParentID=Faculty.O_ID ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoID"></param>
        /// <returns></returns>
        public List<Model.Organization> SelectOrganizationByUserInfoID(int userInfoID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [Organization].* ")
                .Append("FROM ")
                .Append("   [UserInfo] ")
                .Append("   INNER JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   INNER JOIN [Organization] ")
                .Append("       ON [UserOrganization].[O_ID] = [Organization].[O_ID] ")
                .Append("WHERE ")
                .Append("   [UserInfo].[U_ID] = :userInfoID ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.Organization));
                //设置查询参数
                iSQLQuery.SetInt32("userInfoID", userInfoID);
                //查询结果并返回
                return iSQLQuery
                    .List<Model.Organization>()
                    .ToList<Model.Organization>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，查询考生用户班级信息失败", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 获得以用户分管组织在上的的列表
        /// </summary>
        public DataSet GetIncludeMList(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select O_ID,O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM Organization O");
            strSql.Append(string.Format(" where exists (SELECT * FROM ManagementRelation M WHERE U_ID={0} and O.O_ID=M.O_ID)", U_ID));
            strSql.Append(" union ");
            strSql.Append("select O_ID,O_Name,O_Contont,O_ParentID,OL_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
            strSql.Append(" FROM Organization O");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一个组织机构（事务处理，包括删除其有关的关系）
        /// </summary>
        /// <param name="O_ID"></param>
        /// <returns></returns>
        public bool DelByTran(int O_ID)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getDelSubOrganization(O_ID));
            list.Add(getDelOrganization(O_ID));
            list.Add(getDelUserOrganization(O_ID));
            list.Add(getDelManagementRelation(O_ID));
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CommandInfo getDelSubOrganization(int O_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Organization ");
            strSql.Append(" where O_ParentID in (select O_ID from Organization where O_ParentID=@O_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)			};
            parameters[0].Value = O_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelOrganization(int O_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Organization ");
            strSql.Append(" where O_ID=@O_ID or O_ParentID=@O_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)			};
            parameters[0].Value = O_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserOrganization(int O_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserOrganization ");
            strSql.Append(" where O_ID=@O_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)			};
            parameters[0].Value = O_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelManagementRelation(int O_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ManagementRelation ");
            strSql.Append(" where O_ID=@O_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4)			};
            parameters[0].Value = O_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        /// <summary>
        /// 删除多个组织机构（事务处理，包括删除其有关的关系）
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public bool DelListByTran(string O_IDlist)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getDelSubOrganizationList(O_IDlist));
            list.Add(getDelOrganizationList(O_IDlist));
            list.Add(getDelUserOrganizationList(O_IDlist));
            list.Add(getDelManagementRelationList(O_IDlist));
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CommandInfo getDelSubOrganizationList(string O_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Organization ");
            strSql.Append(" where O_ParentID in (select O_ID from Organization where O_ParentID in (" + O_IDlist + ")  ");
            SqlParameter[] parameters = { };

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelOrganizationList(string O_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Organization ");
            strSql.Append(" where O_ID in (" + O_IDlist + ") or  O_ParentID in (" + O_IDlist + ")  ");
            SqlParameter[] parameters = { };

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserOrganizationList(string O_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserOrganization ");
            strSql.Append(" where O_ID in (" + O_IDlist + ")  ");
            SqlParameter[] parameters = { };

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelManagementRelationList(string O_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ManagementRelation ");
            strSql.Append(" where O_ID in (" + O_IDlist + ")  ");
            SqlParameter[] parameters = { };

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

		#endregion  ExtensionMethod

        
    }
}

