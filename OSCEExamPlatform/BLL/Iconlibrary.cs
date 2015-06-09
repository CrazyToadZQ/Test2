using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
  public  class Iconlibrary
    {

        private readonly Tellyes.DAL.Iconlibrary dal = new Tellyes.DAL.Iconlibrary();
        public Iconlibrary()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Icon_ID)
        {
            return dal.Exists(Icon_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.Iconlibrary model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.Iconlibrary model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Icon_ID)
        {

            return dal.Delete(Icon_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Icon_IDlist)
        {
            return dal.DeleteList(Icon_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.Iconlibrary GetModel(int Icon_ID)
        {

            return dal.GetModel(Icon_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.Iconlibrary GetModelByCache(int Icon_ID)
        {

            string CacheKey = "IconlibraryModel-" + Icon_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Icon_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.Iconlibrary)objModel;
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
        public List<Tellyes.Model.Iconlibrary> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.Iconlibrary> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.Iconlibrary> modelList = new List<Tellyes.Model.Iconlibrary>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.Iconlibrary model;
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

        // <summary>
        // 批量更新数据
        // </summary>
        public int UpdateList(List<Tellyes.Model.Iconlibrary> iconModelList)
        {
            return dal.UpdateList(iconModelList);
        }
        #endregion  ExtensionMethod
    }
}
