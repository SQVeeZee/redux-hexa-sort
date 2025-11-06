using UnityEngine;

namespace Project
{
    [CreateAssetMenu(menuName = "Configs/Levels/Levels config", fileName = "levels_config", order = 0)]
    public class LevelsConfig : ScriptableObject
    {
        [SerializeField]
        private string[] _levels;

        public string GetLevelNameByIndex(int index) => _levels[index];
    }
}