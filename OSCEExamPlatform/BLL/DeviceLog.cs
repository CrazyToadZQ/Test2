using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Model;
using Tellyes.DAL;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    //DeviceLog
    public partial class DeviceLog
    {

        private readonly Tellyes.DAL.DeviceLog dal = new Tellyes.DAL.DeviceLog();

        public DeviceLog()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DL_ID)
        {
            return dal.Exists(DL_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceLog model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceLog model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DL_ID)
        {

            return dal.Delete(DL_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string DL_IDlist)
        {
            return dal.DeleteList(DL_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceLog GetModel(int DL_ID)
        {

            return dal.GetModel(DL_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceLog GetModelByCache(int DL_ID)
        {

            string CacheKey = "DeviceLogModel-" + DL_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DL_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceLog)objModel;
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
        public List<Tellyes.Model.DeviceLog> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceLog> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceLog> modelList = new List<Tellyes.Model.DeviceLog>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceLog model;
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
        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加DeviceLog记录
        /// </summary>
        /// <param name="deviceLog"></param>
        /// <returns></returns>
        public bool AddDeviceLog(Model.DeviceLog deviceLog)
        {
            return new DAL.DeviceLog().Insert(deviceLog);
        }

        /// <summary>
        /// 删除DeviceLog记录
        /// </summary>
        /// <param name="deviceLog"></param>
        /// <returns></returns>
        public bool RemoveDeviceLog(Model.DeviceLog deviceLog)
        {
            return new DAL.DeviceLog().Delete(deviceLog);
        }

        /// <summary>
        /// 修改DeviceLog记录
        /// </summary>
        /// <param name="deviceLog"></param>
        /// <returns></returns>
        public bool ModifyDeviceLog(Model.DeviceLog deviceLog)
        {
            return new DAL.DeviceLog().Update((object)deviceLog);
        }

        /// <summary>
        /// 查询DeviceLog下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceLogIdentity()
        {
            return new DAL.DeviceLog().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceLog记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceLogCount()
        {
            return new DAL.DeviceLog().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceLog记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceLogCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceLog().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dL_ID的DeviceLog是否存在
        /// </summary>
        /// <param name="dL_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceLogExists(object dL_ID)
        {
            return new DAL.DeviceLog().SelectModelObjectExistsByID(dL_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceLog是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceLogExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceLog().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dL_ID查询DeviceLog
        /// </summary>
        /// <param name="dL_ID"></param>
        /// <returns></returns>
        public Model.DeviceLog SearchDeviceLogByID(object dL_ID)
        {
            return new DAL.DeviceLog().SelectModelObjectByID(dL_ID);
        }

        /// <summary>
        /// 查询第一个DeviceLog对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceLog SearchUniqueDeviceLogByCondition()
        {
            return new DAL.DeviceLog().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceLog SearchUniqueDeviceLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceLog().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceLog SearchUniqueDeviceLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceLog().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceLog对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceLog> SearchDeviceLogByCondition()
        {
            return new DAL.DeviceLog().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceLog> SearchDeviceLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceLog().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceLog> SearchDeviceLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceLog().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceLog内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceLog> SearchDeviceLogByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceLog().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion




         /// <summary>
        /// 按条件查询日志信息总记录数（deviceLog表，device表，deviceClass表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectDeviceLogInfoTotalRowCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            int? totalCount = new DAL.DeviceLog().SelectDeviceLogInfoTotalRowCountByCondition(conditionDictionary);
            return totalCount;
        }

        

        /// <summary>
        /// 查询设备日志信息（deviceLog表，device表，deviceClass表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SelectDeviceLogInfoPageByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> deviceLogList = new DAL.DeviceLog().SelectDeviceLogInfoPageByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (deviceLogList == null)
            {
                Log4NetUtility.Error(this, "deviceLog设备日志信息查询失败！");
                return null;
            }


            List<Dictionary<string, object>> LogDictionaryList = new List<Dictionary<string, object>>();
            foreach (object[] LogObject in deviceLogList)
            {
                LogDictionaryList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"DeviceLog", LogObject[0]},
                        {"D_SerialNumber", LogObject[1]},
                        {"D_Name", LogObject[2]},
                        {"D_State", LogObject[3]},
                        {"DC_ID", LogObject[4]},
                        {"DC_Name", LogObject[5]}
                    }
                );
            }

            return LogDictionaryList;
        }

        #endregion
    }
}
