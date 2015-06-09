using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// 组织机构级别名称管理
	/// </summary>
	public partial class Organization_Level
	{
		private readonly Tellyes.DAL.Organization_Level dal=new Tellyes.DAL.Organization_Level();
		public Organization_Level()
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
		public bool Exists(int OL_ID)
		{
			return dal.Exists(OL_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.Organization_Level model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.Organization_Level model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int OL_ID)
		{
			
			return dal.Delete(OL_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string OL_IDlist )
		{
			return dal.DeleteList(OL_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.Organization_Level GetModel(int OL_ID)
		{
			
			return dal.GetModel(OL_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.Organization_Level GetModelByCache(int OL_ID)
		{
			
			string CacheKey = "Organization_LevelModel-" + OL_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(OL_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.Organization_Level)objModel;
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
		public List<Tellyes.Model.Organization_Level> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.Organization_Level> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.Organization_Level> modelList = new List<Tellyes.Model.Organization_Level>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.Organization_Level model;
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

        #region Extension NHibernate

        /// <summary>
        /// 添加Organization_Level记录
        /// </summary>
        /// <param name="organization_Level"></param>
        /// <returns></returns>
        public bool AddOrganization_Level(Model.Organization_Level organization_Level)
        {
            return new DAL.Organization_Level().Insert(organization_Level);
        }

        /// <summary>
        /// 删除Organization_Level记录
        /// </summary>
        /// <param name="organization_Level"></param>
        /// <returns></returns>
        public bool RemoveOrganization_Level(Model.Organization_Level organization_Level)
        {
            return new DAL.Organization_Level().Delete(organization_Level);
        }

        /// <summary>
        /// 修改Organization_Level记录
        /// </summary>
        /// <param name="organization_Level"></param>
        /// <returns></returns>
        public bool ModifyOrganization_Level(Model.Organization_Level organization_Level)
        {
            return new DAL.Organization_Level().Update((object)organization_Level);
        }

        /// <summary>
        /// 查询Organization_Level下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchOrganization_LevelIdentity()
        {
            return new DAL.Organization_Level().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部Organization_Level记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchOrganization_LevelCount()
        {
            return new DAL.Organization_Level().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询Organization_Level记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchOrganization_LevelCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization_Level().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定oL_ID的Organization_Level是否存在
        /// </summary>
        /// <param name="oL_ID"></param>
        /// <returns></returns>
        public bool? SearchOrganization_LevelExists(object oL_ID)
        {
            return new DAL.Organization_Level().SelectModelObjectExistsByID(oL_ID);
        }

        /// <summary>
        /// 查询指定条件的Organization_Level是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchOrganization_LevelExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization_Level().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按oL_ID查询Organization_Level
        /// </summary>
        /// <param name="oL_ID"></param>
        /// <returns></returns>
        public Model.Organization_Level SearchOrganization_LevelByID(object oL_ID)
        {
            return new DAL.Organization_Level().SelectModelObjectByID(oL_ID);
        }

        /// <summary>
        /// 查询第一个Organization_Level对象
        /// </summary>
        /// <returns></returns>
        public Model.Organization_Level SearchUniqueOrganization_LevelByCondition()
        {
            return new DAL.Organization_Level().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个Organization_Level对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.Organization_Level SearchUniqueOrganization_LevelByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization_Level().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个Organization_Level对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.Organization_Level SearchUniqueOrganization_LevelByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Organization_Level().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部Organization_Level对象
        /// </summary>
        /// <returns></returns>
        public List<Model.Organization_Level> SearchOrganization_LevelByCondition()
        {
            return new DAL.Organization_Level().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询Organization_Level对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.Organization_Level> SearchOrganization_LevelByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization_Level().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询Organization_Level对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.Organization_Level> SearchOrganization_LevelByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Organization_Level().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询Organization_Level内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.Organization_Level> SearchOrganization_LevelByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.Organization_Level().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

		#region  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationLevelList"></param>
        /// <returns></returns>
        public bool ModifyOrganizationLevelList(List<Tellyes.Model.Organization_Level>  organizationLevelList)
        {
            return new DAL.Organization_Level().Transaction
            (
                new List<List<object>>() 
                { 
                    new List<object>(){"update", organizationLevelList.ToList<object>()}
                }
            );
        }

		#endregion  ExtensionMethod
	}
}

