using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
  public  class HealthStatus
    {
        public int Id { set; get; }
        public string Name { set; get; }
        ICollection<PersonHealthStatus> personHealthStatus { set; get; }
    }
}
