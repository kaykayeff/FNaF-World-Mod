using System.IO;

namespace FNaF_World_Mod_Menu_V4
{

    public partial class Form1 : Form
    {
        string mmfApps = Environment.ExpandEnvironmentVariables("%AppData%\\MMFApplications");
        string slotNum = "";

        public Form1()
        {
            InitializeComponent();
            AddDrag(topbar);
            AddDrag(titleLabel);
        }

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
                switch (method)
                {
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (homePage.Visible == false)
            {
                homePage.Visible = true; modsPage.Visible = false; miscPage.Visible = false;
            }
        }

        private void modsButton_Click(object sender, EventArgs e)
        {
            if (modsPage.Visible == false)
            {
                modsPage.Visible = true; homePage.Visible = false; miscPage.Visible = false;
            }
        }

        private void miscButton_Click(object sender, EventArgs e)
        {
            if (miscPage.Visible == false)
            {
                homePage.Visible = false; modsPage.Visible = false; miscPage.Visible = true;
            }
        }

        private void charListButton_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slotNum = slotBox.Text.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WriteToSlot("characters");
        }

        private void maxlvl_Click(object sender, EventArgs e)
        {
            WriteToSlot("max");
        }

        private void getchips_Click(object sender, EventArgs e)
        {
            WriteToSlot("chips");
        }

        private void getbytes_Click(object sender, EventArgs e)
        {
            WriteToSlot("bytes");
        }

        private void inftokens_Click(object sender, EventArgs e)
        {
            WriteToSlot("tokens");
        }

        private void allzones_Click(object sender, EventArgs e)
        {
            WriteToSlot("zones");
        }

        private void key_Click(object sender, EventArgs e)
        {
            WriteToSlot("key");
        }

        private void getarmor_Click(object sender, EventArgs e)
        {
            WriteToSlot("armor");
        }

        private void beatthegame_Click(object sender, EventArgs e)
        {
            WriteToSlot("beatgame?");
        }

        private void charConfirm_Click(object sender, EventArgs e)
        {
            LoadToSlot(slotNum, "getCharacter", charByNumberBox.Text.ToString());
        }

        private void dataConfirm_Click(object sender, EventArgs e)
        {
            LoadToSlot(slotNum, "loadCode", dataBox.Text.ToString());
        }
    }
}