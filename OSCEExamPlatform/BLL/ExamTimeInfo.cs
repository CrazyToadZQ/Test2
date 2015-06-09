using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// ExamTimeInfo
    /// </summary>
    public partial class ExamTimeInfo
    {
        private readonly Tellyes.DAL.ExamTimeInfo dal = new Tellyes.DAL.ExamTimeInfo();
        public ExamTimeInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ETI_ID)
        {
            return dal.Exists(ETI_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamTimeInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamTimeInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ETI_ID)
        {

            return dal.Delete(ETI_ID);
        }
        ///// <summary>
        ///// 删除一条数据
        ///// </summary>
        //public bool DeleteList(string ETI_IDlist)
        //{
        //    return dal.DeleteList(Tellyes.Common.PageValidate.SafeLongFilter(ETI_IDlist, 0));
        //}

        /// <summary>
        /// 批量删除
        /// </summary>
        public bool DeleteList(string ETI_IDlist)
        {
            return dal.DeleteList(ETI_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamTimeInfo GetModel(int ETI_ID)
        {

            return dal.GetModel(ETI_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamTimeInfo GetModelByCache(int ETI_ID)
        {

            string CacheKey = "ExamTimeInfoModel-" + ETI_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ETI_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamTimeInfo)objModel;
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
        public List<Tellyes.Model.ExamTimeInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamTimeInfo> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamTimeInfo> modelList = new List<Tellyes.Model.ExamTimeInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamTimeInfo model;
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
        /// 添加ExamTimeInfo记录
        /// </summary>
        /// <param name="examTimeInfo"></param>
        /// <returns></returns>
        public bool AddExamTimeInfo(Model.ExamTimeInfo examTimeInfo)
        {
            return new DAL.ExamTimeInfo().Insert(examTimeInfo);
        }

        /// <summary>
        /// 删除ExamTimeInfo记录
        /// </summary>
        /// <param name="examTimeInfo"></param>
        /// <returns></returns>
        public bool RemoveExamTimeInfo(Model.ExamTimeInfo examTimeInfo)
        {
            return new DAL.ExamTimeInfo().Delete(examTimeInfo);
        }

        /// <summary>
        /// 修改ExamTimeInfo记录
        /// </summary>
        /// <param name="examTimeInfo"></param>
        /// <returns></returns>
        public bool ModifyExamTimeInfo(Model.ExamTimeInfo examTimeInfo)
        {
            return new DAL.ExamTimeInfo().Update((object)examTimeInfo);
        }

        /// <summary>
        /// 查询ExamTimeInfo下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamTimeInfoIdentity()
        {
            return new DAL.ExamTimeInfo().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamTimeInfo记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamTimeInfoCount()
        {
            return new DAL.ExamTimeInfo().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamTimeInfo记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamTimeInfoCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定eTI_ID的ExamTimeInfo是否存在
        /// </summary>
        /// <param name="eTI_ID"></param>
        /// <returns></returns>
        public bool? SearchExamTimeInfoExists(object eTI_ID)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectExistsByID(eTI_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamTimeInfo是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamTimeInfoExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按eTI_ID查询ExamTimeInfo
        /// </summary>
        /// <param name="eTI_ID"></param>
        /// <returns></returns>
        public Model.ExamTimeInfo SearchExamTimeInfoByID(object eTI_ID)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectByID(eTI_ID);
        }

        /// <summary>
        /// 查询第一个ExamTimeInfo对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamTimeInfo SearchUniqueExamTimeInfoByCondition()
        {
            return new DAL.ExamTimeInfo().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamTimeInfo SearchUniqueExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTimeInfo().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamTimeInfo SearchUniqueExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamTimeInfo().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamTimeInfo对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamTimeInfo> SearchExamTimeInfoByCondition()
        {
            return new DAL.ExamTimeInfo().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamTimeInfo> SearchExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamTimeInfo> SearchExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamTimeInfo内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamTimeInfo> SearchExamTimeInfoByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamTimeInfo().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }




        /// <summary>
        /// 查询每天考生数量
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, int>> SearchEachDateStudentCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> examStudentList = new Tellyes.DAL.ExamTimeInfo().SelectEachDateStudentCountByCondition(conditionDictionary);
                
            if (examStudentList == null)
            {
                Log4NetUtility.Error(this, "查询考生总量失败");
                return null;
            }
            List<Dictionary<string, int>> eaxmInfoList = new List<Dictionary<string, int>>();
            foreach (object[] item in examStudentList)
            {
                Dictionary<string, int> eaxmInfoDictionary = new Dictionary<string, int>();
                string examDate=item[0].ToString();
                eaxmInfoDictionary.Add(examDate, Convert.ToInt32(item[1]));
                //if (!eaxmInfoDictionary.ContainsKey(examDate))
                //{
                //    eaxmInfoDictionary.Add(examDate, new int());
                //}
                //eaxmInfoDictionary[examDate] = Convert.ToInt32(item[1]);
                eaxmInfoList.Add(eaxmInfoDictionary);
            }
            return eaxmInfoList;
        }

        #endregion
    }
}
