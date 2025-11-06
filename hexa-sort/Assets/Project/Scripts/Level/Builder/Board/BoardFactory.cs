using Project.Extension;
using UnityEngine;
using VContainer;

namespace Project
{
    public class BoardFactory : MonoFactory<BoardView>
    {
        private readonly BoardAssetConfig _boardAssetConfig;

        [Inject]
        private BoardFactory(BoardAssetConfig boardAssetConfig) => _boardAssetConfig = boardAssetConfig;

        public BoardView CreateBoard(Transform root) => Create(_boardAssetConfig.BoardView, root);
    }
}