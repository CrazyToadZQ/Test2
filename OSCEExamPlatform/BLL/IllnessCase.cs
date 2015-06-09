using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public partial class IllnessCase
    {
        private readonly DAL.IllnessCase dal = new DAL.IllnessCase();
        public IllnessCase()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int IllnessCaseID)
        {
            return dal.Exists(IllnessCaseID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.IllnessCase model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.IllnessCase model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IllnessCaseID)
        {

            return dal.Delete(IllnessCaseID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IllnessCaseIDlist)
        {
            return dal.DeleteList(IllnessCaseIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.IllnessCase GetModel(int IllnessCaseID)
        {

            return dal.GetModel(IllnessCaseID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.IllnessCase GetModelByCache(int IllnessCaseID)
        {

            string CacheKey = "IllnessCaseModel-" + IllnessCaseID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(IllnessCaseID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.IllnessCase)objModel;
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
        public List<Model.IllnessCase> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.IllnessCase> DataTableToList(DataTable dt)
        {
            List<Model.IllnessCase> modelList = new List<Model.IllnessCase>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.IllnessCase model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.IllnessCase();
                    if (dt.Rows[n]["IllnessCaseID"].ToString() != "")
                    {
                        model.IllnessCaseID = int.Parse(dt.Rows[n]["IllnessCaseID"].ToString());
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
                    model.IllnessCaseName = dt.Rows[n]["IllnessCaseName"].ToString();
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
                    if (dt.Rows[n]["MarkSheetKindID"].ToString() != "")
                    {
                        model.MarkSheetKindID = int.Parse(dt.Rows[n]["MarkSheetKindID"].ToString());
                    }
                    if (dt.Rows[n]["Datetime4"].ToString() != "")
                    {
                        model.Datetime4 = DateTime.Parse(dt.Rows[n]["Datetime4"].ToString());
                    }
                    model.IllnessCaseContent = dt.Rows[n]["IllnessCaseContent"].ToString();
                    model.IllnessCaseText = dt.Rows[n]["IllnessCaseText"].ToString();
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

        #region Extension NHibernate

        /// <summary>
        /// 添加IllnessCase记录
        /// </summary>
        /// <param name="illnessCase"></param>
        /// <returns></returns>
        public bool AddIllnessCase(Model.IllnessCase illnessCase)
        {
            return new DAL.IllnessCase().Insert(illnessCase);
        }

        /// <summary>
        /// 删除IllnessCase记录
        /// </summary>
        /// <param name="illnessCase"></param>
        /// <returns></returns>
        public bool RemoveIllnessCase(Model.IllnessCase illnessCase)
        {
            return new DAL.IllnessCase().Delete(illnessCase);
        }

        /// <summary>
        /// 修改IllnessCase记录
        /// </summary>
        /// <param name="illnessCase"></param>
        /// <returns></returns>
        public bool ModifyIllnessCase(Model.IllnessCase illnessCase)
        {
            return new DAL.IllnessCase().Update((object)illnessCase);
        }

        /// <summary>
        /// 查询IllnessCase下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchIllnessCaseIdentity()
        {
            return new DAL.IllnessCase().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部IllnessCase记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchIllnessCaseCount()
        {
            return new DAL.IllnessCase().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询IllnessCase记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchIllnessCaseCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.IllnessCase().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定illnessCaseID的IllnessCase是否存在
        /// </summary>
        /// <param name="illnessCaseID"></param>
        /// <returns></returns>
        public bool? SearchIllnessCaseExists(object illnessCaseID)
        {
            return new DAL.IllnessCase().SelectModelObjectExistsByID(illnessCaseID);
        }

        /// <summary>
        /// 查询指定条件的IllnessCase是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchIllnessCaseExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.IllnessCase().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按illnessCaseID查询IllnessCase
        /// </summary>
        /// <param name="illnessCaseID"></param>
        /// <returns></returns>
        public Model.IllnessCase SearchIllnessCaseByID(object illnessCaseID)
        {
            return new DAL.IllnessCase().SelectModelObjectByID(illnessCaseID);
        }

        /// <summary>
        /// 查询第一个IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public Model.IllnessCase SearchUniqueIllnessCaseByCondition()
        {
            return new DAL.IllnessCase().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.IllnessCase SearchUniqueIllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.IllnessCase SearchUniqueIllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public List<Model.IllnessCase> SearchIllnessCaseByCondition()
        {
            return new DAL.IllnessCase().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.IllnessCase> SearchIllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.IllnessCase().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.IllnessCase> SearchIllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.IllnessCase().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询IllnessCase内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.IllnessCase> SearchIllnessCaseByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.IllnessCase().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extension Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="illnessCase"></param>
        /// <returns></returns>
        public bool RemoveIllnessCaseInLogical(Model.IllnessCase illnessCase)
        {
            return new DAL.IllnessCase().Update((object)illnessCase);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="illnessCaseList"></param>
        /// <returns></returns>
        public bool RemoveIllnessCaseList(List<Model.IllnessCase> illnessCaseList)
        {
            return new DAL.IllnessCase().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", illnessCaseList.ToList<object>()}
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="illnessCaseList"></param>
        /// <returns></returns>
        public bool ModifyIllnessCase(List<Model.IllnessCase> illnessCaseList)
        {
            return new DAL.IllnessCase().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", illnessCaseList.ToList<object>()}
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="illnessCase"></param>
        /// <param name="newIllnessCase"></param>
        /// <param name="illnessCaseScriptList"></param>
        /// <param name="illnessCaseSPList"></param>
        /// <returns></returns>
        public bool ModifyIllnessCase(Model.IllnessCase illnessCase, Model.IllnessCase newIllnessCase, List<Model.IllnessCaseScript> illnessCaseScriptList, List<Model.IllnessCaseSP> illnessCaseSPList)
        {
            return new DAL.IllnessCase().Transaction(new List<List<object>>() 
            { 
                new List<object>(){"update", illnessCase},
                new List<object>(){"insert", newIllnessCase},
                new List<object>(){"update", illnessCaseScriptList.ToList<object>()},
                new List<object>(){"update", illnessCaseSPList.ToList<object>()}
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examStationID"></param>
        /// <param name="examKind"></param>
        /// <returns></returns>
        public Dictionary<string, object> SearchIllnessCaseByExamStationID(Guid examStationID, int examKind)
        {
            object[] examStaionIllnessCase = new DAL.IllnessCase().SelectIllnessCaseByExamStationID(examStationID, examKind);
            if (examStaionIllnessCase == null)
            {
                Log4NetUtility.Error(this, "查询考站病例信息失败，examStationID：" + examStationID);
                return null;
            }

            return new Dictionary<string, object>()
            {
                {"illnessCase", examStaionIllnessCase[0]},
                {"illnessCaseScript", examStaionIllnessCase[1]}
            };
        }
        #endregion
    }
}
