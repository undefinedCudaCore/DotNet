namespace ClassMethodsExercices
{
    internal class WinProgram
    {
        public WinProgram(double ramToRunProgram)
        {
            RamToRunProgram = ramToRunProgram;
        }

        public WinProgram(double ramToRunProgram, string programTitle) : this(ramToRunProgram)
        {
            ProgramTitle = programTitle;
        }

        public double RamToRunProgram { get; set; }
        public string ProgramTitle { get; set; }
    }
}
