using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// MultiStationExamArrangement
    /// </summary>
    public partial class MultiStationExamArrangement
    {
        private readonly Tellyes.DAL.MultiStationExamArrangement dal = new Tellyes.DAL.MultiStationExamArrangement();
        public MultiStationExamArrangement()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSEA_ID)
        {
            return dal.Exists(MSEA_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.MultiStationExamArrangement model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.MultiStationExamArrangement model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MSEA_ID)
        {

            return dal.Delete(MSEA_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MSEA_IDlist)
        {
            return dal.DeleteList(MSEA_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.MultiStationExamArrangement GetModel(int MSEA_ID)
        {

            return dal.GetModel(MSEA_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.MultiStationExamArrangement GetModelByCache(int MSEA_ID)
        {

            string CacheKey = "MultiStationExamArrangementModel-" + MSEA_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MSEA_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.MultiStationExamArrangement)objModel;
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
        public List<Tellyes.Model.MultiStationExamArrangement> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.MultiStationExamArrangement> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.MultiStationExamArrangement> modelList = new List<Tellyes.Model.MultiStationExamArrangement>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.MultiStationExamArrangement model;
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

        #region Extension NHibernate

        /// <summary>
        /// 添加MultiStationExamArrangement记录
        /// </summary>
        /// <param name="multiStationExamArrangement"></param>
        /// <returns></returns>
        public bool AddMultiStationExamArrangement(Model.MultiStationExamArrangement multiStationExamArrangement)
        {
            return new DAL.MultiStationExamArrangement().Insert(multiStationExamArrangement);
        }

        /// <summary>
        /// 删除MultiStationExamArrangement记录
        /// </summary>
        /// <param name="multiStationExamArrangement"></param>
        /// <returns></returns>
        public bool RemoveMultiStationExamArrangement(Model.MultiStationExamArrangement multiStationExamArrangement)
        {
            return new DAL.MultiStationExamArrangement().Delete(multiStationExamArrangement);
        }

        /// <summary>
        /// 修改MultiStationExamArrangement记录
        /// </summary>
        /// <param name="multiStationExamArrangement"></param>
        /// <returns></returns>
        public bool ModifyMultiStationExamArrangement(Model.MultiStationExamArrangement multiStationExamArrangement)
        {
            return new DAL.MultiStationExamArrangement().Update((object)multiStationExamArrangement);
        }

        /// <summary>
        /// 查询MultiStationExamArrangement下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExamArrangementIdentity()
        {
            return new DAL.MultiStationExamArrangement().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部MultiStationExamArrangement记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExamArrangementCount()
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExamArrangement记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchMultiStationExamArrangementCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定mSEA_ID的MultiStationExamArrangement是否存在
        /// </summary>
        /// <param name="mSEA_ID"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExamArrangementExists(object mSEA_ID)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectExistsByID(mSEA_ID);
        }

        /// <summary>
        /// 查询指定条件的MultiStationExamArrangement是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExamArrangementExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按mSEA_ID查询MultiStationExamArrangement
        /// </summary>
        /// <param name="mSEA_ID"></param>
        /// <returns></returns>
        public Model.MultiStationExamArrangement SearchMultiStationExamArrangementByID(object mSEA_ID)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByID(mSEA_ID);
        }

        /// <summary>
        /// 查询第一个MultiStationExamArrangement对象
        /// </summary>
        /// <returns></returns>
        public Model.MultiStationExamArrangement SearchUniqueMultiStationExamArrangementByCondition()
        {
            return new DAL.MultiStationExamArrangement().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个MultiStationExamArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.MultiStationExamArrangement SearchUniqueMultiStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExamArrangement().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个MultiStationExamArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.MultiStationExamArrangement SearchUniqueMultiStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExamArrangement().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部MultiStationExamArrangement对象
        /// </summary>
        /// <returns></returns>
        public List<Model.MultiStationExamArrangement> SearchMultiStationExamArrangementByCondition()
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExamArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.MultiStationExamArrangement> SearchMultiStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询MultiStationExamArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.MultiStationExamArrangement> SearchMultiStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询MultiStationExamArrangement内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.MultiStationExamArrangement> SearchMultiStationExamArrangementByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public List<Model.MultiStationExamArrangement> SearchMultiStationExamArrangementByExamID(Guid examID)
        {
            return new DAL.MultiStationExamArrangement().SelectModelObjectByCondition
            (
                new Dictionary<string, object>()
                {
                    {"Exam_ID", examID}
                },
                null
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, int> SearchStudentCountDictionaryInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            object[] studentCountDictionary = new DAL.MultiStationExamArrangement().SelectStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
            if (studentCountDictionary == null) 
            {
                Log4NetUtility.Error(this, "手持评分，查询考试学生数量失败");
                return null;
            }
            return new Dictionary<string, int>() 
            { 
                {"All_Student_Count", Convert.ToInt32(studentCountDictionary[0])},
                {"Student_With_Score_Count", Convert.ToInt32(studentCountDictionary[1])}
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchStudentCountInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExamArrangement().SelectStudentCountInHandScoreByCondition(conditionDictionary);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchStudentListInHandScoreByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            List<object[]> _studentList = new DAL.MultiStationExamArrangement().SelectStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
            if (_studentList == null)
            {
                Log4NetUtility.Error(this, "手持评分，查询考生分页信息失败");
                return null;
            }
            List<Dictionary<string, object>> studentList = new List<Dictionary<string, object>>();
            foreach (object[] student in _studentList)
            {
                studentList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"StudentUserInfoID", student[0]},
                        {"StudentUserInfoTrueName", student[1]},
                        {"StudentUserInfoName", student[2]},
                        {"ExamStudentNumber", student[3]},
                        {"OrganizationName", student[4]},
                        {"ExamStartTime", student[5]},
                        {"StudentScore", student[6]},
                        {"StudentState", student[7]},
                        {"ExamEndTime", student[8]}
                    }
                );
            }
            return studentList;
        }

        /// <summary>
        /// 根据RoomID查找考试ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetExamID(string RoomID)
        {
            DataTable dt = new DataTable();
            DataSet ds = dal.GetExamID(RoomID);
            if (ds != null)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站排考表
        /// </summary>
        /// <param name="ExamID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetArrangementTable(Guid ExamID, int RoomID)
        {
            DataTable dt = dal.GetArrangementTable(ExamID, RoomID).Tables[0];
            return dt;
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站ESID
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string GetESIDStr(Guid ExamID, int RoomID)
        {
            string ESIDStr = "";
            DataTable dt = GetArrangementTable(ExamID, RoomID);
            if (dt.Rows.Count > 0)
            {
                ESIDStr = dt.Rows[0]["ES_ID"].ToString();
            }
            return ESIDStr;
        }

        //获取系统时间
        public string GetSystemTime()
        {
            string system = "";
            DataTable dt = dal.GetSystemTime().Tables[0];
            system = dt.Rows[0][0].ToString();

            return system;
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod
        /// <summary>
        /// 根据考试EID查找考试房间ID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet GetMultiRoom(Guid EID)
        {
            return dal.GetMultiRoom(EID);
        }

        /// <summary>
        /// 查找该房间的考试开始时间和结束时间
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetRoomExamStartEndTime(Guid EID, int RoomID)
        {
            return dal.GetRoomExamStartEndTime(EID, RoomID);
        }
        #endregion

    }
}
