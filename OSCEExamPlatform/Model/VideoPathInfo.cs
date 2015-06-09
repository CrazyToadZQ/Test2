using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    public class VideoPathInfo
    {
        /// <summary>
        /// 主键编号
        /// </summary>
        public virtual int VideoPathInfo_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 路径信息描述
        /// </summary>
        public virtual string Path_Description
        {
            get;
            set;
        }
        /// <summary>
        /// 视频存储根路径
        /// </summary>
        public virtual string Root_Path
        {
            get;
            set;
        }
        /// <summary>
        /// 服务器IP地址
        /// </summary>
        public virtual string Server_IP
        {
            get;
            set;
        }
        /// <summary>
        /// 服务器用户名
        /// </summary>
        public virtual string Server_Username
        {
            get;
            set;
        }
        /// <summary>
        /// 服务器用户密码
        /// </summary>
        public virtual string User_Password
        {
            get;
            set;
        }
    }
}
