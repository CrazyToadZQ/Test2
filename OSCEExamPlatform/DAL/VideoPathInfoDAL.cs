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
    public class VideoPathInfoDAL : BaseDAL<VideoPathInfo>
    {
        public VideoPathInfo SelectUniqueVideoPathInfo()
        {
            ISession session = null;
            try
            {
                session = SessionManager.OpenSession();
                return session.CreateCriteria<VideoPathInfo>()
                    .SetFirstResult(0)
                    .SetMaxResults(1)
                    .UniqueResult<VideoPathInfo>();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error(this, "查询视频存储根目录信息失败", e);
                return null;
            }
            finally
            {
                SessionManager.CloseSession(session);
            }
        }

        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            return criteria;
        }
    }
}
