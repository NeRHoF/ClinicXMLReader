using FileWatcherXMLService.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileWatcherXMLService
{
    public class RecordData
    {
        /// <summary>
        /// Запись в БД одного запроса
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="fileName"></param>
        /// <param name="clinic"></param>
        public static void RecordRequest(Customer customer, string fileName, Clinic clinic)
        {
            if (customer.animal.Count != 0)
            {
                DataBase dataBase = new DataBase();
                dataBase.DataRecordingCustomer(customer, fileName, clinic.Id);
            }
            else
            {
                Logger.RecordEntry("У клиента нет животных", fileName);
            }
        }
        /// <summary>
        /// Запись запроса из файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="xDoc"></param>
        public static void ViewXMLRequests(string fileName, XmlDocument xDoc)
        {
            XmlElement rootClinic = xDoc.DocumentElement;
            if (rootClinic != null)
            {

                if (rootClinic.Name == "request")
                {
                    Clinic clinic = new Clinic(rootClinic.GetAttribute("type"), rootClinic.GetAttribute("id"), rootClinic.GetAttribute("rq-time"));
                    var resultsClinic = new List<ValidationResult>();
                    var contextClinic = new ValidationContext(clinic);
                    if (ValidateObject(clinic, contextClinic, resultsClinic, true, fileName))
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.DataRecordingClinic(clinic, fileName);
                        ViewCustomer(clinic, rootClinic, fileName);
                    }
                }
                else
                {
                    Logger.RecordEntry("Неправильно ветка request", fileName);
                }
            }
            else
            {
                Logger.RecordEntry("Отсутствует корневая ветка request", fileName);
            }
        }
        /// <summary>
        /// Запись всех людей у запроса
        /// </summary>
        /// <param name="clinic"></param>
        /// <param name="rootClinic"></param>
        /// <param name="fileName"></param>
        public static void ViewCustomer(Clinic clinic, XmlElement rootClinic, string fileName)
        {
            foreach (XmlElement nodeCustomer in rootClinic)
            {
                if (nodeCustomer.Name == "customer")
                {
                    Customer customer = new Customer(int.Parse(nodeCustomer.GetAttribute("id")), nodeCustomer.GetAttribute("f"), nodeCustomer.GetAttribute("i"), nodeCustomer.GetAttribute("o"));
                    var resultsCustomer = new List<ValidationResult>();
                    var contextCustomer = new ValidationContext(customer);
                    if (ValidateObject(customer, contextCustomer, resultsCustomer, true, fileName))
                    {
                        ViewXMLAnimal(customer, nodeCustomer, fileName);
                        RecordRequest(customer, fileName, clinic);
                    }
                }
                else
                {
                    Logger.RecordEntry("Неправильно ветка customer", fileName);
                }
            }
        }
        /// <summary>
        /// Запись всех животных у человека
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="nodeCustomer"></param>
        /// <param name="fileName"></param>
        public static void ViewXMLAnimal(Customer customer, XmlElement nodeCustomer, string fileName)
        {
            foreach (XmlElement childnodeAnimal in nodeCustomer)
            {
                if (childnodeAnimal.Name == "animal")
                {
                    Animal animal = new Animal(int.Parse(childnodeAnimal.GetAttribute("id")), childnodeAnimal.GetAttribute("type"), childnodeAnimal.GetAttribute("Name"), childnodeAnimal.GetAttribute("BithDate"));
                    var resultsAnimal = new List<ValidationResult>();
                    var contextAnimal = new ValidationContext(animal);
                    if (ValidateObject(animal, contextAnimal, resultsAnimal, true, fileName))
                    {
                        customer.animal.Add(animal);
                    }
                }
                else
                {
                    Logger.RecordEntry("Неправильно ветка animal", fileName);
                }
            }
        }
        /// <summary>
        /// Запись данных из xml файла в объекты
        /// </summary>
        /// <param name="filePath"></param>
        public static void RecordXML(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(filePath);                
                ViewXMLRequests(fileName, xDoc);
                Logger.RecordEntry("Файл успешно записан", filePath);
            }
            catch (Exception e)
            {
                Logger.RecordEntry(e.ToString(), fileName);
                return;
            }
        }
        /// <summary>
        /// Проверка на валидность объектов
        /// </summary>
        /// <param name="someObject"></param>
        /// <param name="context"></param>
        /// <param name="result"></param>
        /// <param name="response"></param>
        /// <param name="fileName"></param>
        /// <returns>Прошел ли объект проверку</returns>
        private static bool ValidateObject(object someObject, ValidationContext context, List<ValidationResult> result, bool response, string fileName)
        {
            if (!Validator.TryValidateObject(someObject, context, result, response))
            {
                foreach (var error in result)
                {
                    Logger.RecordEntry(error.ErrorMessage, fileName);
                }
                return false;
            }
            return true;
        }
    }
}
