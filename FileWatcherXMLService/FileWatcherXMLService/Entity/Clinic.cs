using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherXMLService.Entity
{
    /// <summary>
    /// Класс клиники
    /// </summary>
    public class Clinic
    {
        [Required(ErrorMessage = "Не указан тип")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Не указано id")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Не указано время"),RegularExpression(@"^\d{4}\-\d{2}\-\d{2}T\d{2}:\d{2}:\d{2}")]
        public string Rqtime { get; set; }

        public Clinic(string _type, string _id, string _rqtime)
        {
            this.Type = _type;
            this.Id = _id;
            this.Rqtime = _rqtime;
        }
    }

}

