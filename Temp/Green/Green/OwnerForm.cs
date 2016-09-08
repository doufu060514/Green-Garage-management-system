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
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddOwner.Left = 359;
            pnlAddOwner.Top = 39;
            pnlUpdateOwner.Left = 359;
            pnlUpdateOwner.Top = 39;
        }

        public void BindControls()
        {
            lblOwnerID.DataBindings.Add("Text", DM.DSGreen, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtLastName.Enabled = false;
            txtFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtFirstName.Enabled = false;
            txtPhone.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");
            txtPhone.Enabled = false;
            txtStreetAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            txtStreetAddress.Enabled = false;
            txtSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtSuburb.Enabled = false;
            
            lstOwners.DataSource = DM.DSGreen;
            lstOwners.DisplayMember = "Owner.LastName";
            lstOwners.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Owner"];
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

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Enabled = false;
            lstOwners.SelectedItem = null;
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddOwner.Show();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            txtAddFirstName.Clear();
            txtAddLastName.Clear();
            txtAddPhone.Clear();
            txtAddStreetAddress.Clear();
            txtAddSuburb.Clear();
            lstOwners.Enabled = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
            btnReturn.Enabled = true;
            
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            lblOwnerID.Text = null;
            DataRow newOwnerRow = DM.dtOwner.NewRow();
            foreach(Control ctr in pnlAddOwner.Controls){
                if (ctr.Text == "") {
                    MessageBox.Show("You must type all the fields", "Error");
                    valid = false;
                    break;
                }
            }
            if (valid) {
                if (txtAddPhone.TextLength < 9 || txtAddPhone.TextLength > 12) {
                    MessageBox.Show("Phone number length must between 9 to 12", "Error");
                    valid = false;
                }
            }
            if (valid) {
                try
                {
                    newOwnerRow["LastName"] = txtAddLastName.Text;
                    newOwnerRow["FirstName"] = txtAddFirstName.Text;
                    newOwnerRow["PhoneNumber"] = txtAddPhone.Text;
                    newOwnerRow["StreetAddress"] = txtAddStreetAddress.Text;
                    newOwnerRow["Suburb"] = txtAddSuburb.Text;
                    DM.dtOwner.Rows.Add(newOwnerRow);
                    MessageBox.Show("Owner added successfully", "Success");
                    DM.UpdateOwner();
                    pnlAddOwner.Hide();
                    lstOwners.Enabled = true;
                    btnDeleteOwner.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnUpdateOwner.Enabled = true;
                    btnAddOwner.Enabled = true;
                    btnReturn.Enabled = true;
                    txtAddFirstName.Clear();
                    txtAddLastName.Clear();
                    txtAddPhone.Clear();
                    txtAddStreetAddress.Clear();
                    txtAddSuburb.Clear();
                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Owner added unsuccessfully", "Error");
                }

            }
            
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Enabled = false;
            lstOwners.SelectedItem = null;
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            btnReturn.Enabled = false;
            txtUpdateLastName.DataBindings.Clear();
            txtUpdateFirstName.DataBindings.Clear();
            txtUpdatePhone.DataBindings.Clear();
            txtUpdateSuburb.DataBindings.Clear();
            txtUpdateStreetAddress.DataBindings.Clear();
            txtUpdateLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtUpdatePhone.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");
            txtUpdateSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtUpdateStreetAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            pnlUpdateOwner.Show();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateOwner.Hide();
            lstOwners.Enabled = true;
            
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            foreach (Control ctr in pnlUpdateOwner.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("You must type all the fields", "Error");
                    valid = false;
                    break;
                }
            }
            if (valid)
            {
                if (txtUpdatePhone.TextLength < 9 || txtUpdatePhone.TextLength > 12)
                {
                    MessageBox.Show("Phone number length must between 9 to 12", "Error");
                    valid = false;
                }
            }
            if (valid)
            {
                try
                {
                    updateOwnerRow["LastName"] = txtUpdateLastName.Text;
                    updateOwnerRow["FirstName"] = txtUpdateFirstName.Text;
                    updateOwnerRow["PhoneNumber"] = txtUpdatePhone.Text;
                    updateOwnerRow["Suburb"] = txtUpdateSuburb.Text;
                    updateOwnerRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateOwner();
                    MessageBox.Show("Owner updated successfully", "Success");
                    pnlUpdateOwner.Hide();
                    lstOwners.Enabled = true;
                    
                    btnDeleteOwner.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnUpdateOwner.Enabled = true;
                    btnAddOwner.Enabled = true;
                    btnReturn.Enabled = true;

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Owner updated unsuccessfully", "Error");
                }

            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] VehicleRow = DM.dtVehicle.Select("OwnerID = " + lblOwnerID.Text);
            if (VehicleRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    MessageBox.Show("Owner deleted successfully");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete owner who have no vehicles", "Error");
                return;
            }
            //Update
            DM.UpdateOwner();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
