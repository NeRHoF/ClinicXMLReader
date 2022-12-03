using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherXMLService.Entity
{
    /// <summary>
    /// Класс животных
    /// </summary>
    public class Animal
    {
        [Required(ErrorMessage = "Не указан ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан тип")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указана дата"), RegularExpression(@"^\d{4}\-\d{2}\-\d{2}")]
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
