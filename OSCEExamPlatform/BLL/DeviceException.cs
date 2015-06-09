using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //设备异常表
    public partial class DeviceException
    {

        private readonly Tellyes.DAL.DeviceException dal = new Tellyes.DAL.DeviceException();
        public DeviceException()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DE_ID)
        {
            return dal.Exists(DE_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceException model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceException model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DE_ID)
        {

            return dal.Delete(DE_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceException GetModel(int DE_ID)
        {

            return dal.GetModel(DE_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceException GetModelByCache(int DE_ID)
        {

            string CacheKey = "DeviceExceptionModel-" + DE_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DE_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceException)objModel;
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
        public List<Tellyes.Model.DeviceException> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceException> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceException> modelList = new List<Tellyes.Model.DeviceException>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceException model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.DeviceException();
                    if (dt.Rows[n]["DE_ID"].ToString() != "")
                    {
                        model.DE_ID = int.Parse(dt.Rows[n]["DE_ID"].ToString());
                    }
                    if (dt.Rows[n]["DE_Number4"].ToString() != "")
                    {
                        model.DE_Number4 = int.Parse(dt.Rows[n]["DE_Number4"].ToString());
                    }
                    model.DE_String1 = dt.Rows[n]["DE_String1"].ToString();
                    model.DE_String2 = dt.Rows[n]["DE_String2"].ToString();
                    model.DE_String3 = dt.Rows[n]["DE_String3"].ToString();
                    model.DE_String4 = dt.Rows[n]["DE_String4"].ToString();
                    model.DE_String5 = dt.Rows[n]["DE_String5"].ToString();
                    if (dt.Rows[n]["D_ID"].ToString() != "")
                    {
                        model.D_ID = int.Parse(dt.Rows[n]["D_ID"].ToString());
                    }
                    if (dt.Rows[n]["DE_StartTime"].ToString() != "")
                    {
                        model.DE_StartTime = DateTime.Parse(dt.Rows[n]["DE_StartTime"].ToString());
                    }
                    if (dt.Rows[n]["DE_EndTime"].ToString() != "")
                    {
                        model.DE_EndTime = DateTime.Parse(dt.Rows[n]["DE_EndTime"].ToString());
                    }
                    if (dt.Rows[n]["DE_TimeSpan"].ToString() != "")
                    {
                        model.DE_TimeSpan = int.Parse(dt.Rows[n]["DE_TimeSpan"].ToString());
                    }
                    model.DE_Description = dt.Rows[n]["DE_Description"].ToString();
                    if (dt.Rows[n]["DE_Number1"].ToString() != "")
                    {
                        model.DE_Number1 = int.Parse(dt.Rows[n]["DE_Number1"].ToString());
                    }
                    if (dt.Rows[n]["DE_Number2"].ToString() != "")
                    {
                        model.DE_Number2 = int.Parse(dt.Rows[n]["DE_Number2"].ToString());
                    }
                    if (dt.Rows[n]["DE_Number3"].ToString() != "")
                    {
                        model.DE_Number3 = int.Parse(dt.Rows[n]["DE_Number3"].ToString());
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
        /// 添加DeviceException记录
        /// </summary>
        /// <param name="deviceException"></param>
        /// <returns></returns>
        public bool AddDeviceException(Model.DeviceException deviceException)
        {
            return new DAL.DeviceException().Insert(deviceException);
        }

        /// <summary>
        /// 删除DeviceException记录
        /// </summary>
        /// <param name="deviceException"></param>
        /// <returns></returns>
        public bool RemoveDeviceException(Model.DeviceException deviceException)
        {
            return new DAL.DeviceException().Delete(deviceException);
        }

        /// <summary>
        /// 修改DeviceException记录
        /// </summary>
        /// <param name="deviceException"></param>
        /// <returns></returns>
        public bool ModifyDeviceException(Model.DeviceException deviceException)
        {
            return new DAL.DeviceException().Update((object)deviceException);
        }

        /// <summary>
        /// 查询DeviceException下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceExceptionIdentity()
        {
            return new DAL.DeviceException().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceException记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceExceptionCount()
        {
            return new DAL.DeviceException().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceException记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceExceptionCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceException().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dE_ID的DeviceException是否存在
        /// </summary>
        /// <param name="dE_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceExceptionExists(object dE_ID)
        {
            return new DAL.DeviceException().SelectModelObjectExistsByID(dE_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceException是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceExceptionExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceException().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dE_ID查询DeviceException
        /// </summary>
        /// <param name="dE_ID"></param>
        /// <returns></returns>
        public Model.DeviceException SearchDeviceExceptionByID(object dE_ID)
        {
            return new DAL.DeviceException().SelectModelObjectByID(dE_ID);
        }

        /// <summary>
        /// 查询第一个DeviceException对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceException SearchUniqueDeviceExceptionByCondition()
        {
            return new DAL.DeviceException().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceException对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceException SearchUniqueDeviceExceptionByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceException().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceException对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceException SearchUniqueDeviceExceptionByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceException().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceException对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceException> SearchDeviceExceptionByCondition()
        {
            return new DAL.DeviceException().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceException对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceException> SearchDeviceExceptionByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceException().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceException对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceException> SearchDeviceExceptionByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceException().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceException内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceException> SearchDeviceExceptionByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceException().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
