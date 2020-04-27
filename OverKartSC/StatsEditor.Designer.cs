namespace OverKartSC
{
    partial class StatsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsEditor));
            this.loadBtn = new System.Windows.Forms.Button();
            this.cSelect = new System.Windows.Forms.ComboBox();
            this.h1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.h16 = new System.Windows.Forms.TextBox();
            this.h15 = new System.Windows.Forms.TextBox();
            this.h14 = new System.Windows.Forms.TextBox();
            this.h13 = new System.Windows.Forms.TextBox();
            this.h12 = new System.Windows.Forms.TextBox();
            this.h11 = new System.Windows.Forms.TextBox();
            this.h10 = new System.Windows.Forms.TextBox();
            this.h9 = new System.Windows.Forms.TextBox();
            this.h8 = new System.Windows.Forms.TextBox();
            this.h7 = new System.Windows.Forms.TextBox();
            this.h6 = new System.Windows.Forms.TextBox();
            this.h5 = new System.Windows.Forms.TextBox();
            this.h4 = new System.Windows.Forms.TextBox();
            this.h3 = new System.Windows.Forms.TextBox();
            this.h2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topspeed = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.a16 = new System.Windows.Forms.TextBox();
            this.a15 = new System.Windows.Forms.TextBox();
            this.a14 = new System.Windows.Forms.TextBox();
            this.a13 = new System.Windows.Forms.TextBox();
            this.a12 = new System.Windows.Forms.TextBox();
            this.a11 = new System.Windows.Forms.TextBox();
            this.a10 = new System.Windows.Forms.TextBox();
            this.a9 = new System.Windows.Forms.TextBox();
            this.a8 = new System.Windows.Forms.TextBox();
            this.a7 = new System.Windows.Forms.TextBox();
            this.a6 = new System.Windows.Forms.TextBox();
            this.a5 = new System.Windows.Forms.TextBox();
            this.a4 = new System.Windows.Forms.TextBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orwater = new System.Windows.Forms.TextBox();
            this.ormud = new System.Windows.Forms.TextBox();
            this.orsnow = new System.Windows.Forms.TextBox();
            this.orgrass = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.w6 = new System.Windows.Forms.TextBox();
            this.w5 = new System.Windows.Forms.TextBox();
            this.w4 = new System.Windows.Forms.TextBox();
            this.w3 = new System.Windows.Forms.TextBox();
            this.w2 = new System.Windows.Forms.TextBox();
            this.w1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sl8 = new System.Windows.Forms.TextBox();
            this.sl7 = new System.Windows.Forms.TextBox();
            this.sl6 = new System.Windows.Forms.TextBox();
            this.sl5 = new System.Windows.Forms.TextBox();
            this.sl4 = new System.Windows.Forms.TextBox();
            this.sl3 = new System.Windows.Forms.TextBox();
            this.sl2 = new System.Windows.Forms.TextBox();
            this.sl1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadClick);
            // 
            // cSelect
            // 
            this.cSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSelect.Enabled = false;
            this.cSelect.FormattingEnabled = true;
            this.cSelect.Items.AddRange(new object[] {
            "Mario",
            "Luigi",
            "Bowser",
            "Peach",
            "D. K.",
            "Wario",
            "Toad",
            "Yoshi"});
            this.cSelect.Location = new System.Drawing.Point(118, 46);
            this.cSelect.Name = "cSelect";
            this.cSelect.Size = new System.Drawing.Size(121, 21);
            this.cSelect.TabIndex = 2;
            this.cSelect.SelectedIndexChanged += new System.EventHandler(this.cSelect_SelectedIndexChanged);
            // 
            // h1
            // 
            this.h1.Location = new System.Drawing.Point(6, 19);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(85, 20);
            this.h1.TabIndex = 3;
            this.h1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.h16);
            this.groupBox1.Controls.Add(this.h15);
            this.groupBox1.Controls.Add(this.h14);
            this.groupBox1.Controls.Add(this.h13);
            this.groupBox1.Controls.Add(this.h12);
            this.groupBox1.Controls.Add(this.h11);
            this.groupBox1.Controls.Add(this.h10);
            this.groupBox1.Controls.Add(this.h9);
            this.groupBox1.Controls.Add(this.h8);
            this.groupBox1.Controls.Add(this.h7);
            this.groupBox1.Controls.Add(this.h6);
            this.groupBox1.Controls.Add(this.h5);
            this.groupBox1.Controls.Add(this.h4);
            this.groupBox1.Controls.Add(this.h3);
            this.groupBox1.Controls.Add(this.h2);
            this.groupBox1.Controls.Add(this.h1);
            this.groupBox1.Location = new System.Drawing.Point(21, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Handling Array";
            // 
            // h16
            // 
            this.h16.Location = new System.Drawing.Point(279, 97);
            this.h16.Name = "h16";
            this.h16.Size = new System.Drawing.Size(85, 20);
            this.h16.TabIndex = 18;
            this.h16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h15
            // 
            this.h15.Location = new System.Drawing.Point(188, 97);
            this.h15.Name = "h15";
            this.h15.Size = new System.Drawing.Size(85, 20);
            this.h15.TabIndex = 17;
            this.h15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h14
            // 
            this.h14.Location = new System.Drawing.Point(97, 97);
            this.h14.Name = "h14";
            this.h14.Size = new System.Drawing.Size(85, 20);
            this.h14.TabIndex = 16;
            this.h14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h13
            // 
            this.h13.Location = new System.Drawing.Point(6, 97);
            this.h13.Name = "h13";
            this.h13.Size = new System.Drawing.Size(85, 20);
            this.h13.TabIndex = 15;
            this.h13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h12
            // 
            this.h12.Location = new System.Drawing.Point(279, 71);
            this.h12.Name = "h12";
            this.h12.Size = new System.Drawing.Size(85, 20);
            this.h12.TabIndex = 14;
            this.h12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h11
            // 
            this.h11.Location = new System.Drawing.Point(189, 71);
            this.h11.Name = "h11";
            this.h11.Size = new System.Drawing.Size(85, 20);
            this.h11.TabIndex = 13;
            this.h11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h10
            // 
            this.h10.Location = new System.Drawing.Point(97, 71);
            this.h10.Name = "h10";
            this.h10.Size = new System.Drawing.Size(85, 20);
            this.h10.TabIndex = 12;
            this.h10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h9
            // 
            this.h9.Location = new System.Drawing.Point(6, 71);
            this.h9.Name = "h9";
            this.h9.Size = new System.Drawing.Size(85, 20);
            this.h9.TabIndex = 11;
            this.h9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h8
            // 
            this.h8.Location = new System.Drawing.Point(279, 45);
            this.h8.Name = "h8";
            this.h8.Size = new System.Drawing.Size(85, 20);
            this.h8.TabIndex = 10;
            this.h8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h7
            // 
            this.h7.Location = new System.Drawing.Point(188, 45);
            this.h7.Name = "h7";
            this.h7.Size = new System.Drawing.Size(85, 20);
            this.h7.TabIndex = 9;
            this.h7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h6
            // 
            this.h6.Location = new System.Drawing.Point(97, 45);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(85, 20);
            this.h6.TabIndex = 8;
            this.h6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h5
            // 
            this.h5.Location = new System.Drawing.Point(6, 45);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(85, 20);
            this.h5.TabIndex = 7;
            this.h5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h4
            // 
            this.h4.Location = new System.Drawing.Point(279, 19);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(85, 20);
            this.h4.TabIndex = 6;
            this.h4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h3
            // 
            this.h3.Location = new System.Drawing.Point(188, 19);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(85, 20);
            this.h3.TabIndex = 5;
            this.h3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // h2
            // 
            this.h2.Location = new System.Drawing.Point(97, 19);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(85, 20);
            this.h2.TabIndex = 4;
            this.h2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.topspeed);
            this.groupBox3.Location = new System.Drawing.Point(293, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Top Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topspeed
            // 
            this.topspeed.Location = new System.Drawing.Point(7, 19);
            this.topspeed.Name = "topspeed";
            this.topspeed.Size = new System.Drawing.Size(85, 20);
            this.topspeed.TabIndex = 3;
            this.topspeed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(93, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.a16);
            this.groupBox4.Controls.Add(this.a15);
            this.groupBox4.Controls.Add(this.a14);
            this.groupBox4.Controls.Add(this.a13);
            this.groupBox4.Controls.Add(this.a12);
            this.groupBox4.Controls.Add(this.a11);
            this.groupBox4.Controls.Add(this.a10);
            this.groupBox4.Controls.Add(this.a9);
            this.groupBox4.Controls.Add(this.a8);
            this.groupBox4.Controls.Add(this.a7);
            this.groupBox4.Controls.Add(this.a6);
            this.groupBox4.Controls.Add(this.a5);
            this.groupBox4.Controls.Add(this.a4);
            this.groupBox4.Controls.Add(this.a3);
            this.groupBox4.Controls.Add(this.a2);
            this.groupBox4.Controls.Add(this.a1);
            this.groupBox4.Location = new System.Drawing.Point(403, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 133);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acceleration Array";
            // 
            // a16
            // 
            this.a16.Location = new System.Drawing.Point(279, 97);
            this.a16.Name = "a16";
            this.a16.Size = new System.Drawing.Size(85, 20);
            this.a16.TabIndex = 18;
            this.a16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a15
            // 
            this.a15.Location = new System.Drawing.Point(188, 97);
            this.a15.Name = "a15";
            this.a15.Size = new System.Drawing.Size(85, 20);
            this.a15.TabIndex = 17;
            this.a15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a14
            // 
            this.a14.Location = new System.Drawing.Point(97, 97);
            this.a14.Name = "a14";
            this.a14.Size = new System.Drawing.Size(85, 20);
            this.a14.TabIndex = 16;
            this.a14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a13
            // 
            this.a13.Location = new System.Drawing.Point(6, 97);
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(85, 20);
            this.a13.TabIndex = 15;
            this.a13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(279, 71);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(85, 20);
            this.a12.TabIndex = 14;
            this.a12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(188, 71);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(85, 20);
            this.a11.TabIndex = 13;
            this.a11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a10
            // 
            this.a10.Location = new System.Drawing.Point(97, 71);
            this.a10.Name = "a10";
            this.a10.Size = new System.Drawing.Size(85, 20);
            this.a10.TabIndex = 12;
            this.a10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a9
            // 
            this.a9.Location = new System.Drawing.Point(6, 71);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(85, 20);
            this.a9.TabIndex = 11;
            this.a9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a8
            // 
            this.a8.Location = new System.Drawing.Point(279, 45);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(85, 20);
            this.a8.TabIndex = 10;
            this.a8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a7
            // 
            this.a7.Location = new System.Drawing.Point(187, 45);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(85, 20);
            this.a7.TabIndex = 9;
            this.a7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(97, 45);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(85, 20);
            this.a6.TabIndex = 8;
            this.a6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(6, 45);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(85, 20);
            this.a5.TabIndex = 7;
            this.a5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(279, 19);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(85, 20);
            this.a4.TabIndex = 6;
            this.a4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(188, 19);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(85, 20);
            this.a3.TabIndex = 5;
            this.a3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(97, 19);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(85, 20);
            this.a2.TabIndex = 4;
            this.a2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(6, 19);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(85, 20);
            this.a1.TabIndex = 3;
            this.a1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.orwater);
            this.groupBox2.Controls.Add(this.ormud);
            this.groupBox2.Controls.Add(this.orsnow);
            this.groupBox2.Controls.Add(this.orgrass);
            this.groupBox2.Location = new System.Drawing.Point(403, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Off-Road Stats";
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(280, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Water";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(188, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mud / Cloud";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(97, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Snow";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Grass";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orwater
            // 
            this.orwater.Location = new System.Drawing.Point(279, 19);
            this.orwater.Name = "orwater";
            this.orwater.Size = new System.Drawing.Size(85, 20);
            this.orwater.TabIndex = 22;
            this.orwater.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // ormud
            // 
            this.ormud.Location = new System.Drawing.Point(188, 19);
            this.ormud.Name = "ormud";
            this.ormud.Size = new System.Drawing.Size(85, 20);
            this.ormud.TabIndex = 21;
            this.ormud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // orsnow
            // 
            this.orsnow.Location = new System.Drawing.Point(97, 19);
            this.orsnow.Name = "orsnow";
            this.orsnow.Size = new System.Drawing.Size(85, 20);
            this.orsnow.TabIndex = 20;
            this.orsnow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // orgrass
            // 
            this.orgrass.Location = new System.Drawing.Point(6, 19);
            this.orgrass.Name = "orgrass";
            this.orgrass.Size = new System.Drawing.Size(85, 20);
            this.orgrass.TabIndex = 19;
            this.orgrass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.w6);
            this.groupBox5.Controls.Add(this.w5);
            this.groupBox5.Controls.Add(this.w4);
            this.groupBox5.Controls.Add(this.w3);
            this.groupBox5.Controls.Add(this.w2);
            this.groupBox5.Controls.Add(this.w1);
            this.groupBox5.Location = new System.Drawing.Point(491, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 80);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Weight";
            // 
            // w6
            // 
            this.w6.Location = new System.Drawing.Point(195, 45);
            this.w6.Name = "w6";
            this.w6.Size = new System.Drawing.Size(85, 20);
            this.w6.TabIndex = 25;
            this.w6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // w5
            // 
            this.w5.Location = new System.Drawing.Point(104, 45);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(85, 20);
            this.w5.TabIndex = 24;
            this.w5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(13, 45);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(85, 20);
            this.w4.TabIndex = 23;
            this.w4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(195, 19);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(85, 20);
            this.w3.TabIndex = 22;
            this.w3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(104, 19);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(85, 20);
            this.w2.TabIndex = 21;
            this.w2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(13, 19);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(85, 20);
            this.w1.TabIndex = 20;
            this.w1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.cSelect);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Location = new System.Drawing.Point(12, 41);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(798, 262);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Character Stats";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Location = new System.Drawing.Point(12, 322);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(798, 121);
            this.groupBox8.TabIndex = 31;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Global Stats";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sl8);
            this.groupBox6.Controls.Add(this.sl7);
            this.groupBox6.Controls.Add(this.sl6);
            this.groupBox6.Controls.Add(this.sl5);
            this.groupBox6.Controls.Add(this.sl4);
            this.groupBox6.Controls.Add(this.sl3);
            this.groupBox6.Controls.Add(this.sl2);
            this.groupBox6.Controls.Add(this.sl1);
            this.groupBox6.Location = new System.Drawing.Point(21, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(376, 77);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Speed Loss";
            // 
            // sl8
            // 
            this.sl8.Location = new System.Drawing.Point(279, 45);
            this.sl8.Name = "sl8";
            this.sl8.Size = new System.Drawing.Size(85, 20);
            this.sl8.TabIndex = 10;
            // 
            // sl7
            // 
            this.sl7.Location = new System.Drawing.Point(189, 45);
            this.sl7.Name = "sl7";
            this.sl7.Size = new System.Drawing.Size(85, 20);
            this.sl7.TabIndex = 9;
            // 
            // sl6
            // 
            this.sl6.Location = new System.Drawing.Point(97, 45);
            this.sl6.Name = "sl6";
            this.sl6.Size = new System.Drawing.Size(85, 20);
            this.sl6.TabIndex = 8;
            // 
            // sl5
            // 
            this.sl5.Location = new System.Drawing.Point(6, 45);
            this.sl5.Name = "sl5";
            this.sl5.Size = new System.Drawing.Size(85, 20);
            this.sl5.TabIndex = 7;
            // 
            // sl4
            // 
            this.sl4.Location = new System.Drawing.Point(279, 19);
            this.sl4.Name = "sl4";
            this.sl4.Size = new System.Drawing.Size(85, 20);
            this.sl4.TabIndex = 6;
            // 
            // sl3
            // 
            this.sl3.Location = new System.Drawing.Point(188, 19);
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(85, 20);
            this.sl3.TabIndex = 5;
            // 
            // sl2
            // 
            this.sl2.Location = new System.Drawing.Point(97, 19);
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(85, 20);
            this.sl2.TabIndex = 4;
            // 
            // sl1
            // 
            this.sl1.Location = new System.Drawing.Point(6, 19);
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(85, 20);
            this.sl1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Character";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 451);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsEditor";
            this.Text = "Stats Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox cSelect;
        private System.Windows.Forms.TextBox h1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox h6;
        private System.Windows.Forms.TextBox h5;
        private System.Windows.Forms.TextBox h4;
        private System.Windows.Forms.TextBox h3;
        private System.Windows.Forms.TextBox h2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox topspeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox h16;
        private System.Windows.Forms.TextBox h15;
        private System.Windows.Forms.TextBox h14;
        private System.Windows.Forms.TextBox h13;
        private System.Windows.Forms.TextBox h12;
        private System.Windows.Forms.TextBox h11;
        private System.Windows.Forms.TextBox h10;
        private System.Windows.Forms.TextBox h9;
        private System.Windows.Forms.TextBox h8;
        private System.Windows.Forms.TextBox h7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox a16;
        private System.Windows.Forms.TextBox a15;
        private System.Windows.Forms.TextBox a14;
        private System.Windows.Forms.TextBox a13;
        private System.Windows.Forms.TextBox a12;
        private System.Windows.Forms.TextBox a11;
        private System.Windows.Forms.TextBox a10;
        private System.Windows.Forms.TextBox a9;
        private System.Windows.Forms.TextBox a8;
        private System.Windows.Forms.TextBox a7;
        private System.Windows.Forms.TextBox a6;
        private System.Windows.Forms.TextBox a5;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orwater;
        private System.Windows.Forms.TextBox ormud;
        private System.Windows.Forms.TextBox orsnow;
        private System.Windows.Forms.TextBox orgrass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox w3;
        private System.Windows.Forms.TextBox w2;
        private System.Windows.Forms.TextBox w1;
        private System.Windows.Forms.TextBox w6;
        private System.Windows.Forms.TextBox w5;
        private System.Windows.Forms.TextBox w4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox sl8;
        private System.Windows.Forms.TextBox sl7;
        private System.Windows.Forms.TextBox sl6;
        private System.Windows.Forms.TextBox sl5;
        private System.Windows.Forms.TextBox sl4;
        private System.Windows.Forms.TextBox sl3;
        private System.Windows.Forms.TextBox sl2;
        private System.Windows.Forms.TextBox sl1;
        private System.Windows.Forms.Label label6;
    }
}

