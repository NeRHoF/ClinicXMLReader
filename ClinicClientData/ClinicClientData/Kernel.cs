using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicClientData
{
    public static class Kernel
    {
        public static string RootFolderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\"));
        public static string DBFilePath = "DataBase\\BDXML.db";
        public static string LogFilePath = "TempLog\\templog.txt";
        public static string DateFilterMask = "    -  -  T  :  :";
        public static string Exception = "Ошибка";
    }
}
