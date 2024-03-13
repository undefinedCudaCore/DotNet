namespace _18_Dictionary.Tests
{
    [TestClass()]
    public class TaskNo01Tests
    {
        [TestMethod()]
        public void CountryCapitalTest()
        {
            //Arrange
            string fakeCountry = "Wrong";
            string fakeReturnOfCapital = "You entered wrong country.";

            //Act
            string actualCountry = TaskNo01.CountryCapital(fakeCountry);

            //Assert
            Assert.AreEqual(actualCountry, fakeReturnOfCapital);
        }

        [TestMethod()]
        public void RenewFruitListTest1()
        {
            //Arrange
            Dictionary<string, int> fakeTitleAndQtyOfFruits = new Dictionary<string, int>
            {
                { "Orange", 7 },
                { "Apple", 6},
                { "Banana", 9999},
                { "Coconut", 6 }
            };

            string fakeFruit = "Banana";
            string fakeQty = "9999";

            //Act
            Dictionary<string, int> actualReturnedListOfFruitsToPrint =
                TaskNo01.AddOrRenewFruitList(TaskNo01.FruitsTitleAndQty(), fakeFruit, fakeQty);

            //Assert
            CollectionAssert.AreEqual(actualReturnedListOfFruitsToPrint, fakeTitleAndQtyOfFruits);
        }

        [TestMethod()]
        public void AddFruitListTest1()
        {
            //Arrange
            Dictionary<string, int> fakeTitleAndQtyOfFruits = new Dictionary<string, int>
            {
                { "Orange", 7 },
                { "Apple", 6},
                { "Banana", 8},
                { "Coconut", 6 },
                { "Guava", 9999}
            };

            string fakeFruit = "Guava";
            string fakeQty = "9999";

            //Act
            Dictionary<string, int> actualReturnedListOfFruitsToPrint =
                TaskNo01.AddOrRenewFruitList(TaskNo01.FruitsTitleAndQty(), fakeFruit, fakeQty);

            //Assert
            CollectionAssert.AreEqual(actualReturnedListOfFruitsToPrint, fakeTitleAndQtyOfFruits);
        }
    }
}