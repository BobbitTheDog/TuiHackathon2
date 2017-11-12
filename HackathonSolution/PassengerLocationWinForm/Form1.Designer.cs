namespace PassengerLocationMonitor
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
            this.lstOnBoard = new System.Windows.Forms.ListBox();
            this.lstOnCoach = new System.Windows.Forms.ListBox();
            this.lstOnExcursion = new System.Windows.Forms.ListBox();
            this.lstDisembarked = new System.Windows.Forms.ListBox();
            this.onBoardLbl = new System.Windows.Forms.Label();
            this.onCoachLbl = new System.Windows.Forms.Label();
            this.onExcursionLbl = new System.Windows.Forms.Label();
            this.disembarkedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOnBoard
            // 
            this.lstOnBoard.FormattingEnabled = true;
            this.lstOnBoard.Location = new System.Drawing.Point(9, 22);
            this.lstOnBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOnBoard.Name = "lstOnBoard";
            this.lstOnBoard.Size = new System.Drawing.Size(138, 381);
            this.lstOnBoard.TabIndex = 0;
            // 
            // lstOnCoach
            // 
            this.lstOnCoach.FormattingEnabled = true;
            this.lstOnCoach.Location = new System.Drawing.Point(170, 22);
            this.lstOnCoach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOnCoach.Name = "lstOnCoach";
            this.lstOnCoach.Size = new System.Drawing.Size(140, 381);
            this.lstOnCoach.TabIndex = 1;
            // 
            // lstOnExcursion
            // 
            this.lstOnExcursion.FormattingEnabled = true;
            this.lstOnExcursion.Location = new System.Drawing.Point(338, 22);
            this.lstOnExcursion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOnExcursion.Name = "lstOnExcursion";
            this.lstOnExcursion.Size = new System.Drawing.Size(138, 381);
            this.lstOnExcursion.TabIndex = 2;
            // 
            // lstDisembarked
            // 
            this.lstDisembarked.FormattingEnabled = true;
            this.lstDisembarked.Location = new System.Drawing.Point(500, 22);
            this.lstDisembarked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDisembarked.Name = "lstDisembarked";
            this.lstDisembarked.Size = new System.Drawing.Size(138, 381);
            this.lstDisembarked.TabIndex = 3;
            // 
            // onBoardLbl
            // 
            this.onBoardLbl.AutoSize = true;
            this.onBoardLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onBoardLbl.Location = new System.Drawing.Point(46, 6);
            this.onBoardLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onBoardLbl.Name = "onBoardLbl";
            this.onBoardLbl.Size = new System.Drawing.Size(54, 15);
            this.onBoardLbl.TabIndex = 4;
            this.onBoardLbl.Text = "On Board";
            // 
            // onCoachLbl
            // 
            this.onCoachLbl.AutoSize = true;
            this.onCoachLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onCoachLbl.Location = new System.Drawing.Point(208, 6);
            this.onCoachLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onCoachLbl.Name = "onCoachLbl";
            this.onCoachLbl.Size = new System.Drawing.Size(57, 15);
            this.onCoachLbl.TabIndex = 5;
            this.onCoachLbl.Text = "On Coach";
            // 
            // onExcursionLbl
            // 
            this.onExcursionLbl.AutoSize = true;
            this.onExcursionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onExcursionLbl.Location = new System.Drawing.Point(369, 6);
            this.onExcursionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onExcursionLbl.Name = "onExcursionLbl";
            this.onExcursionLbl.Size = new System.Drawing.Size(72, 15);
            this.onExcursionLbl.TabIndex = 6;
            this.onExcursionLbl.Text = "On Excursion";
            // 
            // disembarkedLbl
            // 
            this.disembarkedLbl.AutoSize = true;
            this.disembarkedLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.disembarkedLbl.Location = new System.Drawing.Point(534, 6);
            this.disembarkedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disembarkedLbl.Name = "disembarkedLbl";
            this.disembarkedLbl.Size = new System.Drawing.Size(71, 15);
            this.disembarkedLbl.TabIndex = 7;
            this.disembarkedLbl.Text = "Disembarked";
            // 
            // passengerLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 412);
            this.Controls.Add(this.disembarkedLbl);
            this.Controls.Add(this.onExcursionLbl);
            this.Controls.Add(this.onCoachLbl);
            this.Controls.Add(this.onBoardLbl);
            this.Controls.Add(this.lstDisembarked);
            this.Controls.Add(this.lstOnExcursion);
            this.Controls.Add(this.lstOnCoach);
            this.Controls.Add(this.lstOnBoard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "passengerLocationForm";
            this.Text = "Passenger Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOnBoard;
        private System.Windows.Forms.ListBox lstOnCoach;
        private System.Windows.Forms.ListBox lstOnExcursion;
        private System.Windows.Forms.ListBox lstDisembarked;
        private System.Windows.Forms.Label onBoardLbl;
        private System.Windows.Forms.Label onCoachLbl;
        private System.Windows.Forms.Label onExcursionLbl;
        private System.Windows.Forms.Label disembarkedLbl;
    }
}

