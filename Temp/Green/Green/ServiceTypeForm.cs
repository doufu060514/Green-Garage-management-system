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
    public partial class ServiceTypeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ServiceTypeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddServiceType.Left = 357;
            pnlAddServiceType.Top = 48;
            pnlModifyServiceType.Left = 357;
            pnlModifyServiceType.Top = 48;
        }

        public void BindControls()
        {
            lblServiceTypeID.DataBindings.Add("Text", DM.DSGreen, "ServiceType.ServiceTypeID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");
            txtHourlyRate.DataBindings.Add("Text", DM.DSGreen, "ServiceType.HourlyRate");
            txtDescription.Enabled = false;
            txtHourlyRate.Enabled = false;
            lstServiceType.DataSource = DM.DSGreen;
            lstServiceType.DisplayMember = "ServiceType.Description";
            lstServiceType.ValueMember = "ServiceType.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
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

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Enabled = false;
            lstServiceType.SelectedItem = null;
            btnDeleteServiceType.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyServiceType.Enabled = false;
            btnAddServiceType.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddServiceType.Show();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddServiceType.Hide();
            lstServiceType.Enabled = true;
            btnDeleteServiceType.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyServiceType.Enabled = true;
            btnAddServiceType.Enabled = true;
            btnReturn.Enabled = true;
            
        }

        private void btnSaveServiceType_Click(object sender, EventArgs e)
        {
            lblServiceTypeID.Text = null;
            float result = 0.0f;
            DataRow newServiceTypeRow = DM.dtServiceType.NewRow();
            if ((txtAddDescription.Text == "") || (txtAddHourlyRate.Text == ""))
            {
                MessageBox.Show("You must type in all the fields", "Error");
            }
            else if (!float.TryParse(txtAddHourlyRate.Text,out result))
            {
                MessageBox.Show("Hourly rate must be a number", "Error");
            }
            else
            {
                try
                {
                    newServiceTypeRow["Description"] = txtAddDescription.Text;
                    newServiceTypeRow["HourlyRate"] = txtAddHourlyRate.Text;
                    DM.dtServiceType.Rows.Add(newServiceTypeRow);
                    MessageBox.Show("Service type added successfully", "Success");
                    DM.UpdateServiceType();
                    pnlAddServiceType.Hide();
                    lstServiceType.Enabled = true;
                    btnDeleteServiceType.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnModifyServiceType.Enabled = true;
                    btnAddServiceType.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Service type added unsuccessfully", "Error");
                }
            }
            
            return;
        }

        private void btnModifyServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Enabled = false;
            lstServiceType.SelectedItem = null;
            btnDeleteServiceType.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnModifyServiceType.Enabled = false;
            btnAddServiceType.Enabled = false;
            btnReturn.Enabled = false;
            txtModifyDescription.DataBindings.Clear();
            txtModifyHourlyRate.DataBindings.Clear();
            txtModifyDescription.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");
            txtModifyHourlyRate.Text = DM.dtServiceType.Rows[currencyManager.Position]["HourlyRate"].ToString();
            //txtModifyHourlyRate.DataBindings.Add("Text", DM.DSGreen, "ServiceType.HourlyRate");
            pnlModifyServiceType.Show();
            return;
        }

        private void btnModifySave_Click(object sender, EventArgs e)
        {
            //txtModifyHourlyRate.Refresh();
            DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            float result = 0.0f;
            //MessageBox.Show("Length" + txtModifyHourlyRate.Text.Length.ToString() + "   Content:" + txtModifyHourlyRate.Text);
            if ((txtModifyDescription.Text == "") || (txtModifyHourlyRate.Text == ""))
            {
                MessageBox.Show("You must type in all the fields", "Error");
            }
            else if (!float.TryParse(txtModifyHourlyRate.Text, out result))
            {
                MessageBox.Show("Hourly rate must be a number", "Error");
            }
            else {
                try
                {
                    updateServiceTypeRow["Description"] = txtModifyDescription.Text;
                    updateServiceTypeRow["HourlyRate"] = txtModifyHourlyRate.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateServiceType();
                    MessageBox.Show("Service type updated successfully", "Success");
                    pnlModifyServiceType.Hide();
                    lstServiceType.Enabled = true;
                    btnDeleteServiceType.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnModifyServiceType.Enabled = true;
                    btnAddServiceType.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Service type updated unsuccessfully", "Error");
                }
            }
            
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            pnlModifyServiceType.Hide();
            lstServiceType.Enabled = true;
            btnDeleteServiceType.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyServiceType.Enabled = true;
            btnAddServiceType.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnDeleteServiceType_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("ServiceTypeID = " + lblServiceTypeID.Text);
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("ServiceTypeID = " + lblServiceTypeID.Text);
            if (ServiceRow.Length == 0)
            {
                if (ServiceTypeEquipmentRow.Length == 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteServiceTypeRow.Delete();
                        MessageBox.Show("Service type deleted successfully");
                    }
                    else
                    {
                        return;
                    }
                }
                else {
                    MessageBox.Show("You may only delete Service Types who are not allocated equipment", "Error");
                }
            }
            else
            {
                MessageBox.Show("You may only delete Service Types that are not assigned to services", "Error");
                return;
            }
            //Update
            DM.UpdateServiceType();
        }

        private void ServiceTypeForm_Load(object sender, EventArgs e)
        {

        }       
    }
}
