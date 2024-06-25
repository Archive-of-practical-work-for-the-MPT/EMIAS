using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10.Model
{
    internal class Patients
    {
        public long oms {  get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public DateOnly birthDate { get; set; }
        public string address { get; set; }
        public string livingAddress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string nickname { get; set; }
    }
}
