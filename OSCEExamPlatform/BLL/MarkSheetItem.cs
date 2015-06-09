using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using System.Linq;
namespace Tellyes.BLL
{
    /// <summary>
    /// MarkSheetItem
    /// </summary>
    public partial class MarkSheetItem
    {
        private readonly Tellyes.DAL.MarkSheetItem dal = new Tellyes.DAL.MarkSheetItem();
        public MarkSheetItem()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSI_ID)
        {
            return dal.Exists(MSI_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.MarkSheetItem model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.MarkSheetItem model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MSI_ID)
        {

            return dal.Delete(MSI_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MSI_IDlist)
        {
            return dal.DeleteList(MSI_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.MarkSheetItem GetModel(int MSI_ID)
        {

            return dal.GetModel(MSI_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.MarkSheetItem GetModelByCache(int MSI_ID)
        {

            string CacheKey = "MarkSheetItemModel-" + MSI_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MSI_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.MarkSheetItem)objModel;
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
        public List<Tellyes.Model.MarkSheetItem> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.MarkSheetItem> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.MarkSheetItem> modelList = new List<Tellyes.Model.MarkSheetItem>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.MarkSheetItem model;
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
        /// 获取评分项详细信息（二级分类）
        /// </summary>
        /// <param name="MS_ID">父评分表ID</param>
        /// <returns></returns>
        public DataSet GetItemsList(int MS_ID)
        {
            return dal.GetItemsList(MS_ID);
        }
        #endregion  ExtensionMethod
        #region Extension NHibernate

        /// <summary>
        /// 添加MarkSheetItem记录
        /// </summary>
        /// <param name="markSheetItem"></param>
        /// <returns></returns>
        public bool AddMarkSheetItem(Model.MarkSheetItem markSheetItem)
        {
            return new DAL.MarkSheetItem().Insert(markSheetItem);
        }

        /// <summary>
        /// 删除MarkSheetItem记录
        /// </summary>
        /// <param name="markSheetItem"></param>
        /// <returns></returns>
        public bool RemoveMarkSheetItem(Model.MarkSheetItem markSheetItem)
        {
            return new DAL.MarkSheetItem().Delete(markSheetItem);
        }

        /// <summary>
        /// 修改MarkSheetItem记录
        /// </summary>
        /// <param name="markSheetItem"></param>
        /// <returns></returns>
        public bool ModifyMarkSheetItem(Model.MarkSheetItem markSheetItem)
        {
            return new DAL.MarkSheetItem().Update((object)markSheetItem);
        }

        /// <summary>
        /// 查询MarkSheetItem下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchMarkSheetItemIdentity()
        {
            return new DAL.MarkSheetItem().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部MarkSheetItem记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchMarkSheetItemCount()
        {
            return new DAL.MarkSheetItem().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询MarkSheetItem记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchMarkSheetItemCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheetItem().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定mSI_ID的MarkSheetItem是否存在
        /// </summary>
        /// <param name="mSI_ID"></param>
        /// <returns></returns>
        public bool? SearchMarkSheetItemExists(object mSI_ID)
        {
            return new DAL.MarkSheetItem().SelectModelObjectExistsByID(mSI_ID);
        }

        /// <summary>
        /// 查询指定条件的MarkSheetItem是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchMarkSheetItemExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheetItem().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按mSI_ID查询MarkSheetItem
        /// </summary>
        /// <param name="mSI_ID"></param>
        /// <returns></returns>
        public Model.MarkSheetItem SearchMarkSheetItemByID(object mSI_ID)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByID(mSI_ID);
        }

        /// <summary>
        /// 查询第一个MarkSheetItem对象
        /// </summary>
        /// <returns></returns>
        public Model.MarkSheetItem SearchUniqueMarkSheetItemByCondition()
        {
            return new DAL.MarkSheetItem().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个MarkSheetItem对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.MarkSheetItem SearchUniqueMarkSheetItemByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheetItem().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个MarkSheetItem对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.MarkSheetItem SearchUniqueMarkSheetItemByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MarkSheetItem().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部MarkSheetItem对象
        /// </summary>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByCondition()
        {
            return new DAL.MarkSheetItem().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询MarkSheetItem对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询MarkSheetItem对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询MarkSheetItem内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="markSheetIDList"></param>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByMarkSheetIDList(List<int> markSheetIDList)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"MarkSheetIDList", markSheetIDList}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("MSI_ID", "asc")
                }
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MS_ID"></param>
        /// <returns></returns>
        public List<Model.MarkSheetItem> SearchMarkSheetItemByMarkSheetID(int MS_ID)
        {
            return new DAL.MarkSheetItem().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"MarkSheetID", MS_ID}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("MSI_ID", "asc")
                }
            );
        }

        #endregion

        #region 获取的二级或者三级的总数
        public object getSecondMarkNewTotal(int MS_ID, string parentID)
        {
            return dal.getSecondMarkNewTotal(MS_ID, parentID);

        }
        #endregion

        #region 获取的是二级表中的数据
        public List<Tellyes.Model.MarkSheetItem> getSecondMarkNewALL(int MS_ID, string parentID, string pageIndex, string pageSize)
        {
            return dal.getSecondMarkNewALL(MS_ID, parentID, pageIndex, pageSize);
        }
        #endregion

        #region 新增二级或者是三级评分表
        public bool addSecondOrThreeMarkSheet(Tellyes.Model.MarkSheetItem mark)
        {
            return dal.addSecondOrThreeMarkSheet(mark) > 0 ? true : false;
        }
        #endregion

        #region 编辑二级或者是三级评分表
        public bool editSecondOrThreeMarkSheet(Tellyes.Model.MarkSheetItem model, decimal secondMark, decimal oneMark)
        {
            return dal.editSecondOrThreeMarkSheet(model,secondMark,oneMark) > 0 ? true : false;
        }
        #endregion

        #region 删除二级或者是三级评分表
        /// <summary>
        /// 删除二级或者是三级评分表
        /// </summary>
        /// <returns></returns>
        public bool delSecondOrThreeMarkSheet(params string[] conditions)
        {
            return dal.delSecondOrThreeMarkSheet(conditions) > 0 ? true : false;
        }
        #endregion

        #region 向上移动和向下移动进行更新数据
        public bool insertSecondOrThreeMarkSheet(List<Tellyes.Model.MarkSheetItem> model)
        {

            return dal.insertSecondOrThreeMarkSheet(model) > 0 ? true : false;
        }
        #endregion

        #region 获取的是二级表中的数据
        public List<Tellyes.Model.MarkSheetItem> getSecondMarkNew(int MS_ID, string parentID)
        {
            return dal.getSecondMarkNew(MS_ID, parentID);
        }
        #endregion

        
    }
}

