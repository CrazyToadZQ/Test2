using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
using System.Linq;
namespace Tellyes.BLL
{
    /// <summary>
    /// MarkSheet
    /// </summary>
    public partial class MarkSheet
    {
        private readonly Tellyes.DAL.MarkSheet dal = new Tellyes.DAL.MarkSheet();
        public MarkSheet()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MS_ID)
        {
            return dal.Exists(MS_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MarkSheet model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.MarkSheet model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MS_ID)
        {

            return dal.Delete(MS_ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string MS_IDlist)
        {
            return dal.DeleteList(MS_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.MarkSheet GetModel(int MS_ID)
        {

            return dal.GetModel(MS_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.MarkSheet GetModelByCache(int MS_ID)
        {

            string CacheKey = "MarkSheetModel-" + MS_ID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MS_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.MarkSheet)objModel;
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
        public List<Model.MarkSheet> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.MarkSheet> DataTableToList(DataTable dt)
        {
            List<Model.MarkSheet> modelList = new List<Model.MarkSheet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.MarkSheet model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.MarkSheet();
                    if (dt.Rows[n]["MS_ID"].ToString() != "")
                    {
                        model.MS_ID = int.Parse(dt.Rows[n]["MS_ID"].ToString());
                    }
                    model.string1 = dt.Rows[n]["string1"].ToString();
                    model.string2 = dt.Rows[n]["string2"].ToString();
                    model.string3 = dt.Rows[n]["string3"].ToString();
                    model.string4 = dt.Rows[n]["string4"].ToString();
                    if (dt.Rows[n]["MarkSheetNumber1"].ToString() != "")
                    {
                        model.MarkSheetNumber1 = int.Parse(dt.Rows[n]["MarkSheetNumber1"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetNumber2"].ToString() != "")
                    {
                        model.MarkSheetNumber2 = int.Parse(dt.Rows[n]["MarkSheetNumber2"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetNumber3"].ToString() != "")
                    {
                        model.MarkSheetNumber3 = decimal.Parse(dt.Rows[n]["MarkSheetNumber3"].ToString());
                    }
                    if (dt.Rows[n]["MarkSheetNumber4"].ToString() != "")
                    {
                        model.MarkSheetNumber4 = decimal.Parse(dt.Rows[n]["MarkSheetNumber4"].ToString());
                    }
                    if (dt.Rows[n]["User_ID"].ToString() != "")
                    {
                        model.User_ID = int.Parse(dt.Rows[n]["User_ID"].ToString());
                    }
                    if (dt.Rows[n]["MSK_ID"].ToString() != "")
                    {
                        model.MSK_ID = int.Parse(dt.Rows[n]["MSK_ID"].ToString());
                    }
                    model.MS_Name = dt.Rows[n]["MS_Name"].ToString();
                    if (dt.Rows[n]["MS_Share"].ToString() != "")
                    {
                        model.MS_Share = int.Parse(dt.Rows[n]["MS_Share"].ToString());
                    }
                    if (dt.Rows[n]["MS_CreateDate"].ToString() != "")
                    {
                        model.MS_CreateDate = DateTime.Parse(dt.Rows[n]["MS_CreateDate"].ToString());
                    }
                    if (dt.Rows[n]["MS_ModifyDate"].ToString() != "")
                    {
                        model.MS_ModifyDate = DateTime.Parse(dt.Rows[n]["MS_ModifyDate"].ToString());
                    }
                    if (dt.Rows[n]["MS_ModifyPerson"].ToString() != "")
                    {
                        model.MS_ModifyPerson = int.Parse(dt.Rows[n]["MS_ModifyPerson"].ToString());
                    }
                    if (dt.Rows[n]["MS_Score"].ToString() != "")
                    {
                        model.MS_Score = decimal.Parse(dt.Rows[n]["MS_Score"].ToString());
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
        #endregion  BasicMethod

        #region Extension NHibernate

        /// <summary>
        /// 添加MarkSheet记录
        /// </summary>
        /// <param name="markSheet"></param>
        /// <returns></returns>
        public bool AddMarkSheet(Model.MarkSheet markSheet)
        {
            return new DAL.MarkSheet().Insert(markSheet);
        }

        /// <summary>
        /// 删除MarkSheet记录
        /// </summary>
        /// <param name="markSheet"></param>
        /// <returns></returns>
        public bool RemoveMarkSheet(Model.MarkSheet markSheet)
        {
            return new DAL.MarkSheet().Delete(markSheet);
        }

        /// <summary>
        /// 修改MarkSheet记录
        /// </summary>
        /// <param name="markSheet"></param>
        /// <returns></returns>
        public bool ModifyMarkSheet(Model.MarkSheet markSheet)
        {
            return new DAL.MarkSheet().Update((object)markSheet);
        }

        /// <summary>
        /// 查询MarkSheet下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchMarkSheetIdentity()
        {
            return new DAL.MarkSheet().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部MarkSheet记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchMarkSheetCount()
        {
            return new DAL.MarkSheet().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询MarkSheet记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchMarkSheetCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheet().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定mS_ID的MarkSheet是否存在
        /// </summary>
        /// <param name="mS_ID"></param>
        /// <returns></returns>
        public bool? SearchMarkSheetExists(object mS_ID)
        {
            return new DAL.MarkSheet().SelectModelObjectExistsByID(mS_ID);
        }

        /// <summary>
        /// 查询指定条件的MarkSheet是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchMarkSheetExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheet().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按mS_ID查询MarkSheet
        /// </summary>
        /// <param name="mS_ID"></param>
        /// <returns></returns>
        public Model.MarkSheet SearchMarkSheetByID(object mS_ID)
        {
            return new DAL.MarkSheet().SelectModelObjectByID(mS_ID);
        }

        /// <summary>
        /// 查询第一个MarkSheet对象
        /// </summary>
        /// <returns></returns>
        public Model.MarkSheet SearchUniqueMarkSheetByCondition()
        {
            return new DAL.MarkSheet().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个MarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.MarkSheet SearchUniqueMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个MarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.MarkSheet SearchUniqueMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MarkSheet().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部MarkSheet对象
        /// </summary>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByCondition()
        {
            return new DAL.MarkSheet().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询MarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheet().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询MarkSheet对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.MarkSheet().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询MarkSheet内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.MarkSheet().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region  ExtensionMethod
        /// <summary>
        /// 返回评分表列表
        /// </summary>
        /// <param name="sheetSort">评分表类别（0代表全部）</param>
        /// <param name="sheetKind">类型（1代表个人评分表，2代表他人评分表，3代表系统评分表）</param>
        /// <param name="userID">用户id（0代表admin，-1代表系统评分表）</param>
        /// <param name="searchSheetName">评分表名称（查询关键字）</param>
        /// <returns></returns>
        public DataSet GetMarkSheetList(string sheetSort, string[] sheetKinds, int userID, string searchSheetName)
        {
            return dal.GetMarkSheetList(sheetSort, sheetKinds, userID, searchSheetName);
        }

        /// <summary>
        /// 获取单个评分表信息
        /// </summary>
        /// <param name="ms_id">父评分表id</param>
        /// <returns></returns>
        public DataSet GetSingleMarkSheet(string ms_id)
        {
            return dal.GetSingleMarkSheet(ms_id);
        }

        /// <summary>
        /// 更新评分表（父表 + 子表），含二级评分项.（事务操作）
        /// </summary>
        /// <param name="model">父表</param>
        /// <param name="dtParentItem">父评分项表</param>
        /// <param name="ChildrenItemList">子评分项表</param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Update(Tellyes.Model.MarkSheet model, DataTable dtParentItem, System.Collections.Generic.List<DataTable> ChildrenItemList)
        {
            return dal.ExecuteSqlTran_Update(model, dtParentItem, ChildrenItemList);
        }

        /// <summary>
        /// 插入评分表（父表 + 子表），含二级评分项.（事务操作）
        /// </summary>
        /// <param name="model">父表model</param>
        /// <param name="dtParentItem">父评分项表</param>
        /// <param name="ChildrenItemList">子评分项表</param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(Tellyes.Model.MarkSheet model, DataTable dtParentItem, System.Collections.Generic.List<DataTable> ChildrenItemList)
        {
            return dal.ExecuteSqlTran_Insert(model, dtParentItem, ChildrenItemList);
        }

        /// <summary>
        /// 根据病例脚本，获得评分表集合
        /// </summary>
        /// <param name="icsID"></param>
        /// <returns></returns>
        public DataSet getMsFromIllnessCaseScript(string icsID)
        {
            return dal.getMsFromIllnessCaseScript(icsID);
        }

        #endregion  ExtensionMethod

        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ES_ID"></param>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public List<Model.MarkSheet> SearchMarkSheetByExamStationIDAndUserInfoID(Guid ES_ID, int U_ID)
        {
            return new DAL.MarkSheet().SelectMarkSheetByExamStationIDAndUserInfoID(ES_ID, U_ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examTableID"></param>
        /// <returns></returns>
        public Dictionary<Guid, decimal> SearchMarkSheetScoreByExamTableID(Guid examTableID)
        {
            List<object[]> examStationIDMarkSheetScoreList = new DAL.MarkSheet().SelectMarkSheetScoreByExamTableID(examTableID);
            if (examStationIDMarkSheetScoreList == null)
            {
                Log4NetUtility.Error(this, "查询考试使用的评分表信息失败，examTableID：" + examTableID);
                return null;
            }
            Dictionary<Guid, decimal> examStationIDMarkSheetScoreDictionary = new Dictionary<Guid, decimal>();
            foreach (object[] examStationIDMarkSheetScore in examStationIDMarkSheetScoreList) 
            {
                examStationIDMarkSheetScoreDictionary.Add(Guid.Parse(examStationIDMarkSheetScore[0].ToString()), Convert.ToDecimal(examStationIDMarkSheetScore[1]));
            }
            return examStationIDMarkSheetScoreDictionary;
        }


        public int? SearchMarkSheetCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.MarkSheet().SelectMarkSheetCountByCondition(conditionDictionary);

        }
        
        /// <summary>
        /// 查询评分表信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>>  SearchMarkSheetInfoByCondition(Dictionary<string, object> conditionDictionary,int pageIndex,int pageSize)
        {
            List<object[]> markSheetInfoObjectList = new DAL.MarkSheet().SelectMarkSheetInfoByCondition(conditionDictionary, pageIndex, pageSize);
            if (markSheetInfoObjectList == null)
            {
                Log4NetUtility.Error(this, "查询考试使用的评分表信息失败");
                return null;
            }

            List<Dictionary<string, object>> markSheetInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in markSheetInfoObjectList)
            {
                markSheetInfoList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"User_ID", item[0]},
                        {"U_Name", item[1]},
                        {"MSK_ID", item[2]},
                        {"MSK_Kind", item[3]},
                        {"MS_Name", item[4]},
                        {"MS_Share", item[5]},
                        {"MS_CreateDate", item[6]},
                        {"MS_ID", item[7]}
                    }
                );
            }
            return markSheetInfoList;
        }

        /// <summary>
        ///  删除评分表记录，由于设置了逻辑删除列，所以仅仅是对此条记录的逻辑删除列(MarkSheet为string1，MarkSheetItem待定)的值进行更新，即从“0”变为“-1”。实际数据库中的记录将不被删除
        /// </summary>
        /// <param name="markSheetList"></param>
        /// <param name="markSheetItemList"></param>
        /// <returns></returns>
        public bool RemoveMarkSheetInfoByCondition(List<Tellyes.Model.MarkSheet> markSheetList, List<Tellyes.Model.MarkSheetItem> markSheetItemList)
        {
            return new Tellyes.DAL.MarkSheet().Transaction(
               new List<List<object>>() 
                { 
                    new List<object>(){"update", markSheetList.ToList<object>()},
                    new List<object>(){"update", markSheetItemList.ToList<object>()}
                }
           );
        }



        /// <summary>
        /// 增加一条房间记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool AddMarkSheetInfo(List<Tellyes.Model.MarkSheet> markSheetList, List<Tellyes.Model.MarkSheetItem> markSheetItemList)
        {
            return new Tellyes.DAL.MarkSheet().Transaction(
                new List<List<object>>() 
                { 
                    new List<object>(){"insert", markSheetList.ToList<object>()},
                    new List<object>(){"insert", markSheetItemList.ToList<object>()}
                }
            );
        }

        #endregion

        #region 获取总的数据
        public DataSet GetMarkSheetListNew(string pageIndex, string pageSize, string msName, string mskID)
        {
            return dal.GetMarkSheetListNew(pageIndex, pageSize, msName, mskID);
        }
        #endregion

        #region 获取评分表的总的记录的数量
        public object GetMarkSheetListNewALL( string msName, string mskID) {

            return dal.GetMarkSheetListNewALL( msName, mskID);
        }
        #endregion

        #region 新增加评分表
        /// <summary>
        /// 新增加评分表,如果插入数据成功就返回true方法，否则返回的是false
        /// </summary>
        /// <returns></returns>
        public bool AddMarkSheetnew(Tellyes.Model.MarkSheet mark)
        {
            return dal.AddMarkSheet(mark) > 0 ? true : false;
        }
        #endregion

        #region 编辑评分表数据
        public bool EditMarkSheetNew(Tellyes.Model.MarkSheet mark)
        {
            return dal.EditMarkSheetNew(mark) > 0 ? true : false;

        }
        #endregion

        #region 删除评分表的数据
        public bool DelMarkSheetNew(string condition)
        {
            return dal.DelMarkSheetNew(condition) > 0 ? true : false;

        }
        #endregion 

        #region 获取到的是一级评分表中的数据
        /// <summary>
        /// 获取到的是一级评分表中的数据
        /// </summary>
        /// <returns></returns>
        public DataSet getMarkSheetLists()
        {
            return dal.getMarkSheetLists();
        }
        #endregion


    }
}