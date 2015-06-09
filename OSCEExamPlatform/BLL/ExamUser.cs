using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.DAL;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    /// <summary>
    /// 考试用户表
    /// </summary>
    public partial class ExamUser
    {
        public static int juryFlag = 4;
        public static int spFlag = 5;

        private static Tellyes.DAL.ExamUser eu = new DAL.ExamUser();
        private static Tellyes.BLL.UserInfo ui = new Tellyes.BLL.UserInfo();

        private readonly Tellyes.DAL.ExamUser dal = new Tellyes.DAL.ExamUser();
        public ExamUser()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EU_ID)
        {
            return dal.Exists(EU_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamUser model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamUser model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int EU_ID)
        {

            return dal.Delete(EU_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EU_IDlist)
        {
            return dal.DeleteList(EU_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamUser GetModel(Guid EU_ID)
        {

            return dal.GetModel(EU_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamUser GetModelByCache(Guid EU_ID)
        {

            string CacheKey = "ExamUserModel-" + EU_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EU_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamUser)objModel;
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
        public List<Tellyes.Model.ExamUser> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamUser> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamUser> modelList = new List<Tellyes.Model.ExamUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
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

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据考试ID，获得督考官ID
        /// </summary>
        /// <param name="eid"></param>
        /// <returns></returns>
        public string getZadok(Guid eid)
        {
            return dal.getZadok(eid);
        }
        
        /// <summary>
        /// 根据考试ID，获得督考官，评委，SP 的信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="isSP">是SP</param>
        /// <param name="isGovernor">是督考官</param>
        /// <param name="isReserve">是后备</param>
        /// <returns></returns>
        public static DataTable GetExistedJuryOrSP(string E_ID, bool isSP = false, bool isGovernor = false,bool isReserve=false)
        {
            return eu.GetExistedJuryOrSP(E_ID, isSP, isGovernor, isReserve);
        }

        #region 督考官

        /// <summary>
        /// 将一个评委，设为督考
        /// </summary>
        /// <param name="EU_ID"></param>
        public static void SetVerifierToOneEU(string EU_ID, string EU_ISZadokTheExaminer)
        {
            eu.SetVerifierToOneEU(EU_ID, EU_ISZadokTheExaminer);
        }

        #endregion

        #region 后备评委

        /// <summary>
        /// 获得某次考试中，后备评委
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingJury(string E_ID)
        {
            DataTable result = eu.GetExistedJuryOrSP(E_ID, false, false, true);
            return result;
        }

        /// <summary>
        /// 获得可选为后备评委的，评委列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingJuryAndThatCanBeSelected(string E_ID)
        {
            DataTable trueJury = eu.GetExistedJuryOrSP(E_ID, false, false, false);
            DataTable allUsersThatCanBeSelected = ui.getUserByRid(juryFlag).Tables[0];
            DataTable preparingJury = GetPreparingJury(E_ID);

            DataTable result = allUsersThatCanBeSelected.Clone();
            result.Columns.Add("EU_ISReserve");

            foreach (DataRow row in allUsersThatCanBeSelected.Rows)
            {
                string U_ID = row["U_ID"].ToString().Trim();
                DataRow[] trueJuries = trueJury.Select("U_ID='" + U_ID + "'");
                if (trueJuries.Length == 0)
                {
                    result.Rows.Add(row.ItemArray);
                }
            }

            foreach (DataRow canBeSelectedRow in result.Rows)
            {
                string U_ID2 = canBeSelectedRow["U_ID"].ToString().Trim();
                DataRow[] preparingRow = preparingJury.Select("U_ID='" + U_ID2 + "'");
                if (preparingRow.Length == 0)
                {
                    canBeSelectedRow["EU_ISReserve"] = 0;
                }
                else
                {
                    canBeSelectedRow["EU_ISReserve"] = 1;
                }
            }

            return result;
        }

        //清除已存在，后备评委
        public static void ClearPreparingJury(string E_ID)
        {
            eu.ClearPreparingJury(E_ID);
        }

        /// <summary>
        /// 增加一个新增后备评委
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="int2"></param>
        public static void AddNewItemToPreparingJury(string E_ID, string U_ID, string int2)
        {
            Tellyes.Model.ExamUser model = new Model.ExamUser();
            model.EU_ISSP = 0;
            model.EU_ISZadokTheExaminer = 0;
            model.EU_ISReserve = 1;
            model.E_ID = new Guid(E_ID);
            model.U_ID = Convert.ToInt32(U_ID);
            model.int2 = Convert.ToInt32(int2);
            eu.Add(model);
        }

        #endregion

        #region 后备SP

        /// <summary>
        /// 获得某次考试中，后备SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingSP(string E_ID)
        {
            DataTable result = eu.GetExistedJuryOrSP(E_ID,true, false, true);
            return result;
        }

        /// <summary>
        /// 获得可选为后备SP的，SP列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetPreparingSPAndThatCanBeSelected(string E_ID)
        {
            DataTable trueSP = eu.GetExistedJuryOrSP(E_ID, true, false, false);
            DataTable allUsersThatCanBeSelected = ui.getUserByRid(spFlag).Tables[0];
            DataTable preparingSP = GetPreparingSP(E_ID);

            DataTable result = allUsersThatCanBeSelected.Clone();
            result.Columns.Add("EU_ISReserve");

            foreach (DataRow row in allUsersThatCanBeSelected.Rows)
            {
                string U_ID = row["U_ID"].ToString().Trim();
                DataRow[] trueJuries = trueSP.Select("U_ID='" + U_ID + "'");
                if (trueJuries.Length == 0)
                {
                    result.Rows.Add(row.ItemArray);
                }
            }

            foreach (DataRow canBeSelectedRow in result.Rows)
            {
                string U_ID2 = canBeSelectedRow["U_ID"].ToString().Trim();
                DataRow[] preparingRow = preparingSP.Select("U_ID='" + U_ID2 + "'");
                if (preparingRow.Length == 0)
                {
                    canBeSelectedRow["EU_ISReserve"] = 0;
                }
                else
                {
                    canBeSelectedRow["EU_ISReserve"] = 1;
                }
            }

            return result;
        }

        //清除已存在，后备评委
        public static void ClearPreparingSP(string E_ID)
        {
            eu.ClearPreparingSP(E_ID);
        }

        /// <summary>
        /// 增加一个新增后备评委
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="int2"></param>
        public static void AddNewItemToPreparingSP(string E_ID, string U_ID)
        {
            Tellyes.Model.ExamUser model = new Model.ExamUser();
            model.EU_ISSP = 1;
            model.EU_ISZadokTheExaminer = 0;
            model.EU_ISReserve = 1;
            model.E_ID = new Guid(E_ID);
            model.U_ID = Convert.ToInt32(U_ID);
            eu.Add(model);
        }

        #endregion

        #region 人员一览
        
        //获得某考试中所有相关评委和SP
        public static DataTable GetExameUsersInOneExame(string E_ID)
        {
            return eu.GetExameUsersInOneExame(E_ID);
        }

        #endregion

        #region 房间X评委设置
        /// <summary>
        /// 获得某房间，备选评委列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetJuryThatCanBeSelect(string E_ID)
        {
            DataTable allUsersThatCanBeSelected = ui.getUserByRid(juryFlag).Tables[0];
            DataTable allExamUsers = GetExameUsersInOneExame(E_ID);
            DataTable result = allUsersThatCanBeSelected.Clone();
            foreach (DataRow row in allUsersThatCanBeSelected.Rows)
            {
                DataRow[] existedRows = allExamUsers.Select(" U_ID='"+row["U_ID"].ToString().Trim()+"' ");
                if (existedRows.Length == 0)
                {
                    result.Rows.Add(row.ItemArray);
                }
            }
            return result;
        }
        #endregion

        #region 房间XSP设置
        /// <summary>
        /// 获得某房间，备选SP列表
        /// </summary>
        /// <param name="E_ID"></param>
        /// <returns></returns>
        public static DataTable GetSPThatCanBeSelect(string E_ID)
        {
            DataTable allUsersThatCanBeSelected = ui.getUserByRid(spFlag).Tables[0];
            DataTable allExamUsers = GetExameUsersInOneExame(E_ID);
            DataTable result = allUsersThatCanBeSelected.Clone();
            foreach (DataRow row in allUsersThatCanBeSelected.Rows)
            {
                DataRow[] existedRows = allExamUsers.Select(" U_ID='"+row["U_ID"].ToString().Trim()+"' ");
                if (existedRows.Length == 0)
                {
                    result.Rows.Add(row.ItemArray);
                }
            }
            return result;
        }
        #endregion

        #region 打分评委、SP
        /// <summary>
        /// 获得指定房间的评委或SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="ES_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public static DataTable GetExameUsersInSpecialRoom(string E_ID, string ESR_ID, bool isSP)
        {
            return eu.GetExameUsersInSpecialRoom(E_ID, ESR_ID, isSP);
        }

        /// <summary>
        /// 为指定评委，更新 远程 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateInt1Int2ForSpecialEU(string int1, string int2, string EU_ID)
        {
            eu.UpdateInt1Int2ForSpecialEU(int1,int2, EU_ID);
        }

        /// <summary>
        /// 为指定评委，更新 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateOnlyInt1ForSpecialEU(string int1, string EU_ID)
        {
            eu.UpdateOnlyInt1ForSpecialEU(int1, EU_ID);
        }

        /// <summary>
        /// 为指定SP，更新 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateOnlyInt1ForSpecialEU_SP(string int1, string EU_ID)
        {
            eu.UpdateOnlyInt1ForSpecialEU_SP(int1, EU_ID);
        }

        /// <summary>
        /// 项某考站的房间内，添加一名评委
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void AddScoreJuryToOneExam(string E_ID, string U_ID, string ESR_ID)
        {
            eu.AddScoreJuryToOneExam(E_ID, U_ID, ESR_ID);
        }

        /// <summary>
        /// 项某考站的房间内，添加一名SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <param name="int1"></param>
        public static void AddScoreSPToOneExam(string E_ID, string U_ID, string ESR_ID)
        {
            eu.AddScoreSPToOneExam(E_ID, U_ID, ESR_ID);
        }

        #endregion

        public static DataTable GetErrorApplyExamUserData(string eid)
        {
            return Tellyes.DAL.ExamUser.GetErrorApplyExamUserData(eid);
        }

        public static DataTable GetPreparingUserInfo(string eid)
        {
            return Tellyes.DAL.ExamUser.GetPreparingUserInfo(eid);
        }

        #endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加ExamUser记录
        /// </summary>
        /// <param name="examUser"></param>
        /// <returns></returns>
        public bool AddExamUser(Model.ExamUser examUser)
        {
            return new DAL.ExamUser().Insert(examUser);
        }

        /// <summary>
        /// 删除ExamUser记录
        /// </summary>
        /// <param name="examUser"></param>
        /// <returns></returns>
        public bool RemoveExamUser(Model.ExamUser examUser)
        {
            return new DAL.ExamUser().Delete(examUser);
        }

        /// <summary>
        /// 修改ExamUser记录
        /// </summary>
        /// <param name="examUser"></param>
        /// <returns></returns>
        public bool ModifyExamUser(Model.ExamUser examUser)
        {
            return new DAL.ExamUser().Update((object)examUser);
        }

        /// <summary>
        /// 查询ExamUser下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamUserIdentity()
        {
            return new DAL.ExamUser().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamUser记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamUserCount()
        {
            return new DAL.ExamUser().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamUser记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamUserCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定EU_ID的ExamUser是否存在
        /// </summary>
        /// <param name="EU_ID"></param>
        /// <returns></returns>
        public bool? SearchExamUserExists(object EU_ID)
        {
            return new DAL.ExamUser().SelectModelObjectExistsByID(EU_ID);
        }

        /// <summary>
        /// 查询指定条件的ExamUser是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamUserExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按EU_ID查询ExamUser
        /// </summary>
        /// <param name="EU_ID"></param>
        /// <returns></returns>
        public Model.ExamUser SearchExamUserByID(object EU_ID)
        {
            return new DAL.ExamUser().SelectModelObjectByID(EU_ID);
        }

        /// <summary>
        /// 查询第一个ExamUser对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamUser SearchUniqueExamUserByCondition()
        {
            return new DAL.ExamUser().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamUser SearchUniqueExamUserByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamUser SearchUniqueExamUserByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamUser().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamUser对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamUser> SearchExamUserByCondition()
        {
            return new DAL.ExamUser().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamUser> SearchExamUserByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamUser对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamUser> SearchExamUserByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamUser().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamUser内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamUser> SearchExamUserByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamUser().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        public List<Dictionary<string, object>> SearchExamUserAndUserInfoByExamTableIDAndExamStationID(Guid examTableID, Guid examStationID)
        {
            List<object[]> examUserList = new DAL.ExamUser().SelectExamUserAndUserInfoByExamTableIDAndExamStationID(examTableID, examStationID);
            if (examUserList == null || examUserList.Count < 1)
            {
                Log4NetUtility.Error(this, "考站用户信息查询失败：ExamTable_ID ： " + examTableID.ToString() + "ExamStationID：" + examStationID.ToString());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in examUserList)
            {
                result.Add(new Dictionary<string, object>() 
                { 
                    {"ExamUserList", item[0]},
                    {"U_TrueName", item[1]},
                });
            }
            return result;   
        }

        /// <summary>
        /// 分组统计某考站人员数量
        /// </summary>
        /// <param name="examTableID"></param>
        /// <param name="examStationID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamUserCountGroupedByType(Guid examTableID, Guid examStationID)
        {
            List<object[]> examUserList = new DAL.ExamUser().SelectExamUserCountGroupedByType(examTableID, examStationID);
            if (examUserList == null || examUserList.Count < 1)
            {
                Log4NetUtility.Error(this, "考站用户信息查询失败：ExamTable_ID ： " + examTableID.ToString() + "ExamStationID：" + examStationID.ToString());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in examUserList)
            {
                if(Convert.ToInt32(item[0])==1)
                {
                    //sp
                    result.Add(new Dictionary<string, object>() { 
                        {"SPCount",item[2]}
                    });
                }
                else
                {
                    if(Convert.ToInt32(item[1])==2)
                    {
                        //现场
                        result.Add(new Dictionary<string,object>(){
                            {"JudgeCount",item[2]}
                        });
                    }
                    if (Convert.ToInt32(item[1]) == 3) 
                    { 
                        //远程
                        result.Add(new Dictionary<string, object>(){
                            {"RemoteJudgeCount",item[2]}
                        });
                    }
                }
            }
            return result;   
        }

        /// <summary>
        /// 根据 E_ID，获得评委 | SP信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamUserInfoForApplyModel(Dictionary<string, object> condition)
        {
            List<object[]> examUserList = new DAL.ExamUser().SelectExamUserInfoForApplyModel(condition);
            if (examUserList == null || examUserList.Count < 1)
            {
                Log4NetUtility.Error(this, "评委 | SP信息查询失败：ExamTable_ID ： " + Guid.Parse(condition["E_ID"].ToString().Trim()).ToString());
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in examUserList) 
            {
                result.Add(new Dictionary<string, object>(){
                            {"UserInfo",item[0]},
                            {"ES_Name",item[1]},
                            {"U_Type",item[2]},
                            {"Room_Name",item[3]},
                            {"int3",item[4] == null ? 1 : item[4]}
                        });
            }
            return result;
        }

        #endregion

        #region  扩展方法 （评委查询）

        /// <summary>
        /// 获得数据列表 评委查询   陶东利2014/6/18增加
        /// </summary>
        public List<Tellyes.Model.CompositedModelJudgeQuery> GetModelListJudgeQuery(string strWhere)
        {
            DataSet ds = dal.GetListJudgeQuery(strWhere);
            return DataTableToListDataRowToModelJudgeQuery(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表 评委查询  陶东利2014/6/18增加
        /// </summary>
        public List<Tellyes.Model.CompositedModelJudgeQuery> DataTableToListDataRowToModelJudgeQuery(DataTable dt)
        {
            List<Tellyes.Model.CompositedModelJudgeQuery> modelList = new List<Tellyes.Model.CompositedModelJudgeQuery>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.CompositedModelJudgeQuery model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModelJudgeQuery(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 手持评分接口使用的函数，查询根据考试ID、考站房间ID和用户ID查询ExamUser信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="Room_ID"></param>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public Model.ExamUser SearchExamUserByAddHandScore(Guid E_ID, int Room_ID,  int U_ID)
        {
            return new DAL.ExamUser().SelectUniqueModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"Exam_ID", E_ID},
                    {"Room_ID", Room_ID},
                    {"UserInfo_ID", U_ID}
                },
                null
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamUserAndUserInfoByExamTableID(Guid examTableID)
        {
            List<object[]> _examUserList = new DAL.ExamUser().SelectExamUserAndUserInfoByExamTableID(examTableID);
            if (_examUserList == null)
            {
                Log4NetUtility.Error(this, "查询考试用户信息失败，examTableID：" + examTableID);
                return null;
            }

            List<Dictionary<string, object>> examUserList = new List<Dictionary<string, object>>();
            foreach (object[] item in _examUserList)
            {
                examUserList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"ExamUser", item[0]},
                        {"U_TrueName", item[1]},
                        {"U_Title", item[2] ?? ""},
                        {"U_GoodField", item[3] ?? ""}
                    }
                );
            }
            return examUserList;
        }

        #endregion 

        #region 手持评分查询使用函数

        /// <summary>
        /// 手持评分用户登录查询函数
        /// </summary>
        /// <param name="U_ID"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchExamUserInHandScoreByUserInfoIDAndDatetime(int U_ID, DateTime datetime)
        {
            List<object[]> examUserList = new DAL.ExamUser().SelectExamUserInHandScoreByUserInfoIDAndDatetime(U_ID, datetime);
            if (examUserList == null || examUserList.Count < 1) 
            {
                Log4NetUtility.Error(this, "手持设备，用户登录查询失败：U_ID（" + U_ID + "），Datetime（" + datetime.ToString("yyyy-MM-dd HH:mm:ss") + "）");
                return null;
            }
            return new Dictionary<string, object>() 
            { 
                {"EU_ID", examUserList[0][0]},
                {"E_ID", examUserList[0][1]},
                {"ESR_ID", examUserList[0][2]},
                {"MarkSheetCount", examUserList[0][3]},
                {"ExamUserType", examUserList[0][4]}
            };
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoID"></param>
        /// <returns></returns>
        public int? SearchExamCountWithSPInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectExamUserInfoCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <param name="examStationID"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchExamUserInfoByCondition(Dictionary<string, object> conditionDictionary , int pageIndex, int pageSize)
        {
            List<object[]> examUserList = new DAL.ExamUser().SelectExamUserInfoByCondition(conditionDictionary,pageIndex,pageSize);
            if (examUserList == null )
            {
                Log4NetUtility.Error(this, "考站用户信息查询失败");
                return null;
            }
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (object[] item in examUserList)
            {
                result.Add(new Dictionary<string, object>() 
                { 
                    {"RoleType", item[0]},
                    {"EU_ISSP", item[1]},
                    {"EU_ISReserve", item[2]},
                    {"ES_ID", item[3]},
                    {"ES_Name", item[4]},
                    {"Room_Name", item[5]},
                    {"ExamTable", item[6]}
                });
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoID"></param>
        /// <returns></returns>
        public int? SearchExamInfoCountWithTeacherInfoByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamUser().SelectExamInfoCountWithTeacherInfoByCondition(conditionDictionary);
        }

         /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <param name="examStationID"></param>
        /// <returns></returns>
        public List<Tellyes.Model.ExamTable>  SearchExamInfoWithTeacherInfoByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            List<Tellyes.Model.ExamTable> examTableList = new DAL.ExamUser().SelectExamInfoWithTeacherInfoByCondition(conditionDictionary, pageIndex, pageSize);
            if (examTableList == null )
            {
                Log4NetUtility.Error(this, "考站用户信息查询失败");
                return null;
            }
            return examTableList;
        }

    }
}
