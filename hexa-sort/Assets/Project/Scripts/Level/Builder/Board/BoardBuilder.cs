using UnityEngine;
using VContainer;

namespace Project
{
    public class BoardBuilder
    {
        private readonly BoardFactory _boardFactory;
        private readonly IBoardContext _boardContext;

        [Inject]
        private BoardBuilder(
            BoardFactory boardFactory,
            IBoardContext boardContext)
        {
            _boardFactory = boardFactory;
            _boardContext = boardContext;
        }

        public BoardView BuildBoard(Transform root)
        {
            var boardView = _boardFactory.CreateBoard(root);
            _boardContext.Bind(boardView);
            return boardView;
        }
    }
}