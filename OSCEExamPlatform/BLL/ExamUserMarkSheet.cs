using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    /// <summary>
    /// 考试用户与评分表关联
    /// </summary>
    public partial class ExamUserMarkSheet
    {
        private readonly Tellyes.DAL.ExamUserMarkSheet dal = new Tellyes.DAL.ExamUserMarkSheet();
        public ExamUserMarkSheet()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EUMS_ID)
        {
            return dal.Exists(EUMS_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamUserMarkSheet model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamUserMarkSheet model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int EUMS_ID)
        {

            return dal.Delete(EUMS_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EUMS_IDlist)
        {
            return dal.DeleteList((EUMS_IDlist));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamUserMarkSheet GetModel(int EUMS_ID)
        {

            return dal.GetModel(EUMS_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamUserMarkSheet GetModelByCache(int EUMS_ID)
        {

            string CacheKey = "ExamUserMarkSheetModel-" + EUMS_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EUMS_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamUserMarkSheet)objModel;
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
        public List<Tellyes.Model.ExamUserMarkSheet> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamUserMarkSheet> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamUserMarkSheet> modelList = new List<Tellyes.Model.ExamUserMarkSheet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamUserMarkSheet model;
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
        /// 根据考试的ID，获得考试User评分表的集合
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet getEumsByExamID(Guid EID)
        {
            return dal.getEumsByExamID(EID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examUserID"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByExamUserID(Guid examUserID)
        {
            return new DAL.ExamUserMarkSheet().SelectMarkSheetByExamUserID(examUserID);
        }

        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamUserMarkSheet记录
        /// </summary>
        /// <param name="examUserMarkSheet"></param>
        /// <returns></returns>
        public bool AddExamUserMarkSheet(Model.ExamUserMarkSheet examUserMarkSheet)
        {
            return new DAL.ExamUserMarkSheet().Insert(examUserMarkSheet);
        }

        /// <summary>
        /// 删除ExamUserMarkSheet记录
        /// </summary>
        /// <param name="examUserMarkSheet"></param>
        /// <returns></returns>
        public bool RemoveExamUserMarkSheet(Model.ExamUserMarkSheet examUserMarkSheet)
        {
            return new DAL.ExamUserMarkSheet().Delete(examUserMarkSheet);
        }

        /// <summary>
        /// 修改ExamUserMarkSheet记录
        /// </summary>
        /// <param name="examUserMarkSheet"></param>
        /// <returns></returns>
        public bool ModifyExamUserMarkSheet(Model.ExamUserMarkSheet examUserMarkSheet)
        {
            return new DAL.ExamUserMarkSheet().Update((object)examUserMarkSheet);
        }

        /// <summary>
        /// 查询ExamUserMarkSheet下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamUserMarkSheetIdentity()
        {
            return new DAL.ExamUserMarkSheet().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamUserMarkSheet记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamUserMarkSheetCount()
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamUserMarkSheet记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamUserMarkSheetCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定eUMS_ID的ExamUserMarkSheet是否存在
        /// </summary>
        /// <param name="eUMS_ID"></param>
        /// <returns></returns>
        public bool? SearchExamUserMarkSheetExists(object eUMS_ID)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectExistsByID(eUMS_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamUserMarkSheet是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamUserMarkSheetExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按eUMS_ID查询ExamUserMarkSheet
        /// </summary>
        /// <param name="eUMS_ID"></param>
        /// <returns></returns>
        public Model.ExamUserMarkSheet SearchExamUserMarkSheetByID(object eUMS_ID)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectByID(eUMS_ID);
        }

        /// <summary>
        /// 查询第一个ExamUserMarkSheet对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamUserMarkSheet SearchUniqueExamUserMarkSheetByCondition()
        {
            return new DAL.ExamUserMarkSheet().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamUserMarkSheet SearchUniqueExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUserMarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamUserMarkSheet SearchUniqueExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamUserMarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamUserMarkSheet对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamUserMarkSheet> SearchExamUserMarkSheetByCondition()
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamUserMarkSheet> SearchExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamUserMarkSheet> SearchExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamUserMarkSheet内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamUserMarkSheet> SearchExamUserMarkSheetByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamUserMarkSheet().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
    }
}
