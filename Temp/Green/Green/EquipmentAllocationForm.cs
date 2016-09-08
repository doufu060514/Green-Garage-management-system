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
    public partial class EquipmentAllocationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmServiceType;
        private CurrencyManager cmEquipment;
        private CurrencyManager cmServiceTypeEquipment;
        //private CurrencyManager cmVVT;
        private DataTable dt = new DataTable();
        //private CurrencyManager cmDt;


        public EquipmentAllocationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceTypeEquipment"];
            BindControls();
        }

        public void BindControls()
        {
            dgvServiceType.DataSource = DM.DSGreen;
            dgvServiceType.DataMember = "ServiceType";

            dgvEquipment.DataSource = DM.DSGreen;
            dgvEquipment.DataMember = "Equipment";

            dgvServiceTypeEquipment.DataSource = DM.DSGreen;
            dgvServiceTypeEquipment.DataMember = "ServiceTypeEquipment";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAllocateEquipment_Click(object sender, EventArgs e)
        {
            string serviceTypeID = dgvServiceType["ServiceTypeID", cmServiceType.Position].Value.ToString();
            string equipmentID = dgvEquipment["EquipmentID", cmEquipment.Position].Value.ToString();
            Boolean status = true;
            for (int i = 0; i < DM.dtServiceTypeEquipment.Rows.Count; i++)
            {
                string stID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
                string eID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();
                if (stID == serviceTypeID && eID == equipmentID)
                {
                    MessageBox.Show("This item of equipment has already been allocated to this service type","Error");
                    status = false;
                }
            }
            if (status) {
                DataRow newServiceTypeEquimentRow = DM.dtServiceTypeEquipment.NewRow();
                newServiceTypeEquimentRow["ServiceTypeID"] = serviceTypeID;
                newServiceTypeEquimentRow["EquipmentID"] = equipmentID;
                DM.DSGreen.Tables["ServiceTypeEquipment"].Rows.Add(newServiceTypeEquimentRow);    
                MessageBox.Show("Item of equipment allocated successfully", "Success");
                DM.UpdateServiceTypeEquipment();
            }
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = DM.dtServiceTypeEquipment.Rows[cmServiceTypeEquipment.Position];
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteServiceTypeRow.Delete();
                MessageBox.Show("Item of equipment removed successfully");
            }
            else
            {
                return;
            }
        }


    }
}
