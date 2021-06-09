using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Model
{
   public class PersonStatus
    {
        public int Id { set; get; }
        public string Status { set; get; }
        public DateTime Date { set; get; }
        public int IdPerson { set; get; }
        public Person Person { set; get; }
        public int IdEntrySide { set; get; }
        public EntrySide EntrySide { set; get; }
    }
}
