using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class ScoreLog
    {
        private readonly DAL.ScoreLog dal = new DAL.ScoreLog();
        public ScoreLog()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ScoreLogID)
        {
            return dal.Exists(ScoreLogID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ScoreLog model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.ScoreLog model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ScoreLogID)
        {

            return dal.Delete(ScoreLogID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string ScoreLogIDlist)
        {
            return dal.DeleteList(ScoreLogIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.ScoreLog GetModel(int ScoreLogID)
        {

            return dal.GetModel(ScoreLogID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.ScoreLog GetModelByCache(int ScoreLogID)
        {

            string CacheKey = "ScoreLogModel-" + ScoreLogID;
            object objModel = Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ScoreLogID);
                    if (objModel != null)
                    {
                        int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
                        Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.ScoreLog)objModel;
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
        public List<Model.ScoreLog> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
      /// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.ScoreLog> DataTableToList(DataTable dt)
		{
			List<Model.ScoreLog> modelList = new List<Model.ScoreLog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.ScoreLog model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.ScoreLog();					
				if(dt.Rows[n]["ScoreLogID"].ToString()!="")
				{
					model.ScoreLogID=int.Parse(dt.Rows[n]["ScoreLogID"].ToString());
				}
			    if(dt.Rows[n]["Score"].ToString()!="")
				{
					model.Score=decimal.Parse(dt.Rows[n]["Score"].ToString());
				}
				if(dt.Rows[n]["ScoreLogNumber1"].ToString()!="")
				{
					model.ScoreLogNumber1=int.Parse(dt.Rows[n]["ScoreLogNumber1"].ToString());
				}
				if(dt.Rows[n]["ScoreLogNumber2"].ToString()!="")
				{
					model.ScoreLogNumber2=decimal.Parse(dt.Rows[n]["ScoreLogNumber2"].ToString());
				}
					model.ScoreLogString1= dt.Rows[n]["ScoreLogString1"].ToString();
				    model.ScoreLogString2= dt.Rows[n]["ScoreLogString2"].ToString();
		        if(dt.Rows[n]["ScoreLogDatetime1"].ToString()!="")
				{
					model.ScoreLogDatetime1=DateTime.Parse(dt.Rows[n]["ScoreLogDatetime1"].ToString());
				}
				if(dt.Rows[n]["ScoreLogDatetime2"].ToString()!="")
				{
					model.ScoreLogDatetime2=DateTime.Parse(dt.Rows[n]["ScoreLogDatetime2"].ToString());
				}
				if(dt.Rows[n]["MS_ID"].ToString()!="")
				{
					model.MS_ID=int.Parse(dt.Rows[n]["MS_ID"].ToString());
				}
				if(dt.Rows[n]["ScorePercent"].ToString()!="")
				{
					model.ScorePercent=int.Parse(dt.Rows[n]["ScorePercent"].ToString());
				}
				if(dt.Rows[n]["ExamStationScore"].ToString()!="")
				{
					model.ExamStationScore=decimal.Parse(dt.Rows[n]["ExamStationScore"].ToString());
				}
				if(dt.Rows[n]["LogUserInfoID"].ToString()!="")
				{
					model.LogUserInfoID=int.Parse(dt.Rows[n]["LogUserInfoID"].ToString());
				}
				if(dt.Rows[n]["ExamStationPercent"].ToString()!="")
				{
					model.ExamStationPercent=int.Parse(dt.Rows[n]["ExamStationPercent"].ToString());
				}
				if(dt.Rows[n]["ExamScore"].ToString()!="")
				{
					model.ExamScore=decimal.Parse(dt.Rows[n]["ExamScore"].ToString());
				}
			    if(dt.Rows[n]["LogDatetime"].ToString()!="")
				{
					model.LogDatetime=DateTime.Parse(dt.Rows[n]["LogDatetime"].ToString());
				}
				if(dt.Rows[n]["LogType"].ToString()!="")
				{
					model.LogType=int.Parse(dt.Rows[n]["LogType"].ToString());
				}
				if(dt.Rows[n]["ScoreSummariedScoreID"].ToString()!="")
				{
					model.ScoreSummariedScoreID=int.Parse(dt.Rows[n]["ScoreSummariedScoreID"].ToString());
				}
                if (dt.Rows[n]["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(dt.Rows[n]["E_ID"].ToString());
                }
                if (dt.Rows[n]["ES_ID"].ToString() != "")
                {
                    model.ES_ID = Guid.Parse(dt.Rows[n]["ES_ID"].ToString());
                }
				if(dt.Rows[n]["Room_ID"].ToString()!="")
				{
					model.Room_ID=int.Parse(dt.Rows[n]["Room_ID"].ToString());
				}
				if(dt.Rows[n]["StudentUserInfoID"].ToString()!="")
				{
					model.StudentUserInfoID=int.Parse(dt.Rows[n]["StudentUserInfoID"].ToString());
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
        /// 添加ScoreLog记录
        /// </summary>
        /// <param name="scoreLog"></param>
        /// <returns></returns>
        public bool AddScoreLog(Model.ScoreLog scoreLog)
        {
            return new DAL.ScoreLog().Insert(scoreLog);
        }

        /// <summary>
        /// 删除ScoreLog记录
        /// </summary>
        /// <param name="scoreLog"></param>
        /// <returns></returns>
        public bool RemoveScoreLog(Model.ScoreLog scoreLog)
        {
            return new DAL.ScoreLog().Delete(scoreLog);
        }

        /// <summary>
        /// 修改ScoreLog记录
        /// </summary>
        /// <param name="scoreLog"></param>
        /// <returns></returns>
        public bool ModifyScoreLog(Model.ScoreLog scoreLog)
        {
            return new DAL.ScoreLog().Update((object)scoreLog);
        }

        /// <summary>
        /// 查询ScoreLog下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreLogIdentity()
        {
            return new DAL.ScoreLog().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部ScoreLog记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchScoreLogCount()
        {
            return new DAL.ScoreLog().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreLog记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchScoreLogCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreLog().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定scoreLogID的ScoreLog是否存在
        /// </summary>
        /// <param name="scoreLogID"></param>
        /// <returns></returns>
        public bool? SearchScoreLogExists(object scoreLogID)
        {
            return new DAL.ScoreLog().SelectModelObjectExistsByID(scoreLogID);
        }

        /// <summary>
        /// 查询指定条件的ScoreLog是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchScoreLogExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreLog().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按scoreLogID查询ScoreLog
        /// </summary>
        /// <param name="scoreLogID"></param>
        /// <returns></returns>
        public Model.ScoreLog SearchScoreLogByID(object scoreLogID)
        {
            return new DAL.ScoreLog().SelectModelObjectByID(scoreLogID);
        }

        /// <summary>
        /// 查询第一个ScoreLog对象
        /// </summary>
        /// <returns></returns>
        public Model.ScoreLog SearchUniqueScoreLogByCondition()
        {
            return new DAL.ScoreLog().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个ScoreLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.ScoreLog SearchUniqueScoreLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreLog().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个ScoreLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.ScoreLog SearchUniqueScoreLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreLog().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部ScoreLog对象
        /// </summary>
        /// <returns></returns>
        public List<Model.ScoreLog> SearchScoreLogByCondition()
        {
            return new DAL.ScoreLog().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询ScoreLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.ScoreLog> SearchScoreLogByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.ScoreLog().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询ScoreLog对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.ScoreLog> SearchScoreLogByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.ScoreLog().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询ScoreLog内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.ScoreLog> SearchScoreLogByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.ScoreLog().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchScoreLogInfo(Dictionary<string, object> conditionDictionary)
        {
            List<object[]> _scoreLogList = new Tellyes.DAL.ScoreLog().SelectScoreLogInfo(conditionDictionary);
                
            if (_scoreLogList == null)
            {
                Log4NetUtility.Error(this, "查询成绩日志信息失败");
                return null;
            }
            List<Dictionary<string, object>> logInfoList = new List<Dictionary<string, object>>();
            foreach (object[] item in _scoreLogList)
            {
                logInfoList.Add(new Dictionary<string, object>() 
                    { 
                    {"ScoreLog", item[0]},
                    {"ES_Name", item[1]}, 
                    {"LogUserInfoName", item[2]},
                    {"MS_Name", item[3]},
                    {"Room_Name", item[4]}
                });
            }
            return logInfoList;
        }
        

        #endregion
    }
}
