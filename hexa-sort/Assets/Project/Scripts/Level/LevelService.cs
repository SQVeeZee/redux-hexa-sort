using Project.Progress;
using VContainer;

namespace Project
{
    public class LevelService
    {
        private readonly ProgressManager _progressManager;
        private readonly LevelBuilder _levelBuilder;
        private readonly LevelsConfig _levelsConfig;

        [Inject]
        private LevelService(
            ProgressManager progressManager,
            LevelBuilder levelBuilder,
            LevelsConfig levelsConfig)
        {
            _progressManager = progressManager;
            _levelBuilder = levelBuilder;
            _levelsConfig = levelsConfig;
        }

        public void CreateLevel()
        {
            var levelData = GetCurrentLevelData();
            _levelBuilder.BuildLevel(levelData);
        }

        private LevelData GetCurrentLevelData()
        {
            var levelName = GetCurrentLevelName();
            return LevelLoader.LoadLevel(levelName);
        }

        private string GetCurrentLevelName()
        {
            var levelIndex = _progressManager.CurrentLevelIndex;
            return _levelsConfig.GetLevelNameByIndex(levelIndex);
        }
    }
}