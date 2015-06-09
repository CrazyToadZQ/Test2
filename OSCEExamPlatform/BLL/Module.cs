﻿using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// 功能模块表
	/// </summary>
	public partial class Module
	{
		private readonly Tellyes.DAL.Module dal=new Tellyes.DAL.Module();
		public Module()
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
		public bool Exists(int M_ID)
		{
			return dal.Exists(M_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.Module model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.Module model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int M_ID)
		{
			
			return dal.Delete(M_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string M_IDlist )
		{
			return dal.DeleteList(M_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.Module GetModel(int M_ID)
		{
			
			return dal.GetModel(M_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.Module GetModelByCache(int M_ID)
		{
			
			string CacheKey = "ModuleModel-" + M_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(M_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.Module)objModel;
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
		public List<Tellyes.Model.Module> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.Module> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.Module> modelList = new List<Tellyes.Model.Module>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.Module model;
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
        /// 根据用户ID，获得功能列表
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public List<Model.Module> getModuleList(int UID)
        {
            return dal.getModuleList(UID);
        }

		#endregion  ExtensionMethod

        #region
        public List<Model.Module> SearchModuleNameByCondition(int roleID)
        {
            return new DAL.Module().SelectModuleNameByCondition(roleID);
        }
        #endregion
    }
}

