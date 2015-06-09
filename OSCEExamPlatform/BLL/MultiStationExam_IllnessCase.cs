using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    public class MultiStationExam_IllnessCase
    {
        private readonly DAL.MultiStationExam_IllnessCase dal = new DAL.MultiStationExam_IllnessCase();
        public MultiStationExam_IllnessCase()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Exam_Station_IllnessCase_ID)
        {
            return dal.Exists(Exam_Station_IllnessCase_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MultiStationExam_IllnessCase model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.MultiStationExam_IllnessCase model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Exam_Station_IllnessCase_ID)
        {

            return dal.Delete(Exam_Station_IllnessCase_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string Exam_Station_IllnessCase_IDlist)
        {
            return dal.DeleteList(Exam_Station_IllnessCase_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.MultiStationExam_IllnessCase GetModel(int Exam_Station_IllnessCase_ID)
        {

            return dal.GetModel(Exam_Station_IllnessCase_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.MultiStationExam_IllnessCase GetModelByCache(int Exam_Station_IllnessCase_ID)
        {

            string CacheKey = "MultiStationExam_IllnessCaseModel-" + Exam_Station_IllnessCase_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Exam_Station_IllnessCase_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.MultiStationExam_IllnessCase)objModel;
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
        public List<Model.MultiStationExam_IllnessCase> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.MultiStationExam_IllnessCase> DataTableToList(DataTable dt)
        {
            List<Model.MultiStationExam_IllnessCase> modelList = new List<Model.MultiStationExam_IllnessCase>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.MultiStationExam_IllnessCase model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.MultiStationExam_IllnessCase();
                    if (dt.Rows[n]["Exam_Station_IllnessCase_ID"].ToString() != "")
                    {
                        model.Exam_Station_IllnessCase_ID = int.Parse(dt.Rows[n]["Exam_Station_IllnessCase_ID"].ToString());
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
                    model.String5 = dt.Rows[n]["String5"].ToString();
                    if (dt.Rows[n]["Exam_ID"].ToString() != "")
                    {
                        model.Exam_ID = Guid.Parse(dt.Rows[n]["Exam_ID"].ToString());
                    }
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
                    if (dt.Rows[n]["Exam_Station_ID"].ToString() != "")
                    {
                        model.Exam_Station_ID = Guid.Parse(dt.Rows[n]["Exam_Station_ID"].ToString());
                    }
                    if (dt.Rows[n]["Room_ID"].ToString() != "")
                    {
                        model.Room_ID = int.Parse(dt.Rows[n]["Room_ID"].ToString());
                    }
                    if (dt.Rows[n]["Illness_Case_ID"].ToString() != "")
                    {
                        model.Illness_Case_ID = int.Parse(dt.Rows[n]["Illness_Case_ID"].ToString());
                    }
                    if (dt.Rows[n]["Illness_Case_Script_ID"].ToString() != "")
                    {
                        model.Illness_Case_Script_ID = int.Parse(dt.Rows[n]["Illness_Case_Script_ID"].ToString());
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
        /// 添加MultiStationExam_IllnessCase记录
        /// </summary>
        /// <param name="multiStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool AddMultiStationExam_IllnessCase(Model.MultiStationExam_IllnessCase multiStationExam_IllnessCase)
        {
            return new DAL.MultiStationExam_IllnessCase().Insert(multiStationExam_IllnessCase);
        }

        /// <summary>
        /// 删除MultiStationExam_IllnessCase记录
        /// </summary>
        /// <param name="multiStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool RemoveMultiStationExam_IllnessCase(Model.MultiStationExam_IllnessCase multiStationExam_IllnessCase)
        {
            return new DAL.MultiStationExam_IllnessCase().Delete(multiStationExam_IllnessCase);
        }

        /// <summary>
        /// 修改MultiStationExam_IllnessCase记录
        /// </summary>
        /// <param name="multiStationExam_IllnessCase"></param>
        /// <returns></returns>
        public bool ModifyMultiStationExam_IllnessCase(Model.MultiStationExam_IllnessCase multiStationExam_IllnessCase)
        {
            return new DAL.MultiStationExam_IllnessCase().Update((object)multiStationExam_IllnessCase);
        }

        /// <summary>
        /// 查询MultiStationExam_IllnessCase下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExam_IllnessCaseIdentity()
        {
            return new DAL.MultiStationExam_IllnessCase().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部MultiStationExam_IllnessCase记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchMultiStationExam_IllnessCaseCount()
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExam_IllnessCase记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchMultiStationExam_IllnessCaseCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定exam_Station_IllnessCase_ID的MultiStationExam_IllnessCase是否存在
        /// </summary>
        /// <param name="exam_Station_IllnessCase_ID"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExam_IllnessCaseExists(object exam_Station_IllnessCase_ID)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectExistsByID(exam_Station_IllnessCase_ID);
        }

        /// <summary>
        /// 查询指定条件的MultiStationExam_IllnessCase是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchMultiStationExam_IllnessCaseExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按exam_Station_IllnessCase_ID查询MultiStationExam_IllnessCase
        /// </summary>
        /// <param name="exam_Station_IllnessCase_ID"></param>
        /// <returns></returns>
        public Model.MultiStationExam_IllnessCase SearchMultiStationExam_IllnessCaseByID(object exam_Station_IllnessCase_ID)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectByID(exam_Station_IllnessCase_ID);
        }

        /// <summary>
        /// 查询第一个MultiStationExam_IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public Model.MultiStationExam_IllnessCase SearchUniqueMultiStationExam_IllnessCaseByCondition()
        {
            return new DAL.MultiStationExam_IllnessCase().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个MultiStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.MultiStationExam_IllnessCase SearchUniqueMultiStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个MultiStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.MultiStationExam_IllnessCase SearchUniqueMultiStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部MultiStationExam_IllnessCase对象
        /// </summary>
        /// <returns></returns>
        public List<Model.MultiStationExam_IllnessCase> SearchMultiStationExam_IllnessCaseByCondition()
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询MultiStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_IllnessCase> SearchMultiStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询MultiStationExam_IllnessCase对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_IllnessCase> SearchMultiStationExam_IllnessCaseByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询MultiStationExam_IllnessCase内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.MultiStationExam_IllnessCase> SearchMultiStationExam_IllnessCaseByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.MultiStationExam_IllnessCase().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion
    }
}
