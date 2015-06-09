using System;
using System.Data;
using System.Collections.Generic;
using Tellyes.Common;
using Tellyes.Model;
using Tellyes.Log4Net;
namespace Tellyes.BLL
{
	/// <summary>
	/// SingleStationExamArrangement
	/// </summary>
	public partial class SingleStationExamArrangement
	{
        private readonly Tellyes.DAL.SingleStationExamArrangement dal = new Tellyes.DAL.SingleStationExamArrangement();
		public SingleStationExamArrangement()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int SE_ID)
		{
			return dal.Exists(SE_ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public int Add(Tellyes.Model.SingleStationExamArrangement model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public bool Update(Tellyes.Model.SingleStationExamArrangement model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int SE_ID)
		{
			
			return dal.Delete(SE_ID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string SE_IDlist )
		{
			return dal.DeleteList(SE_IDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
        public Tellyes.Model.SingleStationExamArrangement GetModel(int SE_ID)
		{
			
			return dal.GetModel(SE_ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
        public Tellyes.Model.SingleStationExamArrangement GetModelByCache(int SE_ID)
		{
			
			string CacheKey = "SingleStationExamArrangementModel-" + SE_ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SE_ID);
					if (objModel != null)
					{
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
            return (Tellyes.Model.SingleStationExamArrangement)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
        public List<Tellyes.Model.SingleStationExamArrangement> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
        public List<Tellyes.Model.SingleStationExamArrangement> DataTableToList(DataTable dt)
		{
            List<Tellyes.Model.SingleStationExamArrangement> modelList = new List<Tellyes.Model.SingleStationExamArrangement>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                Tellyes.Model.SingleStationExamArrangement model;
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// ����RoomID���ҿ���ExamID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetExamID(string RoomID)
        {
            DataTable dt = new DataTable();
            DataSet ds = dal.GetExamID(RoomID);
            if (ds != null)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }

        /// <summary>
        /// ���ݿ���ExamID��RoomID���ұ���վ�ſ���
        /// </summary>
        /// <param name="ExamID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataTable GetArrangementTable(Guid ExamID, int RoomID)
        {
            DataTable dt = dal.GetArrangementTable(ExamID, RoomID).Tables[0];
            return dt;
        }

        /// <summary>
        /// ���ݿ���ExamID��RoomID���ұ���վESID
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string GetESIDStr(Guid ExamID, int RoomID)
        {
            string ESIDStr = "";
            DataTable dt = GetArrangementTable(ExamID, RoomID);
            if (dt.Rows.Count > 0)
            {
                ESIDStr = dt.Rows[0]["ES_ID"].ToString();
            }
            return ESIDStr;
        }
		#endregion  ExtensionMethod

        #region Extension NHibernate

        /// <summary>
        /// ���SingleStationExamArrangement��¼
        /// </summary>
        /// <param name="singleStationExamArrangement"></param>
        /// <returns></returns>
        public bool AddSingleStationExamArrangement(Model.SingleStationExamArrangement singleStationExamArrangement)
        {
            return new DAL.SingleStationExamArrangement().Insert(singleStationExamArrangement);
        }

        /// <summary>
        /// ɾ��SingleStationExamArrangement��¼
        /// </summary>
        /// <param name="singleStationExamArrangement"></param>
        /// <returns></returns>
        public bool RemoveSingleStationExamArrangement(Model.SingleStationExamArrangement singleStationExamArrangement)
        {
            return new DAL.SingleStationExamArrangement().Delete(singleStationExamArrangement);
        }

        /// <summary>
        /// �޸�SingleStationExamArrangement��¼
        /// </summary>
        /// <param name="singleStationExamArrangement"></param>
        /// <returns></returns>
        public bool ModifySingleStationExamArrangement(Model.SingleStationExamArrangement singleStationExamArrangement)
        {
            return new DAL.SingleStationExamArrangement().Update((object)singleStationExamArrangement);
        }

        /// <summary>
        /// ��ѯSingleStationExamArrangement��һ������ID
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExamArrangementIdentity()
        {
            return new DAL.SingleStationExamArrangement().SelectNextIdentity();
        }

        /// <summary>
        /// ��ѯȫ��SingleStationExamArrangement��¼����
        /// </summary>
        /// <returns></returns>
        public int? SearchSingleStationExamArrangementCount()
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// ��������ѯSingleStationExamArrangement��¼����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchSingleStationExamArrangementCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// ��ѯָ��sE_ID��SingleStationExamArrangement�Ƿ����
        /// </summary>
        /// <param name="sE_ID"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExamArrangementExists(object sE_ID)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectExistsByID(sE_ID);
        }

        /// <summary>
        /// ��ѯָ��������SingleStationExamArrangement�Ƿ����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchSingleStationExamArrangementExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// ��sE_ID��ѯSingleStationExamArrangement
        /// </summary>
        /// <param name="sE_ID"></param>
        /// <returns></returns>
        public Model.SingleStationExamArrangement SearchSingleStationExamArrangementByID(object sE_ID)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectByID(sE_ID);
        }

        /// <summary>
        /// ��ѯ��һ��SingleStationExamArrangement����
        /// </summary>
        /// <returns></returns>
        public Model.SingleStationExamArrangement SearchUniqueSingleStationExamArrangementByCondition()
        {
            return new DAL.SingleStationExamArrangement().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// ��������ѯ��һ��SingleStationExamArrangement����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.SingleStationExamArrangement SearchUniqueSingleStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamArrangement().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// �������������ѯ��һ��SingleStationExamArrangement����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.SingleStationExamArrangement SearchUniqueSingleStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExamArrangement().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// ��ѯȫ��SingleStationExamArrangement����
        /// </summary>
        /// <returns></returns>
        public List<Model.SingleStationExamArrangement> SearchSingleStationExamArrangementByCondition()
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectByCondition();
        }

        /// <summary>
        /// ��������ѯSingleStationExamArrangement����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamArrangement> SearchSingleStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// �������������ѯSingleStationExamArrangement����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamArrangement> SearchSingleStationExamArrangementByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// ����ҳ�����������ѯSingleStationExamArrangement����
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.SingleStationExamArrangement> SearchSingleStationExamArrangementByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.SingleStationExamArrangement().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region NHibernate Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, int> SearchStudentCountDictionaryInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            object[] studentCountDictionary = new DAL.SingleStationExamArrangement().SelectStudentCountDictionaryInHandScoreByCondition(conditionDictionary);
            if (studentCountDictionary == null)
            {
                Log4NetUtility.Error(this, "�ֳ����֣���ѯ����ѧ������ʧ��");
                return null;
            }
            return new Dictionary<string, int>() 
            { 
                {"All_Student_Count", Convert.ToInt32(studentCountDictionary[0])},
                {"Student_With_Score_Count", Convert.ToInt32(studentCountDictionary[1])}
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchStudentCountInHandScoreByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.SingleStationExamArrangement().SelectStudentCountInHandScoreByCondition(conditionDictionary);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> SearchStudentListInHandScoreByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            List<object[]> _studentList = new DAL.SingleStationExamArrangement().SelectStudentListInHandScoreByCondition(conditionDictionary, pageIndex, pageSize);
            if (_studentList == null)
            {
                Log4NetUtility.Error(this, "�ֳ����֣���ѯ������ҳ��Ϣʧ��");
                return null;
            }
            List<Dictionary<string, object>> studentList = new List<Dictionary<string, object>>();
            foreach (object[] student in _studentList)
            {
                studentList.Add
                (
                    new Dictionary<string, object>() 
                    { 
                        {"StudentUserInfoID", student[0]},
                        {"StudentUserInfoTrueName", student[1]},
                        {"StudentUserInfoName", student[2]},
                        {"ExamStudentNumber", student[3]},
                        {"OrganizationName", student[4]},
                        {"ExamStartTime", student[5]},
                        {"StudentScore", student[6]},
                        {"StudentState", student[7]},
                        {"ExamEndTime", student[8]}
                    }
                );
            }
            return studentList;
        }

        #endregion

        #region ExtensionMethod
        //���ҵ�վ���Է���
        public DataSet GetSingleRoom(Guid EID)
        {
            return dal.GetSingleRoom(EID);
        }

        //���Ҹ÷���Ŀ��Կ�ʼʱ��ͽ���ʱ��
        public DataSet GetRoomExamStartEndTime(Guid EID, int RoomID)
        {
            return dal.GetRoomExamStartEndTime(EID, RoomID);
        }
        #endregion
    }
}

