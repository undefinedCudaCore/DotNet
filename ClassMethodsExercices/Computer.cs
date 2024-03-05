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

        public Computer(string computerID, string model, double ramGB, string storage)
        {
            ComputerID = computerID;
            Model = model;
            RamGB = ramGB;
            Storage = storage;
            WinProgramList = new List<WinProgram>();
        }

        public string ComputerID { get; set; }
        public string Model { get; set; }
        public double RamGB { get; set; }
        public string Storage { get; set; }
        public List<WinProgram> WinProgramList { get; set; }

        public List<WinProgram> AddProgram(WinProgram program)
        {
            WinProgramList.Add(program);

            return WinProgramList;
        }

        /// <summary>
        /// It's a simple way to print if the computer has enough time to run the program.
        /// </summary>
        public void PrintIsComputerAbleToOpenProgram()
        {
            for (int i = 0; i < WinProgramList.Count; i++)
            {
                if (WinProgramList[i].RamToRunProgram >= RamGB)
                {
                    Console.WriteLine($"Yes, your computer {Model} {ComputerID} can run {WinProgramList[i].ProgramTitle}.");
                }
                else
                {
                    Console.WriteLine($"Your PC {Model} {ComputerID} can't run {WinProgramList[i].ProgramTitle}.");
                }

            }
        }
    }

}
