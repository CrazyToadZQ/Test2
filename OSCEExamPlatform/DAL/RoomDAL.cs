using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.NHibernate;
using Tellyes.Model;
using NHibernate;
using NHibernate.Criterion;
using Tellyes.Log4Net;

namespace Tellyes.DAL
{
    public class RoomDAL : BaseDAL<Room>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public List<Model.ExamStationClass> SelectRoomExamStationClassListByRoomID(int roomID)
        {
            ISession session = null;
            try
            {
                string sql = new StringBuilder(string.Empty)
                    .Append("SELECT ")
                    .Append("   [ExamStationClass].[Exam_Station_Class_ID], ")
                    .Append("   [ExamStationClass].[Exam_Station_Class_Name], ")
                    .Append("   [ExamStationClass].[Number1], ")
                    .Append("   [ExamStationClass].[Number2] ")
                    .Append("FROM ")
                    .Append("   [Room] ")
                    .Append("   INNER JOIN [RoomExamStationClassRelation] AS [Relation] ")
                    .Append("       ON [Room].[Room_ID] = [Relation].[Room_ID] ")
                    .Append("   INNER JOIN [ExamStationClass] ")
                    .Append("       ON [ExamStationClass].[Exam_Station_Class_ID] = [Relation].[Exam_Station_Class_ID] ")
                    .Append("WHERE ")
                    .Append("   [Room].[Room_ID] = :Room_ID ")
                    .ToString();
                session = SessionManager.OpenSession();
                return session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Model.ExamStationClass))
                    .SetInt32("Room_ID", roomID)
                    .List<Model.ExamStationClass>().
                    ToList<Model.ExamStationClass>();
            }
            catch (Exception e)
            {
                Tellyes.Log4Net.Log4NetUtility.Error(this, "查询房间关联的考站类型信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public Model.Room SelectRoomByExamStationRoomID(Guid ESR_ID)
        {
            //NHibernate连接对象
            ISession session = null;
            //原生SQL语句
            string sql = new StringBuilder(string.Empty)
                .Append("SELECT ")
                .Append("   [Room].* ")
                .Append("FROM ")
                .Append("   [Room] ")
                .Append("   INNER JOIN [ExamStation_Room] ")
                .Append("       ON [Room].[Room_ID] = [ExamStation_Room].[Room_ID] ")
                .Append("WHERE ")
                .Append("   [ExamStation_Room].[ESR_ID] = :ESR_ID ")
                .ToString();
            try
            {
                //获取连接池中的活动连接对象
                session = SessionManager.OpenSession();
                //加载SQL语句
                ISQLQuery iSQLQuery = session.CreateSQLQuery(sql);
                //设置查询结果类型
                iSQLQuery.AddEntity(typeof(Model.Room));
                //设置查询参数
                iSQLQuery.SetGuid("ESR_ID", ESR_ID);
                //查询结果并返回
                return iSQLQuery
                    .SetFirstResult(0)
                    .SetMaxResults(1)
                    .UniqueResult<Model.Room>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "手持设备，房间信息查询失败：ESR_ID（" + ESR_ID + "）", e);
                return null;
            }
            finally
            {
                //释放活动的连接对象回到连接池
                SessionManager.CloseSession(session);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)   //对父类中的 查找条件进行重写
        {
            if (conditionDictionary.ContainsKey("ParentRoomID_Is"))
            {
                criteria.Add(Restrictions.Eq("ParentRoomID", 0));
            }
            if (conditionDictionary.ContainsKey("IsExist"))
            {
                criteria.Add(Restrictions.Eq("IsExist", 1));
            }
            if (conditionDictionary.ContainsKey("ChildRoomListByParentRoomId"))
            {
                criteria.Add(Restrictions.Eq("ParentRoomID", conditionDictionary["ChildRoomListByParentRoomId"]));
            }
            if (conditionDictionary.ContainsKey("Room_ID_IN")) {
                criteria.Add(Restrictions.In("RoomID", (List<int>)conditionDictionary["Room_ID_IN"]));
            }

            return criteria;
        }
    }
}
