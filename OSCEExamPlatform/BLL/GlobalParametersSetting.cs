using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
  public  class GlobalParametersSetting
    {
        private readonly Tellyes.DAL.GlobalParametersSetting dal = new Tellyes.DAL.GlobalParametersSetting();
        public GlobalParametersSetting()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Global_Parameters_Setting_ID)
        {
            return dal.Exists(Global_Parameters_Setting_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.GlobalParametersSetting model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.GlobalParametersSetting model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Global_Parameters_Setting_ID)
        {

            return dal.Delete(Global_Parameters_Setting_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Global_Parameters_Setting_IDlist)
        {
            return dal.DeleteList(Global_Parameters_Setting_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.GlobalParametersSetting GetModel(int Global_Parameters_Setting_ID)
        {

            return dal.GetModel(Global_Parameters_Setting_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.GlobalParametersSetting GetModelByCache(int Global_Parameters_Setting_ID)
        {

            string CacheKey = "GlobalParametersSettingModel-" + Global_Parameters_Setting_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Global_Parameters_Setting_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.GlobalParametersSetting)objModel;
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
        public List<Tellyes.Model.GlobalParametersSetting> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.GlobalParametersSetting> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.GlobalParametersSetting> modelList = new List<Tellyes.Model.GlobalParametersSetting>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.GlobalParametersSetting model;
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
        /// 得到第一条记录（Top 1）
        /// </summary>
        public Tellyes.Model.GlobalParametersSetting GetModelTopOne()
        {
            return dal.GetModelTopOne();
        }
        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加GlobalParametersSetting记录
        /// </summary>
        /// <param name="globalParametersSetting"></param>
        /// <returns></returns>
        public bool AddGlobalParametersSetting(Model.GlobalParametersSetting globalParametersSetting)
        {
            return new DAL.GlobalParametersSetting().Insert(globalParametersSetting);
        }

        /// <summary>
        /// 删除GlobalParametersSetting记录
        /// </summary>
        /// <param name="globalParametersSetting"></param>
        /// <returns></returns>
        public bool RemoveGlobalParametersSetting(Model.GlobalParametersSetting globalParametersSetting)
        {
            return new DAL.GlobalParametersSetting().Delete(globalParametersSetting);
        }

        /// <summary>
        /// 修改GlobalParametersSetting记录
        /// </summary>
        /// <param name="globalParametersSetting"></param>
        /// <returns></returns>
        public bool ModifyGlobalParametersSetting(Model.GlobalParametersSetting globalParametersSetting)
        {
            return new DAL.GlobalParametersSetting().Update((object)globalParametersSetting);
        }

        /// <summary>
        /// 查询GlobalParametersSetting下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchGlobalParametersSettingIdentity()
        {
            return new DAL.GlobalParametersSetting().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部GlobalParametersSetting记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchGlobalParametersSettingCount()
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询GlobalParametersSetting记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchGlobalParametersSettingCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定global_Parameters_Setting_ID的GlobalParametersSetting是否存在
        /// </summary>
        /// <param name="global_Parameters_Setting_ID"></param>
        /// <returns></returns>
        public bool? SearchGlobalParametersSettingExists(object global_Parameters_Setting_ID)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectExistsByID(global_Parameters_Setting_ID);
        }

        /// <summary>
        /// 查询指定条件的GlobalParametersSetting是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchGlobalParametersSettingExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按global_Parameters_Setting_ID查询GlobalParametersSetting
        /// </summary>
        /// <param name="global_Parameters_Setting_ID"></param>
        /// <returns></returns>
        public Model.GlobalParametersSetting SearchGlobalParametersSettingByID(object global_Parameters_Setting_ID)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectByID(global_Parameters_Setting_ID);
        }

        /// <summary>
        /// 查询第一个GlobalParametersSetting对象
        /// </summary>
        /// <returns></returns>
        public Model.GlobalParametersSetting SearchUniqueGlobalParametersSettingByCondition()
        {
            return new DAL.GlobalParametersSetting().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个GlobalParametersSetting对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.GlobalParametersSetting SearchUniqueGlobalParametersSettingByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.GlobalParametersSetting().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个GlobalParametersSetting对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.GlobalParametersSetting SearchUniqueGlobalParametersSettingByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.GlobalParametersSetting().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部GlobalParametersSetting对象
        /// </summary>
        /// <returns></returns>
        public List<Model.GlobalParametersSetting> SearchGlobalParametersSettingByCondition()
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询GlobalParametersSetting对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.GlobalParametersSetting> SearchGlobalParametersSettingByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询GlobalParametersSetting对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.GlobalParametersSetting> SearchGlobalParametersSettingByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询GlobalParametersSetting内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.GlobalParametersSetting> SearchGlobalParametersSettingByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.GlobalParametersSetting().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
    }
}
