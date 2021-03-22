using MyPropertiesMachine.Business;
using MyPropertiesMachine.Entities;
using MyPropertiesMachine.Services.Contract;

namespace MyPropertiesMachine.Services.Implementation
{
    public class MachineService : IMachineService
    {
        /// <summary>
        /// Obtiene la información de la maquina. 
        /// </summary>
        /// <returns></returns>
        public Machine GetMachineProperties()
        {
            var machine = new MachineBL().GetMachineProperties();
            return machine;
        }

        /// <summary>
        /// Genera el archivo plano con la informacíón de la BD, filtrando por la dirección IP
        /// </summary>
        /// <param name="prmIPAddress">IP para buscar en BD</param>
        /// <param name="prmFileName">Nombre base para archivo plano.</param>
        /// <returns></returns>
        public string DownloadFileFlat(string prmIPAddress, string prmFileName)
        {
            var fileName = new MachineBL().DownloadFileFlat(prmIPAddress, prmFileName);
            return fileName;

        }
    }
}
