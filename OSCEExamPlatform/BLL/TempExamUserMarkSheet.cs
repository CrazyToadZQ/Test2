using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamUserMarkSheet
    {
        private readonly DAL.TempExamUserMarkSheet dal = new DAL.TempExamUserMarkSheet();
        public TempExamUserMarkSheet()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TempExamUserMarkSheetID)
        {
            return dal.Exists(TempExamUserMarkSheetID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TempExamUserMarkSheet model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamUserMarkSheet model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TempExamUserMarkSheetID)
        {

            return dal.Delete(TempExamUserMarkSheetID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string TempExamUserMarkSheetIDlist)
        {
            return dal.DeleteList(TempExamUserMarkSheetIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamUserMarkSheet GetModel(int TempExamUserMarkSheetID)
        {

            return dal.GetModel(TempExamUserMarkSheetID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamUserMarkSheet GetModelByCache(int TempExamUserMarkSheetID)
        {

            string CacheKey = "TempExamUserMarkSheetModel-" + TempExamUserMarkSheetID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamUserMarkSheetID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamUserMarkSheet)objModel;
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
        public List<Model.TempExamUserMarkSheet> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamUserMarkSheet> DataTableToList(DataTable dt)
        {
            List<Model.TempExamUserMarkSheet> modelList = new List<Model.TempExamUserMarkSheet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamUserMarkSheet model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamUserMarkSheet();
                    if (dt.Rows[n]["TempExamUserMarkSheetID"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetID = int.Parse(dt.Rows[n]["TempExamUserMarkSheetID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserMarkSheetNumber2"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetNumber2 = int.Parse(dt.Rows[n]["TempExamUserMarkSheetNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserMarkSheetNumber3"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetNumber3 = decimal.Parse(dt.Rows[n]["TempExamUserMarkSheetNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserMarkSheetNumber4"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetNumber4 = decimal.Parse(dt.Rows[n]["TempExamUserMarkSheetNumber4"].ToString());
                    }
                    model.TempExamUserMarkSheetString1 = dt.Rows[n]["TempExamUserMarkSheetString1"].ToString();
                    model.TempExamUserMarkSheetString2 = dt.Rows[n]["TempExamUserMarkSheetString2"].ToString();
                    model.TempExamUserMarkSheetString3 = dt.Rows[n]["TempExamUserMarkSheetString3"].ToString();
                    model.TempExamUserMarkSheetString4 = dt.Rows[n]["TempExamUserMarkSheetString4"].ToString();
                    if (dt.Rows[n]["TempExamUserMarkSheetDatetime1"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamUserMarkSheetDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserMarkSheetDatetime2"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamUserMarkSheetDatetime2"].ToString());
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
                    if (dt.Rows[n]["TempExamUserID"].ToString() != "")
                    {
                        model.TempExamUserID = Guid.Parse(dt.Rows[n]["TempExamUserID"].ToString());
                    }
                    if (dt.Rows[n]["RoomID"].ToString() != "")
                    {
                        model.RoomID = int.Parse(dt.Rows[n]["RoomID"].ToString());
                    }
                    if (dt.Rows[n]["UserInfoID"].ToString() != "")
                    {
                        model.UserInfoID = int.Parse(dt.Rows[n]["UserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetID"].ToString() != "")
                    {
                        model.MarkSheetID = int.Parse(dt.Rows[n]["MarkSheetID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserMarkSheetNumber1"].ToString() != "")
                    {
                        model.TempExamUserMarkSheetNumber1 = int.Parse(dt.Rows[n]["TempExamUserMarkSheetNumber1"].ToString());
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
        /// 添加TempExamUserMarkSheet记录
        /// </summary>
        /// <param name="tempExamUserMarkSheet"></param>
        /// <returns></returns>
        public bool AddTempExamUserMarkSheet(Model.TempExamUserMarkSheet tempExamUserMarkSheet)
        {
            return new DAL.TempExamUserMarkSheet().Insert(tempExamUserMarkSheet);
        }

        /// <summary>
        /// 删除TempExamUserMarkSheet记录
        /// </summary>
        /// <param name="tempExamUserMarkSheet"></param>
        /// <returns></returns>
        public bool RemoveTempExamUserMarkSheet(Model.TempExamUserMarkSheet tempExamUserMarkSheet)
        {
            return new DAL.TempExamUserMarkSheet().Delete(tempExamUserMarkSheet);
        }

        /// <summary>
        /// 修改TempExamUserMarkSheet记录
        /// </summary>
        /// <param name="tempExamUserMarkSheet"></param>
        /// <returns></returns>
        public bool ModifyTempExamUserMarkSheet(Model.TempExamUserMarkSheet tempExamUserMarkSheet)
        {
            return new DAL.TempExamUserMarkSheet().Update((object)tempExamUserMarkSheet);
        }

        /// <summary>
        /// 查询TempExamUserMarkSheet下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamUserMarkSheetIdentity()
        {
            return new DAL.TempExamUserMarkSheet().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamUserMarkSheet记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamUserMarkSheetCount()
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamUserMarkSheet记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamUserMarkSheetCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamUserMarkSheetID的TempExamUserMarkSheet是否存在
        /// </summary>
        /// <param name="tempExamUserMarkSheetID"></param>
        /// <returns></returns>
        public bool? SearchTempExamUserMarkSheetExists(object tempExamUserMarkSheetID)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectExistsByID(tempExamUserMarkSheetID);
        }

        /// <summary>
        /// 查询指定条件的TempExamUserMarkSheet是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamUserMarkSheetExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamUserMarkSheetID查询TempExamUserMarkSheet
        /// </summary>
        /// <param name="tempExamUserMarkSheetID"></param>
        /// <returns></returns>
        public Model.TempExamUserMarkSheet SearchTempExamUserMarkSheetByID(object tempExamUserMarkSheetID)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectByID(tempExamUserMarkSheetID);
        }

        /// <summary>
        /// 查询第一个TempExamUserMarkSheet对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamUserMarkSheet SearchUniqueTempExamUserMarkSheetByCondition()
        {
            return new DAL.TempExamUserMarkSheet().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamUserMarkSheet SearchUniqueTempExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUserMarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamUserMarkSheet SearchUniqueTempExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamUserMarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamUserMarkSheet对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamUserMarkSheet> SearchTempExamUserMarkSheetByCondition()
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamUserMarkSheet> SearchTempExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamUserMarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamUserMarkSheet> SearchTempExamUserMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamUserMarkSheet内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamUserMarkSheet> SearchTempExamUserMarkSheetByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamUserMarkSheet().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
