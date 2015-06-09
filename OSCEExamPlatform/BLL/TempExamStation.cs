using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamStation
    {
        private readonly DAL.TempExamStation dal = new DAL.TempExamStation();
        public TempExamStation()
        { }

        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid TempExamStationID)
        {
            return dal.Exists(TempExamStationID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStation model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStation model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid TempExamStationID)
        {

            return dal.Delete(TempExamStationID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamStation GetModel(Guid TempExamStationID)
        {

            return dal.GetModel(TempExamStationID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamStation GetModelByCache(Guid TempExamStationID)
        {

            string CacheKey = "TempExamStationModel-" + TempExamStationID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamStationID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamStation)objModel;
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
        public List<Model.TempExamStation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamStation> DataTableToList(DataTable dt)
        {
            List<Model.TempExamStation> modelList = new List<Model.TempExamStation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamStation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamStation();
                    if (dt.Rows[n]["TempExamStationID"].ToString() != "")
                    {
                        model.TempExamStationID = Guid.Parse(dt.Rows[n]["TempExamStationID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationIsComplete"].ToString() != "")
                    {
                        model.TempExamStationIsComplete = int.Parse(dt.Rows[n]["TempExamStationIsComplete"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber1"].ToString() != "")
                    {
                        model.TempExamStationNumber1 = int.Parse(dt.Rows[n]["TempExamStationNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber2"].ToString() != "")
                    {
                        model.TempExamStationNumber2 = int.Parse(dt.Rows[n]["TempExamStationNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber3"].ToString() != "")
                    {
                        model.TempExamStationNumber3 = int.Parse(dt.Rows[n]["TempExamStationNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber4"].ToString() != "")
                    {
                        model.TempExamStationNumber4 = long.Parse(dt.Rows[n]["TempExamStationNumber4"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber5"].ToString() != "")
                    {
                        model.TempExamStationNumber5 = long.Parse(dt.Rows[n]["TempExamStationNumber5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber6"].ToString() != "")
                    {
                        model.TempExamStationNumber6 = decimal.Parse(dt.Rows[n]["TempExamStationNumber6"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber7"].ToString() != "")
                    {
                        model.TempExamStationNumber7 = decimal.Parse(dt.Rows[n]["TempExamStationNumber7"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber8"].ToString() != "")
                    {
                        model.TempExamStationNumber8 = decimal.Parse(dt.Rows[n]["TempExamStationNumber8"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationNumber9"].ToString() != "")
                    {
                        model.TempExamStationNumber9 = decimal.Parse(dt.Rows[n]["TempExamStationNumber9"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    model.TempExamStationString1 = dt.Rows[n]["TempExamStationString1"].ToString();
                    model.TempExamStationString2 = dt.Rows[n]["TempExamStationString2"].ToString();
                    model.TempExamStationString3 = dt.Rows[n]["TempExamStationString3"].ToString();
                    model.TempExamStationString4 = dt.Rows[n]["TempExamStationString4"].ToString();
                    model.TempExamStationString5 = dt.Rows[n]["TempExamStationString5"].ToString();
                    model.TempExamStationString6 = dt.Rows[n]["TempExamStationString6"].ToString();
                    model.TempExamStationString7 = dt.Rows[n]["TempExamStationString7"].ToString();
                    model.TempExamStationString8 = dt.Rows[n]["TempExamStationString8"].ToString();
                    model.TempExamStationString9 = dt.Rows[n]["TempExamStationString9"].ToString();
                    if (dt.Rows[n]["TempExamStationDatetime1"].ToString() != "")
                    {
                        model.TempExamStationDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["ExamStationClassID"].ToString() != "")
                    {
                        model.ExamStationClassID = int.Parse(dt.Rows[n]["ExamStationClassID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationDatetime2"].ToString() != "")
                    {
                        model.TempExamStationDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationDatetime3"].ToString() != "")
                    {
                        model.TempExamStationDatetime3 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationDatetime4"].ToString() != "")
                    {
                        model.TempExamStationDatetime4 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime4"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationDatetime5"].ToString() != "")
                    {
                        model.TempExamStationDatetime5 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationDatetime6"].ToString() != "")
                    {
                        model.TempExamStationDatetime6 = DateTime.Parse(dt.Rows[n]["TempExamStationDatetime6"].ToString());
                    }
                    model.TempExamStationName = dt.Rows[n]["TempExamStationName"].ToString();
                    model.TempExamStationContent = dt.Rows[n]["TempExamStationContent"].ToString();
                    model.TempExamStationCurriculum = dt.Rows[n]["TempExamStationCurriculum"].ToString();
                    if (dt.Rows[n]["TempExamStationKind"].ToString() != "")
                    {
                        model.TempExamStationKind = int.Parse(dt.Rows[n]["TempExamStationKind"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationSubjectivePercent"].ToString() != "")
                    {
                        model.TempExamStationSubjectivePercent = int.Parse(dt.Rows[n]["TempExamStationSubjectivePercent"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationOrderNumber"].ToString() != "")
                    {
                        model.TempExamStationOrderNumber = int.Parse(dt.Rows[n]["TempExamStationOrderNumber"].ToString());
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
        /// 添加TempExamStation记录
        /// </summary>
        /// <param name="tempExamStation"></param>
        /// <returns></returns>
        public bool AddTempExamStation(Model.TempExamStation tempExamStation)
        {
            return new DAL.TempExamStation().Insert(tempExamStation);
        }

        /// <summary>
        /// 删除TempExamStation记录
        /// </summary>
        /// <param name="tempExamStation"></param>
        /// <returns></returns>
        public bool RemoveTempExamStation(Model.TempExamStation tempExamStation)
        {
            return new DAL.TempExamStation().Delete(tempExamStation);
        }

        /// <summary>
        /// 修改TempExamStation记录
        /// </summary>
        /// <param name="tempExamStation"></param>
        /// <returns></returns>
        public bool ModifyTempExamStation(Model.TempExamStation tempExamStation)
        {
            return new DAL.TempExamStation().Update((object)tempExamStation);
        }

        /// <summary>
        /// 查询TempExamStation下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStationIdentity()
        {
            return new DAL.TempExamStation().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamStation记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStationCount()
        {
            return new DAL.TempExamStation().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStation记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamStationCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStation().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamStationID的TempExamStation是否存在
        /// </summary>
        /// <param name="tempExamStationID"></param>
        /// <returns></returns>
        public bool? SearchTempExamStationExists(object tempExamStationID)
        {
            return new DAL.TempExamStation().SelectModelObjectExistsByID(tempExamStationID);
        }

        /// <summary>
        /// 查询指定条件的TempExamStation是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamStationExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStation().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamStationID查询TempExamStation
        /// </summary>
        /// <param name="tempExamStationID"></param>
        /// <returns></returns>
        public Model.TempExamStation SearchTempExamStationByID(object tempExamStationID)
        {
            return new DAL.TempExamStation().SelectModelObjectByID(tempExamStationID);
        }

        /// <summary>
        /// 查询第一个TempExamStation对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamStation SearchUniqueTempExamStationByCondition()
        {
            return new DAL.TempExamStation().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamStation SearchUniqueTempExamStationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStation().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamStation SearchUniqueTempExamStationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStation().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamStation对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamStation> SearchTempExamStationByCondition()
        {
            return new DAL.TempExamStation().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamStation> SearchTempExamStationByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStation().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamStation对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamStation> SearchTempExamStationByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStation().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamStation内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamStation> SearchTempExamStationByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamStation().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
