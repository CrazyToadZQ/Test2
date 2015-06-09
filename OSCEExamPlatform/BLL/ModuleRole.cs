using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// 角色功能模块分配表
	/// </summary>
	public partial class ModuleRole
	{
		private readonly Tellyes.DAL.ModuleRole dal=new Tellyes.DAL.ModuleRole();
		public ModuleRole()
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
		public bool Exists(int M_ID,int R_ID)
		{
			return dal.Exists(M_ID,R_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.ModuleRole model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.ModuleRole model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int M_ID,int R_ID)
		{
			
			return dal.Delete(M_ID,R_ID);
		}

        /// <summary>
        /// 删除一条数据,通过role
        /// </summary>
        public bool Delete(int R_ID)
        {

            return dal.Delete(R_ID);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.ModuleRole GetModel(int M_ID,int R_ID)
		{
			
			return dal.GetModel(M_ID,R_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.ModuleRole GetModelByCache(int M_ID,int R_ID)
		{
			
			string CacheKey = "ModuleRoleModel-" + M_ID+R_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(M_ID,R_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.ModuleRole)objModel;
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
		public List<Tellyes.Model.ModuleRole> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.ModuleRole> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.ModuleRole> modelList = new List<Tellyes.Model.ModuleRole>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.ModuleRole model;
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
        /// 根据角色ID，获得模块ID的列表。
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public string getMidList(int rid)
        {
            return dal.getMidList(rid);
        }
        
        /// <summary>
        /// 添加一个角色的所有权限（事务处理）
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="mids"></param>
        /// <returns></returns>
        public bool insertByTran(string rid, string mids)
        {
            return dal.insertByTran(rid, mids);
        }

		#endregion  ExtensionMethod
	}
}

