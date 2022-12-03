using FileWatcherXMLService.Entity;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherXMLService
{
    public class DataBase
    {

        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        SQLiteConnection _sqlConnection = new SQLiteConnection(@"Data Source="+Path.Combine(Kernel.RootFolderPath, Kernel.DBFilePath));
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

                Logger.RecordEntry(e.ToString(), "Ошибка подключения к бд");
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
        /// <summary>
        /// Получить строку подключение к БД
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection GetConnection()
        {
            return _sqlConnection;
        }
        /// <summary>
        /// Запись данных о клинике в базу данных
        /// </summary>
        /// <param name="clinic"></param>
        /// <param name="fileName"></param>
        public void DataRecordingClinic(Clinic clinic, string fileName)
        {
            SQLiteCommand request = new SQLiteCommand(ResourceQuery.INSERT_DATA_CLINIC, GetConnection());
            request.Parameters.Add(new SQLiteParameter("@Id", DbType.String));
            request.Parameters["@Id"].Value = clinic.Id;
            request.Parameters.Add(new SQLiteParameter("@Type", DbType.String));
            request.Parameters["@Type"].Value = clinic.Type;
            request.Parameters.Add(new SQLiteParameter("@Time", DbType.String));
            request.Parameters["@Time"].Value = clinic.Rqtime;
            OpenConnection();
            try
            {
                request.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Logger.RecordEntry(e.ToString(), fileName);
            }
            CloseConnection();
        }
        /// <summary>
        /// Запись данных о человеке и его питомцах в базу данных
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="fileName"></param>
        /// <param name="Clinic_id"></param>
        public void DataRecordingCustomer(Customer customer, string fileName, string Clinic_id)
        {
            SQLiteCommand requestCustomer = new SQLiteCommand(ResourceQuery.INSERT_DATA_CUSTOMER, GetConnection());
            requestCustomer.Parameters.Add(new SQLiteParameter("@Id", DbType.Int64));
            requestCustomer.Parameters["@Id"].Value = customer.Id;
            requestCustomer.Parameters.Add(new SQLiteParameter("@f", DbType.String));
            requestCustomer.Parameters["@f"].Value = customer.Surname;
            requestCustomer.Parameters.Add(new SQLiteParameter("@i", DbType.String));
            requestCustomer.Parameters["@i"].Value = customer.Name;
            requestCustomer.Parameters.Add(new SQLiteParameter("@o", DbType.String));
            requestCustomer.Parameters["@o"].Value = customer.Patronymic;
            requestCustomer.Parameters.Add(new SQLiteParameter("@Clinic_id", DbType.String));
            requestCustomer.Parameters["@Clinic_id"].Value = Clinic_id;
            OpenConnection();
            try
            {
                requestCustomer.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Logger.RecordEntry(e.ToString(), fileName);
            }
            foreach (Animal animal in customer.animal)
            {
                SQLiteCommand requestAnimal = new SQLiteCommand(ResourceQuery.INSERT_DATA_ANIMAL, GetConnection());
                requestAnimal.Parameters.Add(new SQLiteParameter("@Id", DbType.Int64));
                requestAnimal.Parameters["@Id"].Value = animal.Id;
                requestAnimal.Parameters.Add(new SQLiteParameter("@Name", DbType.String));
                requestAnimal.Parameters["@Name"].Value = animal.Name;
                requestAnimal.Parameters.Add(new SQLiteParameter("@Type", DbType.String));
                requestAnimal.Parameters["@Type"].Value = animal.Type;
                requestAnimal.Parameters.Add(new SQLiteParameter("@BithDate", DbType.String));
                requestAnimal.Parameters["@BithDate"].Value = animal.BithDate;
                requestAnimal.Parameters.Add(new SQLiteParameter("@Customer_id", DbType.Int64));
                requestAnimal.Parameters["@Customer_id"].Value = customer.Id;
                try
                {
                    requestAnimal.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Logger.RecordEntry(e.ToString(), fileName);
                }

            }
            CloseConnection();
        }
    }
}
