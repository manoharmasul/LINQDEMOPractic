using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDEMO
{
    class lINQDemo1
    {

        //example using query syntax 
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var querysyntax = from obj in li where obj > 5 select obj;

            foreach(var item in querysyntax)
            {
                Console.Write(item +",");
            }
        }
    }
    class LINQDemo2
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var methodsyntax = li.Where(x => x > 5).ToList();
            foreach(var item in methodsyntax)
            {
                Console.Write(item +",");
            }
        }
       
    }
    class LINQDemo3
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
                {
                    2,3,4,5,6,7,8,9,10,11
                };
            var syntax = (from obj in li where obj > 5 select obj).Sum();
            Console.WriteLine("sum is " + syntax);
        }
    }
    public class Studentt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class LINQDemo4
    {
        static void Main(string[] args)
        {
            List<Studentt> slist = new List<Studentt>()
            {
                new Studentt(){Id=101,Name="Manohar",Gender="Male"},
                new Studentt(){Id=102,Name="Mansi",Gender="Female"},
                new Studentt(){Id=103,Name="Jaya",Gender="Female"},
                new Studentt(){Id=107,Name="Sandip",Gender="Male"},
                new Studentt(){Id=104,Name="Arohi",Gender="Female"},
                new Studentt(){Id=105,Name="Madhuri",Gender="Female"}
            };
            IEnumerable<Studentt> query = from studd in slist where studd.Gender == "Male" select studd;
            foreach(var student in query)
            {
                Console.WriteLine($"ID:{ student.Id} Name:{student.Name}");
            }
        }
    }

}
