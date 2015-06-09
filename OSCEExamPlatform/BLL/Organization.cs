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
	public partial class Organization
	{
		private readonly Tellyes.DAL.Organization dal=new Tellyes.DAL.Organization();
		public Organization()
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
		public int  Add(Tellyes.Model.Organization model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.Organization model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int O_ID)
		{

            return dal.DelByTran(O_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string O_IDlist )
		{
            return dal.DelListByTran(O_IDlist);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.Organization GetModel(int O_ID)
		{
			
			return dal.GetModel(O_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.Organization GetModelByCache(int O_ID)
		{
			
			string CacheKey = "OrganizationModel-" + O_ID;
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
			return (Tellyes.Model.Organization)objModel;
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
		public List<Tellyes.Model.Organization> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.Organization> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.Organization> modelList = new List<Tellyes.Model.Organization>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.Organization model;
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
        /// 添加Organization记录
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public bool AddOrganization(Model.Organization organization)
        {
            return new DAL.Organization().Insert(organization);
        }

        /// <summary>
        /// 删除Organization记录
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public bool RemoveOrganization(Model.Organization organization)
        {
            return new DAL.Organization().Delete(organization);
        }

        /// <summary>
        /// 修改Organization记录
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public bool ModifyOrganization(Model.Organization organization)
        {
            return new DAL.Organization().Update((object)organization);
        }

        /// <summary>
        /// 查询Organization下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchOrganizationIdentity()
        {
            return new DAL.Organization().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部Organization记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchOrganizationCount()
        {
            return new DAL.Organization().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询Organization记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchOrganizationCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定o_ID的Organization是否存在
        /// </summary>
        /// <param name="o_ID"></param>
        /// <returns></returns>
        public bool? SearchOrganizationExists(object o_ID)
        {
            return new DAL.Organization().SelectModelObjectExistsByID(o_ID);
        }

        /// <summary>
        /// 查询指定条件的Organization是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchOrganizationExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按o_ID查询Organization
        /// </summary>
        /// <param name="o_ID"></param>
        /// <returns></returns>
        public Model.Organization SearchOrganizationByID(object o_ID)
        {
            return new DAL.Organization().SelectModelObjectByID(o_ID);
        }

        /// <summary>
        /// 查询第一个Organization对象
        /// </summary>
        /// <returns></returns>
        public Model.Organization SearchUniqueOrganizationByCondition()
        {
            return new DAL.Organization().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个Organization对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.Organization SearchUniqueOrganizationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个Organization对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.Organization SearchUniqueOrganizationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Organization().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部Organization对象
        /// </summary>
        /// <returns></returns>
        public List<Model.Organization> SearchOrganizationByCondition()
        {
            return new DAL.Organization().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询Organization对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.Organization> SearchOrganizationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Organization().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询Organization对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.Organization> SearchOrganizationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Organization().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询Organization内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.Organization> SearchOrganizationByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.Organization().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

		#region  ExtensionMethod
        
        /// <summary>
        /// 批量删除组织机构信息
        /// </summary>
        /// <param name="organizationList"></param>
        /// <returns></returns>
        public bool RemoveOrganization(List<Model.Organization> organizationList)
        {
            return new DAL.Organization().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"delete", organizationList.ToList<object>()}
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationList"></param>
        /// <param name="organizationIteraList"></param>
        /// <param name="O_ParentID"></param>
        /// <param name="O_Level"></param>
        /// <returns></returns>
        public List<Model.Organization> IteraOrganization(List<Model.Organization> organizationList, List<Model.Organization> organizationIteraList, int O_ParentID, int O_Level)
        {
            foreach (Model.Organization organization in organizationList)
            {
                if (organization.O_ParentID == O_ParentID)
                {
                    organization.O_Level = O_Level;
                    organizationIteraList.Add(organization);
                    organizationIteraList = this.IteraOrganization(organizationList, organizationIteraList, organization.O_ID, O_Level + 1);
                }
            }
            return organizationIteraList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationList"></param>
        /// <param name="organizationIteraList"></param>
        /// <param name="O_ParentID"></param>
        /// <returns></returns>
        public List<Model.Organization> IteraOrganization(List<Model.Organization> organizationList, List<Model.Organization> organizationIteraList, int O_ParentID)
        {
            foreach (Model.Organization organization in organizationList)
            {
                if (organization.O_ParentID == O_ParentID)
                {
                    organizationIteraList.Add(organization);
                    organizationIteraList = this.IteraOrganization(organizationList, organizationIteraList, organization.O_ID);
                }
            }
            return organizationIteraList;
        }

        /// <summary>
        /// 迭代查询组织结构的父节点
        /// </summary>
        /// <param name="organizationList"></param>
        /// <param name="organizationTreeList"></param>
        /// <param name="organization"></param>
        /// <returns></returns>
        public List<Model.Organization> IteraOrganizationTree(List<Model.Organization> organizationList, List<Model.Organization> organizationTree, Model.Organization organization)
        {
            if (organization.O_ParentID == 0)
            {
                return organizationTree;
            }
            else
            {
                //查询父节点对象
                int i = 0;
                for (; i < organizationList.Count && organizationList[i].O_ID != organization.O_ParentID; i++) ;
                if (i < organizationList.Count)
                {
                    organizationTree.Add(organizationList[i]);
                    return this.IteraOrganizationTree(organizationList, organizationTree, organizationList[i]);
                }
                else 
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 查询用户所属的组织机构
        /// </summary>
        /// <param name="userInfoID"></param>
        /// <returns></returns>
        public List<Model.Organization> SearchOrganizationByUserInfoID(int userInfoID)
        {
            return new DAL.Organization().SelectOrganizationByUserInfoID(userInfoID);
        }

        /// <summary>
        /// 依据班级id,反向查询整个组织机构
        /// </summary>
        /// <param name="strClassIds">班级IDS（例如： '1','2','3'）</param>
        /// <returns></returns>
        public DataSet GetDetailList(string strClassIds)
        {
            return dal.GetDetailList(strClassIds);
        }

        /// <summary>
        /// 获得以用户分管组织在上的的列表
        /// </summary>
        public DataSet GetIncludeMList(int U_ID)
        {
            return dal.GetIncludeMList(U_ID);
        }
		#endregion  ExtensionMethod
	}
}

