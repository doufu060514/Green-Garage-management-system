namespace Green
{
    partial class VehicleForm
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnModifyVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.pnlAddVehicle = new System.Windows.Forms.Panel();
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.lblAddOwner = new System.Windows.Forms.Label();
            this.txtAddMake = new System.Windows.Forms.TextBox();
            this.lblAddPlateNumber = new System.Windows.Forms.Label();
            this.txtAddPlateNumber = new System.Windows.Forms.TextBox();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.cmbAddOwner = new System.Windows.Forms.ComboBox();
            this.pnlModifyVehicle = new System.Windows.Forms.Panel();
            this.btnModifyUpdate = new System.Windows.Forms.Button();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.txtModifyModel = new System.Windows.Forms.TextBox();
            this.lblModifyModel = new System.Windows.Forms.Label();
            this.txtModifyMake = new System.Windows.Forms.TextBox();
            this.lblModifyPlateNumber = new System.Windows.Forms.Label();
            this.txtModifyPlateNumber = new System.Windows.Forms.TextBox();
            this.lblModifyMake = new System.Windows.Forms.Label();
            this.pnlAddVehicle.SuspendLayout();
            this.pnlModifyVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(451, 195);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(112, 20);
            this.txtModel.TabIndex = 70;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(362, 198);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 69;
            this.lblModel.Text = "Model:";
            // 
            // txtOwner
            // 
            this.txtOwner.Enabled = false;
            this.txtOwner.Location = new System.Drawing.Point(451, 246);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(112, 20);
            this.txtOwner.TabIndex = 68;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(362, 249);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(41, 13);
            this.lblOwner.TabIndex = 67;
            this.lblOwner.Text = "Owner:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(600, 501);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 32);
            this.btnReturn.TabIndex = 57;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtMake
            // 
            this.txtMake.Enabled = false;
            this.txtMake.Location = new System.Drawing.Point(451, 144);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(112, 20);
            this.txtMake.TabIndex = 64;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(362, 94);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblPlateNumber.TabIndex = 63;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Enabled = false;
            this.txtPlateNumber.Location = new System.Drawing.Point(451, 91);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(112, 20);
            this.txtPlateNumber.TabIndex = 62;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(173, 431);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 32);
            this.btnNext.TabIndex = 61;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(315, 431);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(102, 32);
            this.btnAddVehicle.TabIndex = 60;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnModifyVehicle
            // 
            this.btnModifyVehicle.Location = new System.Drawing.Point(459, 431);
            this.btnModifyVehicle.Name = "btnModifyVehicle";
            this.btnModifyVehicle.Size = new System.Drawing.Size(104, 32);
            this.btnModifyVehicle.TabIndex = 59;
            this.btnModifyVehicle.Text = "Modify Vehicle";
            this.btnModifyVehicle.UseVisualStyleBackColor = true;
            this.btnModifyVehicle.Click += new System.EventHandler(this.btnModifyVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(600, 431);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(102, 32);
            this.btnDeleteVehicle.TabIndex = 58;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(39, 431);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 32);
            this.btnPrevious.TabIndex = 56;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(362, 147);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 55;
            this.lblMake.Text = "Make:";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(448, 44);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(42, 13);
            this.lblVehicleID.TabIndex = 54;
            this.lblVehicleID.Text = "Vehicle";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(362, 44);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(59, 13);
            this.lblVehicle.TabIndex = 53;
            this.lblVehicle.Text = "Vehicle ID:";
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(41, 35);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(246, 329);
            this.lstVehicle.TabIndex = 52;
            this.lstVehicle.SelectedIndexChanged += new System.EventHandler(this.lstVehicle_SelectedIndexChanged);
            // 
            // pnlAddVehicle
            // 
            this.pnlAddVehicle.Controls.Add(this.cmbAddOwner);
            this.pnlAddVehicle.Controls.Add(this.btnAddSave);
            this.pnlAddVehicle.Controls.Add(this.btnAddCancel);
            this.pnlAddVehicle.Controls.Add(this.txtAddModel);
            this.pnlAddVehicle.Controls.Add(this.lblAddModel);
            this.pnlAddVehicle.Controls.Add(this.lblAddOwner);
            this.pnlAddVehicle.Controls.Add(this.txtAddMake);
            this.pnlAddVehicle.Controls.Add(this.lblAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.txtAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.lblAddMake);
            this.pnlAddVehicle.Location = new System.Drawing.Point(49, 113);
            this.pnlAddVehicle.Name = "pnlAddVehicle";
            this.pnlAddVehicle.Size = new System.Drawing.Size(260, 329);
            this.pnlAddVehicle.TabIndex = 71;
            this.pnlAddVehicle.Visible = false;
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(114, 141);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(121, 20);
            this.txtAddModel.TabIndex = 78;
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.Location = new System.Drawing.Point(25, 144);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(39, 13);
            this.lblAddModel.TabIndex = 77;
            this.lblAddModel.Text = "Model:";
            // 
            // lblAddOwner
            // 
            this.lblAddOwner.AutoSize = true;
            this.lblAddOwner.Location = new System.Drawing.Point(25, 195);
            this.lblAddOwner.Name = "lblAddOwner";
            this.lblAddOwner.Size = new System.Drawing.Size(41, 13);
            this.lblAddOwner.TabIndex = 75;
            this.lblAddOwner.Text = "Owner:";
            // 
            // txtAddMake
            // 
            this.txtAddMake.Location = new System.Drawing.Point(114, 90);
            this.txtAddMake.Name = "txtAddMake";
            this.txtAddMake.Size = new System.Drawing.Size(121, 20);
            this.txtAddMake.TabIndex = 74;
            // 
            // lblAddPlateNumber
            // 
            this.lblAddPlateNumber.AutoSize = true;
            this.lblAddPlateNumber.Location = new System.Drawing.Point(25, 40);
            this.lblAddPlateNumber.Name = "lblAddPlateNumber";
            this.lblAddPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblAddPlateNumber.TabIndex = 73;
            this.lblAddPlateNumber.Text = "Plate Number:";
            // 
            // txtAddPlateNumber
            // 
            this.txtAddPlateNumber.Location = new System.Drawing.Point(114, 37);
            this.txtAddPlateNumber.Name = "txtAddPlateNumber";
            this.txtAddPlateNumber.Size = new System.Drawing.Size(121, 20);
            this.txtAddPlateNumber.TabIndex = 72;
            // 
            // lblAddMake
            // 
            this.lblAddMake.AutoSize = true;
            this.lblAddMake.Location = new System.Drawing.Point(25, 93);
            this.lblAddMake.Name = "lblAddMake";
            this.lblAddMake.Size = new System.Drawing.Size(37, 13);
            this.lblAddMake.TabIndex = 71;
            this.lblAddMake.Text = "Make:";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(133, 263);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(102, 32);
            this.btnAddSave.TabIndex = 80;
            this.btnAddSave.Text = "Save Vehicle";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(25, 263);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(102, 32);
            this.btnAddCancel.TabIndex = 79;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // cmbAddOwner
            // 
            this.cmbAddOwner.FormattingEnabled = true;
            this.cmbAddOwner.Location = new System.Drawing.Point(114, 192);
            this.cmbAddOwner.Name = "cmbAddOwner";
            this.cmbAddOwner.Size = new System.Drawing.Size(121, 21);
            this.cmbAddOwner.TabIndex = 81;
            // 
            // pnlModifyVehicle
            // 
            this.pnlModifyVehicle.Controls.Add(this.btnModifyUpdate);
            this.pnlModifyVehicle.Controls.Add(this.btnModifyCancel);
            this.pnlModifyVehicle.Controls.Add(this.txtModifyModel);
            this.pnlModifyVehicle.Controls.Add(this.lblModifyModel);
            this.pnlModifyVehicle.Controls.Add(this.txtModifyMake);
            this.pnlModifyVehicle.Controls.Add(this.lblModifyPlateNumber);
            this.pnlModifyVehicle.Controls.Add(this.txtModifyPlateNumber);
            this.pnlModifyVehicle.Controls.Add(this.lblModifyMake);
            this.pnlModifyVehicle.Location = new System.Drawing.Point(334, 117);
            this.pnlModifyVehicle.Name = "pnlModifyVehicle";
            this.pnlModifyVehicle.Size = new System.Drawing.Size(260, 329);
            this.pnlModifyVehicle.TabIndex = 72;
            this.pnlModifyVehicle.Visible = false;
            // 
            // btnModifyUpdate
            // 
            this.btnModifyUpdate.Location = new System.Drawing.Point(133, 263);
            this.btnModifyUpdate.Name = "btnModifyUpdate";
            this.btnModifyUpdate.Size = new System.Drawing.Size(102, 32);
            this.btnModifyUpdate.TabIndex = 80;
            this.btnModifyUpdate.Text = "Update Vehicle";
            this.btnModifyUpdate.UseVisualStyleBackColor = true;
            this.btnModifyUpdate.Click += new System.EventHandler(this.btnModifyUpdate_Click);
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(25, 263);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(102, 32);
            this.btnModifyCancel.TabIndex = 79;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // txtModifyModel
            // 
            this.txtModifyModel.Location = new System.Drawing.Point(114, 141);
            this.txtModifyModel.Name = "txtModifyModel";
            this.txtModifyModel.Size = new System.Drawing.Size(121, 20);
            this.txtModifyModel.TabIndex = 78;
            // 
            // lblModifyModel
            // 
            this.lblModifyModel.AutoSize = true;
            this.lblModifyModel.Location = new System.Drawing.Point(25, 144);
            this.lblModifyModel.Name = "lblModifyModel";
            this.lblModifyModel.Size = new System.Drawing.Size(39, 13);
            this.lblModifyModel.TabIndex = 77;
            this.lblModifyModel.Text = "Model:";
            // 
            // txtModifyMake
            // 
            this.txtModifyMake.Location = new System.Drawing.Point(114, 90);
            this.txtModifyMake.Name = "txtModifyMake";
            this.txtModifyMake.Size = new System.Drawing.Size(121, 20);
            this.txtModifyMake.TabIndex = 74;
            // 
            // lblModifyPlateNumber
            // 
            this.lblModifyPlateNumber.AutoSize = true;
            this.lblModifyPlateNumber.Location = new System.Drawing.Point(25, 40);
            this.lblModifyPlateNumber.Name = "lblModifyPlateNumber";
            this.lblModifyPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblModifyPlateNumber.TabIndex = 73;
            this.lblModifyPlateNumber.Text = "Plate Number:";
            // 
            // txtModifyPlateNumber
            // 
            this.txtModifyPlateNumber.Location = new System.Drawing.Point(114, 37);
            this.txtModifyPlateNumber.Name = "txtModifyPlateNumber";
            this.txtModifyPlateNumber.Size = new System.Drawing.Size(121, 20);
            this.txtModifyPlateNumber.TabIndex = 72;
            // 
            // lblModifyMake
            // 
            this.lblModifyMake.AutoSize = true;
            this.lblModifyMake.Location = new System.Drawing.Point(25, 93);
            this.lblModifyMake.Name = "lblModifyMake";
            this.lblModifyMake.Size = new System.Drawing.Size(37, 13);
            this.lblModifyMake.TabIndex = 71;
            this.lblModifyMake.Text = "Make:";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 550);
            this.Controls.Add(this.pnlModifyVehicle);
            this.Controls.Add(this.pnlAddVehicle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnModifyVehicle);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lstVehicle);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Maintenance";
            this.pnlAddVehicle.ResumeLayout(false);
            this.pnlAddVehicle.PerformLayout();
            this.pnlModifyVehicle.ResumeLayout(false);
            this.pnlModifyVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnModifyVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Panel pnlAddVehicle;
        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.Label lblAddOwner;
        private System.Windows.Forms.TextBox txtAddMake;
        private System.Windows.Forms.Label lblAddPlateNumber;
        private System.Windows.Forms.TextBox txtAddPlateNumber;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.ComboBox cmbAddOwner;
        private System.Windows.Forms.Panel pnlModifyVehicle;
        private System.Windows.Forms.Button btnModifyUpdate;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.TextBox txtModifyModel;
        private System.Windows.Forms.Label lblModifyModel;
        private System.Windows.Forms.TextBox txtModifyMake;
        private System.Windows.Forms.Label lblModifyPlateNumber;
        private System.Windows.Forms.TextBox txtModifyPlateNumber;
        private System.Windows.Forms.Label lblModifyMake;
    }
}