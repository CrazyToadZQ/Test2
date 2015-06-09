using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using Tellyes.Model;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    public class DeviceLog : BaseDAL<Tellyes.Model.DeviceLog>
    {
        public DeviceLog()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DL_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceLog");
            strSql.Append(" where DL_ID=@DL_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DL_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DL_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceLog(");
            strSql.Append("D_ID,DL_Type,DL_Description,DL_CreateTime,DL_CreatorID,DL_CreatorName,DL_int1,DL_int2,DL_string1,DL_string2,DL_image,DL_Reason,DL_Contact_Person,DL_Contact_Person_Company,DL_Contact_Person_Phone)");
            strSql.Append(" values (");
            strSql.Append("@D_ID,@DL_Type,@DL_Description,@DL_CreateTime,@DL_CreatorID,@DL_CreatorName,@DL_int1,@DL_int2,@DL_string1,@DL_string2,@DL_image,@DL_Reason,@DL_Contact_Person,@DL_Contact_Person_Company,@DL_Contact_Person_Phone)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@D_ID", SqlDbType.Int,4),
					new SqlParameter("@DL_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Description", SqlDbType.NVarChar,4000),
					new SqlParameter("@DL_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@DL_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@DL_CreatorName", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_int1", SqlDbType.Int,4),
					new SqlParameter("@DL_int2", SqlDbType.Int,4),
					new SqlParameter("@DL_string1", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_string2", SqlDbType.NVarChar,1000),
					new SqlParameter("@DL_image", SqlDbType.Image),
					new SqlParameter("@DL_Reason", SqlDbType.NVarChar,4000),
					new SqlParameter("@DL_Contact_Person", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Contact_Person_Company", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Contact_Person_Phone", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.D_ID;
            parameters[1].Value = model.DL_Type;
            parameters[2].Value = model.DL_Description;
            parameters[3].Value = model.DL_CreateTime;
            parameters[4].Value = model.DL_CreatorID;
            parameters[5].Value = model.DL_CreatorName;
            parameters[6].Value = model.DL_int1;
            parameters[7].Value = model.DL_int2;
            parameters[8].Value = model.DL_string1;
            parameters[9].Value = model.DL_string2;
            parameters[10].Value = model.DL_image;
            parameters[11].Value = model.DL_Reason;
            parameters[12].Value = model.DL_Contact_Person;
            parameters[13].Value = model.DL_Contact_Person_Company;
            parameters[14].Value = model.DL_Contact_Person_Phone;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.DeviceLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceLog set ");
            strSql.Append("D_ID=@D_ID,");
            strSql.Append("DL_Type=@DL_Type,");
            strSql.Append("DL_Description=@DL_Description,");
            strSql.Append("DL_CreateTime=@DL_CreateTime,");
            strSql.Append("DL_CreatorID=@DL_CreatorID,");
            strSql.Append("DL_CreatorName=@DL_CreatorName,");
            strSql.Append("DL_int1=@DL_int1,");
            strSql.Append("DL_int2=@DL_int2,");
            strSql.Append("DL_string1=@DL_string1,");
            strSql.Append("DL_string2=@DL_string2,");
            strSql.Append("DL_image=@DL_image,");
            strSql.Append("DL_Reason=@DL_Reason,");
            strSql.Append("DL_Contact_Person=@DL_Contact_Person,");
            strSql.Append("DL_Contact_Person_Company=@DL_Contact_Person_Company,");
            strSql.Append("DL_Contact_Person_Phone=@DL_Contact_Person_Phone");
            strSql.Append(" where DL_ID=@DL_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@D_ID", SqlDbType.Int,4),
					new SqlParameter("@DL_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Description", SqlDbType.NVarChar,4000),
					new SqlParameter("@DL_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@DL_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@DL_CreatorName", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_int1", SqlDbType.Int,4),
					new SqlParameter("@DL_int2", SqlDbType.Int,4),
					new SqlParameter("@DL_string1", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_string2", SqlDbType.NVarChar,1000),
					new SqlParameter("@DL_image", SqlDbType.Image),
					new SqlParameter("@DL_Reason", SqlDbType.NVarChar,4000),
					new SqlParameter("@DL_Contact_Person", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Contact_Person_Company", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_Contact_Person_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@DL_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.D_ID;
            parameters[1].Value = model.DL_Type;
            parameters[2].Value = model.DL_Description;
            parameters[3].Value = model.DL_CreateTime;
            parameters[4].Value = model.DL_CreatorID;
            parameters[5].Value = model.DL_CreatorName;
            parameters[6].Value = model.DL_int1;
            parameters[7].Value = model.DL_int2;
            parameters[8].Value = model.DL_string1;
            parameters[9].Value = model.DL_string2;
            parameters[10].Value = model.DL_image;
            parameters[11].Value = model.DL_Reason;
            parameters[12].Value = model.DL_Contact_Person;
            parameters[13].Value = model.DL_Contact_Person_Company;
            parameters[14].Value = model.DL_Contact_Person_Phone;
            parameters[15].Value = model.DL_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DL_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceLog ");
            strSql.Append(" where DL_ID=@DL_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DL_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DL_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string DL_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceLog ");
            strSql.Append(" where DL_ID in (" + DL_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceLog GetModel(int DL_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 DL_ID,D_ID,DL_Type,DL_Description,DL_CreateTime,DL_CreatorID,DL_CreatorName,DL_int1,DL_int2,DL_string1,DL_string2,DL_image,DL_Reason,DL_Contact_Person,DL_Contact_Person_Company,DL_Contact_Person_Phone from DeviceLog ");
            strSql.Append(" where DL_ID=@DL_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DL_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DL_ID;

            Tellyes.Model.DeviceLog model = new Tellyes.Model.DeviceLog();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.DeviceLog DataRowToModel(DataRow row)
        {
            Tellyes.Model.DeviceLog model = new Tellyes.Model.DeviceLog();
            if (row != null)
            {
                if (row["DL_ID"] != null && row["DL_ID"].ToString() != "")
                {
                    model.DL_ID = int.Parse(row["DL_ID"].ToString());
                }
                if (row["D_ID"] != null && row["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(row["D_ID"].ToString());
                }
                if (row["DL_Type"] != null)
                {
                    model.DL_Type = row["DL_Type"].ToString();
                }
                if (row["DL_Description"] != null)
                {
                    model.DL_Description = row["DL_Description"].ToString();
                }
                if (row["DL_CreateTime"] != null && row["DL_CreateTime"].ToString() != "")
                {
                    model.DL_CreateTime = DateTime.Parse(row["DL_CreateTime"].ToString());
                }
                if (row["DL_CreatorID"] != null && row["DL_CreatorID"].ToString() != "")
                {
                    model.DL_CreatorID = int.Parse(row["DL_CreatorID"].ToString());
                }
                if (row["DL_CreatorName"] != null)
                {
                    model.DL_CreatorName = row["DL_CreatorName"].ToString();
                }
                if (row["DL_int1"] != null && row["DL_int1"].ToString() != "")
                {
                    model.DL_int1 = int.Parse(row["DL_int1"].ToString());
                }
                if (row["DL_int2"] != null && row["DL_int2"].ToString() != "")
                {
                    model.DL_int2 = int.Parse(row["DL_int2"].ToString());
                }
                if (row["DL_string1"] != null)
                {
                    model.DL_string1 = row["DL_string1"].ToString();
                }
                if (row["DL_string2"] != null)
                {
                    model.DL_string2 = row["DL_string2"].ToString();
                }
                if (row["DL_image"] != null && row["DL_image"].ToString() != "")
                {
                    model.DL_image = (byte[])row["DL_image"];
                }
                if (row["DL_Reason"] != null)
                {
                    model.DL_Reason = row["DL_Reason"].ToString();
                }
                if (row["DL_Contact_Person"] != null)
                {
                    model.DL_Contact_Person = row["DL_Contact_Person"].ToString();
                }
                if (row["DL_Contact_Person_Company"] != null)
                {
                    model.DL_Contact_Person_Company = row["DL_Contact_Person_Company"].ToString();
                }
                if (row["DL_Contact_Person_Phone"] != null)
                {
                    model.DL_Contact_Person_Phone = row["DL_Contact_Person_Phone"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DL_ID,D_ID,DL_Type,DL_Description,DL_CreateTime,DL_CreatorID,DL_CreatorName,DL_int1,DL_int2,DL_string1,DL_string2,DL_image,DL_Reason,DL_Contact_Person,DL_Contact_Person_Company,DL_Contact_Person_Phone ");
            strSql.Append(" FROM DeviceLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" DL_ID,D_ID,DL_Type,DL_Description,DL_CreateTime,DL_CreatorID,DL_CreatorName,DL_int1,DL_int2,DL_string1,DL_string2,DL_image,DL_Reason,DL_Contact_Person,DL_Contact_Person_Company,DL_Contact_Person_Phone ");
            strSql.Append(" FROM DeviceLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM DeviceLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.DL_ID desc");
            }
            strSql.Append(")AS Row, T.*  from DeviceLog T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion


        #region NHibernate Method

        /// <summary>
        /// 按条件查询日志信息总记录数（deviceLog表，device表，deviceClass表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectDeviceLogInfoTotalRowCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT COUNT([DeviceLog].[DL_ID]) ")
                .Append("FROM ")
                .Append("   [DeviceLog] ")
                .Append("   INNER JOIN [Device] ")
                .Append("       ON [DeviceLog].[D_ID] = [Device].[D_ID] ")
                .Append("   LEFT JOIN [DeviceClass] ")
                .Append("       ON ([DeviceClass].[DC_ID] = [Device].[DC_ID]) ")
                .Append("WHERE ")
                .Append("   [DeviceLog].[DL_Type] IN (:deviceLogTypeList) ");

            if (conditionDictionary.ContainsKey("D_Name,Like"))
            {
                sqlStringBuilder.Append(" AND [Device].[D_Name] LIKE :D_Name ");
            }
            if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
            {
                sqlStringBuilder.Append(" AND [Device].[D_SerialNumber] LIKE :D_SerialNumber ");
            }
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                sqlStringBuilder.Append(" AND [Device].[DC_ID] IN (:deviceClassList) ");
            }

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);             
                //设置查询参数(Set方式 防SQL注入)
                iSQLQuery.SetParameterList("deviceLogTypeList", (string[])conditionDictionary["DL_Type,IN"]);
                if (conditionDictionary.ContainsKey("D_Name,Like"))
                {
                    iSQLQuery.SetString("D_Name", "%" + conditionDictionary["D_Name,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
                {
                    iSQLQuery.SetString("D_SerialNumber", "%" + conditionDictionary["D_SerialNumber,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (string[])conditionDictionary["DC_ID,IN"]);
                }
                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "分页查询设备日志信息totalCount失败！请查看DAL层中 SelectDeviceLogInfoTotalRowCountByCondition()方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }





        /// <summary>
        /// 分页查询设备日志信息（deviceLog表，device表，deviceClass表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectDeviceLogInfoPageByCondition(Dictionary<string, object> conditionDictionary,List<KeyValuePair<string, string>> orderList,int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [DeviceLog].*,")
                .Append("   [Device].[D_SerialNumber], ")
                .Append("   [Device].[D_Name], ")
                .Append("   [Device].[D_State], ")
                .Append("   [Device].[DC_ID], ")
                .Append("   [DeviceClass].[DC_Name] ")
                .Append("FROM ")
                .Append("   [DeviceLog] ")
                .Append("   INNER JOIN [Device] ")
                .Append("       ON [DeviceLog].[D_ID] = [Device].[D_ID] ")
                .Append("   LEFT JOIN [DeviceClass] ")
                .Append("       ON ([DeviceClass].[DC_ID] = [Device].[DC_ID]) ")
                .Append("WHERE ")
                .Append("   [DeviceLog].[DL_Type] IN (:deviceLogTypeList) ");

            if (conditionDictionary.ContainsKey("D_Name,Like"))
            {
                sqlStringBuilder.Append(" AND [Device].[D_Name] LIKE :D_Name ");
            }
            if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
            {
                sqlStringBuilder.Append(" AND [Device].[D_SerialNumber] LIKE :D_SerialNumber ");
            }
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                sqlStringBuilder.Append(" AND [Device].[DC_ID] IN (:deviceClassList) ");
            }
            if (orderList != null && orderList.Count > 0) 
            {
                sqlStringBuilder.Append(" ORDER BY ");
                foreach (KeyValuePair<string, string> orderItem in orderList)
                {
                    string orderColumn = orderItem.Key;
                    if (orderItem.Key == "D_ID")
                    {
                        orderColumn = "[Device].[D_ID]";
                    }
                    sqlStringBuilder.Append(orderColumn).Append(" ").Append(orderItem.Value.ToLower() == "asc" ? "ASC" : "DESC").Append(",");
                }
                sqlStringBuilder.Remove(sqlStringBuilder.Length - 1, 1);
            }

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.DeviceLog))
                    .AddScalar("D_SerialNumber", NHibernateUtil.String)
                    .AddScalar("D_Name", NHibernateUtil.String)
                    .AddScalar("D_State", NHibernateUtil.String)
                    .AddScalar("DC_ID", NHibernateUtil.Int32)
                    .AddScalar("DC_Name", NHibernateUtil.String);
                //设置查询参数(Set方式 防SQL注入)
                iSQLQuery.SetParameterList("deviceLogTypeList", (string[])conditionDictionary["DL_Type,IN"]);               
                if (conditionDictionary.ContainsKey("D_Name,Like"))
                {
                    iSQLQuery.SetString("D_Name", "%" + conditionDictionary["D_Name,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
                {
                    iSQLQuery.SetString("D_SerialNumber", "%" + conditionDictionary["D_SerialNumber,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (string[])conditionDictionary["DC_ID,IN"]);
                }
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult((pageIndex - 1) * pageSize)
                    .SetMaxResults(pageSize)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "分页查询设备日志信息失败！请查看DAL层中 SelectDeviceLogInPageByCondition（）方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            //按设备ID进行设备日志查询
            if (conditionDictionary.ContainsKey("D_ID"))
            {
                criteria.Add(Restrictions.Eq("D_ID",conditionDictionary["D_ID"]));
            }
            //按设备ID进行设备日志查询
            if (conditionDictionary.ContainsKey("D_ID,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("D_ID"));
                criteria.Add(Restrictions.In("D_ID", (List<int>)conditionDictionary["D_ID,IN"]));
            }
            //按设备ID进行设备日志查询
            if (conditionDictionary.ContainsKey("DL_Type,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("DL_Type"));
                criteria.Add(Restrictions.In("DL_Type", (string[])conditionDictionary["DL_Type,IN"]));
            }
            //按设备日志注册时间进行设备日志查询
            if (conditionDictionary.ContainsKey("DL_CreateTime,Greater"))
            {
                criteria.Add(Restrictions.IsNotNull("DL_CreateTime"));
                criteria.Add(Restrictions.Gt("DL_CreateTime", DateTime.Parse(conditionDictionary["DL_CreateTime,Greater"].ToString())));
            }
            return criteria;
        }

        #endregion
        
    }
}
