using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;

namespace Tellyes.DAL
{
    //系统设备
    public partial class SystemDevice : BaseDAL<Model.SystemDevice>
    {

        public bool Exists(Guid SD_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SystemDevice");
            strSql.Append(" where ");
            strSql.Append(" SD_ID = @SD_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = SD_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.SystemDevice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SystemDevice(");
            strSql.Append("SD_ID,SD_HardDisk_SerialNumber,SD_MAC_Address,SD_Verification_SerialNumber,SD_Registration_Time,SD_Number1,SD_Number2,SD_Number3,SD_Number4,SD_String1,SD_String2,SD_Application_Type,SD_String3,SD_String4,SD_String5,SD_Type,SD_HardWare_Version,SD_HardWare_System_Version,SD_HardWare_SerialNumber,SD_CPU_SerialNumber,SD_Mainboard_SerialNumber,SD_BIOS_SerialNumber");
            strSql.Append(") values (");
            strSql.Append("@SD_ID,@SD_HardDisk_SerialNumber,@SD_MAC_Address,@SD_Verification_SerialNumber,@SD_Registration_Time,@SD_Number1,@SD_Number2,@SD_Number3,@SD_Number4,@SD_String1,@SD_String2,@SD_Application_Type,@SD_String3,@SD_String4,@SD_String5,@SD_Type,@SD_HardWare_Version,@SD_HardWare_System_Version,@SD_HardWare_SerialNumber,@SD_CPU_SerialNumber,@SD_Mainboard_SerialNumber,@SD_BIOS_SerialNumber");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@SD_HardDisk_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_MAC_Address", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Verification_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Registration_Time", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@SD_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@SD_Application_Type", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@SD_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@SD_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@SD_Type", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_Version", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_System_Version", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_CPU_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Mainboard_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_BIOS_SerialNumber", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.SD_HardDisk_SerialNumber;
            parameters[2].Value = model.SD_MAC_Address;
            parameters[3].Value = model.SD_Verification_SerialNumber;
            parameters[4].Value = model.SD_Registration_Time;
            parameters[5].Value = model.SD_Number1;
            parameters[6].Value = model.SD_Number2;
            parameters[7].Value = model.SD_Number3;
            parameters[8].Value = model.SD_Number4;
            parameters[9].Value = model.SD_String1;
            parameters[10].Value = model.SD_String2;
            parameters[11].Value = model.SD_Application_Type;
            parameters[12].Value = model.SD_String3;
            parameters[13].Value = model.SD_String4;
            parameters[14].Value = model.SD_String5;
            parameters[15].Value = model.SD_Type;
            parameters[16].Value = model.SD_HardWare_Version;
            parameters[17].Value = model.SD_HardWare_System_Version;
            parameters[18].Value = model.SD_HardWare_SerialNumber;
            parameters[19].Value = model.SD_CPU_SerialNumber;
            parameters[20].Value = model.SD_Mainboard_SerialNumber;
            parameters[21].Value = model.SD_BIOS_SerialNumber;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.SystemDevice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SystemDevice set ");

            strSql.Append(" SD_ID = @SD_ID , ");
            strSql.Append(" SD_HardDisk_SerialNumber = @SD_HardDisk_SerialNumber , ");
            strSql.Append(" SD_MAC_Address = @SD_MAC_Address , ");
            strSql.Append(" SD_Verification_SerialNumber = @SD_Verification_SerialNumber , ");
            strSql.Append(" SD_Registration_Time = @SD_Registration_Time , ");
            strSql.Append(" SD_Number1 = @SD_Number1 , ");
            strSql.Append(" SD_Number2 = @SD_Number2 , ");
            strSql.Append(" SD_Number3 = @SD_Number3 , ");
            strSql.Append(" SD_Number4 = @SD_Number4 , ");
            strSql.Append(" SD_String1 = @SD_String1 , ");
            strSql.Append(" SD_String2 = @SD_String2 , ");
            strSql.Append(" SD_Application_Type = @SD_Application_Type , ");
            strSql.Append(" SD_String3 = @SD_String3 , ");
            strSql.Append(" SD_String4 = @SD_String4 , ");
            strSql.Append(" SD_String5 = @SD_String5 , ");
            strSql.Append(" SD_Type = @SD_Type , ");
            strSql.Append(" SD_HardWare_Version = @SD_HardWare_Version , ");
            strSql.Append(" SD_HardWare_System_Version = @SD_HardWare_System_Version , ");
            strSql.Append(" SD_HardWare_SerialNumber = @SD_HardWare_SerialNumber , ");
            strSql.Append(" SD_CPU_SerialNumber = @SD_CPU_SerialNumber , ");
            strSql.Append(" SD_Mainboard_SerialNumber = @SD_Mainboard_SerialNumber , ");
            strSql.Append(" SD_BIOS_SerialNumber = @SD_BIOS_SerialNumber  ");
            strSql.Append(" where SD_ID=@SD_ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@SD_HardDisk_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_MAC_Address", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Verification_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Registration_Time", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@SD_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@SD_String2", SqlDbType.VarChar,500) ,            
                        new SqlParameter("@SD_Application_Type", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@SD_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@SD_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@SD_Type", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_Version", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_System_Version", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_HardWare_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_CPU_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_Mainboard_SerialNumber", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SD_BIOS_SerialNumber", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.SD_ID;
            parameters[1].Value = model.SD_HardDisk_SerialNumber;
            parameters[2].Value = model.SD_MAC_Address;
            parameters[3].Value = model.SD_Verification_SerialNumber;
            parameters[4].Value = model.SD_Registration_Time;
            parameters[5].Value = model.SD_Number1;
            parameters[6].Value = model.SD_Number2;
            parameters[7].Value = model.SD_Number3;
            parameters[8].Value = model.SD_Number4;
            parameters[9].Value = model.SD_String1;
            parameters[10].Value = model.SD_String2;
            parameters[11].Value = model.SD_Application_Type;
            parameters[12].Value = model.SD_String3;
            parameters[13].Value = model.SD_String4;
            parameters[14].Value = model.SD_String5;
            parameters[15].Value = model.SD_Type;
            parameters[16].Value = model.SD_HardWare_Version;
            parameters[17].Value = model.SD_HardWare_System_Version;
            parameters[18].Value = model.SD_HardWare_SerialNumber;
            parameters[19].Value = model.SD_CPU_SerialNumber;
            parameters[20].Value = model.SD_Mainboard_SerialNumber;
            parameters[21].Value = model.SD_BIOS_SerialNumber;
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
        public bool Delete(Guid SD_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SystemDevice ");
            strSql.Append(" where SD_ID=@SD_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = SD_ID;


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
        public Tellyes.Model.SystemDevice GetModel(Guid SD_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SD_ID, SD_HardDisk_SerialNumber, SD_MAC_Address, SD_Verification_SerialNumber, SD_Registration_Time, SD_Number1, SD_Number2, SD_Number3, SD_Number4, SD_String1, SD_String2, SD_Application_Type, SD_String3, SD_String4, SD_String5, SD_Type, SD_HardWare_Version, SD_HardWare_System_Version, SD_HardWare_SerialNumber, SD_CPU_SerialNumber, SD_Mainboard_SerialNumber, SD_BIOS_SerialNumber  ");
            strSql.Append("  from SystemDevice ");
            strSql.Append(" where SD_ID=@SD_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = SD_ID;


            Tellyes.Model.SystemDevice model = new Tellyes.Model.SystemDevice();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["SD_ID"].ToString() != "")
                {
                    model.SD_ID =ds.Tables[0].Rows[0]["SD_ID"].ToString();
                }
                model.SD_HardDisk_SerialNumber = ds.Tables[0].Rows[0]["SD_HardDisk_SerialNumber"].ToString();
                model.SD_MAC_Address = ds.Tables[0].Rows[0]["SD_MAC_Address"].ToString();
                model.SD_Verification_SerialNumber = ds.Tables[0].Rows[0]["SD_Verification_SerialNumber"].ToString();
                model.SD_Registration_Time = ds.Tables[0].Rows[0]["SD_Registration_Time"].ToString();
                if (ds.Tables[0].Rows[0]["SD_Number1"].ToString() != "")
                {
                    model.SD_Number1 = int.Parse(ds.Tables[0].Rows[0]["SD_Number1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SD_Number2"].ToString() != "")
                {
                    model.SD_Number2 = int.Parse(ds.Tables[0].Rows[0]["SD_Number2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SD_Number3"].ToString() != "")
                {
                    model.SD_Number3 = int.Parse(ds.Tables[0].Rows[0]["SD_Number3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SD_Number4"].ToString() != "")
                {
                    model.SD_Number4 = int.Parse(ds.Tables[0].Rows[0]["SD_Number4"].ToString());
                }
                model.SD_String1 = ds.Tables[0].Rows[0]["SD_String1"].ToString();
                model.SD_String2 = ds.Tables[0].Rows[0]["SD_String2"].ToString();
                model.SD_Application_Type = ds.Tables[0].Rows[0]["SD_Application_Type"].ToString();
                model.SD_String3 = ds.Tables[0].Rows[0]["SD_String3"].ToString();
                model.SD_String4 = ds.Tables[0].Rows[0]["SD_String4"].ToString();
                model.SD_String5 = ds.Tables[0].Rows[0]["SD_String5"].ToString();
                model.SD_Type = ds.Tables[0].Rows[0]["SD_Type"].ToString();
                model.SD_HardWare_Version = ds.Tables[0].Rows[0]["SD_HardWare_Version"].ToString();
                model.SD_HardWare_System_Version = ds.Tables[0].Rows[0]["SD_HardWare_System_Version"].ToString();
                model.SD_HardWare_SerialNumber = ds.Tables[0].Rows[0]["SD_HardWare_SerialNumber"].ToString();
                model.SD_CPU_SerialNumber = ds.Tables[0].Rows[0]["SD_CPU_SerialNumber"].ToString();
                model.SD_Mainboard_SerialNumber = ds.Tables[0].Rows[0]["SD_Mainboard_SerialNumber"].ToString();
                model.SD_BIOS_SerialNumber = ds.Tables[0].Rows[0]["SD_BIOS_SerialNumber"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM SystemDevice ");
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
            strSql.Append(" * ");
            strSql.Append(" FROM SystemDevice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #region Extension NHibernate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("SD_Application_Type_Is"))
            {
                criteria.Add(Restrictions.Eq("SD_Application_Type", (string)conditionDictionary["SD_Application_Type_Is"]));
            }

            if (conditionDictionary.ContainsKey("SD_Verification_SerialNumber_Is"))
            {
                criteria.Add(Restrictions.Eq("SD_Verification_SerialNumber", (string)conditionDictionary["SD_Verification_SerialNumber_Is"]));
            }

            return criteria;
        }

        #endregion

    }
}
