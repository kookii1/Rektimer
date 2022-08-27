using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rektimer
{
    public partial class MainForm : Form
    {
        int nLoadCounter = 1;
        string loadCounterTextBase = "Load Counter: ";
        Color backColor = ColorTranslator.FromHtml("#A5C9CA");

        TextBox[] startLoadTextBox = {}; TextBox[] endLoadTextBox = { };

        float timeWithLoads = 0F, timeWithoutLoads = 0F;

        public MainForm()
        {
            InitializeComponent();
            applyTheme();                           // Apply theme to controls
            Array.Resize(ref startLoadTextBox, 32);
            Array.Resize(ref endLoadTextBox, 32);   // Resize the arrays to support multiple loads
        }

        private void loadAdd_Click(object sender, EventArgs e)
        {
            // Create the load start and end text boxes and add them to an array

            TextBox txtloadStart = new TextBox();
            txtloadStart.BackColor = backColor;
            txtloadStart.SetBounds(nLoadCounter * 120, 25, 110, 20);

            TextBox txtloadEnd = new TextBox();
            txtloadEnd.BackColor = backColor;
            txtloadEnd.SetBounds(nLoadCounter * 120, 70, 110, 20);

            startLoadTextBox[nLoadCounter - 1] = txtloadStart;
            endLoadTextBox[nLoadCounter - 1] = txtloadEnd;

            panel1.Controls.Add(txtloadStart as TextBox);
            panel1.Controls.Add(txtloadEnd as TextBox);

            nLoadCounter++;
            loadCounter.Text = loadCounterTextBase + (nLoadCounter - 1);
        }

        private void retimeBtn_Click(object sender, EventArgs e)
        {
            float framerate = float.Parse(vFPS.Text), start = float.Parse(fStart.Text), end = float.Parse(fEnd.Text), totalLoadFrames = 0; // Get information from the input

            timeWithLoads = (end - start) / framerate;                          // Epic calculation

            for (int i = 0; i < nLoadCounter - 1; i++)
            {
                int loadStart = int.Parse(startLoadTextBox[i].Text),
                loadEnd = int.Parse(endLoadTextBox[i].Text);

                totalLoadFrames += (loadEnd - loadStart);                      // Get all the loads and calculate to get the number of frames of each load
            }

            timeWithoutLoads = ((end - start) - totalLoadFrames) / framerate;  // More epic calculation

            TimeSpan tSpanLoads = TimeSpan.FromSeconds(timeWithLoads), tSpanNoLoads = TimeSpan.FromSeconds(timeWithoutLoads);

            string tLoads = "", tNoLoads = "";

            // Well.. Remove the useless zeroes from the time

            string[] removeZeroes = tSpanLoads.ToString().Split(':'), removeNoLoadZeroes = tSpanNoLoads.ToString().Split(':');

            foreach(string time in removeZeroes)
            {
                if(time == "00")
                {
                    continue;
                }

                tLoads += time + ":";
            }

            foreach (string time in removeNoLoadZeroes)
            {
                if (time == "00")
                {
                    continue;
                }

                tNoLoads += time + ":";
            }

            tLoads = tLoads.Substring(0, tLoads.Length - 5);
            tNoLoads = tNoLoads.Substring(0, tNoLoads.Length - 5);                                        // Remove useless milliseconds from the final time

            string endingMessage = "Time with loads: " + tLoads + "\nTime without loads: " + tNoLoads;
            Clipboard.SetText(endingMessage);                                                            // Copy text to the clipboard
            MessageBox.Show(endingMessage + "\nThis message was copied to the clipboard");
        }

        private void applyTheme()
        {
            BackColor = ColorTranslator.FromHtml("#2C3333");

            retimeBtn.BackColor = backColor; loadAdd.BackColor = backColor;

            fStart.BackColor = backColor; fEnd.BackColor = backColor; vFPS.BackColor = backColor;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = Pens.White; Rectangle rect = new Rectangle(panel1.Bounds.X - 1, panel1.Bounds.Y - 1, panel1.Size.Width + 1, panel1.Size.Height + 1);
            e.Graphics.DrawRectangle(p, rect); // Load panel outline
        }
    }
}
