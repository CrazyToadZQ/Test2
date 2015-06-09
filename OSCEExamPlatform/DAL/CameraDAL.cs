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
    public class CameraDAL : BaseDAL<Camera>
    {
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            if (conditionDictionary.ContainsKey("CameraIP_Exists"))
            {
                criteria.Add(Restrictions.Eq("CameraIP", conditionDictionary["CameraIP_Exists"]));
            }

            if (conditionDictionary.ContainsKey("ParentRoomID_Is"))
            {
                criteria.Add(Restrictions.Eq("ParentRoomID", 0));
            }

            if (conditionDictionary.ContainsKey("ParentRoomID"))
            {
                criteria.Add(Restrictions.Eq("ParentRoomID", conditionDictionary["ParentRoomID"]));
            }

            if (conditionDictionary.ContainsKey("ChildRoomID"))
            {
                criteria.Add(Restrictions.Eq("ChildRoomID", conditionDictionary["ChildRoomID"]));
            }

            if (conditionDictionary.ContainsKey("RoomID")) 
            {
                criteria.Add
                (
                    Restrictions.Or
                    (
                        Restrictions.Eq("ParentRoomID", conditionDictionary["RoomID"]), 
                        Restrictions.Eq("ChildRoomID", conditionDictionary["RoomID"])
                    )
                );
            }

            return criteria;
        }
    }
}
