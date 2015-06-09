using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// ObjectiveMarkSheet
	/// </summary>
	public partial class ObjectiveMarkSheet
	{
		private readonly Tellyes.DAL.ObjectiveMarkSheet dal=new Tellyes.DAL.ObjectiveMarkSheet();
		public ObjectiveMarkSheet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OMS_ID)
		{
			return dal.Exists(OMS_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.ObjectiveMarkSheet model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.ObjectiveMarkSheet model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int OMS_ID)
		{
			
			return dal.Delete(OMS_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string OMS_IDlist )
		{
			return dal.DeleteList(OMS_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.ObjectiveMarkSheet GetModel(int OMS_ID)
		{
			
			return dal.GetModel(OMS_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.ObjectiveMarkSheet GetModelByCache(int OMS_ID)
		{
			
			string CacheKey = "ObjectiveMarkSheetModel-" + OMS_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(OMS_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.ObjectiveMarkSheet)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.ObjectiveMarkSheet> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.ObjectiveMarkSheet> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.ObjectiveMarkSheet> modelList = new List<Tellyes.Model.ObjectiveMarkSheet>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.ObjectiveMarkSheet model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 获得某种设备，全部客观评分表
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public static DataTable GetObjectMarkTable(string DC_ID)
        {
            return Tellyes.DAL.ObjectiveMarkSheet.GetObjectMarkTable(DC_ID);
        }
		#endregion  ExtensionMethod
	}
}

