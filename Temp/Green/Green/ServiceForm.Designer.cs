namespace Green
{
    partial class ServiceForm
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDrscription = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnModifyService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.pnlAddService = new System.Windows.Forms.Panel();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAddServiceType = new System.Windows.Forms.ComboBox();
            this.cmbAddVehicle = new System.Windows.Forms.ComboBox();
            this.txtAddHours = new System.Windows.Forms.TextBox();
            this.lblAddHours = new System.Windows.Forms.Label();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.lblAddServiceType = new System.Windows.Forms.Label();
            this.lblAddVehicle = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.pnlModifyService = new System.Windows.Forms.Panel();
            this.txtModifyServiceType = new System.Windows.Forms.TextBox();
            this.txtModifyVehicle = new System.Windows.Forms.TextBox();
            this.dtpModifyDate = new System.Windows.Forms.DateTimePicker();
            this.txtModifyHours = new System.Windows.Forms.TextBox();
            this.lblModifyHours = new System.Windows.Forms.Label();
            this.lblModifyDate = new System.Windows.Forms.Label();
            this.lblModifyServiceType = new System.Windows.Forms.Label();
            this.lblModifyVehicle = new System.Windows.Forms.Label();
            this.btnModifySave = new System.Windows.Forms.Button();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.btnMarkAsPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.pnlAddService.SuspendLayout();
            this.pnlModifyService.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(12, 12);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(558, 421);
            this.dgvService.TabIndex = 0;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(599, 23);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(125, 20);
            this.lblVehicle.TabIndex = 1;
            this.lblVehicle.Text = "Vehicle\'s Details";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(600, 65);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(49, 16);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Owner:";
            // 
            // txtOwner
            // 
            this.txtOwner.Enabled = false;
            this.txtOwner.Location = new System.Drawing.Point(699, 65);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(151, 20);
            this.txtOwner.TabIndex = 3;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Enabled = false;
            this.txtPlateNumber.Location = new System.Drawing.Point(699, 110);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(151, 20);
            this.txtPlateNumber.TabIndex = 5;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.Location = new System.Drawing.Point(600, 110);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(93, 16);
            this.lblPlateNumber.TabIndex = 4;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(599, 186);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(152, 20);
            this.lblServiceType.TabIndex = 6;
            this.lblServiceType.Text = "Service Type Details";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(699, 285);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(151, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDrscription
            // 
            this.lblDrscription.AutoSize = true;
            this.lblDrscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrscription.Location = new System.Drawing.Point(600, 285);
            this.lblDrscription.Name = "lblDrscription";
            this.lblDrscription.Size = new System.Drawing.Size(79, 16);
            this.lblDrscription.TabIndex = 9;
            this.lblDrscription.Text = "Description:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Enabled = false;
            this.txtHourlyRate.Location = new System.Drawing.Point(699, 240);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(151, 20);
            this.txtHourlyRate.TabIndex = 8;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(600, 240);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(82, 16);
            this.lblHourlyRate.TabIndex = 7;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(748, 476);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 32);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(12, 476);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(102, 32);
            this.btnAddService.TabIndex = 43;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnModifyService
            // 
            this.btnModifyService.Location = new System.Drawing.Point(201, 476);
            this.btnModifyService.Name = "btnModifyService";
            this.btnModifyService.Size = new System.Drawing.Size(102, 32);
            this.btnModifyService.TabIndex = 44;
            this.btnModifyService.Text = "Modify Service";
            this.btnModifyService.UseVisualStyleBackColor = true;
            this.btnModifyService.Click += new System.EventHandler(this.btnModifyService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(392, 476);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(102, 32);
            this.btnDeleteService.TabIndex = 45;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // pnlAddService
            // 
            this.pnlAddService.Controls.Add(this.dtpAddDate);
            this.pnlAddService.Controls.Add(this.cmbAddServiceType);
            this.pnlAddService.Controls.Add(this.cmbAddVehicle);
            this.pnlAddService.Controls.Add(this.txtAddHours);
            this.pnlAddService.Controls.Add(this.lblAddHours);
            this.pnlAddService.Controls.Add(this.lblAddDate);
            this.pnlAddService.Controls.Add(this.lblAddServiceType);
            this.pnlAddService.Controls.Add(this.lblAddVehicle);
            this.pnlAddService.Controls.Add(this.btnAddSave);
            this.pnlAddService.Controls.Add(this.btnAddCancel);
            this.pnlAddService.Location = new System.Drawing.Point(56, 23);
            this.pnlAddService.Name = "pnlAddService";
            this.pnlAddService.Size = new System.Drawing.Size(247, 421);
            this.pnlAddService.TabIndex = 46;
            this.pnlAddService.Visible = false;
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddDate.Location = new System.Drawing.Point(102, 179);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(121, 20);
            this.dtpAddDate.TabIndex = 78;
            // 
            // cmbAddServiceType
            // 
            this.cmbAddServiceType.FormattingEnabled = true;
            this.cmbAddServiceType.Location = new System.Drawing.Point(102, 80);
            this.cmbAddServiceType.Name = "cmbAddServiceType";
            this.cmbAddServiceType.Size = new System.Drawing.Size(121, 21);
            this.cmbAddServiceType.TabIndex = 77;
            // 
            // cmbAddVehicle
            // 
            this.cmbAddVehicle.FormattingEnabled = true;
            this.cmbAddVehicle.Location = new System.Drawing.Point(102, 26);
            this.cmbAddVehicle.Name = "cmbAddVehicle";
            this.cmbAddVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddVehicle.TabIndex = 76;
            // 
            // txtAddHours
            // 
            this.txtAddHours.Location = new System.Drawing.Point(102, 131);
            this.txtAddHours.Name = "txtAddHours";
            this.txtAddHours.Size = new System.Drawing.Size(121, 20);
            this.txtAddHours.TabIndex = 75;
            // 
            // lblAddHours
            // 
            this.lblAddHours.AutoSize = true;
            this.lblAddHours.Location = new System.Drawing.Point(23, 134);
            this.lblAddHours.Name = "lblAddHours";
            this.lblAddHours.Size = new System.Drawing.Size(38, 13);
            this.lblAddHours.TabIndex = 74;
            this.lblAddHours.Text = "Hours:";
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Location = new System.Drawing.Point(23, 185);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(33, 13);
            this.lblAddDate.TabIndex = 72;
            this.lblAddDate.Text = "Date:";
            // 
            // lblAddServiceType
            // 
            this.lblAddServiceType.AutoSize = true;
            this.lblAddServiceType.Location = new System.Drawing.Point(23, 83);
            this.lblAddServiceType.Name = "lblAddServiceType";
            this.lblAddServiceType.Size = new System.Drawing.Size(73, 13);
            this.lblAddServiceType.TabIndex = 68;
            this.lblAddServiceType.Text = "Service Type:";
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Location = new System.Drawing.Point(23, 30);
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(45, 13);
            this.lblAddVehicle.TabIndex = 66;
            this.lblAddVehicle.Text = "Vehicle:";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(132, 386);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(102, 32);
            this.btnAddSave.TabIndex = 65;
            this.btnAddSave.Text = "Save Service";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(3, 386);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(102, 32);
            this.btnAddCancel.TabIndex = 64;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // pnlModifyService
            // 
            this.pnlModifyService.Controls.Add(this.txtModifyServiceType);
            this.pnlModifyService.Controls.Add(this.txtModifyVehicle);
            this.pnlModifyService.Controls.Add(this.dtpModifyDate);
            this.pnlModifyService.Controls.Add(this.txtModifyHours);
            this.pnlModifyService.Controls.Add(this.lblModifyHours);
            this.pnlModifyService.Controls.Add(this.lblModifyDate);
            this.pnlModifyService.Controls.Add(this.lblModifyServiceType);
            this.pnlModifyService.Controls.Add(this.lblModifyVehicle);
            this.pnlModifyService.Controls.Add(this.btnModifySave);
            this.pnlModifyService.Controls.Add(this.btnModifyCancel);
            this.pnlModifyService.Location = new System.Drawing.Point(323, 23);
            this.pnlModifyService.Name = "pnlModifyService";
            this.pnlModifyService.Size = new System.Drawing.Size(247, 421);
            this.pnlModifyService.TabIndex = 79;
            this.pnlModifyService.Visible = false;
            // 
            // txtModifyServiceType
            // 
            this.txtModifyServiceType.Enabled = false;
            this.txtModifyServiceType.Location = new System.Drawing.Point(102, 80);
            this.txtModifyServiceType.Name = "txtModifyServiceType";
            this.txtModifyServiceType.Size = new System.Drawing.Size(121, 20);
            this.txtModifyServiceType.TabIndex = 80;
            // 
            // txtModifyVehicle
            // 
            this.txtModifyVehicle.Enabled = false;
            this.txtModifyVehicle.Location = new System.Drawing.Point(102, 27);
            this.txtModifyVehicle.Name = "txtModifyVehicle";
            this.txtModifyVehicle.Size = new System.Drawing.Size(121, 20);
            this.txtModifyVehicle.TabIndex = 79;
            // 
            // dtpModifyDate
            // 
            this.dtpModifyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModifyDate.Location = new System.Drawing.Point(102, 179);
            this.dtpModifyDate.Name = "dtpModifyDate";
            this.dtpModifyDate.Size = new System.Drawing.Size(121, 20);
            this.dtpModifyDate.TabIndex = 78;
            // 
            // txtModifyHours
            // 
            this.txtModifyHours.Location = new System.Drawing.Point(102, 131);
            this.txtModifyHours.Name = "txtModifyHours";
            this.txtModifyHours.Size = new System.Drawing.Size(121, 20);
            this.txtModifyHours.TabIndex = 75;
            // 
            // lblModifyHours
            // 
            this.lblModifyHours.AutoSize = true;
            this.lblModifyHours.Location = new System.Drawing.Point(23, 134);
            this.lblModifyHours.Name = "lblModifyHours";
            this.lblModifyHours.Size = new System.Drawing.Size(38, 13);
            this.lblModifyHours.TabIndex = 74;
            this.lblModifyHours.Text = "Hours:";
            // 
            // lblModifyDate
            // 
            this.lblModifyDate.AutoSize = true;
            this.lblModifyDate.Location = new System.Drawing.Point(23, 185);
            this.lblModifyDate.Name = "lblModifyDate";
            this.lblModifyDate.Size = new System.Drawing.Size(33, 13);
            this.lblModifyDate.TabIndex = 72;
            this.lblModifyDate.Text = "Date:";
            // 
            // lblModifyServiceType
            // 
            this.lblModifyServiceType.AutoSize = true;
            this.lblModifyServiceType.Location = new System.Drawing.Point(23, 83);
            this.lblModifyServiceType.Name = "lblModifyServiceType";
            this.lblModifyServiceType.Size = new System.Drawing.Size(73, 13);
            this.lblModifyServiceType.TabIndex = 68;
            this.lblModifyServiceType.Text = "Service Type:";
            // 
            // lblModifyVehicle
            // 
            this.lblModifyVehicle.AutoSize = true;
            this.lblModifyVehicle.Location = new System.Drawing.Point(23, 30);
            this.lblModifyVehicle.Name = "lblModifyVehicle";
            this.lblModifyVehicle.Size = new System.Drawing.Size(45, 13);
            this.lblModifyVehicle.TabIndex = 66;
            this.lblModifyVehicle.Text = "Vehicle:";
            // 
            // btnModifySave
            // 
            this.btnModifySave.Location = new System.Drawing.Point(132, 386);
            this.btnModifySave.Name = "btnModifySave";
            this.btnModifySave.Size = new System.Drawing.Size(102, 32);
            this.btnModifySave.TabIndex = 65;
            this.btnModifySave.Text = "Update Service";
            this.btnModifySave.UseVisualStyleBackColor = true;
            this.btnModifySave.Click += new System.EventHandler(this.btnModifySave_Click);
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(3, 386);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(102, 32);
            this.btnModifyCancel.TabIndex = 64;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // btnMarkAsPaid
            // 
            this.btnMarkAsPaid.Location = new System.Drawing.Point(577, 476);
            this.btnMarkAsPaid.Name = "btnMarkAsPaid";
            this.btnMarkAsPaid.Size = new System.Drawing.Size(116, 32);
            this.btnMarkAsPaid.TabIndex = 80;
            this.btnMarkAsPaid.Text = "Mark Service as Paid";
            this.btnMarkAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkAsPaid.Click += new System.EventHandler(this.btnMarkAsPaid_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 533);
            this.Controls.Add(this.btnMarkAsPaid);
            this.Controls.Add(this.pnlModifyService);
            this.Controls.Add(this.pnlAddService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnModifyService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDrscription);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.dgvService);
            this.Name = "ServiceForm";
            this.Text = "Service Maintenance";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.pnlAddService.ResumeLayout(false);
            this.pnlAddService.PerformLayout();
            this.pnlModifyService.ResumeLayout(false);
            this.pnlModifyService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDrscription;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnModifyService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Panel pnlAddService;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.ComboBox cmbAddServiceType;
        private System.Windows.Forms.ComboBox cmbAddVehicle;
        private System.Windows.Forms.TextBox txtAddHours;
        private System.Windows.Forms.Label lblAddHours;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.Label lblAddServiceType;
        private System.Windows.Forms.Label lblAddVehicle;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Panel pnlModifyService;
        private System.Windows.Forms.TextBox txtModifyServiceType;
        private System.Windows.Forms.TextBox txtModifyVehicle;
        private System.Windows.Forms.DateTimePicker dtpModifyDate;
        private System.Windows.Forms.TextBox txtModifyHours;
        private System.Windows.Forms.Label lblModifyHours;
        private System.Windows.Forms.Label lblModifyDate;
        private System.Windows.Forms.Label lblModifyServiceType;
        private System.Windows.Forms.Label lblModifyVehicle;
        private System.Windows.Forms.Button btnModifySave;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.Button btnMarkAsPaid;
    }
}