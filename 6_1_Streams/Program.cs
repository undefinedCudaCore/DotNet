using _6_1_Streams.Models;
using _6_1_Streams.Services;


namespace _6_1_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro intro = new Intro();

            //Intro.ReadFromTxtFile();
            //Intro.ReadFromTxtFileLines();
            //StreamReaderAndStreamWriter.StreamWriter();
            //StreamReaderAndStreamWriter.ReadFileUsingStreams();

            Service fileServeice = new Service(Environment.CurrentDirectory + "\\Data\\UserData1.csv");
            //Console.WriteLine(fileServeice.ExtractCsvHeaders());

            //PrintAddBasicUsers(fileServeice.FetchBasicUserCsvRecords());

            //StreamReaderAndStreamWriter.WriteFileUsingStreams();
            //StreamReaderAndStreamWriter.WriteFileUsingStreamsWhichWillBeUsedALot();
            //StreamReaderAndStreamWriter.ReadFromBufferFileStream();

            //Exercise 2-------------------------
            //List<string> strings = new List<string>();
            //strings.Add("But who vaunted power can basked a childe evil deem");
            //strings.Add("Delight hall shades times partings hope which if mother did weary it satiety loved weary venerable feeble my oh scorching");
            //strings.Add("Sooth most nor soul flash did be glorious pile loved");
            //strings.Add("Seek nor friend artless the left day it they yea at would he of feel who knew not he to");
            //strings.Add("Were like along brow and partings where of he fountain whence stalked other such flee hall his his sighed who deeds she lemans wight joyless and sorrow at he shades earthly wight fly deem true harolds land rill of in childe nor he shameless yet had suits he hight in nor uncouth scorching pollution native this by from and sight me himnot sighed and childe yet were the consecrate him one be condemned agen womans love fall say said weary sins for he the chill dares for womans the forgot say in wins counsel was not one shades however for");
            //strings.Add("Fame but still sins not bliss waste caught seek the sooth him lyres my to he mine so like and pollution loathed which lone a day childe these sullen whilome in on one friends dear he nor atonement to alone he maddest the to for adversity to and oh might as have as cell his and oer if blazon agen sea pile by had childe did harold grace perchance they and old he the like know there which was was heralds grace where low to run sun call he such");
            //strings.Add("His to did will nor saw than by none fall had ever drugged sorrow festal lay found in my native his that wandered would did gild not he who he he care nor glorious none finds and and passion him cell but the in harold lone sick a of nor were departed a alas fame suits drugged and visit control glee childe superstition deemed and change the but oft a would fulness have true objects did nor yet of shamed dote now grief the land");

            //StreamReaderAndStreamWriter.WriteFileUsingStreamsWhichWillBeUsedALotExerciseTwo(strings);

            //Exercise 3-------------------------
            //StreamReaderAndStreamWriter.CopyFile();

            //Exercise 4-------------------------
            //StreamReaderAndStreamWriter.CountLineSimbols();

            //Exercise 5-------------------------
            StreamReaderAndStreamWriter.StreamWriter2();

            //Exercise 6-------------------------
            //StreamReaderAndStreamWriter.WriteDefaultValuesToDataFile();
            //StreamReaderAndStreamWriter.DisplayDefaultValuesFromDataFile();

        }

        public static void PrintAddBasicUsers(List<BasicUser> basicUsers)
        {
            foreach (BasicUser basicUser in basicUsers)
            {
                Console.WriteLine($"Id: {basicUser.Id}, First name: {basicUser.FirstName}, Last name: {basicUser.LastName}," +
                    $" Email: {basicUser.Email}, gender: {basicUser.Gender}, salary: {basicUser.Salary}, " +
                    $"favorite color: {basicUser.FavoriteColor}, birth date: {basicUser.BirthDate}");
            }
        }
    }
}
