using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //系统设备
    public partial class SystemDevice
    {

        private readonly Tellyes.DAL.SystemDevice dal = new Tellyes.DAL.SystemDevice();
        public SystemDevice()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid SD_ID)
        {
            return dal.Exists(SD_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.SystemDevice model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.SystemDevice model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid SD_ID)
        {

            return dal.Delete(SD_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.SystemDevice GetModel(Guid SD_ID)
        {

            return dal.GetModel(SD_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.SystemDevice GetModelByCache(Guid SD_ID)
        {

            string CacheKey = "SystemDeviceModel-" + SD_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(SD_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.SystemDevice)objModel;
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
        public List<Tellyes.Model.SystemDevice> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.SystemDevice> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.SystemDevice> modelList = new List<Tellyes.Model.SystemDevice>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.SystemDevice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.SystemDevice();
                    if (dt.Rows[n]["SD_ID"].ToString() != "")
                    {
                        model.SD_ID = dt.Rows[n]["SD_ID"].ToString();
                    }
                    model.SD_HardDisk_SerialNumber = dt.Rows[n]["SD_HardDisk_SerialNumber"].ToString();
                    model.SD_MAC_Address = dt.Rows[n]["SD_MAC_Address"].ToString();
                    model.SD_Verification_SerialNumber = dt.Rows[n]["SD_Verification_SerialNumber"].ToString();
                    model.SD_Registration_Time = dt.Rows[n]["SD_Registration_Time"].ToString();
                    if (dt.Rows[n]["SD_Number1"].ToString() != "")
                    {
                        model.SD_Number1 = int.Parse(dt.Rows[n]["SD_Number1"].ToString());
                    }
                    if (dt.Rows[n]["SD_Number2"].ToString() != "")
                    {
                        model.SD_Number2 = int.Parse(dt.Rows[n]["SD_Number2"].ToString());
                    }
                    if (dt.Rows[n]["SD_Number3"].ToString() != "")
                    {
                        model.SD_Number3 = int.Parse(dt.Rows[n]["SD_Number3"].ToString());
                    }
                    if (dt.Rows[n]["SD_Number4"].ToString() != "")
                    {
                        model.SD_Number4 = int.Parse(dt.Rows[n]["SD_Number4"].ToString());
                    }
                    model.SD_String1 = dt.Rows[n]["SD_String1"].ToString();
                    model.SD_String2 = dt.Rows[n]["SD_String2"].ToString();
                    model.SD_Application_Type = dt.Rows[n]["SD_Application_Type"].ToString();
                    model.SD_String3 = dt.Rows[n]["SD_String3"].ToString();
                    model.SD_String4 = dt.Rows[n]["SD_String4"].ToString();
                    model.SD_String5 = dt.Rows[n]["SD_String5"].ToString();
                    model.SD_Type = dt.Rows[n]["SD_Type"].ToString();
                    model.SD_HardWare_Version = dt.Rows[n]["SD_HardWare_Version"].ToString();
                    model.SD_HardWare_System_Version = dt.Rows[n]["SD_HardWare_System_Version"].ToString();
                    model.SD_HardWare_SerialNumber = dt.Rows[n]["SD_HardWare_SerialNumber"].ToString();
                    model.SD_CPU_SerialNumber = dt.Rows[n]["SD_CPU_SerialNumber"].ToString();
                    model.SD_Mainboard_SerialNumber = dt.Rows[n]["SD_Mainboard_SerialNumber"].ToString();
                    model.SD_BIOS_SerialNumber = dt.Rows[n]["SD_BIOS_SerialNumber"].ToString();


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
        /// 添加SystemDevice记录
        /// </summary>
        /// <param name="systemDevice"></param>
        /// <returns></returns>
        public bool AddSystemDevice(Model.SystemDevice systemDevice)
        {
            return new DAL.SystemDevice().Insert(systemDevice);
        }

        /// <summary>
        /// 删除SystemDevice记录
        /// </summary>
        /// <param name="systemDevice"></param>
        /// <returns></returns>
        public bool RemoveSystemDevice(Model.SystemDevice systemDevice)
        {
            return new DAL.SystemDevice().Delete(systemDevice);
        }

        /// <summary>
        /// 修改SystemDevice记录
        /// </summary>
        /// <param name="systemDevice"></param>
        /// <returns></returns>
        public bool ModifySystemDevice(Model.SystemDevice systemDevice)
        {
            return new DAL.SystemDevice().Update((object)systemDevice);
        }

        /// <summary>
        /// 查询SystemDevice下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchSystemDeviceIdentity()
        {
            return new DAL.SystemDevice().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部SystemDevice记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchSystemDeviceCount()
        {
            return new DAL.SystemDevice().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询SystemDevice记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchSystemDeviceCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SystemDevice().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定sD_ID的SystemDevice是否存在
        /// </summary>
        /// <param name="sD_ID"></param>
        /// <returns></returns>
        public bool? SearchSystemDeviceExists(object sD_ID)
        {
            return new DAL.SystemDevice().SelectModelObjectExistsByID(sD_ID);
        }

        /// <summary>
        /// 查询指定条件的SystemDevice是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchSystemDeviceExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SystemDevice().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按sD_ID查询SystemDevice
        /// </summary>
        /// <param name="sD_ID"></param>
        /// <returns></returns>
        public Model.SystemDevice SearchSystemDeviceByID(object sD_ID)
        {
            return new DAL.SystemDevice().SelectModelObjectByID(sD_ID);
        }

        /// <summary>
        /// 查询第一个SystemDevice对象
        /// </summary>
        /// <returns></returns>
        public Model.SystemDevice SearchUniqueSystemDeviceByCondition()
        {
            return new DAL.SystemDevice().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个SystemDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.SystemDevice SearchUniqueSystemDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SystemDevice().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个SystemDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.SystemDevice SearchUniqueSystemDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SystemDevice().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部SystemDevice对象
        /// </summary>
        /// <returns></returns>
        public List<Model.SystemDevice> SearchSystemDeviceByCondition()
        {
            return new DAL.SystemDevice().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询SystemDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.SystemDevice> SearchSystemDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SystemDevice().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询SystemDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.SystemDevice> SearchSystemDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SystemDevice().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询SystemDevice内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.SystemDevice> SearchSystemDeviceByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.SystemDevice().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }


        /// <summary>
        /// 校验码固定秘钥Json
        /// </summary>
        /// <param name="AppType"></param>
        /// <param name="HardWareSerialNumber"></param>
        /// <param name="MacAddress"></param>
        /// <returns></returns>
        public string ToJsonString(string AppType, string HardWareSerialNumber, string MacAddress)
        {
            string json = "";
            json = "{\"AppType\":\"" + Uri.EscapeDataString(AppType) + "\",\"HardWareSerialNumber \":\"" + Uri.EscapeDataString(HardWareSerialNumber) + "\",\" MacAddress\":\"" + Uri.EscapeDataString(MacAddress) + "\"}";
            return json;
        }

        /// <summary>
        /// 校验码固定秘钥Json
        /// </summary>
        /// <param name="AppType"></param>
        /// <param name="CPUSerialNumber"></param>
        /// <param name="MainboardSerialNumber"></param>
        /// <param name="BIOSSerialNumber"></param>
        /// <returns></returns>
        public string ToJsonString(string AppType, string CPUSerialNumber, string MainboardSerialNumber, string BIOSSerialNumber)
        {
            string json = "";
            json = "{\"AppType\":\"" + Uri.EscapeDataString(AppType) + "\",\"CPUSerialNumber \":\"" + Uri.EscapeDataString(CPUSerialNumber) + "\",\" MainboardSerialNumber\":\"" + Uri.EscapeDataString(MainboardSerialNumber) + "\",\"BIOSSerialNumber\":\"" + Uri.EscapeDataString(BIOSSerialNumber) + "\"}";
            return json;
        }


        /// <summary>
        ///  事务处理，批量删除SystemDevice记录
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public bool RemoveSystemDeviceList(List<Tellyes.Model.SystemDevice> systemDeviceList)
        {
            bool flag = false;
            Tellyes.DAL.SystemDevice systemDeviceDAL = new DAL.SystemDevice();
            flag = systemDeviceDAL.Transaction(new List<List<object>>()
                {
                    new List<object>(){"delete", systemDeviceList.ToList<object>()}
                });
            return flag;
        }

        #endregion

        #region Extesion


        #endregion
    }
}
