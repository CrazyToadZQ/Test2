using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //设备维修表
    public partial class DeviceMaintain
    {

        private readonly Tellyes.DAL.DeviceMaintain dal = new Tellyes.DAL.DeviceMaintain();
        public DeviceMaintain()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DM_ID)
        {
            return dal.Exists(DM_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.DeviceMaintain model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceMaintain model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DM_ID)
        {

            return dal.Delete(DM_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceMaintain GetModel(int DM_ID)
        {

            return dal.GetModel(DM_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.DeviceMaintain GetModelByCache(int DM_ID)
        {

            string CacheKey = "DeviceMaintainModel-" + DM_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(DM_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.DeviceMaintain)objModel;
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
        public List<Tellyes.Model.DeviceMaintain> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.DeviceMaintain> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.DeviceMaintain> modelList = new List<Tellyes.Model.DeviceMaintain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.DeviceMaintain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.DeviceMaintain();
                    if (dt.Rows[n]["DM_ID"].ToString() != "")
                    {
                        model.DM_ID = int.Parse(dt.Rows[n]["DM_ID"].ToString());
                    }
                    model.DM_ContactPersonCompany = dt.Rows[n]["DM_ContactPersonCompany"].ToString();
                    model.DM_ContactPerson = dt.Rows[n]["DM_ContactPerson"].ToString();
                    model.DM_ContactPersonPhone = dt.Rows[n]["DM_ContactPersonPhone"].ToString();
                    if (dt.Rows[n]["DM_Number1"].ToString() != "")
                    {
                        model.DM_Number1 = int.Parse(dt.Rows[n]["DM_Number1"].ToString());
                    }
                    if (dt.Rows[n]["DM_Number2"].ToString() != "")
                    {
                        model.DM_Number2 = int.Parse(dt.Rows[n]["DM_Number2"].ToString());
                    }
                    if (dt.Rows[n]["DM_Number3"].ToString() != "")
                    {
                        model.DM_Number3 = int.Parse(dt.Rows[n]["DM_Number3"].ToString());
                    }
                    if (dt.Rows[n]["DM_Number4"].ToString() != "")
                    {
                        model.DM_Number4 = int.Parse(dt.Rows[n]["DM_Number4"].ToString());
                    }
                    model.DM_String1 = dt.Rows[n]["DM_String1"].ToString();
                    model.DM_String2 = dt.Rows[n]["DM_String2"].ToString();
                    model.DM_String3 = dt.Rows[n]["DM_String3"].ToString();
                    if (dt.Rows[n]["D_ID"].ToString() != "")
                    {
                        model.D_ID = int.Parse(dt.Rows[n]["D_ID"].ToString());
                    }
                    model.DM_String4 = dt.Rows[n]["DM_String4"].ToString();
                    model.DM_String5 = dt.Rows[n]["DM_String5"].ToString();
                    if (dt.Rows[n]["DM_StartTime"].ToString() != "")
                    {
                        model.DM_StartTime = DateTime.Parse(dt.Rows[n]["DM_StartTime"].ToString());
                    }
                    if (dt.Rows[n]["DM_EndTime"].ToString() != "")
                    {
                        model.DM_EndTime = DateTime.Parse(dt.Rows[n]["DM_EndTime"].ToString());
                    }
                    if (dt.Rows[n]["DM_TimeSpan"].ToString() != "")
                    {
                        model.DM_TimeSpan = int.Parse(dt.Rows[n]["DM_TimeSpan"].ToString());
                    }
                    model.DM_Reason = dt.Rows[n]["DM_Reason"].ToString();
                    model.DM_Result = dt.Rows[n]["DM_Result"].ToString();
                    model.DM_Fee = dt.Rows[n]["DM_Fee"].ToString();
                    model.DM_Content = dt.Rows[n]["DM_Content"].ToString();


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
        /// 添加DeviceMaintain记录
        /// </summary>
        /// <param name="deviceMaintain"></param>
        /// <returns></returns>
        public bool AddDeviceMaintain(Model.DeviceMaintain deviceMaintain)
        {
            return new DAL.DeviceMaintain().Insert(deviceMaintain);
        }

        /// <summary>
        /// 删除DeviceMaintain记录
        /// </summary>
        /// <param name="deviceMaintain"></param>
        /// <returns></returns>
        public bool RemoveDeviceMaintain(Model.DeviceMaintain deviceMaintain)
        {
            return new DAL.DeviceMaintain().Delete(deviceMaintain);
        }

        /// <summary>
        /// 修改DeviceMaintain记录
        /// </summary>
        /// <param name="deviceMaintain"></param>
        /// <returns></returns>
        public bool ModifyDeviceMaintain(Model.DeviceMaintain deviceMaintain)
        {
            return new DAL.DeviceMaintain().Update((object)deviceMaintain);
        }

        /// <summary>
        /// 查询DeviceMaintain下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceMaintainIdentity()
        {
            return new DAL.DeviceMaintain().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceMaintain记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceMaintainCount()
        {
            return new DAL.DeviceMaintain().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceMaintain记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceMaintainCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceMaintain().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dM_ID的DeviceMaintain是否存在
        /// </summary>
        /// <param name="dM_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceMaintainExists(object dM_ID)
        {
            return new DAL.DeviceMaintain().SelectModelObjectExistsByID(dM_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceMaintain是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceMaintainExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceMaintain().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dM_ID查询DeviceMaintain
        /// </summary>
        /// <param name="dM_ID"></param>
        /// <returns></returns>
        public Model.DeviceMaintain SearchDeviceMaintainByID(object dM_ID)
        {
            return new DAL.DeviceMaintain().SelectModelObjectByID(dM_ID);
        }

        /// <summary>
        /// 查询第一个DeviceMaintain对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceMaintain SearchUniqueDeviceMaintainByCondition()
        {
            return new DAL.DeviceMaintain().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceMaintain对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceMaintain SearchUniqueDeviceMaintainByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceMaintain().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceMaintain对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceMaintain SearchUniqueDeviceMaintainByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceMaintain().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceMaintain对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceMaintain> SearchDeviceMaintainByCondition()
        {
            return new DAL.DeviceMaintain().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceMaintain对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceMaintain> SearchDeviceMaintainByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceMaintain().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceMaintain对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceMaintain> SearchDeviceMaintainByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceMaintain().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceMaintain内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceMaintain> SearchDeviceMaintainByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceMaintain().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
