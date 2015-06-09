using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
    /// </summary>
    public partial class OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView
    {
        public OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView");
            strSql.Append(" where U_ID=@U_ID and E_ID=@E_ID and EStu_ExamNumber=@EStu_ExamNumber and EStu_int=@EStu_int and EStu_string=@EStu_string and EStu_bool=@EStu_bool and OEA_ID=@OEA_ID and EStu_ID=@EStu_ID and ESR_ID=@ESR_ID and OEA_StartTime=@OEA_StartTime and OEA_EndTime=@OEA_EndTime and OSCEExamInt1=@OSCEExamInt1 and OSCEExamInt2=@OSCEExamInt2 and OSCEExamInt3=@OSCEExamInt3 and OSCEExamString1=@OSCEExamString1 and OSCEExamString2=@OSCEExamString2 and OSCEExamString3=@OSCEExamString3 and OSCEExamDate1=@OSCEExamDate1 and OSCEExamDate2=@OSCEExamDate2 and OSCEExamDate3=@OSCEExamDate3 and OSCEExamFloat1=@OSCEExamFloat1 and OSCEExamFloat2=@OSCEExamFloat2 and OSCEExamFloat3=@OSCEExamFloat3 and ES_ID=@ES_ID and Room_ID=@Room_ID and ExamStationRoomInt1=@ExamStationRoomInt1 and ExamStationRoomInt2=@ExamStationRoomInt2 and ExamStationRoomInt3=@ExamStationRoomInt3 and ExamStationRoomString1=@ExamStationRoomString1 and ExamStationRoomString2=@ExamStationRoomString2 and ExamStationRoomString3=@ExamStationRoomString3 and ExamStationRoomDate1=@ExamStationRoomDate1 and ExamStationRoomDate2=@ExamStationRoomDate2 and ExamStationRoomDate3=@ExamStationRoomDate3 and ExamStationRoomFloat1=@ExamStationRoomFloat1 and ExamStationRoomFloat2=@ExamStationRoomFloat2 and ExamStationRoomFloat3=@ExamStationRoomFloat3 ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamInt1", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt2", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt3", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamString1", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString2", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString3", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamDate1", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate2", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate3", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat3", SqlDbType.Decimal,9)			};
            parameters[0].Value = U_ID;
            parameters[1].Value = E_ID;
            parameters[2].Value = EStu_ExamNumber;
            parameters[3].Value = EStu_int;
            parameters[4].Value = EStu_string;
            parameters[5].Value = EStu_bool;
            parameters[6].Value = OEA_ID;
            parameters[7].Value = EStu_ID;
            parameters[8].Value = ESR_ID;
            parameters[9].Value = OEA_StartTime;
            parameters[10].Value = OEA_EndTime;
            parameters[11].Value = OSCEExamInt1;
            parameters[12].Value = OSCEExamInt2;
            parameters[13].Value = OSCEExamInt3;
            parameters[14].Value = OSCEExamString1;
            parameters[15].Value = OSCEExamString2;
            parameters[16].Value = OSCEExamString3;
            parameters[17].Value = OSCEExamDate1;
            parameters[18].Value = OSCEExamDate2;
            parameters[19].Value = OSCEExamDate3;
            parameters[20].Value = OSCEExamFloat1;
            parameters[21].Value = OSCEExamFloat2;
            parameters[22].Value = OSCEExamFloat3;
            parameters[23].Value = ES_ID;
            parameters[24].Value = Room_ID;
            parameters[25].Value = ExamStationRoomInt1;
            parameters[26].Value = ExamStationRoomInt2;
            parameters[27].Value = ExamStationRoomInt3;
            parameters[28].Value = ExamStationRoomString1;
            parameters[29].Value = ExamStationRoomString2;
            parameters[30].Value = ExamStationRoomString3;
            parameters[31].Value = ExamStationRoomDate1;
            parameters[32].Value = ExamStationRoomDate2;
            parameters[33].Value = ExamStationRoomDate3;
            parameters[34].Value = ExamStationRoomFloat1;
            parameters[35].Value = ExamStationRoomFloat2;
            parameters[36].Value = ExamStationRoomFloat3;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView(");
            strSql.Append("U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool,OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,OSCEExamInt1,OSCEExamInt2,OSCEExamInt3,OSCEExamString1,OSCEExamString2,OSCEExamString3,OSCEExamDate1,OSCEExamDate2,OSCEExamDate3,OSCEExamFloat1,OSCEExamFloat2,OSCEExamFloat3,ES_ID,Room_ID,ExamStationRoomInt1,ExamStationRoomInt2,ExamStationRoomInt3,ExamStationRoomString1,ExamStationRoomString2,ExamStationRoomString3,ExamStationRoomDate1,ExamStationRoomDate2,ExamStationRoomDate3,ExamStationRoomFloat1,ExamStationRoomFloat2,ExamStationRoomFloat3)");
            strSql.Append(" values (");
            strSql.Append("@U_ID,@E_ID,@EStu_ExamNumber,@EStu_int,@EStu_string,@EStu_bool,@OEA_ID,@EStu_ID,@ESR_ID,@OEA_StartTime,@OEA_EndTime,@OSCEExamInt1,@OSCEExamInt2,@OSCEExamInt3,@OSCEExamString1,@OSCEExamString2,@OSCEExamString3,@OSCEExamDate1,@OSCEExamDate2,@OSCEExamDate3,@OSCEExamFloat1,@OSCEExamFloat2,@OSCEExamFloat3,@ES_ID,@Room_ID,@ExamStationRoomInt1,@ExamStationRoomInt2,@ExamStationRoomInt3,@ExamStationRoomString1,@ExamStationRoomString2,@ExamStationRoomString3,@ExamStationRoomDate1,@ExamStationRoomDate2,@ExamStationRoomDate3,@ExamStationRoomFloat1,@ExamStationRoomFloat2,@ExamStationRoomFloat3)");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamInt1", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt2", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt3", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamString1", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString2", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString3", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamDate1", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate2", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate3", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat3", SqlDbType.Decimal,9)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.EStu_ExamNumber;
            parameters[3].Value = model.EStu_int;
            parameters[4].Value = model.EStu_string;
            parameters[5].Value = model.EStu_bool;
            parameters[6].Value = model.OEA_ID;
            parameters[7].Value = model.EStu_ID;
            parameters[8].Value = model.ESR_ID;
            parameters[9].Value = model.OEA_StartTime;
            parameters[10].Value = model.OEA_EndTime;
            parameters[11].Value = model.OSCEExamInt1;
            parameters[12].Value = model.OSCEExamInt2;
            parameters[13].Value = model.OSCEExamInt3;
            parameters[14].Value = model.OSCEExamString1;
            parameters[15].Value = model.OSCEExamString2;
            parameters[16].Value = model.OSCEExamString3;
            parameters[17].Value = model.OSCEExamDate1;
            parameters[18].Value = model.OSCEExamDate2;
            parameters[19].Value = model.OSCEExamDate3;
            parameters[20].Value = model.OSCEExamFloat1;
            parameters[21].Value = model.OSCEExamFloat2;
            parameters[22].Value = model.OSCEExamFloat3;
            parameters[23].Value = model.ES_ID;
            parameters[24].Value = model.Room_ID;
            parameters[25].Value = model.ExamStationRoomInt1;
            parameters[26].Value = model.ExamStationRoomInt2;
            parameters[27].Value = model.ExamStationRoomInt3;
            parameters[28].Value = model.ExamStationRoomString1;
            parameters[29].Value = model.ExamStationRoomString2;
            parameters[30].Value = model.ExamStationRoomString3;
            parameters[31].Value = model.ExamStationRoomDate1;
            parameters[32].Value = model.ExamStationRoomDate2;
            parameters[33].Value = model.ExamStationRoomDate3;
            parameters[34].Value = model.ExamStationRoomFloat1;
            parameters[35].Value = model.ExamStationRoomFloat2;
            parameters[36].Value = model.ExamStationRoomFloat3;

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
        public bool Update(Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView set ");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("EStu_ExamNumber=@EStu_ExamNumber,");
            strSql.Append("EStu_int=@EStu_int,");
            strSql.Append("EStu_string=@EStu_string,");
            strSql.Append("EStu_bool=@EStu_bool,");
            strSql.Append("OEA_ID=@OEA_ID,");
            strSql.Append("EStu_ID=@EStu_ID,");
            strSql.Append("ESR_ID=@ESR_ID,");
            strSql.Append("OEA_StartTime=@OEA_StartTime,");
            strSql.Append("OEA_EndTime=@OEA_EndTime,");
            strSql.Append("OSCEExamInt1=@OSCEExamInt1,");
            strSql.Append("OSCEExamInt2=@OSCEExamInt2,");
            strSql.Append("OSCEExamInt3=@OSCEExamInt3,");
            strSql.Append("OSCEExamString1=@OSCEExamString1,");
            strSql.Append("OSCEExamString2=@OSCEExamString2,");
            strSql.Append("OSCEExamString3=@OSCEExamString3,");
            strSql.Append("OSCEExamDate1=@OSCEExamDate1,");
            strSql.Append("OSCEExamDate2=@OSCEExamDate2,");
            strSql.Append("OSCEExamDate3=@OSCEExamDate3,");
            strSql.Append("OSCEExamFloat1=@OSCEExamFloat1,");
            strSql.Append("OSCEExamFloat2=@OSCEExamFloat2,");
            strSql.Append("OSCEExamFloat3=@OSCEExamFloat3,");
            strSql.Append("ES_ID=@ES_ID,");
            strSql.Append("Room_ID=@Room_ID,");
            strSql.Append("ExamStationRoomInt1=@ExamStationRoomInt1,");
            strSql.Append("ExamStationRoomInt2=@ExamStationRoomInt2,");
            strSql.Append("ExamStationRoomInt3=@ExamStationRoomInt3,");
            strSql.Append("ExamStationRoomString1=@ExamStationRoomString1,");
            strSql.Append("ExamStationRoomString2=@ExamStationRoomString2,");
            strSql.Append("ExamStationRoomString3=@ExamStationRoomString3,");
            strSql.Append("ExamStationRoomDate1=@ExamStationRoomDate1,");
            strSql.Append("ExamStationRoomDate2=@ExamStationRoomDate2,");
            strSql.Append("ExamStationRoomDate3=@ExamStationRoomDate3,");
            strSql.Append("ExamStationRoomFloat1=@ExamStationRoomFloat1,");
            strSql.Append("ExamStationRoomFloat2=@ExamStationRoomFloat2,");
            strSql.Append("ExamStationRoomFloat3=@ExamStationRoomFloat3");
            strSql.Append(" where U_ID=@U_ID and E_ID=@E_ID and EStu_ExamNumber=@EStu_ExamNumber and EStu_int=@EStu_int and EStu_string=@EStu_string and EStu_bool=@EStu_bool and OEA_ID=@OEA_ID and EStu_ID=@EStu_ID and ESR_ID=@ESR_ID and OEA_StartTime=@OEA_StartTime and OEA_EndTime=@OEA_EndTime and OSCEExamInt1=@OSCEExamInt1 and OSCEExamInt2=@OSCEExamInt2 and OSCEExamInt3=@OSCEExamInt3 and OSCEExamString1=@OSCEExamString1 and OSCEExamString2=@OSCEExamString2 and OSCEExamString3=@OSCEExamString3 and OSCEExamDate1=@OSCEExamDate1 and OSCEExamDate2=@OSCEExamDate2 and OSCEExamDate3=@OSCEExamDate3 and OSCEExamFloat1=@OSCEExamFloat1 and OSCEExamFloat2=@OSCEExamFloat2 and OSCEExamFloat3=@OSCEExamFloat3 and ES_ID=@ES_ID and Room_ID=@Room_ID and ExamStationRoomInt1=@ExamStationRoomInt1 and ExamStationRoomInt2=@ExamStationRoomInt2 and ExamStationRoomInt3=@ExamStationRoomInt3 and ExamStationRoomString1=@ExamStationRoomString1 and ExamStationRoomString2=@ExamStationRoomString2 and ExamStationRoomString3=@ExamStationRoomString3 and ExamStationRoomDate1=@ExamStationRoomDate1 and ExamStationRoomDate2=@ExamStationRoomDate2 and ExamStationRoomDate3=@ExamStationRoomDate3 and ExamStationRoomFloat1=@ExamStationRoomFloat1 and ExamStationRoomFloat2=@ExamStationRoomFloat2 and ExamStationRoomFloat3=@ExamStationRoomFloat3 ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamInt1", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt2", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt3", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamString1", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString2", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString3", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamDate1", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate2", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate3", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat3", SqlDbType.Decimal,9)};
            parameters[0].Value = model.U_ID;
            parameters[1].Value = model.E_ID;
            parameters[2].Value = model.EStu_ExamNumber;
            parameters[3].Value = model.EStu_int;
            parameters[4].Value = model.EStu_string;
            parameters[5].Value = model.EStu_bool;
            parameters[6].Value = model.OEA_ID;
            parameters[7].Value = model.EStu_ID;
            parameters[8].Value = model.ESR_ID;
            parameters[9].Value = model.OEA_StartTime;
            parameters[10].Value = model.OEA_EndTime;
            parameters[11].Value = model.OSCEExamInt1;
            parameters[12].Value = model.OSCEExamInt2;
            parameters[13].Value = model.OSCEExamInt3;
            parameters[14].Value = model.OSCEExamString1;
            parameters[15].Value = model.OSCEExamString2;
            parameters[16].Value = model.OSCEExamString3;
            parameters[17].Value = model.OSCEExamDate1;
            parameters[18].Value = model.OSCEExamDate2;
            parameters[19].Value = model.OSCEExamDate3;
            parameters[20].Value = model.OSCEExamFloat1;
            parameters[21].Value = model.OSCEExamFloat2;
            parameters[22].Value = model.OSCEExamFloat3;
            parameters[23].Value = model.ES_ID;
            parameters[24].Value = model.Room_ID;
            parameters[25].Value = model.ExamStationRoomInt1;
            parameters[26].Value = model.ExamStationRoomInt2;
            parameters[27].Value = model.ExamStationRoomInt3;
            parameters[28].Value = model.ExamStationRoomString1;
            parameters[29].Value = model.ExamStationRoomString2;
            parameters[30].Value = model.ExamStationRoomString3;
            parameters[31].Value = model.ExamStationRoomDate1;
            parameters[32].Value = model.ExamStationRoomDate2;
            parameters[33].Value = model.ExamStationRoomDate3;
            parameters[34].Value = model.ExamStationRoomFloat1;
            parameters[35].Value = model.ExamStationRoomFloat2;
            parameters[36].Value = model.ExamStationRoomFloat3;

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
        public bool Delete(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView ");
            strSql.Append(" where U_ID=@U_ID and E_ID=@E_ID and EStu_ExamNumber=@EStu_ExamNumber and EStu_int=@EStu_int and EStu_string=@EStu_string and EStu_bool=@EStu_bool and OEA_ID=@OEA_ID and EStu_ID=@EStu_ID and ESR_ID=@ESR_ID and OEA_StartTime=@OEA_StartTime and OEA_EndTime=@OEA_EndTime and OSCEExamInt1=@OSCEExamInt1 and OSCEExamInt2=@OSCEExamInt2 and OSCEExamInt3=@OSCEExamInt3 and OSCEExamString1=@OSCEExamString1 and OSCEExamString2=@OSCEExamString2 and OSCEExamString3=@OSCEExamString3 and OSCEExamDate1=@OSCEExamDate1 and OSCEExamDate2=@OSCEExamDate2 and OSCEExamDate3=@OSCEExamDate3 and OSCEExamFloat1=@OSCEExamFloat1 and OSCEExamFloat2=@OSCEExamFloat2 and OSCEExamFloat3=@OSCEExamFloat3 and ES_ID=@ES_ID and Room_ID=@Room_ID and ExamStationRoomInt1=@ExamStationRoomInt1 and ExamStationRoomInt2=@ExamStationRoomInt2 and ExamStationRoomInt3=@ExamStationRoomInt3 and ExamStationRoomString1=@ExamStationRoomString1 and ExamStationRoomString2=@ExamStationRoomString2 and ExamStationRoomString3=@ExamStationRoomString3 and ExamStationRoomDate1=@ExamStationRoomDate1 and ExamStationRoomDate2=@ExamStationRoomDate2 and ExamStationRoomDate3=@ExamStationRoomDate3 and ExamStationRoomFloat1=@ExamStationRoomFloat1 and ExamStationRoomFloat2=@ExamStationRoomFloat2 and ExamStationRoomFloat3=@ExamStationRoomFloat3 ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamInt1", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt2", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt3", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamString1", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString2", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString3", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamDate1", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate2", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate3", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat3", SqlDbType.Decimal,9)			};
            parameters[0].Value = U_ID;
            parameters[1].Value = E_ID;
            parameters[2].Value = EStu_ExamNumber;
            parameters[3].Value = EStu_int;
            parameters[4].Value = EStu_string;
            parameters[5].Value = EStu_bool;
            parameters[6].Value = OEA_ID;
            parameters[7].Value = EStu_ID;
            parameters[8].Value = ESR_ID;
            parameters[9].Value = OEA_StartTime;
            parameters[10].Value = OEA_EndTime;
            parameters[11].Value = OSCEExamInt1;
            parameters[12].Value = OSCEExamInt2;
            parameters[13].Value = OSCEExamInt3;
            parameters[14].Value = OSCEExamString1;
            parameters[15].Value = OSCEExamString2;
            parameters[16].Value = OSCEExamString3;
            parameters[17].Value = OSCEExamDate1;
            parameters[18].Value = OSCEExamDate2;
            parameters[19].Value = OSCEExamDate3;
            parameters[20].Value = OSCEExamFloat1;
            parameters[21].Value = OSCEExamFloat2;
            parameters[22].Value = OSCEExamFloat3;
            parameters[23].Value = ES_ID;
            parameters[24].Value = Room_ID;
            parameters[25].Value = ExamStationRoomInt1;
            parameters[26].Value = ExamStationRoomInt2;
            parameters[27].Value = ExamStationRoomInt3;
            parameters[28].Value = ExamStationRoomString1;
            parameters[29].Value = ExamStationRoomString2;
            parameters[30].Value = ExamStationRoomString3;
            parameters[31].Value = ExamStationRoomDate1;
            parameters[32].Value = ExamStationRoomDate2;
            parameters[33].Value = ExamStationRoomDate3;
            parameters[34].Value = ExamStationRoomFloat1;
            parameters[35].Value = ExamStationRoomFloat2;
            parameters[36].Value = ExamStationRoomFloat3;

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
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView GetModel(int U_ID, int E_ID, int EStu_ExamNumber, int EStu_int, string EStu_string, bool EStu_bool, int OEA_ID, int EStu_ID, int ESR_ID, DateTime OEA_StartTime, DateTime OEA_EndTime, int OSCEExamInt1, int OSCEExamInt2, int OSCEExamInt3, string OSCEExamString1, string OSCEExamString2, string OSCEExamString3, DateTime OSCEExamDate1, DateTime OSCEExamDate2, DateTime OSCEExamDate3, decimal OSCEExamFloat1, decimal OSCEExamFloat2, decimal OSCEExamFloat3, int ES_ID, int Room_ID, int ExamStationRoomInt1, int ExamStationRoomInt2, int ExamStationRoomInt3, string ExamStationRoomString1, string ExamStationRoomString2, string ExamStationRoomString3, DateTime ExamStationRoomDate1, DateTime ExamStationRoomDate2, DateTime ExamStationRoomDate3, decimal ExamStationRoomFloat1, decimal ExamStationRoomFloat2, decimal ExamStationRoomFloat3)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool,OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,OSCEExamInt1,OSCEExamInt2,OSCEExamInt3,OSCEExamString1,OSCEExamString2,OSCEExamString3,OSCEExamDate1,OSCEExamDate2,OSCEExamDate3,OSCEExamFloat1,OSCEExamFloat2,OSCEExamFloat3,ES_ID,Room_ID,ExamStationRoomInt1,ExamStationRoomInt2,ExamStationRoomInt3,ExamStationRoomString1,ExamStationRoomString2,ExamStationRoomString3,ExamStationRoomDate1,ExamStationRoomDate2,ExamStationRoomDate3,ExamStationRoomFloat1,ExamStationRoomFloat2,ExamStationRoomFloat3 from OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView ");
            strSql.Append(" where U_ID=@U_ID and E_ID=@E_ID and EStu_ExamNumber=@EStu_ExamNumber and EStu_int=@EStu_int and EStu_string=@EStu_string and EStu_bool=@EStu_bool and OEA_ID=@OEA_ID and EStu_ID=@EStu_ID and ESR_ID=@ESR_ID and OEA_StartTime=@OEA_StartTime and OEA_EndTime=@OEA_EndTime and OSCEExamInt1=@OSCEExamInt1 and OSCEExamInt2=@OSCEExamInt2 and OSCEExamInt3=@OSCEExamInt3 and OSCEExamString1=@OSCEExamString1 and OSCEExamString2=@OSCEExamString2 and OSCEExamString3=@OSCEExamString3 and OSCEExamDate1=@OSCEExamDate1 and OSCEExamDate2=@OSCEExamDate2 and OSCEExamDate3=@OSCEExamDate3 and OSCEExamFloat1=@OSCEExamFloat1 and OSCEExamFloat2=@OSCEExamFloat2 and OSCEExamFloat3=@OSCEExamFloat3 and ES_ID=@ES_ID and Room_ID=@Room_ID and ExamStationRoomInt1=@ExamStationRoomInt1 and ExamStationRoomInt2=@ExamStationRoomInt2 and ExamStationRoomInt3=@ExamStationRoomInt3 and ExamStationRoomString1=@ExamStationRoomString1 and ExamStationRoomString2=@ExamStationRoomString2 and ExamStationRoomString3=@ExamStationRoomString3 and ExamStationRoomDate1=@ExamStationRoomDate1 and ExamStationRoomDate2=@ExamStationRoomDate2 and ExamStationRoomDate3=@ExamStationRoomDate3 and ExamStationRoomFloat1=@ExamStationRoomFloat1 and ExamStationRoomFloat2=@ExamStationRoomFloat2 and ExamStationRoomFloat3=@ExamStationRoomFloat3 ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@EStu_ExamNumber", SqlDbType.Int,4),
					new SqlParameter("@EStu_int", SqlDbType.Int,4),
					new SqlParameter("@EStu_string", SqlDbType.NVarChar,100),
					new SqlParameter("@EStu_bool", SqlDbType.Bit,1),
					new SqlParameter("@OEA_ID", SqlDbType.Int,4),
					new SqlParameter("@EStu_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@OEA_StartTime", SqlDbType.DateTime),
					new SqlParameter("@OEA_EndTime", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamInt1", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt2", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamInt3", SqlDbType.Int,4),
					new SqlParameter("@OSCEExamString1", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString2", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamString3", SqlDbType.NVarChar,500),
					new SqlParameter("@OSCEExamDate1", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate2", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamDate3", SqlDbType.DateTime),
					new SqlParameter("@OSCEExamFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@OSCEExamFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@Room_ID", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamStationRoomString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamStationRoomDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamStationRoomFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamStationRoomFloat3", SqlDbType.Decimal,9)			};
            parameters[0].Value = U_ID;
            parameters[1].Value = E_ID;
            parameters[2].Value = EStu_ExamNumber;
            parameters[3].Value = EStu_int;
            parameters[4].Value = EStu_string;
            parameters[5].Value = EStu_bool;
            parameters[6].Value = OEA_ID;
            parameters[7].Value = EStu_ID;
            parameters[8].Value = ESR_ID;
            parameters[9].Value = OEA_StartTime;
            parameters[10].Value = OEA_EndTime;
            parameters[11].Value = OSCEExamInt1;
            parameters[12].Value = OSCEExamInt2;
            parameters[13].Value = OSCEExamInt3;
            parameters[14].Value = OSCEExamString1;
            parameters[15].Value = OSCEExamString2;
            parameters[16].Value = OSCEExamString3;
            parameters[17].Value = OSCEExamDate1;
            parameters[18].Value = OSCEExamDate2;
            parameters[19].Value = OSCEExamDate3;
            parameters[20].Value = OSCEExamFloat1;
            parameters[21].Value = OSCEExamFloat2;
            parameters[22].Value = OSCEExamFloat3;
            parameters[23].Value = ES_ID;
            parameters[24].Value = Room_ID;
            parameters[25].Value = ExamStationRoomInt1;
            parameters[26].Value = ExamStationRoomInt2;
            parameters[27].Value = ExamStationRoomInt3;
            parameters[28].Value = ExamStationRoomString1;
            parameters[29].Value = ExamStationRoomString2;
            parameters[30].Value = ExamStationRoomString3;
            parameters[31].Value = ExamStationRoomDate1;
            parameters[32].Value = ExamStationRoomDate2;
            parameters[33].Value = ExamStationRoomDate3;
            parameters[34].Value = ExamStationRoomFloat1;
            parameters[35].Value = ExamStationRoomFloat2;
            parameters[36].Value = ExamStationRoomFloat3;

            Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model = new Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView();
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
        public Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView DataRowToModel(DataRow row)
        {
            Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView model = new Tellyes.Model.OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView();
            if (row != null)
            {
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = new Guid(row["E_ID"].ToString());
                }
                if (row["EStu_ExamNumber"] != null && row["EStu_ExamNumber"].ToString() != "")
                {
                    model.EStu_ExamNumber = int.Parse(row["EStu_ExamNumber"].ToString());
                }
                if (row["EStu_int"] != null && row["EStu_int"].ToString() != "")
                {
                    model.EStu_int = int.Parse(row["EStu_int"].ToString());
                }
                if (row["EStu_string"] != null)
                {
                    model.EStu_string = row["EStu_string"].ToString();
                }
                if (row["EStu_bool"] != null && row["EStu_bool"].ToString() != "")
                {
                    if ((row["EStu_bool"].ToString() == "1") || (row["EStu_bool"].ToString().ToLower() == "true"))
                    {
                        model.EStu_bool = true;
                    }
                    else
                    {
                        model.EStu_bool = false;
                    }
                }
                if (row["OEA_ID"] != null && row["OEA_ID"].ToString() != "")
                {
                    model.OEA_ID = int.Parse(row["OEA_ID"].ToString());
                }
                if (row["EStu_ID"] != null && row["EStu_ID"].ToString() != "")
                {
                    model.EStu_ID = new Guid(row["EStu_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = new Guid(row["ESR_ID"].ToString());
                }
                if (row["OEA_StartTime"] != null && row["OEA_StartTime"].ToString() != "")
                {
                    model.OEA_StartTime = DateTime.Parse(row["OEA_StartTime"].ToString());
                }
                if (row["OEA_EndTime"] != null && row["OEA_EndTime"].ToString() != "")
                {
                    model.OEA_EndTime = DateTime.Parse(row["OEA_EndTime"].ToString());
                }
                if (row["OSCEExamInt1"] != null && row["OSCEExamInt1"].ToString() != "")
                {
                    model.OSCEExamInt1 = int.Parse(row["OSCEExamInt1"].ToString());
                }
                if (row["OSCEExamInt2"] != null && row["OSCEExamInt2"].ToString() != "")
                {
                    model.OSCEExamInt2 = int.Parse(row["OSCEExamInt2"].ToString());
                }
                if (row["OSCEExamInt3"] != null && row["OSCEExamInt3"].ToString() != "")
                {
                    model.OSCEExamInt3 = int.Parse(row["OSCEExamInt3"].ToString());
                }
                if (row["OSCEExamString1"] != null)
                {
                    model.OSCEExamString1 = row["OSCEExamString1"].ToString();
                }
                if (row["OSCEExamString2"] != null)
                {
                    model.OSCEExamString2 = row["OSCEExamString2"].ToString();
                }
                if (row["OSCEExamString3"] != null)
                {
                    model.OSCEExamString3 = row["OSCEExamString3"].ToString();
                }
                if (row["OSCEExamDate1"] != null && row["OSCEExamDate1"].ToString() != "")
                {
                    model.OSCEExamDate1 = DateTime.Parse(row["OSCEExamDate1"].ToString());
                }
                if (row["OSCEExamDate2"] != null && row["OSCEExamDate2"].ToString() != "")
                {
                    model.OSCEExamDate2 = DateTime.Parse(row["OSCEExamDate2"].ToString());
                }
                if (row["OSCEExamDate3"] != null && row["OSCEExamDate3"].ToString() != "")
                {
                    model.OSCEExamDate3 = DateTime.Parse(row["OSCEExamDate3"].ToString());
                }
                if (row["OSCEExamFloat1"] != null && row["OSCEExamFloat1"].ToString() != "")
                {
                    model.OSCEExamFloat1 = decimal.Parse(row["OSCEExamFloat1"].ToString());
                }
                if (row["OSCEExamFloat2"] != null && row["OSCEExamFloat2"].ToString() != "")
                {
                    model.OSCEExamFloat2 = decimal.Parse(row["OSCEExamFloat2"].ToString());
                }
                if (row["OSCEExamFloat3"] != null && row["OSCEExamFloat3"].ToString() != "")
                {
                    model.OSCEExamFloat3 = decimal.Parse(row["OSCEExamFloat3"].ToString());
                }
                if (row["ES_ID"] != null && row["ES_ID"].ToString() != "")
                {
                    model.ES_ID = new Guid(row["ES_ID"].ToString());
                }
                if (row["Room_ID"] != null && row["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(row["Room_ID"].ToString());
                }
                if (row["ExamStationRoomInt1"] != null && row["ExamStationRoomInt1"].ToString() != "")
                {
                    model.ExamStationRoomInt1 = int.Parse(row["ExamStationRoomInt1"].ToString());
                }
                if (row["ExamStationRoomInt2"] != null && row["ExamStationRoomInt2"].ToString() != "")
                {
                    model.ExamStationRoomInt2 = int.Parse(row["ExamStationRoomInt2"].ToString());
                }
                if (row["ExamStationRoomInt3"] != null && row["ExamStationRoomInt3"].ToString() != "")
                {
                    model.ExamStationRoomInt3 = int.Parse(row["ExamStationRoomInt3"].ToString());
                }
                if (row["ExamStationRoomString1"] != null)
                {
                    model.ExamStationRoomString1 = row["ExamStationRoomString1"].ToString();
                }
                if (row["ExamStationRoomString2"] != null)
                {
                    model.ExamStationRoomString2 = row["ExamStationRoomString2"].ToString();
                }
                if (row["ExamStationRoomString3"] != null)
                {
                    model.ExamStationRoomString3 = row["ExamStationRoomString3"].ToString();
                }
                if (row["ExamStationRoomDate1"] != null && row["ExamStationRoomDate1"].ToString() != "")
                {
                    model.ExamStationRoomDate1 = DateTime.Parse(row["ExamStationRoomDate1"].ToString());
                }
                if (row["ExamStationRoomDate2"] != null && row["ExamStationRoomDate2"].ToString() != "")
                {
                    model.ExamStationRoomDate2 = DateTime.Parse(row["ExamStationRoomDate2"].ToString());
                }
                if (row["ExamStationRoomDate3"] != null && row["ExamStationRoomDate3"].ToString() != "")
                {
                    model.ExamStationRoomDate3 = DateTime.Parse(row["ExamStationRoomDate3"].ToString());
                }
                if (row["ExamStationRoomFloat1"] != null && row["ExamStationRoomFloat1"].ToString() != "")
                {
                    model.ExamStationRoomFloat1 = decimal.Parse(row["ExamStationRoomFloat1"].ToString());
                }
                if (row["ExamStationRoomFloat2"] != null && row["ExamStationRoomFloat2"].ToString() != "")
                {
                    model.ExamStationRoomFloat2 = decimal.Parse(row["ExamStationRoomFloat2"].ToString());
                }
                if (row["ExamStationRoomFloat3"] != null && row["ExamStationRoomFloat3"].ToString() != "")
                {
                    model.ExamStationRoomFloat3 = decimal.Parse(row["ExamStationRoomFloat3"].ToString());
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
            strSql.Append("select U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool,OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,OSCEExamInt1,OSCEExamInt2,OSCEExamInt3,OSCEExamString1,OSCEExamString2,OSCEExamString3,OSCEExamDate1,OSCEExamDate2,OSCEExamDate3,OSCEExamFloat1,OSCEExamFloat2,OSCEExamFloat3,ES_ID,Room_ID,ExamStationRoomInt1,ExamStationRoomInt2,ExamStationRoomInt3,ExamStationRoomString1,ExamStationRoomString2,ExamStationRoomString3,ExamStationRoomDate1,ExamStationRoomDate2,ExamStationRoomDate3,ExamStationRoomFloat1,ExamStationRoomFloat2,ExamStationRoomFloat3 ");
            strSql.Append(" FROM OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView ");
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
            strSql.Append(" U_ID,E_ID,EStu_ExamNumber,EStu_int,EStu_string,EStu_bool,OEA_ID,EStu_ID,ESR_ID,OEA_StartTime,OEA_EndTime,OSCEExamInt1,OSCEExamInt2,OSCEExamInt3,OSCEExamString1,OSCEExamString2,OSCEExamString3,OSCEExamDate1,OSCEExamDate2,OSCEExamDate3,OSCEExamFloat1,OSCEExamFloat2,OSCEExamFloat3,ES_ID,Room_ID,ExamStationRoomInt1,ExamStationRoomInt2,ExamStationRoomInt3,ExamStationRoomString1,ExamStationRoomString2,ExamStationRoomString3,ExamStationRoomDate1,ExamStationRoomDate2,ExamStationRoomDate3,ExamStationRoomFloat1,ExamStationRoomFloat2,ExamStationRoomFloat3 ");
            strSql.Append(" FROM OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView ");
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
            strSql.Append("select count(1) FROM OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView ");
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
                strSql.Append("order by T.ExamStationRoomFloat3 desc");
            }
            strSql.Append(")AS Row, T.*  from OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView T ");
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
            parameters[0].Value = "OSCEExamArrangement_ExamStudent_ExamStationRoom_TableView";
            parameters[1].Value = "ExamStationRoomFloat3";
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
