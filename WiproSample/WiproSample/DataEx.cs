using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample
{
    public class DataEx
    {
        

        public void DisplayInfo()
        {
            Console.WriteLine("Enter Your Name:");
            string EmpName=Console.ReadLine();

            Console.WriteLine("Enter your age:");
            byte Age= Convert.ToByte( Console.ReadLine());

            //accept salary of a person from console window and print it
            Console.WriteLine("Enter your Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(  );

            Console.WriteLine("My name is="+EmpName+" Age="+Age+" Salary="+salary);
            Console.WriteLine("My name is={0}, Age={1}, Salary={2}",EmpName,Age,salary);
        }

        /*
         1. Get phone number of person and print it (Note:phone number
            1. it should be a 10 digit number, but it can be +ve or -ve number
            2. it can start with any number except 0)
        2. Accept address of person and print it. (Note: it should be a full address with 
           street name, area name, pincode etc separated by comma)
        3. Accept date of birth of person and print it
        4. Accept monthly salary of person and print his annual salary
        5. Print all details in the format given below

        ****************************************************************
        Phone Number : 8965000000
        Address      : No:52, RadhaStreet, Kolumbu, Maharastra - 369852
        DOB          : 25/12/2025
        MonthlySalary: 5000
        AnnualSalary : 60000
        ****************************************************************
         */
    }
}
