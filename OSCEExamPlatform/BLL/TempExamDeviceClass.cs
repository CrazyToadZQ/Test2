using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamDeviceClass
    {
        private readonly DAL.TempExamDeviceClass dal = new DAL.TempExamDeviceClass();
        public TempExamDeviceClass()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TempExamDeviceClassID)
        {
            return dal.Exists(TempExamDeviceClassID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamDeviceClass model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamDeviceClass model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TempExamDeviceClassID)
        {

            return dal.Delete(TempExamDeviceClassID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string TempExamDeviceClassIDlist)
        {
            return dal.DeleteList(TempExamDeviceClassIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamDeviceClass GetModel(int TempExamDeviceClassID)
        {

            return dal.GetModel(TempExamDeviceClassID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamDeviceClass GetModelByCache(int TempExamDeviceClassID)
        {

            string CacheKey = "TempExamDeviceClassModel-" + TempExamDeviceClassID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamDeviceClassID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamDeviceClass)objModel;
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
        public List<Model.TempExamDeviceClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamDeviceClass> DataTableToList(DataTable dt)
        {
            List<Model.TempExamDeviceClass> modelList = new List<Model.TempExamDeviceClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamDeviceClass model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamDeviceClass();
                    if (dt.Rows[n]["TempExamDeviceClassID"].ToString() != "")
                    {
                        model.TempExamDeviceClassID = int.Parse(dt.Rows[n]["TempExamDeviceClassID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDeviceClassNumber2"].ToString() != "")
                    {
                        model.TempExamDeviceClassNumber2 = int.Parse(dt.Rows[n]["TempExamDeviceClassNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDeviceClassNumber3"].ToString() != "")
                    {
                        model.TempExamDeviceClassNumber3 = decimal.Parse(dt.Rows[n]["TempExamDeviceClassNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDeviceClassNumber4"].ToString() != "")
                    {
                        model.TempExamDeviceClassNumber4 = decimal.Parse(dt.Rows[n]["TempExamDeviceClassNumber4"].ToString());
                    }
                    model.TempExamDeviceClassString1 = dt.Rows[n]["TempExamDeviceClassString1"].ToString();
                    model.TempExamDeviceClassString2 = dt.Rows[n]["TempExamDeviceClassString2"].ToString();
                    model.TempExamDeviceClassString3 = dt.Rows[n]["TempExamDeviceClassString3"].ToString();
                    model.TempExamDeviceClassString4 = dt.Rows[n]["TempExamDeviceClassString4"].ToString();
                    if (dt.Rows[n]["TempExamDeviceClassDatetime1"].ToString() != "")
                    {
                        model.TempExamDeviceClassDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamDeviceClassDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDeviceClassDatetime2"].ToString() != "")
                    {
                        model.TempExamDeviceClassDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamDeviceClassDatetime2"].ToString());
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
                    if (dt.Rows[n]["DeviceClassID"].ToString() != "")
                    {
                        model.DeviceClassID = int.Parse(dt.Rows[n]["DeviceClassID"].ToString());
                    }
                    if (dt.Rows[n]["DeviceCount"].ToString() != "")
                    {
                        model.DeviceCount = int.Parse(dt.Rows[n]["DeviceCount"].ToString());
                    }
                    if (dt.Rows[n]["ObjectiveMarkSheetID"].ToString() != "")
                    {
                        model.ObjectiveMarkSheetID = int.Parse(dt.Rows[n]["ObjectiveMarkSheetID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDeviceClassNumber1"].ToString() != "")
                    {
                        model.TempExamDeviceClassNumber1 = int.Parse(dt.Rows[n]["TempExamDeviceClassNumber1"].ToString());
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
        /// 添加TempExamDeviceClass记录
        /// </summary>
        /// <param name="tempExamDeviceClass"></param>
        /// <returns></returns>
        public bool AddTempExamDeviceClass(Model.TempExamDeviceClass tempExamDeviceClass)
        {
            return new DAL.TempExamDeviceClass().Insert(tempExamDeviceClass);
        }

        /// <summary>
        /// 删除TempExamDeviceClass记录
        /// </summary>
        /// <param name="tempExamDeviceClass"></param>
        /// <returns></returns>
        public bool RemoveTempExamDeviceClass(Model.TempExamDeviceClass tempExamDeviceClass)
        {
            return new DAL.TempExamDeviceClass().Delete(tempExamDeviceClass);
        }

        /// <summary>
        /// 修改TempExamDeviceClass记录
        /// </summary>
        /// <param name="tempExamDeviceClass"></param>
        /// <returns></returns>
        public bool ModifyTempExamDeviceClass(Model.TempExamDeviceClass tempExamDeviceClass)
        {
            return new DAL.TempExamDeviceClass().Update((object)tempExamDeviceClass);
        }

        /// <summary>
        /// 查询TempExamDeviceClass下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamDeviceClassIdentity()
        {
            return new DAL.TempExamDeviceClass().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamDeviceClass记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamDeviceClassCount()
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamDeviceClass记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamDeviceClassCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamDeviceClassID的TempExamDeviceClass是否存在
        /// </summary>
        /// <param name="tempExamDeviceClassID"></param>
        /// <returns></returns>
        public bool? SearchTempExamDeviceClassExists(object tempExamDeviceClassID)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectExistsByID(tempExamDeviceClassID);
        }

        /// <summary>
        /// 查询指定条件的TempExamDeviceClass是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamDeviceClassExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamDeviceClassID查询TempExamDeviceClass
        /// </summary>
        /// <param name="tempExamDeviceClassID"></param>
        /// <returns></returns>
        public Model.TempExamDeviceClass SearchTempExamDeviceClassByID(object tempExamDeviceClassID)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectByID(tempExamDeviceClassID);
        }

        /// <summary>
        /// 查询第一个TempExamDeviceClass对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamDeviceClass SearchUniqueTempExamDeviceClassByCondition()
        {
            return new DAL.TempExamDeviceClass().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamDeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamDeviceClass SearchUniqueTempExamDeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamDeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamDeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamDeviceClass SearchUniqueTempExamDeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamDeviceClass().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamDeviceClass对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamDeviceClass> SearchTempExamDeviceClassByCondition()
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamDeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamDeviceClass> SearchTempExamDeviceClassByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamDeviceClass对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamDeviceClass> SearchTempExamDeviceClassByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamDeviceClass内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamDeviceClass> SearchTempExamDeviceClassByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamDeviceClass().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
