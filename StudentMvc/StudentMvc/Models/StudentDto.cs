using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMvc.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Seat_no { get; set; }
        public Nullable<int> Year { get; set; }
        public string Address { get; set; }
        public string Department_Name { get; set; }

    }
}