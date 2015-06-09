using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// ExamStation
    /// </summary>
    public partial class ExamStation
    {
        private readonly Tellyes.DAL.ExamStation dal = new Tellyes.DAL.ExamStation();
        public ExamStation()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ES_ID)
        {
            return dal.Exists(ES_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStation model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamStation model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ES_ID)
        {

            return dal.Delete(ES_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ES_IDlist)
        {
            return dal.DeleteList(ES_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamStation GetModel(Guid ES_ID)
        {

            return dal.GetModel(ES_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamStation GetModelByCache(Guid ES_ID)
        {

            string CacheKey = "ExamStationModel-" + ES_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ES_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamStation)objModel;
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
        public List<Tellyes.Model.ExamStation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamStation> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamStation> modelList = new List<Tellyes.Model.ExamStation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamStation model;
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
        /// 判断考站的完备性
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <returns></returns>
        public bool ESIsFinished(Guid ES_ID)
        {
            return dal.ESIsFinished(ES_ID);
        }

        /// <summary>
        /// 更新考站表，主观评分比例
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="int2"></param>
        public void UpdateSubRate(string ES_ID, string int2)
        {
            dal.UpdateSubRate(ES_ID, int2);
        }

        /// <summary>
        /// 根据考试ID，获得考站信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetSingleExamData(string E_ID)
        {
            return Tellyes.DAL.ExamStation.GetSingleExamData(E_ID);
        }

        //查找当前考生的下一个考站
        public string SelectNextStationName(Guid ExamID, int ExamKind, int UID, DateTime dt1, DateTime dt2)
        {
            string ES_Name = "";

            DataTable dt = dal.SelectNextStationName(ExamID, ExamKind, UID, dt1, dt2).Tables[0];
            int rows = dt.Rows.Count;

            if (rows > 0)
            {
                ES_Name = dt.Rows[0]["ES_Name"].ToString();
            }
            else
            {
                ES_Name = "当前考生考试结束";
            }

            return ES_Name;
        }

        //查找当前考生的下一个考站的房间名称
        public string SelectNextStationRoomName(Guid ExamID, int ExamKind, int UID, DateTime dt1, DateTime dt2)
        {
            string roomName = "";
            DataTable dt = dal.SelectNextStationRoomName(ExamID, ExamKind, UID, dt1, dt2).Tables[0];
            int rows = dt.Rows.Count;

            if (rows > 0)
            {
                roomName = dt.Rows[0]["Room_Name"].ToString();
            }
            else
            {
                roomName = "当前考生考试结束";
            }
            return roomName;
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStationIdentity()
        {
            return new DAL.ExamStation().SelectNextIdentity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStationAndRoomByExamID(Guid examID)
        {
            List<object[]> itemList = new DAL.ExamStation().SelectExamStationAndRoomByExamID(examID);
            if (itemList == null) 
            {
                Log4NetUtility.Error(this, "查询考站信息失败");
                return null;
            }

            List<Dictionary<string, object>> examStationAndRoomList = new List<Dictionary<string, object>>();
            foreach (object[] item in itemList)
            {
                examStationAndRoomList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ExamStation", item[0]},
                        {"Room", item[1]},
                        {"ExamStationClassName", item[2]}
                    }
                );
            }
            return examStationAndRoomList;
        }

        /// <summary>
        /// 按考站房间ID查询考站信息
        /// </summary>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public Model.ExamStation SearchExamStationByExamStationRoomID(Guid ESR_ID)
        {
            return new DAL.ExamStation().SelectExamStationByExamStationRoomID(ESR_ID);
        }

        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamStation记录
        /// </summary>
        /// <param name="examStation"></param>
        /// <returns></returns>
        public bool AddExamStation(Model.ExamStation examStation)
        {
            return new DAL.ExamStation().Insert(examStation);
        }

        /// <summary>
        /// 删除ExamStation记录
        /// </summary>
        /// <param name="examStation"></param>
        /// <returns></returns>
        public bool RemoveExamStation(Model.ExamStation examStation)
        {
            return new DAL.ExamStation().Delete(examStation);
        }

        /// <summary>
        /// 修改ExamStation记录
        /// </summary>
        /// <param name="examStation"></param>
        /// <returns></returns>
        public bool ModifyExamStation(Model.ExamStation examStation)
        {
            return new DAL.ExamStation().Update((object)examStation);
        }

        /// <summary>
        /// 查询全部ExamStation记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStationCount()
        {
            return new DAL.ExamStation().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStation记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStationCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定eS_ID的ExamStation是否存在
        /// </summary>
        /// <param name="eS_ID"></param>
        /// <returns></returns>
        public bool? SearchExamStationExists(object eS_ID)
        {
            return new DAL.ExamStation().SelectModelObjectExistsByID(eS_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamStation是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamStationExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按eS_ID查询ExamStation
        /// </summary>
        /// <param name="eS_ID"></param>
        /// <returns></returns>
        public Model.ExamStation SearchExamStationByID(object eS_ID)
        {
            return new DAL.ExamStation().SelectModelObjectByID(eS_ID);
        }

        /// <summary>
        /// 查询第一个ExamStation对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamStation SearchUniqueExamStationByCondition()
        {
            return new DAL.ExamStation().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamStation SearchUniqueExamStationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamStation SearchUniqueExamStationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStation().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamStation对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamStation> SearchExamStationByCondition()
        {
            return new DAL.ExamStation().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamStation> SearchExamStationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStation().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamStation> SearchExamStationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStation().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamStation内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamStation> SearchExamStationByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamStation().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        /// <summary>
        /// 查询考生的考试信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchEachStudentEachExamInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ExamStation().SelectEachStudentEachExamInfoByCondition(conditionDictionary);
            if (examScoreInfoObjectList == null)
            {
                Log4NetUtility.Error(this, "查询考生成绩信息失败");
                return null;
            }
            List<Dictionary<string, object>> perStudentScoreInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreInfoObjectList)
            {
                perStudentScoreInfoList.Add
                (
                    new Dictionary<string, object>() 
                    {
                        {"ExamStation", item[0]},
                        {"Exam_Station_Class_Name", item[1]},
                        {"Room_Name", item[2]},
                        {"E_StartTime", item[3]},
                        {"score", item[4]},
                        {"file_path", item[5]},
                    }
                );
            }
            return perStudentScoreInfoList;
        }


        /// <summary>
        /// 查询考试信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchEachExamInfoByCondition(Guid examStationID)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ExamStation().SelectEachExamEachExamStationInfoByCondition(examStationID);
            if (examScoreInfoObjectList == null)
            {
                Log4NetUtility.Error(this, "查询考生成绩信息失败");
                return null;
            }
            List<Dictionary<string, object>> perStudentScoreInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreInfoObjectList)
            {
                perStudentScoreInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ExamStation", item[0]},
                        {"Exam_Station_Class_Name", item[1]}
                    }
                );
            }
            return perStudentScoreInfoList;
        }


        // <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<Guid, object> SearchEachExamInfoByCondition(List<Guid> examTableLlist)
        {
            List<object[]> examStationList = new Tellyes.DAL.ExamStation().SelectEachExamStationCountByCondition(examTableLlist);
            if (examStationList == null)
            {
                Log4NetUtility.Error(this, "查询考站总量失败");
                return null;
            }

            Dictionary<Guid, object> eaxmInfoDictionary = new Dictionary<Guid, object>();
            foreach (object[] item in examStationList)
            {
                Guid examTableID = Guid.Parse(item[0].ToString());

                if (!eaxmInfoDictionary.ContainsKey(examTableID))
                {
                    eaxmInfoDictionary.Add(examTableID,new object());
                }
                eaxmInfoDictionary[examTableID] = item[1];
            }
            return eaxmInfoDictionary;
        }
        #endregion

        #region  扩展方法
        /// <summary>
        /// 教师查询-获得多站式考试的考站数据列表 陶东利-2014-7-17
        /// 输入E_ID
        /// </summary>
        public List<Tellyes.Model.CompositedModelTeacherQueryExamStation> GetModelListTeacherQueryMultiStation(Guid E_ID)
        {
            DataSet ds = dal.GetListTeacherQueryMultiStation(E_ID); 
            return DataRowToModelTeacherQuery(ds.Tables[0]);  
        }

        /// <summary>
        /// 教师查询-DataTable数据转换为model，返回数据列表  陶东利-2014-7-17
        /// </summary>
        public List<Tellyes.Model.CompositedModelTeacherQueryExamStation> DataRowToModelTeacherQuery(DataTable dt)
        {
            List<Tellyes.Model.CompositedModelTeacherQueryExamStation> modelList = new List<Tellyes.Model.CompositedModelTeacherQueryExamStation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.CompositedModelTeacherQueryExamStation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModelTeacherQuery(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }


        /// <summary>
        /// 教师查询-获得某个考站、某个房间中的评委或SP列表 陶东利-2014-7-17
        /// </summary>
        /// <param name="ES_ID">考站ID</param>
        /// <param name="RoomId">房间ID</param>
        /// <param name="Flag">查询评委列表或Sp列表标识位（Flag=1：查询评委列表，Flag=2：查询SP列表）</param>
        /// <returns></returns>
        public List<Tellyes.Model.CompositedModelTeacherQueryExamStationUser> GetModelListTeacherQuery(int ES_ID, int RoomId, int Flag)
        {
            DataSet ds = dal.GetListTeacherQuery(ES_ID, RoomId, Flag);
            return DataRowToModelTeacherQueryUser(ds.Tables[0]);  
        }


        /// <summary>
        /// 教师查询-DataTable数据转换为model，返回数据列表  陶东利-2014-7-17
        /// </summary>
        public List<Tellyes.Model.CompositedModelTeacherQueryExamStationUser> DataRowToModelTeacherQueryUser(DataTable dt)
        {
            List<Tellyes.Model.CompositedModelTeacherQueryExamStationUser> modelList = new List<Tellyes.Model.CompositedModelTeacherQueryExamStationUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.CompositedModelTeacherQueryExamStationUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModelTeacherQueryUser(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        #endregion
    }
}
