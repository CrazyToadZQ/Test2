using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Tellyes.DBUtility;

namespace Tellyes.DAL
{
    /// <summary>
    /// 数据访问类:ExamUserExamTableView
    /// </summary>
    public partial class ExamUserExamTableView
    {
        public ExamUserExamTableView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamUserExamTableView");
            strSql.Append(" where E_ID=@E_ID and E_Name=@E_Name and E_StartTime=@E_StartTime and E_EndTime=@E_EndTime and E_CreateUser=@E_CreateUser and E_CreateTime=@E_CreateTime and E_ModifyTime=@E_ModifyTime and E_Kind=@E_Kind and E_OID=@E_OID and E_GID=@E_GID and E_NoStuID=@E_NoStuID and E_LongStationExamTimeNum=@E_LongStationExamTimeNum and E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum and E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum and E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum and E_State=@E_State and E_ZadokTheExaminer=@E_ZadokTheExaminer and E_IsOpenScore=@E_IsOpenScore and E_IsOpenVideo=@E_IsOpenVideo and ExamTableInt1=@ExamTableInt1 and ExamTableInt2=@ExamTableInt2 and ExamTableInt3=@ExamTableInt3 and ExamTableString1=@ExamTableString1 and ExamTableString2=@ExamTableString2 and ExamTableString3=@ExamTableString3 and ExamTableDate1=@ExamTableDate1 and ExamTableDate2=@ExamTableDate2 and ExamTableDate3=@ExamTableDate3 and ExamTableFloat1=@ExamTableFloat1 and ExamTableFloat2=@ExamTableFloat2 and ExamTableFloat3=@ExamTableFloat3 and EU_ISSP=@EU_ISSP and EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer and EU_ISReserve=@EU_ISReserve and U_ID=@U_ID and ESR_ID=@ESR_ID and ExamUserInt1=@ExamUserInt1 and ExamUserInt2=@ExamUserInt2 and ExamUserInt3=@ExamUserInt3 and ExamUserString1=@ExamUserString1 and ExamUserString2=@ExamUserString2 and ExamUserString3=@ExamUserString3 and ExamUserDate1=@ExamUserDate1 and ExamUserDate2=@ExamUserDate2 and ExamUserDate3=@ExamUserDate3 and ExamUserFloat1=@ExamUserFloat1 and ExamUserFloat2=@ExamUserFloat2 and ExamUserFloat3=@ExamUserFloat3 and EU_ID=@EU_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamTableString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamTableFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ExamUserInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamUserString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamUserFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)			};
            parameters[0].Value = E_ID;
            parameters[1].Value = E_Name;
            parameters[2].Value = E_StartTime;
            parameters[3].Value = E_EndTime;
            parameters[4].Value = E_CreateUser;
            parameters[5].Value = E_CreateTime;
            parameters[6].Value = E_ModifyTime;
            parameters[7].Value = E_Kind;
            parameters[8].Value = E_OID;
            parameters[9].Value = E_GID;
            parameters[10].Value = E_NoStuID;
            parameters[11].Value = E_LongStationExamTimeNum;
            parameters[12].Value = E_LongStationScoreTimeNum;
            parameters[13].Value = E_ShortStationExamTimeNum;
            parameters[14].Value = E_ShortStationScoreTimeNum;
            parameters[15].Value = E_State;
            parameters[16].Value = E_ZadokTheExaminer;
            parameters[17].Value = E_IsOpenScore;
            parameters[18].Value = E_IsOpenVideo;
            parameters[19].Value = ExamTableInt1;
            parameters[20].Value = ExamTableInt2;
            parameters[21].Value = ExamTableInt3;
            parameters[22].Value = ExamTableString1;
            parameters[23].Value = ExamTableString2;
            parameters[24].Value = ExamTableString3;
            parameters[25].Value = ExamTableDate1;
            parameters[26].Value = ExamTableDate2;
            parameters[27].Value = ExamTableDate3;
            parameters[28].Value = ExamTableFloat1;
            parameters[29].Value = ExamTableFloat2;
            parameters[30].Value = ExamTableFloat3;
            parameters[31].Value = EU_ISSP;
            parameters[32].Value = EU_ISZadokTheExaminer;
            parameters[33].Value = EU_ISReserve;
            parameters[34].Value = U_ID;
            parameters[35].Value = ESR_ID;
            parameters[36].Value = ExamUserInt1;
            parameters[37].Value = ExamUserInt2;
            parameters[38].Value = ExamUserInt3;
            parameters[39].Value = ExamUserString1;
            parameters[40].Value = ExamUserString2;
            parameters[41].Value = ExamUserString3;
            parameters[42].Value = ExamUserDate1;
            parameters[43].Value = ExamUserDate2;
            parameters[44].Value = ExamUserDate3;
            parameters[45].Value = ExamUserFloat1;
            parameters[46].Value = ExamUserFloat2;
            parameters[47].Value = ExamUserFloat3;
            parameters[48].Value = EU_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tellyes.Model.ExamUserExamTableView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamUserExamTableView(");
            strSql.Append("E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,ExamTableInt1,ExamTableInt2,ExamTableInt3,ExamTableString1,ExamTableString2,ExamTableString3,ExamTableDate1,ExamTableDate2,ExamTableDate3,ExamTableFloat1,ExamTableFloat2,ExamTableFloat3,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,U_ID,ESR_ID,ExamUserInt1,ExamUserInt2,ExamUserInt3,ExamUserString1,ExamUserString2,ExamUserString3,ExamUserDate1,ExamUserDate2,ExamUserDate3,ExamUserFloat1,ExamUserFloat2,ExamUserFloat3,EU_ID)");
            strSql.Append(" values (");
            strSql.Append("@E_ID,@E_Name,@E_StartTime,@E_EndTime,@E_CreateUser,@E_CreateTime,@E_ModifyTime,@E_Kind,@E_OID,@E_GID,@E_NoStuID,@E_LongStationExamTimeNum,@E_LongStationScoreTimeNum,@E_ShortStationExamTimeNum,@E_ShortStationScoreTimeNum,@E_State,@E_ZadokTheExaminer,@E_IsOpenScore,@E_IsOpenVideo,@ExamTableInt1,@ExamTableInt2,@ExamTableInt3,@ExamTableString1,@ExamTableString2,@ExamTableString3,@ExamTableDate1,@ExamTableDate2,@ExamTableDate3,@ExamTableFloat1,@ExamTableFloat2,@ExamTableFloat3,@EU_ISSP,@EU_ISZadokTheExaminer,@EU_ISReserve,@U_ID,@ESR_ID,@ExamUserInt1,@ExamUserInt2,@ExamUserInt3,@ExamUserString1,@ExamUserString2,@ExamUserString3,@ExamUserDate1,@ExamUserDate2,@ExamUserDate3,@ExamUserFloat1,@ExamUserFloat2,@ExamUserFloat3,@EU_ID)");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamTableString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamTableFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ExamUserInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamUserString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamUserFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.E_ID;
            parameters[1].Value = model.E_Name;
            parameters[2].Value = model.E_StartTime;
            parameters[3].Value = model.E_EndTime;
            parameters[4].Value = model.E_CreateUser;
            parameters[5].Value = model.E_CreateTime;
            parameters[6].Value = model.E_ModifyTime;
            parameters[7].Value = model.E_Kind;
            parameters[8].Value = model.E_OID;
            parameters[9].Value = model.E_GID;
            parameters[10].Value = model.E_NoStuID;
            parameters[11].Value = model.E_LongStationExamTimeNum;
            parameters[12].Value = model.E_LongStationScoreTimeNum;
            parameters[13].Value = model.E_ShortStationExamTimeNum;
            parameters[14].Value = model.E_ShortStationScoreTimeNum;
            parameters[15].Value = model.E_State;
            parameters[16].Value = model.E_ZadokTheExaminer;
            parameters[17].Value = model.E_IsOpenScore;
            parameters[18].Value = model.E_IsOpenVideo;
            parameters[19].Value = model.ExamTableInt1;
            parameters[20].Value = model.ExamTableInt2;
            parameters[21].Value = model.ExamTableInt3;
            parameters[22].Value = model.ExamTableString1;
            parameters[23].Value = model.ExamTableString2;
            parameters[24].Value = model.ExamTableString3;
            parameters[25].Value = model.ExamTableDate1;
            parameters[26].Value = model.ExamTableDate2;
            parameters[27].Value = model.ExamTableDate3;
            parameters[28].Value = model.ExamTableFloat1;
            parameters[29].Value = model.ExamTableFloat2;
            parameters[30].Value = model.ExamTableFloat3;
            parameters[31].Value = model.EU_ISSP;
            parameters[32].Value = model.EU_ISZadokTheExaminer;
            parameters[33].Value = model.EU_ISReserve;
            parameters[34].Value = model.U_ID;
            parameters[35].Value = model.ESR_ID;
            parameters[36].Value = model.ExamUserInt1;
            parameters[37].Value = model.ExamUserInt2;
            parameters[38].Value = model.ExamUserInt3;
            parameters[39].Value = model.ExamUserString1;
            parameters[40].Value = model.ExamUserString2;
            parameters[41].Value = model.ExamUserString3;
            parameters[42].Value = model.ExamUserDate1;
            parameters[43].Value = model.ExamUserDate2;
            parameters[44].Value = model.ExamUserDate3;
            parameters[45].Value = model.ExamUserFloat1;
            parameters[46].Value = model.ExamUserFloat2;
            parameters[47].Value = model.ExamUserFloat3;
            parameters[48].Value = model.EU_ID;

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
        public bool Update(Tellyes.Model.ExamUserExamTableView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamUserExamTableView set ");
            strSql.Append("E_ID=@E_ID,");
            strSql.Append("E_Name=@E_Name,");
            strSql.Append("E_StartTime=@E_StartTime,");
            strSql.Append("E_EndTime=@E_EndTime,");
            strSql.Append("E_CreateUser=@E_CreateUser,");
            strSql.Append("E_CreateTime=@E_CreateTime,");
            strSql.Append("E_ModifyTime=@E_ModifyTime,");
            strSql.Append("E_Kind=@E_Kind,");
            strSql.Append("E_OID=@E_OID,");
            strSql.Append("E_GID=@E_GID,");
            strSql.Append("E_NoStuID=@E_NoStuID,");
            strSql.Append("E_LongStationExamTimeNum=@E_LongStationExamTimeNum,");
            strSql.Append("E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum,");
            strSql.Append("E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum,");
            strSql.Append("E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum,");
            strSql.Append("E_State=@E_State,");
            strSql.Append("E_ZadokTheExaminer=@E_ZadokTheExaminer,");
            strSql.Append("E_IsOpenScore=@E_IsOpenScore,");
            strSql.Append("E_IsOpenVideo=@E_IsOpenVideo,");
            strSql.Append("ExamTableInt1=@ExamTableInt1,");
            strSql.Append("ExamTableInt2=@ExamTableInt2,");
            strSql.Append("ExamTableInt3=@ExamTableInt3,");
            strSql.Append("ExamTableString1=@ExamTableString1,");
            strSql.Append("ExamTableString2=@ExamTableString2,");
            strSql.Append("ExamTableString3=@ExamTableString3,");
            strSql.Append("ExamTableDate1=@ExamTableDate1,");
            strSql.Append("ExamTableDate2=@ExamTableDate2,");
            strSql.Append("ExamTableDate3=@ExamTableDate3,");
            strSql.Append("ExamTableFloat1=@ExamTableFloat1,");
            strSql.Append("ExamTableFloat2=@ExamTableFloat2,");
            strSql.Append("ExamTableFloat3=@ExamTableFloat3,");
            strSql.Append("EU_ISSP=@EU_ISSP,");
            strSql.Append("EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer,");
            strSql.Append("EU_ISReserve=@EU_ISReserve,");
            strSql.Append("U_ID=@U_ID,");
            strSql.Append("ESR_ID=@ESR_ID,");
            strSql.Append("ExamUserInt1=@ExamUserInt1,");
            strSql.Append("ExamUserInt2=@ExamUserInt2,");
            strSql.Append("ExamUserInt3=@ExamUserInt3,");
            strSql.Append("ExamUserString1=@ExamUserString1,");
            strSql.Append("ExamUserString2=@ExamUserString2,");
            strSql.Append("ExamUserString3=@ExamUserString3,");
            strSql.Append("ExamUserDate1=@ExamUserDate1,");
            strSql.Append("ExamUserDate2=@ExamUserDate2,");
            strSql.Append("ExamUserDate3=@ExamUserDate3,");
            strSql.Append("ExamUserFloat1=@ExamUserFloat1,");
            strSql.Append("ExamUserFloat2=@ExamUserFloat2,");
            strSql.Append("ExamUserFloat3=@ExamUserFloat3,");
            strSql.Append("EU_ID=@EU_ID");
            strSql.Append(" where E_ID=@E_ID and E_Name=@E_Name and E_StartTime=@E_StartTime and E_EndTime=@E_EndTime and E_CreateUser=@E_CreateUser and E_CreateTime=@E_CreateTime and E_ModifyTime=@E_ModifyTime and E_Kind=@E_Kind and E_OID=@E_OID and E_GID=@E_GID and E_NoStuID=@E_NoStuID and E_LongStationExamTimeNum=@E_LongStationExamTimeNum and E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum and E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum and E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum and E_State=@E_State and E_ZadokTheExaminer=@E_ZadokTheExaminer and E_IsOpenScore=@E_IsOpenScore and E_IsOpenVideo=@E_IsOpenVideo and ExamTableInt1=@ExamTableInt1 and ExamTableInt2=@ExamTableInt2 and ExamTableInt3=@ExamTableInt3 and ExamTableString1=@ExamTableString1 and ExamTableString2=@ExamTableString2 and ExamTableString3=@ExamTableString3 and ExamTableDate1=@ExamTableDate1 and ExamTableDate2=@ExamTableDate2 and ExamTableDate3=@ExamTableDate3 and ExamTableFloat1=@ExamTableFloat1 and ExamTableFloat2=@ExamTableFloat2 and ExamTableFloat3=@ExamTableFloat3 and EU_ISSP=@EU_ISSP and EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer and EU_ISReserve=@EU_ISReserve and U_ID=@U_ID and ESR_ID=@ESR_ID and ExamUserInt1=@ExamUserInt1 and ExamUserInt2=@ExamUserInt2 and ExamUserInt3=@ExamUserInt3 and ExamUserString1=@ExamUserString1 and ExamUserString2=@ExamUserString2 and ExamUserString3=@ExamUserString3 and ExamUserDate1=@ExamUserDate1 and ExamUserDate2=@ExamUserDate2 and ExamUserDate3=@ExamUserDate3 and ExamUserFloat1=@ExamUserFloat1 and ExamUserFloat2=@ExamUserFloat2 and ExamUserFloat3=@ExamUserFloat3 and EU_ID=@EU_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamTableString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamTableFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ExamUserInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamUserString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamUserFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)};
            parameters[0].Value = model.E_ID;
            parameters[1].Value = model.E_Name;
            parameters[2].Value = model.E_StartTime;
            parameters[3].Value = model.E_EndTime;
            parameters[4].Value = model.E_CreateUser;
            parameters[5].Value = model.E_CreateTime;
            parameters[6].Value = model.E_ModifyTime;
            parameters[7].Value = model.E_Kind;
            parameters[8].Value = model.E_OID;
            parameters[9].Value = model.E_GID;
            parameters[10].Value = model.E_NoStuID;
            parameters[11].Value = model.E_LongStationExamTimeNum;
            parameters[12].Value = model.E_LongStationScoreTimeNum;
            parameters[13].Value = model.E_ShortStationExamTimeNum;
            parameters[14].Value = model.E_ShortStationScoreTimeNum;
            parameters[15].Value = model.E_State;
            parameters[16].Value = model.E_ZadokTheExaminer;
            parameters[17].Value = model.E_IsOpenScore;
            parameters[18].Value = model.E_IsOpenVideo;
            parameters[19].Value = model.ExamTableInt1;
            parameters[20].Value = model.ExamTableInt2;
            parameters[21].Value = model.ExamTableInt3;
            parameters[22].Value = model.ExamTableString1;
            parameters[23].Value = model.ExamTableString2;
            parameters[24].Value = model.ExamTableString3;
            parameters[25].Value = model.ExamTableDate1;
            parameters[26].Value = model.ExamTableDate2;
            parameters[27].Value = model.ExamTableDate3;
            parameters[28].Value = model.ExamTableFloat1;
            parameters[29].Value = model.ExamTableFloat2;
            parameters[30].Value = model.ExamTableFloat3;
            parameters[31].Value = model.EU_ISSP;
            parameters[32].Value = model.EU_ISZadokTheExaminer;
            parameters[33].Value = model.EU_ISReserve;
            parameters[34].Value = model.U_ID;
            parameters[35].Value = model.ESR_ID;
            parameters[36].Value = model.ExamUserInt1;
            parameters[37].Value = model.ExamUserInt2;
            parameters[38].Value = model.ExamUserInt3;
            parameters[39].Value = model.ExamUserString1;
            parameters[40].Value = model.ExamUserString2;
            parameters[41].Value = model.ExamUserString3;
            parameters[42].Value = model.ExamUserDate1;
            parameters[43].Value = model.ExamUserDate2;
            parameters[44].Value = model.ExamUserDate3;
            parameters[45].Value = model.ExamUserFloat1;
            parameters[46].Value = model.ExamUserFloat2;
            parameters[47].Value = model.ExamUserFloat3;
            parameters[48].Value = model.EU_ID;

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
        public bool Delete(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamUserExamTableView ");
            strSql.Append(" where E_ID=@E_ID and E_Name=@E_Name and E_StartTime=@E_StartTime and E_EndTime=@E_EndTime and E_CreateUser=@E_CreateUser and E_CreateTime=@E_CreateTime and E_ModifyTime=@E_ModifyTime and E_Kind=@E_Kind and E_OID=@E_OID and E_GID=@E_GID and E_NoStuID=@E_NoStuID and E_LongStationExamTimeNum=@E_LongStationExamTimeNum and E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum and E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum and E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum and E_State=@E_State and E_ZadokTheExaminer=@E_ZadokTheExaminer and E_IsOpenScore=@E_IsOpenScore and E_IsOpenVideo=@E_IsOpenVideo and ExamTableInt1=@ExamTableInt1 and ExamTableInt2=@ExamTableInt2 and ExamTableInt3=@ExamTableInt3 and ExamTableString1=@ExamTableString1 and ExamTableString2=@ExamTableString2 and ExamTableString3=@ExamTableString3 and ExamTableDate1=@ExamTableDate1 and ExamTableDate2=@ExamTableDate2 and ExamTableDate3=@ExamTableDate3 and ExamTableFloat1=@ExamTableFloat1 and ExamTableFloat2=@ExamTableFloat2 and ExamTableFloat3=@ExamTableFloat3 and EU_ISSP=@EU_ISSP and EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer and EU_ISReserve=@EU_ISReserve and U_ID=@U_ID and ESR_ID=@ESR_ID and ExamUserInt1=@ExamUserInt1 and ExamUserInt2=@ExamUserInt2 and ExamUserInt3=@ExamUserInt3 and ExamUserString1=@ExamUserString1 and ExamUserString2=@ExamUserString2 and ExamUserString3=@ExamUserString3 and ExamUserDate1=@ExamUserDate1 and ExamUserDate2=@ExamUserDate2 and ExamUserDate3=@ExamUserDate3 and ExamUserFloat1=@ExamUserFloat1 and ExamUserFloat2=@ExamUserFloat2 and ExamUserFloat3=@ExamUserFloat3 and EU_ID=@EU_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamTableString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamTableFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ExamUserInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamUserString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamUserFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)			};
            parameters[0].Value = E_ID;
            parameters[1].Value = E_Name;
            parameters[2].Value = E_StartTime;
            parameters[3].Value = E_EndTime;
            parameters[4].Value = E_CreateUser;
            parameters[5].Value = E_CreateTime;
            parameters[6].Value = E_ModifyTime;
            parameters[7].Value = E_Kind;
            parameters[8].Value = E_OID;
            parameters[9].Value = E_GID;
            parameters[10].Value = E_NoStuID;
            parameters[11].Value = E_LongStationExamTimeNum;
            parameters[12].Value = E_LongStationScoreTimeNum;
            parameters[13].Value = E_ShortStationExamTimeNum;
            parameters[14].Value = E_ShortStationScoreTimeNum;
            parameters[15].Value = E_State;
            parameters[16].Value = E_ZadokTheExaminer;
            parameters[17].Value = E_IsOpenScore;
            parameters[18].Value = E_IsOpenVideo;
            parameters[19].Value = ExamTableInt1;
            parameters[20].Value = ExamTableInt2;
            parameters[21].Value = ExamTableInt3;
            parameters[22].Value = ExamTableString1;
            parameters[23].Value = ExamTableString2;
            parameters[24].Value = ExamTableString3;
            parameters[25].Value = ExamTableDate1;
            parameters[26].Value = ExamTableDate2;
            parameters[27].Value = ExamTableDate3;
            parameters[28].Value = ExamTableFloat1;
            parameters[29].Value = ExamTableFloat2;
            parameters[30].Value = ExamTableFloat3;
            parameters[31].Value = EU_ISSP;
            parameters[32].Value = EU_ISZadokTheExaminer;
            parameters[33].Value = EU_ISReserve;
            parameters[34].Value = U_ID;
            parameters[35].Value = ESR_ID;
            parameters[36].Value = ExamUserInt1;
            parameters[37].Value = ExamUserInt2;
            parameters[38].Value = ExamUserInt3;
            parameters[39].Value = ExamUserString1;
            parameters[40].Value = ExamUserString2;
            parameters[41].Value = ExamUserString3;
            parameters[42].Value = ExamUserDate1;
            parameters[43].Value = ExamUserDate2;
            parameters[44].Value = ExamUserDate3;
            parameters[45].Value = ExamUserFloat1;
            parameters[46].Value = ExamUserFloat2;
            parameters[47].Value = ExamUserFloat3;
            parameters[48].Value = EU_ID;

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
        public Tellyes.Model.ExamUserExamTableView GetModel(int E_ID, string E_Name, DateTime E_StartTime, DateTime E_EndTime, string E_CreateUser, DateTime E_CreateTime, DateTime E_ModifyTime, int E_Kind, string E_OID, string E_GID, string E_NoStuID, int E_LongStationExamTimeNum, int E_LongStationScoreTimeNum, int E_ShortStationExamTimeNum, int E_ShortStationScoreTimeNum, int E_State, string E_ZadokTheExaminer, int E_IsOpenScore, int E_IsOpenVideo, int ExamTableInt1, int ExamTableInt2, int ExamTableInt3, string ExamTableString1, string ExamTableString2, string ExamTableString3, DateTime ExamTableDate1, DateTime ExamTableDate2, DateTime ExamTableDate3, decimal ExamTableFloat1, decimal ExamTableFloat2, decimal ExamTableFloat3, int EU_ISSP, int EU_ISZadokTheExaminer, int EU_ISReserve, int U_ID, int ESR_ID, int ExamUserInt1, int ExamUserInt2, int ExamUserInt3, string ExamUserString1, string ExamUserString2, string ExamUserString3, DateTime ExamUserDate1, DateTime ExamUserDate2, DateTime ExamUserDate3, decimal ExamUserFloat1, decimal ExamUserFloat2, decimal ExamUserFloat3, int EU_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,ExamTableInt1,ExamTableInt2,ExamTableInt3,ExamTableString1,ExamTableString2,ExamTableString3,ExamTableDate1,ExamTableDate2,ExamTableDate3,ExamTableFloat1,ExamTableFloat2,ExamTableFloat3,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,U_ID,ESR_ID,ExamUserInt1,ExamUserInt2,ExamUserInt3,ExamUserString1,ExamUserString2,ExamUserString3,ExamUserDate1,ExamUserDate2,ExamUserDate3,ExamUserFloat1,ExamUserFloat2,ExamUserFloat3,EU_ID from ExamUserExamTableView ");
            strSql.Append(" where E_ID=@E_ID and E_Name=@E_Name and E_StartTime=@E_StartTime and E_EndTime=@E_EndTime and E_CreateUser=@E_CreateUser and E_CreateTime=@E_CreateTime and E_ModifyTime=@E_ModifyTime and E_Kind=@E_Kind and E_OID=@E_OID and E_GID=@E_GID and E_NoStuID=@E_NoStuID and E_LongStationExamTimeNum=@E_LongStationExamTimeNum and E_LongStationScoreTimeNum=@E_LongStationScoreTimeNum and E_ShortStationExamTimeNum=@E_ShortStationExamTimeNum and E_ShortStationScoreTimeNum=@E_ShortStationScoreTimeNum and E_State=@E_State and E_ZadokTheExaminer=@E_ZadokTheExaminer and E_IsOpenScore=@E_IsOpenScore and E_IsOpenVideo=@E_IsOpenVideo and ExamTableInt1=@ExamTableInt1 and ExamTableInt2=@ExamTableInt2 and ExamTableInt3=@ExamTableInt3 and ExamTableString1=@ExamTableString1 and ExamTableString2=@ExamTableString2 and ExamTableString3=@ExamTableString3 and ExamTableDate1=@ExamTableDate1 and ExamTableDate2=@ExamTableDate2 and ExamTableDate3=@ExamTableDate3 and ExamTableFloat1=@ExamTableFloat1 and ExamTableFloat2=@ExamTableFloat2 and ExamTableFloat3=@ExamTableFloat3 and EU_ISSP=@EU_ISSP and EU_ISZadokTheExaminer=@EU_ISZadokTheExaminer and EU_ISReserve=@EU_ISReserve and U_ID=@U_ID and ESR_ID=@ESR_ID and ExamUserInt1=@ExamUserInt1 and ExamUserInt2=@ExamUserInt2 and ExamUserInt3=@ExamUserInt3 and ExamUserString1=@ExamUserString1 and ExamUserString2=@ExamUserString2 and ExamUserString3=@ExamUserString3 and ExamUserDate1=@ExamUserDate1 and ExamUserDate2=@ExamUserDate2 and ExamUserDate3=@ExamUserDate3 and ExamUserFloat1=@ExamUserFloat1 and ExamUserFloat2=@ExamUserFloat2 and ExamUserFloat3=@ExamUserFloat3 and EU_ID=@EU_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@E_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_StartTime", SqlDbType.DateTime),
					new SqlParameter("@E_EndTime", SqlDbType.DateTime),
					new SqlParameter("@E_CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@E_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@E_Kind", SqlDbType.Int,4),
					new SqlParameter("@E_OID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_GID", SqlDbType.VarChar,5000),
					new SqlParameter("@E_NoStuID", SqlDbType.VarChar,8000),
					new SqlParameter("@E_LongStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_LongStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationExamTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_ShortStationScoreTimeNum", SqlDbType.Int,4),
					new SqlParameter("@E_State", SqlDbType.Int,4),
					new SqlParameter("@E_ZadokTheExaminer", SqlDbType.VarChar,50),
					new SqlParameter("@E_IsOpenScore", SqlDbType.Int,4),
					new SqlParameter("@E_IsOpenVideo", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamTableInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamTableString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamTableDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamTableDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamTableFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamTableFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ISSP", SqlDbType.Int,4),
					new SqlParameter("@EU_ISZadokTheExaminer", SqlDbType.Int,4),
					new SqlParameter("@EU_ISReserve", SqlDbType.Int,4),
					new SqlParameter("@U_ID", SqlDbType.Int,4),
					new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,32),
					new SqlParameter("@ExamUserInt1", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt2", SqlDbType.Int,4),
					new SqlParameter("@ExamUserInt3", SqlDbType.Int,4),
					new SqlParameter("@ExamUserString1", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString2", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserString3", SqlDbType.NVarChar,500),
					new SqlParameter("@ExamUserDate1", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate2", SqlDbType.DateTime),
					new SqlParameter("@ExamUserDate3", SqlDbType.DateTime),
					new SqlParameter("@ExamUserFloat1", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat2", SqlDbType.Decimal,9),
					new SqlParameter("@ExamUserFloat3", SqlDbType.Decimal,9),
					new SqlParameter("@EU_ID", SqlDbType.UniqueIdentifier,32)			};
            parameters[0].Value = E_ID;
            parameters[1].Value = E_Name;
            parameters[2].Value = E_StartTime;
            parameters[3].Value = E_EndTime;
            parameters[4].Value = E_CreateUser;
            parameters[5].Value = E_CreateTime;
            parameters[6].Value = E_ModifyTime;
            parameters[7].Value = E_Kind;
            parameters[8].Value = E_OID;
            parameters[9].Value = E_GID;
            parameters[10].Value = E_NoStuID;
            parameters[11].Value = E_LongStationExamTimeNum;
            parameters[12].Value = E_LongStationScoreTimeNum;
            parameters[13].Value = E_ShortStationExamTimeNum;
            parameters[14].Value = E_ShortStationScoreTimeNum;
            parameters[15].Value = E_State;
            parameters[16].Value = E_ZadokTheExaminer;
            parameters[17].Value = E_IsOpenScore;
            parameters[18].Value = E_IsOpenVideo;
            parameters[19].Value = ExamTableInt1;
            parameters[20].Value = ExamTableInt2;
            parameters[21].Value = ExamTableInt3;
            parameters[22].Value = ExamTableString1;
            parameters[23].Value = ExamTableString2;
            parameters[24].Value = ExamTableString3;
            parameters[25].Value = ExamTableDate1;
            parameters[26].Value = ExamTableDate2;
            parameters[27].Value = ExamTableDate3;
            parameters[28].Value = ExamTableFloat1;
            parameters[29].Value = ExamTableFloat2;
            parameters[30].Value = ExamTableFloat3;
            parameters[31].Value = EU_ISSP;
            parameters[32].Value = EU_ISZadokTheExaminer;
            parameters[33].Value = EU_ISReserve;
            parameters[34].Value = U_ID;
            parameters[35].Value = ESR_ID;
            parameters[36].Value = ExamUserInt1;
            parameters[37].Value = ExamUserInt2;
            parameters[38].Value = ExamUserInt3;
            parameters[39].Value = ExamUserString1;
            parameters[40].Value = ExamUserString2;
            parameters[41].Value = ExamUserString3;
            parameters[42].Value = ExamUserDate1;
            parameters[43].Value = ExamUserDate2;
            parameters[44].Value = ExamUserDate3;
            parameters[45].Value = ExamUserFloat1;
            parameters[46].Value = ExamUserFloat2;
            parameters[47].Value = ExamUserFloat3;
            parameters[48].Value = EU_ID;

            Tellyes.Model.ExamUserExamTableView model = new Tellyes.Model.ExamUserExamTableView();
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
        public Tellyes.Model.ExamUserExamTableView DataRowToModel(DataRow row)
        {
            Tellyes.Model.ExamUserExamTableView model = new Tellyes.Model.ExamUserExamTableView();
            if (row != null)
            {
                if (row["E_ID"] != null && row["E_ID"].ToString() != "")
                {
                    model.E_ID = int.Parse(row["E_ID"].ToString());
                }
                if (row["E_Name"] != null)
                {
                    model.E_Name = row["E_Name"].ToString();
                }
                if (row["E_StartTime"] != null && row["E_StartTime"].ToString() != "")
                {
                    model.E_StartTime = DateTime.Parse(row["E_StartTime"].ToString());
                }
                if (row["E_EndTime"] != null && row["E_EndTime"].ToString() != "")
                {
                    model.E_EndTime = DateTime.Parse(row["E_EndTime"].ToString());
                }
                if (row["E_CreateUser"] != null)
                {
                    model.E_CreateUser = row["E_CreateUser"].ToString();
                }
                if (row["E_CreateTime"] != null && row["E_CreateTime"].ToString() != "")
                {
                    model.E_CreateTime = DateTime.Parse(row["E_CreateTime"].ToString());
                }
                if (row["E_ModifyTime"] != null && row["E_ModifyTime"].ToString() != "")
                {
                    model.E_ModifyTime = DateTime.Parse(row["E_ModifyTime"].ToString());
                }
                if (row["E_Kind"] != null && row["E_Kind"].ToString() != "")
                {
                    model.E_Kind = int.Parse(row["E_Kind"].ToString());
                }
                if (row["E_OID"] != null)
                {
                    model.E_OID = row["E_OID"].ToString();
                }
                if (row["E_GID"] != null)
                {
                    model.E_GID = row["E_GID"].ToString();
                }
                if (row["E_NoStuID"] != null)
                {
                    model.E_NoStuID = row["E_NoStuID"].ToString();
                }
                if (row["E_LongStationExamTimeNum"] != null && row["E_LongStationExamTimeNum"].ToString() != "")
                {
                    model.E_LongStationExamTimeNum = int.Parse(row["E_LongStationExamTimeNum"].ToString());
                }
                if (row["E_LongStationScoreTimeNum"] != null && row["E_LongStationScoreTimeNum"].ToString() != "")
                {
                    model.E_LongStationScoreTimeNum = int.Parse(row["E_LongStationScoreTimeNum"].ToString());
                }
                if (row["E_ShortStationExamTimeNum"] != null && row["E_ShortStationExamTimeNum"].ToString() != "")
                {
                    model.E_ShortStationExamTimeNum = int.Parse(row["E_ShortStationExamTimeNum"].ToString());
                }
                if (row["E_ShortStationScoreTimeNum"] != null && row["E_ShortStationScoreTimeNum"].ToString() != "")
                {
                    model.E_ShortStationScoreTimeNum = int.Parse(row["E_ShortStationScoreTimeNum"].ToString());
                }
                if (row["E_State"] != null && row["E_State"].ToString() != "")
                {
                    model.E_State = int.Parse(row["E_State"].ToString());
                }
                if (row["E_ZadokTheExaminer"] != null)
                {
                    model.E_ZadokTheExaminer = row["E_ZadokTheExaminer"].ToString();
                }
                if (row["E_IsOpenScore"] != null && row["E_IsOpenScore"].ToString() != "")
                {
                    model.E_IsOpenScore = int.Parse(row["E_IsOpenScore"].ToString());
                }
                if (row["E_IsOpenVideo"] != null && row["E_IsOpenVideo"].ToString() != "")
                {
                    model.E_IsOpenVideo = int.Parse(row["E_IsOpenVideo"].ToString());
                }
                if (row["ExamTableInt1"] != null && row["ExamTableInt1"].ToString() != "")
                {
                    model.ExamTableInt1 = int.Parse(row["ExamTableInt1"].ToString());
                }
                if (row["ExamTableInt2"] != null && row["ExamTableInt2"].ToString() != "")
                {
                    model.ExamTableInt2 = int.Parse(row["ExamTableInt2"].ToString());
                }
                if (row["ExamTableInt3"] != null && row["ExamTableInt3"].ToString() != "")
                {
                    model.ExamTableInt3 = int.Parse(row["ExamTableInt3"].ToString());
                }
                if (row["ExamTableString1"] != null)
                {
                    model.ExamTableString1 = row["ExamTableString1"].ToString();
                }
                if (row["ExamTableString2"] != null)
                {
                    model.ExamTableString2 = row["ExamTableString2"].ToString();
                }
                if (row["ExamTableString3"] != null)
                {
                    model.ExamTableString3 = row["ExamTableString3"].ToString();
                }
                if (row["ExamTableDate1"] != null && row["ExamTableDate1"].ToString() != "")
                {
                    model.ExamTableDate1 = DateTime.Parse(row["ExamTableDate1"].ToString());
                }
                if (row["ExamTableDate2"] != null && row["ExamTableDate2"].ToString() != "")
                {
                    model.ExamTableDate2 = DateTime.Parse(row["ExamTableDate2"].ToString());
                }
                if (row["ExamTableDate3"] != null && row["ExamTableDate3"].ToString() != "")
                {
                    model.ExamTableDate3 = DateTime.Parse(row["ExamTableDate3"].ToString());
                }
                if (row["ExamTableFloat1"] != null && row["ExamTableFloat1"].ToString() != "")
                {
                    model.ExamTableFloat1 = decimal.Parse(row["ExamTableFloat1"].ToString());
                }
                if (row["ExamTableFloat2"] != null && row["ExamTableFloat2"].ToString() != "")
                {
                    model.ExamTableFloat2 = decimal.Parse(row["ExamTableFloat2"].ToString());
                }
                if (row["ExamTableFloat3"] != null && row["ExamTableFloat3"].ToString() != "")
                {
                    model.ExamTableFloat3 = decimal.Parse(row["ExamTableFloat3"].ToString());
                }
                if (row["EU_ISSP"] != null && row["EU_ISSP"].ToString() != "")
                {
                    model.EU_ISSP = int.Parse(row["EU_ISSP"].ToString());
                }
                if (row["EU_ISZadokTheExaminer"] != null && row["EU_ISZadokTheExaminer"].ToString() != "")
                {
                    model.EU_ISZadokTheExaminer = int.Parse(row["EU_ISZadokTheExaminer"].ToString());
                }
                if (row["EU_ISReserve"] != null && row["EU_ISReserve"].ToString() != "")
                {
                    model.EU_ISReserve = int.Parse(row["EU_ISReserve"].ToString());
                }
                if (row["U_ID"] != null && row["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(row["U_ID"].ToString());
                }
                if (row["ESR_ID"] != null && row["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = int.Parse(row["ESR_ID"].ToString());
                }
                if (row["ExamUserInt1"] != null && row["ExamUserInt1"].ToString() != "")
                {
                    model.ExamUserInt1 = int.Parse(row["ExamUserInt1"].ToString());
                }
                if (row["ExamUserInt2"] != null && row["ExamUserInt2"].ToString() != "")
                {
                    model.ExamUserInt2 = int.Parse(row["ExamUserInt2"].ToString());
                }
                if (row["ExamUserInt3"] != null && row["ExamUserInt3"].ToString() != "")
                {
                    model.ExamUserInt3 = int.Parse(row["ExamUserInt3"].ToString());
                }
                if (row["ExamUserString1"] != null)
                {
                    model.ExamUserString1 = row["ExamUserString1"].ToString();
                }
                if (row["ExamUserString2"] != null)
                {
                    model.ExamUserString2 = row["ExamUserString2"].ToString();
                }
                if (row["ExamUserString3"] != null)
                {
                    model.ExamUserString3 = row["ExamUserString3"].ToString();
                }
                if (row["ExamUserDate1"] != null && row["ExamUserDate1"].ToString() != "")
                {
                    model.ExamUserDate1 = DateTime.Parse(row["ExamUserDate1"].ToString());
                }
                if (row["ExamUserDate2"] != null && row["ExamUserDate2"].ToString() != "")
                {
                    model.ExamUserDate2 = DateTime.Parse(row["ExamUserDate2"].ToString());
                }
                if (row["ExamUserDate3"] != null && row["ExamUserDate3"].ToString() != "")
                {
                    model.ExamUserDate3 = DateTime.Parse(row["ExamUserDate3"].ToString());
                }
                if (row["ExamUserFloat1"] != null && row["ExamUserFloat1"].ToString() != "")
                {
                    model.ExamUserFloat1 = decimal.Parse(row["ExamUserFloat1"].ToString());
                }
                if (row["ExamUserFloat2"] != null && row["ExamUserFloat2"].ToString() != "")
                {
                    model.ExamUserFloat2 = decimal.Parse(row["ExamUserFloat2"].ToString());
                }
                if (row["ExamUserFloat3"] != null && row["ExamUserFloat3"].ToString() != "")
                {
                    model.ExamUserFloat3 = decimal.Parse(row["ExamUserFloat3"].ToString());
                }
                if (row["EU_ID"] != null && row["EU_ID"].ToString() != "")
                {
                    model.EU_ID = int.Parse(row["EU_ID"].ToString());
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
            strSql.Append("select E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,ExamTableInt1,ExamTableInt2,ExamTableInt3,ExamTableString1,ExamTableString2,ExamTableString3,ExamTableDate1,ExamTableDate2,ExamTableDate3,ExamTableFloat1,ExamTableFloat2,ExamTableFloat3,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,U_ID,ESR_ID,ExamUserInt1,ExamUserInt2,ExamUserInt3,ExamUserString1,ExamUserString2,ExamUserString3,ExamUserDate1,ExamUserDate2,ExamUserDate3,ExamUserFloat1,ExamUserFloat2,ExamUserFloat3,EU_ID ");
            strSql.Append(" FROM ExamUserExamTableView ");
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
            strSql.Append(" E_ID,E_Name,E_StartTime,E_EndTime,E_CreateUser,E_CreateTime,E_ModifyTime,E_Kind,E_OID,E_GID,E_NoStuID,E_LongStationExamTimeNum,E_LongStationScoreTimeNum,E_ShortStationExamTimeNum,E_ShortStationScoreTimeNum,E_State,E_ZadokTheExaminer,E_IsOpenScore,E_IsOpenVideo,ExamTableInt1,ExamTableInt2,ExamTableInt3,ExamTableString1,ExamTableString2,ExamTableString3,ExamTableDate1,ExamTableDate2,ExamTableDate3,ExamTableFloat1,ExamTableFloat2,ExamTableFloat3,EU_ISSP,EU_ISZadokTheExaminer,EU_ISReserve,U_ID,ESR_ID,ExamUserInt1,ExamUserInt2,ExamUserInt3,ExamUserString1,ExamUserString2,ExamUserString3,ExamUserDate1,ExamUserDate2,ExamUserDate3,ExamUserFloat1,ExamUserFloat2,ExamUserFloat3,EU_ID ");
            strSql.Append(" FROM ExamUserExamTableView ");
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
            strSql.Append("select count(1) FROM ExamUserExamTableView ");
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
                strSql.Append("order by T.EU_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExamUserExamTableView T ");
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
            parameters[0].Value = "ExamUserExamTableView";
            parameters[1].Value = "EU_ID";
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
        /// 获得系统当前时间 距离“Time”的时间差，以“天”为单位
        /// </summary>
        public int GetRemainingDays(DateTime Time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Datediff(d,getdate(),'" + Time + "')");
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
        }

        /// <summary>
        /// 获得在系统当前时间基础上 增加固定的天数后 的新时间
        /// </summary>
        /// <param name="Days"></param>
        /// <returns></returns>
        public DateTime GetNewTime(int Days)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select dateadd(DAY," + Days + ",getdate())");
            return Convert.ToDateTime(DbHelperSQL.GetSingle(strSql.ToString()));
        }

        /// <summary>
        /// 获取系统当前时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetNowTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select getdate()");
            return Convert.ToDateTime(DbHelperSQL.GetSingle(strSql.ToString()));
        }

        #endregion  ExtensionMethod
    }
}
