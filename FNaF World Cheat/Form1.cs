using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FNaF_World_Cheat
{
    public partial class Form1 : Form
    {

        string mmfApps = Environment.ExpandEnvironmentVariables("%AppData%\\MMFApplications");
        string slotNum = "";

        public void WriteToSlot(string method)
        {
            using (StreamWriter slot = new StreamWriter(Path.Combine(mmfApps, $"fnafw{slotNum}"), true))
            {
                /*
                if (method == "characters")
                {
                    for (int i = 11; i <= 48; i++)
                    {
                        slot.WriteLine($"\n{i}have=1");
                    }
                }*/
                switch (method) {
                    case "characters":
                        for (int i = 9; i <= 48; i++)
                        {
                            slot.WriteLine($"\n{i}have=1");
                        }
                    break;
                    case "chips":
                        for (int i = 1; i <= 21; i++)
                        {
                            slot.WriteLine($"\nc{i}=1");
                        }
                        break;
                    case "bytes":
                        for (int i = 1; i <= 21; i++)
                        {
                            slot.WriteLine($"\np{i}=1");
                        }
                        break;
                    case "max":
                        for (int i = 0; i <= 48; i++)
                        {
                            slot.WriteLine($"\n{i}lv=99999999");
                        }
                        break;
                    case "tokens":
                        slot.WriteLine($"\ntokens=999999999");
                        break;
                    case "zones":
                        slot.WriteLine("\nsw1=1\nw3=1\nsw2=1\nsw3=1\nsw4=1\nsw5=1");
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getCharactersBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("characters");
        }

        private void saveSlotBTN_Click(object sender, EventArgs e)
        {
            slotNum = slotBox.Text.ToString();
        }

        private void getChipsBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("chips");
        }

        private void getByte_Click(object sender, EventArgs e)
        {
            WriteToSlot("bytes");
        }

        private void maxLevelBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("max");
        }

        private void tokensBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("tokens");
        }

        private void zonesBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("zones");
        }
    }
}
