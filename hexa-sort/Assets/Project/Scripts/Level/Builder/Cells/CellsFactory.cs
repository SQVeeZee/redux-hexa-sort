using Project.Extension;
using UnityEngine;
using VContainer;

namespace Project
{
    public class CellsFactory : MonoFactory<CellView>
    {
        private readonly CellsAssetConfig _cellsConfig;

        [Inject]
        private CellsFactory(CellsAssetConfig cellsConfig) => _cellsConfig = cellsConfig;

        public CellView CreateBoard(Transform root) => Create(_cellsConfig.CellView, root);
    }
}