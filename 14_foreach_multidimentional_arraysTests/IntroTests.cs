namespace _14_foreach_multidimentional_arrays.Tests
{
    [TestClass()]
    public class IntroTests
    {
        [TestMethod()]
        public void SquarreNumbersTest()
        {
            //Arrange
            int[] fakeInts = { 1, 2, 3 }; // Memory blok AF30BE
            int[] expectedInts = { 1, 4, 9 }; // Memory blok FF11EE

            //Act
            int[] actualSquareInts = Intro.SquarreNumbers(fakeInts);

            //Assert
            CollectionAssert.Equals(actualSquareInts, expectedInts);
        }
    }
}