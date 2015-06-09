using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace Tellyes.Common
{
    public class OSCEServerInformation
    {
        /// <summary>
        /// 获取服务器CPU ID
        /// </summary>
        /// <returns></returns>
        public static string SearchServerProcessorID()
        {
            List<string> processorIDList = new List<string>();
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                processorIDList.Add(mo["processorid"].ToString().Trim());
            }
            moc.Dispose();
            mc.Dispose();
            processorIDList.Sort();
            return string.Join<string>(",", processorIDList);
        }

        /// <summary>
        /// 获取服务器主板ID
        /// </summary>
        /// <returns></returns>
        public static string SearchServerBaseBoardID()
        {
            List<string> baseBoardIDList = new List<string>();
            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                baseBoardIDList.Add(mo.Properties["SerialNumber"].Value.ToString().Trim());
            }
            moc.Dispose();
            mc.Dispose();
            baseBoardIDList.Sort();
            return string.Join<string>(",", baseBoardIDList);
        }

        /// <summary>
        /// 获取服务器BIOS ID
        /// </summary>
        /// <returns></returns>
        public static string SearchBiosID() 
        {
            List<string> biosIDList = new List<string>();
            ManagementClass mc = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                biosIDList.Add(mo.Properties["SerialNumber"].Value.ToString().Trim());
            }
            moc.Dispose();
            mc.Dispose();
            biosIDList.Sort();
            return string.Join<string>(",", biosIDList);
        }

        /// <summary>
        /// 获取服务器硬盘ID
        /// </summary>
        /// <returns></returns>
        public static string SearchDiskDriveID()
        {
            List<string> diskDriveIDList = new List<string>();
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                diskDriveIDList.Add(mo.Properties["SerialNumber"].Value.ToString().Trim());
            }
            moc.Dispose();
            mc.Dispose();
            diskDriveIDList.Sort();
            return string.Join<string>(",", diskDriveIDList);
        }

        /// <summary>
        /// 获取服务器MAC地址
        /// </summary>
        /// <returns></returns>
        public static string SearchMacAddress()
        {
            List<string> macAddressList = new List<string>();
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    macAddressList.Add(mo["MacAddress"].ToString().Trim());
                }
            }
            moc.Dispose();
            mc.Dispose();
            macAddressList.Sort();
            return string.Join<string>(",", macAddressList);
        }
    }
}
