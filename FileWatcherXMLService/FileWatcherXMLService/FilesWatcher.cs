using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileWatcherXMLService
{
    class FilesWatcher
    {
        FileSystemWatcher watcher;
        bool enabled = true;
        public FilesWatcher()
        {
            watcher = new FileSystemWatcher(Path.Combine(Kernel.RootFolderPath,Kernel.XMLFilePath));
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Renamed;
        }
        /// <summary>
        /// Старт прослушки
        /// </summary>
        public void Start()
        {
            watcher.EnableRaisingEvents = true;
            while (enabled)
            {
                Thread.Sleep(200);
            }
        }
        /// <summary>
        /// Остановка прослушки
        /// </summary>
        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
            enabled = false;
        }
        /// <summary>
        /// Отслеживание переименования файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {           
            string fileEvent = "Переименован в " + e.FullPath;
            string filePath = e.OldFullPath;
            Logger.RecordEntry(fileEvent, filePath);
        }
        /// <summary>
        /// Отслеживание изменения файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "Изменен";
            string filePath = e.FullPath;
            Logger.RecordEntry(fileEvent, filePath);
        }
        /// <summary>
        /// Отслеживание создания файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "Создан";
            string filePath = e.FullPath;
            Logger.RecordEntry(fileEvent, filePath);
            if (Path.GetExtension(filePath) == ".xml")
            {
                RecordData.RecordXML(filePath);            
            }
            else
            {
                Logger.RecordEntry("не xml,файл не записан", filePath);
            }
        }
        /// <summary>
        /// Отслеживание удаления файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "Удален";
            string filePath = e.FullPath;
            Logger.RecordEntry(fileEvent, filePath);
        }       
    }
}
