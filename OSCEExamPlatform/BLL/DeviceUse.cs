using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
  public  class DeviceUse
    {

        private readonly Tellyes.DAL.DeviceUse dal = new Tellyes.DAL.DeviceUse();
        public DeviceUse()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DU_ID)
        {
            return dal.Exists(DU_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceUse model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceUse model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DU_ID)
        {

            return dal.Delete(DU_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string DU_IDlist)
        {
            return dal.DeleteList(DU_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceUse GetModel(int DU_ID)
        {

            return dal.GetModel(DU_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceUse GetModelByCache(int DU_ID)
        {

            string CacheKey = "DeviceUseModel-" + DU_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DU_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceUse)objModel;
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
        public List<Tellyes.Model.DeviceUse> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceUse> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceUse> modelList = new List<Tellyes.Model.DeviceUse>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceUse model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.DeviceUse();
                    if (dt.Rows[n]["DU_ID"].ToString() != "")
                    {
                        model.DU_ID = int.Parse(dt.Rows[n]["DU_ID"].ToString());
                    }
                    if (dt.Rows[n]["DU_Number3"].ToString() != "")
                    {
                        model.DU_Number3 = int.Parse(dt.Rows[n]["DU_Number3"].ToString());
                    }
                    if (dt.Rows[n]["DU_Number4"].ToString() != "")
                    {
                        model.DU_Number4 = int.Parse(dt.Rows[n]["DU_Number4"].ToString());
                    }
                    model.DU_String1 = dt.Rows[n]["DU_String1"].ToString();
                    model.DU_String2 = dt.Rows[n]["DU_String2"].ToString();
                    model.DU_String3 = dt.Rows[n]["DU_String3"].ToString();
                    model.DU_String4 = dt.Rows[n]["DU_String4"].ToString();
                    model.DU_String5 = dt.Rows[n]["DU_String5"].ToString();
                    if (dt.Rows[n]["D_ID"].ToString() != "")
                    {
                        model.D_ID = int.Parse(dt.Rows[n]["D_ID"].ToString());
                    }
                    if (dt.Rows[n]["E_ID"].ToString() != "")
                    {
                        model.E_ID = Guid.Parse(dt.Rows[n]["E_ID"].ToString());
                    }
                    if (dt.Rows[n]["RoomID"].ToString() != "")
                    {
                        model.RoomID = int.Parse(dt.Rows[n]["RoomID"].ToString());
                    }
                    if (dt.Rows[n]["DU_StartTime"].ToString() != "")
                    {
                        model.DU_StartTime = DateTime.Parse(dt.Rows[n]["DU_StartTime"].ToString());
                    }
                    if (dt.Rows[n]["DU_EndTime"].ToString() != "")
                    {
                        model.DU_EndTime = DateTime.Parse(dt.Rows[n]["DU_EndTime"].ToString());
                    }
                    if (dt.Rows[n]["DU_TimeSpan"].ToString() != "")
                    {
                        model.DU_TimeSpan = int.Parse(dt.Rows[n]["DU_TimeSpan"].ToString());
                    }
                    if (dt.Rows[n]["DU_Number1"].ToString() != "")
                    {
                        model.DU_Number1 = int.Parse(dt.Rows[n]["DU_Number1"].ToString());
                    }
                    if (dt.Rows[n]["DU_Number2"].ToString() != "")
                    {
                        model.DU_Number2 = int.Parse(dt.Rows[n]["DU_Number2"].ToString());
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
        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加DeviceUse记录
        /// </summary>
        /// <param name="deviceUse"></param>
        /// <returns></returns>
        public bool AddDeviceUse(Model.DeviceUse deviceUse)
        {
            return new DAL.DeviceUse().Insert(deviceUse);
        }

        /// <summary>
        /// 删除DeviceUse记录
        /// </summary>
        /// <param name="deviceUse"></param>
        /// <returns></returns>
        public bool RemoveDeviceUse(Model.DeviceUse deviceUse)
        {
            return new DAL.DeviceUse().Delete(deviceUse);
        }

        /// <summary>
        /// 修改DeviceUse记录
        /// </summary>
        /// <param name="deviceUse"></param>
        /// <returns></returns>
        public bool ModifyDeviceUse(Model.DeviceUse deviceUse)
        {
            return new DAL.DeviceUse().Update((object)deviceUse);
        }

        /// <summary>
        /// 查询DeviceUse下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceUseIdentity()
        {
            return new DAL.DeviceUse().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceUse记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceUseCount()
        {
            return new DAL.DeviceUse().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceUse记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceUseCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceUse().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dU_ID的DeviceUse是否存在
        /// </summary>
        /// <param name="dU_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceUseExists(object dU_ID)
        {
            return new DAL.DeviceUse().SelectModelObjectExistsByID(dU_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceUse是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceUseExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceUse().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dU_ID查询DeviceUse
        /// </summary>
        /// <param name="dU_ID"></param>
        /// <returns></returns>
        public Model.DeviceUse SearchDeviceUseByID(object dU_ID)
        {
            return new DAL.DeviceUse().SelectModelObjectByID(dU_ID);
        }

        /// <summary>
        /// 查询第一个DeviceUse对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceUse SearchUniqueDeviceUseByCondition()
        {
            return new DAL.DeviceUse().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceUse对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceUse SearchUniqueDeviceUseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceUse().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceUse对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceUse SearchUniqueDeviceUseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceUse().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceUse对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceUse> SearchDeviceUseByCondition()
        {
            return new DAL.DeviceUse().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceUse对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceUse> SearchDeviceUseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceUse().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceUse对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceUse> SearchDeviceUseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceUse().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceUse内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceUse> SearchDeviceUseByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceUse().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion

        #endregion
    }
}
