using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamTimeInfo
    {
        private readonly DAL.TempExamTimeInfo dal = new DAL.TempExamTimeInfo();
        public TempExamTimeInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TempExamTimeInfoID)
        {
            return dal.Exists(TempExamTimeInfoID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamTimeInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamTimeInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TempExamTimeInfoID)
        {

            return dal.Delete(TempExamTimeInfoID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string TempExamTimeInfoIDlist)
        {
            return dal.DeleteList(TempExamTimeInfoIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamTimeInfo GetModel(int TempExamTimeInfoID)
        {

            return dal.GetModel(TempExamTimeInfoID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamTimeInfo GetModelByCache(int TempExamTimeInfoID)
        {

            string CacheKey = "TempExamTimeInfoModel-" + TempExamTimeInfoID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamTimeInfoID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamTimeInfo)objModel;
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
        public List<Model.TempExamTimeInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamTimeInfo> DataTableToList(DataTable dt)
        {
            List<Model.TempExamTimeInfo> modelList = new List<Model.TempExamTimeInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamTimeInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamTimeInfo();
                    if (dt.Rows[n]["TempExamTimeInfoID"].ToString() != "")
                    {
                        model.TempExamTimeInfoID = int.Parse(dt.Rows[n]["TempExamTimeInfoID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTimeInfoNumber4"].ToString() != "")
                    {
                        model.TempExamTimeInfoNumber4 = decimal.Parse(dt.Rows[n]["TempExamTimeInfoNumber4"].ToString());
                    }
                    model.TempExamTimeInfoString1 = dt.Rows[n]["TempExamTimeInfoString1"].ToString();
                    model.TempExamTimeInfoString2 = dt.Rows[n]["TempExamTimeInfoString2"].ToString();
                    model.TempExamTimeInfoString3 = dt.Rows[n]["TempExamTimeInfoString3"].ToString();
                    model.TempExamTimeInfoString4 = dt.Rows[n]["TempExamTimeInfoString4"].ToString();
                    if (dt.Rows[n]["TempExamTimeInfoDatetime1"].ToString() != "")
                    {
                        model.TempExamTimeInfoDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamTimeInfoDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTimeInfoDatetime2"].ToString() != "")
                    {
                        model.TempExamTimeInfoDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamTimeInfoDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    model.TempExamTimeInfoDate = dt.Rows[n]["TempExamTimeInfoDate"].ToString();
                    model.TempExamTimeInfoStartTime = dt.Rows[n]["TempExamTimeInfoStartTime"].ToString();
                    model.TempExamTimeInfoEndTime = dt.Rows[n]["TempExamTimeInfoEndTime"].ToString();
                    if (dt.Rows[n]["TempExamTimeInfoStudentCount"].ToString() != "")
                    {
                        model.TempExamTimeInfoStudentCount = int.Parse(dt.Rows[n]["TempExamTimeInfoStudentCount"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTimeInfoNumber1"].ToString() != "")
                    {
                        model.TempExamTimeInfoNumber1 = int.Parse(dt.Rows[n]["TempExamTimeInfoNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTimeInfoNumber2"].ToString() != "")
                    {
                        model.TempExamTimeInfoNumber2 = int.Parse(dt.Rows[n]["TempExamTimeInfoNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTimeInfoNumber3"].ToString() != "")
                    {
                        model.TempExamTimeInfoNumber3 = decimal.Parse(dt.Rows[n]["TempExamTimeInfoNumber3"].ToString());
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
        /// 添加TempExamTimeInfo记录
        /// </summary>
        /// <param name="tempExamTimeInfo"></param>
        /// <returns></returns>
        public bool AddTempExamTimeInfo(Model.TempExamTimeInfo tempExamTimeInfo)
        {
            return new DAL.TempExamTimeInfo().Insert(tempExamTimeInfo);
        }

        /// <summary>
        /// 删除TempExamTimeInfo记录
        /// </summary>
        /// <param name="tempExamTimeInfo"></param>
        /// <returns></returns>
        public bool RemoveTempExamTimeInfo(Model.TempExamTimeInfo tempExamTimeInfo)
        {
            return new DAL.TempExamTimeInfo().Delete(tempExamTimeInfo);
        }

        /// <summary>
        /// 修改TempExamTimeInfo记录
        /// </summary>
        /// <param name="tempExamTimeInfo"></param>
        /// <returns></returns>
        public bool ModifyTempExamTimeInfo(Model.TempExamTimeInfo tempExamTimeInfo)
        {
            return new DAL.TempExamTimeInfo().Update((object)tempExamTimeInfo);
        }

        /// <summary>
        /// 查询TempExamTimeInfo下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamTimeInfoIdentity()
        {
            return new DAL.TempExamTimeInfo().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamTimeInfo记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamTimeInfoCount()
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamTimeInfo记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamTimeInfoCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamTimeInfoID的TempExamTimeInfo是否存在
        /// </summary>
        /// <param name="tempExamTimeInfoID"></param>
        /// <returns></returns>
        public bool? SearchTempExamTimeInfoExists(object tempExamTimeInfoID)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectExistsByID(tempExamTimeInfoID);
        }

        /// <summary>
        /// 查询指定条件的TempExamTimeInfo是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamTimeInfoExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamTimeInfoID查询TempExamTimeInfo
        /// </summary>
        /// <param name="tempExamTimeInfoID"></param>
        /// <returns></returns>
        public Model.TempExamTimeInfo SearchTempExamTimeInfoByID(object tempExamTimeInfoID)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectByID(tempExamTimeInfoID);
        }

        /// <summary>
        /// 查询第一个TempExamTimeInfo对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamTimeInfo SearchUniqueTempExamTimeInfoByCondition()
        {
            return new DAL.TempExamTimeInfo().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamTimeInfo SearchUniqueTempExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTimeInfo().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamTimeInfo SearchUniqueTempExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamTimeInfo().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamTimeInfo对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamTimeInfo> SearchTempExamTimeInfoByCondition()
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamTimeInfo> SearchTempExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamTimeInfo对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamTimeInfo> SearchTempExamTimeInfoByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamTimeInfo内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamTimeInfo> SearchTempExamTimeInfoByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamTimeInfo().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
