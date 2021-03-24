using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramsAssignment.Helper
{
    public class FileHelper
    {
        /// <summary>
        /// Return List of Works from given Text file
        /// </summary>
        /// <returns></returns>
        public static List<string> FetchWordListFromFileByFileName(string fileName) {
            return System.IO.File.ReadAllLines("Files/" + fileName).ToList();
        }
    }
}
