using JetBrains.Annotations;
using UnityEngine;

namespace Project.Editor
{
    public class LevelEditorCreation : MonoBehaviour
    {
        [SerializeField]
        private EditorCellView[] _cellViews;
        [SerializeField]
        private Transform _tilesRoot;
        [SerializeField]
        private string _levelName;

        [ContextMenu("Generate level"), UsedImplicitly]
        private void GenerateLevelContextMenu() => GenerateAndCacheLevel();

        [ContextMenu("Get all tiles"), UsedImplicitly]
        private void CacheTilesContextMenu()
        {
            if (_tilesRoot != null)
            {
                _cellViews = _tilesRoot.GetComponentsInChildren<EditorCellView>();
            }
        }

        private void GenerateAndCacheLevel()
        {
            var levelData = GetLevelData(_cellViews);
            EditorSerialization.SaveLevel(_levelName, levelData);
        }

        private static LevelData GetLevelData(EditorCellView[] editorCells)
        {
            var boardData = GetBoardData(editorCells);
            return new LevelData(boardData);
        }

        private static BoardData GetBoardData(EditorCellView[] editorCells)
        {
            var cells = GetCells(editorCells);
            return new BoardData(cells);
        }

        private static CellData[] GetCells(EditorCellView[] editorCells)
        {
            var cells = new CellData[editorCells.Length];
            for (var i = 0; i < cells.Length; i++)
            {
                var editorCell = editorCells[i];
                var cellData = ConvertEditorCellViewToCellData(editorCell);
                cells[i] = cellData;
            }
            return cells;
        }

        private static CellData ConvertEditorCellViewToCellData(EditorCellView editorCell)
        {
            var towerData = GetTowerData(editorCell.Pattern.Patterns);
            var position = GetPositionData(editorCell);
            return new CellData(editorCell.TileType, towerData, position);
        }

        private static TowerData GetTowerData(TowerPattern[] patterns)
        {
            var tiles = new TileData[patterns.Length];
            for (var i = 0; i < patterns.Length; i++)
            {
                var tile = new TileData(patterns[i].TileType, patterns[i].Height);
                tiles[i] = tile;
            }
            return new TowerData(tiles);
        }

        private static PositionData GetPositionData(EditorCellView editorCell)
        {
            var x = RoundPosition(editorCell.Position.x);
            var y = RoundPosition(editorCell.Position.z);
            return new PositionData(x, y);
        }

        private static float RoundPosition(float position) => Mathf.Round(position * 10f) / 10f;
    }
}