using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class AllUserInfoView
    {
        private readonly Tellyes.DAL.AllUserInfoView dal = new Tellyes.DAL.AllUserInfoView();
        public AllUserInfoView()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID, string U_Source, string U_Unit, string U_TrueName, int R_ID, string R_Name, int O_ID, string O_Name, int O_ParentID, string OL_Name, int OL_ID, string U_Name, string U_PWD, string U_Phone2, string U_Email2, byte[] U_Photo, string U_Title, string U_Education, int U_Sex, string U_Email, string U_Phone, string U_Contont, string U_GoodField, DateTime U_InTime)
        {
            return dal.Exists(U_ID, U_Source, U_Unit, U_TrueName, R_ID, R_Name, O_ID, O_Name, O_ParentID, OL_Name, OL_ID, U_Name, U_PWD, U_Phone2, U_Email2, U_Photo, U_Title, U_Education, U_Sex, U_Email, U_Phone, U_Contont, U_GoodField, U_InTime);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.AllUserInfoView model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.AllUserInfoView model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int U_ID, string U_Source, string U_Unit, string U_TrueName, int R_ID, string R_Name, int O_ID, string O_Name, int O_ParentID, string OL_Name, int OL_ID, string U_Name, string U_PWD, string U_Phone2, string U_Email2, byte[] U_Photo, string U_Title, string U_Education, int U_Sex, string U_Email, string U_Phone, string U_Contont, string U_GoodField, DateTime U_InTime)
        {

            return dal.Delete(U_ID, U_Source, U_Unit, U_TrueName, R_ID, R_Name, O_ID, O_Name, O_ParentID, OL_Name, OL_ID, U_Name, U_PWD, U_Phone2, U_Email2, U_Photo, U_Title, U_Education, U_Sex, U_Email, U_Phone, U_Contont, U_GoodField, U_InTime);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.AllUserInfoView GetModel(int U_ID)
        {

            return dal.GetModel(U_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.AllUserInfoView GetModelByCache(int U_ID, string U_Source, string U_Unit, string U_TrueName, int R_ID, string R_Name, int O_ID, string O_Name, int O_ParentID, string OL_Name, int OL_ID, string U_Name, string U_PWD, string U_Phone2, string U_Email2, byte[] U_Photo, string U_Title, string U_Education, int U_Sex, string U_Email, string U_Phone, string U_Contont, string U_GoodField, DateTime U_InTime)
        {

            string CacheKey = "AllUserInfoViewModel-" + U_ID + U_Source + U_Unit + U_TrueName + R_ID + R_Name + O_ID + O_Name + O_ParentID + OL_Name + OL_ID + U_Name + U_PWD + U_Phone2 + U_Email2 + U_Photo + U_Title + U_Education + U_Sex + U_Email + U_Phone + U_Contont + U_GoodField + U_InTime;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(U_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.AllUserInfoView)objModel;
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
        public List<Tellyes.Model.AllUserInfoView> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.AllUserInfoView> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.AllUserInfoView> modelList = new List<Tellyes.Model.AllUserInfoView>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.AllUserInfoView model;
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
