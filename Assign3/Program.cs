using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Manager Id");
            int MId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Manager Name");
            string MName = Console.ReadLine();
            Console.WriteLine("Enter the Manager Salary");
            double MSalary = Convert.ToDouble(Console.ReadLine());
            Manager manager1 = new Manager(MId, MName, MSalary);

            Console.WriteLine("Enter the MarketingExecutive Id");
            int MEId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the MarketingExecutive Name");
            string MEName = Console.ReadLine();
            Console.WriteLine("Enter the MarketingExecutive Salary");
            double MESalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Travelling Km");
            int MKm = Convert.ToInt32(Console.ReadLine());
            MarketingExecutive mExecutive1 = new MarketingExecutive(MEId, MEName, MESalary, MKm);

            double managerSalary = manager1.calculateGrossSalary();
            double mExecutiveSalary = mExecutive1.calculateGrossSalary();

            Console.WriteLine("Manager Gross Salary " + managerSalary);
            Console.WriteLine("Marketing Executive Gross Salary " + mExecutiveSalary);
            Console.ReadLine();
        }
    }
}
