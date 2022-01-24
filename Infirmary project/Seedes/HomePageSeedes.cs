using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Seedes
{
    public class HomePageSeedes
    {
        public readonly List<string> PersonType = new List<string> { "نزيل", "موظف" };
        public readonly List<string> EmployeeType = new List<string> { "سكرتاريا", "ممرض", "عامل نظافة" };
        public readonly List<string> GuestType = new List<string> { "الحاليين", "المغادرين", "المتوفيين" };
    }
}
