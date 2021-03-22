using MyPropertiesMachine.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyPropertiesMachine.Business
{
    public static class FileMachineBL
    {
        //Genera archivo plano en disco local.
        public static string generateFileFlat(string prmFileName, List<Machine> prmMachineList)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            prmFileName = prmFileName.Replace("{date}", DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            using (TextWriter tw = new StreamWriter(Path.Combine(docPath, prmFileName)))
            {
                tw.WriteLine("SistemaOperativo;NombreMaquina;DireccionIP;DiscoDuro;RAM;Procesador;FechaRegistro");
                foreach (var prop in prmMachineList)
                {
                    tw.WriteLine(prop.SO + ";" + prop.MachineName + ";" + prop.IP + ";" + prop.HardDisk + ";" + prop.RAM + ";" + prop.CPU + ";" + prop.CreationDate.ToLocalTime().ToString());
                }
            }
            return prmFileName;
        }
    }
}
