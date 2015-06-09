using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class ScoreInfo
    {
        private readonly DAL.ScoreInfo dal = new DAL.ScoreInfo();
        public ScoreInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SI_ID)
        {
            return dal.Exists(SI_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ScoreInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.ScoreInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int SI_ID)
        {

            return dal.Delete(SI_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string SI_IDlist)
        {
            return dal.DeleteList(SI_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.ScoreInfo GetModel(int SI_ID)
        {

            return dal.GetModel(SI_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.ScoreInfo GetModelByCache(int SI_ID)
        {

            string CacheKey = "ScoreInfoModel-" + SI_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(SI_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.ScoreInfo)objModel;
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
        public List<Model.ScoreInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.ScoreInfo> DataTableToList(DataTable dt)
        {
            List<Model.ScoreInfo> modelList = new List<Model.ScoreInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.ScoreInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.ScoreInfo();
                    if (dt.Rows[n]["SI_ID"].ToString() != "")
                    {
                        model.SI_ID = int.Parse(dt.Rows[n]["SI_ID"].ToString());
                    }
                    model.SI_ProvisionScore = dt.Rows[n]["SI_ProvisionScore"].ToString();
                    if (dt.Rows[n]["SI_DigitalSignature"].ToString() != "")
                    {
                        model.SI_DigitalSignature = (byte[])dt.Rows[n]["SI_DigitalSignature"];
                    }
                    if (dt.Rows[n]["SI_CreateTime"].ToString() != "")
                    {
                        model.SI_CreateTime = DateTime.Parse(dt.Rows[n]["SI_CreateTime"].ToString());
                    }
                    if (dt.Rows[n]["SI_int1"].ToString() != "")
                    {
                        model.SI_int1 = int.Parse(dt.Rows[n]["SI_int1"].ToString());
                    }
                    if (dt.Rows[n]["SI_int2"].ToString() != "")
                    {
                        model.SI_int2 = int.Parse(dt.Rows[n]["SI_int2"].ToString());
                    }
                    model.SI_string1 = dt.Rows[n]["SI_string1"].ToString();
                    model.SI_string2 = dt.Rows[n]["SI_string2"].ToString();
                    if (dt.Rows[n]["SI_datetime"].ToString() != "")
                    {
                        model.SI_datetime = DateTime.Parse(dt.Rows[n]["SI_datetime"].ToString());
                    }
                    if (dt.Rows[n]["calcuated"].ToString() != "")
                    {
                        model.calcuated = int.Parse(dt.Rows[n]["calcuated"].ToString());
                    }
                    model.timeStamp = dt.Rows[n]["timeStamp"].ToString();
                    if (dt.Rows[n]["Exam_ID"].ToString() != "")
                    {
                        model.Exam_ID = Guid.Parse(dt.Rows[n]["Exam_ID"].ToString());
                    }
                    if (dt.Rows[n]["ExamStation_ID"].ToString() != "")
                    {
                        model.ExamStation_ID = Guid.Parse(dt.Rows[n]["ExamStation_ID"].ToString());
                    }
                    if (dt.Rows[n]["Student_ID"].ToString() != "")
                    {
                        model.Student_ID = int.Parse(dt.Rows[n]["Student_ID"].ToString());
                    }
                    if (dt.Rows[n]["SI_Type"].ToString() != "")
                    {
                        model.SI_Type = int.Parse(dt.Rows[n]["SI_Type"].ToString());
                    }
                    if (dt.Rows[n]["Rater_ID"].ToString() != "")
                    {
                        model.Rater_ID = int.Parse(dt.Rows[n]["Rater_ID"].ToString());
                    }
                    if (dt.Rows[n]["SI_Score"].ToString() != "")
                    {
                        model.SI_Score = int.Parse(dt.Rows[n]["SI_Score"].ToString());
                    }
                    model.SI_ActualScore = dt.Rows[n]["SI_ActualScore"].ToString();
                    model.SI_Items = dt.Rows[n]["SI_Items"].ToString();


                    modelList.Add(model);
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
        #endregion

        #region Extension NHibernate

        /// <summary>
        /// 添加ScoreInfo记录
        /// </summary>
        /// <param name="scoreInfo"></param>
        /// <returns></returns>
        public bool AddScoreInfo(Model.ScoreInfo scoreInfo)
        {
            return new DAL.ScoreInfo().Insert(scoreInfo);
        }

        /// <summary>
        /// 删除ScoreInfo记录
        /// </summary>
        /// <param name="scoreInfo"></param>
        /// <returns></returns>
        public bool RemoveScoreInfo(Model.ScoreInfo scoreInfo)
        {
            return new DAL.ScoreInfo().Delete(scoreInfo);
        }

        /// <summary>
        /// 修改ScoreInfo记录
        /// </summary>
        /// <param name="scoreInfo"></param>
        /// <returns></returns>
        public bool ModifyScoreInfo(Model.ScoreInfo scoreInfo)
        {
            return new DAL.ScoreInfo().Update((object)scoreInfo);
        }

        /// <summary>
        /// 查询ScoreInfo下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreInfoIdentity()
        {
            return new DAL.ScoreInfo().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ScoreInfo记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreInfoCount()
        {
            return new DAL.ScoreInfo().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreInfo记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchScoreInfoCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreInfo().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定sI_ID的ScoreInfo是否存在
        /// </summary>
        /// <param name="sI_ID"></param>
        /// <returns></returns>
        public bool? SearchScoreInfoExists(object sI_ID)
        {
            return new DAL.ScoreInfo().SelectModelObjectExistsByID(sI_ID);
        }

        /// <summary>
        /// 查询指定条件的ScoreInfo是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchScoreInfoExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreInfo().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按sI_ID查询ScoreInfo
        /// </summary>
        /// <param name="sI_ID"></param>
        /// <returns></returns>
        public Model.ScoreInfo SearchScoreInfoByID(object sI_ID)
        {
            return new DAL.ScoreInfo().SelectModelObjectByID(sI_ID);
        }

        /// <summary>
        /// 查询第一个ScoreInfo对象
        /// </summary>
        /// <returns></returns>
        public Model.ScoreInfo SearchUniqueScoreInfoByCondition()
        {
            return new DAL.ScoreInfo().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ScoreInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ScoreInfo SearchUniqueScoreInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreInfo().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ScoreInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ScoreInfo SearchUniqueScoreInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreInfo().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ScoreInfo对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ScoreInfo> SearchScoreInfoByCondition()
        {
            return new DAL.ScoreInfo().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ScoreInfo> SearchScoreInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreInfo().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ScoreInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ScoreInfo> SearchScoreInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreInfo().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ScoreInfo内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ScoreInfo> SearchScoreInfoByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ScoreInfo().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityDictionary"></param>
        /// <returns></returns>
        public bool AddScoreInfo(Dictionary<string, object> entityDictionary)
        {
            List<List<object>> entityList = new List<List<object>>();
            entityList.Add(new List<object>() { "insert", entityDictionary["ScoreInfo,Add"] });
            entityList.Add(new List<object>() { "insert", entityDictionary["ScoreLog,Add"] });
            if(entityDictionary.ContainsKey("ScoreSummariedScore,Add"))
            {
                entityList.Add(new List<object>() { "insert", entityDictionary["ScoreSummariedScore,Add"] });
            }
            else if (entityDictionary.ContainsKey("ScoreSummariedScore,Modify"))
            {
                entityList.Add(new List<object>() { "update", entityDictionary["ScoreSummariedScore,Modify"] });
            }
            return new DAL.ScoreInfo().Transaction(entityList);
        }

        /// <summary>
        /// 成绩录入与修改页面 查询成绩完整性
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchStudentInfoWithCompletedScoreInScoreEnterAndModifyPage(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examStudentInfoObjectList = new Tellyes.DAL.ScoreInfo().SelectStudentInfoWithCompletedScoreInScoreEnterAndModifyPage(conditionDictionary);
            if (examStudentInfoObjectList == null)
            {
                Log4NetUtility.Error(this, "查询成绩完整性失败");
                return null;
            }
            List<Dictionary<string, object>> studentInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in examStudentInfoObjectList)
            {
                studentInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"Student_ID", item[0]},
                        {"ES_ID", item[1]},
                    }
                );
            }
            return studentInfoList;
        }


        /// <summary>
        /// 查询考试时间和房间
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchExamTimeAndRoomInfo(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _examInfoList = new Tellyes.DAL.ScoreInfo().SelectExamTimeAndRoomInfo(conditionDictionary);
            if (_examInfoList == null)
            {
                Log4NetUtility.Error(this, "查询考试时间和房间失败");
                return null;
            }
            object[] _examInfo = _examInfoList.First();
            Dictionary<string, object> examTimeAndRoomInfo =new Dictionary<string,object>();
            examTimeAndRoomInfo.Add("Exam_StartTime", _examInfo[0]);
            examTimeAndRoomInfo.Add("Exam_EndTime", _examInfo[1]);
            examTimeAndRoomInfo.Add("Room_Name", _examInfo[2]);
            return examTimeAndRoomInfo;
        }
        

        /// <summary>
        /// 查询评分表名称，评委
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchScoreInfoAndMarkSheetInfo(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _scoreInfoList = new Tellyes.DAL.ScoreInfo().SelectScoreInfoAndMarkSheetInfo(conditionDictionary);
            if (_scoreInfoList == null)
            {
                Log4NetUtility.Error(this, "查询评分表名称，评委和评分时间失败");
                return null;
            }
            List<Dictionary<string, object>> markInfo = new List<Dictionary<string, object>>();
            foreach (object[] item in _scoreInfoList)
            {
                markInfo.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ScoreInfo", item[0]},
                        {"MS_Name", item[1]},
                        {"judgeUserInfoTrueName", item[2]},
                    }
                );
            }
            return markInfo;
        }
        
        #endregion
    }
}
