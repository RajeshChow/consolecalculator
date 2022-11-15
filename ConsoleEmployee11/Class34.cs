using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmployee11
{
    internal class Class34
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }



        public void EmployeeDetails()
        {
            Console.WriteLine("Enter employee number");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Please enter your Salary");
            Salary = Convert.ToDouble(Console.ReadLine());



            try
            {
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100;
                    TA = Salary * 5 / 100;
                    DA = Salary * 15 / 100;
                }
                else if (Salary > 5000 && Salary < 10000)
                {
                    HRA = Salary * 15 / 100;
                    TA = Salary * 10 / 100;
                    DA = Salary * 20 / 100;
                }
                else if (Salary > 10000 && Salary < 15000)
                {
                    HRA = Salary * 20 / 100;
                    TA = Salary * 15 / 100;
                    DA = Salary * 25 / 100;
                }
                else if (Salary > 15000 && Salary < 20000)
                {
                    HRA = Salary * 25 / 100;
                    TA = Salary * 20 / 100;
                    DA = Salary * 30 / 100;
                }
                else
                {
                    HRA = Salary * 30 / 100;
                    TA = Salary * 25 / 100;
                    DA = Salary * 35 / 100;
                }
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary(GrossSalary);




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void CalculateSalary(double GrossSalary)
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            DisplaySalary(GrossSalary, PF, TDS, NetSalary);




        }
        public void DisplaySalary(double GrossSalary, double PF, double TDS, double NetSalary)
        {
            Console.WriteLine("Gralary is " + GrossSalary);
            Console.WriteLine("PF is " + PF);
            Console.WriteLine("TDS is " + TDS);
            Console.WriteLine("NET Salary is " + NetSalary);
        }
    }
}
