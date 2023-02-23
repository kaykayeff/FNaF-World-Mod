namespace FNaF_World_Mod_Menu_V4
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
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sidelist = new System.Windows.Forms.Panel();
            this.charListButton = new System.Windows.Forms.Button();
            this.miscButton = new System.Windows.Forms.Button();
            this.modsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Panel();
            this.slotConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slotBox = new System.Windows.Forms.TextBox();
            this.homeTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maxlvl = new System.Windows.Forms.Button();
            this.getchips = new System.Windows.Forms.Button();
            this.getbytes = new System.Windows.Forms.Button();
            this.inftokens = new System.Windows.Forms.Button();
            this.allzones = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Button();
            this.getarmor = new System.Windows.Forms.Button();
            this.beatthegame = new System.Windows.Forms.Button();
            this.modsPage = new System.Windows.Forms.Panel();
            this.miscPage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.dataConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.charByNumberBox = new System.Windows.Forms.TextBox();
            this.charConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.topbar.SuspendLayout();
            this.sidelist.SuspendLayout();
            this.homePage.SuspendLayout();
            this.modsPage.SuspendLayout();
            this.miscPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topbar.Controls.Add(this.minimizeButton);
            this.topbar.Controls.Add(this.closeButton);
            this.topbar.Controls.Add(this.titleLabel);
            this.topbar.Location = new System.Drawing.Point(-10, -7);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(821, 53);
            this.topbar.TabIndex = 0;
            this.topbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(719, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(51, 60);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(767, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 63);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(22, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(246, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FNaF World Mod Menu V4";
            // 
            // sidelist
            // 
            this.sidelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sidelist.Controls.Add(this.charListButton);
            this.sidelist.Controls.Add(this.miscButton);
            this.sidelist.Controls.Add(this.modsButton);
            this.sidelist.Controls.Add(this.homeButton);
            this.sidelist.Location = new System.Drawing.Point(-10, 40);
            this.sidelist.Name = "sidelist";
            this.sidelist.Size = new System.Drawing.Size(130, 424);
            this.sidelist.TabIndex = 1;
            // 
            // charListButton
            // 
            this.charListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.charListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.charListButton.FlatAppearance.BorderSize = 0;
            this.charListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.charListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.charListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charListButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charListButton.ForeColor = System.Drawing.Color.White;
            this.charListButton.Location = new System.Drawing.Point(15, 138);
            this.charListButton.Name = "charListButton";
            this.charListButton.Size = new System.Drawing.Size(108, 36);
            this.charListButton.TabIndex = 9;
            this.charListButton.Text = "Character List";
            this.charListButton.UseVisualStyleBackColor = false;
            this.charListButton.Click += new System.EventHandler(this.charListButton_Click_1);
            // 
            // miscButton
            // 
            this.miscButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.miscButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miscButton.FlatAppearance.BorderSize = 0;
            this.miscButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.miscButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.miscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miscButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miscButton.ForeColor = System.Drawing.Color.White;
            this.miscButton.Location = new System.Drawing.Point(15, 96);
            this.miscButton.Name = "miscButton";
            this.miscButton.Size = new System.Drawing.Size(108, 36);
            this.miscButton.TabIndex = 8;
            this.miscButton.Text = "Misc";
            this.miscButton.UseVisualStyleBackColor = false;
            this.miscButton.Click += new System.EventHandler(this.miscButton_Click);
            // 
            // modsButton
            // 
            this.modsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.modsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modsButton.FlatAppearance.BorderSize = 0;
            this.modsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.modsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.modsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modsButton.ForeColor = System.Drawing.Color.White;
            this.modsButton.Location = new System.Drawing.Point(15, 54);
            this.modsButton.Name = "modsButton";
            this.modsButton.Size = new System.Drawing.Size(108, 36);
            this.modsButton.TabIndex = 7;
            this.modsButton.Text = "Mods";
            this.modsButton.UseVisualStyleBackColor = false;
            this.modsButton.Click += new System.EventHandler(this.modsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(15, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(108, 36);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.homePage.Controls.Add(this.slotConfirmButton);
            this.homePage.Controls.Add(this.label1);
            this.homePage.Controls.Add(this.slotBox);
            this.homePage.Controls.Add(this.homeTitle);
            this.homePage.Location = new System.Drawing.Point(126, 52);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(668, 393);
            this.homePage.TabIndex = 2;
            this.homePage.Visible = false;
            // 
            // slotConfirmButton
            // 
            this.slotConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slotConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.slotConfirmButton.FlatAppearance.BorderSize = 0;
            this.slotConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.slotConfirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.slotConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slotConfirmButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slotConfirmButton.ForeColor = System.Drawing.Color.White;
            this.slotConfirmButton.Location = new System.Drawing.Point(203, 126);
            this.slotConfirmButton.Name = "slotConfirmButton";
            this.slotConfirmButton.Size = new System.Drawing.Size(247, 36);
            this.slotConfirmButton.TabIndex = 10;
            this.slotConfirmButton.Text = "Confirm";
            this.slotConfirmButton.UseVisualStyleBackColor = false;
            this.slotConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter slot number";
            // 
            // slotBox
            // 
            this.slotBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slotBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slotBox.ForeColor = System.Drawing.Color.White;
            this.slotBox.Location = new System.Drawing.Point(203, 84);
            this.slotBox.Name = "slotBox";
            this.slotBox.Size = new System.Drawing.Size(247, 25);
            this.slotBox.TabIndex = 1;
            this.slotBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slotBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // homeTitle
            // 
            this.homeTitle.AutoSize = true;
            this.homeTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTitle.ForeColor = System.Drawing.Color.White;
            this.homeTitle.Location = new System.Drawing.Point(298, 7);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(62, 25);
            this.homeTitle.TabIndex = 0;
            this.homeTitle.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mods";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get all characters";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // maxlvl
            // 
            this.maxlvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maxlvl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxlvl.FlatAppearance.BorderSize = 0;
            this.maxlvl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.maxlvl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.maxlvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxlvl.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxlvl.ForeColor = System.Drawing.Color.White;
            this.maxlvl.Location = new System.Drawing.Point(236, 48);
            this.maxlvl.Name = "maxlvl";
            this.maxlvl.Size = new System.Drawing.Size(172, 29);
            this.maxlvl.TabIndex = 11;
            this.maxlvl.Text = "Get max level on characters";
            this.maxlvl.UseVisualStyleBackColor = false;
            this.maxlvl.Click += new System.EventHandler(this.maxlvl_Click);
            // 
            // getchips
            // 
            this.getchips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.getchips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getchips.FlatAppearance.BorderSize = 0;
            this.getchips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.getchips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.getchips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getchips.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getchips.ForeColor = System.Drawing.Color.White;
            this.getchips.Location = new System.Drawing.Point(430, 48);
            this.getchips.Name = "getchips";
            this.getchips.Size = new System.Drawing.Size(172, 29);
            this.getchips.TabIndex = 12;
            this.getchips.Text = "Get all chips";
            this.getchips.UseVisualStyleBackColor = false;
            this.getchips.Click += new System.EventHandler(this.getchips_Click);
            // 
            // getbytes
            // 
            this.getbytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.getbytes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getbytes.FlatAppearance.BorderSize = 0;
            this.getbytes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.getbytes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.getbytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getbytes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getbytes.ForeColor = System.Drawing.Color.White;
            this.getbytes.Location = new System.Drawing.Point(39, 90);
            this.getbytes.Name = "getbytes";
            this.getbytes.Size = new System.Drawing.Size(172, 29);
            this.getbytes.TabIndex = 13;
            this.getbytes.Text = "Get all bytes";
            this.getbytes.UseVisualStyleBackColor = false;
            this.getbytes.Click += new System.EventHandler(this.getbytes_Click);
            // 
            // inftokens
            // 
            this.inftokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inftokens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inftokens.FlatAppearance.BorderSize = 0;
            this.inftokens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.inftokens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.inftokens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inftokens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inftokens.ForeColor = System.Drawing.Color.White;
            this.inftokens.Location = new System.Drawing.Point(236, 90);
            this.inftokens.Name = "inftokens";
            this.inftokens.Size = new System.Drawing.Size(172, 29);
            this.inftokens.TabIndex = 14;
            this.inftokens.Text = "Get infinite tokens";
            this.inftokens.UseVisualStyleBackColor = false;
            this.inftokens.Click += new System.EventHandler(this.inftokens_Click);
            // 
            // allzones
            // 
            this.allzones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.allzones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allzones.FlatAppearance.BorderSize = 0;
            this.allzones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.allzones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.allzones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allzones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allzones.ForeColor = System.Drawing.Color.White;
            this.allzones.Location = new System.Drawing.Point(430, 90);
            this.allzones.Name = "allzones";
            this.allzones.Size = new System.Drawing.Size(172, 29);
            this.allzones.TabIndex = 15;
            this.allzones.Text = "Unlock all zones";
            this.allzones.UseVisualStyleBackColor = false;
            this.allzones.Click += new System.EventHandler(this.allzones_Click);
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.key.FlatAppearance.BorderSize = 0;
            this.key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key.ForeColor = System.Drawing.Color.White;
            this.key.Location = new System.Drawing.Point(39, 133);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(172, 29);
            this.key.TabIndex = 16;
            this.key.Text = "Get key";
            this.key.UseVisualStyleBackColor = false;
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // getarmor
            // 
            this.getarmor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.getarmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getarmor.FlatAppearance.BorderSize = 0;
            this.getarmor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.getarmor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.getarmor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getarmor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getarmor.ForeColor = System.Drawing.Color.White;
            this.getarmor.Location = new System.Drawing.Point(236, 133);
            this.getarmor.Name = "getarmor";
            this.getarmor.Size = new System.Drawing.Size(172, 29);
            this.getarmor.TabIndex = 17;
            this.getarmor.Text = "Get armor";
            this.getarmor.UseVisualStyleBackColor = false;
            this.getarmor.Click += new System.EventHandler(this.getarmor_Click);
            // 
            // beatthegame
            // 
            this.beatthegame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.beatthegame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beatthegame.FlatAppearance.BorderSize = 0;
            this.beatthegame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.beatthegame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.beatthegame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beatthegame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beatthegame.ForeColor = System.Drawing.Color.White;
            this.beatthegame.Location = new System.Drawing.Point(430, 133);
            this.beatthegame.Name = "beatthegame";
            this.beatthegame.Size = new System.Drawing.Size(172, 29);
            this.beatthegame.TabIndex = 18;
            this.beatthegame.Text = "Beat the game..?";
            this.beatthegame.UseVisualStyleBackColor = false;
            this.beatthegame.Click += new System.EventHandler(this.beatthegame_Click);
            // 
            // modsPage
            // 
            this.modsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.modsPage.Controls.Add(this.beatthegame);
            this.modsPage.Controls.Add(this.getarmor);
            this.modsPage.Controls.Add(this.key);
            this.modsPage.Controls.Add(this.allzones);
            this.modsPage.Controls.Add(this.inftokens);
            this.modsPage.Controls.Add(this.getbytes);
            this.modsPage.Controls.Add(this.getchips);
            this.modsPage.Controls.Add(this.maxlvl);
            this.modsPage.Controls.Add(this.button1);
            this.modsPage.Controls.Add(this.label3);
            this.modsPage.Location = new System.Drawing.Point(126, 52);
            this.modsPage.Name = "modsPage";
            this.modsPage.Size = new System.Drawing.Size(668, 393);
            this.modsPage.TabIndex = 11;
            this.modsPage.Visible = false;
            // 
            // miscPage
            // 
            this.miscPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.miscPage.Controls.Add(this.label5);
            this.miscPage.Controls.Add(this.dataBox);
            this.miscPage.Controls.Add(this.dataConfirm);
            this.miscPage.Controls.Add(this.label4);
            this.miscPage.Controls.Add(this.charByNumberBox);
            this.miscPage.Controls.Add(this.charConfirm);
            this.miscPage.Controls.Add(this.label2);
            this.miscPage.Location = new System.Drawing.Point(126, 52);
            this.miscPage.Name = "miscPage";
            this.miscPage.Size = new System.Drawing.Size(668, 393);
            this.miscPage.TabIndex = 19;
            this.miscPage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(414, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inject data into slot";
            // 
            // dataBox
            // 
            this.dataBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataBox.ForeColor = System.Drawing.Color.White;
            this.dataBox.Location = new System.Drawing.Point(375, 77);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(247, 25);
            this.dataBox.TabIndex = 21;
            this.dataBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataConfirm
            // 
            this.dataConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataConfirm.FlatAppearance.BorderSize = 0;
            this.dataConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataConfirm.ForeColor = System.Drawing.Color.White;
            this.dataConfirm.Location = new System.Drawing.Point(414, 115);
            this.dataConfirm.Name = "dataConfirm";
            this.dataConfirm.Size = new System.Drawing.Size(172, 29);
            this.dataConfirm.TabIndex = 20;
            this.dataConfirm.Text = "Confirm";
            this.dataConfirm.UseVisualStyleBackColor = false;
            this.dataConfirm.Click += new System.EventHandler(this.dataConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Get character by number";
            // 
            // charByNumberBox
            // 
            this.charByNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.charByNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charByNumberBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charByNumberBox.ForeColor = System.Drawing.Color.White;
            this.charByNumberBox.Location = new System.Drawing.Point(39, 77);
            this.charByNumberBox.Name = "charByNumberBox";
            this.charByNumberBox.Size = new System.Drawing.Size(247, 25);
            this.charByNumberBox.TabIndex = 18;
            this.charByNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charConfirm
            // 
            this.charConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.charConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.charConfirm.FlatAppearance.BorderSize = 0;
            this.charConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.charConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.charConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charConfirm.ForeColor = System.Drawing.Color.White;
            this.charConfirm.Location = new System.Drawing.Point(78, 115);
            this.charConfirm.Name = "charConfirm";
            this.charConfirm.Size = new System.Drawing.Size(172, 29);
            this.charConfirm.TabIndex = 17;
            this.charConfirm.Text = "Confirm";
            this.charConfirm.UseVisualStyleBackColor = false;
            this.charConfirm.Click += new System.EventHandler(this.charConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miscellaneous";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidelist);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.miscPage);
            this.Controls.Add(this.modsPage);
            this.Controls.Add(this.homePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.sidelist.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            this.modsPage.ResumeLayout(false);
            this.modsPage.PerformLayout();
            this.miscPage.ResumeLayout(false);
            this.miscPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topbar;
        private Label titleLabel;
        private Panel sidelist;
        private Button closeButton;
        private Button minimizeButton;
        private Button homeButton;
        private Button modsButton;
        private Button charListButton;
        private Button miscButton;
        private Panel homePage;
        private Label homeTitle;
        private Label label1;
        private TextBox slotBox;
        private Button slotConfirmButton;
        private Label label3;
        private Button button1;
        private Button maxlvl;
        private Button getchips;
        private Button getbytes;
        private Button inftokens;
        private Button allzones;
        private Button key;
        private Button getarmor;
        private Button beatthegame;
        private Panel modsPage;
        private Panel miscPage;
        private Label label5;
        private TextBox dataBox;
        private Button dataConfirm;
        private Label label4;
        private TextBox charByNumberBox;
        private Button charConfirm;
        private Label label2;
    }
}