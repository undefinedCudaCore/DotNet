namespace _8_1_Extention_Methods_Intro
{
    public static class Extentions
    {
        public static bool CheckIsParameterIntIsBigger(this int myInt, int intToCheck)
        {
            return intToCheck > myInt;
        }

        public static string CreateEmail(this string email, string fullname, int yearOfBirth, string domain)
        {
            string[] splitedName = fullname.Split(" ");
            fullname = "";

            for (int i = 0; i < splitedName.Length; i++)
            {
                fullname += splitedName[i];
            }

            return fullname.ToLower() + yearOfBirth.ToString() + "@" + domain.ToLower();
        }

        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            for (int i = 1; i < list.Count; i = i + 1)
            {
                list.RemoveAt(i);
            }
            return list;
        }

        public static void WriteToFileEveryOtherWord(this string path)
        {
            List<string> list = Fulfill();

            using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }

            string[] fileLines = File.ReadAllLines(path);

            List<string> fileLinesList = fileLines.ToList();

            for (int i = 0; i < fileLinesList.Count; i = i + 1)
            {
                fileLinesList.RemoveAt(i);
            }

            File.WriteAllLines(path, fileLinesList);
        }

        private static List<string> Fulfill()
        {
            string lorem = "Ancient though there men been olden strength night almost bade to shameless ofttimes all to him a himnot of things";
            List<string> list = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(lorem);
            }

            return list;
        }
    }
}
