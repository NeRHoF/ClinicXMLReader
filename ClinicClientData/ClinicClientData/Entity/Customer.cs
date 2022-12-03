using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicClientData.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public List<Animal> animal = new List<Animal>();
        public Customer()
        {
        }
        public Customer(int _id, string _name, string _surname, string _patronymic)
        {
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
            this.Patronymic = _patronymic;
        }
    }
}
