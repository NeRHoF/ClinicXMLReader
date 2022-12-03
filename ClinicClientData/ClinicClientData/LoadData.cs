using ClinicClientData.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicClientData
{
    public class LoadData
    {
        /// <summary>
        /// Получить данные клиентов
        /// </summary>
        /// <returns></returns>
        public static DataSet GetData()
        {
            DataBase dataBase = new DataBase();
            DataSet dataSetClinicClientData = new DataSet();
            SQLiteCommand requestClinic = new SQLiteCommand(ResourceQuery.ALL_DATA_CLIENT, dataBase.getConnection());
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
            dataAdapter.SelectCommand = requestClinic;
            dataAdapter.Fill(dataSetClinicClientData);
            dataAdapter.Dispose();
            return dataSetClinicClientData;
        }
        /// <summary>
        /// Получить данные животных у выбранного клиента
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static DataSet GetAnimalData(Customer customer) {
            DataBase dataBase = new DataBase();
            DataSet dataSetAnimalData = new DataSet();
            SQLiteCommand requestAnimalData = new SQLiteCommand(ResourceQuery.DATA_ANIMAL, dataBase.getConnection());
            requestAnimalData.Parameters.Add(new SQLiteParameter("@Customer_id",DbType.Int64));
            requestAnimalData.Parameters["@Customer_id"].Value = customer.Id;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
            dataAdapter.SelectCommand = requestAnimalData;
            dataAdapter.Fill(dataSetAnimalData);
            dataAdapter.Dispose();
            return dataSetAnimalData;
        }
    }
}
