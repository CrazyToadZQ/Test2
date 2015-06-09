using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public partial class IllnessCaseSP
    {
        private readonly DAL.IllnessCaseSP dal = new DAL.IllnessCaseSP();
        public IllnessCaseSP()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int IllnessCaseSPID)
        {
            return dal.Exists(IllnessCaseSPID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseSP model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.IllnessCaseSP model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IllnessCaseSPID)
        {

            return dal.Delete(IllnessCaseSPID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IllnessCaseSPIDlist)
        {
            return dal.DeleteList(IllnessCaseSPIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.IllnessCaseSP GetModel(int IllnessCaseSPID)
        {

            return dal.GetModel(IllnessCaseSPID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.IllnessCaseSP GetModelByCache(int IllnessCaseSPID)
        {

            string CacheKey = "IllnessCaseSPModel-" + IllnessCaseSPID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(IllnessCaseSPID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.IllnessCaseSP)objModel;
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
        public List<Model.IllnessCaseSP> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.IllnessCaseSP> DataTableToList(DataTable dt)
        {
            List<Model.IllnessCaseSP> modelList = new List<Model.IllnessCaseSP>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.IllnessCaseSP model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.IllnessCaseSP();
                    if (dt.Rows[n]["IllnessCaseSPID"].ToString() != "")
                    {
                        model.IllnessCaseSPID = int.Parse(dt.Rows[n]["IllnessCaseSPID"].ToString());
                    }
                    if (dt.Rows[n]["IllnessCaseID"].ToString() != "")
                    {
                        model.IllnessCaseID = int.Parse(dt.Rows[n]["IllnessCaseID"].ToString());
                    }
                    if (dt.Rows[n]["SPUserInfoID"].ToString() != "")
                    {
                        model.SPUserInfoID = int.Parse(dt.Rows[n]["SPUserInfoID"].ToString());
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

        #region Extension

        public bool AddIllnessCaseSPList(List<Model.IllnessCaseSP> illnessCaseSPList)
        {
            return new DAL.IllnessCaseSP().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"insert", illnessCaseSPList.ToList<object>()}
            });
        }

        public bool RemoveIllnessCaseSP(Model.IllnessCaseSP illnessCaseSP)
        {
            return new DAL.IllnessCaseSP().Delete(illnessCaseSP);
        }

        public bool RemoveIllnessCaseSPList(List<Model.IllnessCaseSP> illnessCaseSPList)
        {
            return new DAL.IllnessCaseSP().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"delete", illnessCaseSPList.ToList<object>()}
            });
        }

        public List<Dictionary<string, object>> SearchIllnessCaseSPInfoByIllnessCaseID(int illnessCaseID) 
        {
            List<object[]> dataList = new DAL.IllnessCaseSP().SelectIllnessCaseSPInfoByIllnessCaseID(illnessCaseID);
            if (dataList == null)
            {
                return null;
            }
            List<Dictionary<string, object>> illnessCaseSPList = new List<Dictionary<string, object>>();
            foreach (object[] data in dataList)
            {
                illnessCaseSPList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"userInfo", data[0]},
                        {"illnessCaseSP", data[1]}
                    }
                );
            }
            return illnessCaseSPList;
        }

        public List<Model.IllnessCaseSP> SearchIllnessCaseSPByIllnessCaseID(int illnessCaseID)
        {
            return new DAL.IllnessCaseSP().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IllnessCaseID", illnessCaseID}
                },
                null
            );
        }

        #endregion
    }
}
