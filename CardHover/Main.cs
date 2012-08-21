using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Windows.Automation;

/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * Main.cs
 */

namespace CardHover
{
    public partial class Main : Form
    {
        public static bool _doDelete = false;
        public static string _picDirectory;
        public static AutomationElement _AEMainWnd;
        public static bool _showingCard;
        public static string _currentCardName;
        public pictureBox _picFrame;
        public pictureBox _searchPicFrame;

        // Autocomplete for the searchBox.
        AutoCompleteStringCollection _autoComplete = new AutoCompleteStringCollection();

        public Main()
        {
            InitializeComponent();
            _picFrame = new pictureBox();
            _searchPicFrame = new pictureBox();
            if (!SettingsExist())
            {
                Welcome();
                GetSettings();
                cacheFiles();
            }
            // Otherwise get the settings from a file.
            else
            {
                ReadSettings();
            }
        }

        public void Welcome()
        {
            MessageBox.Show("Welcome to CardHover, this is a one time message.  Some things you want to know are:" +
                "\nCardHover uses pictures stored ON your computer, so in order to use it, you must have scans." +
                "\nThis only works with .jpg images, and it works a lot better with .full.jpg scans." +
                "\nFinally, if the app goes non-responsive for a few seconds in the 'Caching' window, " +
                "just let it finish.", "Welcome!");
        }

        // reads the settings, then the cache
        public int ReadSettings()
        {
            StreamReader inFile = new StreamReader("Settings.CardHover");
            inFile.ReadLine();
            string tempLine = inFile.ReadLine();
            tempLine = tempLine.Substring(tempLine.IndexOf("=") + 1);
            
            // Set the picturepath
            _picDirectory = tempLine;

            // Close the stream
            inFile.Close();
            
            // Instantiate PICTURES
            DEFINES.PICTURES = new Hashtable();

            try
            {
                // Read the cacheFile into DEFINES
                StreamReader sr = new StreamReader("cache.CardHover");

                // Read past the intro
                sr.ReadLine();
                for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
                {
                    string key = line.Substring(0, line.IndexOf(">"));
                    string value = line.Substring(line.IndexOf(">") + 1);
                    DEFINES.PICTURES.Add(key, value);
                    _autoComplete.Add(key);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bad Cache, Deleting the Cache.CardHover and Settings.CardHover files and closing.");
                _doDelete = true;
                this.Close();
            }
            
            searchBox.AutoCompleteCustomSource = _autoComplete;
            return 0;
        }
        public int cacheFiles()
        {
            Caching cache = new Caching();
            cache.Show();
            cache.startCaching(0);
            cache.WriteCache();
            
            // Update the autocomplete
            foreach (string key in DEFINES.PICTURES.Keys)
            {
                _autoComplete.Add(key);
            }
            searchBox.AutoCompleteCustomSource = _autoComplete;
            cache.Close();
            return 0;
        }

        // Checks if the "Settings.CardHover" file exists
        public bool SettingsExist()
        {
            if (File.Exists("Settings.CardHover"))
                return true;
            else
                return false;
        }

        // Gets the settings from a dialog and then writes them to a file (Settings.CardHover).
        public int GetSettings()
        {
            // Get picture directory
            SettingsForm settingsDlg = new SettingsForm();
            settingsDlg.ShowDialog();

            // Set the global var then write to "Settings.CardHover"
            _picDirectory = settingsDlg.pathBox.Text;

            if (!Directory.Exists(_picDirectory))
            {
                MessageBox.Show("Error, Bad Directory.");
                GetSettings();
                return 0;
            }

            StreamWriter outFile = new StreamWriter("Settings.CardHover");
            outFile.WriteLine("// Settings file for cardHover\nPicturePath =" + _picDirectory);

            outFile.Close();
            return 0;
        }

        public int checkMousePos()
        {
            try
            {
                AutomationElement hoverElement = AutomationElement.FromPoint(
                    new System.Windows.Point(MousePosition.X, MousePosition.Y));

                if (hoverElement != null)
                {
                    // output to debug1
                    debugBox.Text = "MousePos: (" + MousePosition.X.ToString() + ", " + MousePosition.Y.ToString() + ") CardName: "
                        + hoverElement.Current.Name;

                    // output to debug2
                    debugBox2.Text = "MousePos: (" + MousePosition.X.ToString() + ", " + MousePosition.Y.ToString() + ") CardName: "
                        + hoverElement.Current.AutomationId;

                    showCardPic(hoverElement.Current.Name);
                }
            }
            catch (ElementNotAvailableException e)
            {
                Console.WriteLine("Element Not Available Exception. " + e.StackTrace);
                return 0;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception. " + e.StackTrace);
                return 0;
            }
            return 0;
        }

        public int showCardPic(string Name)
        {
            Name = Name.Trim();
            if (DEFINES.PICTURES.ContainsKey(Name))
            {
                string picPath = DEFINES.PICTURES[Name].ToString();
                _picFrame.picInner.ImageLocation = picPath;
                _picFrame.Location = new Point(MousePosition.X - (_picFrame.Width + 10),
                    MousePosition.Y - (_picFrame.Height + 10));
                _picFrame.Show();
            }
            else
                _picFrame.Hide();
            return 0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            mouseTimer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            mouseTimer.Stop();
        }

        private void mouseTimer_tick(object sender, EventArgs e)
        {
            checkMousePos();
        }

        private void searchBox_MouseDown(object sender, MouseEventArgs e)
        {
            searchBox.SelectAll();
        }

        // searchbox
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (DEFINES.PICTURES.Contains(searchBox.Text))
            {
                string picPath = DEFINES.PICTURES[searchBox.Text].ToString();
                _searchPicFrame.picInner.ImageLocation = picPath;
                _searchPicFrame.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height);
                _searchPicFrame.Show();
                searchBox.Focus();
            }
            else
                _searchPicFrame.Hide();
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            _searchPicFrame.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteTempFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _doDelete = true;
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_doDelete)
            {
                File.Delete("Cache.CardHover");
                File.Delete("Settings.CardHover");
            }
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            _searchPicFrame.Hide();
            _picFrame.Hide();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                minimizeToTrayIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
                minimizeToTrayIcon.Visible = false;
        }

        private void minimizeToTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutDlg = new About();
            aboutDlg.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void cloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HowTo howToDlg = new HowTo();
            howToDlg.ShowDialog();
        }
    }
}
