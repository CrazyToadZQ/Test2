using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //属性表
    public partial class UserProperty
    {

        private readonly Tellyes.DAL.UserProperty dal = new Tellyes.DAL.UserProperty();
        public UserProperty()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int UserPropertyID)
        {
            return dal.Exists(UserPropertyID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.UserProperty model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.UserProperty model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int UserPropertyID)
        {

            return dal.Delete(UserPropertyID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string UserPropertyIDlist)
        {
            return dal.DeleteList(UserPropertyIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.UserProperty GetModel(int UserPropertyID)
        {

            return dal.GetModel(UserPropertyID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.UserProperty GetModelByCache(int UserPropertyID)
        {

            string CacheKey = "UserPropertyModel-" + UserPropertyID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(UserPropertyID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.UserProperty)objModel;
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
        public List<Tellyes.Model.UserProperty> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.UserProperty> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.UserProperty> modelList = new List<Tellyes.Model.UserProperty>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.UserProperty model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.UserProperty();
                    if (dt.Rows[n]["UserPropertyID"].ToString() != "")
                    {
                        model.UserPropertyID = int.Parse(dt.Rows[n]["UserPropertyID"].ToString());
                    }
                    model.UserPropertyString4 = dt.Rows[n]["UserPropertyString4"].ToString();
                    model.UserPropertyString5 = dt.Rows[n]["UserPropertyString5"].ToString();
                    model.UserPropertyName = dt.Rows[n]["UserPropertyName"].ToString();
                    if (dt.Rows[n]["UserPropertyNumber1"].ToString() != "")
                    {
                        model.UserPropertyNumber1 = int.Parse(dt.Rows[n]["UserPropertyNumber1"].ToString());
                    }
                    if (dt.Rows[n]["UserPropertyNumber2"].ToString() != "")
                    {
                        model.UserPropertyNumber2 = int.Parse(dt.Rows[n]["UserPropertyNumber2"].ToString());
                    }
                    if (dt.Rows[n]["UserPropertyNumber3"].ToString() != "")
                    {
                        model.UserPropertyNumber3 = int.Parse(dt.Rows[n]["UserPropertyNumber3"].ToString());
                    }
                    if (dt.Rows[n]["UserPropertyNumber4"].ToString() != "")
                    {
                        model.UserPropertyNumber4 = int.Parse(dt.Rows[n]["UserPropertyNumber4"].ToString());
                    }
                    model.UserPropertyString1 = dt.Rows[n]["UserPropertyString1"].ToString();
                    model.UserPropertyString2 = dt.Rows[n]["UserPropertyString2"].ToString();
                    model.UserPropertyString3 = dt.Rows[n]["UserPropertyString3"].ToString();


                    modelList.Add(model);
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
        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加UserProperty记录
        /// </summary>
        /// <param name="userProperty"></param>
        /// <returns></returns>
        public bool AddUserProperty(Model.UserProperty userProperty)
        {
            return new DAL.UserProperty().Insert(userProperty);
        }

        /// <summary>
        /// 删除UserProperty记录
        /// </summary>
        /// <param name="userProperty"></param>
        /// <returns></returns>
        public bool RemoveUserProperty(Model.UserProperty userProperty)
        {
            return new DAL.UserProperty().Delete(userProperty);
        }

        /// <summary>
        /// 修改UserProperty记录
        /// </summary>
        /// <param name="userProperty"></param>
        /// <returns></returns>
        public bool ModifyUserProperty(Model.UserProperty userProperty)
        {
            return new DAL.UserProperty().Update((object)userProperty);
        }

        /// <summary>
        /// 查询UserProperty下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchUserPropertyIdentity()
        {
            return new DAL.UserProperty().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部UserProperty记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchUserPropertyCount()
        {
            return new DAL.UserProperty().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询UserProperty记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchUserPropertyCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserProperty().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定userPropertyID的UserProperty是否存在
        /// </summary>
        /// <param name="userPropertyID"></param>
        /// <returns></returns>
        public bool? SearchUserPropertyExists(object userPropertyID)
        {
            return new DAL.UserProperty().SelectModelObjectExistsByID(userPropertyID);
        }

        /// <summary>
        /// 查询指定条件的UserProperty是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchUserPropertyExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserProperty().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按userPropertyID查询UserProperty
        /// </summary>
        /// <param name="userPropertyID"></param>
        /// <returns></returns>
        public Model.UserProperty SearchUserPropertyByID(object userPropertyID)
        {
            return new DAL.UserProperty().SelectModelObjectByID(userPropertyID);
        }

        /// <summary>
        /// 查询第一个UserProperty对象
        /// </summary>
        /// <returns></returns>
        public Model.UserProperty SearchUniqueUserPropertyByCondition()
        {
            return new DAL.UserProperty().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个UserProperty对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.UserProperty SearchUniqueUserPropertyByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserProperty().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个UserProperty对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.UserProperty SearchUniqueUserPropertyByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserProperty().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部UserProperty对象
        /// </summary>
        /// <returns></returns>
        public List<Model.UserProperty> SearchUserPropertyByCondition()
        {
            return new DAL.UserProperty().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询UserProperty对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.UserProperty> SearchUserPropertyByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.UserProperty().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询UserProperty对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.UserProperty> SearchUserPropertyByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.UserProperty().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询UserProperty内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.UserProperty> SearchUserPropertyByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.UserProperty().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
