using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;
using Tellyes.DAL;
using Tellyes.Log4Net;

namespace Tellyes.BLL
{
    public class CameraBLL
    {
        /// <summary>
        /// 新增摄像头
        /// </summary>
        /// <param name="camera"></param>
        /// <returns>bool</returns>
        public bool AddCamera(Camera camera)
        {
            
            return new CameraDAL().Insert(camera);
        }

        /// <summary>
        /// 查询所有摄像头
        /// </summary>
        /// <returns></returns>
        public List<Camera> SearchCamera() 
        {
            return new CameraDAL().SelectModelObjectByCondition
            (
                null,
                new List<KeyValuePair<string, string>>() 
                { 
                    new KeyValuePair<string, string>("CameraIP", "ASC")
                }
            );
        }


        /// <summary>
        /// 查询所有没有绑定房间的摄像头列表
        /// </summary>
        /// <returns></returns>
        public List<Camera> SearchCameraNoRoom()
        {
            return new CameraDAL().SelectModelObjectByCondition
             (
                new Dictionary<string, object>() 
                { 
                    {"ParentRoomID_Is", 0}
                },
                 new List<KeyValuePair<string, string>>() 
                { 
                    new KeyValuePair<string, string>("CameraIP", "ASC")
                }
             );
        }


        /// <summary>
        /// 根据父房间ID查询属于房间的摄像头列表
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public List<Camera> SearchCameraByParentRoomID(int RoomID)
        {
            return new CameraDAL().SelectModelObjectByCondition
            (
               new Dictionary<string, object>() 
                { 
                    {"ParentRoomID",RoomID}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("CameraIP", "asc")
                }
            );
        }

        /// <summary>
        /// 根据子房间ID查询属于该房间的摄像头列表
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public List<Camera> SearchCameraByChildRoomID(int RoomID)
        {
            return new CameraDAL().SelectModelObjectByCondition
             (
                new Dictionary<string, object>() 
                { 
                    {"ChildRoomID",RoomID}
                },
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("CameraIP", "asc")
                }
             );
        }



        /// <summary>
        /// 根据摄像头ID查询摄像头
        /// </summary>
        /// <param name="CameraID"></param>
        /// <returns></returns>
        public Camera SearchCameraByCameraID(int CameraID)
        {
            return new CameraDAL().SelectModelObjectByID(CameraID);
        }

        /// <summary>
        /// 根据房间ID查询属于该房间的摄像头数量
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public int? SearchCameraCountByRoomID(int RoomID)
        {
            return new CameraDAL().SelectModelObjectCountByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"RoomID", RoomID}
                }
            );
        }


        /// <summary>
        /// 判断指定IP摄像头是否存在
        /// </summary>
        /// <param name="CameraIP"></param>
        /// <returns>bool</returns>
        public bool IsCameraIPExists(string CameraIP)
        {
            List<Camera> cameraList = new CameraDAL().SelectModelObjectByCondition
            (
                new Dictionary<string, object>() 
                { 
                    {"CameraIP_Exists", CameraIP}
                }, 
                null
            );
            if (cameraList == null) 
            {
                Log4NetUtility.Error(this, "按照CameraIP查询Camera信息失败");
                return true;
            }
            return cameraList.Count != 0;
        }


        /// <summary>
        /// 删除摄像头
        /// </summary>
        /// <param name="camera"></param>
        /// <returns></returns>
        public bool RemoveCamera(Camera camera)
        {
            return new CameraDAL().Delete(camera);
        }

        /// <summary>
        /// 修改摄像头///////////////////
        /// </summary>
        /// <param name="camera"></param>
        /// <returns></returns>
        public bool ModifyCamera(Camera camera)
        {
            return new CameraDAL().Update(camera);
        }
    }
}
