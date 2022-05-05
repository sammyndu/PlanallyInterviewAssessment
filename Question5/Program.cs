using System;
using System.Threading.Tasks;

namespace Question5
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);

            static async Task<(long , long)> SomeCalculation(long salaries, int employees, bool compare) {
                var getAverageSalary = salaries / employees;

                return (getAverageSalary, employees);
            }
        }
    }
}
