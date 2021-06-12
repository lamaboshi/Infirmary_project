using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
    public class Medicine
    {
        public int Id { set; get; }
        public int Amount { set; get; }
        public DateTime Date { set; get; }
        public int IdPersonHealthStatus { set; get; }
        public PersonHealthStatus PersonHealthStatus { set; get; }
        public int IdReportMaterial { set; get; }
        public ReportMaterial ReportMaterial { set; get; }
    }
}
