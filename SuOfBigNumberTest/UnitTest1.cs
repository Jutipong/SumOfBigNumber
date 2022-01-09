using NUnit.Framework;
using SumOfBigNumbers.Services;
using System.Numerics;

namespace SuOfBigNumberTest
{
    public class Tests
    {
        [Test]
        public void TestSumOfBigIntegerValid()
        {
            //Arrange
            BigInteger input1 = BigInteger.Parse("9999999999999999999999999");
            BigInteger input2 = BigInteger.Parse("1");
            BigInteger expect = BigInteger.Parse("10000000000000000000000000");

            //Act
            SumOfNumberService sumOfNumberService = new SumOfNumberService();
            var actual = sumOfNumberService.SumBigInteger(input1, input2);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void TestSumOfBigIntegerInvalid()
        {
            //Arrange
            var input1 = 1;
            var input2 = 1;
            var expect = 4;

            //Act
            SumOfNumberService sumOfNumberService = new SumOfNumberService();
            var actual = sumOfNumberService.SumBigInteger(input1, input2);

            //Assert
            Assert.AreNotEqual(expect, actual);

        }
    }
}