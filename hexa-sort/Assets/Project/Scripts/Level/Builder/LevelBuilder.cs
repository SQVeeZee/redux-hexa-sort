using UnityEngine;
using VContainer;

namespace Project
{
    public class LevelBuilder
    {
        private readonly BoardBuilder _boardBuilder;
        private readonly TilesBuilder _tileBuilder;
        private readonly CellsBuilder _cellsBuilder;

        [Inject]
        private LevelBuilder(
            BoardBuilder boardBuilder,
            TilesBuilder tileBuilder,
            CellsBuilder cellsBuilder)
        {
            _boardBuilder = boardBuilder;
            _tileBuilder = tileBuilder;
            _cellsBuilder = cellsBuilder;
        }

        public void BuildLevel(LevelData levelData)
        {
            var root = CreateLevelRoot();
            var board = _boardBuilder.BuildBoard(root);
            FillBoard(board, levelData.BoardData);
        }

        private static Transform CreateLevelRoot() => new GameObject("Level").transform;

        private void FillBoard(BoardView boardView, BoardData boardData)
        {
            var cellRoot = boardView.CellsRoot;
            var cells = boardData.Cells;
            foreach (var cellData in cells)
            {
                TryCreateCellWithTiles(cellData, cellRoot);
            }
        }

        private void TryCreateCellWithTiles(CellData cellData, Transform cellRoot)
        {
            if (cellData.CellType != CellType.Exist)
            {
                return;
            }

            var cell = _cellsBuilder.BuildCell(cellData, cellRoot);
            var tiles = cellData.TowerData.Tiles;
            if (tiles.Length > 0)
            {
                CreateTiles(tiles, cell.TilesRoot);
            }
        }

        private void CreateTiles(TileData[] tiles, Transform root)
        {
            foreach (var data in tiles)
            {
                for (var i = 0; i < data.Height; i++)
                {
                    _tileBuilder.BuildTile(data.TileType, root);
                }
            }
        }
    }
}