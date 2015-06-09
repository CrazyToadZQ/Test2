using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class IllnessCaseScript
    {
        private readonly DAL.IllnessCaseScript dal = new DAL.IllnessCaseScript();
        public IllnessCaseScript()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int IllnessCaseScriptID)
        {
            return dal.Exists(IllnessCaseScriptID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCaseScript model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.IllnessCaseScript model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IllnessCaseScriptID)
        {

            return dal.Delete(IllnessCaseScriptID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IllnessCaseScriptIDlist)
        {
            return dal.DeleteList(IllnessCaseScriptIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.IllnessCaseScript GetModel(int IllnessCaseScriptID)
        {

            return dal.GetModel(IllnessCaseScriptID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.IllnessCaseScript GetModelByCache(int IllnessCaseScriptID)
        {

            string CacheKey = "IllnessCaseScriptModel-" + IllnessCaseScriptID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(IllnessCaseScriptID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.IllnessCaseScript)objModel;
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
        public List<Model.IllnessCaseScript> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.IllnessCaseScript> DataTableToList(DataTable dt)
        {
            List<Model.IllnessCaseScript> modelList = new List<Model.IllnessCaseScript>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.IllnessCaseScript model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.IllnessCaseScript();
                    if (dt.Rows[n]["IllnessCaseScriptID"].ToString() != "")
                    {
                        model.IllnessCaseScriptID = int.Parse(dt.Rows[n]["IllnessCaseScriptID"].ToString());
                    }
                    if (dt.Rows[n]["IsValid"].ToString() != "")
                    {
                        model.IsValid = int.Parse(dt.Rows[n]["IsValid"].ToString());
                    }
                    if (dt.Rows[n]["Number1"].ToString() != "")
                    {
                        model.Number1 = int.Parse(dt.Rows[n]["Number1"].ToString());
                    }
                    if (dt.Rows[n]["Number2"].ToString() != "")
                    {
                        model.Number2 = int.Parse(dt.Rows[n]["Number2"].ToString());
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
                    model.IllnessCaseScriptName = dt.Rows[n]["IllnessCaseScriptName"].ToString();
                    model.String2 = dt.Rows[n]["String2"].ToString();
                    model.String3 = dt.Rows[n]["String3"].ToString();
                    model.String4 = dt.Rows[n]["String4"].ToString();
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
                    if (dt.Rows[n]["IllnessCaseID"].ToString() != "")
                    {
                        model.IllnessCaseID = int.Parse(dt.Rows[n]["IllnessCaseID"].ToString());
                    }
                    if (dt.Rows[n]["Datetime4"].ToString() != "")
                    {
                        model.Datetime4 = DateTime.Parse(dt.Rows[n]["Datetime4"].ToString());
                    }
                    model.IllnessCaseScriptContent = dt.Rows[n]["IllnessCaseScriptContent"].ToString();
                    model.IllnessCaseScriptText = dt.Rows[n]["IllnessCaseScriptText"].ToString();
                    if (dt.Rows[n]["CreatorUserInfoID"].ToString() != "")
                    {
                        model.CreatorUserInfoID = int.Parse(dt.Rows[n]["CreatorUserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["CreateDatetime"].ToString() != "")
                    {
                        model.CreateDatetime = DateTime.Parse(dt.Rows[n]["CreateDatetime"].ToString());
                    }
                    if (dt.Rows[n]["ModifierUserInfoID"].ToString() != "")
                    {
                        model.ModifierUserInfoID = int.Parse(dt.Rows[n]["ModifierUserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["ModifyDatetime"].ToString() != "")
                    {
                        model.ModifyDatetime = DateTime.Parse(dt.Rows[n]["ModifyDatetime"].ToString());
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

        public bool AddIllnessCaseScript(Model.IllnessCaseScript illnessCaseScript)
        {
            return new DAL.IllnessCaseScript().Insert(illnessCaseScript);
        }

        public bool RemoveIllnessCaseScriptList(List<Model.IllnessCaseScript> illnessCaseScriptList)
        {
            return new DAL.IllnessCaseScript().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", illnessCaseScriptList.ToList<object>()}
            });
        }

        public bool ModifyIllnessCaseScript(Model.IllnessCaseScript illnessCaseScript)
        {
            return new DAL.IllnessCaseScript().Update(illnessCaseScript);
        }

        public bool ModifyIllnessCaseScript(Model.IllnessCaseScript illnessCaseScript, Model.IllnessCaseScript newIllnessCaseScript, List<Model.IllnessCaseScriptMarkSheet> illnessCaseScriptMarkSheetList)
        {
            return new DAL.IllnessCaseScript().Transaction
            (
                new List<List<object>>() 
                { 
                    new List<object>(){"update", illnessCaseScript},
                    new List<object>(){"insert", newIllnessCaseScript},
                    new List<object>(){"update", illnessCaseScriptMarkSheetList.ToList<object>()}
                }
            );
        }

        public int? SearchIllnessCaseScriptIdentity()
        {
            return new DAL.IllnessCaseScript().SelectNextIdentity();
        }

        public List<Model.IllnessCaseScript> SearchIllnessCaseScript()
        {
            return new DAL.IllnessCaseScript().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IsValid", 1}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("IllnessCaseScriptName", "ASC")
                }
            );
        }

        public Model.IllnessCaseScript SearchIllnessCaseScriptByIllnessCaseScriptID(int illnessCaseScriptID)
        {
            return new DAL.IllnessCaseScript().SelectModelObjectByID(illnessCaseScriptID);
        }

        public List<Model.IllnessCaseScript> SearchIllnessCaseScriptByIllnessCaseID(int illnessCaseID)
        {
            return new DAL.IllnessCaseScript().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IsValid", 1},
                    {"IllnessCaseID", illnessCaseID}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("IllnessCaseScriptName", "ASC")
                }
            );
        }

        public List<Model.IllnessCaseScript> SearchIllnessCaseScriptByIllnessCaseScriptIDList(List<int> illnessCaseScriptIDList)
        {
            return new DAL.IllnessCaseScript().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IllnessCaseScriptIDList", illnessCaseScriptIDList}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("IllnessCaseScriptName", "ASC")
                }
            );
        }

        #endregion
    }
}
