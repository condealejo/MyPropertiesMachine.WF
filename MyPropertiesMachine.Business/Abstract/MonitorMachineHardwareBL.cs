using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace MyPropertiesMachine.Business
{
    public class MonitorMachineHardwareBL
    {
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public static string SizeSuffix(long value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }
            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }
            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        public static string GetIPAddressMachine()
        {
            string ipResult = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipResult = ip.ToString();
                }
            }
            return ipResult;
        }

        public static string GetHardDiskProperties()
        {
            string hardDiskResult = string.Empty;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            if (allDrives != null && allDrives.Any())
            {
                long freeSpace = allDrives[0].TotalFreeSpace;
                long totalSpace = allDrives[0].TotalSize;
                long spaceConsumed = totalSpace - freeSpace;
                double percentConsumed = (spaceConsumed * 100) / totalSpace;

                var totalSpaceDisk = SizeSuffix(spaceConsumed);
                hardDiskResult = allDrives[0].Name + " -> " + totalSpaceDisk + " -> " + "Usado: " + Math.Round(percentConsumed, 1) + "%";
            }
            return hardDiskResult;
        }

        public static string GetMemoryRAMProperties()
        {
            string ramResult = string.Empty;
            var available = MonitorMachineRAMBL.GetRAMAvailable();
            var totalRAM = MonitorMachineRAMBL.GetTotalRAM();
            var usage = totalRAM - available;
            var percentUsage = (usage * 100) / totalRAM;
            var strTotalRAM = SizeSuffix((totalRAM * 1024) * 1024, 0);
            ramResult = " " + strTotalRAM + " -> Usado: " + percentUsage + "%";
            return ramResult;
        }

        public static string getCPUProperties()
        {
            string cpuResult = string.Empty;
            bool isLinuxOrMac = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            if (isLinuxOrMac)
            {
                MonitorMachineCPUBL.GetValues();
                cpuResult = MonitorMachineCPUBL.VendorId + " -> " + MonitorMachineCPUBL.CpuFamily + " -> " + MonitorMachineCPUBL.ModelName;
            }
            else
            {
                cpuResult = MonitorMachineCPUBL.GetProcessorName();
            }
            return cpuResult;
        }


    }
}
