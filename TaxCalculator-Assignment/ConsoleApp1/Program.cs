using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using System.Threading;
using System.Transactions;
using System.Runtime.InteropServices.WindowsRuntime;


//class contains all business logic for tax calculations

#region calculator class
public class TaxCalculator
{

    //properties Declatratoion section
    #region Poperties
    private double _userSalary { get; set; }
    private int _userAge { get; set; }
    private double _taxAmount { get; set; }
    #endregion

    //All the constant required to calculate tax are declared here
    #region Constant Declaeation
    private const double _taxChargeforIncomeBetween5to10lacforAgeBelow60 = 12500;
    private const double _taxChargeforIncomeAbove10lacforAgeBelow60 = 112500;
    private const double _taxChargeforIncomeBetween5to10lacforAgeBetween60and80 = 10000;
    private const double _taxChargeforIncomeAbove10lacforAgeBetween60and80 = 110000;
    private const double _taxChargeforIncomeAbove10lacforAgeAbove80 = 100000;
    private const int _maxAgeLimit = 100;
    private const int _ageLimitforfFirstCategory = 60;
    private const int _ageLimitforSecondgCategory = 80;
    #endregion



    //constructor section
    #region constructor
    public TaxCalculator(double userSalary, int userAge)
    {
        this._userSalary = userSalary;


        //this will check valiid user input for constructoe
        if (userAge <= 0 || userSalary <= 0)
        {
            throw new ArgumentException("value cannot be less than or equal to zero");

        }
        else if (userAge > _maxAgeLimit)
        {
            throw new ArgumentException("User Age cannot be more than 100");
        }
        else
        {


            this._userAge = userAge;
            this._userSalary = userSalary;


        }
    }
    #endregion




    //this method will return value of calculated tax
    #region Taxcalculation Method
    public double CalculateTax()
    {
        if (this._userAge <= _ageLimitforfFirstCategory)
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
        if (this._userAge > _ageLimitforfFirstCategory && this._userAge <= _ageLimitforSecondgCategory)
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
        if (this._userAge > _ageLimitforSecondgCategory)
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
    #endregion
}
#endregion

#region Business logic
class TaxCalculatorAssignment
{
    public static void Main(string[] args)
    {
        //local variables to store input from user
        double inputSalary;
        int inputAge;



    ValueAssignment:
        try
        {
            Console.WriteLine("Enter Income");
            //this will verify values passed by user or not\
            while (!double.TryParse(Console.ReadLine(), out inputSalary))
            {

                throw new ArgumentException("Invalid value please enter valid Number");
            }


            Console.WriteLine("Enter Age");
            while (!int.TryParse(Console.ReadLine(), out inputAge))
            {
                throw new ArgumentException("Invalid value please enter valid Number");
            }



            //object initializaon section
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
#endregion
