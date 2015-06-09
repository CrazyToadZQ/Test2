using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Web;

namespace Tellyes.Common
{
    public class SetAppClass
    {
        /// <summary>
        /// 修改app.config中的appSettings中的一
        /// </summary>
        /// <param name="AppKey"></param>
        /// <param name="AppValue"></param>
        public static void SetValue(string AppKey, string AppValue)
        {

            XmlDocument xDoc = new XmlDocument();
            //加载app.config
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            xDoc.Load(path + "\\web.config");

            XmlNode xNode = xDoc.SelectSingleNode("//appSettings");

            XmlElement oldElement = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");

            if (oldElement != null)
            {
                oldElement.SetAttribute("value", AppValue);
            }
            else
            {
                XmlElement newElement = xDoc.CreateElement("add");
                newElement.SetAttribute("key", AppKey);
                newElement.SetAttribute("value", AppValue);
                xNode.AppendChild(newElement);
            }

            xDoc.Save(path + "\\web.config");
            //try
            //{
            //    Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/web.config");
            //    AppSettingsSection appseting = (AppSettingsSection)config.GetSection("appSettings");
            //    //appseting.Settings.Remove(AppKey);
            //    //appseting.Settings.Add(AppKey, AppValue);
            //    appseting.Settings["AdminPWD"].Value = AppValue;
            //    config.SaveAs("passWord.config",ConfigurationSaveMode.Modified);
            //}
            //catch (ConfigurationErrorsException ee)
            //{
            //    string a = "a";
            //}
          
        }

        /// <summary>
        /// 修改app.config中的appSettings中的一
        /// </summary>
        /// <param name="AppKey"></param>
        /// <param name="AppValue"></param>
        public static void SetValue(string AppKey, string AppValue,string path)
        {

            XmlDocument xDoc = new XmlDocument();
            //加载app.config
            //string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            xDoc.Load(path);

            XmlNode xNode = xDoc.SelectSingleNode("//appSettings");

            XmlElement oldElement = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");

            if (oldElement != null)
            {
                oldElement.SetAttribute("value", AppValue);
            }
            else
            {
                XmlElement newElement = xDoc.CreateElement("add");
                newElement.SetAttribute("key", AppKey);
                newElement.SetAttribute("value", AppValue);
                xNode.AppendChild(newElement);
            }
            xDoc.Save(path);
        }

        /// <summary>
        /// 修改app.config中的appSettings中的一
        /// </summary>
        /// <param name="AppKey"></param>
        /// <param name="AppValue"></param>
        public static string GetValue(string AppKey)
        {

            XmlDocument xDoc = new XmlDocument();
            //加载app.config
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            xDoc.Load(path + "\\web.config");

            XmlNode xNode = xDoc.SelectSingleNode("//appSettings");

            XmlElement oldElement = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");

            if (oldElement != null)
            {
                return oldElement.GetAttribute("value");
            }
            return null;
        }
    }
}
