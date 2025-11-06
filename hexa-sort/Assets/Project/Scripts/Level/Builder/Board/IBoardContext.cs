namespace Project
{
    public interface IBoardContext
    {
        BoardView BoardView { get; }

        void Bind(BoardView boardView);
        void UnBind();
    }
}