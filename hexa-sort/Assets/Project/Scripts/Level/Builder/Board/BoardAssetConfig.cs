using UnityEngine;

namespace Project
{
    [CreateAssetMenu(menuName = "Configs/Board/Board asset config", fileName = "board_asset_config", order = 0)]
    public class BoardAssetConfig : ScriptableObject
    {
        [SerializeField]
        private BoardView _boardView;

        public BoardView BoardView => _boardView;
    }
}