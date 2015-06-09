using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
namespace Tellyes.BLL
{
	/// <summary>
	/// 预约信息表
	/// </summary>
	public partial class Reservation
	{
		private readonly Tellyes.DAL.Reservation dal=new Tellyes.DAL.Reservation();
		public Reservation()
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
		public bool Exists(int Reservation_ID)
		{
			return dal.Exists(Reservation_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.Reservation model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.Reservation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Reservation_ID)
		{
			
			return dal.Delete(Reservation_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Reservation_IDlist )
		{
			return dal.DeleteList(Reservation_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.Reservation GetModel(int Reservation_ID)
		{
			
			return dal.GetModel(Reservation_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.Reservation GetModelByCache(int Reservation_ID)
		{
			
			string CacheKey = "ReservationModel-" + Reservation_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Reservation_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.Reservation)objModel;
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
		public List<Tellyes.Model.Reservation> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.Reservation> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.Reservation> modelList = new List<Tellyes.Model.Reservation>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.Reservation model;
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

        #region Extension NHibernate

        /// <summary>
        /// 添加Reservation记录
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool AddReservation(Model.Reservation reservation)
        {
            return new DAL.Reservation().Insert(reservation);
        }

        /// <summary>
        /// 删除Reservation记录
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool RemoveReservation(Model.Reservation reservation)
        {
            return new DAL.Reservation().Delete(reservation);
        }

        /// <summary>
        /// 修改Reservation记录
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool ModifyReservation(Model.Reservation reservation)
        {
            return new DAL.Reservation().Update((object)reservation);
        }

        /// <summary>
        /// 查询Reservation下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchReservationIdentity()
        {
            return new DAL.Reservation().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部Reservation记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchReservationCount()
        {
            return new DAL.Reservation().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询Reservation记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchReservationCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Reservation().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定reservationID的Reservation是否存在
        /// </summary>
        /// <param name="reservationID"></param>
        /// <returns></returns>
        public bool? SearchReservationExists(object reservationID)
        {
            return new DAL.Reservation().SelectModelObjectExistsByID(reservationID);
        }

        /// <summary>
        /// 查询指定条件的Reservation是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchReservationExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Reservation().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按reservationID查询Reservation
        /// </summary>
        /// <param name="reservationID"></param>
        /// <returns></returns>
        public Model.Reservation SearchReservationByID(object reservationID)
        {
            return new DAL.Reservation().SelectModelObjectByID(reservationID);
        }

        /// <summary>
        /// 查询第一个Reservation对象
        /// </summary>
        /// <returns></returns>
        public Model.Reservation SearchUniqueReservationByCondition()
        {
            return new DAL.Reservation().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个Reservation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.Reservation SearchUniqueReservationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Reservation().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个Reservation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.Reservation SearchUniqueReservationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Reservation().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部Reservation对象
        /// </summary>
        /// <returns></returns>
        public List<Model.Reservation> SearchReservationByCondition()
        {
            return new DAL.Reservation().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询Reservation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.Reservation> SearchReservationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.Reservation().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询Reservation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.Reservation> SearchReservationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.Reservation().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询Reservation内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.Reservation> SearchReservationByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.Reservation().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        /// <summary>
        /// 根据预约ID及资源类型，获得冲突信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Dictionary<String, Object>> SearchClashedInfoByReservationIDAndResourceType(Dictionary<string, object> condition)
        {
            List<object[]> roomAndClashedInfoList = new Tellyes.DAL.Reservation().SelectClashedInfoByReservationIDAndResourceType(condition);
            if (roomAndClashedInfoList == null)
            {
                Log4NetUtility.Error(this, "冲突信息查询失败：ReservationID ： " + condition["ReservationID"].ToString().Trim());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in roomAndClashedInfoList)
            {
                result.Add(new Dictionary<string, object>() { 
                    { "Reservation_ID", item[0] }
                    , { "ReservationName", item[1] }
                    , { "ResourceID", item[2] } 
                    , { "ReservationTimeInfoDateInfo", item[3] } 
                    , { "StartTime", item[4] } 
                    , { "EndTime", item[5] } 
                });
            }
            return result;
        }

        /// <summary>
        /// 根据条件搜索参加考试的考生总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int? SearchStudentInfoTotalCount(Dictionary<string, object> condition) 
        {
            return new Tellyes.DAL.Reservation().SelectStudentInfoTotalCount(condition);
        }

        /// <summary>
        /// 根据条件搜索参加考试的考生
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Dictionary<String, Object>> SearchStudentInfoForReservation(Dictionary<string, object> condition)
        {
            List<object[]> studentInfoList = new Tellyes.DAL.Reservation().SelectStudentInfoForReservation(condition);
            if (studentInfoList == null)
            {
                Log4NetUtility.Error(this, "参加考试考生信息查询失败：ReservationID ： " + condition["ReservationID"].ToString().Trim());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in studentInfoList)
            {
                result.Add(new Dictionary<string, object>() { 
                    { "UserInfo", item[0] }
                    , { "O_ID_List", item[1] }
                });
            }
            return result;
        }

        #endregion

		#region  ExtensionMethod
        /// <summary>
        /// 获得有申请的起始日期
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static DataTable GetReservationCalenderDataByTimeCondition(string startDate, string endDate, string otherSqlCondition = null)
        {
            return Tellyes.DAL.Reservation.GetReservationCalenderDataByTimeCondition(startDate, endDate,otherSqlCondition);
        }

        /// <summary>
        /// 获得有申请的日期的分类统计
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByCondition(string startDate, string endDate, string others = null)
        {
            return Tellyes.DAL.Reservation.GetExamTableApplyByCondition(startDate, endDate, others);
        }

        /// <summary>
        /// 直接获取，带有详细时间的考试申请
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyByConditionWithNoSum(string startDate, string endDate, string others = null)
        {
            return Tellyes.DAL.Reservation.GetExamTableApplyByConditionWithNoSum(startDate, endDate, others);
        }

        /// <summary>
        /// 生成测试数据
        /// </summary>
        public static void MockTestData()
        {
            Tellyes.DAL.Reservation.MockTestData();
        }
		#endregion  ExtensionMethod
	}
}

