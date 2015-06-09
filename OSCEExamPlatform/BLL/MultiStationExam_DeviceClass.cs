using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class MultiStationExam_DeviceClass
    {
        private readonly DAL.MultiStationExam_DeviceClass dal = new DAL.MultiStationExam_DeviceClass();
        public MultiStationExam_DeviceClass()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSE_DC_ID)
        {
            return dal.Exists(MSE_DC_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MultiStationExam_DeviceClass model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.MultiStationExam_DeviceClass model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MSE_DC_ID)
        {

            return dal.Delete(MSE_DC_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string MSE_DC_IDlist)
        {
            return dal.DeleteList(MSE_DC_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.MultiStationExam_DeviceClass GetModel(int MSE_DC_ID)
        {

            return dal.GetModel(MSE_DC_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.MultiStationExam_DeviceClass GetModelByCache(int MSE_DC_ID)
        {

            string CacheKey = "MultiStationExam_DeviceClassModel-" + MSE_DC_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MSE_DC_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.MultiStationExam_DeviceClass)objModel;
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
        public List<Model.MultiStationExam_DeviceClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.MultiStationExam_DeviceClass> DataTableToList(DataTable dt)
        {
            List<Model.MultiStationExam_DeviceClass> modelList = new List<Model.MultiStationExam_DeviceClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.MultiStationExam_DeviceClass model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.MultiStationExam_DeviceClass();
                    if (dt.Rows[n]["MSE_DC_ID"].ToString() != "")
                    {
                        model.MSE_DC_ID = int.Parse(dt.Rows[n]["MSE_DC_ID"].ToString());
                    }
                    if (dt.Rows[n]["E_ID"].ToString() != "")
                    {
                        model.E_ID = Guid.Parse(dt.Rows[n]["E_ID"].ToString());
                    }
                    if (dt.Rows[n]["ES_ID"].ToString() != "")
                    {
                        model.ES_ID = Guid.Parse(dt.Rows[n]["ES_ID"].ToString());
                    }
                    if (dt.Rows[n]["Room_ID"].ToString() != "")
                    {
                        model.Room_ID = int.Parse(dt.Rows[n]["Room_ID"].ToString());
                    }
                    if (dt.Rows[n]["DC_ID"].ToString() != "")
                    {
                        model.DC_ID = int.Parse(dt.Rows[n]["DC_ID"].ToString());
                    }
                    if (dt.Rows[n]["DC_Count"].ToString() != "")
                    {
                        model.DC_Count = int.Parse(dt.Rows[n]["DC_Count"].ToString());
                    }


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

        #region Extension NHibernate

        /// <summary>
        /// 添加MultiStationExam_DeviceClass记录
        /// </summary>
        /// <param name="multiStationExam_DeviceClass"></param>
        /// <returns></returns>
        public bool AddMultiStationExam_DeviceClass(Model.MultiStationExam_DeviceClass multiStationExam_DeviceClass)
        {
            return new DAL.MultiStationExam_DeviceClass().Insert(multiStationExam_DeviceClass);
        }

        /// <summary>
        /// 删除MultiStationExam_DeviceClass记录
        /// </summary>
        /// <param name="multiStationExam_DeviceClass"></param>
        /// <returns></returns>
        public bool RemoveMultiStationExam_DeviceClass(Model.MultiStationExam_DeviceClass multiStationExam_DeviceClass)
        {
            return new DAL.MultiStationExam_DeviceClass().Delete(multiStationExam_DeviceClass);
        }

        /// <summary>
        /// 修改MultiStationExam_DeviceClass记录
        /// </summary>
        /// <param name="multiStationExam_DeviceClass"></param>
        /// <returns></returns>
        public bool ModifyMultiStationExam_DeviceClass(Model.MultiStationExam_DeviceClass multiStationExam_DeviceClass)
        {
            return new DAL.MultiStationExam_DeviceClass().Update((object)multiStationExam_DeviceClass);
        }

        /// <summary>
        /// 查询MultiStationExam_DeviceClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExam_DeviceClassIdentity()
        {
            return new DAL.MultiStationExam_DeviceClass().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部MultiStationExam_DeviceClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExam_DeviceClassCount()
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExam_DeviceClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchMultiStationExam_DeviceClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定mSE_DC_ID的MultiStationExam_DeviceClass是否存在
        /// </summary>
        /// <param name="mSE_DC_ID"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExam_DeviceClassExists(object mSE_DC_ID)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectExistsByID(mSE_DC_ID);
        }

        /// <summary>
        /// 查询指定条件的MultiStationExam_DeviceClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExam_DeviceClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按mSE_DC_ID查询MultiStationExam_DeviceClass
        /// </summary>
        /// <param name="mSE_DC_ID"></param>
        /// <returns></returns>
        public Model.MultiStationExam_DeviceClass SearchMultiStationExam_DeviceClassByID(object mSE_DC_ID)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectByID(mSE_DC_ID);
        }

        /// <summary>
        /// 查询第一个MultiStationExam_DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public Model.MultiStationExam_DeviceClass SearchUniqueMultiStationExam_DeviceClassByCondition()
        {
            return new DAL.MultiStationExam_DeviceClass().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个MultiStationExam_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.MultiStationExam_DeviceClass SearchUniqueMultiStationExam_DeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个MultiStationExam_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.MultiStationExam_DeviceClass SearchUniqueMultiStationExam_DeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部MultiStationExam_DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.MultiStationExam_DeviceClass> SearchMultiStationExam_DeviceClassByCondition()
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExam_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_DeviceClass> SearchMultiStationExam_DeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询MultiStationExam_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_DeviceClass> SearchMultiStationExam_DeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询MultiStationExam_DeviceClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_DeviceClass> SearchMultiStationExam_DeviceClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.MultiStationExam_DeviceClass().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #endregion
    }
}
