namespace ClassMethodsExercices
{
    internal class Computer
    {
        public Computer(string model, double ram, string storage)
        {
            Model = model;
            RamGB = ram;
            Storage = storage;
            WinProgramList = new List<WinProgram>();
        }

        public string Model { get; set; }
        public double RamGB { get; set; }
        public string Storage { get; set; }
        public List<WinProgram> WinProgramList { get; set; }

        public List<WinProgram> AddProgram(WinProgram program)
        {
            WinProgramList.Add(program);

            return WinProgramList;
        }

        public void PrintIsComputerAbleToOpenProgram()
        {
            for (int i = 0; i < WinProgramList.Count; i++)
            {
                if (WinProgramList[i].RamToRunProgram >= RamGB)
                {
                    Console.WriteLine($"Yes, your computer can run {WinProgramList[i].ProgramTitle}.");
                }
                else
                {
                    Console.WriteLine($"Your PC can't run {WinProgramList[i].ProgramTitle}.");
                }

            }
        }
    }

}
