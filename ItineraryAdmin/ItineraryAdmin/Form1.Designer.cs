namespace ItineraryAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitForm = new System.Windows.Forms.SplitContainer();
            this.lblShips = new System.Windows.Forms.Label();
            this.cmbShips = new System.Windows.Forms.ComboBox();
            this.lblNoneSelected = new System.Windows.Forms.Label();
            this.splitControls = new System.Windows.Forms.SplitContainer();
            this.grpPorts = new System.Windows.Forms.GroupBox();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lstAssignedPorts = new System.Windows.Forms.ListBox();
            this.lstUnassignedPorts = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitForm)).BeginInit();
            this.splitForm.Panel1.SuspendLayout();
            this.splitForm.Panel2.SuspendLayout();
            this.splitForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControls)).BeginInit();
            this.splitControls.Panel1.SuspendLayout();
            this.splitControls.Panel2.SuspendLayout();
            this.splitControls.SuspendLayout();
            this.grpPorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitForm
            // 
            this.splitForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitForm.Location = new System.Drawing.Point(0, 0);
            this.splitForm.Name = "splitForm";
            this.splitForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitForm.Panel1
            // 
            this.splitForm.Panel1.Controls.Add(this.lblShips);
            this.splitForm.Panel1.Controls.Add(this.cmbShips);
            // 
            // splitForm.Panel2
            // 
            this.splitForm.Panel2.Controls.Add(this.lblNoneSelected);
            this.splitForm.Panel2.Controls.Add(this.splitControls);
            this.splitForm.Size = new System.Drawing.Size(284, 306);
            this.splitForm.SplitterDistance = 55;
            this.splitForm.TabIndex = 0;
            // 
            // lblShips
            // 
            this.lblShips.AutoSize = true;
            this.lblShips.Location = new System.Drawing.Point(15, 11);
            this.lblShips.Name = "lblShips";
            this.lblShips.Size = new System.Drawing.Size(77, 13);
            this.lblShips.TabIndex = 1;
            this.lblShips.Text = "Select a cruise";
            // 
            // cmbShips
            // 
            this.cmbShips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShips.FormattingEnabled = true;
            this.cmbShips.Location = new System.Drawing.Point(12, 28);
            this.cmbShips.Name = "cmbShips";
            this.cmbShips.Size = new System.Drawing.Size(260, 21);
            this.cmbShips.TabIndex = 0;
            this.cmbShips.SelectedIndexChanged += new System.EventHandler(this.cmbShips_SelectedIndexChanged);
            // 
            // lblNoneSelected
            // 
            this.lblNoneSelected.AutoSize = true;
            this.lblNoneSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblNoneSelected.Location = new System.Drawing.Point(169, 38);
            this.lblNoneSelected.Name = "lblNoneSelected";
            this.lblNoneSelected.Size = new System.Drawing.Size(90, 13);
            this.lblNoneSelected.TabIndex = 3;
            this.lblNoneSelected.Text = "No Ship Selected";
            // 
            // splitControls
            // 
            this.splitControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControls.Location = new System.Drawing.Point(0, 0);
            this.splitControls.Name = "splitControls";
            this.splitControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitControls.Panel1
            // 
            this.splitControls.Panel1.Controls.Add(this.grpPorts);
            // 
            // splitControls.Panel2
            // 
            this.splitControls.Panel2.Controls.Add(this.btnSubmit);
            this.splitControls.Size = new System.Drawing.Size(284, 247);
            this.splitControls.SplitterDistance = 201;
            this.splitControls.TabIndex = 0;
            // 
            // grpPorts
            // 
            this.grpPorts.AutoSize = true;
            this.grpPorts.Controls.Add(this.btnUnassign);
            this.grpPorts.Controls.Add(this.btnAssign);
            this.grpPorts.Controls.Add(this.lstAssignedPorts);
            this.grpPorts.Controls.Add(this.lstUnassignedPorts);
            this.grpPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPorts.Location = new System.Drawing.Point(0, 0);
            this.grpPorts.Name = "grpPorts";
            this.grpPorts.Size = new System.Drawing.Size(284, 201);
            this.grpPorts.TabIndex = 1;
            this.grpPorts.TabStop = false;
            this.grpPorts.Text = "Destination Ports";
            // 
            // btnUnassign
            // 
            this.btnUnassign.Enabled = false;
            this.btnUnassign.Image = global::ItineraryAdmin.Properties.Resources.chevron_left_3x;
            this.btnUnassign.Location = new System.Drawing.Point(128, 58);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(28, 28);
            this.btnUnassign.TabIndex = 3;
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Enabled = false;
            this.btnAssign.Image = global::ItineraryAdmin.Properties.Resources.chevron_right_3x;
            this.btnAssign.Location = new System.Drawing.Point(128, 114);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(28, 28);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lstAssignedPorts
            // 
            this.lstAssignedPorts.Enabled = false;
            this.lstAssignedPorts.FormattingEnabled = true;
            this.lstAssignedPorts.Location = new System.Drawing.Point(157, 19);
            this.lstAssignedPorts.Name = "lstAssignedPorts";
            this.lstAssignedPorts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAssignedPorts.Size = new System.Drawing.Size(115, 173);
            this.lstAssignedPorts.TabIndex = 1;
            this.lstAssignedPorts.SelectedIndexChanged += new System.EventHandler(this.lstAssignedPorts_SelectedIndexChanged);
            // 
            // lstUnassignedPorts
            // 
            this.lstUnassignedPorts.Enabled = false;
            this.lstUnassignedPorts.FormattingEnabled = true;
            this.lstUnassignedPorts.Location = new System.Drawing.Point(12, 19);
            this.lstUnassignedPorts.Name = "lstUnassignedPorts";
            this.lstUnassignedPorts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUnassignedPorts.Size = new System.Drawing.Size(115, 173);
            this.lstUnassignedPorts.TabIndex = 0;
            this.lstUnassignedPorts.SelectedIndexChanged += new System.EventHandler(this.lstUnassignedPorts_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(94, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.splitForm);
            this.Name = "Form1";
            this.Text = "Itinerary Control Panel";
            this.splitForm.Panel1.ResumeLayout(false);
            this.splitForm.Panel1.PerformLayout();
            this.splitForm.Panel2.ResumeLayout(false);
            this.splitForm.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitForm)).EndInit();
            this.splitForm.ResumeLayout(false);
            this.splitControls.Panel1.ResumeLayout(false);
            this.splitControls.Panel1.PerformLayout();
            this.splitControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitControls)).EndInit();
            this.splitControls.ResumeLayout(false);
            this.grpPorts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitForm;
        private System.Windows.Forms.ComboBox cmbShips;
        private System.Windows.Forms.SplitContainer splitControls;
        private System.Windows.Forms.GroupBox grpPorts;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblShips;
        private System.Windows.Forms.Label lblNoneSelected;
        private System.Windows.Forms.ListBox lstAssignedPorts;
        private System.Windows.Forms.ListBox lstUnassignedPorts;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Button btnAssign;
    }
}

