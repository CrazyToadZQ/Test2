using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// 用户的角色分派表
	/// </summary>
	public partial class UserRole
	{
		private readonly Tellyes.DAL.UserRole dal=new Tellyes.DAL.UserRole();
		public UserRole()
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
		public bool Exists(int R_ID,int U_ID)
		{
			return dal.Exists(R_ID,U_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.UserRole model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.UserRole model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int R_ID,int U_ID)
		{
			
			return dal.Delete(R_ID,U_ID);
		}

                /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByUser(int U_ID)
        {
           return dal.DeleteByUser(U_ID);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.UserRole GetModel(int R_ID,int U_ID)
		{
			
			return dal.GetModel(R_ID,U_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.UserRole GetModelByCache(int R_ID,int U_ID)
		{
			
			string CacheKey = "UserRoleModel-" + R_ID+U_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(R_ID,U_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.UserRole)objModel;
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
		public List<Tellyes.Model.UserRole> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.UserRole> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.UserRole> modelList = new List<Tellyes.Model.UserRole>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.UserRole model;
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
        /// 添加用户与角色的关联信息（事务处理）
        /// </summary>
        /// <param name="rids"></param>
        /// <param name="uids"></param>
        /// <returns></returns>
        public bool InsertByTran(string rids, string uids)
        {
            return dal.InsertByTran(rids, uids);
        }

         /// <summary>
        /// 将用户从某一个角色中删除关联
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="uList"></param>
        /// <returns></returns>
        public bool DeleteUserFromRole(string rid, string uList)
        {
            return dal.DeleteUserFromRole(rid, uList);
        }

         /// <summary>
        /// 获得角色ID的集合，通过用户的ID
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string getRidList(int uid)
        {
            return dal.getRidList(uid);
        }

         /// <summary>
        /// 获得角色名称的集合，通过用户的ID
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string getRNameList(int uid)
        {
            return dal.getRNameList(uid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public List<Model.UserRole> SearchUserRoleByUserInfoID(int U_ID)
        {
            return new DAL.UserRole().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"U_ID", U_ID}
                },
                null
            );
        }

        //根据用户UID判断其角色
        public int GetRole(int UID)
        {
            int role = 0;
            DataTable dt = dal.GetRole(UID).Tables[0];
            int count = dt.Rows.Count;
            if (count > 0)
            {
                role = Convert.ToInt32(dt.Rows[0]["R_ID"].ToString());
            }

            return role;
        }

		#endregion  ExtensionMethod

        #region Extension NHibernate
		
		/// <summary>
		/// 添加UserRole记录
		/// </summary>
		/// <param name="userRole"></param>
		/// <returns></returns>
		public bool AddUserRole(Model.UserRole userRole)
		{
		    return new DAL.UserRole().Insert(userRole);
		}
		
		/// <summary>
        /// 删除UserRole记录
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public bool RemoveUserRole(Model.UserRole userRole)
        {
            return new DAL.UserRole().Delete(userRole);
        }
		
		/// <summary>
        /// 修改UserRole记录
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public bool ModifyUserRole(Model.UserRole userRole)
        {
            return new DAL.UserRole().Update((object)userRole);
        }
		
		/// <summary>
        /// 查询UserRole下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchUserRoleIdentity()
        {
            return new DAL.UserRole().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部UserRole记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchUserRoleCount()
        {
            return new DAL.UserRole().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询UserRole记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchUserRoleCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserRole().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定条件的UserRole是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchUserRoleExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserRole().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询第一个UserRole对象
        /// </summary>
        /// <returns></returns>
        public Model.UserRole SearchUniqueUserRoleByCondition()
        {
            return new DAL.UserRole().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个UserRole对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.UserRole SearchUniqueUserRoleByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserRole().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个UserRole对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.UserRole SearchUniqueUserRoleByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserRole().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部UserRole对象
        /// </summary>
        /// <returns></returns>
        public List<Model.UserRole> SearchUserRoleByCondition()
        {
            return new DAL.UserRole().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询UserRole对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.UserRole> SearchUserRoleByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserRole().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询UserRole对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.UserRole> SearchUserRoleByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserRole().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询UserRole内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.UserRole> SearchUserRoleByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.UserRole().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }
		
		#endregion

        #region 批量设置用户的角色
        /// <summary>
        /// 批量设置用户的角色
        /// </summary>
        /// <param name="userids"></param>
        /// <param name="roleids"></param>
        /// <returns></returns>
        public bool serialSetUserRole(string userids, string roleids) 
        {
            return dal.serialSetUserRole(userids, roleids) > 0 ? true : false;
        }
        #endregion




    }
}

