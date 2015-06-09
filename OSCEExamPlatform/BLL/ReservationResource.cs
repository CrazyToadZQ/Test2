using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
    //预约资源表
    public partial class ReservationResource
    {

        private readonly Tellyes.DAL.ReservationResource dal = new Tellyes.DAL.ReservationResource();
        public ReservationResource()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Reservation_Res_ID)
        {
            return dal.Exists(Reservation_Res_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ReservationResource model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ReservationResource model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Reservation_Res_ID)
        {

            return dal.Delete(Reservation_Res_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string Reservation_Res_IDlist)
        {
            return dal.DeleteList(Reservation_Res_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ReservationResource GetModel(int Reservation_Res_ID)
        {

            return dal.GetModel(Reservation_Res_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ReservationResource GetModelByCache(int Reservation_Res_ID)
        {

            string CacheKey = "ReservationResourceModel-" + Reservation_Res_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Reservation_Res_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ReservationResource)objModel;
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
        public List<Tellyes.Model.ReservationResource> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ReservationResource> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ReservationResource> modelList = new List<Tellyes.Model.ReservationResource>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ReservationResource model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.ReservationResource();
                    if (dt.Rows[n]["Reservation_Res_ID"].ToString() != "")
                    {
                        model.Reservation_Res_ID = int.Parse(dt.Rows[n]["Reservation_Res_ID"].ToString());
                    }
                    if (dt.Rows[n]["Number3"].ToString() != "")
                    {
                        model.Number3 = int.Parse(dt.Rows[n]["Number3"].ToString());
                    }
                    if (dt.Rows[n]["Number4"].ToString() != "")
                    {
                        model.Number4 = int.Parse(dt.Rows[n]["Number4"].ToString());
                    }
                    if (dt.Rows[n]["Number5"].ToString() != "")
                    {
                        model.Number5 = int.Parse(dt.Rows[n]["Number5"].ToString());
                    }
                    if (dt.Rows[n]["Number6"].ToString() != "")
                    {
                        model.Number6 = decimal.Parse(dt.Rows[n]["Number6"].ToString());
                    }
                    if (dt.Rows[n]["Number7"].ToString() != "")
                    {
                        model.Number7 = decimal.Parse(dt.Rows[n]["Number7"].ToString());
                    }
                    if (dt.Rows[n]["Number8"].ToString() != "")
                    {
                        model.Number8 = decimal.Parse(dt.Rows[n]["Number8"].ToString());
                    }
                    model.String1 = dt.Rows[n]["String1"].ToString();
                    model.String2 = dt.Rows[n]["String2"].ToString();
                    model.String3 = dt.Rows[n]["String3"].ToString();
                    model.String4 = dt.Rows[n]["String4"].ToString();
                    if (dt.Rows[n]["Reservation_ID"].ToString() != "")
                    {
                        model.Reservation_ID = int.Parse(dt.Rows[n]["Reservation_ID"].ToString());
                    }
                    model.String5 = dt.Rows[n]["String5"].ToString();
                    model.String6 = dt.Rows[n]["String6"].ToString();
                    model.String7 = dt.Rows[n]["String7"].ToString();
                    model.String8 = dt.Rows[n]["String8"].ToString();
                    if (dt.Rows[n]["Datetime1"].ToString() != "")
                    {
                        model.Datetime1 = DateTime.Parse(dt.Rows[n]["Datetime1"].ToString());
                    }
                    if (dt.Rows[n]["Datetime2"].ToString() != "")
                    {
                        model.Datetime2 = DateTime.Parse(dt.Rows[n]["Datetime2"].ToString());
                    }
                    if (dt.Rows[n]["Datetime3"].ToString() != "")
                    {
                        model.Datetime3 = DateTime.Parse(dt.Rows[n]["Datetime3"].ToString());
                    }
                    if (dt.Rows[n]["Datetime4"].ToString() != "")
                    {
                        model.Datetime4 = DateTime.Parse(dt.Rows[n]["Datetime4"].ToString());
                    }
                    model.Resource_Type = dt.Rows[n]["Resource_Type"].ToString();
                    if (dt.Rows[n]["ResourceID"].ToString() != "")
                    {
                        model.ResourceID = dt.Rows[n]["ResourceID"].ToString();
                    }
                    model.Resource_Code = dt.Rows[n]["Resource_Code"].ToString();
                    model.Resource_Name = dt.Rows[n]["Resource_Name"].ToString();
                    model.EnityID = dt.Rows[n]["EnityID"].ToString();
                    if (dt.Rows[n]["Number1"].ToString() != "")
                    {
                        model.Number1 = int.Parse(dt.Rows[n]["Number1"].ToString());
                    }
                    if (dt.Rows[n]["Number2"].ToString() != "")
                    {
                        model.Number2 = int.Parse(dt.Rows[n]["Number2"].ToString());
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

        #region Extesion


        #endregion
    }
}

