using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Model
{
   public class Category
    {
        public int Id { set; get; }
        public string category { set; get; }
        ICollection<Material> material { set; get; }
    }
}
