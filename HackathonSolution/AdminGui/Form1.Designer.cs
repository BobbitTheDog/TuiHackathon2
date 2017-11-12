namespace AdminGui
{
    partial class formExAdmin
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
            this.gbExc = new System.Windows.Forms.GroupBox();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.tbNameEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectEx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDesEx = new System.Windows.Forms.RichTextBox();
            this.dtStartTimeEx = new System.Windows.Forms.DateTimePicker();
            this.dtEndTimeEx = new System.Windows.Forms.DateTimePicker();
            this.tbSeaportIDEx = new System.Windows.Forms.TextBox();
            this.tbCoachNoEx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmitEx = new System.Windows.Forms.Button();
            this.btnCancelEx = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSelectBook = new System.Windows.Forms.ComboBox();
            this.cbExBook = new System.Windows.Forms.ComboBox();
            this.cbCabinBook = new System.Windows.Forms.ComboBox();
            this.cbStatusBook = new System.Windows.Forms.ComboBox();
            this.txtPassNumBook = new System.Windows.Forms.TextBox();
            this.btnSubmitBook = new System.Windows.Forms.Button();
            this.gbExc.SuspendLayout();
            this.gbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbExc
            // 
            this.gbExc.Controls.Add(this.btnCancelEx);
            this.gbExc.Controls.Add(this.btnSubmitEx);
            this.gbExc.Controls.Add(this.label7);
            this.gbExc.Controls.Add(this.label6);
            this.gbExc.Controls.Add(this.label5);
            this.gbExc.Controls.Add(this.label4);
            this.gbExc.Controls.Add(this.tbCoachNoEx);
            this.gbExc.Controls.Add(this.tbSeaportIDEx);
            this.gbExc.Controls.Add(this.dtEndTimeEx);
            this.gbExc.Controls.Add(this.dtStartTimeEx);
            this.gbExc.Controls.Add(this.rtbDesEx);
            this.gbExc.Controls.Add(this.label3);
            this.gbExc.Controls.Add(this.label2);
            this.gbExc.Controls.Add(this.cbSelectEx);
            this.gbExc.Controls.Add(this.label1);
            this.gbExc.Controls.Add(this.tbNameEx);
            this.gbExc.Location = new System.Drawing.Point(12, 10);
            this.gbExc.Name = "gbExc";
            this.gbExc.Size = new System.Drawing.Size(268, 290);
            this.gbExc.TabIndex = 0;
            this.gbExc.TabStop = false;
            this.gbExc.Text = "Manage Excursions";
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.btnSubmitBook);
            this.gbBook.Controls.Add(this.txtPassNumBook);
            this.gbBook.Controls.Add(this.cbStatusBook);
            this.gbBook.Controls.Add(this.cbCabinBook);
            this.gbBook.Controls.Add(this.cbExBook);
            this.gbBook.Controls.Add(this.cbSelectBook);
            this.gbBook.Controls.Add(this.label12);
            this.gbBook.Controls.Add(this.label11);
            this.gbBook.Controls.Add(this.label10);
            this.gbBook.Controls.Add(this.label9);
            this.gbBook.Controls.Add(this.label8);
            this.gbBook.Location = new System.Drawing.Point(286, 12);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(276, 288);
            this.gbBook.TabIndex = 1;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Manage Bookings";
            // 
            // tbNameEx
            // 
            this.tbNameEx.Location = new System.Drawing.Point(118, 48);
            this.tbNameEx.Name = "tbNameEx";
            this.tbNameEx.Size = new System.Drawing.Size(121, 20);
            this.tbNameEx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Excursion:";
            // 
            // cbSelectEx
            // 
            this.cbSelectEx.FormattingEnabled = true;
            this.cbSelectEx.Location = new System.Drawing.Point(118, 21);
            this.cbSelectEx.Name = "cbSelectEx";
            this.cbSelectEx.Size = new System.Drawing.Size(121, 21);
            this.cbSelectEx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // rtbDesEx
            // 
            this.rtbDesEx.Location = new System.Drawing.Point(118, 74);
            this.rtbDesEx.Name = "rtbDesEx";
            this.rtbDesEx.Size = new System.Drawing.Size(121, 53);
            this.rtbDesEx.TabIndex = 7;
            this.rtbDesEx.Text = "";
            // 
            // dtStartTimeEx
            // 
            this.dtStartTimeEx.Location = new System.Drawing.Point(118, 133);
            this.dtStartTimeEx.Name = "dtStartTimeEx";
            this.dtStartTimeEx.Size = new System.Drawing.Size(121, 20);
            this.dtStartTimeEx.TabIndex = 8;
            // 
            // dtEndTimeEx
            // 
            this.dtEndTimeEx.Location = new System.Drawing.Point(118, 159);
            this.dtEndTimeEx.Name = "dtEndTimeEx";
            this.dtEndTimeEx.Size = new System.Drawing.Size(121, 20);
            this.dtEndTimeEx.TabIndex = 9;
            // 
            // tbSeaportIDEx
            // 
            this.tbSeaportIDEx.Location = new System.Drawing.Point(118, 185);
            this.tbSeaportIDEx.Name = "tbSeaportIDEx";
            this.tbSeaportIDEx.Size = new System.Drawing.Size(121, 20);
            this.tbSeaportIDEx.TabIndex = 10;
            // 
            // tbCoachNoEx
            // 
            this.tbCoachNoEx.Location = new System.Drawing.Point(118, 211);
            this.tbCoachNoEx.Name = "tbCoachNoEx";
            this.tbCoachNoEx.Size = new System.Drawing.Size(121, 20);
            this.tbCoachNoEx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "End Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seaport ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number of Coaches:";
            // 
            // btnSubmitEx
            // 
            this.btnSubmitEx.Location = new System.Drawing.Point(83, 252);
            this.btnSubmitEx.Name = "btnSubmitEx";
            this.btnSubmitEx.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitEx.TabIndex = 17;
            this.btnSubmitEx.Text = "Submit";
            this.btnSubmitEx.UseVisualStyleBackColor = true;
            // 
            // btnCancelEx
            // 
            this.btnCancelEx.Location = new System.Drawing.Point(164, 252);
            this.btnCancelEx.Name = "btnCancelEx";
            this.btnCancelEx.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEx.TabIndex = 18;
            this.btnCancelEx.Text = "Cancel";
            this.btnCancelEx.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Booking:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cabin ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Excursion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "No. of Passengers:";
            // 
            // cbSelectBook
            // 
            this.cbSelectBook.FormattingEnabled = true;
            this.cbSelectBook.Location = new System.Drawing.Point(114, 22);
            this.cbSelectBook.Name = "cbSelectBook";
            this.cbSelectBook.Size = new System.Drawing.Size(121, 21);
            this.cbSelectBook.TabIndex = 5;
            // 
            // cbExBook
            // 
            this.cbExBook.FormattingEnabled = true;
            this.cbExBook.Location = new System.Drawing.Point(114, 50);
            this.cbExBook.Name = "cbExBook";
            this.cbExBook.Size = new System.Drawing.Size(121, 21);
            this.cbExBook.TabIndex = 6;
            // 
            // cbCabinBook
            // 
            this.cbCabinBook.FormattingEnabled = true;
            this.cbCabinBook.Location = new System.Drawing.Point(114, 78);
            this.cbCabinBook.Name = "cbCabinBook";
            this.cbCabinBook.Size = new System.Drawing.Size(121, 21);
            this.cbCabinBook.TabIndex = 7;
            // 
            // cbStatusBook
            // 
            this.cbStatusBook.FormattingEnabled = true;
            this.cbStatusBook.Location = new System.Drawing.Point(114, 105);
            this.cbStatusBook.Name = "cbStatusBook";
            this.cbStatusBook.Size = new System.Drawing.Size(121, 21);
            this.cbStatusBook.TabIndex = 8;
            // 
            // txtPassNumBook
            // 
            this.txtPassNumBook.Location = new System.Drawing.Point(114, 132);
            this.txtPassNumBook.Name = "txtPassNumBook";
            this.txtPassNumBook.Size = new System.Drawing.Size(121, 20);
            this.txtPassNumBook.TabIndex = 9;
            // 
            // btnSubmitBook
            // 
            this.btnSubmitBook.Location = new System.Drawing.Point(160, 163);
            this.btnSubmitBook.Name = "btnSubmitBook";
            this.btnSubmitBook.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitBook.TabIndex = 10;
            this.btnSubmitBook.Text = "Submit";
            this.btnSubmitBook.UseVisualStyleBackColor = true;
            // 
            // formExAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 311);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.gbExc);
            this.Name = "formExAdmin";
            this.Text = "Excursion Admin";
            this.gbExc.ResumeLayout(false);
            this.gbExc.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameEx;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCoachNoEx;
        private System.Windows.Forms.TextBox tbSeaportIDEx;
        private System.Windows.Forms.DateTimePicker dtEndTimeEx;
        private System.Windows.Forms.DateTimePicker dtStartTimeEx;
        private System.Windows.Forms.RichTextBox rtbDesEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelEx;
        private System.Windows.Forms.Button btnSubmitEx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassNumBook;
        private System.Windows.Forms.ComboBox cbStatusBook;
        private System.Windows.Forms.ComboBox cbCabinBook;
        private System.Windows.Forms.ComboBox cbExBook;
        private System.Windows.Forms.ComboBox cbSelectBook;
        private System.Windows.Forms.Button btnSubmitBook;
    }
}

