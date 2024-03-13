namespace _14_foreach_multidimentional_arrays.Tests
{
    [TestClass()]
    public class TaskNo01Tests
    {
        [TestMethod()]
        public void AverageOfPositiveArrayValuesTest()
        {
            //Arrange
            int[] fakePositiveNumbers = { 55, 12, 132 };
            int expectedPositiveAverage = 66;

            //Act
            int actualPositiveNumberAverage = TaskNo01.AverageOfArrayValues(fakePositiveNumbers);

            //Assert
            Assert.AreEqual(actualPositiveNumberAverage, expectedPositiveAverage);
        }

        [TestMethod()]
        public void AverageOfNegativeArrayValuesTest()
        {
            //Arrange
            int[] fakeNegativeNumbers = { -69, -58, -9999 };
            int expectedNegativeAverage = -3375;

            //Act
            int actualNegativeNumberAverage = TaskNo01.AverageOfArrayValues(fakeNegativeNumbers);

            //Assert
            Assert.AreEqual(actualNegativeNumberAverage, expectedNegativeAverage);
        }

        [TestMethod()]
        public void ArrayOfPositiveValuesTest1()
        {
            //Arrange
            int[] fakeArrayWithNegativeNumbers = { -69, -58, -9999, 2, 88, -6, 8, 12 };
            int[] expectedReturnedArrayWithoutNegativeNumbers = { 2, 88, 8, 42 };

            //Act
            int[] actualArrayWithPositiveNumbers = TaskNo01.ArrayOfPositiveValues(fakeArrayWithNegativeNumbers);
            //Assert
            CollectionAssert.Equals(actualArrayWithPositiveNumbers, expectedReturnedArrayWithoutNegativeNumbers);
        }

        [TestMethod()]
        public void ArrayOfPositiveValuesTest2()
        {
            //Arrange
            int[] fakeArrayArrayWithoutNegativeNumbers = { 10, 15, 12, 18, 555 };
            int[] expectedReturnedFakeArrayWithoutNegativeNumbers = { 10, 12, 15, 18, 555 };

            //Act
            int[] actualArrayWithPositiveNumbers = TaskNo01.ArrayOfPositiveValues(fakeArrayArrayWithoutNegativeNumbers);
            //Assert
            CollectionAssert.Equals(actualArrayWithPositiveNumbers, expectedReturnedFakeArrayWithoutNegativeNumbers);
        }
    }
}