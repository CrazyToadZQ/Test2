using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Model;
using System.Collections;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class TempExamStationRoom
    {
        private readonly DAL.TempExamStationRoom dal = new DAL.TempExamStationRoom();
        public TempExamStationRoom()
        { }

        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid TempExamStationRoomID)
        {
            return dal.Exists(TempExamStationRoomID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStationRoom model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStationRoom model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid TempExamStationRoomID)
        {

            return dal.Delete(TempExamStationRoomID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamStationRoom GetModel(Guid TempExamStationRoomID)
        {

            return dal.GetModel(TempExamStationRoomID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamStationRoom GetModelByCache(Guid TempExamStationRoomID)
        {

            string CacheKey = "TempExamStationRoomModel-" + TempExamStationRoomID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamStationRoomID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamStationRoom)objModel;
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
        public List<Model.TempExamStationRoom> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamStationRoom> DataTableToList(DataTable dt)
        {
            List<Model.TempExamStationRoom> modelList = new List<Model.TempExamStationRoom>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamStationRoom model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamStationRoom();
                    if (dt.Rows[n]["TempExamStationRoomID"].ToString() != "")
                    {
                        model.TempExamStationRoomID = Guid.Parse( dt.Rows[n]["TempExamStationRoomID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber5"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber5 = long.Parse(dt.Rows[n]["TempExamStationRoomNumber5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber6"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber6 = decimal.Parse(dt.Rows[n]["TempExamStationRoomNumber6"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber7"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber7 = decimal.Parse(dt.Rows[n]["TempExamStationRoomNumber7"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber8"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber8 = decimal.Parse(dt.Rows[n]["TempExamStationRoomNumber8"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber9"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber9 = decimal.Parse(dt.Rows[n]["TempExamStationRoomNumber9"].ToString());
                    }
                    model.TempExamStationRoomString1 = dt.Rows[n]["TempExamStationRoomString1"].ToString();
                    model.TempExamStationRoomString2 = dt.Rows[n]["TempExamStationRoomString2"].ToString();
                    model.TempExamStationRoomString3 = dt.Rows[n]["TempExamStationRoomString3"].ToString();
                    model.TempExamStationRoomString4 = dt.Rows[n]["TempExamStationRoomString4"].ToString();
                    model.TempExamStationRoomString5 = dt.Rows[n]["TempExamStationRoomString5"].ToString();
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse( dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    model.TempExamStationRoomString6 = dt.Rows[n]["TempExamStationRoomString6"].ToString();
                    model.TempExamStationRoomString7 = dt.Rows[n]["TempExamStationRoomString7"].ToString();
                    model.TempExamStationRoomString8 = dt.Rows[n]["TempExamStationRoomString8"].ToString();
                    model.TempExamStationRoomString9 = dt.Rows[n]["TempExamStationRoomString9"].ToString();
                    if (dt.Rows[n]["TempExamStationRoomDatetime1"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomDatetime2"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomDatetime3"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime3 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomDatetime4"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime4 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime4"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomDatetime5"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime5 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomDatetime6"].ToString() != "")
                    {
                        model.TempExamStationRoomDatetime6 = DateTime.Parse(dt.Rows[n]["TempExamStationRoomDatetime6"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationID"].ToString() != "")
                    {
                        model.TempExamStationID = Guid.Parse( dt.Rows[n]["TempExamStationID"].ToString());
                    }
                    if (dt.Rows[n]["RoomID"].ToString() != "")
                    {
                        model.RoomID = int.Parse(dt.Rows[n]["RoomID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomIsComplete"].ToString() != "")
                    {
                        model.TempExamStationRoomIsComplete = int.Parse(dt.Rows[n]["TempExamStationRoomIsComplete"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber1"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber1 = int.Parse(dt.Rows[n]["TempExamStationRoomNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber2"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber2 = int.Parse(dt.Rows[n]["TempExamStationRoomNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber3"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber3 = int.Parse(dt.Rows[n]["TempExamStationRoomNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationRoomNumber4"].ToString() != "")
                    {
                        model.TempExamStationRoomNumber4 = long.Parse(dt.Rows[n]["TempExamStationRoomNumber4"].ToString());
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
        /// 添加TempExamStationRoom记录
        /// </summary>
        /// <param name="tempExamStationRoom"></param>
        /// <returns></returns>
        public bool AddTempExamStationRoom(Model.TempExamStationRoom tempExamStationRoom)
        {
            return new DAL.TempExamStationRoom().Insert(tempExamStationRoom);
        }

        /// <summary>
        /// 删除TempExamStationRoom记录
        /// </summary>
        /// <param name="tempExamStationRoom"></param>
        /// <returns></returns>
        public bool RemoveTempExamStationRoom(Model.TempExamStationRoom tempExamStationRoom)
        {
            return new DAL.TempExamStationRoom().Delete(tempExamStationRoom);
        }

        /// <summary>
        /// 修改TempExamStationRoom记录
        /// </summary>
        /// <param name="tempExamStationRoom"></param>
        /// <returns></returns>
        public bool ModifyTempExamStationRoom(Model.TempExamStationRoom tempExamStationRoom)
        {
            return new DAL.TempExamStationRoom().Update((object)tempExamStationRoom);
        }

        /// <summary>
        /// 查询TempExamStationRoom下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStationRoomIdentity()
        {
            return new DAL.TempExamStationRoom().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamStationRoom记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStationRoomCount()
        {
            return new DAL.TempExamStationRoom().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStationRoom记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamStationRoomCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamStationRoomID的TempExamStationRoom是否存在
        /// </summary>
        /// <param name="tempExamStationRoomID"></param>
        /// <returns></returns>
        public bool? SearchTempExamStationRoomExists(object tempExamStationRoomID)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectExistsByID(tempExamStationRoomID);
        }

        /// <summary>
        /// 查询指定条件的TempExamStationRoom是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamStationRoomExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamStationRoomID查询TempExamStationRoom
        /// </summary>
        /// <param name="tempExamStationRoomID"></param>
        /// <returns></returns>
        public Model.TempExamStationRoom SearchTempExamStationRoomByID(object tempExamStationRoomID)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectByID(tempExamStationRoomID);
        }

        /// <summary>
        /// 查询第一个TempExamStationRoom对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamStationRoom SearchUniqueTempExamStationRoomByCondition()
        {
            return new DAL.TempExamStationRoom().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamStationRoom对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamStationRoom SearchUniqueTempExamStationRoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStationRoom().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamStationRoom对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamStationRoom SearchUniqueTempExamStationRoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStationRoom().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamStationRoom对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamStationRoom> SearchTempExamStationRoomByCondition()
        {
            return new DAL.TempExamStationRoom().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStationRoom对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamStationRoom> SearchTempExamStationRoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamStationRoom对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamStationRoom> SearchTempExamStationRoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamStationRoom内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamStationRoom> SearchTempExamStationRoomByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamStationRoom().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion

        /// <summary>
        /// 获得房间评委，SP级联信息
        /// </summary>
        /// <param name="TempExamTableID"></param>
        public static Hashtable GetTempExamRoomAndUserInfoForSingleExam(Guid TempExamTableID)
        {
            return Tellyes.DAL.TempExamStationRoom.GetTempExamRoomAndUserInfoForSingleExam(TempExamTableID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchTempExamStationRoomAndRoomByTempExamTableID(Guid tempExamTableID)
        {
            List<object[]> tempExamStationRoomList
                = new DAL.TempExamStationRoom().SelectTempExamStationRoomAndRoomByTempExamTableID(tempExamTableID);
            if (tempExamStationRoomList == null)
            {
                Log4NetUtility.Error(this, "BLL查询单站式考站房间信息失败：" + tempExamTableID);
                return null;
            }
            List<Dictionary<string, object>> tempExamStationRoomDictionaryList = new List<Dictionary<string, object>>();
            foreach (object[] items in tempExamStationRoomList)
            {
                tempExamStationRoomDictionaryList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"TempExamStationRoom", items[0]},
                        {"Room_Name", items[1]}
                    }
                );
            }
            return tempExamStationRoomDictionaryList;
        }

        #endregion
    }
}
