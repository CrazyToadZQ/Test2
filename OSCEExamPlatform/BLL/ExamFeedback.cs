using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class ExamFeedback
    {
        private readonly Tellyes.DAL.ExamFeedback dal = new Tellyes.DAL.ExamFeedback();
        public ExamFeedback()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ExamFeedbackID)
        {
            return dal.Exists(ExamFeedbackID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.ExamFeedback model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamFeedback model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ExamFeedbackID)
        {

            return dal.Delete(ExamFeedbackID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string ExamFeedbackIDlist)
        {
            return dal.DeleteList(ExamFeedbackIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.ExamFeedback GetModel(int ExamFeedbackID)
        {

            return dal.GetModel(ExamFeedbackID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.ExamFeedback GetModelByCache(int ExamFeedbackID)
        {

            string CacheKey = "ExamFeedbackModel-" + ExamFeedbackID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ExamFeedbackID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.ExamFeedback)objModel;
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
        public List<Tellyes.Model.ExamFeedback> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.ExamFeedback> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.ExamFeedback> modelList = new List<Tellyes.Model.ExamFeedback>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.ExamFeedback model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.ExamFeedback();
                    if (dt.Rows[n]["ExamFeedbackID"].ToString() != "")
                    {
                        model.ExamFeedbackID = int.Parse(dt.Rows[n]["ExamFeedbackID"].ToString());
                    }
                    if (dt.Rows[n]["ExamFeedbackNumber2"].ToString() != "")
                    {
                        model.ExamFeedbackNumber2 = decimal.Parse(dt.Rows[n]["ExamFeedbackNumber2"].ToString());
                    }
                    model.ExamFeedbackString1 = dt.Rows[n]["ExamFeedbackString1"].ToString();
                    model.ExamFeedbackString2 = dt.Rows[n]["ExamFeedbackString2"].ToString();
                    if (dt.Rows[n]["UserInfoID"].ToString() != "")
                    {
                        model.UserInfoID = int.Parse(dt.Rows[n]["UserInfoID"].ToString());
                    }
                    model.UserTrueName = dt.Rows[n]["UserTrueName"].ToString();
                    if (dt.Rows[n]["ExamID"].ToString() != "")
                    {
                        model.ExamID = Guid.Parse(dt.Rows[n]["ExamID"].ToString());
                    }
                    model.ExamName = dt.Rows[n]["ExamName"].ToString();
                    model.RoleName = dt.Rows[n]["RoleName"].ToString();
                    model.ExamFeedbackContent = dt.Rows[n]["ExamFeedbackContent"].ToString();
                    if (dt.Rows[n]["ExamFeedbackDate"].ToString() != "")
                    {
                        model.ExamFeedbackDate = DateTime.Parse(dt.Rows[n]["ExamFeedbackDate"].ToString());
                    }
                    if (dt.Rows[n]["ExamFeedbackNumber1"].ToString() != "")
                    {
                        model.ExamFeedbackNumber1 = int.Parse(dt.Rows[n]["ExamFeedbackNumber1"].ToString());
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
        /// 添加ExamFeedback记录
        /// </summary>
        /// <param name="examFeedback"></param>
        /// <returns></returns>
        public bool AddExamFeedback(Model.ExamFeedback examFeedback)
        {
            return new DAL.ExamFeedback().Insert(examFeedback);
        }

        /// <summary>
        /// 删除ExamFeedback记录
        /// </summary>
        /// <param name="examFeedback"></param>
        /// <returns></returns>
        public bool RemoveExamFeedback(Model.ExamFeedback examFeedback)
        {
            return new DAL.ExamFeedback().Delete(examFeedback);
        }

        /// <summary>
        /// 修改ExamFeedback记录
        /// </summary>
        /// <param name="examFeedback"></param>
        /// <returns></returns>
        public bool ModifyExamFeedback(Model.ExamFeedback examFeedback)
        {
            return new DAL.ExamFeedback().Update((object)examFeedback);
        }

        /// <summary>
        /// 查询ExamFeedback下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchExamFeedbackIdentity()
        {
            return new DAL.ExamFeedback().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ExamFeedback记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchExamFeedbackCount()
        {
            return new DAL.ExamFeedback().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ExamFeedback记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchExamFeedbackCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamFeedback().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定examFeedbackID的ExamFeedback是否存在
        /// </summary>
        /// <param name="examFeedbackID"></param>
        /// <returns></returns>
        public bool? SearchExamFeedbackExists(object examFeedbackID)
        {
            return new DAL.ExamFeedback().SelectModelObjectExistsByID(examFeedbackID);
        }

        /// <summary>
        /// 查询指定条件的ExamFeedback是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchExamFeedbackExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamFeedback().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按examFeedbackID查询ExamFeedback
        /// </summary>
        /// <param name="examFeedbackID"></param>
        /// <returns></returns>
        public Model.ExamFeedback SearchExamFeedbackByID(object examFeedbackID)
        {
            return new DAL.ExamFeedback().SelectModelObjectByID(examFeedbackID);
        }

        /// <summary>
        /// 查询第一个ExamFeedback对象
        /// </summary>
        /// <returns></returns>
        public Model.ExamFeedback SearchUniqueExamFeedbackByCondition()
        {
            return new DAL.ExamFeedback().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ExamFeedback对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ExamFeedback SearchUniqueExamFeedbackByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamFeedback().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ExamFeedback对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ExamFeedback SearchUniqueExamFeedbackByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamFeedback().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ExamFeedback对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ExamFeedback> SearchExamFeedbackByCondition()
        {
            return new DAL.ExamFeedback().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ExamFeedback对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ExamFeedback> SearchExamFeedbackByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ExamFeedback().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ExamFeedback对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ExamFeedback> SearchExamFeedbackByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ExamFeedback().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ExamFeedback内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ExamFeedback> SearchExamFeedbackByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ExamFeedback().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion


        #region Extesion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityDictionary"></param>
        /// <returns></returns>
        public bool AddExamFeedbackInfo(Dictionary<string, object> entityDictionary)
        {
            List<List<object>> entityList = new List<List<object>>();
            entityList.Add(new List<object>() { "insert", ((List<Tellyes.Model.ExamFeedback>)entityDictionary["ExamFeedback,List,Add"]).ToList<object>() });
            return new DAL.ExamFeedback().Transaction(entityList);
        }

        #endregion
    }
}
