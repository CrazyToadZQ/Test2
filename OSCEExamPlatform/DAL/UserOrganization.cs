using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using NHibernate;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Data;
using Tellyes.Model;
using Tellyes.Log4Net;
using NHibernate.Criterion;
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:UserOrganization
	/// </summary>
	public partial class UserOrganization : BaseDAL<Model.UserOrganization>
	{
		public UserOrganization()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("O_ID", "UserOrganization"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int O_ID,int U_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserOrganization");
			strSql.Append(" where O_ID=@O_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = O_ID;
			parameters[1].Value = U_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.UserOrganization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserOrganization(");
			strSql.Append("O_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
			strSql.Append(" values (");
			strSql.Append("@O_ID,@U_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
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
			parameters[0].Value = model.O_ID;
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
		public bool Update(Tellyes.Model.UserOrganization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserOrganization set ");
            strSql.Append("O_ID=@O_ID,");
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
			strSql.Append(" where U_ID=@U_ID ");
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
					new SqlParameter("@O_ID", SqlDbType.Int,4),
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
			parameters[12].Value = model.O_ID;
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
		public bool Delete(int O_ID,int U_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserOrganization ");
			strSql.Append(" where O_ID=@O_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = O_ID;
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
            strSql.Append("delete from UserOrganization ");
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
		public Tellyes.Model.UserOrganization GetModel(int O_ID,int U_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 O_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 from UserOrganization ");
			strSql.Append(" where O_ID=@O_ID and U_ID=@U_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
			parameters[0].Value = O_ID;
			parameters[1].Value = U_ID;

			Tellyes.Model.UserOrganization model=new Tellyes.Model.UserOrganization();
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
		public Tellyes.Model.UserOrganization DataRowToModel(DataRow row)
		{
			Tellyes.Model.UserOrganization model=new Tellyes.Model.UserOrganization();
			if (row != null)
			{
				if(row["O_ID"]!=null && row["O_ID"].ToString()!="")
				{
					model.O_ID=int.Parse(row["O_ID"].ToString());
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
			strSql.Append("select O_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM UserOrganization ");
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
			strSql.Append(" O_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3 ");
			strSql.Append(" FROM UserOrganization ");
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
			strSql.Append("select count(1) FROM UserOrganization ");
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
			strSql.Append(")AS Row, T.*  from UserOrganization T ");
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
			parameters[0].Value = "UserOrganization";
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
        /// 根据用户ID获得组织机构ID的集合
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public string getOids(int U_ID)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("select O_ID from UserOrganization where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

            DataSet ds = DbHelperSQL.Query(sqlStr.ToString(), parameters);
            string sRtn = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sRtn += "'" + ds.Tables[0].Rows[i]["O_ID"] + "',";
            }
            return sRtn.Trim(new char[] { ',' });
        }

        /// <summary>
        /// 参加某次考试的班级学生信息
        /// </summary>
        /// <param name="classID">班级id</param>
        /// <param name="noStudentIDs">未参加考试的学生id（例如：'1','2','3'）</param>
        /// <returns></returns>
        public DataSet GetClassExamStudentInfo(int classID, string noStudentIDs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Class.O_ID as Class_ID,Student.U_ID as Student_ID,Student.U_Name as Student_Name,Student.U_TrueName as Student_TrueName from ");
            strSql.Append(string.Format(" (select * from UserOrganization where O_ID={0}) as Class ", classID));
            strSql.Append(" left join UserInfo as Student on Class.U_ID=Student.U_ID ");
            if (noStudentIDs != string.Empty)
            {
                strSql.Append(string.Format("where Class.U_ID not in ({0})", noStudentIDs));
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

		#endregion  ExtensionMethod
        #region NHibernate Method

        /// <summary>
        /// 查询当前考试的班级ID集合
        /// </summary>
        /// <param name="userInfoIDList"></param>
        /// <returns></returns>
        public List<object> SelectOrganizationIDByUserInfoIDList(List<int> userInfoIDList)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   DISTINCT [UserOrganization].[O_ID] ")
                .Append("FROM ")
                .Append("   [ExamStudent] ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [ExamStudent].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[U_ID] IN (:userInfoIDList) ")
                .Append("ORDER BY ")
                .Append("   [UserOrganization].[O_ID] ASC ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("O_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetParameterList("userInfoIDList", userInfoIDList);
                //查询结果并返回
                return iSQLQuery.List<object>().ToList<object>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "按照用户ID集合查询组织机构ID", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 查询班级和学生的对应关系
        /// </summary>
        /// <param name="userInfoIDList"></param>
        /// <returns></returns>
        public List<object[]> SelectOrganizationIDUserInfoIDByCondition(List<int> userInfoIDList)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [UserOrganization].[O_ID], ")
                .Append("   [UserInfo].[U_ID] ")
                .Append("FROM ")
                .Append("   [UserInfo] ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("WHERE ")
                .Append("   [UserInfo].[U_ID] IN (:userInfoIDList) ")
                .Append("ORDER BY ")
                .Append("   UserOrganization.O_ID ASC ");
            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddScalar("O_ID", NHibernateUtil.Int32);
                iSQLQuery.AddScalar("U_ID", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetParameterList("userInfoIDList", userInfoIDList);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "按照用户ID集合查询组织机构ID", e);
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
            if (conditionDictionary.ContainsKey("U_ID,In"))
            {
                criteria.Add(Restrictions.In("U_ID", (List<int>)conditionDictionary["U_ID,In"]));
            }

            return criteria;
        }

        #endregion

        
    }
}

