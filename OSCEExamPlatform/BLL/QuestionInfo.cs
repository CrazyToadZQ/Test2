
using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// QuestionInfo
	/// </summary>
	public partial class QuestionInfo
	{
		private readonly Tellyes.DAL.QuestionInfo dal=new Tellyes.DAL.QuestionInfo();
		public QuestionInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Q_ID)
		{
			return dal.Exists(Q_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.QuestionInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.QuestionInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Q_ID)
		{
			
			return dal.Delete(Q_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Q_IDlist )
		{
			return dal.DeleteList(Q_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.QuestionInfo GetModel(int Q_ID)
		{
			
			return dal.GetModel(Q_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.QuestionInfo GetModelByCache(int Q_ID)
		{
			
			string CacheKey = "QuestionInfoModel-" + Q_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Q_ID);
					if (objModel != null)
					{
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.QuestionInfo)objModel;
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.QuestionInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.QuestionInfo> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.QuestionInfo> modelList = new List<Tellyes.Model.QuestionInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.QuestionInfo model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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

        /// <summary>
        /// 查找该试题库中的试题是否已经存在于试卷试题库内
        /// </summary>
        /// <param name="EQID"></param>
        /// <returns></returns>
        public bool IsQID(string EQID)
        {
            bool ret = false;
            DataTable dt = dal.GetQID(EQID).Tables[0];
            int rows = dt.Rows.Count;
            if (rows > 0)
            {
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// 通过EQ_ID查找Q_ID
        /// </summary>
        /// <param name="EQ_ID"></param>
        /// <returns></returns>
        public string GetQID(string EQ_ID)
        {
            string QID = "";
            DataTable dt = dal.GetQID(EQ_ID).Tables[0];
            if (dt.Rows.Count > 0)
            {
                QID = dt.Rows[0]["Q_ID"].ToString();
            }
            
            return QID;
        }

        /// <summary>
        /// 根据EID更改所有试题成绩为平均成绩
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="averageScore"></param>
        /// <returns></returns>
        public int UpdateAllScore(string EID, int averageScore)
        {
            return dal.UpdateAllScore(EID, averageScore);
        }

        /// <summary>
        /// 更改最后一道试题的分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="TQR_Number"></param>
        /// <param name="lastScore"></param>
        /// <returns></returns>
        public int UpdateLastScore(string EID, int TQR_Number, int lastScore)
        {
            return dal.UpdateLastScore(EID, TQR_Number, lastScore);
        }

		#endregion  ExtensionMethod
	}
}

