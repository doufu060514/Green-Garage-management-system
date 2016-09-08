namespace Green
{
    partial class ServiceTypeForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.btnModifyServiceType = new System.Windows.Forms.Button();
            this.btnDeleteServiceType = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblServiceTypeID = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lstServiceType = new System.Windows.Forms.ListBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.pnlAddServiceType = new System.Windows.Forms.Panel();
            this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
            this.lblAddHourlyRate = new System.Windows.Forms.Label();
            this.btnSaveServiceType = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.pnlModifyServiceType = new System.Windows.Forms.Panel();
            this.txtModifyHourlyRate = new System.Windows.Forms.TextBox();
            this.lblModifyHourlyRate = new System.Windows.Forms.Label();
            this.btnModifySave = new System.Windows.Forms.Button();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.lblModifyDescription = new System.Windows.Forms.Label();
            this.pnlAddServiceType.SuspendLayout();
            this.pnlModifyServiceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(201, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 32);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(339, 407);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(102, 32);
            this.btnAddServiceType.TabIndex = 37;
            this.btnAddServiceType.Text = "Add Service Type";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnModifyServiceType
            // 
            this.btnModifyServiceType.Location = new System.Drawing.Point(467, 407);
            this.btnModifyServiceType.Name = "btnModifyServiceType";
            this.btnModifyServiceType.Size = new System.Drawing.Size(113, 32);
            this.btnModifyServiceType.TabIndex = 36;
            this.btnModifyServiceType.Text = "Modify Service Type";
            this.btnModifyServiceType.UseVisualStyleBackColor = true;
            this.btnModifyServiceType.Click += new System.EventHandler(this.btnModifyServiceType_Click);
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.Location = new System.Drawing.Point(608, 407);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(114, 32);
            this.btnDeleteServiceType.TabIndex = 35;
            this.btnDeleteServiceType.Text = "Delete Service Type";
            this.btnDeleteServiceType.UseVisualStyleBackColor = true;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(620, 467);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 32);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(57, 407);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 32);
            this.btnPrevious.TabIndex = 33;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(467, 162);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 56);
            this.txtDescription.TabIndex = 32;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(378, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description:";
            // 
            // lblServiceTypeID
            // 
            this.lblServiceTypeID.AutoSize = true;
            this.lblServiceTypeID.Location = new System.Drawing.Point(464, 47);
            this.lblServiceTypeID.Name = "lblServiceTypeID";
            this.lblServiceTypeID.Size = new System.Drawing.Size(70, 13);
            this.lblServiceTypeID.TabIndex = 30;
            this.lblServiceTypeID.Text = "Service Type";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(354, 47);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(87, 13);
            this.lblServiceType.TabIndex = 29;
            this.lblServiceType.Text = "Service Type ID:";
            // 
            // lstServiceType
            // 
            this.lstServiceType.FormattingEnabled = true;
            this.lstServiceType.Location = new System.Drawing.Point(57, 48);
            this.lstServiceType.Name = "lstServiceType";
            this.lstServiceType.Size = new System.Drawing.Size(246, 316);
            this.lstServiceType.TabIndex = 28;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(369, 100);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblHourlyRate.TabIndex = 39;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(467, 97);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyRate.TabIndex = 40;
            // 
            // pnlAddServiceType
            // 
            this.pnlAddServiceType.Controls.Add(this.txtAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.lblAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.btnSaveServiceType);
            this.pnlAddServiceType.Controls.Add(this.btnAddCancel);
            this.pnlAddServiceType.Controls.Add(this.txtAddDescription);
            this.pnlAddServiceType.Controls.Add(this.lblAddDescription);
            this.pnlAddServiceType.Location = new System.Drawing.Point(357, 123);
            this.pnlAddServiceType.Name = "pnlAddServiceType";
            this.pnlAddServiceType.Size = new System.Drawing.Size(354, 287);
            this.pnlAddServiceType.TabIndex = 41;
            this.pnlAddServiceType.Visible = false;
            // 
            // txtAddHourlyRate
            // 
            this.txtAddHourlyRate.Location = new System.Drawing.Point(114, 33);
            this.txtAddHourlyRate.Name = "txtAddHourlyRate";
            this.txtAddHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtAddHourlyRate.TabIndex = 42;
            // 
            // lblAddHourlyRate
            // 
            this.lblAddHourlyRate.AutoSize = true;
            this.lblAddHourlyRate.Location = new System.Drawing.Point(16, 36);
            this.lblAddHourlyRate.Name = "lblAddHourlyRate";
            this.lblAddHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblAddHourlyRate.TabIndex = 41;
            this.lblAddHourlyRate.Text = "Hourly Rate:";
            // 
            // btnSaveServiceType
            // 
            this.btnSaveServiceType.Location = new System.Drawing.Point(208, 199);
            this.btnSaveServiceType.Name = "btnSaveServiceType";
            this.btnSaveServiceType.Size = new System.Drawing.Size(102, 32);
            this.btnSaveServiceType.TabIndex = 16;
            this.btnSaveServiceType.Text = "Save";
            this.btnSaveServiceType.UseVisualStyleBackColor = true;
            this.btnSaveServiceType.Click += new System.EventHandler(this.btnSaveServiceType_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(28, 199);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(102, 32);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(114, 93);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(196, 55);
            this.txtAddDescription.TabIndex = 15;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(25, 100);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddDescription.TabIndex = 15;
            this.lblAddDescription.Text = "Description:";
            // 
            // pnlModifyServiceType
            // 
            this.pnlModifyServiceType.Controls.Add(this.txtModifyHourlyRate);
            this.pnlModifyServiceType.Controls.Add(this.lblModifyHourlyRate);
            this.pnlModifyServiceType.Controls.Add(this.btnModifySave);
            this.pnlModifyServiceType.Controls.Add(this.btnModifyCancel);
            this.pnlModifyServiceType.Controls.Add(this.txtModifyDescription);
            this.pnlModifyServiceType.Controls.Add(this.lblModifyDescription);
            this.pnlModifyServiceType.Location = new System.Drawing.Point(12, 248);
            this.pnlModifyServiceType.Name = "pnlModifyServiceType";
            this.pnlModifyServiceType.Size = new System.Drawing.Size(354, 287);
            this.pnlModifyServiceType.TabIndex = 42;
            this.pnlModifyServiceType.Visible = false;
            // 
            // txtModifyHourlyRate
            // 
            this.txtModifyHourlyRate.Location = new System.Drawing.Point(114, 33);
            this.txtModifyHourlyRate.Name = "txtModifyHourlyRate";
            this.txtModifyHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtModifyHourlyRate.TabIndex = 42;
            // 
            // lblModifyHourlyRate
            // 
            this.lblModifyHourlyRate.AutoSize = true;
            this.lblModifyHourlyRate.Location = new System.Drawing.Point(16, 36);
            this.lblModifyHourlyRate.Name = "lblModifyHourlyRate";
            this.lblModifyHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblModifyHourlyRate.TabIndex = 41;
            this.lblModifyHourlyRate.Text = "Hourly Rate:";
            // 
            // btnModifySave
            // 
            this.btnModifySave.Location = new System.Drawing.Point(192, 197);
            this.btnModifySave.Name = "btnModifySave";
            this.btnModifySave.Size = new System.Drawing.Size(118, 32);
            this.btnModifySave.TabIndex = 16;
            this.btnModifySave.Text = "Update Service Type";
            this.btnModifySave.UseVisualStyleBackColor = true;
            this.btnModifySave.Click += new System.EventHandler(this.btnModifySave_Click);
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Location = new System.Drawing.Point(28, 197);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(102, 32);
            this.btnModifyCancel.TabIndex = 15;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(114, 93);
            this.txtModifyDescription.Multiline = true;
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(196, 55);
            this.txtModifyDescription.TabIndex = 15;
            // 
            // lblModifyDescription
            // 
            this.lblModifyDescription.AutoSize = true;
            this.lblModifyDescription.Location = new System.Drawing.Point(25, 100);
            this.lblModifyDescription.Name = "lblModifyDescription";
            this.lblModifyDescription.Size = new System.Drawing.Size(63, 13);
            this.lblModifyDescription.TabIndex = 15;
            this.lblModifyDescription.Text = "Description:";
            // 
            // ServiceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 547);
            this.Controls.Add(this.pnlModifyServiceType);
            this.Controls.Add(this.pnlAddServiceType);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(this.btnModifyServiceType);
            this.Controls.Add(this.btnDeleteServiceType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblServiceTypeID);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lstServiceType);
            this.Name = "ServiceTypeForm";
            this.Text = "Service Type Maintenance";
            this.Load += new System.EventHandler(this.ServiceTypeForm_Load);
            this.pnlAddServiceType.ResumeLayout(false);
            this.pnlAddServiceType.PerformLayout();
            this.pnlModifyServiceType.ResumeLayout(false);
            this.pnlModifyServiceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.Button btnModifyServiceType;
        private System.Windows.Forms.Button btnDeleteServiceType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblServiceTypeID;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ListBox lstServiceType;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Panel pnlAddServiceType;
        private System.Windows.Forms.TextBox txtAddHourlyRate;
        private System.Windows.Forms.Label lblAddHourlyRate;
        private System.Windows.Forms.Button btnSaveServiceType;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel pnlModifyServiceType;
        private System.Windows.Forms.Label lblModifyHourlyRate;
        private System.Windows.Forms.Button btnModifySave;
        private System.Windows.Forms.Button btnModifyCancel;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.Label lblModifyDescription;
        private System.Windows.Forms.TextBox txtModifyHourlyRate;
    }
}