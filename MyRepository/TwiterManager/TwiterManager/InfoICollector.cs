using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitterizer;
using System.Diagnostics;
using System.IO;

namespace TwiterManager
{
    class InfoICollector
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private float ramFree;
        private float cpuLoad;
        private DriveInfo[] allDrives;


        public float RAMFree { get => ramFree; set => ramFree = value; }
        public PerformanceCounter CpuCounter { get => cpuCounter; set => cpuCounter = value; }
        public float CPULoad { get => cpuLoad; set => cpuLoad = value; }
        public PerformanceCounter RamCounter { get => ramCounter; set => ramCounter = value; }
        public DriveInfo[] AllDrives { get => allDrives; set => allDrives = value; }

        public InfoICollector()
        {
            CPUAndMemoryInfoInit();
            DiskInfo();
        }

        public void CPUAndMemoryInfoInit()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory","Available MBytes");
            ramFree = ramCounter.NextValue();
            cpuLoad = cpuCounter.NextValue();
        }

        public void DiskInfo()
        {
            AllDrives = DriveInfo.GetDrives();
        }

        public string GetDriveInfo(DriveInfo d)
        {
            string tmpstr =  "Drive : " + d.Name + "  Drive type : " + d.DriveType;
            if (d.IsReady == true)
            {
                ulong driveTotalFreeSpace = Convert.ToUInt64(d.TotalFreeSpace) / 1073741824;
                ulong driveTotalSize = Convert.ToUInt64(d.TotalSize) / 1073741824;
                tmpstr += " File system : " + d.DriveFormat;
                tmpstr += " Total available space : " + driveTotalFreeSpace.ToString() + "Gb";
                tmpstr += " Total size of drive : " + driveTotalSize.ToString() + "Gb" + "@";

            }
            return tmpstr;
        }

        public string MessageComposer()
        {
            string message =  "Memory available:" + RAMFree.ToString() + "Mb";
            message += " CPU load:" + CPULoad.ToString() + "%" + "@";
            foreach (DriveInfo d in AllDrives)
            {
                 message+=(GetDriveInfo(d));
            }
            return message;

        }


    }
}
