using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollege.Interface;

namespace WebCollege
{
    public class College: ICollege
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ITeatcher> Teatchers { get; set; } = new List<ITeatcher>();

        public College(string name, string address) 
        { 
            Name = name;
            Address = address;
        }


        // информация о колледже
        public void Show()
        {
            Console.WriteLine($"Информация о колледже {Name}.\nАдрес: {Address}. Количество преподавателей {Teatchers.Count}");
        }

        public void ShowAll()
        {
            Teatchers.Sort();
            Show();

            foreach(Teatcher te in Teatchers)
            {
                te.Show();
            }
        }

        public void AddTeatchers(ITeatcher[] teatchers)
        {
            foreach (Teatcher te in teatchers)
            {
                AddTeatcher(te);
            }
        }

        // добавить одного преподавателя
        private void AddTeatcher(ITeatcher te)
        {
            Teatchers.Add(te);
        }
    }
}
