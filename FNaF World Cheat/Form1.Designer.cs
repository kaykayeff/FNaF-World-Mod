namespace FNaF_World_Cheat
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
            this.getCharactersBTN = new System.Windows.Forms.Button();
            this.slotBox = new System.Windows.Forms.TextBox();
            this.slotlabel = new System.Windows.Forms.Label();
            this.saveSlotBTN = new System.Windows.Forms.Button();
            this.getChipsBTN = new System.Windows.Forms.Button();
            this.getByte = new System.Windows.Forms.Button();
            this.maxLevelBTN = new System.Windows.Forms.Button();
            this.tokensBTN = new System.Windows.Forms.Button();
            this.zonesBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getCharactersBTN
            // 
            this.getCharactersBTN.Location = new System.Drawing.Point(3, 164);
            this.getCharactersBTN.Name = "getCharactersBTN";
            this.getCharactersBTN.Size = new System.Drawing.Size(226, 57);
            this.getCharactersBTN.TabIndex = 0;
            this.getCharactersBTN.Text = "Get all characters";
            this.getCharactersBTN.UseVisualStyleBackColor = true;
            this.getCharactersBTN.Click += new System.EventHandler(this.getCharactersBTN_Click);
            // 
            // slotBox
            // 
            this.slotBox.Location = new System.Drawing.Point(235, 37);
            this.slotBox.Name = "slotBox";
            this.slotBox.Size = new System.Drawing.Size(226, 22);
            this.slotBox.TabIndex = 1;
            // 
            // slotlabel
            // 
            this.slotlabel.Location = new System.Drawing.Point(307, 7);
            this.slotlabel.Name = "slotlabel";
            this.slotlabel.Size = new System.Drawing.Size(81, 27);
            this.slotlabel.TabIndex = 2;
            this.slotlabel.Text = "Slot Number";
            // 
            // saveSlotBTN
            // 
            this.saveSlotBTN.Location = new System.Drawing.Point(235, 65);
            this.saveSlotBTN.Name = "saveSlotBTN";
            this.saveSlotBTN.Size = new System.Drawing.Size(226, 57);
            this.saveSlotBTN.TabIndex = 3;
            this.saveSlotBTN.Text = "Load slot";
            this.saveSlotBTN.UseVisualStyleBackColor = true;
            this.saveSlotBTN.Click += new System.EventHandler(this.saveSlotBTN_Click);
            // 
            // getChipsBTN
            // 
            this.getChipsBTN.Location = new System.Drawing.Point(235, 164);
            this.getChipsBTN.Name = "getChipsBTN";
            this.getChipsBTN.Size = new System.Drawing.Size(226, 57);
            this.getChipsBTN.TabIndex = 4;
            this.getChipsBTN.Text = "Get all chips";
            this.getChipsBTN.UseVisualStyleBackColor = true;
            this.getChipsBTN.Click += new System.EventHandler(this.getChipsBTN_Click);
            // 
            // getByte
            // 
            this.getByte.Location = new System.Drawing.Point(464, 164);
            this.getByte.Name = "getByte";
            this.getByte.Size = new System.Drawing.Size(226, 57);
            this.getByte.TabIndex = 5;
            this.getByte.Text = "Get all bytes";
            this.getByte.UseVisualStyleBackColor = true;
            this.getByte.Click += new System.EventHandler(this.getByte_Click);
            // 
            // maxLevelBTN
            // 
            this.maxLevelBTN.Location = new System.Drawing.Point(235, 227);
            this.maxLevelBTN.Name = "maxLevelBTN";
            this.maxLevelBTN.Size = new System.Drawing.Size(226, 57);
            this.maxLevelBTN.TabIndex = 6;
            this.maxLevelBTN.Text = "Get max level on all characters";
            this.maxLevelBTN.UseVisualStyleBackColor = true;
            this.maxLevelBTN.Click += new System.EventHandler(this.maxLevelBTN_Click);
            // 
            // tokensBTN
            // 
            this.tokensBTN.Location = new System.Drawing.Point(3, 227);
            this.tokensBTN.Name = "tokensBTN";
            this.tokensBTN.Size = new System.Drawing.Size(226, 57);
            this.tokensBTN.TabIndex = 7;
            this.tokensBTN.Text = "Get 999999999 tokens";
            this.tokensBTN.UseVisualStyleBackColor = true;
            this.tokensBTN.Click += new System.EventHandler(this.tokensBTN_Click);
            // 
            // zonesBTN
            // 
            this.zonesBTN.Location = new System.Drawing.Point(464, 227);
            this.zonesBTN.Name = "zonesBTN";
            this.zonesBTN.Size = new System.Drawing.Size(226, 57);
            this.zonesBTN.TabIndex = 8;
            this.zonesBTN.Text = "Unlock all zones";
            this.zonesBTN.UseVisualStyleBackColor = true;
            this.zonesBTN.Click += new System.EventHandler(this.zonesBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.zonesBTN);
            this.Controls.Add(this.tokensBTN);
            this.Controls.Add(this.maxLevelBTN);
            this.Controls.Add(this.getByte);
            this.Controls.Add(this.getChipsBTN);
            this.Controls.Add(this.saveSlotBTN);
            this.Controls.Add(this.slotlabel);
            this.Controls.Add(this.slotBox);
            this.Controls.Add(this.getCharactersBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FNaF World Mod Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCharactersBTN;
        private System.Windows.Forms.TextBox slotBox;
        private System.Windows.Forms.Label slotlabel;
        private System.Windows.Forms.Button saveSlotBTN;
        private System.Windows.Forms.Button getChipsBTN;
        private System.Windows.Forms.Button getByte;
        private System.Windows.Forms.Button maxLevelBTN;
        private System.Windows.Forms.Button tokensBTN;
        private System.Windows.Forms.Button zonesBTN;
    }
}

