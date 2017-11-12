namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.onBoardListBox = new System.Windows.Forms.ListBox();
            this.onCoachListBox = new System.Windows.Forms.ListBox();
            this.onExcursionListBox = new System.Windows.Forms.ListBox();
            this.disembarked = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.testCount)).BeginInit();
            this.SuspendLayout();
            // 
            // onBoardListBox
            // 
            this.onBoardListBox.FormattingEnabled = true;
            this.onBoardListBox.ItemHeight = 16;
            this.onBoardListBox.Location = new System.Drawing.Point(83, 36);
            this.onBoardListBox.Name = "onBoardListBox";
            this.onBoardListBox.Size = new System.Drawing.Size(120, 84);
            this.onBoardListBox.TabIndex = 0;
            this.onBoardListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // onCoachListBox
            // 
            this.onCoachListBox.FormattingEnabled = true;
            this.onCoachListBox.ItemHeight = 16;
            this.onCoachListBox.Location = new System.Drawing.Point(455, 36);
            this.onCoachListBox.Name = "onCoachListBox";
            this.onCoachListBox.Size = new System.Drawing.Size(120, 84);
            this.onCoachListBox.TabIndex = 1;
            // 
            // onExcursionListBox
            // 
            this.onExcursionListBox.FormattingEnabled = true;
            this.onExcursionListBox.ItemHeight = 16;
            this.onExcursionListBox.Location = new System.Drawing.Point(83, 258);
            this.onExcursionListBox.Name = "onExcursionListBox";
            this.onExcursionListBox.Size = new System.Drawing.Size(129, 84);
            this.onExcursionListBox.TabIndex = 2;
            // 
            // disembarked
            // 
            this.disembarked.FormattingEnabled = true;
            this.disembarked.ItemHeight = 16;
            this.disembarked.Location = new System.Drawing.Point(455, 258);
            this.disembarked.Name = "disembarked";
            this.disembarked.Size = new System.Drawing.Size(120, 84);
            this.disembarked.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testCount
            // 
            this.testCount.Location = new System.Drawing.Point(304, 186);
            this.testCount.Name = "testCount";
            this.testCount.Size = new System.Drawing.Size(120, 22);
            this.testCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 445);
            this.Controls.Add(this.testCount);
            this.Controls.Add(this.disembarked);
            this.Controls.Add(this.onExcursionListBox);
            this.Controls.Add(this.onCoachListBox);
            this.Controls.Add(this.onBoardListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox onBoardListBox;
        private System.Windows.Forms.ListBox onCoachListBox;
        private System.Windows.Forms.ListBox onExcursionListBox;
        private System.Windows.Forms.ListBox disembarked;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown testCount;
    }
}

