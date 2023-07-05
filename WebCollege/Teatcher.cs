using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollege.Interface;

namespace WebCollege
{
    public class Teatcher: ITeatcher
    {
        public string Name { get; set; }
        public string Course { get; set; }

        public Teatcher(string name, string course)
        {
            Name = name;
            Course = course;
        }

        // выводим информацию об учителе
        public void Show()
        {
            Console.WriteLine($"Преподаватель {Name} закреплен за курсом {Course}");
        }

        // сравниваеи по длине строки имени
        int IComparable<ITeatcher>.CompareTo(ITeatcher other)
        {
            return String.Compare(Name, other.Name);
        }
    }
}
