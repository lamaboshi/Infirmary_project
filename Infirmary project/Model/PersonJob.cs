using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Model
{
   public class PersonJob
    {
        public  int Id { set; get; }
        public int FinSalary { set; get; }
        public DateTime Date { set; get; }
        public int IdPerson { set; get; }
        public Person Person { set; get; }
        public int IdJob { set; get; }
        public Job Job { set; get; }
    }
}
