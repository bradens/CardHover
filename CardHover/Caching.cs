using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * Caching.cs
 */


namespace CardHover
{
    public partial class Caching : Form
    {
        public string[] _Directories;
        public static int _totalDirs;
        public string[] _Files;

        public Caching()
        {
            InitializeComponent();
            DEFINES.PICTURES = new Hashtable();
            // Get the files
            _Files = Directory.GetFiles(Main._picDirectory, "*.full.jpg", SearchOption.AllDirectories);

            // Get the # of files for progress bar
            DEFINES.MAXIMUM_FILES = _Files.Length;
            cacheProgress.Maximum = DEFINES.MAXIMUM_FILES;

        }

        public int startCaching(int DirNumber)
        {
            for (int i = 0; i < DEFINES.MAXIMUM_FILES; i++)
            {
                cacheProgress.Value++;
                string tmp = _Files[i];
                fileNameLbl.Text = tmp;
                fileNameLbl.Update();
                tmp = tmp.Substring(tmp.LastIndexOf("\\") + 1);
                tmp = tmp.Replace(".full.jpg", "");
                
                if (!DEFINES.PICTURES.ContainsKey(tmp))
                    DEFINES.PICTURES.Add(tmp, _Files[i]);
            }
            return 0;
        }

        // Writes the DEFINES.PICTURES Hashtable to a file.
        public int WriteCache()
        {
            StreamWriter sw = new StreamWriter("Cache.CardHover");
            sw.WriteLine("//-------------------------------- BEGIN CACHE --------------------------------//");
            foreach (string key in DEFINES.PICTURES.Keys)
            {
                sw.WriteLine(key + ">" + DEFINES.PICTURES[key]);
            }
            sw.Close();
            return 0;
        }
    }
}
