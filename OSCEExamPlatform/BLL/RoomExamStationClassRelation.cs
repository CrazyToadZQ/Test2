using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //房间-考站类型-关系表
    public partial class RoomExamStationClassRelation
    {

        private readonly Tellyes.DAL.RoomExamStationClassRelation dal = new Tellyes.DAL.RoomExamStationClassRelation();
        public RoomExamStationClassRelation()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.RoomExamStationClassRelation model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.RoomExamStationClassRelation model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.RoomExamStationClassRelation GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.RoomExamStationClassRelation GetModelByCache(int ID)
        {

            string CacheKey = "RoomExamStationClassRelationModel-" + ID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.RoomExamStationClassRelation)objModel;
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
        public List<Tellyes.Model.RoomExamStationClassRelation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.RoomExamStationClassRelation> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.RoomExamStationClassRelation> modelList = new List<Tellyes.Model.RoomExamStationClassRelation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.RoomExamStationClassRelation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.RoomExamStationClassRelation();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["Room_ID"].ToString() != "")
                    {
                        model.Room_ID = int.Parse(dt.Rows[n]["Room_ID"].ToString());
                    }
                    if (dt.Rows[n]["Exam_Station_Class_ID"].ToString() != "")
                    {
                        model.Exam_Station_Class_ID = int.Parse(dt.Rows[n]["Exam_Station_Class_ID"].ToString());
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


        #region 
        /// <summary>
        /// 根据父房间ID查询属于房间的考站类型列表
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public List<Tellyes.Model.RoomExamStationClassRelation> SearchExamStationClassIDByRoomID(int RoomID)
        {
            return new Tellyes.DAL.RoomExamStationClassRelation().SelectModelObjectByCondition
            (
               new Dictionary<string, object>() 
                { 
                    {"ExamStationClassRelationRoomID",RoomID}
                },
                null
            );
        }
        #endregion

    }
}
