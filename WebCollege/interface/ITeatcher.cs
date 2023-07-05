using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCollege.Interface
{
    public interface ITeatcher : IComparable<ITeatcher>
    {
        string Name { get; set; }
        string Course { get; set; }

        void Show();
    }
}
