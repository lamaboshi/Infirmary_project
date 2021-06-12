using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infirmary_project.Model
{
    class InfirmaryProjectContext:DbContext
    {
        public InfirmaryProjectContext(): base("Data Source=.;Initial Catalog=DBInfirmaryProject;Integrated Security=True")
        {

        }
        public DbSet <Category> Categories { set; get; }
        public DbSet<EntrySide> EntrySides { set; get; }
        public DbSet<HealthStatus> HealthStatuses { set; get; }
        public DbSet<Job> Jobs { set; get; }
        public DbSet<Material> Materials { set; get; }
        public DbSet<Medicine> medicines { set; get; }
        public DbSet<Person> people { set; get; }
        public DbSet<PersonHealthStatus> PersonHealthStatuses { set; get; }
        public DbSet<PersonJob> PersonJobs { set; get; }
        public DbSet<PersonStatus> PersonStatuses { set; get; }
        public DbSet<Report> Reports { set; get; }
        public DbSet<ReportMaterial> ReportMaterials { set; get; }
    }
}
