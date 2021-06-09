using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
   public class ReportMaterial
    {
        public int Id { set; get; }
        public int Amount { set; get; }
        ICollection<Medicine> medicine { set; get; }
        public int IdReport { set; get; }
        public Report Report { set; get; }
        public int IdMaterial { set; get; }
        public Material Material { set; get; }
    }
}
