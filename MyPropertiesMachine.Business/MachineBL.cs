using MyPropertiesMachine.Data;
using MyPropertiesMachine.Entities;
using System;

namespace MyPropertiesMachine.Business
{
    public class MachineBL
    {
        //Obtiene información de maquina y consume capa de datos para almacenar en BD. Retorna entidad de tipo maquina.
        public Machine GetMachineProperties()
        {
            //Capturamos datos de maquina.
            Machine machine = new Machine();
            machine.MachineName = Environment.MachineName;
            machine.UserDomain = Environment.GetEnvironmentVariable("USERDOMAIN") ?? Environment.GetEnvironmentVariable("HOSTNAME");
            machine.SO = Environment.OSVersion.VersionString;
            machine.IP = MonitorMachineHardwareBL.GetIPAddressMachine();
            machine.HardDisk = MonitorMachineHardwareBL.GetHardDiskProperties();
            machine.RAM = MonitorMachineHardwareBL.GetMemoryRAMProperties();
            machine.CPU = MonitorMachineHardwareBL.getCPUProperties();

            //insertamos registro en BD
            new MachineDAL().InsertMachineProperties(machine);
            return machine;
        }

        //Genera el archivo txt en disco local.
        public string DownloadFileFlat(string prmIPAddress, string prmFileName)
        {
            var machinePropertiesList = new MachineDAL().GetMachinePropertiesByIP(prmIPAddress);
            return FileMachineBL.generateFileFlat(prmFileName, machinePropertiesList);
        }
    }
}
