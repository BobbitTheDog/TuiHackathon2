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
        

        public formExAdmin()
        {
            InitializeComponent();

            LoadExcursions();
            LoadBookings();
        }

        private void LoadExcursions()
        {
            var excursions = SqlTasks.GetAllExcursions();
        }
        private void LoadBookings()
        {

        }

        private void formExAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
