﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcNo_Transcoder
{
    class Global
    {
        // Global variable definitions
        // Global static strings that won't change, and can be localised will be located in GlobalStr.resx, and their different language counterparts.
        public static int Bit;                  // Operating system bit
        public static string Nvexe;             // NVEncC executable, operating system bit specific
        public static string NvexeFull;         // Full locatino of NVEncC executable.
        public static string ExeLocation;       // Folder in which the program's .exe is
        public static DateTime EncodeStartTime;
        public static string LastFileEncoded;

        // User settings
        public static Dictionary<string, string> Settings =
            new Dictionary<string, string>();
    }
}