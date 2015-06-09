using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// DeviceClassOriginal
	/// </summary>
	public partial class DeviceClassOriginal
	{
		private readonly Tellyes.DAL.DeviceClassOriginal dal=new Tellyes.DAL.DeviceClassOriginal();
        public DeviceClassOriginal() 
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

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
		public int  Add(Tellyes.Model.DeviceClassOriginal model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.DeviceClassOriginal model)
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
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DC_IDlist )
		{
			return dal.DeleteList(DC_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.DeviceClassOriginal GetModel(int DC_ID)
		{
			
			return dal.GetModel(DC_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.DeviceClassOriginal GetModelByCache(int DC_ID)
		{
			
			string CacheKey = "DeviceClassModel-" + DC_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DC_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.DeviceClassOriginal)objModel;
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
		public List<Tellyes.Model.DeviceClassOriginal> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.DeviceClassOriginal> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.DeviceClassOriginal> modelList = new List<Tellyes.Model.DeviceClassOriginal>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.DeviceClassOriginal model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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
        public static DataTable GetDeviceClassData(int E_ID)
        {
            return Tellyes.DAL.DeviceClassOriginal.GetDeviceClassData(E_ID);
        }

        public static DataTable GetLastLevelDeviceClassData(string parentID, Guid E_ID)
        {
            return Tellyes.DAL.DeviceClassOriginal.GetLastLevelDeviceClassData(parentID,E_ID);
        }

        public static DataTable GetLastLevelDeviceClassDataBaseMemory(string parentID, string DC_IDs)
        {
            return Tellyes.DAL.DeviceClassOriginal.GetLastLevelDeviceClassDataBaseMemory(parentID, DC_IDs);
        }

        public static DataTable GetDeviceClassByName(string partOfDC_Name, string E_ID)
        {
            return Tellyes.DAL.DeviceClassOriginal.GetDeviceClassByName(partOfDC_Name,E_ID);
        }

        public static DataTable GetDeviceClassByMemory(string partOfDC_Name, string DC_IDs)
        {
            return Tellyes.DAL.DeviceClassOriginal.GetDeviceClassByMemory(partOfDC_Name, DC_IDs);
        }

        /// <summary>
        /// 根据查询条件获得所需要的查询结果
        /// </summary>
        /// <param name="Pid"></param>
        /// <param name="Name"></param>
        /// <param name="IsTellyes"></param>
        /// <returns></returns>
        public DataSet GetDeviceByInfo(string Pid, string Name, string IsTellyes)
        {
            return dal.GetDeviceByInfo(Pid, Name, IsTellyes);
        }

        /// <summary>
        /// 更新建议合理库存量
        /// </summary>
        /// <param name="DC_ID">设备类型</param>
        /// <param name="newStock">合理库存量</param>
        public static void UpdateStockForSpecialDeviceClass(string DC_ID, string newStock)
        {
            Tellyes.DAL.DeviceClassOriginal.UpdateStockForSpecialDeviceClass(DC_ID, newStock);
        }

        /// <summary>
        /// 返回所有第三级设备类别
        /// </summary>
        /// <returns></returns>
        public static DataTable GetLastLevelDeviceClass()
        {
            return Tellyes.DAL.DeviceClassOriginal.GetLastLevelDeviceClass();
        }

        /// <summary>
        /// 验证最后一级设备分类中是否存在该分类名称
        /// </summary>
        /// <param name="deviceclassName">设备分类名称</param>
        /// <returns></returns>
        public bool IsExistLastLevelDeviceClass(string deviceclassName)
        {
            DataTable dtTemp = dal.GetLastLevelDeviceClass(deviceclassName);
            bool flag;
            if (dtTemp.Rows.Count > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// 返回最后一级设备分类中该分类名称信息
        /// </summary>
        /// <param name="deviceclassName">设备分类名称</param>
        /// <returns></returns>
        public DataTable GetLastLevelDeviceClass(string deviceclassName)
        {
            return dal.GetLastLevelDeviceClass(deviceclassName);
        }
		#endregion  ExtensionMethod
	}
}

