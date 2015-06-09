using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamLog
    {
        private readonly DAL.TempExamLog dal = new DAL.TempExamLog();
        public TempExamLog()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TempExamLogID)
        {
            return dal.Exists(TempExamLogID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamLog model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamLog model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TempExamLogID)
        {

            return dal.Delete(TempExamLogID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string TempExamLogIDlist)
        {
            return dal.DeleteList(TempExamLogIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamLog GetModel(int TempExamLogID)
        {

            return dal.GetModel(TempExamLogID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamLog GetModelByCache(int TempExamLogID)
        {

            string CacheKey = "TempExamLogModel-" + TempExamLogID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamLogID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamLog)objModel;
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
        public List<Model.TempExamLog> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamLog> DataTableToList(DataTable dt)
        {
            List<Model.TempExamLog> modelList = new List<Model.TempExamLog>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamLog model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamLog();
                    if (dt.Rows[n]["TempExamLogID"].ToString() != "")
                    {
                        model.TempExamLogID = int.Parse(dt.Rows[n]["TempExamLogID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLogNumber3"].ToString() != "")
                    {
                        model.TempExamLogNumber3 = decimal.Parse(dt.Rows[n]["TempExamLogNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLogNumber4"].ToString() != "")
                    {
                        model.TempExamLogNumber4 = decimal.Parse(dt.Rows[n]["TempExamLogNumber4"].ToString());
                    }
                    model.TempExamLogString1 = dt.Rows[n]["TempExamLogString1"].ToString();
                    model.TempExamLogString2 = dt.Rows[n]["TempExamLogString2"].ToString();
                    model.TempExamLogString3 = dt.Rows[n]["TempExamLogString3"].ToString();
                    model.TempExamLogString4 = dt.Rows[n]["TempExamLogString4"].ToString();
                    if (dt.Rows[n]["TempExamLogDatetime1"].ToString() != "")
                    {
                        model.TempExamLogDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamLogDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLogDatetime2"].ToString() != "")
                    {
                        model.TempExamLogDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamLogDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    model.LogType = dt.Rows[n]["LogType"].ToString();
                    model.LogContent = dt.Rows[n]["LogContent"].ToString();
                    if (dt.Rows[n]["LogDatetime"].ToString() != "")
                    {
                        model.LogDatetime = DateTime.Parse(dt.Rows[n]["LogDatetime"].ToString());
                    }
                    if (dt.Rows[n]["LogUserInfoID"].ToString() != "")
                    {
                        model.LogUserInfoID = int.Parse(dt.Rows[n]["LogUserInfoID"].ToString());
                    }
                    model.LogUerInfoTrueName = dt.Rows[n]["LogUerInfoTrueName"].ToString();
                    if (dt.Rows[n]["TempExamLogNumber1"].ToString() != "")
                    {
                        model.TempExamLogNumber1 = int.Parse(dt.Rows[n]["TempExamLogNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLogNumber2"].ToString() != "")
                    {
                        model.TempExamLogNumber2 = int.Parse(dt.Rows[n]["TempExamLogNumber2"].ToString());
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

        #region Extension NHibernate

        /// <summary>
        /// 添加TempExamLog记录
        /// </summary>
        /// <param name="tempExamLog"></param>
        /// <returns></returns>
        public bool AddTempExamLog(Model.TempExamLog tempExamLog)
        {
            return new DAL.TempExamLog().Insert(tempExamLog);
        }

        /// <summary>
        /// 删除TempExamLog记录
        /// </summary>
        /// <param name="tempExamLog"></param>
        /// <returns></returns>
        public bool RemoveTempExamLog(Model.TempExamLog tempExamLog)
        {
            return new DAL.TempExamLog().Delete(tempExamLog);
        }

        /// <summary>
        /// 修改TempExamLog记录
        /// </summary>
        /// <param name="tempExamLog"></param>
        /// <returns></returns>
        public bool ModifyTempExamLog(Model.TempExamLog tempExamLog)
        {
            return new DAL.TempExamLog().Update((object)tempExamLog);
        }

        /// <summary>
        /// 查询TempExamLog下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamLogIdentity()
        {
            return new DAL.TempExamLog().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamLog记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamLogCount()
        {
            return new DAL.TempExamLog().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamLog记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamLogCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamLog().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamLogID的TempExamLog是否存在
        /// </summary>
        /// <param name="tempExamLogID"></param>
        /// <returns></returns>
        public bool? SearchTempExamLogExists(object tempExamLogID)
        {
            return new DAL.TempExamLog().SelectModelObjectExistsByID(tempExamLogID);
        }

        /// <summary>
        /// 查询指定条件的TempExamLog是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamLogExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamLog().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamLogID查询TempExamLog
        /// </summary>
        /// <param name="tempExamLogID"></param>
        /// <returns></returns>
        public Model.TempExamLog SearchTempExamLogByID(object tempExamLogID)
        {
            return new DAL.TempExamLog().SelectModelObjectByID(tempExamLogID);
        }

        /// <summary>
        /// 查询第一个TempExamLog对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamLog SearchUniqueTempExamLogByCondition()
        {
            return new DAL.TempExamLog().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamLog SearchUniqueTempExamLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamLog().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamLog SearchUniqueTempExamLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamLog().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamLog对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamLog> SearchTempExamLogByCondition()
        {
            return new DAL.TempExamLog().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamLog> SearchTempExamLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamLog().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamLog> SearchTempExamLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamLog().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamLog内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamLog> SearchTempExamLogByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamLog().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
