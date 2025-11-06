namespace Project.Progress
{
    public interface ILevelProgress
    {
        int CurrentLevel { get; set; }
        int CurrentLevelIndex { get; }
        void Increase();
    }
}