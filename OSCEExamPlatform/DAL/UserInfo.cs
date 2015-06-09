using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Tellyes.DBUtility;
using System.Collections.Generic;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;//Please add references
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace Tellyes.DAL
{
	/// <summary>
	/// 数据访问类:UserInfo
	/// </summary>
	public partial class UserInfo : BaseDAL<Model.UserInfo>
	{
		public UserInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("U_ID", "UserInfo"); 
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserInfo");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = U_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string U_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserInfo");
            strSql.Append(" where U_Name=@U_Name");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = U_Name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserInfo(");
            strSql.Append("U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit,U_OriginalUrl,U_ThumbnailUrl)");
            strSql.Append(" values (");
            strSql.Append("@U_Name,@U_TrueName,@U_PWD,@U_Sex,@U_Phone,@U_Phone2,@U_Email,@U_Email2,@U_Contont,@U_Photo,@U_GoodField,@U_Title,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3,@U_Ethnic,@U_Education,@U_InTime,@U_Source,@U_Unit,@U_OriginalUrl,@U_ThumbnailUrl)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_Ethnic", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_OriginalUrl", SqlDbType.NVarChar,20),
					new SqlParameter("@U_ThumbnailUrl", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.U_Name;
            parameters[1].Value = model.U_TrueName;
            parameters[2].Value = model.U_PWD;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Phone;
            parameters[5].Value = model.U_Phone2;
            parameters[6].Value = model.U_Email;
            parameters[7].Value = model.U_Email2;
            parameters[8].Value = model.U_Contont;
            parameters[9].Value = model.U_Photo;
            parameters[10].Value = model.U_GoodField;
            parameters[11].Value = model.U_Title;
            parameters[12].Value = model.int1;
            parameters[13].Value = model.int2;
            parameters[14].Value = model.int3;
            parameters[15].Value = model.string1;
            parameters[16].Value = model.string2;
            parameters[17].Value = model.string3;
            parameters[18].Value = model.date1;
            parameters[19].Value = model.date2;
            parameters[20].Value = model.date3;
            parameters[21].Value = model.float1;
            parameters[22].Value = model.float2;
            parameters[23].Value = model.float3;
            parameters[24].Value = model.U_Ethnic;
            parameters[25].Value = model.U_Education;
            parameters[26].Value = model.U_InTime;
            parameters[27].Value = model.U_Source;
            parameters[28].Value = model.U_Unit;
            parameters[29].Value = model.U_OriginalUrl;
            parameters[30].Value = model.U_ThumbnailUrl;

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
        public bool Update(Tellyes.Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserInfo set ");
            strSql.Append("U_Name=@U_Name,");
            strSql.Append("U_TrueName=@U_TrueName,");
            strSql.Append("U_PWD=@U_PWD,");
            strSql.Append("U_Sex=@U_Sex,");
            strSql.Append("U_Phone=@U_Phone,");
            strSql.Append("U_Phone2=@U_Phone2,");
            strSql.Append("U_Email=@U_Email,");
            strSql.Append("U_Email2=@U_Email2,");
            strSql.Append("U_Contont=@U_Contont,");
            strSql.Append("U_Photo=@U_Photo,");
            strSql.Append("U_GoodField=@U_GoodField,");
            strSql.Append("U_Title=@U_Title,");
            strSql.Append("int1=@int1,");
            strSql.Append("int2=@int2,");
            strSql.Append("int3=@int3,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3,");
            strSql.Append("date1=@date1,");
            strSql.Append("date2=@date2,");
            strSql.Append("date3=@date3,");
            strSql.Append("float1=@float1,");
            strSql.Append("float2=@float2,");
            strSql.Append("float3=@float3,");
            strSql.Append("U_Ethnic=@U_Ethnic,");
            strSql.Append("U_Education=@U_Education,");
            strSql.Append("U_InTime=@U_InTime,");
            strSql.Append("U_Source=@U_Source,");
            strSql.Append("U_Unit=@U_Unit,");
            strSql.Append("U_OriginalUrl=@U_OriginalUrl,");
            strSql.Append("U_ThumbnailUrl=@U_ThumbnailUrl");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_Ethnic", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_OriginalUrl", SqlDbType.NVarChar,20),
					new SqlParameter("@U_ThumbnailUrl", SqlDbType.NVarChar,20),
					new SqlParameter("@U_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.U_Name;
            parameters[1].Value = model.U_TrueName;
            parameters[2].Value = model.U_PWD;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Phone;
            parameters[5].Value = model.U_Phone2;
            parameters[6].Value = model.U_Email;
            parameters[7].Value = model.U_Email2;
            parameters[8].Value = model.U_Contont;
            parameters[9].Value = model.U_Photo;
            parameters[10].Value = model.U_GoodField;
            parameters[11].Value = model.U_Title;
            parameters[12].Value = model.int1;
            parameters[13].Value = model.int2;
            parameters[14].Value = model.int3;
            parameters[15].Value = model.string1;
            parameters[16].Value = model.string2;
            parameters[17].Value = model.string3;
            parameters[18].Value = model.date1;
            parameters[19].Value = model.date2;
            parameters[20].Value = model.date3;
            parameters[21].Value = model.float1;
            parameters[22].Value = model.float2;
            parameters[23].Value = model.float3;
            parameters[24].Value = model.U_Ethnic;
            parameters[25].Value = model.U_Education;
            parameters[26].Value = model.U_InTime;
            parameters[27].Value = model.U_Source;
            parameters[28].Value = model.U_Unit;
            parameters[29].Value = model.U_OriginalUrl;
            parameters[30].Value = model.U_ThumbnailUrl;
            parameters[31].Value = model.U_ID;

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
        public bool Delete(int U_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = U_ID;

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
        public bool DeleteList(string U_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where U_ID in (" + U_IDlist + ")  ");
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
        public Tellyes.Model.UserInfo GetModel(int U_ID)    
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 U_ID,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit,U_OriginalUrl,U_ThumbnailUrl from UserInfo ");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = U_ID;

            Tellyes.Model.UserInfo model = new Tellyes.Model.UserInfo();
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
        public Tellyes.Model.UserInfo DataRowToModel(DataRow row)
        {
            Tellyes.Model.UserInfo model = new Tellyes.Model.UserInfo();
            if (row != null)
            {
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["U_Name"] != null)
                {
                    model.U_Name = row["U_Name"].ToString();
                }
                if (row["U_TrueName"] != null)
                {
                    model.U_TrueName = row["U_TrueName"].ToString();
                }
                if (row["U_PWD"] != null)
                {
                    model.U_PWD = row["U_PWD"].ToString();
                }
                if (row["U_Sex"] != null && row["U_Sex"].ToString() != "")
                {
                    model.U_Sex = int.Parse(row["U_Sex"].ToString());
                }
                if (row["U_Phone"] != null)
                {
                    model.U_Phone = row["U_Phone"].ToString();
                }
                if (row["U_Phone2"] != null)
                {
                    model.U_Phone2 = row["U_Phone2"].ToString();
                }
                if (row["U_Email"] != null)
                {
                    model.U_Email = row["U_Email"].ToString();
                }
                if (row["U_Email2"] != null)
                {
                    model.U_Email2 = row["U_Email2"].ToString();
                }
                if (row["U_Contont"] != null)
                {
                    model.U_Contont = row["U_Contont"].ToString();
                }
                if (row["U_Photo"] != null && row["U_Photo"].ToString() != "")
                {
                    model.U_Photo = (byte[])row["U_Photo"];
                }
                if (row["U_GoodField"] != null)
                {
                    model.U_GoodField = row["U_GoodField"].ToString();
                }
                if (row["U_Title"] != null)
                {
                    model.U_Title = row["U_Title"].ToString();
                }
                if (row["int1"] != null && row["int1"].ToString() != "")
                {
                    model.int1 = int.Parse(row["int1"].ToString());
                }
                if (row["int2"] != null && row["int2"].ToString() != "")
                {
                    model.int2 = int.Parse(row["int2"].ToString());
                }
                if (row["int3"] != null && row["int3"].ToString() != "")
                {
                    model.int3 = int.Parse(row["int3"].ToString());
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
                if (row["date1"] != null && row["date1"].ToString() != "")
                {
                    model.date1 = DateTime.Parse(row["date1"].ToString());
                }
                if (row["date2"] != null && row["date2"].ToString() != "")
                {
                    model.date2 = DateTime.Parse(row["date2"].ToString());
                }
                if (row["date3"] != null && row["date3"].ToString() != "")
                {
                    model.date3 = DateTime.Parse(row["date3"].ToString());
                }
                if (row["float1"] != null && row["float1"].ToString() != "")
                {
                    model.float1 = decimal.Parse(row["float1"].ToString());
                }
                if (row["float2"] != null && row["float2"].ToString() != "")
                {
                    model.float2 = decimal.Parse(row["float2"].ToString());
                }
                if (row["float3"] != null && row["float3"].ToString() != "")
                {
                    model.float3 = decimal.Parse(row["float3"].ToString());
                }
                if (row["U_Ethnic"] != null)
                {
                    model.U_Ethnic = row["U_Ethnic"].ToString();
                }
                if (row["U_Education"] != null)
                {
                    model.U_Education = row["U_Education"].ToString();
                }
                if (row["U_InTime"] != null && row["U_InTime"].ToString() != "")
                {
                    model.U_InTime = DateTime.Parse(row["U_InTime"].ToString());
                }
                if (row["U_Source"] != null)
                {
                    model.U_Source = row["U_Source"].ToString();
                }
                if (row["U_Unit"] != null)
                {
                    model.U_Unit = row["U_Unit"].ToString();
                }
                if (row["U_OriginalUrl"] != null)
                {
                    model.U_OriginalUrl = row["U_OriginalUrl"].ToString();
                }
                if (row["U_ThumbnailUrl"] != null)
                {
                    model.U_ThumbnailUrl = row["U_ThumbnailUrl"].ToString();
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
            strSql.Append("select U_ID,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit,U_OriginalUrl,U_ThumbnailUrl ");
            strSql.Append(" FROM UserInfo ");
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
            strSql.Append(" U_ID,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit,U_OriginalUrl,U_ThumbnailUrl ");
            strSql.Append(" FROM UserInfo ");
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
            strSql.Append("select count(1) FROM UserInfo ");
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
                strSql.Append("order by T.U_ID desc");
            }
            strSql.Append(")AS Row, T.*  from UserInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        public DataSet GetAllInfoByPage(string where ,string orderby,int startIndex,int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserInfo.U_ID,UserInfo.U_Name ,UserInfo.U_Education,UserInfo.U_Sex,UserInfo.U_Email,UserInfo.U_Phone,UserInfo.U_Contont,UserInfo.U_GoodField,UserInfo.U_InTime,UserInfo.U_Source,UserInfo.U_Unit,UserInfo.U_TrueName,Role.R_ID,Role.R_Name,Organization.O_ID,Organization.O_Name,Organization.O_ParentID");
            strSql.Append("from UserInfo join UserRole on UserInfo.U_ID=UserRole.U_ID join Role on UserRole.R_ID=Role.R_ID join UserOrganization on UserInfo.U_ID=UserOrganization.U_ID join Organization on Organization.O_ID=UserOrganization.O_ID");
            
            return DbHelperSQL.Query(strSql.ToString());
        }

		#endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 将页面中的显示数据的表格，转换为Excel显示的表格并返回
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ht"></param>
        /// <returns></returns>
        public DataSet GetExcleDS(List<string> list, Hashtable ht, DataSet ds, int rid)
        {
            string str = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                str += "'" + ds.Tables[0].Rows[i]["U_ID"].ToString() + "',";
            }
            str = str.Trim(new char[] { ',' });
            if (list == null || list.Count == 0)
            {
                return null;
            }
            string strSql = "select ";
            for (int i = 0; i < list.Count; i++)
            {
                string colHeader = list[i];
                if (colHeader != "U_Sex")
                {

                    strSql += "t1." + colHeader + " '" + ht[colHeader].ToString() + "',";

                }
                else
                {
                    strSql += "case when U_Sex=1 then '男' else '女' end ' " + ht[colHeader].ToString() + "',";
                }
            }
            strSql = strSql.Trim(new char[] { ',' });
            strSql += "from UserInfo t1"
                + " left join UserRole t2 on t1.U_ID=t2.U_ID "
                + " where t2.R_ID = " + rid + "  order by t1.U_ID desc";
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="uList"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public bool ImportUser(List<Model.UserInfo> uList, ref string err, List<Int32> roleIDList = null)
        {
            List<CommandInfo> cmdList = new List<CommandInfo>();
            List<Model.UserInfo> tempList = new List<Model.UserInfo>();
            for (int i = 0; i < uList.Count; i++)
            {
                tempList.Add(uList[i]);
            }
            int rowNum = 0;
            err="";
            bool bk = false;
            for (int i = 0; i < uList.Count; i++)            
            {
                Model.UserInfo model = uList[i];
                tempList.RemoveAt(0);
                var q = from user in tempList
                        where user.U_Name == model.U_Name
                        select user;
                List<Model.UserInfo> pdList = q.ToList<Model.UserInfo>();
                if (pdList.Count > 0)
                {
                    err += "发生错误：上传的文件中，共有“" + (pdList.Count + 1) + "”条记录，包含了用户名为【" + model.U_Name + "】的信息，请检查并更改后，方可导入";
                    bk = true;
                    break;
                }
                model.U_PWD = "000000";
                rowNum++;
                if (model.U_Name.Length == 0 || model.U_Name.Length > 20)
                {
                    err += "第" + rowNum + "行发生错误：【用户名】格式非法，请控制在20位之内，并不能为空";
                    bk = true;
                    break;
                }
                if (Exists(model.U_Name))
                {
                    err += "第" + rowNum + "行发生错误：已包含【用户名】为：“"+model.U_Name+"”的记录";
                    bk = true;
                    break;
                }
                if (model.U_TrueName.Length == 0 || model.U_TrueName.Length > 20)
                {
                    err += "第" + rowNum + "行发生错误：【真实姓名】格式非法，请控制在20位之内，并不能为空";
                    bk = true;
                    break;
                }
                if (model.U_Source != null && model.U_Source.Length>20)
                {
                    err += "第" + rowNum + "行发生错误：【生源地】格式非法，请控制在20位之内";
                    bk = true;
                    break;
                }
                //Regex r = new egex(@"((^((1[8-9]\\d{2})|([2-9]\\d{3}))([-\\/\\._])(10|12|0?[13578])([-\\/\\._])(3[01]|[12][0-9]|0?[1-9])$)|(^((1[8-9]\\d{2})|([2-9]\\d{3}))([-\\/\\._])(11|0?[469])([-\\/\\._])(30|[12][0-9]|0?[1-9])$)|(^((1[8-9]\\d{2})|([2-9]\\d{3}))([-\\/\\._])(0?2)([-\\/\\._])(2[0-8]|1[0-9]|0?[1-9])$)|(^([2468][048]00)([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([3579][26]00)([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([1][89][0][48])([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([2-9][0-9][0][48])([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([1][89][2468][048])([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([2-9][0-9][2468][048])([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([1][89][13579][26])([-\\/\\._])(0?2)([-\\/\\._])(29)$)|(^([2-9][0-9][13579][26])([-\\/\\._])(0?2)([-\\/\\._])(29)$)");
                //if (!model.date1.HasValue)
                //{
                //    err += "第" + rowNum + "行发生错误：【出生日期】不能为空";
                //    bk = true;
                //    break;
                //}
                try
                {
                    if (model.date1.HasValue)
                    {
                        string str = model.date1.Value.ToString("yyyy-MM-dd");
                    }
                    
                }
                catch (Exception)
                {
                    err += "第" + rowNum + "行发生错误：【出生日期】格式非法";
                    bk = true;
                    break;
                }
                Regex r = new Regex(@"[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{4}");
                if (!r.IsMatch(model.string1))
                {
                    err += "第" + rowNum + "行发生错误：【身份证号】格式非法";
                    bk = true;
                    break;
                }
                if (string.IsNullOrEmpty(model.string2) && model.string2.Length > 50)
                {
                    err += "第" + rowNum + "行发生错误：【毕业院校】格式非法，请控制在50位之内";
                    bk = true;
                    break;
                }
                if (string.IsNullOrEmpty(model.string3) && model.string3.Length > 10)
                {
                    err += "第" + rowNum + "行发生错误：【政治背景】格式非法，请控制在10位之内";
                    bk = true;
                    break;
                }
                if (!string.IsNullOrEmpty(model.U_Contont))
                {
                    if (model.U_Contont.Length > 500)
                    {
                        err += "第" + rowNum + "行发生错误：【备注】格式非法，请控制在500位之内";
                        bk = true;
                        break;
                    }
                }
                
                if (model.U_Education.Length > 10)
                {
                    err += "第" + rowNum + "行发生错误：【学历】格式非法，请控制在10位之内";
                    bk = true;
                    break;
                }
                r = new Regex(@"0?(13[0-9]|15[0-9]|18[0-9]|14[0-9])[0-9]{8}");
                if (string.IsNullOrEmpty(model.U_Phone))
                {
                    err += "第" + rowNum + "行发生错误：【手机号码】不能为空";
                    bk = true;
                    break;
                }
                if (!r.IsMatch(model.U_Phone))
                {
                    err += "第" + rowNum + "行发生错误：【手机号码】格式非法";
                    bk = true;
                    break;
                }
                if (!string.IsNullOrEmpty(model.U_Phone2) && !r.IsMatch(model.U_Phone))
                {
                    err += "第" + rowNum + "行发生错误：【手机号码(备用)】格式非法";
                    bk = true;
                    break;
                }
                r = new Regex(@"[\w\-\.]+@[\w\-\.]+(\.\w+)+");
                if (string.IsNullOrEmpty(model.U_Email))
                {
                    err += "第" + rowNum + "行发生错误：【Email】不能为空";
                    bk = true;
                    break;
                }
                if (!r.IsMatch(model.U_Email))
                {
                    err += "第" + rowNum + "行发生错误：【Email】格式非法";
                    bk = true;
                    break;
                }
                if (!string.IsNullOrEmpty(model.U_Email2) && !r.IsMatch(model.U_Email2))
                {
                    err += "第" + rowNum + "行发生错误：【Email(备用)】格式非法";
                    bk = true;
                    break;
                }
                if (!string.IsNullOrEmpty(model.U_Ethnic) && model.U_Ethnic.Length > 10)
                {
                    err += "第" + rowNum + "行发生错误：【民族】格式非法，请控制在10位之内";
                    bk = true;
                    break;
                }
                //if (!string.IsNullOrEmpty(model.U_Education) && model.U_Education.Length > 10)
                //{
                //    err += "第" + rowNum + "行发生错误：【学历】格式非法，请控制在10位之内";
                //    bk = true;
                //    break;
                //}
                if (!model.U_InTime.HasValue)
                {
                    err += "第" + rowNum + "行发生错误：【入学时间】不能为空";
                    bk = true;
                    break;
                }
                try
                {
                    if (model.date1.HasValue)
                    {
                        string str = model.U_InTime.Value.ToString("yyyy-MM-dd");
                    }

                }
                catch 
                {
                    err += "第" + rowNum + "行发生错误：【入学时间】格式非法";
                    bk = true;
                    break;
                }
                cmdList.Add(getAdd(model));
                Tellyes.Model.UserRole ur = new Model.UserRole();
                if (roleIDList != null)
                {
                    ur.R_ID = roleIDList.ToArray()[i];
                }
                cmdList.Add(getAddUserRole(ur));
               
            }
            if (bk)
            {
                return false;
            }
            try
            {
                return DbHelperSQL.ExecuteSqlTran(cmdList, new object()) ;
            }
            catch 
            {
                return false;
            }
        }

        
        /// <summary>
        /// 验证登陆的合法性
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public Model.UserInfo ValidateLogin(string userName, string Password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select U_ID,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit");
            strSql.Append(" FROM UserInfo where U_Name=@U_Name and U_PWD=@U_PWD");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,50)};
            parameters[0].Value = userName;
            parameters[1].Value = Password;
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
        /// 根据用户信息，查询符合条件的用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <returns></returns>
        public DataSet getUserByInfo(string name,string ridList,string OID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct tt.U_ID, U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_GoodField,U_Title,int1,int2 from (");
            strSql.Append("select t1.* from UserInfo t1");
            strSql.Append(" left join UserRole t2 on t1.U_ID=t2.U_ID");
            strSql.Append(" left join UserOrganization t3 on t1.U_ID=t3.U_ID where 1=1");
            
            if (!string.IsNullOrEmpty(name))
            {
                strSql.Append("  and (t1.U_Name like '%" + name + "%' or t1.U_TrueName like '%" + name + "%')");
            }

            if (!string.IsNullOrEmpty(ridList))
            {                              
                strSql.Append(" and t2.R_ID in (" + ridList + ")");                
            }

            
            if (!string.IsNullOrEmpty(OID))
            {
                if (OID != "-1")
                {
                    
                        strSql.Append(" and t3.O_ID in (" + OID + ")");
                    
                }
            }

           

            if (ridList.IndexOf("0") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserRole))");
            }

            if (OID.IndexOf("-2") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserOrganization))");
            }

            strSql.Append(") tt");
            try
            {
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }


        #region  根据条件进行的筛选信息的-----里面还涉到了分页信息
        /// <summary>
        /// 根据条件进行的筛选信息的-----里面还涉到了分页信息
        /// </summary>where  flagAutoIncreate  between   ( "+pagesize+" * (" + CurrentPage + " -1)+1)   and   "+pagesize+" * (" + CurrentPage + ") 
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <param name="CurrentPage"></param>
        /// <returns></returns>
        public DataSet getUserbyInfos(string name, string ridList, string OID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  *   from (  ");
            strSql.Append("select distinct tt.U_ID,tt.R_ID,tt.R_Name ,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_GoodField,U_Title,int1,int2,string1,string2,string3,date1,U_Ethnic,U_Education,U_Source,U_InTime,U_OriginalUrl,U_ThumbnailUrl ,ROW_NUMBER() over(order by tt.U_ID)  as  flagAutoIncreate  from (");

            strSql.Append("select t1.*  , convert(nvarchar(10) ,t2.R_ID) as R_ID,t4.R_Name  from UserInfo t1");
            strSql.Append(" left join UserRole t2 on t1.U_ID=t2.U_ID ");
            strSql.Append(" left join UserOrganization t3 on t1.U_ID=t3.U_ID  left join  role as t4 on t2.R_ID=t4.R_ID   where 1=1");

            if (!string.IsNullOrEmpty(name))
            {
                strSql.Append("  and (t1.U_Name like '%" + name + "%' or t1.U_TrueName like '%" + name + "%')");
            }

            if (ridList!="-1")
            {
                strSql.Append(" and t2.R_ID in (" + ridList + ")");
            }


            if (!string.IsNullOrEmpty(OID))
            {
                if (OID != "-1")
                {

                    strSql.Append(" and t3.O_ID in (" + OID + ")");

                }
            }



            if (ridList.IndexOf("0") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserRole))");
            }

            if (OID.IndexOf("-2") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserOrganization))");
            }

            strSql.Append(") tt");

            strSql.Append(") ss    ");
            string strs = strSql.ToString();
            try
            {
                return DbHelperSQL.Query(strs);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 查询总的信息
        /// <summary>
        /// 查询总的信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ridList"></param>
        /// <param name="OID"></param>
        /// <returns></returns>
        public DataSet getUserByInfosCount(string name, string ridList, string OID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  *   from (  ");
            strSql.Append("select distinct tt.U_ID,  tt.R_ID ,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_GoodField,U_Title,int1,int2,string1,string2,string3,date1,U_Ethnic,U_Education,U_Source,U_InTime, ROW_NUMBER() over(order by tt.U_ID)  as  flagAutoIncreate  from (");

            strSql.Append("select t1.* , t2.R_ID  from UserInfo t1");
            strSql.Append(" left join UserRole t2 on t1.U_ID=t2.U_ID");
            strSql.Append(" left join UserOrganization t3 on t1.U_ID=t3.U_ID where 1=1");

            if (!string.IsNullOrEmpty(name))
            {
                strSql.Append("  and (t1.U_Name like '%" + name + "%' or t1.U_TrueName like '%" + name + "%')");
            }

            if (ridList != "-1")
            {
                strSql.Append(" and t2.R_ID in (" + ridList + ")");
            }


            if (!string.IsNullOrEmpty(OID))
            {
                if (OID != "-1")
                {

                    strSql.Append(" and t3.O_ID in (" + OID + ")");

                }
            }



            if (ridList.IndexOf("0") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserRole))");
            }

            if (OID.IndexOf("-2") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserOrganization))");
            }

            strSql.Append(") tt");

            strSql.Append(") ss   ");
            try
            {
                return DbHelperSQL.Query(strSql.ToString());

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region  获取的总的记录数
        public object getTotalUserInfosRecords(string name, string ridList, string OID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  count(1) from (  ");
            strSql.Append("select distinct tt.U_ID, tt.R_ID ,U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_GoodField,U_Title,int1,int2,string1,string2,string3,date1,U_Ethnic,U_Education,U_Source,U_InTime, ROW_NUMBER() over(order by tt.U_ID)  as  flagAutoIncreate  from (");

            strSql.Append("select t1.*  , t2.R_ID  from UserInfo t1");
            strSql.Append(" left join UserRole t2 on t1.U_ID=t2.U_ID");
            strSql.Append(" left join UserOrganization t3 on t1.U_ID=t3.U_ID where 1=1");

            if (!string.IsNullOrEmpty(name))
            {
                strSql.Append("  and (t1.U_Name like '%" + name + "%' or t1.U_TrueName like '%" + name + "%')");
            }

            if (ridList != "-1")
            {
                strSql.Append(" and t2.R_ID in (" + ridList + ")");
            }


            if (!string.IsNullOrEmpty(OID))
            {
                if (OID != "-1")
                {

                    strSql.Append(" and t3.O_ID in (" + OID + ")");

                }
            }



            if (ridList.IndexOf("0") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserRole))");
            }

            if (OID.IndexOf("-2") > -1)
            {
                strSql.Append(" union all(select * from UserInfo where U_ID not in (select U_ID from UserOrganization))");
            }

            strSql.Append(") tt");

            strSql.Append(") ss     ");
            try
            {
                return DbHelperSQL.GetSingle(strSql.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        
        }
        #endregion

        /// <summary>
        /// 根据用户名，查询用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string getUserIdByUserName(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select U_ID from UserInfo where U_Name='"+name+"'");
            
            DataSet ds= DbHelperSQL.Query(strSql.ToString());
            if (ds != null)
            {
                return ds.Tables[0].Rows[0]["U_ID"].ToString();
            }
            else{
                return null;
            }
        }


        /// <summary>
        /// 根据角色获得用户的集合
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public DataSet getUserByRid(int rid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from UserInfo where U_ID in (select U_ID from UserRole where R_ID = @R_ID)");
            SqlParameter[] parameters = {
                                            new SqlParameter("R_ID",SqlDbType.Int,4)};
            parameters[0].Value = rid;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 添加一个User（事务处理，包括添加用户的角色集合，以及组织机构集合）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="rids"></param>
        /// <param name="oids"></param>
        /// <param name="managementoids"></param>
        /// <returns></returns>
        public bool InsertByTran(Model.UserInfo model, string rids, string oids, string managementoids)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getAdd(model));
            rids = rids.Replace("'", "");
            oids = oids.Replace("'", "");
            if (!string.IsNullOrEmpty(rids))
            {
                string[] ridArr = rids.Split(new char[] { ',' });
                for (int i = 0; i < ridArr.Length; i++)
                {
                    Model.UserRole ur = new Model.UserRole();
                    ur.R_ID = int.Parse(ridArr[i]);
                    ur.U_ID = 0;
                    list.Add(getAddUserRole(ur));
                }
            }
            if (!string.IsNullOrEmpty(oids))
            {
                string[] oidArr = oids.Split(new char[] { ',' });
                for (int i = 0; i < oidArr.Length; i++)
                {
                    Model.UserOrganization uo = new Model.UserOrganization();
                    uo.O_ID = int.Parse(oidArr[i]);
                    uo.U_ID = 0;
                    list.Add(getAddUserOrganization(uo));
                }
            }
            if (!string.IsNullOrEmpty(managementoids))
            {
                string[] managementoidArr = managementoids.Split(new char[] { ',' });
                for (int i = 0; i < managementoidArr.Length; i++)
                {
                    Model.ManagementRelation mr = new Model.ManagementRelation();
                    mr.O_ID = int.Parse(managementoidArr[i]);
                    mr.U_ID = 0;
                    mr.Flag = 0;
                    mr.AddTime = DateTime.Now;
                    mr.EndTime = DateTime.Now;
                    list.Add(getAddManagementRelation(mr));
                }
            }
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list, new object());
            }
            catch (Exception)
            {
                return false;   
            }
        }

        /// <summary>
        /// 修改一个用户（事务处理，包括更改角色的变更信息，以及组织机构的变更信息）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="rids"></param>
        /// <param name="oids"></param>
        /// <param name="managementoids"></param>
        /// <returns></returns>
        public bool UpdByTran(Model.UserInfo model, string rids, string oids, string managementoids)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getUpdUser(model));
            list.Add(getDelUserRole(model.U_ID));
            list.Add(getDelUserOrganization(model.U_ID));
            list.Add(getDelManagementRelation(model.U_ID));
            if (!string.IsNullOrEmpty(rids))
            {
                string[] ridArr = rids.Split(new char[] { ',' });
                for (int i = 0; i < ridArr.Length; i++)
                {
                    Model.UserRole ur = new Model.UserRole();
                    ur.R_ID = int.Parse(ridArr[i]);
                    ur.U_ID = model.U_ID;
                    list.Add(getAddUserRole(ur));
                }
            }
            if (!string.IsNullOrEmpty(oids))
            {
                oids = oids.Replace("'", "");
                string[] oidArr = oids.Split(new char[] { ',' });
                for (int i = 0; i < oidArr.Length; i++)
                {
                    Model.UserOrganization uo = new Model.UserOrganization();
                    uo.O_ID = int.Parse(oidArr[i]);
                    uo.U_ID = model.U_ID;
                    list.Add(getAddUserOrganization(uo));
                }
            }
            if (!string.IsNullOrEmpty(managementoids))
            {
                string[] managementoidArr = managementoids.Split(new char[] { ',' });
                for (int i = 0; i < managementoidArr.Length; i++)
                {
                    Model.ManagementRelation mr = new Model.ManagementRelation();
                    mr.O_ID = int.Parse(managementoidArr[i]);
                    mr.U_ID = model.U_ID;
                    mr.Flag = 0;
                    mr.AddTime = DateTime.Now;
                    mr.EndTime = DateTime.Now;
                    list.Add(getAddManagementRelation(mr));
                }
            }
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一个用户（事务处理，包括删除该用户的角色，组织机构，分管班级关系信息）
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public bool DelByTran(int U_ID)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getDelUser(U_ID));
            list.Add(getDelUserRole(U_ID));
            list.Add(getDelUserOrganization(U_ID));
            list.Add(getDelManagementRelation(U_ID));
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除多个用户（事务处理，包括删除该用户的角色，组织机构，分管班级关系信息）
        /// </summary>
        /// <param name="U_ID"></param>
        /// <returns></returns>
        public bool DelListByTran(string U_IDlist)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(getDelUserList(U_IDlist));
            list.Add(getDelUserRoleList(U_IDlist));
            list.Add(getDelUserOrganizationList(U_IDlist));
            list.Add(getDelManagementRelationList(U_IDlist));
            try
            {
                return DbHelperSQL.ExecuteSqlTran(list) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CommandInfo getDelUser(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where U_ID=@U_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserOrganization(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserOrganization ");
            strSql.Append(" where U_ID=@U_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserRole(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserRole ");
            strSql.Append(" where U_ID=@U_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelManagementRelation(int U_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ManagementRelation ");
            strSql.Append(" where U_ID=@U_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)			};
            parameters[0].Value = U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserList(string U_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where U_ID in (" + U_IDlist + ")  ");
            SqlParameter[] parameters = {};

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserOrganizationList(string U_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserOrganization ");
            strSql.Append(" where U_ID in (" + U_IDlist + ")  ");
            SqlParameter[] parameters = {};

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelUserRoleList(string U_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserRole ");
            strSql.Append(" where U_ID in (" + U_IDlist + ")  ");
            SqlParameter[] parameters = {};

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getDelManagementRelationList(string U_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ManagementRelation ");
            strSql.Append(" where U_ID in (" + U_IDlist + ")  ");
            SqlParameter[] parameters = {};

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.None);
        }

        private CommandInfo getUpdUser(Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserInfo set ");
            strSql.Append("U_Name=@U_Name,");
            strSql.Append("U_TrueName=@U_TrueName,");
            strSql.Append("U_PWD=@U_PWD,");
            strSql.Append("U_Sex=@U_Sex,");
            strSql.Append("U_Phone=@U_Phone,");
            strSql.Append("U_Phone2=@U_Phone2,");
            strSql.Append("U_Email=@U_Email,");
            strSql.Append("U_Email2=@U_Email2,");
            strSql.Append("U_Contont=@U_Contont,");
            strSql.Append("U_Photo=@U_Photo,");
            strSql.Append("U_GoodField=@U_GoodField,");
            strSql.Append("U_Title=@U_Title,");
            strSql.Append("int1=@int1,");
            strSql.Append("int2=@int2,");
            strSql.Append("int3=@int3,");
            strSql.Append("string1=@string1,");
            strSql.Append("string2=@string2,");
            strSql.Append("string3=@string3,");
            strSql.Append("date1=@date1,");
            strSql.Append("date2=@date2,");
            strSql.Append("date3=@date3,");
            strSql.Append("float1=@float1,");
            strSql.Append("float2=@float2,");
            strSql.Append("float3=@float3,");
            strSql.Append("U_Ethnic=@U_Ethnic,");
            strSql.Append("U_Education=@U_Education,");
            strSql.Append("U_InTime=@U_InTime,");
            strSql.Append("U_Source=@U_Source,");
            strSql.Append("U_Unit=@U_Unit");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_Ethnic", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.U_Name;
            parameters[1].Value = model.U_TrueName;
            parameters[2].Value = model.U_PWD;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Phone;
            parameters[5].Value = model.U_Phone2;
            parameters[6].Value = model.U_Email;
            parameters[7].Value = model.U_Email2;
            parameters[8].Value = model.U_Contont;
            parameters[9].Value = model.U_Photo;
            parameters[10].Value = model.U_GoodField;
            parameters[11].Value = model.U_Title;
            parameters[12].Value = model.int1;
            parameters[13].Value = model.int2;
            parameters[14].Value = model.int3;
            parameters[15].Value = model.string1;
            parameters[16].Value = model.string2;
            parameters[17].Value = model.string3;
            parameters[18].Value = model.date1;
            parameters[19].Value = model.date2;
            parameters[20].Value = model.date3;
            parameters[21].Value = model.float1;
            parameters[22].Value = model.float2;
            parameters[23].Value = model.float3;
            parameters[24].Value = model.U_Ethnic;
            parameters[25].Value = model.U_Education;
            parameters[26].Value = model.U_InTime;
            parameters[27].Value = model.U_Source;
            parameters[28].Value = model.U_Unit;
            parameters[29].Value = model.U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.ExcuteEffectRows);
        }

        private CommandInfo getAddUserOrganization(Model.UserOrganization model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserOrganization(");
            strSql.Append("O_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@O_ID,@U_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@U_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.O_ID;
            parameters[1].Value = model.float3;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.WhenHaveContinueToUse);
        }

        private CommandInfo getAddUserRole(Model.UserRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserRole(");
            strSql.Append("R_ID,U_ID,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@R_ID,@U_ID,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            SqlParameter[] parameters = {
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@U_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.R_ID;
            parameters[1].Value = model.float3;
            parameters[2].Value = model.int1;
            parameters[3].Value = model.int2;
            parameters[4].Value = model.int3;
            parameters[5].Value = model.string1;
            parameters[6].Value = model.string2;
            parameters[7].Value = model.string3;
            parameters[8].Value = model.date1;
            parameters[9].Value = model.date2;
            parameters[10].Value = model.date3;
            parameters[11].Value = model.float1;
            parameters[12].Value = model.float2;
            parameters[13].Value = model.U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.WhenHaveContinueToUse);
        }

        private CommandInfo getAddManagementRelation(Model.ManagementRelation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ManagementRelation(");
            strSql.Append("O_ID,U_ID,Flag,AddTime,EndTime,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3)");
            strSql.Append(" values (");
            strSql.Append("@O_ID,@U_ID,@Flag,@AddTime,@EndTime,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3)");
            SqlParameter[] parameters = {
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
                    new SqlParameter("@U_ID", SqlDbType.Int,4),};
            parameters[0].Value = model.O_ID;
            parameters[1].Value = model.Flag;
            parameters[2].Value = model.AddTime;
            parameters[3].Value = model.EndTime;
            parameters[4].Value = model.int1;
            parameters[5].Value = model.int2;
            parameters[6].Value = model.int3;
            parameters[7].Value = model.string1;
            parameters[8].Value = model.string2;
            parameters[9].Value = model.string3;
            parameters[10].Value = model.date1;
            parameters[11].Value = model.date2;
            parameters[12].Value = model.date3;
            parameters[13].Value = model.float1;
            parameters[14].Value = model.float2;
            parameters[15].Value = model.float3;
            parameters[16].Value = model.U_ID;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.WhenHaveContinueToUse);
        }

        private CommandInfo getAdd(Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserInfo(");
            strSql.Append("U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_Photo,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit)");
            strSql.Append(" values (");
            strSql.Append("@U_Name,@U_TrueName,@U_PWD,@U_Sex,@U_Phone,@U_Phone2,@U_Email,@U_Email2,@U_Contont,@U_Photo,@U_GoodField,@U_Title,@int1,@int2,@int3,@string1,@string2,@string3,@date1,@date2,@date3,@float1,@float2,@float3,@U_Ethnic,@U_Education,@U_InTime,@U_Source,@U_Unit)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@int1", SqlDbType.Int,4),
					new SqlParameter("@int2", SqlDbType.Int,4),
					new SqlParameter("@int3", SqlDbType.Int,4),
					new SqlParameter("@string1", SqlDbType.NVarChar,500),
					new SqlParameter("@string2", SqlDbType.NVarChar,500),
					new SqlParameter("@string3", SqlDbType.NVarChar,500),
					new SqlParameter("@date1", SqlDbType.DateTime),
					new SqlParameter("@date2", SqlDbType.DateTime),
					new SqlParameter("@date3", SqlDbType.DateTime),
					new SqlParameter("@float1", SqlDbType.Decimal,9),
					new SqlParameter("@float2", SqlDbType.Decimal,9),
					new SqlParameter("@float3", SqlDbType.Decimal,9),
					new SqlParameter("@U_Ethnic", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.U_Name;
            parameters[1].Value = model.U_TrueName;
            parameters[2].Value = model.U_PWD;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Phone;
            parameters[5].Value = model.U_Phone2;
            parameters[6].Value = model.U_Email;
            parameters[7].Value = model.U_Email2;
            parameters[8].Value = model.U_Contont;
            parameters[9].Value = model.U_Photo;
            parameters[10].Value = model.U_GoodField;
            parameters[11].Value = model.U_Title;
            parameters[12].Value = model.int1;
            parameters[13].Value = model.int2;
            parameters[14].Value = model.int3;
            parameters[15].Value = model.string1;
            parameters[16].Value = model.string2;
            parameters[17].Value = model.string3;
            parameters[18].Value = model.date1;
            parameters[19].Value = model.date2;
            parameters[20].Value = model.date3;
            parameters[21].Value = model.float1;
            parameters[22].Value = model.float2;
            parameters[23].Value = model.float3;
            parameters[24].Value = model.U_Ethnic;
            parameters[25].Value = model.U_Education;
            parameters[26].Value = model.U_InTime;
            parameters[27].Value = model.U_Source;
            parameters[28].Value = model.U_Unit;

            return new CommandInfo(strSql.ToString(), parameters, EffentNextType.WhenHaveContinueAndUse);
        }

        /// <summary>
        /// 根据组织机构的ID集合，获得相应的学生
        /// </summary>
        /// <param name="OIDList"></param>
        /// <returns></returns>
        public DataSet getUserByOrganization(string OIDList)
        {
            StringBuilder strSql = new StringBuilder();
            OIDList = string.IsNullOrEmpty(OIDList) ? "-1" : OIDList;
            strSql.Append("select * from UserInfo where U_ID in (select U_ID from UserRole where R_ID=6)");
            strSql.Append(" and U_ID in (select U_ID from UserOrganization where O_ID in (" + OIDList + "))");
            try
            {
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch 
            {
                return null;
            }
        }

        /// <summary>
        /// 查询指定Role_ID的用户信息
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SelectUserInfoByRoleID(int roleID)
        {
            StringBuilder sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [UserInfo].[U_ID], ")
                .Append("    [U_Name], ")
                .Append("    [U_TrueName], ")
                .Append("    [U_PWD], ")
                .Append("    [U_Sex], ")
                .Append("    [U_Phone], ")
                .Append("    [U_Phone2], ")
                .Append("    [U_Email], ")
                .Append("    [U_Email2], ")
                .Append("    [U_Contont], ")
                .Append("    [U_Photo], ")
                .Append("    [U_GoodField], ")
                .Append("    [U_Title] ")
                .Append("FROM ")
                .Append("    [UserInfo] ")
                .Append("    INNER JOIN [UserRole] ")
                .Append("        ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                .Append("    INNER JOIN [Role] ")
                .Append("        ON [Role].[R_ID] = [UserRole].[R_ID] ")
                .Append("WHERE ")
                .Append("   [Role].[R_ID] = @R_ID ");
            SqlParameter[] parameters = {
                new SqlParameter("R_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = roleID;
            try
            {
                DataSet dataset = DbHelperSQL.Query(sql.ToString(), parameters);
                if (dataset.Tables.Count == 0) 
                {
                    throw new Exception("查询[Role].[R_ID]为" + roleID + "的用户信息失败");
                }
                List<Model.UserInfo> userInfoList = new List<Model.UserInfo>();
                foreach(DataRow row in dataset.Tables[0].Rows)
                {
                    Model.UserInfo userInfo = new Model.UserInfo();
                    userInfo.U_ID = Convert.ToInt32(row["U_ID"]);
                    userInfo.U_Name = Convert.ToString(row["U_Name"]);
                    userInfo.U_TrueName = Convert.ToString(row["U_TrueName"]);
                    userInfo.U_PWD = Convert.ToString(row["U_PWD"]);
                    userInfo.U_Sex = Convert.ToInt32(row["U_Sex"]);
                    userInfo.U_Phone = Convert.ToString(row["U_Phone"]);
                    userInfo.U_Phone2 = Convert.ToString(row["U_Phone2"]);
                    userInfo.U_Email = Convert.ToString(row["U_Email"]);
                    userInfo.U_Email2 = Convert.ToString(row["U_Email2"]);
                    userInfo.U_Contont = Convert.ToString(row["U_Contont"]);
                    userInfo.U_Photo = row["U_Photo"] is System.DBNull ? null : ((byte[])row["U_Photo"]);
                    userInfo.U_GoodField = Convert.ToString(row["U_GoodField"]);
                    userInfo.U_Title = Convert.ToString(row["U_Title"]);
                    userInfoList.Add(userInfo);
                }
                return userInfoList;
            } 
            catch(Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询[Role].[R_ID]为" + roleID + "的用户信息失败", e);
                return null;
            }
        }

        /// <summary>
        /// 查询指定Role_ID的用户信息和组织机构信息，带条件查询
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public List<object[]> SelectUserInfoAndOrganizationByRoleID(int roleID, Dictionary<string, object> conditionDictionary)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [UserInfo].[U_ID], ")
                .Append("    [U_Name], ")
                .Append("    [U_TrueName], ")
                .Append("    [U_PWD], ")
                .Append("    [U_Sex], ")
                .Append("    [U_Phone], ")
                .Append("    [U_Phone2], ")
                .Append("    [U_Email], ")
                .Append("    [U_Email2], ")
                .Append("    [U_Contont], ")
                .Append("    [U_Photo], ")
                .Append("    [U_GoodField], ")
                .Append("    [UserInfo].[date1], ")
                .Append("    [UserInfo].[string1], ")
                .Append("    [U_Title], ")
                .Append("    [U_Ethnic], ")
                .Append("    [U_Education], ")
                .Append("    [U_InTime], ")
                .Append("    [U_Source], ")
                .Append("    [U_Unit], ")
                .Append("    [Organization].[O_ID], ")
                .Append("    [O_Name], ")
                .Append("    [O_Contont], ")
                .Append("    [O_ParentID], ")
                .Append("    [OL_ID] ")
                .Append("FROM ")
                .Append("   ( ")
                .Append("       [UserInfo] ")
                .Append("       INNER JOIN [UserRole] ")
                .Append("           ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                .Append("       INNER JOIN [Role] ")
                .Append("           ON [Role].[R_ID] = [UserRole].[R_ID] ")
                .Append("   ) ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [Organization].[O_ID] = [UserOrganization].[O_ID] ")
                .Append("WHERE ")
                .Append("   [Role].[R_ID] = :R_ID ")
                .ToString();

            if (conditionDictionary.ContainsKey("U_Name")) 
            {
                sql += " AND [U_Name] LIKE :U_Name";
            }
            if (conditionDictionary.ContainsKey("U_TrueName"))
            {
                sql += " AND [U_TrueName] LIKE :U_TrueName ";
            }
            if (conditionDictionary.ContainsKey("O_ID_String"))
            {
                sql += " AND [Organization].[O_ID] IN (" + conditionDictionary["O_ID_String"] + ") ";
            }
            if (conditionDictionary.ContainsKey("U_ID,NotIn"))
            {
                sql += " AND [UserInfo].[U_ID] NOT IN (" + conditionDictionary["U_ID,NotIn"] + ") ";
            }

            sql += " ORDER BY [Organization].[O_ID] ASC, [UserInfo].[U_ID] ASC";

            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                IQuery iQuery = session.CreateSQLQuery(sql).AddEntity(typeof(Model.UserInfo)).AddEntity(typeof(Model.Organization));
                iQuery.SetInt32("R_ID", roleID);
                if (conditionDictionary.ContainsKey("U_Name")) 
                {
                    iQuery.SetString("U_Name", "%" + Convert.ToString(conditionDictionary["U_Name"]) + "%");
                }
                if (conditionDictionary.ContainsKey("U_TrueName")) 
                {
                    iQuery.SetString("U_TrueName", "%" + Convert.ToString(conditionDictionary["U_TrueName"]) + "%");
                }
                return iQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询[Role].[R_ID]为" + roleID + "的用户信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        public List<Model.UserInfo> SelectUserInfoByRoleIDAndExcludeUserInfoIDList(int roleID, List<int> userInfoIDList)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [UserInfo].[U_ID], ")
                    .Append("   [U_Name], ")
                    .Append("   [U_TrueName], ")
                    .Append("   [U_PWD], ")
                    .Append("   [U_Sex], ")
                    .Append("   [U_Phone], ")
                    .Append("   [U_Phone2], ")
                    .Append("   [U_Email], ")
                    .Append("   [U_Email2], ")
                    .Append("   [U_Contont], ")
                    .Append("   [U_Photo], ")
                    .Append("   [U_GoodField], ")
                    .Append("   [UserInfo].[date1], ")
                    .Append("   [UserInfo].[string1], ")
                    .Append("   [U_Title], ")
                    .Append("   [U_Ethnic], ")
                    .Append("   [U_Education], ")
                    .Append("   [U_InTime], ")
                    .Append("   [U_Source], ")
                    .Append("   [U_Unit] ")
                    .Append("FROM ")
                    .Append("    [UserInfo] ")
                    .Append("    INNER JOIN [UserRole] ")
                    .Append("        ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                    .Append("    INNER JOIN [Role] ")
                    .Append("        ON [Role].[R_ID] = [UserRole].[R_ID] ")
                    .Append("WHERE ")
                    .Append("   [Role].[R_ID] = :R_ID ")
                    .ToString();
                if(userInfoIDList != null && userInfoIDList.Count > 0) 
                {
                    string userInfoIDString = "(";
                    foreach(int item in userInfoIDList) 
                    {
                        userInfoIDString += item + ",";
                    }
                    userInfoIDString = userInfoIDString.Remove(userInfoIDString.Length - 1, 1) + ")";
                    sql += " AND [UserInfo].[U_ID] NOT IN " + userInfoIDString;
                }
                    
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.UserInfo))
                    .SetInt32("R_ID", roleID)
                    .List<Model.UserInfo>().
                    ToList<Model.UserInfo>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        public List<object[]> SelectUserInfoAndOrganizationByExamIDAndExamStudentNumber(int E_ID, int Exam_Student_Code)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [UserInfo].[U_ID], ")
                .Append("    [U_Name], ")
                .Append("    [U_TrueName], ")
                .Append("    [U_PWD], ")
                .Append("    [U_Sex], ")
                .Append("    [U_Phone], ")
                .Append("    [U_Phone2], ")
                .Append("    [U_Email], ")
                .Append("    [U_Email2], ")
                .Append("    [U_Contont], ")
                .Append("    [U_Photo], ")
                .Append("    [U_GoodField], ")
                .Append("    [UserInfo].[date1], ")
                .Append("   [UserInfo].[string1], ")
                .Append("    [U_Title], ")
                .Append("    [U_Ethnic], ")
                .Append("    [U_Education], ")
                .Append("    [U_InTime], ")
                .Append("    [U_Source], ")
                .Append("    [U_Unit], ")
                .Append("    [Organization].[O_ID], ")
                .Append("    [O_Name], ")
                .Append("    [O_Contont], ")
                .Append("    [O_ParentID], ")
                .Append("    [OL_ID] ")
                .Append("FROM ")
                .Append("   ( ")
                .Append("       [UserInfo] ")
                .Append("       INNER JOIN [ExamStudent] ")
                .Append("           ON [UserInfo].[U_ID] = [ExamStudent].[U_ID] ")
                .Append("   ) ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [Organization].[O_ID] = [UserOrganization].[O_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStudent].[EStu_ExamNumber] = :EStu_ExamNumber ")
                .Append("   AND [ExamStudent].[E_ID] = :E_ID ")
                .ToString();
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session
                    .CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.UserInfo))
                    .AddEntity(typeof(Model.Organization))
                    .SetInt32("EStu_ExamNumber", Exam_Student_Code)
                    .SetInt32("E_ID", E_ID)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考试学生用户信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        public List<object[]> SelectUserInfoAndOrganizationByExamIDAndExamStudentNumber(int E_ID, string U_Name)
        {
            String sql = new StringBuilder()
                .Append("SELECT ")
                .Append("    [UserInfo].[U_ID], ")
                .Append("    [U_Name], ")
                .Append("    [U_TrueName], ")
                .Append("    [U_PWD], ")
                .Append("    [U_Sex], ")
                .Append("    [U_Phone], ")
                .Append("    [U_Phone2], ")
                .Append("    [U_Email], ")
                .Append("    [U_Email2], ")
                .Append("    [U_Contont], ")
                .Append("    [U_Photo], ")
                .Append("    [U_GoodField], ")
                .Append("    [UserInfo].[date1], ")
                .Append("    [UserInfo].[string1], ")
                .Append("    [U_Title], ")
                .Append("    [U_Ethnic], ")
                .Append("    [U_Education], ")
                .Append("    [U_InTime], ")
                .Append("    [U_Source], ")
                .Append("    [U_Unit], ")
                .Append("    [Organization].[O_ID], ")
                .Append("    [O_Name], ")
                .Append("    [O_Contont], ")
                .Append("    [O_ParentID], ")
                .Append("    [OL_ID] ")
                .Append("FROM ")
                .Append("   ( ")
                .Append("       [UserInfo] ")
                .Append("       INNER JOIN [ExamStudent] ")
                .Append("           ON [UserInfo].[U_ID] = [ExamStudent].[U_ID] ")
                .Append("   ) ")
                .Append("   LEFT JOIN [UserOrganization] ")
                .Append("       ON [UserInfo].[U_ID] = [UserOrganization].[U_ID] ")
                .Append("   LEFT JOIN [Organization] ")
                .Append("       ON [Organization].[O_ID] = [UserOrganization].[O_ID] ")
                .Append("WHERE ")
                .Append("   [UserInfo].[U_Name] = :U_Name ")
                .Append("   AND [ExamStudent].[E_ID] = :E_ID ")
                .ToString();
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session
                    .CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.UserInfo))
                    .AddEntity(typeof(Model.Organization))
                    .SetString("U_Name", U_Name)
                    .SetInt32("E_ID", E_ID)
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询考试学生用户信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 按照条件对象查询用户数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectUserInfoCountByCondition(Dictionary<string, object> conditionDictionary)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   COUNT(DISTINCT [UserInfo].[U_ID]) ")
                    .Append("FROM ")
                    .Append("    [UserInfo] ")
                    .Append("    INNER JOIN [UserRole] ")
                    .Append("        ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                    .Append("    INNER JOIN [Role] ")
                    .Append("        ON [Role].[R_ID] = [UserRole].[R_ID] ")
                    .Append("WHERE ")
                    .Append("   [Role].[R_ID] = :R_ID ")
                    .ToString();
                if (conditionDictionary.ContainsKey("user_info_keyword"))
                {
                    sql += " AND ([UserInfo].[U_TrueName] LIKE :U_TrueName OR [UserInfo].[U_GoodField] LIKE :U_GoodField OR [UserInfo].[U_Contont] LIKE :U_Contont) ";
                }
                if (conditionDictionary.ContainsKey("user_info_judge_keyword"))
                {
                    sql += " AND ([UserInfo].[U_TrueName] LIKE :U_TrueName OR [UserInfo].[U_Title] LIKE :U_Title OR [UserInfo].[U_Contont] LIKE :U_Contont) ";
                }
                if (conditionDictionary.ContainsKey("user_info_unit"))
                {
                    sql += " AND [UserInfo].[U_Unit] LIKE :U_Unit ";
                }
                if (conditionDictionary.ContainsKey("user_info_sex"))
                {
                    sql += " AND [UserInfo].[U_Sex] = :U_Sex ";
                }
                if (conditionDictionary.ContainsKey("user_info_age_min"))
                {
                    sql += " AND [UserInfo].[date1] IS NOT NULL AND [UserInfo].[date1] <= :maxDate ";
                }
                if (conditionDictionary.ContainsKey("user_info_age_max"))
                {
                    sql += " AND [UserInfo].[date1] IS NOT NULL AND [UserInfo].[date1] >= :minDate ";
                }
                if (conditionDictionary.ContainsKey("U_ID,NotIn"))
                {
                    sql += " AND [UserInfo].[U_ID] NOT IN (:userInfoIDList) ";
                }

                session = SessionManager.OpenSession();
                IQuery iQuery = session.CreateSQLQuery(sql).SetInt32("R_ID", Convert.ToInt32(conditionDictionary["RoleID"]));
                if (conditionDictionary.ContainsKey("user_info_keyword"))
                {
                    string keyword = "%" + conditionDictionary["user_info_keyword"] + "%";
                    iQuery.SetString("U_TrueName", keyword).SetString("U_GoodField", keyword).SetString("U_Contont", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_judge_keyword"))
                {
                    string keyword = "%" + conditionDictionary["user_info_judge_keyword"] + "%";
                    iQuery.SetString("U_TrueName", keyword).SetString("U_Title", keyword).SetString("U_Contont", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_unit"))
                {
                    string keyword = "%" + conditionDictionary["user_info_unit"] + "%";
                    iQuery.SetString("U_Unit", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_sex"))
                {
                    iQuery.SetInt32("U_Sex", Convert.ToInt32(conditionDictionary["user_info_sex"]));
                }
                if (conditionDictionary.ContainsKey("user_info_age_min"))
                {
                    iQuery.SetDateTime("maxDate", DateTime.Now.AddYears(-Convert.ToInt32(conditionDictionary["user_info_age_min"])));
                }
                if (conditionDictionary.ContainsKey("user_info_age_max"))
                {
                    iQuery.SetDateTime("minDate", DateTime.Now.AddYears(-Convert.ToInt32(conditionDictionary["user_info_age_max"])));
                }
                if (conditionDictionary.ContainsKey("U_ID,NotIn"))
                {
                    iQuery.SetParameterList("userInfoIDList", (List<int>)conditionDictionary["U_ID,NotIn"]);
                }
                return iQuery.UniqueResult<int>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 按照条件对象查询用户分页信息
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.UserInfo> SelectUserInfoInPageByCondition(Dictionary<string, object> conditionDictionary, int pageIndex, int pageSize)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("    [UserInfo].[U_ID], ")
                    .Append("    [U_Name], ")
                    .Append("    [U_TrueName], ")
                    .Append("    [U_PWD], ")
                    .Append("    [U_Sex], ")
                    .Append("    [U_Phone], ")
                    .Append("    [U_Phone2], ")
                    .Append("    [U_Email], ")
                    .Append("    [U_Email2], ")
                    .Append("    [U_Contont], ")
                    .Append("    [U_Photo], ")
                    .Append("    [U_GoodField], ")
                    .Append("    [UserInfo].[date1], ")
                    .Append("    [UserInfo].[string1], ")
                    .Append("    [U_Title], ")
                    .Append("    [U_Ethnic], ")
                    .Append("    [U_Education], ")
                    .Append("    [U_InTime], ")
                    .Append("    [U_Source], ")
                    .Append("    [U_Unit] ")
                    .Append("FROM ")
                    .Append("    [UserInfo] ")
                    .Append("    INNER JOIN [UserRole] ")
                    .Append("        ON [UserInfo].[U_ID] = [UserRole].[U_ID] ")
                    .Append("    INNER JOIN [Role] ")
                    .Append("        ON [Role].[R_ID] = [UserRole].[R_ID] ")
                    .Append("WHERE ")
                    .Append("   [Role].[R_ID] = :R_ID ")
                    .ToString();
                if (conditionDictionary.ContainsKey("user_info_keyword"))
                {
                    sql += " AND ([UserInfo].[U_TrueName] LIKE :U_TrueName OR [UserInfo].[U_GoodField] LIKE :U_GoodField OR [UserInfo].[U_Contont] LIKE :U_Contont) ";
                }
                if (conditionDictionary.ContainsKey("user_info_judge_keyword"))
                {
                    sql += " AND ([UserInfo].[U_TrueName] LIKE :U_TrueName OR [UserInfo].[U_Title] LIKE :U_Title OR [UserInfo].[U_Contont] LIKE :U_Contont) ";
                }
                if (conditionDictionary.ContainsKey("user_info_unit"))
                {
                    sql += " AND [UserInfo].[U_Unit] LIKE :U_Unit ";
                }
                if (conditionDictionary.ContainsKey("user_info_sex"))
                {
                    sql += " AND [UserInfo].[U_Sex] = :U_Sex ";
                }
                if (conditionDictionary.ContainsKey("user_info_age_min"))
                {
                    sql += " AND [UserInfo].[date1] IS NOT NULL AND [UserInfo].[date1] <= :maxDate ";
                }
                if (conditionDictionary.ContainsKey("user_info_age_max"))
                {
                    sql += " AND [UserInfo].[date1] IS NOT NULL AND [UserInfo].[date1] >= :minDate ";
                }
                if (conditionDictionary.ContainsKey("U_ID,NotIn"))
                {
                    sql += " AND [UserInfo].[U_ID] NOT IN (:userInfoIDList) ";
                }

                session = SessionManager.OpenSession();
                IQuery iQuery = session
                    .CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.UserInfo))
                    .SetInt32("R_ID", Convert.ToInt32(conditionDictionary["RoleID"]));
                if (conditionDictionary.ContainsKey("user_info_keyword"))
                {
                    string keyword = "%" + conditionDictionary["user_info_keyword"] + "%";
                    iQuery.SetString("U_TrueName", keyword).SetString("U_GoodField", keyword).SetString("U_Contont", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_judge_keyword"))
                {
                    string keyword = "%" + conditionDictionary["user_info_judge_keyword"] + "%";
                    iQuery.SetString("U_TrueName", keyword).SetString("U_Title", keyword).SetString("U_Contont", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_unit"))
                {
                    string keyword = "%" + conditionDictionary["user_info_unit"] + "%";
                    iQuery.SetString("U_Unit", keyword);
                }
                if (conditionDictionary.ContainsKey("user_info_sex"))
                {
                    iQuery.SetInt32("U_Sex", Convert.ToInt32(conditionDictionary["user_info_sex"]));
                }
                if (conditionDictionary.ContainsKey("user_info_age_min"))
                {
                    iQuery.SetDateTime("maxDate", DateTime.Now.AddYears(-Convert.ToInt32(conditionDictionary["user_info_age_min"])));
                }
                if (conditionDictionary.ContainsKey("user_info_age_max"))
                {
                    iQuery.SetDateTime("minDate", DateTime.Now.AddYears(-Convert.ToInt32(conditionDictionary["user_info_age_max"])));
                }
                if (conditionDictionary.ContainsKey("U_ID,NotIn"))
                {
                    iQuery.SetParameterList("userInfoIDList", (List<int>)conditionDictionary["U_ID,NotIn"]);
                }
                return iQuery
                    .SetFirstResult((pageIndex - 1) * pageSize)
                    .SetMaxResults(pageSize)
                    .List<Model.UserInfo>()
                    .ToList<Model.UserInfo>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询UserInfo信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 实现基类抽象方法
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("U_Name"))
            {
                criteria.Add(Restrictions.Eq("U_Name", conditionDictionary["U_Name"]));
            }
            if (conditionDictionary.ContainsKey("U_PWD"))
            {
                criteria.Add(Restrictions.Eq("U_PWD", conditionDictionary["U_PWD"]));
            }
            if (conditionDictionary.ContainsKey("U_Name,EQ"))
            {
                criteria.Add(Restrictions.Eq("U_Name", conditionDictionary["U_Name,EQ"]));
            }
            if (conditionDictionary.ContainsKey("U_PWD,EQ"))
            {
                criteria.Add(Restrictions.Eq("U_PWD", conditionDictionary["U_PWD,EQ"]));
            }
            return criteria;
        }
		#endregion  ExtensionMethod

        #region 这是添加用户的基本信息
        /// <summary>
        /// 添加用户的基本信息
        /// </summary>
        /// <returns></returns>
        public int addUserBasicInfos(Tellyes.Model.UserInfo  user, string organizationIDS,List<string> roleList,List<string>classList)
        {
            string[] orgIDS =new string[3];
            if(!string.IsNullOrEmpty(organizationIDS))
            {
                orgIDS = organizationIDS.Split(',');
            }
            StringBuilder strSql = new StringBuilder();
            List<string> sqlList =new List<string>();
            if(user!=null && roleList!=null){
                strSql.Append("   begin tran ; ");
                strSql.Append("insert into [dbo].[UserInfo] ( ");
                strSql.Append("U_Name,U_TrueName,U_PWD,U_Sex,U_Phone,U_Phone2,U_Email,U_Email2,U_Contont,U_GoodField,U_Title,int1,int2,int3,string1,string2,string3,date1,date2,date3,float1,float2,float3,U_Ethnic,U_Education,U_InTime,U_Source,U_Unit,U_OriginalUrl,U_ThumbnailUrl)");
                strSql.Append(" values ");
                strSql.Append("('"+user.U_Name+"',");
                strSql.Append(" '"+user.U_TrueName+"','"+user.U_PWD+"',"+user.U_Sex+",'"+user.U_Phone+"','"+user.U_Phone2+"','"+user.U_Email+"','"+user.U_Email2+"','"+user.U_Contont+"','"+user.U_GoodField+"','"+user.U_Title+"',"+user.int1+", ");
                if (string.IsNullOrEmpty(user.int2.ToString()))
                {
                    user.int2 = 0;
                    strSql.Append("" + user.int2 + ", ");
                }
                else 
                {
                    strSql.Append("" + user.int2 + ", ");
                }
                if (string.IsNullOrEmpty(user.int3.ToString()))
                {
                    user.int3 = 0;
                    strSql.Append("" + user.int3 + ", ");
                }
                else 
                {
                    strSql.Append("" + user.int3 + ", ");
                }
                strSql.Append("'"+user.string1+"','"+user.string2+"','"+user.string3+"','"+user.date1+"','"+user.date2+"','"+user.date3+"',");

                if (string.IsNullOrEmpty(user.float1.ToString()))
                {
                    user.float1 = 0;
                    strSql.Append("  '" + user.float1 + "', ");
                }
                else 
                {
                    strSql.Append("  '" + user.float1 + "', ");
                }
                if (string.IsNullOrEmpty(user.float2.ToString()))
                {
                    user.float2 = 0;
                    strSql.Append("   '" + user.float2 + "', ");
                }
                else 
                {
                    strSql.Append("   '" + user.float2 + "', ");
                }
                if (string.IsNullOrEmpty(user.float3.ToString()))
                {
                    user.float3 = 0;
                    strSql.Append("  '" + user.float3 + "', ");
                }
                else 
                {
                    strSql.Append("  '" + user.float3 + "', ");
                }
        
                
                
                
                
                strSql.Append(" '"+user.U_Ethnic+"','"+user.U_Education+"','"+user.U_InTime+"','"+user.U_Source+"','"+user.U_Unit+"','"+user.U_OriginalUrl+"','"+user.U_ThumbnailUrl+"' );");
              
                
                strSql.Append("  declare @newID int; ");
                strSql.Append("  set @newID =(select @@IDENTITY); ");
                foreach(string item in roleList){
                strSql.Append(" insert into UserRole (R_ID,U_ID) values ("+item+",@newID); ");
                }
                if(!string.IsNullOrEmpty(orgIDS[0])){
                strSql.Append(" insert into UserOrganization(O_ID,U_ID ) values(" + orgIDS[2]+ " ,@newID);");
                }
                if (classList != null)
                {
                    foreach (string item in classList)
                    {
                        strSql.Append("insert into ManagementRelation (O_ID,U_ID,flag ) values(" + item + " ,@newID,'0');");
                    }
                }




                strSql.Append("    commit tran; ");
                sqlList.Add(strSql.ToString());
                strSql.Clear();
            }

            return DbHelperSQL.ExecuteSqlTran(sqlList);
        }



        #endregion

        #region 获取到用户的信息
        /// <summary>
        /// 获取到用户的信息
        /// </summary>
        public void getAllBasicUserInfos(string name, string ridList, string OID, string CurrentPage, string pagesize) 
        {

          
        }
        #endregion


    }
}

