using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rektimer
{
    public partial class MainForm : Form
    {
        int nLoadCounter = 0;
        string loadCounterTextBase = "Load Counter: ";
        Color backColor = ColorTranslator.FromHtml("#A5C9CA");

        TextBox[] startLoadTextBox = {}; TextBox[] endLoadTextBox = { };

        float timeWithLoads = 0F, timeWithoutLoads = 0F;

        public MainForm()
        {
            InitializeComponent();
            applyTheme(); // Apply theme to controls

            Array.Resize(ref startLoadTextBox, 64);
            Array.Resize(ref endLoadTextBox, 64); // Resize the arrays to support multiple loads

            fStart.ContextMenu = null;
            fEnd.ContextMenu = null;
            vFPS.ContextMenu = null; // Disables context menu on all the text boxes so pasting letters is impossible
        }

        private void loadAdd_Click(object sender, EventArgs e)
        {
            // Create the load start and end text boxes and add them to an array

            TextBox txtloadStart = new TextBox();
            TextBox txtloadEnd = new TextBox();

            txtloadStart.Name = "loadStart" + nLoadCounter; // Set text box name for identification
            txtloadStart.BackColor = backColor;
            txtloadStart.SetBounds((nLoadCounter + 1) * 120, 25, 110, 20); // Set theme and position

            txtloadStart.ContextMenu = null; // Disables copy and pasting
            txtloadStart.ShortcutsEnabled = false;


            txtloadEnd.Name = "loadEnd" + nLoadCounter;
            txtloadEnd.BackColor = backColor;
            txtloadEnd.SetBounds((nLoadCounter + 1) * 120, 70, 110, 20);

            txtloadEnd.ContextMenu = null;
            txtloadEnd.ShortcutsEnabled = false;

            txtloadStart.KeyPress += allowDigitsOnly;
            txtloadEnd.KeyPress += allowDigitsOnly; // Disables the option to insert letters or special characters
            startLoadTextBox[nLoadCounter] = txtloadStart;
            endLoadTextBox[nLoadCounter] = txtloadEnd;

            panel1.Controls.Add(txtloadStart as TextBox);
            panel1.Controls.Add(txtloadEnd as TextBox); // Add controls to panel

            nLoadCounter++;
            loadCounter.Text = loadCounterTextBase + (nLoadCounter);
        }

        private void retimeBtn_Click(object sender, EventArgs e)
        {
            if(vFPS.Text == "" || fStart.Text == "" || fEnd.Text == "")
            {
                MessageBox.Show("Please fill all the text boxes before retiming.");
                return; // Throw error if any of the text boxes is empty
            }


            float framerate = float.Parse(vFPS.Text), 
                start = float.Parse(fStart.Text), 
                end = float.Parse(fEnd.Text), totalLoadFrames = 0; // Get information from the input
            bool hasLoads = false;


            if(end <= start)
            {
                MessageBox.Show("End frame cannot be smaller or equal to start frame." +
                    "\nPlease check your input then try again.");
                return; 
            }


            timeWithLoads = (end - start) / framerate; // Epic calculation

            for (int i = 0; i < nLoadCounter; i++)
            {
                if(startLoadTextBox[i].Text == "" || endLoadTextBox[i].Text == "")
                {
                    MessageBox.Show("Please fill all the text boxes before retiming.");
                    return; // Throw error if any of the text boxes is empty
                }

                int loadStart = int.Parse(startLoadTextBox[i].Text),
                loadEnd = int.Parse(endLoadTextBox[i].Text);

                totalLoadFrames += (loadEnd - loadStart); // Get all the loads and calculate to get the number of frames of each load
                hasLoads = true;
            }

            timeWithoutLoads = ((end - start) - totalLoadFrames) / framerate; // More epic calculation


            TimeSpan tSpanLoads = TimeSpan.FromSeconds(timeWithLoads), tSpanNoLoads = TimeSpan.FromSeconds(timeWithoutLoads);
            string tLoads = tSpanLoads.ToString(), tNoLoads = tSpanNoLoads.ToString(), endingMessage = "";

            if(tLoads.Contains("."))
            {
                tLoads = tLoads.Substring(0, tLoads.Length - 4);
            }
            if (tNoLoads.Contains("."))
            {
                tNoLoads = tNoLoads.Substring(0, tNoLoads.Length - 4);
            }

            /*while ((char)tLoads[0] == '0' || (char)tLoads[0] == ':')
            {
                tLoads = tLoads.Remove(0, 1);
            }
            while ((char)tNoLoads[0] == '0' || (char)tNoLoads[0] == ':')
            {
                tNoLoads = tNoLoads.Remove(0, 1);
            }*/
            

            if (hasLoads)
            {
                endingMessage = "Time with loads: " + tLoads + "\n";
            }

            endingMessage += "Time without loads: " + tNoLoads + "\nRetimed with Rektimer https://github.com/rekkto/Rektimer";
            Clipboard.SetText(endingMessage); // Copy text to the clipboard
            MessageBox.Show(endingMessage + "\nThis message was copied to the clipboard");
        }

        private void loadRem_Click(object sender, EventArgs e)
        {
            if(nLoadCounter == 0) {
                MessageBox.Show("No Loads to remove.");
                return; 
            }

            // Remove a load from the counter

            panel1.Controls["loadStart" + (nLoadCounter - 1)].Dispose();
            panel1.Controls["loadEnd" + (nLoadCounter - 1)].Dispose();

            startLoadTextBox[nLoadCounter] = null;
            endLoadTextBox[nLoadCounter] = null;

            nLoadCounter--;
            loadCounter.Text = loadCounterTextBase + (nLoadCounter);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = Pens.White; Rectangle rect = new Rectangle(panel1.Bounds.X - 1, panel1.Bounds.Y - 1, panel1.Size.Width + 1, panel1.Size.Height + 1);
            e.Graphics.DrawRectangle(p, rect); // Render panel outline
        }

        private void applyTheme()
        {
            BackColor = ColorTranslator.FromHtml("#2C3333");

            retimeBtn.BackColor = backColor; loadAdd.BackColor = backColor; loadRem.BackColor = backColor;

            fStart.BackColor = backColor; fEnd.BackColor = backColor; vFPS.BackColor = backColor;
        }

        private void allowDigitsOnly(object sender, KeyPressEventArgs e) { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
        // Makes all the text boxes recieve numbers only
    }
}
