using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class Room1
    {
        private readonly Tellyes.DAL.Room1 dal=new Tellyes.DAL.Room1();
		public Room1()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Room_ID)
		{
			return dal.Exists(Room_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.Room1 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.Room1 model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Room_ID)
		{
			
			return dal.Delete(Room_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Room_IDlist )
		{
			return dal.DeleteList(Room_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.Room1 GetModel(int Room_ID)
		{
			
			return dal.GetModel(Room_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.Room1 GetModelByCache(int Room_ID)
		{
			
			string CacheKey = "RoomModel-" + Room_ID;
			object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Room_ID);
					if (objModel != null)
					{
						int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
						Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.Room1)objModel;
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
		public List<Tellyes.Model.Room1> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.Room1> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.Room1> modelList = new List<Tellyes.Model.Room1>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.Room1 model;
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
        /// <summary>
        /// 获得所有可选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllRoomsThatCanBeChoose(string ES_ID)
        {
            return Tellyes.DAL.Room1.GetAllRoomsThatCanBeChoose(ES_ID);
        }

        /// <summary>
        /// 获得所有可选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllRoomsThatCanBeChooseByMemory(string Room_IDs)
        {
            return Tellyes.DAL.Room1.GetAllRoomsThatCanBeChooseByMemory(Room_IDs);
        }

        /// <summary>
        /// 获得所有已选房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public static DataTable GetAllSelectedRooms(string ES_ID)
        {
            return Tellyes.DAL.Room1.GetAllSelectedRooms(ES_ID);
        }

        /// <summary>
        /// 根据房间名称查找房间RoomID
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public int GetRoomID(string roomName)
        {
            int RoomID = 0;
            if (!string.IsNullOrEmpty(roomName))
            {
                DataTable dt = dal.GetRoomID(roomName).Tables[0];
                int count = dt.Rows.Count;
                if (count > 0)
                {
                    RoomID = Convert.ToInt32(dt.Rows[0]["Room_ID"].ToString());
                }
            }

            return RoomID;
        }

        public DataSet GetRoomIDName()
        {
            return dal.GetRoomIDName();
        }
		#endregion  ExtensionMethod
    }
}
