using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class IllnessCaseScriptMarkSheet
    {
        private readonly DAL.IllnessCaseScriptMarkSheet dal = new DAL.IllnessCaseScriptMarkSheet();
        public IllnessCaseScriptMarkSheet()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int IllnessCaseScriptMarkSheetID)
        {
            return dal.Exists(IllnessCaseScriptMarkSheetID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseScriptMarkSheet model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.IllnessCaseScriptMarkSheet model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IllnessCaseScriptMarkSheetID)
        {

            return dal.Delete(IllnessCaseScriptMarkSheetID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IllnessCaseScriptMarkSheetIDlist)
        {
            return dal.DeleteList(IllnessCaseScriptMarkSheetIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.IllnessCaseScriptMarkSheet GetModel(int IllnessCaseScriptMarkSheetID)
        {

            return dal.GetModel(IllnessCaseScriptMarkSheetID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.IllnessCaseScriptMarkSheet GetModelByCache(int IllnessCaseScriptMarkSheetID)
        {

            string CacheKey = "IllnessCaseScriptMarkSheetModel-" + IllnessCaseScriptMarkSheetID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(IllnessCaseScriptMarkSheetID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.IllnessCaseScriptMarkSheet)objModel;
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
        public List<Model.IllnessCaseScriptMarkSheet> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.IllnessCaseScriptMarkSheet> DataTableToList(DataTable dt)
        {
            List<Model.IllnessCaseScriptMarkSheet> modelList = new List<Model.IllnessCaseScriptMarkSheet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.IllnessCaseScriptMarkSheet model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.IllnessCaseScriptMarkSheet();
                    if (dt.Rows[n]["IllnessCaseScriptMarkSheetID"].ToString() != "")
                    {
                        model.IllnessCaseScriptMarkSheetID = int.Parse(dt.Rows[n]["IllnessCaseScriptMarkSheetID"].ToString());
                    }
                    if (dt.Rows[n]["IllnessCaseScriptID"].ToString() != "")
                    {
                        model.IllnessCaseScriptID = int.Parse(dt.Rows[n]["IllnessCaseScriptID"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetID"].ToString() != "")
                    {
                        model.MarkSheetID = int.Parse(dt.Rows[n]["MarkSheetID"].ToString());
                    }


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

        #region Extension

        public bool AddIllnessCaseScriptMarkSheetList(List<Model.IllnessCaseScriptMarkSheet> illnessCaseScriptMarkSheetList)
        {
            return new DAL.IllnessCaseScriptMarkSheet().Transaction
            (
                new List<List<object>>() 
                { 
                    new List<object>(){"insert", illnessCaseScriptMarkSheetList.ToList<object>()}
                }
            );
        }

        public bool RemoveIllnessCaseScriptMarkSheet(Model.IllnessCaseScriptMarkSheet illnessCaseScriptMarkSheet)
        {
            return new DAL.IllnessCaseScriptMarkSheet().Delete(illnessCaseScriptMarkSheet);
        }

        public bool RemoveAllIllnessCaseScriptMarkSheet(int illnessCaseScriptID)
        {
            return new DAL.IllnessCaseScriptMarkSheet().DeleteIllnessCaseScriptMarkSheetByIllnessCaseScriptID(illnessCaseScriptID);
        }

        public List<Model.IllnessCaseScriptMarkSheet> SearchIllnessCaseScriptMarkSheetByIllnessCaseScriptID(int illnessCaseScriptID)
        {
            return new DAL.IllnessCaseScriptMarkSheet().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IllnessCaseScriptID", illnessCaseScriptID}
                }
            );
        }

        public List<Model.IllnessCaseScriptMarkSheet> SearchIllnessCaseScriptMarkSheetByIllnessCaseScriptIDList(List<int> illnessCaseScriptIDList)
        {
            return new DAL.IllnessCaseScriptMarkSheet().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IllnessCaseScriptIDList", illnessCaseScriptIDList}
                }
            );
        }

        public Dictionary<int, List<Dictionary<string, object>>> SearchIllnessCaseScriptMarkSheetByIllnessCaseScriptList(List<Model.IllnessCaseScript> illnessCaseScriptList)
        {
            List<int> illnessCaseScriptIDList = new List<int>();
            foreach (Model.IllnessCaseScript illnessCaseScript in illnessCaseScriptList) 
            {
                illnessCaseScriptIDList.Add(illnessCaseScript.IllnessCaseScriptID);
            }

            List<object[]> illnessCaseScriptMarkSheetList = new DAL.IllnessCaseScriptMarkSheet().SelectIllnessCaseScriptMarkSheetByIllnessCaseScriptList(illnessCaseScriptIDList);
            if (illnessCaseScriptMarkSheetList == null)
            {
                Log4NetUtility.Error(this, "查询IllnessCaseScriptMarkSheet信息失败");
                return null;
            }

            Dictionary<int, List<Dictionary<string, object>>> markSheetDictionary = new Dictionary<int, List<Dictionary<string, object>>>();
            foreach (object[] items in illnessCaseScriptMarkSheetList) 
            {
                Model.IllnessCaseScriptMarkSheet illnessCaseScriptMarkSheet = (Model.IllnessCaseScriptMarkSheet)items[0];
                Model.MarkSheet markSheet = (Model.MarkSheet)items[1];
                if (!markSheetDictionary.ContainsKey(illnessCaseScriptMarkSheet.IllnessCaseScriptID)) 
                {
                    markSheetDictionary.Add(illnessCaseScriptMarkSheet.IllnessCaseScriptID, new List<Dictionary<string, object>>());
                }
                markSheetDictionary[illnessCaseScriptMarkSheet.IllnessCaseScriptID].Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"MarkSheet", markSheet},
                        {"IllnessCaseScriptMarkSheet", illnessCaseScriptMarkSheet}
                    }
                );
            }
            return markSheetDictionary;
        }

        #endregion
    }
}
