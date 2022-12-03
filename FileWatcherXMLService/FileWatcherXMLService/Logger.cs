using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherXMLService
{
    internal class Logger
    {
        /// <summary>
        /// Запись логов
        /// </summary>
        /// <param name="fileEvent"></param>
        /// <param name="filePath"></param>
        public static void RecordEntry(string fileEvent, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(Kernel.RootFolderPath,Kernel.LogFilePath), true))
            {
                writer.WriteLine(String.Format("{0} файл {1} был {2}",
                    DateTime.Now.ToString(Kernel.LogFormat), filePath, fileEvent));
                writer.Flush();
            }
        }       
    }
}
