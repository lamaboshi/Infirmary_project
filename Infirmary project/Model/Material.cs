using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Model
{
  public  class Material
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Amount { set; get; }
        public int IdCategory { set; get; }
        public Category Category { set; get; }
        ICollection<ReportMaterial> ReportMaterial { set; get; }
    }
}
