using UnityEngine;

namespace Project
{
    [CreateAssetMenu(menuName = "Configs/Board/Cells asset config", fileName = "cells_asset_config", order = 0)]
    public class CellsAssetConfig : ScriptableObject
    {
        [SerializeField]
        private CellView _cellView;

        public CellView CellView => _cellView;
    }
}