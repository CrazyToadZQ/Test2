using Tellyes.Log4Net;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NHibernate.SqlCommand;

namespace Tellyes.NHibernate
{
    public class SessionManager
    {
        private static ISessionFactory _sessionFactory;
        static SessionManager()
        {
            try
            {
                Configuration cfg = new Configuration();
                string binPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string webFileName = binPath + @"bin\Config\NHibernate.cfg.xml";
                string appFileName = binPath + @"Config\NHibernate.cfg.xml";
                if (File.Exists(webFileName))
                    cfg.Configure(webFileName);
                else if (File.Exists(appFileName))
                    cfg.Configure(appFileName);
                else
                    throw new Exception("找不到NHibernate配置文件");
                _sessionFactory = cfg.BuildSessionFactory();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "数据库连接失败", e);
            }
        }
        public static ISession OpenSession()
        {
            try
            {
                return _sessionFactory.OpenSession();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "NHibernate Session打开失败", e);
                return null;
            }
        }
        public static void CloseSession(ISession session)
        {
            if (session == null)
                return;
            try
            {
                session.Close();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "NHibernate Session关闭失败", e);
            }
        }
        public static void DisposeTransaction(ITransaction transaction)
        {
            if (transaction == null)
                return;
            try
            {
                transaction.Dispose();
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "NHibernate Transaction关闭失败", e);
            }
        }
        public static string GetEntityTableName(string entityName)
        {
            string binPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string webFileName = binPath + @"bin\Mapping\" + entityName + ".hbm.xml";
            string appFileName = binPath + @"Mapping\" + entityName + ".hbm.xml";
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists(webFileName))
                    xmlDoc.Load(webFileName);
                else if (File.Exists(appFileName))
                    xmlDoc.Load(appFileName);
                else
                    return null;
                XmlElement element = (XmlElement)xmlDoc.GetElementsByTagName("class")[0];
                string tableName = element.GetAttribute("table");
                return tableName;
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "获取实体对应数据表名称失败", e);
                return null;
            }
        }
        public static List<Dictionary<string, string>> GetEntityPropertyList(string entityName)
        {
            string binPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string webFileName = binPath + @"bin\Mapping\" + entityName + ".hbm.xml";
            string appFileName = binPath + @"Mapping\" + entityName + ".hbm.xml";
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists(webFileName))
                    xmlDoc.Load(webFileName);
                else if (File.Exists(appFileName))
                    xmlDoc.Load(appFileName);
                else
                    return null;
                List<Dictionary<string, string>> entityPropertyList = new List<Dictionary<string, string>>();
                XmlElement element = (XmlElement)xmlDoc.GetElementsByTagName("id")[0];
                entityPropertyList.Add(new Dictionary<string, string>() 
                {
                    {"name", element.GetAttribute("name")},
                    {"column", element.GetAttribute("column")},
                    {"type", element.GetAttribute("type")}
                });
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName("property");
                foreach (XmlNode node in nodeList)
                {
                    element = (XmlElement)node;
                    entityPropertyList.Add(new Dictionary<string, string>() 
                    {
                        {"name", element.GetAttribute("name")},
                        {"column", element.GetAttribute("column")},
                        {"type", element.GetAttribute("type")}
                    });
                }
                return entityPropertyList;
            }
            catch (Exception e)
            {
                Log4NetUtility.Error("Tellyes.NHibernate.SessionManager", "获取实体对应属性失败", e);
                return null;
            }
        }
    }
}
