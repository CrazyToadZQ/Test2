using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:DeviceClass
	/// </summary>
	public partial class DeviceClassOriginal
	{
        public DeviceClassOriginal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DC_ID", "DeviceClass"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DeviceClass");
			strSql.Append(" where DC_ID=@DC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = DC_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.DeviceClassOriginal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DeviceClass(");
			strSql.Append("DC_Name,DC_ParentID,DC_Content,DC_IsValid,DC_int,DC_string)");
			strSql.Append(" values (");
			strSql.Append("@DC_Name,@DC_ParentID,@DC_Content,@DC_IsValid,@DC_int,@DC_string)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DC_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ParentID", SqlDbType.Int,4),
					new SqlParameter("@DC_Content", SqlDbType.NVarChar,1000),
					new SqlParameter("@DC_IsValid", SqlDbType.Int,4),
					new SqlParameter("@DC_int", SqlDbType.Int,4),
					new SqlParameter("@DC_string", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DC_Name;
			parameters[1].Value = model.DC_ParentID;
			parameters[2].Value = model.DC_Content;
			parameters[3].Value = model.DC_IsValid;
			parameters[4].Value = model.DC_int;
			parameters[5].Value = model.DC_string;

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
		public bool Update(Tellyes.Model.DeviceClassOriginal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DeviceClass set ");
			strSql.Append("DC_Name=@DC_Name,");
			strSql.Append("DC_ParentID=@DC_ParentID,");
			strSql.Append("DC_Content=@DC_Content,");
			strSql.Append("DC_IsValid=@DC_IsValid,");
			strSql.Append("DC_int=@DC_int,");
			strSql.Append("DC_string=@DC_string");
			strSql.Append(" where DC_ID=@DC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DC_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ParentID", SqlDbType.Int,4),
					new SqlParameter("@DC_Content", SqlDbType.NVarChar,1000),
					new SqlParameter("@DC_IsValid", SqlDbType.Int,4),
					new SqlParameter("@DC_int", SqlDbType.Int,4),
					new SqlParameter("@DC_string", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DC_Name;
			parameters[1].Value = model.DC_ParentID;
			parameters[2].Value = model.DC_Content;
			parameters[3].Value = model.DC_IsValid;
			parameters[4].Value = model.DC_int;
			parameters[5].Value = model.DC_string;
			parameters[6].Value = model.DC_ID;

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
		public bool Delete(int DC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeviceClass ");
			strSql.Append(" where DC_ID=@DC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = DC_ID;

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
		public bool DeleteList(string DC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeviceClass ");
			strSql.Append(" where DC_ID in ("+DC_IDlist + ")  ");
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
		public Tellyes.Model.DeviceClassOriginal GetModel(int DC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DC_ID,DC_Name,DC_ParentID,DC_Content,DC_IsValid,DC_int,DC_string from DeviceClass ");
			strSql.Append(" where DC_ID=@DC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = DC_ID;

			Tellyes.Model.DeviceClassOriginal model=new Tellyes.Model.DeviceClassOriginal();
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
		public Tellyes.Model.DeviceClassOriginal DataRowToModel(DataRow row)
		{
			Tellyes.Model.DeviceClassOriginal model=new Tellyes.Model.DeviceClassOriginal();
			if (row != null)
			{
				if(row["DC_ID"]!=null && row["DC_ID"].ToString()!="")
				{
					model.DC_ID=int.Parse(row["DC_ID"].ToString());
				}
				if(row["DC_Name"]!=null)
				{
					model.DC_Name=row["DC_Name"].ToString();
				}
				if(row["DC_ParentID"]!=null && row["DC_ParentID"].ToString()!="")
				{
					model.DC_ParentID=int.Parse(row["DC_ParentID"].ToString());
				}
				if(row["DC_Content"]!=null)
				{
					model.DC_Content=row["DC_Content"].ToString();
				}
				if(row["DC_IsValid"]!=null && row["DC_IsValid"].ToString()!="")
				{
					model.DC_IsValid=int.Parse(row["DC_IsValid"].ToString());
				}
				if(row["DC_int"]!=null && row["DC_int"].ToString()!="")
				{
					model.DC_int=int.Parse(row["DC_int"].ToString());
				}
				if(row["DC_string"]!=null)
				{
					model.DC_string=row["DC_string"].ToString();
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
			strSql.Append("select DC_ID,DC_Name,DC_ParentID,DC_Content,DC_IsValid,DC_int,DC_string ");
			strSql.Append(" FROM DeviceClass ");
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
			strSql.Append(" DC_ID,DC_Name,DC_ParentID,DC_Content,DC_IsValid,DC_int,DC_string ");
			strSql.Append(" FROM DeviceClass ");
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
			strSql.Append("select count(1) FROM DeviceClass ");
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
				strSql.Append("order by T.DC_ID desc");
			}
			strSql.Append(")AS Row, T.*  from DeviceClass T ");
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
			parameters[0].Value = "DeviceClass";
			parameters[1].Value = "DC_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public static DataTable GetDeviceClassData(int E_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from DeviceClass where DC_IsValid=1 and DC_ID not in (select DC_ID from SingleStationExamRoom_DeviceClass where E_ID='" + E_ID + "') and DC_IsValid='1'; ");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());

            return ds.Tables[0];
        }

        public static DataTable GetLastLevelDeviceClassData(string parentID,Guid E_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from DeviceClass where DC_IsValid=1 and DC_ID not in (select DC_ID from SingleStationExamRoom_DeviceClass where E_ID='" + E_ID + "' ) and DC_IsValid='1' and DC_ParentID='" + parentID + "' ;");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());

            return ds.Tables[0];
        }

        public static DataTable GetLastLevelDeviceClassDataBaseMemory(string parentID, string DC_IDs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from DeviceClass where DC_IsValid=1 and DC_ID not in (" + DC_IDs + ") and DC_IsValid='1' and DC_ParentID='" + parentID + "' ;");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());

            return ds.Tables[0];
        }

        public static DataTable GetDeviceClassByName(string partOfDC_Name,string E_ID)
        {
            string sql = " select * from DeviceClass as dc where DC_Name like '%" + partOfDC_Name + "%' and  DC_ID not in (select DC_ID from SingleStationExamRoom_DeviceClass where E_ID='" + E_ID + "' ) and DC_IsValid='1'  and not exists (select * from DeviceClass where DC_ParentID=dc.DC_ID); ";
            DataSet ds = DbHelperSQL.Query(sql.ToString());

            return ds.Tables[0];
        }

        public static DataTable GetDeviceClassByMemory(string partOfDC_Name, string DC_IDs)
        {
            string sql = " select * from DeviceClass as dc where DC_Name like '%" + partOfDC_Name + "%' and  DC_ID not in (" + DC_IDs + ") and DC_IsValid='1'  and not exists (select * from DeviceClass where DC_ParentID=dc.DC_ID); ";
            DataSet ds = DbHelperSQL.Query(sql.ToString());

            return ds.Tables[0];
        }

        /// <summary>
        /// 根据查询条件获得所需要的查询结果
        /// </summary>
        /// <param name="Pid"></param>
        /// <param name="Name"></param>
        /// <param name="IsTellyes"></param>
        /// <returns></returns>
        public DataSet GetDeviceByInfo(string Pid,string Name,string IsTellyes )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from DeviceClass where 1=1");
            if (!string.IsNullOrEmpty(Pid) && Pid != "-1") 
            {
                strSql.Append(" and DC_ParentID ="+Pid);
            }
            if (!string.IsNullOrEmpty(Name))
            {
                strSql.Append(" and DC_Name like '%" + Name + "%'");
            }
            /*
             此处缺少针对是否选中天堰或其他的选择框的代码，原因是原数据库设计中，没有考虑此处的元素存在
             */
            try
            {
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch 
            {
                return null;
            }
        }

        public static void UpdateStockForSpecialDeviceClass(string DC_ID,string newStock)
        {
            string sql = " update DeviceClass set DC_int='" + newStock + "' where DC_ID='" + DC_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 返回所有第三级设备类别
        /// </summary>
        /// <returns></returns>
        public static DataTable GetLastLevelDeviceClass() 
        {
            string sql = " select distinct dc.DC_ID,dc.DC_Name from dbo.DeviceClass as dc join dbo.Device as d on dc.DC_ID =d.DC_ID order by DC_Name; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 返回最后一级设备分类中该分类名称信息
        /// </summary>
        /// <param name="deviceclassName">设备分类名称</param>
        /// <returns></returns>
        public DataTable GetLastLevelDeviceClass(string deviceclassName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from DeviceClass as A where A.DC_ID not in (select DC_ParentID from DeviceClass) ");
            strSql.Append(string.Format(" and DC_Name='{0}'", deviceclassName));
            DataTable dtTemp = DbHelperSQL.Query(strSql.ToString()).Tables[0];

            return dtTemp;
        }

		#endregion  ExtensionMethod
	}
}

