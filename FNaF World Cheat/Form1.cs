using System;
using System.IO;
using System.Windows.Forms;

namespace FNaF_World_Cheat
{
    public partial class Form1 : Form
    {

        string mmfApps = Environment.ExpandEnvironmentVariables("%AppData%\\MMFApplications");
        string slotNum = "";

        public void LoadToSlot(string slotNumber, string method, string text)
        {
            using (StreamWriter slot = new StreamWriter(Path.Combine(mmfApps, $"fnafw{slotNumber}"), true))
            {
                switch (method)
                {
                    case "loadCode":
                        slot.WriteLine($"\n{text}");
                        break;
                    case "getCharacter":
                        slot.WriteLine($"\n{text}have=1");
                        break;
                }
            }
        }

        public void WriteToSlot(string method)
        {
            using (StreamWriter slot = new StreamWriter(Path.Combine(mmfApps, $"fnafw{slotNum}"), true))
            {
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
                        slot.WriteLine("\nsw1=1\nw3=1\nsw2=1\nsw3=1\nsw4=1\nsw5=1\nsw6=1\nsw7=1\nsw8=1\nsw9=1");
                        break;
                    case "key":
                        slot.WriteLine("\nkey=1");
                        break;
                    case "armor":
                        slot.WriteLine("\nar1=1\nar2=1\nar3=1");
                        break;
                    case "beatgame?":
                        slot.WriteLine("\nbeatgame=1\nlast=1\nbeatgame2=1");
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

        private void keyBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("key");
        }

        private void armorBTN_Click(object sender, EventArgs e)
        {
            WriteToSlot("armor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteToSlot("beatgame?");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getcharBTN_Click(object sender, EventArgs e)
        {
            LoadToSlot(slotNum, "getCharacter", charBox.Text.ToString());
        }

        private void dataBTN_Click(object sender, EventArgs e)
        {
            LoadToSlot(slotNum, "loadCode", dataBox.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e) // Character list btn
        {
            Form2 characterList = new Form2();
            characterList.Show();
        }

    }
}
