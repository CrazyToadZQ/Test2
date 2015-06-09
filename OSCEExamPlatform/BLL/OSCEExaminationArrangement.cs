using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// 长短站式排考表
    /// </summary>
    public partial class OSCEExaminationArrangement
    {
        private readonly Tellyes.DAL.OSCEExaminationArrangement dal = new Tellyes.DAL.OSCEExaminationArrangement();
        public OSCEExaminationArrangement()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int OEA_ID)
        {
            return dal.Exists(OEA_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.OSCEExaminationArrangement model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.OSCEExaminationArrangement model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int OEA_ID)
        {

            return dal.Delete(OEA_ID);
        }
        

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.OSCEExaminationArrangement GetModel(int OEA_ID)
        {

            return dal.GetModel(OEA_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.OSCEExaminationArrangement GetModelByCache(int OEA_ID)
        {

            string CacheKey = "OSCEExaminationArrangementModel-" + OEA_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(OEA_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.OSCEExaminationArrangement)objModel;
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
        public List<Tellyes.Model.OSCEExaminationArrangement> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.OSCEExaminationArrangement> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.OSCEExaminationArrangement> modelList = new List<Tellyes.Model.OSCEExaminationArrangement>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.OSCEExaminationArrangement model;
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
        /// 添加OSCEExaminationArrangement记录
        /// </summary>
        /// <param name="oSCEExaminationArrangement"></param>
        /// <returns></returns>
        public bool AddOSCEExaminationArrangement(Model.OSCEExaminationArrangement oSCEExaminationArrangement)
        {
            return new DAL.OSCEExaminationArrangement().Insert(oSCEExaminationArrangement);
        }

        /// <summary>
        /// 删除OSCEExaminationArrangement记录
        /// </summary>
        /// <param name="oSCEExaminationArrangement"></param>
        /// <returns></returns>
        public bool RemoveOSCEExaminationArrangement(Model.OSCEExaminationArrangement oSCEExaminationArrangement)
        {
            return new DAL.OSCEExaminationArrangement().Delete(oSCEExaminationArrangement);
        }

        /// <summary>
        /// 修改OSCEExaminationArrangement记录
        /// </summary>
        /// <param name="oSCEExaminationArrangement"></param>
        /// <returns></returns>
        public bool ModifyOSCEExaminationArrangement(Model.OSCEExaminationArrangement oSCEExaminationArrangement)
        {
            return new DAL.OSCEExaminationArrangement().Update((object)oSCEExaminationArrangement);
        }

        /// <summary>
        /// 查询OSCEExaminationArrangement下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchOSCEExaminationArrangementIdentity()
        {
            return new DAL.OSCEExaminationArrangement().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部OSCEExaminationArrangement记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchOSCEExaminationArrangementCount()
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询OSCEExaminationArrangement记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchOSCEExaminationArrangementCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定oEA_ID的OSCEExaminationArrangement是否存在
        /// </summary>
        /// <param name="oEA_ID"></param>
        /// <returns></returns>
        public bool? SearchOSCEExaminationArrangementExists(object oEA_ID)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectExistsByID(oEA_ID);
        }

        /// <summary>
        /// 查询指定条件的OSCEExaminationArrangement是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchOSCEExaminationArrangementExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按oEA_ID查询OSCEExaminationArrangement
        /// </summary>
        /// <param name="oEA_ID"></param>
        /// <returns></returns>
        public Model.OSCEExaminationArrangement SearchOSCEExaminationArrangementByID(object oEA_ID)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectByID(oEA_ID);
        }

        /// <summary>
        /// 查询第一个OSCEExaminationArrangement对象
        /// </summary>
        /// <returns></returns>
        public Model.OSCEExaminationArrangement SearchUniqueOSCEExaminationArrangementByCondition()
        {
            return new DAL.OSCEExaminationArrangement().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个OSCEExaminationArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.OSCEExaminationArrangement SearchUniqueOSCEExaminationArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.OSCEExaminationArrangement().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个OSCEExaminationArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.OSCEExaminationArrangement SearchUniqueOSCEExaminationArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.OSCEExaminationArrangement().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部OSCEExaminationArrangement对象
        /// </summary>
        /// <returns></returns>
        public List<Model.OSCEExaminationArrangement> SearchOSCEExaminationArrangementByCondition()
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询OSCEExaminationArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.OSCEExaminationArrangement> SearchOSCEExaminationArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询OSCEExaminationArrangement对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.OSCEExaminationArrangement> SearchOSCEExaminationArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询OSCEExaminationArrangement内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.OSCEExaminationArrangement> SearchOSCEExaminationArrangementByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.OSCEExaminationArrangement().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, int> SearchStudentCountDictionaryInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            object[] studentCountDictionary = new DAL.OSCEExaminationArrangement().SelectStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
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
            return new DAL.OSCEExaminationArrangement().SelectStudentCountInHandScoreByCondition(conditionDictionary);
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
            List<object[]> _studentList = new DAL.OSCEExaminationArrangement().SelectStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
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

        #endregion  ExtensionMethod

        #region ExtensionMethod
        public DataSet GetOsceRoom(Guid EID)
        {
            return GetOsceRoom(EID);
        }
        #endregion
    }
}
