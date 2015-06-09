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
    public class DeviceClassBLL
    {
        private readonly DAL.DeviceClassDAL dal=new DAL.DeviceClassDAL();
        public DeviceClassBLL()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DC_ID)
		{
			return dal.Exists(DC_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.DeviceClass model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.DeviceClass model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int DC_ID)
		{
			
			return dal.Delete(DC_ID);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string DC_IDlist )
		{
			return dal.DeleteList(DC_IDlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.DeviceClass GetModel(int DC_ID)
		{
			
			return dal.GetModel(DC_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.DeviceClass GetModelByCache(int DC_ID)
		{
			
			string CacheKey = "DeviceClassModel-" + DC_ID;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DC_ID);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.DeviceClass)objModel;
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.DeviceClass> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.DeviceClass> DataTableToList(DataTable dt)
		{
			List<Model.DeviceClass> modelList = new List<Model.DeviceClass>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.DeviceClass model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.DeviceClass();					
													if(dt.Rows[n]["DC_ID"].ToString()!="")
				{
					model.DC_ID=int.Parse(dt.Rows[n]["DC_ID"].ToString());
				}
																																				model.DC_Name= dt.Rows[n]["DC_Name"].ToString();
																												if(dt.Rows[n]["DC_ParentID"].ToString()!="")
				{
					model.DC_ParentID=int.Parse(dt.Rows[n]["DC_ParentID"].ToString());
				}
																																				model.DC_Content= dt.Rows[n]["DC_Content"].ToString();
																												if(dt.Rows[n]["DC_IsValid"].ToString()!="")
				{
					model.DC_IsValid=int.Parse(dt.Rows[n]["DC_IsValid"].ToString());
				}
																																if(dt.Rows[n]["DC_int"].ToString()!="")
				{
					model.DC_int=int.Parse(dt.Rows[n]["DC_int"].ToString());
				}
																																				model.DC_string= dt.Rows[n]["DC_string"].ToString();
																						
				
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
		/// 添加DeviceClass记录
		/// </summary>
		/// <param name="deviceClass"></param>
		/// <returns></returns>
		public bool AddDeviceClass(Model.DeviceClass deviceClass)
		{
            return new DAL.DeviceClassDAL().Insert(deviceClass);
		}
		
		/// <summary>
        /// 删除DeviceClass记录
        /// </summary>
        /// <param name="deviceClass"></param>
        /// <returns></returns>
        public bool RemoveDeviceClass(Model.DeviceClass deviceClass)
        {
            return new DAL.DeviceClassDAL().Delete(deviceClass);
        }
		
		/// <summary>
        /// 修改DeviceClass记录
        /// </summary>
        /// <param name="deviceClass"></param>
        /// <returns></returns>
        public bool ModifyDeviceClass(Model.DeviceClass deviceClass)
        {
            return new DAL.DeviceClassDAL().Update((object)deviceClass);
        }
		
		/// <summary>
        /// 查询DeviceClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceClassIdentity()
        {
            return new DAL.DeviceClassDAL().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部DeviceClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchDeviceClassCount()
        {
            return new DAL.DeviceClassDAL().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchDeviceClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定dC_ID的DeviceClass是否存在
        /// </summary>
        /// <param name="dC_ID"></param>
        /// <returns></returns>
        public bool? SearchDeviceClassExists(object dC_ID)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectExistsByID(dC_ID);
        }

        /// <summary>
        /// 查询指定条件的DeviceClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchDeviceClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按dC_ID查询DeviceClass
        /// </summary>
        /// <param name="dC_ID"></param>
        /// <returns></returns>
        public Model.DeviceClass SearchDeviceClassByID(object dC_ID)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectByID(dC_ID);
        }

        /// <summary>
        /// 查询第一个DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public Model.DeviceClass SearchUniqueDeviceClassByCondition()
        {
            return new DAL.DeviceClassDAL().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.DeviceClass SearchUniqueDeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceClassDAL().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.DeviceClass SearchUniqueDeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceClassDAL().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.DeviceClass> SearchDeviceClassByCondition()
        {
            return new DAL.DeviceClassDAL().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.DeviceClass> SearchDeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.DeviceClass> SearchDeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询DeviceClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.DeviceClass> SearchDeviceClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.DeviceClassDAL().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }
		
		#endregion
   
   		#region Extesion

        /// <summary>
        /// 逻辑删除设备分类
        /// </summary>
        /// <param name="deviceClassList"></param>
        /// <returns></returns>
        public bool LogicalRemoveDeviceClass(List<DeviceClass> deviceClassList)
        {
            return new DeviceClassDAL().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", deviceClassList.ToList<object>()}
            });
        }

        /// <summary>
        /// 逻辑修改设备分类
        /// </summary>
        /// <param name="oldDeviceClass"></param>
        /// <param name="newDeviceClass"></param>
        /// <param name="childDeviceClassList"></param>
        /// <returns></returns>
        public bool LogicalModifyDeviceClass(DeviceClass oldDeviceClass, DeviceClass newDeviceClass, List<DeviceClass> childDeviceClassList)
        {
            return new DeviceClassDAL().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", oldDeviceClass},
                new List<object>(){"insert", newDeviceClass},
                new List<object>(){"update", childDeviceClassList.ToList<object>()}
            });
        }

        /// <summary>
        /// 按ID查询设备分类
        /// </summary>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public DeviceClass SearchDeviceClassByDCID(int DC_ID)
        {
            return new DeviceClassDAL().SelectModelObjectByID(DC_ID);
        }

        /// <summary>
        /// 按父类ID查询设备分类
        /// </summary>
        /// <param name="DC_ParentID"></param>
        /// <returns></returns>
        public List<DeviceClass> SearchDeviceClassByDCParentID(int DC_ParentID)
        {
            return new DeviceClassDAL().SelectModelObjectByCondition
            (
                new Dictionary<string, object>()
                {
                    {"DC_IsValid", 1},
                    {"DC_ParentID", DC_ParentID}
                },
                null
            );
        }

        /// <summary>
        /// 查询全部有效的设备分类
        /// </summary>
        /// <returns></returns>
        public List<DeviceClass> SearchDeviceClass()
        {
            return new DeviceClassDAL().SelectModelObjectByCondition
            (
                new Dictionary<string, object>()
                {
                    {"DC_IsValid", 1}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("DC_ParentID", "asc"),
                    new KeyValuePair<string, string>("DC_Name", "asc")
                }
            );
        }

        /// <summary>
        /// 迭代设备分类信息，生成设备分类级别
        /// </summary>
        /// <param name="deviceClassList"></param>
        /// <param name="deviceClassIteraList"></param>
        /// <param name="DC_ParentID"></param>
        /// <param name="DC_Level"></param>
        /// <returns></returns>
        public List<DeviceClass> IteraDeviceClass(List<DeviceClass> deviceClassList, List<DeviceClass> deviceClassIteraList, int DC_ParentID, int DC_Level)
        {
            foreach (DeviceClass deviceClass in deviceClassList)
            {
                if (deviceClass.DC_ParentID == DC_ParentID)
                {
                    deviceClass.DC_Level = DC_Level;
                    deviceClassIteraList.Add(deviceClass);
                    deviceClassIteraList = this.IteraDeviceClass(deviceClassList, deviceClassIteraList, deviceClass.DC_ID, DC_Level + 1);
                }
            }
            return deviceClassIteraList;
        }

        /// <summary>
        /// 迭代查询设备类别名称
        /// </summary>
        /// <param name="deviceClassList"></param>
        /// <param name="deviceClassIteraList"></param>
        /// <param name="DC_ParentID"></param>
        /// <returns></returns>
        public List<DeviceClass> IteraDeviceClassNameList(List<DeviceClass> deviceClassList, List<DeviceClass> deviceClassIteraList, int DC_ParentID)
        {
            foreach(DeviceClass deviceClass in deviceClassList)
            {
                if(deviceClass.DC_ParentID==DC_ParentID)
                {
                    if (deviceClass.DC_ParentID != 0)
                    {
                        deviceClass.DC_Name = new DeviceClassDAL().SelectModelObjectByID(DC_ParentID).DC_Name + " -> " + deviceClass.DC_Name;
                    }
                    deviceClassIteraList.Add(deviceClass);
                    deviceClassIteraList = this.IteraDeviceClassNameList(deviceClassList, deviceClassIteraList, deviceClass.DC_ID);
                }
            }
            return deviceClassIteraList;
        }

        /// <summary>
        /// 迭代查询设备类别名称
        /// </summary>
        /// <returns></returns>
        public string IteraDeviceClassName(int deviceClassId,List<Tellyes.Model.DeviceClass> allDeviceClassList)
        {
            string className = "";
            foreach (Tellyes.Model.DeviceClass deviceClass in allDeviceClassList)
            {
                if(deviceClass.DC_ID==deviceClassId)
                {
                    if (deviceClass.DC_ParentID == 0)
                    {
                        className = deviceClass.DC_Name;
                    }
                    else
                    {
                        className = IteraDeviceClassName(deviceClass.DC_ParentID, allDeviceClassList) + " -> " + deviceClass.DC_Name;
                    }
                }
            }
            return className;
        }

        /// <summary>
        /// 迭代输出Json字符串
        /// </summary>
        /// <returns></returns>
        public StringBuilder IteraDeviceClassToJsonString(List<DeviceClass> deviceClassIteraList, int DC_ParentID)
        {
            StringBuilder JsonStringBuilder = new StringBuilder();
            JsonStringBuilder.Append("[");
            foreach (DeviceClass deviceClass in deviceClassIteraList)
            {
                if (deviceClass.DC_ParentID == DC_ParentID)
                 {
                     JsonStringBuilder.Append("{");
                     JsonStringBuilder.Append("\"DC_ID\":\"" + deviceClass.DC_ID + "\",");
                     JsonStringBuilder.Append("\"DC_Name\":\"" + Uri.EscapeDataString(deviceClass.DC_Name) + "\"");
                     string str1 = IteraDeviceClassToJsonString(deviceClassIteraList, deviceClass.DC_ID).ToString();
                     if (str1 != "[]")
                     {
                         JsonStringBuilder.Append(",\"childrenDeviceClassList\":" + str1);
                     }                     
                     JsonStringBuilder.Append("},");
                 }
            }
            if (JsonStringBuilder.Length !=0 && JsonStringBuilder[JsonStringBuilder.Length - 1] == ',')
            {
                JsonStringBuilder.Remove(JsonStringBuilder.Length - 1, 1);
            }
            JsonStringBuilder.Append("]");
            return JsonStringBuilder;
        }

        /// <summary>
        /// 迭代设备分类信息
        /// </summary>
        /// <param name="deviceClassList"></param>
        /// <param name="deviceClassIteraList"></param>
        /// <param name="DC_ParentID"></param>
        /// <returns></returns>
        public List<DeviceClass> IteraDeviceClass(List<DeviceClass> deviceClassList, List<DeviceClass> deviceClassIteraList, int DC_ParentID)
        {
            foreach (DeviceClass deviceClass in deviceClassList)
            {
                if (deviceClass.DC_ParentID == DC_ParentID)
                {
                    deviceClassIteraList.Add(deviceClass);
                    deviceClassIteraList = this.IteraDeviceClass(deviceClassList, deviceClassIteraList, deviceClass.DC_ID);
                }
            }
            return deviceClassIteraList;
        }
   		
   		#endregion
    }
}
