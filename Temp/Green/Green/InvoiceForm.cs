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
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int lineCount;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            lineCount = 0;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            CurrencyManager cmOwner;
            CurrencyManager cmVehicle;
            CurrencyManager cmServiceType;
            CurrencyManager cmEquipment;
            string serviceText = "";
            double serviceTotal = 0;

            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];

            txtInvoices.Text = "";

            foreach (DataRow drService in DM.dtService.Rows) { 
                string serviceStatus = drService["Status"].ToString();
                if (serviceStatus == "Pending")
                {
                    int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                    cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
                    DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];


                    int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(aVehicleID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    serviceText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    serviceText += drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    serviceText += drOwner["StreetAddress"] + "\r\n";
                    serviceText += drOwner["Suburb"] + "\r\n\r\n\r\n";
                    serviceText += "Vehicle Plate Number: " + drVehicle["PlateNumber"] + "Make: " + drVehicle["Make"] + "Model: " + drVehicle["Model"] + "\r\n\r\n\r\n";

                    
                    int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
                    cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
                    DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];
                    serviceText += "Service Type Description: " + drServiceType["Description"] + "  " + "Hourly Rate: " + drServiceType["HourlyRate"] + "  " + "Service Hours: " + drService["Hours"] + "  " + "Service Date: " + drService["ServiceDate"] + "\r\n";
                    serviceTotal += Convert.ToDouble(drServiceType["HourlyRate"]) * Convert.ToDouble(drService["Hours"]);

                    txtInvoices.Text += serviceText;
                    txtInvoices.Text += "\r\n";
                    txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(serviceTotal);
                    txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                }
                serviceText = "";
                serviceTotal = 0;
            }

        }

        private void printDocument1_Print(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font printFont = new Font("Calibri", 10);

            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 850, 1100);
            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;
            float fontHeight = printFont.GetHeight();
            int lineHeight = printFont.Height;
            int linesSoFar = 0;
            int leftMargin = 12;
            int topMargin = e.MarginBounds.Top;
            int lineLeft = txtInvoices.Lines.Length;
            while (linesSoFar < 20)
            {
                if ((lineCount + linesSoFar) < txtInvoices.Lines.Length)
                {
                    graphic.DrawString(txtInvoices.Lines[linesSoFar + lineCount], printFont, Brushes.Gray,
                      leftMargin, linesSoFar * lineHeight);
                }
                linesSoFar++;

            }
            lineCount += 20;
            if (txtInvoices.Lines.Length > lineCount)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                lineCount = 0;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

    }
}
