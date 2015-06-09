using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;

namespace Tellyes.Model
{
  public class DeviceUse
    {
		#region Model
		
      	/// <summary>
		/// 设备使用记录ID
        /// </summary>
        public virtual int DU_ID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 设备ID
        /// </summary>
        public virtual int D_ID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 考试ID
        /// </summary>
        public virtual Guid E_ID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 房间ID
        /// </summary>
        public virtual int RoomID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 设备使用开始时间
        /// </summary>
        public virtual DateTime DU_StartTime
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 设备使用结束时间
        /// </summary>
        public virtual DateTime DU_EndTime
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 设备使用时长
        /// </summary>
        public virtual int DU_TimeSpan
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_Number1
        /// </summary>
        public virtual int? DU_Number1
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_Number2
        /// </summary>
        public virtual int? DU_Number2
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_Number3
        /// </summary>
        public virtual int? DU_Number3
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_Number4
        /// </summary>
        public virtual int? DU_Number4
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_String1
        /// </summary>
        public virtual string DU_String1
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_String2
        /// </summary>
        public virtual string DU_String2
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_String3
        /// </summary>
        public virtual string DU_String3
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_String4
        /// </summary>
        public virtual string DU_String4
        {
            get; 
            set; 
        }        
		/// <summary>
		/// DU_String5
        /// </summary>
        public virtual string DU_String5
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
   				.Append("\"DU_ID\":\"").Append(Uri.EscapeDataString(this.DU_ID.ToString())).Append("\",")
   				.Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID.ToString())).Append("\",")
   				.Append("\"E_ID\":\"").Append(Uri.EscapeDataString(this.E_ID.ToString())).Append("\",")
   				.Append("\"RoomID\":\"").Append(Uri.EscapeDataString(this.RoomID.ToString())).Append("\",")
   				.Append("\"DU_StartTime\":\"").Append(Uri.EscapeDataString(this.DU_StartTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
   				.Append("\"DU_EndTime\":\"").Append(Uri.EscapeDataString(this.DU_EndTime.ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
   				.Append("\"DU_TimeSpan\":\"").Append(Uri.EscapeDataString(this.DU_TimeSpan.ToString())).Append("\",")
   				.Append("\"DU_Number1\":\"").Append(Uri.EscapeDataString(this.DU_Number1 == null ? "" : this.DU_Number1.ToString())).Append("\",")
   				.Append("\"DU_Number2\":\"").Append(Uri.EscapeDataString(this.DU_Number2 == null ? "" : this.DU_Number2.ToString())).Append("\",")
   				.Append("\"DU_Number3\":\"").Append(Uri.EscapeDataString(this.DU_Number3 == null ? "" : this.DU_Number3.ToString())).Append("\",")
   				.Append("\"DU_Number4\":\"").Append(Uri.EscapeDataString(this.DU_Number4 == null ? "" : this.DU_Number4.ToString())).Append("\",")
   				.Append("\"DU_String1\":\"").Append(Uri.EscapeDataString(this.DU_String1 == null ? "" : this.DU_String1.ToString())).Append("\",")
   				.Append("\"DU_String2\":\"").Append(Uri.EscapeDataString(this.DU_String2 == null ? "" : this.DU_String2.ToString())).Append("\",")
   				.Append("\"DU_String3\":\"").Append(Uri.EscapeDataString(this.DU_String3 == null ? "" : this.DU_String3.ToString())).Append("\",")
   				.Append("\"DU_String4\":\"").Append(Uri.EscapeDataString(this.DU_String4 == null ? "" : this.DU_String4.ToString())).Append("\",")
   				.Append("\"DU_String5\":\"").Append(Uri.EscapeDataString(this.DU_String5 == null ? "" : this.DU_String5.ToString())).Append("\"")
   				.Append(close ? "}" : "")
                .ToString();
   		}
   		
   		#endregion
	}
 }

