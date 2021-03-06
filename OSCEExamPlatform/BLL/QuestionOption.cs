﻿using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
namespace Tellyes.BLL
{
	/// <summary>
	/// QuestionOption
	/// </summary>
	public partial class QuestionOption
	{
		private readonly Tellyes.DAL.QuestionOption dal=new Tellyes.DAL.QuestionOption();
		public QuestionOption()
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
		public bool Exists(int QO_ID)
		{
			return dal.Exists(QO_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.QuestionOption model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.QuestionOption model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int QO_ID)
		{
			
			return dal.Delete(QO_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string QO_IDlist )
		{
			return dal.DeleteList(QO_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.QuestionOption GetModel(int QO_ID)
		{
			
			return dal.GetModel(QO_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Tellyes.Model.QuestionOption GetModelByCache(int QO_ID)
		{
			
			string CacheKey = "QuestionOptionModel-" + QO_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(QO_ID);
					if (objModel != null)
					{
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Tellyes.Model.QuestionOption)objModel;
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
		public List<Tellyes.Model.QuestionOption> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.QuestionOption> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.QuestionOption> modelList = new List<Tellyes.Model.QuestionOption>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.QuestionOption model;
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
        /// 查找试题的选项信息，并根据int1排序显示
        /// </summary>
        /// <param name="EQ_ID"></param>
        /// <returns></returns>
        public DataSet GetQuestionOption(string EQ_ID)
        {
            return dal.GetQuestionOption(EQ_ID);
        }

        public DataSet GetOption(string QO_IDStr)
        {
            return dal.GetOption(QO_IDStr);
        }

		#endregion  ExtensionMethod
	}
}

