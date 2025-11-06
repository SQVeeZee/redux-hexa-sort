using UnityEngine;

namespace Project.Editor
{
    public class EditorCellView : MonoBehaviour
    {
        [SerializeField]
        private CellType _cellType = CellType.None;
        [SerializeField]
        private TowerPatternConfig _pattern;

        public Vector3 Position => transform.position;
        public CellType TileType => _cellType;
        public TowerPatternConfig Pattern => _pattern;
    }
}