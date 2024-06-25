using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10.Model
{
    internal class Appointments
    {
        public int idAppointment {  get; set; }
        public long oms {  get; set; }
        public int idDoctor { get; set; }
        public DateOnly appointmentDate {  get; set; }
        public TimeOnly appointmentTime { get; set; }
        public int idStatus { get; set; }
    }
}
