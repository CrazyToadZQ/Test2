using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //设备外借表
    public partial class DeviceBorrow
    {

        private readonly Tellyes.DAL.DeviceBorrow dal = new Tellyes.DAL.DeviceBorrow();
        public DeviceBorrow()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DB_ID)
        {
            return dal.Exists(DB_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceBorrow model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceBorrow model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DB_ID)
        {

            return dal.Delete(DB_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceBorrow GetModel(int DB_ID)
        {

            return dal.GetModel(DB_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceBorrow GetModelByCache(int DB_ID)
        {

            string CacheKey = "DeviceBorrowModel-" + DB_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DB_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceBorrow)objModel;
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
        public List<Tellyes.Model.DeviceBorrow> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceBorrow> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceBorrow> modelList = new List<Tellyes.Model.DeviceBorrow>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceBorrow model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.DeviceBorrow();
                    if (dt.Rows[n]["DB_ID"].ToString() != "")
                    {
                        model.DB_ID = int.Parse(dt.Rows[n]["DB_ID"].ToString());
                    }
                    model.DB_ReturnState = dt.Rows[n]["DB_ReturnState"].ToString();
                    if (dt.Rows[n]["DB_OperatePersonID"].ToString() != "")
                    {
                        model.DB_OperatePersonID = int.Parse(dt.Rows[n]["DB_OperatePersonID"].ToString());
                    }
                    model.DB_OperatePersonName = dt.Rows[n]["DB_OperatePersonName"].ToString();
                    if (dt.Rows[n]["DB_Number1"].ToString() != "")
                    {
                        model.DB_Number1 = int.Parse(dt.Rows[n]["DB_Number1"].ToString());
                    }
                    if (dt.Rows[n]["DB_Number2"].ToString() != "")
                    {
                        model.DB_Number2 = int.Parse(dt.Rows[n]["DB_Number2"].ToString());
                    }
                    if (dt.Rows[n]["DB_Number3"].ToString() != "")
                    {
                        model.DB_Number3 = int.Parse(dt.Rows[n]["DB_Number3"].ToString());
                    }
                    if (dt.Rows[n]["DB_Number4"].ToString() != "")
                    {
                        model.DB_Number4 = int.Parse(dt.Rows[n]["DB_Number4"].ToString());
                    }
                    model.DB_String1 = dt.Rows[n]["DB_String1"].ToString();
                    model.DB_String2 = dt.Rows[n]["DB_String2"].ToString();
                    model.DB_String3 = dt.Rows[n]["DB_String3"].ToString();
                    if (dt.Rows[n]["D_ID"].ToString() != "")
                    {
                        model.D_ID = int.Parse(dt.Rows[n]["D_ID"].ToString());
                    }
                    model.DB_String4 = dt.Rows[n]["DB_String4"].ToString();
                    model.DB_String5 = dt.Rows[n]["DB_String5"].ToString();
                    if (dt.Rows[n]["DB_StartTime"].ToString() != "")
                    {
                        model.DB_StartTime = DateTime.Parse(dt.Rows[n]["DB_StartTime"].ToString());
                    }
                    if (dt.Rows[n]["DB_EndTime"].ToString() != "")
                    {
                        model.DB_EndTime = DateTime.Parse(dt.Rows[n]["DB_EndTime"].ToString());
                    }
                    if (dt.Rows[n]["DB_TimeSpan"].ToString() != "")
                    {
                        model.DB_TimeSpan = int.Parse(dt.Rows[n]["DB_TimeSpan"].ToString());
                    }
                    model.DB_Reason = dt.Rows[n]["DB_Reason"].ToString();
                    model.DB_ContactPersonCompany = dt.Rows[n]["DB_ContactPersonCompany"].ToString();
                    model.DB_ContactPerson = dt.Rows[n]["DB_ContactPerson"].ToString();
                    model.DB_ContactPersonPhone = dt.Rows[n]["DB_ContactPersonPhone"].ToString();


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
        /// 添加DeviceBorrow记录
        /// </summary>
        /// <param name="deviceBorrow"></param>
        /// <returns></returns>
        public bool AddDeviceBorrow(Model.DeviceBorrow deviceBorrow)
        {
            return new DAL.DeviceBorrow().Insert(deviceBorrow);
        }

        /// <summary>
        /// 删除DeviceBorrow记录
        /// </summary>
        /// <param name="deviceBorrow"></param>
        /// <returns></returns>
        public bool RemoveDeviceBorrow(Model.DeviceBorrow deviceBorrow)
        {
            return new DAL.DeviceBorrow().Delete(deviceBorrow);
        }

        /// <summary>
        /// 修改DeviceBorrow记录
        /// </summary>
        /// <param name="deviceBorrow"></param>
        /// <returns></returns>
        public bool ModifyDeviceBorrow(Model.DeviceBorrow deviceBorrow)
        {
            return new DAL.DeviceBorrow().Update((object)deviceBorrow);
        }

        /// <summary>
        /// 查询DeviceBorrow下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceBorrowIdentity()
        {
            return new DAL.DeviceBorrow().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceBorrow记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceBorrowCount()
        {
            return new DAL.DeviceBorrow().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceBorrow记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceBorrowCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceBorrow().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dB_ID的DeviceBorrow是否存在
        /// </summary>
        /// <param name="dB_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceBorrowExists(object dB_ID)
        {
            return new DAL.DeviceBorrow().SelectModelObjectExistsByID(dB_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceBorrow是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceBorrowExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceBorrow().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dB_ID查询DeviceBorrow
        /// </summary>
        /// <param name="dB_ID"></param>
        /// <returns></returns>
        public Model.DeviceBorrow SearchDeviceBorrowByID(object dB_ID)
        {
            return new DAL.DeviceBorrow().SelectModelObjectByID(dB_ID);
        }

        /// <summary>
        /// 查询第一个DeviceBorrow对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceBorrow SearchUniqueDeviceBorrowByCondition()
        {
            return new DAL.DeviceBorrow().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceBorrow对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceBorrow SearchUniqueDeviceBorrowByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceBorrow().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceBorrow对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceBorrow SearchUniqueDeviceBorrowByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceBorrow().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceBorrow对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceBorrow> SearchDeviceBorrowByCondition()
        {
            return new DAL.DeviceBorrow().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceBorrow对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceBorrow> SearchDeviceBorrowByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceBorrow().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceBorrow对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceBorrow> SearchDeviceBorrowByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceBorrow().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceBorrow内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceBorrow> SearchDeviceBorrowByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceBorrow().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
