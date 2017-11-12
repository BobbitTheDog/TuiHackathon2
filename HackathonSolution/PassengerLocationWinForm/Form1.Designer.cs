namespace PassengerLocationWinForm
{
    partial class passengerLocationForm
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
            this.components = new System.ComponentModel.Container();
            this.onBoardListBox = new System.Windows.Forms.ListBox();
            this.onCoachListBox = new System.Windows.Forms.ListBox();
            this.onExcursionListBox = new System.Windows.Forms.ListBox();
            this.disembarkedListBox = new System.Windows.Forms.ListBox();
            this.onBoardLbl = new System.Windows.Forms.Label();
            this.onCoachLbl = new System.Windows.Forms.Label();
            this.onExcursionLbl = new System.Windows.Forms.Label();
            this.disembarkedLbl = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // onBoardListBox
            // 
            this.onBoardListBox.FormattingEnabled = true;
            this.onBoardListBox.ItemHeight = 16;
            this.onBoardListBox.Location = new System.Drawing.Point(12, 27);
            this.onBoardListBox.Name = "onBoardListBox";
            this.onBoardListBox.Size = new System.Drawing.Size(183, 468);
            this.onBoardListBox.TabIndex = 0;
            // 
            // onCoachListBox
            // 
            this.onCoachListBox.FormattingEnabled = true;
            this.onCoachListBox.ItemHeight = 16;
            this.onCoachListBox.Location = new System.Drawing.Point(226, 27);
            this.onCoachListBox.Name = "onCoachListBox";
            this.onCoachListBox.Size = new System.Drawing.Size(185, 468);
            this.onCoachListBox.TabIndex = 1;
            // 
            // onExcursionListBox
            // 
            this.onExcursionListBox.FormattingEnabled = true;
            this.onExcursionListBox.ItemHeight = 16;
            this.onExcursionListBox.Location = new System.Drawing.Point(450, 27);
            this.onExcursionListBox.Name = "onExcursionListBox";
            this.onExcursionListBox.Size = new System.Drawing.Size(183, 468);
            this.onExcursionListBox.TabIndex = 2;
            // 
            // disembarkedListBox
            // 
            this.disembarkedListBox.FormattingEnabled = true;
            this.disembarkedListBox.ItemHeight = 16;
            this.disembarkedListBox.Location = new System.Drawing.Point(667, 27);
            this.disembarkedListBox.Name = "disembarkedListBox";
            this.disembarkedListBox.Size = new System.Drawing.Size(183, 468);
            this.disembarkedListBox.TabIndex = 3;
            // 
            // onBoardLbl
            // 
            this.onBoardLbl.AutoSize = true;
            this.onBoardLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onBoardLbl.Location = new System.Drawing.Point(61, 7);
            this.onBoardLbl.Name = "onBoardLbl";
            this.onBoardLbl.Size = new System.Drawing.Size(71, 19);
            this.onBoardLbl.TabIndex = 4;
            this.onBoardLbl.Text = "On Board";
            // 
            // onCoachLbl
            // 
            this.onCoachLbl.AutoSize = true;
            this.onCoachLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onCoachLbl.Location = new System.Drawing.Point(278, 7);
            this.onCoachLbl.Name = "onCoachLbl";
            this.onCoachLbl.Size = new System.Drawing.Size(73, 19);
            this.onCoachLbl.TabIndex = 5;
            this.onCoachLbl.Text = "On Coach";
            // 
            // onExcursionLbl
            // 
            this.onExcursionLbl.AutoSize = true;
            this.onExcursionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onExcursionLbl.Location = new System.Drawing.Point(492, 7);
            this.onExcursionLbl.Name = "onExcursionLbl";
            this.onExcursionLbl.Size = new System.Drawing.Size(94, 19);
            this.onExcursionLbl.TabIndex = 6;
            this.onExcursionLbl.Text = "On Excursion";
            // 
            // disembarkedLbl
            // 
            this.disembarkedLbl.AutoSize = true;
            this.disembarkedLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.disembarkedLbl.Location = new System.Drawing.Point(712, 7);
            this.disembarkedLbl.Name = "disembarkedLbl";
            this.disembarkedLbl.Size = new System.Drawing.Size(93, 19);
            this.disembarkedLbl.TabIndex = 7;
            this.disembarkedLbl.Text = "Disembarked";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // passengerLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 507);
            this.Controls.Add(this.disembarkedLbl);
            this.Controls.Add(this.onExcursionLbl);
            this.Controls.Add(this.onCoachLbl);
            this.Controls.Add(this.onBoardLbl);
            this.Controls.Add(this.disembarkedListBox);
            this.Controls.Add(this.onExcursionListBox);
            this.Controls.Add(this.onCoachListBox);
            this.Controls.Add(this.onBoardListBox);
            this.Name = "passengerLocationForm";
            this.Text = "Passenger Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox onBoardListBox;
        private System.Windows.Forms.ListBox onCoachListBox;
        private System.Windows.Forms.ListBox onExcursionListBox;
        private System.Windows.Forms.ListBox disembarkedListBox;
        private System.Windows.Forms.Label onBoardLbl;
        private System.Windows.Forms.Label onCoachLbl;
        private System.Windows.Forms.Label onExcursionLbl;
        private System.Windows.Forms.Label disembarkedLbl;
        private System.Windows.Forms.Timer refreshTimer;
    }
}

