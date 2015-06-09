using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    /// <summary>
    /// 考站类型表
    /// </summary>
    public partial class ExamStationClass
    {
        private readonly Tellyes.DAL.ExamStationClass dal = new Tellyes.DAL.ExamStationClass();
        public ExamStationClass()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Exam_Station_Class_ID)
        {
            return dal.Exists(Exam_Station_Class_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamStationClass model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamStationClass model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Exam_Station_Class_ID)
        {

            return dal.Delete(Exam_Station_Class_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Exam_Station_Class_IDlist)
        {
            return dal.DeleteList(Exam_Station_Class_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamStationClass GetModel(int Exam_Station_Class_ID)
        {

            return dal.GetModel(Exam_Station_Class_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamStationClass GetModelByCache(int Exam_Station_Class_ID)
        {

            string CacheKey = "ExamStationClassModel-" + Exam_Station_Class_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Exam_Station_Class_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamStationClass)objModel;
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
        public List<Tellyes.Model.ExamStationClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamStationClass> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamStationClass> modelList = new List<Tellyes.Model.ExamStationClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamStationClass model;
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

        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamStationClass记录
        /// </summary>
        /// <param name="examStationClass"></param>
        /// <returns></returns>
        public bool AddExamStationClass(Model.ExamStationClass examStationClass)
        {
            return new DAL.ExamStationClass().Insert(examStationClass);
        }

        /// <summary>
        /// 删除ExamStationClass记录
        /// </summary>
        /// <param name="examStationClass"></param>
        /// <returns></returns>
        public bool RemoveExamStationClass(Model.ExamStationClass examStationClass)
        {
            return new DAL.ExamStationClass().Delete(examStationClass);
        }

        /// <summary>
        /// 修改ExamStationClass记录
        /// </summary>
        /// <param name="examStationClass"></param>
        /// <returns></returns>
        public bool ModifyExamStationClass(Model.ExamStationClass examStationClass)
        {
            return new DAL.ExamStationClass().Update((object)examStationClass);
        }

        /// <summary>
        /// 查询ExamStationClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStationClassIdentity()
        {
            return new DAL.ExamStationClass().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamStationClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamStationClassCount()
        {
            return new DAL.ExamStationClass().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStationClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamStationClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStationClass().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定exam_Station_Class_ID的ExamStationClass是否存在
        /// </summary>
        /// <param name="exam_Station_Class_ID"></param>
        /// <returns></returns>
        public bool? SearchExamStationClassExists(object exam_Station_Class_ID)
        {
            return new DAL.ExamStationClass().SelectModelObjectExistsByID(exam_Station_Class_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamStationClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamStationClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStationClass().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按exam_Station_Class_ID查询ExamStationClass
        /// </summary>
        /// <param name="exam_Station_Class_ID"></param>
        /// <returns></returns>
        public Model.ExamStationClass SearchExamStationClassByID(object exam_Station_Class_ID)
        {
            return new DAL.ExamStationClass().SelectModelObjectByID(exam_Station_Class_ID);
        }

        /// <summary>
        /// 查询第一个ExamStationClass对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamStationClass SearchUniqueExamStationClassByCondition()
        {
            return new DAL.ExamStationClass().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamStationClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamStationClass SearchUniqueExamStationClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStationClass().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamStationClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamStationClass SearchUniqueExamStationClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStationClass().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamStationClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamStationClass> SearchExamStationClassByCondition()
        {
            return new DAL.ExamStationClass().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamStationClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamStationClass> SearchExamStationClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamStationClass().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamStationClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamStationClass> SearchExamStationClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamStationClass().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamStationClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamStationClass> SearchExamStationClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamStationClass().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region  NHibernate 数据库操作方法


        /// <summary>
        /// 查找考站类别List,逻辑删除列为"1"的
        /// </summary>
        /// <returns></returns>
        public List<Tellyes.Model.ExamStationClass> SearchExamStationClass()
        {
            return new Tellyes.DAL.ExamStationClass().SelectModelObjectByCondition
            (
                 new Dictionary<string, object>() 
                { 
                    {"Number1", 1},
                    {"Number2,Eq",1}
                },               
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Exam_Station_Class_ID", "asc"),
                    new KeyValuePair<string, string>("Exam_Station_Class_Name", "asc")
                }
             );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public List<Tellyes.Model.ExamStationClass> SearchExamStationClassByRoomID(int roomID)
        {
            return new DAL.ExamStationClass().SelectExamStationClassByRoomID(roomID);
        }
        #endregion

    }
}
