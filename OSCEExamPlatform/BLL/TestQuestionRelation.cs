
using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// TestQuestionRelation
	/// </summary>
	public partial class TestQuestionRelation
	{
		private readonly Tellyes.DAL.TestQuestionRelation dal=new Tellyes.DAL.TestQuestionRelation();
		public TestQuestionRelation()
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
		public bool Exists(int TQR_ID)
		{
			return dal.Exists(TQR_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.TestQuestionRelation model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.TestQuestionRelation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int TQR_ID)
		{
			
			return dal.Delete(TQR_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string TQR_IDlist )
		{
			return dal.DeleteList(TQR_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.TestQuestionRelation GetModel(int TQR_ID)
		{
			
			return dal.GetModel(TQR_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public Tellyes.Model.TestQuestionRelation GetModelByCache(int TQR_ID)
        //{
			
        //    string CacheKey = "TestQuestionRelationModel-" + TQR_ID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(TQR_ID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Tellyes.Model.TestQuestionRelation)objModel;
        //}

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
		public List<Tellyes.Model.TestQuestionRelation> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.TestQuestionRelation> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.TestQuestionRelation> modelList = new List<Tellyes.Model.TestQuestionRelation>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.TestQuestionRelation model;
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
        /// 根据EID查找所有的试题库中EQID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet ExportEID(string EID)
        {
            return dal.ExportEID(EID);
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
        /// 更改最后一道试卷试题的分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="TQR_Number"></param>
        /// <param name="lastScore"></param>
        /// <returns></returns>
        public int UpdateLastScore(string EID, int TQR_Number, int lastScore)
        {
            return dal.UpdateLastScore(EID, TQR_Number, lastScore);
        }

        /// <summary>
        /// 根据EID,QID更新分数
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="QID"></param>
        /// <param name="scoreStr"></param>
        /// <returns></returns>
        public int UpdateScore(string EID, string QID, string scoreStr)
        {
            return dal.UpdateScore(EID, QID, scoreStr);
        }

        /// <summary>
        /// 通过试卷ID查找其相应的试题ID
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public DataSet GetQID(string EID)
        {
            return dal.GetQID(EID);
        }

        /// <summary>
        /// 通过试卷ID查找试卷具有的题的总数
        /// </summary>
        /// <param name="EID"></param>
        /// <returns></returns>
        public int GetQIDCount(string EID)
        {
            int count = 0;
            DataTable dt = dal.GetQID(EID).Tables[0];
            count = dt.Rows.Count;

            return count;
        }

        /// <summary>
        /// 根据EQID和EID查找题号TQR_Number
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="EQID"></param>
        /// <returns></returns>
        public int GetTQR_Number(string EID, string EQID)
        {
            int num = 0;
            DataTable dt = dal.GetNumber(EID, EQID).Tables[0];
            num = Convert.ToInt32(dt.Rows[0]["TQR_Number"].ToString());

            return num;
        }

        /// <summary>
        /// 更新试卷试题的题号
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="oldNumber"></param>
        /// <param name="newNumber"></param>
        /// <returns></returns>
        public int UpdateTQR_Number(string EID, int oldNumber, int newNumber)
        {
            return dal.UpdateTQR_Number(EID, oldNumber, newNumber);
        }

        /// <summary>
        /// 更新当前行试题的题号
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="QID"></param>
        /// <param name="oldNumber"></param>
        /// <param name="newNumber"></param>
        /// <returns></returns>
        public int UpdateCurrentTQR_Number(string EID, string QID, int oldNumber, int newNumber)
        {
            return dal.UpdateCurrentTQR_Number(EID, QID, oldNumber, newNumber);
        }


        #endregion  ExtensionMethod#region  ExtensionMethod
	}
}

