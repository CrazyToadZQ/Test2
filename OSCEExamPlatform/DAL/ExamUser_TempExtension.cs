using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace Tellyes.DAL
{
    public static class ExamUser_TempExtension
    {
        private static Tellyes.DAL.ExamUser dalEU = new Tellyes.DAL.ExamUser();

        public static DataTable GetExistedJuryOrSP(this Tellyes.DAL.ExamUser self,string E_ID,bool isSP,bool isGovernor,bool isReserve) 
        {
            StringBuilder sql = new StringBuilder();
            if (isSP)
            {
                //SP
                sql.Append(" select distinct eu.*,ui.U_TrueName,ui.U_Title,ui.U_GoodField from dbo.ExamUser as eu join  UserInfo as ui on eu.U_ID=ui.U_ID where E_ID='" + E_ID + "' and EU_ISSP='1' ");
            }
            else
            {
                if (isGovernor)
                { 
                    //督考
                    sql.Append(" select distinct eu.*,ui.U_TrueName,ui.U_Title,ui.U_GoodField from dbo.ExamUser as eu join  UserInfo as ui on eu.U_ID=ui.U_ID where E_ID='" + E_ID + "' and EU_ISZadokTheExaminer='1' ");
                }
                else
                {
                    //评委
                    sql.Append(" select distinct eu.*,ui.U_TrueName,ui.U_Title,ui.U_GoodField from dbo.ExamUser as eu join  UserInfo as ui on eu.U_ID=ui.U_ID where E_ID='" + E_ID + "' and EU_ISSP='0' ");
                }
            }
            if (isReserve)
            {
                sql.Append(" and EU_ISReserve='1' ");
            }
            else
            {
                sql.Append(" and EU_ISReserve='0' ");
            }
            sql.Append(" ; ");
            return DbHelperSQL.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 将一个评委，设为督考
        /// </summary>
        /// <param name="EU_ID"></param>
        public static void SetVerifierToOneEU(this Tellyes.DAL.ExamUser self, string EU_ID, string EU_ISZadokTheExaminer)
        {
            string sql = " update ExamUser set EU_ISZadokTheExaminer='" + EU_ISZadokTheExaminer + "' where EU_ID='" + EU_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        //清除已存在，后备评委
        public static void ClearPreparingJury(this Tellyes.DAL.ExamUser self,string E_ID) 
        {
            string sql = " delete from ExamUser where E_ID='" + E_ID + "' and EU_ISSP='0' and EU_ISReserve='1'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        //清除已存在，后备评委
        public static void ClearPreparingSP(this Tellyes.DAL.ExamUser self, string E_ID)
        {
            string sql = " delete from ExamUser where E_ID='" + E_ID + "' and EU_ISSP='1' and EU_ISReserve='1'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        //获得某考试中所有相关评委和SP
        public static DataTable GetExameUsersInOneExame(this Tellyes.DAL.ExamUser self, string E_ID)
        {
            string sql = "  select distinct eu.*,ui.U_TrueName,ui.U_Title,ui.U_GoodField from dbo.ExamUser as eu join  UserInfo as ui on eu.U_ID=ui.U_ID where E_ID='" + E_ID + "' order by EU_ISSP ,EU_ISZadokTheExaminer desc,EU_ISReserve; ";
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获得指定房间的评委或SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="ES_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public static DataTable GetExameUsersInSpecialRoom(this Tellyes.DAL.ExamUser self, string E_ID, string ESR_ID, bool isSP = false)
        {
            DataTable source = dalEU.GetExistedJuryOrSP(E_ID, isSP, false, false);
            DataTable result = source.Clone();
            DataRow[] rows = source.Select(" ESR_ID='" + ESR_ID + "' ");
            foreach(DataRow row in rows)
            {
                result.Rows.Add(row.ItemArray);
            }
            return result;
        }

        /// <summary>
        /// 为指定评委，更新 远程 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateInt1Int2ForSpecialEU(this Tellyes.DAL.ExamUser self, string int1, string int2, string EU_ID)
        {
            string sql = " update ExamUser set int1='" + int1 + "',int2='3' where EU_ID='" + EU_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 为指定评委，更新 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateOnlyInt1ForSpecialEU(this Tellyes.DAL.ExamUser self, string int1, string EU_ID)
        {
            string sql = " update ExamUser set int1='" + int1 + "',int2='2' where EU_ID='" + EU_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 为指定SP，更新 权重
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void UpdateOnlyInt1ForSpecialEU_SP(this Tellyes.DAL.ExamUser self, string int1, string EU_ID)
        {
            string sql = " update ExamUser set int1='" + int1 + "' where EU_ID='" + EU_ID + "'; ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 项某考站的房间内，添加一名评委
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        public static void AddScoreJuryToOneExam(this Tellyes.DAL.ExamUser self, string E_ID, string U_ID, string ESR_ID, string int1 = "0", string int2 = "2") 
        {
            string sql = " insert into ExamUser (E_ID,U_ID,ESR_ID,int1,int2) values('" + E_ID + "','" + U_ID + "','" + ESR_ID + "','" + int1 + "','" + int2 + "'); ";
            DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 项某考站的房间内，添加一名SP
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="U_ID"></param>
        /// <param name="ESR_ID"></param>
        /// <param name="int1"></param>
        public static void AddScoreSPToOneExam(this Tellyes.DAL.ExamUser self, string E_ID, string U_ID, string ESR_ID, string int1 = "0")
        {
            string sql = " insert into ExamUser (E_ID,EU_ISSP,U_ID,ESR_ID,int1) values('" + E_ID + "','1','" + U_ID + "','" + ESR_ID + "','" + int1 + "'); ";
            DbHelperSQL.ExecuteSql(sql);
        }
    }
}
