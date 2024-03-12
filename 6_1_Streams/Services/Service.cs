using _6_1_Streams.Models;

namespace _6_1_Streams.Services
{
    internal class Service
    {
        readonly string _filePath;

        public Service(string filePath)
        {
            _filePath = filePath;
        }

        public string ExtractCsvHeaders()
        {
            using StreamReader sr = new StreamReader(_filePath);

            return sr.ReadLine();
        }

        public List<BasicUser> FetchBasicUserCsvRecords()
        {
            int userColCount = 8;

            List<BasicUser> users = new List<BasicUser>();

            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\UserData1.csv";

            using StreamReader sr = new StreamReader(path);
            string userLine = "";

            string skippingHeadingLine = sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColCount)
                {
                    break;
                }

                BasicUser newUser = new BasicUser()
                {
                    Id = int.Parse(userData[0]),
                    FirstName = userData[1],
                    LastName = userData[2],
                    Email = userData[3],
                    Gender = userData[4],
                    Salary = int.Parse(userData[5]),
                    FavoriteColor = userData[6],
                    BirthDate = userData[7]
                };

                users.Add(newUser);
            }

            return users;
        }
    }
}
