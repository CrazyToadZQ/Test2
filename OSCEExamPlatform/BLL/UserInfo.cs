using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
using System.Collections;
namespace Tellyes.BLL
{
	/// <summary>
	/// 用户信息表
	/// </summary>
    public partial class UserInfo
    {
        private Tellyes.DAL.UserInfo dal = new Tellyes.DAL.UserInfo();
        public UserInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID)
        {
            return dal.Exists(U_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.UserInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.UserInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int U_ID)
        {

            return dal.DelByTran(U_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string U_IDlist)
        {
            return dal.DelListByTran(U_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.UserInfo GetModel(int U_ID)
        {

            return dal.GetModel(U_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.UserInfo GetModelByCache(int U_ID)
        {

            string CacheKey = "UserInfoModel-" + U_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(U_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.UserInfo)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.UserInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.UserInfo> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.UserInfo> modelList = new List<Tellyes.Model.UserInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.UserInfo model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string U_Name)
        {
            return dal.Exists(U_Name);
        }

        /// <summary>
        /// 将页面中的显示数据的表格，转换为Excel显示的表格并返回
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ht"></param>
        /// <returns></returns>
        public DataSet GetExcleDS(List<string> list, Hashtable ht, DataSet ds, int rid)
        {
            return dal.GetExcleDS(list, ht, ds, rid);
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="uList"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public bool ImportUser(List<Model.UserInfo> uList, ref string err, List<Int32> roleIDList = null)
        {
            return dal.ImportUser(uList, ref err, roleIDList);
        }

         /// <summary>
        /// 根据组织机构的ID集合，获得相应的学生
        /// </summary>
        /// <param name="OIDList"></param>
        /// <returns></returns>
        public DataSet getUserByOrganization(string OIDList)
        {
            return dal.getUserByOrganization(OIDList);
        }

        /// <summary>
        /// 添加一个User（事务处理，包括添加用户的角色集合，以及组织机构集合）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="rids"></param>
        /// <param name="oids"></param>
        /// <returns></returns>
        public bool InsertByTran(Model.UserInfo model, string rids, string oids, string managementoids)
        {
            return dal.InsertByTran(model, rids, oids, managementoids);
        }

         /// <summary>
        /// 修改一个用户（事务处理，包括更改角色的变更信息，以及组织机构的变更信息）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="rids"></param>
        /// <param name="oids"></param>
        /// <returns></returns>
        public bool UpdByTran(Model.UserInfo model, string rids, string oids, string managementoids)
        {
            return dal.UpdByTran(model, rids, oids, managementoids);
        }

        /// <summary>
        /// 验证登陆的合法性
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public Model.UserInfo ValidateLogin(string userName, string Password)
        {
            return dal.ValidateLogin(userName, Password);
        }

        /// <summary>
        /// 根据用户信息，查询符合条件的用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <returns></returns>
        public DataSet getUserByInfo(string name, string ridList, string OID)
        {
            return dal.getUserByInfo(name, ridList, OID);
        }


        #region 根据用户信息查询符合条件的用户信息主要是用于筛序导出数据
        /// <summary>
        /// 根据用户信息查询符合条件的用户信息主要是用于筛序导出数据
        /// </summary>string name, string ridList, string OID, string CurrentPage, string pagesize
        /// <returns></returns>
        public DataSet getUserByInfos(string name, string ridList, string OID, string CurrentPage, string pagesize) 
        {
            DataTable dt_tempary = new DataTable();
            dt_tempary = dal.getUserbyInfos(name, ridList, OID).Tables[0];
            DataTable dt_new = new DataTable();
            DataTable dt_new_copy = new DataTable();
            dt_new = dt_tempary.Clone();
            foreach(System.Data.DataRow drow in  dt_tempary.Rows)
            {
               bool flag = true;//这是一个标识信息，用来判断是否相等
               string temp = string.Empty;
               if (dt_new.Rows.Count > 0)
               {
                   for (int item = 0; item < dt_new.Rows.Count;item++ )
                   {
                       if (drow["U_ID"].ToString() == dt_new.Rows[item]["U_ID"].ToString())
                       {
                           if (drow["R_ID"].ToString() != dt_new.Rows[item]["R_ID"].ToString()) 
                           {
                               dt_new.Rows[item]["R_Name"] = dt_new.Rows[item]["R_Name"].ToString() + "," + drow["R_Name"].ToString();
                           }
                           flag = false;
                           break;
                       }
                      
                   }

                   if(flag)
                   {
                       dt_new.Rows.Add(drow.ItemArray);

                   }
               }
               else {
                   dt_new.Rows.Add(drow.ItemArray);
               }
            
            }
            DataSet ds_infos = new DataSet();
            ds_infos.Tables.Add(dt_new);

            #region 分页
            
            #endregion

            return ds_infos;
        }
        #endregion


        #region 根据用户信息查询符合条件的用户信息主要是用于筛序导出数据
        /// <summary>
        /// 根据用户信息查询符合条件的用户信息主要是用于筛序导出数据
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <returns></returns>
        public DataSet getUserByInfosCount(string name, string ridList, string OID)
        {
            return dal.getUserByInfosCount(name, ridList, OID);
        }
        #endregion


        #region 查询总的记录数量
        /// <summary>
        /// 查询总的记录数量
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <returns></returns>
        public object getTotalUserInfosRecords(string name, string ridList, string OID) 
        {
            return dal.getTotalUserInfosRecords(name,ridList,OID);
        }
        #endregion

        public string getUserIdByUserName(string name)
        {
           return dal.getUserIdByUserName(name);
        }

        /// <summary>
        /// 根据角色获得用户的集合
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public DataSet getUserByRid(int rid)
        {
            return dal.getUserByRid(rid);
        }

        /// <summary>
        /// 根据角色获得用户的集合
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByRoleID(int roleID)
        {
            return new DAL.UserInfo().SelectUserInfoByRoleID(roleID);
        }

        /// <summary>
        /// 根据用户ID数组获取排除这些ID后的用户集合
        /// </summary>
        /// <param name="userInfoIDList"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByRoleIDAndExcludeUserInfoIDList(int roleID, List<int> userInfoIDList)
        {
            return new DAL.UserInfo().SelectUserInfoByRoleIDAndExcludeUserInfoIDList(roleID, userInfoIDList);
        }

        /// <summary>
        /// 带条件查询指定Role_ID用户信息和组织机构信息
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchUserInfoAndOrganizationByRoleID(int roleID, Dictionary<string, object> conditionDictionary)
        {
            List<object[]> objectList = new DAL.UserInfo().SelectUserInfoAndOrganizationByRoleID(roleID, conditionDictionary);
            if (objectList == null) 
            {
                Log4NetUtility.Error(this, "查询RoleID为" + roleID + "的用户信息失败");
                return null;
            }

            List<Dictionary<string, object>> itemList = new List<Dictionary<string, object>>();
            for (int i = 0; i < objectList.Count; i++ )
            {
                itemList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"UserInfo", objectList[i][0]},
                        {"Organization", objectList[i][1]}
                    }
                );
            }
            return itemList;
        }

        /// <summary>
        /// 按用户ID查询用户信息
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public Model.UserInfo SearchUserInfoByUserID(int U_ID)
        {
            return new DAL.UserInfo().SelectModelObjectByID(U_ID);
        }

        /// <summary>
        /// 查询用户登录信息
        /// </summary>
        /// <param name="U_Name"></param>
        /// <param name="U_PWD"></param>
        /// <returns></returns>
        public Model.UserInfo SearchUserInfoLogin(string U_Name, string U_PWD)
        {
            List<Model.UserInfo> userInfoList = new DAL.UserInfo().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"U_Name", U_Name},
                    {"U_PWD", U_PWD}
                },
                null
            );
            if (userInfoList == null)
            {
                Log4NetUtility.Error(this, "查询用户信息失败");
                return null;
            }
            return userInfoList.Count >0 ? userInfoList[0] : null;
        }

        /// <summary>
        /// 按考试的ID和考生的考号查询学生用户信息和所属班级信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="Exam_Student_Code"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchUserInfoAndOrganizationByExamIDAndExamStudentNumber(int E_ID, int Exam_Student_Code)
        {
            List<object[]> itemList = new DAL.UserInfo().SelectUserInfoAndOrganizationByExamIDAndExamStudentNumber(E_ID, Exam_Student_Code);
            if (itemList == null)
            {
                Log4NetUtility.Error(this, "查询考试学生信息失败");
                return null;
            }

            Dictionary<string, object> itemDictionary = new Dictionary<string, object>()
            { 
                {"UserInfo", itemList[0][0]},
                {"Organization", itemList[0][1]}
            };
            return itemDictionary;
        }

        /// <summary>
        /// 按考试的ID和考生的学号查询学生用户信息和所属班级信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_Name"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchUserInfoAndOrganizationByExamIDAndExamStudentNumber(int E_ID, string U_Name)
        {
            List<object[]> itemList = new DAL.UserInfo().SelectUserInfoAndOrganizationByExamIDAndExamStudentNumber(E_ID, U_Name);
            if (itemList == null)
            {
                Log4NetUtility.Error(this, "查询考试学生信息失败");
                return null;
            }

            Dictionary<string, object> itemDictionary = new Dictionary<string, object>()
            { 
                {"UserInfo", itemList[0][0]},
                {"Organization", itemList[0][1]}
            };
            return itemDictionary;
        }

        /// <summary>
        /// 按照条件对象查询用户数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchUserInfoCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new Tellyes.DAL.UserInfo().SelectUserInfoCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按照条件对象查询用户分页数据
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoInPageByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            return new Tellyes.DAL.UserInfo().SelectUserInfoInPageByCondition(conditionDictionary, pageIndex, pageSize);
        }

        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加UserInfo记录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool AddUserInfo(Model.UserInfo userInfo)
        {
            return new DAL.UserInfo().Insert(userInfo);
        }

