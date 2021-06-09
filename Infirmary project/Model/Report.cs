using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Model
{
    public class Report
    {
        public int Id { set; get; }
        public string Type { set; get; }
        public int Amount { set; get; }
        public DateTime Date { set; get; }
        ICollection<ReportMaterial> ReportMaterial { set; get; }
    }
}
