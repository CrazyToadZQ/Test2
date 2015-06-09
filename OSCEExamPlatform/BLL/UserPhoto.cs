
using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using Tellyes.Model;

using System.IO;
using System.Data.SqlClient;

namespace Tellyes.BLL
{
	/// <summary>
	/// UserPhoto
	/// </summary>
	public partial class UserPhoto
	{
		private readonly Tellyes.DAL.UserPhoto dal=new Tellyes.DAL.UserPhoto();
		public UserPhoto()
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
		public bool Exists(int UP_ID)
		{
			return dal.Exists(UP_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tellyes.Model.UserPhoto model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.UserPhoto model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UP_ID)
		{
			
			return dal.Delete(UP_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UP_IDlist )
		{
			return dal.DeleteList(UP_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.UserPhoto GetModel(int UP_ID)
		{
			
			return dal.GetModel(UP_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public Tellyes.Model.UserPhoto GetModelByCache(int UP_ID)
        //{
			
        //    string CacheKey = "UserPhotoModel-" + UP_ID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(UP_ID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Tellyes.Model.UserPhoto)objModel;
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
		public List<Tellyes.Model.UserPhoto> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tellyes.Model.UserPhoto> DataTableToList(DataTable dt)
		{
			List<Tellyes.Model.UserPhoto> modelList = new List<Tellyes.Model.UserPhoto>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tellyes.Model.UserPhoto model;
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
        /// 将图片保存到数据库中
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int WriteImage(string filePath, int UID, DateTime dtTime, Guid EID, int RoomID)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Delete);
            byte[] imageBytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));

            int rows = 0;
            string strSql = string.Format(@"insert into [UserPhoto] (U_ID ,UP_Photo ,UP_CreateTime ,E_ID ,Room_ID ,int1) values 
                   ('{0}',@image,'{1}','{2}',{3},0)",UID ,dtTime ,EID ,RoomID );
            rows = dal.WriteImage(strSql, imageBytes);
            return rows;
        }

        /// <summary>
        /// 判断是否已经采集图像
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="EID"></param>
        /// <returns></returns>
        public bool IsHavePhoto(int UID, Guid EID)
        {
            bool ret = false;
            DataTable dt = dal.IsHavePhoto(UID, EID).Tables[0];
            int rows = dt.Rows.Count;
            if (rows > 0)
            {
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// 根据UID获取该考生的图像信息
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public byte[] GetUserPhoto(int UID, Guid EID)
        {
            try
            {
                SqlDataReader sqlDR = dal.GetUserPhoto(UID, EID);
                sqlDR.Read();
                byte[] imagesByte = (byte[])sqlDR["UP_Photo"];
                sqlDR.Close();
                return imagesByte;
            }
            catch (Exception ex)
            {
                Log4Net.Log4NetUtility.Error(this, "用户照片获取失败，UID：" + UID + "，EID：" + EID.ToString());
                return null;
            }

        }

		#endregion  ExtensionMethod
	}
}

