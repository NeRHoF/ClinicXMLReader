using System;
using System.IO;

namespace FileWatcherXMLService
{
    public static class Kernel
    {
        public static string RootFolderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\"));
        public static string DBFilePath = "DataBase\\BDXML.db";
        public static string LogFilePath = "TempLog\\templog.txt";
        public static string LogFormat = "dd/MM/yyyy hh:mm:ss";
        public static string XMLFilePath = "FolderXML";
    }
}