        /// <summary>
        /// 删除UserInfo记录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool RemoveUserInfo(Model.UserInfo userInfo)
        {
            return new DAL.UserInfo().Delete(userInfo);
        }

        /// <summary>
        /// 修改UserInfo记录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool ModifyUserInfo(Model.UserInfo userInfo)
        {
            return new DAL.UserInfo().Update((object)userInfo);
        }

        /// <summary>
        /// 查询UserInfo下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchUserInfoIdentity()
        {
            return new DAL.UserInfo().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部UserInfo记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchUserInfoCount()
        {
            return new DAL.UserInfo().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询UserInfo记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchUserInfoCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserInfo().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定u_ID的UserInfo是否存在
        /// </summary>
        /// <param name="u_ID"></param>
        /// <returns></returns>
        public bool? SearchUserInfoExists(object u_ID)
        {
            return new DAL.UserInfo().SelectModelObjectExistsByID(u_ID);
        }

        /// <summary>
        /// 查询指定条件的UserInfo是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchUserInfoExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserInfo().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按u_ID查询UserInfo
        /// </summary>
        /// <param name="u_ID"></param>
        /// <returns></returns>
        public Model.UserInfo SearchUserInfoByID(object u_ID)
        {
            return new DAL.UserInfo().SelectModelObjectByID(u_ID);
        }

        /// <summary>
        /// 查询第一个UserInfo对象
        /// </summary>
        /// <returns></returns>
        public Model.UserInfo SearchUniqueUserInfoByCondition()
        {
            return new DAL.UserInfo().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个UserInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.UserInfo SearchUniqueUserInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserInfo().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个UserInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.UserInfo SearchUniqueUserInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserInfo().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部UserInfo对象
        /// </summary>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByCondition()
        {
            return new DAL.UserInfo().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询UserInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserInfo().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询UserInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserInfo().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询UserInfo内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SearchUserInfoByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.UserInfo().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region 添加用户涉及的角色 --组织等
        /// <summary>
        /// 添加用户涉及的角色 --组织等
        /// </summary>
        /// <returns></returns>
        public bool addUserBasicInfos(Tellyes.Model.UserInfo user, string organizationIDS, List<string> roleList,List<string> classList) 
        {
            return dal.addUserBasicInfos(user, organizationIDS, roleList, classList) > 0 ? true : false;
        
        }
        #endregion
    }
}

