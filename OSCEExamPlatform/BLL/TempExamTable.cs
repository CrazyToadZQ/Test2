using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class TempExamTable
    {
        private readonly DAL.TempExamTable dal = new DAL.TempExamTable();
        public TempExamTable()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid TempExamTableID)
        {
            return dal.Exists(TempExamTableID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamTable model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamTable model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid TempExamTableID)
        {

            return dal.Delete(TempExamTableID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamTable GetModel(Guid TempExamTableID)
        {

            return dal.GetModel(TempExamTableID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamTable GetModelByCache(Guid TempExamTableID)
        {

            string CacheKey = "TempExamTableModel-" + TempExamTableID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamTableID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamTable)objModel;
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
        public List<Model.TempExamTable> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamTable> DataTableToList(DataTable dt)
        {
            List<Model.TempExamTable> modelList = new List<Model.TempExamTable>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamTable model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamTable();
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLongExamMinute"].ToString() != "")
                    {
                        model.TempExamLongExamMinute = int.Parse(dt.Rows[n]["TempExamLongExamMinute"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLongScoreMinute"].ToString() != "")
                    {
                        model.TempExamLongScoreMinute = int.Parse(dt.Rows[n]["TempExamLongScoreMinute"].ToString());
                    }
                    if (dt.Rows[n]["TempExamShortExamMinute"].ToString() != "")
                    {
                        model.TempExamShortExamMinute = int.Parse(dt.Rows[n]["TempExamShortExamMinute"].ToString());
                    }
                    if (dt.Rows[n]["TempExamShortScoreMinute"].ToString() != "")
                    {
                        model.TempExamShortScoreMinute = int.Parse(dt.Rows[n]["TempExamShortScoreMinute"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIsOpenScore"].ToString() != "")
                    {
                        model.TempExamIsOpenScore = int.Parse(dt.Rows[n]["TempExamIsOpenScore"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIsOpenVideo"].ToString() != "")
                    {
                        model.TempExamIsOpenVideo = int.Parse(dt.Rows[n]["TempExamIsOpenVideo"].ToString());
                    }
                    if (dt.Rows[n]["TempExamIsComplete"].ToString() != "")
                    {
                        model.TempExamIsComplete = int.Parse(dt.Rows[n]["TempExamIsComplete"].ToString());
                    }
                    if (dt.Rows[n]["TempExamState"].ToString() != "")
                    {
                        model.TempExamState = int.Parse(dt.Rows[n]["TempExamState"].ToString());
                    }
                    if (dt.Rows[n]["TempExamCreateTime"].ToString() != "")
                    {
                        model.TempExamCreateTime = DateTime.Parse(dt.Rows[n]["TempExamCreateTime"].ToString());
                    }
                    if (dt.Rows[n]["TempExamLastModifyTime"].ToString() != "")
                    {
                        model.TempExamLastModifyTime = DateTime.Parse(dt.Rows[n]["TempExamLastModifyTime"].ToString());
                    }
                    model.TempExamName = dt.Rows[n]["TempExamName"].ToString();
                    if (dt.Rows[n]["TempExamUserInfoID"].ToString() != "")
                    {
                        model.TempExamUserInfoID = int.Parse(dt.Rows[n]["TempExamUserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber1"].ToString() != "")
                    {
                        model.TempExamNumber1 = int.Parse(dt.Rows[n]["TempExamNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber2"].ToString() != "")
                    {
                        model.TempExamNumber2 = int.Parse(dt.Rows[n]["TempExamNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber3"].ToString() != "")
                    {
                        model.TempExamNumber3 = int.Parse(dt.Rows[n]["TempExamNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber4"].ToString() != "")
                    {
                        model.TempExamNumber4 = long.Parse(dt.Rows[n]["TempExamNumber4"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber5"].ToString() != "")
                    {
                        model.TempExamNumber5 = long.Parse(dt.Rows[n]["TempExamNumber5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber6"].ToString() != "")
                    {
                        model.TempExamNumber6 = decimal.Parse(dt.Rows[n]["TempExamNumber6"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber7"].ToString() != "")
                    {
                        model.TempExamNumber7 = decimal.Parse(dt.Rows[n]["TempExamNumber7"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber8"].ToString() != "")
                    {
                        model.TempExamNumber8 = decimal.Parse(dt.Rows[n]["TempExamNumber8"].ToString());
                    }
                    if (dt.Rows[n]["TempExamNumber9"].ToString() != "")
                    {
                        model.TempExamNumber9 = decimal.Parse(dt.Rows[n]["TempExamNumber9"].ToString());
                    }
                    if (dt.Rows[n]["TempExamKind"].ToString() != "")
                    {
                        model.TempExamKind = int.Parse(dt.Rows[n]["TempExamKind"].ToString());
                    }
                    model.TempExamString1 = dt.Rows[n]["TempExamString1"].ToString();
                    model.TempExamString2 = dt.Rows[n]["TempExamString2"].ToString();
                    model.TempExamString3 = dt.Rows[n]["TempExamString3"].ToString();
                    model.TempExamString4 = dt.Rows[n]["TempExamString4"].ToString();
                    model.TempExamString5 = dt.Rows[n]["TempExamString5"].ToString();
                    model.TempExamString6 = dt.Rows[n]["TempExamString6"].ToString();
                    model.TempExamString7 = dt.Rows[n]["TempExamString7"].ToString();
                    model.TempExamString8 = dt.Rows[n]["TempExamString8"].ToString();
                    model.TempExamString9 = dt.Rows[n]["TempExamString9"].ToString();
                    if (dt.Rows[n]["TempExamDatetime1"].ToString() != "")
                    {
                        model.TempExamDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["ExamClassID"].ToString() != "")
                    {
                        model.ExamClassID = int.Parse(dt.Rows[n]["ExamClassID"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDatetime2"].ToString() != "")
                    {
                        model.TempExamDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDatetime3"].ToString() != "")
                    {
                        model.TempExamDatetime3 = DateTime.Parse(dt.Rows[n]["TempExamDatetime3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDatetime4"].ToString() != "")
                    {
                        model.TempExamDatetime4 = DateTime.Parse(dt.Rows[n]["TempExamDatetime4"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDatetime5"].ToString() != "")
                    {
                        model.TempExamDatetime5 = DateTime.Parse(dt.Rows[n]["TempExamDatetime5"].ToString());
                    }
                    if (dt.Rows[n]["TempExamDatetime6"].ToString() != "")
                    {
                        model.TempExamDatetime6 = DateTime.Parse(dt.Rows[n]["TempExamDatetime6"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentCount"].ToString() != "")
                    {
                        model.TempExamStudentCount = int.Parse(dt.Rows[n]["TempExamStudentCount"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStationCount"].ToString() != "")
                    {
                        model.TempExamStationCount = int.Parse(dt.Rows[n]["TempExamStationCount"].ToString());
                    }
                    if (dt.Rows[n]["TempExamRoomCount"].ToString() != "")
                    {
                        model.TempExamRoomCount = int.Parse(dt.Rows[n]["TempExamRoomCount"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStartTime"].ToString() != "")
                    {
                        model.TempExamStartTime = DateTime.Parse(dt.Rows[n]["TempExamStartTime"].ToString());
                    }
                    if (dt.Rows[n]["TempExamEndTime"].ToString() != "")
                    {
                        model.TempExamEndTime = DateTime.Parse(dt.Rows[n]["TempExamEndTime"].ToString());
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
        /// 添加TempExamTable记录
        /// </summary>
        /// <param name="tempExamTable"></param>
        /// <returns></returns>
        public bool AddTempExamTable(Model.TempExamTable tempExamTable)
        {
            return new DAL.TempExamTable().Insert(tempExamTable);
        }

        /// <summary>
        /// 删除TempExamTable记录
        /// </summary>
        /// <param name="tempExamTable"></param>
        /// <returns></returns>
        public bool RemoveTempExamTable(Model.TempExamTable tempExamTable)
        {
            return new DAL.TempExamTable().Delete(tempExamTable);
        }

        /// <summary>
        /// 修改TempExamTable记录
        /// </summary>
        /// <param name="tempExamTable"></param>
        /// <returns></returns>
        public bool ModifyTempExamTable(Model.TempExamTable tempExamTable)
        {
            return new DAL.TempExamTable().Update((object)tempExamTable);
        }

        /// <summary>
        /// 查询TempExamTable下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamTableIdentity()
        {
            return new DAL.TempExamTable().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamTable记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamTableCount()
        {
            return new DAL.TempExamTable().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamTable记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamTableCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTable().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamTableID的TempExamTable是否存在
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public bool? SearchTempExamTableExists(object tempExamTableID)
        {
            return new DAL.TempExamTable().SelectModelObjectExistsByID(tempExamTableID);
        }

        /// <summary>
        /// 查询指定条件的TempExamTable是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamTableExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTable().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamTableID查询TempExamTable
        /// </summary>
        /// <param name="tempExamTableID"></param>
        /// <returns></returns>
        public Model.TempExamTable SearchTempExamTableByID(object tempExamTableID)
        {
            return new DAL.TempExamTable().SelectModelObjectByID(tempExamTableID);
        }

        /// <summary>
        /// 查询第一个TempExamTable对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamTable SearchUniqueTempExamTableByCondition()
        {
            return new DAL.TempExamTable().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamTable SearchUniqueTempExamTableByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTable().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamTable SearchUniqueTempExamTableByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamTable().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamTable对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamTable> SearchTempExamTableByCondition()
        {
            return new DAL.TempExamTable().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamTable> SearchTempExamTableByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamTable().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamTable对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamTable> SearchTempExamTableByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamTable().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamTable内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamTable> SearchTempExamTableByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamTable().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extension

        /// <summary>
        /// 单站事务处理 BLL 收口函数
        /// </summary>
        /// <param name="sourceData"></param>
        /// <returns></returns>
        public bool ProcessDBForSingleExam(IEnumerable<KeyValuePair<String,Object>> sourceData) 
        {
            List<List<Object>> DataToParse=new List<List<Object>>();

            foreach (KeyValuePair<String, Object> item in sourceData)
            {
                if (item.Value != null)
                {
                    if (item.Value is IEnumerable<Object>)
                    {
                        List<Object> tempDataContainer = new List<Object>();
                        if (item.Key.Contains("add"))
                        {
                            DataToParse.Add(new List<Object>() { "insert", ((IEnumerable<Object>)item.Value).ToList<Object>() });
                        }
                        if (item.Key.Contains("remove"))
                        {
                            DataToParse.Add(new List<Object>() { "delete", ((IEnumerable<Object>)item.Value).ToList<Object>() });
                        }
                        if (item.Key.Contains("modify"))
                        {
                            DataToParse.Add(new List<Object>() { "update", ((IEnumerable<Object>)item.Value).ToList<Object>() });
                        }
                    }
                    else
                    {
                        if (item.Key.Contains("add"))
                        {
                            DataToParse.Add(new List<Object>() { "insert", item.Value });
                        }
                        if (item.Key.Contains("remove"))
                        {
                            DataToParse.Add(new List<Object>() { "delete", item.Value });
                        }
                        if (item.Key.Contains("modify"))
                        {
                            DataToParse.Add(new List<Object>() { "update", item.Value });
                        }
                    }
                }
            }

            return new DAL.TempExamTable().TransactionMulitySameTable(DataToParse);
        }

        /// <summary>
        /// 根据类型，获得可选数据
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="tempExamTableID">ID</param>
        /// <param name="cachedDataFromFrontPage">前台界面中已选元素</param>
        /// <returns></returns>
        public List<Object> GetPartDataToShowForSingleExam(string type,Guid tempExamTableID,IEnumerable<Object> cachedDataFromFrontPage=null) 
        {
            List<Object> result = null;

            #region 房间信息
            if (type.Equals("roomInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region 评委信息
            if (type.Equals("judgeInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region SP信息
            if (type.Equals("spInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region 督考官信息
            if (type.Equals("verifyInfo", StringComparison.OrdinalIgnoreCase)) 
            {
                string uidListString = String.Join(",", (new Tellyes.BLL.TempExamUser()).GetModelList(" TempExamTableID='" + tempExamTableID.ToString().Trim() + "' and UserType='4' ").Select(e => e.UserInfoID));
                if (uidListString.Trim() == String.Empty) 
                {
                    uidListString = "0";
                }
                List<Tellyes.Model.UserInfo> allJudgesInOneSingleExam = (new Tellyes.BLL.UserInfo()).GetModelList(" U_ID in ( " + uidListString + " ) ");
                if(cachedDataFromFrontPage != null)
                {
                    List<Tellyes.Model.UserInfo> cache = allJudgesInOneSingleExam;
                    allJudgesInOneSingleExam = new List<Model.UserInfo>();
                    foreach (Tellyes.Model.UserInfo tempExamUserItem in cache)
                    {
                        if (!cachedDataFromFrontPage.ToList().Contains(tempExamUserItem.U_ID)) 
                        {
                            allJudgesInOneSingleExam.Add(tempExamUserItem);
                        }
                    }
                }
                result = allJudgesInOneSingleExam.ToList<Object>();
            }
            #endregion

            #region 后备评委信息
            if (type.Equals("repareJudgeInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region 后备SP信息
            if (type.Equals("repareSpInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region 学生信息
            if (type.Equals("studentsInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            #region 时间信息
            if (type.Equals("timeInfo", StringComparison.OrdinalIgnoreCase)) { }
            #endregion

            return result;
        }
        #endregion

        #region 多站式考试

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityDictionary"></param>
        /// <returns></returns>
        public bool DisposeTempExamTableTransaction(Dictionary<string, object> entityDictionary)
        {
            List<List<object>> entityList = new List<List<object>>();

            #region TempExamTable
            if(entityDictionary.ContainsKey("Add,TempExamTable"))
            {
                entityList.Add(new List<object>() { "insert", entityDictionary["Add,TempExamTable"] });
            }
            else if (entityDictionary.ContainsKey("Modify,TempExamTable"))
            {
                entityList.Add(new List<object>() { "update", entityDictionary["Modify,TempExamTable"] });
            }
            #endregion

            #region TempExamUser
            if (entityDictionary.ContainsKey("Add,TempExamUser,ReserveSPList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamUser>)entityDictionary["Add,TempExamUser,ReserveSPList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Remove,TempExamUser,ReserveSP"))
            {
                entityList.Add(new List<object>() { "delete", entityDictionary["Remove,TempExamUser,ReserveSP"] });
            }
            else if (entityDictionary.ContainsKey("Add,TempExamUser,ReserveJudgeList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamUser>)entityDictionary["Add,TempExamUser,ReserveJudgeList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Remove,TempExamUser,ReserveJudge"))
            {
                entityList.Add(new List<object>() { "delete", entityDictionary["Remove,TempExamUser,ReserveJudge"] });
            }
            else if (entityDictionary.ContainsKey("Add,TempExamUser,ExaminerList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamUser>)entityDictionary["Add,TempExamUser,ExaminerList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Remove,TempExamUser,Examiner"))
            {
                entityList.Add(new List<object>() { "delete", entityDictionary["Remove,TempExamUser,Examiner"] });
            }
            else if (entityDictionary.ContainsKey("Remove,TempExamUserList,TempExamStationUser"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamUser>)entityDictionary["Remove,TempExamUserList,TempExamStationUser"]).ToList<object>() });
            }
            #endregion

            #region TempExamLog
            if (entityDictionary.ContainsKey("Add,TempExamLog,AddTempExam"))
            {
                entityList.Add(new List<object>() { "insert", entityDictionary["Add,TempExamLog,AddTempExam"] });
            }
            if (entityDictionary.ContainsKey("Add,TempExamLog,ModifyTempExam"))
            {
                entityList.Add(new List<object>() { "insert", entityDictionary["Add,TempExamLog,ModifyTempExam"] });
            }
            #endregion

            #region TempExamTimeInfo
            if (entityDictionary.ContainsKey("Remove,TempExamTimeInfoList"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamTimeInfo>)entityDictionary["Remove,TempExamTimeInfoList"]).ToList<object>() });
            }
            #endregion

            #region TempExamStation
            if (entityDictionary.ContainsKey("Add,TempExamStationList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamStation>)entityDictionary["Add,TempExamStationList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Remove,TempExamStationList"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamStation>)entityDictionary["Remove,TempExamStationList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Modify,TempExamStationList"))
            {
                entityList.Add(new List<object>() { "update", ((List<Model.TempExamStation>)entityDictionary["Modify,TempExamStationList"]).ToList<object>() });
            }
            else if (entityDictionary.ContainsKey("Modify,TempExamStation"))
            {
                entityList.Add(new List<object>() { "update", entityDictionary["Modify,TempExamStation"] });
            }
            #endregion

            #region TempExamStationRoom
            if (entityDictionary.ContainsKey("Remove,TempExamStationRoomList"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamStationRoom>)entityDictionary["Remove,TempExamStationRoomList"]).ToList<object>() });
            }
            #endregion

            #region TempExamUserMarkSheet
            if (entityDictionary.ContainsKey("Remove,TempExamUserMarkSheetList"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamUserMarkSheet>)entityDictionary["Remove,TempExamUserMarkSheetList"]).ToList<object>() });
            }
            #endregion


            if (entityDictionary.ContainsKey("Add,TempExamTimeInfoList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamTimeInfo>)entityDictionary["Add,TempExamTimeInfoList"]).ToList<object>() });
            }
            if (entityDictionary.ContainsKey("Remove,TempExamStudentList"))
            {
                entityList.Add(new List<object>() { "delete", ((List<Model.TempExamStudent>)entityDictionary["Remove,TempExamStudentList"]).ToList<object>() });
            }
            if (entityDictionary.ContainsKey("Add,TempExamStudentList"))
            {
                entityList.Add(new List<object>() { "insert", ((List<Model.TempExamStudent>)entityDictionary["Add,TempExamStudentList"]).ToList<object>() });
            }

            return new DAL.TempExamTable().Transaction(entityList);
        }

        #endregion
    }
}
