
namespace MyPropertiesMachine.WF
{
    partial class FrmInput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInput));
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.grpInformationMachine = new System.Windows.Forms.GroupBox();
            this.lblHardDisk = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.btnGetMachineProperties = new System.Windows.Forms.Button();
            this.lblDescriptionMachine = new System.Windows.Forms.Label();
            this.grpContainer.SuspendLayout();
            this.grpInformationMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.Controls.Add(this.grpInformationMachine);
            this.grpContainer.Controls.Add(this.btnGetMachineProperties);
            this.grpContainer.Controls.Add(this.lblDescriptionMachine);
            this.grpContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpContainer.Location = new System.Drawing.Point(13, 13);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(563, 459);
            this.grpContainer.TabIndex = 0;
            this.grpContainer.TabStop = false;
            // 
            // grpInformationMachine
            // 
            this.grpInformationMachine.Controls.Add(this.lblHardDisk);
            this.grpInformationMachine.Controls.Add(this.lblSO);
            this.grpInformationMachine.Controls.Add(this.btnExportReport);
            this.grpInformationMachine.Controls.Add(this.lblMachineName);
            this.grpInformationMachine.Controls.Add(this.lblCreationDate);
            this.grpInformationMachine.Controls.Add(this.lblIP);
            this.grpInformationMachine.Controls.Add(this.lblCPU);
            this.grpInformationMachine.Controls.Add(this.lblRAM);
            this.grpInformationMachine.Location = new System.Drawing.Point(7, 159);
            this.grpInformationMachine.Name = "grpInformationMachine";
            this.grpInformationMachine.Size = new System.Drawing.Size(534, 294);
            this.grpInformationMachine.TabIndex = 9;
            this.grpInformationMachine.TabStop = false;
            // 
            // lblHardDisk
            // 
            this.lblHardDisk.AutoSize = true;
            this.lblHardDisk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHardDisk.Location = new System.Drawing.Point(20, 117);
            this.lblHardDisk.Name = "lblHardDisk";
            this.lblHardDisk.Size = new System.Drawing.Size(88, 20);
            this.lblHardDisk.TabIndex = 9;
            this.lblHardDisk.Text = "Disco duro: ";
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSO.Location = new System.Drawing.Point(20, 23);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(136, 20);
            this.lblSO.TabIndex = 2;
            this.lblSO.Text = "Sistema operativo: ";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(20, 247);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(160, 29);
            this.btnExportReport.TabIndex = 8;
            this.btnExportReport.Text = "Exportar reporte";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMachineName.Location = new System.Drawing.Point(20, 55);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(170, 20);
            this.lblMachineName.TabIndex = 3;
            this.lblMachineName.Text = "Nombre de la maquina: ";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreationDate.Location = new System.Drawing.Point(20, 208);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(111, 20);
            this.lblCreationDate.TabIndex = 7;
            this.lblCreationDate.Text = "Fecha Reporte: ";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIP.Location = new System.Drawing.Point(20, 87);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(95, 20);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "Dirección IP: ";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPU.Location = new System.Drawing.Point(20, 177);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(90, 20);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "Procesador: ";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRAM.Location = new System.Drawing.Point(20, 146);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(48, 20);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "RAM: ";
            // 
            // btnGetMachineProperties
            // 
            this.btnGetMachineProperties.Location = new System.Drawing.Point(7, 124);
            this.btnGetMachineProperties.Name = "btnGetMachineProperties";
            this.btnGetMachineProperties.Size = new System.Drawing.Size(169, 29);
            this.btnGetMachineProperties.TabIndex = 1;
            this.btnGetMachineProperties.Text = "Obtener datos";
            this.btnGetMachineProperties.UseVisualStyleBackColor = true;
            this.btnGetMachineProperties.Click += new System.EventHandler(this.btnGetMachineProperties_Click);
            // 
            // lblDescriptionMachine
            // 
            this.lblDescriptionMachine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionMachine.Location = new System.Drawing.Point(7, 27);
            this.lblDescriptionMachine.Name = "lblDescriptionMachine";
            this.lblDescriptionMachine.Size = new System.Drawing.Size(534, 76);
            this.lblDescriptionMachine.TabIndex = 0;
            this.lblDescriptionMachine.Text = "TextCustom";
            // 
            // FrmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 484);
            this.Controls.Add(this.grpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba Aranda";
            this.Load += new System.EventHandler(this.FrmInput_Load);
            this.grpContainer.ResumeLayout(false);
            this.grpInformationMachine.ResumeLayout(false);
            this.grpInformationMachine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Label lblDescriptionMachine;
        private System.Windows.Forms.Button btnGetMachineProperties;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.GroupBox grpInformationMachine;
        private System.Windows.Forms.Label lblHardDisk;
    }
}

