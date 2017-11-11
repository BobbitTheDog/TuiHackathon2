using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackathonFramework;
using System.Data;

namespace ItineraryAdmin
{
    public partial class Form1 : Form
    {
        List<Ship> allShips = new List<Ship>();
        List<Port> allPorts;

        string selectedShip;

        public Form1()
        {
            InitializeComponent();

            LoadShips();
            LoadPorts();
        }

        private void LoadShips()
        {
            cmbShips.Items.Clear();
            cmbShips.Items.Add("");

            allShips = SqlTasks.GetAllShips();
            allShips.ForEach(ship => cmbShips.Items.Add(ship.Name));
        }

        private void LoadPorts()
        {
            allPorts = SqlTasks.GetAllPorts();

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
