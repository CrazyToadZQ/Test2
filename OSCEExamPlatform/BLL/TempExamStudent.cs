using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class TempExamStudent
    {
        private readonly DAL.TempExamStudent dal = new DAL.TempExamStudent();
        public TempExamStudent()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid TempExamStudentID)
        {
            return dal.Exists(TempExamStudentID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TempExamStudent model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TempExamStudent model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid TempExamStudentID)
        {

            return dal.Delete(TempExamStudentID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TempExamStudent GetModel(Guid TempExamStudentID)
        {

            return dal.GetModel(TempExamStudentID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.TempExamStudent GetModelByCache(Guid TempExamStudentID)
        {

            string CacheKey = "TempExamStudentModel-" + TempExamStudentID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(TempExamStudentID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.TempExamStudent)objModel;
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
        public List<Model.TempExamStudent> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.TempExamStudent> DataTableToList(DataTable dt)
        {
            List<Model.TempExamStudent> modelList = new List<Model.TempExamStudent>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.TempExamStudent model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.TempExamStudent();
                    if (dt.Rows[n]["TempExamStudentID"].ToString() != "")
                    {
                        model.TempExamStudentID = Guid.Parse(dt.Rows[n]["TempExamStudentID"].ToString());
                    }
                    model.TempExamStudentString2 = dt.Rows[n]["TempExamStudentString2"].ToString();
                    model.TempExamStudentString3 = dt.Rows[n]["TempExamStudentString3"].ToString();
                    model.TempExamStudentString4 = dt.Rows[n]["TempExamStudentString4"].ToString();
                    if (dt.Rows[n]["TempExamStudentDatetime1"].ToString() != "")
                    {
                        model.TempExamStudentDatetime1 = DateTime.Parse(dt.Rows[n]["TempExamStudentDatetime1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentDatetime2"].ToString() != "")
                    {
                        model.TempExamStudentDatetime2 = DateTime.Parse(dt.Rows[n]["TempExamStudentDatetime2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamTableID"].ToString() != "")
                    {
                        model.TempExamTableID = Guid.Parse(dt.Rows[n]["TempExamTableID"].ToString());
                    }
                    if (dt.Rows[n]["UserInfoID"].ToString() != "")
                    {
                        model.UserInfoID = int.Parse(dt.Rows[n]["UserInfoID"].ToString());
                    }
                    if (dt.Rows[n]["ExamNumber"].ToString() != "")
                    {
                        model.ExamNumber = int.Parse(dt.Rows[n]["ExamNumber"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentNumber1"].ToString() != "")
                    {
                        model.TempExamStudentNumber1 = int.Parse(dt.Rows[n]["TempExamStudentNumber1"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentNumber2"].ToString() != "")
                    {
                        model.TempExamStudentNumber2 = int.Parse(dt.Rows[n]["TempExamStudentNumber2"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentNumber3"].ToString() != "")
                    {
                        model.TempExamStudentNumber3 = decimal.Parse(dt.Rows[n]["TempExamStudentNumber3"].ToString());
                    }
                    if (dt.Rows[n]["TempExamStudentNumber4"].ToString() != "")
                    {
                        model.TempExamStudentNumber4 = decimal.Parse(dt.Rows[n]["TempExamStudentNumber4"].ToString());
                    }
                    model.TempExamStudentString1 = dt.Rows[n]["TempExamStudentString1"].ToString();


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
        /// 添加TempExamStudent记录
        /// </summary>
        /// <param name="tempExamStudent"></param>
        /// <returns></returns>
        public bool AddTempExamStudent(Model.TempExamStudent tempExamStudent)
        {
            return new DAL.TempExamStudent().Insert(tempExamStudent);
        }

        /// <summary>
        /// 删除TempExamStudent记录
        /// </summary>
        /// <param name="tempExamStudent"></param>
        /// <returns></returns>
        public bool RemoveTempExamStudent(Model.TempExamStudent tempExamStudent)
        {
            return new DAL.TempExamStudent().Delete(tempExamStudent);
        }

        /// <summary>
        /// 修改TempExamStudent记录
        /// </summary>
        /// <param name="tempExamStudent"></param>
        /// <returns></returns>
        public bool ModifyTempExamStudent(Model.TempExamStudent tempExamStudent)
        {
            return new DAL.TempExamStudent().Update((object)tempExamStudent);
        }

        /// <summary>
        /// 查询TempExamStudent下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStudentIdentity()
        {
            return new DAL.TempExamStudent().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部TempExamStudent记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchTempExamStudentCount()
        {
            return new DAL.TempExamStudent().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStudent记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchTempExamStudentCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStudent().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定tempExamStudentID的TempExamStudent是否存在
        /// </summary>
        /// <param name="tempExamStudentID"></param>
        /// <returns></returns>
        public bool? SearchTempExamStudentExists(object tempExamStudentID)
        {
            return new DAL.TempExamStudent().SelectModelObjectExistsByID(tempExamStudentID);
        }

        /// <summary>
        /// 查询指定条件的TempExamStudent是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchTempExamStudentExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStudent().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按tempExamStudentID查询TempExamStudent
        /// </summary>
        /// <param name="tempExamStudentID"></param>
        /// <returns></returns>
        public Model.TempExamStudent SearchTempExamStudentByID(object tempExamStudentID)
        {
            return new DAL.TempExamStudent().SelectModelObjectByID(tempExamStudentID);
        }

        /// <summary>
        /// 查询第一个TempExamStudent对象
        /// </summary>
        /// <returns></returns>
        public Model.TempExamStudent SearchUniqueTempExamStudentByCondition()
        {
            return new DAL.TempExamStudent().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个TempExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.TempExamStudent SearchUniqueTempExamStudentByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStudent().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个TempExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.TempExamStudent SearchUniqueTempExamStudentByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStudent().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部TempExamStudent对象
        /// </summary>
        /// <returns></returns>
        public List<Model.TempExamStudent> SearchTempExamStudentByCondition()
        {
            return new DAL.TempExamStudent().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询TempExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.TempExamStudent> SearchTempExamStudentByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.TempExamStudent().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询TempExamStudent对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.TempExamStudent> SearchTempExamStudentByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.TempExamStudent().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询TempExamStudent内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.TempExamStudent> SearchTempExamStudentByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.TempExamStudent().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        /// <summary>
        /// 带条件查询指定单站考试中考生用户信息和组织机构信息
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public DataTable SelectUserInfoAndOrganizationByTempExamTableID(Dictionary<string, object> conditionDictionary)
        {
            DataTable objectList = new DAL.TempExamStudent().SelectUserInfoAndOrganizationByTempExamTableID(conditionDictionary);
            if (objectList == null)
            {
                Log4NetUtility.Error(this, "查询单站考生的用户信息失败");
                return null;
            }

            return objectList;
        }

        #endregion

        #region Extesion


        #endregion

        #region 协和兼容
        public static List<Tellyes.Model.TempExamStudent> ReOrderDataByU_Name(List<Tellyes.Model.TempExamStudent> dataToParse) 
        {
            List<Tellyes.Model.TempExamStudent> result = new List<Model.TempExamStudent>();
            List<Tellyes.Model.UserInfo> userInfoList = new List<Model.UserInfo>();
            List<int> userInfoIDList = new List<int>();
            foreach (Tellyes.Model.TempExamStudent item in dataToParse)
            {
                userInfoIDList.Add(item.UserInfoID);
            }
            StringBuilder uidListInSql = new StringBuilder();
            string fengefu = String.Empty;
            foreach (int u_id in userInfoIDList) 
            {
                uidListInSql.Append(fengefu + "'" + u_id + "'");
                fengefu = ",";
            }
            userInfoList = new Tellyes.BLL.UserInfo().GetModelList(" U_ID in (" + uidListInSql.ToString().Trim() + ") ").OrderBy(e=>e.U_Name).ToList();
            int indexID = 0;
            foreach (Tellyes.Model.UserInfo userInfo in userInfoList) 
            {
                var tempItem = dataToParse.Where(e => e.UserInfoID == userInfo.U_ID).FirstOrDefault();
                if (tempItem != null) 
                {
                    tempItem.ExamNumber = indexID;
                    result.Add(tempItem);
                    indexID = indexID + 1;
                }
            }
            return result;
        }

        public static List<Tellyes.Model.ExamStudent> ReOrderDataByU_Name_NoTemp(List<Tellyes.Model.ExamStudent> dataToParse) 
        {
            List<Tellyes.Model.ExamStudent> result = new List<Model.ExamStudent>();
            List<Tellyes.Model.UserInfo> userInfoList = new List<Model.UserInfo>();
            List<int> userInfoIDList = new List<int>();
            foreach (Tellyes.Model.ExamStudent item in dataToParse)
            {
                userInfoIDList.Add(item.U_ID);
            }
            StringBuilder uidListInSql = new StringBuilder();
            string fengefu = String.Empty;
            foreach (int u_id in userInfoIDList)
            {
                uidListInSql.Append(fengefu + "'" + u_id + "'");
                fengefu = ",";
            }
            userInfoList = new Tellyes.BLL.UserInfo().GetModelList(" U_ID in (" + uidListInSql.ToString().Trim() + ") ").OrderBy(e => e.U_Name).ToList();
            int indexID = 1;
            foreach (Tellyes.Model.UserInfo userInfo in userInfoList)
            {
                var item = dataToParse.Where(e => e.U_ID == userInfo.U_ID).FirstOrDefault();
                if (item != null)
                {
                    item.EStu_ExamNumber = indexID;
                    result.Add(item);
                    indexID = indexID + 1;
                }
            }
            return result;
        }
        #endregion
    }
}
