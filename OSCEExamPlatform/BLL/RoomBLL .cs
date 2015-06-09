using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;
using Tellyes.DAL;
using Tellyes.Log4Net;
using System.Data;

namespace Tellyes.BLL
{
    public class RoomBLL
    {
        #region Extension NHibernate

        /// <summary>
        /// 添加Room记录
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool AddRoom(Model.Room room)
        {
            return new DAL.RoomDAL().Insert(room);
        }

        /// <summary>
        /// 删除Room记录
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool RemoveRoom(Model.Room room)
        {
            return new DAL.RoomDAL().Delete(room);
        }

        /// <summary>
        /// 修改Room记录
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool ModifyRoom(Model.Room room)
        {
            return new DAL.RoomDAL().Update((object)room);
        }

        /// <summary>
        /// 查询Room下一个自增ID
        /// </summary>
        /// <returns></returns>
        public int? SearchRoomIdentity()
        {
            return new DAL.RoomDAL().SelectNextIdentity();
        }

        /// <summary>
        /// 查询全部Room记录数量
        /// </summary>
        /// <returns></returns>
        public int? SearchRoomCount()
        {
            return new DAL.RoomDAL().SelectModelObjectCountByCondition();
        }

        /// <summary>
        /// 按条件查询Room记录数量
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public int? SearchRoomCount(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.RoomDAL().SelectModelObjectCountByCondition(conditionDictionary);
        }

        /// <summary>
        /// 查询指定room_ID的Room是否存在
        /// </summary>
        /// <param name="room_ID"></param>
        /// <returns></returns>
        public bool? SearchRoomExists(object room_ID)
        {
            return new DAL.RoomDAL().SelectModelObjectExistsByID(room_ID);
        }

        /// <summary>
        /// 查询指定条件的Room是否存在
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public bool? SearchRoomExists(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.RoomDAL().SelectModelObjectExistsByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按room_ID查询Room
        /// </summary>
        /// <param name="room_ID"></param>
        /// <returns></returns>
        public Model.Room SearchRoomByID(object room_ID)
        {
            return new DAL.RoomDAL().SelectModelObjectByID(room_ID);
        }

        /// <summary>
        /// 查询第一个Room对象
        /// </summary>
        /// <returns></returns>
        public Model.Room SearchUniqueRoomByCondition()
        {
            return new DAL.RoomDAL().SelectUniqueModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询第一个Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public Model.Room SearchUniqueRoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.RoomDAL().SelectUniqueModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询第一个Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public Model.Room SearchUniqueRoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.RoomDAL().SelectUniqueModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 查询全部Room对象
        /// </summary>
        /// <returns></returns>
        public List<Model.Room> SearchRoomByCondition()
        {
            return new DAL.RoomDAL().SelectModelObjectByCondition();
        }

        /// <summary>
        /// 按条件查询Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <returns></returns>
        public List<Model.Room> SearchRoomByCondition(Dictionary<string, object> conditionDictionary)
        {
            return new DAL.RoomDAL().SelectModelObjectByCondition(conditionDictionary);
        }

        /// <summary>
        /// 按条件和排序查询Room对象
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <returns></returns>
        public List<Model.Room> SearchRoomByCondition(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList)
        {
            return new DAL.RoomDAL().SelectModelObjectByCondition(conditionDictionary, orderList);
        }

        /// <summary>
        /// 按分页条件和排序查询Room内容
        /// </summary>
        /// <param name="conditionDictionary"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Model.Room> SearchRoomByPage(Dictionary<string, object> conditionDictionary, List<KeyValuePair<string, string>> orderList, int pageIndex, int pageSize)
        {
            return new DAL.RoomDAL().SelectModelObjectByPage(conditionDictionary, orderList, pageIndex, pageSize);
        }

        #endregion

        /// <summary>
        /// 搜索所有房间，按照房间名进行升序排列
        /// </summary>
        /// <returns></returns>
        public List<Room> SearchRoom() 
        {
            return new RoomDAL().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"IsExist",1}
                },
                new List<KeyValuePair<string, string>>() 
                { 
                    new KeyValuePair<string, string>("RoomName", "ASC")
                }
            );
        }

