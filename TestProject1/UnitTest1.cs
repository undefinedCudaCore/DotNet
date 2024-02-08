using _08_paskaita;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Sum_CheckIsCorrect()
        {
            //Arrange
            double number1 = 2;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Sum(number1, number2);

            //Assert
            Assert.AreEqual(4, mySum);
        }

        [Test]
        public void Substract_CheckIsCorrect()
        {
            //Arrange
            double number1 = 2;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Substract(number1, number2);

            //Assert
            Assert.AreEqual(0, mySum);
        }

        [Test]
        public void Multiplication_CheckIsCorrect()
        {
            //Arrange
            double number1 = 5;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Multiplication(number1, number2);

            //Assert
            Assert.AreEqual(10, mySum);
        }

        [Test]
        public void Devide_CheckIsCorrect()
        {
            //Arrange
            double number1 = 5;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Devide(number1, number2);

            //Assert
            Assert.AreEqual(2.5, mySum);
        }

        [Test]
        public void Sqrt_CheckIsCorrect()
        {
            //Arrange
            double number1 = 5;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Sqrt(number1, number2);

            //Assert
            Assert.AreEqual(3.16, mySum);
        }

        [Test]
        public void Pow_CheckIsCorrect()
        {
            //Arrange
            double number1 = 5.2;
            double number2 = 3.6;

            //Act
            double mySum = TaskNo01.Pow(number1, number2);

            //Assert
            Assert.AreEqual(378.1, mySum);
        }
    }
}