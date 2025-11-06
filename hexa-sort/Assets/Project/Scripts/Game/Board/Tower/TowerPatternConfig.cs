using UnityEngine;

namespace Project
{
    [CreateAssetMenu(menuName = "Configs/Game/Tower/Pattern", fileName = "tower_pattern", order = 0)]
    public class TowerPatternConfig : ScriptableObject
    {
        [SerializeField]
        private TowerPattern[] _towerPattern;

        public TowerPattern[] Patterns => _towerPattern;
    }
}