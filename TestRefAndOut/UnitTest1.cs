using _10_ref_out;

namespace TestRefAndOut
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void UserNameAndSurenameAreEqualTo()
        {
            //Arrange
            string namie = "tadas";
            string surenamie = "blinda";

            //Act
            TaskNo02.GetUserData(namie, surenamie, out string name, out string surename);
            string sentence = name + " " + surename;

            //Assert
            Assert.That(sentence, Is.EqualTo("Tadas Blinda"));
            Assert.That(sentence, Is.Not.EqualTo("tadas blinda"));
        }

        [Test]
        public void TestDevisioAndRemindes()
        {
            //Arrange
            string testNumber1 = "4";
            string testNumber2 = "2";
            string testNumber3 = "0";
            string testNumber4 = "asdsadsa";

            //Act
            double result = TaskNo02.Devide(testNumber1, testNumber2, out double reminder);
            double result2 = TaskNo02.Devide(testNumber1, testNumber3, out reminder);
            double result3 = TaskNo02.Devide(testNumber1, testNumber4, out reminder);

            //Assert
            Assert.That(result, Is.EqualTo(2));
            Assert.That(reminder, Is.EqualTo(0));
            Assert.That(result2, Is.EqualTo(double.NaN));
            Assert.That(result3, Is.EqualTo(double.NaN));
        }
    }
}