using _08_paskaita;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Sum_CheckIsCorrect()
        {
            //Arrange
            double number1 = 2;
            double number2 = 2;

            //Act
            double mySum = TaskNo01.Sum(number1, number2);

            //Assert
            Assert.That(mySum, Is.EqualTo(4));
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
            Assert.That(mySum, Is.EqualTo(0));
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
            Assert.That(mySum, Is.EqualTo(10));
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
            Assert.That(mySum, Is.EqualTo(2.5));
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
            Assert.That(mySum, Is.EqualTo(3.16));
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
            Assert.That(mySum, Is.EqualTo(378.1));
        }
    }
}