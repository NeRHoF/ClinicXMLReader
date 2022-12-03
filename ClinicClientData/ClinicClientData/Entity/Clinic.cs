using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicClientData.Entity
{
    public class Clinic
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public string Rqtime { get; set; }
        public Clinic(string _type, string _id, string _rqtime)
        {
            this.Type = _type;
            this.Id = _id;
            this.Rqtime = _rqtime;
        }
    }
}
