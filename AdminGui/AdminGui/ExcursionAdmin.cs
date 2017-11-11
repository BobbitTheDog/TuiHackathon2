using AdminGui.Properties;
using MySql.Data.MySqlClient;
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
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.excursion_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {

                da.Fill(data);

            }
        }
        private void LoadBookings()
        {

        }

        private void formExAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
