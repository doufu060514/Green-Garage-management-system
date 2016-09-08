namespace Green
{
    partial class EquipmentAllocationForm
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
            this.dgvServiceType = new System.Windows.Forms.DataGridView();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.btnAllocateEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvServiceTypeEquipment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceType
            // 
            this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceType.Location = new System.Drawing.Point(12, 12);
            this.dgvServiceType.Name = "dgvServiceType";
            this.dgvServiceType.Size = new System.Drawing.Size(419, 253);
            this.dgvServiceType.TabIndex = 0;
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(476, 12);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.Size = new System.Drawing.Size(299, 253);
            this.dgvEquipment.TabIndex = 1;
            // 
            // btnAllocateEquipment
            // 
            this.btnAllocateEquipment.Location = new System.Drawing.Point(419, 301);
            this.btnAllocateEquipment.Name = "btnAllocateEquipment";
            this.btnAllocateEquipment.Size = new System.Drawing.Size(98, 42);
            this.btnAllocateEquipment.TabIndex = 2;
            this.btnAllocateEquipment.Text = "Allowcate Equipment";
            this.btnAllocateEquipment.UseVisualStyleBackColor = true;
            this.btnAllocateEquipment.Click += new System.EventHandler(this.btnAllocateEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(419, 442);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(98, 42);
            this.btnRemoveEquipment.TabIndex = 3;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(672, 442);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 42);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvServiceTypeEquipment
            // 
            this.dgvServiceTypeEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTypeEquipment.Location = new System.Drawing.Point(12, 301);
            this.dgvServiceTypeEquipment.Name = "dgvServiceTypeEquipment";
            this.dgvServiceTypeEquipment.Size = new System.Drawing.Size(299, 183);
            this.dgvServiceTypeEquipment.TabIndex = 5;
            // 
            // EquipmentAllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 522);
            this.Controls.Add(this.dgvServiceTypeEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAllocateEquipment);
            this.Controls.Add(this.dgvEquipment);
            this.Controls.Add(this.dgvServiceType);
            this.Name = "EquipmentAllocationForm";
            this.Text = "Equipment Allocation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceType;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnAllocateEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvServiceTypeEquipment;
    }
}