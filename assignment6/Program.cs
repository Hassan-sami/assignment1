using assignment6.context;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new RouteContext())
            {
                var studnets = context.Students;
                foreach(var student in studnets)
                {
                    Console.WriteLine(student.Address);
                }
            }
        }
    }
}