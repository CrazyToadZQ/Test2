using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    public class AllUserInfoView
    {
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID, string U_Source, string U_Unit, string U_TrueName, int R_ID, string R_Name, int O_ID, string O_Name, int O_ParentID, string OL_Name, int OL_ID, string U_Name, string U_PWD, string U_Phone2, string U_Email2, byte[] U_Photo, string U_Title, string U_Education, int U_Sex, string U_Email, string U_Phone, string U_Contont, string U_GoodField, DateTime U_InTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AllUserInfo");
            strSql.Append(" where U_ID=@U_ID and U_Source=@U_Source and U_Unit=@U_Unit and U_TrueName=@U_TrueName and R_ID=@R_ID and R_Name=@R_Name and O_ID=@O_ID and O_Name=@O_Name and O_ParentID=@O_ParentID and OL_Name=@OL_Name and OL_ID=@OL_ID and U_Name=@U_Name and U_PWD=@U_PWD and U_Phone2=@U_Phone2 and U_Email2=@U_Email2 and U_Photo=@U_Photo and U_Title=@U_Title and U_Education=@U_Education and U_Sex=@U_Sex and U_Email=@U_Email and U_Phone=@U_Phone and U_Contont=@U_Contont and U_GoodField=@U_GoodField and U_InTime=@U_InTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime)			};
            parameters[0].Value = U_ID;
            parameters[1].Value = U_Source;
            parameters[2].Value = U_Unit;
            parameters[3].Value = U_TrueName;
            parameters[4].Value = R_ID;
            parameters[5].Value = R_Name;
            parameters[6].Value = O_ID;
            parameters[7].Value = O_Name;
            parameters[8].Value = O_ParentID;
            parameters[9].Value = OL_Name;
            parameters[10].Value = OL_ID;
            parameters[11].Value = U_Name;
            parameters[12].Value = U_PWD;
            parameters[13].Value = U_Phone2;
            parameters[14].Value = U_Email2;
            parameters[15].Value = U_Photo;
            parameters[16].Value = U_Title;
            parameters[17].Value = U_Education;
            parameters[18].Value = U_Sex;
            parameters[19].Value = U_Email;
            parameters[20].Value = U_Phone;
            parameters[21].Value = U_Contont;
            parameters[22].Value = U_GoodField;
            parameters[23].Value = U_InTime;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.AllUserInfoView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AllUserInfo(");
            strSql.Append("U_ID,U_Name,U_Education,U_Sex,U_Email,U_Phone,U_Contont,U_GoodField,U_InTime,U_Source,U_Unit,U_TrueName,R_ID,R_Name,O_ID,O_Name,O_ParentID,OL_Name,OL_ID,U_PWD,U_Phone2,U_Email2,U_Photo,U_Title)");
            strSql.Append(" values (");
            strSql.Append("@U_ID,@U_Name,@U_Education,@U_Sex,@U_Email,@U_Phone,@U_Contont,@U_GoodField,@U_InTime,@U_Source,@U_Unit,@U_TrueName,@R_ID,@R_Name,@O_ID,@O_Name,@O_ParentID,@OL_Name,@OL_ID,@U_PWD,@U_Phone2,@U_Email2,@U_Photo,@U_Title)");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.U_Name;
            parameters[2].Value = model.U_Education;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Email;
            parameters[5].Value = model.U_Phone;
            parameters[6].Value = model.U_Contont;
            parameters[7].Value = model.U_GoodField;
            parameters[8].Value = model.U_InTime;
            parameters[9].Value = model.U_Source;
            parameters[10].Value = model.U_Unit;
            parameters[11].Value = model.U_TrueName;
            parameters[12].Value = model.R_ID;
            parameters[13].Value = model.R_Name;
            parameters[14].Value = model.O_ID;
            parameters[15].Value = model.O_Name;
            parameters[16].Value = model.O_ParentID;
            parameters[17].Value = model.OL_Name;
            parameters[18].Value = model.OL_ID;
            parameters[19].Value = model.U_PWD;
            parameters[20].Value = model.U_Phone2;
            parameters[21].Value = model.U_Email2;
            parameters[22].Value = model.U_Photo;
            parameters[23].Value = model.U_Title;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.AllUserInfoView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AllUserInfo set ");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("U_Name=@U_Name,");
            strSql.Append("U_Education=@U_Education,");
            strSql.Append("U_Sex=@U_Sex,");
            strSql.Append("U_Email=@U_Email,");
            strSql.Append("U_Phone=@U_Phone,");
            strSql.Append("U_Contont=@U_Contont,");
            strSql.Append("U_GoodField=@U_GoodField,");
            strSql.Append("U_InTime=@U_InTime,");
            strSql.Append("U_Source=@U_Source,");
            strSql.Append("U_Unit=@U_Unit,");
            strSql.Append("U_TrueName=@U_TrueName,");
            strSql.Append("R_ID=@R_ID,");
            strSql.Append("R_Name=@R_Name,");
            strSql.Append("O_ID=@O_ID,");
            strSql.Append("O_Name=@O_Name,");
            strSql.Append("O_ParentID=@O_ParentID,");
            strSql.Append("OL_Name=@OL_Name,");
            strSql.Append("OL_ID=@OL_ID,");
            strSql.Append("U_PWD=@U_PWD,");
            strSql.Append("U_Phone2=@U_Phone2,");
            strSql.Append("U_Email2=@U_Email2,");
            strSql.Append("U_Photo=@U_Photo,");
            strSql.Append("U_Title=@U_Title");
            strSql.Append(" where U_ID=@U_ID and U_Source=@U_Source and U_Unit=@U_Unit and U_TrueName=@U_TrueName and R_ID=@R_ID and R_Name=@R_Name and O_ID=@O_ID and O_Name=@O_Name and O_ParentID=@O_ParentID and OL_Name=@OL_Name and OL_ID=@OL_ID and U_Name=@U_Name and U_PWD=@U_PWD and U_Phone2=@U_Phone2 and U_Email2=@U_Email2 and U_Photo=@U_Photo and U_Title=@U_Title and U_Education=@U_Education and U_Sex=@U_Sex and U_Email=@U_Email and U_Phone=@U_Phone and U_Contont=@U_Contont and U_GoodField=@U_GoodField and U_InTime=@U_InTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.U_Name;
            parameters[2].Value = model.U_Education;
            parameters[3].Value = model.U_Sex;
            parameters[4].Value = model.U_Email;
            parameters[5].Value = model.U_Phone;
            parameters[6].Value = model.U_Contont;
            parameters[7].Value = model.U_GoodField;
            parameters[8].Value = model.U_InTime;
            parameters[9].Value = model.U_Source;
            parameters[10].Value = model.U_Unit;
            parameters[11].Value = model.U_TrueName;
            parameters[12].Value = model.R_ID;
            parameters[13].Value = model.R_Name;
            parameters[14].Value = model.O_ID;
            parameters[15].Value = model.O_Name;
            parameters[16].Value = model.O_ParentID;
            parameters[17].Value = model.OL_Name;
            parameters[18].Value = model.OL_ID;
            parameters[19].Value = model.U_PWD;
            parameters[20].Value = model.U_Phone2;
            parameters[21].Value = model.U_Email2;
            parameters[22].Value = model.U_Photo;
            parameters[23].Value = model.U_Title;

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
        public bool Delete(int U_ID, string U_Source, string U_Unit, string U_TrueName, int R_ID, string R_Name, int O_ID, string O_Name, int O_ParentID, string OL_Name, int OL_ID, string U_Name, string U_PWD, string U_Phone2, string U_Email2, byte[] U_Photo, string U_Title, string U_Education, int U_Sex, string U_Email, string U_Phone, string U_Contont, string U_GoodField, DateTime U_InTime)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AllUserInfo ");
            strSql.Append(" where U_ID=@U_ID and U_Source=@U_Source and U_Unit=@U_Unit and U_TrueName=@U_TrueName and R_ID=@R_ID and R_Name=@R_Name and O_ID=@O_ID and O_Name=@O_Name and O_ParentID=@O_ParentID and OL_Name=@OL_Name and OL_ID=@OL_ID and U_Name=@U_Name and U_PWD=@U_PWD and U_Phone2=@U_Phone2 and U_Email2=@U_Email2 and U_Photo=@U_Photo and U_Title=@U_Title and U_Education=@U_Education and U_Sex=@U_Sex and U_Email=@U_Email and U_Phone=@U_Phone and U_Contont=@U_Contont and U_GoodField=@U_GoodField and U_InTime=@U_InTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@U_TrueName", SqlDbType.VarChar,20),
					new SqlParameter("@R_ID", SqlDbType.Int,4),
					new SqlParameter("@R_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ID", SqlDbType.Int,4),
					new SqlParameter("@O_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@O_ParentID", SqlDbType.Int,4),
					new SqlParameter("@OL_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@OL_ID", SqlDbType.Int,4),
					new SqlParameter("@U_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@U_PWD", SqlDbType.VarChar,20),
					new SqlParameter("@U_Phone2", SqlDbType.VarChar,20),
					new SqlParameter("@U_Email2", SqlDbType.VarChar,50),
					new SqlParameter("@U_Photo", SqlDbType.Image),
					new SqlParameter("@U_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Education", SqlDbType.NVarChar,50),
					new SqlParameter("@U_Sex", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,50),
					new SqlParameter("@U_Phone", SqlDbType.VarChar,20),
					new SqlParameter("@U_Contont", SqlDbType.VarChar,200),
					new SqlParameter("@U_GoodField", SqlDbType.VarChar,50),
					new SqlParameter("@U_InTime", SqlDbType.DateTime)			};
            parameters[0].Value = U_ID;
            parameters[1].Value = U_Source;
            parameters[2].Value = U_Unit;
            parameters[3].Value = U_TrueName;
            parameters[4].Value = R_ID;
            parameters[5].Value = R_Name;
            parameters[6].Value = O_ID;
            parameters[7].Value = O_Name;
            parameters[8].Value = O_ParentID;
            parameters[9].Value = OL_Name;
            parameters[10].Value = OL_ID;
            parameters[11].Value = U_Name;
            parameters[12].Value = U_PWD;
            parameters[13].Value = U_Phone2;
            parameters[14].Value = U_Email2;
            parameters[15].Value = U_Photo;
            parameters[16].Value = U_Title;
            parameters[17].Value = U_Education;
            parameters[18].Value = U_Sex;
            parameters[19].Value = U_Email;
            parameters[20].Value = U_Phone;
            parameters[21].Value = U_Contont;
            parameters[22].Value = U_GoodField;
            parameters[23].Value = U_InTime;

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
        /// 得到一个对象实体
        /// </summary>
        public Tellyes.Model.AllUserInfoView GetModel(int U_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 U_ID,U_Name,U_Education,U_Sex,U_Email,U_Phone,U_Contont,U_GoodField,U_InTime,U_Source,U_Unit,U_TrueName,R_ID,R_Name,O_ID,O_Name,O_ParentID,OL_Name,OL_ID,U_PWD,U_Phone2,U_Email2,U_Photo,U_Title from AllUserInfo ");
            strSql.Append(" where U_ID=@U_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4)
						};
            parameters[0].Value = U_ID;
            Tellyes.Model.AllUserInfoView model = new Tellyes.Model.AllUserInfoView();
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
        public Tellyes.Model.AllUserInfoView DataRowToModel(DataRow row)
        {
            Tellyes.Model.AllUserInfoView model = new Tellyes.Model.AllUserInfoView();
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
                if (row["U_Education"] != null)
                {
                    model.U_Education = row["U_Education"].ToString();
                }
                if (row["U_Sex"] != null && row["U_Sex"].ToString() != "")
                {
                    model.U_Sex = int.Parse(row["U_Sex"].ToString());
                }
                if (row["U_Email"] != null)
                {
                    model.U_Email = row["U_Email"].ToString();
                }
                if (row["U_Phone"] != null)
                {
                    model.U_Phone = row["U_Phone"].ToString();
                }
                if (row["U_Contont"] != null)
                {
                    model.U_Contont = row["U_Contont"].ToString();
                }
                if (row["U_GoodField"] != null)
                {
                    model.U_GoodField = row["U_GoodField"].ToString();
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
                if (row["U_TrueName"] != null)
                {
                    model.U_TrueName = row["U_TrueName"].ToString();
                }
                if (row["R_ID"] != null && row["R_ID"].ToString() != "")
                {
                    model.R_ID = int.Parse(row["R_ID"].ToString());
                }
                if (row["R_Name"] != null)
                {
                    model.R_Name = row["R_Name"].ToString();
                }
                if (row["O_ID"] != null && row["O_ID"].ToString() != "")
                {
                    model.O_ID = int.Parse(row["O_ID"].ToString());
                }
                if (row["O_Name"] != null)
                {
                    model.O_Name = row["O_Name"].ToString();
                }
                if (row["O_ParentID"] != null && row["O_ParentID"].ToString() != "")
                {
                    model.O_ParentID = int.Parse(row["O_ParentID"].ToString());
                }
                if (row["OL_Name"] != null)
                {
                    model.OL_Name = row["OL_Name"].ToString();
                }
                if (row["OL_ID"] != null && row["OL_ID"].ToString() != "")
                {
                    model.OL_ID = int.Parse(row["OL_ID"].ToString());
                }
                if (row["U_PWD"] != null)
                {
                    model.U_PWD = row["U_PWD"].ToString();
                }
                if (row["U_Phone2"] != null)
                {
                    model.U_Phone2 = row["U_Phone2"].ToString();
                }
                if (row["U_Email2"] != null)
                {
                    model.U_Email2 = row["U_Email2"].ToString();
                }
                if (row["U_Photo"] != null && row["U_Photo"].ToString() != "")
                {
                    model.U_Photo = (byte[])row["U_Photo"];
                }
                if (row["U_Title"] != null)
                {
                    model.U_Title = row["U_Title"].ToString();
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
            strSql.Append("select U_ID,U_Name,U_Education,U_Sex,U_Email,U_Phone,U_Contont,U_GoodField,U_InTime,U_Source,U_Unit,U_TrueName,R_ID,R_Name,O_ID,O_Name,O_ParentID,OL_Name,OL_ID,U_PWD,U_Phone2,U_Email2,U_Photo,U_Title ");
            strSql.Append(" FROM AllUserInfo ");
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
            strSql.Append(" U_ID,U_Name,U_Education,U_Sex,U_Email,U_Phone,U_Contont,U_GoodField,U_InTime,U_Source,U_Unit,U_TrueName,R_ID,R_Name,O_ID,O_Name,O_ParentID,OL_Name,OL_ID,U_PWD,U_Phone2,U_Email2,U_Photo,U_Title ");
            strSql.Append(" FROM AllUserInfo ");
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
            strSql.Append("select count(1) FROM AllUserInfo ");
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
                strSql.Append("order by T.U_InTime desc");
            }
            strSql.Append(")AS Row, T.*  from AllUserInfo T ");
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
            parameters[0].Value = "AllUserInfo";
            parameters[1].Value = "U_InTime";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
