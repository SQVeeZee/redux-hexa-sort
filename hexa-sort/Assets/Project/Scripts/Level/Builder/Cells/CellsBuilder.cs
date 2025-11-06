using UnityEngine;
using VContainer;

namespace Project
{
    public class CellsBuilder
    {
        private readonly CellsFactory _factory;
        private readonly ICellsContext _context;

        [Inject]
        private CellsBuilder(
            CellsFactory cellsFactory,
            ICellsContext cellsContext)
        {
            _factory = cellsFactory;
            _context = cellsContext;
        }

        public CellView BuildCell(CellData cellData, Transform root)
        {
            var cellView = _factory.CreateBoard(root);
            var position = new Vector3(cellData.Position.X, 0, cellData.Position.Z);
            cellView.ApplyPosition(position);
            _context.AddCell(cellView);
            return cellView;
        }
    }
}