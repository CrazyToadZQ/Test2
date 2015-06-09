using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tellyes.BLL
{
    //属性值表
    public partial class PropertyValue
    {

        private readonly Tellyes.DAL.PropertyValue dal = new Tellyes.DAL.PropertyValue();
        public PropertyValue()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PropertyValueID)
        {
            return dal.Exists(PropertyValueID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.PropertyValue model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.PropertyValue model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PropertyValueID)
        {

            return dal.Delete(PropertyValueID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string PropertyValueIDlist)
        {
            return dal.DeleteList(PropertyValueIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.PropertyValue GetModel(int PropertyValueID)
        {

            return dal.GetModel(PropertyValueID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Tellyes.Model.PropertyValue GetModelByCache(int PropertyValueID)
        {

            string CacheKey = "PropertyValueModel-" + PropertyValueID;
            object objModel = Tellyes.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PropertyValueID);
                    if (objModel != null)
                    {
                        int ModelCache = Tellyes.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Tellyes.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Tellyes.Model.PropertyValue)objModel;
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
        public List<Tellyes.Model.PropertyValue> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tellyes.Model.PropertyValue> DataTableToList(DataTable dt)
        {
            List<Tellyes.Model.PropertyValue> modelList = new List<Tellyes.Model.PropertyValue>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tellyes.Model.PropertyValue model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Tellyes.Model.PropertyValue();
                    if (dt.Rows[n]["PropertyValueID"].ToString() != "")
                    {
                        model.PropertyValueID = int.Parse(dt.Rows[n]["PropertyValueID"].ToString());
                    }
                    model.PropertyValueString3 = dt.Rows[n]["PropertyValueString3"].ToString();
                    model.PropertyValueString4 = dt.Rows[n]["PropertyValueString4"].ToString();
                    model.PropertyValueString5 = dt.Rows[n]["PropertyValueString5"].ToString();
                    model.PropertyValueName = dt.Rows[n]["PropertyValueName"].ToString();
                    model.PropertyValueOrderNumber = dt.Rows[n]["PropertyValueOrderNumber"].ToString();
                    if (dt.Rows[n]["PropertyValueNumber1"].ToString() != "")
                    {
                        model.PropertyValueNumber1 = int.Parse(dt.Rows[n]["PropertyValueNumber1"].ToString());
                    }
                    if (dt.Rows[n]["PropertyValueNumber2"].ToString() != "")
                    {
                        model.PropertyValueNumber2 = int.Parse(dt.Rows[n]["PropertyValueNumber2"].ToString());
                    }
                    if (dt.Rows[n]["PropertyValueNumber3"].ToString() != "")
                    {
                        model.PropertyValueNumber3 = int.Parse(dt.Rows[n]["PropertyValueNumber3"].ToString());
                    }
                    if (dt.Rows[n]["PropertyValueNumber4"].ToString() != "")
                    {
                        model.PropertyValueNumber4 = int.Parse(dt.Rows[n]["PropertyValueNumber4"].ToString());
                    }
                    model.PropertyValueString1 = dt.Rows[n]["PropertyValueString1"].ToString();
                    model.PropertyValueString2 = dt.Rows[n]["PropertyValueString2"].ToString();
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
        /// 添加PropertyValue记录
        /// </summary>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public bool AddPropertyValue(Model.PropertyValue propertyValue)
        {
            return new DAL.PropertyValue().Insert(propertyValue);
        }

        /// <summary>
        /// 删除PropertyValue记录
        /// </summary>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public bool RemovePropertyValue(Model.PropertyValue propertyValue)
        {
            return new DAL.PropertyValue().Delete(propertyValue);
        }

        /// <summary>
        /// 修改PropertyValue记录
        /// </summary>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public bool ModifyPropertyValue(Model.PropertyValue propertyValue)
        {
            return new DAL.PropertyValue().Update((object)propertyValue);
        }

        /// <summary>
        /// 查询PropertyValue下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchPropertyValueIdentity()
        {
            return new DAL.PropertyValue().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部PropertyValue记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchPropertyValueCount()
        {
            return new DAL.PropertyValue().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询PropertyValue记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchPropertyValueCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PropertyValue().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定propertyValueID的PropertyValue是否存在
        /// </summary>
        /// <param name="propertyValueID"></param>
        /// <returns></returns>
        public bool? SearchPropertyValueExists(object propertyValueID)
        {
            return new DAL.PropertyValue().SelectModelObjectExistsByID(propertyValueID);
        }

        /// <summary>
        /// 查询指定条件的PropertyValue是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchPropertyValueExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PropertyValue().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按propertyValueID查询PropertyValue
        /// </summary>
        /// <param name="propertyValueID"></param>
        /// <returns></returns>
        public Model.PropertyValue SearchPropertyValueByID(object propertyValueID)
        {
            return new DAL.PropertyValue().SelectModelObjectByID(propertyValueID);
        }

        /// <summary>
        /// 查询第一个PropertyValue对象
        /// </summary>
        /// <returns></returns>
        public Model.PropertyValue SearchUniquePropertyValueByCondition()
        {
            return new DAL.PropertyValue().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个PropertyValue对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.PropertyValue SearchUniquePropertyValueByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PropertyValue().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个PropertyValue对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.PropertyValue SearchUniquePropertyValueByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.PropertyValue().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部PropertyValue对象
        /// </summary>
        /// <returns></returns>
        public List<Model.PropertyValue> SearchPropertyValueByCondition()
        {
            return new DAL.PropertyValue().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询PropertyValue对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.PropertyValue> SearchPropertyValueByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.PropertyValue().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询PropertyValue对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.PropertyValue> SearchPropertyValueByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.PropertyValue().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询PropertyValue内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.PropertyValue> SearchPropertyValueByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.PropertyValue().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        #region Extesion

        /// <summary>
        /// 批量删除属性值List
        /// </summary>
        /// <param name="propertyValueList"></param>
        /// <returns></returns>
        public bool RemovePropertyValue(List<Tellyes.Model.PropertyValue> propertyValueList)
        {
            return new Tellyes.DAL.PropertyValue().Transaction(
               new List<List<object>>() 
                { 
                    new List<object>(){"delete", propertyValueList.ToList<object>()}
                }
           );
        }


        /// <summary>
        /// 批量修改属性值List
        /// </summary>
        /// <returns></returns>
        public bool ModifyPropertyValue(Dictionary<int, Tellyes.Model.PropertyValue> propertyValueDictionary)
        {
            return new Tellyes.DAL.PropertyValue().Transaction(
                 new List<List<object>>() 
                { 
                    new List<object>(){"update", propertyValueDictionary.Values.ToList<object>()}
                }
             );
        }

        #endregion
    }
}
