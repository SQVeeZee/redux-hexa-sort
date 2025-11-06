using System.Collections.Generic;
using JetBrains.Annotations;

namespace Project
{
    [UsedImplicitly]
    public class LevelContext : IBoardContext, ICellsContext, ITilesContext
    {
        public BoardView BoardView { get; private set; }
        public List<CellView> Cells { get; } = new();
        public List<TileView> Tiles { get; } = new();

        void IBoardContext.Bind(BoardView boardView) => BoardView = boardView;
        void IBoardContext.UnBind() => BoardView = null;

        void ICellsContext.AddCell(CellView cellView) => Cells.Add(cellView);
        void ICellsContext.RemoveCell(CellView cellView) => Cells.Remove(cellView);

        void ITilesContext.AddTile(TileView tileView) => Tiles.Add(tileView);
        void ITilesContext.RemoveTile(TileView tileView) => Tiles.Remove(tileView);
    }
}