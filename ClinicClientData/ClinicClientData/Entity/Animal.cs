using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicClientData.Entity
{
    public class Animal
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string BithDate { get; set; }
        public Animal(int _id, string _type, string _name, string _bithDate)
        {
            this.Id = _id;
            this.Type = _type;
            this.Name = _name;
            this.BithDate = _bithDate;
        }
    }
}
