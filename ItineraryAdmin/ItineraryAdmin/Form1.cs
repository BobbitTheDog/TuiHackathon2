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
using HackathonFramework;

namespace ItineraryAdmin
{
    public partial class Form1 : Form
    {
        //Dictionary<string, int> ships;
        List<Ship> allShips;
        List<Port> allPorts;

        //Dictionary<int, IEnumerable<string>> shipPorts = new Dictionary<int, IEnumerable<string>>();
        string selectedShip;

        public Form1()
        {
            InitializeComponent();

            LoadShips();
            LoadPorts();
        }

        private void LoadShips()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.Ship_ListNameAndID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                allShips = new List<Ship>();
                cmbShips.Items.Clear();

                da.Fill(data);

                cmbShips.Items.Add("");
                foreach (DataRow row in data.Rows.OfType<DataRow>())
                {
                    var ship = new Ship(row["ShipID"].ToString(), row["Name"].ToString());
                    ship.LoadItinerary();
                    allShips.Add(ship);
                    cmbShips.Items.Add(row["Name"].ToString());
                }
            }
        }

        private void LoadPorts()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.Port_ListNameAndID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                allPorts = data.AsEnumerable().Select(row => new Port(row["PortID"].ToString(), row["Name"].ToString())).ToList();
            }

            SetPortLists();
        }

        private void ResetPortLists()
        {
            lstUnassignedPorts.Items.Clear();
            lstAssignedPorts.Items.Clear();
            allPorts.ForEach(port => lstUnassignedPorts.Items.Add(port.Name));
        }

        private void SetPortLists(Ship ship = null)
        {
            ResetPortLists();

            if (ship == null) return;

            foreach (var port in ship.Ports)
            {
                MoveToAssigned(port.Name);
            }
        }

        private EnumerableRowCollection<DataRow> GetShipItinerary(int shipID)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.PortOfCall_ListByShipID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@ShipID", shipID);

                da.Fill(data);

                return data.AsEnumerable();
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

            if (!string.IsNullOrWhiteSpace(selectedShip))
            {
                SetPortLists(allShips.First(ship => ship.Name == selectedShip));
                EnableListControls();
                return;
            }

            LoadPorts();
            LockListControls();
        }

        private void StoreChanges()
        {
            var ship = allShips.First(s => s.Name == selectedShip);
            ship.Ports.Clear();
            ship.Ports.AddRange(allPorts.Where(p => lstAssignedPorts.Items.Contains(p.Name)));
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            var selections = lstAssignedPorts.SelectedItems.OfType<string>().ToList();
            selections.ForEach(port => MoveToUnassigned(port));

            btnSubmit.Enabled = allShips.Any(ship => ship.Modified);
        }

        private void MoveToUnassigned(string port)
        {
            lstAssignedPorts.Items.Remove(port);
            cmbStartPort.Items.Remove(port);
            lstUnassignedPorts.Items.Add(port);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var selections = lstUnassignedPorts.SelectedItems.OfType<string>().ToList();
            selections.ForEach(port => MoveToAssigned(port));

            btnSubmit.Enabled = allShips.Any(ship => ship.Modified);
        }

        private void MoveToAssigned(string port)
        {
            lstAssignedPorts.Items.Add(port);
            cmbStartPort.Items.Add(port);
            lstUnassignedPorts.Items.Remove(port);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StoreChanges();
            SaveChanges();
        }

        private async void SaveChanges()
        {
            var tasks = new List<Task>();
            foreach (var ship in allShips)
            {
                tasks.Add(ship.SaveItineraryAsync());
            }

            btnSubmit.Enabled = false;

            await Task.WhenAll(tasks);
        }

        private async Task UpdateItineraryOrderAsync(int shipID)
        {
            var stops = GetShipItinerary(shipID);
            // run them against a travelling salesman algorithm
            var route = await CalculateRoute(stops);
            //store the order in the DB
        }

        private async Task<EnumerableRowCollection<DataRow>> CalculateRoute(EnumerableRowCollection<DataRow> stops)
        {
            throw new NotImplementedException();
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
