﻿namespace NetConfClientSoftware
{
    partial class FormOAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comDminterval = new System.Windows.Forms.ComboBox();
            this.comLminterval = new System.Windows.Forms.ComboBox();
            this.comCcinterval = new System.Windows.Forms.ComboBox();
            this.comMel = new System.Windows.Forms.ComboBox();
            this.comMdname = new System.Windows.Forms.ComboBox();
            this.comMegid = new System.Windows.Forms.ComboBox();
            this.comRemoteMepid = new System.Windows.Forms.ComboBox();
            this.comMepid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comdelay = new System.Windows.Forms.ComboBox();
            this.comnearloss = new System.Windows.Forms.ComboBox();
            this.comfarloss = new System.Windows.Forms.ComboBox();
            this.comRxbyte = new System.Windows.Forms.ComboBox();
            this.comtxbtye = new System.Windows.Forms.ComboBox();
            this.comCcstate = new System.Windows.Forms.ComboBox();
            this.comLmstate = new System.Windows.Forms.ComboBox();
            this.comTmstate = new System.Windows.Forms.ComboBox();
            this.comDmstate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comVlan = new System.Windows.Forms.ComboBox();
            this.comVlantype = new System.Windows.Forms.ComboBox();
            this.ButSetconfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.ButSetconfig);
            this.groupBox1.Controls.Add(this.ComName);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OAM配置与状态";
            // 
            // ComName
            // 
            this.ComName.FormattingEnabled = true;
            this.ComName.Location = new System.Drawing.Point(78, 25);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(503, 20);
            this.ComName.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.Controls.Add(this.comVlantype, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comDminterval, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.comLminterval, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.comCcinterval, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comMel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comMdname, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comMegid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comRemoteMepid, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comMepid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comVlan, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comDminterval
            // 
            this.comDminterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comDminterval.FormattingEnabled = true;
            this.comDminterval.Items.AddRange(new object[] {
            "interval-3ms33",
            "interval-1s",
            "interval-10s"});
            this.comDminterval.Location = new System.Drawing.Point(124, 237);
            this.comDminterval.Name = "comDminterval";
            this.comDminterval.Size = new System.Drawing.Size(148, 20);
            this.comDminterval.TabIndex = 16;
            // 
            // comLminterval
            // 
            this.comLminterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comLminterval.FormattingEnabled = true;
            this.comLminterval.Items.AddRange(new object[] {
            "interval-3ms33",
            "interval-1s",
            "interval-10s"});
            this.comLminterval.Location = new System.Drawing.Point(124, 211);
            this.comLminterval.Name = "comLminterval";
            this.comLminterval.Size = new System.Drawing.Size(148, 20);
            this.comLminterval.TabIndex = 15;
            // 
            // comCcinterval
            // 
            this.comCcinterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comCcinterval.FormattingEnabled = true;
            this.comCcinterval.Items.AddRange(new object[] {
            "interval-3ms33",
            "interval-1s",
            "interval-10s"});
            this.comCcinterval.Location = new System.Drawing.Point(124, 185);
            this.comCcinterval.Name = "comCcinterval";
            this.comCcinterval.Size = new System.Drawing.Size(148, 20);
            this.comCcinterval.TabIndex = 14;
            // 
            // comMel
            // 
            this.comMel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comMel.FormattingEnabled = true;
            this.comMel.Location = new System.Drawing.Point(124, 159);
            this.comMel.Name = "comMel";
            this.comMel.Size = new System.Drawing.Size(148, 20);
            this.comMel.TabIndex = 13;
            // 
            // comMdname
            // 
            this.comMdname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comMdname.FormattingEnabled = true;
            this.comMdname.Location = new System.Drawing.Point(124, 133);
            this.comMdname.Name = "comMdname";
            this.comMdname.Size = new System.Drawing.Size(148, 20);
            this.comMdname.TabIndex = 12;
            // 
            // comMegid
            // 
            this.comMegid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comMegid.FormattingEnabled = true;
            this.comMegid.Location = new System.Drawing.Point(124, 107);
            this.comMegid.Name = "comMegid";
            this.comMegid.Size = new System.Drawing.Size(148, 20);
            this.comMegid.TabIndex = 11;
            // 
            // comRemoteMepid
            // 
            this.comRemoteMepid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comRemoteMepid.FormattingEnabled = true;
            this.comRemoteMepid.Location = new System.Drawing.Point(124, 81);
            this.comRemoteMepid.Name = "comRemoteMepid";
            this.comRemoteMepid.Size = new System.Drawing.Size(148, 20);
            this.comRemoteMepid.TabIndex = 10;
            // 
            // comMepid
            // 
            this.comMepid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comMepid.FormattingEnabled = true;
            this.comMepid.Location = new System.Drawing.Point(124, 55);
            this.comMepid.Name = "comMepid";
            this.comMepid.Size = new System.Drawing.Size(148, 20);
            this.comMepid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "mep-id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "remote-mep-id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "meg-id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "md-name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "mel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "cc-interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "lm-interval";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "dm-interval";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel2.Controls.Add(this.comdelay, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.comnearloss, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.comfarloss, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.comRxbyte, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.comtxbtye, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.comCcstate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.comLmstate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comTmstate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comDmstate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 237);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comdelay
            // 
            this.comdelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comdelay.FormattingEnabled = true;
            this.comdelay.Location = new System.Drawing.Point(125, 211);
            this.comdelay.Name = "comdelay";
            this.comdelay.Size = new System.Drawing.Size(150, 20);
            this.comdelay.TabIndex = 22;
            // 
            // comnearloss
            // 
            this.comnearloss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comnearloss.FormattingEnabled = true;
            this.comnearloss.Location = new System.Drawing.Point(125, 185);
            this.comnearloss.Name = "comnearloss";
            this.comnearloss.Size = new System.Drawing.Size(150, 20);
            this.comnearloss.TabIndex = 21;
            // 
            // comfarloss
            // 
            this.comfarloss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comfarloss.FormattingEnabled = true;
            this.comfarloss.Location = new System.Drawing.Point(125, 159);
            this.comfarloss.Name = "comfarloss";
            this.comfarloss.Size = new System.Drawing.Size(150, 20);
            this.comfarloss.TabIndex = 20;
            // 
            // comRxbyte
            // 
            this.comRxbyte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comRxbyte.FormattingEnabled = true;
            this.comRxbyte.Location = new System.Drawing.Point(125, 133);
            this.comRxbyte.Name = "comRxbyte";
            this.comRxbyte.Size = new System.Drawing.Size(150, 20);
            this.comRxbyte.TabIndex = 19;
            // 
            // comtxbtye
            // 
            this.comtxbtye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comtxbtye.FormattingEnabled = true;
            this.comtxbtye.Location = new System.Drawing.Point(125, 107);
            this.comtxbtye.Name = "comtxbtye";
            this.comtxbtye.Size = new System.Drawing.Size(150, 20);
            this.comtxbtye.TabIndex = 18;
            // 
            // comCcstate
            // 
            this.comCcstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comCcstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCcstate.FormattingEnabled = true;
            this.comCcstate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comCcstate.Location = new System.Drawing.Point(125, 81);
            this.comCcstate.Name = "comCcstate";
            this.comCcstate.Size = new System.Drawing.Size(150, 20);
            this.comCcstate.TabIndex = 12;
            // 
            // comLmstate
            // 
            this.comLmstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comLmstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLmstate.FormattingEnabled = true;
            this.comLmstate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comLmstate.Location = new System.Drawing.Point(125, 55);
            this.comLmstate.Name = "comLmstate";
            this.comLmstate.Size = new System.Drawing.Size(150, 20);
            this.comLmstate.TabIndex = 11;
            // 
            // comTmstate
            // 
            this.comTmstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comTmstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTmstate.FormattingEnabled = true;
            this.comTmstate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comTmstate.Location = new System.Drawing.Point(125, 29);
            this.comTmstate.Name = "comTmstate";
            this.comTmstate.Size = new System.Drawing.Size(150, 20);
            this.comTmstate.TabIndex = 10;
            // 
            // comDmstate
            // 
            this.comDmstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comDmstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDmstate.FormattingEnabled = true;
            this.comDmstate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comDmstate.Location = new System.Drawing.Point(125, 3);
            this.comDmstate.Name = "comDmstate";
            this.comDmstate.Size = new System.Drawing.Size(150, 20);
            this.comDmstate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "dm-state";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "tm-state";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "lm-state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "cc-state";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 26);
            this.label13.TabIndex = 13;
            this.label13.Text = "发送字节";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 26);
            this.label14.TabIndex = 14;
            this.label14.Text = "接收字节";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 26);
            this.label15.TabIndex = 15;
            this.label15.Text = "远端丢包率";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 26);
            this.label16.TabIndex = 16;
            this.label16.Text = "近端丢包率";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 29);
            this.label17.TabIndex = 17;
            this.label17.Text = "时延";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "vlan";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 18;
            this.label19.Text = "vlan-type";
            // 
            // comVlan
            // 
            this.comVlan.FormattingEnabled = true;
            this.comVlan.Location = new System.Drawing.Point(124, 3);
            this.comVlan.Name = "comVlan";
            this.comVlan.Size = new System.Drawing.Size(148, 20);
            this.comVlan.TabIndex = 19;
            // 
            // comVlantype
            // 
            this.comVlantype.FormattingEnabled = true;
            this.comVlantype.Location = new System.Drawing.Point(124, 29);
            this.comVlantype.Name = "comVlantype";
            this.comVlantype.Size = new System.Drawing.Size(148, 20);
            this.comVlantype.TabIndex = 20;
            // 
            // ButSetconfig
            // 
            this.ButSetconfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButSetconfig.Location = new System.Drawing.Point(419, 300);
            this.ButSetconfig.Name = "ButSetconfig";
            this.ButSetconfig.Size = new System.Drawing.Size(75, 23);
            this.ButSetconfig.TabIndex = 5;
            this.ButSetconfig.Text = "配置";
            this.ButSetconfig.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(506, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 7;
            this.label20.Text = "CTP接口";
            // 
            // FormOAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 358);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comDminterval;
        private System.Windows.Forms.ComboBox comLminterval;
        private System.Windows.Forms.ComboBox comCcinterval;
        private System.Windows.Forms.ComboBox comMel;
        private System.Windows.Forms.ComboBox comMdname;
        private System.Windows.Forms.ComboBox comMegid;
        private System.Windows.Forms.ComboBox comRemoteMepid;
        private System.Windows.Forms.ComboBox comMepid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comdelay;
        private System.Windows.Forms.ComboBox comnearloss;
        private System.Windows.Forms.ComboBox comfarloss;
        private System.Windows.Forms.ComboBox comRxbyte;
        private System.Windows.Forms.ComboBox comtxbtye;
        private System.Windows.Forms.ComboBox comCcstate;
        private System.Windows.Forms.ComboBox comLmstate;
        private System.Windows.Forms.ComboBox comTmstate;
        private System.Windows.Forms.ComboBox comDmstate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comVlantype;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comVlan;
        private System.Windows.Forms.Button ButSetconfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
    }
}