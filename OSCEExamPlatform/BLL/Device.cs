using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;
using Tellyes.DAL;
using Tellyes.Log4Net;
using System.Data;

namespace Tellyes.BLL
{
	/// <summary>
	/// Device
	/// </summary>
	public partial class Device
	{
        private readonly Tellyes.DAL.Device dal = new Tellyes.DAL.Device();
        public Device()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int D_ID)
        {
            return dal.Exists(D_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.Device model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.Device model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int D_ID)
        {

            return dal.Delete(D_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string D_IDlist)
        {
            return dal.DeleteList(D_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.Device GetModel(int D_ID)
        {

            return dal.GetModel(D_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.Device GetModelByCache(int D_ID)
        {

            string CacheKey = "DeviceModel-" + D_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(D_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.Device)objModel;
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
        public List<Tellyes.Model.Device> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.Device> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.Device> modelList = new List<Tellyes.Model.Device>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.Device model;
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
        /// 返回所有设备位置
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllDevicePosition()
        {
            return Tellyes.DAL.Device.GetAllDevicePosition();
        }

        /// <summary>
        /// 获得产品统计信息
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public static DataTable GetProductsSummary(string DC_ID) 
        {
            return Tellyes.DAL.Device.GetProductsSummary(DC_ID);
        }

        /// <summary>
        /// 获得产品损坏次数统计信息
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public static DataTable GetBrokenProductSummary(string DC_ID)
        {
            return Tellyes.DAL.Device.GetBrokenProductSummary(DC_ID);
        }

        /// <summary>
        /// 获得某第三级所有产品统计信息
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public static DataTable GetLastLevelProductSummary(string DC_ID)
        {
            return Tellyes.DAL.Device.GetLastLevelProductSummary(DC_ID);
        }

        /// <summary>
        /// 批量插入设备信息（事务操作）
        /// </summary>
        /// <param name="deviceModelList"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(System.Collections.Generic.List<Tellyes.Model.Device> deviceModelList)
        {
            return dal.ExecuteSqlTran_Insert(deviceModelList);
        }

        /// <summary>
        /// 设备统计中，根据条件，获得搜索结果
        /// </summary>
        /// <param name="deviceName"></param>
        /// <param name="isLiangHao"></param>
        /// <param name="isYiChang"></param>
        /// <param name="isTianYan"></param>
        /// <returns></returns>
        public static DataTable GetDeviceDetailByCondition(string deviceName = null, bool isLiangHao = false, bool isYiChang = false, bool isTianYan = false, bool isQiTa = false)
        {
            return Tellyes.DAL.Device.GetDeviceDetailByCondition(deviceName, isLiangHao, isYiChang, isTianYan, isQiTa);
        }
        #endregion  ExtensionMethod

        public System.Data.SqlClient.SqlConnection myConection()
        {
            throw new NotImplementedException();
        }

        public DataSet ExecleDs(string strpath, string filename)
        {
            throw new NotImplementedException();
        }
        
        public bool check(string sqlcheck)
        {
            throw new NotImplementedException();
        }

        #region Extension
       
        /// <summary>
		/// 添加Device记录
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		public bool AddDevice(Model.Device device)
		{
		    return new DAL.Device().Insert(device);
		}

        /// <summary>
        /// 事务处理，增加一条设备及增加一条日志记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool AddDeviceAndDeviceLog(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog)
        {
            bool flag = false;
            Tellyes.DAL.Device deviceDAL = new DAL.Device();
            flag = deviceDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"insert", device},
                    new List<object>(){"insert", deviceLog}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备及增加一条日志记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAndDeviceLog(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog)
        {
            bool flag = false;
            Tellyes.DAL.Device deviceDAL = new DAL.Device();
            flag = deviceDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},
                    new List<object>(){"insert", deviceLog}
                });
            return flag;
        }

        /// <summary>
        ///  事务处理，批量修改Device记录,批量增加DeviceLog日志记录
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public bool ModifyDeviceList(List<Tellyes.Model.Device> deviceList, List<Tellyes.Model.DeviceLog> deviceLogList)
        {
            bool flag = false;
            Tellyes.DAL.Device deviceDAL = new DAL.Device();
            flag = deviceDAL.Transaction(new List<List<object>>()
                {
                    new List<object>(){"update", deviceList.ToList<object>()},
                    new List<object>(){"insert", deviceLogList.ToList<object>()}
                });
            return flag;
        }        
		

		/// <summary>
        /// 删除Device记录
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public bool RemoveDevice(Model.Device device)
        {
            return new DAL.Device().Delete(device);
        }
		
		/// <summary>
        /// 修改Device记录
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public bool ModifyDevice(Model.Device device)
        {
            return new DAL.Device().Update((object)device);
        }
       
		/// <summary>
        /// 查询Device下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceIdentity()
        {
            return new DAL.Device().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部Device记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceCount()
        {
            return new DAL.Device().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询Device记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Device().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定d_ID的Device是否存在
        /// </summary>
        /// <param name="d_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceExists(object d_ID)
        {
            return new DAL.Device().SelectModelObjectExistsByID(d_ID);
        }

        /// <summary>
        /// 查询指定条件的Device是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Device().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按d_ID查询Device
        /// </summary>
        /// <param name="d_ID"></param>
        /// <returns></returns>
        public Model.Device SearchDeviceByID(object d_ID)
        {
            return new DAL.Device().SelectModelObjectByID(d_ID);
        }

        /// <summary>
        /// 查询第一个Device对象
        /// </summary>
        /// <returns></returns>
        public Model.Device SearchUniqueDeviceByCondition()
        {
            return new DAL.Device().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个Device对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.Device SearchUniqueDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Device().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个Device对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.Device SearchUniqueDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Device().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部Device对象
        /// </summary>
        /// <returns></returns>
        public List<Model.Device> SearchDeviceByCondition()
        {
            return new DAL.Device().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询Device对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.Device> SearchDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Device().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询Device对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.Device> SearchDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Device().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询Device内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.Device> SearchDeviceByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.Device().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }


        /// <summary>
        /// 事务处理，增加一条设备及增加一条厂商记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool AddDeviceAndDeviceManufacturer(Tellyes.Model.Device device, Tellyes.Model.DeviceManufacturer deviceManufacturer)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"insert", device},
                    new List<object>(){"insert", deviceManufacturer}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，增加一条设备\增加一条厂商记录\增加一条日志记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool AddDeviceAndDeviceManufacturerAndDeviceLog(Tellyes.Model.Device device, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceLog deviceLog)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"insert", device},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"insert", deviceLog},
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备\增加一条厂商记录\增加一条日志记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAndDeviceManufacturerAndDeviceLog(Tellyes.Model.Device device, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceLog deviceLog)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"insert", deviceLog},
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备厂商记录\增加一条设备维修记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerAddDeviceMaintain(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceMaintain deviceMaintain)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"insert", deviceMaintain}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备维修记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceMaintain(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceMaintain deviceMaintain)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceMaintain}
                });
            return flag;
        }

         /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录\Add一条设备维修记录\Modify一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool  ModifyDeviceAddDeviceLogAddDeviceManufacturerAddDeviceMaintainModifyDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog,Tellyes.Model.DeviceManufacturer deviceManufacture,Tellyes.Model.DeviceMaintain deviceMaintain,Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture},
                    new List<object>(){"insert", deviceMaintain},
                    new List<object>(){"update", deviceException}
                });
            return flag;
        }

         /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备维修记录\Modify一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceMaintainModifyDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceMaintain deviceMaintain, Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceMaintain},
                    new List<object>(){"update", deviceException}
                });
            return flag;
        }

        /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录\Add一条设备维修记录\Modify一条设外借常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerAddDeviceMaintainModifyDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacture, Tellyes.Model.DeviceMaintain deviceMaintain, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture},
                    new List<object>(){"insert", deviceMaintain},
                    new List<object>(){"update", deviceBorrow}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备维修记录\Modify一条设备外借记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceMaintainModifyDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceMaintain deviceMaintain, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceMaintain},
                    new List<object>(){"update", deviceBorrow}
                });
            return flag;
        }


        /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录\Modify一条设备维修记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerModifyDeviceMaintain(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacture, Tellyes.Model.DeviceMaintain deviceMaintain)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture},
                    new List<object>(){"update", deviceMaintain}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录\Modify一条设备维修记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogModifyDeviceMaintain(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceMaintain deviceMaintain)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"update", deviceMaintain}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备厂商记录\增加一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerAddDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"insert", deviceException}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceException}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备厂商记录\修改一条设备外借记录\增加一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerModifyDeviceBorrowAddDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceBorrow deviceBorrow,Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"update", deviceBorrow},
                    new List<object>(){"insert", deviceException}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\修改一条设备外借记录\增加一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogModifyDeviceBorrowAddDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog,Tellyes.Model.DeviceBorrow deviceBorrow,Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"update", deviceBorrow},
                    new List<object>(){"insert", deviceException}
                });
            return flag;
        }

        /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录\Modify一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerModifyDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacture, Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture},
                    new List<object>(){"update", deviceException}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录\Modify一条设备异常记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogModifyDeviceException(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceException deviceException)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"update", deviceException}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备厂商记录\增加一条设备外借记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerAddDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacturer, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacturer},
                    new List<object>(){"insert", deviceBorrow}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，修改一条设备记录\增加一条设备日志记录\增加一条设备外借记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceBorrow}
                });
            return flag;
        }

        /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录\Modify一条设备外借记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturerModifyDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacture, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture},
                    new List<object>(){"update", deviceBorrow}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录\Modify一条设备外借记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogModifyDeviceBorrow(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceBorrow deviceBorrow)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"update", deviceBorrow}
                });
            return flag;
        }

        /// <summary>
        ///  事务处理，Modlfy一条设备记录\Add一条设备日志记录\Add一条设备厂商记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLogAddDeviceManufacturer(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog, Tellyes.Model.DeviceManufacturer deviceManufacture)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog},
                    new List<object>(){"insert", deviceManufacture}
                });
            return flag;
        }

        /// <summary>
        /// 事务处理，Modlfy一条设备记录\Add一条设备日志记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyDeviceAddDeviceLog(Tellyes.Model.Device device, Tellyes.Model.DeviceLog deviceLog)
        {
            bool flag = false;
            Tellyes.DAL.DeviceManufacturer deviceManufacturerDAL = new DAL.DeviceManufacturer();
            flag = deviceManufacturerDAL.Transaction(new List<List<object>>() 
                {   new List<object>(){"update", device},                   
                    new List<object>(){"insert", deviceLog}
                });
            return flag;
        }


         /// <summary>
        /// 分页查询设备统计个数（Device表，DeviceUse表，DeviceClass表，DeviceMaintain）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectDeviceStatisticInfoRowCountPageByCondition(Dictionary<string, object> conditionDictionary)
        {
             return new DAL.Device().SelectDeviceStatisticInfoRowCountPageByCondition(conditionDictionary);
        }


        /// <summary>
        /// 联合查询设备统计信息（单个设备）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SelectDeviceStatisticInfoPageByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> deviceStaticInfoList = new DAL.Device().SelectDeviceStatisticInfoPageByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (deviceStaticInfoList == null)
            {
                Log4NetUtility.Error(this, "设备统计信息查询失败！");
                return null;
            }

            List<Dictionary<string, object>> deviceStaticInfoDictionaryList = new List<Dictionary<string, object>>();
            foreach (object[] DeviceObject in deviceStaticInfoList)
            {
                deviceStaticInfoDictionaryList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"D_ID", DeviceObject[0]},
                        {"D_SerialNumber", DeviceObject[1]},
                        {"D_Name", DeviceObject[2]},
                        {"D_State", DeviceObject[3]},
                        {"DC_Name", DeviceObject[4]},
                        {"DC_ID", DeviceObject[5]},
                        {"UseCount", DeviceObject[6]==null? 0 : DeviceObject[6]},
                        {"UseTime", DeviceObject[7]==null? 0 : DeviceObject[7]},
                        {"DeviceUseFrequency", DeviceObject[8]==null? Convert.ToDecimal(0.0):DeviceObject[8]},
                        {"DeviceMaintainCount", DeviceObject[9]==null? 0 : DeviceObject[9]},
                        {"DeviceMaintainFrequency", DeviceObject[10]==null ? Convert.ToDecimal(0.0) : DeviceObject[10]}
                    }
                );
            }
            return deviceStaticInfoDictionaryList;
        }



        /// <summary>
        /// 分页查询设备类别统计信息（Device表，DeviceUse表，DeviceClass表，DeviceMaintain表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public int? SelectDeviceClassStatisticInfoRowCountPageByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Device().SelectDeviceClassStatisticInfoRowCountPageByCondition(conditionDictionary);
        }

          /// <summary>
        /// 分页查询设备统计信息（Device表，DeviceUse表，DeviceClass表，DeviceMaintain表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SelectDeviceClassStatisticInfoPageByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> deviceClassStaticInfoList = new DAL.Device().SelectDeviceClassStatisticInfoPageByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (deviceClassStaticInfoList == null)
            {
                Log4NetUtility.Error(this, "设备类别统计信息查询失败！");
                return null;
            }

            List<Dictionary<string, object>> deviceClassStaticInfoDictionaryList = new List<Dictionary<string, object>>();
            foreach (object[] DeviceClassObject in deviceClassStaticInfoList)
            {
                deviceClassStaticInfoDictionaryList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"DC_ID", DeviceClassObject[0]},
                        {"DC_Name", DeviceClassObject[1]},
                        {"DeviceMaintainSuccessRate", DeviceClassObject[2]==null? Convert.ToDecimal(0.0):DeviceClassObject[2]},
                        {"DeviceClassMaxMaintainCount", DeviceClassObject[3]==null ? 0 : DeviceClassObject[3]},
                        {"DeviceClassAverageUseCount", DeviceClassObject[4]==null? Convert.ToDecimal(0.0):DeviceClassObject[4] },
                        {"DeviceClassCount", DeviceClassObject[5]}
                    }
                );
            }

            return deviceClassStaticInfoDictionaryList;
        }

        #endregion
    }
}

