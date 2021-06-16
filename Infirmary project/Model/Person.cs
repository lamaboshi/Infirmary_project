using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
   public class Person
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string MatherName { set; get; }
        public string Address { set; get; }
        public DateTime BirthDate { set; get; }
        public string CivilianId { set; get; }
        public string RelativeNumber { set; get; }
        public string Type { set; get; }
        public string Notes { set; get; }
        public string Image { set; get; }
        public string Photo { set; get; }

        ICollection<PersonStatus> personStatus { set; get; }
        ICollection<PersonJob> personJob { set; get; }
        ICollection<PersonHealthStatus> personHealthStatus { set; get; }
        ICollection<Report> Report { set; get; }

    }
}
