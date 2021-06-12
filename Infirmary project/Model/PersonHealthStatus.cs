using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
  public  class PersonHealthStatus
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int IdPerson { set; get; }
        public Person Person { set; get; }
        public int IdHealthStatus { set; get; }
        public HealthStatus HealthStatus { set; get; }
        ICollection<Medicine> medicine { set; get; }

    }
}
