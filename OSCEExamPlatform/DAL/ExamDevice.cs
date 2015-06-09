using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Tellyes.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;


namespace Tellyes.DAL
{
    public partial class ExamDevice : BaseDAL<Model.ExamDevice>
    {
        public ExamDevice()
        { }

        #region  BasicMethod
        public bool Exists(Guid ExamDeviceID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExamDevice");
            strSql.Append(" where ");
            strSql.Append(" ExamDeviceID = @ExamDeviceID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamDeviceID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ExamDeviceID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Tellyes.Model.ExamDevice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExamDevice(");
            strSql.Append("ExamDeviceID,ExamDeviceCreateTime,ExamDeviceNumber1,ExamDeviceNumber2,ExamDeviceNumber3,ExamDeviceNumber4,ExamDeviceString1,ExamDeviceString2,ExamDeviceString3,ExamDeviceString4,ExamDeviceDateTime1,E_ID,ExamDeviceDateTime2,ES_ID,ESR_ID,Room_ID,D_ID,DC_ID,D_Manufacturer,U_ID");
            strSql.Append(") values (");
            strSql.Append("@ExamDeviceID,@ExamDeviceCreateTime,@ExamDeviceNumber1,@ExamDeviceNumber2,@ExamDeviceNumber3,@ExamDeviceNumber4,@ExamDeviceString1,@ExamDeviceString2,@ExamDeviceString3,@ExamDeviceString4,@ExamDeviceDateTime1,@E_ID,@ExamDeviceDateTime2,@ES_ID,@ESR_ID,@Room_ID,@D_ID,@DC_ID,@D_Manufacturer,@U_ID");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ExamDeviceID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamDeviceCreateTime", SqlDbType.DateTime,3) ,            
                        new SqlParameter("@ExamDeviceNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamDeviceNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamDeviceNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@ExamDeviceNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@ExamDeviceString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamDeviceString2", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ExamDeviceString3", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@ExamDeviceString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExamDeviceDateTime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamDeviceDateTime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Room_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@D_Manufacturer", SqlDbType.Int,4) ,            
                        new SqlParameter("@U_ID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.ExamDeviceCreateTime;
            parameters[2].Value = model.ExamDeviceNumber1;
            parameters[3].Value = model.ExamDeviceNumber2;
            parameters[4].Value = model.ExamDeviceNumber3;
            parameters[5].Value = model.ExamDeviceNumber4;
            parameters[6].Value = model.ExamDeviceString1;
            parameters[7].Value = model.ExamDeviceString2;
            parameters[8].Value = model.ExamDeviceString3;
            parameters[9].Value = model.ExamDeviceString4;
            parameters[10].Value = model.ExamDeviceDateTime1;
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.ExamDeviceDateTime2;
            parameters[13].Value = Guid.NewGuid();
            parameters[14].Value = Guid.NewGuid();
            parameters[15].Value = Guid.NewGuid();
            parameters[16].Value = model.D_ID;
            parameters[17].Value = model.DC_ID;
            parameters[18].Value = model.D_Manufacturer;
            parameters[19].Value = model.U_ID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tellyes.Model.ExamDevice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExamDevice set ");

            strSql.Append(" ExamDeviceID = @ExamDeviceID , ");
            strSql.Append(" ExamDeviceCreateTime = @ExamDeviceCreateTime , ");
            strSql.Append(" ExamDeviceNumber1 = @ExamDeviceNumber1 , ");
            strSql.Append(" ExamDeviceNumber2 = @ExamDeviceNumber2 , ");
            strSql.Append(" ExamDeviceNumber3 = @ExamDeviceNumber3 , ");
            strSql.Append(" ExamDeviceNumber4 = @ExamDeviceNumber4 , ");
            strSql.Append(" ExamDeviceString1 = @ExamDeviceString1 , ");
            strSql.Append(" ExamDeviceString2 = @ExamDeviceString2 , ");
            strSql.Append(" ExamDeviceString3 = @ExamDeviceString3 , ");
            strSql.Append(" ExamDeviceString4 = @ExamDeviceString4 , ");
            strSql.Append(" ExamDeviceDateTime1 = @ExamDeviceDateTime1 , ");
            strSql.Append(" E_ID = @E_ID , ");
            strSql.Append(" ExamDeviceDateTime2 = @ExamDeviceDateTime2 , ");
            strSql.Append(" ES_ID = @ES_ID , ");
            strSql.Append(" ESR_ID = @ESR_ID , ");
            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" D_ID = @D_ID , ");
            strSql.Append(" DC_ID = @DC_ID , ");
            strSql.Append(" D_Manufacturer = @D_Manufacturer , ");
            strSql.Append(" U_ID = @U_ID  ");
            strSql.Append(" where ExamDeviceID=@ExamDeviceID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ExamDeviceID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamDeviceCreateTime", SqlDbType.DateTime,3) ,            
                        new SqlParameter("@ExamDeviceNumber1", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamDeviceNumber2", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExamDeviceNumber3", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@ExamDeviceNumber4", SqlDbType.Decimal,13) ,            
                        new SqlParameter("@ExamDeviceString1", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ExamDeviceString2", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ExamDeviceString3", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@ExamDeviceString4", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExamDeviceDateTime1", SqlDbType.DateTime) ,            
                        new SqlParameter("@E_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ExamDeviceDateTime2", SqlDbType.DateTime) ,            
                        new SqlParameter("@ES_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ESR_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Room_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@D_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@D_Manufacturer", SqlDbType.Int,4) ,            
                        new SqlParameter("@U_ID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ExamDeviceID;
            parameters[1].Value = model.ExamDeviceCreateTime;
            parameters[2].Value = model.ExamDeviceNumber1;
            parameters[3].Value = model.ExamDeviceNumber2;
            parameters[4].Value = model.ExamDeviceNumber3;
            parameters[5].Value = model.ExamDeviceNumber4;
            parameters[6].Value = model.ExamDeviceString1;
            parameters[7].Value = model.ExamDeviceString2;
            parameters[8].Value = model.ExamDeviceString3;
            parameters[9].Value = model.ExamDeviceString4;
            parameters[10].Value = model.ExamDeviceDateTime1;
            parameters[11].Value = model.E_ID;
            parameters[12].Value = model.ExamDeviceDateTime2;
            parameters[13].Value = model.ES_ID;
            parameters[14].Value = model.ESR_ID;
            parameters[15].Value = model.Room_ID;
            parameters[16].Value = model.D_ID;
            parameters[17].Value = model.DC_ID;
            parameters[18].Value = model.D_Manufacturer;
            parameters[19].Value = model.U_ID;
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
        public bool Delete(Guid ExamDeviceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExamDevice ");
            strSql.Append(" where ExamDeviceID=@ExamDeviceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamDeviceID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ExamDeviceID;


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
        public Tellyes.Model.ExamDevice GetModel(Guid ExamDeviceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ExamDeviceID, ExamDeviceCreateTime, ExamDeviceNumber1, ExamDeviceNumber2, ExamDeviceNumber3, ExamDeviceNumber4, ExamDeviceString1, ExamDeviceString2, ExamDeviceString3, ExamDeviceString4, ExamDeviceDateTime1, E_ID, ExamDeviceDateTime2, ES_ID, ESR_ID, Room_ID, D_ID, DC_ID, D_Manufacturer, U_ID  ");
            strSql.Append("  from ExamDevice ");
            strSql.Append(" where ExamDeviceID=@ExamDeviceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ExamDeviceID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ExamDeviceID;


            Tellyes.Model.ExamDevice model = new Tellyes.Model.ExamDevice();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ExamDeviceID"].ToString() != "")
                {
                    model.ExamDeviceID = Guid.Parse(ds.Tables[0].Rows[0]["ExamDeviceID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceCreateTime"].ToString() != "")
                {
                    model.ExamDeviceCreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["ExamDeviceCreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceNumber1"].ToString() != "")
                {
                    model.ExamDeviceNumber1 = int.Parse(ds.Tables[0].Rows[0]["ExamDeviceNumber1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceNumber2"].ToString() != "")
                {
                    model.ExamDeviceNumber2 = int.Parse(ds.Tables[0].Rows[0]["ExamDeviceNumber2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceNumber3"].ToString() != "")
                {
                    model.ExamDeviceNumber3 = decimal.Parse(ds.Tables[0].Rows[0]["ExamDeviceNumber3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceNumber4"].ToString() != "")
                {
                    model.ExamDeviceNumber4 = decimal.Parse(ds.Tables[0].Rows[0]["ExamDeviceNumber4"].ToString());
                }
                model.ExamDeviceString1 = ds.Tables[0].Rows[0]["ExamDeviceString1"].ToString();
                model.ExamDeviceString2 = ds.Tables[0].Rows[0]["ExamDeviceString2"].ToString();
                model.ExamDeviceString3 = ds.Tables[0].Rows[0]["ExamDeviceString3"].ToString();
                model.ExamDeviceString4 = ds.Tables[0].Rows[0]["ExamDeviceString4"].ToString();
                if (ds.Tables[0].Rows[0]["ExamDeviceDateTime1"].ToString() != "")
                {
                    model.ExamDeviceDateTime1 = DateTime.Parse(ds.Tables[0].Rows[0]["ExamDeviceDateTime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["E_ID"].ToString() != "")
                {
                    model.E_ID = Guid.Parse(ds.Tables[0].Rows[0]["E_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExamDeviceDateTime2"].ToString() != "")
                {
                    model.ExamDeviceDateTime2 = DateTime.Parse(ds.Tables[0].Rows[0]["ExamDeviceDateTime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ES_ID"].ToString() != "")
                {
                    model.ES_ID = Guid.Parse(ds.Tables[0].Rows[0]["ES_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ESR_ID"].ToString() != "")
                {
                    model.ESR_ID = Guid.Parse(ds.Tables[0].Rows[0]["ESR_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Room_ID"].ToString() != "")
                {
                    model.Room_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["Room_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["D_ID"].ToString() != "")
                {
                    model.D_ID = int.Parse(ds.Tables[0].Rows[0]["D_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DC_ID"].ToString() != "")
                {
                    model.DC_ID = int.Parse(ds.Tables[0].Rows[0]["DC_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["D_Manufacturer"].ToString() != "")
                {
                    model.D_Manufacturer = ds.Tables[0].Rows[0]["D_Manufacturer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["U_ID"].ToString() != "")
                {
                    model.U_ID = int.Parse(ds.Tables[0].Rows[0]["U_ID"].ToString());
                }

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
            strSql.Append(" FROM ExamDevice ");
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
            strSql.Append(" FROM ExamDevice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region  ExtensionMethod

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("TempExamTableID,eq")) 
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["TempExamTableID,eq"]));
            }
            if (conditionDictionary.ContainsKey("E_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("E_ID", conditionDictionary["E_ID,eq"]));
            }
            if (conditionDictionary.ContainsKey("DC_ID,eq"))
            {
                criteria.Add(Restrictions.Eq("DC_ID", conditionDictionary["DC_ID,eq"]));
            }
            return criteria;
        }

        /// <summary>
        /// 根据考试ID，设备类型ID，判断已分配设备中是否存在冲突分配
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="DC_ID"></param>
        /// <returns></returns>
        public int? SelectClashedDeviceCountByDeviceClassID(Guid E_ID,int DC_ID) 
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select COUNT(distinct result.D_ID) from ");
            sql.Append(" ( ");
            sql.Append("    select totalED.D_ID,totalET.E_StartTime,totalET.E_EndTime,totalET.E_ID from ExamDevice as totalED ");
            sql.Append("    join ExamTable as totalET ");
            sql.Append("    on totalED.E_ID=totalET.E_ID and DC_ID=:DC_ID and D_ID<>'0' and totalET.int1='1' ");
            sql.Append("    join ");
            sql.Append("    ( ");
            sql.Append("        select ed.D_ID,et.E_StartTime,et.E_EndTime,et.E_ID from ExamDevice as ed ");
            sql.Append("        join ExamTable as et ");
            sql.Append("        on ed.E_ID=et.E_ID ");
            sql.Append("        where ed.E_ID=:E_ID and DC_ID=:DC_ID and D_ID<>'0' ");
            sql.Append("    ) as currentExam ");
            sql.Append("    on totalED.D_ID=currentExam.D_ID and totalED.E_ID<>currentExam.E_ID ");
            sql.Append("    and ((totalET.E_StartTime between currentExam.E_StartTime and currentExam.E_EndTime) or ");
            sql.Append("        (totalET.E_EndTime between currentExam.E_StartTime and currentExam.E_EndTime) or ");
            sql.Append("        (currentExam.E_StartTime between totalET.E_StartTime and totalET.E_EndTime) or ");
            sql.Append("        (currentExam.E_EndTime between totalET.E_StartTime and totalET.E_EndTime)) ");
            sql.Append(" ) as result; ");

            //NHibernate连接对象
            ISession session = null;

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询参数
                iSQLQuery
                    .SetGuid("E_ID", E_ID)
                    .SetInt32("DC_ID", DC_ID);
                //查询结果并返回
                return (int)iSQLQuery.UniqueResult();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "考站人员信息查询失败：E_ID（" + E_ID.ToString() + "），DC_ID（" + DC_ID.ToString() + "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 获得某考试中已分配设备冲突信息
        /// </summary>
        /// <param name="E_ID"></param>
        /// <param name="D_ID"></param>
        /// <returns></returns>
        public List<object[]> SelectExamClashedInfoByE_ID(Guid E_ID) {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct");
            sql.Append("    result.E_ID as E_ID, ");
            sql.Append("    result.E_Name as E_Name, ");
            sql.Append("    result.D_ID as D_ID, ");
            sql.Append("    case when clashedStartTime > = currentStartTime then clashedStartTime else currentStartTime end as coverStartTime, ");
            sql.Append("    case when clashedEndTime < = currentEndTime then clashedEndTime else currentEndTime end as coverEndTime ");
            sql.Append(" from ");
            sql.Append(" ( ");
            sql.Append("    select ");
            sql.Append("        totalED.D_ID, ");
            sql.Append("        rt.ReservationTimeInfoDateInfo as clasehdDateInfo, ");
            sql.Append("        CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoStartTime) as clashedStartTime, ");
            sql.Append("        CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoEndTime) as clashedEndTime, ");
            sql.Append("        CONVERT(datetime,currentDateInfo+' '+currentStartTime) as currentStartTime, ");
            sql.Append("        CONVERT(datetime,currentDateInfo+' '+currentEndTime) as currentEndTime, ");
            sql.Append("        totalET.E_ID, ");
            sql.Append("        totalET.E_Name ");
            sql.Append("    from ");
            sql.Append("        ExamDevice as totalED ");
            sql.Append("    join ExamTable as totalET ");
            sql.Append("        on totalED.E_ID=totalET.E_ID and totalED.E_ID<>:E_ID and totalET.int1='1' ");
            sql.Append("    join dbo.ReservationTimeInfo as rt ");
            sql.Append("        on rt.EnityID=totalET.E_ID ");
            sql.Append("    join ");
            sql.Append("    ( ");
            sql.Append("        select ");
            sql.Append("            ed.D_ID, ");
            sql.Append("            rt.ReservationTimeInfoDateInfo as currentDateInfo, ");
            sql.Append("            rt.ReservationTimeInfoStartTime as currentStartTime, ");
            sql.Append("            rt.ReservationTimeInfoEndTime as currentEndTime, ");
            sql.Append("            et.E_ID ");
            sql.Append("        from ");
            sql.Append("            ExamDevice as ed ");
            sql.Append("        join ExamTable as et ");
            sql.Append("            on ed.E_ID=et.E_ID ");
            sql.Append("        join dbo.ReservationTimeInfo as rt ");
            sql.Append("            on rt.EnityID=et.E_ID ");
            sql.Append("        where ed.E_ID=:E_ID and ed.D_ID<>0 ");
            sql.Append("    ) as currentExam ");
            sql.Append("    on totalED.D_ID=currentExam.D_ID and totalED.E_ID<>currentExam.E_ID  ");
            sql.Append("        and rt.ReservationTimeInfoDateInfo=currentDateInfo ");
            sql.Append("        and ");
            sql.Append("        ( ");
            sql.Append("            (CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoStartTime) between CONVERT(datetime,currentDateInfo+' '+currentStartTime) and CONVERT(datetime,currentDateInfo+' '+currentEndTime)) ");
            sql.Append("            or ");
            sql.Append("            (CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoEndTime) between CONVERT(datetime,currentDateInfo+' '+currentStartTime) and CONVERT(datetime,currentDateInfo+' '+currentEndTime)) ");
            sql.Append("            or ");
            sql.Append("            (CONVERT(datetime,currentDateInfo+' '+currentStartTime) between CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoStartTime) and CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoEndTime)) ");
            sql.Append("            or ");
            sql.Append("            (CONVERT(datetime,currentDateInfo+' '+currentEndTime) between CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoStartTime) and CONVERT(datetime,rt.ReservationTimeInfoDateInfo + ' ' + rt.ReservationTimeInfoEndTime)) ");
            sql.Append("        ) ");
            sql.Append(" ) as result; ");

            //NHibernate连接对象
            ISession session = null;

            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("E_ID", NHibernateUtil.Guid)
                    .AddScalar("E_Name",NHibernateUtil.String)
                    .AddScalar("D_ID",NHibernateUtil.Int32)
                    .AddScalar("coverStartTime",NHibernateUtil.DateTime)
                    .AddScalar("coverEndTime",NHibernateUtil.DateTime);
                //设置查询参数
                iSQLQuery
                    .SetGuid("E_ID", E_ID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "已分配设备冲突信息查询失败：E_ID（" + E_ID.ToString() + "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据E_ID,DC_ID;获得备选设备列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Tellyes.Model.Device> SelectDeviceListInSpecialDeviceClass(Dictionary<string,object> condition) {
            Guid E_ID = (Guid)condition["E_ID"];
            int DC_ID = Convert.ToInt32(condition["DC_ID"]);

            //原生SQL语句
            StringBuilder sql = new StringBuilder();
            sql.Append(" select ");
            sql.Append("    * ");
            sql.Append(" from ");
            sql.Append("    Device ");
            sql.Append(" where ");
            sql.Append("    DC_ID=:DC_ID ");
            sql.Append("    and D_State='良好' ");
            sql.Append("    and D_ID not in (select coalesce(D_ID,0) from ExamDevice where E_ID=:E_ID) ");
            if (condition.Keys.Contains("D_SerialNumber") && condition["D_SerialNumber"].ToString().Trim() != String.Empty) 
            {
                sql.Append(" and D_SerialNumber like '%" + condition["D_SerialNumber"].ToString().Trim() + "%'  ");
            }
            if (condition.Keys.Contains("D_Name") && condition["D_Name"].ToString().Trim() != String.Empty) 
            {
                sql.Append(" and D_Name like '%" + condition["D_Name"].ToString().Trim() + "%' ");
            }
            if (condition.Keys.Contains("D_Manufacturer") && condition["D_Manufacturer"].ToString().Trim() != String.Empty) 
            {
                sql.Append(" and D_Manufacturer in (" + condition["D_Manufacturer"].ToString().Trim() + ") ");
            }
            sql.Append(" order by D_Name; ");

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Model.Device));
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", E_ID)
                    .SetInt32("DC_ID",DC_ID);
                //查询结果并返回
                return iSQLQuery.List<Tellyes.Model.Device>().ToList<Tellyes.Model.Device>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询备选设备信息失败，examTableID：" + E_ID.ToString().Trim() + " ; DC_ID : " + DC_ID.ToString().Trim(), e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 根据条件 ，获得备选设备冲突信息列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<object[]> SelectDeviceClashedInfoListByCondition(Dictionary<string, object> condition) 
        {
            Guid E_ID = (Guid)condition["E_ID"];
            int DC_ID = Convert.ToInt32(condition["DC_ID"]);

            StringBuilder sql = new StringBuilder();
            sql.Append(" select distinct");
            sql.Append("    clashedED.D_ID as D_ID, ");
            sql.Append("    ExamTable.E_Name as E_Name, ");
            sql.Append("    clashedRT.EnityID as E_ID, ");
            sql.Append("    case when CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoStartTime) > CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_StartTime) then CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoStartTime) else CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_StartTime) end as coverStartTime, ");
            sql.Append("    case when CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime) < CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime) then CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime) else CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime) end as coverEndTime ");
            sql.Append(" from ");
            sql.Append("    dbo.ExamDevice as clashedED ");
            sql.Append(" join dbo.Reservation as clashedResource ");
            sql.Append("    on clashedED.E_ID=clashedResource.EnityID ");
            sql.Append("        and clashedED.E_ID<>:E_ID ");
            sql.Append(" join dbo.ReservationTimeInfo as clashedRT ");
            sql.Append("    on clashedResource.EnityID=clashedRT.EnityID ");
            sql.Append(" join ");
            sql.Append("    ( ");
            sql.Append("        select ");
            sql.Append("            Device.D_ID as current_D_ID, ");
            sql.Append("            :E_ID as current_E_ID, ");
            sql.Append("            currentRT.ReservationTimeInfoDateInfo as current_DateInfo, ");
            sql.Append("            currentRT.ReservationTimeInfoStartTime as current_StartTime, ");
            sql.Append("            currentRT.ReservationTimeInfoEndTime as current_EndTime ");
            sql.Append("        from ");
            sql.Append("            Device ");
            sql.Append("        cross join ( select * from dbo.ReservationTimeInfo where EnityID = :E_ID) as currentRT ");
            sql.Append("        where ");
            sql.Append("            DC_ID=:DC_ID ");
            sql.Append("            and D_State='良好' ");
            sql.Append("            and D_ID not in (select coalesce(D_ID,0) from ExamDevice where E_ID=:E_ID) ");
            if (condition.Keys.Contains("D_SerialNumber") && condition["D_SerialNumber"].ToString().Trim() != String.Empty)
            {
                sql.Append("        and D_SerialNumber like '%" + condition["D_SerialNumber"].ToString().Trim() + "%'  ");
            }
            if (condition.Keys.Contains("D_Name") && condition["D_Name"].ToString().Trim() != String.Empty)
            {
                sql.Append("        and D_Name like '%" + condition["D_Name"].ToString().Trim() + "%' ");
            }
            if (condition.Keys.Contains("D_Manufacturer") && condition["D_Manufacturer"].ToString().Trim() != String.Empty)
            {
                sql.Append("        and D_Manufacturer in (" + condition["D_Manufacturer"].ToString().Trim() + ") ");
            }
            sql.Append("    ) as currentExam ");
            sql.Append("    on clashedED.D_ID = currentExam.current_D_ID ");
            sql.Append("        and ( ");
            sql.Append("            (CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoStartTime) between CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_StartTime) and CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_EndTime))	 ");
            sql.Append("            or ");
            sql.Append("            (CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime) between CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_StartTime) and CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_EndTime)) ");
            sql.Append("            or ");
            sql.Append("            ( CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_StartTime) between CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoStartTime) and CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime)) ");
            sql.Append("            or ");
            sql.Append("            ( CONVERT(datetime,currentExam.current_DateInfo + ' ' + currentExam.current_EndTime) between CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoStartTime) and CONVERT(datetime,clashedRT.ReservationTimeInfoDateInfo + ' ' + clashedRT.ReservationTimeInfoEndTime)) ");
            sql.Append("        ) ");
            sql.Append(" join ExamTable  ");
            sql.Append("    on ExamTable.E_ID=clashedED.E_ID; ");

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddScalar("D_ID", NHibernateUtil.Int32)
                    .AddScalar("E_Name", NHibernateUtil.String)
                    .AddScalar("E_ID", NHibernateUtil.Guid)
                    .AddScalar("coverStartTime", NHibernateUtil.DateTime)
                    .AddScalar("coverEndTime", NHibernateUtil.DateTime);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", E_ID)
                    .SetInt32("DC_ID", DC_ID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询备选设备冲突信息失败，examTableID：" + E_ID.ToString().Trim());
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 预约中获取房间
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<object[]> SelectRoomDataInfo(Dictionary<string,object> condition) 
        {
            Guid E_ID = (Guid)condition["E_ID"];
            StringBuilder sql = new StringBuilder();
            sql.Append(" select ");
            sql.Append("    r.*, ");
            sql.Append("    es.ES_Name as ES_Name, ");
            sql.Append("    coalesce(es.int3,1) as int3 ");
            sql.Append(" from ");
            sql.Append("    Room as r ");
            sql.Append(" inner join dbo.ExamStation_Room as sr ");
            sql.Append("    on r.Room_ID = sr.Room_ID ");
            sql.Append(" inner join dbo.ExamStation as es ");
            sql.Append("    on sr.ES_ID=es.ES_ID ");
            sql.Append(" where ");
            sql.Append("    sr.int1=:E_ID ");
            sql.Append(" order by ");
            sql.Append("    es.int3 ");
            sql.Append("    ,ES_Name; ");

            //NHibernate连接对象
            ISession session = null;
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql.ToString().Trim());
                //设置查询结果类型
                iSQLQuery
                    .AddEntity(typeof(Tellyes.Model.Room))
                    .AddScalar("ES_Name", NHibernateUtil.String)
                    .AddScalar("int3", NHibernateUtil.Int32);
                //设置查询参数
                iSQLQuery.SetGuid("E_ID", E_ID);
                //查询结果并返回
                return iSQLQuery.List<object[]>().ToList<object[]>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "房间信息查询失败，examTableID：" + E_ID.ToString().Trim());
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
            
        }
        #endregion  ExtensionMethod
    }
}
