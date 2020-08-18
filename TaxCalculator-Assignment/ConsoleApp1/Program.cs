using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using System.Threading;
using System.Transactions;
using System.Runtime.InteropServices.WindowsRuntime;

public class TaxCalculator
{
    private double _userSalary { get; set; }
    private int _userAge { get; set; }

    private double _taxAmount { get; set; }

    private static double _taxChargeforIncomeBetween5to10lacforAgeBelow60 = 12500;
    private static double _taxChargeforIncomeAbove10lacforAgeBelow60 = 112500;
    private static double _taxChargeforIncomeBetween5to10lacforAgeBetween60and80 = 10000;
    private static double _taxChargeforIncomeAbove10lacforAgeBetween60and80 = 110000;
    private static double _taxChargeforIncomeAbove10lacforAgeAbove80 = 100000;

    public TaxCalculator(double userSalary, int userAge)
    {
        this._userSalary = userSalary;
        if (userAge <= 0 || userSalary <= 0)
        {
            throw new ArgumentException("value cannot be less than or equal to zero");

        }
        else if (userAge > 100)
        {
            throw new ArgumentException("User Age cannot be more than 100");
        }
        else
        {


            this._userAge = userAge;
            this._userSalary = userSalary;


        }

    }

    public double CalculateTax()
    {
        if (this._userAge <= 60)
        {
            if (this._userSalary <= 250000)
            {
                this._taxAmount = 0;

            }
            else if (this._userSalary > 250000 && this._userSalary <= 500000)
            {
                this._taxAmount = ((this._userSalary - 250000) * 5) / 100;

            }
            else if (this._userSalary > 500000 && this._userSalary <= 1000000)
            {
                this._taxAmount = _taxChargeforIncomeBetween5to10lacforAgeBelow60 + ((this._userSalary - 500000) * 20) / 100;

            }
            else
            {
                this._taxAmount = _taxChargeforIncomeAbove10lacforAgeBelow60 + ((this._userSalary - 1000000) * 30) / 100;

            }
            return this._taxAmount;
        }
        if (this._userAge > 60 && this._userAge <= 80)
        {
            if (this._userSalary <= 300000)
            {
                this._taxAmount = 0;
            }
            else if (this._userSalary > 300000 && this._userSalary <= 500000)
            {
                this._taxAmount = ((this._userSalary - 300000) * 5) / 100;
            }
            else if (this._userSalary > 500000 && this._userSalary <= 1000000)
            {
                this._taxAmount = _taxChargeforIncomeBetween5to10lacforAgeBetween60and80 + ((this._userSalary - 500000) * 20) / 100;

            }
            else
            {
                this._taxAmount = _taxChargeforIncomeAbove10lacforAgeBetween60and80 + ((this._userSalary - 1000000) * 30) / 100;
            }
            return this._taxAmount;
        }
        if (this._userAge > 80)
        {
            if (this._userSalary <= 500000)
            {
                this._taxAmount = 0;

            }

            else if (this._userSalary > 500000 && this._userSalary <= 1000000)
            {
                this._taxAmount = ((this._userSalary - 500000) * 20) / 100;

            }
            else
            {
                this._taxAmount = _taxChargeforIncomeAbove10lacforAgeAbove80 + ((this._userSalary - 1000000) * 30) / 100;

            }
            return this._taxAmount;

        }
        return this._taxAmount;
    }
}


class TaxCalculatorAssignment
{
    public static void Main(string[] args)
    {
        double inputSalary;
        int inputAge;



    ValueAssignment:
        try
        { 
            Console.WriteLine("Enter Income");
            while (!double.TryParse(Console.ReadLine(), out inputSalary))
            {

                throw new ArgumentException("Invalid value please enter valid Number");
            }
        
        
            Console.WriteLine("Enter Age");
            while (!int.TryParse(Console.ReadLine(), out inputAge))
            {
                throw new ArgumentException("Invalid value please enter valid Number");
            }
        
        

            TaxCalculator firstcal = new TaxCalculator(inputSalary, inputAge);
            double result = firstcal.CalculateTax();
            Console.WriteLine("===================================");
            Console.WriteLine("Payable tax Amount is:{0}", firstcal.CalculateTax());
            Console.WriteLine("===================================");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            goto ValueAssignment;
        }


    }
}
