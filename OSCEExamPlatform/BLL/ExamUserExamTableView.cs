using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    /// <summary>
    /// ExamUserExamTableView
    /// </summary>
    public partial class ExamUserExamTableView
    {
        private readonly Tellyes.DAL.ExamUserExamTableView dal = new Tellyes.DAL.ExamUserExamTableView();
        public ExamUserExamTableView()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {
            return dal.Exists(E_ID, E_Name, E_StartTime, E_EndTime, E_CreateUser, E_CreateTime, E_ModifyTime, E_Kind, E_OID, E_GID, E_NoStuID, E_LongStationExamTimeNum, E_LongStationScoreTimeNum, E_ShortStationExamTimeNum, E_ShortStationScoreTimeNum, E_State, E_ZadokTheExaminer, E_IsOpenScore, E_IsOpenVideo, ExamTableInt1, ExamTableInt2, ExamTableInt3, ExamTableString1, ExamTableString2, ExamTableString3, ExamTableDate1, ExamTableDate2, ExamTableDate3, ExamTableFloat1, ExamTableFloat2, ExamTableFloat3, EU_ISSP, EU_ISZadokTheExaminer, EU_ISReserve, U_ID, ESR_ID, ExamUserInt1, ExamUserInt2, ExamUserInt3, ExamUserString1, ExamUserString2, ExamUserString3, ExamUserDate1, ExamUserDate2, ExamUserDate3, ExamUserFloat1, ExamUserFloat2, ExamUserFloat3, EU_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.ExamUserExamTableView model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamUserExamTableView model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {

            return dal.Delete(E_ID, E_Name, E_StartTime, E_EndTime, E_CreateUser, E_CreateTime, E_ModifyTime, E_Kind, E_OID, E_GID, E_NoStuID, E_LongStationExamTimeNum, E_LongStationScoreTimeNum, E_ShortStationExamTimeNum, E_ShortStationScoreTimeNum, E_State, E_ZadokTheExaminer, E_IsOpenScore, E_IsOpenVideo, ExamTableInt1, ExamTableInt2, ExamTableInt3, ExamTableString1, ExamTableString2, ExamTableString3, ExamTableDate1, ExamTableDate2, ExamTableDate3, ExamTableFloat1, ExamTableFloat2, ExamTableFloat3, EU_ISSP, EU_ISZadokTheExaminer, EU_ISReserve, U_ID, ESR_ID, ExamUserInt1, ExamUserInt2, ExamUserInt3, ExamUserString1, ExamUserString2, ExamUserString3, ExamUserDate1, ExamUserDate2, ExamUserDate3, ExamUserFloat1, ExamUserFloat2, ExamUserFloat3, EU_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamUserExamTableView GetModel(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {

            return dal.GetModel(E_ID, E_Name, E_StartTime, E_EndTime, E_CreateUser, E_CreateTime, E_ModifyTime, E_Kind, E_OID, E_GID, E_NoStuID, E_LongStationExamTimeNum, E_LongStationScoreTimeNum, E_ShortStationExamTimeNum, E_ShortStationScoreTimeNum, E_State, E_ZadokTheExaminer, E_IsOpenScore, E_IsOpenVideo, ExamTableInt1, ExamTableInt2, ExamTableInt3, ExamTableString1, ExamTableString2, ExamTableString3, ExamTableDate1, ExamTableDate2, ExamTableDate3, ExamTableFloat1, ExamTableFloat2, ExamTableFloat3, EU_ISSP, EU_ISZadokTheExaminer, EU_ISReserve, U_ID, ESR_ID, ExamUserInt1, ExamUserInt2, ExamUserInt3, ExamUserString1, ExamUserString2, ExamUserString3, ExamUserDate1, ExamUserDate2, ExamUserDate3, ExamUserFloat1, ExamUserFloat2, ExamUserFloat3, EU_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamUserExamTableView GetModelByCache(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {

            string CacheKey = "ExamUserExamTableViewModel-" + E_ID + E_Name + E_StartTime + E_EndTime + E_CreateUser + E_CreateTime + E_ModifyTime + E_Kind + E_OID + E_GID + E_NoStuID + E_LongStationExamTimeNum + E_LongStationScoreTimeNum + E_ShortStationExamTimeNum + E_ShortStationScoreTimeNum + E_State + E_ZadokTheExaminer + E_IsOpenScore + E_IsOpenVideo + ExamTableInt1 + ExamTableInt2 + ExamTableInt3 + ExamTableString1 + ExamTableString2 + ExamTableString3 + ExamTableDate1 + ExamTableDate2 + ExamTableDate3 + ExamTableFloat1 + ExamTableFloat2 + ExamTableFloat3 + EU_ISSP + EU_ISZadokTheExaminer + EU_ISReserve + U_ID + ESR_ID + ExamUserInt1 + ExamUserInt2 + ExamUserInt3 + ExamUserString1 + ExamUserString2 + ExamUserString3 + ExamUserDate1 + ExamUserDate2 + ExamUserDate3 + ExamUserFloat1 + ExamUserFloat2 + ExamUserFloat3 + EU_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(E_ID, E_Name, E_StartTime, E_EndTime, E_CreateUser, E_CreateTime, E_ModifyTime, E_Kind, E_OID, E_GID, E_NoStuID, E_LongStationExamTimeNum, E_LongStationScoreTimeNum, E_ShortStationExamTimeNum, E_ShortStationScoreTimeNum, E_State, E_ZadokTheExaminer, E_IsOpenScore, E_IsOpenVideo, ExamTableInt1, ExamTableInt2, ExamTableInt3, ExamTableString1, ExamTableString2, ExamTableString3, ExamTableDate1, ExamTableDate2, ExamTableDate3, ExamTableFloat1, ExamTableFloat2, ExamTableFloat3, EU_ISSP, EU_ISZadokTheExaminer, EU_ISReserve, U_ID, ESR_ID, ExamUserInt1, ExamUserInt2, ExamUserInt3, ExamUserString1, ExamUserString2, ExamUserString3, ExamUserDate1, ExamUserDate2, ExamUserDate3, ExamUserFloat1, ExamUserFloat2, ExamUserFloat3, EU_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamUserExamTableView)objModel;
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
        public List<Tellyes.Model.ExamUserExamTableView> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamUserExamTableView> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamUserExamTableView> modelList = new List<Tellyes.Model.ExamUserExamTableView>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamUserExamTableView model;
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
        ///  获得系统当前时间 距离“Time”的时间差，以“天”为单位
        /// </summary>
        /// <param name="Time"></param>
        /// <returns></returns>
        public int GetRemainingDays(DateTime Time)
        {
           return dal.GetRemainingDays(Time);
        }

        /// <summary>
        /// 获得在系统当前时间基础上 增加固定的天数后 的新时间
        /// </summary>
        /// <param name="Days"></param>
        /// <returns></returns>
        public DateTime GetNewTime(int Days)
        {
            return dal.GetNewTime(Days);
        }

        /// <summary>
        /// 获取系统当前时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetNowTime()
        {
            return dal.GetNowTime();
        }

        #endregion  ExtensionMethod
    }
}
