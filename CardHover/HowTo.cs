using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * Main.Designer.cs
 */

namespace CardHover
{
    public partial class HowTo : Form
    {
        public HowTo()
        {
            InitializeComponent();
            helpText.Text = "To get CardHover working:\n\n1. Start the netdraft client before opening Card Hover\n" +
                "\n2. When Card Hover is first opened it will ask you to select the directory where your pictures are stored. This is normally C:\\Program Files\\Magic Workstation\\Pics" + 
                "\n\n3. Card Hover will then cache the images so they are available. Be patient. If the program goes 'non responsive' wait, and it will resume." +
                "\n\n4. Press 'Start CardHover'\n\n5. Mouse over any card within the netdraft client." + 
                    "\n\nIf a card is not being displayed, this means you do not have the appropriate card picture on your hardrive.";
        }
    }
}
