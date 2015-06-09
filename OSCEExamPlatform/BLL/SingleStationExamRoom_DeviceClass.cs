using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// SingleStationExamRoom_DeviceClass
	/// </summary>
	public partial class SingleStationExamRoom_DeviceClass
	{
		private readonly Tellyes.DAL.SingleStationExamRoom_DeviceClass dal=new Tellyes.DAL.SingleStationExamRoom_DeviceClass();
		public SingleStationExamRoom_DeviceClass()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.SingleStationExamRoom_DeviceClass model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.SingleStationExamRoom_DeviceClass model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.SingleStationExamRoom_DeviceClass GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.SingleStationExamRoom_DeviceClass GetModelByCache(int ID)
		{
			
			string CacheKey = "SingleStationExamRoom_DeviceClassModel-" + ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.SingleStationExamRoom_DeviceClass)objModel;
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
		public List<Tellyes.Model.SingleStationExamRoom_DeviceClass> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.SingleStationExamRoom_DeviceClass> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.SingleStationExamRoom_DeviceClass> modelList = new List<Tellyes.Model.SingleStationExamRoom_DeviceClass>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.SingleStationExamRoom_DeviceClass model;
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
        //增加新设备，更新老设备
        public static void ParseDeviceClassData(DataTable source)
        {
            Tellyes.DAL.SingleStationExamRoom_DeviceClass.ParseDeviceClassData(source);
        }
        //获得已添加设备数据
        public static DataTable GetSelectedDeviceClassData(string E_ID)
        {
            return Tellyes.DAL.SingleStationExamRoom_DeviceClass.GetSelectedDeviceClassData(E_ID);
        }
		#endregion  ExtensionMethod
        #region Extension NHibernate

        /// <summary>
        /// 添加SingleStationExamRoom_DeviceClass记录
        /// </summary>
        /// <param name="singleStationExamRoom_DeviceClass"></param>
        /// <returns></returns>
        public bool AddSingleStationExamRoom_DeviceClass(Model.SingleStationExamRoom_DeviceClass singleStationExamRoom_DeviceClass)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().Insert(singleStationExamRoom_DeviceClass);
        }

        /// <summary>
        /// 删除SingleStationExamRoom_DeviceClass记录
        /// </summary>
        /// <param name="singleStationExamRoom_DeviceClass"></param>
        /// <returns></returns>
        public bool RemoveSingleStationExamRoom_DeviceClass(Model.SingleStationExamRoom_DeviceClass singleStationExamRoom_DeviceClass)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().Delete(singleStationExamRoom_DeviceClass);
        }

        /// <summary>
        /// 修改SingleStationExamRoom_DeviceClass记录
        /// </summary>
        /// <param name="singleStationExamRoom_DeviceClass"></param>
        /// <returns></returns>
        public bool ModifySingleStationExamRoom_DeviceClass(Model.SingleStationExamRoom_DeviceClass singleStationExamRoom_DeviceClass)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().Update((object)singleStationExamRoom_DeviceClass);
        }

        /// <summary>
        /// 查询SingleStationExamRoom_DeviceClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExamRoom_DeviceClassIdentity()
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部SingleStationExamRoom_DeviceClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExamRoom_DeviceClassCount()
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询SingleStationExamRoom_DeviceClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchSingleStationExamRoom_DeviceClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定iD的SingleStationExamRoom_DeviceClass是否存在
        /// </summary>
        /// <param name="iD"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExamRoom_DeviceClassExists(object iD)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectExistsByID(iD);
        }

        /// <summary>
        /// 查询指定条件的SingleStationExamRoom_DeviceClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExamRoom_DeviceClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按iD查询SingleStationExamRoom_DeviceClass
        /// </summary>
        /// <param name="iD"></param>
        /// <returns></returns>
        public Model.SingleStationExamRoom_DeviceClass SearchSingleStationExamRoom_DeviceClassByID(object iD)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectByID(iD);
        }

        /// <summary>
        /// 查询第一个SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public Model.SingleStationExamRoom_DeviceClass SearchUniqueSingleStationExamRoom_DeviceClassByCondition()
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.SingleStationExamRoom_DeviceClass SearchUniqueSingleStationExamRoom_DeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.SingleStationExamRoom_DeviceClass SearchUniqueSingleStationExamRoom_DeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.SingleStationExamRoom_DeviceClass> SearchSingleStationExamRoom_DeviceClassByCondition()
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamRoom_DeviceClass> SearchSingleStationExamRoom_DeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询SingleStationExamRoom_DeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamRoom_DeviceClass> SearchSingleStationExamRoom_DeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询SingleStationExamRoom_DeviceClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamRoom_DeviceClass> SearchSingleStationExamRoom_DeviceClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.SingleStationExamRoom_DeviceClass().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
	}
}

