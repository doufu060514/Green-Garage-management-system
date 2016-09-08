using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Green
{

    public partial class DataModule : Form
    {
        public DataTable dtEquipment;
        public DataTable dtOwner;
        public DataTable dtServiceType;
        public DataTable dtService;
        public DataTable dtVehicle;
        public DataTable dtServiceTypeEquipment;
        public DataView equipmentView;
        public DataView serviceTypeView;
        public DataView ownerView;
        public DataView serviceView;
        public DataView vehicleView;
        public DataView serviceTypeEquipmentView;

        public DataModule()
        {
            InitializeComponent();
            DSGreen.EnforceConstraints = false;
            daEquipment.Fill(DSGreen);
            daService.Fill(DSGreen);
            daOwner.Fill(DSGreen);
            daVehicle.Fill(DSGreen);
            daServiceType.Fill(DSGreen);
            daServiceTypeEquipment.Fill(DSGreen);
            dtEquipment = DSGreen.Tables["Equipment"];
            dtService = DSGreen.Tables["Service"];
            dtOwner = DSGreen.Tables["Owner"];
            dtVehicle = DSGreen.Tables["Vehicle"];
            dtServiceType = DSGreen.Tables["ServiceType"];
            dtServiceTypeEquipment = DSGreen.Tables["ServiceTypeEquipment"];
            vehicleView = new DataView(dtVehicle);
            vehicleView.Sort = "VehicleID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            serviceTypeView = new DataView(dtServiceType);
            serviceTypeView.Sort = "ServiceTypeID";
            equipmentView = new DataView(dtServiceTypeEquipment);
            equipmentView.Sort = "EquipmentID";
            DSGreen.EnforceConstraints = true;

        }

        public void UpdateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }

        public void UpdateOwner() 
        {
            daOwner.Update(dtOwner);
        }

        public void UpdateServiceType()
        {
            daServiceType.Update(dtServiceType);
        }

        public void UpdateService()
        {
            daService.Update(dtService);
        }

        public void UpdateVehicle()
        {
            daVehicle.Update(dtVehicle);
        }

        public void UpdateServiceTypeEquipment()
        {
            daServiceTypeEquipment.Update(dtServiceTypeEquipment);
        }

        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGreen);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }

        }

        

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGreen);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }

        }

        private void daVehicle_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGreen);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }
        }
    }
}
