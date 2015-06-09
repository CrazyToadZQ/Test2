using Tellyes.Log4Net;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tellyes.DBUtility;

namespace Tellyes.NHibernate {
    public abstract class BaseDAL<Model> {
        public bool Insert(object modelObject) {
            try {
                Type modelObjectType = modelObject.GetType();
                string tableName = SessionManager.GetEntityTableName(modelObjectType.Name);
                List<Dictionary<string, string>> entityPropertyList = SessionManager.GetEntityPropertyList(modelObjectType.Name);
                if (entityPropertyList == null)
                    throw new Exception("查询实体对象属性集合失败");
                object modelObjectID = modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null);
                ISession session = null;
                if (modelObjectID is Int32 && modelObjectID.Equals(0) || modelObjectID is Guid || modelObjectID is string)
                {
                    try {
                        session = SessionManager.OpenSession();
                        session.Save(modelObject);
                        session.Flush();
                        return true;
                    } catch (Exception e) {
                        Log4NetUtility.Error(this, "Insert失败", e);
                        return false;
                    } finally {
                        SessionManager.CloseSession(session);
                    }
                } else {
                    ITransaction transaction = null;
                    try {
                        session = SessionManager.OpenSession();
                        transaction = session.BeginTransaction();
                        session.CreateSQLQuery("SET IDENTITY_INSERT " + tableName + " ON").ExecuteUpdate();
                        string columnString = "[" + entityPropertyList[0]["column"] + "]";
                        string valueString = ":" + entityPropertyList[0]["column"];
                        for (int i = 1; i < entityPropertyList.Count; i++) {
                            columnString += "," + "[" + entityPropertyList[i]["column"] + "]";
                            valueString += ",:" + entityPropertyList[i]["column"];
                        }
                        ISQLQuery insert = session.CreateSQLQuery("INSERT INTO [" + tableName + "](" + columnString + ") VALUES(" + valueString + ")");
                        foreach (Dictionary<string, string> property in entityPropertyList) {
                            string type = property["type"].ToLower();
                            object value = modelObjectType.GetProperty(property["name"]).GetValue(modelObject, null);
                            if (type.Equals("int")) {
                                if (value == null) {
                                    insert.SetParameter(property["column"], new Nullable<int>());
                                } else {
                                    insert.SetInt32(property["column"], Convert.ToInt32(value));
                                }
                            } else if (type.Equals("long")) {
                                if (value == null) {
                                    insert.SetParameter(property["column"], new Nullable<long>());
                                } else {
                                    insert.SetInt64(property["column"], Convert.ToInt64(value));
                                }
                            } else if (type.Equals("decimal")) {
                                if (value == null) {
                                    insert.SetParameter(property["column"], new Nullable<decimal>());
                                } else {
                                    insert.SetDecimal(property["column"], Convert.ToDecimal(value));
                                }
                            } else if (type.Equals("string")) {
                                insert.SetString(property["column"], value as string);
                            } else if (type.Equals("datetime")) {
                                if (value == null) {
                                    insert.SetParameter(property["column"], new Nullable<DateTime>());
                                } else {
                                    insert.SetDateTime(property["column"], Convert.ToDateTime(value));
                                }
                            } else if (type.Equals("guid")) {
                                if (value == null) {
                                    insert.SetParameter(property["column"], new Nullable<Guid>());
                                } else {
                                    insert.SetGuid(property["column"], Guid.Parse(value.ToString()));
                                }
                            } else if (type.Equals("binaryblob"))
                                insert.SetParameter(property["column"], value, NHibernateUtil.BinaryBlob);
                            else if(type.Equals("stringclob"))
                                insert.SetParameter(property["column"], value, NHibernateUtil.StringClob);
                            else
                                throw new Exception("未处理的字段数据类型");
                        }
                        insert.ExecuteUpdate();
                        session.CreateSQLQuery("SET IDENTITY_INSERT " + tableName + " OFF").ExecuteUpdate();
                        transaction.Commit();
                        return true;
                    } catch (Exception e) {
                        transaction.Rollback();
                        Log4NetUtility.Error(this, "Insert失败", e);
                        return false;
                    } finally {
                        SessionManager.DisposeTransaction(transaction);
                        SessionManager.CloseSession(session);
                    }
                }
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Insert失败", e);
                return false;
            }
        }
        public bool Delete(object modelObject) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                session.Delete(modelObject);
                session.Flush();
                return true;
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Delete失败", e);
                return false;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public bool Update(object modelObject) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                session.Update(modelObject);
                session.Flush();
                return true;
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Update失败", e);
                return false;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public bool Transaction(List<List<object>> modelObjectList) {
            ISession session = null;
            ITransaction transaction = null;
            try {
                session = SessionManager.OpenSession();
                transaction = session.BeginTransaction();
                foreach (List<object> item in modelObjectList) {
                    List<object> objectList = null;
                    if (item[1] is List<object>) {
                        objectList = item[1] as List<object>;
                    } else {
                        objectList = new List<object>() { item[1] };
                    }
                    if (item[0].Equals("insert") && objectList.Count > 0) {
                        Type modelObjectType = objectList[0].GetType();
                        string tableName = SessionManager.GetEntityTableName(modelObjectType.Name);
                        List<Dictionary<string, string>> entityPropertyList = SessionManager.GetEntityPropertyList(modelObjectType.Name);
                        if (entityPropertyList == null)
                            throw new Exception("查询实体对象属性集合失败");
                        string columnString = "[" + entityPropertyList[0]["column"] + "]";
                        string valueString = ":" + entityPropertyList[0]["column"];
                        for (int i = 1; i < entityPropertyList.Count; i++) {
                            columnString += "," + "[" + entityPropertyList[i]["column"] + "]";
                            valueString += ",:" + entityPropertyList[i]["column"];
                        }
                        string insertSQL = "INSERT INTO [" + tableName + "](" + columnString + ") VALUES(" + valueString + ")";
                        foreach (object modelObject in objectList) {
                            object modelObjectID  = modelObjectType.GetProperty(entityPropertyList[0]["name"]).GetValue(modelObject, null);
                            if (modelObjectID is Int32 && modelObjectID.Equals(0) || modelObjectID is Guid || modelObjectID is string)
                                session.Save(modelObject);
                            else {
                                session.CreateSQLQuery("SET IDENTITY_INSERT " + tableName + " ON").ExecuteUpdate();
                                ISQLQuery insert = session.CreateSQLQuery(insertSQL);
                                foreach (Dictionary<string, string> property in entityPropertyList) {
                                    string type = property["type"].ToLower();
                                    object value = modelObjectType.GetProperty(property["name"]).GetValue(modelObject, null);
                                    if (type.Equals("int")) {
                                        if (value == null) {
                                            insert.SetParameter(property["column"], new Nullable<int>());
                                        } else {
                                            insert.SetInt32(property["column"], Convert.ToInt32(value));
                                        }
                                    } else if (type.Equals("long")) {
                                        if (value == null) {
                                            insert.SetParameter(property["column"], new Nullable<long>());
                                        } else {
                                            insert.SetInt64(property["column"], Convert.ToInt64(value));
                                        }
                                    } else if (type.Equals("decimal")) {
                                        if (value == null) {
                                            insert.SetParameter(property["column"], new Nullable<decimal>());
                                        } else {
                                            insert.SetDecimal(property["column"], Convert.ToDecimal(value));
                                        }
                                    } else if (type.Equals("string")) {
                                        insert.SetString(property["column"], value == null ? null : value.ToString());
                                    } else if (type.Equals("datetime")) {
                                        if (value == null) {
                                            insert.SetParameter(property["column"], new Nullable<DateTime>());
                                        } else {
                                            insert.SetDateTime(property["column"], Convert.ToDateTime(value));
                                        }
                                    } else if (type.Equals("guid")) {
                                        if (value == null) {
                                            insert.SetParameter(property["column"], new Nullable<Guid>());
                                        } else {
                                            insert.SetGuid(property["column"], Guid.Parse(value.ToString()));
                                        }
                                    } else if (type.Equals("binaryblob"))
                                        insert.SetParameter(property["column"], value, NHibernateUtil.BinaryBlob);
                                    else if (type.Equals("stringclob"))
                                        insert.SetParameter(property["column"], value, NHibernateUtil.StringClob);
                                    else
                                        throw new Exception("未处理的字段数据类型");
                                }
                                insert.ExecuteUpdate();
                                session.CreateSQLQuery("SET IDENTITY_INSERT " + tableName + " OFF").ExecuteUpdate();
                            }
                        }
                    }
                    else if (item[0].Equals("delete") && objectList.Count > 0)
                        foreach (object modelObject in objectList)
                            session.Delete(modelObject);
                    else if (item[0].Equals("update") && objectList.Count > 0)
                        foreach (object modelObject in objectList)
                            session.Update(modelObject);
                    session.Flush();
                }
                transaction.Commit();
                return true;
            } catch (Exception e) {
                transaction.Rollback();
                Log4NetUtility.Error(this, "事务执行失败", e);
                return false;
            } finally {
                SessionManager.DisposeTransaction(transaction);
                SessionManager.CloseSession(session);
            }
        }       
        public int? SelectNextIdentity() {
            ISession session = null;
            try {
                string tableName = SessionManager.GetEntityTableName(typeof(Model).Name);
                if (tableName == null)
                    throw new Exception("查询数据表自增长主键ID失败");
                string sql = "SELECT IDENT_CURRENT('" + tableName + "') + IDENT_INCR ('" + tableName + "')";
                session = SessionManager.OpenSession();
                int result = Convert.ToInt32(session.CreateSQLQuery(sql).UniqueResult<object>());
                return result;
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public int? SelectModelObjectCountByCondition() {
            return this.SelectModelObjectCountByCondition(null);
        }
        public int? SelectModelObjectCountByCondition(Dictionary<string, object> conditionDictionary) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                if (conditionDictionary != null && conditionDictionary.Count > 0)
                    criteria = this._createConditionCriteria(criteria, conditionDictionary);
                return Convert.ToInt32(criteria.SetProjection(Projections.RowCount()).UniqueResult());
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public bool? SelectModelObjectExistsByID(object modelObjectID) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                criteria.Add(Restrictions.IdEq(modelObjectID));
                return Convert.ToInt32(criteria.SetProjection(Projections.RowCount()).UniqueResult()) > 0;
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public bool? SelectModelObjectExistsByCondition(Dictionary<string, object> conditionDictionary) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                if (conditionDictionary != null && conditionDictionary.Count > 0)
                    criteria = this._createConditionCriteria(criteria, conditionDictionary);
                return Convert.ToInt32(criteria.SetProjection(Projections.RowCount()).UniqueResult()) > 0;
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public Model SelectModelObjectByID(object modelObjectID) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                criteria.Add(Restrictions.IdEq(modelObjectID));
                return criteria.UniqueResult<Model>();
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return default(Model);
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public Model SelectUniqueModelObjectByCondition() {
            return this.SelectUniqueModelObjectByCondition(null, null);
        }
        public Model SelectUniqueModelObjectByCondition(Dictionary<string, object> conditionDictionary) {
            return this.SelectUniqueModelObjectByCondition(conditionDictionary, null);
        }
        public Model SelectUniqueModelObjectByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                if (conditionDictionary != null && conditionDictionary.Count > 0)
                    criteria = this._createConditionCriteria(criteria, conditionDictionary);
                if (orderList != null && orderList.Count > 0)
                    criteria = this._createOrderCriteria(criteria, orderList);
                return criteria.SetFirstResult(0).SetMaxResults(1).UniqueResult<Model>();
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return default(Model);
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public List<Model> SelectModelObjectByCondition() {
            return this.SelectModelObjectByCondition(null, null);
        }
        public List<Model> SelectModelObjectByCondition(Dictionary<string, object> conditionDictionary) {
            return this.SelectModelObjectByCondition(conditionDictionary, null);
        }
        public List<Model> SelectModelObjectByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                if (conditionDictionary != null && conditionDictionary.Count > 0)
                    criteria = this._createConditionCriteria(criteria, conditionDictionary);
                if (orderList != null && orderList.Count > 0)
                    criteria = this._createOrderCriteria(criteria, orderList);
                return criteria.List<Model>().ToList<Model>();
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        public List<Model> SelectModelObjectByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize) {
            ISession session = null;
            try {
                session = SessionManager.OpenSession();
                ICriteria criteria = session.CreateCriteria(typeof(Model));
                if (conditionDictionary != null && conditionDictionary.Count > 0)
                    criteria = this._createConditionCriteria(criteria, conditionDictionary);
                if (orderList != null && orderList.Count > 0)
                    criteria = this._createOrderCriteria(criteria, orderList);
                return criteria.SetFirstResult((pageIndex - 1) * pageSize).SetMaxResults(pageSize).List<Model>().ToList<Model>();
            } catch (Exception e) {
                Log4NetUtility.Error(this, "Select失败", e);
                return null;
            } finally {
                SessionManager.CloseSession(session);
            }
        }
        protected abstract ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary);
        protected virtual ICriteria _createOrderCriteria(ICriteria criteria, List<KeyValuePair<string, string>> orderList) {
            foreach (KeyValuePair<string, string> orderItem in orderList)
                criteria.AddOrder(new Order(orderItem.Key, orderItem.Value.ToLower().Equals("asc")));
            return criteria;
        }
    }
}
