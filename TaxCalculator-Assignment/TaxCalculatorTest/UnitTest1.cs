using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TaxCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Sad Path")]
        public void NegativeAgeAssignmentTest()
        {
            double Usersalary = 1000;
            int UserAge = -1;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Sad Path")]

        public void NegativeSalaryAssignmentTest()
        {
            double Usersalary = -1;
            int UserAge = 100;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Sad Path")]

        public void AgeGreaterthan100Test()
        {
            double Usersalary = 1;
            int UserAge = 101;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Sad Path")]

        public void AgeEqualzeroTest()
        {
            double Usersalary = 1;
            int UserAge = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
        }


        //Test cases for tax calculation of Age below Sixty Category

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelow60andhavingMinimumBoundarysalaryofSlab1Test()
        {
            double Usersalary = 1;
            int UserAge = 12;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebelow60andhavingMaximumBoundaryofsalaryofSlab1Test()
        {
            double Usersalary = 250000;
            int UserAge = 12;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebelow60andhavingMiddlevalueofsalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 12;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMinimumAgetillSixtyOfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 1;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMaximumAgetillSixtyOfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 60;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgetillSixtyOfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 30;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }


        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMinimumBoundarysalaryofSlab2Test()
        {
            double Usersalary = 250001;
            int UserAge = 12;
            double expectedOutput = 0.05;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMaximumsalaryofSlab2Test()
        {
            double Usersalary = 500000;
            int UserAge = 12;
            double expectedOutput = 12500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebelowSixtyandhavingMiddlesalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 12;
            double expectedOutput = 5000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgetillSixtyOfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 30;
            double expectedOutput = 5000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgetillSixtyOfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 60;
            double expectedOutput = 5000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgetillSixtyOfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 1;
            double expectedOutput = 5000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgetillSixtyOfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 30;
            double expectedOutput = 52500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgetillSixtyOfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 60;
            double expectedOutput = 52500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgetillSixtyOfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 1;
            double expectedOutput = 52500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMaximumsalaryofSlab3Test()
        {
            double Usersalary = 1000000;
            int UserAge = 12;
            double expectedOutput = 112500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMinumumsalaryofSlab3Test()
        {
            double Usersalary = 500001;
            int UserAge = 12;
            double expectedOutput = 12500.2;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }
        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMiddlealaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 12;
            double expectedOutput = 52500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }


        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgetillSixtyOfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 60;
            double expectedOutput = 142500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgetillSixtyOfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 30;
            double expectedOutput = 142500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgetillSixtyOfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 1;
            double expectedOutput = 142500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMiddlealaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 12;
            double expectedOutput = 142500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebelowSixtyandhavingMaximumSalaryofSlab4Test()
        {
            double Usersalary = 10000000;
            int UserAge = 12;
            double expectedOutput = 2812500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebelowSixtyandhavingMinimumSalaryofSlab4Test()
        {
            double Usersalary = 1000001;
            int UserAge = 12;
            double expectedOutput = 112500.3;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        //Test cases for tax calculation of Age between Sixty to Eighty

        public void TaxCalculationforAgebetween60to80andhavingMinimumBoundarysalaryofSlab1Test()
        {
            double Usersalary = 1;
            int UserAge = 65;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebetween60to80andhavingMaximumBoundaryofsalaryofSlab1Test()
        {
            double Usersalary = 300000;
            int UserAge = 65;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebetween60to80andhavingMiddlevalueofsalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 65;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMinimumAgebetween60to80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 60;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMaximumAgebetween60to80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 80;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgebetween60to80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 67;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }


        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMinimumBoundarysalaryofSlab2Test()
        {
            double Usersalary = 300001;
            int UserAge = 65;
            double expectedOutput = 0.05;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMaximumsalaryofSlab2Test()
        {
            double Usersalary = 500000;
            int UserAge = 65;
            double expectedOutput = 10000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebetween60to80andhavingMiddlesalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 65;
            double expectedOutput = 2500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgebetween60to80OfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 65;
            double expectedOutput = 2500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgebetween60to80OfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 80;
            double expectedOutput = 2500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgebetween60to80OfSalaryofSlab2Test()
        {
            double Usersalary = 350000;
            int UserAge = 61;
            double expectedOutput = 2500;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgebetween60to80OfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 65;
            double expectedOutput = 50000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgebetween60to80OfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 80;
            double expectedOutput = 50000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgebetween60to80OfSalaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 61;
            double expectedOutput = 50000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMaximumsalaryofSlab3Test()
        {
            double Usersalary = 1000000;
            int UserAge = 65;
            double expectedOutput = 110000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMinumumsalaryofSlab3Test()
        {
            double Usersalary = 500001;
            int UserAge = 65;
            double expectedOutput = 10000.2;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }
        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMiddlealaryofSlab3Test()
        {
            double Usersalary = 700000;
            int UserAge = 65;
            double expectedOutput = 50000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }


        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgebetween60to80OfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 80;
            double expectedOutput = 140000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgebetween60to80OfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 65;
            double expectedOutput = 140000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgebetween60to80OfSalaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 61;
            double expectedOutput = 140000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMiddlealaryofSlab4Test()
        {
            double Usersalary = 1100000;
            int UserAge = 65;
            double expectedOutput = 140000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgebetween60to80andhavingMaximumSalaryofSlab4Test()
        {
            double Usersalary = 10000000;
            int UserAge = 65;
            double expectedOutput = 2810000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgebetween60to80andhavingMinimumSalaryofSlab4Test()
        {
            double Usersalary = 1000001;
            int UserAge = 65;
            double expectedOutput = 110000.3;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        //test cases for above 80
        public void TaxCalculationforAgeAbove80andhavingMinimumBoundarysalaryofSlab1Test()
        {
            double Usersalary = 0;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgeAbove80andhavingMaximumBoundaryofsalaryofSlab1Test()
        {
            double Usersalary = 500000;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgeAbove80andhavingMiddlevalueofsalaryofSlab1Test()
        {
            double Usersalary = 250000;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMinimumAgeAbove80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforMaximumAgeAbove80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgeAbove80OfSalaryofSlab1Test()
        {
            double Usersalary = 125000;
            int UserAge = 81;
            double expectedOutput = 0;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }


        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgeAbove80andhavingMinimumBoundarysalaryofSlab2Test()
        {
            double Usersalary = 500001;
            int UserAge = 81;
            double expectedOutput = 0.2;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgeAbove80andhavingMaximumsalaryofSlab2Test()
        {
            double Usersalary = 1000000;
            int UserAge = 81;
            double expectedOutput = 100000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationforAgeAbove80andhavingMiddlesalaryofSlab2Test()
        {
            double Usersalary = 700000;
            int UserAge = 81;
            double expectedOutput = 40000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgeAbove80OfSalaryofSlab2Test()
        {
            double Usersalary = 700000;
            int UserAge = 95;
            double expectedOutput = 40000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgeAbove80OfSalaryofSlab2Test()
        {
            double Usersalary = 700000;
            int UserAge = 81;
            double expectedOutput = 40000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgeAbove80OfSalaryofSlab2Test()
        {
            double Usersalary = 700000;
            int UserAge = 100;
            double expectedOutput = 40000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMiddleAgeAbove80OfSalaryofSlab3Test()
        {
            double Usersalary = 1100000;
            int UserAge = 90;
            double expectedOutput = 130000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMaximumAgeAbove80OfSalaryofSlab3Test()
        {
            double Usersalary = 1100000;
            int UserAge = 99;
            double expectedOutput = 130000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]
        public void TaxCalculationMinimumAgeAbove80OfSalaryofSlab3Test()
        {
            double Usersalary = 1100000;
            int UserAge = 81;
            double expectedOutput = 130000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgeAbove80andhavingMaximumsalaryofSlab3Test()
        {
            double Usersalary = 10000000;
            int UserAge = 81;
            double expectedOutput = 2800000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }

        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgeAbove80andhavingMinumumsalaryofSlab3Test()
        {
            double Usersalary = 1100000;
            int UserAge = 81;
            double expectedOutput = 130000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }
        [TestMethod]
        [TestCategory("Happy path")]

        public void TaxCalculationforAgeAbove80andhavingMiddlealaryofSlab3Test()
        {
            double Usersalary = 5000000;
            int UserAge = 81;
            double expectedOutput = 1300000;
            TaxCalculator firstclaculation = new TaxCalculator(Usersalary, UserAge);
            Assert.AreEqual(firstclaculation.CalculateTax(), expectedOutput, "Output did not match");
        }



    }
}
