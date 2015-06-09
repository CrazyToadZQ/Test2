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
    //房间-考站类型-关系表
    public partial class RoomExamStationClassRelation : BaseDAL<Tellyes.Model.RoomExamStationClassRelation>
    {
        #region basic
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RoomExamStationClassRelation");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tellyes.Model.RoomExamStationClassRelation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RoomExamStationClassRelation(");
            strSql.Append("Room_ID,Exam_Station_Class_ID");
            strSql.Append(") values (");
            strSql.Append("@Room_ID,@Exam_Station_Class_ID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.Room_ID;
            parameters[1].Value = model.Exam_Station_Class_ID;

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
        public bool Update(Tellyes.Model.RoomExamStationClassRelation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RoomExamStationClassRelation set ");

            strSql.Append(" Room_ID = @Room_ID , ");
            strSql.Append(" Exam_Station_Class_ID = @Exam_Station_Class_ID  ");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Room_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Exam_Station_Class_ID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.Room_ID;
            parameters[2].Value = model.Exam_Station_Class_ID;
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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RoomExamStationClassRelation ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RoomExamStationClassRelation ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public Tellyes.Model.RoomExamStationClassRelation GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, Room_ID, Exam_Station_Class_ID  ");
            strSql.Append("  from RoomExamStationClassRelation ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


            Tellyes.Model.RoomExamStationClassRelation model = new Tellyes.Model.RoomExamStationClassRelation();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Room_ID"].ToString() != "")
                {
                    model.Room_ID = int.Parse(ds.Tables[0].Rows[0]["Room_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Exam_Station_Class_ID"].ToString() != "")
                {
                    model.Exam_Station_Class_ID = int.Parse(ds.Tables[0].Rows[0]["Exam_Station_Class_ID"].ToString());
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
            strSql.Append(" FROM RoomExamStationClassRelation ");
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
            strSql.Append(" FROM RoomExamStationClassRelation ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {

            if (conditionDictionary.ContainsKey("ExamStationClassRelationRoomID"))
            {
                criteria.Add(Restrictions.Eq("Room_ID", conditionDictionary["ExamStationClassRelationRoomID"]));
            }

            return criteria;
        }
    }
}
