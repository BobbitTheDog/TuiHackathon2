using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;
using ItineraryAdmin.Properties;

namespace ItineraryAdmin
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> ships;
        Dictionary<string, int> ports;

        Dictionary<string, IEnumerable<string>> shipPorts = new Dictionary<string, IEnumerable<string>>();
        string selectedShip;

        public Form1()
        {
            InitializeComponent();

            LoadShipList();
            LoadPortList();
        }

        private void LoadShipList()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.CruiseShip_ListNameAndId, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                ships = new Dictionary<string, int>();
                cmbShips.Items.Clear();

                da.Fill(data);

                cmbShips.Items.Add("");
                foreach (DataRow row in data.Rows.OfType<DataRow>())
                {
                    ships.Add(row["Name"].ToString(), (int)row["ShipID"]);
                    cmbShips.Items.Add(row["Name"].ToString());
                }
            }
        }

        private void LoadPortList()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.Seaport_ListNameAndId, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                ports = new Dictionary<string, int>();

                lstUnassignedPorts.Items.Clear();
                lstAssignedPorts.Items.Clear();

                da.Fill(data);

                ports = data.AsEnumerable().ToDictionary(r => r["Name"].ToString(), r => (int)r["SeaportID"]);
                ports.Keys.ToList().ForEach(x => lstUnassignedPorts.Items.Add(x));
            }
        }

        private void LoadItineraryData(string shipName)
        {
            LoadPortList();

            if (shipPorts.Keys.Contains(shipName))
            {
                foreach (var port in shipPorts[shipName])
                {
                    AssignPort(port);
                }
                return;
            }

            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.ItineraryStop_ListByShipName, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@ShipName", shipName);

                da.Fill(data);

                foreach (var row in data.Rows.OfType<DataRow>())
                {
                    AssignPort(row["Name"].ToString());
                }
            }
        }

        private void LockListControls()
        {
            lstAssignedPorts.Enabled = false;
            lstUnassignedPorts.Enabled = false;
            lblNoneSelected.Visible = true;
        }

        private void EnableListControls()
        {
            lblNoneSelected.Visible = false;
            lstAssignedPorts.Enabled = true;
            lstUnassignedPorts.Enabled = true;
        }

        private void cmbShips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectedShip))
                StoreChanges();

            selectedShip = cmbShips.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(cmbShips.SelectedItem.ToString()))
            {
                LoadItineraryData(cmbShips.SelectedItem.ToString());
                EnableListControls();
                return;
            }

            LoadPortList();
            LockListControls();
        }

        private void StoreChanges()
        {
            shipPorts[selectedShip] = lstAssignedPorts.Items.OfType<string>().ToList();
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            var selections = lstAssignedPorts.SelectedItems.OfType<string>().ToList();
            selections.ForEach(port => UnassignPort(port));

            btnSubmit.Enabled = shipPorts.Count > 0;
        }

        private void UnassignPort(string port)
        {
            lstAssignedPorts.Items.Remove(port);
            lstUnassignedPorts.Items.Add(port);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var selections = lstUnassignedPorts.SelectedItems.OfType<string>().ToList();
            selections.ForEach(port => AssignPort(port));

            btnSubmit.Enabled = shipPorts.Count > 0;
        }

        private void AssignPort(string port)
        {
            lstAssignedPorts.Items.Add(port);
            lstUnassignedPorts.Items.Remove(port);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StoreChanges();
            SaveChanges();
        }

        private void SaveChanges()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();
                using (var clearCmd = new MySqlCommand(Resources.ItineraryStop_ClearByShipID, conn))
                {
                    clearCmd.Parameters.Add("@shipID", MySqlDbType.Int16);

                    foreach (var shipName in shipPorts.Keys)
                    {
                        var shipID = ships[shipName];

                        clearCmd.Parameters["@shipID"].Value = shipID;
                        clearCmd.ExecuteNonQuery();

                        using (var insertCmd = new MySqlCommand(Resources.ItineraryStop_Insert, conn))
                        {
                            insertCmd.Parameters.Add("@shipID", MySqlDbType.Int16);
                            insertCmd.Parameters.Add("@seaportID", MySqlDbType.Int16);

                            foreach (var seaportName in shipPorts[shipName])
                            {
                                var seaportID = ports[seaportName];

                                insertCmd.Parameters["@shipID"].Value = shipID;
                                insertCmd.Parameters["@seaportID"].Value = seaportID;

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            shipPorts.Clear();
            btnSubmit.Enabled = false;
        }

        private void lstUnassignedPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAssign.Enabled = (lstUnassignedPorts.SelectedItems.Count > 0);
        }

        private void lstAssignedPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUnassign.Enabled = (lstAssignedPorts.SelectedItems.Count > 0);
        }
    }
}
