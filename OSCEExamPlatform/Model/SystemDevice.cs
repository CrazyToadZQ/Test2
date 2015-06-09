using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    //系统设备
    public class SystemDevice
    {
        #region Model

        /// <summary>
        /// 主键
        /// </summary>
        public virtual string SD_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 应用类型
        /// </summary>
        public virtual string SD_Application_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 系统设备类型
        /// </summary>
        public virtual string SD_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 硬件版本
        /// </summary>
        public virtual string SD_HardWare_Version
        {
            get;
            set;
        }
        /// <summary>
        /// 硬件系统版本
        /// </summary>
        public virtual string SD_HardWare_System_Version
        {
            get;
            set;
        }
        /// <summary>
        /// 硬件序列号
        /// </summary>
        public virtual string SD_HardWare_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// CPU序列号
        /// </summary>
        public virtual string SD_CPU_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 主板序列号
        /// </summary>
        public virtual string SD_Mainboard_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// BIOS序列号
        /// </summary>
        public virtual string SD_BIOS_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 硬盘序列号
        /// </summary>
        public virtual string SD_HardDisk_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// MAC地址
        /// </summary>
        public virtual string SD_MAC_Address
        {
            get;
            set;
        }
        /// <summary>
        /// 设备验证序列号
        /// </summary>
        public virtual string SD_Verification_SerialNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 设备验注册时间
        /// </summary>
        public virtual string SD_Registration_Time
        {
            get;
            set;
        }
        /// <summary>
        /// SD_Number1
        /// </summary>
        public virtual int? SD_Number1
        {
            get;
            set;
        }
        /// <summary>
        /// SD_Number2
        /// </summary>
        public virtual int? SD_Number2
        {
            get;
            set;
        }
        /// <summary>
        /// SD_Number3
        /// </summary>
        public virtual int? SD_Number3
        {
            get;
            set;
        }
        /// <summary>
        /// SD_Number4
        /// </summary>
        public virtual int? SD_Number4
        {
            get;
            set;
        }
        /// <summary>
        /// SD_String1
        /// </summary>
        public virtual string SD_String1
        {
            get;
            set;
        }
        /// <summary>
        /// SD_String2
        /// </summary>
        public virtual string SD_String2
        {
            get;
            set;
        }
        /// <summary>
        /// SD_String3
        /// </summary>
        public virtual string SD_String3
        {
            get;
            set;
        }
        /// <summary>
        /// SD_String4
        /// </summary>
        public virtual string SD_String4
        {
            get;
            set;
        }
        /// <summary>
        /// SD_String5
        /// </summary>
        public virtual string SD_String5
        {
            get;
            set;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 生成闭合结构的json结构
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 生成json结构
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new System.Text.StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"SD_ID\":\"").Append(Uri.EscapeDataString(this.SD_ID.ToString())).Append("\",")
                .Append("\"SD_Application_Type\":\"").Append(Uri.EscapeDataString(this.SD_Application_Type.ToString())).Append("\",")
                .Append("\"SD_Type\":\"").Append(Uri.EscapeDataString(this.SD_Type.ToString())).Append("\",")
                .Append("\"SD_HardWare_Version\":\"").Append(Uri.EscapeDataString(this.SD_HardWare_Version.ToString())).Append("\",")
                .Append("\"SD_HardWare_System_Version\":\"").Append(Uri.EscapeDataString(this.SD_HardWare_System_Version.ToString())).Append("\",")
                .Append("\"SD_HardWare_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_HardWare_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_CPU_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_CPU_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_Mainboard_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_Mainboard_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_BIOS_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_BIOS_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_HardDisk_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_HardDisk_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_MAC_Address\":\"").Append(Uri.EscapeDataString(this.SD_MAC_Address.ToString())).Append("\",")
                .Append("\"SD_Verification_SerialNumber\":\"").Append(Uri.EscapeDataString(this.SD_Verification_SerialNumber.ToString())).Append("\",")
                .Append("\"SD_Registration_Time\":\"").Append(Uri.EscapeDataString(this.SD_Registration_Time.ToString())).Append("\",")
                .Append("\"SD_Number1\":\"").Append(Uri.EscapeDataString(this.SD_Number1 == null ? "" : this.SD_Number1.ToString())).Append("\",")
                .Append("\"SD_Number2\":\"").Append(Uri.EscapeDataString(this.SD_Number2 == null ? "" : this.SD_Number2.ToString())).Append("\",")
                .Append("\"SD_Number3\":\"").Append(Uri.EscapeDataString(this.SD_Number3 == null ? "" : this.SD_Number3.ToString())).Append("\",")
                .Append("\"SD_Number4\":\"").Append(Uri.EscapeDataString(this.SD_Number4 == null ? "" : this.SD_Number4.ToString())).Append("\",")
                .Append("\"SD_String1\":\"").Append(Uri.EscapeDataString(this.SD_String1 == null ? "" : this.SD_String1.ToString())).Append("\",")
                .Append("\"SD_String2\":\"").Append(Uri.EscapeDataString(this.SD_String2 == null ? "" : this.SD_String2.ToString())).Append("\",")
                .Append("\"SD_String3\":\"").Append(Uri.EscapeDataString(this.SD_String3 == null ? "" : this.SD_String3.ToString())).Append("\",")
                .Append("\"SD_String4\":\"").Append(Uri.EscapeDataString(this.SD_String4 == null ? "" : this.SD_String4.ToString())).Append("\",")
                .Append("\"SD_String5\":\"").Append(Uri.EscapeDataString(this.SD_String5 == null ? "" : this.SD_String5.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }

        #endregion
    }
}
