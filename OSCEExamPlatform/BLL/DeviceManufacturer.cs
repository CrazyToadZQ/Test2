using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Tellyes.BLL
{
    /// <summary>
    /// DeviceManufacturer
    /// </summary>
    public partial class DeviceManufacturer
    {
        private readonly Tellyes.DAL.DeviceManufacturer dal = new Tellyes.DAL.DeviceManufacturer();
        public DeviceManufacturer()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DMA_ID)
        {
            return dal.Exists(DMA_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceManufacturer model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceManufacturer model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DMA_ID)
        {

            return dal.Delete(DMA_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string DMA_IDlist)
        {
            return dal.DeleteList(DMA_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceManufacturer GetModel(int DMA_ID)
        {

            return dal.GetModel(DMA_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceManufacturer GetModelByCache(int DMA_ID)
        {

            string CacheKey = "DeviceManufacturerModel-" + DMA_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DMA_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceManufacturer)objModel;
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
        public List<Tellyes.Model.DeviceManufacturer> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceManufacturer> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceManufacturer> modelList = new List<Tellyes.Model.DeviceManufacturer>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceManufacturer model;
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

        public List<Model.DeviceManufacturer> SearchDeviceManufacturer()
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 添加DeviceManufacturer记录
        /// </summary>
        /// <param name="deviceManufacturer"></param>
        /// <returns></returns>
        public bool AddDeviceManufacturer(Model.DeviceManufacturer deviceManufacturer)
        {
            return new DAL.DeviceManufacturer().Insert(deviceManufacturer);
        }

        /// <summary>
        /// 删除DeviceManufacturer记录
        /// </summary>
        /// <param name="deviceManufacturer"></param>
        /// <returns></returns>
        public bool RemoveDeviceManufacturer(Model.DeviceManufacturer deviceManufacturer)
        {
            return new DAL.DeviceManufacturer().Delete(deviceManufacturer);
        }

        /// <summary>
        /// 修改DeviceManufacturer记录
        /// </summary>
        /// <param name="deviceManufacturer"></param>
        /// <returns></returns>
        public bool ModifyDeviceManufacturer(Model.DeviceManufacturer deviceManufacturer)
        {
            return new DAL.DeviceManufacturer().Update((object)deviceManufacturer);
        }

        /// <summary>
        /// 查询DeviceManufacturer下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceManufacturerIdentity()
        {
            return new DAL.DeviceManufacturer().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceManufacturer记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceManufacturerCount()
        {
            return new DAL.DeviceManufacturer().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceManufacturer记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceManufacturerCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dM_ID的DeviceManufacturer是否存在
        /// </summary>
        /// <param name="dM_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceManufacturerExists(object dM_ID)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectExistsByID(dM_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceManufacturer是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceManufacturerExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dM_ID查询DeviceManufacturer
        /// </summary>
        /// <param name="dM_ID"></param>
        /// <returns></returns>
        public Model.DeviceManufacturer SearchDeviceManufacturerByID(object dM_ID)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByID(dM_ID);
        }

        /// <summary>
        /// 查询第一个DeviceManufacturer对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceManufacturer SearchUniqueDeviceManufacturerByCondition()
        {
            return new DAL.DeviceManufacturer().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceManufacturer对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceManufacturer SearchUniqueDeviceManufacturerByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceManufacturer().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceManufacturer对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceManufacturer SearchUniqueDeviceManufacturerByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceManufacturer().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceManufacturer对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceManufacturer> SearchDeviceManufacturerByCondition()
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceManufacturer对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceManufacturer> SearchDeviceManufacturerByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceManufacturer对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceManufacturer> SearchDeviceManufacturerByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceManufacturer内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceManufacturer> SearchDeviceManufacturerByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceManufacturer().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }



        #endregion  ExtensionMethod
    }
}
