using MyPropertiesMachine.Entities;

namespace MyPropertiesMachine.Services.Contract
{
    public interface IMachineService
    {
        Machine GetMachineProperties();
        string DownloadFileFlat(string prmIPAddress, string prmFileName);
    }
}
