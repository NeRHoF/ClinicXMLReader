using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ClinicClientData
{
    public class DataBase
    {
        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        SQLiteConnection _sqlConnection = new SQLiteConnection(@"Data Source=" + Path.Combine(Kernel.RootFolderPath, Kernel.DBFilePath));
        /// <summary>
        /// Открыть подключение к БД
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка подключения к БД", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Закрыть подключение к БД
        /// </summary>
        public void CloseConnection()
        {
            if (_sqlConnection.State == ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }
        public SQLiteConnection getConnection()
        {
            return _sqlConnection;
        }
    }
}
