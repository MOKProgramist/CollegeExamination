using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCollege.Interface
{
   public interface ICollege
    {
        string Name { get; set; }
        string Address { get; set; }

        List<ITeatcher> Teatchers { get; set; }

        void ShowAll();
        void Show();
        // добавить преподавателей
        void AddTeatchers(ITeatcher[] teatchers);
    }
}
