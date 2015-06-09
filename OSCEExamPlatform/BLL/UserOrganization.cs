using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using System.Linq;
using Tellyes.Log4Net;
namespace Tellyes.BLL
{
	/// <summary>
	/// 用户与组织机构关系表
	/// </summary>
	public partial class UserOrganization
	{
		private readonly Tellyes.DAL.UserOrganization dal=new Tellyes.DAL.UserOrganization();
		public UserOrganization()
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
		public bool Exists(int O_ID,int U_ID)
		{
			return dal.Exists(O_ID,U_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tellyes.Model.UserOrganization model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.UserOrganization model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int O_ID,int U_ID)
		{
			
			return dal.Delete(O_ID,U_ID);
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
		public Tellyes.Model.UserOrganization GetModel(int O_ID,int U_ID)
		{
			
			return dal.GetModel(O_ID,U_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.UserOrganization GetModelByCache(int O_ID,int U_ID)
		{
			
			string CacheKey = "UserOrganizationModel-" + O_ID+U_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(O_ID,U_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.UserOrganization)objModel;
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
		public List<Tellyes.Model.UserOrganization> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.UserOrganization> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.UserOrganization> modelList = new List<Tellyes.Model.UserOrganization>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.UserOrganization model;
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
        /// 根据用户ID获得组织机构ID的集合
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public string getOids(int U_ID)
        {
            return dal.getOids(U_ID);
        }

        /// <summary>
        /// 参加某次考试的班级学生信息
        /// </summary>
        /// <param name="classID">班级id</param>
        /// <param name="noStudentIDs">未参加考试的学生id（例如：'1','2','3'）</param>
        /// <returns></returns>
        public DataSet GetClassExamStudentInfo(int classID, string noStudentIDs)
        {
            return dal.GetClassExamStudentInfo(classID, noStudentIDs);
        }

        /// <summary>
        /// 按条件查询ExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Tellyes.Model.UserOrganization> SearchUserOrganizationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserOrganization().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoIDList"></param>
        /// <returns></returns>
        public List<int> SearchOrganizationIDByUserInfoIDList(List<int> userInfoIDList)
        {
            List<object> organizationIDObjectList = new DAL.UserOrganization().SelectOrganizationIDByUserInfoIDList(userInfoIDList);
            if (organizationIDObjectList == null)
            {
                Log4NetUtility.Error(this, "查询考生所在组织机构信息失败");
                return null;
            }
            List<int> organizationIDList = new List<int>();
            foreach (object organizationIDObject in organizationIDObjectList) 
            {
                if (organizationIDObject != null)
                {
                    organizationIDList.Add(Convert.ToInt32(organizationIDObject));
                }
                else
                {
                    organizationIDList.Add(-1);
                }
            }
            return organizationIDList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoIDList"></param>
        /// <returns></returns>
        public Dictionary<int, List<int>> SearchOrganizationIDUserInfoIDByCondition(List<int> userInfoIDList)
        {
            List<object[]> organizationUserInfoIDList = new DAL.UserOrganization().SelectOrganizationIDUserInfoIDByCondition(userInfoIDList);
            if (organizationUserInfoIDList == null)
            {
                Log4NetUtility.Error(this, "查询考生所在组织机构信息失败");
                return null;
            }
            Dictionary<int, List<int>> organizationIDStudentIDDictionary=new Dictionary<int,List<int>>();
            List<int> userinfoIDList = new List<int>();
            int preOrganizationID = -1;
            foreach(object[] obj in organizationUserInfoIDList){
                int  organizationID = obj[0]==null?-1:Convert.ToInt32(obj[0]);
                int userinfoID = Convert.ToInt32(obj[1]);
                if (organizationID == preOrganizationID)
                {
                    userinfoIDList.Add(userinfoID);
                }
                else
                {
                    if (userinfoIDList.Count > 0)
                    {
                        organizationIDStudentIDDictionary.Add(preOrganizationID, userinfoIDList);
                    }
                    preOrganizationID = organizationID;
                    userinfoIDList = new List<int>();
                    userinfoIDList.Add(userinfoID);
                }
            }
            organizationIDStudentIDDictionary.Add(preOrganizationID, userinfoIDList);
            return organizationIDStudentIDDictionary;
        }

		#endregion  ExtensionMethod
	}
}

