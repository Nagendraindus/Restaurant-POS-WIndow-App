namespace RestApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closelbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NoodlesTbb = new System.Windows.Forms.TextBox();
            this.NoodlesTb = new System.Windows.Forms.Label();
            this.NoodlesCb = new System.Windows.Forms.CheckBox();
            this.ChickenTbb = new System.Windows.Forms.TextBox();
            this.ChickenTb = new System.Windows.Forms.Label();
            this.ChickenCb = new System.Windows.Forms.CheckBox();
            this.SandwichTbb = new System.Windows.Forms.TextBox();
            this.SandwichTb = new System.Windows.Forms.Label();
            this.SandwichCb = new System.Windows.Forms.CheckBox();
            this.SaladTbb = new System.Windows.Forms.TextBox();
            this.SaladTb = new System.Windows.Forms.Label();
            this.SaladCb = new System.Windows.Forms.CheckBox();
            this.BurgerTbb = new System.Windows.Forms.TextBox();
            this.BurgerTb = new System.Windows.Forms.Label();
            this.BurgerCb = new System.Windows.Forms.CheckBox();
            this.FriesTbb = new System.Windows.Forms.TextBox();
            this.FriesTb = new System.Windows.Forms.Label();
            this.FriesCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LassiTbb = new System.Windows.Forms.TextBox();
            this.LassiTb = new System.Windows.Forms.Label();
            this.LassiCb = new System.Windows.Forms.CheckBox();
            this.CakesTbb = new System.Windows.Forms.TextBox();
            this.CakesTb = new System.Windows.Forms.Label();
            this.CakesCb = new System.Windows.Forms.CheckBox();
            this.ChocoTbb = new System.Windows.Forms.TextBox();
            this.ChocoTb = new System.Windows.Forms.Label();
            this.ChocoCb = new System.Windows.Forms.CheckBox();
            this.WaterTbb = new System.Windows.Forms.TextBox();
            this.WaterTb = new System.Windows.Forms.Label();
            this.WaterCb = new System.Windows.Forms.CheckBox();
            this.ColaTbb = new System.Windows.Forms.TextBox();
            this.TeaTbb = new System.Windows.Forms.TextBox();
            this.ColaTb = new System.Windows.Forms.Label();
            this.ColaCb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeaTb = new System.Windows.Forms.Label();
            this.TeaCb = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Grdtotallbl = new System.Windows.Forms.Label();
            this.taxlbl = new System.Windows.Forms.Label();
            this.Subtotallbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RecieptTb = new System.Windows.Forms.RichTextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Date2lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Date2lbl);
            this.panel1.Controls.Add(this.Closelbl);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // Closelbl
            // 
            this.Closelbl.AutoSize = true;
            this.Closelbl.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closelbl.ForeColor = System.Drawing.Color.Red;
            this.Closelbl.Location = new System.Drawing.Point(1008, 0);
            this.Closelbl.Name = "Closelbl";
            this.Closelbl.Size = new System.Drawing.Size(39, 36);
            this.Closelbl.TabIndex = 22;
            this.Closelbl.Text = "X";
            this.Closelbl.Click += new System.EventHandler(this.Closelbl_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Datelbl.Location = new System.Drawing.Point(953, 47);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(39, 24);
            this.Datelbl.TabIndex = 21;
            this.Datelbl.Text = "Time";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(263, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 38);
            this.panel6.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "FAST FOOD RESTAURANT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(799, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 573);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 414);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NoodlesTbb);
            this.panel3.Controls.Add(this.NoodlesTb);
            this.panel3.Controls.Add(this.NoodlesCb);
            this.panel3.Controls.Add(this.ChickenTbb);
            this.panel3.Controls.Add(this.ChickenTb);
            this.panel3.Controls.Add(this.ChickenCb);
            this.panel3.Controls.Add(this.SandwichTbb);
            this.panel3.Controls.Add(this.SandwichTb);
            this.panel3.Controls.Add(this.SandwichCb);
            this.panel3.Controls.Add(this.SaladTbb);
            this.panel3.Controls.Add(this.SaladTb);
            this.panel3.Controls.Add(this.SaladCb);
            this.panel3.Controls.Add(this.BurgerTbb);
            this.panel3.Controls.Add(this.BurgerTb);
            this.panel3.Controls.Add(this.BurgerCb);
            this.panel3.Controls.Add(this.FriesTbb);
            this.panel3.Controls.Add(this.FriesTb);
            this.panel3.Controls.Add(this.FriesCb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 573);
            this.panel3.TabIndex = 1;
            // 
            // NoodlesTbb
            // 
            this.NoodlesTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoodlesTbb.Enabled = false;
            this.NoodlesTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoodlesTbb.Location = new System.Drawing.Point(176, 500);
            this.NoodlesTbb.Multiline = true;
            this.NoodlesTbb.Name = "NoodlesTbb";
            this.NoodlesTbb.Size = new System.Drawing.Size(36, 38);
            this.NoodlesTbb.TabIndex = 20;
            this.NoodlesTbb.Text = "0";
            this.NoodlesTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NoodlesTb
            // 
            this.NoodlesTb.AutoSize = true;
            this.NoodlesTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoodlesTb.ForeColor = System.Drawing.Color.Maroon;
            this.NoodlesTb.Location = new System.Drawing.Point(74, 499);
            this.NoodlesTb.Name = "NoodlesTb";
            this.NoodlesTb.Size = new System.Drawing.Size(80, 29);
            this.NoodlesTb.TabIndex = 19;
            this.NoodlesTb.Text = "Noodles";
            // 
            // NoodlesCb
            // 
            this.NoodlesCb.AutoSize = true;
            this.NoodlesCb.Location = new System.Drawing.Point(12, 511);
            this.NoodlesCb.Name = "NoodlesCb";
            this.NoodlesCb.Size = new System.Drawing.Size(18, 17);
            this.NoodlesCb.TabIndex = 18;
            this.NoodlesCb.UseVisualStyleBackColor = true;
            this.NoodlesCb.CheckedChanged += new System.EventHandler(this.NoodlesCb_CheckedChanged);
            // 
            // ChickenTbb
            // 
            this.ChickenTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChickenTbb.Enabled = false;
            this.ChickenTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChickenTbb.Location = new System.Drawing.Point(176, 407);
            this.ChickenTbb.Multiline = true;
            this.ChickenTbb.Name = "ChickenTbb";
            this.ChickenTbb.Size = new System.Drawing.Size(36, 38);
            this.ChickenTbb.TabIndex = 17;
            this.ChickenTbb.Text = "0";
            this.ChickenTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChickenTb
            // 
            this.ChickenTb.AutoSize = true;
            this.ChickenTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChickenTb.ForeColor = System.Drawing.Color.Maroon;
            this.ChickenTb.Location = new System.Drawing.Point(75, 405);
            this.ChickenTb.Name = "ChickenTb";
            this.ChickenTb.Size = new System.Drawing.Size(79, 29);
            this.ChickenTb.TabIndex = 16;
            this.ChickenTb.Text = "Chicken";
            // 
            // ChickenCb
            // 
            this.ChickenCb.AutoSize = true;
            this.ChickenCb.Location = new System.Drawing.Point(12, 418);
            this.ChickenCb.Name = "ChickenCb";
            this.ChickenCb.Size = new System.Drawing.Size(18, 17);
            this.ChickenCb.TabIndex = 15;
            this.ChickenCb.UseVisualStyleBackColor = true;
            this.ChickenCb.CheckedChanged += new System.EventHandler(this.ChickenCb_CheckedChanged);
            // 
            // SandwichTbb
            // 
            this.SandwichTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SandwichTbb.Enabled = false;
            this.SandwichTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichTbb.Location = new System.Drawing.Point(176, 317);
            this.SandwichTbb.Multiline = true;
            this.SandwichTbb.Name = "SandwichTbb";
            this.SandwichTbb.Size = new System.Drawing.Size(36, 38);
            this.SandwichTbb.TabIndex = 14;
            this.SandwichTbb.Text = "0";
            this.SandwichTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SandwichTb
            // 
            this.SandwichTb.AutoSize = true;
            this.SandwichTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichTb.ForeColor = System.Drawing.Color.Maroon;
            this.SandwichTb.Location = new System.Drawing.Point(58, 316);
            this.SandwichTb.Name = "SandwichTb";
            this.SandwichTb.Size = new System.Drawing.Size(96, 29);
            this.SandwichTb.TabIndex = 13;
            this.SandwichTb.Text = "Sandwich";
            // 
            // SandwichCb
            // 
            this.SandwichCb.AutoSize = true;
            this.SandwichCb.Location = new System.Drawing.Point(12, 328);
            this.SandwichCb.Name = "SandwichCb";
            this.SandwichCb.Size = new System.Drawing.Size(18, 17);
            this.SandwichCb.TabIndex = 12;
            this.SandwichCb.UseVisualStyleBackColor = true;
            this.SandwichCb.CheckedChanged += new System.EventHandler(this.SandwichCb_CheckedChanged);
            // 
            // SaladTbb
            // 
            this.SaladTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaladTbb.Enabled = false;
            this.SaladTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaladTbb.Location = new System.Drawing.Point(176, 219);
            this.SaladTbb.Multiline = true;
            this.SaladTbb.Name = "SaladTbb";
            this.SaladTbb.Size = new System.Drawing.Size(36, 38);
            this.SaladTbb.TabIndex = 11;
            this.SaladTbb.Text = "0";
            this.SaladTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaladTb
            // 
            this.SaladTb.AutoSize = true;
            this.SaladTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaladTb.ForeColor = System.Drawing.Color.Maroon;
            this.SaladTb.Location = new System.Drawing.Point(80, 218);
            this.SaladTb.Name = "SaladTb";
            this.SaladTb.Size = new System.Drawing.Size(59, 29);
            this.SaladTb.TabIndex = 10;
            this.SaladTb.Text = "Salad";
            // 
            // SaladCb
            // 
            this.SaladCb.AutoSize = true;
            this.SaladCb.Location = new System.Drawing.Point(12, 230);
            this.SaladCb.Name = "SaladCb";
            this.SaladCb.Size = new System.Drawing.Size(18, 17);
            this.SaladCb.TabIndex = 9;
            this.SaladCb.UseVisualStyleBackColor = true;
            this.SaladCb.CheckedChanged += new System.EventHandler(this.SaladCb_CheckedChanged_1);
            // 
            // BurgerTbb
            // 
            this.BurgerTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BurgerTbb.Enabled = false;
            this.BurgerTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerTbb.Location = new System.Drawing.Point(176, 127);
            this.BurgerTbb.Multiline = true;
            this.BurgerTbb.Name = "BurgerTbb";
            this.BurgerTbb.Size = new System.Drawing.Size(36, 38);
            this.BurgerTbb.TabIndex = 8;
            this.BurgerTbb.Text = "0";
            this.BurgerTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BurgerTb
            // 
            this.BurgerTb.AutoSize = true;
            this.BurgerTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerTb.ForeColor = System.Drawing.Color.Maroon;
            this.BurgerTb.Location = new System.Drawing.Point(75, 126);
            this.BurgerTb.Name = "BurgerTb";
            this.BurgerTb.Size = new System.Drawing.Size(74, 29);
            this.BurgerTb.TabIndex = 7;
            this.BurgerTb.Text = "Burger";
            // 
            // BurgerCb
            // 
            this.BurgerCb.AutoSize = true;
            this.BurgerCb.Location = new System.Drawing.Point(12, 138);
            this.BurgerCb.Name = "BurgerCb";
            this.BurgerCb.Size = new System.Drawing.Size(18, 17);
            this.BurgerCb.TabIndex = 6;
            this.BurgerCb.UseVisualStyleBackColor = true;
            this.BurgerCb.CheckedChanged += new System.EventHandler(this.BurgerCb_CheckedChanged_1);
            // 
            // FriesTbb
            // 
            this.FriesTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriesTbb.Enabled = false;
            this.FriesTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriesTbb.Location = new System.Drawing.Point(176, 49);
            this.FriesTbb.Multiline = true;
            this.FriesTbb.Name = "FriesTbb";
            this.FriesTbb.Size = new System.Drawing.Size(36, 38);
            this.FriesTbb.TabIndex = 5;
            this.FriesTbb.Text = "0";
            this.FriesTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FriesTb
            // 
            this.FriesTb.AutoSize = true;
            this.FriesTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriesTb.ForeColor = System.Drawing.Color.Maroon;
            this.FriesTb.Location = new System.Drawing.Point(80, 48);
            this.FriesTb.Name = "FriesTb";
            this.FriesTb.Size = new System.Drawing.Size(57, 29);
            this.FriesTb.TabIndex = 4;
            this.FriesTb.Text = "Fries";
            this.FriesTb.Click += new System.EventHandler(this.label4_Click);
            // 
            // FriesCb
            // 
            this.FriesCb.AutoSize = true;
            this.FriesCb.Location = new System.Drawing.Point(12, 60);
            this.FriesCb.Name = "FriesCb";
            this.FriesCb.Size = new System.Drawing.Size(18, 17);
            this.FriesCb.TabIndex = 3;
            this.FriesCb.UseVisualStyleBackColor = true;
            this.FriesCb.CheckedChanged += new System.EventHandler(this.FriesCb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(46, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fast Food";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleGreen;
            this.panel5.Controls.Add(this.LassiTbb);
            this.panel5.Controls.Add(this.LassiTb);
            this.panel5.Controls.Add(this.LassiCb);
            this.panel5.Controls.Add(this.CakesTbb);
            this.panel5.Controls.Add(this.CakesTb);
            this.panel5.Controls.Add(this.CakesCb);
            this.panel5.Controls.Add(this.ChocoTbb);
            this.panel5.Controls.Add(this.ChocoTb);
            this.panel5.Controls.Add(this.ChocoCb);
            this.panel5.Controls.Add(this.WaterTbb);
            this.panel5.Controls.Add(this.WaterTb);
            this.panel5.Controls.Add(this.WaterCb);
            this.panel5.Controls.Add(this.ColaTbb);
            this.panel5.Controls.Add(this.TeaTbb);
            this.panel5.Controls.Add(this.ColaTb);
            this.panel5.Controls.Add(this.ColaCb);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.TeaTb);
            this.panel5.Controls.Add(this.TeaCb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(804, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 573);
            this.panel5.TabIndex = 2;
            // 
            // LassiTbb
            // 
            this.LassiTbb.BackColor = System.Drawing.SystemColors.Window;
            this.LassiTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LassiTbb.Enabled = false;
            this.LassiTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LassiTbb.Location = new System.Drawing.Point(197, 499);
            this.LassiTbb.Multiline = true;
            this.LassiTbb.Name = "LassiTbb";
            this.LassiTbb.Size = new System.Drawing.Size(36, 38);
            this.LassiTbb.TabIndex = 20;
            this.LassiTbb.Text = "0";
            this.LassiTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LassiTb
            // 
            this.LassiTb.AutoSize = true;
            this.LassiTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LassiTb.ForeColor = System.Drawing.Color.Maroon;
            this.LassiTb.Location = new System.Drawing.Point(101, 498);
            this.LassiTb.Name = "LassiTb";
            this.LassiTb.Size = new System.Drawing.Size(57, 29);
            this.LassiTb.TabIndex = 19;
            this.LassiTb.Text = "Lassi";
            // 
            // LassiCb
            // 
            this.LassiCb.AutoSize = true;
            this.LassiCb.Location = new System.Drawing.Point(33, 510);
            this.LassiCb.Name = "LassiCb";
            this.LassiCb.Size = new System.Drawing.Size(18, 17);
            this.LassiCb.TabIndex = 18;
            this.LassiCb.UseVisualStyleBackColor = true;
            this.LassiCb.CheckedChanged += new System.EventHandler(this.LassiCb_CheckedChanged);
            // 
            // CakesTbb
            // 
            this.CakesTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CakesTbb.Enabled = false;
            this.CakesTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CakesTbb.Location = new System.Drawing.Point(197, 406);
            this.CakesTbb.Multiline = true;
            this.CakesTbb.Name = "CakesTbb";
            this.CakesTbb.Size = new System.Drawing.Size(36, 38);
            this.CakesTbb.TabIndex = 17;
            this.CakesTbb.Text = "0";
            this.CakesTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CakesTb
            // 
            this.CakesTb.AutoSize = true;
            this.CakesTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CakesTb.ForeColor = System.Drawing.Color.Maroon;
            this.CakesTb.Location = new System.Drawing.Point(101, 405);
            this.CakesTb.Name = "CakesTb";
            this.CakesTb.Size = new System.Drawing.Size(64, 29);
            this.CakesTb.TabIndex = 16;
            this.CakesTb.Text = "Cakes";
            // 
            // CakesCb
            // 
            this.CakesCb.AutoSize = true;
            this.CakesCb.Location = new System.Drawing.Point(33, 417);
            this.CakesCb.Name = "CakesCb";
            this.CakesCb.Size = new System.Drawing.Size(18, 17);
            this.CakesCb.TabIndex = 15;
            this.CakesCb.UseVisualStyleBackColor = true;
            this.CakesCb.CheckedChanged += new System.EventHandler(this.CakesCb_CheckedChanged);
            // 
            // ChocoTbb
            // 
            this.ChocoTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChocoTbb.Enabled = false;
            this.ChocoTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocoTbb.Location = new System.Drawing.Point(197, 316);
            this.ChocoTbb.Multiline = true;
            this.ChocoTbb.Name = "ChocoTbb";
            this.ChocoTbb.Size = new System.Drawing.Size(36, 38);
            this.ChocoTbb.TabIndex = 14;
            this.ChocoTbb.Text = "0";
            this.ChocoTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChocoTb
            // 
            this.ChocoTb.AutoSize = true;
            this.ChocoTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocoTb.ForeColor = System.Drawing.Color.Maroon;
            this.ChocoTb.Location = new System.Drawing.Point(78, 316);
            this.ChocoTb.Name = "ChocoTb";
            this.ChocoTb.Size = new System.Drawing.Size(96, 29);
            this.ChocoTb.TabIndex = 13;
            this.ChocoTb.Text = "Chocolate";
            // 
            // ChocoCb
            // 
            this.ChocoCb.AutoSize = true;
            this.ChocoCb.Location = new System.Drawing.Point(33, 327);
            this.ChocoCb.Name = "ChocoCb";
            this.ChocoCb.Size = new System.Drawing.Size(18, 17);
            this.ChocoCb.TabIndex = 12;
            this.ChocoCb.UseVisualStyleBackColor = true;
            this.ChocoCb.CheckedChanged += new System.EventHandler(this.ChocoCb_CheckedChanged);
            // 
            // WaterTbb
            // 
            this.WaterTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WaterTbb.Enabled = false;
            this.WaterTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterTbb.Location = new System.Drawing.Point(197, 217);
            this.WaterTbb.Multiline = true;
            this.WaterTbb.Name = "WaterTbb";
            this.WaterTbb.Size = new System.Drawing.Size(36, 38);
            this.WaterTbb.TabIndex = 11;
            this.WaterTbb.Text = "0";
            this.WaterTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WaterTb
            // 
            this.WaterTb.AutoSize = true;
            this.WaterTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterTb.ForeColor = System.Drawing.Color.Maroon;
            this.WaterTb.Location = new System.Drawing.Point(101, 216);
            this.WaterTb.Name = "WaterTb";
            this.WaterTb.Size = new System.Drawing.Size(69, 29);
            this.WaterTb.TabIndex = 10;
            this.WaterTb.Text = "Water";
            // 
            // WaterCb
            // 
            this.WaterCb.AutoSize = true;
            this.WaterCb.Location = new System.Drawing.Point(33, 228);
            this.WaterCb.Name = "WaterCb";
            this.WaterCb.Size = new System.Drawing.Size(18, 17);
            this.WaterCb.TabIndex = 9;
            this.WaterCb.UseVisualStyleBackColor = true;
            this.WaterCb.CheckedChanged += new System.EventHandler(this.WaterCb_CheckedChanged);
            // 
            // ColaTbb
            // 
            this.ColaTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColaTbb.Enabled = false;
            this.ColaTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColaTbb.Location = new System.Drawing.Point(197, 134);
            this.ColaTbb.Multiline = true;
            this.ColaTbb.Name = "ColaTbb";
            this.ColaTbb.Size = new System.Drawing.Size(36, 38);
            this.ColaTbb.TabIndex = 8;
            this.ColaTbb.Text = "0";
            this.ColaTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeaTbb
            // 
            this.TeaTbb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeaTbb.Enabled = false;
            this.TeaTbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaTbb.Location = new System.Drawing.Point(197, 56);
            this.TeaTbb.Multiline = true;
            this.TeaTbb.Name = "TeaTbb";
            this.TeaTbb.Size = new System.Drawing.Size(36, 38);
            this.TeaTbb.TabIndex = 8;
            this.TeaTbb.Text = "0";
            this.TeaTbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColaTb
            // 
            this.ColaTb.AutoSize = true;
            this.ColaTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColaTb.ForeColor = System.Drawing.Color.Maroon;
            this.ColaTb.Location = new System.Drawing.Point(101, 133);
            this.ColaTb.Name = "ColaTb";
            this.ColaTb.Size = new System.Drawing.Size(48, 29);
            this.ColaTb.TabIndex = 7;
            this.ColaTb.Text = "cola";
            // 
            // ColaCb
            // 
            this.ColaCb.AutoSize = true;
            this.ColaCb.Location = new System.Drawing.Point(33, 145);
            this.ColaCb.Name = "ColaCb";
            this.ColaCb.Size = new System.Drawing.Size(18, 17);
            this.ColaCb.TabIndex = 6;
            this.ColaCb.UseVisualStyleBackColor = true;
            this.ColaCb.CheckedChanged += new System.EventHandler(this.ColaCb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(32, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drinks / Dessert";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TeaTb
            // 
            this.TeaTb.AutoSize = true;
            this.TeaTb.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaTb.ForeColor = System.Drawing.Color.Maroon;
            this.TeaTb.Location = new System.Drawing.Point(101, 55);
            this.TeaTb.Name = "TeaTb";
            this.TeaTb.Size = new System.Drawing.Size(43, 29);
            this.TeaTb.TabIndex = 7;
            this.TeaTb.Text = "Tea";
            // 
            // TeaCb
            // 
            this.TeaCb.AutoSize = true;
            this.TeaCb.Location = new System.Drawing.Point(33, 67);
            this.TeaCb.Name = "TeaCb";
            this.TeaCb.Size = new System.Drawing.Size(18, 17);
            this.TeaCb.TabIndex = 6;
            this.TeaCb.UseVisualStyleBackColor = true;
            this.TeaCb.CheckedChanged += new System.EventHandler(this.TeaCb_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.HotPink;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(264, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 45);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(212, 2);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Meal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.Grdtotallbl);
            this.panel8.Controls.Add(this.taxlbl);
            this.panel8.Controls.Add(this.Subtotallbl);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(258, 551);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(546, 122);
            this.panel8.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(389, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "PRINT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(212, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(18, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grdtotallbl
            // 
            this.Grdtotallbl.AutoSize = true;
            this.Grdtotallbl.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grdtotallbl.ForeColor = System.Drawing.Color.Black;
            this.Grdtotallbl.Location = new System.Drawing.Point(451, 21);
            this.Grdtotallbl.Name = "Grdtotallbl";
            this.Grdtotallbl.Size = new System.Drawing.Size(49, 24);
            this.Grdtotallbl.TabIndex = 26;
            this.Grdtotallbl.Text = "Rs/- -";
            // 
            // taxlbl
            // 
            this.taxlbl.AutoSize = true;
            this.taxlbl.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxlbl.ForeColor = System.Drawing.Color.Black;
            this.taxlbl.Location = new System.Drawing.Point(270, 21);
            this.taxlbl.Name = "taxlbl";
            this.taxlbl.Size = new System.Drawing.Size(49, 24);
            this.taxlbl.TabIndex = 25;
            this.taxlbl.Text = "Rs/- -";
            // 
            // Subtotallbl
            // 
            this.Subtotallbl.AutoSize = true;
            this.Subtotallbl.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotallbl.ForeColor = System.Drawing.Color.Black;
            this.Subtotallbl.Location = new System.Drawing.Point(99, 21);
            this.Subtotallbl.Name = "Subtotallbl";
            this.Subtotallbl.Size = new System.Drawing.Size(49, 24);
            this.Subtotallbl.TabIndex = 24;
            this.Subtotallbl.Text = "Rs/- -";
            this.Subtotallbl.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(389, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(220, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tax";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "SubTotal";
            // 
            // RecieptTb
            // 
            this.RecieptTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecieptTb.Location = new System.Drawing.Point(269, 161);
            this.RecieptTb.Name = "RecieptTb";
            this.RecieptTb.Size = new System.Drawing.Size(525, 375);
            this.RecieptTb.TabIndex = 30;
            this.RecieptTb.Text = "";
            this.RecieptTb.TextChanged += new System.EventHandler(this.RecieptTb_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Date2lbl
            // 
            this.Date2lbl.AutoSize = true;
            this.Date2lbl.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date2lbl.Location = new System.Drawing.Point(11, 47);
            this.Date2lbl.Name = "Date2lbl";
            this.Date2lbl.Size = new System.Drawing.Size(37, 24);
            this.Date2lbl.TabIndex = 23;
            this.Date2lbl.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.ControlBox = false;
            this.Controls.Add(this.RecieptTb);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FriesTb;
        private System.Windows.Forms.CheckBox FriesCb;
        private System.Windows.Forms.TextBox FriesTbb;
        private System.Windows.Forms.TextBox NoodlesTbb;
        private System.Windows.Forms.Label NoodlesTb;
        private System.Windows.Forms.CheckBox NoodlesCb;
        private System.Windows.Forms.TextBox ChickenTbb;
        private System.Windows.Forms.Label ChickenTb;
        private System.Windows.Forms.CheckBox ChickenCb;
        private System.Windows.Forms.TextBox SandwichTbb;
        private System.Windows.Forms.Label SandwichTb;
        private System.Windows.Forms.CheckBox SandwichCb;
        private System.Windows.Forms.TextBox SaladTbb;
        private System.Windows.Forms.Label SaladTb;
        private System.Windows.Forms.CheckBox SaladCb;
        private System.Windows.Forms.TextBox BurgerTbb;
        private System.Windows.Forms.Label BurgerTb;
        private System.Windows.Forms.CheckBox BurgerCb;
        private System.Windows.Forms.TextBox ChocoTbb;
        private System.Windows.Forms.Label ChocoTb;
        private System.Windows.Forms.CheckBox ChocoCb;
        private System.Windows.Forms.TextBox WaterTbb;
        private System.Windows.Forms.Label WaterTb;
        private System.Windows.Forms.CheckBox WaterCb;
        private System.Windows.Forms.TextBox ColaTbb;
        private System.Windows.Forms.TextBox TeaTbb;
        private System.Windows.Forms.Label ColaTb;
        private System.Windows.Forms.CheckBox ColaCb;
        private System.Windows.Forms.Label TeaTb;
        private System.Windows.Forms.CheckBox TeaCb;
        private System.Windows.Forms.TextBox LassiTbb;
        private System.Windows.Forms.Label LassiTb;
        private System.Windows.Forms.CheckBox LassiCb;
        private System.Windows.Forms.TextBox CakesTbb;
        private System.Windows.Forms.Label CakesTb;
        private System.Windows.Forms.CheckBox CakesCb;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Closelbl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Subtotallbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Grdtotallbl;
        private System.Windows.Forms.Label taxlbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox RecieptTb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label Date2lbl;
    }
}

