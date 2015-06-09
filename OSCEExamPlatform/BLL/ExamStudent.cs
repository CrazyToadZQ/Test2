using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class ExamStudent
    {
        private readonly DAL.ExamStudent dal = new DAL.ExamStudent();
        public ExamStudent()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EStu_ID)
        {
            return dal.Exists(EStu_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ExamStudent model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.ExamStudent model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int EStu_ID)
        {

            return dal.Delete(EStu_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EStu_IDlist)
        {
            return dal.DeleteList(EStu_IDlist);
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList_Where(string sql)
        {
            return dal.DeleteList_Where(sql);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.ExamStudent GetModel(int EStu_ID)
        {

            return dal.GetModel(EStu_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.ExamStudent GetModelByCache(int EStu_ID)
        {

            string CacheKey = "ExamStudentModel-" + EStu_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EStu_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.ExamStudent)objModel;
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
        public List<Model.ExamStudent> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.ExamStudent> DataTableToList(DataTable dt)
        {
            List<Model.ExamStudent> modelList = new List<Model.ExamStudent>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.ExamStudent model;
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
        /// 递增打印次数
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        public static void AddPrintCount(string E_ID, string U_ID)
        {
            Tellyes.DAL.ExamStudent.AddPrintCount(E_ID, U_ID);
        }

        /// <summary>
        /// 获取某次考试考生信息
        /// </summary>
        /// <param name="examID">考试id</param>
        /// <returns></returns>
        public DataSet GetExamStudentInfo(Guid examID)
        {
            return dal.GetExamStudentInfo(examID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStudentAndUserInfoByExamID(Guid examID)
        {
            List<object[]> itemList = new DAL.ExamStudent().SelectExamStudentAndUserInfoByExamID(examID);
            if (itemList == null)
            {
                Log4NetUtility.Error(this, "查询考试学生信息失败");
                return null;
            }

            List<Dictionary<string, object>> examStudentAndUserInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in itemList)
            {
                examStudentAndUserInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ExamStudent", item[0]},
                        {"U_Name", item[1]},
                        {"U_TrueName", item[2]}
                    }
                );
            }
            return examStudentAndUserInfoList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public List<object> SearchExamStudentUNameByExamID(int E_ID)
        {
            return new DAL.ExamStudent().SelectExamStudentUNameByExamID(E_ID);
        }

        /// <summary>
        /// 根据考试ID查询考生信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStudentInfoListByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _examStudentInfoList = new DAL.ExamStudent().SelectExamStudentInfoListByCondition(conditionDictionary);
            if (_examStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }

            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in _examStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"EStu_ExamNumber", item[0]},
                        {"U_Name", item[1]},
                        {"U_TrueName", item[2]},
                        {"U_ID", item[3]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-多站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListInMultiStationExamByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> examScoreStudentInfoList 
                = new DAL.ExamStudent().SelectExamScoreStudentInfoListInMultiStationExamByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-长短站考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListInLongShortStationExamByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> examScoreStudentInfoList
                = new DAL.ExamStudent().SelectExamScoreStudentInfoListInLongShortStationExamByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-单站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListInSingleStationExamByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> examScoreStudentInfoList 
                = new DAL.ExamStudent().SelectExamScoreStudentInfoListInSingleStationExamByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-多站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListPrintInMultiStationExam(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreStudentInfoList = new DAL.ExamStudent().SelectExamScoreStudentInfoListPrintInMultiStationExam(conditionDictionary);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-长短站
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListPrintInLongShortStationExam(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreStudentInfoList = new DAL.ExamStudent().SelectExamScoreStudentInfoListPrintInLongShortStationExam(conditionDictionary);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        ///  成绩查询与打印页面 条件查询参加该场考试的考生信息-单站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListPrintInSingleStationExam(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreStudentInfoList = new DAL.ExamStudent().SelectExamScoreStudentInfoListPrintInSingleStationExam(conditionDictionary);
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MINExam_StartTime", item[0]},
                        {"EStu_ExamNumber", item[1]},
                        {"U_Name", item[2]},
                        {"U_TrueName", item[3]},
                        {"U_ID", item[4]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-多站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStudentCountInMultiStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectExamStudentCountInMultiStationExamByCondition(conditionDictionary);
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-长短站考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStudentCountInLongShortStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectExamStudentCountInLongShortStationExamByCondition(conditionDictionary);
        }

        /// <summary>
        /// 成绩查询与打印页面 根据条件查询考生信息总数-单站式考试
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStudentCountInSingleStationExamByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectExamStudentCountInSingleStationExamByCondition(conditionDictionary);
        }

        /// <summary>
        /// 成绩录入与修改界面 根据条件查询考生信息总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStudentCountInScoreModifyPageByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectExamStudentCountInScoreModifyPageByCondition(conditionDictionary);
        }

        /// <summary>
        ///  成绩录入与修改界面 条件查询参加该场考试的考生信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamScoreStudentInfoListInScoreModifyPageByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {

            List<object[]> examScoreStudentInfoList = new DAL.ExamStudent().SelectExamScoreStudentInfoListByCondition(conditionDictionary, orderList, pageIndex, pageSize);
                
            if (examScoreStudentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考生信息失败");
                return null;
            }
            List<Dictionary<string, object>> examStudentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreStudentInfoList)
            {
                examStudentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"EStu_ExamNumber", item[0]},
                        {"U_Name", item[1]},
                        {"U_TrueName", item[2]},
                        {"U_ID", item[3]}
                    }
                );
            }
            return examStudentInfoList;
        }

        /// <summary>
        /// 根据UID查找考生的考号
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="EID"></param>
        /// <returns></returns>
        public string GetEStuExamNumber(int UID, Guid EID)
        {
            string StuExamNumber = "";
            DataTable dt = dal.GetExamStudentInfo(UID, EID).Tables[0];
            int count = dt.Rows.Count;
            if (count > 0)
            {
                StuExamNumber = dt.Rows[0]["EStu_ExamNumber"].ToString();
            }

            return StuExamNumber;
        }

        /// <summary>
        /// 考试视频回放页面 根据条件查询视频总数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchexamPlaybackCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SearchexamPlaybackCountByCondition(conditionDictionary);
        }

        /// <summary>
        ///  条件查询考试视频
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SelecPlaybackByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            List<object[]> playbackInfoList
                = new DAL.ExamStudent().SelecPlaybackByCondition(conditionDictionary, orderList, pageIndex, pageSize);
            if (playbackInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考试视频失败");
                return null;
            }
            List<Dictionary<string, object>> examPlaybackInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in playbackInfoList)
            {
                examPlaybackInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"E_Name", item[0]},
                        {"ES_Name", item[1]},
                        {"U_ID", item[2]},
                        {"EStu_ExamNumber", item[3]},
                        {"U_Name", item[4]},
                        {"U_TrueName", item[5]},
                        {"StartTime", item[6]},
                        {"EndTime", item[7]},
                        {"File_Path", item[8]}
                    }
                );
            }
            return examPlaybackInfoList;
        }
        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamStudent记录
        /// </summary>
        /// <param name="examStudent"></param>
        /// <returns></returns>
        public bool AddExamStudent(Model.ExamStudent examStudent)
        {
            return new DAL.ExamStudent().Insert(examStudent);
        }

        /// <summary>
        /// 删除ExamStudent记录
        /// </summary>
        /// <param name="examStudent"></param>
        /// <returns></returns>
        public bool RemoveExamStudent(Model.ExamStudent examStudent)
        {
            return new DAL.ExamStudent().Delete(examStudent);
        }

        /// <summary>
        /// 修改ExamStudent记录
        /// </summary>
        /// <param name="examStudent"></param>
        /// <returns></returns>
        public bool ModifyExamStudent(Model.ExamStudent examStudent)
        {
            return new DAL.ExamStudent().Update((object)examStudent);
        }

        /// <summary>
        /// 查询ExamStudent下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStudentIdentity()
        {
            return new DAL.ExamStudent().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamStudent记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStudentCount()
        {
            return new DAL.ExamStudent().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStudent记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStudentCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定eStu_ID的ExamStudent是否存在
        /// </summary>
        /// <param name="eStu_ID"></param>
        /// <returns></returns>
        public bool? SearchExamStudentExists(object eStu_ID)
        {
            return new DAL.ExamStudent().SelectModelObjectExistsByID(eStu_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamStudent是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamStudentExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按eStu_ID查询ExamStudent
        /// </summary>
        /// <param name="eStu_ID"></param>
        /// <returns></returns>
        public Model.ExamStudent SearchExamStudentByID(object eStu_ID)
        {
            return new DAL.ExamStudent().SelectModelObjectByID(eStu_ID);
        }

        /// <summary>
        /// 查询第一个ExamStudent对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamStudent SearchUniqueExamStudentByCondition()
        {
            return new DAL.ExamStudent().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamStudent SearchUniqueExamStudentByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamStudent SearchUniqueExamStudentByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStudent().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamStudent对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamStudent> SearchExamStudentByCondition()
        {
            return new DAL.ExamStudent().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamStudent> SearchExamStudentByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStudent().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamStudent> SearchExamStudentByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStudent().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamStudent内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamStudent> SearchExamStudentByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamStudent().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
        #region 扩展方法（学生查询）

        /// <summary>
        /// 获得数据列表 学生查询   陶东利2014/7/15增加
        /// </summary>
        public List<Tellyes.Model.CompositedModelStudentQuery> GetModelListStudentQuery(string strWhere)
        {
            DataSet ds = dal.GetListStudentQuery(strWhere);
            return DataTableToListDataRowToModelStudentQuery(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表 学生查询   陶东利2014/7/15增加
        /// </summary>
        public List<Tellyes.Model.CompositedModelStudentQuery> DataTableToListDataRowToModelStudentQuery(DataTable dt)
        {
            List<Tellyes.Model.CompositedModelStudentQuery> modelList = new List<Tellyes.Model.CompositedModelStudentQuery>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.CompositedModelStudentQuery model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModelStudentQuery(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }



        /// <summary>
        /// 成绩展示页面 查询学生信息和总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchStudentInfoAndTotalScoreBySingleStation(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ExamStudent().SelectStudentInfoAndTotalScoreBySingleStation(conditionDictionary);
            if (examScoreInfoObjectList == null)
            {
                Log4NetUtility.Error(this, "查询成绩信息失败");
                return null;
            }
            List<Dictionary<string, object>> examScoreInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examScoreInfoObjectList)
            {
                examScoreInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"U_ID", item[0]},
                        {"U_Name", item[1]},
                        {"U_TrueName", item[2]},
                        {"EStu_ExamNumber", item[3]},
                        {"TotalScore", item[4]}
                    }
                );
            }
            return examScoreInfoList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchPerSelectedStudentInfo(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _studentInfoList = new Tellyes.DAL.ExamStudent().SelectPerSelectedStudentInfo(conditionDictionary);
            if (_studentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询选中的考生信息失败");
                return null;
            }
            Dictionary<string, object> studentInfo = new Dictionary<string, object>();
            foreach (object[] item in _studentInfoList)
            {
                studentInfo = new Dictionary<string, object>() 
                    { 
                    {"U_ID", item[0]},
                    {"U_Name", item[1]},
                    {"U_TrueName", item[2]},
                    {"EStu_ExamNumber", item[3]},
                };
            }
            return studentInfo;
        }

        /// <summary>
        /// 查询各个班级的考生数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, int>> SearchEachOrganizationStudentCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _studentInfoList = new Tellyes.DAL.ExamStudent().SelectEachOrganizationStudentCountByCondition(conditionDictionary);
            if (_studentInfoList == null)
            {
                Log4NetUtility.Error(this, "查询各个班级的考生数量失败");
                return null;
            }
            List<Dictionary<string, int>> organizationStudentCountList = new List<Dictionary<string, int>>();
            foreach (object[] item  in _studentInfoList)
            {
                organizationStudentCountList.Add(
                    new Dictionary<string, int>() 
                    { 
                        {"O_ID", item[0] == null ? -1 : Convert.ToInt32(item[0])},
                        {"examStudentCount", Convert.ToInt32(item[1])}
                    }
                );
            }
            if (organizationStudentCountList.Count > 1 && organizationStudentCountList[0]["O_ID"].Equals(-1)) 
            {
                organizationStudentCountList.Add(organizationStudentCountList[0]);
                organizationStudentCountList.RemoveAt(0);
            }
            return organizationStudentCountList;
        }


        // <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<Guid, object> SearchEachExamInfoByCondition(List<Guid> examTableLlist)
        {
            List<object[]> examStudentList = new Tellyes.DAL.ExamStudent().SelectEachExamStudentCountByCondition(examTableLlist);
                
            if (examStudentList == null)
            {
                Log4NetUtility.Error(this, "查询考生总量失败");
                return null;
            }

            Dictionary<Guid, object> eaxmInfoDictionary = new Dictionary<Guid, object>();
            foreach (object[] item in examStudentList)
            {
                Guid examTableID = Guid.Parse(item[0].ToString());

                if (!eaxmInfoDictionary.ContainsKey(examTableID))
                {
                    eaxmInfoDictionary.Add(examTableID, new object());
                }
                eaxmInfoDictionary[examTableID] = item[1];
            }
            return eaxmInfoDictionary;
        }
        #endregion
        #region 获取的是学生最近一周的考站信息
        /// <summary>
        /// 获取的是学生最近一周的考站信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public DataSet getStuStationInfos(int userID)
        {
            return dal.getStuStationInfos(userID);
        }
        #endregion

        #region 获取学生考站的信息
        public DataSet getStuStationAllInfos(int userID)
        {
            return dal.getStuStationAllInfos(userID);

        }
        #endregion
    }
}
