namespace FNaF_World_Cheat
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "1 - Freddy",
            "2 - Bonnie",
            "3 - Chica",
            "4 - Foxy",
            "5 - Toy Bonnie",
            "6 - Toy Chica",
            "7 - Toy Freddy",
            "8 - Mangle",
            "9 - BB",
            "10 - JJ",
            "11 - Phantom Freddy",
            "12 - Phantom Chica",
            "13 - Phantom BB",
            "14 - Phantom Foxy",
            "15 - Phantom Mangle",
            "16 - Withered Bonnie",
            "17 - Withered Chica",
            "18 - Withered Freddy",
            "19 - Withered Foxy",
            "20 - Shadow Freddy",
            "21 - Puppet",
            "22 - Phantom Puppet",
            "23 - Golden Freddy",
            "24 - Paperpals",
            "25 - Nightmare Freddy",
            "26 - Nightmare Bonnie",
            "27 - Nightmare Chica",
            "28 - Nightmare Foxy",
            "29 - Endo 01",
            "30 - Endo 02",
            "31 - Plushtrap",
            "32 - Endoplush",
            "33 - Springtrap",
            "34 - Shadow Bonnie",
            "35 - Crying Child",
            "36 - Funtime Foxy",
            "37 - Nightmare Fredbear",
            "38 - Nightmare",
            "39 - Fredbear",
            "40 - Spring Bonnie",
            "41 - Jack-O-Bonnie",
            "42 - Jack-O-Chica",
            "43 - Animdude",
            "44 - Chipper",
            "45 - Nightmare BB",
            "46 - Nightmarionne",
            "47 - Coffee",
            "48 - Purple Guy"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 270);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Character list";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}