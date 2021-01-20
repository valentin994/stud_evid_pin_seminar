using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stud_evid_pin_seminar.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        
        public int BrojDolazaka { get; set; }
    }
}
