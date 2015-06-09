using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //Pc系统设备摄像头绑定关系表
    public partial class PcDeviceCamera
    {

        private readonly Tellyes.DAL.PcDeviceCamera dal = new Tellyes.DAL.PcDeviceCamera();
        public PcDeviceCamera()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PDC_ID)
        {
            return dal.Exists(PDC_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.PcDeviceCamera model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.PcDeviceCamera model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PDC_ID)
        {

            return dal.Delete(PDC_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string PDC_IDlist)
        {
            return dal.DeleteList(PDC_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.PcDeviceCamera GetModel(int PDC_ID)
        {

            return dal.GetModel(PDC_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.PcDeviceCamera GetModelByCache(int PDC_ID)
        {

            string CacheKey = "PcDeviceCameraModel-" + PDC_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PDC_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.PcDeviceCamera)objModel;
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
        public List<Tellyes.Model.PcDeviceCamera> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.PcDeviceCamera> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.PcDeviceCamera> modelList = new List<Tellyes.Model.PcDeviceCamera>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.PcDeviceCamera model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.PcDeviceCamera();
                    if (dt.Rows[n]["PDC_ID"].ToString() != "")
                    {
                        model.PDC_ID = int.Parse(dt.Rows[n]["PDC_ID"].ToString());
                    }
                    model.Pc_String3 = dt.Rows[n]["Pc_String3"].ToString();
                    model.Pc_String4 = dt.Rows[n]["Pc_String4"].ToString();
                    model.Pc_String5 = dt.Rows[n]["Pc_String5"].ToString();
                    if (dt.Rows[n]["SD_ID"].ToString() != "")
                    {
                        model.SD_ID = Guid.Parse(dt.Rows[n]["SD_ID"].ToString());
                    }
                    if (dt.Rows[n]["Camera_ID"].ToString() != "")
                    {
                        model.Camera_ID = int.Parse(dt.Rows[n]["Camera_ID"].ToString());
                    }
                    if (dt.Rows[n]["Pc_Number1"].ToString() != "")
                    {
                        model.Pc_Number1 = int.Parse(dt.Rows[n]["Pc_Number1"].ToString());
                    }
                    if (dt.Rows[n]["Pc_Number2"].ToString() != "")
                    {
                        model.Pc_Number2 = int.Parse(dt.Rows[n]["Pc_Number2"].ToString());
                    }
                    if (dt.Rows[n]["Pc_Number3"].ToString() != "")
                    {
                        model.Pc_Number3 = int.Parse(dt.Rows[n]["Pc_Number3"].ToString());
                    }
                    if (dt.Rows[n]["Pc_Number4"].ToString() != "")
                    {
                        model.Pc_Number4 = int.Parse(dt.Rows[n]["Pc_Number4"].ToString());
                    }
                    model.Pc_String1 = dt.Rows[n]["Pc_String1"].ToString();
                    model.Pc_String2 = dt.Rows[n]["Pc_String2"].ToString();


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
        /// 添加PcDeviceCamera记录
        /// </summary>
        /// <param name="pcDeviceCamera"></param>
        /// <returns></returns>
        public bool AddPcDeviceCamera(Model.PcDeviceCamera pcDeviceCamera)
        {
            return new DAL.PcDeviceCamera().Insert(pcDeviceCamera);
        }

        /// <summary>
        /// 删除PcDeviceCamera记录
        /// </summary>
        /// <param name="pcDeviceCamera"></param>
        /// <returns></returns>
        public bool RemovePcDeviceCamera(Model.PcDeviceCamera pcDeviceCamera)
        {
            return new DAL.PcDeviceCamera().Delete(pcDeviceCamera);
        }

        /// <summary>
        /// 修改PcDeviceCamera记录
        /// </summary>
        /// <param name="pcDeviceCamera"></param>
        /// <returns></returns>
        public bool ModifyPcDeviceCamera(Model.PcDeviceCamera pcDeviceCamera)
        {
            return new DAL.PcDeviceCamera().Update((object)pcDeviceCamera);
        }

        /// <summary>
        /// 查询PcDeviceCamera下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchPcDeviceCameraIdentity()
        {
            return new DAL.PcDeviceCamera().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部PcDeviceCamera记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchPcDeviceCameraCount()
        {
            return new DAL.PcDeviceCamera().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询PcDeviceCamera记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchPcDeviceCameraCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定pDC_ID的PcDeviceCamera是否存在
        /// </summary>
        /// <param name="pDC_ID"></param>
        /// <returns></returns>
        public bool? SearchPcDeviceCameraExists(object pDC_ID)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectExistsByID(pDC_ID);
        }

        /// <summary>
        /// 查询指定条件的PcDeviceCamera是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchPcDeviceCameraExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按pDC_ID查询PcDeviceCamera
        /// </summary>
        /// <param name="pDC_ID"></param>
        /// <returns></returns>
        public Model.PcDeviceCamera SearchPcDeviceCameraByID(object pDC_ID)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectByID(pDC_ID);
        }

        /// <summary>
        /// 查询第一个PcDeviceCamera对象
        /// </summary>
        /// <returns></returns>
        public Model.PcDeviceCamera SearchUniquePcDeviceCameraByCondition()
        {
            return new DAL.PcDeviceCamera().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个PcDeviceCamera对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.PcDeviceCamera SearchUniquePcDeviceCameraByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PcDeviceCamera().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个PcDeviceCamera对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.PcDeviceCamera SearchUniquePcDeviceCameraByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.PcDeviceCamera().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部PcDeviceCamera对象
        /// </summary>
        /// <returns></returns>
        public List<Model.PcDeviceCamera> SearchPcDeviceCameraByCondition()
        {
            return new DAL.PcDeviceCamera().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询PcDeviceCamera对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.PcDeviceCamera> SearchPcDeviceCameraByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询PcDeviceCamera对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.PcDeviceCamera> SearchPcDeviceCameraByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询PcDeviceCamera内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.PcDeviceCamera> SearchPcDeviceCameraByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.PcDeviceCamera().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion


        #endregion
    }
}
