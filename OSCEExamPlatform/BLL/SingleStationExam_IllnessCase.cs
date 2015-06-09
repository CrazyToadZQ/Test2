using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public partial class SingleStationExam_IllnessCase
    {
        private readonly Tellyes.DAL.SingleStationExam_IllnessCase dal = new Tellyes.DAL.SingleStationExam_IllnessCase();
        public SingleStationExam_IllnessCase()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SingleExam_IllnessCase_ID)
        {
            return dal.Exists(SingleExam_IllnessCase_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.SingleStationExam_IllnessCase model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.SingleStationExam_IllnessCase model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int SingleExam_IllnessCase_ID)
        {

            return dal.Delete(SingleExam_IllnessCase_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string SingleExam_IllnessCase_IDlist)
        {
            return dal.DeleteList(SingleExam_IllnessCase_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.SingleStationExam_IllnessCase GetModel(int SingleExam_IllnessCase_ID)
        {

            return dal.GetModel(SingleExam_IllnessCase_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.SingleStationExam_IllnessCase GetModelByCache(int SingleExam_IllnessCase_ID)
        {

            string CacheKey = "SingleStationExam_IllnessCaseModel-" + SingleExam_IllnessCase_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(SingleExam_IllnessCase_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.SingleStationExam_IllnessCase)objModel;
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
        public List<Tellyes.Model.SingleStationExam_IllnessCase> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.SingleStationExam_IllnessCase> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.SingleStationExam_IllnessCase> modelList = new List<Tellyes.Model.SingleStationExam_IllnessCase>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.SingleStationExam_IllnessCase model;
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
        /// 添加SingleStationExam_IllnessCase记录
        /// </summary>
        /// <param name="singleStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool AddSingleStationExam_IllnessCase(Model.SingleStationExam_IllnessCase singleStationExam_IllnessCase)
        {
            return new DAL.SingleStationExam_IllnessCase().Insert(singleStationExam_IllnessCase);
        }

        /// <summary>
        /// 删除SingleStationExam_IllnessCase记录
        /// </summary>
        /// <param name="singleStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool RemoveSingleStationExam_IllnessCase(Model.SingleStationExam_IllnessCase singleStationExam_IllnessCase)
        {
            return new DAL.SingleStationExam_IllnessCase().Delete(singleStationExam_IllnessCase);
        }

        /// <summary>
        /// 修改SingleStationExam_IllnessCase记录
        /// </summary>
        /// <param name="singleStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool ModifySingleStationExam_IllnessCase(Model.SingleStationExam_IllnessCase singleStationExam_IllnessCase)
        {
            return new DAL.SingleStationExam_IllnessCase().Update((object)singleStationExam_IllnessCase);
        }

        /// <summary>
        /// 查询SingleStationExam_IllnessCase下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExam_IllnessCaseIdentity()
        {
            return new DAL.SingleStationExam_IllnessCase().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部SingleStationExam_IllnessCase记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExam_IllnessCaseCount()
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询SingleStationExam_IllnessCase记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchSingleStationExam_IllnessCaseCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定singleExam_IllnessCase_ID的SingleStationExam_IllnessCase是否存在
        /// </summary>
        /// <param name="singleExam_IllnessCase_ID"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExam_IllnessCaseExists(object singleExam_IllnessCase_ID)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectExistsByID(singleExam_IllnessCase_ID);
        }

        /// <summary>
        /// 查询指定条件的SingleStationExam_IllnessCase是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExam_IllnessCaseExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按singleExam_IllnessCase_ID查询SingleStationExam_IllnessCase
        /// </summary>
        /// <param name="singleExam_IllnessCase_ID"></param>
        /// <returns></returns>
        public Model.SingleStationExam_IllnessCase SearchSingleStationExam_IllnessCaseByID(object singleExam_IllnessCase_ID)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectByID(singleExam_IllnessCase_ID);
        }

        /// <summary>
        /// 查询第一个SingleStationExam_IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public Model.SingleStationExam_IllnessCase SearchUniqueSingleStationExam_IllnessCaseByCondition()
        {
            return new DAL.SingleStationExam_IllnessCase().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个SingleStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.SingleStationExam_IllnessCase SearchUniqueSingleStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个SingleStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.SingleStationExam_IllnessCase SearchUniqueSingleStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部SingleStationExam_IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public List<Model.SingleStationExam_IllnessCase> SearchSingleStationExam_IllnessCaseByCondition()
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询SingleStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.SingleStationExam_IllnessCase> SearchSingleStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询SingleStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.SingleStationExam_IllnessCase> SearchSingleStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询SingleStationExam_IllnessCase内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.SingleStationExam_IllnessCase> SearchSingleStationExam_IllnessCaseByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.SingleStationExam_IllnessCase().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
