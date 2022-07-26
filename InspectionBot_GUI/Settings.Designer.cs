namespace InspectionBot_GUI
{
    partial class Settings
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
            this.travel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedlimit = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.travel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedlimit)).BeginInit();
            this.SuspendLayout();
            // 
            // travel
            // 
            this.travel.DecimalPlaces = 2;
            this.travel.Location = new System.Drawing.Point(78, 23);
            this.travel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(114, 27);
            this.travel.TabIndex = 0;
            this.travel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "总里程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "限速";
            // 
            // speedlimit
            // 
            this.speedlimit.DecimalPlaces = 2;
            this.speedlimit.Location = new System.Drawing.Point(78, 67);
            this.speedlimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedlimit.Name = "speedlimit";
            this.speedlimit.Size = new System.Drawing.Size(114, 27);
            this.speedlimit.TabIndex = 3;
            this.speedlimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 113);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.speedlimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.travel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "基础设置";
            ((System.ComponentModel.ISupportInitialize)(this.travel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedlimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown travel;
        public System.Windows.Forms.NumericUpDown speedlimit;
    }
}