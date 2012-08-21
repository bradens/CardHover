using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
 * DEFINES.cs
 */

namespace CardHover
{
    public class DEFINES
    {
        public static bool VERBOSE_OUTPUT = true;
        
        public static string NETDRAFT_NAME = "iDraft";
        public static int MAXIMUM_FILES = 20000;        // Arbitrary number to approximate # of images.
        public static Hashtable PICTURES;
        public static string EXAMPLE_CARD_NAME = "cardBox";

    }
}
