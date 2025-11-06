namespace Project.Progress
{
    public class ProgressManager : ILevelProgress
    {
        public int CurrentLevel { get; set; } = 1;

        public int CurrentLevelIndex => CurrentLevel - 1;
        public void Increase() => CurrentLevel++;
    }
}