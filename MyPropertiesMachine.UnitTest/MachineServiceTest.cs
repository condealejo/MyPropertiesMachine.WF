using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPropertiesMachine.Entities;
using MyPropertiesMachine.Services.Contract;
using MyPropertiesMachine.Services.Implementation;
using Newtonsoft.Json;

namespace MyPropertiesMachine.UnitTest
{
    [TestClass]
    public class MachineServiceTest
    {
        IMachineService machineService = new MachineService();

        /// <summary>
        /// Prueba de capa de servicio para obtener información de la maquina. 
        /// </summary>
        [TestMethod]
        public void GetMachinePropertiesTest()
        {
            //Arrange
            string json = Resources.MachineResourcesTest.MachineExpected;
            Machine machineExpected = JsonConvert.DeserializeObject<Machine>(json);
            var machineActual = machineService.GetMachineProperties();
            //Assert
            Assert.AreEqual(machineExpected.IP.Trim(), machineActual.IP.Trim(), "La dirección IP no es la esperada");
            Assert.AreEqual(machineExpected.SO.Trim(), machineActual.SO.Trim(), "El sistema operativo no es el valor esperado");
            Assert.AreEqual(machineExpected.MachineName.Trim(), machineActual.MachineName.Trim(), "El nombre de la maquina no es el valor esperado");
            Assert.AreEqual(machineExpected.CPU.Trim(), machineActual.CPU.Trim(), "la información de procesador no es el esperado");
        }

        /// <summary>
        /// prueba de servicio para descarga del archivo plano.
        /// </summary>
        [TestMethod]
        public void DownloadFileFlat()
        {
            var result = machineService.DownloadFileFlat(Resources.MachineResourcesTest.prmIPAddress, Resources.MachineResourcesTest.prmFileName);
            StringAssert.Contains(result, "Aranda");
        }
    }
}
