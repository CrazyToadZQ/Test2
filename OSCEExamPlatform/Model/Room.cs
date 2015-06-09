using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class Room : IComparable<Room>
    {
        /// <summary>
        /// 主键编号
        /// </summary>
        public virtual int RoomID
        {
            get;
            set;
        }
        /// <summary>
        /// 父房间ID(房间只允许分两级，第一级房间的父房间ID默认为0，第二级房间的父房间ID为对应上一级房间的Room_ID)
        /// </summary>
        public virtual int ParentRoomID
        {
            get;
            set;
        }
        /// <summary>
        /// 房间名称
        /// </summary>
        public virtual string RoomName
        {
            get;
            set;
        }
        /// <summary>
        /// 房间面积
        /// </summary>
        public virtual string RoomArea
        {
            get;
            set;
        }
        /// <summary>
        /// 房间人数
        /// </summary>
        public virtual int RoomPeopleNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 房间考站数量
        /// </summary>
        public virtual int RoomStationNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 房间是否绑定设备(‘0’不绑定设备，‘1’绑定设备)
        /// </summary>
        public virtual int RoomISBindingDevice
        {
            get;
            set;
        }
        /// <summary>
        /// 房间绑定设备名称
        /// </summary>
        public virtual string RoomDeviceName
        {
            get;
            set;
        }
        /// <summary>
        /// 房间描述
        /// </summary>
        public virtual string RoomDescribe
        {
            get;
            set;
        }

        /// <summary>
        /// 逻辑删除列，表示此条记录目前是否存在，值为“1” 表示词条记录目前还存在，值为“0”表示目前已经被删除
        /// </summary>
        public virtual int IsExist
        {
            get;
            set;
        }

        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        public virtual string ToJsonString(bool close) 
        {
            string jsonString = "{";
            if(!close)
            {
                jsonString = String.Empty;
            }
            jsonString += "\"RoomID\":\"" + this.RoomID + "\",";
            jsonString += "\"ParentRoomID\":\"" + this.ParentRoomID + "\",";
            jsonString += "\"RoomName\":\"" + Uri.EscapeDataString(this.RoomName) + "\",";
            jsonString += "\"RoomArea\":\"" + Uri.EscapeDataString(this.RoomArea) + "\",";
            jsonString += "\"RoomPeopleNumber\":\"" + this.RoomPeopleNumber + "\",";
            jsonString += "\"RoomStationNumber\":\"" + this.RoomStationNumber + "\",";
            jsonString += "\"RoomISBindingDevice\":\"" + this.RoomISBindingDevice + "\",";
            jsonString += "\"RoomDeviceName\":\"" + Uri.EscapeDataString(this.RoomDeviceName) + "\",";
            jsonString += "\"RoomDescribe\":\"" + Uri.EscapeDataString(this.RoomDescribe) + "\",";
            jsonString += "\"IsExist\":\"" + this.IsExist + "\"";
            if (close)
            {
                jsonString += "}";
            }
            
            return jsonString;
        }

        public virtual int CompareTo(Room other)
        {
            for (int i = 0; i < this.RoomName.Length && i < other.RoomName.Length; i++)
            {
                if ((int)this.RoomName[i] == (int)other.RoomName[i])
                {
                    continue;
                }
                return (int)this.RoomName[i] - (int)other.RoomName[i];
            }
            return this.RoomName.Length - other.RoomName.Length;
        }
    }
}
