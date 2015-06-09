using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class OSCEStationExamRoom_DeviceClass
    {
        private readonly DAL.OSCEStationExamRoom_DeviceClass dal = new DAL.OSCEStationExamRoom_DeviceClass();
        public OSCEStationExamRoom_DeviceClass()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.OSCEStationExamRoom_DeviceClass model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.OSCEStationExamRoom_DeviceClass model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.OSCEStationExamRoom_DeviceClass GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.OSCEStationExamRoom_DeviceClass GetModelByCache(int ID)
        {

            string CacheKey = "OSCEStationExamRoom_DeviceClassModel-" + ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.OSCEStationExamRoom_DeviceClass)objModel;
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
        public List<Tellyes.Model.OSCEStationExamRoom_DeviceClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.OSCEStationExamRoom_DeviceClass> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.OSCEStationExamRoom_DeviceClass> modelList = new List<Tellyes.Model.OSCEStationExamRoom_DeviceClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.OSCEStationExamRoom_DeviceClass model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.OSCEStationExamRoom_DeviceClass();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["E_ID"].ToString() != "")
                    {
                        model.E_ID = Guid.Parse(dt.Rows[n]["E_ID"].ToString());
                    }
                    if (dt.Rows[n]["DC_ID"].ToString() != "")
                    {
                        model.DC_ID = int.Parse(dt.Rows[n]["DC_ID"].ToString());
                    }
                    if (dt.Rows[n]["D_Count"].ToString() != "")
                    {
                        model.D_Count = int.Parse(dt.Rows[n]["D_Count"].ToString());
                    }
                    if (dt.Rows[n]["ES_ID"].ToString() != "")
                    {
                        model.ES_ID = Guid.Parse(dt.Rows[n]["ES_ID"].ToString());
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
