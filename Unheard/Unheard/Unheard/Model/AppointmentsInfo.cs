using System;
using System.Collections.Generic;
using System.Text;
using Appointments.Services.Interfaces;

namespace Appointments.Model
{
    public class AppointmentsInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Emailadress { get; set; }

        public int Cellphone { get; set; }

        public string Gender { get; set; }

        public int IDnumber { get; set; }

        public string MaritalStatus{ get; set; }

        public string SpouseName { get; set; }

        public string PatientEmployer { get; set; }

        public int EmployerPhone { get; set; }

        public int EmergencyPhone { get; set; }

        public int Date{ get; set; }

        public int DateofAppointment { get; set; }

        


    }
}