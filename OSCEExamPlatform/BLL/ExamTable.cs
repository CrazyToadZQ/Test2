using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// ExamTable
    /// </summary>
    public partial class ExamTable
    {
        private readonly Tellyes.DAL.ExamTable dal = new Tellyes.DAL.ExamTable();
        public ExamTable()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int E_ID)
        {
            return dal.Exists(E_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamTable model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamTable model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int E_ID)
        {

            return dal.Delete(E_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string E_IDlist)
        {
            return dal.DeleteList(E_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamTable GetModel(Guid E_ID)
        {

            return dal.GetModel(E_ID);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Tellyes.Model.ExamTable GetModelByCache(int E_ID)
        //{

        //    string CacheKey = "ExamTableModel-" + E_ID;
        //    object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(E_ID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (Tellyes.Model.ExamTable)objModel;
        //}

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
        public List<Tellyes.Model.ExamTable> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamTable> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamTable> modelList = new List<Tellyes.Model.ExamTable>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamTable model;
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
        /// 是否存在考试编号
        /// </summary>
        public bool ExistsExamNo(string E_No, string oldNo)
        {
            return dal.ExistsExamNo(E_No, oldNo);
        }

         /// <summary>
        /// 是否存在考试名称
        /// </summary>
        public bool ExistsExamName(string E_Name, string oldName)
        {
            return dal.ExistsExamName(E_Name, oldName);
        }

        /// <summary>
        /// 添加一次排考信息
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public bool InsertByTran(Hashtable ht)
        {
            return dal.InsertByTran(ht);
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
            return Tellyes.DAL.ExamTable.GetExamTableApplyByCondition(startDate, endDate, others);
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
            return Tellyes.DAL.ExamTable.GetExamTableApplyByConditionWithNoSum(startDate, endDate, others);
        }

        /// <summary>
        /// 获得有申请的日期
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static DataTable GetExamTableCalenderDataByTimeCondition(string startDate, string endDate)
        {
            return Tellyes.DAL.ExamTable.GetExamTableCalenderDataByTimeCondition(startDate, endDate);
        }

        /// <summary>
        /// 为申请页面左边列表，获取数据
        /// </summary>
        /// <param name="startDate">起始日期</param>
        /// <param name="applyType">审批状态</param>
        /// <param name="levelOneType">考试，课程，ALL（备用）</param>
        /// <returns></returns>
        public static DataTable GetExamTableApplyForLeftList(string startDate, string applyType = null,string levelOneType=null)
        {
            DataTable result;
            DataTable examTable = Tellyes.DAL.ExamTable.GetExamTableApplyForLeftList(startDate, applyType);
            result = examTable.Clone();
            foreach(DataRow row in examTable.Rows)
            {
                result.Rows.Add(row.ItemArray);
            }
            result.Columns.Add("levelOneType");
            foreach (DataRow row in result.Rows)
            {
                row["levelOneType"] = "考试";
            }
            return result;
        }

        /// <summary>
        /// 级联ExamTable与UserInfo
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static DataTable GetListByCondition(string strWhere)
        {
            DataTable result=Tellyes.DAL.ExamTable.GetListByCondition(strWhere).Tables[0];
            result.Columns.Add("levelOneType");
            foreach (DataRow row in result.Rows)
            {
                row["levelOneType"] = "考试";
            }
            return result;
        }

        /// <summary>
        /// 获得可选老师、SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="isSP"></param>
        /// <returns></returns>
        public static DataTable GetJuryOrSPThatCanBeChoose(string E_ID, bool isSP = false)
        { 
            return Tellyes.DAL.ExamTable.GetJuryOrSPThatCanBeChoose(E_ID, isSP);
        }
        #endregion  ExtensionMethod

        #region ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTable"></param>
        /// <param name="examUserList"></param>
        /// <param name="examStationList"></param>
        /// <param name="examStationRoomList"></param>
        /// <param name="examUserMarkSheetList"></param>
        /// <param name="multiStationExamDeviceClassList"></param>
        /// <param name="multiStationExamIllnessCaseList"></param>
        /// <param name="examStudentList"></param>
        /// <param name="examTimeInfoList"></param>
        /// <param name="multiStationExamArrangementList"></param>
        /// <returns></returns>
        public bool AddExamTable
        (
            Model.ExamTable examTable, 
            List<Model.ExamUser> examUserList,
            List<Model.ExamStation> examStationList, 
            List<Model.ExamStation_Room> examStationRoomList,
            List<Model.ExamUserMarkSheet> examUserMarkSheetList, 
            List<Tellyes.Model.MultiStationExam_DeviceClass> multiStationExamDeviceClassList,
            List<Model.MultiStationExam_IllnessCase> multiStationExamIllnessCaseList,
            List<Model.ExamStudent> examStudentList,
            List<Model.ExamTimeInfo> examTimeInfoList,
            List<Model.MultiStationExamArrangement> multiStationExamArrangementList
        )
        {
            return new DAL.ExamTable().Transaction
            (
                new List<List<object>>() 
                { 
                    new List<object>(){"insert", examTable},
                    new List<object>(){"insert", examUserList.ToList<object>()},
                    new List<object>(){"insert", examStationList.ToList<object>()},
                    new List<object>(){"insert", examStationRoomList.ToList<object>()},
                    new List<object>(){"insert", examUserMarkSheetList.ToList<object>()},
                    new List<object>(){"insert", multiStationExamDeviceClassList.ToList<object>()},
                    new List<object>(){"insert", multiStationExamIllnessCaseList.ToList<object>()},
                    new List<object>(){"insert", examStudentList.ToList<object>()},
                    new List<object>(){"insert", examTimeInfoList.ToList<object>()},
                    new List<object>(){"insert", multiStationExamArrangementList.ToList<object>()}
                }
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public List<Model.ExamTable> SearchExamTableByDatetimeNow(DateTime datetime)
        {
            return new DAL.ExamTable().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"Exam_Datetime", datetime}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("E_StartTime", "ASC")
                }
            );
        }

        /// <summary>
        /// 获得人员冲突列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetCrashedApply(string E_ID, bool isSP = false)
        {
            return Tellyes.DAL.ExamTable.GetCrashedApply(E_ID,isSP);
        }

        /// <summary>
        /// 考试成绩页面，按参加考试的学生信息查询考试ID集合
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Guid> SearchExamIDListByConditionInExamScorePage(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTable().SelectExamIDListByConditionInExamScorePage(conditionDictionary);
        }

        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamTable记录
        /// </summary>
        /// <param name="examTable"></param>
        /// <returns></returns>
        public bool AddExamTable(Model.ExamTable examTable)
        {
            return new DAL.ExamTable().Insert(examTable);
        }

        /// <summary>
        /// 删除ExamTable记录
        /// </summary>
        /// <param name="examTable"></param>
        /// <returns></returns>
        public bool RemoveExamTable(Model.ExamTable examTable)
        {
            return new DAL.ExamTable().Delete(examTable);
        }

        /// <summary>
        /// 修改ExamTable记录
        /// </summary>
        /// <param name="examTable"></param>
        /// <returns></returns>
        public bool ModifyExamTable(Model.ExamTable examTable)
        {
            return new DAL.ExamTable().Update((object)examTable);
        }

        /// <summary>
        /// 查询ExamTable下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamTableIdentity()
        {
            return new DAL.ExamTable().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamTable记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamTableCount()
        {
            return new DAL.ExamTable().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamTable记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamTableCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTable().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定e_ID的ExamTable是否存在
        /// </summary>
        /// <param name="e_ID"></param>
        /// <returns></returns>
        public bool? SearchExamTableExists(object e_ID)
        {
            return new DAL.ExamTable().SelectModelObjectExistsByID(e_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamTable是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamTableExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTable().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按e_ID查询ExamTable
        /// </summary>
        /// <param name="e_ID"></param>
        /// <returns></returns>
        public Model.ExamTable SearchExamTableByID(object e_ID)
        {
            return new DAL.ExamTable().SelectModelObjectByID(e_ID);
        }

        /// <summary>
        /// 查询第一个ExamTable对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamTable SearchUniqueExamTableByCondition()
        {
            return new DAL.ExamTable().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamTable SearchUniqueExamTableByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTable().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamTable SearchUniqueExamTableByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamTable().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamTable对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamTable> SearchExamTableByCondition()
        {
            return new DAL.ExamTable().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamTable> SearchExamTableByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTable().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamTable> SearchExamTableByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamTable().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamTable内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamTable> SearchExamTableByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamTable().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }


        /// <summary>
        /// 按学生ID查询ExamTable记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamTableCountByStudentID(Dictionary<string, object> conditionDictionary)
        {
            return new Tellyes.DAL.ExamTable().SelectExamTableCountByStudentID(conditionDictionary);
        }

         /// <summary>
        /// 按学生ID查询ExamTable信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamTableInfoByStudentID(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize) 
        {
            List<object[]> objectExamInfoList = new Tellyes.DAL.ExamTable().SelectExamTableInfoByStudentID(conditionDictionary, pageIndex, pageSize);
            if (objectExamInfoList == null)
            {

                Log4NetUtility.Error(this, "查询考试信息失败");
                return null;
            }
            List<Dictionary<string, object>> examInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in objectExamInfoList)
            {
                examInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"E_ID", item[0]},
                        {"E_Name", item[1]},
                        {"E_Kind", item[2]},
                        {"int3", item[3]},
                        {"E_IsOpenScore", item[4]},
                        {"Exam_StartTime", item[5]},
                        {"Exam_EndTime", item[6]},
                        {"MIN_Exam_StartTime", item[7]},
                        {"MAX_Exam_EndTime", item[8]}
                    }
                );
            }
            return examInfoList;
        }
        
        #endregion

        #region ExtensionMethod

        public DataSet GetTodayExamInfoTable()
        {
            return dal.GetTodayExamInfo();
        }
        #endregion
    }
}
