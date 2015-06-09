using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamIllnessCase
    {
        private readonly DAL.TempExamIllnessCase dal = new DAL.TempExamIllnessCase();
        public TempExamIllnessCase()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TempExamIllnessCaseID)
        {
            return dal.Exists(TempExamIllnessCaseID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamIllnessCase model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamIllnessCase model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TempExamIllnessCaseID)
        {

            return dal.Delete(TempExamIllnessCaseID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string TempExamIllnessCaseIDlist)
        {
            return dal.DeleteList(TempExamIllnessCaseIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamIllnessCase GetModel(int TempExamIllnessCaseID)
        {

            return dal.GetModel(TempExamIllnessCaseID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamIllnessCase GetModelByCache(int TempExamIllnessCaseID)
        {

            string CacheKey = "TempExamIllnessCaseModel-" + TempExamIllnessCaseID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamIllnessCaseID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamIllnessCase)objModel;
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
        public List<Model.TempExamIllnessCase> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamIllnessCase> DataTableToList(DataTable dt)
        {
            List<Model.TempExamIllnessCase> modelList = new List<Model.TempExamIllnessCase>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamIllnessCase model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamIllnessCase();
                    if (dt.Rows[n]["TempExamIllnessCaseID"].ToString() != "")
                    {
                        model.TempExamIllnessCaseID = int.Parse(dt.Rows[n]["TempExamIllnessCaseID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIllnessCaseNumber2"].ToString() != "")
                    {
                        model.TempExamIllnessCaseNumber2 = int.Parse(dt.Rows[n]["TempExamIllnessCaseNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIllnessCaseNumber3"].ToString() != "")
                    {
                        model.TempExamIllnessCaseNumber3 = decimal.Parse(dt.Rows[n]["TempExamIllnessCaseNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIllnessCaseNumber4"].ToString() != "")
                    {
                        model.TempExamIllnessCaseNumber4 = decimal.Parse(dt.Rows[n]["TempExamIllnessCaseNumber4"].ToString());
                    }
                    model.TempExamIllnessCaseString1 = dt.Rows[n]["TempExamIllnessCaseString1"].ToString();
                    model.TempExamIllnessCaseString2 = dt.Rows[n]["TempExamIllnessCaseString2"].ToString();
                    model.TempExamIllnessCaseString3 = dt.Rows[n]["TempExamIllnessCaseString3"].ToString();
                    model.TempExamIllnessCaseString4 = dt.Rows[n]["TempExamIllnessCaseString4"].ToString();
                    if (dt.Rows[n]["TempExamIllnessCaseDatetime1"].ToString() != "")
                    {
                        model.TempExamIllnessCaseDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamIllnessCaseDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIllnessCaseDatetime2"].ToString() != "")
                    {
                        model.TempExamIllnessCaseDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamIllnessCaseDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationID"].ToString() != "")
                    {
                        model.TempExamStationID = Guid.Parse(dt.Rows[n]["TempExamStationID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomID"].ToString() != "")
                    {
                        model.TempExamStationRoomID = Guid.Parse(dt.Rows[n]["TempExamStationRoomID"].ToString());
                    }
                    if (dt.Rows[n]["RoomID"].ToString() != "")
                    {
                        model.RoomID = int.Parse(dt.Rows[n]["RoomID"].ToString());
                    }
                    if (dt.Rows[n]["IllnessCaseID"].ToString() != "")
                    {
                        model.IllnessCaseID = int.Parse(dt.Rows[n]["IllnessCaseID"].ToString());
                    }
                    if (dt.Rows[n]["IllnessCaseScriptID"].ToString() != "")
                    {
                        model.IllnessCaseScriptID = int.Parse(dt.Rows[n]["IllnessCaseScriptID"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetID"].ToString() != "")
                    {
                        model.MarkSheetID = int.Parse(dt.Rows[n]["MarkSheetID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIllnessCaseNumber1"].ToString() != "")
                    {
                        model.TempExamIllnessCaseNumber1 = int.Parse(dt.Rows[n]["TempExamIllnessCaseNumber1"].ToString());
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
        /// 添加TempExamIllnessCase记录
        /// </summary>
        /// <param name="tempExamIllnessCase"></param>
        /// <returns></returns>
        public bool AddTempExamIllnessCase(Model.TempExamIllnessCase tempExamIllnessCase)
        {
            return new DAL.TempExamIllnessCase().Insert(tempExamIllnessCase);
        }

        /// <summary>
        /// 删除TempExamIllnessCase记录
        /// </summary>
        /// <param name="tempExamIllnessCase"></param>
        /// <returns></returns>
        public bool RemoveTempExamIllnessCase(Model.TempExamIllnessCase tempExamIllnessCase)
        {
            return new DAL.TempExamIllnessCase().Delete(tempExamIllnessCase);
        }

        /// <summary>
        /// 修改TempExamIllnessCase记录
        /// </summary>
        /// <param name="tempExamIllnessCase"></param>
        /// <returns></returns>
        public bool ModifyTempExamIllnessCase(Model.TempExamIllnessCase tempExamIllnessCase)
        {
            return new DAL.TempExamIllnessCase().Update((object)tempExamIllnessCase);
        }

        /// <summary>
        /// 查询TempExamIllnessCase下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamIllnessCaseIdentity()
        {
            return new DAL.TempExamIllnessCase().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamIllnessCase记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamIllnessCaseCount()
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamIllnessCase记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamIllnessCaseCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamIllnessCaseID的TempExamIllnessCase是否存在
        /// </summary>
        /// <param name="tempExamIllnessCaseID"></param>
        /// <returns></returns>
        public bool? SearchTempExamIllnessCaseExists(object tempExamIllnessCaseID)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectExistsByID(tempExamIllnessCaseID);
        }

        /// <summary>
        /// 查询指定条件的TempExamIllnessCase是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamIllnessCaseExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamIllnessCaseID查询TempExamIllnessCase
        /// </summary>
        /// <param name="tempExamIllnessCaseID"></param>
        /// <returns></returns>
        public Model.TempExamIllnessCase SearchTempExamIllnessCaseByID(object tempExamIllnessCaseID)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectByID(tempExamIllnessCaseID);
        }

        /// <summary>
        /// 查询第一个TempExamIllnessCase对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamIllnessCase SearchUniqueTempExamIllnessCaseByCondition()
        {
            return new DAL.TempExamIllnessCase().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamIllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamIllnessCase SearchUniqueTempExamIllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamIllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamIllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamIllnessCase SearchUniqueTempExamIllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamIllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamIllnessCase对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamIllnessCase> SearchTempExamIllnessCaseByCondition()
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamIllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamIllnessCase> SearchTempExamIllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamIllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamIllnessCase> SearchTempExamIllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamIllnessCase内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamIllnessCase> SearchTempExamIllnessCaseByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamIllnessCase().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
