using AdminGui.Properties;
using HackathonFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGui
{
    public partial class formExAdmin : Form
    {
        List<Excursion> excursions;
        List<Port> port;
        List<Booking> booking;

        public formExAdmin()
        {
            InitializeComponent();

            LoadPorts();
            LoadBookings();
        }

        private void LoadPorts()
        {
            port = SqlTasks.GetAllPorts();
            cmbSeaportEx.Items.AddRange(port.Select(port => port.Name).ToArray());

        }

        private void LoadExcursions(string portID)
        {
            excursions = SqlTasks.GetExcursionsByPort(portID);
            cmbSeaportEx.Items.AddRange(excursions.Select(excursion => excursion.Name).ToArray());
        }
        private void LoadBookings()
        {
            var bookings = SqlTasks.GetAllBookings();
            cmbSelectBook.Items.AddRange(booking.Select(booking => booking.BookingID).ToArray());

        }
        private void LoadExcBook(string bookingID)
        {
            //var excursion = SqlTasks.GetBookingExcursion(bookingID);
            

        }


        private void formExAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cmbSeaportEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var portID = port.First(port => port.Name == cmbSeaportEx.SelectedItem.ToString()).ID;
            LoadExcursions(portID);
        }

        private void cmbSelectEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numCoach = excursions.First(exc => exc.Name == cmbSelectEx.SelectedItem.ToString()).NumCoach;
            txtCoachNoEx.Text = numCoach.ToString();
            
            
        }

        private void btnSubmitEx_Click(object sender, EventArgs e)
        {
            if (cmbSelectEx.Text != "" && cmbSeaportEx.Text !="") {

                var excursionID = excursions.First(exc => exc.Name == cmbSelectEx.SelectedItem.ToString()).ExcursionID;
                var portID = excursions.First(exc => exc.Name == cmbSelectEx.SelectedItem.ToString()).PortID;
                var name = cmbSelectEx.SelectedItem.ToString();
                int numCoach = excursions.First(exc => exc.Name == cmbSelectEx.SelectedItem.ToString()).NumCoach;
                SqlTasks.InsertExcursion(excursionID,portID,name,numCoach);
            }
        }

        private void btnCancelEx_Click(object sender, EventArgs e)
        {
            if (cmbSelectEx.Text != "" && cmbSeaportEx.Text != "")
            {
                var excursionID = excursions.First(exc => exc.Name == cmbSelectEx.SelectedItem.ToString()).ExcursionID;
                SqlTasks.DeleteExcursion(excursionID);
            }
        }

        private void cmbSelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bookingID = cmbSelectBook.SelectedItem.ToString();
            LoadExcBook(bookingID);
        }
    }
}
