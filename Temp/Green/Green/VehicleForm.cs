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
    public partial class VehicleForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public VehicleForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVehicle.Left = 352;
            pnlAddVehicle.Top = 35;
            pnlModifyVehicle.Left = 352;
            pnlModifyVehicle.Top = 35;
        }

        public void BindControls()
        {
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            lblVehicleID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.VehicleID");
            txtPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            txtMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");
            string ownerID = DM.dtVehicle.Rows[currencyManager.Position]["OwnerID"].ToString();
            for (int i = 0; i < DM.dtOwner.Rows.Count; i++) {
                string oID = DM.dtOwner.Rows[i]["OwnerID"].ToString();
                if (oID == ownerID)
                {
                    txtOwner.Text = DM.dtOwner.Rows[i]["FirstName"].ToString() + " " + DM.dtOwner.Rows[i]["LastName"].ToString();
                }
            }
            lstVehicle.DataSource = DM.DSGreen;
            lstVehicle.DisplayMember = "Vehicle.PlateNumber";
            lstVehicle.ValueMember = "Vehicle.VehicleID";
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

        private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ownerID = DM.dtVehicle.Rows[currencyManager.Position]["OwnerID"].ToString();
            for (int i = 0; i < DM.dtOwner.Rows.Count; i++)
            {
                string oID = DM.dtOwner.Rows[i]["OwnerID"].ToString();
                if (oID == ownerID)
                {
                    txtOwner.Text = DM.dtOwner.Rows[i]["FirstName"].ToString() + " " + DM.dtOwner.Rows[i]["LastName"].ToString();
                }
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnModifyVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;
            lstVehicle.Enabled = false;
            pnlAddVehicle.Show();
            DM.dtOwner.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            cmbAddOwner.DataSource = DM.DSGreen;
            cmbAddOwner.DisplayMember = "Owner.FullName";
            cmbAddOwner.ValueMember = "Owner.OwnerID";
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddVehicle.Hide();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnModifyVehicle.Enabled = true;
            btnDeleteVehicle.Enabled = true;
            lstVehicle.Enabled = true;
            DM.dtOwner.Columns.Remove("FullName");
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            lblVehicleID.Text = null;
            DataRow newVehicleRow = DM.dtVehicle.NewRow();
            foreach (Control ctr in pnlAddVehicle.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("You must type all the fields", "Error");
                    valid = false;
                    break;
                }
            }
            if (txtAddPlateNumber.Text.Length > 10)
            {
                MessageBox.Show("Length of Plate Number must less then 10", "Error");
                valid = false;
            }
            if (valid)
            {
                try
                {
                    newVehicleRow["PlateNumber"] = txtAddPlateNumber.Text;
                    newVehicleRow["Make"] = txtAddMake.Text;
                    newVehicleRow["Model"] = txtAddModel.Text;
                    newVehicleRow["OwnerID"] = cmbAddOwner.SelectedValue;

                    DM.dtVehicle.Rows.Add(newVehicleRow);
                    MessageBox.Show("Vehicle added successfully", "Success");
                    DM.UpdateVehicle();
                    DM.dtOwner.Columns.Remove("FullName");
                    pnlAddVehicle.Hide();
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnModifyVehicle.Enabled = true;
                    btnDeleteVehicle.Enabled = true;
                    lstVehicle.Enabled = true;

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Vehicle added unsuccessfully", "Error");
                }

            }
        }

        private void btnModifyVehicle_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;
            lstVehicle.Enabled = false;
            txtModifyPlateNumber.DataBindings.Clear();
            txtModifyMake.DataBindings.Clear();
            txtModifyModel.DataBindings.Clear();
            txtModifyPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            txtModifyMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModifyModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");
            pnlModifyVehicle.Show();
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            pnlModifyVehicle.Hide();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVehicle.Enabled = true;
            btnDeleteVehicle.Enabled = true;
            lstVehicle.Enabled = true;
        }

        private void btnModifyUpdate_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            foreach (Control ctr in pnlModifyVehicle.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("You must type all the fields", "Error");
                    valid = false;
                    break;
                }
            }
            if (txtModifyPlateNumber.Text.Length > 10)
            {
                MessageBox.Show("Length of Plate Number must less then 10", "Error");
                valid = false;
            }
            if (valid)
            {
                try
                {
                    updateVehicleRow["PlateNumber"] = txtModifyPlateNumber.Text;
                    updateVehicleRow["Make"] = txtModifyMake.Text;
                    updateVehicleRow["Model"] = txtModifyModel.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVehicle();
                    MessageBox.Show("Vehicle updated successfully", "Success");
                    pnlModifyVehicle.Hide();
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddVehicle.Enabled = true;
                    btnDeleteVehicle.Enabled = true;
                    lstVehicle.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Vehicle updated unsuccessfully", "Error");
                }

            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("VehicleID = " + lblVehicleID.Text);
            if (ServiceRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVehicleRow.Delete();
                    MessageBox.Show("Vehicle deleted successfully");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete vehicles that do not have services", "Error");
                return;
            }
            //Update
            DM.UpdateVehicle();
        }
        
    }
}
