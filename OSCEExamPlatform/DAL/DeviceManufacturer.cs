using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.DBUtility;
using System.Data.SqlClient;
using Tellyes.NHibernate;
using NHibernate;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:DeviceManufacturer
    /// </summary>
    public partial class DeviceManufacturer : BaseDAL<Model.DeviceManufacturer>
    {
        public DeviceManufacturer()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int DMA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceManufacturer");
            strSql.Append(" where DMA_ID=@DMA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DMA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DMA_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.DeviceManufacturer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceManufacturer(");
            strSql.Append("DMA_Name,DMA_int,DMA_string)");
            strSql.Append(" values (");
            strSql.Append("@DMA_Name,@DMA_int,@DMA_string)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DMA_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@DMA_int", SqlDbType.Int,4),
					new SqlParameter("@DMA_string", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.DMA_Name;
            parameters[1].Value = model.DMA_int;
            parameters[2].Value = model.DMA_string;

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
        public bool Update(Tellyes.Model.DeviceManufacturer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceManufacturer set ");
            strSql.Append("DMA_Name=@DMA_Name,");
            strSql.Append("DMA_int=@DMA_int,");
            strSql.Append("DMA_string=@DMA_string");
            strSql.Append(" where DMA_ID=@DMA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DMA_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@DMA_int", SqlDbType.Int,4),
					new SqlParameter("@DMA_string", SqlDbType.NVarChar,50),
					new SqlParameter("@DMA_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.DMA_Name;
            parameters[1].Value = model.DMA_int;
            parameters[2].Value = model.DMA_string;
            parameters[3].Value = model.DMA_ID;

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
        public bool Delete(int DMA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceManufacturer ");
            strSql.Append(" where DMA_ID=@DMA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DMA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DMA_ID;

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
        public bool DeleteList(string DMA_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceManufacturer ");
            strSql.Append(" where DMA_ID in (" + DMA_IDlist + ")  ");
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
        public Tellyes.Model.DeviceManufacturer GetModel(int DMA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 DMA_ID,DMA_Name,DMA_int,DMA_string from DeviceManufacturer ");
            strSql.Append(" where DMA_ID=@DMA_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DMA_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = DMA_ID;

            Tellyes.Model.DeviceManufacturer model = new Tellyes.Model.DeviceManufacturer();
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
        public Tellyes.Model.DeviceManufacturer DataRowToModel(DataRow row)
        {
            Tellyes.Model.DeviceManufacturer model = new Tellyes.Model.DeviceManufacturer();
            if (row != null)
            {
                if (row["DMA_ID"] != null && row["DMA_ID"].ToString() != "")
                {
                    model.DMA_ID = int.Parse(row["DMA_ID"].ToString());
                }
                if (row["DMA_Name"] != null)
                {
                    model.DMA_Name = row["DMA_Name"].ToString();
                }
                if (row["DMA_int"] != null && row["DMA_int"].ToString() != "")
                {
                    model.DMA_int = int.Parse(row["DMA_int"].ToString());
                }
                if (row["DMA_string"] != null)
                {
                    model.DMA_string = row["DMA_string"].ToString();
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
            strSql.Append("select DMA_ID,DMA_Name,DMA_int,DMA_string ");
            strSql.Append(" FROM DeviceManufacturer ");
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
            strSql.Append(" DMA_ID,DMA_Name,DMA_int,DMA_string ");
            strSql.Append(" FROM DeviceManufacturer ");
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
            strSql.Append("select count(1) FROM DeviceManufacturer ");
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
                strSql.Append("order by T.DMA_ID desc");
            }
            strSql.Append(")AS Row, T.*  from DeviceManufacturer T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }

        #endregion  ExtensionMethod

        
    }
}
