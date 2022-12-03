using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherXMLService.Entity
{
    /// <summary>
    /// Класс человека
    /// </summary>
    public class Customer
    {
        [Required(ErrorMessage = "Не указан id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указана фамилия")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Не указано отчество")]
        public string Patronymic { get; set; }
        public List<Animal> animal = new List<Animal>();
        public Customer(int _id, string _name, string _surname, string _patronymic)
        {
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
            this.Patronymic = _patronymic;
        }
    }

}
