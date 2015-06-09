using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using NHibernate.Criterion;//Please add references
namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:MarkSheetItem
    /// </summary>
    public partial class MarkSheetItem : BaseDAL<Model.MarkSheetItem>
    {
        public MarkSheetItem()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MSI_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MarkSheetItem");
            strSql.Append(" where MSI_ID=@MSI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSI_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.MarkSheetItem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MarkSheetItem(");
            strSql.Append("MS_ID,MSI_Item,MSI_Score,string1,string2,string3)");
            strSql.Append(" values (");
            strSql.Append("@MS_ID,@MSI_Item,@MSI_Score,@string1,@string2,@string3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@MSI_Item", SqlDbType.NVarChar,200),
					new SqlParameter("@MSI_Score", SqlDbType.Decimal,9),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.MS_ID;
            parameters[1].Value = model.MSI_Item;
            parameters[2].Value = model.MSI_Score;
            parameters[3].Value = model.string1;
            parameters[4].Value = model.string2;
            parameters[5].Value = model.string3;

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
        public bool Update(Tellyes.Model.MarkSheetItem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MarkSheetItem set ");
            strSql.Append("MS_ID=@MS_ID,");
            strSql.Append("MSI_Item=@MSI_Item,");
            strSql.Append("MSI_Score=@MSI_Score,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3");
            strSql.Append(" where MSI_ID=@MSI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@MSI_Item", SqlDbType.NVarChar,200),
					new SqlParameter("@MSI_Score", SqlDbType.Decimal,9),
					new SqlParameter("@string1", SqlDbType.NVarChar,50),
					new SqlParameter("@string2", SqlDbType.NVarChar,50),
					new SqlParameter("@string3", SqlDbType.NVarChar,50),
					new SqlParameter("@MSI_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MS_ID;
            parameters[1].Value = model.MSI_Item;
            parameters[2].Value = model.MSI_Score;
            parameters[3].Value = model.string1;
            parameters[4].Value = model.string2;
            parameters[5].Value = model.string3;
            parameters[6].Value = model.MSI_ID;

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
        public bool Delete(int MSI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheetItem ");
            strSql.Append(" where MSI_ID=@MSI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSI_ID;

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
        public bool DeleteList(string MSI_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MarkSheetItem ");
            strSql.Append(" where MSI_ID in (" + MSI_IDlist + ")  ");
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
        public Tellyes.Model.MarkSheetItem GetModel(int MSI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MSI_ID,MS_ID,MSI_Item,MSI_Score,string1,string2,string3 from MarkSheetItem ");
            strSql.Append(" where MSI_ID=@MSI_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MSI_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = MSI_ID;

            Tellyes.Model.MarkSheetItem model = new Tellyes.Model.MarkSheetItem();
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
        public Tellyes.Model.MarkSheetItem DataRowToModel(DataRow row)
        {
            Tellyes.Model.MarkSheetItem model = new Tellyes.Model.MarkSheetItem();
            if (row != null)
            {
                if (row["MSI_ID"] != null && row["MSI_ID"].ToString() != "")
                {
                    model.MSI_ID = int.Parse(row["MSI_ID"].ToString());
                }
                if (row["MS_ID"] != null && row["MS_ID"].ToString() != "")
                {
                    model.MS_ID = int.Parse(row["MS_ID"].ToString());
                }
                if (row["MSI_Item"] != null)
                {
                    model.MSI_Item = row["MSI_Item"].ToString();
                }
                if (row["MSI_Score"] != null && row["MSI_Score"].ToString() != "")
                {
                    model.MSI_Score = decimal.Parse(row["MSI_Score"].ToString());
                }
                if (row["string1"] != null)
                {
                    model.string1 = row["string1"].ToString();
                }
                if (row["string2"] != null)
                {
                    model.string2 = row["string2"].ToString();
                }
                if (row["string3"] != null)
                {
                    model.string3 = row["string3"].ToString();
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
            strSql.Append("select MSI_ID,MS_ID,MSI_Item,MSI_Score,string1,string2,string3 ");
            strSql.Append(" FROM MarkSheetItem ");
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
            strSql.Append(" MSI_ID,MS_ID,MSI_Item,MSI_Score,string1,string2,string3 ");
            strSql.Append(" FROM MarkSheetItem ");
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
            strSql.Append("select count(1) FROM MarkSheetItem ");
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
                strSql.Append("order by T.MSI_ID desc");
            }
            strSql.Append(")AS Row, T.*  from MarkSheetItem T ");
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
            parameters[0].Value = "MarkSheetItem";
            parameters[1].Value = "MSI_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取评分项详细信息（二级分类）
        /// </summary>
        /// <param name="MS_ID">父评分表ID</param>
        /// <returns></returns>
        public DataSet GetItemsList(int MS_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.*,B.* from ");
            strSql.Append(string.Format(" (select * from MarkSheetItem where string1=0 and MS_ID={0}) as A ", MS_ID));
            strSql.Append(" left join (select MSI_Item as Child_Item,MSI_Score as Child_Score,string1 as Parent_ID from MarkSheetItem) as B on A.MSI_ID=B.Parent_ID");

            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
        #region Extension

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("MarkSheetIDList"))
            {
                criteria.Add(Restrictions.In("MS_ID", (List<int>)conditionDictionary["MarkSheetIDList"]));
            }
            if (conditionDictionary.ContainsKey("MarkSheetID"))
            {
                criteria.Add(Restrictions.Eq("MS_ID", conditionDictionary["MarkSheetID"]));
            }
            if (conditionDictionary.ContainsKey("MarkSheetID,EQ"))
            {
                criteria.Add(Restrictions.Eq("MS_ID", conditionDictionary["MarkSheetID,EQ"]));
            }
            if (conditionDictionary.ContainsKey("MS_ID,IN"))
            {
                criteria.Add(Restrictions.In("MS_ID", (List<int>)conditionDictionary["MS_ID,IN"]));
            }
            if (conditionDictionary.ContainsKey("MSI_ID,IN"))
            {
                criteria.Add(Restrictions.In("MSI_ID", (List<int>)conditionDictionary["MSI_ID,IN"]));
            }
            return criteria;
        }

        #endregion

        #region 获取的是总数二级或者是三级的
        /// <summary>
        /// 获取的是总数二级或者是三级的
        /// </summary>
        /// <returns></returns>
        public object getSecondMarkNewTotal(int MS_ID, string parentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(1) from MarkSheetItem  ");
            strSql.Append(" where MS_ID = @MS_ID  and  string1=@string1 ");
            SqlParameter[] parameters = { 
                                        new SqlParameter("@MS_ID",SqlDbType.Int,4),
                                        new SqlParameter("@string1",SqlDbType.NVarChar,50)
                                      };

            parameters[0].Value = MS_ID;
            parameters[1].Value = parentID;

            return DbHelperSQL.GetSingle(strSql.ToString(), parameters);

        }

        #endregion

        #region 获取二级评分表中的数据
        public List<Tellyes.Model.MarkSheetItem> getSecondMarkNewALL(int MS_ID, string parentID, string pageIndex, string pageSize)
        {
            StringBuilder strSql = new StringBuilder();
            List<Tellyes.Model.MarkSheetItem> markList = null;
            strSql.Append("select * from  ( select *, ROW_NUMBER() over(order by string3   ) as stringOrder from ( select MSI_ID,MS_ID,MSI_Item,MSI_Score,string1,string2,string3 from MarkSheetItem  ");
            strSql.Append(" where MS_ID = @MS_ID  and  string1=@string1  ) secondMark  ) secondsMark where    stringOrder  between   (( " + pageSize + " * " + (Convert.ToInt32(pageIndex) - 1) + " )+1)   and  ( " + pageSize + " * " + (Convert.ToInt32(pageIndex)) + " )   ");
            SqlParameter[] parameters = { 
                                        new SqlParameter("@MS_ID",SqlDbType.Int,4),
                                        new SqlParameter("@string1",SqlDbType.NVarChar,50)
                                      };

            parameters[0].Value = MS_ID;
            parameters[1].Value = parentID;
            DataSet dt = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (dt.Tables[0].Rows.Count > 0)
            {
                markList = new List<Model.MarkSheetItem>();
                foreach (System.Data.DataRow dr in dt.Tables[0].Rows)
                {
                    Tellyes.Model.MarkSheetItem markItem = new Model.MarkSheetItem();
                    markItem.MSI_ID = Convert.ToInt32(dr["MSI_ID"]);
                    markItem.MS_ID = Convert.ToInt32(dr["MS_ID"]);
                    markItem.MSI_Item = dr["MSI_Item"].ToString();
                    markItem.MSI_Score = Convert.ToDecimal(dr["MSI_Score"]);
                    markItem.string1 = dr["string1"].ToString();
                    markItem.string2 = dr["string2"].ToString();
                    markItem.string3 = dr["string3"].ToString();
                    markList.Add(markItem);
                }
            }
            return markList;

        }
        #endregion

        #region 新增二级或者是三级评分列表
        public int addSecondOrThreeMarkSheet(Tellyes.Model.MarkSheetItem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into MarkSheetItem (MS_ID,MSI_Item,MSI_Score,string1,string2,string3) values ( ");
            strSql.Append(" @MS_ID,@MSI_Item,@MSI_Score,@string1,@string2,@string3) ");
            SqlParameter[] parameters ={
                                        new SqlParameter("@MS_ID", SqlDbType.Int,4),
                                        new SqlParameter("@MSI_Item",SqlDbType.NVarChar,200),
                                        new SqlParameter("@MSI_Score",SqlDbType.Int,4),
                                        new SqlParameter("@string1",SqlDbType.NVarChar,50),
                                        new SqlParameter("@string2",SqlDbType.NVarChar,50),
                                        new SqlParameter("@string3",SqlDbType.NVarChar,50)
                                      };

            parameters[0].Value = model.MS_ID;
            parameters[1].Value = model.MSI_Item;
            parameters[2].Value = model.MSI_Score;
            parameters[3].Value = model.string1;
            parameters[4].Value = model.string2;
            parameters[5].Value = model.string3;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        #endregion

        #region 编辑二级或者是三级评分列表
        /// <summary>
        /// /测试用到的编辑二级或者是三级评分列表
        /// </summary>
        /// <returns></returns>
        public int editSecondOrThreeMarkSheet(Tellyes.Model.MarkSheetItem model,decimal secondMark,decimal oneMark)
        {
            List<string> strSqlList = new List<string>();
            StringBuilder strSql = new StringBuilder();
            //if (string.IsNullOrEmpty(model.MSI_Score.ToString()))
            //{
            //    strSql.Append("update  MarkSheetItem set MSI_Item = @MSI_Item  ");
            //}
            //else {
            //    strSql.Append(" update  MarkSheetItem set MSI_Item = @MSI_Item , MSI_Score=@MSI_Score ");
            
            //}
            //strSql.Append(" where MSI_ID=@MSI_ID  ");

            //if (string.IsNullOrEmpty(model.MSI_Score.ToString()))
            //{
            //    SqlParameter[] parameters ={ 
            //                           new SqlParameter("@MSI_Item",SqlDbType.NVarChar,200),
            //                           new SqlParameter("@MSI_ID",SqlDbType.Int,4)
            //                         };
            //    parameters[0].Value = model.MSI_Item;
            //    parameters[1].Value = model.MSI_ID;
            //    return DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            //}
            //else
            //{
            //    SqlParameter[] parameters ={ 
            //                           new SqlParameter("@MSI_Item",SqlDbType.NVarChar,200),
            //                           new SqlParameter("@MSI_ID",SqlDbType.Int,4),
            //                           new SqlParameter("@MSI_Score",SqlDbType.Decimal,18)
            //                         };
            //    parameters[0].Value = model.MSI_Item;
            //    parameters[1].Value = model.MSI_ID;
            //    parameters[2].Value = model.MSI_Score;
            if(model!=null && secondMark>0 && oneMark>0)
            {
              strSql.Append(" update  MarkSheetItem set MSI_Item = '"+model.MSI_Item+"' , MSI_Score="+model.MSI_Score+" ");
              strSql.Append(" where MSI_ID="+model.MSI_ID+"  ");
              strSqlList.Add(strSql.ToString());
              strSql.Clear();
              strSql.Append(" update  MarkSheetItem set  MSI_Score="+secondMark+"  where  MSI_ID="+model.string1+" ");
              strSqlList.Add(strSql.ToString());
              strSql.Clear();
              strSql.Append(" update MarkSheet set Ms_Score ="+oneMark+"  where MS_ID ="+model.MS_ID+" ");
              strSqlList.Add(strSql.ToString());
              strSql.Clear();
            }

              

                return DbHelperSQL.ExecuteSqlTran(strSqlList);
        }

        #endregion

        


        #region 删除二级或者是三级评分列表
        public int delSecondOrThreeMarkSheet(params string[] msiList)
        {

            StringBuilder strSql = new StringBuilder();
            List<string> strList = new List<string>();
            for (int i = 0; i < msiList.Length; i++)
            {
                string[] msipartList = msiList[i].Split(',');
                strSql.Append(" delete from MarkSheetItem  where  ");
                if (msipartList[2] == "0")
                {
                    strSql.Append(" MSI_ID =" + msipartList[0] + " and    MS_ID=" + msipartList[1] + "  and  string1=" + msipartList[2] + " ");
                    strList.Add(strSql.ToString());
                    strSql.Clear();
                    strSql.Append("  delete from MarkSheetItem  where   MS_ID=" + msipartList[1] + "  and  string1=" + msipartList[0] + "  ");
                    strList.Add(strSql.ToString());
                    strSql.Clear();
                }
                else
                {
                    strSql.Append(" MSI_ID =" + msipartList[0] + "  and  MS_ID = " + msipartList[1] + "  and  string1=" + msipartList[2] + "  ");
                }
                strList.Add(strSql.ToString());
                strSql.Clear();
                msipartList = null;
            }

            return DbHelperSQL.ExecuteSqlTran(strList);

        }
        #endregion

        #region 向上移动或者是向下移动的功能，进行更新数据
        /// <summary>
        ///  向上移动或者是向下移动的功能，进行更新数据
        /// </summary>
        public int insertSecondOrThreeMarkSheet(List<Tellyes.Model.MarkSheetItem> model)
        {
            StringBuilder strSql = new StringBuilder();
            List<string> strList = new List<string>();
            if (model != null)
            {
                foreach (Tellyes.Model.MarkSheetItem item in model)
                {
                    strSql.Append(" update MarkSheetItem set  string3='" + item.string3 + "'  where MSI_ID=" + item.MSI_ID + "  ");
                    strList.Add(strSql.ToString());
                    strSql.Clear();
                }
            }

            return DbHelperSQL.ExecuteSqlTran(strList);
        }
        #endregion

        #region 获取二级评分表中的数据
        public List<Tellyes.Model.MarkSheetItem> getSecondMarkNew(int MS_ID, string parentID)
        {
            StringBuilder strSql = new StringBuilder();
            List<Tellyes.Model.MarkSheetItem> markList = null;
            strSql.Append(" select MSI_ID,MS_ID,MSI_Item,MSI_Score,string1,string2,string3 from MarkSheetItem  ");
            strSql.Append(" where MS_ID = @MS_ID  and  string1=@string1 ");
            SqlParameter[] parameters = { 
                                        new SqlParameter("@MS_ID",SqlDbType.Int,4),
                                        new SqlParameter("@string1",SqlDbType.NVarChar,50)
                                      };

            parameters[0].Value = MS_ID;
            parameters[1].Value = parentID;
            DataSet dt = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (dt.Tables[0].Rows.Count > 0)
            {
                markList = new List<Model.MarkSheetItem>();
                foreach (System.Data.DataRow dr in dt.Tables[0].Rows)
                {
                    Tellyes.Model.MarkSheetItem markItem = new Model.MarkSheetItem();
                    markItem.MSI_ID = Convert.ToInt32(dr["MSI_ID"]);
                    markItem.MS_ID = Convert.ToInt32(dr["MS_ID"]);
                    markItem.MSI_Item = dr["MSI_Item"].ToString();
                    markItem.MSI_Score = Convert.ToDecimal(dr["MSI_Score"]);
                    markItem.string1 = dr["string1"].ToString();
                    markItem.string2 = dr["string2"].ToString();
                    markItem.string3 = dr["string3"].ToString();
                    markList.Add(markItem);
                }
            }
            return markList;

        }
        #endregion

        
    }
}

