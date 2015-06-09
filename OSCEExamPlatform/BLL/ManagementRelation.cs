using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
namespace Tellyes.BLL
{
	/// <summary>
	/// 组织机构表
	/// </summary>
	public partial class ManagementRelation
	{
		private readonly Tellyes.DAL.ManagementRelation dal=new Tellyes.DAL.ManagementRelation();
		public ManagementRelation()
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
		public bool Exists(int O_ID)
		{
			return dal.Exists(O_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.ManagementRelation model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.ManagementRelation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int O_ID)
		{
			
			return dal.Delete(O_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string O_IDlist )
		{
			return dal.DeleteList(O_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.ManagementRelation GetModel(int O_ID)
		{
			
			return dal.GetModel(O_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.ManagementRelation GetModelByCache(int O_ID)
		{
			
			string CacheKey = "ManagementRelationModel-" + O_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(O_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.ManagementRelation)objModel;
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
		public List<Tellyes.Model.ManagementRelation> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.ManagementRelation> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.ManagementRelation> modelList = new List<Tellyes.Model.ManagementRelation>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.ManagementRelation model;
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
        /// 添加ManagementRelation记录
        /// </summary>
        /// <param name="ManagementRelation"></param>
        /// <returns></returns>
        public bool AddManagementRelation(Model.ManagementRelation ManagementRelation)
        {
            return new DAL.ManagementRelation().Insert(ManagementRelation);
        }

        /// <summary>
        /// 删除ManagementRelation记录
        /// </summary>
        /// <param name="ManagementRelation"></param>
        /// <returns></returns>
        public bool RemoveManagementRelation(Model.ManagementRelation ManagementRelation)
        {
            return new DAL.ManagementRelation().Delete(ManagementRelation);
        }

        /// <summary>
        /// 修改ManagementRelation记录
        /// </summary>
        /// <param name="ManagementRelation"></param>
        /// <returns></returns>
        public bool ModifyManagementRelation(Model.ManagementRelation ManagementRelation)
        {
            return new DAL.ManagementRelation().Update((object)ManagementRelation);
        }

        /// <summary>
        /// 查询ManagementRelation下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchManagementRelationIdentity()
        {
            return new DAL.ManagementRelation().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ManagementRelation记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchManagementRelationCount()
        {
            return new DAL.ManagementRelation().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ManagementRelation记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchManagementRelationCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ManagementRelation().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定o_ID的ManagementRelation是否存在
        /// </summary>
        /// <param name="o_ID"></param>
        /// <returns></returns>
        public bool? SearchManagementRelationExists(object o_ID)
        {
            return new DAL.ManagementRelation().SelectModelObjectExistsByID(o_ID);
        }

        /// <summary>
        /// 查询指定条件的ManagementRelation是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchManagementRelationExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ManagementRelation().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按o_ID查询ManagementRelation
        /// </summary>
        /// <param name="o_ID"></param>
        /// <returns></returns>
        public Model.ManagementRelation SearchManagementRelationByID(object o_ID)
        {
            return new DAL.ManagementRelation().SelectModelObjectByID(o_ID);
        }

        /// <summary>
        /// 查询第一个ManagementRelation对象
        /// </summary>
        /// <returns></returns>
        public Model.ManagementRelation SearchUniqueManagementRelationByCondition()
        {
            return new DAL.ManagementRelation().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ManagementRelation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ManagementRelation SearchUniqueManagementRelationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ManagementRelation().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ManagementRelation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ManagementRelation SearchUniqueManagementRelationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ManagementRelation().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ManagementRelation对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ManagementRelation> SearchManagementRelationByCondition()
        {
            return new DAL.ManagementRelation().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ManagementRelation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ManagementRelation> SearchManagementRelationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ManagementRelation().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ManagementRelation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ManagementRelation> SearchManagementRelationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ManagementRelation().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ManagementRelation内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ManagementRelation> SearchManagementRelationByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ManagementRelation().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

		#region  ExtensionMethod
        
        /// <summary>
        /// 批量删除组织机构信息
        /// </summary>
        /// <param name="ManagementRelationList"></param>
        /// <returns></returns>
        public bool RemoveManagementRelation(List<Model.ManagementRelation> ManagementRelationList)
        {
            return new DAL.ManagementRelation().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"delete", ManagementRelationList.ToList<object>()}
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ManagementRelationList"></param>
        /// <param name="ManagementRelationIteraList"></param>
        /// <param name="O_ParentID"></param>
        /// <param name="O_Level"></param>
        /// <returns></returns>
        public List<Model.ManagementRelation> IteraManagementRelation(List<Model.ManagementRelation> ManagementRelationList, List<Model.ManagementRelation> ManagementRelationIteraList, int O_ParentID, int O_Level)
        {
            foreach (Model.ManagementRelation ManagementRelation in ManagementRelationList)
            {
                ManagementRelationIteraList.Add(ManagementRelation);
            }
            return ManagementRelationIteraList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ManagementRelationList"></param>
        /// <param name="ManagementRelationIteraList"></param>
        /// <param name="O_ParentID"></param>
        /// <returns></returns>
        public List<Model.ManagementRelation> IteraManagementRelation(List<Model.ManagementRelation> ManagementRelationList, List<Model.ManagementRelation> ManagementRelationIteraList, int O_ParentID)
        {
            foreach (Model.ManagementRelation ManagementRelation in ManagementRelationList)
            {
                ManagementRelationIteraList.Add(ManagementRelation);
            }
            return ManagementRelationIteraList;
        }

        /// <summary>
        /// 依据用户id,获取该用户的分管班级列表
        /// </summary>
        /// <param name="U_ID">用户ID</param>
        /// <returns></returns>
        public DataSet GetManagementList(int U_ID)
        {
            return dal.GetManagementList(U_ID);
        }

		#endregion  ExtensionMethod
	}
}

