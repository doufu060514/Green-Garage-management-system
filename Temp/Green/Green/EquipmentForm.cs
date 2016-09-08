using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Green
{
    public partial class EquipmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EquipmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEquipment.Left = 220;
            pnlAddEquipment.Top = 40;
            pnlUpdateEquipment.Left = 220;
            pnlUpdateEquipment.Top = 40;

        }

        public void BindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            txtDescription.Enabled = false; 
            lstEquipments.DataSource = DM.DSGreen;
            lstEquipments.DisplayMember = "Equipment.Description";
            lstEquipments.ValueMember = "Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
        }


        private void EquipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            lstEquipments.Visible = false;                   
            lstEquipments.Enabled = false;                   
            lstEquipments.SelectedItem = null;               
            btnDeleteEquipment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            pnlAddEquipment.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            lblEquipmentID.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();
            if ((txtAddDescription.Text == ""))
            {
                MessageBox.Show("You must type in a Equipment description", "Error");
            }
            else
            {
                try
                {
                    newEquipmentRow["Description"] = txtAddDescription.Text;
                    DM.dtEquipment.Rows.Add(newEquipmentRow);
                    MessageBox.Show("Equipment added successfully", "Success");
                    DM.UpdateEquipment();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Equipment added unsuccessfully", "Error");
                }
            }
            pnlAddEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
            return;
          
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            lstEquipments.Visible = false;
            lstEquipments.Enabled = false;
            lstEquipments.SelectedItem = null;
            btnDeleteEquipment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            txtUpdateEquipment.DataBindings.Clear();
            txtUpdateEquipment.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            pnlUpdateEquipment.Show();
            return;
            
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            
            if ((txtUpdateEquipment.Text == ""))
            {
                MessageBox.Show("You must type in a Equipment description", "Error");

            }
            else
            {
                updateEquipmentRow["Description"] = txtUpdateEquipment.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment updated successfully", "Success");
            }
            
            pnlUpdateEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
            return;
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                    MessageBox.Show("Item of equipment deleted successfully");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete equipment that are not allocated to service types", "Error");
                return;
            }
            //Update
            DM.UpdateEquipment();
        }


    }
}
