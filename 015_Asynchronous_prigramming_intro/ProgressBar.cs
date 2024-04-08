namespace _015_Asynchronous_prigramming_intro
{
    internal class ProgressBar
    {
        public ProgressBar()
        {
            _progress = 0;
        }

        internal int _progress { get; set; }

        public async Task AddOneEverySecondToProgressAsynnc()
        {
            while (_progress < 100)
            {
                await Task.Delay(1000);
                _progress++;
            }
        }
        public async Task PrintThEverySecondsProgressAsynnc()
        {
            while (_progress < 100)
            {
                await Task.Delay(3000);
                Console.WriteLine($"{_progress}%.");
            }
        }
    }
}
