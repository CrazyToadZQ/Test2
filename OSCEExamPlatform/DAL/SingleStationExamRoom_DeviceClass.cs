using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Collections.Generic;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:SingleStationExamRoom_DeviceClass
	/// </summary>
    public partial class SingleStationExamRoom_DeviceClass : BaseDAL<Model.SingleStationExamRoom_DeviceClass>
	{
        public static SingleStationExamRoom_DeviceClass processor = new SingleStationExamRoom_DeviceClass();

		public SingleStationExamRoom_DeviceClass()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SingleStationExamRoom_DeviceClass"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SingleStationExamRoom_DeviceClass");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.SingleStationExamRoom_DeviceClass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SingleStationExamRoom_DeviceClass(");
			strSql.Append("E_ID,DC_ID,D_Count)");
			strSql.Append(" values (");
			strSql.Append("@E_ID,@DC_ID,@D_Count)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@D_Count", SqlDbType.Money,8)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.DC_ID;
			parameters[2].Value = model.D_Count;

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
		public bool Update(Tellyes.Model.SingleStationExamRoom_DeviceClass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SingleStationExamRoom_DeviceClass set ");
			strSql.Append("E_ID=@E_ID,");
			strSql.Append("DC_ID=@DC_ID,");
			strSql.Append("D_Count=@D_Count");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@D_Count", SqlDbType.Money,8),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_ID;
			parameters[1].Value = model.DC_ID;
			parameters[2].Value = model.D_Count;
			parameters[3].Value = model.ID;

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
			strSql.Append("delete from SingleStationExamRoom_DeviceClass ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
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
			strSql.Append("delete from SingleStationExamRoom_DeviceClass ");
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
		public Tellyes.Model.SingleStationExamRoom_DeviceClass GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,E_ID,DC_ID,D_Count from SingleStationExamRoom_DeviceClass ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Tellyes.Model.SingleStationExamRoom_DeviceClass model=new Tellyes.Model.SingleStationExamRoom_DeviceClass();
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
		public Tellyes.Model.SingleStationExamRoom_DeviceClass DataRowToModel(DataRow row)
		{
			Tellyes.Model.SingleStationExamRoom_DeviceClass model=new Tellyes.Model.SingleStationExamRoom_DeviceClass();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["E_ID"]!=null && row["E_ID"].ToString()!="")
				{
					model.E_ID=Guid.Parse(row["E_ID"].ToString());
				}
				if(row["DC_ID"]!=null && row["DC_ID"].ToString()!="")
				{
					model.DC_ID=int.Parse(row["DC_ID"].ToString());
				}
				if(row["D_Count"]!=null && row["D_Count"].ToString()!="")
				{
					model.D_Count=int.Parse(row["D_Count"].ToString());
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
			strSql.Append("select ID,E_ID,DC_ID,D_Count ");
			strSql.Append(" FROM SingleStationExamRoom_DeviceClass ");
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
			strSql.Append(" ID,E_ID,DC_ID,D_Count ");
			strSql.Append(" FROM SingleStationExamRoom_DeviceClass ");
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
			strSql.Append("select count(1) FROM SingleStationExamRoom_DeviceClass ");
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
			strSql.Append(")AS Row, T.*  from SingleStationExamRoom_DeviceClass T ");
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
			parameters[0].Value = "SingleStationExamRoom_DeviceClass";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public static void ParseDeviceClassData(DataTable source)
        {
            List<Tellyes.Model.SingleStationExamRoom_DeviceClass> dataToAdd = new List<Model.SingleStationExamRoom_DeviceClass>();
            List<Tellyes.Model.SingleStationExamRoom_DeviceClass> dataToUpdate = new List<Model.SingleStationExamRoom_DeviceClass>();
            
            foreach(DataRow row in source.Rows)
            {
                string E_ID = row["E_ID"].ToString().Trim();
                string DC_ID = row["DC_ID"].ToString().Trim();
                DataTable existedData = processor.GetList(" E_ID='' and DC_ID='' ").Tables[0];
                if (existedData.Rows.Count > 0) 
                {
                    Tellyes.Model.SingleStationExamRoom_DeviceClass existedItem = processor.DataRowToModel(existedData.Rows[0]);
                    dataToUpdate.Add(existedItem);
                }
                else
                {
                    Tellyes.Model.SingleStationExamRoom_DeviceClass newItem = new Model.SingleStationExamRoom_DeviceClass();
                    newItem.E_ID = Guid.Parse(E_ID);
                    newItem.DC_ID = Convert.ToInt32(DC_ID);
                    newItem.D_Count = Convert.ToInt32(row["D_Count"]);
                    dataToAdd.Add(newItem);
                }
            }

            foreach (Tellyes.Model.SingleStationExamRoom_DeviceClass dataToAddItem in dataToAdd)
            {
                processor.Add(dataToAddItem);
            }

            foreach (Tellyes.Model.SingleStationExamRoom_DeviceClass dataToUpdateItem in dataToUpdate) 
            {
                processor.Add(dataToUpdateItem);
            }
        }

        public static DataTable GetSelectedDeviceClassData(string E_ID)
        {
            string sql = " select sdc.*,dc.DC_Name from dbo.SingleStationExamRoom_DeviceClass as sdc join dbo.DeviceClass as dc on sdc.DC_ID=dc.DC_ID where sdc.E_ID='" + E_ID + "';";
            return DbHelperSQL.Query(sql).Tables[0];
        }
		#endregion  ExtensionMethod

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Like("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,eq"))
            {
                criteria.Add(Restrictions.Like("ES_ID", conditionDictionary["ES_ID,eq"]));
            }
            return criteria;
        }
    }
}

