using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCollege;
using WebCollege.Interface;

namespace WebCollegeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение для работы с колледжем и предователем в нем");
            ICollege collegeMOK = new College(name: "Первый МОК", address: "Москва, старавотутинский проекзд, дом 6");
            ICollege college26KADR = new College(name: "26 кадр", address: "Москва, ул. Трофимова, 27, корп. 2");

            ITeatcher[] collegeMOKTeacher = new[] {
                new Teatcher(name: "Анатолий Тузовский", course: "ТРПО"),
                new Teatcher(name: "Екатерина Вейнгерова", course: "Математическое моделирование")
            };

            ITeatcher[] college26KADRTeacher = new[] {
                new Teatcher(name: "Зюзин Михаил", course: "ТРПО"),
                new Teatcher(name: "Альбина Зразова", course: "Математическое моделирование"),
                new Teatcher(name: "Анатолий Сипрко", course: "Математическое моделирование")
            };

            collegeMOK.AddTeatchers(collegeMOKTeacher);
            college26KADR.AddTeatchers(college26KADRTeacher);

            List<ICollege> allCollege = new List<ICollege> {
               collegeMOK,
               college26KADR
            };

            foreach(var college in allCollege)
            {
                college.ShowAll();
            }

            Console.WriteLine("На этом все. Работу выполнил студент 31ИС, Романов Андрей");
            Console.ReadLine();
        }
    }
}
