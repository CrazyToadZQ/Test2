using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class ExamDevice
    {
        private readonly Tellyes.DAL.ExamDevice dal = new Tellyes.DAL.ExamDevice();
        public ExamDevice()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ExamDeviceID)
        {
            return dal.Exists(ExamDeviceID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.ExamDevice model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamDevice model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ExamDeviceID)
        {

            return dal.Delete(ExamDeviceID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamDevice GetModel(Guid ExamDeviceID)
        {

            return dal.GetModel(ExamDeviceID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamDevice GetModelByCache(Guid ExamDeviceID)
        {

            string CacheKey = "ExamDeviceModel-" + ExamDeviceID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ExamDeviceID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamDevice)objModel;
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
        public List<Tellyes.Model.ExamDevice> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamDevice> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamDevice> modelList = new List<Tellyes.Model.ExamDevice>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamDevice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.ExamDevice();
                    if (dt.Rows[n]["ExamDeviceID"].ToString() != "")
                    {
                        model.ExamDeviceID = Guid.Parse(dt.Rows[n]["ExamDeviceID"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceCreateTime"].ToString() != "")
                    {
                        model.ExamDeviceCreateTime = DateTime.Parse(dt.Rows[n]["ExamDeviceCreateTime"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceNumber1"].ToString() != "")
                    {
                        model.ExamDeviceNumber1 = int.Parse(dt.Rows[n]["ExamDeviceNumber1"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceNumber2"].ToString() != "")
                    {
                        model.ExamDeviceNumber2 = int.Parse(dt.Rows[n]["ExamDeviceNumber2"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceNumber3"].ToString() != "")
                    {
                        model.ExamDeviceNumber3 = decimal.Parse(dt.Rows[n]["ExamDeviceNumber3"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceNumber4"].ToString() != "")
                    {
                        model.ExamDeviceNumber4 = decimal.Parse(dt.Rows[n]["ExamDeviceNumber4"].ToString());
                    }
                    model.ExamDeviceString1 = dt.Rows[n]["ExamDeviceString1"].ToString();
                    model.ExamDeviceString2 = dt.Rows[n]["ExamDeviceString2"].ToString();
                    model.ExamDeviceString3 = dt.Rows[n]["ExamDeviceString3"].ToString();
                    model.ExamDeviceString4 = dt.Rows[n]["ExamDeviceString4"].ToString();
                    if (dt.Rows[n]["ExamDeviceDateTime1"].ToString() != "")
                    {
                        model.ExamDeviceDateTime1 = DateTime.Parse(dt.Rows[n]["ExamDeviceDateTime1"].ToString());
                    }
                    if (dt.Rows[n]["E_ID"].ToString() != "")
                    {
                        model.E_ID = Guid.Parse(dt.Rows[n]["E_ID"].ToString());
                    }
                    if (dt.Rows[n]["ExamDeviceDateTime2"].ToString() != "")
                    {
                        model.ExamDeviceDateTime2 = DateTime.Parse(dt.Rows[n]["ExamDeviceDateTime2"].ToString());
                    }
                    if (dt.Rows[n]["ES_ID"].ToString() != "")
                    {
                        model.ES_ID = Guid.Parse(dt.Rows[n]["ES_ID"].ToString());
                    }
                    if (dt.Rows[n]["ESR_ID"].ToString() != "")
                    {
                        model.ESR_ID = Guid.Parse(dt.Rows[n]["ESR_ID"].ToString());
                    }
                    if (dt.Rows[n]["Room_ID"].ToString() != "")
                    {
                        model.Room_ID = Convert.ToInt32(dt.Rows[n]["Room_ID"].ToString());
                    }
                    if (dt.Rows[n]["D_ID"].ToString() != "")
                    {
                        model.D_ID = int.Parse(dt.Rows[n]["D_ID"].ToString());
                    }
                    if (dt.Rows[n]["DC_ID"].ToString() != "")
                    {
                        model.DC_ID = int.Parse(dt.Rows[n]["DC_ID"].ToString());
                    }
                    if (dt.Rows[n]["D_Manufacturer"].ToString() != "")
                    {
                        model.D_Manufacturer = dt.Rows[n]["D_Manufacturer"].ToString();
                    }
                    if (dt.Rows[n]["U_ID"].ToString() != "")
                    {
                        model.U_ID = int.Parse(dt.Rows[n]["U_ID"].ToString());
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
        /// 添加ExamDevice记录
        /// </summary>
        /// <param name="examDevice"></param>
        /// <returns></returns>
        public bool AddExamDevice(Model.ExamDevice examDevice)
        {
            return new DAL.ExamDevice().Insert(examDevice);
        }

        /// <summary>
        /// 删除ExamDevice记录
        /// </summary>
        /// <param name="examDevice"></param>
        /// <returns></returns>
        public bool RemoveExamDevice(Model.ExamDevice examDevice)
        {
            return new DAL.ExamDevice().Delete(examDevice);
        }

        /// <summary>
        /// 修改ExamDevice记录
        /// </summary>
        /// <param name="examDevice"></param>
        /// <returns></returns>
        public bool ModifyExamDevice(Model.ExamDevice examDevice)
        {
            return new DAL.ExamDevice().Update((object)examDevice);
        }

        /// <summary>
        /// 查询ExamDevice下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamDeviceIdentity()
        {
            return new DAL.ExamDevice().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamDevice记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamDeviceCount()
        {
            return new DAL.ExamDevice().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamDevice记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamDeviceCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamDevice().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定examDeviceID的ExamDevice是否存在
        /// </summary>
        /// <param name="examDeviceID"></param>
        /// <returns></returns>
        public bool? SearchExamDeviceExists(object examDeviceID)
        {
            return new DAL.ExamDevice().SelectModelObjectExistsByID(examDeviceID);
        }

        /// <summary>
        /// 查询指定条件的ExamDevice是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamDeviceExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamDevice().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按examDeviceID查询ExamDevice
        /// </summary>
        /// <param name="examDeviceID"></param>
        /// <returns></returns>
        public Model.ExamDevice SearchExamDeviceByID(object examDeviceID)
        {
            return new DAL.ExamDevice().SelectModelObjectByID(examDeviceID);
        }

        /// <summary>
        /// 查询第一个ExamDevice对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamDevice SearchUniqueExamDeviceByCondition()
        {
            return new DAL.ExamDevice().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamDevice SearchUniqueExamDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamDevice().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamDevice SearchUniqueExamDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamDevice().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamDevice对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamDevice> SearchExamDeviceByCondition()
        {
            return new DAL.ExamDevice().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamDevice> SearchExamDeviceByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamDevice().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamDevice对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamDevice> SearchExamDeviceByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamDevice().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamDevice内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamDevice> SearchExamDeviceByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamDevice().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        /// <summary>
        /// 根据考试ID，设备类型ID，判断已分配设备中是否存在冲突分配
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public int? SearchClashedDeviceCountByDeviceClassID(Guid E_ID, int DC_ID)
        {
            return new Tellyes.DAL.ExamDevice().SelectClashedDeviceCountByDeviceClassID(E_ID, DC_ID);
        }

        /// <summary>
        /// 获得某考试中与某设备冲突的其他考试信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="D_ID"></param>
        /// <returns></returns>
        public List<Dictionary<String,Object>> SearchExamClashedInfoByE_ID(Guid E_ID)
        {
            List<object[]> deviceClashedList=new Tellyes.DAL.ExamDevice().SelectExamClashedInfoByE_ID(E_ID);
            if (deviceClashedList == null)
            {
                Log4NetUtility.Error(this, "设备冲突信息查询失败：ExamTable_ID ： " + E_ID.ToString().Trim());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in deviceClashedList)
            {
                result.Add(new Dictionary<string, object>() 
                { 
                    { "E_ID", item[0] }, 
                    { "E_Name", item[1] },
                    { "D_ID", item[2] },
                    { "coverStartTime", item[3] },
                    { "coverEndTime", item[4] }
                });
            }
            return result;
        }

        /// <summary>
        /// 根据E_ID,DC_ID;获得备选设备列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Tellyes.Model.Device> SearchDeviceListInSpecialDeviceClass(Dictionary<string, object> condition)
        {
            List<Tellyes.Model.Device> deviceList = new Tellyes.DAL.ExamDevice().SelectDeviceListInSpecialDeviceClass(condition);
            if (deviceList == null)
            {
                Log4NetUtility.Error(this, "可选设备列表查询失败：ExamTable_ID ： " + condition["E_ID"].ToString().Trim() + "ExamStationID：" + condition["DC_ID"].ToString().Trim());
                return null;
            }
            return deviceList;
        }

        /// <summary>
        /// 根据条件 ，获得设备冲突信息列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Dictionary<String, Object>> SearchDeviceClashedInfoListByCondition(Dictionary<string, object> condition) 
        {
            List<object[]> clashedInfoList = new Tellyes.DAL.ExamDevice().SelectDeviceClashedInfoListByCondition(condition);
            if (clashedInfoList == null) 
            {
                Log4NetUtility.Error(this, "可选设备冲突信息查询失败：ExamTable_ID ： " + condition["E_ID"].ToString().Trim());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            foreach (object[] item in clashedInfoList)
            {
                result.Add(new Dictionary<string, object>() { 
                    { "D_ID", item[0] }
                    , { "E_Name", item[1] }
                    , { "E_ID", item[2] } 
                    , { "coverStartTime", item[3] } 
                    , { "coverEndTime", item[4] } 
                });
            }

            return result;
        }

        /// <summary>
        /// 预约中获取房间
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchRoomDataInfo(Dictionary<string, object> condition)
        {
            List<object[]> roomInfoList = new Tellyes.DAL.ExamDevice().SelectRoomDataInfo(condition);
            if (roomInfoList == null)
            {
                Log4NetUtility.Error(this, "房间信息查询失败：ExamTable_ID ： " + condition["E_ID"].ToString().Trim());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in roomInfoList)
            {
                result.Add(new Dictionary<string, object>() { 
                    { "Room", item[0] }
                    , { "ES_Name", item[1] }
                    , { "int3", item[2] }
                });
            }
            return result;
        }

        #endregion

        #region Extesion


        #endregion
    }
}
