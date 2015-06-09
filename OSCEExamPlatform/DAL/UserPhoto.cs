
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;//Please add references

namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:UserPhoto
	/// </summary>
	public partial class UserPhoto
	{
		public UserPhoto()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UP_ID", "UserPhoto"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UP_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserPhoto");
			strSql.Append(" where UP_ID=@UP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UP_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UP_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.UserPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserPhoto(");
			strSql.Append("U_ID,UP_Photo,UP_CreateTime,E_ID,Room_ID,int1,string1)");
			strSql.Append(" values (");
			strSql.Append("@U_ID,@UP_Photo,@UP_CreateTime,@E_ID,@Room_ID,@int1,@string1)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@UP_Photo", SqlDbType.Image),
					new SqlParameter("@UP_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.U_ID;
			parameters[1].Value = model.UP_Photo;
			parameters[2].Value = model.UP_CreateTime;
			//parameters[3].Value = Guid.NewGuid();
            parameters[3].Value = model.E_ID;
			parameters[4].Value = model.Room_ID;
			parameters[5].Value = model.int1;
			parameters[6].Value = model.string1;

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
		public bool Update(Tellyes.Model.UserPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserPhoto set ");
			strSql.Append("U_ID=@U_ID,");
			strSql.Append("UP_Photo=@UP_Photo,");
			strSql.Append("UP_CreateTime=@UP_CreateTime,");
			strSql.Append("E_ID=@E_ID,");
			strSql.Append("Room_ID=@Room_ID,");
			strSql.Append("int1=@int1,");
			strSql.Append("string1=@string1");
			strSql.Append(" where UP_ID=@UP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@UP_Photo", SqlDbType.Image),
					new SqlParameter("@UP_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,200),
					new SqlParameter("@UP_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.U_ID;
			parameters[1].Value = model.UP_Photo;
			parameters[2].Value = model.UP_CreateTime;
			parameters[3].Value = model.E_ID;
			parameters[4].Value = model.Room_ID;
			parameters[5].Value = model.int1;
			parameters[6].Value = model.string1;
			parameters[7].Value = model.UP_ID;

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
		public bool Delete(int UP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserPhoto ");
			strSql.Append(" where UP_ID=@UP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UP_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UP_ID;

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
		public bool DeleteList(string UP_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserPhoto ");
			strSql.Append(" where UP_ID in ("+UP_IDlist + ")  ");
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
		public Tellyes.Model.UserPhoto GetModel(int UP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UP_ID,U_ID,UP_Photo,UP_CreateTime,E_ID,Room_ID,int1,string1 from UserPhoto ");
			strSql.Append(" where UP_ID=@UP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UP_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UP_ID;

			Tellyes.Model.UserPhoto model=new Tellyes.Model.UserPhoto();
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
		public Tellyes.Model.UserPhoto DataRowToModel(DataRow row)
		{
			Tellyes.Model.UserPhoto model=new Tellyes.Model.UserPhoto();
			if (row != null)
			{
				if(row["UP_ID"]!=null && row["UP_ID"].ToString()!="")
				{
					model.UP_ID=int.Parse(row["UP_ID"].ToString());
				}
				if(row["U_ID"]!=null && row["U_ID"].ToString()!="")
				{
					model.U_ID=int.Parse(row["U_ID"].ToString());
				}
				if(row["UP_Photo"]!=null && row["UP_Photo"].ToString()!="")
				{
					model.UP_Photo=(byte[])row["UP_Photo"];
				}
				if(row["UP_CreateTime"]!=null && row["UP_CreateTime"].ToString()!="")
				{
					model.UP_CreateTime=DateTime.Parse(row["UP_CreateTime"].ToString());
				}
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID= new Guid(row["E_ID"].ToString());
				}
				if(row["Room_ID"]!=null && row["Room_ID"].ToString()!="")
				{
					model.Room_ID=int.Parse(row["Room_ID"].ToString());
				}
				if(row["int1"]!=null && row["int1"].ToString()!="")
				{
					model.int1=int.Parse(row["int1"].ToString());
				}
				if(row["string1"]!=null)
				{
					model.string1=row["string1"].ToString();
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
			strSql.Append("select UP_ID,U_ID,UP_Photo,UP_CreateTime,E_ID,Room_ID,int1,string1 ");
			strSql.Append(" FROM UserPhoto ");
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
			strSql.Append(" UP_ID,U_ID,UP_Photo,UP_CreateTime,E_ID,Room_ID,int1,string1 ");
			strSql.Append(" FROM UserPhoto ");
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
			strSql.Append("select count(1) FROM UserPhoto ");
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
				strSql.Append("order by T.UP_ID desc");
			}
			strSql.Append(")AS Row, T.*  from UserPhoto T ");
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
			parameters[0].Value = "UserPhoto";
			parameters[1].Value = "UP_ID";
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
        /// 将图片保存到数据库中
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="imageBytes"></param>
        /// <returns></returns>
        public int WriteImage(string strSql, byte[] imageBytes)
        {
            return DbHelperSQL.ExecuteWriteImage(strSql, imageBytes);
        }

        /// <summary>
        /// 根据UID、EID查找相应的信息
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet IsHavePhoto(int UID, Guid EID)
        {
            string strSql = string.Format("select * from [UserPhoto] where U_ID = '{0}' and E_ID ='{1}'", UID, EID);
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 根据UID获取该考生的图像信息
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public SqlDataReader GetUserPhoto(int UID, Guid EID)
        {
            string strSql = string.Format("select UP_Photo from [UserPhoto] where U_ID = '{0}' and E_ID ='{1}'", UID,EID);
            //string strSql = string.Format("select UP_Photo from [UserPhoto] where U_ID = '{0}'", UID);
            return DbHelperSQL.ExecuteReader(strSql);
        }

		#endregion  ExtensionMethod
	}
}

