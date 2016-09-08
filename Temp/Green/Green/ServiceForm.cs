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
    public partial class ServiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        
        private CurrencyManager cmService;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public ServiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "Service"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            BindControls();
            pnlAddService.Left = 603;
            pnlAddService.Top = 12;
            pnlModifyService.Left = 603;
            pnlModifyService.Top = 12;

            

        }

        public void BindControls() {
            dgvService.DataSource = DM.DSGreen;
            dgvService.DataMember = "Service";

            string vehicleID = dgvService["vehicleID", cmService.Position].Value.ToString();
            string ownerID = "";
            string serviceTypeID = dgvService["ServiceTypeID", cmService.Position].Value.ToString();
            for (int i = 0; i < DM.dtVehicle.Rows.Count; i++)
            {
                string vID = DM.dtVehicle.Rows[i]["VehicleID"].ToString();
                if (vID == vehicleID)
                {
                    txtPlateNumber.Text = DM.dtVehicle.Rows[i]["PlateNumber"].ToString();
                    ownerID = DM.dtVehicle.Rows[i]["OwnerID"].ToString();
                }
            }
            for (int i = 0; i < DM.dtOwner.Rows.Count; i++)
            {
                string oID = DM.dtOwner.Rows[i]["OwnerID"].ToString();
                if (oID == ownerID)
                {
                    txtOwner.Text = DM.dtOwner.Rows[i]["FirstName"].ToString() + " " + DM.dtOwner.Rows[i]["LastName"].ToString();
                }
            }
            for (int i = 0; i < DM.dtServiceType.Rows.Count; i++)
            {
                string stID = DM.dtServiceType.Rows[i]["ServiceTypeID"].ToString();
                if (stID == serviceTypeID)
                {
                    txtHourlyRate.Text = DM.dtServiceType.Rows[i]["HourlyRate"].ToString();
                    txtDescription.Text = DM.dtServiceType.Rows[i]["Description"].ToString();
                }
            }


        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string vehicleID = dgvService["vehicleID", cmService.Position].Value.ToString();
            string ownerID = "";
            string serviceTypeID = dgvService["ServiceTypeID", cmService.Position].Value.ToString();
            for (int i = 0; i < DM.dtVehicle.Rows.Count; i++)
            {
                string vID = DM.dtVehicle.Rows[i]["VehicleID"].ToString();
                if (vID == vehicleID)
                {
                    txtPlateNumber.Text = DM.dtVehicle.Rows[i]["PlateNumber"].ToString();
                    ownerID = DM.dtVehicle.Rows[i]["OwnerID"].ToString();
                }
            }
            for (int i = 0; i < DM.dtOwner.Rows.Count; i++)
            {
                string oID = DM.dtOwner.Rows[i]["OwnerID"].ToString();
                if (oID == ownerID)
                {
                    txtOwner.Text = DM.dtOwner.Rows[i]["FirstName"].ToString() + " " + DM.dtOwner.Rows[i]["LastName"].ToString();
                }
            }
            for (int i = 0; i < DM.dtServiceType.Rows.Count; i++)
            {
                string stID = DM.dtServiceType.Rows[i]["ServiceTypeID"].ToString();
                if (stID == serviceTypeID)
                {
                    txtHourlyRate.Text = DM.dtServiceType.Rows[i]["HourlyRate"].ToString();
                    txtDescription.Text = DM.dtServiceType.Rows[i]["Description"].ToString();
                }
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            btnModifyService.Enabled = false;
            btnDeleteService.Enabled = false;
            pnlAddService.Show();
            cmbAddVehicle.DataSource = DM.DSGreen;
            cmbAddVehicle.DisplayMember = "Vehicle.PlateNumber";
            cmbAddVehicle.ValueMember = "Vehicle.VehicleID";
            cmbAddServiceType.DataSource = DM.DSGreen;
            cmbAddServiceType.DisplayMember = "ServiceType.Description";
            cmbAddServiceType.ValueMember = "ServiceType.ServiceTypeID";
        
        }

        
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddService.Hide();
            btnModifyService.Enabled = true;
            btnDeleteService.Enabled = true;
        }    

        private void btnModifyService_Click(object sender, EventArgs e)
        {
            string status = dgvService["Status", cmService.Position].Value.ToString();
            if (status == "Pending")
            {
                pnlModifyService.Show();
                btnAddService.Enabled = false;
                btnDeleteService.Enabled = false;
                string vehicleID = dgvService["vehicleID", cmService.Position].Value.ToString();
                for (int i = 0; i < DM.dtVehicle.Rows.Count; i++)
                {
                    string vID = DM.dtVehicle.Rows[i]["VehicleID"].ToString();
                    if (vID == vehicleID)
                    {
                        txtModifyVehicle.Text = DM.dtVehicle.Rows[i]["PlateNumber"].ToString();
                    }
                }
                string serviceTypeID = dgvService["ServiceTypeID", cmService.Position].Value.ToString();
                for (int i = 0; i < DM.dtServiceType.Rows.Count; i++)
                {
                    string stID = DM.dtServiceType.Rows[i]["ServiceTypeID"].ToString();
                    if (stID == serviceTypeID)
                    {
                        txtModifyServiceType.Text = DM.dtServiceType.Rows[i]["Description"].ToString();
                    }
                }
                txtModifyHours.Text = dgvService["Hours", cmService.Position].Value.ToString();
                
            }
            else 
            {
                MessageBox.Show("Cannot update a paid service","Error");    
            }

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            Boolean valid = false;
            DataRow newServiceRow = DM.dtService.NewRow();
            try
            {
                Convert.ToInt32(txtAddHours.Text);
                newServiceRow["Hours"] = txtAddHours.Text;
                valid = true;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hours must be a integer", "Error");
            }
            if (valid)
            {
                try
                {
                    int vID = (Int32)Convert.ToInt32(cmbAddVehicle.SelectedValue);
                    newServiceRow["VehicleID"] = vID;
                    newServiceRow["ServiceTypeID"] = Convert.ToInt32(cmbAddServiceType.SelectedValue);

                    newServiceRow["ServiceDate"] = DateTime.Parse(dtpAddDate.Text);
                    newServiceRow["Status"] = "Pending";
                    DM.dtService.Rows.Add(newServiceRow);
                    MessageBox.Show("Service added successfully", "Success");
                    DM.UpdateService();
                    pnlAddService.Hide();
                    btnModifyService.Enabled = true;
                    btnDeleteService.Enabled = true;
                }catch (FormatException ex){
                    MessageBox.Show("Service added unsuccessfully", "Error");
                }
            }
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            pnlModifyService.Hide();
            btnAddService.Enabled = true;
            btnDeleteService.Enabled = true;
        }

        private void btnModifySave_Click(object sender, EventArgs e)
        {
            Boolean valid = false;
            DataRow updateServiceRow = DM.dtService.Rows[cmService.Position];
            try
            {
                Convert.ToInt32(txtModifyHours.Text);
                updateServiceRow["Hours"] = txtModifyHours.Text;
                valid = true;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hours must be a integer", "Error");
            }
            if (valid) {
                try
                {
                    updateServiceRow["ServiceDate"] = DateTime.Parse(dtpModifyDate.Text);
                    cmService.EndCurrentEdit();
                    DM.UpdateService();
                    MessageBox.Show("Service updated successfully", "Success");
                    pnlModifyService.Hide();
                    btnAddService.Enabled = true;
                    btnDeleteService.Enabled = true;
                }
                catch (FormatException ex) 
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Service updated unsuccessfully", "Error");
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceRow = DM.dtService.Rows[cmService.Position];
            string status = dgvService["Status", cmService.Position].Value.ToString();
            if (status == "Paid")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteServiceRow.Delete();
                    MessageBox.Show("Service deleted successfully");
                }
                else
                {
                    return;
                }
            }
            else {
                MessageBox.Show("You may only delete paid services");
                return;
            }
            DM.UpdateService();
        }

        private void btnMarkAsPaid_Click(object sender, EventArgs e)
        {
            DataRow updateServiceRow = DM.dtService.Rows[cmService.Position];
            string status = dgvService["Status", cmService.Position].Value.ToString();
            if (status == "Pending")
            {
                updateServiceRow["Status"] = "Paid";
                cmService.EndCurrentEdit();
                DM.UpdateService();
                MessageBox.Show("Service marked as paid");
            }
            else
            {
                MessageBox.Show("The Service is already paid");
            }
            
        }


       
    }
}