        /// <summary>
        /// 搜索ParentRoomID为0的房间，即，第一级房间
        /// </summary>
        /// <returns></returns>
        public List<Room> SearchFirstClassRoom()
        {
            return new RoomDAL().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"ParentRoomID_Is",0},
                    {"IsExist",1}
                },
                new List<KeyValuePair<string, string>>() 
                { 
                    new KeyValuePair<string, string>("RoomName", "ASC")
                }
             );
        }

        /// <summary>
        /// 搜索ParentRoomID不等于0的房间，即，第二级房间
        /// </summary>
        /// <returns></returns>

        public List<Room> SearchSecondClassRoom()
        {
            Tellyes.BLL.RoomBLL roomBll = new RoomBLL();
            List<Tellyes.Model.Room> roomList = roomBll.SearchRoom();
            List<Tellyes.Model.Room> roomListParent = roomBll.SearchFirstClassRoom();
            List<Tellyes.Model.Room> roomListChild = new List<Room>();

            foreach (Tellyes.Model.Room room in roomList)
            {
                bool sign = false;

                foreach (Tellyes.Model.Room roomParent in roomListParent)
                {
                    if (room.RoomID == roomParent.RoomID)
                    {
                        sign = true;
                        break;
                    }
                }

                if (sign == false)
                {
                    roomListChild.Add(room);
                }
            }

            return roomListChild;
        }

        /// <summary>
        /// 搜索父房间中的所有子房间列表
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public List<Room> SearchChildRoomListByParentRoomId(int roomId)
        {
            return new RoomDAL().SelectModelObjectByCondition
              (
                  new Dictionary<string, object>() 
                { 
                    {"ChildRoomListByParentRoomId",roomId},
                    {"IsExist",1}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("RoomName", "asc")
                }
              );
        }


        /// <summary>
        /// 查询房间，房间ID对应的房间实体
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Room> SearchRoomDictionary()
        {
            List<Room> roomList = this.SearchRoom();
            if (roomList == null)
            {
                Log4NetUtility.Error("RoomBLL", "从数据库中查询房间字典列表失败");
                return null;
            }
            Dictionary<int, Room> roomDictionary = new Dictionary<int, Room>();
            foreach (Room room in roomList)
            {
                roomDictionary.Add(room.RoomID, room);
            }
            return roomDictionary;
        }

        /// <summary>
        /// 按照房间ID搜索房间
        /// </summary>
        /// <param name="roomID">Room编号</param>
        /// <returns>Room</returns>
        public Room SearchRoomByRoomID(int roomID)
        {
            return new RoomDAL().SelectModelObjectByID(roomID);
        }
         

        /// <summary>
        /// 增加一条房间记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool AddRoom(Room room, List<Tellyes.Model.RoomExamStationClassRelation> roomExamStationClassRelationList, List<Camera> cameraList)
        {
            return new RoomDAL().Transaction(
                new List<List<object>>() 
                { 
                    new List<object>(){"insert", room},
                    new List<object>(){"insert", roomExamStationClassRelationList.ToList<object>()},
                    new List<object>(){"update", cameraList.ToList<object>()}
                }
            );
        }

        /// <summary>
        /// 更新一条房间记录
        /// </summary>
        /// <param name="roomModel"></param>
        /// <returns></returns>
        public bool ModifyRoom(Room room, List<Tellyes.Model.RoomExamStationClassRelation> roomExamStationClassRelationListAdd, List<Tellyes.Model.RoomExamStationClassRelation> roomExamStationClassRelationListDelete, List<Tellyes.Model.RoomExamStationClassRelation> roomExamStationClassRelationListUpdate,List<Camera> cameraList)
        {
            return new RoomDAL().Transaction(
               new List<List<object>>() 
                { 
                    new List<object>(){"update", room},
                    new List<object>(){"insert", roomExamStationClassRelationListAdd.ToList<object>()},
                    new List<object>(){"delete", roomExamStationClassRelationListDelete.ToList<object>()},
                    new List<object>(){"update", roomExamStationClassRelationListUpdate.ToList<object>()},
                    new List<object>(){"update", cameraList.ToList<object>()}
                }
           );
        }

        /// <summary>
        /// 删除一条房间记录，由于设置了逻辑删除列，所以仅仅是对此条记录的逻辑删除列的值进行更新，即从“1”变为“0”。实际数据库中的记录将不被删除。
        /// </summary>
        /// <param name="room"></param>
        /// <param name="cameraList"></param>
        /// <returns></returns>
        public bool RemoveRoom(List<Tellyes.Model.Room> roomList, List<Tellyes.Model.Camera> cameraList)
        {
            return new RoomDAL().Transaction(
               new List<List<object>>() 
                { 
                    new List<object>(){"update", roomList.ToList<object>()},
                    new List<object>(){"update", cameraList.ToList<object>()}
                }
           );
        }


        /// <summary>
        /// 删除一条房间记录，由于设置了逻辑删除列，所以仅仅是对此条记录的逻辑删除列的值进行更新，即从“1”变为“0”。实际数据库中的记录将不被删除。
        /// 批量删除用此方法
        /// </summary>
        /// <param name="room"></param>
        /// <param name="cameraList"></param>
        /// <returns></returns>
        public bool RemoveRoom(List<Tellyes.Model.Room> roomList)
        {
            return new RoomDAL().Transaction(
               new List<List<object>>()  
                { 
                    new List<object>(){"update", roomList.ToList<object>()}                    
                }
           );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? SearchNextRoomID()
        {
            return new RoomDAL().SelectNextIdentity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public List<Model.ExamStationClass> SearchRoomExamStationClassListByRoomID(int roomID)
        {
            return new Tellyes.DAL.RoomDAL().SelectRoomExamStationClassListByRoomID(roomID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ESR_ID"></param>
        /// <returns></returns>
        public Model.Room SearchRoomByExamStationRoomID(Guid ESR_ID)
        {
            return new RoomDAL().SelectRoomByExamStationRoomID(ESR_ID);
        }

    }
}
