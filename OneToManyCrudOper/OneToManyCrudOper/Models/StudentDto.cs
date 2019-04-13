using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneToManyCrudOper.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Upload)]
        public HttpPostedFileBase Image { get; set; }
        public int SchoolId { get; set; }
    }
}