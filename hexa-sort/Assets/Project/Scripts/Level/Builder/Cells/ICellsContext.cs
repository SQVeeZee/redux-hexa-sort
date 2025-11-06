using System.Collections.Generic;

namespace Project
{
    public interface ICellsContext
    {
        List<CellView> Cells { get; }
        void AddCell(CellView cellView);
        void RemoveCell(CellView cellView);
    }
}