using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
namespace Tellyes.BLL
{
    /// <summary>
    /// MarkSheetKind
    /// </summary>
    public partial class MarkSheetKind
    {
        private readonly Tellyes.DAL.MarkSheetKind dal = new Tellyes.DAL.MarkSheetKind();
        public MarkSheetKind()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSK_ID)
        {
            return dal.Exists(MSK_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.MarkSheetKind model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.MarkSheetKind model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MSK_ID)
        {

            return dal.Delete(MSK_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MSK_IDlist)
        {
            return dal.DeleteList(MSK_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.MarkSheetKind GetModel(int MSK_ID)
        {

            return dal.GetModel(MSK_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.MarkSheetKind GetModelByCache(int MSK_ID)
        {

            string CacheKey = "MarkSheetKindModel-" + MSK_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MSK_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.MarkSheetKind)objModel;
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
        public List<Tellyes.Model.MarkSheetKind> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.MarkSheetKind> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.MarkSheetKind> modelList = new List<Tellyes.Model.MarkSheetKind>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.MarkSheetKind model;
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

        public List<Model.MarkSheetKind> SearchMarkSheetKind()
        {
            return new DAL.MarkSheetKind().SelectModelObjectByCondition(
                new Dictionary<string, object>() 
                { 
                    {"string1", "1"}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("MSK_Kind", "ASC")
                }
            );
        }
        public Dictionary<int, Model.MarkSheetKind> SearchMarkSheetKindDictionary()
        {
            List<Model.MarkSheetKind> markSheetKindList = new DAL.MarkSheetKind().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"string1", "1"}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("MSK_Kind", "ASC")
                }
            );
            if(markSheetKindList == null) 
            {
                Log4NetUtility.Error(this, "评分表分类查询失败");
                return null;
            }
            Dictionary<int, Model.MarkSheetKind> markSheetKindDictionary = new Dictionary<int,Model.MarkSheetKind>();
            foreach (Model.MarkSheetKind markSheetKind in markSheetKindList)
            {
                markSheetKindDictionary.Add(markSheetKind.MSK_ID, markSheetKind);
            }
            return markSheetKindDictionary;
        }

        public Model.MarkSheetKind SearchMarkSheetKindByMSKID(int MSK_ID)
        {
            return new DAL.MarkSheetKind().SelectModelObjectByID(MSK_ID);
        }

        #endregion  ExtensionMethod
    }
}

