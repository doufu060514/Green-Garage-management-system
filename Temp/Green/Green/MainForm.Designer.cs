namespace Green
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEquipmentAllocation = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnServiceType = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnEquipmentAllocation);
            this.grpMaintenance.Controls.Add(this.btnService);
            this.grpMaintenance.Controls.Add(this.btnVehicle);
            this.grpMaintenance.Controls.Add(this.btnEquipment);
            this.grpMaintenance.Controls.Add(this.btnServiceType);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Location = new System.Drawing.Point(51, 54);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(351, 517);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEquipmentAllocation
            // 
            this.btnEquipmentAllocation.Location = new System.Drawing.Point(45, 401);
            this.btnEquipmentAllocation.Name = "btnEquipmentAllocation";
            this.btnEquipmentAllocation.Size = new System.Drawing.Size(252, 32);
            this.btnEquipmentAllocation.TabIndex = 7;
            this.btnEquipmentAllocation.Text = "Equipment Allocation";
            this.btnEquipmentAllocation.UseVisualStyleBackColor = true;
            this.btnEquipmentAllocation.Click += new System.EventHandler(this.btnEquipmentAllocation_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(45, 328);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(252, 32);
            this.btnService.TabIndex = 6;
            this.btnService.Text = "Service  Maintenance";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(45, 257);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(252, 32);
            this.btnVehicle.TabIndex = 5;
            this.btnVehicle.Text = "Vehicle  Maintenance";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(45, 185);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(252, 32);
            this.btnEquipment.TabIndex = 4;
            this.btnEquipment.Text = "Equipment  Maintenance";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnServiceType
            // 
            this.btnServiceType.Location = new System.Drawing.Point(45, 112);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(252, 32);
            this.btnServiceType.TabIndex = 3;
            this.btnServiceType.Text = "Service Type  Maintenance";
            this.btnServiceType.UseVisualStyleBackColor = true;
            this.btnServiceType.Click += new System.EventHandler(this.btnServiceType_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(45, 45);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(252, 32);
            this.btnOwner.TabIndex = 2;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(446, 54);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(351, 517);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(52, 45);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(252, 32);
            this.btnInvoices.TabIndex = 2;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 611);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.MinimumSize = new System.Drawing.Size(870, 650);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnEquipmentAllocation;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnServiceType;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnExit;
    }
}

