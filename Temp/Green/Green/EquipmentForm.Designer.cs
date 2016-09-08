namespace Green
{
    partial class EquipmentForm
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
            this.pnlAddEquipment = new System.Windows.Forms.Panel();
            this.btnSaveEquipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lstEquipments = new System.Windows.Forms.ListBox();
            this.pnlUpdateEquipment = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.txtUpdateEquipment = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.pnlAddEquipment.SuspendLayout();
            this.pnlUpdateEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddEquipment
            // 
            this.pnlAddEquipment.Controls.Add(this.btnSaveEquipment);
            this.pnlAddEquipment.Controls.Add(this.btnCancel);
            this.pnlAddEquipment.Controls.Add(this.txtAddDescription);
            this.pnlAddEquipment.Controls.Add(this.lblAddDescription);
            this.pnlAddEquipment.Location = new System.Drawing.Point(412, 542);
            this.pnlAddEquipment.Name = "pnlAddEquipment";
            this.pnlAddEquipment.Size = new System.Drawing.Size(354, 185);
            this.pnlAddEquipment.TabIndex = 28;
            this.pnlAddEquipment.Visible = false;
            // 
            // btnSaveEquipment
            // 
            this.btnSaveEquipment.Location = new System.Drawing.Point(208, 125);
            this.btnSaveEquipment.Name = "btnSaveEquipment";
            this.btnSaveEquipment.Size = new System.Drawing.Size(102, 32);
            this.btnSaveEquipment.TabIndex = 16;
            this.btnSaveEquipment.Text = "Save Equipment";
            this.btnSaveEquipment.UseVisualStyleBackColor = true;
            this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(114, 30);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(196, 55);
            this.txtAddDescription.TabIndex = 15;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(25, 37);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddDescription.TabIndex = 15;
            this.lblAddDescription.Text = "Description:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(232, 423);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 32);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(370, 423);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(102, 32);
            this.btnAddEquipment.TabIndex = 26;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(510, 423);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(104, 32);
            this.btnUpdateEquipment.TabIndex = 25;
            this.btnUpdateEquipment.Text = "Update Equipment";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(651, 423);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(102, 32);
            this.btnDeleteEquipment.TabIndex = 24;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(651, 483);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 32);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(88, 423);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 32);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(498, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 56);
            this.txtDescription.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(409, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(495, 63);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipmentID.TabIndex = 17;
            this.lblEquipmentID.Text = "Equipment";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(400, 63);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(74, 13);
            this.lblEquipment.TabIndex = 16;
            this.lblEquipment.Text = "Equipment ID:";
            // 
            // lstEquipments
            // 
            this.lstEquipments.FormattingEnabled = true;
            this.lstEquipments.Location = new System.Drawing.Point(88, 64);
            this.lstEquipments.Name = "lstEquipments";
            this.lstEquipments.Size = new System.Drawing.Size(246, 316);
            this.lstEquipments.TabIndex = 15;
            // 
            // pnlUpdateEquipment
            // 
            this.pnlUpdateEquipment.Controls.Add(this.btnUpdate);
            this.pnlUpdateEquipment.Controls.Add(this.btnCancel2);
            this.pnlUpdateEquipment.Controls.Add(this.txtUpdateEquipment);
            this.pnlUpdateEquipment.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateEquipment.Location = new System.Drawing.Point(12, 542);
            this.pnlUpdateEquipment.Name = "pnlUpdateEquipment";
            this.pnlUpdateEquipment.Size = new System.Drawing.Size(354, 185);
            this.pnlUpdateEquipment.TabIndex = 29;
            this.pnlUpdateEquipment.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(208, 125);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Equipment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(28, 125);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(102, 32);
            this.btnCancel2.TabIndex = 15;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // txtUpdateEquipment
            // 
            this.txtUpdateEquipment.Location = new System.Drawing.Point(114, 30);
            this.txtUpdateEquipment.Multiline = true;
            this.txtUpdateEquipment.Name = "txtUpdateEquipment";
            this.txtUpdateEquipment.Size = new System.Drawing.Size(196, 55);
            this.txtUpdateEquipment.TabIndex = 15;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(25, 37);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateDescription.TabIndex = 15;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.pnlUpdateEquipment);
            this.Controls.Add(this.pnlAddEquipment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lstEquipments);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Maintenance";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.pnlAddEquipment.ResumeLayout(false);
            this.pnlAddEquipment.PerformLayout();
            this.pnlUpdateEquipment.ResumeLayout(false);
            this.pnlUpdateEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddEquipment;
        private System.Windows.Forms.Button btnSaveEquipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ListBox lstEquipments;
        private System.Windows.Forms.Panel pnlUpdateEquipment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.TextBox txtUpdateEquipment;
        private System.Windows.Forms.Label lblUpdateDescription;
    }
}