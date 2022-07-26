namespace InspectionBot_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cam_Both = new System.Windows.Forms.Button();
            this.cam_rgb = new System.Windows.Forms.Button();
            this.cam_IR = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cam_down = new System.Windows.Forms.Button();
            this.cam_up = new System.Windows.Forms.Button();
            this.cam_left = new System.Windows.Forms.Button();
            this.cam_right = new System.Windows.Forms.Button();
            this.cam_center = new System.Windows.Forms.Button();
            this.cam_zoomIn = new System.Windows.Forms.Button();
            this.cam_record = new System.Windows.Forms.Button();
            this.cam_snapshot = new System.Windows.Forms.Button();
            this.cam_zoomOut = new System.Windows.Forms.Button();
            this.numberpos_full = new System.Windows.Forms.Label();
            this.numberpos_zero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.home = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.TextBox();
            this.stopmov = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startmov = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notice_manualctrl = new System.Windows.Forms.Label();
            this.EMO_Stop = new System.Windows.Forms.Button();
            this.manualGoForward = new System.Windows.Forms.Button();
            this.manualGoBackward = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.manualSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.preposlist = new System.Windows.Forms.ListBox();
            this.presetduration = new System.Windows.Forms.NumericUpDown();
            this.presetpos = new System.Windows.Forms.NumericUpDown();
            this.delpreset = new System.Windows.Forms.Button();
            this.savepreset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态检测CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetduration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetpos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.cam_Both);
            this.splitContainer1.Panel1.Controls.Add(this.cam_rgb);
            this.splitContainer1.Panel1.Controls.Add(this.cam_IR);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1MinSize = 45;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1501, 721);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // cam_Both
            // 
            this.cam_Both.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam_Both.Location = new System.Drawing.Point(5, 463);
            this.cam_Both.Margin = new System.Windows.Forms.Padding(4);
            this.cam_Both.Name = "cam_Both";
            this.cam_Both.Size = new System.Drawing.Size(33, 140);
            this.cam_Both.TabIndex = 2;
            this.cam_Both.Text = "同步监控";
            this.cam_Both.UseVisualStyleBackColor = true;
            // 
            // cam_rgb
            // 
            this.cam_rgb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam_rgb.Location = new System.Drawing.Point(5, 280);
            this.cam_rgb.Margin = new System.Windows.Forms.Padding(4);
            this.cam_rgb.Name = "cam_rgb";
            this.cam_rgb.Size = new System.Drawing.Size(33, 140);
            this.cam_rgb.TabIndex = 1;
            this.cam_rgb.Text = "监控画面";
            this.cam_rgb.UseVisualStyleBackColor = true;
            // 
            // cam_IR
            // 
            this.cam_IR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam_IR.Location = new System.Drawing.Point(5, 108);
            this.cam_IR.Margin = new System.Windows.Forms.Padding(4);
            this.cam_IR.Name = "cam_IR";
            this.cam_IR.Size = new System.Drawing.Size(33, 140);
            this.cam_IR.TabIndex = 0;
            this.cam_IR.Text = "红外热像";
            this.cam_IR.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.numberpos_full);
            this.splitContainer2.Panel1.Controls.Add(this.numberpos_zero);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.trackBar1);
            this.splitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2MinSize = 540;
            this.splitContainer2.Size = new System.Drawing.Size(1451, 721);
            this.splitContainer2.SplitterDistance = 904;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cam_down);
            this.groupBox3.Controls.Add(this.cam_up);
            this.groupBox3.Controls.Add(this.cam_left);
            this.groupBox3.Controls.Add(this.cam_right);
            this.groupBox3.Controls.Add(this.cam_center);
            this.groupBox3.Controls.Add(this.cam_zoomIn);
            this.groupBox3.Controls.Add(this.cam_record);
            this.groupBox3.Controls.Add(this.cam_snapshot);
            this.groupBox3.Controls.Add(this.cam_zoomOut);
            this.groupBox3.Location = new System.Drawing.Point(673, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 651);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "视频监控";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 495);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 20);
            this.label25.TabIndex = 12;
            this.label25.Text = "监控记录";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 377);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 20);
            this.label24.TabIndex = 10;
            this.label24.Text = "摄像头变倍";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(19, 401);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 46);
            this.button5.TabIndex = 9;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(138, 401);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 46);
            this.button6.TabIndex = 11;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 274);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "摄像头变焦";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "摄像头位姿";
            // 
            // cam_down
            // 
            this.cam_down.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_down.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_down.Location = new System.Drawing.Point(87, 168);
            this.cam_down.Margin = new System.Windows.Forms.Padding(4);
            this.cam_down.Name = "cam_down";
            this.cam_down.Size = new System.Drawing.Size(53, 55);
            this.cam_down.TabIndex = 1;
            this.cam_down.Text = "↓";
            this.cam_down.UseVisualStyleBackColor = true;
            // 
            // cam_up
            // 
            this.cam_up.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_up.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_up.Location = new System.Drawing.Point(87, 64);
            this.cam_up.Margin = new System.Windows.Forms.Padding(4);
            this.cam_up.Name = "cam_up";
            this.cam_up.Size = new System.Drawing.Size(53, 53);
            this.cam_up.TabIndex = 0;
            this.cam_up.Text = "↑";
            this.cam_up.UseVisualStyleBackColor = true;
            // 
            // cam_left
            // 
            this.cam_left.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_left.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_left.Location = new System.Drawing.Point(21, 120);
            this.cam_left.Margin = new System.Windows.Forms.Padding(4);
            this.cam_left.Name = "cam_left";
            this.cam_left.Size = new System.Drawing.Size(58, 45);
            this.cam_left.TabIndex = 2;
            this.cam_left.Text = "←";
            this.cam_left.UseVisualStyleBackColor = true;
            // 
            // cam_right
            // 
            this.cam_right.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_right.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_right.Location = new System.Drawing.Point(147, 120);
            this.cam_right.Margin = new System.Windows.Forms.Padding(4);
            this.cam_right.Name = "cam_right";
            this.cam_right.Size = new System.Drawing.Size(54, 45);
            this.cam_right.TabIndex = 3;
            this.cam_right.Text = "→";
            this.cam_right.UseVisualStyleBackColor = true;
            // 
            // cam_center
            // 
            this.cam_center.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_center.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_center.Location = new System.Drawing.Point(87, 120);
            this.cam_center.Margin = new System.Windows.Forms.Padding(4);
            this.cam_center.Name = "cam_center";
            this.cam_center.Size = new System.Drawing.Size(53, 45);
            this.cam_center.TabIndex = 4;
            this.cam_center.Text = "●";
            this.cam_center.UseVisualStyleBackColor = true;
            // 
            // cam_zoomIn
            // 
            this.cam_zoomIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_zoomIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_zoomIn.Location = new System.Drawing.Point(19, 298);
            this.cam_zoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.cam_zoomIn.Name = "cam_zoomIn";
            this.cam_zoomIn.Size = new System.Drawing.Size(71, 46);
            this.cam_zoomIn.TabIndex = 5;
            this.cam_zoomIn.Text = "+";
            this.cam_zoomIn.UseVisualStyleBackColor = true;
            // 
            // cam_record
            // 
            this.cam_record.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_record.Location = new System.Drawing.Point(42, 586);
            this.cam_record.Margin = new System.Windows.Forms.Padding(4);
            this.cam_record.Name = "cam_record";
            this.cam_record.Size = new System.Drawing.Size(133, 46);
            this.cam_record.TabIndex = 6;
            this.cam_record.Text = "录像";
            this.cam_record.UseVisualStyleBackColor = true;
            // 
            // cam_snapshot
            // 
            this.cam_snapshot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_snapshot.Location = new System.Drawing.Point(42, 519);
            this.cam_snapshot.Margin = new System.Windows.Forms.Padding(4);
            this.cam_snapshot.Name = "cam_snapshot";
            this.cam_snapshot.Size = new System.Drawing.Size(133, 46);
            this.cam_snapshot.TabIndex = 7;
            this.cam_snapshot.Text = "拍照";
            this.cam_snapshot.UseVisualStyleBackColor = true;
            // 
            // cam_zoomOut
            // 
            this.cam_zoomOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cam_zoomOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cam_zoomOut.Location = new System.Drawing.Point(138, 298);
            this.cam_zoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.cam_zoomOut.Name = "cam_zoomOut";
            this.cam_zoomOut.Size = new System.Drawing.Size(67, 46);
            this.cam_zoomOut.TabIndex = 8;
            this.cam_zoomOut.Text = "-";
            this.cam_zoomOut.UseVisualStyleBackColor = true;
            // 
            // numberpos_full
            // 
            this.numberpos_full.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberpos_full.AutoSize = true;
            this.numberpos_full.Location = new System.Drawing.Point(863, 698);
            this.numberpos_full.Name = "numberpos_full";
            this.numberpos_full.Size = new System.Drawing.Size(36, 20);
            this.numberpos_full.TabIndex = 18;
            this.numberpos_full.Text = "End";
            this.numberpos_full.LocationChanged += new System.EventHandler(this.label21_LocationChanged);
            // 
            // numberpos_zero
            // 
            this.numberpos_zero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberpos_zero.AutoSize = true;
            this.numberpos_zero.Location = new System.Drawing.Point(0, 698);
            this.numberpos_zero.Name = "numberpos_zero";
            this.numberpos_zero.Size = new System.Drawing.Size(44, 20);
            this.numberpos_zero.TabIndex = 10;
            this.numberpos_zero.Text = "Start";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 651);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(3, 662);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(896, 56);
            this.trackBar1.SmallChange = 0;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.MouseEnter += new System.EventHandler(this.trackBar1_MouseEnter);
            this.trackBar1.MouseLeave += new System.EventHandler(this.trackBar1_MouseLeave);
            this.trackBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseMove);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel1MinSize = 125;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(542, 721);
            this.splitContainer3.SplitterDistance = 145;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Controls.Add(this.position);
            this.groupBox1.Controls.Add(this.stopmov);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.startmov);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(534, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "机器人运动状态";
            // 
            // home
            // 
            this.home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home.Location = new System.Drawing.Point(253, 79);
            this.home.Margin = new System.Windows.Forms.Padding(4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(96, 27);
            this.home.TabIndex = 24;
            this.home.Text = "回原点";
            this.home.UseVisualStyleBackColor = true;
            // 
            // position
            // 
            this.position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.position.Location = new System.Drawing.Point(303, 35);
            this.position.Margin = new System.Windows.Forms.Padding(4);
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(127, 27);
            this.position.TabIndex = 23;
            // 
            // stopmov
            // 
            this.stopmov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopmov.Location = new System.Drawing.Point(134, 79);
            this.stopmov.Margin = new System.Windows.Forms.Padding(4);
            this.stopmov.Name = "stopmov";
            this.stopmov.Size = new System.Drawing.Size(96, 27);
            this.stopmov.TabIndex = 20;
            this.stopmov.Text = "停止巡航";
            this.stopmov.UseVisualStyleBackColor = true;
            this.stopmov.Click += new System.EventHandler(this.stopmov_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "位置";
            // 
            // speed
            // 
            this.speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speed.Location = new System.Drawing.Point(61, 35);
            this.speed.Margin = new System.Windows.Forms.Padding(4);
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Size = new System.Drawing.Size(127, 27);
            this.speed.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "m/s";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "速度";
            // 
            // startmov
            // 
            this.startmov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startmov.Location = new System.Drawing.Point(13, 79);
            this.startmov.Margin = new System.Windows.Forms.Padding(4);
            this.startmov.Name = "startmov";
            this.startmov.Size = new System.Drawing.Size(96, 27);
            this.startmov.TabIndex = 19;
            this.startmov.Text = "开始巡航";
            this.startmov.UseVisualStyleBackColor = true;
            this.startmov.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer4.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer4.Panel1MinSize = 125;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer4.Panel2.Controls.Add(this.preposlist);
            this.splitContainer4.Panel2.Controls.Add(this.presetduration);
            this.splitContainer4.Panel2.Controls.Add(this.presetpos);
            this.splitContainer4.Panel2.Controls.Add(this.delpreset);
            this.splitContainer4.Panel2.Controls.Add(this.savepreset);
            this.splitContainer4.Panel2.Controls.Add(this.label7);
            this.splitContainer4.Panel2.Controls.Add(this.label6);
            this.splitContainer4.Panel2.Controls.Add(this.label5);
            this.splitContainer4.Panel2.Controls.Add(this.label4);
            this.splitContainer4.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer4.Size = new System.Drawing.Size(542, 571);
            this.splitContainer4.SplitterDistance = 163;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.notice_manualctrl);
            this.groupBox2.Controls.Add(this.EMO_Stop);
            this.groupBox2.Controls.Add(this.manualGoForward);
            this.groupBox2.Controls.Add(this.manualGoBackward);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.manualSpeed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(534, 156);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "机器人手动控制";
            // 
            // notice_manualctrl
            // 
            this.notice_manualctrl.AutoSize = true;
            this.notice_manualctrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notice_manualctrl.Location = new System.Drawing.Point(8, 22);
            this.notice_manualctrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notice_manualctrl.Name = "notice_manualctrl";
            this.notice_manualctrl.Size = new System.Drawing.Size(208, 20);
            this.notice_manualctrl.TabIndex = 7;
            this.notice_manualctrl.Text = "移动控制不可用 请先停止巡航";
            // 
            // EMO_Stop
            // 
            this.EMO_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMO_Stop.BackColor = System.Drawing.Color.Red;
            this.EMO_Stop.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EMO_Stop.ForeColor = System.Drawing.Color.White;
            this.EMO_Stop.Location = new System.Drawing.Point(346, 30);
            this.EMO_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.EMO_Stop.Name = "EMO_Stop";
            this.EMO_Stop.Size = new System.Drawing.Size(171, 96);
            this.EMO_Stop.TabIndex = 6;
            this.EMO_Stop.Text = "停";
            this.EMO_Stop.UseVisualStyleBackColor = false;
            // 
            // manualGoForward
            // 
            this.manualGoForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualGoForward.Location = new System.Drawing.Point(224, 103);
            this.manualGoForward.Margin = new System.Windows.Forms.Padding(4);
            this.manualGoForward.Name = "manualGoForward";
            this.manualGoForward.Size = new System.Drawing.Size(96, 27);
            this.manualGoForward.TabIndex = 5;
            this.manualGoForward.Text = "前进 →";
            this.manualGoForward.UseVisualStyleBackColor = true;
            // 
            // manualGoBackward
            // 
            this.manualGoBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualGoBackward.Location = new System.Drawing.Point(101, 103);
            this.manualGoBackward.Margin = new System.Windows.Forms.Padding(4);
            this.manualGoBackward.Name = "manualGoBackward";
            this.manualGoBackward.Size = new System.Drawing.Size(96, 27);
            this.manualGoBackward.TabIndex = 4;
            this.manualGoBackward.Text = "← 后退";
            this.manualGoBackward.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "位置调整";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "m/s";
            // 
            // manualSpeed
            // 
            this.manualSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualSpeed.DecimalPlaces = 2;
            this.manualSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.manualSpeed.Location = new System.Drawing.Point(101, 55);
            this.manualSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.manualSpeed.Name = "manualSpeed";
            this.manualSpeed.Size = new System.Drawing.Size(154, 27);
            this.manualSpeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "速度调整";
            // 
            // preposlist
            // 
            this.preposlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preposlist.FormattingEnabled = true;
            this.preposlist.ItemHeight = 20;
            this.preposlist.Items.AddRange(new object[] {
            "位置\t停留时间"});
            this.preposlist.Location = new System.Drawing.Point(9, 92);
            this.preposlist.Name = "preposlist";
            this.preposlist.Size = new System.Drawing.Size(521, 264);
            this.preposlist.TabIndex = 13;
            // 
            // presetduration
            // 
            this.presetduration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.presetduration.Location = new System.Drawing.Point(332, 16);
            this.presetduration.Margin = new System.Windows.Forms.Padding(4);
            this.presetduration.Name = "presetduration";
            this.presetduration.Size = new System.Drawing.Size(116, 27);
            this.presetduration.TabIndex = 12;
            // 
            // presetpos
            // 
            this.presetpos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.presetpos.DecimalPlaces = 2;
            this.presetpos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.presetpos.Location = new System.Drawing.Point(79, 16);
            this.presetpos.Margin = new System.Windows.Forms.Padding(4);
            this.presetpos.Name = "presetpos";
            this.presetpos.Size = new System.Drawing.Size(113, 27);
            this.presetpos.TabIndex = 11;
            // 
            // delpreset
            // 
            this.delpreset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delpreset.Location = new System.Drawing.Point(165, 58);
            this.delpreset.Margin = new System.Windows.Forms.Padding(4);
            this.delpreset.Name = "delpreset";
            this.delpreset.Size = new System.Drawing.Size(96, 27);
            this.delpreset.TabIndex = 7;
            this.delpreset.Text = "删除";
            this.delpreset.UseVisualStyleBackColor = true;
            this.delpreset.Click += new System.EventHandler(this.delpreset_Click);
            // 
            // savepreset
            // 
            this.savepreset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savepreset.Location = new System.Drawing.Point(17, 58);
            this.savepreset.Margin = new System.Windows.Forms.Padding(4);
            this.savepreset.Name = "savepreset";
            this.savepreset.Size = new System.Drawing.Size(96, 27);
            this.savepreset.TabIndex = 6;
            this.savepreset.Text = "保存";
            this.savepreset.UseVisualStyleBackColor = true;
            this.savepreset.Click += new System.EventHandler(this.savepreset_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "s";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "停留时间";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "m";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "预留位";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置SToolStripMenuItem,
            this.状态检测CToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1501, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 状态检测CToolStripMenuItem
            // 
            this.状态检测CToolStripMenuItem.Name = "状态检测CToolStripMenuItem";
            this.状态检测CToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.状态检测CToolStripMenuItem.Text = "状态检测(&C)";
            this.状态检测CToolStripMenuItem.Click += new System.EventHandler(this.状态检测CToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1519, 796);
            this.Name = "Form1";
            this.Text = "巡检机器人上位机 Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetduration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetpos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cam_Both;
        private System.Windows.Forms.Button cam_rgb;
        private System.Windows.Forms.Button cam_IR;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cam_center;
        private System.Windows.Forms.Button cam_right;
        private System.Windows.Forms.Button cam_left;
        private System.Windows.Forms.Button cam_down;
        private System.Windows.Forms.Button cam_up;
        private System.Windows.Forms.Button cam_zoomOut;
        private System.Windows.Forms.Button cam_snapshot;
        private System.Windows.Forms.Button cam_record;
        private System.Windows.Forms.Button cam_zoomIn;
        private System.Windows.Forms.Button manualGoForward;
        private System.Windows.Forms.Button manualGoBackward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown manualSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EMO_Stop;
        private System.Windows.Forms.Label notice_manualctrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delpreset;
        private System.Windows.Forms.Button savepreset;
        private System.Windows.Forms.Button stopmov;
        private System.Windows.Forms.Button startmov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown presetduration;
        private System.Windows.Forms.NumericUpDown presetpos;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label numberpos_full;
        private System.Windows.Forms.Label numberpos_zero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox preposlist;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态检测CToolStripMenuItem;
    }
}
