using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using Tellyes.Log4Net;
using System.Linq;


namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:Device
    /// </summary>
    public partial class Device : BaseDAL<Model.Device>
    {
        public Device()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int D_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Device");
            strSql.Append(" where D_ID=@D_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@D_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = D_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.Device model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Device(");
            strSql.Append("D_SerialNumber,D_Name,DC_ID,DC_ID1,DT_ID,D_Model,D_Manufacturer,D_ManufacturerNumber,D_ManufactureDate,D_Batch,D_WarrantyInfo,D_Remark,D_RegisterDate,D_Position,D_IsCanUse,D_State,D_StateDescription,D_CurrUseCount,D_ExamUseCount,D_TotalUseCount,D_CurrUseTime,D_ExamUseTime,D_TotalUseTime,D_AbnormalCount,D_RepairedCount,D_Skill,D_ScoreItems,D_int1,D_int2,D_int3,D_int4,D_int5,D_string1,D_string2,D_string3,D_string4,D_string5,D_string6,D_string7,D_string8,D_string9,D_string10,D_datetime1,D_datetime2,D_datetime3,D_datetime4,D_datetime5,D_QRCode)");
            strSql.Append(" values (");
            strSql.Append("@D_SerialNumber,@D_Name,@DC_ID,@DC_ID1,@DT_ID,@D_Model,@D_Manufacturer,@D_ManufacturerNumber,@D_ManufactureDate,@D_Batch,@D_WarrantyInfo,@D_Remark,@D_RegisterDate,@D_Position,@D_IsCanUse,@D_State,@D_StateDescription,@D_CurrUseCount,@D_ExamUseCount,@D_TotalUseCount,@D_CurrUseTime,@D_ExamUseTime,@D_TotalUseTime,@D_AbnormalCount,@D_RepairedCount,@D_Skill,@D_ScoreItems,@D_int1,@D_int2,@D_int3,@D_int4,@D_int5,@D_string1,@D_string2,@D_string3,@D_string4,@D_string5,@D_string6,@D_string7,@D_string8,@D_string9,@D_string10,@D_datetime1,@D_datetime2,@D_datetime3,@D_datetime4,@D_datetime5,@D_QRCode)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@D_SerialNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@DC_ID1", SqlDbType.Int,4),
					new SqlParameter("@DT_ID", SqlDbType.Int,4),
					new SqlParameter("@D_Model", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Manufacturer", SqlDbType.NVarChar,50),
					new SqlParameter("@D_ManufacturerNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_ManufactureDate", SqlDbType.DateTime),
					new SqlParameter("@D_Batch", SqlDbType.NVarChar,50),
					new SqlParameter("@D_WarrantyInfo", SqlDbType.NVarChar,1000),
					new SqlParameter("@D_Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@D_Position", SqlDbType.NVarChar,200),
					new SqlParameter("@D_IsCanUse", SqlDbType.Int,4),
					new SqlParameter("@D_State", SqlDbType.NVarChar,20),
					new SqlParameter("@D_StateDescription", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_CurrUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_CurrUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_AbnormalCount", SqlDbType.Int,4),
					new SqlParameter("@D_RepairedCount", SqlDbType.Int,4),
					new SqlParameter("@D_Skill", SqlDbType.NVarChar,100),
					new SqlParameter("@D_ScoreItems", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_int1", SqlDbType.Int,4),
					new SqlParameter("@D_int2", SqlDbType.Int,4),
					new SqlParameter("@D_int3", SqlDbType.Int,4),
					new SqlParameter("@D_int4", SqlDbType.Int,4),
					new SqlParameter("@D_int5", SqlDbType.Int,4),
					new SqlParameter("@D_string1", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string2", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string3", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string4", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string5", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string6", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string7", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string8", SqlDbType.NVarChar,200),
					new SqlParameter("@D_string9", SqlDbType.NVarChar,500),
					new SqlParameter("@D_string10", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_datetime1", SqlDbType.DateTime),
					new SqlParameter("@D_datetime2", SqlDbType.DateTime),
					new SqlParameter("@D_datetime3", SqlDbType.DateTime),
					new SqlParameter("@D_datetime4", SqlDbType.DateTime),
					new SqlParameter("@D_datetime5", SqlDbType.DateTime),
					new SqlParameter("@D_QRCode", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.D_SerialNumber;
            parameters[1].Value = model.D_Name;
            parameters[2].Value = model.DC_ID;
            parameters[3].Value = model.DC_ID1;
            parameters[4].Value = model.DT_ID;
            parameters[5].Value = model.D_Model;
            parameters[6].Value = model.D_Manufacturer;
            parameters[7].Value = model.D_ManufacturerNumber;
            parameters[8].Value = model.D_ManufactureDate;
            parameters[9].Value = model.D_Batch;
            parameters[10].Value = model.D_WarrantyInfo;
            parameters[11].Value = model.D_Remark;
            parameters[12].Value = model.D_RegisterDate;
            parameters[13].Value = model.D_Position;
            parameters[14].Value = model.D_IsCanUse;
            parameters[15].Value = model.D_State;
            parameters[16].Value = model.D_StateDescription;
            parameters[17].Value = model.D_CurrUseCount;
            parameters[18].Value = model.D_ExamUseCount;
            parameters[19].Value = model.D_TotalUseCount;
            parameters[20].Value = model.D_CurrUseTime;
            parameters[21].Value = model.D_ExamUseTime;
            parameters[22].Value = model.D_TotalUseTime;
            parameters[23].Value = model.D_AbnormalCount;
            parameters[24].Value = model.D_RepairedCount;
            parameters[25].Value = model.D_Skill;
            parameters[26].Value = model.D_ScoreItems;
            parameters[27].Value = model.D_int1;
            parameters[28].Value = model.D_int2;
            parameters[29].Value = model.D_int3;
            parameters[30].Value = model.D_int4;
            parameters[31].Value = model.D_int5;
            parameters[32].Value = model.D_string1;
            parameters[33].Value = model.D_string2;
            parameters[34].Value = model.D_string3;
            parameters[35].Value = model.D_string4;
            parameters[36].Value = model.D_string5;
            parameters[37].Value = model.D_string6;
            parameters[38].Value = model.D_string7;
            parameters[39].Value = model.D_string8;
            parameters[40].Value = model.D_string9;
            parameters[41].Value = model.D_string10;
            parameters[42].Value = model.D_datetime1;
            parameters[43].Value = model.D_datetime2;
            parameters[44].Value = model.D_datetime3;
            parameters[45].Value = model.D_datetime4;
            parameters[46].Value = model.D_datetime5;
            parameters[47].Value = model.D_QRCode;

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
        public bool Update(Tellyes.Model.Device model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Device set ");
            strSql.Append("D_SerialNumber=@D_SerialNumber,");
            strSql.Append("D_Name=@D_Name,");
            strSql.Append("DC_ID=@DC_ID,");
            strSql.Append("DC_ID1=@DC_ID1,");
            strSql.Append("DT_ID=@DT_ID,");
            strSql.Append("D_Model=@D_Model,");
            strSql.Append("D_Manufacturer=@D_Manufacturer,");
            strSql.Append("D_ManufacturerNumber=@D_ManufacturerNumber,");
            strSql.Append("D_ManufactureDate=@D_ManufactureDate,");
            strSql.Append("D_Batch=@D_Batch,");
            strSql.Append("D_WarrantyInfo=@D_WarrantyInfo,");
            strSql.Append("D_Remark=@D_Remark,");
            strSql.Append("D_RegisterDate=@D_RegisterDate,");
            strSql.Append("D_Position=@D_Position,");
            strSql.Append("D_IsCanUse=@D_IsCanUse,");
            strSql.Append("D_State=@D_State,");
            strSql.Append("D_StateDescription=@D_StateDescription,");
            strSql.Append("D_CurrUseCount=@D_CurrUseCount,");
            strSql.Append("D_ExamUseCount=@D_ExamUseCount,");
            strSql.Append("D_TotalUseCount=@D_TotalUseCount,");
            strSql.Append("D_CurrUseTime=@D_CurrUseTime,");
            strSql.Append("D_ExamUseTime=@D_ExamUseTime,");
            strSql.Append("D_TotalUseTime=@D_TotalUseTime,");
            strSql.Append("D_AbnormalCount=@D_AbnormalCount,");
            strSql.Append("D_RepairedCount=@D_RepairedCount,");
            strSql.Append("D_Skill=@D_Skill,");
            strSql.Append("D_ScoreItems=@D_ScoreItems,");
            strSql.Append("D_int1=@D_int1,");
            strSql.Append("D_int2=@D_int2,");
            strSql.Append("D_int3=@D_int3,");
            strSql.Append("D_int4=@D_int4,");
            strSql.Append("D_int5=@D_int5,");
            strSql.Append("D_string1=@D_string1,");
            strSql.Append("D_string2=@D_string2,");
            strSql.Append("D_string3=@D_string3,");
            strSql.Append("D_string4=@D_string4,");
            strSql.Append("D_string5=@D_string5,");
            strSql.Append("D_string6=@D_string6,");
            strSql.Append("D_string7=@D_string7,");
            strSql.Append("D_string8=@D_string8,");
            strSql.Append("D_string9=@D_string9,");
            strSql.Append("D_string10=@D_string10,");
            strSql.Append("D_datetime1=@D_datetime1,");
            strSql.Append("D_datetime2=@D_datetime2,");
            strSql.Append("D_datetime3=@D_datetime3,");
            strSql.Append("D_datetime4=@D_datetime4,");
            strSql.Append("D_datetime5=@D_datetime5,");
            strSql.Append("D_QRCode=@D_QRCode");
            strSql.Append(" where D_ID=@D_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@D_SerialNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@DC_ID1", SqlDbType.Int,4),
					new SqlParameter("@DT_ID", SqlDbType.Int,4),
					new SqlParameter("@D_Model", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Manufacturer", SqlDbType.NVarChar,50),
					new SqlParameter("@D_ManufacturerNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_ManufactureDate", SqlDbType.DateTime),
					new SqlParameter("@D_Batch", SqlDbType.NVarChar,50),
					new SqlParameter("@D_WarrantyInfo", SqlDbType.NVarChar,1000),
					new SqlParameter("@D_Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@D_Position", SqlDbType.NVarChar,200),
					new SqlParameter("@D_IsCanUse", SqlDbType.Int,4),
					new SqlParameter("@D_State", SqlDbType.NVarChar,20),
					new SqlParameter("@D_StateDescription", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_CurrUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_CurrUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_AbnormalCount", SqlDbType.Int,4),
					new SqlParameter("@D_RepairedCount", SqlDbType.Int,4),
					new SqlParameter("@D_Skill", SqlDbType.NVarChar,100),
					new SqlParameter("@D_ScoreItems", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_int1", SqlDbType.Int,4),
					new SqlParameter("@D_int2", SqlDbType.Int,4),
					new SqlParameter("@D_int3", SqlDbType.Int,4),
					new SqlParameter("@D_int4", SqlDbType.Int,4),
					new SqlParameter("@D_int5", SqlDbType.Int,4),
					new SqlParameter("@D_string1", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string2", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string3", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string4", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string5", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string6", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string7", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string8", SqlDbType.NVarChar,200),
					new SqlParameter("@D_string9", SqlDbType.NVarChar,500),
					new SqlParameter("@D_string10", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_datetime1", SqlDbType.DateTime),
					new SqlParameter("@D_datetime2", SqlDbType.DateTime),
					new SqlParameter("@D_datetime3", SqlDbType.DateTime),
					new SqlParameter("@D_datetime4", SqlDbType.DateTime),
					new SqlParameter("@D_datetime5", SqlDbType.DateTime),
					new SqlParameter("@D_QRCode", SqlDbType.NVarChar,500),
					new SqlParameter("@D_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.D_SerialNumber;
            parameters[1].Value = model.D_Name;
            parameters[2].Value = model.DC_ID;
            parameters[3].Value = model.DC_ID1;
            parameters[4].Value = model.DT_ID;
            parameters[5].Value = model.D_Model;
            parameters[6].Value = model.D_Manufacturer;
            parameters[7].Value = model.D_ManufacturerNumber;
            parameters[8].Value = model.D_ManufactureDate;
            parameters[9].Value = model.D_Batch;
            parameters[10].Value = model.D_WarrantyInfo;
            parameters[11].Value = model.D_Remark;
            parameters[12].Value = model.D_RegisterDate;
            parameters[13].Value = model.D_Position;
            parameters[14].Value = model.D_IsCanUse;
            parameters[15].Value = model.D_State;
            parameters[16].Value = model.D_StateDescription;
            parameters[17].Value = model.D_CurrUseCount;
            parameters[18].Value = model.D_ExamUseCount;
            parameters[19].Value = model.D_TotalUseCount;
            parameters[20].Value = model.D_CurrUseTime;
            parameters[21].Value = model.D_ExamUseTime;
            parameters[22].Value = model.D_TotalUseTime;
            parameters[23].Value = model.D_AbnormalCount;
            parameters[24].Value = model.D_RepairedCount;
            parameters[25].Value = model.D_Skill;
            parameters[26].Value = model.D_ScoreItems;
            parameters[27].Value = model.D_int1;
            parameters[28].Value = model.D_int2;
            parameters[29].Value = model.D_int3;
            parameters[30].Value = model.D_int4;
            parameters[31].Value = model.D_int5;
            parameters[32].Value = model.D_string1;
            parameters[33].Value = model.D_string2;
            parameters[34].Value = model.D_string3;
            parameters[35].Value = model.D_string4;
            parameters[36].Value = model.D_string5;
            parameters[37].Value = model.D_string6;
            parameters[38].Value = model.D_string7;
            parameters[39].Value = model.D_string8;
            parameters[40].Value = model.D_string9;
            parameters[41].Value = model.D_string10;
            parameters[42].Value = model.D_datetime1;
            parameters[43].Value = model.D_datetime2;
            parameters[44].Value = model.D_datetime3;
            parameters[45].Value = model.D_datetime4;
            parameters[46].Value = model.D_datetime5;
            parameters[47].Value = model.D_QRCode;
            parameters[48].Value = model.D_ID;

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
        public bool Delete(int D_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Device ");
            strSql.Append(" where D_ID=@D_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@D_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = D_ID;

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
        public bool DeleteList(string D_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Device ");
            strSql.Append(" where D_ID in (" + D_IDlist + ")  ");
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
        public Tellyes.Model.Device GetModel(int D_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 D_ID,D_SerialNumber,D_Name,DC_ID,DC_ID1,DT_ID,D_Model,D_Manufacturer,D_ManufacturerNumber,D_ManufactureDate,D_Batch,D_WarrantyInfo,D_Remark,D_RegisterDate,D_Position,D_IsCanUse,D_State,D_StateDescription,D_CurrUseCount,D_ExamUseCount,D_TotalUseCount,D_CurrUseTime,D_ExamUseTime,D_TotalUseTime,D_AbnormalCount,D_RepairedCount,D_Skill,D_ScoreItems,D_int1,D_int2,D_int3,D_int4,D_int5,D_string1,D_string2,D_string3,D_string4,D_string5,D_string6,D_string7,D_string8,D_string9,D_string10,D_datetime1,D_datetime2,D_datetime3,D_datetime4,D_datetime5,D_QRCode from Device ");
            strSql.Append(" where D_ID=@D_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@D_ID", SqlDbType.Int,4)
			};
            parameters[0].Value = D_ID;

            Tellyes.Model.Device model = new Tellyes.Model.Device();
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
        public Tellyes.Model.Device DataRowToModel(DataRow row)
        {
            Tellyes.Model.Device model = new Tellyes.Model.Device();
            if (row != null)
            {
                if (row["D_ID"] != null && row["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(row["D_ID"].ToString());
                }
                if (row["D_SerialNumber"] != null)
                {
                    model.D_SerialNumber = row["D_SerialNumber"].ToString();
                }
                if (row["D_Name"] != null)
                {
                    model.D_Name = row["D_Name"].ToString();
                }
                if (row["DC_ID"] != null && row["DC_ID"].ToString() != "")
                {
                    model.DC_ID = int.Parse(row["DC_ID"].ToString());
                }
                if (row["DC_ID1"] != null && row["DC_ID1"].ToString() != "")
                {
                    model.DC_ID1 = int.Parse(row["DC_ID1"].ToString());
                }
                if (row["DT_ID"] != null && row["DT_ID"].ToString() != "")
                {
                    model.DT_ID = int.Parse(row["DT_ID"].ToString());
                }
                if (row["D_Model"] != null)
                {
                    model.D_Model = row["D_Model"].ToString();
                }
                if (row["D_Manufacturer"] != null)
                {
                    model.D_Manufacturer = row["D_Manufacturer"].ToString();
                }
                if (row["D_ManufacturerNumber"] != null)
                {
                    model.D_ManufacturerNumber = row["D_ManufacturerNumber"].ToString();
                }
                if (row["D_ManufactureDate"] != null && row["D_ManufactureDate"].ToString() != "")
                {
                    model.D_ManufactureDate = DateTime.Parse(row["D_ManufactureDate"].ToString());
                }
                if (row["D_Batch"] != null)
                {
                    model.D_Batch = row["D_Batch"].ToString();
                }
                if (row["D_WarrantyInfo"] != null)
                {
                    model.D_WarrantyInfo = row["D_WarrantyInfo"].ToString();
                }
                if (row["D_Remark"] != null)
                {
                    model.D_Remark = row["D_Remark"].ToString();
                }
                if (row["D_RegisterDate"] != null && row["D_RegisterDate"].ToString() != "")
                {
                    model.D_RegisterDate = DateTime.Parse(row["D_RegisterDate"].ToString());
                }
                if (row["D_Position"] != null)
                {
                    model.D_Position = row["D_Position"].ToString();
                }
                if (row["D_IsCanUse"] != null && row["D_IsCanUse"].ToString() != "")
                {
                    model.D_IsCanUse = int.Parse(row["D_IsCanUse"].ToString());
                }
                if (row["D_State"] != null)
                {
                    model.D_State = row["D_State"].ToString();
                }
                if (row["D_StateDescription"] != null)
                {
                    model.D_StateDescription = row["D_StateDescription"].ToString();
                }
                if (row["D_CurrUseCount"] != null && row["D_CurrUseCount"].ToString() != "")
                {
                    model.D_CurrUseCount = int.Parse(row["D_CurrUseCount"].ToString());
                }
                if (row["D_ExamUseCount"] != null && row["D_ExamUseCount"].ToString() != "")
                {
                    model.D_ExamUseCount = int.Parse(row["D_ExamUseCount"].ToString());
                }
                if (row["D_TotalUseCount"] != null && row["D_TotalUseCount"].ToString() != "")
                {
                    model.D_TotalUseCount = int.Parse(row["D_TotalUseCount"].ToString());
                }
                if (row["D_CurrUseTime"] != null && row["D_CurrUseTime"].ToString() != "")
                {
                    model.D_CurrUseTime = int.Parse(row["D_CurrUseTime"].ToString());
                }
                if (row["D_ExamUseTime"] != null && row["D_ExamUseTime"].ToString() != "")
                {
                    model.D_ExamUseTime = int.Parse(row["D_ExamUseTime"].ToString());
                }
                if (row["D_TotalUseTime"] != null && row["D_TotalUseTime"].ToString() != "")
                {
                    model.D_TotalUseTime = int.Parse(row["D_TotalUseTime"].ToString());
                }
                if (row["D_AbnormalCount"] != null && row["D_AbnormalCount"].ToString() != "")
                {
                    model.D_AbnormalCount = int.Parse(row["D_AbnormalCount"].ToString());
                }
                if (row["D_RepairedCount"] != null && row["D_RepairedCount"].ToString() != "")
                {
                    model.D_RepairedCount = int.Parse(row["D_RepairedCount"].ToString());
                }
                if (row["D_Skill"] != null)
                {
                    model.D_Skill = row["D_Skill"].ToString();
                }
                if (row["D_ScoreItems"] != null)
                {
                    model.D_ScoreItems = row["D_ScoreItems"].ToString();
                }
                if (row["D_int1"] != null && row["D_int1"].ToString() != "")
                {
                    model.D_int1 = int.Parse(row["D_int1"].ToString());
                }
                if (row["D_int2"] != null && row["D_int2"].ToString() != "")
                {
                    model.D_int2 = int.Parse(row["D_int2"].ToString());
                }
                if (row["D_int3"] != null && row["D_int3"].ToString() != "")
                {
                    model.D_int3 = int.Parse(row["D_int3"].ToString());
                }
                if (row["D_int4"] != null && row["D_int4"].ToString() != "")
                {
                    model.D_int4 = int.Parse(row["D_int4"].ToString());
                }
                if (row["D_int5"] != null && row["D_int5"].ToString() != "")
                {
                    model.D_int5 = int.Parse(row["D_int5"].ToString());
                }
                if (row["D_string1"] != null)
                {
                    model.D_string1 = row["D_string1"].ToString();
                }
                if (row["D_string2"] != null)
                {
                    model.D_string2 = row["D_string2"].ToString();
                }
                if (row["D_string3"] != null)
                {
                    model.D_string3 = row["D_string3"].ToString();
                }
                if (row["D_string4"] != null)
                {
                    model.D_string4 = row["D_string4"].ToString();
                }
                if (row["D_string5"] != null)
                {
                    model.D_string5 = row["D_string5"].ToString();
                }
                if (row["D_string6"] != null)
                {
                    model.D_string6 = row["D_string6"].ToString();
                }
                if (row["D_string7"] != null)
                {
                    model.D_string7 = row["D_string7"].ToString();
                }
                if (row["D_string8"] != null)
                {
                    model.D_string8 = row["D_string8"].ToString();
                }
                if (row["D_string9"] != null)
                {
                    model.D_string9 = row["D_string9"].ToString();
                }
                if (row["D_string10"] != null)
                {
                    model.D_string10 = row["D_string10"].ToString();
                }
                if (row["D_datetime1"] != null && row["D_datetime1"].ToString() != "")
                {
                    model.D_datetime1 = DateTime.Parse(row["D_datetime1"].ToString());
                }
                if (row["D_datetime2"] != null && row["D_datetime2"].ToString() != "")
                {
                    model.D_datetime2 = DateTime.Parse(row["D_datetime2"].ToString());
                }
                if (row["D_datetime3"] != null && row["D_datetime3"].ToString() != "")
                {
                    model.D_datetime3 = DateTime.Parse(row["D_datetime3"].ToString());
                }
                if (row["D_datetime4"] != null && row["D_datetime4"].ToString() != "")
                {
                    model.D_datetime4 = DateTime.Parse(row["D_datetime4"].ToString());
                }
                if (row["D_datetime5"] != null && row["D_datetime5"].ToString() != "")
                {
                    model.D_datetime5 = DateTime.Parse(row["D_datetime5"].ToString());
                }
                if (row["D_QRCode"] != null)
                {
                    model.D_QRCode = row["D_QRCode"].ToString();
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
            strSql.Append("select D_ID,D_SerialNumber,D_Name,DC_ID,DC_ID1,DT_ID,D_Model,D_Manufacturer,D_ManufacturerNumber,D_ManufactureDate,D_Batch,D_WarrantyInfo,D_Remark,D_RegisterDate,D_Position,D_IsCanUse,D_State,D_StateDescription,D_CurrUseCount,D_ExamUseCount,D_TotalUseCount,D_CurrUseTime,D_ExamUseTime,D_TotalUseTime,D_AbnormalCount,D_RepairedCount,D_Skill,D_ScoreItems,D_int1,D_int2,D_int3,D_int4,D_int5,D_string1,D_string2,D_string3,D_string4,D_string5,D_string6,D_string7,D_string8,D_string9,D_string10,D_datetime1,D_datetime2,D_datetime3,D_datetime4,D_datetime5,D_QRCode ");
            strSql.Append(" FROM Device ");
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
            strSql.Append(" D_ID,D_SerialNumber,D_Name,DC_ID,DC_ID1,DT_ID,D_Model,D_Manufacturer,D_ManufacturerNumber,D_ManufactureDate,D_Batch,D_WarrantyInfo,D_Remark,D_RegisterDate,D_Position,D_IsCanUse,D_State,D_StateDescription,D_CurrUseCount,D_ExamUseCount,D_TotalUseCount,D_CurrUseTime,D_ExamUseTime,D_TotalUseTime,D_AbnormalCount,D_RepairedCount,D_Skill,D_ScoreItems,D_int1,D_int2,D_int3,D_int4,D_int5,D_string1,D_string2,D_string3,D_string4,D_string5,D_string6,D_string7,D_string8,D_string9,D_string10,D_datetime1,D_datetime2,D_datetime3,D_datetime4,D_datetime5,D_QRCode ");
            strSql.Append(" FROM Device ");
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
            strSql.Append("select count(1) FROM Device ");
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
                strSql.Append("order by T.D_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Device T ");
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
            parameters[0].Value = "Device";
            parameters[1].Value = "D_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public static DataTable GetProductsSummary(string DC_ID)
        {
            string sql = " select COUNT(D_ID) as c,(select DM_Name from DeviceManufacturer where DM_ID=base.D_Manufacturer) as n from dbo.Device as base where DC_ID='" + DC_ID + "' group by D_Manufacturer ";
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        public static DataTable GetBrokenProductSummary(string DC_ID)
        {
            string sql = " select  coalesce( sum(D_AbnormalCount),0) as c,(select DM_Name from DeviceManufacturer where DM_ID=base.D_Manufacturer) as n  from dbo.Device as base where DC_ID='" + DC_ID + "' group by D_Manufacturer ";
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        public static DataTable GetLastLevelProductSummary(string DC_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select ");
            sql.Append(" COUNT(D_ID) as shuliang ");
            sql.Append(" ,COUNT(distinct D_Manufacturer) as D_Manufacturer ");
            sql.Append(" ,coalesce(SUM(D_TotalUseTime),0) as D_TotalUseTime ");
            sql.Append(" ,coalesce(SUM(D_TotalUseCount),0) as D_TotalUseCount ");
            sql.Append(" ,coalesce(SUM(D_AbnormalCount),0) as D_AbnormalCount ");
            sql.Append(" ,coalesce(SUM(D_RepairedCount),0) as D_RepairedCount ");
            sql.Append(" ,coalesce((select COUNT(D_ID) from Device where DC_ID='" + DC_ID + "' and D_State='报废'),0) as baoFeiCount ");
            sql.Append(" ,coalesce(SUM(D_int2),0) as xiuFuCiShu ");
            sql.Append(" ,coalesce(SUM(D_ExamUseCount),0) as D_ExamUseCount ");
            sql.Append(" ,coalesce(SUM(D_TotalUseCount),0) as D_TotalUseCount ");
            sql.Append(" ,coalesce( SUM(D_int1),0) as kuCun ");
            sql.Append(" from dbo.Device as base where DC_ID='" + DC_ID + "'  ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        public static DataTable GetAllDevicePosition()
        {
            string sql = " select distinct D_Position from dbo.Device order by D_Position; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 批量插入设备信息（事务操作）
        /// </summary>
        /// <param name="deviceModelList"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran_Insert(System.Collections.Generic.List<Tellyes.Model.Device> deviceModelList)
        {
            System.Collections.Generic.List<CommandInfo> cmdList = new System.Collections.Generic.List<CommandInfo>();
            foreach (Tellyes.Model.Device model in deviceModelList)
            {
                cmdList.Add(GetCmdInfo_Insert(model));
            }

            int flagNum = DbHelperSQL.ExecuteSqlTran(cmdList);//
            if (flagNum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取插入命令
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CommandInfo GetCmdInfo_Insert(Tellyes.Model.Device model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Device(");
            strSql.Append("D_SerialNumber,D_Name,DC_ID,DC_ID1,DT_ID,D_Model,D_Manufacturer,D_ManufacturerNumber,D_ManufactureDate,D_Batch,D_WarrantyInfo,D_Remark,D_RegisterDate,D_Position,D_IsCanUse,D_State,D_StateDescription,D_CurrUseCount,D_ExamUseCount,D_TotalUseCount,D_CurrUseTime,D_ExamUseTime,D_TotalUseTime,D_AbnormalCount,D_RepairedCount,D_Skill,D_ScoreItems,D_int1,D_int2,D_int3,D_int4,D_int5,D_string1,D_string2,D_string3,D_string4,D_string5,D_string6,D_string7,D_string8,D_string9,D_string10,D_datetime1,D_datetime2,D_datetime3,D_datetime4,D_datetime5,D_QRCode)");
            strSql.Append(" values (");
            strSql.Append("@D_SerialNumber,@D_Name,@DC_ID,@DC_ID1,@DT_ID,@D_Model,@D_Manufacturer,@D_ManufacturerNumber,@D_ManufactureDate,@D_Batch,@D_WarrantyInfo,@D_Remark,@D_RegisterDate,@D_Position,@D_IsCanUse,@D_State,@D_StateDescription,@D_CurrUseCount,@D_ExamUseCount,@D_TotalUseCount,@D_CurrUseTime,@D_ExamUseTime,@D_TotalUseTime,@D_AbnormalCount,@D_RepairedCount,@D_Skill,@D_ScoreItems,@D_int1,@D_int2,@D_int3,@D_int4,@D_int5,@D_string1,@D_string2,@D_string3,@D_string4,@D_string5,@D_string6,@D_string7,@D_string8,@D_string9,@D_string10,@D_datetime1,@D_datetime2,@D_datetime3,@D_datetime4,@D_datetime5,@D_QRCode)");
            //strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@D_SerialNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@DC_ID", SqlDbType.Int,4),
					new SqlParameter("@DC_ID1", SqlDbType.Int,4),
					new SqlParameter("@DT_ID", SqlDbType.Int,4),
					new SqlParameter("@D_Model", SqlDbType.NVarChar,30),
					new SqlParameter("@D_Manufacturer", SqlDbType.NVarChar,50),
					new SqlParameter("@D_ManufacturerNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@D_ManufactureDate", SqlDbType.DateTime),
					new SqlParameter("@D_Batch", SqlDbType.NVarChar,50),
					new SqlParameter("@D_WarrantyInfo", SqlDbType.NVarChar,1000),
					new SqlParameter("@D_Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@D_Position", SqlDbType.NVarChar,200),
					new SqlParameter("@D_IsCanUse", SqlDbType.Int,4),
					new SqlParameter("@D_State", SqlDbType.NVarChar,20),
					new SqlParameter("@D_StateDescription", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_CurrUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseCount", SqlDbType.Int,4),
					new SqlParameter("@D_CurrUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_ExamUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_TotalUseTime", SqlDbType.Int,4),
					new SqlParameter("@D_AbnormalCount", SqlDbType.Int,4),
					new SqlParameter("@D_RepairedCount", SqlDbType.Int,4),
					new SqlParameter("@D_Skill", SqlDbType.NVarChar,100),
					new SqlParameter("@D_ScoreItems", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_int1", SqlDbType.Int,4),
					new SqlParameter("@D_int2", SqlDbType.Int,4),
					new SqlParameter("@D_int3", SqlDbType.Int,4),
					new SqlParameter("@D_int4", SqlDbType.Int,4),
					new SqlParameter("@D_int5", SqlDbType.Int,4),
					new SqlParameter("@D_string1", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string2", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string3", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string4", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string5", SqlDbType.NVarChar,50),
					new SqlParameter("@D_string6", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string7", SqlDbType.NVarChar,100),
					new SqlParameter("@D_string8", SqlDbType.NVarChar,200),
					new SqlParameter("@D_string9", SqlDbType.NVarChar,500),
					new SqlParameter("@D_string10", SqlDbType.NVarChar,4000),
					new SqlParameter("@D_datetime1", SqlDbType.DateTime),
					new SqlParameter("@D_datetime2", SqlDbType.DateTime),
					new SqlParameter("@D_datetime3", SqlDbType.DateTime),
					new SqlParameter("@D_datetime4", SqlDbType.DateTime),
					new SqlParameter("@D_datetime5", SqlDbType.DateTime),
					new SqlParameter("@D_QRCode", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.D_SerialNumber;
            parameters[1].Value = model.D_Name;
            parameters[2].Value = model.DC_ID;
            parameters[3].Value = model.DC_ID1;
            parameters[4].Value = model.DT_ID;
            parameters[5].Value = model.D_Model;
            parameters[6].Value = model.D_Manufacturer;
            parameters[7].Value = model.D_ManufacturerNumber;
            parameters[8].Value = model.D_ManufactureDate;
            parameters[9].Value = model.D_Batch;
            parameters[10].Value = model.D_WarrantyInfo;
            parameters[11].Value = model.D_Remark;
            parameters[12].Value = model.D_RegisterDate;
            parameters[13].Value = model.D_Position;
            parameters[14].Value = model.D_IsCanUse;
            parameters[15].Value = model.D_State;
            parameters[16].Value = model.D_StateDescription;
            parameters[17].Value = model.D_CurrUseCount;
            parameters[18].Value = model.D_ExamUseCount;
            parameters[19].Value = model.D_TotalUseCount;
            parameters[20].Value = model.D_CurrUseTime;
            parameters[21].Value = model.D_ExamUseTime;
            parameters[22].Value = model.D_TotalUseTime;
            parameters[23].Value = model.D_AbnormalCount;
            parameters[24].Value = model.D_RepairedCount;
            parameters[25].Value = model.D_Skill;
            parameters[26].Value = model.D_ScoreItems;
            parameters[27].Value = model.D_int1;
            parameters[28].Value = model.D_int2;
            parameters[29].Value = model.D_int3;
            parameters[30].Value = model.D_int4;
            parameters[31].Value = model.D_int5;
            parameters[32].Value = model.D_string1;
            parameters[33].Value = model.D_string2;
            parameters[34].Value = model.D_string3;
            parameters[35].Value = model.D_string4;
            parameters[36].Value = model.D_string5;
            parameters[37].Value = model.D_string6;
            parameters[38].Value = model.D_string7;
            parameters[39].Value = model.D_string8;
            parameters[40].Value = model.D_string9;
            parameters[41].Value = model.D_string10;
            parameters[42].Value = model.D_datetime1;
            parameters[43].Value = model.D_datetime2;
            parameters[44].Value = model.D_datetime3;
            parameters[45].Value = model.D_datetime4;
            parameters[46].Value = model.D_datetime5;
            parameters[47].Value = model.D_QRCode;

            return new CommandInfo(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 设备统计中，根据条件，获得搜索结果
        /// </summary>
        /// <param name="deviceName"></param>
        /// <param name="isLiangHao"></param>
        /// <param name="isYiChang"></param>
        /// <param name="isTianYan"></param>
        /// <returns></returns>
        public static DataTable GetDeviceDetailByCondition(string deviceName = null, bool isLiangHao = false, bool isYiChang = false, bool isTianYan = false,bool isQiTa=false)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct d.* from dbo.Device as d join dbo.DeviceManufacturer as dm on d.DC_ID=dm.DM_ID where 1=1 ");
            if (deviceName != null)
            {
                sql.Append(" and d.D_Name like '%" + deviceName.Trim() + "%' ");
            }
            #region MyRegion
            if (isLiangHao & isYiChang)
            {
                sql.Append(" and d.D_State = '良好' or d.D_State='异常' ");
            }
            else if (isLiangHao)
            {
                sql.Append(" and d.D_State = '良好' ");
            }
            else if (isYiChang)
            {
                sql.Append(" and d.D_State='异常' ");
            }
            #endregion
            if (isTianYan)
            {
                sql.Append(" and dm.DM_Name like '%天堰%' ");
            }
            if (isQiTa)
            {
                sql.Append(" and dm.DM_Name not like '%天堰%' ");
            }

            return DbHelperSQL.Query(sql.ToString().Trim()).Tables[0];
        }
        #endregion  ExtensionMethod


        #region 联合查询

        /// <summary>
        /// 分页查询设备统计个数（Device表，DeviceUse表，DeviceClass表，DeviceMaintain）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SelectDeviceStatisticInfoRowCountPageByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("COUNT([Device].[D_ID]) ")                
                .Append("FROM ")
                .Append("     [Device]")
                .Append("     LEFT JOIN [DeviceClass]")
                .Append("     ON [Device].[DC_ID] = [DeviceClass].[DC_ID]")
                .Append("     LEFT JOIN (")
                .Append("          SELECT ")
                .Append("               [Device].[D_ID],")
                .Append("               [DeviceUserCount].[UseCount],")
                .Append("               [DeviceUserCount].[UseTime],")
                .Append("               [DeviceClassUseCount].[ClassUseCount],")
                .Append("               CAST(CAST([DeviceUserCount].[UseCount] AS DECIMAL(18,2)) / [DeviceClassUseCount].[ClassUseCount] AS DECIMAL(18,2)) AS [DeviceUseFrequency]")
                .Append("          FROM ")
                .Append("              [Device]")
                .Append("              INNER JOIN (")
                .Append("                    SELECT ")
                .Append("                         [D_ID],")
                .Append("                         COUNT([DU_ID]) AS [UseCount],")
                .Append("                         SUM(DU_TimeSpan) AS [UseTime]")
                .Append("                    FROM ")
                .Append("                        [DeviceUse]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                      [DU_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY ")
            .Append("                          D_ID")
            .Append("              ) AS [DeviceUserCount] ")
            .Append("                   ON [Device].[D_ID] = [DeviceUserCount].[D_ID] ")
            .Append("              INNER JOIN (")
            .Append("                    SELECT ")
            .Append("                         [Device].[DC_ID],")
            .Append("                         COUNT([DU_ID]) AS [ClassUseCount]")
            .Append("                    FROM ")
            .Append("                         [DeviceUse]  ")
            .Append("                         INNER JOIN [Device] ")
            .Append("                               ON [DeviceUse].[D_ID] = [Device].[D_ID]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                WHERE ")
                .Append("                    [DeviceUse].[DU_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY ")
            .Append("                         [Device].[DC_ID]")
            .Append("               ) AS [DeviceClassUseCount]")
            .Append("                    ON [Device].[DC_ID] = [DeviceClassUseCount].[DC_ID]")
            .Append("     ) AS [DeviceUseInfo]")
            .Append("          ON [Device].[D_ID] = [DeviceUseInfo].[D_ID]	")
            .Append("     LEFT JOIN (")
            .Append("          SELECT")
            .Append("               [Device].[D_ID],")
            .Append("               [DeviceMaintainCountSheet].[DeviceMaintainCount],")
            .Append("               [DeviceMaintainCountSheet].[MaintainTime],")
            .Append("               CAST(CAST([DeviceMaintainCountSheet].[DeviceMaintainCount] AS DECIMAL(18,2)) / [DeviceClassMaintainCount].[ClassMaintainCount] AS DECIMAL(18,2)) AS [DeviceMaintainFrequency]")
            .Append("          FROM ")
            .Append("               [Device]")
            .Append("               INNER JOIN (")
            .Append("                     SELECT ")
            .Append("                           [D_ID],")
            .Append("                           COUNT([DM_ID]) AS [DeviceMaintainCount],")
            .Append("                           SUM(DM_TimeSpan) AS [MaintainTime]")
            .Append("                      FROM ")
            .Append("                           [DeviceMaintain] ");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                    WHERE ")
                .Append("                         [DeviceMaintain].[DM_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                      GROUP BY ")
            .Append("                            D_ID")
            .Append("              ) AS [DeviceMaintainCountSheet] ")
            .Append("                   ON [Device].[D_ID] = [DeviceMaintainCountSheet].[D_ID] ")
            .Append("              INNER JOIN (")
            .Append("                    SELECT ")
            .Append("                         [Device].[DC_ID],")
            .Append("                         COUNT([DM_ID]) AS [ClassMaintainCount]")
            .Append("                    FROM ")
            .Append("                         [DeviceMaintain] ")
            .Append("                         INNER JOIN [Device] ")
            .Append("                               ON [DeviceMaintain].[D_ID] = [Device].[D_ID]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                        [DeviceMaintain].[DM_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY")
            .Append("                         [Device].[DC_ID]")
            .Append("              ) AS [DeviceClassMaintainCount]")
            .Append("                  ON [Device].[DC_ID] = [DeviceClassMaintainCount].[DC_ID]")
            .Append("    ) AS [DeviceMaintainInfo]")
            .Append("         ON [Device].[D_ID] = [DeviceMaintainInfo].[D_ID]");

            List<string> conditionSQLStringList = new List<string>();

            if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
            {
                conditionSQLStringList.Add(" [Device].[D_SerialNumber] LIKE :D_SerialNumber ");
            }
            if (conditionDictionary.ContainsKey("D_Name,Like"))
            {
                conditionSQLStringList.Add(" [Device].[D_Name] LIKE :D_Name ");
            }
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                conditionSQLStringList.Add(" [Device].[DC_ID] IN (:deviceClassList) ");
            }
            if (conditionDictionary.ContainsKey("D_State,IN"))
            {
                conditionSQLStringList.Add(" [Device].[D_State] IN (:deviceStateList)");
            }
            conditionSQLStringList.Add(" [Device].[D_int4] = 1"); //逻辑删除字段判断

            if (conditionDictionary.ContainsKey("D_UseCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= 0 AND [DeviceUseInfo].[UseCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] > 10 AND [DeviceUseInfo].[UseCount] < 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] > 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= 0 AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[0] == 0.0)
                    {
                        deviceUseConditionSQLStringList.Add("([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add("([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value)  ");
                    }                    
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }

            }
            if (conditionDictionary.ContainsKey("D_UseTime"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseTime_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= 0 AND [DeviceUseInfo].[UseTime] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] > 10 AND [DeviceUseInfo].[UseTime] < 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] > 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= 0 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[0] == 0)
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value*60 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value*60)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value*60 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value*60)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }
            if (conditionDictionary.ContainsKey("D_UseFrequency"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseFrequency_0_0.5"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[DeviceUseFrequency]) IS NULL OR ([DeviceUseInfo].[DeviceUseFrequency] >= 0 AND [DeviceUseInfo].[DeviceUseFrequency] <= 0.5)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_0.51_0.8"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= 0.51 AND [DeviceUseInfo].[DeviceUseFrequency] <= 0.8)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_0.81_1.0"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= 0.81 AND [DeviceUseInfo].[DeviceUseFrequency]<=1.0)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[DeviceUseFrequency] IS NULL) OR ([DeviceUseInfo].[DeviceUseFrequency] >= 0 AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] IS NULL) OR ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value)  ");
                    }                   
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }
            if (conditionDictionary.ContainsKey("D_MaintainCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] > 10 AND [DeviceMaintainInfo].[DeviceMaintainCount] < 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] > 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[0] == 0)
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }
            if (conditionDictionary.ContainsKey("D_MaintainFrequency"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0_0.5"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainFrequency]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= 0.5)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0.51_0.8"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0.51 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= 0.8)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0.81_1.0"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0.81 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <=1.0)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainFrequency] IS NULL) OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] IS NULL) OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value)  ");
                    }                    
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }

            if (conditionSQLStringList.Count > 0)
            {
                sqlStringBuilder.Append(" WHERE ").Append(string.Join<string>(" AND ", conditionSQLStringList));
            }
          

            string sql = sqlStringBuilder.ToString();

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询参数(Set方式 防SQL注入)    
                if (conditionDictionary.ContainsKey(">StartTime"))
                {
                    iSQLQuery.SetDateTime("StartTime", Convert.ToDateTime(conditionDictionary[">StartTime"]));
                }
                if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
                {
                    iSQLQuery.SetString("D_SerialNumber", "%" + conditionDictionary["D_SerialNumber,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("D_Name,Like"))
                {
                    iSQLQuery.SetString("D_Name", "%" + conditionDictionary["D_Name,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (List<Int32>)conditionDictionary["DC_ID,IN"]);
                }
                if (conditionDictionary.ContainsKey("D_State,IN"))
                {
                    iSQLQuery.SetParameterList("deviceStateList", (string[])conditionDictionary["D_State,IN"]);
                }


                if (conditionDictionary.ContainsKey("D_UseCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Upper_Value", Convert.ToInt32(conditionDictionary["D_UseCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Down_Value", Convert.ToInt32(conditionDictionary["D_UseCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Down_Value", ((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_UseCount_Upper_Value", ((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_UseTime_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDateTime("D_UseTime_Upper_Value", Convert.ToDateTime(conditionDictionary["D_UseTime_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDateTime("D_UseTime_Down_Value",  Convert.ToDateTime(conditionDictionary["D_UseTime_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseTime_Down_Value", ((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_UseTime_Upper_Value", ((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Upper_Value", Convert.ToDecimal(conditionDictionary["D_UseFrequency_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Down_Value", Convert.ToDecimal(conditionDictionary["D_UseFrequency_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Down_Value", ((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_UseFrequency_Upper_Value", ((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Upper_Value", Convert.ToInt32((conditionDictionary["D_MaintainCount_Custom_0_Upper_Value"])));
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Down_Value", Convert.ToInt32(conditionDictionary["D_MaintainCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Down_Value", ((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_MaintainCount_Upper_Value", ((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Upper_Value", Convert.ToDecimal(conditionDictionary["D_MaintainFrequency_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Down_Value", Convert.ToDecimal(conditionDictionary["D_MaintainFrequency_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Down_Value", ((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Upper_Value", ((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[1]);
                }

                //查询结果并返回
                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "分页查询设备统计信息总数失败！请查看DAL层中 SelectDeviceStatisticInfoRowCountPageByCondition（）方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 分页查询设备统计信息（Device表，DeviceUse表，DeviceClass表，DeviceMaintain表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<object[]> SelectDeviceStatisticInfoPageByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("     [Device].[D_ID], ")
                .Append("     [Device].[D_SerialNumber], ")
                .Append("     [Device].[D_Name], ")
                .Append("     [Device].[D_State], ")
                .Append("     [DeviceClass].[DC_Name], ")
                .Append("     [DeviceClass].[DC_ID], ")
                .Append("     [DeviceUseInfo].[UseCount],")
                .Append("     [DeviceUseInfo].[UseTime], ")
                .Append("     [DeviceUseInfo].[DeviceUseFrequency], ")
                .Append("     [DeviceMaintainInfo].[DeviceMaintainCount], ")
                .Append("     [DeviceMaintainInfo].[DeviceMaintainFrequency] ")
                .Append("FROM ")
                .Append("     [Device]")
                .Append("     LEFT JOIN [DeviceClass]")
                .Append("     ON [Device].[DC_ID] = [DeviceClass].[DC_ID]")
                .Append("     LEFT JOIN (")
                .Append("          SELECT ")
                .Append("               [Device].[D_ID],")
                .Append("               [DeviceUserCount].[UseCount],")
                .Append("               [DeviceUserCount].[UseTime],")
                .Append("               [DeviceClassUseCount].[ClassUseCount],")
                .Append("               CAST(CAST([DeviceUserCount].[UseCount] AS DECIMAL(18,2)) / [DeviceClassUseCount].[ClassUseCount] AS DECIMAL(18,2)) AS [DeviceUseFrequency]")
                .Append("          FROM ")
                .Append("              [Device]")
                .Append("              INNER JOIN (")
                .Append("                    SELECT ")
                .Append("                         [D_ID],")
                .Append("                         COUNT([DU_ID]) AS [UseCount],")
                .Append("                         SUM(DU_TimeSpan) AS [UseTime]")
                .Append("                    FROM ")
                .Append("                        [DeviceUse]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                      [DU_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY ")
            .Append("                          D_ID")
            .Append("              ) AS [DeviceUserCount] ")
            .Append("                   ON [Device].[D_ID] = [DeviceUserCount].[D_ID] ")
            .Append("              INNER JOIN (")
            .Append("                    SELECT ")
            .Append("                         [Device].[DC_ID],")
            .Append("                         COUNT([DU_ID]) AS [ClassUseCount]")
            .Append("                    FROM ")
            .Append("                         [DeviceUse]  ")
            .Append("                         INNER JOIN [Device] ")
            .Append("                               ON [DeviceUse].[D_ID] = [Device].[D_ID]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                WHERE ")
                .Append("                    [DeviceUse].[DU_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY ")
            .Append("                         [Device].[DC_ID]")
            .Append("               ) AS [DeviceClassUseCount]")
            .Append("                    ON [Device].[DC_ID] = [DeviceClassUseCount].[DC_ID]")
            .Append("     ) AS [DeviceUseInfo]")
            .Append("          ON [Device].[D_ID] = [DeviceUseInfo].[D_ID]	")
            .Append("     LEFT JOIN (")
            .Append("          SELECT")
            .Append("               [Device].[D_ID],")
            .Append("               [DeviceMaintainCountSheet].[DeviceMaintainCount],")
            .Append("               [DeviceMaintainCountSheet].[MaintainTime],")
            .Append("               CAST(CAST([DeviceMaintainCountSheet].[DeviceMaintainCount] AS DECIMAL(18,2)) / [DeviceClassMaintainCount].[ClassMaintainCount] AS DECIMAL(18,2)) AS [DeviceMaintainFrequency]")
            .Append("          FROM ")
            .Append("               [Device]")
            .Append("               INNER JOIN (")
            .Append("                     SELECT ")
            .Append("                           [D_ID],")
            .Append("                           COUNT([DM_ID]) AS [DeviceMaintainCount],")
            .Append("                           SUM(DM_TimeSpan) AS [MaintainTime]")
            .Append("                      FROM ")
            .Append("                           [DeviceMaintain] ");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                    WHERE ")
                .Append("                         [DeviceMaintain].[DM_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                      GROUP BY ")
            .Append("                            D_ID")
            .Append("              ) AS [DeviceMaintainCountSheet] ")
            .Append("                   ON [Device].[D_ID] = [DeviceMaintainCountSheet].[D_ID] ")
            .Append("              INNER JOIN (")
            .Append("                    SELECT ")
            .Append("                         [Device].[DC_ID],")
            .Append("                         COUNT([DM_ID]) AS [ClassMaintainCount]")
            .Append("                    FROM ")
            .Append("                         [DeviceMaintain] ")
            .Append("                         INNER JOIN [Device] ")
            .Append("                               ON [DeviceMaintain].[D_ID] = [Device].[D_ID]");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                        [DeviceMaintain].[DM_StartTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                    GROUP BY")
            .Append("                         [Device].[DC_ID]")
            .Append("              ) AS [DeviceClassMaintainCount]")
            .Append("                  ON [Device].[DC_ID] = [DeviceClassMaintainCount].[DC_ID]")
            .Append("    ) AS [DeviceMaintainInfo]")
            .Append("         ON [Device].[D_ID] = [DeviceMaintainInfo].[D_ID]");

            List<string> conditionSQLStringList = new List<string>();

            if (conditionDictionary.ContainsKey("D_ID"))
            {
                conditionSQLStringList.Add(" [Device].[D_ID] = :D_ID");
            }
            if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
            {
                conditionSQLStringList.Add(" [Device].[D_SerialNumber] LIKE :D_SerialNumber ");
            }
            if (conditionDictionary.ContainsKey("D_Name,Like"))
            {
                conditionSQLStringList.Add(" [Device].[D_Name] LIKE :D_Name ");
            }
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                conditionSQLStringList.Add(" [Device].[DC_ID] IN (:deviceClassList) ");
            }
            if (conditionDictionary.ContainsKey("D_State,IN"))
            {
                conditionSQLStringList.Add(" [Device].[D_State] IN (:deviceStateList)");
            }

            conditionSQLStringList.Add(" [Device].[D_int4] = 1"); //逻辑删除字段判断

            if (conditionDictionary.ContainsKey("D_UseCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= 0 AND [DeviceUseInfo].[UseCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] > 10 AND [DeviceUseInfo].[UseCount] < 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] > 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= 0 AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[0] == 0)
                    {     
                        deviceUseConditionSQLStringList.Add("([DeviceUseInfo].[UseCount] IS NULL) OR ([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add("([DeviceUseInfo].[UseCount] >= :D_UseCount_Down_Value AND [DeviceUseInfo].[UseCount] <= :D_UseCount_Upper_Value)  ");
                    }                    
                }
                if (deviceUseConditionSQLStringList.Count!=0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }                

            }
            if (conditionDictionary.ContainsKey("D_UseTime"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseTime_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= 0 AND [DeviceUseInfo].[UseTime] <= 10*60)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] > 10*60 AND [DeviceUseInfo].[UseTime] < 100*60)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] > 100*60)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= 0 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[0] == 0)
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] IS NULL) OR ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value*60 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value*60)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[UseTime] >= :D_UseTime_Down_Value*60 AND [DeviceUseInfo].[UseTime] <= :D_UseTime_Upper_Value*60)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                } 
            }
            if (conditionDictionary.ContainsKey("D_UseFrequency"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_UseFrequency_0_0.5"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[DeviceUseFrequency]) IS NULL OR ([DeviceUseInfo].[DeviceUseFrequency] >= 0 AND [DeviceUseInfo].[DeviceUseFrequency] <= 0.5)) ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_0.51_0.8"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= 0.51 AND [DeviceUseInfo].[DeviceUseFrequency] <= 0.8)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_0.81_1.0"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= 0.81 AND [DeviceUseInfo].[DeviceUseFrequency]<=1.0)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceUseInfo].[DeviceUseFrequency] IS NULL) OR ([DeviceUseInfo].[DeviceUseFrequency] >= 0 AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] IS NULL) OR ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceUseInfo].[DeviceUseFrequency] >= :D_UseFrequency_Down_Value AND [DeviceUseInfo].[DeviceUseFrequency] <= :D_UseFrequency_Upper_Value)  ");
                    }                   
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                } 
            }
            if (conditionDictionary.ContainsKey("D_MaintainCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] > 10 AND [DeviceMaintainInfo].[DeviceMaintainCount] < 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] > 100)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[0] == 0)
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainInfo].[DeviceMaintainCount]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value)  ");
                    }
                    else 
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainInfo].[DeviceMaintainCount] >= :D_MaintainCount_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainCount] <= :D_MaintainCount_Upper_Value)  ");
                    }
                    
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                } 
            }
            if (conditionDictionary.ContainsKey("D_MaintainFrequency"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0_0.5"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainFrequency]) IS NULL OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= 0.5)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0.51_0.8"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0.51 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= 0.8)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_0.81_1.0"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0.81 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <=1.0)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainInfo].[DeviceMaintainFrequency] IS NULL) OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= 0 AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] IS NULL) OR ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceMaintainInfo].[DeviceMaintainFrequency] >= :D_MaintainFrequency_Down_Value AND [DeviceMaintainInfo].[DeviceMaintainFrequency] <= :D_MaintainFrequency_Upper_Value)  ");
                    }                    
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                } 
            }
          
            if (conditionSQLStringList.Count > 0)
            {
                sqlStringBuilder.Append(" WHERE ").Append(string.Join<string>(" AND ", conditionSQLStringList));
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
                    .AddScalar("D_ID", NHibernateUtil.Int32)
                    .AddScalar("D_SerialNumber", NHibernateUtil.String)
                    .AddScalar("D_Name", NHibernateUtil.String)
                    .AddScalar("D_State", NHibernateUtil.String)
                    .AddScalar("DC_Name", NHibernateUtil.String)
                    .AddScalar("DC_ID", NHibernateUtil.Int32)
                    .AddScalar("UseCount", NHibernateUtil.Int32)
                    .AddScalar("UseTime", NHibernateUtil.Int32)
                    .AddScalar("DeviceUseFrequency", NHibernateUtil.Decimal)
                    .AddScalar("DeviceMaintainCount", NHibernateUtil.Int32)
                    .AddScalar("DeviceMaintainFrequency", NHibernateUtil.Decimal);
                //设置查询参数(Set方式 防SQL注入)    
                if (conditionDictionary.ContainsKey(">StartTime"))
                {
                    iSQLQuery.SetDateTime("StartTime", Convert.ToDateTime(conditionDictionary[">StartTime"]));
                }
                if (conditionDictionary.ContainsKey("D_ID"))
                {
                    iSQLQuery.SetInt32("D_ID", Convert.ToInt32(conditionDictionary["D_ID"]));
                }
                if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
                {
                    iSQLQuery.SetString("D_SerialNumber", "%" + conditionDictionary["D_SerialNumber,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("D_Name,Like"))
                {
                    iSQLQuery.SetString("D_Name", "%" + conditionDictionary["D_Name,Like"] + "%");
                }
                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (List<Int32>)conditionDictionary["DC_ID,IN"]);
                }
                if (conditionDictionary.ContainsKey("D_State,IN"))
                {
                    iSQLQuery.SetParameterList("deviceStateList", (string[])conditionDictionary["D_State,IN"]);
                }
                

                if (conditionDictionary.ContainsKey("D_UseCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Upper_Value", Convert.ToInt32(conditionDictionary["D_UseCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Down_Value", Convert.ToInt32(conditionDictionary["D_UseCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseCount_Down_Value", ((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_UseCount_Upper_Value", ((Int32[])conditionDictionary["D_UseCount_Custom_Down_Value_Upper_Value"])[1]);                   
                }


                if (conditionDictionary.ContainsKey("D_UseTime_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseTime_Upper_Value", Convert.ToInt32(conditionDictionary["D_UseTime_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_UseTime_Down_Value", Convert.ToInt32(conditionDictionary["D_UseTime_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseTime_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_UseTime_Down_Value", ((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_UseTime_Upper_Value", ((Int32[])conditionDictionary["D_UseTime_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Upper_Value", Convert.ToInt32(conditionDictionary["D_UseFrequency_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Down_Value", Convert.ToInt32(conditionDictionary["D_UseFrequency_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_UseFrequency_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_UseFrequency_Down_Value", ((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_UseFrequency_Upper_Value", ((Decimal[])conditionDictionary["D_UseFrequency_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Upper_Value", Convert.ToInt32(conditionDictionary["D_MaintainCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Down_Value", Convert.ToInt32(conditionDictionary["D_MaintainCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaintainCount_Down_Value", ((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_MaintainCount_Upper_Value", ((Int32[])conditionDictionary["D_MaintainCount_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Upper_Value", Convert.ToDecimal(conditionDictionary["D_MaintainFrequency_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Down_Value", Convert.ToDecimal(conditionDictionary["D_MaintainFrequency_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainFrequency_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Down_Value", ((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_MaintainFrequency_Upper_Value", ((Decimal[])conditionDictionary["D_MaintainFrequency_Custom_Down_Value_Upper_Value"])[1]);
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
                Log4NetUtility.Error(this, "分页查询设备统计信息失败！请查看DAL层中 SelectDeviceStatisticInfoPageByCondition（）方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 分页查询设备类别统计信息（Device表，DeviceUse表，DeviceClass表，DeviceMaintain表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<object[]> SelectDeviceClassStatisticInfoPageByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("       [DeviceClass].[DC_ID], ")
                .Append("       [DeviceClass].[DC_Name], ")
                .Append("       [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate], ")
                .Append("       [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount], ")
                .Append("       [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount], ")
                .Append("       [DeviceStatisticSheet].[DeviceClassCount] ")
                .Append("FROM   ")
                .Append("       [DeviceClass] ")
                .Append("       LEFT JOIN ( ")
                .Append("                  SELECT ")
                .Append("                        [Device].[DC_ID],")
                .Append("                        CAST(SUM(CASE [DeviceMaintain].[DM_Result] WHEN '良好' then 1 ELSE 0 END) / CAST(COUNT([DeviceMaintain].[DM_ID]) AS DECIMAL(18,2)) AS DECIMAL(18,2)) AS [DeviceMaintainSuccessRate] ")
                .Append("                  FROM ")
                .Append("                       [DeviceMaintain] ")
                .Append("                       INNER JOIN [Device] ")
                .Append("                               ON [Device].[D_ID] = [DeviceMaintain].[D_ID] ");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                    [DeviceMaintain].[DM_EndTime] IS NULL OR [DeviceMaintain].[DM_EndTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                     GROUP BY ")
            .Append("                            [Device].[DC_ID]) AS [DeviceMaintainSuccessRateSheet]")
            .Append("                     ON [DeviceMaintainSuccessRateSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
            .Append("         LEFT JOIN (")
            .Append("                    SELECT ")
            .Append("                          [Device].[DC_ID], ")
            .Append("                          MAX([DeviceMaintainCountSheet].[DeviceMaintainCount]) AS [DeviceClassMaxMaintainCount] ")
            .Append("                     FROM ")
            .Append("                          [Device]  ")
            .Append("                          INNER JOIN (  ")
            .Append("                                     SELECT  ")
            .Append("                                           [DeviceMaintain].[D_ID], ")
            .Append("                                           COUNT([DeviceMaintain].[DM_ID]) AS [DeviceMaintainCount]  ")
            .Append("                                      FROM  ")
            .Append("                                           [DeviceMaintain]  ");
             if (conditionDictionary.ContainsKey(">StartTime"))
             {
                sqlStringBuilder
                .Append("                                  WHERE ")
                .Append("                                       [DeviceMaintain].[DM_EndTime] IS NULL OR [DeviceMaintain].[DM_EndTime] > :StartTime");
             }

             sqlStringBuilder
            .Append("                                      GROUP BY ")
            .Append("                                              [DeviceMaintain].[D_ID] ) AS [DeviceMaintainCountSheet]")
            .Append("                                           ON [DeviceMaintainCountSheet].[D_ID] = [Device].[D_ID]")
            .Append("                    GROUP BY ")
            .Append("                             [Device].[DC_ID]) AS [DeviceClassMaxMaintainCountSheet] ")
            .Append("                         ON  [DeviceClassMaxMaintainCountSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
            .Append("          LEFT JOIN (")
            .Append("                       SELECT ")
            .Append("                             [Device].[DC_ID], ")
            .Append("                             CAST(COUNT([DeviceUse].[DU_ID]) / CAST (COUNT(DISTINCT [DeviceUse].[E_ID]) AS DECIMAL(18,2)) AS DECIMAL(18,2)) AS DeviceClassAverageUseCount ")
            .Append("                       FROM ")
            .Append("                           [Device] ")
            .Append("                           INNER JOIN [DeviceUse] ")
            .Append("                                   ON [Device].[D_ID] = [DeviceUse].[D_ID] ");
             if (conditionDictionary.ContainsKey(">StartTime"))
             {
                 sqlStringBuilder
                 .Append("                  WHERE ")
                 .Append("                [DeviceUse].[DU_EndTime] IS NULL  OR [DeviceUse].[DU_EndTime] > :StartTime");
             }
             sqlStringBuilder
            .Append("                    GROUP BY ")
            .Append("                             [Device].[DC_ID]) AS [DeviceClassAverageUseCountSheet] ")
            .Append("                          ON [DeviceClassAverageUseCountSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
            .Append("        LEFT JOIN ( ")
            .Append("                    SELECT ")
            .Append("                          [DeviceClass].[DC_ID], ")
            .Append("                          COUNT([Device].[D_ID]) AS DeviceClassCount ")
            .Append("                    FROM ")
            .Append("                         [DeviceClass] ")
            .Append("                          LEFT JOIN [Device] ")
            .Append("                                 ON [Device].[DC_ID] = [DeviceClass].[DC_ID]  ")
            .Append("                    WHERE  [Device].[D_int4]=1")////////逻辑删除列
            .Append("                          GROUP BY ")
            .Append("                                [DeviceClass].[DC_ID]) AS DeviceStatisticSheet ")
            .Append("                             ON [DeviceClass].DC_ID=DeviceStatisticSheet.DC_ID	   ");
            

            List<string> conditionSQLStringList = new List<string>();
            if (conditionDictionary.ContainsKey("DC_ID,IN")) 
            {
                conditionSQLStringList.Add(" [DeviceClass].[DC_ID] IN (:deviceClassList) ");
            }
            conditionSQLStringList.Add(" [DeviceClass].[DC_IsValid] = 1"); //逻辑删除字段判断

            if (conditionDictionary.ContainsKey("D_MaintainSuccessRate"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_0_30%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] IS NULL OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= 0 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 0.30)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_31%_60%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] > 0.31 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 0.60)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_61%_100%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] > 0.61 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 1.00)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] IS NULL) OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]  >= 0 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]  >= :D_MaintainSuccessRate_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0.0))
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]) IS NULL OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= :D_MaintainSuccessRate_Down_Value AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= :D_MaintainSuccessRate_Down_Value AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value) ");
                    }

                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }
            if (conditionDictionary.ContainsKey("D_MaxMaintainCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] IS NULL OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= 0 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] > 11 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]<= 100) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] > 100) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] IS NULL) OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  >= 0 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <=  :D_MaxMaintainCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  >= :D_MaxMaintainCount_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[0] == 0.0)
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  IS NULL) OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= :D_MaxMaintainCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_MaxMaintainCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= :D_MaxMaintainCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_MaxMaintainCount_Upper_Value)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }

            if (conditionDictionary.ContainsKey("D_AverageUseCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_AverageUseCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] IS NULL OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= 0 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] > 11 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]<= 100) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] > 100) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] IS NULL) OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= 0 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] <= :D_AverageUseCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]  >= :D_AverageUseCount_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0.0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]  IS NULL) OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]>= :D_AverageUseCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_AverageUseCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= :D_AverageUseCount_Down_Value AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]<= :D_AverageUseCount_Upper_Value)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }

            //添加设备类型ID条件
            if (conditionDictionary.ContainsKey("deviceClassId"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                deviceUseConditionSQLStringList.Add(" ( [DeviceClass].[DC_ID] = :DC_ID) ");
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }


            if (conditionSQLStringList.Count > 0)
            {
                sqlStringBuilder.Append(" WHERE ").Append(string.Join<string>(" AND ", conditionSQLStringList));
            }

            if (orderList != null && orderList.Count > 0)
            {
                sqlStringBuilder.Append(" ORDER BY ");
                foreach (KeyValuePair<string, string> orderItem in orderList)
                {
                    string orderColumn = orderItem.Key;             
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
                    .AddScalar("DC_ID", NHibernateUtil.Int32)
                    .AddScalar("DC_Name", NHibernateUtil.String)
                    .AddScalar("DeviceMaintainSuccessRate", NHibernateUtil.Decimal)
                    .AddScalar("DeviceClassMaxMaintainCount", NHibernateUtil.Int32)
                    .AddScalar("DeviceClassAverageUseCount", NHibernateUtil.Decimal)
                    .AddScalar("DeviceClassCount", NHibernateUtil.Int32);
                //设置查询参数(Set方式 防SQL注入)               

                if (conditionDictionary.ContainsKey(">StartTime"))
                {
                    iSQLQuery.SetDateTime("StartTime", Convert.ToDateTime(conditionDictionary[">StartTime"]));
                }

                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (List<Int32>)conditionDictionary["DC_ID,IN"]);
                }

                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Upper_Value", Convert.ToDecimal(conditionDictionary["D_MaintainSuccessRate_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Down_Value", Convert.ToDecimal(conditionDictionary["D_MaintainSuccessRate_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Down_Value",  ((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Upper_Value", ((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Upper_Value", Convert.ToInt32(conditionDictionary["D_MaxMaintainCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Down_Value", Convert.ToInt32(conditionDictionary["D_MaxMaintainCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Down_Value", ((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Upper_Value", ((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[1]);
                }

                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Upper_Value", Convert.ToDecimal(conditionDictionary["D_AverageUseCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Down_Value", Convert.ToDecimal(conditionDictionary["D_AverageUseCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Down_Value", ((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_AverageUseCount_Upper_Value", ((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[1]);
                }

                if (conditionDictionary.ContainsKey("deviceClassId"))
                {
                    iSQLQuery.SetInt32("DC_ID", Convert.ToInt32(conditionDictionary["deviceClassId"]));
                }

                iSQLQuery
                    .SetFirstResult((pageIndex - 1) * pageSize)
                    .SetMaxResults(pageSize);

                //查询结果并返回
                return iSQLQuery
                    .List<object[]>()
                    .ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "分页查询设备统计信息失败！请查看DAL层中 SelectDeviceClassStatisticInfoPageByCondition（）方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }


        /// <summary>
        /// 分页查询设备类别统计信息（Device表，DeviceUse表，DeviceClass表，DeviceMaintain表）
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public int ? SelectDeviceClassStatisticInfoRowCountPageByCondition(Dictionary<string, object> conditionDictionary)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            StringBuilder sqlStringBuilder = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("        COUNT([DeviceClass].[DC_ID]) ")
                .Append("FROM   ")
                .Append("       [DeviceClass] ")
                .Append("       LEFT JOIN ( ")
                .Append("                  SELECT ")
                .Append("                        [Device].[DC_ID],")
                .Append("                        CAST(SUM(CASE [DeviceMaintain].[DM_Result] WHEN '良好' then 1 ELSE 0 END) / CAST(COUNT([DeviceMaintain].[DM_ID]) AS DECIMAL(18,2)) AS DECIMAL(18,2)) AS [DeviceMaintainSuccessRate] ")
                .Append("                  FROM ")
                .Append("                       [DeviceMaintain] ")
                .Append("                       INNER JOIN [Device] ")
                .Append("                               ON [Device].[D_ID] = [DeviceMaintain].[D_ID] ");

            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                     [DeviceMaintain].[DM_EndTime] IS NULL OR [DeviceMaintain].[DM_EndTime] > :StartTime");
            }

            sqlStringBuilder
            .Append("                     GROUP BY ")
            .Append("                            [Device].[DC_ID]) AS [DeviceMaintainSuccessRateSheet]")
            .Append("                     ON [DeviceMaintainSuccessRateSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
            .Append("         LEFT JOIN (")
            .Append("                    SELECT ")
            .Append("                          [Device].[DC_ID], ")
            .Append("                          MAX([DeviceMaintainCountSheet].[DeviceMaintainCount]) AS [DeviceClassMaxMaintainCount] ")
            .Append("                     FROM ")
            .Append("                          [Device]  ")
            .Append("                          INNER JOIN (  ")
            .Append("                                     SELECT  ")
            .Append("                                           [DeviceMaintain].[D_ID], ")
            .Append("                                           COUNT([DeviceMaintain].[DM_ID]) AS [DeviceMaintainCount]  ")
            .Append("                                      FROM  ")
            .Append("                                           [DeviceMaintain]  ");
            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                                  WHERE ")
                .Append("                                  [DeviceMaintain].[DM_EndTime] IS NULL OR [DeviceMaintain].[DM_EndTime] > :StartTime");
            }

            sqlStringBuilder
           .Append("                                      GROUP BY ")
           .Append("                                              [DeviceMaintain].[D_ID] ) AS [DeviceMaintainCountSheet]")
           .Append("                                           ON [DeviceMaintainCountSheet].[D_ID] = [Device].[D_ID]")
           .Append("                    GROUP BY ")
           .Append("                             [Device].[DC_ID]) AS [DeviceClassMaxMaintainCountSheet] ")
           .Append("                         ON  [DeviceClassMaxMaintainCountSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
           .Append("          LEFT JOIN (")
           .Append("                       SELECT ")
           .Append("                             [Device].[DC_ID], ")
           .Append("                             CAST(COUNT([DeviceUse].[DU_ID]) / CAST (COUNT(DISTINCT [DeviceUse].[E_ID]) AS DECIMAL(18,2)) AS DECIMAL(18,2)) AS DeviceClassAverageUseCount ")
           .Append("                       FROM ")
           .Append("                           [Device] ")
           .Append("                           INNER JOIN [DeviceUse] ")
           .Append("                                   ON [Device].[D_ID] = [DeviceUse].[D_ID] ");
            if (conditionDictionary.ContainsKey(">StartTime"))
            {
                sqlStringBuilder
                .Append("                  WHERE ")
                .Append("                       [DeviceUse].[DU_EndTime] IS NULL  OR [DeviceUse].[DU_EndTime] > :StartTime");
            }
            sqlStringBuilder
           .Append("                    GROUP BY ")
           .Append("                             [Device].[DC_ID]) AS [DeviceClassAverageUseCountSheet] ")
           .Append("                          ON [DeviceClassAverageUseCountSheet].[DC_ID] = [DeviceClass].[DC_ID] ")
           .Append("        LEFT JOIN ( ")
           .Append("                    SELECT ")
           .Append("                          [DeviceClass].[DC_ID], ")
           .Append("                          COUNT([Device].[D_ID]) AS DeviceClassCount ")
           .Append("                    FROM ")
           .Append("                         [DeviceClass] ")
           .Append("                          LEFT JOIN [Device] ")
           .Append("                                 ON [Device].[DC_ID] = [DeviceClass].[DC_ID]  ")
           .Append("                    WHERE  [Device].[D_int4]=1")////////逻辑删除列
           .Append("                          GROUP BY ")
           .Append("                                [DeviceClass].[DC_ID]) AS DeviceStatisticSheet ")
           .Append("                             ON [DeviceClass].DC_ID=DeviceStatisticSheet.DC_ID	   ");


            List<string> conditionSQLStringList = new List<string>();
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                conditionSQLStringList.Add(" [DeviceClass].[DC_ID] IN (:deviceClassList) ");
            }
            conditionSQLStringList.Add(" [DeviceClass].[DC_IsValid] = 1"); //逻辑删除字段判断

            if (conditionDictionary.ContainsKey("D_MaintainSuccessRate"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_0_30%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] IS NULL OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= 0 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 0.30)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_31%_60%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] > 0.31 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 0.60)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_61%_100%"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] > 0.61 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= 1.00)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] IS NULL) OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]  >= 0 AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]  >= :D_MaintainSuccessRate_Down_Value)  ");
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0.0))
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate]) IS NULL OR ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= :D_MaintainSuccessRate_Down_Value AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add("  ([DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] >= :D_MaintainSuccessRate_Down_Value AND [DeviceMaintainSuccessRateSheet].[DeviceMaintainSuccessRate] <= :D_MaintainSuccessRate_Upper_Value) ");
                    }

                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }
            if (conditionDictionary.ContainsKey("D_MaxMaintainCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] IS NULL OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= 0 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] > 11 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]<= 100) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] > 100) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] IS NULL) OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  >= 0 AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <=  :D_MaxMaintainCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  >= :D_MaxMaintainCount_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[0] == 0.0)
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount]  IS NULL) OR ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= :D_MaxMaintainCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_MaxMaintainCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] >= :D_MaxMaintainCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_MaxMaintainCount_Upper_Value)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }

            if (conditionDictionary.ContainsKey("D_AverageUseCount"))
            {
                List<string> deviceUseConditionSQLStringList = new List<string>();
                if (conditionDictionary.ContainsKey("D_AverageUseCount_0_10"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] IS NULL OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= 0 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] <= 10)) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_11_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] > 11 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]<= 100) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_over_100"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] > 100) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_0_Upper_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" (([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] IS NULL) OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= 0 AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] <= :D_AverageUseCount_Upper_Value))  ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Over_Down_Value"))
                {
                    deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]  >= :D_AverageUseCount_Down_Value) ");
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Down_Value_Upper_Value"))
                {
                    if (((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[0] == Convert.ToDecimal(0.0))
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]  IS NULL) OR ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]>= :D_AverageUseCount_Down_Value AND [DeviceClassMaxMaintainCountSheet].[DeviceClassMaxMaintainCount] <= :D_AverageUseCount_Upper_Value)  ");
                    }
                    else
                    {
                        deviceUseConditionSQLStringList.Add(" ([DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount] >= :D_AverageUseCount_Down_Value AND [DeviceClassAverageUseCountSheet].[DeviceClassAverageUseCount]<= :D_AverageUseCount_Upper_Value)  ");
                    }
                }
                if (deviceUseConditionSQLStringList.Count != 0)
                {
                    conditionSQLStringList.Add(" ( " + string.Join<string>(" OR ", deviceUseConditionSQLStringList) + " ) ");
                }
            }


            if (conditionSQLStringList.Count > 0)
            {
                sqlStringBuilder.Append(" WHERE ").Append(string.Join<string>(" AND ", conditionSQLStringList));
            }           

            string sql = sqlStringBuilder.ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);

                //设置查询参数(Set方式 防SQL注入)
                if (conditionDictionary.ContainsKey(">StartTime"))
                {
                    iSQLQuery.SetDateTime("StartTime", Convert.ToDateTime(conditionDictionary[">StartTime"]));
                }

                if (conditionDictionary.ContainsKey("DC_ID,IN"))
                {
                    iSQLQuery.SetParameterList("deviceClassList", (List<Int32>)conditionDictionary["DC_ID,IN"]);
                }

                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Upper_Value", Convert.ToDecimal(conditionDictionary["D_MaintainSuccessRate_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Down_Value", Convert.ToDecimal(conditionDictionary["D_MaintainSuccessRate_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Down_Value", ((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_MaintainSuccessRate_Upper_Value", ((Decimal[])conditionDictionary["D_MaintainSuccessRate_Custom_Down_Value_Upper_Value"])[1]);
                }


                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Upper_Value", Convert.ToInt32(conditionDictionary["D_MaxMaintainCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Down_Value", Convert.ToInt32(conditionDictionary["D_MaxMaintainCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_MaxMaintainCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Down_Value", ((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetInt32("D_MaxMaintainCount_Upper_Value", ((Int32[])conditionDictionary["D_MaxMaintainCount_Custom_Down_Value_Upper_Value"])[1]);
                }

                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_0_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Upper_Value", Convert.ToDecimal(conditionDictionary["D_AverageUseCount_Custom_0_Upper_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Over_Down_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Down_Value", Convert.ToDecimal(conditionDictionary["D_AverageUseCount_Custom_Over_Down_Value"]));
                }
                if (conditionDictionary.ContainsKey("D_AverageUseCount_Custom_Down_Value_Upper_Value"))
                {
                    iSQLQuery.SetDecimal("D_AverageUseCount_Down_Value", ((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[0]);
                    iSQLQuery.SetDecimal("D_AverageUseCount_Upper_Value", ((Decimal[])conditionDictionary["D_AverageUseCount_Custom_Down_Value_Upper_Value"])[1]);
                }

                return Convert.ToInt32(iSQLQuery.UniqueResult());
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "分页查询设备统计个数信息失败！请查看DAL层中 SelectDeviceClassStatisticInfoRowCountPageByCondition（）方法", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        #endregion

        #region Extension

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            //按设备编号进行模糊查询
            if (conditionDictionary.ContainsKey("D_SerialNumber,Like"))
            {
                criteria.Add(Restrictions.Like("D_SerialNumber", "%" + conditionDictionary["D_SerialNumber,Like"] + "%"));
            }
            //按设备名称进行模糊查询
            if (conditionDictionary.ContainsKey("D_Name,Like"))
            {
                criteria.Add(Restrictions.Like("D_Name", "%" + conditionDictionary["D_Name,Like"] + "%"));
            }
            //查询符合当前状态列表的设备信息
            if (conditionDictionary.ContainsKey("D_State,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("D_State"));
                criteria.Add(Restrictions.In("D_State", (string[])conditionDictionary["D_State,IN"]));
            }
            //查询符合当前设备类别ID列表的设备信息
            if (conditionDictionary.ContainsKey("DC_ID,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("DC_ID"));
                criteria.Add(Restrictions.In("DC_ID", (string[])conditionDictionary["DC_ID,IN"]));
            }
            //查询符合当前制造商列表的设备信息
            if (conditionDictionary.ContainsKey("D_Manufacturer,IN"))
            {
                criteria.Add(Restrictions.IsNotNull("D_Manufacturer"));
                criteria.Add(Restrictions.In("D_Manufacturer", (string[])conditionDictionary["D_Manufacturer,IN"]));
            }
            //查询符合注册开始时间 >= 选择的时间
            if (conditionDictionary.ContainsKey("D_RegisterDate,Earliest"))
            { 
                criteria.Add(Restrictions.IsNotNull("D_RegisterDate"));
                criteria.Add(Restrictions.Ge("D_RegisterDate", conditionDictionary["D_RegisterDate,Earliest"]));
            }
            //查询符合注册开始时间 <= 选择的时间
            if (conditionDictionary.ContainsKey("D_RegisterDate,Latest"))
            {
                criteria.Add(Restrictions.IsNotNull("D_RegisterDate"));
                criteria.Add(Restrictions.Le("D_RegisterDate",conditionDictionary["D_RegisterDate,Latest"]));
            }
            //查询等于设备编号的设备
            if (conditionDictionary.ContainsKey("D_SerialNumber"))
            {
                criteria.Add(Restrictions.IsNotNull("D_SerialNumber"));
                criteria.Add(Restrictions.Eq("D_SerialNumber", conditionDictionary["D_SerialNumber"]));
            }
            //逻辑删除字段
            if (conditionDictionary.ContainsKey("Is_Exist"))
            {
                criteria.Add(Restrictions.IsNotNull("D_int4"));
                criteria.Add(Restrictions.Eq("D_int4", conditionDictionary["Is_Exist"]));
            }
            //查询符合当前设备ID列表的Device集合
            if (conditionDictionary.ContainsKey("D_ID,in"))
            {
                criteria.Add(Restrictions.In("D_ID", (List<Int32>)conditionDictionary["D_ID,in"]));
            }

            //查询等于当前设备ID的Device
            if (conditionDictionary.ContainsKey("D_ID"))
            {
                criteria.Add(Restrictions.Eq("D_ID", (int)conditionDictionary["D_ID"]));
            }  
            return criteria;
        }

        #endregion
    }
}

