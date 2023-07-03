namespace GameBall
{
    partial class CatBox
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatBox));
            this.cbxPlayers = new System.Windows.Forms.ComboBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblRegisterPlayer = new System.Windows.Forms.Label();
            this.txtRegisterPlayer = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlContainerRegister1 = new System.Windows.Forms.Panel();
            this.pnlContainerRegister = new System.Windows.Forms.Panel();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.pnlContainerPlayer = new System.Windows.Forms.Panel();
            this.pnlContainerNav = new System.Windows.Forms.Panel();
            this.dgvClassification = new System.Windows.Forms.DataGridView();
            this.colPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPonint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpenBoxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBox1 = new System.Windows.Forms.Button();
            this.btnBox2 = new System.Windows.Forms.Button();
            this.btnBox3 = new System.Windows.Forms.Button();
            this.boxOpen1 = new System.Windows.Forms.Panel();
            this.boxOpen2 = new System.Windows.Forms.Panel();
            this.boxOpen3 = new System.Windows.Forms.Panel();
            this.boxCatOpen1 = new System.Windows.Forms.Panel();
            this.pnlContainerBoxes = new System.Windows.Forms.Panel();
            this.BoxResult5L = new System.Windows.Forms.Panel();
            this.BoxResult5R = new System.Windows.Forms.Panel();
            this.BoxResult10R = new System.Windows.Forms.Panel();
            this.BoxResult10L = new System.Windows.Forms.Panel();
            this.BoxResultGameOverL = new System.Windows.Forms.Panel();
            this.BoxResultGameOverR = new System.Windows.Forms.Panel();
            this.boxCatOpen3 = new System.Windows.Forms.Panel();
            this.boxCatOpen2 = new System.Windows.Forms.Panel();
            this.pnlContainerRegister1.SuspendLayout();
            this.pnlContainerRegister.SuspendLayout();
            this.pnlContainerPlayer.SuspendLayout();
            this.pnlContainerNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassification)).BeginInit();
            this.pnlContainerBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPlayers
            // 
            this.cbxPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.cbxPlayers.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cbxPlayers.FormattingEnabled = true;
            this.cbxPlayers.Location = new System.Drawing.Point(8, 66);
            this.cbxPlayers.Name = "cbxPlayers";
            this.cbxPlayers.Size = new System.Drawing.Size(300, 27);
            this.cbxPlayers.TabIndex = 0;
            this.cbxPlayers.SelectedIndexChanged += new System.EventHandler(this.cbxPlayers_SelectedIndexChanged);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lblPlayer.Location = new System.Drawing.Point(121, 37);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(75, 19);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player";
            // 
            // lblRegisterPlayer
            // 
            this.lblRegisterPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterPlayer.AutoSize = true;
            this.lblRegisterPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterPlayer.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegisterPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lblRegisterPlayer.Location = new System.Drawing.Point(85, 6);
            this.lblRegisterPlayer.Name = "lblRegisterPlayer";
            this.lblRegisterPlayer.Size = new System.Drawing.Size(130, 19);
            this.lblRegisterPlayer.TabIndex = 2;
            this.lblRegisterPlayer.Text = "Name Player";
            // 
            // txtRegisterPlayer
            // 
            this.txtRegisterPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.txtRegisterPlayer.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRegisterPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtRegisterPlayer.Location = new System.Drawing.Point(7, 41);
            this.txtRegisterPlayer.Name = "txtRegisterPlayer";
            this.txtRegisterPlayer.Size = new System.Drawing.Size(300, 30);
            this.txtRegisterPlayer.TabIndex = 3;
            this.txtRegisterPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(188)))), ((int)(((byte)(237)))));
            this.btnRegister.Location = new System.Drawing.Point(7, 74);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 56);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlContainerRegister1
            // 
            this.pnlContainerRegister1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainerRegister1.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainerRegister1.Controls.Add(this.lblRegisterPlayer);
            this.pnlContainerRegister1.Location = new System.Drawing.Point(7, 9);
            this.pnlContainerRegister1.Name = "pnlContainerRegister1";
            this.pnlContainerRegister1.Size = new System.Drawing.Size(300, 30);
            this.pnlContainerRegister1.TabIndex = 6;
            // 
            // pnlContainerRegister
            // 
            this.pnlContainerRegister.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainerRegister.Controls.Add(this.pnlContainerRegister1);
            this.pnlContainerRegister.Controls.Add(this.txtRegisterPlayer);
            this.pnlContainerRegister.Controls.Add(this.btnRegister);
            this.pnlContainerRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainerRegister.Location = new System.Drawing.Point(10, 10);
            this.pnlContainerRegister.Name = "pnlContainerRegister";
            this.pnlContainerRegister.Size = new System.Drawing.Size(315, 130);
            this.pnlContainerRegister.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(81)))), ((int)(((byte)(48)))));
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(81)))), ((int)(((byte)(48)))));
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 100;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.Location = new System.Drawing.Point(325, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(614, 130);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlContainerPlayer
            // 
            this.pnlContainerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainerPlayer.Controls.Add(this.lblPlayer);
            this.pnlContainerPlayer.Controls.Add(this.cbxPlayers);
            this.pnlContainerPlayer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContainerPlayer.Location = new System.Drawing.Point(939, 10);
            this.pnlContainerPlayer.Name = "pnlContainerPlayer";
            this.pnlContainerPlayer.Size = new System.Drawing.Size(315, 130);
            this.pnlContainerPlayer.TabIndex = 12;
            // 
            // pnlContainerNav
            // 
            this.pnlContainerNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainerNav.Controls.Add(this.btnPlay);
            this.pnlContainerNav.Controls.Add(this.pnlContainerRegister);
            this.pnlContainerNav.Controls.Add(this.pnlContainerPlayer);
            this.pnlContainerNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainerNav.Location = new System.Drawing.Point(0, 0);
            this.pnlContainerNav.Name = "pnlContainerNav";
            this.pnlContainerNav.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainerNav.Size = new System.Drawing.Size(1264, 150);
            this.pnlContainerNav.TabIndex = 13;
            // 
            // dgvClassification
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(188)))), ((int)(((byte)(237)))));
            this.dgvClassification.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClassification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClassification.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.dgvClassification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlayer,
            this.colPonint,
            this.colAttempts,
            this.colOpenBoxes});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(188)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassification.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClassification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClassification.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(188)))), ((int)(((byte)(237)))));
            this.dgvClassification.Location = new System.Drawing.Point(0, 431);
            this.dgvClassification.Name = "dgvClassification";
            this.dgvClassification.ReadOnly = true;
            this.dgvClassification.Size = new System.Drawing.Size(1264, 250);
            this.dgvClassification.TabIndex = 18;
            // 
            // colPlayer
            // 
            this.colPlayer.HeaderText = "Player";
            this.colPlayer.Name = "colPlayer";
            this.colPlayer.ReadOnly = true;
            // 
            // colPonint
            // 
            this.colPonint.HeaderText = "Points";
            this.colPonint.Name = "colPonint";
            this.colPonint.ReadOnly = true;
            // 
            // colAttempts
            // 
            this.colAttempts.HeaderText = "Attempts";
            this.colAttempts.Name = "colAttempts";
            this.colAttempts.ReadOnly = true;
            // 
            // colOpenBoxes
            // 
            this.colOpenBoxes.HeaderText = "Open boxes";
            this.colOpenBoxes.Name = "colOpenBoxes";
            this.colOpenBoxes.ReadOnly = true;
            // 
            // btnBox1
            // 
            this.btnBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox1.BackgroundImage")));
            this.btnBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBox1.Enabled = false;
            this.btnBox1.FlatAppearance.BorderSize = 0;
            this.btnBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox1.Location = new System.Drawing.Point(270, 40);
            this.btnBox1.Name = "btnBox1";
            this.btnBox1.Size = new System.Drawing.Size(200, 200);
            this.btnBox1.TabIndex = 25;
            this.btnBox1.UseVisualStyleBackColor = false;
            this.btnBox1.Click += new System.EventHandler(this.btnBox1_Click);
            // 
            // btnBox2
            // 
            this.btnBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox2.BackgroundImage")));
            this.btnBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBox2.Enabled = false;
            this.btnBox2.FlatAppearance.BorderSize = 0;
            this.btnBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox2.Location = new System.Drawing.Point(532, 40);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.Size = new System.Drawing.Size(200, 200);
            this.btnBox2.TabIndex = 26;
            this.btnBox2.UseVisualStyleBackColor = false;
            this.btnBox2.Click += new System.EventHandler(this.btnBox2_Click);
            // 
            // btnBox3
            // 
            this.btnBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox3.BackgroundImage")));
            this.btnBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBox3.Enabled = false;
            this.btnBox3.FlatAppearance.BorderSize = 0;
            this.btnBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox3.Location = new System.Drawing.Point(794, 40);
            this.btnBox3.Name = "btnBox3";
            this.btnBox3.Size = new System.Drawing.Size(200, 200);
            this.btnBox3.TabIndex = 27;
            this.btnBox3.UseVisualStyleBackColor = false;
            this.btnBox3.Click += new System.EventHandler(this.btnBox3_Click);
            // 
            // boxOpen1
            // 
            this.boxOpen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxOpen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxOpen1.BackgroundImage")));
            this.boxOpen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxOpen1.Location = new System.Drawing.Point(270, 40);
            this.boxOpen1.Name = "boxOpen1";
            this.boxOpen1.Padding = new System.Windows.Forms.Padding(50);
            this.boxOpen1.Size = new System.Drawing.Size(200, 200);
            this.boxOpen1.TabIndex = 24;
            this.boxOpen1.Visible = false;
            // 
            // boxOpen2
            // 
            this.boxOpen2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxOpen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxOpen2.BackgroundImage")));
            this.boxOpen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxOpen2.Location = new System.Drawing.Point(532, 40);
            this.boxOpen2.Name = "boxOpen2";
            this.boxOpen2.Padding = new System.Windows.Forms.Padding(50);
            this.boxOpen2.Size = new System.Drawing.Size(200, 200);
            this.boxOpen2.TabIndex = 25;
            this.boxOpen2.Visible = false;
            // 
            // boxOpen3
            // 
            this.boxOpen3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxOpen3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxOpen3.BackgroundImage")));
            this.boxOpen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxOpen3.Location = new System.Drawing.Point(794, 40);
            this.boxOpen3.Name = "boxOpen3";
            this.boxOpen3.Padding = new System.Windows.Forms.Padding(50);
            this.boxOpen3.Size = new System.Drawing.Size(200, 200);
            this.boxOpen3.TabIndex = 26;
            this.boxOpen3.Visible = false;
            // 
            // boxCatOpen1
            // 
            this.boxCatOpen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCatOpen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxCatOpen1.BackgroundImage")));
            this.boxCatOpen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxCatOpen1.Location = new System.Drawing.Point(270, 40);
            this.boxCatOpen1.Name = "boxCatOpen1";
            this.boxCatOpen1.Padding = new System.Windows.Forms.Padding(50);
            this.boxCatOpen1.Size = new System.Drawing.Size(200, 200);
            this.boxCatOpen1.TabIndex = 28;
            this.boxCatOpen1.Visible = false;
            // 
            // pnlContainerBoxes
            // 
            this.pnlContainerBoxes.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainerBoxes.Controls.Add(this.BoxResult5L);
            this.pnlContainerBoxes.Controls.Add(this.BoxResult5R);
            this.pnlContainerBoxes.Controls.Add(this.BoxResult10R);
            this.pnlContainerBoxes.Controls.Add(this.BoxResult10L);
            this.pnlContainerBoxes.Controls.Add(this.BoxResultGameOverL);
            this.pnlContainerBoxes.Controls.Add(this.BoxResultGameOverR);
            this.pnlContainerBoxes.Controls.Add(this.boxCatOpen3);
            this.pnlContainerBoxes.Controls.Add(this.boxCatOpen2);
            this.pnlContainerBoxes.Controls.Add(this.boxCatOpen1);
            this.pnlContainerBoxes.Controls.Add(this.boxOpen3);
            this.pnlContainerBoxes.Controls.Add(this.boxOpen2);
            this.pnlContainerBoxes.Controls.Add(this.boxOpen1);
            this.pnlContainerBoxes.Controls.Add(this.btnBox3);
            this.pnlContainerBoxes.Controls.Add(this.btnBox2);
            this.pnlContainerBoxes.Controls.Add(this.btnBox1);
            this.pnlContainerBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerBoxes.Location = new System.Drawing.Point(0, 150);
            this.pnlContainerBoxes.Name = "pnlContainerBoxes";
            this.pnlContainerBoxes.Size = new System.Drawing.Size(1264, 281);
            this.pnlContainerBoxes.TabIndex = 17;
            // 
            // BoxResult5L
            // 
            this.BoxResult5L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResult5L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResult5L.BackgroundImage")));
            this.BoxResult5L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResult5L.Location = new System.Drawing.Point(10, 40);
            this.BoxResult5L.Name = "BoxResult5L";
            this.BoxResult5L.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResult5L.Size = new System.Drawing.Size(200, 200);
            this.BoxResult5L.TabIndex = 36;
            this.BoxResult5L.Visible = false;
            // 
            // BoxResult5R
            // 
            this.BoxResult5R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResult5R.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResult5R.BackgroundImage")));
            this.BoxResult5R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResult5R.Location = new System.Drawing.Point(1056, 40);
            this.BoxResult5R.Name = "BoxResult5R";
            this.BoxResult5R.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResult5R.Size = new System.Drawing.Size(200, 200);
            this.BoxResult5R.TabIndex = 35;
            this.BoxResult5R.Visible = false;
            // 
            // BoxResult10R
            // 
            this.BoxResult10R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResult10R.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResult10R.BackgroundImage")));
            this.BoxResult10R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResult10R.Location = new System.Drawing.Point(1056, 40);
            this.BoxResult10R.Name = "BoxResult10R";
            this.BoxResult10R.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResult10R.Size = new System.Drawing.Size(200, 200);
            this.BoxResult10R.TabIndex = 34;
            this.BoxResult10R.Visible = false;
            // 
            // BoxResult10L
            // 
            this.BoxResult10L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResult10L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResult10L.BackgroundImage")));
            this.BoxResult10L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResult10L.Location = new System.Drawing.Point(10, 40);
            this.BoxResult10L.Name = "BoxResult10L";
            this.BoxResult10L.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResult10L.Size = new System.Drawing.Size(200, 200);
            this.BoxResult10L.TabIndex = 33;
            this.BoxResult10L.Visible = false;
            // 
            // BoxResultGameOverL
            // 
            this.BoxResultGameOverL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResultGameOverL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResultGameOverL.BackgroundImage")));
            this.BoxResultGameOverL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResultGameOverL.Location = new System.Drawing.Point(10, 40);
            this.BoxResultGameOverL.Name = "BoxResultGameOverL";
            this.BoxResultGameOverL.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResultGameOverL.Size = new System.Drawing.Size(200, 200);
            this.BoxResultGameOverL.TabIndex = 32;
            this.BoxResultGameOverL.Visible = false;
            // 
            // BoxResultGameOverR
            // 
            this.BoxResultGameOverR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxResultGameOverR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxResultGameOverR.BackgroundImage")));
            this.BoxResultGameOverR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxResultGameOverR.Location = new System.Drawing.Point(1056, 40);
            this.BoxResultGameOverR.Name = "BoxResultGameOverR";
            this.BoxResultGameOverR.Padding = new System.Windows.Forms.Padding(50);
            this.BoxResultGameOverR.Size = new System.Drawing.Size(200, 200);
            this.BoxResultGameOverR.TabIndex = 31;
            this.BoxResultGameOverR.Visible = false;
            // 
            // boxCatOpen3
            // 
            this.boxCatOpen3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCatOpen3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxCatOpen3.BackgroundImage")));
            this.boxCatOpen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxCatOpen3.Location = new System.Drawing.Point(794, 40);
            this.boxCatOpen3.Name = "boxCatOpen3";
            this.boxCatOpen3.Padding = new System.Windows.Forms.Padding(50);
            this.boxCatOpen3.Size = new System.Drawing.Size(200, 200);
            this.boxCatOpen3.TabIndex = 30;
            this.boxCatOpen3.Visible = false;
            // 
            // boxCatOpen2
            // 
            this.boxCatOpen2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCatOpen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxCatOpen2.BackgroundImage")));
            this.boxCatOpen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxCatOpen2.Location = new System.Drawing.Point(532, 40);
            this.boxCatOpen2.Name = "boxCatOpen2";
            this.boxCatOpen2.Padding = new System.Windows.Forms.Padding(50);
            this.boxCatOpen2.Size = new System.Drawing.Size(200, 200);
            this.boxCatOpen2.TabIndex = 29;
            this.boxCatOpen2.Visible = false;
            // 
            // CatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContainerBoxes);
            this.Controls.Add(this.dgvClassification);
            this.Controls.Add(this.pnlContainerNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatBox";
            this.Text = "CatBox Game";
            this.pnlContainerRegister1.ResumeLayout(false);
            this.pnlContainerRegister1.PerformLayout();
            this.pnlContainerRegister.ResumeLayout(false);
            this.pnlContainerRegister.PerformLayout();
            this.pnlContainerPlayer.ResumeLayout(false);
            this.pnlContainerPlayer.PerformLayout();
            this.pnlContainerNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassification)).EndInit();
            this.pnlContainerBoxes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlayers;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblRegisterPlayer;
        private System.Windows.Forms.TextBox txtRegisterPlayer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlContainerRegister1;
        private System.Windows.Forms.Panel pnlContainerRegister;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Panel pnlContainerPlayer;
        private System.Windows.Forms.Panel pnlContainerNav;
        private System.Windows.Forms.DataGridView dgvClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPonint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpenBoxes;
        private System.Windows.Forms.Button btnBox1;
        private System.Windows.Forms.Button btnBox2;
        private System.Windows.Forms.Button btnBox3;
        private System.Windows.Forms.Panel boxOpen1;
        private System.Windows.Forms.Panel boxOpen2;
        private System.Windows.Forms.Panel boxCatOpen2;
        private System.Windows.Forms.Panel boxOpen3;
        private System.Windows.Forms.Panel boxCatOpen1;
        private System.Windows.Forms.Panel pnlContainerBoxes;
        private System.Windows.Forms.Panel boxCatOpen3;
        private System.Windows.Forms.Panel BoxResultGameOverR;
        private System.Windows.Forms.Panel BoxResultGameOverL;
        private System.Windows.Forms.Panel BoxResult10R;
        private System.Windows.Forms.Panel BoxResult10L;
        private System.Windows.Forms.Panel BoxResult5R;
        private System.Windows.Forms.Panel BoxResult5L;
    }
}

