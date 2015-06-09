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
    /// <summary>
    /// 已汇总成绩
    /// </summary>
    public partial class ScoreSummariedScore
    {
        private static readonly Tellyes.DAL.ScoreSummariedScore dal = new Tellyes.DAL.ScoreSummariedScore();
        public ScoreSummariedScore()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ScoreSummariedScore model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ScoreSummariedScore model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return dal.Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ScoreSummariedScore GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ScoreSummariedScore GetModelByCache(int id)
        {

            string CacheKey = "ScoreSummariedScoreModel-" + id;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(id);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ScoreSummariedScore)objModel;
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
        public List<Tellyes.Model.ScoreSummariedScore> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ScoreSummariedScore> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ScoreSummariedScore> modelList = new List<Tellyes.Model.ScoreSummariedScore>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ScoreSummariedScore model;
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
        /// 事务处理（插入成绩）
        /// </summary>
        /// <param name="SSSmodelList"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(System.Collections.Generic.List<Tellyes.Model.ScoreSummariedScore> SSSmodelList, Guid examID)
        {
            return dal.ExecuteSqlTran_Insert(SSSmodelList, examID);
        }

        /// <summary>
        /// 获得考试成绩 详细信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="Student_ID"></param>
        /// <returns></returns>
        public static DataTable GetScoreDetail(string E_ID, string Student_ID)
        {
            DataTable result = Tellyes.DAL.ScoreSummariedScore.GetScoreDetail(E_ID, Student_ID);
            result.Columns.Add("isNormalRow");
            result.Columns.Add("RowIndex");

            foreach (DataRow row in result.Rows)
            {
                row["isNormalRow"] = true;
            }

            if (result.Rows.Count > 0)
            {
                DataRow averageRow = result.NewRow();
                DataRow totalRow = result.NewRow();

                if (result.Columns.Contains("ES_Name"))
                {
                    averageRow["ES_Name"] = "平均";
                    totalRow["ES_Name"] = "总分";
                }

                if (result.Columns.Contains("score"))
                {
                    decimal totalScore = 0;

                    foreach (DataRow r in result.Rows)
                    {
                        totalScore = totalScore + Convert.ToDecimal(r["score"]);
                    }

                    decimal averageScore = totalScore / result.Rows.Count;

                    averageRow["score"] = averageScore;
                    averageRow["isNormalRow"] = false;
                    totalRow["score"] = totalScore;
                    totalRow["isNormalRow"] = false;

                    result.Rows.Add(averageRow);
                    result.Rows.Add(totalRow);
                }

                for (int i = 0; i < result.Rows.Count; i++)
                {
                    DataRow r = result.Rows[i];
                    r["RowIndex"] = i;
                }
            }
            return result;
        }

        /// <summary>
        /// 获得当天考试列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllExams()
        {
            return Tellyes.DAL.ScoreSummariedScore.GetAllExams();
        }

        /// <summary>
        /// 获得待打印成绩列表
        /// </summary>
        /// <param name="E_ID">考试ID</param>
        /// <param name="EStu_int">状态 0|Null</param>
        /// <param name="Student_ID">学号</param>
        /// <param name="EStu_ExamNumber">考号</param>
        /// <param name="U_TrueName">真实姓名</param>
        /// <returns></returns>
        public static DataTable GetScorePrintList(string E_ID, string EStu_int = null, string Student_ID = null, string EStu_ExamNumber = null, string U_TrueName = null)
        {
            return Tellyes.DAL.ScoreSummariedScore.GetScorePrintList(E_ID, EStu_int, Student_ID, EStu_ExamNumber, U_TrueName);
        }

        /// <summary>
        /// 获取某次考试所有考生的成绩信息
        /// </summary>
        /// <param name="classIDs">班级列表（例如：'2','3','4'）</param>
        /// <param name="examID">考试id</param>
        /// <param name="noExamStudentIDs">未参加学生列表（例如：'2','3','4'）</param>
        /// <returns></returns>
        public DataSet GetStatisticsScoreList(string classIDs, Guid examID, string noExamStudentIDs)
        {
            return dal.GetStatisticsScoreList(classIDs, examID, noExamStudentIDs);
        }

        /// <summary>
        /// 获取某次考试单个考生的成绩信息
        /// </summary>
        /// <param name="examID"></param>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public DataSet GetSingleStudentScore(Guid examID, int studentID)
        {
            return dal.GetSingleStudentScore(examID, studentID);
        }
        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加ScoreSummariedScore记录
        /// </summary>
        /// <param name="scoreSummariedScore"></param>
        /// <returns></returns>
        public bool AddScoreSummariedScore(Model.ScoreSummariedScore scoreSummariedScore)
        {
            return new DAL.ScoreSummariedScore().Insert(scoreSummariedScore);
        }

        /// <summary>
        /// 删除ScoreSummariedScore记录
        /// </summary>
        /// <param name="scoreSummariedScore"></param>
        /// <returns></returns>
        public bool RemoveScoreSummariedScore(Model.ScoreSummariedScore scoreSummariedScore)
        {
            return new DAL.ScoreSummariedScore().Delete(scoreSummariedScore);
        }

        /// <summary>
        /// 修改ScoreSummariedScore记录
        /// </summary>
        /// <param name="scoreSummariedScore"></param>
        /// <returns></returns>
        public bool ModifyScoreSummariedScore(Model.ScoreSummariedScore scoreSummariedScore)
        {
            return new DAL.ScoreSummariedScore().Update((object)scoreSummariedScore);
        }

        /// <summary>
        /// 查询ScoreSummariedScore下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreSummariedScoreIdentity()
        {
            return new DAL.ScoreSummariedScore().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ScoreSummariedScore记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreSummariedScoreCount()
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreSummariedScore记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchScoreSummariedScoreCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定id的ScoreSummariedScore是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool? SearchScoreSummariedScoreExists(object id)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectExistsByID(id);
        }

        /// <summary>
        /// 查询指定条件的ScoreSummariedScore是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchScoreSummariedScoreExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按id查询ScoreSummariedScore
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.ScoreSummariedScore SearchScoreSummariedScoreByID(object id)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectByID(id);
        }

        /// <summary>
        /// 查询第一个ScoreSummariedScore对象
        /// </summary>
        /// <returns></returns>
        public Model.ScoreSummariedScore SearchUniqueScoreSummariedScoreByCondition()
        {
            return new DAL.ScoreSummariedScore().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ScoreSummariedScore对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ScoreSummariedScore SearchUniqueScoreSummariedScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreSummariedScore().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ScoreSummariedScore对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ScoreSummariedScore SearchUniqueScoreSummariedScoreByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreSummariedScore().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ScoreSummariedScore对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ScoreSummariedScore> SearchScoreSummariedScoreByCondition()
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreSummariedScore对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ScoreSummariedScore> SearchScoreSummariedScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ScoreSummariedScore对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ScoreSummariedScore> SearchScoreSummariedScoreByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ScoreSummariedScore内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ScoreSummariedScore> SearchScoreSummariedScoreByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ScoreSummariedScore().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityDictionary"></param>
        /// <returns></returns>
        public bool ModifyScoreSummariedScore(Dictionary<string, object> entityDictionary)
        {
            List<List<object>> entityList = new List<List<object>>();
            entityList.Add(new List<object>() { "insert", ((List<Tellyes.Model.ScoreSummariedScore>)entityDictionary["ScoreSummariedScore,List,Add"]).ToList<object>()});
            entityList.Add(new List<object>() { "update", ((List<Tellyes.Model.ScoreSummariedScore>)entityDictionary["ScoreSummariedScore,List,Modify"]).ToList<object>() });
            entityList.Add(new List<object>() { "insert", ((List<Tellyes.Model.ScoreLog>)entityDictionary["ScoreLog,List,Add"]).ToList<object>() });
            return new DAL.ScoreSummariedScore().Transaction(entityList);
        }

        /// <summary>
        /// 生成手持/中央评分考站成绩汇总对象
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="ES_ID"></param>
        /// <param name="Room_ID"></param>
        /// <param name="Student_U_ID"></param>
        /// <param name="Judge_U_ID"></param>
        /// <param name="SI_Score"></param>
        /// <returns></returns>
        public Model.ScoreSummariedScore CreateScoreSummariedScoreObject(Guid E_ID, Guid ES_ID, Guid EU_ID, int Room_ID, int Student_U_ID, int Judge_U_ID, decimal SI_Score)
        {
            //查询当前考生在当前考站的成绩汇总记录
            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"E_ID,EQ", E_ID},
                {"ES_ID,EQ", ES_ID},
                {"Room_ID,EQ", Room_ID},
                {"Student_ID,EQ", Student_U_ID}
            };
            List<Model.ScoreSummariedScore> scoreSummariedScoreList = this.SearchScoreSummariedScoreByCondition(conditionDictionary);
            Model.ScoreSummariedScore scoreSummariedScore = null;
            if (scoreSummariedScoreList == null)
            {
                Log4Net.Log4NetUtility.Error(this, "考生成绩汇总信息查询失败");
                return null;
            }
            if (scoreSummariedScoreList.Count == 0)
            {
                scoreSummariedScore = new Model.ScoreSummariedScore();
                scoreSummariedScore.Student_ID = Student_U_ID;
                scoreSummariedScore.E_ID = E_ID;
                scoreSummariedScore.ES_ID = ES_ID;
                scoreSummariedScore.Room_ID = Room_ID;
                scoreSummariedScore.score = 0;
            }
            else
            {
                scoreSummariedScore = scoreSummariedScoreList[0];
            }

            //查询当前评分用户的权重
            Model.ExamUser examUser = new BLL.ExamUser().SearchExamUserByID(EU_ID);
            if (examUser == null)
            {
                Log4Net.Log4NetUtility.Error(this, "考试评委信息查询失败");
                return null;
            }
            decimal examUserPercent = (examUser.int1 == null ? 0 : Convert.ToDecimal(examUser.int1)) / 100;

            //查询当前考站的主观权重
            Model.ExamStation examStation = new BLL.ExamStation().SearchExamStationByID(ES_ID);
            if (examStation == null)
            {
                Log4Net.Log4NetUtility.Error(this, "考试考站信息查询失败");
                return null;
            }
            decimal examStationPercent = (examStation.int2 == null ? 0 : Convert.ToDecimal(examStation.int2)) / 100;

            //计算新的成绩汇总
            scoreSummariedScore.score += SI_Score * examUserPercent * examStationPercent;

            return scoreSummariedScore;
        }

        /// <summary>
        /// 生成手持/中央评分考试成绩汇总对象
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="ES_ID"></param>
        /// <param name="Student_U_ID"></param>
        /// <param name="examStationScore"></param>
        /// <returns></returns>
        public decimal? CreateExamScore(Guid E_ID, Guid ES_ID, int Student_U_ID, decimal examStationScore)
        {
            //查询当前考生在当前考试，除了当前考站的成绩汇总记录
            Dictionary<string, object> conditionDictionary = new Dictionary<string, object>() 
            { 
                {"E_ID,EQ", E_ID},
                {"ES_ID,NEQ", ES_ID},
                {"Student_ID,EQ", Student_U_ID}
            };

            List<Model.ScoreSummariedScore> scoreSummariedScoreList = this.SearchScoreSummariedScoreByCondition(conditionDictionary);
            if (scoreSummariedScoreList == null)
            {
                Log4Net.Log4NetUtility.Error(this, "考生成绩汇总信息查询失败");
                return null;
            }

            decimal examScore = 0;
            foreach (Model.ScoreSummariedScore scoreSummariedScore in scoreSummariedScoreList) 
            {
                examScore += scoreSummariedScore.score;
            }

            return examScore + examStationScore;
        }

        /// <summary>
        /// 查询学生成绩打印-多站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStudentScoreForPrintInMultiByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ScoreSummariedScore().SelectScoreSummariedScoreRoomPrintInMultiStationExam(conditionDictionary);
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
                        {"MultiStationExamArrangement", item[0]},
                        {"Room_Name", item[1]},
                        {"Score", item[2]}
                    }
                );
            }
            return examScoreInfoList;
        }

        /// <summary>
        /// 查询学生成绩打印-长短站
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStudentScoreForPrintInLongAndShortByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ScoreSummariedScore().SelectScoreSummariedScoreRoomPrintInLongShortStationExam(conditionDictionary);
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
                        {"OSCEExaminationArrangement", item[0]},
                        {"Room_Name", item[1]},
                        {"Score", item[2]}
                    }
                );
            }
            return examScoreInfoList;
        }

        /// <summary>
        /// 查询学生成绩打印-单站式
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamStudentScoreForPrintInSingleByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ScoreSummariedScore().SelectScoreSummariedScoreRoomPrintInSingleStationExam(conditionDictionary);
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
                        {"SingleStationExamArrangement", item[0]},
                        {"Room_Name", item[1]},
                        {"Score", item[2]}
                    }
                );
            }
            return examScoreInfoList;
        }

        /// <summary>
        /// 查询学生总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> totalScoreList = new Tellyes.DAL.ScoreSummariedScore().SelectTotalScoreByCondition(conditionDictionary);
            if (totalScoreList == null)
            {
                Log4NetUtility.Error(this, "查询总分失败");
                return null;
            }
             List<Dictionary<string, object>> examTotalScoreInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in totalScoreList)
            {
                examTotalScoreInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"Student_ID", item[0]},
                        {"Score", item[1]}
                    }
                );
            }
             return examTotalScoreInfoList;
        }
        /// <summary>
        /// 查询选中考生的成绩信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchPerStudentScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examScoreInfoObjectList = new Tellyes.DAL.ScoreSummariedScore().SelectPerStudentScoreByCondition(conditionDictionary);
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
                        {"ES_ID", item[0]},
                        {"ES_Name", item[1]},
                        {"Room_ID", item[2]},
                        {"Room_Name", item[3]},
                        {"id", item[4]},
                        {"ScoreType", item[5]},
                        {"LastScoreModifyDate", item[6]},
                        {"ScoreModifyUserInfoID", item[7]},
                        {"ScoreModifyUserInfoName", item[8]},
                        {"score", item[9]}
                    }
                );
            }
            return perStudentScoreInfoList;
        }

        /// <summary>
        /// 查询各考站总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<Guid, decimal> SearchEachStationTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> totalScoreList = new Tellyes.DAL.ScoreSummariedScore().SelectEachStationTotalScoreByCondition(conditionDictionary);
            if (totalScoreList == null)
            {
                Log4NetUtility.Error(this, "查询各考站总分失败");
                return null;
            }
            Dictionary<Guid, decimal> examTotalScoreInfoDictionary = new Dictionary<Guid, decimal>();
            foreach (object[] item in totalScoreList)
            {
                examTotalScoreInfoDictionary.Add(Guid.Parse(item[0].ToString()), Convert.ToDecimal(item[1]));
            }
            return examTotalScoreInfoDictionary;
        }

          /// <summary>
        /// 查询各班级各考站的分数
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<int, Dictionary<Guid, decimal>> SearchEachOrganizationTotalScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> totalScoreList = new Tellyes.DAL.ScoreSummariedScore().SelectEachOrganizationTotalScoreByCondition(conditionDictionary);
            if (totalScoreList == null)
            {
                Log4NetUtility.Error(this, "查询班级各考站的分数失败");
                return null;
            }
            Dictionary<int, Dictionary<Guid, decimal>> examTotalScoreInfoDictionary = new Dictionary<int, Dictionary<Guid, decimal>>();
            foreach (object[] item in totalScoreList)
            {
                int o_id = item[0] == null ? -1 : Convert.ToInt32(item[0]);
                Guid examStationID = Guid.Parse(item[1].ToString());
                if (!examTotalScoreInfoDictionary.ContainsKey(o_id)) 
                {
                    examTotalScoreInfoDictionary.Add(o_id, new Dictionary<Guid,decimal>());
                }
                examTotalScoreInfoDictionary[o_id].Add(examStationID, Convert.ToDecimal(item[2]));
            }
            return examTotalScoreInfoDictionary;
        }

        /// <summary>
        /// 查询房间ID
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<int, Dictionary<Guid, int>> SearchEachRoomIDByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> roomIDList = new Tellyes.DAL.ScoreSummariedScore().SelectRoomIDByCondition(conditionDictionary);
            if (roomIDList == null)
            {
                Log4NetUtility.Error(this, "查询房间ID失败");
                return null;
            }
            Dictionary<int, Dictionary<Guid, int>> roomInfoDictionary = new Dictionary<int, Dictionary<Guid, int>>();
            foreach (object[] item in roomIDList)
            {
                int studentID =Convert.ToInt32(item[0]);
                Guid examStationID = Guid.Parse(item[1].ToString());
                if (!roomInfoDictionary.ContainsKey(studentID)) 
                {
                    roomInfoDictionary.Add(studentID, new Dictionary<Guid, Int32>());
                }
                roomInfoDictionary[studentID].Add(examStationID, Convert.ToInt32(item[2]));
            }
            return roomInfoDictionary;
        }


        /// <summary>
        /// 查询学生总分
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<Guid,decimal>  SearchTotalScoreByStudentID(int studentID)
        {
            List<object[]> totalScoreList = new Tellyes.DAL.ScoreSummariedScore().SelectTotalScoreByStudentID(studentID);
            if (totalScoreList == null)
            {
                Log4NetUtility.Error(this, "查询总分失败");
                return null;
            }

            Dictionary<Guid, decimal> examIDTotalScore = new Dictionary<Guid, decimal>();
            foreach (object[] item in totalScoreList)
            {
                Guid examID = Guid.Parse(item[0].ToString());
                if (!examIDTotalScore.ContainsKey(examID))
                {
                    examIDTotalScore[examID] = new decimal();
                }
                examIDTotalScore[examID] = Convert.ToDecimal(item[1]);
            }

            return examIDTotalScore;
        }

        #endregion
    }
}

