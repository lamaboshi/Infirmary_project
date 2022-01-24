using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infirmary_project.Util.ExtensionMethod
{
        public static class ExtensionMethod
        {
            public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> Enum) where T : class
            {
                return new ObservableCollection<T>(Enum);
            }
        }

}
