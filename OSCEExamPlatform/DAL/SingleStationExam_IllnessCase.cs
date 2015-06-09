using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace Tellyes.DAL
{
    public partial class SingleStationExam_IllnessCase : BaseDAL<Model.SingleStationExam_IllnessCase>
    {
        public SingleStationExam_IllnessCase()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SingleExam_IllnessCase_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SingleStationExam_IllnessCase");
            strSql.Append(" where SingleExam_IllnessCase_ID=@SingleExam_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SingleExam_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SingleExam_IllnessCase_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.SingleStationExam_IllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SingleStationExam_IllnessCase(");
            strSql.Append("E_ID,ES_ID,Illness_Case_ID,Illness_Case_Script_ID,MarkSheetID)");
            strSql.Append(" values (");
            strSql.Append("@E_ID,@ES_ID,@Illness_Case_ID,@Illness_Case_Script_ID,@MarkSheetID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Illness_Case_ID", SqlDbType.Int,4),
					new SqlParameter("@Illness_Case_Script_ID", SqlDbType.Int,4),
					new SqlParameter("@MarkSheetID", SqlDbType.Int,4)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = Guid.NewGuid();
            parameters[2].Value = model.Illness_Case_ID;
            parameters[3].Value = model.Illness_Case_Script_ID;
            parameters[4].Value = model.MarkSheetID;

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
        public bool Update(Tellyes.Model.SingleStationExam_IllnessCase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SingleStationExam_IllnessCase set ");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("ES_ID=@ES_ID,");
            strSql.Append("Illness_Case_ID=@Illness_Case_ID,");
            strSql.Append("Illness_Case_Script_ID=@Illness_Case_Script_ID,");
            strSql.Append("MarkSheetID=@MarkSheetID");
            strSql.Append(" where SingleExam_IllnessCase_ID=@SingleExam_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Illness_Case_ID", SqlDbType.Int,4),
					new SqlParameter("@Illness_Case_Script_ID", SqlDbType.Int,4),
					new SqlParameter("@MarkSheetID", SqlDbType.Int,4),
					new SqlParameter("@SingleExam_IllnessCase_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.E_ID;
            parameters[1].Value = model.ES_ID;
            parameters[2].Value = model.Illness_Case_ID;
            parameters[3].Value = model.Illness_Case_Script_ID;
            parameters[4].Value = model.MarkSheetID;
            parameters[5].Value = model.SingleExam_IllnessCase_ID;

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
        public bool Delete(int SingleExam_IllnessCase_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SingleStationExam_IllnessCase ");
            strSql.Append(" where SingleExam_IllnessCase_ID=@SingleExam_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SingleExam_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SingleExam_IllnessCase_ID;

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
        public bool DeleteList(string SingleExam_IllnessCase_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SingleStationExam_IllnessCase ");
            strSql.Append(" where SingleExam_IllnessCase_ID in (" + SingleExam_IllnessCase_IDlist + ")  ");
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
        public Tellyes.Model.SingleStationExam_IllnessCase GetModel(int SingleExam_IllnessCase_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SingleExam_IllnessCase_ID,E_ID,ES_ID,Illness_Case_ID,Illness_Case_Script_ID,MarkSheetID from SingleStationExam_IllnessCase ");
            strSql.Append(" where SingleExam_IllnessCase_ID=@SingleExam_IllnessCase_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SingleExam_IllnessCase_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = SingleExam_IllnessCase_ID;

            Tellyes.Model.SingleStationExam_IllnessCase model = new Tellyes.Model.SingleStationExam_IllnessCase();
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
        public Tellyes.Model.SingleStationExam_IllnessCase DataRowToModel(DataRow row)
        {
            Tellyes.Model.SingleStationExam_IllnessCase model = new Tellyes.Model.SingleStationExam_IllnessCase();
            if (row != null)
            {
                if (row["SingleExam_IllnessCase_ID"] != null && row["SingleExam_IllnessCase_ID"].ToString() != "")
                {
                    model.SingleExam_IllnessCase_ID = int.Parse(row["SingleExam_IllnessCase_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["Illness_Case_ID"] != null && row["Illness_Case_ID"].ToString() != "")
                {
                    model.Illness_Case_ID = int.Parse(row["Illness_Case_ID"].ToString());
                }
                if (row["Illness_Case_Script_ID"] != null && row["Illness_Case_Script_ID"].ToString() != "")
                {
                    model.Illness_Case_Script_ID = int.Parse(row["Illness_Case_Script_ID"].ToString());
                }
                if (row["MarkSheetID"] != null && row["MarkSheetID"].ToString() != "")
                {
                    model.MarkSheetID = int.Parse(row["MarkSheetID"].ToString());
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
            strSql.Append("select SingleExam_IllnessCase_ID,E_ID,ES_ID,Illness_Case_ID,Illness_Case_Script_ID,MarkSheetID ");
            strSql.Append(" FROM SingleStationExam_IllnessCase ");
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
            strSql.Append(" SingleExam_IllnessCase_ID,E_ID,ES_ID,Illness_Case_ID,Illness_Case_Script_ID,MarkSheetID ");
            strSql.Append(" FROM SingleStationExam_IllnessCase ");
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
            strSql.Append("select count(1) FROM SingleStationExam_IllnessCase ");
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
                strSql.Append("order by T.SingleExam_IllnessCase_ID desc");
            }
            strSql.Append(")AS Row, T.*  from SingleStationExam_IllnessCase T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "SingleStationExam_IllnessCase";
            parameters[1].Value = "SingleExam_IllnessCase_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Like("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("ES_ID,eq"))
            {
                criteria.Add(Restrictions.Like("ES_ID", conditionDictionary["ES_ID,eq"]));
            }
            return criteria;
        }
        #endregion  ExtensionMethod
    }
}
