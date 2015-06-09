using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// 考站和房间关联表
    /// </summary>
    public partial class ExamStation_Room
    {
        private readonly Tellyes.DAL.ExamStation_Room dal = new Tellyes.DAL.ExamStation_Room();
        public ExamStation_Room()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ESR_ID)
        {
            return dal.Exists(ESR_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStation_Room model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamStation_Room model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ESR_ID)
        {

            return dal.Delete(ESR_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ESR_IDlist)
        {
            return dal.DeleteList(ESR_IDlist);
        }

        /// <summary>
        /// 获取房间名称信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetRoomInfo(string strWhere)
        {
            return dal.GetRoomInfo(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamStation_Room GetModel(int ESR_ID)
        {

            return dal.GetModel(ESR_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamStation_Room GetModelByCache(int ESR_ID)
        {

            string CacheKey = "ExamStation_RoomModel-" + ESR_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ESR_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamStation_Room)objModel;
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
        public List<Tellyes.Model.ExamStation_Room> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamStation_Room> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamStation_Room> modelList = new List<Tellyes.Model.ExamStation_Room>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamStation_Room model;
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
        /// 判断是否已经，包含了此房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="Room_ID"></param>
        /// <returns></returns>
        public static bool IsESRoomExisted(string ES_ID, string Room_ID)
        {
            return Tellyes.DAL.ExamStation_Room.isESRoomExisted(ES_ID, Room_ID);
        }

        /// <summary>
        /// 向某考站增加一个房间
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="Room_ID"></param>
        public static void AddNewRoomToES(string ES_ID, string Room_ID)
        {
            Tellyes.DAL.ExamStation_Room.AddNewRoomToES(ES_ID, Room_ID);
        }

        /// <summary>
        /// 从某考站，删除某房间
        /// </summary>
        /// <param name="self"></param>
        /// <param name="ESR_ID"></param>
        public static void DeleteRoomFromES(string ESR_ID)
        {
            Tellyes.DAL.ExamStation_Room.DeleteRoomFromES(ESR_ID);
        }

        /// <summary>
        /// 根据E_ID获得考站中房间信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetExamStationRoomByE_ID(string E_ID)
        {
            return Tellyes.DAL.ExamStation_Room.GetExamStationRoomByE_ID(E_ID);
        }

        /// <summary>
        /// 根据E_ID获得考站中冲突房间信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetErrorExamStationRoomByE_ID(string E_ID)
        {
            return Tellyes.DAL.ExamStation_Room.GetErrorExamStationRoomByE_ID(E_ID);
        }

        /// <summary>
        /// 根据E_ID获得考站中可选房间信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingExamStationRoomByE_ID(string E_ID)
        {
            return Tellyes.DAL.ExamStation_Room.GetPreparingExamStationRoomByE_ID(E_ID);
        }
        #endregion  ExtensionMethod

        #region  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStationRoomIdentity()
        {
            return new DAL.ExamStation_Room().SelectNextIdentity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <returns></returns>
        public Dictionary<Guid, List<Dictionary<string, object>>> SearchExamStationRoomAndRoomByExamTableID(Guid examTableID)
        {
            List<object[]> examStationRoomAndRoomList = new DAL.ExamStation_Room().SelectExamStationRoomAndRoomByExamTableID(examTableID);
            if (examStationRoomAndRoomList == null)
            {
                Log4NetUtility.Error(this, "查询考站房间信息失败，E_ID：" + examTableID);
                return null;
            }

            Dictionary<Guid, List<Dictionary<string, object>>> examStationAndExamStationRoomDictionary = new Dictionary<Guid, List<Dictionary<string, object>>>();
            foreach (object[] examStationRoomAndRoom in examStationRoomAndRoomList)
            {
                Guid examStationID = Guid.Parse(examStationRoomAndRoom[1].ToString());
                if (!examStationAndExamStationRoomDictionary.ContainsKey(examStationID))
                {
                    examStationAndExamStationRoomDictionary[examStationID] = new List<Dictionary<string, object>>();
                }
                examStationAndExamStationRoomDictionary[examStationID].Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ESR_ID", examStationRoomAndRoom[0]},
                        {"ES_ID", examStationRoomAndRoom[1]},
                        {"Room_ID", examStationRoomAndRoom[2]},
                        {"Room_Name", examStationRoomAndRoom[3]}
                    }
                );
            }
            return examStationAndExamStationRoomDictionary;
        }

        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamStation_Room记录
        /// </summary>
        /// <param name="examStation_Room"></param>
        /// <returns></returns>
        public bool AddExamStation_Room(Model.ExamStation_Room examStation_Room)
        {
            return new DAL.ExamStation_Room().Insert(examStation_Room);
        }

        /// <summary>
        /// 删除ExamStation_Room记录
        /// </summary>
        /// <param name="examStation_Room"></param>
        /// <returns></returns>
        public bool RemoveExamStation_Room(Model.ExamStation_Room examStation_Room)
        {
            return new DAL.ExamStation_Room().Delete(examStation_Room);
        }

        /// <summary>
        /// 修改ExamStation_Room记录
        /// </summary>
        /// <param name="examStation_Room"></param>
        /// <returns></returns>
        public bool ModifyExamStation_Room(Model.ExamStation_Room examStation_Room)
        {
            return new DAL.ExamStation_Room().Update((object)examStation_Room);
        }

        /// <summary>
        /// 查询ExamStation_Room下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStation_RoomIdentity()
        {
            return new DAL.ExamStation_Room().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamStation_Room记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStation_RoomCount()
        {
            return new DAL.ExamStation_Room().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStation_Room记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStation_RoomCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation_Room().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定eSR_ID的ExamStation_Room是否存在
        /// </summary>
        /// <param name="eSR_ID"></param>
        /// <returns></returns>
        public bool? SearchExamStation_RoomExists(object eSR_ID)
        {
            return new DAL.ExamStation_Room().SelectModelObjectExistsByID(eSR_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamStation_Room是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamStation_RoomExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation_Room().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按eSR_ID查询ExamStation_Room
        /// </summary>
        /// <param name="eSR_ID"></param>
        /// <returns></returns>
        public Model.ExamStation_Room SearchExamStation_RoomByID(object eSR_ID)
        {
            return new DAL.ExamStation_Room().SelectModelObjectByID(eSR_ID);
        }

        /// <summary>
        /// 查询第一个ExamStation_Room对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamStation_Room SearchUniqueExamStation_RoomByCondition()
        {
            return new DAL.ExamStation_Room().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamStation_Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamStation_Room SearchUniqueExamStation_RoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation_Room().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamStation_Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamStation_Room SearchUniqueExamStation_RoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStation_Room().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamStation_Room对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamStation_Room> SearchExamStation_RoomByCondition()
        {
            return new DAL.ExamStation_Room().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStation_Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamStation_Room> SearchExamStation_RoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation_Room().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamStation_Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamStation_Room> SearchExamStation_RoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStation_Room().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamStation_Room内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamStation_Room> SearchExamStation_RoomByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamStation_Room().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        public List<Dictionary<string, object>> SearchExamStation_RoomListByExamTableIDAndExamStationID(Guid examTableID, Guid examStationID)
        {
            List<object[]> examRoomList = new DAL.ExamStation_Room().SelectExamStation_RoomListByExamTableID(examTableID, examStationID);
            if (examRoomList == null || examRoomList.Count < 1)
            {
                Log4NetUtility.Error(this, "考试房间信息查询失败：ExamTable_ID ： " + examTableID.ToString() + "ExamStationID：" + examStationID.ToString());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in examRoomList)
            {
                result.Add(new Dictionary<string, object>() 
                { 
                    {"ExamStation_RoomList", item[0]},
                    {"Room_Name", item[1]},
                });
            }
            return result;
        }

        #endregion
    }
}
