using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public partial class ReservationTimeInfo
    {

        private readonly Tellyes.DAL.ReservationTimeInfo dal = new Tellyes.DAL.ReservationTimeInfo();
        public ReservationTimeInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ReservationTimeInfoID)
        {
            return dal.Exists(ReservationTimeInfoID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ReservationTimeInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ReservationTimeInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ReservationTimeInfoID)
        {

            return dal.Delete(ReservationTimeInfoID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string ReservationTimeInfoIDlist)
        {
            return dal.DeleteList(ReservationTimeInfoIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ReservationTimeInfo GetModel(int ReservationTimeInfoID)
        {

            return dal.GetModel(ReservationTimeInfoID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ReservationTimeInfo GetModelByCache(int ReservationTimeInfoID)
        {

            string CacheKey = "ReservationTimeInfoModel-" + ReservationTimeInfoID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ReservationTimeInfoID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ReservationTimeInfo)objModel;
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
        public List<Tellyes.Model.ReservationTimeInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ReservationTimeInfo> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ReservationTimeInfo> modelList = new List<Tellyes.Model.ReservationTimeInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ReservationTimeInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.ReservationTimeInfo();
                    if (dt.Rows[n]["ReservationTimeInfoID"].ToString() != "")
                    {
                        model.ReservationTimeInfoID = int.Parse(dt.Rows[n]["ReservationTimeInfoID"].ToString());
                    }
                    model.EnityID = dt.Rows[n]["EnityID"].ToString();
                    model.ReservationTimeInfoDateInfo = dt.Rows[n]["ReservationTimeInfoDateInfo"].ToString();
                    model.ReservationTimeInfoStartTime = dt.Rows[n]["ReservationTimeInfoStartTime"].ToString();
                    model.ReservationTimeInfoEndTime = dt.Rows[n]["ReservationTimeInfoEndTime"].ToString();
                    if (dt.Rows[n]["ReservationID"].ToString() != "")
                    {
                        model.ReservationID = int.Parse(dt.Rows[n]["ReservationID"].ToString());
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

    }
}
