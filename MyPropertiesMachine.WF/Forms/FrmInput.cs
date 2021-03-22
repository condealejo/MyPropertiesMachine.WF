using MyPropertiesMachine.Entities;
using MyPropertiesMachine.Services.Contract;
using System;
using System.Windows.Forms;


namespace MyPropertiesMachine.WF
{
    public partial class FrmInput : Form
    {
        readonly IMachineService MachineService;
        Machine machineGlobal = new Machine();
        public FrmInput(IMachineService machineService)
        {
            InitializeComponent();
            MachineService = machineService;
        }

        #region EventsForm
        private void FrmInput_Load(object sender, EventArgs e)
        {
            lblDescriptionMachine.Text = Resources.MyResources.DescriptionMachineLabel;
            HideInformation(true);
        }

        private void btnGetMachineProperties_Click(object sender, EventArgs e)
        {
            RestartLabelsText();
            GetMachineProperties();
            HideInformation(false);
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            var fileName = MachineService.DownloadFileFlat(machineGlobal.IP, Resources.MyResources.NameFileOutPut);
            MessageBox.Show("El archivo " + fileName + " ha sido descargado, por favor revisar la carpeta 'Mis Documentos' o 'Home' de acuerdo a su sistema operativo", "Archivo descargado correctamente", MessageBoxButtons.OK);
        }
        #endregion


        #region LogicFront
        private void RestartLabelsText()
        {
            lblSO.Text = "Sistema operativo: ";
            lblMachineName.Text = "Disco duro: ";
            lblIP.Text = "Dirección IP: ";
            lblHardDisk.Text = "Disco duro: ";
            lblRAM.Text = "RAM: ";
            lblCPU.Text = "Procesador: ";
            lblCreationDate.Text = "Fecha Reporte: ";
        }

        private void HideInformation(bool show)
        {
            if (show)
                grpInformationMachine.Hide();
            else
                grpInformationMachine.Show();

        }

        private void GetMachineProperties()
        {

            var machine = MachineService.GetMachineProperties();
            if (machine != null)
            {
                lblSO.Text += machine.SO;
                lblMachineName.Text += machine.MachineName;
                lblIP.Text += machine.IP;
                lblHardDisk.Text += machine.HardDisk;
                lblRAM.Text += machine.RAM;
                lblCPU.Text += machine.CPU;
                lblCreationDate.Text += machine.CreationDate.ToString();

                machineGlobal.IP = machine.IP;
            }
        }
        #endregion

    }
}
