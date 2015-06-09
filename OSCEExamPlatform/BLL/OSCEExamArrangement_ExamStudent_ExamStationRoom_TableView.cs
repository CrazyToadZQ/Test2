using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    /// <summary>
    /// OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
    /// </summary>
    public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
    {
        private readonly Tellyes.DAL.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView dal = new Tellyes.DAL.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView();
        public OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {
            return dal.Exists(U_ID, E_ID, EStu_ExamNumber, EStu_int, EStu_string, EStu_bool, OEA_ID, EStu_ID, ESR_ID, OEA_StartTime, OEA_EndTime, OSCEExamInt1, OSCEExamInt2, OSCEExamInt3, OSCEExamString1, OSCEExamString2, OSCEExamString3, OSCEExamDate1, OSCEExamDate2, OSCEExamDate3, OSCEExamFloat1, OSCEExamFloat2, OSCEExamFloat3, ES_ID, Room_ID, ExamStationRoomInt1, ExamStationRoomInt2, ExamStationRoomInt3, ExamStationRoomString1, ExamStationRoomString2, ExamStationRoomString3, ExamStationRoomDate1, ExamStationRoomDate2, ExamStationRoomDate3, ExamStationRoomFloat1, ExamStationRoomFloat2, ExamStationRoomFloat3);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {

            return dal.Delete(U_ID, E_ID, EStu_ExamNumber, EStu_int, EStu_string, EStu_bool, OEA_ID, EStu_ID, ESR_ID, OEA_StartTime, OEA_EndTime, OSCEExamInt1, OSCEExamInt2, OSCEExamInt3, OSCEExamString1, OSCEExamString2, OSCEExamString3, OSCEExamDate1, OSCEExamDate2, OSCEExamDate3, OSCEExamFloat1, OSCEExamFloat2, OSCEExamFloat3, ES_ID, Room_ID, ExamStationRoomInt1, ExamStationRoomInt2, ExamStationRoomInt3, ExamStationRoomString1, ExamStationRoomString2, ExamStationRoomString3, ExamStationRoomDate1, ExamStationRoomDate2, ExamStationRoomDate3, ExamStationRoomFloat1, ExamStationRoomFloat2, ExamStationRoomFloat3);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView GetModel(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {

            return dal.GetModel(U_ID, E_ID, EStu_ExamNumber, EStu_int, EStu_string, EStu_bool, OEA_ID, EStu_ID, ESR_ID, OEA_StartTime, OEA_EndTime, OSCEExamInt1, OSCEExamInt2, OSCEExamInt3, OSCEExamString1, OSCEExamString2, OSCEExamString3, OSCEExamDate1, OSCEExamDate2, OSCEExamDate3, OSCEExamFloat1, OSCEExamFloat2, OSCEExamFloat3, ES_ID, Room_ID, ExamStationRoomInt1, ExamStationRoomInt2, ExamStationRoomInt3, ExamStationRoomString1, ExamStationRoomString2, ExamStationRoomString3, ExamStationRoomDate1, ExamStationRoomDate2, ExamStationRoomDate3, ExamStationRoomFloat1, ExamStationRoomFloat2, ExamStationRoomFloat3);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView GetModelByCache(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {

            string CacheKey = "OSCEExamArrangement_ExamStudent_ExamStationRoom_TableViewModel-" + U_ID + E_ID + EStu_ExamNumber + EStu_int + EStu_string + EStu_bool + OEA_ID + EStu_ID + ESR_ID + OEA_StartTime + OEA_EndTime + OSCEExamInt1 + OSCEExamInt2 + OSCEExamInt3 + OSCEExamString1 + OSCEExamString2 + OSCEExamString3 + OSCEExamDate1 + OSCEExamDate2 + OSCEExamDate3 + OSCEExamFloat1 + OSCEExamFloat2 + OSCEExamFloat3 + ES_ID + Room_ID + ExamStationRoomInt1 + ExamStationRoomInt2 + ExamStationRoomInt3 + ExamStationRoomString1 + ExamStationRoomString2 + ExamStationRoomString3 + ExamStationRoomDate1 + ExamStationRoomDate2 + ExamStationRoomDate3 + ExamStationRoomFloat1 + ExamStationRoomFloat2 + ExamStationRoomFloat3;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(U_ID, E_ID, EStu_ExamNumber, EStu_int, EStu_string, EStu_bool, OEA_ID, EStu_ID, ESR_ID, OEA_StartTime, OEA_EndTime, OSCEExamInt1, OSCEExamInt2, OSCEExamInt3, OSCEExamString1, OSCEExamString2, OSCEExamString3, OSCEExamDate1, OSCEExamDate2, OSCEExamDate3, OSCEExamFloat1, OSCEExamFloat2, OSCEExamFloat3, ES_ID, Room_ID, ExamStationRoomInt1, ExamStationRoomInt2, ExamStationRoomInt3, ExamStationRoomString1, ExamStationRoomString2, ExamStationRoomString3, ExamStationRoomDate1, ExamStationRoomDate2, ExamStationRoomDate3, ExamStationRoomFloat1, ExamStationRoomFloat2, ExamStationRoomFloat3);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView)objModel;
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
        public List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView> modelList = new List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model;
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

        #endregion  ExtensionMethod
    }
}
