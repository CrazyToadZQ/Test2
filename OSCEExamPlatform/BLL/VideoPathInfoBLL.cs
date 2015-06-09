using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tellyes.Model;
using Tellyes.DAL;

namespace Tellyes.BLL
{
    public class VideoPathInfoBLL
    {
        /// <summary>
        /// 查询视频存储根路径信息
        /// </summary>
        /// <returns>VideoPathInfo</returns>
        public VideoPathInfo SearchVideoPathInfo()
        {
            return new VideoPathInfoDAL().SelectUniqueVideoPathInfo();
        }
    }
}
