using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    /// <summary>
    /// 考试类型表
    /// </summary>
    public partial class ExamClass
    {
        private readonly Tellyes.DAL.ExamClass dal = new Tellyes.DAL.ExamClass();
        public ExamClass()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Exam_Class_ID)
        {
            return dal.Exists(Exam_Class_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamClass model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamClass model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Exam_Class_ID)
        {

            return dal.Delete(Exam_Class_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Exam_Class_IDlist)
        {
            return dal.DeleteList(Exam_Class_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamClass GetModel(int Exam_Class_ID)
        {

            return dal.GetModel(Exam_Class_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamClass GetModelByCache(int Exam_Class_ID)
        {

            string CacheKey = "ExamClassModel-" + Exam_Class_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Exam_Class_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamClass)objModel;
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
        public List<Tellyes.Model.ExamClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamClass> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamClass> modelList = new List<Tellyes.Model.ExamClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamClass model;
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
        /// 添加ExamClass记录
        /// </summary>
        /// <param name="examClass"></param>
        /// <returns></returns>
        public bool AddExamClass(Model.ExamClass examClass)
        {
            return new DAL.ExamClass().Insert(examClass);
        }

        /// <summary>
        /// 删除ExamClass记录
        /// </summary>
        /// <param name="examClass"></param>
        /// <returns></returns>
        public bool RemoveExamClass(Model.ExamClass examClass)
        {
            return new DAL.ExamClass().Delete(examClass);
        }

        /// <summary>
        /// 修改ExamClass记录
        /// </summary>
        /// <param name="examClass"></param>
        /// <returns></returns>
        public bool ModifyExamClass(Model.ExamClass examClass)
        {
            return new DAL.ExamClass().Update((object)examClass);
        }

        /// <summary>
        /// 查询ExamClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamClassIdentity()
        {
            return new DAL.ExamClass().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamClassCount()
        {
            return new DAL.ExamClass().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamClass().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定exam_Class_ID的ExamClass是否存在
        /// </summary>
        /// <param name="exam_Class_ID"></param>
        /// <returns></returns>
        public bool? SearchExamClassExists(object exam_Class_ID)
        {
            return new DAL.ExamClass().SelectModelObjectExistsByID(exam_Class_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamClass().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按exam_Class_ID查询ExamClass
        /// </summary>
        /// <param name="exam_Class_ID"></param>
        /// <returns></returns>
        public Model.ExamClass SearchExamClassByID(object exam_Class_ID)
        {
            return new DAL.ExamClass().SelectModelObjectByID(exam_Class_ID);
        }

        /// <summary>
        /// 查询第一个ExamClass对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamClass SearchUniqueExamClassByCondition()
        {
            return new DAL.ExamClass().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamClass SearchUniqueExamClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamClass().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamClass SearchUniqueExamClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamClass().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamClass> SearchExamClassByCondition()
        {
            return new DAL.ExamClass().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamClass> SearchExamClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamClass().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamClass> SearchExamClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamClass().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamClass> SearchExamClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamClass().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamClass> SearchExamClass()
        {
            return new DAL.ExamClass().SelectModelObjectByCondition
            (
                new Dictionary<string, object>()
                {
                    {"Number1", 1}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Exam_Class_Level", "asc")
                }
            );
        }

        #endregion  ExtensionMethod
    }
}
