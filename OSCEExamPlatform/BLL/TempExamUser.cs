using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Model;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class TempExamUser
    {
        private readonly DAL.TempExamUser dal = new DAL.TempExamUser();
        public TempExamUser()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid TempExamUserID)
        {
            return dal.Exists(TempExamUserID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamUser model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamUser model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid TempExamUserID)
        {

            return dal.Delete(TempExamUserID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamUser GetModel(Guid TempExamUserID)
        {

            return dal.GetModel(TempExamUserID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamUser GetModelByCache(Guid TempExamUserID)
        {

            string CacheKey = "TempExamUserModel-" + TempExamUserID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamUserID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamUser)objModel;
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
        public List<Model.TempExamUser> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamUser> DataTableToList(DataTable dt)
        {
            List<Model.TempExamUser> modelList = new List<Model.TempExamUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamUser();
                    if (dt.Rows[n]["TempExamUserID"].ToString() != "")
                    {
                        model.TempExamUserID = Guid.Parse(dt.Rows[n]["TempExamUserID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserNumber1"].ToString() != "")
                    {
                        model.TempExamUserNumber1 = int.Parse(dt.Rows[n]["TempExamUserNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserNumber2"].ToString() != "")
                    {
                        model.TempExamUserNumber2 = int.Parse(dt.Rows[n]["TempExamUserNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserNumber3"].ToString() != "")
                    {
                        model.TempExamUserNumber3 = decimal.Parse(dt.Rows[n]["TempExamUserNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserNumber4"].ToString() != "")
                    {
                        model.TempExamUserNumber4 = decimal.Parse(dt.Rows[n]["TempExamUserNumber4"].ToString());
                    }
                    model.TempExamUserString1 = dt.Rows[n]["TempExamUserString1"].ToString();
                    model.TempExamUserString2 = dt.Rows[n]["TempExamUserString2"].ToString();
                    model.TempExamUserString3 = dt.Rows[n]["TempExamUserString3"].ToString();
                    model.TempExamUserString4 = dt.Rows[n]["TempExamUserString4"].ToString();
                    if (dt.Rows[n]["TempExamUserDatetime1"].ToString() != "")
                    {
                        model.TempExamUserDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamUserDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamUserDatetime2"].ToString() != "")
                    {
                        model.TempExamUserDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamUserDatetime2"].ToString());
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
                    if (dt.Rows[n]["UserInfoID"].ToString() != "")
                    {
                        model.UserInfoID = int.Parse(dt.Rows[n]["UserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["UserType"].ToString() != "")
                    {
                        model.UserType = int.Parse(dt.Rows[n]["UserType"].ToString());
                    }
                    if (dt.Rows[n]["UserScorePercent"].ToString() != "")
                    {
                        model.UserScorePercent = int.Parse( (decimal.Parse(dt.Rows[n]["UserScorePercent"].ToString()).ToString()));
                    }
                    if (dt.Rows[n]["UserMarkSheetCount"].ToString() != "")
                    {
                        model.UserMarkSheetCount = int.Parse(dt.Rows[n]["UserMarkSheetCount"].ToString());
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
        /// 添加TempExamUser记录
        /// </summary>
        /// <param name="tempExamUser"></param>
        /// <returns></returns>
        public bool AddTempExamUser(Model.TempExamUser tempExamUser)
        {
            return new DAL.TempExamUser().Insert(tempExamUser);
        }

        /// <summary>
        /// 删除TempExamUser记录
        /// </summary>
        /// <param name="tempExamUser"></param>
        /// <returns></returns>
        public bool RemoveTempExamUser(Model.TempExamUser tempExamUser)
        {
            return new DAL.TempExamUser().Delete(tempExamUser);
        }

        /// <summary>
        /// 修改TempExamUser记录
        /// </summary>
        /// <param name="tempExamUser"></param>
        /// <returns></returns>
        public bool ModifyTempExamUser(Model.TempExamUser tempExamUser)
        {
            return new DAL.TempExamUser().Update((object)tempExamUser);
        }

        /// <summary>
        /// 查询TempExamUser下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamUserIdentity()
        {
            return new DAL.TempExamUser().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamUser记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamUserCount()
        {
            return new DAL.TempExamUser().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamUser记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamUserCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUser().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamUserID的TempExamUser是否存在
        /// </summary>
        /// <param name="tempExamUserID"></param>
        /// <returns></returns>
        public bool? SearchTempExamUserExists(object tempExamUserID)
        {
            return new DAL.TempExamUser().SelectModelObjectExistsByID(tempExamUserID);
        }

        /// <summary>
        /// 查询指定条件的TempExamUser是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamUserExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUser().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamUserID查询TempExamUser
        /// </summary>
        /// <param name="tempExamUserID"></param>
        /// <returns></returns>
        public Model.TempExamUser SearchTempExamUserByID(object tempExamUserID)
        {
            return new DAL.TempExamUser().SelectModelObjectByID(tempExamUserID);
        }

        /// <summary>
        /// 查询第一个TempExamUser对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamUser SearchUniqueTempExamUserByCondition()
        {
            return new DAL.TempExamUser().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamUser SearchUniqueTempExamUserByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUser().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamUser SearchUniqueTempExamUserByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamUser().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamUser对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamUser> SearchTempExamUserByCondition()
        {
            return new DAL.TempExamUser().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamUser> SearchTempExamUserByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamUser().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamUser> SearchTempExamUserByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamUser().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamUser内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamUser> SearchTempExamUserByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamUser().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchTempExamUserAndUserInfoByTempExamTableID(Guid tempExamTableID)
        {
            List<object[]> tempExamUserList = new DAL.TempExamUser().SelectTempExamUserAndUserInfoByTempExamTableID(tempExamTableID);
            if (tempExamUserList == null)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败：" + tempExamTableID);
                return null;
            }
            List<Dictionary<string, object>> tempExamUserDictionaryList = new List<Dictionary<string, object>>();
            foreach (object[] items in tempExamUserList)
            {
                tempExamUserDictionaryList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"TempExamUser", items[0]},
                        {"U_TrueName", items[1]},
                        {"U_Title", items[2]},
                        {"U_GoodField", items[3]}
                    }
                );
            }
            return tempExamUserDictionaryList;
        }

        /// <summary>
        /// 获得单站排考，首界面上要显示的已存在TempExamUser数据
        /// </summary>
        /// <param name="TempExamTableID"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public List<Tellyes.Model.TempExamUser_SingleExamMainPage> GetExistedExamUserInfoForSingleExamMainPage(string TempExamTableID, ExamUserType userType)
        {
            return dal.GetExistedExamUserInfoForSingleExamMainPage(TempExamTableID, userType);
        }

        #endregion
    }
}
