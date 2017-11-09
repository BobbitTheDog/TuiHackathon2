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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpPorts = new System.Windows.Forms.GroupBox();
            this.chkPort3 = new System.Windows.Forms.CheckBox();
            this.chkPort2 = new System.Windows.Forms.CheckBox();
            this.chkPort1 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpPorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(284, 146);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpPorts);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSubmit);
            this.splitContainer2.Size = new System.Drawing.Size(284, 96);
            this.splitContainer2.SplitterDistance = 42;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpPorts
            // 
            this.grpPorts.Controls.Add(this.chkPort3);
            this.grpPorts.Controls.Add(this.chkPort2);
            this.grpPorts.Controls.Add(this.chkPort1);
            this.grpPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPorts.Location = new System.Drawing.Point(0, 0);
            this.grpPorts.Name = "grpPorts";
            this.grpPorts.Size = new System.Drawing.Size(284, 42);
            this.grpPorts.TabIndex = 1;
            this.grpPorts.TabStop = false;
            this.grpPorts.Text = "Destination Ports";
            // 
            // chkPort3
            // 
            this.chkPort3.AutoSize = true;
            this.chkPort3.Location = new System.Drawing.Point(184, 20);
            this.chkPort3.Name = "chkPort3";
            this.chkPort3.Size = new System.Drawing.Size(54, 17);
            this.chkPort3.TabIndex = 0;
            this.chkPort3.Text = "Port 3";
            this.chkPort3.UseVisualStyleBackColor = true;
            // 
            // chkPort2
            // 
            this.chkPort2.AutoSize = true;
            this.chkPort2.Location = new System.Drawing.Point(98, 20);
            this.chkPort2.Name = "chkPort2";
            this.chkPort2.Size = new System.Drawing.Size(54, 17);
            this.chkPort2.TabIndex = 0;
            this.chkPort2.Text = "Port 2";
            this.chkPort2.UseVisualStyleBackColor = true;
            // 
            // chkPort1
            // 
            this.chkPort1.AutoSize = true;
            this.chkPort1.Location = new System.Drawing.Point(12, 19);
            this.chkPort1.Name = "chkPort1";
            this.chkPort1.Size = new System.Drawing.Size(54, 17);
            this.chkPort1.TabIndex = 0;
            this.chkPort1.Text = "Port 1";
            this.chkPort1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(93, 14);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Itinerary Control Panel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpPorts.ResumeLayout(false);
            this.grpPorts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpPorts;
        private System.Windows.Forms.CheckBox chkPort3;
        private System.Windows.Forms.CheckBox chkPort2;
        private System.Windows.Forms.CheckBox chkPort1;
        private System.Windows.Forms.Button btnSubmit;
    }
}

