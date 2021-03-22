using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyPropertiesMachine.Business
{
    public static class MonitorMachineCPUBL
    {
        public static string VendorId { get; private set; }
        public static int CpuFamily { get; private set; }
        public static int Model { get; private set; }
        public static string ModelName { get; private set; }
        public static int Stepping { get; private set; }
        public static double MHz { get; private set; }
        public static string CacheSize { get; private set; }

        public static void GetValues()
        {
            string[] cpuInfoLines = File.ReadAllLines(@"/proc/cpuinfo");

            CpuInfoMatch[] cpuInfoMatches =
            {
                new CpuInfoMatch(@"^vendor_id\s+:\s+(.+)", value => VendorId = value),
                new CpuInfoMatch(@"^cpu family\s+:\s+(.+)", value => CpuFamily = int.Parse(value)),
                new CpuInfoMatch(@"^model\s+:\s+(.+)", value => Model = int.Parse(value)),
                new CpuInfoMatch(@"^model name\s+:\s+(.+)", value => ModelName = value),
                new CpuInfoMatch(@"^stepping\s+:\s+(.+)", value => Stepping = int.Parse(value)),
                new CpuInfoMatch(@"^cpu MHz\s+:\s+(.+)", value => MHz = double.Parse(value)),
                new CpuInfoMatch(@"^cache size\s+:\s+(.+)", value => CacheSize = value)
            };

            foreach (string cpuInfoLine in cpuInfoLines)
            {
                foreach (CpuInfoMatch cpuInfoMatch in cpuInfoMatches)
                {
                    Match match = cpuInfoMatch.regex.Match(cpuInfoLine);
                    if (match.Groups[0].Success)
                    {
                        string value = match.Groups[1].Value;
                        cpuInfoMatch.updateValue(value);
                    }
                }
            }
        }

        public static string GetProcessorName()
        {
            var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0\");
            return key?.GetValue("ProcessorNameString").ToString() ?? "No se encontro nombre de Procesador";
        }
    }

    class CpuInfoMatch
    {
        public Regex regex;
        public Action<string> updateValue;

        public CpuInfoMatch(string pattern, Action<string> update)
        {
            regex = new Regex(pattern, RegexOptions.Compiled);
            updateValue = update;
        }
    }


}
