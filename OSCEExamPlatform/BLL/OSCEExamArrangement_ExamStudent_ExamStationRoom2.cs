
using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// 用户信息表
	/// </summary>
	public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom2
	{
        private readonly Tellyes.DAL.OSCEExamArrangement_ExamStudent_ExamStationRoom2 dal = new Tellyes.DAL.OSCEExamArrangement_ExamStudent_ExamStationRoom2();
        public OSCEExamArrangement_ExamStudent_ExamStationRoom2()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        //public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 GetModelByCache()
        //{
        //    //该表无主键信息，请自定义主键/条件字段
        //    string CacheKey = "OSCEExamArrangement_ExamStudent_ExamStationRoom2Model-" ;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel();
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2)objModel;
        //}

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
        public List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2> modelList = new List<Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom2 model;
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
        /// 根据RoomID查找考试ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetExamID(string RoomID)
        {
            DataTable dt = new DataTable();
            DataSet ds = dal.GetExamID(RoomID);
            if (ds != null)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站的排考表
        /// </summary>
        /// <param name="ExamID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetArrangementTable(Guid ExamID, int RoomID)
        {
            DataTable dt = dal.GetArrangementTable(ExamID, RoomID).Tables[0];
            return dt;
        }

        /// <summary>
        /// 根据考试ExamID和RoomID查找本考站ESID
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string GetESIDStr(Guid ExamID, int RoomID)
        {
            string ESIDStr = "";
            DataTable dt = GetArrangementTable(ExamID, RoomID);
            if (dt.Rows.Count > 0)
            {
                ESIDStr = dt.Rows[0]["ES_ID"].ToString();
            }
            return ESIDStr;
        }
        #endregion  ExtensionMethod
	}
}

